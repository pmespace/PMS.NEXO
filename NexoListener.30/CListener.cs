﻿using System.Net.Sockets;
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

namespace NexoListener
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

		#region properties
		private struct DataToExchange
		{
			public string Path;
			public List<string> LPath;
			public CListenerDataElement Data;
		}
		private class DataToExchangeList : List<DataToExchange> { }

		private class SessionType
		{
			public bool IsLogged { get; set; }
			List<CListenerReply> Activity { get; set; }
		}

		private class SettingsType
		{
			public uint Port { get; set; }
			public bool AutoLoginLogout { get; set; } = false;
			public bool LogExchanges { get; set; } = false;
			public bool DisplayMessages { get; set; } = false;
			public List<string> AllowedIP { get; set; } = new List<string>();
			public List<string> AllowedServices { get; set; } = new List<string>();
			[JsonIgnore]
			public List<MessageCategoryEnumeration> AllowedCategories { get; set; } = new List<MessageCategoryEnumeration>();
			[JsonIgnore]
			private Dictionary<int, SessionType> sessions = new Dictionary<int, SessionType>();

			public override string ToString()
			{
				string s = $"Port: {Port} - AutoLoginLogout: {AutoLoginLogout}{Chars.CRLF}";
				s += $"AllowedIP:" + Chars.CRLF;
				foreach (string k in AllowedIP)
					s += " - " + k + Chars.CRLF;
				s += $"AllowedServices:" + Chars.CRLF;
				foreach (string k in AllowedServices)
					s += " - " + k + Chars.CRLF;
				return s;
			}
		}

		private SettingsType Settings;
		private CStreamServer StreamServer = null;
		private CListenerStats Stats = new CListenerStats();
		#endregion

		#region properties
		public uint Port { get => Settings.Port; }
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
		internal bool Start(string settingsFileName)
		{
			if (null == StreamServer)
			{
				// load settings
				CJson<SettingsType> json = new CJson<SettingsType>(settingsFileName);
				CLogger.Add($"Trying to read settings from {json.FileName}");
				if (null == (Settings = json.ReadSettings(out bool except)))
				{
					CLogger.Add("Failed to read settings", TLog.ERROR);

					Settings = new SettingsType() { Port = 29134, };

					json.WriteSettings(Settings, true);
					return false;
				}
				else
				{
					json.WriteSettings(Settings, true);
					// add localhost address to the authorised IPs
					Settings.AllowedIP.Add(CStream.Localhost());
					Settings.AllowedServices.Add("Login");
					Settings.AllowedServices.Add("Logout");
					Settings.AllowedServices.Add("Payment");
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
						Port = Settings.Port,
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
				return ok;
			}
			return false;
		}
		/// <summary>
		/// Stop the listener
		/// </summary>
		internal void Stop()
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
			SettingsType settings = (SettingsType)o;


			// prepare the list of managed services
			foreach (string svc in settings.AllowedServices)
			{
				MessageCategoryEnumeration? cat = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), svc);
				if (null != cat)
					settings.AllowedCategories.Add((MessageCategoryEnumeration)cat);
			}
			if (0 == settings.AllowedCategories.Count)
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
			SettingsType settings = (SettingsType)parameters;
			try
			{
				if (settings.AllowedIP.Contains(((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString()))
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
			SettingsType settings = (SettingsType)parameters;

			string srequest = Encoding.ASCII.GetString(request);
			CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Request from client [{request.Length} bytes] {srequest}", TLog.INFOR, settings.DisplayMessages);

			/*
			 * process settings
			 */

			Stats.counterTotal++;
			Stats.counterSinceLastStart++;

			// pre-increment invalid counter
			Stats.counterInvalidMessages++;
			Stats.counterInvalidMessagesSinceLastStart++;

			CListenerRequest listenerRequest = CJson<CListenerRequest>.Deserialize(srequest, out bool except);
			CListenerReply listenerReply = new CListenerReply() { Request = listenerRequest, };
			if (null == listenerRequest)
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Message can't be converted to a request [{srequest}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.invalidRequest;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			string path = null;
			string tempName = null;
			string fileNameHeader = $"nexolistener.{tcp.Client.RemoteEndPoint}.{listenerReply.Request.SaleID}.{listenerReply.Request.POIID}";
			char[] chars = Path.GetInvalidFileNameChars();
			foreach (char c in chars)
				fileNameHeader = fileNameHeader.Replace(c, '.');

			// log request if requested
			if (settings.LogExchanges)
			{
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
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			Func<string> SupportedServices = delegate ()
				{
					int i = 0;
					string s = null;
					foreach (MessageCategoryEnumeration cat in settings.AllowedCategories)
					{
						i++;
						s += cat.ToString() + (settings.AllowedCategories.Count == i ? null : ", ");
					}
					return s;
				};

			if (!settings.AllowedCategories.Contains((MessageCategoryEnumeration)category))
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] The requested service is invalid [{listenerRequest.Service}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.serviceNotSupported;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			// test parameters
			if (string.IsNullOrEmpty(listenerRequest.SaleID) || string.IsNullOrEmpty(listenerRequest.POIID))
			{
				CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] Request parameters are not set properly, SaleID: {(string.IsNullOrEmpty(listenerRequest.SaleID) ? "<is missing>" : listenerRequest.SaleID)}, SaleID: {(string.IsNullOrEmpty(listenerRequest.POIID) ? "<is missing>" : listenerRequest.POIID)}", TLog.ERROR);
				listenerReply.Status = ReplyStatus.mandatoryObjectNotSet;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
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
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
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
			string resourceName = $"{listenerRequest.IP}:{listenerRequest.Port}.mutex";
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
						StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = sts,
								Label = sts.ToString(),
								Message = $"[{tcp.Client.RemoteEndPoint}] POI is already in use, please wait",
							})),
							addBufferSize, action, reserved);
						mutex.WaitOne();
						sts = ReplyStatus.accessToPOIHasBeenGranted;
						StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
							new CListenerReply()
							{
								Notification = true,
								Status = sts,
								Label = sts.ToString(),
								Message = $"[{tcp.Client.RemoteEndPoint}] POI access has been granted",
							})),
							addBufferSize, action, reserved);
					}

					NexoRetailerClient client = new NexoRetailerClient(listenerRequest.SaleID, listenerRequest.POIID);
					NexoRetailerClientSettings clientSettings = new NexoRetailerClientSettings() { StreamClientSettings = new CStreamClientSettings() { IP = listenerRequest.IP, Port = (uint)listenerRequest.Port, ReceiveTimeout = listenerRequest.ReceiveTimeout } };
					if (client.Connect(clientSettings))
					{
						bool ok = true;

						// auto login ?
						//if (listenerRequest.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						if (settings.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Performing auto log-in");
							NexoLogin login = new NexoLogin() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.login;
							StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Label = sts.ToString(),
									Message = $"[{tcp.Client.RemoteEndPoint}] Trying to log from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
								})),
								addBufferSize, action, reserved);
							if (!(ok = client.SendRequestSync(login)))
							{
								CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] An error has occurred while trying to log to the POI", TLog.ERROR);
								StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
									new CListenerReply()
									{
										Notification = true,
										Status = sts,
										Label = sts.ToString(),
										Message = $"[{tcp.Client.RemoteEndPoint}] Failed to log from from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
									})),
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
							StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Label = sts.ToString(),
									Message = $"[{tcp.Client.RemoteEndPoint}] Starting service {serviceName}",
								})),
								addBufferSize, action, reserved);
							// send the request synchronously
							if (!client.SendRequestSync(nexo))
								CLogger.Add(listenerReply.Message = $"[{tcp.Client.RemoteEndPoint}] An error has occurred while trying to exchange the nexo retailer order", TLog.ERROR);
							StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts2,
									Label = sts2.ToString(),
									Message = $"[{tcp.Client.RemoteEndPoint}] Service {serviceName} is finished",
								})),
								addBufferSize, action, reserved);
							timedout = client.TimedOut;
							cancelled = client.Cancelled;
							received = client.Received;
						}

						// auto logout ?
						//if (ok && listenerRequest.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						if (ok && settings.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
						{
							CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Performing auto logout");
							NexoLogout logout = new NexoLogout() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
							sts = ReplyStatus.logout;
							StreamServer.Send1WayNotification(Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(
								new CListenerReply()
								{
									Notification = true,
									Status = sts,
									Label = sts.ToString(),
									Message = $"[{tcp.Client.RemoteEndPoint}] Log-out from SaleID: {listenerRequest.SaleID} to POIID: {listenerRequest.POIID}",
								})),
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
			if (settings.LogExchanges)
			{
				CJson<CListenerReply> json = new CJson<CListenerReply>(GetTempFileName(fileNameHeader + ".reply", ref path, ref tempName));
				json.WriteSettings(listenerReply);
			}

			string sreply = CJson<CListenerReply>.Serialize(listenerReply);
			byte[] breply = Encoding.UTF8.GetBytes(sreply);
			CLogger.Add($"[{tcp.Client.RemoteEndPoint}] Reply to client [{breply.Length} bytes] {sreply}", TLog.INFOR, settings.DisplayMessages);

			return breply;
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
		#endregion
	}
}