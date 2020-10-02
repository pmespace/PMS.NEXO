using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("D71CE22F-0AA1-4792-9857-864A5E29A2BE")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoAbort
	{
		#region owned
		[DispId(1)]
		AbortRequestType RequestData { get; }
		[DispId(3)]
		string AbortPOIID { get; set; }
		[DispId(4)]
		string AbortSaleID { get; set; }
		[DispId(5)]
		string AbortServiceID { get; set; }
		[DispId(6)]
		string AbortDeviceID { get; set; }
		[DispId(7)]
		MessageCategoryEnumeration AbortMessageCategory { get; set; }
		[DispId(8)]
		string AbortReason { get; set; }
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
	[Guid("01101E72-06B5-47BA-B305-611BEEAF3AE4")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoAbort: NexoService, INexoAbort
	{
		#region constructor
		public NexoAbort() : base(MessageCategoryEnumeration.Abort)
		{
			RequestType = typeof(AbortRequestType);
			RequestItem = new AbortRequestType();
			ReplyType = null;
			ReplyItem = ReplyData;
		}
		#endregion

		#region shared properties
		public AbortRequestType RequestData { get => (AbortRequestType)RequestItem; }
		public object ReplyData { get => Reply.Item; }
		#endregion

		#region request inner properties
		public string AbortPOIID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.POIID);
			set => RequestData.MessageReference.POIID = value;
		}
		public string AbortSaleID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.SaleID);
			set => RequestData.MessageReference.SaleID = value;
		}
		public string AbortServiceID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.ServiceID);
			set => RequestData.MessageReference.ServiceID = value;
		}
		public string AbortDeviceID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.DeviceID);
			set => RequestData.MessageReference.DeviceID = value;
		}
		public MessageCategoryEnumeration AbortMessageCategory
		{
			get => (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), CMisc.Trimmed(RequestData.MessageReference.MessageCategory));
			set => RequestData.MessageReference.MessageCategory = CMisc.GetEnumName(typeof(MessageCategoryEnumeration), value);
		}
		public string AbortReason
		{
			get => CMisc.Trimmed(RequestData.AbortReason);
			set => RequestData.AbortReason = value;
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return null; }
		protected override void SetResponse(ResponseType r) { }
		protected override InternalAction AutoCompleteRequest()
		{
			AbortReason = SetDefaultStringValue(AbortReason, "Unknown error");
			return InternalAction.noError;
		}
		/// <summary>
		/// Set the generic fields from the original request
		/// </summary>
		/// <param name="o"></param>
		public void AbortRequest(NexoObject o)
		{
			AbortMessageCategory = o.MessageCategory;
			AbortServiceID = o.ServiceID;
			AbortDeviceID = o.DeviceID;
			AbortSaleID = o.SaleID;
			AbortPOIID = o.POIID;
		}
		#endregion
	}
}
