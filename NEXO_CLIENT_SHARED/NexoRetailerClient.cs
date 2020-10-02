using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;
using System.Threading;
using System.Collections.Generic;
using NEXO;
using System.Net;
using System.IO;

namespace NEXO.Client
{
	[Guid("006465F7-6122-44C2-BBF1-166B483315E4")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerClientHandle
	{
		#region INexoRetailerClientHandle
		[DispId(1)]
		string XML { get; }
		#endregion
	}
	[Guid("1AD62E2A-7807-46E1-B3E5-69ED82788C7E")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerClientHandle: INexoRetailerClientHandle
	{
		public NexoRetailerClientHandle(string xml, object handle) { XML = xml; Handle = handle; }
		public string XML { get; }
		internal object Handle { get; }
	}

	[Guid("8B1988DB-F6AC-4B87-B874-62C58ED8E95F")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerClient
	{
		#region INexoRetailerClient
		[DispId(1)]
		NexoRetailerClientSettings Settings { get; }
		[DispId(2)]
		string Key { get; }
		[DispId(3)]
		string KeyClient { get; }
		[DispId(4)]
		string KeyServer { get; }
		[DispId(5)]
		int ID { get; }
		[DispId(6)]
		string Name { get; set; }
		[DispId(7)]
		string Description { get; }
		[DispId(8)]
		string SaleID { get; }
		[DispId(9)]
		string POIID { get; }
		[DispId(10)]
		bool Connected { get; }
		[DispId(11)]
		NexoRetailerClientActivity Activity { get; }

		[DispId(100)]
		string ToString();
		[DispId(101)]
		bool Connect(NexoRetailerClientSettings settings);
		[DispId(102)]
		void Disconnect();
		[DispId(103)]
		NexoRetailerClientHandle SendRequest(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT);
		[DispId(104)]
		NexoRetailerClientHandle SendRequest(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT);
		[DispId(105)]
		bool SendReply(NexoObject msg);
		[DispId(106)]
		bool SendReply(SaleToPOIResponse msg);
		[DispId(107)]
		object SendRawRequest(string xml, int timer = CStreamSettings.NO_TIMEOUT);
		#endregion

		#region INexoRetailer
		[DispId(1000)]
		bool SendWithErrors { get; set; }
		[DispId(1001)]
		bool SendWithWarnings { get; set; }
		[DispId(1002)]
		int NbErrors { get; }
		[DispId(1003)]
		bool ContainsErrors { get; }
		[DispId(1004)]
		int NbWarnings { get; }
		[DispId(1005)]
		bool ContainsWarnings { get; }
		[DispId(1006)]
		bool ContainsEvents { get; }
		[DispId(1007)]
		bool BOM { get; set; }
		[DispId(1008)]
		bool LogSerialisationEvents { get; set; }

		[DispId(1100)]
		string ErrorsList();
		[DispId(1102)]
		string WarningsList();
		[DispId(1103)]
		string EventsList();
		#endregion
	}
	[Guid("48D91DB7-8D55-4151-B04D-02985CFCF6DF")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class NexoRetailerClient: NexoRetailer, INexoRetailerClient
	{
		#region constructor
		public NexoRetailerClient() { SaleID = null; POIID = null; }
		public NexoRetailerClient(string saleid, string poiid) { SaleID = saleid; POIID = poiid; }
		#endregion

		#region internal classes
		//public enum ExchangeStatus
		//{
		//	_unknown,
		//	stopped,
		//	received,
		//	timedout,
		//	cancelled,
		//}
		/// <summary>
		/// Describe a request and the response it eventually provoked
		/// This class handles the lifetime of a request
		/// </summary>
		class Exchange
		{
			#region constructor
			public Exchange(NexoItem item, int timer)
			{
				Outgoing = item;
				Timer = (0 == timer ? Timeout.Infinite : timer * CStreamSettings.ONESECOND);
			}
			#endregion

			#region properties
			/// <summary>
			/// Timer to wait for a response
			/// </summary>
			public int Timer { get; }
			/// <summary>
			/// Request to send
			/// </summary>
			public NexoItem Outgoing { get; }
			/// <summary>
			/// The received response
			/// </summary>
			public NexoItem Incoming { get; set; } = null;
			#endregion

			#region methods
			#endregion
		}
		#endregion

		#region public properties
		public NexoRetailerClientSettings Settings { get; private set; } = null;
		/// <summary>
		/// Key to use for a collection
		/// </summary>
		public string Key { get => Connected ? KeyClient + "@" + KeyServer : null; }
		public string KeyClient { get => Connected ? StreamIO.Tcp.Client.LocalEndPoint.ToString() : null; }
		public string KeyServer { get => Connected ? StreamIO.Tcp.Client.RemoteEndPoint.ToString() : null; }
		/// <summary>
		/// The ID which can be used to identify the thread when it ends.
		/// The ID will be returned to the warned window (through a PostMessage), when the thread ends, inside the wParam.
		/// The ID is automatically set using the local port used by the client to connect to a server.
		/// </summary>
		public int ID
		{
			get => _id;
			//set
			//{
			//	if (!Connected)
			//		_id = value;
			//}
		}
		private int _id = 0;
		/// <summary>
		/// Connection's name
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
				if (!Connected)
					_name = value;
			}
		}
		private string _name = null;
		/// <summary>
		/// Description of the thread
		/// </summary>
		public string Description { get => "Client :" + (string.IsNullOrEmpty(Name) ? @"N/A" : Name) + " - ID: " + ID + " - "; }
		/// <summary>
		/// SaleID to use
		/// </summary>
		public string SaleID
		{
			get => _saleid;
			private set => _saleid = Connected ? SaleID : value;
		}
		private string _saleid = null;
		/// <summary>
		/// POI ID to connect to
		/// </summary>
		public string POIID
		{
			get => _poiid;
			private set => _poiid = Connected ? POIID : value;
		}
		private string _poiid = null;
		/// <summary>
		///  indicates whether connected or not
		/// </summary>
		public bool Connected { get; private set; }
		/// <summary>
		/// Activity for that client
		/// </summary>
		public NexoRetailerClientActivity Activity { get; private set; } = new NexoRetailerClientActivity();
		/// <summary>
		/// Response received indicator, true means a response to the request has been received
		/// </summary>
		public bool Received
		{
			get => _received;
			private set
			{
				if (value && !_timedout && !_cancelled)
				{
					ActivateTimeoutTimer = false;
					_received = value;
				}
			}
		}
		private bool _received = false;
		/// <summary>
		/// Timeout indicator, true means a timeout occurred while waiting the response
		/// </summary>
		public bool Timedout
		{
			get => _timedout;
			private set
			{
				if (value && !_received && !_cancelled)
					_timedout = value;
			}
		}
		private bool _timedout = false;
		/// <summary>
		/// Response reception cancelled indicator, true means the operation was cancelled by the caller
		/// </summary>
		public bool Cancelled
		{
			get => _cancelled;
			private set
			{
				if (value && !_received && !_timedout)
					_cancelled = value;
			}
		}
		private bool _cancelled = false;
		/// <summary>
		/// Response still expected indicator, true means a response is still expected, no timeout and no cancellation yet
		/// </summary>
		public bool InProgress { get => null != exchange && !Timedout && !Cancelled && !Received; }
		/// <summary>
		/// timer started when the request is sent.
		/// when elapsed the callback function will set the timeout event
		/// </summary>
		private bool ActivateTimeoutTimer
		{
			get => null != _timeouttimer;
			set
			{
				if (value && null != exchange)
				{
					// cleanup
					if (null != _timeouttimer)
						_timeouttimer.Dispose();
					// start new timer
					_timeouttimer = new Timer(TimerCallback, evtTimeout, exchange.Timer, 0);
				}
				else
				{
					// cleanup
					if (null != _timeouttimer)
						_timeouttimer.Dispose();
					_timeouttimer = null;
				}
			}
		}
		private Timer _timeouttimer = null;
		#endregion

		#region private properties
		/// <summary>
		/// private properties
		/// </summary>
		private object myLock = new object();
		private CThread ReceiverThread = null;
		private CThreadEvents ReceiverEvents = new CThreadEvents();
		private CThread DispatchThread = null;
		private CThreadEvents DispatchEvents = new CThreadEvents();
		private CStreamClientIO StreamIO = null;

		private NexoQueueOfObjectsToApplication receivedMessages = new NexoQueueOfObjectsToApplication();
		private ManualResetEvent evtStopDispatcher = new ManualResetEvent(false);
		private ManualResetEvent evtCancelled = new ManualResetEvent(false);
		private ManualResetEvent evtReceived = new ManualResetEvent(false);
		private ManualResetEvent evtTimeout = new ManualResetEvent(false);
		private Mutex isDisconnectingMutex = new Mutex(false);
		private Exchange exchange
		{
			get => _exchange;
			set
			{
				Received = false;
				Timedout = false;
				Cancelled = false;
				if (null != value)
				{
					_exchange = value;
					ActivateTimeoutTimer = true;
				}
				else
				{
					ActivateTimeoutTimer = false;
				}
			}
		}
		private Exchange _exchange = null;
		#endregion

		#region public methods
		public override string ToString()
		{
			return Key;
		}
		/// <summary>
		/// Connect to the server
		/// </summary>
		/// <param name="settings">All settings</param>
		/// <returns></returns>
		public bool Connect(NexoRetailerClientSettings settings)
		{
			if (!settings.IsValid)
				return false;
			if (Connected)
			{
				if (null != Settings && Settings.StreamClientSettings.FullIP == settings.StreamClientSettings.FullIP)
					return true;
				else
					Disconnect();
			}
			// try to connect
			bool f = false;
			Monitor.Enter(myLock);
			try
			{
				// set no timeout on receive
				if (f = (null != (StreamIO = CStream.Connect(settings.StreamClientSettings))))
				{
					StreamIO.Tcp.ReceiveTimeout = CStreamSettings.NO_TIMEOUT;
					_id = ((IPEndPoint)StreamIO.Tcp.Client.LocalEndPoint).Port;
				}
			}
			catch (Exception) { }
			finally { Monitor.Exit(myLock); }
			if (f)
			{
				// save settings to use
				Settings = settings;
				// start threads
				DispatchThread = new CThread();
				DispatchThread.Name = "[" + StreamIO.Tcp.Client.LocalEndPoint.ToString() + "] CLIENT DISPATCHER";
				DispatchEvents.Reset();
				if (DispatchThread.Start(ThreadDispatch, Settings.ThreadData, Settings, DispatchEvents.Started))
				{
					ReceiverThread = new CThread();
					ReceiverThread.Name = "[" + StreamIO.Tcp.Client.LocalEndPoint.ToString() + "] CLIENT RECEIVER";
					ReceiverEvents.Reset();
					if (ReceiverThread.Start(ThreadReceive, Settings.ThreadData, Settings, ReceiverEvents.Started))
					{
						// everything went right
						return Connected = true;
					}
					else
					{
						CLog.Add(Description + "Failed to start receiver thread", TLog.ERROR);
						// stop the dispatcher
						evtStopDispatcher.Set();
						DispatchEvents.WaitStopped();
						DispatchThread = null;
					}
				}
				else
				{
					CLog.Add(Description + "Failed to start dispatcher thread", TLog.ERROR);
					DispatchThread = null;
				}
				CStream.Disconnect(StreamIO);
				StreamIO = null;
			}
			return false;
		}
		/// <summary>
		/// Disconnect from the server
		/// </summary>
		public void Disconnect()
		{
			if (Connected)
			{
				// diconnect stream
				if (isDisconnectingMutex.WaitOne(0))
				{
					Connected = false;
					// cleanup
					StopReceiverThread();
					StopDispatcherThread();
					CThread.SendNotification(Settings.ThreadData, ID, 0, true);
				}
			}
		}
		/// <summary>
		/// Send a REQUEST
		/// </summary>
		/// <param name="msg">request to send</param>
		/// <param name="timer">timer to wait for a response (in seconds)</param>
		/// <returns>An object if the message has been sent, null otherwise</returns>
		public NexoRetailerClientHandle SendRequest(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT)
		{
			if (Connected && null != msg)
			{
				// set saleid and poiid if already given
				if (!string.IsNullOrEmpty(SaleID))
					msg.POIID = POIID;

				string xml = msg.SerializeAndCompleteRequest();
				if (!string.IsNullOrEmpty(xml))
				{
					// create the new request template
					NexoItem item = new NexoItem(msg.Request);
					// store the request
					if (SendXML(xml, item))
					{
						Monitor.Enter(myLock);
						try
						{
							// save the exchange for later use
							exchange = new Exchange(item, timer);
						}
						catch (Exception ex)
						{
							xml = null;
							exchange = null;
							CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Error sending request" + MessageDescription(xml));
						}
						finally { Monitor.Exit(myLock); }
						return new NexoRetailerClientHandle(xml, exchange);
					}
					else
					{
						CLog.Add(Description + "Error sending request" + MessageDescription(xml), TLog.ERROR);
					}
				}
				CLog.Add(Description + "Invalid request to send" + MessageDescription(xml), TLog.ERROR);
			}
			else
				CLog.Add(Description + "Not connected or invalid request to send", TLog.ERROR);
			return null;
		}
		public NexoRetailerClientHandle SendRequest(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT)
		{
			NexoItem item = new NexoItem(msg);
			if (item.IsValid)
			{
				NexoObject nxo = (NexoObject)NexoItem.AllocateObject(item.Category);
				if (null != nxo)
				{
					nxo.Request = msg;
					return SendRequest(nxo, timer);
				}
			}
			return null;
		}
		/// <summary>
		/// Send a REPLY
		/// </summary>
		/// <param name="msg">response to send</param>
		/// <returns>True if the message has been sent, false otherwise</returns>
		public bool SendReply(NexoObject msg)
		{
			if (Connected && null != msg)
			{
				NexoItem item = new NexoItem(msg.Reply);
				string xml = msg.SerializeAndCompleteReply();
				if (!string.IsNullOrEmpty(xml))
				{
					if (!SendXML(xml, item))
					{
						CLog.Add(Description + "Error sending reply" + MessageDescription(xml), TLog.ERROR);
					}
				}
			}
			return false;
		}
		public bool SendReply(SaleToPOIResponse msg)
		{
			NexoItem item = new NexoItem(msg);
			if (item.IsValid)
			{
				NexoObject nxo = (NexoObject)NexoItem.AllocateObject(item.Category);
				if (null != nxo)
				{
					nxo.Reply = msg;
					return SendReply(nxo);
				}
			}
			return false;
		}
		/// <summary>
		/// Send a REQUEST asynchronously receiving the reply
		/// </summary>
		/// <param name="xml">Requets to send</param>
		/// <param name="timer">timer to wait for a response (in seconds)</param>
		/// <returns>An object if the message has been sent, null otherwise</returns>
		public object SendRawRequest(string xml, int timer = CStreamSettings.NO_TIMEOUT)
		{
			SaleToPOIRequest request = Deserialize<SaleToPOIRequest>(xml);
			return SendRequest(request, timer);
		}
		#endregion

		#region static methods
		/// <summary>
		/// Send request asynchronously within a new thread.
		/// </summary>
		/// <param name="settings">A <see cref="CStreamClientSettings"/> object describing the server to reach</param>
		/// <param name="xml">Requets to send</param>
		/// <param name="replySize">The size of the reply as received</param>
		/// <param name="timeout">True indicates the function ended up witha timeout, false otherwise</param>
		/// <returns>An xml string received as a reply to the sent xml message, null if an error has occurred</returns>
		public static string SendRawRequest(CStreamClientSettings settings, string xml, out int replySize, out bool timeout)
		{
			return CStream.ConnectSendReceive(settings, xml, out replySize, out timeout);
		}
		#endregion

		#region private methods
		/// <summary>
		/// Stops the receiver thread
		/// </summary>
		private void StopReceiverThread()
		{
			// ensure stopping the received thread by closing the communication stream
			Monitor.Enter(myLock);
			try
			{
				try
				{
					if (null != StreamIO)
					{
						// this will stop receiver thread
						CStream.Disconnect(StreamIO);
					}
				}
				catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
				finally { StreamIO = null; }
			}
			catch (Exception) { }
			finally { Monitor.Exit(myLock); }
			// wait for threads to terminate
			ReceiverEvents.WaitStopped();
			Thread.Sleep(1);
			ReceiverThread = null;
		}
		/// <summary>
		/// Stopes the dispatcher thread
		/// </summary>
		private void StopDispatcherThread()
		{
			// signal the dispatcher to stop
			evtStopDispatcher.Set();
			DispatchEvents.WaitStopped();
			Thread.Sleep(1);
			DispatchThread = null;
		}
		/// <summary>
		/// Thread function receiving messages from the server
		/// </summary>
		/// <param name="threadData"><see cref="CThreadData"/></param>
		/// <param name="o">parameters passed to the thread</param>
		/// <returns><see cref="CThread"/></returns>
		private int ThreadReceive(CThreadData threadData, object o)
		{
			NexoRetailerClientSettings nexoRetailerClientSettings = (NexoRetailerClientSettings)o;
			int res = 0;
			string xml;
			ReceiverEvents.SetStarted();
			try
			{
				// start receiving messages from the server
				while (null != (xml = CStream.Receive(StreamIO, out int replySize, out bool timeout)))
				{
					// is it a timeout ?
					if (timeout)
					{
						// that should never happen as reading here is not subject to timeout
						CLog.Add(ReceiverThread.Description + "Timeout receiving threaddata, THAT SHOULD NEVER HAPPEN !", TLog.ERROR);
					}
					else
					{
						// create the message to store for tracing
						NexoAnyMessage anymessage = new NexoAnyMessage(xml);
						Activity.AddReceivedMessage(anymessage);
						// identify the received message
						NexoItem item = new NexoItem(xml);
						if (item.IsValid)
						{
							string messageShortDesc = "Received " + item.Category.ToString() + "/" + item.Type.ToString();
							string messageFullDesc = messageShortDesc + " message" + MessageDescription(xml);
							CLog.Add(ReceiverThread.Description + messageFullDesc);

							// prepare the message to pass to the application
							NexoObjectToProcess toprocess = new NexoObjectToProcess(item);
							toprocess.SuggestedAction = NexoNextAction.nothing;
							// that will carry the event to notify the type of message which has been received
							Monitor.Enter(myLock);
							try
							{
								// *** EVENT, a notification event has been received
								if (item.IsNotification)
								{
									toprocess.SuggestedAction = NexoNextAction.noReply;
									toprocess.CanModifyAction = false;
								}

								// *** REPLY, a reply to a message has been received
								else if (item.IsReply)
								{
									// let's verify whether the reply is the one expected
									if (null != exchange && exchange.Outgoing.MatchesRequest(item))
									{
										Received = true;

										// this is the reply or a previous request, we mark it as being processed
										toprocess.SuggestedAction = NexoNextAction.final;
										// add the original request 
										toprocess.CurrentObject.ResetRequest((SaleToPOIRequest)exchange.Outgoing.Item);
										// dismiss original request
										exchange = null;
									}
									else
									{
										CLog.Add(ReceiverThread.Description + "Received reply not matching last request, message dismissed", TLog.WARNG);
									}
								}

								// *** REQUEST, it can only be a request which has been received
								else if (item.IsRequestValidForClient)
								{
									// next action depends on the message itself
									if (item.ReplyRequired)
										toprocess.SuggestedAction = NexoNextAction.sendReply;
									else
										toprocess.SuggestedAction = NexoNextAction.noReply;
									toprocess.CanModifyAction = false;
								}

								// it can only be an invalid request for a client
								else
								{
									// the message is not passed to the application
									CLog.Add(ReceiverThread.Description + " not valid for receiving by client; message dismised", TLog.WARNG);
									toprocess.CanModifyAction = false;
								}

								// arrived here we must verify what to do with the message (if there's a message)
								if (null != toprocess)// && NexoNextAction.nothing != toprocess.SuggestedAction)
								{
									// store the message inside the queue of received messages to be processed by the caller
									Monitor.Enter(receivedMessages);
									receivedMessages.Enqueue(toprocess);
									Monitor.Exit(receivedMessages);
									evtReceived.Set();
								}
							}
							catch (Exception ex)
							{
								CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
								res = (int)ThreadResult.Exception;
							}
							finally { Monitor.Exit(myLock); }
							anymessage.Processed = toprocess.SuggestedAction != NexoNextAction.nothing;
						}
						else
						{
							// the message is not usable, dismiss it
							CLog.Add(ReceiverThread.Description + "Received invalid message" + MessageDescription(xml), TLog.WARNG);
						}
						// finally store the message
						Activity.AddReceivedMessage(anymessage);
					}
				}
			}
			catch (Exception ex)
			{
				if (ex is IOException)
				{
					res = (int)ThreadResult.OK;
				}
				else
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
					res = (int)ThreadResult.Exception;
				}
			}
			// indicate the thread is over
			ReceiverEvents.SetStopped();
			Disconnect();
			return res;
		}
		/// <summary>
		/// Dispatch received messages to the sale
		/// </summary>
		/// <param name="threadData"><see cref="CThreadData"/></param>
		/// <param name="o">parameters passed to the thread</param>
		/// <returns><see cref="CThread"/></returns>
		private int ThreadDispatch(CThreadData threadData, object o)
		{
			NexoRetailerClientSettings nexoRetailerClientSettings = (NexoRetailerClientSettings)o;
			int res = 0;
			DispatchEvents.SetStarted();
			try
			{
				int index;
				// ORDER OF THESE VARIABLES MUST NOT BE CHANGED or change following test statement as well
				WaitHandle[] handles = { evtStopDispatcher, evtReceived, evtCancelled, evtTimeout };
				bool keepOnRunning = true;
				do
				{
					// wait for an event to signaled
					index = WaitHandle.WaitAny(handles);
					if (evtStopDispatcher == handles[index])
					{
						// terminate the thread
						keepOnRunning = false;
					}
					else
					{
						// a message is ready to process
						// dequeue the older message
						NexoObjectToProcess toprocess = null;
						// reset the event for next time
						((ManualResetEvent)handles[index]).Reset();
						if (evtReceived == handles[index])
						{
							// get the received message
							Monitor.Enter(myLock);
							try
							{
								toprocess = receivedMessages.Dequeue();
							}
							catch (Exception) { toprocess = null; }
							finally { Monitor.Exit(myLock); }
							if (null != toprocess && NexoNextAction.nothing != toprocess.Action)
							{
								// send that message to the caller for information or action
								NexoDelegates.OnReceivedDelegate onReceived = null;
								if (toprocess.Item.IsNotification)
									onReceived = nexoRetailerClientSettings.OnReceivedNotification;
								else if (toprocess.Item.IsRequest)
									onReceived = nexoRetailerClientSettings.OnReceivedRequest;
								else if (toprocess.Item.IsReply)
									onReceived = nexoRetailerClientSettings.OnReceivedReply;
								if (null != onReceived)
								{
									// inform the application of the received message waiting for next step
									onReceived(toprocess.Item.XML, toprocess, StreamIO.Tcp, threadData, o);
									// on return check whether a new message must be sent or not
									switch (toprocess.Action)
									{
										case NexoNextAction.sendReply:
										case NexoNextAction.sendReplyWithError:
											SendReply(toprocess.CurrentObject.Reply);
											break;
										case NexoNextAction.sendRequest:
										case NexoNextAction.sendNotification:
											SendRequest(toprocess.NextObject.Request, toprocess.NextTimer);
											break;
										default:
											if (MessageCategoryEnumeration.Logout == toprocess.Category &&
												toprocess.Item.IsReply &&
												toprocess.CurrentObject.Success)
											{
												CLog.Add(DispatchThread.Description + "Shutting down client connection");
												// received a successfull logout, stop the idspatcher
												evtStopDispatcher.Set();
											}
											break;
									}
								}

							}
							else if (null != toprocess && NexoNextAction.nothing == toprocess.Action)
							{
								if (null != nexoRetailerClientSettings.OnReceivedIgnoredMessage)
									// inform the application of the ignored message 
									nexoRetailerClientSettings.OnReceivedIgnoredMessage(toprocess.Item.XML, toprocess, StreamIO.Tcp, threadData, o);
							}
						}
						else if (evtCancelled == handles[index] || evtTimeout == handles[index])
						{
							Exchange tmp = exchange;
							// the current exchange must be dismissed
							Monitor.Enter(myLock);
							try
							{
								exchange = null;
							}
							catch (Exception) { }
							finally { Monitor.Exit(myLock); }
							// warn the application
							if (null != nexoRetailerClientSettings.OnSentRequestStatusChanged)
							{
								toprocess = new NexoObjectToProcess(tmp.Outgoing);
								nexoRetailerClientSettings.OnSentRequestStatusChanged(tmp.Outgoing.XML, toprocess, evtTimeout == handles[index] ? NexoMessageStatus.timeout : NexoMessageStatus.cancelled, StreamIO.Tcp, threadData, o);
							}
						}
						//else
						//{
						//	// timeout, this should never happen
						//	CLog.Add(DispatchThread.Description + "Unknown system error", TLog.ERROR);
						//}
					}
				} while (keepOnRunning);
				// arrived here the dispatcher has been ordered to stop
				res = (int)ThreadResult.OK;
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				res = (int)ThreadResult.Exception;
			}
			DispatchEvents.SetStopped();
			Disconnect();
			return res;
		}
		/// <summary>
		/// Send any message 
		/// </summary>
		/// <param name="xml">XML message to send</param>
		/// <param name="item">The message informationformat</param>
		/// <returns>true if sent, false optherwise</returns>
		private bool SendXML(string xml, NexoItem item)
		{
			try
			{
				Settings.OnSend?.Invoke(xml, item, StreamIO.Tcp, Settings.ThreadData, Settings.Parameters);
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, Name + " - OnSend generated an exception, sending anyway");
			}
			bool f;
			lock (myLock)
			{
				f = CStream.Send(StreamIO, xml);
			}
			Activity.AddSentMessage(new NexoAnyMessage(xml) { Processed = f });
			return f;
		}
		/// <summary>
		/// Describes an XML message
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		private string MessageDescription(string msg)
		{
			bool f = string.IsNullOrEmpty(msg);
			return " [" + (f ? "0" : msg.Length.ToString()) + " bytes]" + (f ? string.Empty : ": " + msg);
		}
		/// <summary>
		/// Set the event for timeout
		/// </summary>
		/// <param name="state"></param>
		private static void TimerCallback(object state)
		{
			((ManualResetEvent)state).Set();
		}
		#endregion
	}

	[ComVisible(true)]
	public class NexoRetailerClients: Dictionary<string, NexoRetailerClient> { }
}
