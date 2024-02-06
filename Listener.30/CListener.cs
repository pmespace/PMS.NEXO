//#define ARRAYASLIST
#define REGEXPATHS
#define S920

using System.Net.Sockets;
using System.Reflection;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON;
using NEXO.Client;
using NEXO;
using System.Threading;
using System.IO;
using System.Net.WebSockets;
using System.Net.NetworkInformation;
using System.Resources;
using Listener.Properties;
using Listener.Shared;
using System.Text.RegularExpressions;

namespace Listener
{
	/// <summary>
	/// Listens incoming requests to generate CB2A messages
	/// Once a request is received the listener creates a thread to process it while keeping waiting for incoming requests AND responses from the launched threads
	/// </summary>
	public class CListener
	{
		#region constructor
		public CListener() { }
		#endregion

		#region delegates
		public enum ListenerStatus
		{
			// main status
			Starting,
			Started,
			NotStarted,
			Stopping,
			Stopped,
			// WS server status
			ConnectingToWSServer,
			ConnectedToWSServer,
			ConnectionToWSServerPending,
			DisconnectingFromWSServer,
			DisconnectedFromWSServer,
			LoginToWSServer,
			LoginToWSServerDenied,
			LoggedToWSServer,
		}
		public delegate void SetStatusDelegate(ListenerStatus sts, string msg = default);
		#endregion

		#region static
		public const string DEFAULT_SETTINGS_FILE_NAME = "listener.settings.json";
		public const uint DEFAULT_PORT = CSettingsServer.DEFAULT_PORT;

		public const string VALUE_ID = "@ID@";
		public const string VALUE_POIID = "@SPOIID@";
		public const string VALUE_SALEID = "@SSALEID@";
		public const string VALUE_DEVICEID = "@SDEVICEID@";
		public const string VALUE_SERVICEID = "@SERVICEID@";
		#endregion

		#region private properties
		/// <summary>
		/// Describes a nexo path and its associated value(s)
		/// </summary>
		class DataToExchange
		{
			public string Path;
#if REGEXPATHS
			public CListenerPath LPath { get => _lpath; set => _lpath = value ?? new CListenerPath(); }
			CListenerPath _lpath = new CListenerPath();
			public CListenerDataElement Data;
#else
			public List<string> LPath;
			public CListenerDataElement Data;
#endif
			public string Message;
		}
		private class DataToExchangeList : List<DataToExchange> { }

		CancellationTokenSource WSClientSource = null;
		CancellationToken WSClientToken;
		ClientWebSocket WS = null;
		CSynchronize Synch = null;
		int SynchStopIndex = 0;
		CSynchronize Waits = null;
		int WaitsStopIndex = 0;

		bool Started = false;
		CListenerSettings Settings;
		CStreamServer StreamServer = null;
		CListenerStats Stats = new CListenerStats();
		readonly object mylock = new object();
		CSynchronize Events = new CSynchronize();
		SetStatusDelegate setStatusFnc = default;

		CThread threadClient = default
#if USEWSINTERFACE
			, threadWS = default
#endif
#if USEHTTPINTERFACE
			, threadHTTP = default
#endif
			;
		#endregion

		#region properties
		public string IP { get => CStream.Localhost(); }
		public uint Port { get => Settings.Server.Port; }
		public string WSMap { get => Settings.Server?.WSServer?.WSMap; }
		public uint WSPort { get => Settings.Server.WSServer.WSPort; }
		CancellationTokenSource MainSource = null;
		public CancellationToken MainToken;
		#endregion

		#region methods
		public override string ToString()
		{
			return Settings.ToString();
		}
		/// <summary>
		/// Reads the listener settings
		/// </summary>
		/// <param name="settingsFileName">File name to use to read the settinigs</param>
		/// <returns>
		/// A <see cref="CListenerSettings"/> object if successful, null otherwise
		/// </returns>
		public static CListenerSettings LoadSettings(string settingsFileName, bool rewrite = true)
		{
			CListenerSettings settings = default;

			Func<bool> CheckSettings = () =>
			{
				if (null == settings.Client) settings.Client = new CSettingsClient();
				if (null == settings.Server) settings.Server = new CSettingsServer();
				if (null == settings.Nexo) settings.Nexo = new CSettingsNexo();
				if (0 == settings.POIs.Count)
				{
					settings.POIs.Add("POI1", new CListenerSettings.CPOI());
				}
				if (0 == settings.Server.AllowedIP.Count)
				{
					settings.Server.AllowedIP.Add(CStream.Localhost());
				}
				return true;
			};

			// load settings
			CJson<CListenerSettings> json = new CJson<CListenerSettings>(settingsFileName);
			CLogger.TRACE($"{Resources.DisplayStarting} {json.FileName}");

			if (null == (settings = json.ReadSettings()))
			{
				CLogger.ERROR($"{Resources.DisplayFailedToReadSettings}");
				settings = new CListenerSettings();
				CheckSettings();
				json.WriteSettings(settings, default, false);
				settings = null;
			}
			else
			{
				// if the listener is to run as a client remove all allowed IPs
				if (settings.RunAsClient)
				{
					settings.Server.AllowedIP.Clear();
				}
				CheckSettings();

				if (rewrite)
					json.WriteSettings(settings);

				settings.Nexo.AllowedServices.Add("Login");
				settings.Nexo.AllowedServices.Add("Logout");
				settings.Nexo.AllowedServices.Add("Payment");
			}
			return settings;
		}
		/// <summary>
		/// Start the listener server on settings as deszcribed in <see cref="Settings"/>
		/// </summary>
		/// <param name="settingsFileName">Settings file name</param>
		/// <returns>True if started, false otherwise</returns>
		public bool Start(string settingsFileName, SetStatusDelegate deleg = default)
		{
			if (!Started)
			{
				// save status update function
				setStatusFnc = deleg;
				setStatusFnc?.Invoke(ListenerStatus.Starting);

				// read settings
				if (null == (Settings = LoadSettings(settingsFileName)))
				{
					return false;
				}
				CLog.SeverityToLog = Settings._severity;
				CLog.NumberOfFilesToKeep = Settings.NumberOfFilesToKeep;
				CLogger.Display($"{Resources.DisplayLogFile}: {CLog.LogFilename}");
				CLogger.TRACE(Settings.ToString());

				// start server
				StreamServer = new CStreamServer();
				IPAddress[] addresses = CStream.Localhosts();
				int i = 0;
				foreach (IPAddress addr in addresses)
				{
					i++;
					CLogger.TRACE($"{Resources.DisplayAddress} {i.ToString("00")} = {addr} ({(IPAddress.IsLoopback(addr) ? "loopback" : "internet")})");
				}

				// reset server stats
				Stats.counterSinceLastStart = 0;

				bool ok = false;
				// actually start the server
				CStreamServerStartSettings start = new CStreamServerStartSettings()
				{
					StreamServerSettings = new CStreamServerSettings()
					{
						Port = Settings.Server.Port,
						// indicate the process wants to alter messages logging
						OnMessageToLog = OnMessageToLog,
					},
					ThreadData = null,
					OnConnect = OnConnect,
					OnDisconnect = OnDisconnect,
					OnMessage = OnMessage,
					OnStart = OnStart,
					OnStop = OnStop,
					Parameters = Settings,
				};
				ok = StreamServer.StartServer(start);

				// is running as server or client
				if (ok && Settings.RunAsClient)
				{
					threadClient = new CThread()
					{
						Name = "listener.WS.client",
					};
					Synch = new CSynchronize();
					Synch.Add(new ManualResetEvent(false)); // OK
					Synch.Add(new ManualResetEvent(false)); // KO
					Synch.Add(new ManualResetEvent(false)); // end
					Synch.Add(new ManualResetEvent(false)); // STOP
					SynchStopIndex = 3;

					if (!threadClient.Start(WSClientModeThreadFunction,
							new CThreadData()
							{
								OnTerminates = WSClientModeThreadTerminates,
							},
							new ThreadData()
							{
								Retries = Settings.Client.RetryConnectCounter,
								Delay = Settings.Client.DelayBetwenRetries,
							}))
					{
						CLogger.TRACE($"{Resources.DisplayFailedToConnectToEListener}");
						ok = false;
						Stop();

					}
				}
				else if (ok)
				{
					// no client mode
					setStatusFnc?.Invoke(ListenerStatus.Started);
				}
				if (!ok)
				{
					// current status
					setStatusFnc?.Invoke(ListenerStatus.NotStarted);
				}

				// start alternate server communication entry, only if everything's fine so far
				if (ok && null != Settings.Server.WSServer)
				{
#if USEWSINTERFACE
					threadWS = new CThread();
					threadWS.Name = "listener.WS.interface";
					Waits = new CSynchronize();
					Waits.Add(new ManualResetEvent(false));
					Waits.Add(new ManualResetEvent(false));
					Waits.Add(new ManualResetEvent(false));
					WaitsStopIndex = 2;
					if (!threadWS.Start(WSInterfaceThreadFunction,
						new CThreadData()
						{
							OnTerminates = WSInterfaceThreadTerminates,
						}
						))
					{
						CLogger.TRACE($"{Resources.DisplayFailedToStartWSInterface}");
						ok = false;
						Stop();
					}
#endif
				}

				Started = ok;
				if (Started)
				{
					MainSource = new CancellationTokenSource();
					MainToken = MainSource.Token;
				}
			}
			return Started;
		}
		/// <summary>
		/// Stop the listener
		/// </summary>
		public void Stop()
		{
			setStatusFnc?.Invoke(ListenerStatus.Stopping);
			try
			{
				// stop any connection attempt to the WS server
				Synch?[SynchStopIndex].Set();

				// stop WS interface
				Waits?[WaitsStopIndex].Set();

				// disconnect from WS server
				WSClientSource?.Cancel();

				// stop listener server
				StreamServer?.StopServer();
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			Started = false;
			setStatusFnc?.Invoke(ListenerStatus.Stopped);
			// indicate the process is stopping
			MainSource.Cancel();
		}
		/// <summary>
		/// Get the MAC address
		/// </summary>
		/// <param name="mostUsed">If true search for the available MAC address mostly used, otherwise look for the first or default one</param>
		/// <returns>A string representing the requested MAC address, null if no MAC address is available</returns>
		string GetMACAddress(bool mostUsed = false)
		{
			if (mostUsed)
			{
				Dictionary<string, long> macAddresses = new Dictionary<string, long>();
				foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
				{
					if (nic.OperationalStatus == OperationalStatus.Up)
						macAddresses[nic.GetPhysicalAddress().ToString()] = nic.GetIPStatistics().BytesSent + nic.GetIPStatistics().BytesReceived;
				}
				long maxValue = 0;
				string mac = "";
				foreach (KeyValuePair<string, long> pair in macAddresses)
				{
					if (pair.Value > maxValue)
					{
						mac = pair.Key;
						maxValue = pair.Value;
					}
				}
				return mac;
			}
			var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces()
								where nic.OperationalStatus == OperationalStatus.Up
								select nic.GetPhysicalAddress().ToString()
								).FirstOrDefault();
			return macAddr;
		}

		#region WS client mode
		/// <summary>
		/// Thread starting the client mode trying to connect to the WS server
		/// </summary>
		/// <param name="thread"></param>
		/// <param name="o">a <see cref="ThreadData"/> object</param>
		/// <returns></returns>
		int WSClientModeThreadFunction(CThread thread, object o)
		{
			ThreadData data = (o as ThreadData);
			int attempt = 0;
			CLog.SetSharedGuid();
			int index = 0;
			do
			{
				if (!Synch[SynchStopIndex].WaitOne(0))
				{
					attempt++;
					// create events to manage
					for (int i = 0; i < Synch.Count - 1; i++) Synch[i].Reset(); // last event is not resetted because it marks STOP
					CLogger.INFORMATION(string.Format(Resources.WSClientConnectingToServer, new object[] { Settings.Client.URI, attempt }));

					// the listener needs to connect to a distant server
					WSClientSource = new CancellationTokenSource();
					WSClientToken = WSClientSource.Token;
					WSClientModeStart(Synch);
					index = Synch.WaitAny();

					//if (2 != index)
					if (2 > index)
					{
						if (Started = (0 == index))
						{
							CLogger.TRACE(string.Format(Resources.WSClientIsConnected, new object[] { Settings.Client.URI }));
						}
						else
						{
							CLogger.ERROR(Resources.WSClientFailedToConnect);
						}
					}
					else if (SynchStopIndex == index)
					{
						WSClientSource.Cancel();
						setStatusFnc?.Invoke(ListenerStatus.Stopping);
					}
					else
					{
						setStatusFnc?.Invoke(ListenerStatus.ConnectionToWSServerPending);
						Thread.Sleep((int)data.Delay * 1000);
					}
					Synch[2].WaitOne();
				}
				else
					index = SynchStopIndex;
			}
			while ((0 == data.Retries || attempt < data.Retries) && SynchStopIndex != index);
			Synch[SynchStopIndex].Reset();
			Synch.Clear();
			Synch = null;
			return (int)ThreadResult.OK;
		}
		class ThreadData
		{
			public uint Retries;
			public uint Delay;
		}
		/// <summary>
		/// Called when the listener connection process terminates
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="uniqueId"></param>
		/// <param name="result"></param>
		void WSClientModeThreadTerminates(int id, string name, int uniqueId, int result)
		{
			CLogger.ERROR(Resources.WSClientTerminated);
			Stop();
		}
		/// <summary>
		/// Start the listener in client mode, waiting to receive orders from a remote server through <see cref="WebSocket"/>
		/// </summary>
		async void WSClientModeStart(CSynchronize synch)
		{
			try
			{
				// the listener needs to connect to the server
				WSClientSource = new CancellationTokenSource();
				WSClientToken = WSClientSource.Token;
				WS = new ClientWebSocket();

				// counter of connection attempts
				bool closing = false;
				bool connected = false;
				string order = string.Empty;
				WSClientModeAction action = WSClientModeAction.Connect;
				CStreamClientIO streamIO = null;
				byte[] ab = new byte[Settings.Client.ReceptionBufferSize];
				// connect to the server
				try
				{
					setStatusFnc?.Invoke(ListenerStatus.ConnectingToWSServer);
					await WS.ConnectAsync(new Uri(Settings.Client.URI), WSClientToken);
					setStatusFnc?.Invoke(ListenerStatus.ConnectedToWSServer);
				}
				catch (Exception /*ex*/)
				{
					//CLog.EXCEPT(ex);
					throw new WSClientModeException($"failed to connect to web socket [{Settings.Client.URI}]");
				}
				while (WebSocketState.Open == WS.State)
				{
					connected = true;

					// run requested action
					switch (action)
					{
						case WSClientModeAction.Connect:
							CStreamClientSettings clientSettings = new CStreamClientSettings() { IP = CStream.Localhost(), Port = Settings.Server.Port, ReceiveTimeout = 0 };
							if (null == (streamIO = CStream.Connect(clientSettings)))
								throw new Exception($"failed to connect to listener (as client), disconnecting from WS server");
							setStatusFnc?.Invoke(ListenerStatus.LoginToWSServer);
							action = WSClientModeAction.SendLoginRequest;
							break;

						case WSClientModeAction.SendLoginRequest:
							// send login information
							CListenerClientLoginRequest loginRequest;
							loginRequest = new CListenerClientLoginRequest() { MACAddress = GetMACAddress() };
							loginRequest.SimplePOIs = Settings.POIs.GetSimplePOIs();
							loginRequest._extendedData = Settings.Client.Security._extendedData;
							string s = CJson<CListenerClientLoginRequest>.Serialize(loginRequest);
							if (!s.IsNullOrEmpty())
							{
								CLog.INFORMATION($"sending login request to server [{s}]");
								byte[] abs = Encoding.UTF8.GetBytes(s);
								ArraySegment<byte> ar = new ArraySegment<byte>(abs);
								await WS.SendAsync(ar, WebSocketMessageType.Text, true, WSClientToken);
								action = WSClientModeAction.ReceiveLoginResponse;
								order = string.Empty;
								// message is ready to be processed
								CLog.TRACE("ready to receive incoming requests");
								synch[0].Set();
							}
							else
								throw new WSClientModeException("failed to create security chain, disconnecting from server");
							break;

						case WSClientModeAction.ReceiveLoginResponse:
						case WSClientModeAction.ReceiveRequestOrSettingsUpdate:
							{
								// receive login response
								var result = await WS.ReceiveAsync(new ArraySegment<byte>(ab), WSClientToken);
								closing = (WebSocketMessageType.Close == result.MessageType || (null != result.CloseStatus ? WebSocketCloseStatus.Empty != result.CloseStatus : false) || WSClientToken.IsCancellationRequested);
								if (!closing && 0 != result.Count)
								{
									order += Encoding.UTF8.GetString(ab, 0, result.Count);
									if (result.EndOfMessage)
									{
										// received message is complete, let's process it
										switch (action)
										{
											case WSClientModeAction.ReceiveLoginResponse:
												{
													// convert to a login response
													CListenerClientLoginResponse loginResponse;
													if (null != (loginResponse = CJson<CListenerClientLoginResponse>.Deserialize(order)))
													{
														// connected and a login response has been received, we can reset the attempt counter
														if (loginResponse.Granted)
														{
															CLog.INFORMATION($"connection has been granted [{order}]");
															setStatusFnc?.Invoke(ListenerStatus.LoggedToWSServer);
															action = WSClientModeAction.ReceiveRequestOrSettingsUpdate;
														}
														else
														{
															setStatusFnc?.Invoke(ListenerStatus.LoginToWSServerDenied);
															throw new WSClientModeException($"connection denied, disconnecting from server");
														}
													}
													else
													{
														setStatusFnc?.Invoke(ListenerStatus.DisconnectingFromWSServer);
														throw new WSClientModeException($"invalid login response message received [{order}], disconnecting from server");
													}
												}
												break;

											case WSClientModeAction.ReceiveRequestOrSettingsUpdate:
												{
													CListenerRequestWS listenerRequest = CJson<CListenerRequestWS>.Deserialize(order);
													if (null != listenerRequest)
													{
														CLog.INFORMATION($"received request from server [{order}]");
														listenerRequest.Secured = true;
														string norder = CJson<CListenerRequestWS>.Serialize(listenerRequest);
														if (!norder.IsNullOrEmpty()) order = norder;

														// a request has been received, post it to the listener server part
														if (CStream.Send(streamIO, order))
														{
															CLog.INFORMATION($"request sent to the listener");
														}
														else
														{
															CLog.ERROR($"request failed to be sent to the listener");
														}
													}
													else
													{
														CLog.ERROR($"invalid request received from the server [{order}], still listening");
														CListenerReply reply = new CListenerReply() { RequestAsString = order };
														reply.Status = ReplyStatus.invalidRequest;
														await WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(reply))), WebSocketMessageType.Text, true, WSClientToken);
													}
												}
												break;
										}
										order = string.Empty;
									}
								}
							}
							break;
					}

					// if a cancel event has been received...
					if (WSClientToken.IsCancellationRequested)
					{
						CLog.TRACE("received a cancellation event, disconnecting");
					}
				}
				CLog.TRACE($"disconnecting from server {Settings.Client.URI}");
				await WS.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
				setStatusFnc?.Invoke(ListenerStatus.DisconnectedFromWSServer);
				connected = false;
				WSClientSource.Cancel();
			}
			catch (WSClientModeException ex)
			{
				CLog.EXCEPT(ex);
				synch[1].Set();
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			synch[2].Set();
		}
		class CListenerRequestWS : CListenerRequest
		{
			public bool Secured { get => _secured; set => _secured = value; }
			bool _secured = false;
		}
		class WSClientModeException : Exception
		{
			public WSClientModeException(string s) : base(s) { }
		}
		enum WSClientModeAction
		{
			Error,
			Connect,
			SendLoginRequest,
			ReceiveLoginResponse,
			ReceiveRequestOrSettingsUpdate,
			SendAnswer,
			SendNotification,
		}
		#endregion

		#region WS interface
#if USEWSINTERFACE
		/// <summary>
		/// Thread starting the client mode trying to connect to the WS server
		/// </summary>
		/// <param name="thread"></param>
		/// <param name="o">a <see cref="ThreadData"/> object</param>
		/// <returns></returns>
		int WSInterfaceThreadFunction(CThread thread, object o)
		{
			CLog.SetSharedGuid();
			CLogger.INFORMATION(Resources.INFOR_StartingWSInterface);

			// the listener needs to connect to a distant server
			CWSListener.Start(Settings, Waits, false, WSInterfaceOnStop);
			int index = Waits.WaitAny();
			if (Started = (0 == index))
			{
				CLogger.TRACE(Resources.TRACE_WSInterfaceStarted);
			}
			else
			{
				CLogger.ERROR(Resources.ERROR_WSInterfaceNotStarted);
			}
			Waits.WaitAny(new WaitHandle[] { Waits[1], Waits[WaitsStopIndex] });
			CWSListener.Source.Cancel();
			return (int)ThreadResult.OK;
		}
		/// <summary>
		/// Called when the listener connection process terminates
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="uniqueId"></param>
		/// <param name="result"></param>
		void WSInterfaceThreadTerminates(int id, string name, int uniqueId, int result)
		{
			CLog.ERROR(Resources.ERROR_WSClientHasStopped);
			Stop();
		}
		/// <summary>
		/// Function called when the WS interface stops
		/// </summary>
		/// <param name="i"></param>
		void WSInterfaceOnStop(int i)
		{
			//CLogger.TRACE(string.Format(Resources.WSInterfaceStopped, new object[] { i }));
			return;
		}
#endif
		#endregion

		#region HTTP interface
#if USEHTTPINTERFACE
		/// <summary>
		/// Function called when the HTTP interface stops
		/// </summary>
		/// <param name="i"></param>
		void HTTPOnStop(int i)
		{
			return;
		}
#endif
		#endregion

		#region listener processing
		/// <summary>
		/// <see cref="CStreamSettings.OnMessageToLog"/>
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="current"></param>
		/// <param name="isRequest"></param>
		/// <returns></returns>
		internal static string OnMessageToLog(byte[] bytes, string current, bool isRequest)
		{
			// message is logged as is
			return current;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnStart"/>
		/// </summary>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		private static bool OnStart(CThreadData threadData = null, object o = null)
		{
			CListenerSettings settings = (CListenerSettings)o;

			// prepare the list of managed services
			foreach (string svc in settings.Nexo.AllowedServices)
			{
				MessageCategoryEnumeration? cat = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), svc);
				if (null != cat)
					settings.Nexo.AllowedCategories.Add((MessageCategoryEnumeration)cat);
			}
			if (0 == settings.Nexo.AllowedCategories.Count)
			{
				CLogger.ERROR($"listener can't start, no service is supported");
				return false;
			}

			CLogger.TRACE($"starting listener");
			return true;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnStart"/>
		/// </summary>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		private static void OnStop(CThreadData threadData = null, object o = null)
		{
			CLogger.TRACE($"stopping listener");
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnConnect"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="thread"></param>
		/// <param name="parameters"></param>
		/// <param name="privateData"></param>
		/// <returns></returns>
		private static bool OnConnect(TcpClient tcp, CThread thread, object parameters, ref object privateData)
		{
			CListenerSettings settings = (CListenerSettings)parameters;
			try
			{
				if ((settings.RunAsClient && settings.Server.AllowedIP.Contains(((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString()))
					|| (!settings.RunAsClient && settings.Server.UseAllowedIP && settings.Server.AllowedIP.Contains(((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString()))
					|| (!settings.RunAsClient && !settings.Server.UseAllowedIP))
				{
					CLogger.TRACE($"accepting connection from client {tcp.Client.RemoteEndPoint}{(settings.Server.UseAllowedIP ? string.Empty : $" (not verifying calling IP)")}");
					return true;
				}
				else
				{
					CLogger.ERROR($"connection from client {tcp.Client.RemoteEndPoint} has been declined");
				}
			}
			catch (Exception ex)
			{
				CLogger.EXCEPT(ex, $"exception while connecting client {tcp.Client.RemoteEndPoint}, connection declined");
			}
			return false;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnDisconnect"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="thread"></param>
		/// <param name="parameters"></param>
		/// <param name="statistics"></param>
		private static void OnDisconnect(TcpClient tcp, CThread thread, object parameters, CStreamServerStatistics statistics)
		{
			CLogger.TRACE($"[{tcp}] client has been disconnected");
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnMessage"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="request"></param>
		/// <param name="addBufferSize"></param>
		/// <param name="thread"></param>
		/// <param name="parameters"></param>
		/// <param name="privateData"></param>
		/// <param name="reserved"></param>
		/// <returns></returns>
		private byte[] OnMessage(TcpClient tcp, byte[] request, out bool addBufferSize, CThread thread, object parameters, object privateData, object reserved)
		{
			addBufferSize = true;

			string srequest = Encoding.ASCII.GetString(request);
			string sclient = $"[{tcp.Client.RemoteEndPoint}] ";
			CLogger.INFORMATION(sclient + $"request from client [{request.Length} bytes] {srequest}", Settings.DisplayMessages);

			/*
			 * process settings
			 */

			Stats.counterTotal++;
			Stats.counterSinceLastStart++;

			// pre-increment invalid counter
			Stats.counterInvalidMessages++;
			Stats.counterInvalidMessagesSinceLastStart++;

			CListenerRequestWS listenerRequest = CJson<CListenerRequestWS>.Deserialize(srequest);
			CListenerReply listenerReply = new CListenerReply() { Request = listenerRequest, };
			if (null == listenerRequest)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorMessageCantBeConvertedToRequest, srequest)));
				listenerReply.Status = ReplyStatus.invalidRequest;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
			}

			Func<string, object> ContainsKey = (string _kEY_) =>
			{
				try
				{
					if (listenerRequest.ExtendedData.ContainsKey(_kEY_))
						return listenerRequest.ExtendedData[_kEY_];
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				return null;
			};

			object obj;
			string s;
			string specificProtocole = "Protocole";
			string specificIP = "IP";
			string specificPort = "Port";
			string specificConnectTimeout = "ConnectTimeout";
			string specificReceiveTimeout = "ReceiveTimeout";

			// verify the POI actually exists in the configuration
			CListenerSettings.CPOI poi = null;

			#region parameters
			try
			{
				poi = Settings.POIs[listenerRequest.POI];
			}
			catch (Exception ex)
			{
				bool ok = true;
				obj = null;

				CListenerSettings.CPOI spoi = new CListenerSettings.CPOI() { };
				// has an IP been specified
				if (ok = (ok && null != (obj = ContainsKey(specificIP))))
				{
					s = obj.ToString();
					IPAddress addr = null;
					if (ok = (ok && !s.IsNullOrEmpty() && IPAddress.TryParse(s, out addr)))
						spoi.ConnectionSettings.IP = addr.ToString();
				}
				// has a port been specified
				if (ok && null != (obj = ContainsKey(specificPort)))
				{
					s = obj.ToString();
					uint port = 0;
					if (ok = (ok && !s.IsNullOrEmpty() && uint.TryParse(s, out port)))
						spoi.ConnectionSettings.Port = port;
				}

				// arrived here let's see if we can use the specified address or not
				if (ok = ok && spoi.ConnectionSettings.IsValid)
				{
					// has a receive timeout been specified
					if (null != (obj = ContainsKey(specificReceiveTimeout)))
					{
						s = obj.ToString();
						if (!s.IsNullOrEmpty() && int.TryParse(s, out int tm))
							spoi.ConnectionSettings.ReceiveTimeout = tm;
					}
					// has a connect timeout been specified
					if (null != (obj = ContainsKey(specificConnectTimeout)))
					{
						s = obj.ToString();
						if (!s.IsNullOrEmpty() && int.TryParse(s, out int tm))
							spoi.ConnectionSettings.ConnectTimeout = tm;
					}

					spoi.Label = $"dynamic POI ({spoi.ConnectionSettings.IP})";
					poi = spoi;
				}

				// shall we continue or not
				if (!ok)
				{
					CLog.EXCEPT(ex);
					CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorRequestedPOIDoesntExist, listenerRequest.POI)));
					listenerReply.Status = ReplyStatus.invalidPOIRequested;
					return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
				}
			}
			#endregion

			CLogger.TRACE($"Using {(poi.Label.IsNullOrEmpty() ? poi.FullIP : $"{poi.Label} at {poi.FullIP}")}");

			if (listenerReply.Request.SaleID.IsNullOrEmpty())
				listenerReply.Request.SaleID = CStream.Localhost();
			if (listenerReply.Request.POIID.IsNullOrEmpty())
				listenerReply.Request.POIID = poi.FullIP;

			string path = null;
			string tempName = null;
			string fileNameHeader = $"nexolistener.{tcp.Client.RemoteEndPoint}.{listenerReply.Request.SaleID}.{listenerReply.Request.POIID}";

			// log request if requested
			if (Settings.LogExchanges)
			{
				char[] chars = Path.GetInvalidFileNameChars();
				foreach (char c in chars)
					fileNameHeader = fileNameHeader.Replace(c, '.');
				CJson<CListenerRequest> json = new CJson<CListenerRequest>(GetTempFileName(fileNameHeader + ".request", ref path, ref tempName));
				json.WriteSettings(listenerRequest);
			}

			// arrived here the message has been decoded, let's determine what to do

			// retrieve category and create object if ok
			MessageCategoryEnumeration? category = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), listenerRequest.Service);
			if (null == category)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorInvalidRequestedService, listenerRequest.Service)));
				listenerReply.Status = ReplyStatus.invalidService;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
			}

			Func<string> SupportedServices = delegate ()
				{
					int i = 0;
					string _s_ = null;
					foreach (MessageCategoryEnumeration cat in Settings.Nexo.AllowedCategories)
					{
						i++;
						_s_ += cat.ToString() + (Settings.Nexo.AllowedCategories.Count == i ? null : ", ");
					}
					return _s_;
				};

			if (!Settings.Nexo.AllowedCategories.Contains((MessageCategoryEnumeration)category))
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorRequestedServiceNotAllowed, listenerRequest.Service)));
				listenerReply.Status = ReplyStatus.serviceNotSupported;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
			}

			// test parameters
			if (string.IsNullOrEmpty(listenerRequest.SaleID) || string.IsNullOrEmpty(listenerRequest.POIID))
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorInvalidRequestedIDs, new object[] { (listenerRequest.SaleID.IsNullOrEmpty() ? Resources.IsMissing : listenerRequest.SaleID), (listenerRequest.POIID.IsNullOrEmpty() ? Resources.IsMissing : listenerRequest.POIID) })));
				listenerReply.Status = ReplyStatus.mandatoryObjectNotSet;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
			}

			/*
			 * create the nexo retailer object to exchange
			 */

			// arrived here decrement invalid messages counter
			Stats.counterInvalidMessages--;
			Stats.counterInvalidMessagesSinceLastStart--;

			Stats.counterValidMessages++;
			Stats.counterValidMessagesSinceLastStart++;

			Stats.counterProcessedMessages++;
			Stats.counterProcessedMessagesSinceLastStart++;

			NexoObject nexo = NexoItem.AllocateObject((MessageCategoryEnumeration)category);
			if (null == nexo)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ErrorFailedCreatingTheNexoObject, category.ToString())));
				listenerReply.Status = ReplyStatus.unknownError;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)), tcp);
			}
			nexo.SaleID = listenerRequest.SaleID;
			nexo.POIID = listenerRequest.POIID;

			// specific service processing
			if (MessageCategoryEnumeration.Payment == category)
			{
				PaymentTypeEnumeration? pt = (PaymentTypeEnumeration)CMisc.GetEnumValue(typeof(PaymentTypeEnumeration), listenerRequest.PaymentType);
				if (null != pt)
					((NexoPayment)nexo).PaymentType = (PaymentTypeEnumeration)pt;
				((NexoPayment)nexo).RequestRequestedAmount = listenerRequest.Amount;
				((NexoPayment)nexo).RequestCurrency = listenerRequest.Currency;
			}
			else if (MessageCategoryEnumeration.Reversal == category)
			{
				((NexoReversal)nexo).RequestOriginalPOITransactionID = listenerRequest.POITransaction?.TransactionID;
				((NexoReversal)nexo).RequestOriginalPOITransactionTimestamp = listenerRequest.POITransaction?.TimeStamp;
				((NexoReversal)nexo).RequestReversalReason = ReversalReasonEnumeration.MerchantCancel;
			}

			/*
			 * set specific data
			 */

			// search and set data to send
			DataToExchangeList tosend = new DataToExchangeList();
			foreach (KeyValuePair<string, CListenerDataElement> k in listenerRequest.ElementsToSend)
			{
				// create the data to analyse the current requested value to set
				DataToExchange dte = new DataToExchange()
				{
					Path = k.Key,
					LPath = PathToData(k.Key, false),
					Data = new CListenerDataElement() { Value = k.Value.Value, Status = false },
				};
				// try settings this data within the nexo message
				if (!dte.Path.IsNullOrEmpty() && 0 != dte.LPath.Count)
				{
					CListenerDataElement ldt = dte.Data;
					if (!(ldt.Status = SearchAndProcessProperty(nexo.Request, dte.LPath, ref ldt.Value)))
						CLogger.ERROR(dte.Message = sclient + string.Format(Resources.InputDataFailedToSetData, new object[] { dte.Path, ldt.Value }));
				}
				else
					CLogger.ERROR(dte.Message = sclient + string.Format(Resources.InputDataFailedCreatingPath, new object[] { k.Key }));
				tosend.Add(dte);
			}

			/*
			 * process the nexo retailer message
			 */

			// if concurrency access is activated check whether an access to the requested resource is already active
			NexoRetailerClient client = new NexoRetailerClient(listenerRequest.SaleID, listenerRequest.POIID);
			string resourceName = $"{poi.FullIP}.mutex";
			{
				bool created = false;
				Mutex mutex = null;
				try
				{
					string action = "ListenerAsynchronousMessage";
					ReplyStatus sts = ReplyStatus.unknownError;

					// build resource to access name
					mutex = new Mutex(true, resourceName, out created);
					if (!created)
					{
						sts = ReplyStatus.waitingToGainAccessToPOI;
						StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = sts,
								Message = Resources.POIIsAlreadyInUse,
							})), tcp),
							addBufferSize, action, reserved);
						mutex.WaitOne();
						sts = ReplyStatus.accessToPOIHasBeenGranted;
						StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = sts,
								Message = Resources.POIAccessHasBeenGranted,
							})), tcp),
							addBufferSize, action, reserved);
					}

					CStreamClientSettings scs = new CStreamClientSettings() { IP = poi.ConnectionSettings.IP, Port = (uint)poi.ConnectionSettings.Port, ReceiveTimeout = listenerRequest.ReceiveTimeout };
					NexoRetailerClientSettings clientSettings = new NexoRetailerClientSettings() { StreamClientSettings = scs, OnReceivedReply = OnReceivedReply, OnReceivedRequest = OnReceivedRequest, OnReceivedNotification = OnReceivedNotification, OnReceivedIgnoredMessage = OnReceivedIgnoredMessage, Reserved = reserved };

					if (client.Connect(clientSettings))
					{
						bool ok = true;

						// auto login ?
						if (Settings.Nexo.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLogger.TRACE(sclient + Resources.ProcessingPerformingAutoLogin);
							NexoLogin login = new NexoLogin() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.login;
							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Message = string.Format(Resources.LoginTryingToLogWith, new object[] { listenerRequest.SaleID, listenerRequest.POIID }),
								})), tcp),
								addBufferSize, action, reserved);
							if (ok = client.SendRequestSync(login, poi.ConnectionSettings.GeneralTimer))
							{
								CLog.TRACE(sclient + (listenerReply.Message = Resources.ProcessingConnectedToPOI));
								StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
									new CListenerReply()
									{
										Notification = true,
										Status = sts,
										Message = Resources.LoginSucceeded,
									})), tcp),
									addBufferSize, action, reserved);
							}
							else
							{
								CLogger.ERROR(sclient + (listenerReply.Message = Resources.ProcessingErrorWhileLogin));
								StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
									new CListenerReply()
									{
										Notification = true,
										Status = sts,
										Message = string.Format(Resources.LoginFailedToLogTo, new object[] { listenerRequest.SaleID, listenerRequest.POIID }),
									})), tcp),
									addBufferSize, action, reserved);
							}
						}

						if (ok)
						{
							string serviceName = nexo.MessageCategory.ToString();
							ReplyStatus sts2 = ReplyStatus.unknownError;
							switch (nexo.MessageCategory)
							{
								case MessageCategoryEnumeration.Login:
									sts = sts2 = ReplyStatus.login;
									break;

								case MessageCategoryEnumeration.Logout:
									sts = sts2 = ReplyStatus.logout;
									break;

								case MessageCategoryEnumeration.Payment:
									if (((NexoPayment)nexo).IsNormalPayment)
									{
										sts = ReplyStatus.beginPayment;
										sts2 = ReplyStatus.endPayment;
										serviceName = "Normal Payment";
									}
									else if (((NexoPayment)nexo).IsRefund)
									{
										sts = ReplyStatus.beginRefund;
										sts2 = ReplyStatus.endRefund;
										serviceName = "Refund";
									}
									else
									{
										sts = ReplyStatus.beginOtherPayment;
										sts = ReplyStatus.endOtherPayment;
										serviceName = "Other Payment";
									}
									break;

								case MessageCategoryEnumeration.Reversal:
									sts = ReplyStatus.beginReversal;
									sts2 = ReplyStatus.endReversal;
									break;

								case MessageCategoryEnumeration.Reconciliation:
									sts = ReplyStatus.beginReconciliation;
									sts2 = ReplyStatus.endReconciliation;
									break;

								case MessageCategoryEnumeration.Abort:
									sts = ReplyStatus.beginAbort;
									sts2 = ReplyStatus.endAbort;
									break;

								default:
									sts = ReplyStatus.beginOtherService;
									sts2 = ReplyStatus.endOtherService;
									break;
							}
							serviceName = serviceName.ToUpper();
							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Message = string.Format(Resources.ServiceStarting, new object[] { serviceName }),
								})), tcp),
								addBufferSize, action, reserved);

							// send the request synchronously
							listenerRequest.NexoMessage = nexo.ToString();
							try
							{
								if (!client.SendRequestSync(nexo))
									CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingErrorWhileExchange, serviceName)));
							}
							catch (Exception ex)
							{
								CLog.EXCEPT(ex);
							}
							//listenerReply.NexoMessage = nexo.ToString();

							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts2,
									Message = string.Format(Resources.ServiceCompleted, new object[] { serviceName }),
								})), tcp),
								addBufferSize, action, reserved);
						}

						// auto logout ?
						if (ok && Settings.Nexo.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLog.TRACE(sclient + Resources.ProcessingPerformingAutoLogout);
							NexoLogout logout = new NexoLogout() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.logout;
							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Message = string.Format(Resources.Logout, new object[] { listenerRequest.SaleID, listenerRequest.POIID }),
								})), tcp),
								addBufferSize, action, reserved);
						}
						client.Disconnect();
					}
					else
					{
						CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingErrorConnectingToPOI, clientSettings.StreamClientSettings.IP)));
						listenerReply.Status = ReplyStatus.failedToConnectToPOI;
					}
				}
				catch (Exception ex)
				{
					CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingException, ex.Message)));
					listenerReply.Status = ReplyStatus.unknownError;
				}
				finally
				{
					if (null != mutex)
					{
						mutex.ReleaseMutex();
						mutex.Close();
					}
				}
			}

			/*
			 * check result
			 */

			bool nexoProcessed = false;

			if (client.TimedOut)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingTimeout, nexo.MessageCategory.ToString())));
				listenerReply.Status = ReplyStatus.timeout;
			}
			else if (client.Cancelled)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingCancelled, nexo.MessageCategory.ToString())));
				listenerReply.Status = ReplyStatus.cancelled;
			}
			else if (client.NoMoreAction)
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format(Resources.ProcessingNoMoreAction, nexo.MessageCategory.ToString())));
				listenerReply.Message += client.Outcome.IsNullOrEmpty() ? $" [{client.Outcome}]" : string.Empty;
				listenerReply.Status = ReplyStatus.noMoreAction;
			}
			else if (client.Received)
			{
				nexoProcessed = true;
				listenerReply.Status = (nexo.Success ? ReplyStatus.Success : nexo.Failure ? ReplyStatus.Failure : nexo.Partial ? ReplyStatus.Partial : ReplyStatus.unknownError);

				// specific message processing
				if (MessageCategoryEnumeration.Payment == category)
				{
					listenerReply.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoPayment)nexo).ReplyPOITransactionID, TimeStamp = ((NexoPayment)nexo).ReplyPOITransactionTimestamp };
					// save specific normal payment data
					if (PaymentTypeEnumeration.Normal == (nexo as NexoPayment).PaymentType)
					{
						listenerReply.PaymentData = new CPaymentData()
						{
							CardBrand = GetSchemeFromAvailableData(((NexoPayment)nexo)),
							Receipts = GetReceipts(((NexoPayment)nexo)),
						};
					}
				}
				else if (MessageCategoryEnumeration.Reversal == category)
				{
					listenerReply.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoReversal)nexo).ReplyPOITransactionID, TimeStamp = ((NexoReversal)nexo).ReplyPOITimestamp };
				}

				switch (listenerReply.Status)
				{
					case ReplyStatus.Success:
						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
							listenerReply.Amount = ((NexoPayment)nexo).ReplyAuthorizedAmount;
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.Partial:
						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
							listenerReply.Amount = ((NexoPayment)nexo).ReplyAuthorizedAmount;
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.Failure:
						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					default:
						break;
				}
				CLogger.TRACE(sclient + (listenerReply.Message = string.Format(Resources.ProcessingResult, new object[] { nexo.MessageCategory.ToString(), listenerReply.Status.ToString().ToUpper(), (nexo.AdditionalResponse.IsNullOrEmpty() ? string.Empty : nexo.AdditionalResponse) })));
				listenerReply.NexoError = nexo.ErrorCondition.ToString();
				listenerReply.NexoInformation = nexo.AdditionalResponse;
			}
			else if (listenerReply.Message.IsNullOrEmpty())
			{
				CLogger.ERROR(sclient + (listenerReply.Message = string.Format($"{Resources.ProcessingUnknowError} [{client.Outcome}]", nexo.MessageCategory.ToString())));
				listenerReply.Status = ReplyStatus.unknownError;
			}
			/*
			 * retrieve specific data
			 */

			DataToExchangeList toreturn = new DataToExchangeList();
			foreach (KeyValuePair<string, CListenerDataElement> k in listenerRequest.ElementsToReturn)
			{
				DataToExchange dte = new DataToExchange()
				{
					Path = k.Key,
					LPath = PathToData(k.Key, true),
					Data = new CListenerDataElement(), //{ new Value = null, Status = false } 
				};
				if (!dte.Path.IsNullOrEmpty() && 0 != dte.LPath.Count && nexoProcessed)
				{
					CListenerDataElement ldt = new CListenerDataElement();
					if (!(ldt.Status = SearchAndProcessProperty(nexo.Reply, dte.LPath, ref ldt.Value, false)))
						CLog.ERROR(dte.Message = sclient + Resources.OutputDataFailedFetchingData);
				}
				else
					CLog.ERROR(dte.Message = sclient + string.Format(Resources.OutputDataFailedCreatingPath, new object[] { k.Key }));
				toreturn.Add(dte);
			}

			/*
			 * create the listenerReply
			 */
			listenerReply.Request.ElementsToSend.Clear();
			foreach (DataToExchange dte in tosend)
				listenerReply.Request.ElementsToSend.Add(dte.Path, dte.Data);
			listenerReply.Request.ElementsToReturn.Clear();
			foreach (DataToExchange dte in toreturn)
			{
				if (!dte.LPath.IsEmpty)
					listenerReply.Request.ElementsToReturn.Add(dte.Path, dte.Data);
			}
			listenerReply.Label = listenerReply.Status.ToString();

			// log reply if requested
			if (Settings.LogExchanges)
			{
				CJson<CListenerReply> json = new CJson<CListenerReply>(GetTempFileName(fileNameHeader + ".reply", ref path, ref tempName));
				json.WriteSettings(listenerReply);
			}

			string sreply = CJson<CListenerReply>.Serialize(listenerReply);
			byte[] breply = Encoding.UTF8.GetBytes(sreply);
			CLogger.INFORMATION(sclient + $"reply to client [{breply.Length} bytes] {sreply}", Settings.DisplayMessages);

			return SendAnswer(breply, tcp);
		}
		/// <summary>
		/// Send back an answer according to the way the request has arrived (from a client or from a server)
		/// </summary>
		/// <param name="reply"></param>
		/// <param name="threadName"></param>
		/// <returns></returns>
		byte[] SendAnswer(byte[] reply, TcpClient tcp)
		{
			if (Settings.RunAsClient)
			{
				try
				{
					CLogger.INFORMATION(string.Format(Resources.ProcessingSendingAnswerToServer, new object[] { Encoding.UTF8.GetString(reply) }));
					WS.SendAsync(new ArraySegment<byte>(reply), WebSocketMessageType.Text, true, WSClientToken);
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				return null;
			}
			return reply;
		}

		/// <summary>
		/// Creates a temporary file name
		/// </summary>
		/// <param name="fixedPart">The fixed part of the file name to create, added at the beginning of the file name</param>
		/// <param name="path">[REF] the path where the file is created</param>
		/// <param name="tempName">[REF] the unique extension added at the end of the file name</param>
		/// <returns>
		/// A complete temporary file name
		/// </returns>
		private static string GetTempFileName(string fixedPart, ref string path, ref string tempName)
		{
			if (string.IsNullOrEmpty(tempName))
			{
				string fullname = Path.GetTempFileName();
				tempName = Path.GetFileName(fullname);
				path = Path.GetDirectoryName(fullname);
			}
			return $"{path}{Path.DirectorySeparatorChar}{fixedPart}-{tempName}.json";
		}
		#endregion

		//internal bool SendRequestSync(CListenerRequest request, EServerType origin, ref string error)
		//{
		//	try
		//	{
		//		CStreamClientSettings clientSettings = new CStreamClientSettings()
		//		{
		//			IP = CStream.Localhost(),
		//			Port = Settings.Server.Port,
		//			ReceiveTimeout = request.ReceiveTimeout,
		//		};
		//		CStreamClientIO streamIO = CStream.Connect(clientSettings);
		//		if (null != streamIO)
		//		{
		//			if (CStream.Send(streamIO, CJson<CListenerRequest>.Serialize(request)))
		//			{
		//				string sreply;
		//				CLogger.TRACE($"{request} (sent message, timeout is {clientSettings.ReceiveTimeout} seconds)");
		//				while (!string.IsNullOrEmpty(sreply = CStream.ReceiveAsString(streamIO)))
		//				{
		//					var reply = CJson<CListenerReply>.Deserialize(sreply);
		//					CLogger.TRACE($"{reply.Message} (received message)");
		//					if (!reply.Notification)
		//					{
		//						CLogger.TRACE($"{reply}");
		//						break;
		//					}
		//				}
		//			}
		//			else
		//			{
		//				CLogger.ERROR($"Failed to send the request");
		//			}
		//		}
		//		else
		//		{
		//			error = Resources.WSInterfaceFailedToConnectToListener;
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		CLog.EXCEPT(ex);
		//		return false;
		//	}
		//}

		#region parameters management
#if REGEXPATHS
		/// <summary>
		/// Converts a "aaa[(N)].bbb.ccc[(N)]" string to a list of <see cref=" CListenerData"/> objects
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static CListenerPath PathToData(string value, bool set)
		{
			value.Trim();
			CListenerPath paths = new CListenerPath();
			// names of the groups to locate that will indicate which part is included
			string selement = "element", sname = "name", sarray = "array", sindex = "index", sseparator = "separator";
			// the regex pattern to use
			// (?<element>(?<name>[A-Z-a-z0-9]+)(?<array>(\({1}(?<index>[0-9]+)\){1})?))(?<separator>\.?)
			string pattern = $"(?<{selement}>(?<{sname}>[A-Z-a-z0-9]+)(?<{sarray}>(\\({1}(?<{sindex}>[0-9]{(set ? "+" : "*")})\\){1})?))(?<{sseparator}>\\.?)";
			Regex regex = new Regex(pattern);

			MatchCollection mc = Regex.Matches(value, pattern);
			foreach (Match match in mc)
			{
				CListenerData o = match.Groups[sname].Value.IsNullOrEmpty() ? null : new CListenerData() { Name = match.Groups[sname].Value };
				if (null != o && o.IsValid)
				{
					o.Element = match.Groups[selement].Value;
					if (!match.Groups[sarray].Value.IsNullOrEmpty())
						int.TryParse(match.Groups[sindex].Value, out o.Index);
					paths.Add(o);
				}
			}
			if (!value.Compare(paths.ToString()))
				paths.Clear();
			return paths;
		}
#else
		/// <summary>
		/// Converts a "aaa.bbb.ccc(n)" string to a list of strings [0]=aaa, [1]=bbb,...
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static List<string> PathToData(string value)
		{
			List<string> l = new List<string>();
			string s = value;
			while (!string.IsNullOrEmpty(s))
			{
				int len = s.IndexOf(".");
				if (-1 == len) len = s.Length;

				string p = s.Substring(0, len);
				if (!string.IsNullOrEmpty(p))
				{
					l.Add(p);
					try
					{
						s = s.Substring(len + 1);
					}
					catch (Exception)
					{
						s = null;
					}
				}
			}
			if (0 == l.Count) return null;
			return l;
		}
#endif

		/// <summary>
		/// Search a type for a specific property to set or retrieve
		/// </summary>
		/// <param name="o">The object to look into</param>
		/// <param name="list">List of data to navigate until we find the value</param>
		/// <param name="value">The value to assign to the property or the value that will be fetched from the property</param>
		/// <param name="set">Set to true indicates the property must be set, false indicates the property value must be retrieved</param>
		/// <returns>True if set/retrieved, false otherwise</returns>
#if REGEXPATHS
		private static bool SearchAndProcessProperty(object o, CListenerPath list, ref List<object> values, bool set = true)
		{
			if (list.ToString().IsNullOrEmpty()) return false;
			if (set && 1 > values.Count)
				return false;

			// <<<>>> verify
			if (!set) values = new List<object>();

			CListenerPath llist = new CListenerPath(list);
			Type type = NexoRetailer.GetRealObjectType(o);
			foreach (PropertyInfo pinfo in type.GetProperties())
			{
				//if (!pinfo.PropertyType.IsArray && MemberTypes.Property == pinfo.MemberType && pinfo.PropertyType.IsPublic)
				if (MemberTypes.Property == pinfo.MemberType && pinfo.PropertyType.IsPublic)
				{
					Type pt = pinfo.PropertyType;
					object pv = pinfo.GetValue(o, null);
					if (null != pv)
					{
						//pt = pv.GetType();
						pt = NexoRetailer.GetRealObjectType(pv);
					}
					string itemName = (0 == string.Compare(pinfo.Name, "item", true) ? (pt.Name.EndsWith("Type") ? pt.Name.Substring(0, pt.Name.LastIndexOf("Type")) : pt.Name) : pinfo.Name);

					// if final leaf
					if (0 == string.Compare("System", pt.Namespace, true) && itemName.Compare(llist[0].Name) && 1 == llist.Count)
					{
						try
						{
							if (set)
							{
								string str = values[0].ToString();
								if (str.Compare(VALUE_ID))
									str = new NexoID().Value;
								else if (str.Compare(VALUE_POIID))
									str = new NexoPOIID().Value;
								else if (str.Compare(VALUE_SALEID))
									str = new NexoSaleID().Value;
								else if (str.Compare(VALUE_DEVICEID))
									str = new NexoDeviceID().Value;
								else if (str.Compare(VALUE_SERVICEID))
									str = new NexoServiceID().Value;

								object obj = AdjustValue(str, pinfo.PropertyType);
								if (!pinfo.PropertyType.IsArray)
									pinfo.SetValue(o, obj, null);
								else
									try
									{
										pinfo.SetValue(o, obj, new object[] { llist[0].isArray ? (int)llist[0].Index : (int)0 });
									}
									catch (Exception ex)
									{
										CLog.EXCEPT(ex);
										return false;
									}
							}
							else
							{
								if (!pinfo.PropertyType.IsArray)
								{
									values.Add(pinfo.GetValue(o, null));
								}
								else
								{

								}
							}
							return true;
						}
						catch (Exception ex)
						{
							CLog.EXCEPT(ex);
						}
						return false;
					}
					else if (0 != string.Compare("System", pt.Namespace, true) && 0 == string.Compare(itemName, llist[0].Name, true) && null != pv)
					{
						llist.RemoveAt(0);
						return SearchAndProcessProperty(pv, llist, ref values, set);
					}
					//else if (0 != string.Compare("System", pt.Namespace, true))
					//{
					//	return SearchAndProcessProperty(pv, llist, ref value, set);
					//}
				}
			}
			return false;
		}
#else
		private static bool SearchAndProcessProperty(object o, List<string> list, ref object value, bool set)
		{
			List<string> llist = new List<string>(list);
			string name = llist?[0];
			if (string.IsNullOrEmpty(name)) return false;

			Type type = NexoRetailer.GetRealObjectType(o);
			foreach (PropertyInfo pinfo in type.GetProperties())
			{
				//if (!pinfo.PropertyType.IsArray && MemberTypes.Property == pinfo.MemberType && pinfo.PropertyType.IsPublic)
				if (MemberTypes.Property == pinfo.MemberType && pinfo.PropertyType.IsPublic)
				{
					Type pt = pinfo.PropertyType;
					object pv = pinfo.GetValue(o, null);
					if (null != pv)
					{
						//pt = pv.GetType();
						pt = NexoRetailer.GetRealObjectType(pv);
					}
					string itemName = (0 == string.Compare(pinfo.Name, "item", true) ? (pt.Name.EndsWith("Type") ? pt.Name.Substring(0, pt.Name.LastIndexOf("Type")) : pt.Name) : pinfo.Name);

					// if final leaf
					if (0 == string.Compare("System", pt.Namespace, true) && 0 == string.Compare(itemName, name, true) && 1 == llist.Count)
					{
						try
						{
							if (set)
							{
								string str = value.ToString();
								object obj = AdjustValue(str, pinfo.PropertyType);
								pinfo.SetValue(o, obj, null);
							}
							else
							{
								value = pinfo.GetValue(o, null);
							}
							return true;
						}
						catch (Exception ex)
						{
							CLog.EXCEPT(ex);
						}
						return false;
					}
					else if (0 != string.Compare("System", pt.Namespace, true) && 0 == string.Compare(itemName, name, true) && null != pv)
					{
						llist.RemoveAt(0);
						return SearchAndProcessProperty(pv, llist, ref value, set);
					}
					//else if (0 != string.Compare("System", pt.Namespace, true))
					//{
					//	return SearchAndProcessProperty(pv, llist, ref value, set);
					//}
				}
			}
			return false;
		}
#endif

		static object AdjustValue(string value, Type targetType)
		{
			if (typeof(string) == targetType) { return value; }
			else if (typeof(bool) == targetType) { if (bool.TryParse(value, out bool o)) return o; }
			else if (typeof(Int16) == targetType) { if (Int16.TryParse(value, out Int16 o)) return o; }
			else if (typeof(Int32) == targetType) { if (Int32.TryParse(value, out Int32 o)) return o; }
			else if (typeof(Int64) == targetType) { if (Int64.TryParse(value, out Int64 o)) return o; }
			else if (typeof(UInt16) == targetType) { if (UInt16.TryParse(value, out UInt16 o)) return o; }
			else if (typeof(UInt32) == targetType) { if (UInt32.TryParse(value, out UInt32 o)) return o; }
			else if (typeof(UInt64) == targetType) { if (UInt64.TryParse(value, out UInt64 o)) return o; }
			else if (typeof(Single) == targetType) { if (Single.TryParse(value, out Single o)) return o; }
			else if (typeof(Double) == targetType) { if (Double.TryParse(value, out Double o)) return o; }
			else if (typeof(Decimal) == targetType) { if (Decimal.TryParse(value, out Decimal o)) return o; }
			else if (typeof(Byte) == targetType) { if (Byte.TryParse(value, out Byte o)) return o; }
			else if (typeof(SByte) == targetType) { if (SByte.TryParse(value, out SByte o)) return o; }
			else if (typeof(Char) == targetType) { if (Char.TryParse(value, out Char o)) return o; }
			return null;
		}
		#endregion

		#region nexo processing
		void OnSentRequestStatusChanged(string xml, NexoObjectToProcess msg, NexoMessageStatus status, TcpClient tcp, CThread thread, object parameters) { }
		/// <summary>
		/// Processing of requests received from the POI
		/// </summary>
		/// <param name="xml"></param>
		/// <param name="msg"></param>
		/// <param name="tcp"></param>
		/// <param name="thread"></param>
		/// <param name="parameters">This is a <see cref="NexoRetailerClientSettings"/> object</param>
		void OnReceivedRequest(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters)
		{
			try
			{
				string sclient = $"[{tcp?.Client?.RemoteEndPoint}] ";
				if (MessageCategoryEnumeration.Display == msg.Category)
				{
					string s = default;
					// processing display message
					NexoDeviceDisplay nxo = msg.CurrentObject as NexoDeviceDisplay;
					// fetch the message to display, initialising it to nothing to display and looping on all messages to display
					for (int i = 0; nxo.RequestData.DisplayOutputCount() - 1 >= i; i++)
					{
						OutputResultType ort = new OutputResultType() { Device = nxo.RequestData.DisplayOutput[i].Device, InfoQualify = nxo.RequestData.DisplayOutput[i].InfoQualify, Response = new ResponseType() { Result = ResultEnumeration.Success.ToString() } };
						// if a message to display to the cashier or the customer
						if (nxo.RequestData.DisplayOutput[i].Device.Compare(DeviceEnumeration.CashierDisplay.ToString())
							|| nxo.RequestData.DisplayOutput[i].Device.Compare(DeviceEnumeration.CustomerDisplay.ToString()))
						{
							// if there's some text to process
							if (nxo.RequestData.DisplayOutput[i].OutputContent.OutputFormat.Compare(OutputFormatEnumeration.Text.ToString())
								&& 0 != nxo.RequestData.DisplayOutput[i].OutputContent.OutputTextCount())
							{
								// loop on all lines to display
								string sl = default;
								for (int j = 0; nxo.RequestData.DisplayOutput[i].OutputContent.OutputTextCount() - 1 >= j; j++)
								{
									if (!nxo.RequestData.DisplayOutput[i].OutputContent.OutputText[j].Value.IsNullOrEmpty())
									{
										sl += Chars.CRLF + nxo.RequestData.DisplayOutput[i].OutputContent.OutputText[j].Value.ToUpper();
									}
								}
								// add the text to display to the current text to display
								s += sl;
							}
							else if (nxo.RequestData.DisplayOutput[i].OutputContent.OutputFormat.Compare(OutputFormatEnumeration.BarCode.ToString())
								&& default != nxo.RequestData.DisplayOutput[i].OutputContent.OutputBarcode)
							{
								s += Resources.DisplayingQRCode;
							}
							else if (nxo.RequestData.DisplayOutput[i].OutputContent.OutputFormat.Compare(OutputFormatEnumeration.MessageRef.ToString())
								&& default != nxo.RequestData.DisplayOutput[i].OutputContent.PredefinedContent)
							{
								s += string.Format(Resources.DisplayingPredefinedContent, nxo.RequestData.DisplayOutput[i].OutputContent.PredefinedContent.ReferenceID);
							}
							else if (nxo.RequestData.DisplayOutput[i].OutputContent.OutputFormat.Compare(OutputFormatEnumeration.XHTML.ToString())
								&& default != nxo.RequestData.DisplayOutput[i].OutputContent.OutputXHTML)
							{
								s += Resources.DisplayingXHTMLContent;
							}
							else
							{
								// the message can't be understood
								ort.Response.Result = ResultEnumeration.Failure.ToString();
								ort.Response.ErrorCondition = ErrorConditionEnumeration.Refusal.ToString();
								ort.Response.AdditionalResponse = ErrorConditionEnumeration.Refusal.ToString();
							}
						}
						else
						{
							// the message won't be displayed
							ort.Response.Result = ResultEnumeration.Failure.ToString();
							ort.Response.ErrorCondition = ErrorConditionEnumeration.Refusal.ToString();
							ort.Response.AdditionalResponse = string.Format(Resources.InvalidDisplayDevice, nxo.RequestData.DisplayOutput[i].Device);
						}

						// if no error mode...
						if (Settings.Nexo.AlwaysSucceedOnDeviceDisplay && !ort.Response.Result.Compare(ResultEnumeration.Success.ToString()))
						{
							ort.Response.Result = ResultEnumeration.Success.ToString();
							ort.Response.ErrorCondition = default;
							ort.Response.AdditionalResponse = default;// Resources.DeviceDisplayAlwaysSucceed;

							s = default;
						}

						// add the result of displaying this message to the message to return
						nxo.ReplyData.OutputResultAddItem(ort);
					}
					// if there's a message to display send it as a notification
					if (!s.IsNullOrEmpty())
					{
						StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = ReplyStatus.nexoDeviceDisplay,
								Message = s,
							})), tcp),
							true, "DeviceDisplay processing", (parameters as NexoRetailerClientSettings).Reserved);
					}
					// if no reply to send dismiss it
					if (!nxo.ResponseIsRequired)
						msg.Action = NexoNextAction.noReply;
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}

			//msg.Action = NexoNextAction.noReply;
		}
		void OnReceivedReply(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters) { }
		/// <summary>
		/// Processing of notifications received from the POI
		/// </summary>
		/// <param name="xml"></param>
		/// <param name="msg"></param>
		/// <param name="tcp"></param>
		/// <param name="thread"></param>
		/// <param name="parameters">This is a <see cref="NexoRetailerClientSettings"/> object</param>
		void OnReceivedNotification(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters)
		{
			try
			{
				string sclient = $"[{tcp?.Client?.RemoteEndPoint}] ";
				string notification = default;
				NexoEvent nxo = msg.CurrentObject as NexoEvent;
				notification = $"[{nxo.EventToNotify}] {nxo.EventDetails}";
				for (int i = 0; nxo.RequestData.DisplayOutput.OutputContent.OutputTextCount() > i; i++)
				{
					if (!nxo.RequestData.DisplayOutput.OutputContent.OutputTextGetItem(i).Value.IsNullOrEmpty())
					{
						notification += $"{nxo.RequestData.DisplayOutput.OutputContent.OutputTextGetItem(i).Value}";
					}
				}
				CLog.TRACE($"Received an {nxo.EventToNotify} notification - Message: {notification}");

				// decide what to do depending on the received event
				if (EventToNotifyEnumeration.Completed == nxo.EventToNotify)
				{
					// an abort message arrived too late to be processed
					notification = CLog.TRACE(Resources.NotificationAbortHasNotBeenProcessed) + Chars.CRLF + notification;
				}
				else if (Settings.Nexo.AlwaysSucceedOnNotification)
				{
					//CLog.TRACE(Resources.NotificationMiscellaneousProcessing);
					CLog.TRACE("Notification processed through miscellaneous processing");

					notification = default;
				}
				else
				{
					notification = CLog.TRACE(string.Format(Resources.NotificationForEvent, new object[] { nxo.RequestData.EventToNotify, nxo.EventDetails })) + Chars.CRLF + notification;
				}

				// if there's a message to display send it as a notification
				if (!notification.IsNullOrEmpty())
				{
					StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
						new CListenerReply()
						{
							Notification = true,
							Status = ReplyStatus.nexoNotification,
							Message = notification,
						})), tcp),
						true, "Notification processing", (parameters as NexoRetailerClientSettings).Reserved);
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}
		void OnReceivedIgnoredMessage(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters)
		{
			CLog.TRACE($"Received a dismissed message - Message: {xml}");
		}
		/// <summary>
		/// Tests whether the string is a perfect match for an identified AID or an approximative match (the string bagins with)
		/// </summary>
		/// <param name="sz">the string to test</param>
		/// <returns>
		/// A scheme name if an identified AID (inside <see cref="Schemes"/>) has been found, an empty string otherwise
		/// </returns>
		string TryDeterminingScheme(string sz)
		{
			if (sz.IsNullOrEmpty()) return string.Empty;
			string perfectMatch = string.Empty, approximateMatch = string.Empty;
			try
			{
				sz = CMisc.Trimmed(sz);
				// search a perfect match with the AID
				foreach (KeyValuePair<string, string> k in Schemes)
				{
					if (sz.Compare(k.Key.Trim()))
					{
						perfectMatch = k.Value;
						break;
					}
					else if (approximateMatch.IsNullOrEmpty() && sz.StartsWith(k.Key.Trim(), StringComparison.InvariantCultureIgnoreCase))
					{
						approximateMatch = k.Value;
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				perfectMatch = string.Empty;
				approximateMatch = string.Empty;
			}
			return perfectMatch.IsNullOrEmpty() ? approximateMatch.IsNullOrEmpty() ? string.Empty : approximateMatch : perfectMatch;
		}
		static CSafeStringTDictionary<string> Schemes = new CSafeStringTDictionary<string>()
		{
			{ "A0000000032010", "Visa Electron" },
			{ "A0000000032020", "VPAY" },
			{ "A000000003", "Visa" },
			{ "A0000000043060", "Maestro" },
			{ "A000000004", "MasterCard" },
			{ "A000000025", "AMEX" },
			{ "A000000042", "Carte Bancaire" },
			{ "A000000065", "JCB" },
			{ "A000000152", "DINER'S" },
			{ "A000000324", "Discover" },
			{ "A000000333", "UnionPay" },
			{ "D2500000121010", "CONECS(Sodexho Pass)" },
			{ "D2500000122000", "CONECS(Bimpli)" },
			{ "D2500000123010", "CONECS(Edenred)" },
			{ "D2500000124000", "CONECS(Up)" },
			{ "D250000012", "CONECS" },
		};
		/// <summary>
		/// Analyse the data received from the POI to determine the brand:
		/// - It first checks whether the brand is  whether the brand is returned by the POI.
		/// - It then analyses the receipt look for an AID.
		/// - If nothing (no AID) no brand is returned.
		/// </summary>
		/// <param name="nxo"></param>
		/// <returns>
		/// A scheme name if an identified AID (inside <see cref="Schemes"/>) has been found, an empty string otherwise
		/// </returns>
		string GetSchemeFromAvailableData(NexoPayment nxo)
		{
			if (default == nxo) return string.Empty;


			string cardBrand;
			try
			{
				// look for brand returned by the POI
				cardBrand = TryDeterminingScheme(nxo.ReplyPaymentBrand);

				// if no scheme returned by the POI, look inside the receipts thenselves
				if (cardBrand.IsNullOrEmpty()
					&& default != nxo.ReplyData
					&& 0 != nxo.ReplyData.PaymentReceiptCount()
					)
				{
					// loop on all available receipts
					for (int i = 0; i < nxo.ReplyData.PaymentReceiptCount(); i++)
					{
						var receipt = nxo.ReplyData.PaymentReceiptGetItem(i);
						if (default != receipt && default != receipt.OutputContent && 0 != receipt.OutputContent.OutputTextCount())
						{
							// loop on all available lines inside the receipt
							for (int j = 0; j < receipt.OutputContent.OutputTextCount(); j++)
							{
								var outputtext = receipt.OutputContent.OutputTextGetItem(j);
								// try determining the scheme
								if (default != outputtext)
								{
									cardBrand = TryDeterminingScheme(outputtext.Value);
									if (!cardBrand.IsNullOrEmpty()) break;
								}
							}
						}
						if (!cardBrand.IsNullOrEmpty()) break;
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				cardBrand = default;
			}
			CLog.INFORMATION(string.Format(Resources.ProcessingFoundCardBrand, new object[] { cardBrand }));
			return cardBrand;
		}
		/// <summary>
		/// Extracts valid receipts from the POI response
		/// </summary>
		/// <param name="nxo"></param>
		/// <returns></returns>
		CReceipts GetReceipts(NexoPayment nxo)
		{
			if (default == nxo
				|| default == nxo.ReplyData
				|| default == nxo.ReplyData.PaymentReceipt
#if ARRAYASLIST
				|| 0 == nxo.ReplyData.PaymentReceipt.Count
#else
				|| 0 == nxo.ReplyData.PaymentReceipt.Length
#endif
				)
				return default;
			CReceipts receipts = new CReceipts();
			try
			{
				for (int i = 0; i < nxo.ReplyData.PaymentReceiptCount(); i++)
				{
					Func<string, ReceiptType> GetType = (string qualifier) =>
					{
						if (qualifier.Compare(DocumentQualifierEnumeration.CashierReceipt.ToString())) return ReceiptType.CashierReceipt;
						else if (qualifier.Compare(DocumentQualifierEnumeration.CustomerReceipt.ToString())) return ReceiptType.CustomerReceipt;
						else return ReceiptType.None;
					};

					PaymentReceiptType rect = nxo.ReplyData.PaymentReceipt[i];
					ReceiptType rectyp = GetType(rect.DocumentQualifier);
					if (ReceiptType.None != rectyp && default != rect.OutputContent && default != rect.OutputContent.OutputText && 0 != rect.OutputContent.OutputTextCount())
					{
#if ARRAYASLIST
						List<OutputTextType> content = rect.OutputContent.OutputText;
#else
						OutputTextType[] content = rect.OutputContent.OutputText;
#endif

						// create a receipt then add all lines to the receipt to return
						List<string> ls = new List<string>();
						for (int j = 0;
#if ARRAYASLIST
							j < content.Count;
#else
							j < content.Length;
#endif
							j++)
						{
							Func<string, int> ExtractLines = (string _s_) =>
							{
								int _nb_ = ls.Count;
								// as a line may contain several lines we must extract all of them separating them by LF
								_s_ = _s_.Replace(Chars.CRLF, Chars.LF);
								_s_ = _s_.Replace(Chars.TAB, Chars.LF);
								_s_ = _s_.Replace(Chars.CR, Chars.LF);
								while (_s_.Contains(Chars.LF))
								{
									string _s1_ = _s_.Substring(0, _s_.IndexOf(Chars.LF));
									// empty lines included inside a wider string are not kept
									if (!_s1_.IsNullOrEmpty()) ls.Add(_s1_);
									_s_ = _s_.Substring(_s_.IndexOf(Chars.LF) + (Chars.LF).Length);
								}
								// arrived here there's only a line left, which can be empty
								ls.Add(_s_);
								return ls.Count - _nb_;
							};

							// extract lines inside a line and and everuthing to the list of lines
							ExtractLines(content[j].Value);
						}
						try
						{
							// add the receipt if not already contained
							if (0 != ls.Count) receipts.Add(rectyp, ls);
						}
						catch (Exception ex)
						{
							// arrived here the receipt is duplicated, only 1 can be used
							CLog.EXCEPT(ex);
						}
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				receipts = default;
			}
			return receipts;
		}
		#endregion

		#region pdf
		//class SurroundingClass
		//{
		//	private HPDFSizeStruct GetReceiptRect(PaymentReceiptType receipt, HPDFPage page)
		//	{
		//		var lineSpacing = page.CurrentFontSize;
		//		GetReceiptRect = new HPDFSizeStruct() { Width = 0, Height = 0 };
		//		if (!IsNothing(receipt.OutputContent) && !IsNothing(receipt.OutputContent.OutputText))
		//		{
		//			// verify lines
		//			OutputContentType newt = new OutputContentType();
		//			var crandlf = new char[] { Constants.vbCr, Constants.vbLf };
		//			for (int i = 0; i <= receipt.OutputContent.OutputTextLength - 1; i++)
		//			{
		//				string s = receipt.OutputContent.OutputTextGetItem(i).Value;
		//				char previousc = "";
		//				do
		//				{
		//					var pos = s.IndexOfAny(crandlf);
		//					if (-1 != pos)
		//					{
		//						var currentc = s.Chars[pos];
		//						var v = s.Substring(0, pos);
		//						// add the line only if
		//						// - there are some characters
		//						// - OR no characters but the control character to go to next line is the first one (CR or LF)
		//						// - OR no characters but the control character to go to next line is not the first one but is not différent from the previous one (CRLF won't give 2 lines but 1 while CRCR or LFLF give 2 lines)
		//						if (!string.IsNullOrEmpty(v) || (string.IsNullOrEmpty(v) && (previousc == "" || previousc == currentc)))
		//							newt.OutputTextAddItem(new OutputTextType(receipt.OutputContent.OutputTextGetItem(i)) { Value = v });
		//						previousc = currentc;
		//						if (s.Length - 1 > pos)
		//							s = s.Substring(pos + 1);
		//						else
		//							s = null;
		//					}
		//					else
		//					{
		//						// If Not String.IsNullOrEmpty(s) Then
		//						newt.OutputTextAddItem(new OutputTextType(receipt.OutputContent.OutputTextGetItem(i)) { Value = s });
		//						s = null;
		//					}
		//				}
		//				while (!string.IsNullOrEmpty(s));
		//			}
		//			receipt.OutputContent = newt;
		//			for (var i = 0; i <= receipt.OutputContent.OutputText.Length - 1; i++)
		//			{
		//				GetReceiptRect.Width = Math.Max(GetReceiptRect.Width, page.GetTextWidth(receipt.OutputContent.OutputText(i).Value));
		//				GetReceiptRect.Height += lineSpacing;
		//			}
		//		}
		//	}

		//	private bool CreateReceiptPDF(ReceiptAnalysis analysis, Receipts receipts)
		//	{
		//		// Try
		//		// 'if no receipt to print return immediately
		//		// If 0 = analysis.receipt.OutputContent.OutputTextLength Then Return False

		//		// Dim titleFontSize = 14
		//		// Dim receiptFontSize = 12
		//		// Dim rectangleMargin = 10.0F
		//		// Dim upperPageBorderToTitle = 50.0F
		//		// Dim numberOfEmptyLines = 2

		//		// 'create the PDF document and load fonts
		//		// Dim document As New HPDFDocument
		//		// Dim receiptFont As HPDFFont = document.GetFont(StandardFonts.Courier, HPDFSingleByteEncoders.WinAnsiEncoding.ToString)
		//		// Dim titleFont As HPDFFont = document.GetFont(StandardFonts.CourierBold, HPDFSingleByteEncoders.WinAnsiEncoding.ToString)

		//		// 'create the pdf page to write the receipt into
		//		// Dim page = document.AddPage()
		//		// page.SetSize(HPDFPageSizes.A4, HPDFPageDirections.Portrait)

		//		// 'prepare title
		//		// Dim title As String
		//		// If DocumentQualifierEnumeration.CustomerReceipt = analysis.target Then
		//		// title = My.Resources.CommonResources.FPrint_CustomerReceipt
		//		// Else
		//		// title = My.Resources.CommonResources.FPrint_MerchantReceipt
		//		// End If
		//		// page.SetFont(titleFont, titleFontSize)
		//		// Dim textWidth = page.GetTextWidth(title)
		//		// Dim titlePos As New HPDFPointStruct() With {.x = (page.Width - textWidth) / 2, .y = page.Height - upperPageBorderToTitle - titleFontSize}

		//		// 'prepare receipt itself
		//		// page.SetFont(receiptFont, receiptFontSize)
		//		// Dim receiptPos As New HPDFPointStruct(titlePos)
		//		// Dim receiptRect = GetReceiptRect(analysis.receipt, page)
		//		// If Not receiptRect.IsNull Then
		//		// 'get final text width for outline
		//		// textWidth = Math.Max(textWidth, receiptRect.Width)
		//		// End If

		//		// 'arrived here we can determine the position and size of the logo (if any)
		//		// 'print the logo
		//		// If DocumentQualifierEnumeration.CustomerReceipt = analysis.target AndAlso Not String.IsNullOrEmpty(nexoSale.Settings.Picture) Then
		//		// Dim fi As New FileInfo(nexoSale.Settings.Picture)
		//		// If fi.Exists Then
		//		// Dim image As HPDFImage = Nothing
		//		// Select Case fi.Extension.ToLower
		//		// Case ".png"
		//		// image = document.LoadPNGImageFromFile(nexoSale.Settings.Picture)
		//		// Case ".jpg", ".jpeg"
		//		// image = document.LoadJpegImageFromFile(nexoSale.Settings.Picture)
		//		// 'Case ".bmp"
		//		// '	image = document.LoadRawImageFromFile(nexoSale.Settings.Picture)
		//		// End Select
		//		// If Not IsNothing(image) Then
		//		// Dim size As New HPDFSizeStruct
		//		// 'determine ratio between width and size of the image
		//		// Dim imagewidth As Single = textWidth + rectangleMargin * 2
		//		// Dim f As Single = imagewidth / image.GetWidth
		//		// Dim imageheight As Single = f * image.GetHeight
		//		// page.DrawImage(image, New HPDFPointStruct With {.x = (page.Width - imagewidth) / 2, .y = page.Height - upperPageBorderToTitle - imageheight}, New HPDFSizeStruct With {.Width = imagewidth, .Height = imageheight})
		//		// 'move all subsequent text by the height of the image
		//		// page.TextRaise = -imageheight - rectangleMargin * 2
		//		// End If
		//		// End If
		//		// End If

		//		// 'prepare positions and sizes to use
		//		// Dim lowerLeftCorner As New HPDFPointStruct(titlePos)
		//		// Dim upperLeftCorner As New HPDFPointStruct() With {.x = titlePos.x, .y = titlePos.y + titleFontSize}
		//		// Dim sizeRectangle As New HPDFSizeStruct() With {.Width = textWidth, .Height = titleFontSize}

		//		// 'print the title
		//		// page.SetFont(titleFont, titleFontSize)
		//		// page.BeginText()
		//		// page.ShowTextAt(title, titlePos)
		//		// page.EndText()

		//		// 'leave empty lines
		//		// Dim titleReceiptSpacing = receiptFontSize * numberOfEmptyLines
		//		// sizeRectangle.Width = textWidth
		//		// sizeRectangle.Height += titleReceiptSpacing + receiptRect.Height

		//		// 'print the receipt
		//		// If Not receiptRect.IsNull Then
		//		// page.SetFont(receiptFont, receiptFontSize)
		//		// page.BeginText()
		//		// 'Set position on the page to start printing the receipt
		//		// Dim receiptCurrentPos As New HPDFPointStruct() With {.x = (page.Width - receiptRect.Width) / 2, .y = titlePos.y - titleReceiptSpacing - receiptFontSize}
		//		// receiptPos = New HPDFPointStruct(receiptCurrentPos)
		//		// page.MoveTextPos(receiptCurrentPos)
		//		// receiptCurrentPos.Reset()
		//		// 'print the receipt 
		//		// For i As Integer = 0 To analysis.receipt.OutputContent.OutputTextLength - 1
		//		// page.MoveTextPos(receiptCurrentPos)
		//		// page.ShowText(analysis.receipt.OutputContent.OutputText(i).Value)
		//		// 'page.ShowTextAt(analysis.receipt.OutputContent.OutputText(i).Value, receiptPos)
		//		// receiptCurrentPos.y = -receiptFontSize
		//		// Next
		//		// 'get the final lower left point
		//		// lowerLeftCorner.x = Math.Min(lowerLeftCorner.x, receiptPos.x)
		//		// lowerLeftCorner.y = page.CurrentTextPos.y
		//		// page.EndText()
		//		// End If

		//		// 'add a rectangle around the whole receipt
		//		// page.SetLineWidth(1)
		//		// lowerLeftCorner.AddY(page.TextRaise)
		//		// lowerLeftCorner.DimX(rectangleMargin)
		//		// lowerLeftCorner.DimY(rectangleMargin)
		//		// sizeRectangle.AddWidth(rectangleMargin * 2)
		//		// sizeRectangle.AddHeight(rectangleMargin * 2)
		//		// page.Rectangle(lowerLeftCorner, sizeRectangle)
		//		// page.Stroke()

		//		// 'save file
		//		// Dim dt As DateTime = Now
		//		// 'Dim fname As String = $"{title}-{receipts.POITimestamp}-{receipts.SaleTransactionID}-{receipts.POITransactionID}"
		//		// Dim fname As String = $"{analysis.target}-{dt.ToString("yyyyMMdd HHmmss")}"
		//		// Dim exists As Boolean
		//		// Dim created As Boolean = document.SaveToFile(fname, exists, False)

		//		// #If DEBUG Then
		//		// Try
		//		// If DocumentQualifierEnumeration.CustomerReceipt = analysis.target Then
		//		// If created Then
		//		// Dim fi As New FileInfo(fname)
		//		// Dim si As New ProcessStartInfo()
		//		// si.UseShellExecute = True
		//		// si.FileName = fi.FullName
		//		// si.Verb = "Open"
		//		// Dim prsok = Process.Start(si)
		//		// End If
		//		// End If
		//		// Catch ex As Exception

		//		// End Try
		//		// #End If

		//		// Return created
		//		// Catch ex As Exception
		//		// Return False
		//		// End Try
		//		// Return False

		//		try
		//		{
		//			// if no receipt to print return immediately
		//			if (0 == analysis.receipt.OutputContent.OutputTextLength)
		//				return false;

		//			var receiptFontSize = 12;
		//			var margin = 10.0F;

		//			// create the PDF document and load fonts
		//			HPDFDocument document = new HPDFDocument();
		//			HPDFFont receiptFont = document.GetFont(StandardFonts.Courier, HPDFSingleByteEncoders.WinAnsiEncoding.ToString);

		//			// create the pdf page to write the receipt into
		//			var page = document.AddPage();

		//			// prepare receipt itself
		//			page.SetFont(receiptFont, receiptFontSize);
		//			var receiptRect = GetReceiptRect(analysis.receipt, page);
		//			if (!receiptRect.IsNull)
		//			{
		//				// get final text width for outline
		//				var textWidth = receiptRect.Width;

		//				// resize the page
		//				page.SetSize(HPDFPageSizes.A4, HPDFPageDirections.Portrait);
		//				page.Height = receiptRect.Height + margin * 2;
		//				page.Width = textWidth + margin * 2;

		//				// arrived here we can determine the position and size of the logo (if any)
		//				FileInfo fi;

		//				// print the logo
		//				if (DocumentQualifierEnumeration.CustomerReceipt == analysis.target && !string.IsNullOrEmpty(nexoSale.Settings.Picture))
		//				{
		//					fi = new FileInfo(nexoSale.Settings.Picture);
		//					if (fi.Exists)
		//					{
		//						HPDFImage image = null/* TODO Change to default(_) if this is not a reference type */;
		//						switch (fi.Extension.ToLower())
		//						{
		//							case ".png":
		//								{
		//									image = document.LoadPNGImageFromFile(nexoSale.Settings.Picture);
		//									break;
		//								}

		//							case ".jpg":
		//							case ".jpeg":
		//								{
		//									image = document.LoadJpegImageFromFile(nexoSale.Settings.Picture);
		//									break;
		//								}
		//						}
		//						if (!IsNothing(image))
		//						{
		//							HPDFSizeStruct size = new HPDFSizeStruct();
		//							// determine ratio between width and size of the image
		//							float imagewidth = textWidth + margin * 2;
		//							float f = imagewidth / (double)image.GetWidth;
		//							float imageheight = f * image.GetHeight;

		//							// resize the page
		//							page.Height = receiptRect.Height + imageheight + margin * 3;

		//							page.DrawImage(image, new HPDFPointStruct() { x = (page.Width - imagewidth) / (double)2, y = page.Height - margin - imageheight }, new HPDFSizeStruct() { Width = imagewidth, Height = imageheight });
		//							// move all subsequent text by the height of the image
		//							page.TextRaise = -imageheight - margin;
		//						}
		//					}
		//				}

		//				// starting point of the receipt on the page
		//				HPDFPointStruct receiptPos = new HPDFPointStruct() { x = (page.Width - textWidth) / (double)2, y = page.Height - margin };

		//				// print the receipt
		//				page.BeginText();
		//				page.SetFont(receiptFont, receiptFontSize);
		//				// Set position on the page to start printing the receipt
		//				HPDFPointStruct receiptCurrentPos = new HPDFPointStruct() { x = (page.Width - receiptRect.Width) / (double)2, y = receiptPos.y - receiptFontSize };
		//				receiptPos = new HPDFPointStruct(receiptCurrentPos);
		//				page.MoveTextPos(receiptCurrentPos);
		//				receiptCurrentPos.Reset();
		//				// print the receipt 
		//				for (int i = 0; i <= analysis.receipt.OutputContent.OutputTextLength - 1; i++)
		//				{
		//					var txt = analysis.receipt.OutputContent.OutputTextGetItem(i).Value;
		//					var tw = page.GetTextWidth(txt);
		//					HPDFPointStruct linePos = new HPDFPointStruct(receiptCurrentPos);
		//					AlignmentEnumeration alignment = new NexoEnumeration(TagsEnumeration.Alignment.ToString).GetLabel(analysis.receipt.OutputContent.OutputTextGetItem(i).Alignment);
		//					switch (alignment)
		//					{
		//						case object _ when AlignmentEnumeration.Justified:
		//						case object _ when AlignmentEnumeration.Centred:
		//							{
		//								// justification not supported here
		//								linePos.x = (textWidth - tw) / (double)2;
		//								break;
		//							}

		//						case object _ when AlignmentEnumeration.Left:
		//							{
		//								linePos.x = linePos.x;
		//								break;
		//							}

		//						case object _ when AlignmentEnumeration.Right:
		//							{
		//								linePos.x = linePos.x + textWidth - tw;
		//								break;
		//							}
		//					}
		//					page.MoveTextPos(linePos);
		//					page.ShowText(analysis.receipt.OutputContent.OutputText(i).Value);
		//					// page.ShowTextAt(analysis.receipt.OutputContent.OutputText(i).Value, receiptPos)
		//					receiptCurrentPos.y = -receiptFontSize;
		//				}
		//				// get the final lower left point
		//				page.EndText();

		//				// save file
		//				DateTime dt = DateTime.Now;
		//				// Dim fname As String = $"{title}-{receipts.POITimestamp}-{receipts.SaleTransactionID}-{receipts.POITransactionID}"
		//				// get forlder to save files in
		//				string folder = Path.GetTempPath();
		//				if (analysis.save)
		//				{
		//					try
		//					{
		//						DirectoryInfo di = new DirectoryInfo(nexoSale.Settings.ReceiptFolder);
		//						if (di.Exists)
		//							folder = di.FullName;
		//					}
		//					catch (Exception ex)
		//					{
		//					}
		//				}
		//				if (!folder.EndsWith(Path.DirectorySeparatorChar))
		//					folder = folder + Path.DirectorySeparatorChar;
		//				string fname = $"{folder}{analysis.target}-{receipts.Header.SaleID}-{receipts.Header.POIID}-{dt.ToString("yyyyMMdd HHmmss")}";
		//				bool exists;
		//				bool created = document.SaveToFile(fname, exists, false);
		//				fi = new FileInfo(fname);

		//				// #If DEBUG Then
		//				// Try
		//				// If DocumentQualifierEnumeration.CustomerReceipt = analysis.target Then
		//				// If created Then
		//				// Dim si As New ProcessStartInfo()
		//				// si.UseShellExecute = True
		//				// si.FileName = fi.FullName
		//				// si.Verb = "Open"
		//				// Dim prsok = Process.Start(si)
		//				// Try
		//				// If Not IsNothing(prsok) Then
		//				// prsok.WaitForExit(nexoSale.POIInUse.GeneralTimer * 1000)
		//				// End If
		//				// Catch ex As Exception
		//				// End Try
		//				// End If
		//				// End If
		//				// Catch ex As Exception
		//				// End Try
		//				// #End If

		//				if (created)
		//				{
		//					if (DocumentQualifierEnumeration.CustomerReceipt == analysis.target)
		//						nexoSale.CustomerReceiptFileName = fi.FullName;
		//					else
		//						nexoSale.MerchantReceiptFileName = fi.FullName;
		//					bool canDelete = !analysis.save;
		//					if (analysis.print & 0 != PrinterSettings.InstalledPrinters.Count)
		//					{
		//						PrinterSettings myprinter = new PrinterSettings();
		//						try
		//						{
		//							// get printer to use, a psecified one or the defualt one
		//							if (!string.IsNullOrEmpty(nexoSale.Settings.Printer))
		//							{
		//								myprinter = new PrinterSettings();
		//								myprinter.PrinterName = nexoSale.Settings.Printer;
		//							}
		//							if (IsNothing(myprinter) || !myprinter.IsValid)
		//								myprinter = new PrinterSettings();
		//							if (!IsNothing(myprinter))
		//							{
		//								// arrived here we've got a valid printer
		//								bool usingDefPrinter = (0 == string.Compare(myprinter.PrinterName, new PrinterSettings().PrinterName, true));

		//								ProcessStartInfo si = new ProcessStartInfo(fname);
		//								si.Arguments = "\"" + myprinter.PrinterName + "\"";
		//								si.Verb = "PrintTo";
		//								si.CreateNoWindow = true;
		//								si.WindowStyle = ProcessWindowStyle.Hidden;
		//								si.UseShellExecute = true; // usingDefPrinter
		//								var prc = Process.Start(si);
		//								try
		//								{
		//									if (!Information.IsNothing(prc))
		//										canDelete = prc.WaitForExit(nexoSale.POIInUse.GeneralTimer * 1000);
		//								}
		//								catch (Exception ex)
		//								{
		//									canDelete = false;
		//								}
		//							}
		//						}
		//						catch (Exception ex)
		//						{
		//							CLog.Add(HEADER + $"Printing {analysis.target} receipt ({fname}) on {myprinter.PrinterName} has failed", TLog.ERROR);
		//						}
		//					}

		//					if (canDelete)
		//					{
		//						try
		//						{
		//							fi.Delete();
		//						}
		//						catch (Exception ex)
		//						{
		//						}
		//					}
		//				}
		//				else if (DocumentQualifierEnumeration.CustomerReceipt == analysis.target)
		//					nexoSale.CustomerReceiptFileName = null;
		//				else
		//					nexoSale.MerchantReceiptFileName = null;
		//				return created;
		//			}
		//		}
		//		catch (Exception ex)
		//		{
		//		}
		//		// arrived here no receipt has been printed
		//		return false;
		//	}

		//	private ReceiptAnalysis AnalyseReceipt(DocumentQualifierEnumeration type, PaymentReceiptType[] receipts)
		//	{
		//		ReceiptAnalysis analysis = new ReceiptAnalysis() { OK = false, lines = 0, maxline = 0, receipt = null/* TODO Change to default(_) if this is not a reference type */};
		//		if (Information.IsNothing(receipts) || 0 == receipts.Count)
		//			return analysis;
		//		// search the requested receipt
		//		for (int i = 0; i <= receipts.Count - 1; i++)
		//		{
		//			var receipt = receipts[i];
		//			if (0 == string.Compare(receipt.DocumentQualifier, type.ToString, true))
		//			{
		//				// the requested receipt is present, let's analyse it
		//				analysis.OK = true;
		//				analysis.receipt = receipt;
		//				analysis.target = CMisc.GetEnumValue(typeof(DocumentQualifierEnumeration), receipt.DocumentQualifier);
		//				// count number of lines and maximum line size
		//				analysis.lines = receipt.OutputContent.OutputText.Length;
		//				for (int j = 0; j <= receipt.OutputContent.OutputText.Length - 1; j++)
		//					analysis.maxline = Math.Max(analysis.maxline, receipt.OutputContent.OutputText(j).Value.Length);
		//				break;
		//			}
		//		}
		//		return analysis;
		//	}

		//	private struct ReceiptAnalysis
		//	{
		//		public bool OK;
		//		public int lines;
		//		public int maxline;
		//		public bool save;
		//		public bool print;
		//		public PaymentReceiptType receipt;
		//		public DocumentQualifierEnumeration target;
		//	}

		//	private bool PrepareSpecificPDF(DocumentQualifierEnumeration type, Receipts receipts)
		//	{
		//		switch (type)
		//		{
		//			case object _ when DocumentQualifierEnumeration.CustomerReceipt:
		//			case object _ when DocumentQualifierEnumeration.CashierReceipt:
		//				{
		//					var analysis = AnalyseReceipt(type, receipts.Receipts);
		//					if (!Information.IsNothing(analysis) && analysis.OK)
		//					{
		//						analysis.save = nexoSale.Settings.SaveReceipts;
		//						if (DocumentQualifierEnumeration.CustomerReceipt == type)
		//							analysis.print = requestedOperation.POI.PrintReceipt && requestedOperation.POI.PrintCustomerReceipt;
		//						else
		//							analysis.print = requestedOperation.POI.PrintReceipt && requestedOperation.POI.PrintMerchantReceipt;
		//						analysis.print = analysis.print && nexoSale.UseInternalPrinting;
		//						return CreateReceiptPDF(analysis, receipts);
		//					}

		//					break;
		//				}
		//		}
		//		return false;
		//	}

		//	private bool PreparePDF(Receipts receipts)
		//	{
		//		try
		//		{
		//			if (!HPDFClass.IsReady)
		//				return false;
		//			if (PrepareSpecificPDF(DocumentQualifierEnumeration.CustomerReceipt, receipts))
		//			{
		//				if (PrepareSpecificPDF(DocumentQualifierEnumeration.CashierReceipt, receipts))
		//					return true;
		//			}
		//		}
		//		catch (Exception ex)
		//		{
		//		}
		//		return false;
		//	}
		//}
		#endregion

		#endregion
	}
}
