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
			public List<string> AllowedIP { get; set; } = new List<string>();
			public List<string> AllowedServices { get; set; } = new List<string>();
			[JsonIgnore]
			public List<MessageCategoryEnumeration> AllowedCategories { get; set; } = new List<MessageCategoryEnumeration>();
			[JsonIgnore]
			private Dictionary<int, SessionType> sessions = new Dictionary<int, SessionType>();

			public override string ToString()
			{
				string s = $"Port: {Port}" + Chars.CRLF;
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
		private int NbTxns = 0;
		private const int MaxTxns = 10;
		private int counter = 0;
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
				CLogger.Add($"Opened port {Settings.Port} on {CStream.Localhost()}");
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
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		private static bool OnConnect(TcpClient tcp, CThreadData threadData = null, object o = null)
		{
			SettingsType settings = (SettingsType)o;
			try
			{
				if (settings.AllowedIP.Contains(((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString()))
				{
					CLogger.Add($"Accepting connection from {tcp.Client.RemoteEndPoint}");
					return true;
				}
				else
				{
					CLogger.Add($"Connection from {tcp.Client.RemoteEndPoint} has been declined");
				}
			}
			catch (Exception)
			{
				CLogger.Add($"Exception while connecting a client {tcp.Client.RemoteEndPoint}, connection declined");
			}
			return false;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnDisconnect"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		private static void OnDisconnect(string tcp, CThreadData threadData = null, object o = null)
		{
			CLogger.Add($"Disconnecting {tcp}");
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnMessage"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="request"></param>
		/// <param name="addBufferSize"></param>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		private static byte[] OnMessage(TcpClient tcp, byte[] request, out bool addBufferSize, CThreadData threadData = null, object o = null)
		{
			addBufferSize = true;
			SettingsType settings = (SettingsType)o;

			string srequest = Encoding.ASCII.GetString(request);
			CLogger.Add($"+++ Starting processing message [{request.Length} bytes] {srequest}");

			/*
			 * process settings
			 */

			CListenerRequest listenerRequest = CJson<CListenerRequest>.Deserialize(srequest, out bool except);
			CListenerReply listenerReply = new CListenerReply() { Request = listenerRequest, };
			if (null == listenerRequest)
			{
				CLogger.Add(listenerReply.Message = $"Message can't be converted to a request [{srequest}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.invalidRequest;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			// arrived here the message has been decoded, let's determine what to do

			// retrieve category and create object if ok
			MessageCategoryEnumeration? category = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), listenerRequest.Service);
			if (null == category)
			{
				CLogger.Add(listenerReply.Message = $"The requested service is invalid [{listenerRequest.Service}]", TLog.ERROR);
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
				CLogger.Add(listenerReply.Message = $"The requested service is invalid [{listenerRequest.Service}]", TLog.ERROR);
				listenerReply.Status = ReplyStatus.serviceNotSupported;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			// test parameters
			if (string.IsNullOrEmpty(listenerRequest.SaleID) || string.IsNullOrEmpty(listenerRequest.POIID))
			{
				CLogger.Add(listenerReply.Message = $"Request parameters are not set properly, SaleID: {(string.IsNullOrEmpty(listenerRequest.SaleID) ? "<is missing>" : listenerRequest.SaleID)}, SaleID: {(string.IsNullOrEmpty(listenerRequest.POIID) ? "<is missing>" : listenerRequest.POIID)}", TLog.ERROR);
				listenerReply.Status = ReplyStatus.mandatoryObjectNotSet;
				return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
			}

			/*
			 * create the nexo retailer object to exchange
			 */

			NexoObject nexo = NexoItem.AllocateObject((MessageCategoryEnumeration)category);
			if (null == nexo)
			{
				CLogger.Add(listenerReply.Message = $"Failed creating the nexo object, no more processing will occur", TLog.ERROR);
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
				((NexoPayment)nexo).RequestRequestedAmount = listenerRequest.RequestedAmount;
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
						CLogger.Add(dte.Data.Message = $"Failed settings data {dte.Path} with {dte.Data.Value}", TLog.ERROR);
				}
				else
					CLogger.Add(dte.Data.Message = $"Failed creating the send data path {k.Key}, that data won't be set", TLog.ERROR);
				tosend.Add(dte);
			}

			/*
			 * process the nexo retailer message
			 */

			bool timedout = false, cancelled = false, received = false;
			NexoRetailerClient client = new NexoRetailerClient(listenerRequest.SaleID, listenerRequest.POIID);
			NexoRetailerClientSettings clientSettings = new NexoRetailerClientSettings() { StreamClientSettings = new CStreamClientSettings() { IP = listenerRequest.IP, Port = (uint)listenerRequest.Port } };
			if (client.Connect(clientSettings))
			{
				bool ok = true;

				// auto login ?
				if (listenerRequest.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
				{
					CLogger.Add($"Performing auto login");
					NexoLogin login = new NexoLogin() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
					if (!(ok = client.SendRequestSync(login)))
						CLogger.Add(listenerReply.Message = $"An error has occurred while trying to log to the POI", TLog.ERROR);
				}

				if (ok)
				{
					// send the request synchronously
					if (!client.SendRequestSync(nexo))
						CLogger.Add(listenerReply.Message = $"An error has occurred while trying to exchange the nexo retailer order", TLog.ERROR);
					timedout = client.TimedOut;
					cancelled = client.Cancelled;
					received = client.Received;
				}

				// auto logout ?
				if (ok && listenerRequest.AutoLoginLogout && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Login) && !((MessageCategoryEnumeration)category == MessageCategoryEnumeration.Logout))
				{
					CLogger.Add($"Performing auto login");
					NexoLogout logout = new NexoLogout() { SaleID = listenerRequest.SaleID, POIID = listenerRequest.POIID };
					client.SendRequestSync(logout);
				}
				client.Disconnect();
			}
			else
			{
				CLogger.Add(listenerReply.Message = $"Error connecting to the POI using [{clientSettings.StreamClientSettings}], no message has been sent", TLog.ERROR);
				listenerReply.Status = ReplyStatus.failedToConnectToPOI;
			}

			/*
			 * check result
			 */

			bool nexoProcessed = false;
			if (timedout)
			{
				CLogger.Add(listenerReply.Message = $"Timeout on receiving {nexo.MessageCategory} service listenerReply", TLog.ERROR);
				listenerReply.Status = ReplyStatus.timeout;
			}
			else if (cancelled)
			{
				CLogger.Add(listenerReply.Message = $"Operation manually cancelled while processing {nexo.MessageCategory} service", TLog.ERROR);
				listenerReply.Status = ReplyStatus.cancelled;
			}
			else if (received)
			{
				nexoProcessed = true;
				listenerReply.Status = (nexo.Success ? ReplyStatus.Success : nexo.Failure ? ReplyStatus.Failure : nexo.Partial ? ReplyStatus.Partial : ReplyStatus.unknownError);

				// specific message processing
				if (MessageCategoryEnumeration.Payment == category)
				{
					listenerRequest.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoPayment)nexo).ReplyPOITransactionID, TimeStamp = ((NexoPayment)nexo).ReplyPOITransactionTimestamp };
				}
				else if (MessageCategoryEnumeration.Reversal == category)
				{
					listenerRequest.POITransaction = new TransactionIdentificationType() { TransactionID = ((NexoReversal)nexo).ReplyPOITransactionID, TimeStamp = ((NexoReversal)nexo).ReplyPOITimestamp };
				}

				switch (listenerReply.Status)
				{
					case ReplyStatus.Success:
						CLogger.Add(listenerReply.Message = $"SUCCESS processing {nexo.MessageCategory} service");

						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
							listenerRequest.AuthorizedAmount = ((NexoPayment)nexo).ReplyAuthorizedAmount;
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.Partial:
						CLogger.Add(listenerReply.Message = $"PARTIAL processing {nexo.MessageCategory} service");

						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
							listenerRequest.AuthorizedAmount = ((NexoPayment)nexo).ReplyAuthorizedAmount;
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.Failure:
						CLogger.Add(listenerReply.Message = $"FAILURE processing {nexo.MessageCategory} service");

						// specific message processing
						if (MessageCategoryEnumeration.Payment == category)
						{
						}
						else if (MessageCategoryEnumeration.Reversal == category)
						{
						}
						break;

					case ReplyStatus.unknownError:
						CLogger.Add(listenerReply.Message = $"UNKNOWN ERROR processing {nexo.MessageCategory} service");
						break;
				}
				listenerReply.NexoError = nexo.ErrorCondition.ToString();
				listenerReply.NexoInformation = nexo.AdditionalResponse;
			}
			else
			{
				CLogger.Add(listenerReply.Message = $"Unknown error while processing {nexo.MessageCategory} service", TLog.ERROR);
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
						CLogger.Add(dte.Data.Message = $"Failed fetching data {dte.Path}", TLog.ERROR);
				}
				else
					CLogger.Add(dte.Data.Message = $"Failed creating the return data path {k.Key}, that data won't be fetched", TLog.ERROR);
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

			return Encoding.UTF8.GetBytes(CJson<CListenerReply>.Serialize(listenerReply));
		}

		// convert a "aaa.bbb.ccc" string to a list of strings [0]=aaa, [1]=bbb,...
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
		#endregion
	}
}
