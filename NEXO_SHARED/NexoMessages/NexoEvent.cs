using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("389CD3D9-3950-4A61-B90E-BC9EB85E0008")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoEvent
	{
		#region owned
		[DispId(1)]
		EventNotificationType RequestData { get; }
		[DispId(2)]
		string EventTimestamp { get; set; }
		[DispId(3)]
		EventToNotifyEnumeration EventToNotify { get; set; }
		[DispId(4)]
		string EventDetails { get; set; }
		[DispId(5)]
		NexoByteSequence EventRejectedMessage { get; set; }
		[DispId(6)]
		bool EventMaintenanceRequiredFlag { get; set; }
		[DispId(7)]
		string EventCustomerLanguage { get; set; }
		#endregion

		#region inherited properties & methods
		/// <summary>
		/// <see cref="NexoObject"/>
		/// </summary>
		[DispId(10000)]
		SaleToPOIRequest Request { get; }
		[DispId(10001)]
		SaleToPOIResponse Reply { get; }
		[DispId(10002)]
		ResponseType Response { get; }

		[DispId(10101)]
		MessageCategoryEnumeration MessageCategory { get; }
		[DispId(10103)]
		MessageClassEnumeration MessageClass { get; }
		[DispId(10104)]
		string ProtocolVersion { get; set; }
		[DispId(10005)]
		string ServiceID { get; set; }
		[DispId(10006)]
		string DeviceID { get; set; }
		[DispId(10007)]
		string SaleID { get; set; }
		[DispId(10008)]
		string POIID { get; set; }
		[DispId(15009)]
		bool AddMilliseconds { get; set; }
		[DispId(15010)]
		bool Utc { get; set; }

		[DispId(10050)]
		bool Success { get; }
		[DispId(10051)]
		bool Failure { get; }
		[DispId(10052)]
		bool Partial { get; }

		[DispId(10060)]
		bool Aborted { get; }
		[DispId(10061)]
		bool Busy { get; }
		[DispId(10062)]
		bool Cancel { get; }
		[DispId(10063)]
		bool DeviceOut { get; }
		[DispId(10064)]
		bool InsertedCard { get; }
		[DispId(10065)]
		bool InProgress { get; }
		[DispId(10066)]
		bool LoggedOut { get; }
		[DispId(10067)]
		bool MessageFormat { get; }
		[DispId(10068)]
		bool NotAllowed { get; }
		[DispId(10069)]
		bool NotFound { get; }
		[DispId(10070)]
		bool PaymentRestriction { get; }
		[DispId(10071)]
		bool Refusal { get; }
		[DispId(10072)]
		bool UnavailableDevice { get; }
		[DispId(10073)]
		bool UnavailableService { get; }
		[DispId(10074)]
		bool InvalidCard { get; }
		[DispId(10075)]
		bool UnreachableHost { get; }
		[DispId(10076)]
		bool WrongPIN { get; }
		[DispId(10077)]
		bool UnknownError { get; }

		[DispId(10100)]
		string AdditionalResponse { get; }

		/* inherited methods */
		[DispId(11000)]
		string ToString();
		[DispId(11001)]
		string AutoID();
		[DispId(11002)]
		string SetDefaultCluster(string data, NexoCluster cluster);
		[DispId(11003)]
		string SetDefaultStringValue(string data, string defaultValue, string typeDefaultValue = "");
		[DispId(11004)]
		string CopyRequestStringValue(string data, string requestValue);
		[DispId(11005)]
		DateTime SetDefaultDateTime(DateTime dt, bool utc = false);
		[DispId(11006)]
		NexoISODateTime SetDefaultDateTime(NexoISODateTime dt, string defaultValue);
		[DispId(11007)]
		NexoCurrency SetDefaultCurrency(NexoCurrency currency, string defaultValue);

		/// <summary>
		/// <see cref="NexoRetailer"/>
		/// </summary>
		[DispId(15000)]
		bool SendWithErrors { get; set; }
		[DispId(15001)]
		bool SendWithWarnings { get; set; }
		[DispId(15002)]
		int NbErrors { get; }
		[DispId(15003)]
		bool ContainsErrors { get; }
		[DispId(15004)]
		int NbWarnings { get; }
		[DispId(15005)]
		bool ContainsWarnings { get; }
		[DispId(15006)]
		bool ContainsEvents { get; }
		[DispId(15008)]
		bool BOM { get; set; }

		/* inherited methods */
		[DispId(15502)]
		string ErrorsList();
		[DispId(15503)]
		string WarningsList();
		[DispId(15504)]
		string EventsList();
		#endregion
	}
	[Guid("C30F6D21-9370-494D-B7D8-8BE6A945AA07")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoEvent: NexoNotification, INexoEvent
	{
		#region constructor
		public NexoEvent()
		{
			RequestType = typeof(EventNotificationType);
			RequestItem = new EventNotificationType();
			Request.MessageHeader.MessageType = MessageTypeEnumeration.Notification.ToString();
			ReplyType = null;
			ReplyItem = null;
		}
		#endregion

		#region shared properties
		public EventNotificationType RequestData { get => (EventNotificationType)RequestItem; }
		public object ReplyData { get => null; }
		#endregion

		#region request inner properties
		/// <summary>
		/// Fake data provided to avoid crashes if trying to deal with ResponseType
		/// </summary>
		private ResponseType fakeResponse = new ResponseType();
		public string EventTimestamp
		{
			get => CMisc.Trimmed(RequestData.TimeStamp);
			set => RequestData.TimeStamp = new NexoISODateTime() { Value = value }.Value;
		}
		public EventToNotifyEnumeration EventToNotify
		{
			get => (EventToNotifyEnumeration)CMisc.GetEnumValue(typeof(EventToNotifyEnumeration), CMisc.Trimmed(RequestData.EventToNotify));
			set => RequestData.EventToNotify = CMisc.GetEnumName(typeof(EventToNotifyEnumeration), value);
		}
		public string EventDetails
		{
			get => CMisc.Trimmed(RequestData.EventDetails);
			set => RequestData.EventDetails = value;
		}
		public NexoByteSequence EventRejectedMessage
		{
			get => new NexoByteSequence() { Value = RequestData.RejectedMessage };
			set => RequestData.RejectedMessage = value.Value;
		}
		public bool EventMaintenanceRequiredFlag
		{
			get => RequestData.MaintenanceRequiredFlag;
			set => RequestData.MaintenanceRequiredFlag = value;
		}
		public string EventCustomerLanguage
		{
			get => CMisc.Trimmed(RequestData.CustomerLanguage);
			set => RequestData.CustomerLanguage = new NexoISOLanguage2A() { Value = value }.Value;
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return fakeResponse; }
		protected override void SetResponse(ResponseType r) { fakeResponse = r; }
		protected override InternalAction AutoCompleteRequest()
		{
			return InternalAction.abortBySystem;
		}
		protected override InternalAction AutoCompleteReply()
		{
			ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);
			EventTimestamp = SetDefaultStringValue(EventTimestamp, NexoISODateTime.CurrentDateTime());
			return InternalAction.noError;
		}
		#endregion
	}
}
