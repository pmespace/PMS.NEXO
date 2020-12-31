using System.Runtime.InteropServices;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO.Server
{
	[Guid("0D584C15-C13E-4123-B6A6-57D27C7937D1")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerServerSettings
	{
		#region INexoRetailerServerSettings
		[DispId(1)]
		bool IsValid { get; }
		[DispId(2)]
		object Parameters { get; set; }
		[DispId(3)]
		CThreadData ThreadData { get; set; }
		[DispId(4)]
		CStreamServerSettings Settings { get; set; }
		[DispId(10)]
		NexoDelegates.OnStartDelegate OnStart { get; set; }
		[DispId(11)]
		NexoDelegates.OnReceivedDelegate OnReceivedRequest { get; set; }
		[DispId(12)]
		NexoDelegates.OnReceivedDelegate OnReceivedReply { get; set; }
		[DispId(13)]
		NexoDelegates.OnReceivedDelegate OnReceivedNotification { get; set; }
		[DispId(14)]
		NexoDelegates.OnSendDelegate OnSend { get; set; }
		[DispId(15)]
		NexoDelegates.OnStopDelegate OnStop { get; set; }
		[DispId(16)]
		NexoRetailerServerDatabaseSettings DatabaseSettings { get; set; }
		#endregion
	}
	[Guid("D2737F59-F4EE-4935-9C89-C45667C4D506")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerServerSettings : INexoRetailerServerSettings
	{
		#region constructors
		public NexoRetailerServerSettings() { }
		#endregion

		#region properties
		public bool IsValid
		{
			get => null != Settings && Settings.IsValid
				&& (null == ThreadData || ThreadData.IsValid)
				&& null != OnReceivedRequest && null != OnReceivedReply && null != OnReceivedNotification
				&& null == DatabaseSettings || DatabaseSettings.IsValid();
		}
		public object Parameters { get; set; } = null;
		public CThreadData ThreadData { get; set; } = null;
		public CStreamServerSettings Settings { get; set; } = null;
		/// <summary>
		/// Called before starting processing requests from a client.
		/// This function allows to initialise the server context.
		/// </summary>
		public NexoDelegates.OnStartDelegate OnStart { get; set; } = null;
		/// <summary>
		/// Called when a client connected to the server or disconnected from the server
		/// This function allows to initialise the client context inside the server.
		/// </summary>
		public NexoDelegates.OnConnectDelegate OnConnect { get; set; } = null;
		public NexoDelegates.OnDisconnectDelegate OnDisconnect { get; set; } = null;
		/// <summary>
		/// Called when a message (either request, reply or event) has been received to be processed.
		/// </summary>
		public NexoDelegates.OnReceivedDelegate OnReceivedRequest { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedReply { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedNotification { get; set; } = null;
		/// <summary>
		/// Called when a message (either request, reply or event) has been received to be processed.
		/// </summary>
		public NexoDelegates.OnSendDelegate OnSend { get; set; } = null;
		/// <summary>
		/// Called after the server has received a stop order.
		/// This function allows to clear the server context.
		/// </summary>
		public NexoDelegates.OnStopDelegate OnStop { get; set; } = null;
		/// <summary>
		/// Name of the server
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Settings applicable to the database connection
		/// </summary>
		public NexoRetailerServerDatabaseSettings DatabaseSettings { get; set; } = null;
		#endregion

		#region methods
		/// <summary>
		/// Create a NexoRetailerServerSettings.
		/// Among the processing methods, 1 must be NULL, 1 must be set
		/// </summary>
		/// <param name="settings">Stream settings to use</param>
		/// <param name="threadData">Thread tools to communicate and identify</param>
		/// <param name="onStart">Function called when starting the thread to process requests</param>
		/// <param name="onConnect">Function called when a client connects to the server</param>
		/// <param name="onDisconnect">Function called when a client disconnects from the server</param>
		/// <param name="onReceiveRequest">Function called to process any received request</param>
		/// <param name="onReceiveReply">Function called to process any received reply</param>
		/// <param name="onReceiveNotification">Function called to process any notification</param>
		/// <param name="onSend">Function called to inform the application of the reply about to be sent</param>
		/// <param name="onStop">Function called when stopping the thread to process requests</param>
		/// <param name="databaseSettings">see <see cref="NexoRetailerServerDatabaseSettings"/></param>
		/// <returns>A NexoRetailerServerSettings object</returns>
		public static NexoRetailerServerSettings Prepare(CStreamServerSettings settings, CThreadData threadData, NexoDelegates.OnReceivedDelegate onReceiveRequest, NexoDelegates.OnReceivedDelegate onReceiveReply, NexoDelegates.OnReceivedDelegate onReceiveNotification, NexoDelegates.OnSendDelegate onSend, NexoDelegates.OnStartDelegate onStart, NexoDelegates.OnConnectDelegate onConnect, NexoDelegates.OnDisconnectDelegate onDisconnect, NexoDelegates.OnStopDelegate onStop, NexoRetailerServerDatabaseSettings databaseSettings = null)
		{
			return new NexoRetailerServerSettings()
			{
				Settings = settings,
				ThreadData = threadData,
				OnStart = onStart,
				OnConnect = onConnect,
				OnDisconnect = onDisconnect,
				OnReceivedRequest = onReceiveRequest,
				OnReceivedReply = onReceiveReply,
				OnReceivedNotification = onReceiveNotification,
				OnSend = onSend,
				OnStop = onStop,
				DatabaseSettings = databaseSettings,
			};
		}
		#endregion
	}
}
