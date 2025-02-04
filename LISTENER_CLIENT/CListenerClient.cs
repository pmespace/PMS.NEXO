﻿using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;
using System.Threading;
using System.Collections.Generic;
using NEXO;
using System.Net;
using System.IO;
using System.ComponentModel.Design;

namespace NEXO.Client
{
	[Guid("983DE188-3D03-4F45-900E-9FA84C798D53")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface IListenerClientHandle
	{
		#region IListenerClientHandle
		[DispId(1)]
		object Msg { get; }
		#endregion
	}
	[Guid("D2F98682-E6AA-4541-AE43-34E701071A6C")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class CListenerClientHandle : IListenerClientHandle
	{
		public CListenerClientHandle(object msg, object handle) { Msg = msg; Handle = handle; }
		public object Msg { get; }
		internal object Handle { get; }
	}

	[Guid("FE5D6890-292C-41CC-A455-C1EFFFAB3EF6")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface IListenerClient
	{
		#region IListenerClient
		[DispId(1)]
		CListenerClientSettings Settings { get; }
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
		CListenerClientActivity Activity { get; }
		[DispId(12)]
		bool Received { get; }
		[DispId(13)]
		bool TimedOut { get; }
		[DispId(14)]
		bool Cancelled { get; }
		[DispId(15)]
		bool Error { get; set; }
		[DispId(16)]
		bool InProgress { get; }
		[DispId(17)]
		bool DisconnectOnLogout { get; set; }
		[DispId(18)]
		bool NoMoreAction { get; }
		[DispId(19)]
		string Outcome { get; }

		[DispId(100)]
		string ToString();
		[DispId(101)]
		bool Connect(CListenerClientSettings settings);
		[DispId(102)]
		void Disconnect();
		[DispId(110)]
		CListenerClientHandle SendRequest(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true);
		[DispId(111)]
		CListenerClientHandle SendRequest(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true);
		[DispId(120)]
		bool SendRequestSync(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true);
		[DispId(121)]
		bool SendRequestSync(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true);
		[DispId(200)]
		bool SendReply(NexoObject msg, CThread thread, bool autoComplete = true);
		[DispId(201)]
		bool SendReply(SaleToPOIResponse reply, SaleToPOIRequest request, CThread thread, bool autoComplete = true);
		[DispId(300)]
		CListenerClientHandle SendRawRequest(string xml, int timer = CStreamSettings.NO_TIMEOUT, bool autoComplete = true);
		[DispId(301)]
		bool SendRawRequestSync(string xml, int timer = CStreamSettings.NO_TIMEOUT, bool autoComplete = true);
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
		[DispId(1104)]
		bool IsUsingJson();
		[DispId(1105)]
		void SetUsingJson(bool f = false);
		#endregion
	}
	[Guid("52DD824E-8200-484E-ABBA-F84CB781FD6F")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public sealed class CListenerClient : NexoRetailer, IListenerClient
	{
		#region constructor
		public CListenerClient() { Initialize() }
		protected virtual Initialize() { }
		#endregion

		#region internal classes
		/// <summary>
		/// Describe a request and the response it eventually provoked
		/// This class handles the lifetime of a request
		/// </summary>
		class Exchange
		{
			#region constructor
			public Exchange(object item, int timer)
			{
				Incoming = null;
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
			public object Outgoing { get; }
			/// <summary>
			/// The received response
			/// </summary>
			public object Incoming { get; set; }
			#endregion

			#region methods
			#endregion
		}
		#endregion

		#region public properties
		/// <summary>
		/// Settings given when connecting to the server
		/// </summary>
		public CListenerClientSettings Settings { get; private set; } = null;
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
		public string Description { get => $"Client :{(string.IsNullOrEmpty(Name) ? @"N/A" : Name)} - ID: {ID}"; }

		/// <summary>
		///  indicates whether connected or not
		/// </summary>
		public bool Connected { get; private set; }
		/// <summary>
		/// Activity for that client
		/// </summary>
		public CListenerClientActivity Activity { get; private set; } = new CListenerClientActivity();
		/// <summary>
		/// Description of the final result
		/// </summary>
		public string Outcome { get; private set; }
		/// <summary>
		/// Response received indicator, true means a response to the request has been received
		/// </summary>
		public bool Received
		{
			get => _received;
			private set
			{
				lock (myLockEvent)
				{
					if (value && !evtFinished.WaitOne(0))// !_timedout && !_cancelled && !_error && !_nomoreaction)
					{
						ActivateTimeoutTimer = false;
						_received = value;
						evtFinished.Set();
					}
				}
			}
		}
		private bool _received = false;
		/// <summary>
		/// No more response to expect, true means the process is over without a response
		/// </summary>
		public bool NoMoreAction
		{
			get => _nomoreaction;
			private set
			{
				lock (myLockEvent)
				{
					if (value && !evtFinished.WaitOne(0))// !_received && !_timedout && !_cancelled && !_error)
					{
						ActivateTimeoutTimer = false;
						_nomoreaction = value;
						evtFinished.Set();
					}
				}
			}
		}
		private bool _nomoreaction = false;
		/// <summary>
		/// Timeout indicator, true means a timeout occurred while waiting the response
		/// </summary>
		public bool TimedOut
		{
			get => _timedout;
			private set
			{
				lock (myLockEvent)
				{
					if (value && !evtFinished.WaitOne(0))//!_received && !_cancelled && !_error && !_nomoreaction)
					{
						_timedout = value;
						evtFinished.Set();
					}
				}
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
				lock (myLockEvent)
				{
					if (value && !evtFinished.WaitOne(0))//!_received && !_timedout && !_error && !_nomoreaction)
					{
						_cancelled = value;
						evtFinished.Set();
					}
				}
			}
		}
		private bool _cancelled = false;
		/// <summary>
		/// Indicates whether the exhange is in error or not
		/// This is the only property the client can manipulate to indicate something went wrong during an exchange and it has to stop
		/// </summary>
		public bool Error
		{
			get => _error;
			set
			{
				lock (myLockEvent)
				{
					if (value && !evtFinished.WaitOne(0))
					{
						_error = value;
						evtFinished.Set();
					}
				}
			}
		}
		private bool _error = false;
		/// <summary>
		/// Response still expected indicator, true means a response is still expected, no timeout and no cancellation yet
		/// </summary>
		public bool InProgress { get => null != exchange && !evtFinished.WaitOne(0) /*!Error && !TimedOut && !Cancelled && !Received && !NoMoreAction*/; }
		/// <summary>
		/// Indicates whether disconnecting or not when receiving a logout acknowledgement
		/// </summary>
		public bool DisconnectOnLogout { get; set; } = false;
		#endregion

		#region private properties
		/// <summary>
		/// private properties
		/// </summary>
		private object myLock = new object();
		private object myLockEvent = new object();
		private CThread ReceiverThread = null;
		private CThreadEvents ReceiverEvents = new CThreadEvents();
		private CThread DispatchThread = null;
		private CThreadEvents DispatchEvents = new CThreadEvents();
		private CStreamClientIO StreamIO = null;

		private QueueOfNexoObjectToProcess receivedMessages = new QueueOfNexoObjectToProcess();
		private AutoResetEvent evtStopDispatcher = new AutoResetEvent(false);
		private AutoResetEvent evtCancelled = new AutoResetEvent(false);
		private AutoResetEvent evtReceived = new AutoResetEvent(false);
		private AutoResetEvent evtTimeout = new AutoResetEvent(false);
		private Mutex isDisconnectingMutex = new Mutex(false);
		private Exchange exchange
		{
			get => _exchange;
			set
			{
				_received = false;
				_timedout = false;
				_cancelled = false;
				if (null != value)
				{
					_exchange = value;
					evtFinished.Reset();
					ActivateTimeoutTimer = true;
				}
				else
				{
					_exchange = value;
					ActivateTimeoutTimer = false;
				}
			}
		}
		private Exchange _exchange = null;
		private virtual object lastRequestedObject { get; set; }
		private ManualResetEvent evtFinished = new ManualResetEvent(false);
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
		public bool Connect(CListenerClientSettings settings)
		{
			if (!settings.IsValid) return false;
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
				if (default != receivedMessages) receivedMessages.Clear();
				// set no timeout on receive
				if (f = (null != (StreamIO = CStream.Connect(settings.StreamClientSettings))))
				{
					StreamIO.Tcp.ReceiveTimeout = Timeout.Infinite;
					_id = ((IPEndPoint)StreamIO.Tcp.Client.LocalEndPoint).Port;
				}
			}
			catch (Exception) { }
			finally { Monitor.Exit(myLock); }
			if (f)
			{
				// verify whether connection is requested or not
				bool fPreConnection = true;
				// is the re a connection requested
				if (null != settings.ConnectionSettings && null != settings.ConnectionSettings.OnConnectionRequest && null != settings.ConnectionSettings.OnConnectionReply)
				{
					CLog.Add($"Initiating connection process");
					fPreConnection = false;
					try
					{
						// that error must be accepted in order to proceed
						settings.StreamClientSettings.AllowedSslErrors = System.Net.Security.SslPolicyErrors.RemoteCertificateNameMismatch;

						// get the connection object
						object o = settings.ConnectionSettings.OnConnectionRequest(settings.StreamClientSettings);
						CLog.Add($"Connection request: {o}", null == o ? TLog.ERROR : TLog.INFOR);
						if (null != o)
						{
							// use the specifc cxonnection timeout if using specific connection settings
							StreamIO.Tcp.ReceiveTimeout = settings.ConnectionSettings.ConnectionTimer * CStreamClientSettings.ONESECOND;

							//fPreConnection = CStream.SendLine(StreamIO, o.ToString());

							// send and receive the connection settings
							string reply = CStream.SendReceiveLine(StreamIO, o.ToString());
							CLog.Add($"Connection reply: {reply}", string.IsNullOrEmpty(reply) ? TLog.ERROR : TLog.INFOR);
							if (!string.IsNullOrEmpty(reply))
							{
								// validate the connection object
								fPreConnection = settings.ConnectionSettings.OnConnectionReply(reply);
								CLog.Add($"Connection result: {fPreConnection}", fPreConnection ? TLog.ERROR : TLog.INFOR);
							}
							else
							{
								CLog.Add($"CONNECTION PROCESS FAILED RETURNING A NULL REQUEST", TLog.ERROR);
							}

							// restore standard receive timeout
							StreamIO.Tcp.ReceiveTimeout = settings.StreamClientSettings.ReceiveTimeout * CStreamClientSettings.ONESECOND;
						}
						else
						{
							CLog.Add($"CONNECTION PROCESS FAILED RETURNING A NULL REQUEST", TLog.ERROR);
						}
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex, "OnConnectionRequest generated an exception");
					}
				}

				// arrived here if check connection status
				if (fPreConnection)
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
							CLog.Add($"{Description} - FAILED TO START RECEIVER THREAD", TLog.ERROR);
							// stop the dispatcher
							evtStopDispatcher.Set();
							DispatchEvents.WaitStopped();
							DispatchThread = null;
						}
					}
					else
					{
						CLog.Add($"{Description} - FAILED TO START DISPATCHER THREAD", TLog.ERROR);
						DispatchThread = null;
					}
				}
				// arrived here it means we must close the connection
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
#if NETFRAMEWORK
					CThread.SendNotification(Settings.ThreadData, ID, 0, true);
#endif
				}
			}
			if (default != receivedMessages) receivedMessages.Clear();
		}
		/// <summary>
		/// Send a REQUEST
		/// </summary>
		/// <param name="msg">request to send</param>
		/// <param name="timer">timer to wait for a response (in seconds)</param>
		/// <param name="autoComplete">true if the message must be auto completed before being sent, false to send it as it is</param>
		/// <returns>An object if the message has been sent, null otherwise</returns>
		public CListenerClientHandle SendRequest(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true)
		{
			//if (Connected && null != msg && !InProgress)
			if (Connected && null != msg)
			{
				// set saleid and poiid if already given
				if (!string.IsNullOrEmpty(SaleID))
					msg.POIID = POIID;

				string xml = (autoComplete ? msg.SerializeAndCompleteRequest() : msg.SerializedRequest);
				if (!string.IsNullOrEmpty(xml))
				{
					// create the new request template
					NexoItem item = new NexoItem(msg.Request);
					// store the request
					if (SendXML(xml, item, null))
					{
						Monitor.Enter(myLock);
						try
						{
							// if the exchanged message implies a reply let's save it, otherwise let's keep the previous reply
							if (item.ReplyRequired && msg.ResponseIsRequired)
							{
								// save the exchange for later use
								exchange = new Exchange(item, timer);
							}
							lastRequestedObject = msg;
						}
						catch (Exception ex)
						{
							xml = null;
							exchange = null;
							lastRequestedObject = null;
							CLog.EXCEPT(ex, $"FATAL ERROR while sending request {MessageDescription(xml)} - Receiving the reponse won't be reported");
						}
						finally { Monitor.Exit(myLock); }
						if (null != exchange)
							return new CListenerClientHandle(xml, exchange);
					}
					else
					{
						CLog.Add($"{Description} - ERROR SENDING REQUEST {MessageDescription(xml)}", TLog.ERROR);
					}
				}
				CLog.Add($"{Description} - INVALID REQUEST TO SEND {MessageDescription(xml)}", TLog.ERROR);
			}
			else
				CLog.Add($"{Description} - NOT CONNECTED OR INVALID REQUEST TO SEND", TLog.ERROR);
			return null;
		}
		public CListenerClientHandle SendRequest(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT, /*CListenerClientSettings settings = null,*/ bool autoComplete = true)
		{
			NexoItem item = new NexoItem(msg);
			if (item.IsValid)
			{
				NexoObject nxo = (NexoObject)NexoItem.AllocateObject(item.Category);
				if (null != nxo)
				{
					nxo.Request = msg;
					return SendRequest(nxo, timer, /*settings,*/ autoComplete);
				}
			}
			return null;
		}
		/// <summary>
		/// Send a request synchronously, returning only when the response has been received
		/// or the transactiion has timedout
		/// or it has been cancelled
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="timer"></param>
		/// <param name="autoComplete">true if the message must be auto completed before being sent, false to send it as it is</param>
		/// <returns></returns>
		public bool SendRequestSync(NexoObject msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true)
		{
			CListenerClientHandle handle = SendRequest(msg, timer, autoComplete);
			if (null != handle)
			{
				try
				{
					// wait response or event
					evtFinished.WaitOne();
					msg.Reply = lastRequestedObject.Reply;
					return true;
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex, "Error waiting synchronous response" + MessageDescription(handle.XML));
				}
			}
			return false;
		}
		public bool SendRequestSync(SaleToPOIRequest msg, int timer = CStreamClientSettings.NO_TIMEOUT, bool autoComplete = true)
		{
			NexoItem item = new NexoItem(msg);
			if (item.IsValid)
			{
				NexoObject nxo = (NexoObject)NexoItem.AllocateObject(item.Category);
				if (null != nxo)
				{
					nxo.Request = msg;
					return SendRequestSync(nxo, timer, autoComplete);
				}
			}
			return false;
		}
		/// <summary>
		/// Send a REPLY
		/// </summary>
		/// <param name="msg">response to send</param>
		/// <param name="thread">CThread currently running, or null if main thread</param>
		/// <param name="autoComplete">true if the message must be auto completed before being sent, false to send it as it is</param>
		/// <returns>True if the message has been sent, false otherwise</returns>
		public bool SendReply(NexoObject msg, CThread thread, bool autoComplete = true)
		{
			if (Connected && null != msg)
			{
				NexoItem item = new NexoItem(msg.Reply);
				string xml = autoComplete ? msg.SerializeAndCompleteReply() : msg.SerializedReply;
				if (!string.IsNullOrEmpty(xml))
				{
					if (!SendXML(xml, item, thread))
					{
						CLog.Add($"{Description} - ERROR SENDING REPLY {MessageDescription(xml)}", TLog.ERROR);
					}
				}
			}
			return false;
		}
		public bool SendReply(SaleToPOIResponse reply, SaleToPOIRequest request, CThread thread, bool autoComplete = true)
		{
			NexoItem item = new NexoItem(reply);
			if (item.IsValid)
			{
				NexoObject nxo = (NexoObject)NexoItem.AllocateObject(item.Category);
				if (null != nxo)
				{
					nxo.Request = request;
					nxo.Reply = reply;
					return SendReply(nxo, thread);
				}
			}
			return false;
		}
		/// <summary>
		/// Send a REQUEST asynchronously receiving the reply
		/// </summary>
		/// <param name="xml">Requets to send</param>
		/// <param name="timer">timer to wait for a response (in seconds)</param>
		/// <param name="autoComplete">true if the message must be auto completed before being sent, false to send it as it is</param>
		/// <returns>An object if the message has been sent, null otherwise</returns>
		public CListenerClientHandle SendRawRequest(string xml, int timer = CStreamSettings.NO_TIMEOUT, bool autoComplete = true)
		{
			//SaleToPOIRequest request = Deserialize<SaleToPOIRequest>(xml);
			SaleToPOIRequest request = DeserializeRequest(xml);
			return SendRequest(request, timer, /*null,*/ autoComplete);
		}
		public bool SendRawRequestSync(string xml, int timer = CStreamSettings.NO_TIMEOUT, bool autoComplete = true)
		{
			//SaleToPOIRequest request = Deserialize<SaleToPOIRequest>(xml);
			SaleToPOIRequest request = DeserializeRequest(xml);
			return SendRequestSync(request, timer, autoComplete);
		}
		#endregion

		#region static methods
		/// <summary>
		/// Send request asynchronously within a new thread.
		/// </summary>
		/// <param name="settings">A <see cref="CStreamClientSettings"/> object describing the server to reach</param>
		/// <param name="xml">Requets to send</param>
		/// <returns>An xml string received as a reply to the sent xml message, null if an error has occurred</returns>
		public static string SendRawRequest(CStreamClientSettings settings, string xml)
		{
			return CStream.ConnectSendReceive(settings, xml);
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
				catch (Exception ex) { CLog.EXCEPT(ex); }
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
		/// <param name="thread"><see cref="CThread"/></param>
		/// <param name="o">parameters passed to the thread</param>
		/// <returns><see cref="CThread"/></returns>
		private int ThreadReceive(CThread thread, object o)
		{
			CListenerClientSettings nexoRetailerClientSettings = (CListenerClientSettings)o;
			int res = 0;
			ReceiverEvents.SetStarted();
			try
			{
				string xml;
				// start receiving messages from the server
				while (default != (xml = CStream.ReceiveAsString(StreamIO)))
				{
					CLog.DEBUG($"{ReceiverThread.Description} received {xml}");

					// create the message to store for tracing
					NexoAnyMessage anymessage = new NexoAnyMessage(xml);
					Activity.AddReceivedMessage(anymessage);
					// identify the received message
					NexoItem item = new NexoItem(xml);
					if (item.IsValid)
					{
						string messageShortDesc = $"Received {item.Category}/{item.Type}";
						string messageFullDesc = $"{messageShortDesc} message {MessageDescription(xml)}";
						CLog.Add($"{ReceiverThread.Description} - {messageFullDesc}");

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
								CLog.DEBUG($"message is notification");
								NexoEvent nxo = toprocess.CurrentObject as NexoEvent;
								switch (nxo.EventToNotify)
								{
									case EventToNotifyEnumeration.Reject:
									case EventToNotifyEnumeration.Abort:
										toprocess.SuggestedAction = NexoNextAction.nothing;
										toprocess.CanModifyAction = false;
										break;
									default:
										toprocess.SuggestedAction = NexoNextAction.noReply;
										toprocess.CanModifyAction = true;
										break;
								}
							}

							// *** REPLY, a reply to a message has been received
							else if (item.IsReply)
							{
								CLog.DEBUG($"message is reply");
								// let's verify whether the reply is the one expected
								if (null != exchange && exchange.Outgoing.MatchesRequest(item))
								{
									CLog.DEBUG($"message matches request");
									// this is the reply or a previous request, we mark it as being processed
									toprocess.SuggestedAction = NexoNextAction.final;
									// add the original request 
									toprocess.CurrentObject.ResetRequest((SaleToPOIRequest)exchange.Outgoing.Item);
									// dismiss original request
									exchange = null;
								}
								else
								{
									CLog.Add($"{ReceiverThread.Description} - Received reply not matching last request; message dismissed", TLog.WARNG);
									toprocess.CanModifyAction = false;
									toprocess.Action = NexoNextAction.nothing;
								}
							}

							// *** REQUEST, it can only be a request which has been received
							else if (item.IsRequestValidForClient)
							{
								CLog.DEBUG($"message is valid request");
								// next action depends on the message itself
								if (item.ReplyRequired && toprocess.CurrentObject.ResponseIsRequired)
									toprocess.SuggestedAction = NexoNextAction.sendReply;
								else
									toprocess.SuggestedAction = NexoNextAction.noReply;
								toprocess.CanModifyAction = false;
							}

							// it can only be an invalid request for a client
							else
							{
								// the message is not passed to the application
								CLog.Add($"{ReceiverThread.Description} - Received invalid request to process; message dismissed", TLog.WARNG);
								toprocess.CanModifyAction = false;
								toprocess.Action = NexoNextAction.nothing;
							}

							// arrived here we must verify what to do with the message (if there's a message)
							if (null != toprocess)// && NexoNextAction.nothing != toprocess.SuggestedAction)
							{
								CLog.DEBUG($"posting {toprocess}");
								// store the message inside the queue of received messages to be processed by the caller
								Monitor.Enter(receivedMessages);
								CLog.TRACE($"{ReceiverThread.Description} - enqueuing message to process {MessageDescription(toprocess.CurrentObject.ToString())}");
								receivedMessages.Enqueue(toprocess);
								CLog.DEBUG($"{ReceiverThread.Description} - {receivedMessages.Count}	items in the queue");
								Monitor.Exit(receivedMessages);
								evtReceived.Set();
							}
						}
						catch (Exception ex)
						{
							CLog.EXCEPT(ex);
							res = (int)ThreadResult.Exception;
						}
						finally { Monitor.Exit(myLock); }
						anymessage.Processed = toprocess.SuggestedAction != NexoNextAction.nothing;
					}
					else
					{
						// the message is not usable, dismiss it
						CLog.Add($"{ReceiverThread.Description} - Received invalid message {MessageDescription(xml)}", TLog.WARNG);
					}
					// finally store the message
					Activity.AddReceivedMessage(anymessage);
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
					Error = true;
					CLog.EXCEPT(ex);
					res = (int)ThreadResult.Exception;
				}
			}
			NoMoreAction = true;
			ReceiverEvents.SetStopped();
			Disconnect();
			return res;
		}
		/// <summary>
		/// Dispatch received messages to the sale
		/// </summary>
		/// <param name="thread"><see cref="CThread"/></param>
		/// <param name="o">parameters passed to the thread</param>
		/// <returns><see cref="CThread"/></returns>
		private int ThreadDispatch(CThread thread, object o)
		{
			CListenerClientSettings nexoRetailerClientSettings = (CListenerClientSettings)o;
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
						Outcome = string.Empty;

						// a message is ready to process
						// dequeue the older message
						NexoObjectToProcess toprocess = null;
						if (evtReceived == handles[index])
						{
							NexoDelegates.OnReceivedDelegate onReceived = null;
							// get the received message
							Monitor.Enter(myLock);
							try
							{
								toprocess = receivedMessages.Dequeue();
								CLog.TRACE($"{DispatchThread.Description} - Message to process {MessageDescription(toprocess.CurrentObject.ToString())}");
								CLog.DEBUG($"{DispatchThread.Description} - dequeuing making {receivedMessages.Count}	items in the queue");
							}
							catch (Exception ex)
							{
								CLog.EXCEPT(ex, "No message will be processed");
								toprocess = null;
								//Error = true;
							}
							finally { Monitor.Exit(myLock); }
							// if an action is to be performed...
							if (!Error && null != toprocess && NexoNextAction.nothing != toprocess.Action)
							{
								// send that message to the caller for information or action
								if (toprocess.Item.IsNotification)
									// receiving a notification (a request) keep standard settings
									onReceived = Settings.OnReceivedNotification;
								else if (toprocess.Item.IsRequest)
									// receiving a request keep standard settings
									onReceived = Settings.OnReceivedRequest;
								else if (toprocess.Item.IsReply)
									// receiving a reply, use adapted settings
									onReceived = Settings.OnReceivedReply;
								if (null != onReceived)
								{
									try
									{
										// inform the application of the received message waiting for next step
										onReceived(toprocess.Item.XML, toprocess, StreamIO?.Tcp, thread, o);
										//Error = toprocess.ActionError;
									}
									catch (Exception ex)
									{
										CLog.EXCEPT(ex, $"{(toprocess.Item.IsReply ? "OnReceivedReply" : toprocess.Item.IsRequest ? "OnReceivedRequest" : "OnReceivedNotification")} exception");
										//Error = true;
									}
								}

								// on return check whether a new message must be sent or not
								switch (toprocess.Action)
								{
									case NexoNextAction.sendReply:
										//case NexoNextAction.sendReplyWithError:
										SendReply(toprocess.CurrentObject.Reply, toprocess.CurrentObject.Request, thread);
										break;
									case NexoNextAction.final:
									case NexoNextAction.sendRequest:
									case NexoNextAction.sendNotification:
										if (NexoNextAction.final == toprocess.SuggestedAction)
										{
											lastRequestedObject.Reply = toprocess.CurrentObject.Reply;
											Received = true;
										}
										// if received message is a Logout success nothing else can happen
										if (MessageCategoryEnumeration.Logout == toprocess.Category &&
											toprocess.Item.IsReply &&
											toprocess.CurrentObject.Success)
										{
											// if disconnect on logout, then let's disconnect
											if (DisconnectOnLogout)
											{
												CLog.TRACE($"{DispatchThread.Description} - Shutting down client connection");
												// received a successfull logout, stop the idspatcher
												evtStopDispatcher.Set();
											}
										}
										// received message wasn't a Logout and a new request is expected to be sent
										else if (NexoNextAction.final != toprocess.Action)
										{
											SendRequest(toprocess.NextObject.Request, toprocess.NextTimer);
										}
										break;
									case NexoNextAction.noReply:
										break;
									default:
										Outcome = "no reply or any additional processing to perform";
										NoMoreAction = true;
										break;
								}
							}
							// no action to perform
							else if (null != toprocess && NexoNextAction.nothing == toprocess.Action)
							{
								onReceived = Settings.OnReceivedIgnoredMessage;
								if (null != onReceived)
									try
									{
										// inform the application of the ignored message 
										onReceived(toprocess.Item.XML, toprocess, StreamIO.Tcp, thread, o);
									}
									catch (Exception ex)
									{
										CLog.EXCEPT(ex, "OnReceivedIgnoredMessage exception");
										//Error = true;
									}
								Outcome = $"received message has been dismissed{(toprocess.Item.IsNotification ? " [received an Event]" : string.Empty)}";
								NoMoreAction = true;
							}
						}
						// timeout or cancel (of a request)
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
							if (null != Settings.OnSentRequestStatusChanged)
							{
								toprocess = new NexoObjectToProcess(tmp.Outgoing);
								try
								{
									Settings.OnSentRequestStatusChanged(tmp.Outgoing.XML, toprocess, evtTimeout == handles[index] ? NexoMessageStatus.timeout : NexoMessageStatus.cancelled, StreamIO.Tcp, thread, o);
								}
								catch (Exception ex)
								{
									CLog.EXCEPT(ex, "OnSentRequestStatusChanged exception");
									//Error = true;
								}
							}
							// indicate which action has occurred
							Cancelled = evtCancelled == handles[index];
							TimedOut = evtTimeout == handles[index];
						}
						//else
						//{
						//	// timeout, this should never happen
						//	CLog.Add(DispatchThread.Description + "UNKNOWN SYSTEM ERROR", TLog.ERROR);
						//}
					}
				} while (keepOnRunning);
				// arrived here the dispatcher has been ordered to stop
				res = (int)ThreadResult.OK;
			}
			catch (Exception ex)
			{
				Error = true;
				CLog.EXCEPT(ex);
				res = (int)ThreadResult.Exception;
			}
			NoMoreAction = true;
			DispatchEvents.SetStopped();
			Disconnect();
			return res;
		}
		/// <summary>
		/// Send any message 
		/// </summary>
		/// <param name="xml">XML message to send</param>
		/// <param name="item">The message informationformat</param>
		/// <param name="thread"><see cref="CThread"/> object being used (if sending from inside a thread)</param>
		/// <returns>true if sent, false optherwise</returns>
		private bool SendXML(string xml, NexoItem item, CThread thread)
		{
			try
			{
				Settings.OnSend?.Invoke(xml, item, StreamIO.Tcp, thread, Settings.ThreadData, Settings.Parameters);
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex, Name + " - OnSend generated an exception, sending anyway");
			}
			bool f;
			CLog.Add($"Sending {MessageDescription(xml)}");
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
			return $"[{(f ? "0" : msg.Length.ToString())} bytes] {(f ? string.Empty : msg)}";
		}
		/// <summary>
		/// Set the event for timeout
		/// </summary>
		/// <param name="state"></param>
		private static void TimerCallback(object state)
		{
			((AutoResetEvent)state).Set();
		}
		#endregion
	}

	[ComVisible(false)]
	public class CListenerClients : Dictionary<string, CListenerClient> { }
}
