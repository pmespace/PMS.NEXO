﻿using System.Runtime.InteropServices;
using System.Reflection;
using System.Net;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if !NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

//using NEXO.Properties;
using COMMON;
using NEXO;

namespace NEXO.Server
{
	[ComVisible(false)]
	public sealed class NexoRetailerServer : NexoRetailer
	{
		#region constructor
		public NexoRetailerServer()
		{
			UseDatabase = true;
			Initialise();
		}
		public NexoRetailerServer(bool useDatabase)
		{
			UseDatabase = useDatabase;
			Initialise();
		}
		private void Initialise()
		{
			SupportedProtocolVersions = new NexoSupportedProtocolVersions();
			ServerProtocolVersion = new NexoProtocolVersion(NexoCurrentVersion.Current.Version);
			try
			{
				SupportedProtocolVersions.Add(ServerProtocolVersion.Value, ServerProtocolVersion);
			}
			catch (Exception) { }
		}
		#endregion

		#region public properties
		/// <summary>
		/// Indicator set 
		/// </summary>
		public bool UseDatabase { get; private set; }
		/// <summary>
		/// Indicates whether the serve ris actually running or not
		/// </summary>
		public bool IsRunning { get => null != StreamServer && StreamServer.IsRunning; }
		/// <summary>
		/// Thread of the server
		/// </summary>
		public CStreamServer StreamServer { get; private set; }
		/// <summary>
		/// Allow duplicated messages to be received
		/// </summary>
		public bool AllowDuplicates { get; set; }
		/// <summary>
		/// Version of Nexo Retailer specifications implemented by the server
		/// </summary>
		public NexoProtocolVersion ServerProtocolVersion { get; private set; }
		/// <summary>
		/// All supported protocol versions
		/// </summary>
		public NexoSupportedProtocolVersions SupportedProtocolVersions { get; private set; }
		/// <summary>
		/// data used to initialise the calling environement of the server thread
		/// </summary>
		public NexoRetailerServerSettings Settings { get; private set; } = null;
		/// <summary>
		/// Indicates whether a dump of all commands processed by the server must be produced when the server stops
		/// </summary>
		public bool DumpOnExit { get; set; } = false;
		///// <summary>
		///// server startup datetime
		///// </summary>
		//private DateTime _startup;
		/// <summary>
		/// Server activity while running
		/// </summary>
		public NexoRetailerServerActivity Activity = new NexoRetailerServerActivity();
		/// <summary>
		/// Timer to wait for before the server sends a reply back
		/// </summary>
		public int TimerBeforeReply { get; set; }
		/// <summary>
		/// Database to use for server settings
		/// </summary>
		private NexoRetailerServerDatabase Database = null;
		#endregion

		#region private properties
		/// <summary>
		/// Server stopping mutex
		/// </summary>
		private readonly Mutex isStoppingMutex = new Mutex(false);
		#endregion

		#region public methods
		/// <summary>
		/// Load database settings from a json file
		/// </summary>
		/// <param name="databaseSettingsFileName">Json file to load</param>
		/// <returns>a <see cref="NexoRetailerServerDatabaseSettings"/> if successfull, null otherwise</returns>
		public static NexoRetailerServerDatabaseSettings LoadDatabaseSettings(string databaseSettingsFileName)
		{
			if (string.IsNullOrEmpty(databaseSettingsFileName))
				return null;
			CJson<NexoRetailerServerDatabaseSettings> json = new CJson<NexoRetailerServerDatabaseSettings>(databaseSettingsFileName);
			NexoRetailerServerDatabaseSettings settings = default;
			try
			{
				settings = json.ReadSettings();
			}
			catch (Exception) { }
			return json.ReadSettings();
		}
		/// <summary>
		/// Starts the Nexo server.
		/// </summary>
		/// <param name="settings">Parameters to use to run the server thread</param>
		/// <returns>A <see cref="CThread"/> object if the serve ris started, null otherwise</returns>
		public bool Start(NexoRetailerServerSettings settings)
		{
			if (IsRunning)
				return true;
			if (!settings.IsValid)
			{
				CLog.Add($"SERVER SETTINGS ARE INVALID, CAN'T START SERVER", TLog.ERROR);
				return false;
			}
			else if (UseDatabase)
			{
				if (null != settings.DatabaseSettings && settings.DatabaseSettings.IsValid())
				{
					// verify database connection
					Database = new NexoRetailerServerDatabase() { Settings = settings.DatabaseSettings, };
					if (!Database.IsOpen)
					{
						// database is required but not available
						CLog.Add($"UNABLE TO CONNECT TO THE DATABASE, CHECK SETTINGS", TLog.ERROR);
						Database = null;
						return false;
					}
				}
				else
				{
					// database is required but no parameters are available
					return false;
				}
			}
			else
			{
				// no database to use
				Database = null;
			}
			Settings = settings;
			StreamServer = new CStreamServer();
			StreamServer.StartServer(new CStreamServerStartSettings()
			{
				StreamServerSettings = settings.StreamServerSettings,
				ThreadData = settings.ThreadData,
				OnConnect = OnConnect,
				OnDisconnect = OnDisconnect,
				OnMessage = OnMessage,
				OnStart = OnStart,
				OnStop = OnStop,
				Parameters = settings.Parameters,
			});
			if (null != StreamServer)
			{
				//// save startup time
				//_startup = DateTime.Now;
				// close all currently opened connections
				if (null != Database)
					Database.CloseAllConnections();
				return true;
			}
			return false;
		}
		/// <summary>
		/// Stop the Nexo server.
		/// </summary>
		/// <returns>True if the thread has started, false otherwise</returns>
		public bool Stop(bool wait = true)
		{
			if (!IsRunning)
				return true;
			if (isStoppingMutex.WaitOne(0))
			{
				StreamServer.StopServer();
				StreamServer = null;
			}
			if (null != Database) Database = null;
			return true;
		}
		#endregion

		#region private methods
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnStart"/>
		/// </summary>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		private bool OnStart(CThreadData threadData = null, object o = null)
		{
			try
			{
				return null != Settings.OnStart ? Settings.OnStart(threadData, o) : true;
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				return false;
			}
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnConnect"/>
		/// </summary>
		/// <param name="tcp"></param>
		/// <param name="thread"></param>
		/// <param name="parameters"></param>
		/// <param name="privateData"></param>
		/// <returns></returns>
		private bool OnConnect(TcpClient tcp, CThread thread, object parameters, ref object privateData)
		{
			try
			{
				NexoEndPoint ep = new NexoEndPoint(tcp);
				Activity.AddEndPoint(ep);
				// test list of accepted/refused end points
				if (null == Database || Database.IsEndPointAccepted(tcp))
				{
					bool fOK = true;
					try
					{
						if (null != Settings.OnConnect)
							fOK = Settings.OnConnect(tcp, thread, parameters, ref privateData);
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex, "OnConnect generated an exception");
					}
					if (fOK)
					{
						ep.AddConnection(true);
						CLog.Add($"{StreamServer.Description} - EndPoint allowed to connect: {ep.Key}");
						return true;
					}
					ep.AddConnection(false);
					CLog.Add($"{StreamServer.Description} - ENDPOINT NOT ALLOWED TO CONNECT: {ep.Key}", TLog.ERROR);
				}
				else
					CLog.Add($"{StreamServer.Description} - ENDPOINT NOT ALLOWED TO CONNECT: {ep.Key}", TLog.ERROR);
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnDisconnect"/>
		/// </summary>
		/// <param name="tcpclient"></param>
		/// <param name="thread"></param>
		/// <param name="parameters"></param>
		/// <param name="statistics"></param>
		private void OnDisconnect(TcpClient tcpclient, CThread thread, object parameters, CStreamServerStatistics statistics)
		{
			try
			{
				try
				{
					if (null != Settings.OnDisconnect)
					{
						Settings.OnDisconnect(tcpclient, thread, parameters, statistics);
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex, "OnDisconnect generated an exception");
				}
				NexoEndPoint ep = new NexoEndPoint(tcpclient);
				Activity.RemoveEndPoint(ep);
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
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
		/// <param name="o"></param>
		/// <returns></returns>
		private byte[] OnMessage(TcpClient tcp, byte[] request, out bool addBufferSize, CThread thread, object parameters, object privateData, object o)
		{
			addBufferSize = true;
			byte[] reply = null;
			try
			{
				// get the XML request
				string xml = Encoding.UTF8.GetString(request);
				if (!string.IsNullOrEmpty(xml))
				{
					string shortmessage = null;
					string fullmessage = null;
					long msgid = 0;

					/********************/
					/* message processing */

					// save the mesage
					Activity.AddReceivedMessage(new NexoAnyMessage(xml));
					// try to identify the received message
					NexoItem item = new NexoItem(xml);
					NexoObjectToProcess toprocess = new NexoObjectToProcess(item); ;
					if (item.IsValid && (item.IsNotification || item.IsRequest || item.IsReply))
					{
						RequestResponseType response;

						if (null != Database)
							Database.AddNewRequest(item, out msgid);

						// create the Nexo object according to what is expected
						if (item.IsNotification)
						{
							toprocess.Action = NexoNextAction.noReply;
							toprocess.CanModifyAction = false;
						}
						else if (item.IsRequest)
						{
							response = ProcessRequest(tcp, item);
							toprocess.SuggestedAction = response.Action;
							toprocess.CanModifyAction = response.CanOverride;
							toprocess.CurrentObject.Response = response.Response.Response();
							toprocess.PassToApp = ResultEnumeration.Success == response.Response.Result;
						}
						else if (item.IsReply)
						{
							// fetch original request
							toprocess.SuggestedAction = NexoNextAction.final;
						}
					}
					else
					{
						CLog.Add($"{StreamServer.Description} - Unable to proces the received message, a notification is being sent", TLog.WARNG);
						// invalid message
						toprocess.SuggestedAction = NexoNextAction.sendNotification;
						toprocess.CanModifyAction = false;
						toprocess.PassToApp = false;
						// cerate the notification to send containing the rejected message
						NexoEvent evt = new NexoEvent();
						evt.EventToNotify = EventToNotifyEnumeration.Reject;
						evt.EventRejectedMessage = BitConverter.ToString(request);// new NexoByteSequence() { Value = request };
						evt.EventDetails = "Unrecognized message";
						toprocess.NextObject = evt;
					}

					/********************/
					/* next action processing */

					shortmessage = $"Received {item.Category.ToString().ToUpper()} {item.Type}";
					fullmessage = $"{shortmessage} - Message [{xml.Length} bytes]: {xml}";
					CLog.Add($"{StreamServer.Description} - {fullmessage} - Suggested action: {toprocess.SuggestedAction} - Action: {toprocess.Action}");

					/* arrived here, let's see what to do next
					 * if no suggested action has been set or we must not pass the message to the app for further processing, we don't go through this */
					if (null != toprocess && NexoNextAction.nothing != toprocess.SuggestedAction && toprocess.PassToApp)
					{
						//// if declined do not pass the message to the application for processing, unless it has been explicitely set to
						//if (!toprocess.CurrentObject.Failure || AllowChangingResults)
						//{
						//	if (toprocess.CurrentObject.Failure && AllowChangingResults)
						//	{
						//		// indicate we are in a special case explicitely authorised
						//		CLog.Add("Pre-processing declined the request but server is set to allow application processing anyway", TLog.WARNG);
						//	}
						// request analysis by the application
						try
						{
							if (item.IsNotification)
								Settings.OnReceivedNotification?.Invoke(xml, toprocess, tcp, thread, parameters);
							else if (item.IsRequest)
								Settings.OnReceivedRequest?.Invoke(xml, toprocess, tcp, thread, parameters);
							else if (item.IsReply)
								Settings.OnReceivedReply?.Invoke(xml, toprocess, tcp, thread, parameters);
						}
						catch (Exception ex)
						{
							CLog.EXCEPT(ex, "Message analysis generated an exception");
							// unstable situation, we stop processing the message and send a notification instead
							toprocess.Action = NexoNextAction.sendNotification;
							toprocess.CanModifyAction = false;
							toprocess.PassToApp = false;
							// send a notification with the rejected message
							NexoEvent evt = new NexoEvent();
							evt.EventToNotify = EventToNotifyEnumeration.OutOfOrder;
							evt.EventDetails = "Message analysis generated an exception inside the server";
							toprocess.NextObject = evt;
						}
						if (toprocess.Action != toprocess.SuggestedAction)
						{
							CLog.Add($"{StreamServer.Description} - {shortmessage} - Action has been modified by the application: {toprocess.Action}", TLog.WARNG);
						}
						//}
					}

					/********************/
					/* reply processing */

					CLog.Add($"{StreamServer.Description} - Decided action: {toprocess.Action}");

					try
					{
						// analyse decision
						string s = null, t = null, c = null;
						switch (toprocess.Action)
						{
							case NexoNextAction.sendReply:
								//case NexoNextAction.sendReplyWithError:
								s = toprocess.CurrentObject.SerializeAndCompleteReply();
								c = toprocess.CurrentObject.Reply.MessageHeader.MessageCategory.ToUpper();
								t = MessageTypeEnumeration.Response.ToString().ToUpper();
								break;
							case NexoNextAction.sendRequest:
								s = toprocess.NextObject.SerializeAndCompleteRequest();
								c = toprocess.NextObject.Reply.MessageHeader.MessageCategory.ToUpper();
								t = MessageTypeEnumeration.Request.ToString().ToUpper();
								break;
							case NexoNextAction.sendNotification:
								s = toprocess.NextObject.SerializeAndCompleteRequest();
								c = toprocess.NextObject.Reply.MessageHeader.MessageCategory.ToUpper();
								t = MessageTypeEnumeration.Notification.ToString().ToUpper();
								break;
							default:
								// nothing to do
								break;
						}
						if (!string.IsNullOrEmpty(s))
						{
							CLog.Add($"{StreamServer.Description} - Sending {c} {t} - Message[{s.Length} bytes]: {s}");
							// set message to send (or not)
							reply = Encoding.UTF8.GetBytes(s);
							NexoItem itemToSend = new NexoItem(s);
							try
							{
								Thread.Sleep(TimerBeforeReply * CStreamClientSettings.ONESECOND);
								Settings.OnSend?.Invoke(s, itemToSend, tcp, thread, thread.ThreadData, parameters);
							}
							catch (Exception ex)
							{
								CLog.EXCEPT(ex, "OnSend generated an exception");
							}
							if (null != Database)
							{
								switch (toprocess.Action)
								{
									case NexoNextAction.sendReply:
										//case NexoNextAction.sendReplyWithError:
										Database.SetRequestReply(msgid, itemToSend, toprocess.CurrentObject.Response);
										break;
									case NexoNextAction.sendRequest:
										// <<<>>> REVISIT AS id should be used when the reply arrives
										Database.AddNewRequest(itemToSend, out msgid);
										break;
									case NexoNextAction.sendNotification:
										Database.AddNewRequest(itemToSend, out long id);
										break;
									default:
										// nothing to do
										break;
								}
							}
							// store the replied message if any
							if (null != reply)
								Activity.AddSentMessage(new NexoAnyMessage(Encoding.UTF8.GetString(reply)));
						}
						else
						{
							CLog.Add($"{StreamServer.Description} - NO MESSAGE COULD BE GENERATED TO SEND TO THE CLIENT", TLog.ERROR);
						}
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex);
					}
				}
				else
				{
					CLog.Add($"{StreamServer.Description} - Invalid message received", TLog.WARNG);
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return reply;
		}
		/// <summary>
		/// <see cref="CStreamServerStartSettings.OnStop"/>
		/// </summary>
		/// <param name="threadData"></param>
		/// <param name="o"></param>
		private void OnStop(CThreadData threadData = null, object o = null)
		{
			try
			{
				// should the server stop ?
				Settings.OnStop?.Invoke(threadData, o);
				// dump data if required
				if (DumpOnExit)
				{
					// dump server
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}
		/// <summary>
		/// Processing of a request received by the server
		/// </summary>
		/// <param name="tcp">TCP settings of the originator of the message</param>
		/// <param name="item">The request item received froom the client</param>
		private RequestResponseType ProcessRequest(TcpClient tcp, NexoItem item)
		{
			string xml = item.ToString();
			CLog.Add($"{StreamServer.Description} - Processing request: {xml}");
			RequestResponseType response = new RequestResponseType();
			response.Action = item.ReplyRequired ? NexoNextAction.sendReply : NexoNextAction.noReply;
			// validate XML against XSD
			bool fOK = false;
			bool fConnected = false;
			try
			{
				// save the message
				// determine whether the request is valid or not
				NexoMessageHeader mhex = new NexoMessageHeader(((SaleToPOIRequest)item.Item).MessageHeader, ServerProtocolVersion);
				if (fOK = mhex.IsValid)
				{
					NexoPartner client = Activity.AddClient(new NexoPartner(tcp, ((SaleToPOIRequest)item.Item).MessageHeader));
					NexoMessage msg = client.AddMessage(new NexoMessage((SaleToPOIRequest)item.Item, xml, true));
					// if LoginRequest
					if (MessageCategoryEnumeration.Login == item.Category)
					{
						// login processing, response can't be modified
						response.CanOverride = false;
						NexoSession session = client.AddSession(new NexoSession(client));
						NexoLogin nxo = new NexoLogin();
						nxo.Request = (SaleToPOIRequest)item.Item;
						// test list of accepted/refused sale
						if (null == Database || Database.IsSaleIDAccepted(tcp, nxo))
						{
							// verify protocol version
							try
							{
								NexoProtocolVersion version = SupportedProtocolVersions[mhex.ProtocolVersion.Value];
								// add the client to the list of connected clients
								session.SetConnected();
								Activity.AddCurrentClient(client);
								response.Action = NexoNextAction.sendReply;
							}
							catch (Exception)
							{
								NexoErrors.UnavailableServiceTooOldProtocolVersion(response.Response, mhex.ProtocolVersion.Value, ServerProtocolVersion.Value);
								response.Action = NexoNextAction.sendReply;// sendReplyWithError;
							}
						}
						else
						{
							CLog.Add($"{StreamServer.Description} - SaleID {nxo.SaleID} has not been authorised to connect to {nxo.POIID}", TLog.ERROR);
							NexoErrors.GenericEror(response.Response, ResultEnumeration.Failure, ErrorConditionEnumeration.LoggedOut, $"SaleID : {mhex.SaleID.Value} not allowed to connect");
							response.Action = NexoNextAction.sendReply;// sendReplyWithError;
						}
						// log login result
						if (null != Database)
						{
							DateTime logout = new DateTime();
							Database.AddConnection(tcp, nxo, (response.Action == NexoNextAction.sendReply), new TimeSpan(0, (int)Database.Settings.DelayBeforeAutoLogout, 0), out logout);
						}
					}
					// if LogoutRequest
					else if (MessageCategoryEnumeration.Logout == item.Category)
					{
						// logout processing, response can't be modified
						response.CanOverride = false;
						NexoSession session = client.LastSession();
						NexoLogout nxo = new NexoLogout();
						nxo.Request = (SaleToPOIRequest)item.Item;
						if (null != session)
						{
							// arrived here the logout message has been accepted, mark the SaleID as not connected
							session.SetDisconnected();
							Activity.RemoveCurrentClient(client);
							response.Action = NexoNextAction.sendReply;
							// log logout result
							if (null != Database)
							{
								DateTime logout = new DateTime();
								Database.SetDisconnected(tcp, nxo, out logout);
							}
						}
						else
						{
							// not already connected
							NexoErrors.GenericEror(response.Response, ResultEnumeration.Failure, ErrorConditionEnumeration.LoggedOut, "Logout request was declined");
							response.Action = NexoNextAction.sendReply;// sendReplyWithError;
						}
					}
					else
					{
						// only need to verify connection
						fConnected = (null != Activity.Clients[client.Key].CurrentConnection && Activity.Clients[client.Key].CurrentConnection.Connected);
						if (!fConnected)
						{
							NexoErrors.NotAllowedForbiddenMessage(response.Response, "Not connected, the message " + msg.Key + " hasn't been processed");
							response.Action = item.ReplyRequired ? NexoNextAction.sendReply /* sendReplyWithError */: NexoNextAction.noReply;
						}
					}
				}
				else
				{
					// the request generated an error
					response.Response = mhex.Response;
					response.Action = item.ReplyRequired ? NexoNextAction.sendReply /* sendReplyWithError */ : NexoNextAction.noReply;
				}
				CLog.Add($"{StreamServer.Description} - Request is {(fOK ? "VALID" : "INVALID")} - Analysed next action: {response.Action}");
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex, "PROCESSING ABORTED");
			}
			return response;
		}
		class RequestResponseType
		{
			public NexoResponseType Response = new NexoResponseType();
			public bool CanOverride = true;
			public NexoNextAction Action;
		}
		/// <summary>
		/// Processing of a reply received by the server (should be a device action)
		/// </summary>
		/// <param name="tcp">TCP settings of the originator of the message</param>
		/// <param name="item">The request item received froom the client</param>
		private RequestResponseType ProcessReply(TcpClient tcp, NexoItem item)
		{
			return null;
			//string xml = item.ToString();
			//CLog.Add("Processing request: " + xml);
			//RequestResponseType response = new RequestResponseType();
			//response.Next = item.ReplyRequired ? NexoNextAction.sendReply : NexoNextAction.noReply;
			//// validate XML against XSD
			//bool fOK = false;
			//bool fConnected = false;
			//try
			//{
			//	// save the message
			//	NexoPartner client = new NexoPartner(tcp, item.Request.MessageHeader);
			//	NexoMessage msg = new NexoMessage(item.Request, xml, true);
			//	if (fOK = Activity.AddClientMessage(client, msg))
			//	{
			//		// determine whether the request is valid or not
			//		NexoRetailerServerMessageHeaderValidator mhex = new NexoRetailerServerMessageHeaderValidator(item.Request.MessageHeader, ServerProtocolVersion);
			//		if (fOK = mhex.IsValid)
			//		{
			//			// if LoginRequest
			//			if (MessageCategoryEnumeration.Login == item.Category)
			//			{
			//				// verify protocol version
			//				if (SupportedProtocolVersions.Contains(mhex.ProtocolVersion))
			//				{
			//					// add the client to the list of connected clients
			//					if (fConnected = Activity.SetConnected(client, true))
			//						response.Next = NexoNextAction.sendReply;
			//					else
			//					{
			//						NexoErrors.GenericEror(response.Response, ResultEnumeration.Failure, ErrorConditionEnumeration.LoggedOut, "Login was declined");
			//						response.Next = NexoNextAction.sendReplyWithError;
			//					}
			//				}
			//				else
			//				{
			//					NexoErrors.UnavailableServiceTooOldProtocolVersion(response.Response, mhex.ProtocolVersion.Value, ServerProtocolVersion.Value);
			//					response.Next = NexoNextAction.sendReplyWithError;
			//				}
			//			}
			//			// if LogoutRequest
			//			else if (MessageCategoryEnumeration.Logout == item.Category)
			//			{
			//				// arrived here the logout message has been accepted, mark the SaleID as not connected
			//				Activity.SetConnected(client, false);
			//				if (fConnected = Activity.Clients[client.Key].CurrentConnection.Connected)
			//				{
			//					NexoErrors.GenericEror(response.Response, ResultEnumeration.Failure, ErrorConditionEnumeration.LoggedOut, "Logout was declined");
			//					response.Next = NexoNextAction.sendReplyWithError;
			//				}
			//			}
			//			else
			//			{
			//				// only need to verify connection
			//				fConnected = Activity.Clients[client.Key].CurrentConnection.Connected;
			//				if (!fConnected)
			//				{
			//					NexoErrors.NotAllowedForbiddenMessage(response.Response, "Not connected, the message " + msg.Key + " hasn't been processed");
			//					response.Next = NexoNextAction.sendReplyWithError;
			//				}
			//			}
			//		}
			//		else
			//		{
			//			// the request generated an error
			//			response.Response = mhex.Response;
			//			response.Next = NexoNextAction.sendReplyWithError;
			//		}
			//	}
			//	else
			//	{
			//		NexoErrors.MessageFormatRepeatedMessage(response.Response, msg.Key);
			//		response.Next = NexoNextAction.sendReplyWithError;
			//	}
			//	CLog.Add($"Request is {(fOK ? "VALID" : "INVALID")} - Next action: {response.Next.ToString()}");
			//}
			//catch (Exception ex)
			//{
			//	CLog.EXCEPT(ex, "PROCESSING ABORTED");
			//	response = null;
			//}
			//return response;
		}
		#endregion
	}
}
