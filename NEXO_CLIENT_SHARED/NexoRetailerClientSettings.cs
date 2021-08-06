using System.Runtime.InteropServices;
using COMMON;
using NEXO;

namespace NEXO.Client
{
	[Guid("96259F3B-053E-45AF-B616-079CBC11690A")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerClientSettings
	{
		#region INexoRetailerClientSettings
		[DispId(1)]
		bool IsValid { get; }
		[DispId(2)]
		CStreamClientSettings StreamClientSettings { get; set; }
		[DispId(3)]
		CThreadData ThreadData { get; set; }
		[DispId(4)]
		NexoDelegates.OnSentRequestStatusChangedDelegate OnSentRequestStatusChanged { get; set; }
		[DispId(5)]
		NexoDelegates.OnReceivedDelegate OnReceivedRequest { get; set; }
		[DispId(6)]
		NexoDelegates.OnReceivedDelegate OnReceivedReply { get; set; }
		[DispId(7)]
		NexoDelegates.OnReceivedDelegate OnReceivedNotification { get; set; }
		[DispId(8)]
		NexoDelegates.OnSendDelegate OnSend { get; set; }
		[DispId(9)]
		uint WMNexoMessage { get; set; }
		[DispId(10)]
		object Parameters { get; set; }
		[DispId(11)]
		NexoRetailerClientConnectionSettings ConnectionSettings { get; set; }
		#endregion
	}
	[Guid("863D37D5-09A2-4E2B-A2D2-9C5C41017472")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerClientSettings : INexoRetailerClientSettings
	{
		#region properties
		public bool IsValid { get => null != StreamClientSettings && StreamClientSettings.IsValid && (null == ThreadData || ThreadData.IsValid); }// && null != OnReceivedRequest && null != OnReceivedReply && null != OnReceivedNotification; }
		/// <summary>
		/// Settings to reach the server
		/// </summary>
		public CStreamClientSettings StreamClientSettings { get; set; } = null;
		/// <summary>
		/// Thread data settings
		/// </summary>
		public CThreadData ThreadData { get; set; } = null;
		/// <summary>
		/// Functions to call during client thread lifetime
		/// </summary>
		public NexoDelegates.OnSentRequestStatusChangedDelegate OnSentRequestStatusChanged { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedRequest { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedReply { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedNotification { get; set; } = null;
		public NexoDelegates.OnReceivedDelegate OnReceivedIgnoredMessage { get; set; } = null;
		public NexoDelegates.OnSendDelegate OnSend { get; set; } = null;
		/// <summary>
		/// message sent when a Reply is received
		/// NB: wParam is the MessageCategoryEnumeration value
		/// </summary>
		public uint WMNexoMessage
		{
			get => _wmnexomessage;
			set => _wmnexomessage = value;// Win32.IsValidWM(value) ? value : _wmnexomessage;
		}
		private uint _wmnexomessage = WM_NEXO_CLIENT_MESSAGE;
		public const uint WM_NEXO_CLIENT_MESSAGE = 0x781;
		/// <summary>
		/// Parameters passed to the thread that will be passed to the application through the function
		/// </summary>
		public object Parameters { get; set; }
		/// <summary>
		/// Functions that will be called for pre-connection functionnalities
		/// </summary>
		public NexoRetailerClientConnectionSettings ConnectionSettings { get; set; } = null;
		#endregion

		#region methods
		/// <summary>
		/// Create a NexoRetailerServerSettings.
		/// Among the processing methods, 1 must be NULL, 1 must be set
		/// </summary>
		/// <param name="settings">Stream settings to use</param>
		/// <param name="threadData">Thread tools to communicate and identify</param>
		/// <param name="onReceiveRequest">Function called to process any received request</param>
		/// <param name="onReceiveReply">Function called to process any received reply</param>
		/// <param name="onReceiveNotification">Function called to process any notification</param>
		/// <param name="onSend">Function called to inform the application of the reply about to be sent</param>
		/// <param name="onSentRequestStatusChanged">Function called to inform the application a request hasn't received any answer</param>
		/// <param name="onReceivedIgnoredMessage">Function called to inform the application a message has been received but is ignored</param>
		/// <returns>A NexoRetailerServerSettings object</returns>
		public static NexoRetailerClientSettings Prepare(CStreamClientSettings settings,
			CThreadData threadData,
			NexoDelegates.OnReceivedDelegate onReceiveRequest,
			NexoDelegates.OnReceivedDelegate onReceiveReply,
			NexoDelegates.OnReceivedDelegate onReceiveNotification,
			NexoDelegates.OnSendDelegate onSend,
			NexoDelegates.OnSentRequestStatusChangedDelegate onSentRequestStatusChanged,
			NexoDelegates.OnReceivedDelegate onReceivedIgnoredMessage)
		{
			return new NexoRetailerClientSettings()
			{
				StreamClientSettings = settings,
				ThreadData = threadData,
				OnReceivedRequest = onReceiveRequest,
				OnReceivedReply = onReceiveReply,
				OnReceivedNotification = onReceiveNotification,
				OnSend = onSend,
				OnSentRequestStatusChanged = onSentRequestStatusChanged,
				OnReceivedIgnoredMessage = onReceivedIgnoredMessage,
			};
		}
		#endregion
	}

	[Guid("BFEFE83C-FA94-48DB-B7B9-9E1887CB6884")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerClientConnectionSettings
	{
		#region INexoRetailerClientSettings
		[DispId(1)]
		NexoDelegates.OnConnectionRequestDelegate OnConnectionRequest { get; set; }
		[DispId(2)]
		NexoDelegates.OnConnectionReplyDelegate OnConnectionReply { get; set; }
		[DispId(3)]
		int ConnectionTimer { get; set; }
		#endregion
	}
	[Guid("8005B572-3B32-429E-AE02-294C6522F5FE")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerClientConnectionSettings : INexoRetailerClientConnectionSettings
	{
		#region properties
		public NexoDelegates.OnConnectionRequestDelegate OnConnectionRequest { get; set; } = null;
		public NexoDelegates.OnConnectionReplyDelegate OnConnectionReply { get; set; } = null;
		public int ConnectionTimer { get; set; } = 0;
		#endregion
	}
}
