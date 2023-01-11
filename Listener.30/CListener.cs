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
using Newtonsoft.Json;
using NEXO.Client;
using NEXO;
using System.Threading;
using System.IO;
using System.Net.WebSockets;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using System.Resources;
using Listener.Properties;

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

		#region static
		public const string LISTENER_DEFAULT_SETTINGS_FILE = "listener.settings.json";
		#endregion

		#region properties
		private struct DataToExchange
		{
			public string Path;
			public List<string> LPath;
			public CListenerDataElement Data;
		}
		private class DataToExchangeList : List<DataToExchange> { }

		ClientWebSocket WS = null;
		CancellationTokenSource Source = null;
		CancellationToken Token;
		bool Started = false;
		CSettings Settings;
		CStreamServer StreamServer = null;
		CListenerStats Stats = new CListenerStats();
		object mylock = new object();
		CSynchronize Events = new CSynchronize();
		bool ClientIsRunning = false;
		#endregion

		#region properties
		public uint Port { get => Settings.Server.Port; }
		public string IP { get => CStream.Localhost(); }
		#endregion

		#region methods
		public override string ToString()
		{
			return Settings.ToString();
		}
		/// <summary>
		/// Start the listener server on settings as deszcribed in <see cref="Settings"/>
		/// </summary>
		/// <param name="settingsFileName">Settings file name</param>
		/// <returns>True if started, false otherwise</returns>
		public bool Start(string settingsFileName)
		{
			//if (null == StreamServer)
			//{
			//	// load settings
			//	CJson<CSettings> json = new CJson<CSettings>(settingsFileName);
			//	CLogger.Add($"Trying to read settings from {json.FileName}");
			//	if (null == (Settings = json.ReadSettings(out bool except)))
			//	{
			//		CLogger.Add("Failed to read settings", TLog.ERROR);

			//		Settings = new CSettings() { Port = 29134, };

			//		json.WriteSettings(Settings, true);
			//		return false;
			//	}
			//	else
			//	{
			//		json.WriteSettings(Settings, true);
			//		// add localhost address to the authorised IPs
			//		Settings.AllowedIP.Add(CStream.Localhost());
			//		Settings.AllowedServices.Add("Login");
			//		Settings.AllowedServices.Add("Logout");
			//		Settings.AllowedServices.Add("Payment");
			//		CLog.Add(CLogger.Display(Settings.ToString()));
			//	}

			//	// start server
			//	StreamServer = new CStreamServer();
			//	IPAddress[] addresses = CStream.Localhosts();
			//	int i = 0;
			//	foreach (IPAddress addr in addresses)
			//	{
			//		i++;
			//		CLogger.Add($"Address {i.ToString("00")} = {addr} ({(IPAddress.IsLoopback(addr) ? "loopback" : "internet")})");
			//	}
			//	// indicate the process wants to alter messages logging
			//	CStreamServerStartSettings start = new CStreamServerStartSettings()
			//	{
			//		StreamServerSettings = new CStreamServerSettings()
			//		{
			//			Port = Settings.Port,
			//			OnMessageToLog = OnMessageToLog,
			//		},
			//		ThreadData = null,
			//		OnConnect = OnConnect,
			//		OnDisconnect = OnDisconnect,
			//		OnMessage = OnMessage,
			//		OnStart = OnStart,
			//		OnStop = OnStop,
			//		Parameters = Settings,
			//	};
			//	bool ok = StreamServer.StartServer(start);
			//	Stats.counterSinceLastStart = 0;
			//	return ok;
			//}
			//return false;

			if (!Started)
			{
				Func<bool> CheckSettings = () =>
				{
					if (null == Settings.Client) Settings.Client = new CSettingsClient();
					if (null == Settings.Server) Settings.Server = new CSettingsServer();
					if (null == Settings.Nexo) Settings.Nexo = new CSettingsNexo();
					if (0 == Settings.POIs.Count)
					{
						Settings.POIs.Add("POI1", new CSettings.CPOI());
					}
					if (0 == Settings.Server.AllowedIP.Count)
					{
						Settings.Server.AllowedIP.Add(CStream.Localhost());
					}
					return true;
				};

				// load settings
				CJson<CSettings> json = new CJson<CSettings>(settingsFileName);
				CLogger.Add($"Trying to read settings from {json.FileName}");

				//DateTime dt1 = DateTime.Now;
				Settings = json.ReadSettings();
				//DateTime dt2 = DateTime.Now;
				//TimeSpan ts = dt2.Subtract(dt1);
				//Console.WriteLine($"Duration: {ts}");

				//if (null == (Settings = json.ReadSettings(out Exception except)))
				if (null == Settings)
				{
					CLogger.Add("Failed to read settings", TLog.ERROR);
					Settings = new CSettings();
					CheckSettings();
					json.WriteSettings(Settings);
					return false;
				}
				else
				{
					// if the listener is to run as a client remove all allowed IPs
					if (Settings.RunAsClient)
					{
						Settings.Server.AllowedIP.Clear();
					}
					CheckSettings();
					json.WriteSettings(Settings);

					Settings.Nexo.AllowedServices.Add("Login");
					Settings.Nexo.AllowedServices.Add("Logout");
					Settings.Nexo.AllowedServices.Add("Payment");
					CLog.Add(CLogger.Display(Settings.ToString()));
				}

				// start server
				StreamServer = new CStreamServer();
				IPAddress[] addresses = CStream.Localhosts();
				int i = 0;
				foreach (IPAddress addr in addresses)
				{
					i++;
					CLogger.Add($"Address {i.ToString("00")} = {addr} ({(IPAddress.IsLoopback(addr) ? "loopback" : "internet")})");
				}
				// indicate the process wants to alter messages logging
				CStreamServerStartSettings start = new CStreamServerStartSettings()
				{
					StreamServerSettings = new CStreamServerSettings()
					{
						Port = Settings.Server.Port,
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
				bool ok = StreamServer.StartServer(start);
				Stats.counterSinceLastStart = 0;

				// is running as server or client
				if (ok && Settings.RunAsClient)
				{
					// create events to manage
					CSynchronize synch = new CSynchronize();
					synch.Add(new ManualResetEvent(false)); // OK
					synch.Add(new ManualResetEvent(false)); // KO
																		 // the listener needs to connect to a distant server
					StartClientMode(synch);
					synch.WaitAny();
					ok = ClientIsRunning;
				}
				Started = ok;
			}
			return Started;
		}
		/// <summary>
		/// Start the listener in client mode, waiting to receive orders from a remote server through <see cref="WebSocket"/>
		/// </summary>
		async void StartClientMode(CSynchronize synch)
		{
			try
			{
				// the listener needs to connect to the server
				WS = new ClientWebSocket();
				Source = new CancellationTokenSource();
				Token = Source.Token;
				// counter of connection attempts
				int counter = 0;
				bool doContinue;
				Exception except;
				do
				{
					counter++;
					doContinue = true;
					bool closing = false;
					bool connected = false;
					string order = string.Empty;
					bool overCounterOfAttempts = false;
					WSAction action = WSAction.Connect;
					CStreamClientIO streamIO = null;
					byte[] ab = new byte[Settings.Client.ReceptionBufferSize];
					// connect to the server
					try
					{
						ClientIsRunning = false;
						await WS.ConnectAsync(new Uri(Settings.Client.URI), Token);
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex);
						throw new WSException($"Failed to connect to web socket [{Settings.Client.URI}]");
					}
					while (WebSocketState.Open == WS.State && doContinue)
					{
						connected = true;

						// run requested action
						switch (action)
						{
							case WSAction.Connect:
								CStreamClientSettings clientSettings = new CStreamClientSettings() { IP = CStream.Localhost(), Port = Settings.Server.Port, ReceiveTimeout = 0 };
								if (null == (streamIO = CStream.Connect(clientSettings)))
								{
									throw new Exception($"Failed to connect to listener, disconnecting from server");
								}
								CLog.TRACE($"Connected to listener");
								action = WSAction.SendLoginRequest;
								break;

							case WSAction.SendLoginRequest:
								// send login information
								CListenerClientLoginRequest loginRequest;
								loginRequest = new CListenerClientLoginRequest() { MACAddress = GetMACAddress() };
								loginRequest.POIs = Settings.POIs.GetSimplePOIs();
								loginRequest._extendedData = Settings.Client.Security._extendedData;
								string s = CJson<CListenerClientLoginRequest>.Serialize(loginRequest);
								if (!s.IsNullOrEmpty())
								{
									CLog.TRACE($"Sending login request to server [{order}]");
									byte[] abs = Encoding.UTF8.GetBytes(s);
									ArraySegment<byte> ar = new ArraySegment<byte>(abs);
									await WS.SendAsync(ar, WebSocketMessageType.Text, true, Token);
									action = WSAction.ReceiveLoginResponse;
									order = string.Empty;
									// message is ready to be processed
									CLog.TRACE("Ready to receive incoming requests");
									ClientIsRunning = true;
									synch[0].Set();
								}
								else
								{
									throw new WSException("Failed to create security chain, disconnecting from server");
								}
								break;

							case WSAction.ReceiveLoginResponse:
							case WSAction.ReceiveRequestOrSettingsUpdate:
								{
									// receive login response
									var result = await WS.ReceiveAsync(new ArraySegment<byte>(ab), Token);
									closing = (WebSocketMessageType.Close == result.MessageType || (null != result.CloseStatus ? WebSocketCloseStatus.Empty != result.CloseStatus : false) || Token.IsCancellationRequested);
									if (!closing && 0 != result.Count)
									{
										order += Encoding.UTF8.GetString(ab, 0, result.Count);
										if (result.EndOfMessage)
										{
											// received message is complete, let's process it
											switch (action)
											{
												case WSAction.ReceiveLoginResponse:
													{
														// convert to a login response
														CListenerClientLoginResponse loginResponse;
														if (null != (loginResponse = CJson<CListenerClientLoginResponse>.Deserialize(order)))
														{
															// connected and a login response has been received, we can reset the attempt counter
															counter = 0;
															if (loginResponse.Granted)
															{
																CLog.INFORMATION($"Connection has been granted [{order}]");
																action = WSAction.ReceiveRequestOrSettingsUpdate;
															}
															else
															{
																throw new Exception($"Connection denied, disconnecting from server");
															}
														}
														else
														{
															throw new Exception($"Invalid login response message received [{order}], disconnecting from server");
														}
													}
													break;

												case WSAction.ReceiveRequestOrSettingsUpdate:
													{
														CListenerRequest listenerRequest = CJson<CListenerRequest>.Deserialize(order);
														if (null != listenerRequest)
														{
															CLog.INFORMATION($"Received request from server [{order}]");
															// a request has been received, post it to the listener server part
															if (CStream.Send(streamIO, order))
															{
																CLog.INFORMATION($"Request sent to the listener");
															}
															else
															{
																CLog.ERROR($"Request failed to be sent to the listener");
															}
														}
														else
														{
															CLog.ERROR($"Invalid request received from the server [{order}], still listening");
															CListenerReply reply = new CListenerReply() { RequestAsString = order };
															reply.Status = ReplyStatus.invalidRequest;
															await WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(reply))), WebSocketMessageType.Text, true, Token);
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

						// if the socket is closing let's do it properly
						if (closing)
						{
							// socket is closing and must be reopened
							CLog.TRACE("Connection to the server is closing, disconnecting");
							await WS.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, null, Token);
							action = WSAction.Connect;
							connected = false;
						}

						// verify what to do next
						doContinue = !closing && !Token.IsCancellationRequested;
					}

					// if a cancel event has been received...
					if (Token.IsCancellationRequested)
					{
						CLog.TRACE("Received a cancellation event, disconnecting");
						if (connected)
						{
							// socket is closing and must be reopened
							await WS.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, null, Token);
							action = WSAction.Connect;
						}
					}
					else if (overCounterOfAttempts = Settings.Client.RetryConnectCounter > counter)
					{
						CLog.ERROR($"Too many attempts to connect to the server [{counter}], shutting down the client");
					}
					connected = false;
					doContinue = !overCounterOfAttempts && !Token.IsCancellationRequested;
				} while (doContinue);
				Source.Cancel();
			}
			catch (WSException ex)
			{
				CLog.EXCEPT(ex);
				synch[1].Set();
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}
		class WSException : Exception
		{
			public WSException(string s) : base(s) { }
		}
		enum WSAction
		{
			Error,
			Connect,
			SendLoginRequest,
			ReceiveLoginResponse,
			ReceiveRequestOrSettingsUpdate,
			SendAnswer,
			SendNotification,
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
		/// <summary>
		/// Stop the listener
		/// </summary>
		public void Stop()
		{
			if (null != StreamServer)
				StreamServer.StopServer();
		}
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
			CSettings settings = (CSettings)o;

			// prepare the list of managed services
			foreach (string svc in settings.Nexo.AllowedServices)
			{
				MessageCategoryEnumeration? cat = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), svc);
				if (null != cat)
					settings.Nexo.AllowedCategories.Add((MessageCategoryEnumeration)cat);
			}
			if (0 == settings.Nexo.AllowedCategories.Count)
			{
				CLogger.Add($"Listener can't start, no service is supported");
				return false;
			}

			CLogger.Add($"Starting listener");
			return true;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnStart"/>
		/// </summary>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		private static void OnStop(CThreadData threadData = null, object o = null)
		{
			CLogger.Add($"Stopping listener");
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
			CSettings settings = (CSettings)parameters;
			try
			{
				if (settings.Server.AllowedIP.Contains(((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString()))
				{
					CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Accepting connection from client");
					return true;
				}
				else
				{
					CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Connection from client has been declined");
				}
			}
			catch (Exception)
			{
				CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Exception while connecting client, connection declined");
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
			CLogger.Add($"[{tcp}] Client has been disconnected");
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
			CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Request from client [{request.Length} bytes] {srequest}", TLog.INFOR, Settings.DisplayMessages);

			/*
			 * process settings
			 */

			Stats.counterTotal++;
			Stats.counterSinceLastStart++;

			// pre-increment invalid counter
			Stats.counterInvalidMessages++;
			Stats.counterInvalidMessagesSinceLastStart++;

			CListenerRequest listenerRequest = CJson<CListenerRequest>.Deserialize(srequest);
			CListenerReply listenerReply = new CListenerReply() { Request = listenerRequest, };
			if (null == listenerRequest)
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Message can't be converted to a request [{srequest}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.invalidRequest;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
			}

			// verify the POI actually exists in the configuration
			CSettings.CPOI poi = null;
			try
			{
				poi = Settings.POIs[listenerRequest.POI];
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				CLogger.Add(listenerReply.Message = $"Requested POI [{listenerRequest.POI}] doesn't exist, request will not be carried out", TLog.ERROR);
				listenerReply.Status = ReplyStatus.invalidPOIRequested;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
			}

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
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] The requested service is invalid [{listenerRequest.Service}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.invalidService;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
			}

			Func<string> SupportedServices = delegate ()
				{
					int i = 0;
					string s = null;
					foreach (MessageCategoryEnumeration cat in Settings.Nexo.AllowedCategories)
					{
						i++;
						s += cat.ToString() + (Settings.Nexo.AllowedCategories.Count == i ? null : ", ");
					}
					return s;
				};

			if (!Settings.Nexo.AllowedCategories.Contains((MessageCategoryEnumeration)category))
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] The requested service is invalid [{listenerRequest.Service}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.serviceNotSupported;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
			}

			// test parameters
			if (string.IsNullOrEmpty(listenerRequest.SaleID) || string.IsNullOrEmpty(listenerRequest.POIID))
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Request parameters are not set properly, SaleID: {(string.IsNullOrEmpty(listenerRequest.SaleID) ? "<is missing>" : listenerRequest.SaleID)}, SaleID: {(string.IsNullOrEmpty(listenerRequest.POIID) ? "<is missing>" : listenerRequest.POIID)}", TLog.ERROR);
				listenerReply.Status = ReplyStatus.mandatoryObjectNotSet;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
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
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Failed creating the nexo object, no more processing will occur", TLog.ERROR);
				listenerReply.Status = ReplyStatus.unknownError;
				return SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply)));
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

			#region code has been commented
			//// take a list of strings (refer to PathToData) and add it to a dictionary of paths + save the value to use
			//Func<List<string>, object, DataPath, bool> SavePathToData = (List<string> path, object value, DataPath dp) =>
			//{
			//	try
			//	{

			//		foreach (string s in path)
			//		{
			//			if (!dp.ContainsKey(s))
			//			{
			//				// add a new node
			//				dp.Add(s, new DataPath());
			//			}
			//			dp = dp[s];
			//		}
			//		// arrived here the full path has been created, save the value
			//		dp.Value = value;
			//		return true;
			//	}
			//	catch (Exception) { }
			//	return false;
			//};

			//Func<Dictionary<string, object>, DataPath, bool> CreatePathToData = (Dictionary<string, object> req, DataPath data) =>
			//{
			//	try
			//	{
			//		foreach (KeyValuePair<string, object> k in req)
			//		{
			//			List<string> l = PathToData(k.Key);
			//			if (null != l)
			//			{
			//				DataPath dp = data;
			//				foreach (string s in l)
			//				{
			//					if (!dp.ContainsKey(s))
			//					{
			//						// add a new node
			//						dp.Add(s, new DataPath());
			//					}
			//					dp = dp[s];
			//				}
			//				// arrived here the full path has been created, save the value
			//				dp.Value = k.Value;
			//			}
			//		}
			//		return true;
			//	}
			//	catch (Exception) { }
			//	return false;
			//};

			//DataPath tosend = new DataPath();
			//if (!CreatePathToData(listenerRequest.ElementsToSend, tosend))
			//{
			//	CLogger.Add(error = $"Failed creating the list of objects to send, no more processing will occur", TLog.ERROR);
			//	return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(new CListenerReply() { Status = ReplyStatus.mandatoryObjectNotSet, Message = error }));
			//}

			//DataPath toreturn = new DataPath();
			//if (!CreatePathToData(listenerRequest.ElementsToSend, toreturn))
			//{
			//	CLogger.Add(error = $"Failed creating the list of objects to send, no more processing will occur", TLog.ERROR);
			//	return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(new CListenerReply() { Status = ReplyStatus.mandatoryObjectNotSet, Message = error }));
			//}
			#endregion

			// search and set data to send
			DataToExchangeList tosend = new DataToExchangeList();
			foreach (KeyValuePair<string, CListenerDataElement> k in listenerRequest.ElementsToSend)
			{
				DataToExchange dte = new DataToExchange() { Path = k.Key, LPath = PathToData(k.Key), Data = new CListenerDataElement() { Value = k.Value.Value, Status = false } };
				if (null != dte.Path)
				{
					if (!(dte.Data.Status = SearchAndProcessProperty(nexo.Request, dte.LPath, ref dte.Data.Value, true)))
						CLogger.Add(dte.Data.Message = $"[{tcp.Client.RemoteEndPoint}] Failed settings data {dte.Path} with {dte.Data.Value}", TLog.ERROR);
				}
				else
					CLogger.Add(dte.Data.Message = $"[{tcp.Client.RemoteEndPoint}] Failed creating the send data path {k.Key}, that data won't be set", TLog.ERROR);
				tosend.Add(dte);
			}

			/*
			 * process the nexo retailer message
			 */

			// if concurrency access is activated check whether an access to the requested resource is already active
			//string resourceName = $"{listenerRequest.IP}:{listenerRequest.Port}.mutex";
			string resourceName = $"{poi.FullIP}.mutex";
			bool timedout = false, cancelled = false, received = false;
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
								Message = Resources.POIIsAlreadyInUse, //$"[{tcp.Client.RemoteEndPoint}] POI is already in use, please wait",
							}))),
							addBufferSize, action, reserved);
						mutex.WaitOne();
						sts = ReplyStatus.accessToPOIHasBeenGranted;
						StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = sts,
								Message = Resources.POIAccessHasBeenGranted, //$"[{tcp.Client.RemoteEndPoint}] POI access has been granted",
							}))),
							addBufferSize, action, reserved);
					}

					NexoRetailerClient client = new NexoRetailerClient(listenerRequest.SaleID, listenerRequest.POIID);
					CStreamClientSettings scs = new CStreamClientSettings() { IP = poi.ConnectionSettings.IP, Port = (uint)poi.ConnectionSettings.Port, ReceiveTimeout = listenerRequest.ReceiveTimeout };
					NexoRetailerClientSettings clientSettings = new NexoRetailerClientSettings() { StreamClientSettings = scs, OnReceivedReply = OnReceivedReply, OnReceivedRequest = OnReceivedRequest, OnReceivedNotification = OnReceivedNotification, OnReceivedIgnoredMessage = OnReceivedIgnoredMessage, Reserved = reserved };

					if (client.Connect(clientSettings))
					{
						bool ok = true;

						// auto login ?
						if (Settings.Nexo.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Performing auto log-in");
							NexoLogin login = new NexoLogin() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.login;
							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Message = string.Format(Resources.LoginTryingToLogWith, new object[] { listenerRequest.SaleID, listenerRequest.POIID }), //$"[{tcp.Client.RemoteEndPoint}] Trying to log from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
								}))),
								addBufferSize, action, reserved);
							if (!(ok = client.SendRequestSync(login)))
							{
								CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] An error has occurred while trying to log to the POI", TLog.ERROR);
								StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
									new CListenerReply()
									{
										Notification = true,
										Status = sts,
										Message = string.Format(Resources.LoginFailedToLogTo, new object[] { listenerRequest.SaleID, listenerRequest.POIID }), //$"[{tcp.Client.RemoteEndPoint}] Failed to log from from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
									}))),
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
										serviceName = "Normal payment";
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
										serviceName = "Other payment";
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
									Message = string.Format(Resources.ServiceStarting, new object[] { serviceName }), //$"[{tcp.Client.RemoteEndPoint}] Starting service {serviceName}",
								}))),
								addBufferSize, action, reserved);

							// send the request synchronously
							if (!client.SendRequestSync(nexo))
								CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] An error has occurred while trying to exchange the nexo retailer order", TLog.ERROR);

							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts2,
									Message = string.Format(Resources.ServiceCompleted, new object[] { serviceName }), //$"[{tcp.Client.RemoteEndPoint}] Service {serviceName} is finished",
								}))),
								addBufferSize, action, reserved);

							timedout = client.TimedOut;
							cancelled = client.Cancelled;
							received = client.Received;
						}

						// auto logout ?
						//if (ok && listenerRequest.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						if (ok && Settings.Nexo.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Performing auto logout");
							NexoLogout logout = new NexoLogout() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.logout;
							StreamServer.Send1WayNotification(SendAnswer(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Message = string.Format(Resources.Logout, new object[] { listenerRequest.SaleID, listenerRequest.POIID }), //$"[{tcp.Client.RemoteEndPoint}] Log-out from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
								}))),
								addBufferSize, action, reserved);
							client.SendRequestSync(logout);
						}
						client.Disconnect();
					}
					else
					{
						CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Error connecting to the POI using [{clientSettings.StreamClientSettings}], no message has been sent", TLog.ERROR);
						listenerReply.Status = ReplyStatus.failedToConnectToPOI;
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
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
			if (timedout)
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Timeout on receiving {nexo.MessageCategory} service listenerReply", TLog.ERROR);
				listenerReply.Status = ReplyStatus.timeout;
			}
			else if (cancelled)
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Operation manually cancelled while processing {nexo.MessageCategory} service", TLog.ERROR);
				listenerReply.Status = ReplyStatus.cancelled;
			}
			else if (received)
			{
				nexoProcessed = true;
				listenerReply.Status = (nexo.Success ? ReplyStatus.Success : nexo.Failure ? ReplyStatus.Failure : nexo.Partial ? ReplyStatus.Partial : ReplyStatus.unknownError);

				// specific message processing
				if (MessageCategoryEnumeration.Payment == category)
				{
					listenerReply.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoPayment)nexo).ReplyPOITransactionID, TimeStamp = ((NexoPayment)nexo).ReplyPOITransactionTimestamp };
				}
				else if (MessageCategoryEnumeration.Reversal == category)
				{
					listenerReply.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoReversal)nexo).ReplyPOITransactionID, TimeStamp = ((NexoReversal)nexo).ReplyPOITimestamp };
				}

				switch (listenerReply.Status)
				{
					case ReplyStatus.Success:
						CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] SUCCESS processing {nexo.MessageCategory} service");

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
						CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] PARTIAL processing {nexo.MessageCategory} service");

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
						CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] FAILURE processing {nexo.MessageCategory} service");

						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.unknownError:
						CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] UNKNOWN ERROR processing {nexo.MessageCategory} service");
						break;
				}
				listenerReply.NexoError = nexo.ErrorCondition.ToString();
				listenerReply.NexoInformation = nexo.AdditionalResponse;
			}
			else
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Unknown error while processing {nexo.MessageCategory} service", TLog.ERROR);
				listenerReply.Status = ReplyStatus.unknownError;
			}

			/*
			 * retrieve specific data
			 */

			DataToExchangeList toreturn = new DataToExchangeList();
			foreach (KeyValuePair<string, CListenerDataElement> k in listenerRequest.ElementsToReturn)
			{
				DataToExchange dte = new DataToExchange() { Path = k.Key, LPath = PathToData(k.Key), Data = new CListenerDataElement() { Value = null, Status = false } };
				if (null != dte.Path && nexoProcessed)
				{
					if (!(dte.Data.Status = SearchAndProcessProperty(nexo.Reply, dte.LPath, ref dte.Data.Value, false)))
						CLogger.Add(dte.Data.Message = $"[{tcp.Client.RemoteEndPoint}] Failed fetching data {dte.Path}", TLog.ERROR);
				}
				else
					CLogger.Add(dte.Data.Message = $"[{tcp.Client.RemoteEndPoint}] Failed creating the return data path {k.Key}, that data won't be fetched", TLog.ERROR);
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
				listenerReply.Request.ElementsToReturn.Add(dte.Path, dte.Data);
			listenerReply.Label = listenerReply.Status.ToString();

			// log reply if requested
			if (Settings.LogExchanges)
			{
				CJson<CListenerReply> json = new CJson<CListenerReply>(GetTempFileName(fileNameHeader + ".reply", ref path, ref tempName));
				json.WriteSettings(listenerReply);
			}

			string sreply = CJson<CListenerReply>.Serialize(listenerReply);
			byte[] breply = Encoding.UTF8.GetBytes(sreply);
			CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Reply to client [{breply.Length} bytes] {sreply}", TLog.INFOR, Settings.DisplayMessages);

			return SendAnswer(breply);
		}
		/// <summary>
		/// Send back an answer according to the way the request has arrived (from a client or from a server)
		/// </summary>
		/// <param name="reply"></param>
		/// <returns></returns>
		byte[] SendAnswer(byte[] reply)
		{
			if (Settings.RunAsClient)
			{
				try
				{
					WS.SendAsync(new ArraySegment<byte>(reply), WebSocketMessageType.Text, true, Token);
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
		/// Converts a "aaa.bbb.ccc" string to a list of strings [0]=aaa, [1]=bbb,...
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
		/// <summary>
		/// Search a type for a specific property to set or retrieve
		/// </summary>
		/// <param name="o">The object to look into</param>
		/// <param name="list">List of data to navigate until we find the value</param>
		/// <param name="value">The value to assign to the property or the value that will be fetched from the property</param>
		/// <param name="set">Set to true indicates the property must be set, false indicates the property value must be retrieved</param>
		/// <returns>True if set/retrieved, false otherwise</returns>
		private static bool SearchAndProcessProperty(object o, List<string> list, ref object value, bool set)
		{
			List<string> llist = new List<string>(list);
			string name = llist?[0];
			if (string.IsNullOrEmpty(name)) return false;

			Type type = NexoRetailer.GetRealObjectType(o);
			foreach (PropertyInfo pinfo in type.GetProperties())
			{
				if (!pinfo.PropertyType.IsArray && MemberTypes.Property == pinfo.MemberType && pinfo.PropertyType.IsPublic)
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
								pinfo.SetValue(o, value, null);
							else
								value = pinfo.GetValue(o, null);
							return true;
						}
						catch (Exception) { }
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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="path"></param>
		/// <param name="tempName"></param>
		/// <returns></returns>
		private static string GetTempFileName(string s, ref string path, ref string tempName)
		{
			if (string.IsNullOrEmpty(tempName))
			{
				string fullname = Path.GetTempFileName();
				tempName = Path.GetFileName(fullname);
				path = Path.GetDirectoryName(fullname);
			}
			return $"{path}{Path.DirectorySeparatorChar}{s}-{tempName}.json";
		}

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
				if (MessageCategoryEnumeration.Display == msg.Category)
				{
					string s = default;
					// processing display message
					NexoDeviceDisplay nxo = msg.CurrentObject as NexoDeviceDisplay;
					// fetch the message to display, initialising it to nothing to display and looping on all messages to display
					for (int i = 0; nxo.RequestData.DisplayOutputLength() - 1 >= i; i++)
					{
						OutputResultType ort = new OutputResultType() { Device = nxo.RequestData.DisplayOutput[i].Device, InfoQualify = nxo.RequestData.DisplayOutput[i].InfoQualify, Response = new ResponseType() { Result = ResultEnumeration.Success.ToString() } };
						// if a message to display to the cashier or the customer
						if (nxo.RequestData.DisplayOutput[i].Device.Compare(DeviceEnumeration.CashierDisplay.ToString())
							|| nxo.RequestData.DisplayOutput[i].Device.Compare(DeviceEnumeration.CustomerDisplay.ToString()))
						{
							// if there's some text to process
							if (nxo.RequestData.DisplayOutput[i].OutputContent.OutputFormat.Compare(OutputFormatEnumeration.Text.ToString())
								&& 0 != nxo.RequestData.DisplayOutput[i].OutputContent.OutputTextLength())
							{
								// loop on all lines to display
								string sl = default;
								for (int j = 0; nxo.RequestData.DisplayOutput[i].OutputContent.OutputTextLength() - 1 >= j; j++)
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
							ort.Response.AdditionalResponse = Resources.DeviceDisplayAlwaysSucceed;
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
							}))),
							true, "DeviceDisplay processing", (parameters as NexoRetailerClientSettings).Reserved);
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
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
				string notification = default;
				NexoEvent nxo = msg.CurrentObject as NexoEvent;
				notification = $"[{nxo.EventToNotify}] {nxo.EventDetails}";
				for (int i = 0; nxo.RequestData.DisplayOutput.OutputContent.OutputTextLength() > i; i++)
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
						}))),
						true, "DeviceDisplay processing", (parameters as NexoRetailerClientSettings).Reserved);
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}
		void OnReceivedIgnoredMessage(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters) { }
		#endregion
	}
}
