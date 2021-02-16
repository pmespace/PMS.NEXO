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
		CStreamServerSettings StreamServerSettings { get; set; }
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
			get => null != StreamServerSettings && StreamServerSettings.IsValid
				&& (null == ThreadData || ThreadData.IsValid)
				&& null != OnReceivedRequest && null != OnReceivedReply && null != OnReceivedNotification
				&& null == DatabaseSettings || DatabaseSettings.IsValid();
		}
		public object Parameters { get; set; } = null;
		public CThreadData ThreadData { get; set; } = null;
		public CStreamServerSettings StreamServerSettings { get; set; } = null;
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
	}
}
