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

		#region inherited from NexoObject
		[DispId(10000)]
		SaleToPOIRequest Request { get; }
		[DispId(10001)]
		SaleToPOIResponse Reply { get; }

		[DispId(10010)]
		string SerializedRequest { get; }
		[DispId(10011)]
		string SerializedReply { get; }
		[DispId(10020)]
		ResponseType Response { get; set; }
		[DispId(10030)]
		MessageCategoryEnumeration MessageCategory { get; }
		[DispId(10031)]
		MessageClassEnumeration MessageClass { get; }
		[DispId(10032)]
		bool IsService { get; }
		[DispId(10033)]
		bool IsDevice { get; }
		[DispId(10034)]
		bool IsEvent { get; }
		[DispId(10036)]
		string SaleID { get; set; }
		[DispId(10037)]
		string POIID { get; set; }
		[DispId(10038)]
		string ServiceID { get; set; }
		[DispId(10039)]
		string DeviceID { get; set; }

		[DispId(10050)]
		bool Success { get; }
		[DispId(10051)]
		bool Failure { get; }
		[DispId(10052)]
		bool Partial { get; }
		[DispId(10053)]
		bool Unknown { get; }
		[DispId(10054)]
		bool Aborted { get; }
		[DispId(10055)]
		bool Busy { get; }
		[DispId(10056)]
		bool Cancel { get; }
		[DispId(10057)]
		bool DeviceOut { get; }
		[DispId(10058)]
		bool InsertedCard { get; }
		[DispId(10059)]
		bool InProgress { get; }
		[DispId(10060)]
		bool LoggedOut { get; }
		[DispId(10061)]
		bool MessageFormat { get; }
		[DispId(10062)]
		bool NotAllowed { get; }
		[DispId(10063)]
		bool NotFound { get; }
		[DispId(10064)]
		bool PaymentRestriction { get; }
		[DispId(10065)]
		bool Refusal { get; }
		[DispId(10066)]
		bool UnavailableDevice { get; }
		[DispId(10067)]
		bool UnavailableService { get; }
		[DispId(10068)]
		bool InvalidCard { get; }
		[DispId(10069)]
		bool UnreachableHost { get; }
		[DispId(10070)]
		bool WrongPIN { get; }
		[DispId(10071)]
		bool UnknownError { get; }
		[DispId(10072)]
		ResultEnumeration Result { get; set; }
		[DispId(10073)]
		ErrorConditionEnumeration ErrorCondition { get; set; }
		[DispId(10074)]
		string AdditionalResponse { get; set; }
		[DispId(10075)]
		string ResultAsString { get; }
		[DispId(10076)]
		string ErrorConditionAsString { get; }
		[DispId(10077)]
		bool ResponseIsRequired { get; }

		[DispId(10090)]
		bool AddMilliseconds { get; set; }
		[DispId(10091)]
		bool Utc { get; set; }

		[DispId(11000)]
		string ToString();
		[DispId(11001)]
		string AutoID();
		[DispId(11002)]
		string SetDefaultCluster(string data, NexoCluster cluster);
		[DispId(11003)]
		string SetDefaultStringValue(string data, string defaultValue, string typeDefaultValue = "");
		[DispId(11004)]
		DateTime SetDefaultDateTime(DateTime dt, bool utc = false);
		[DispId(11005)]
		NexoISODateTime SetDefaultDateTime(NexoISODateTime dt, string defaultValue);
		[DispId(11006)]
		string CopyRequestStringValue(string data, string requestValue);
		[DispId(11007)]
		NexoCurrency SetDefaultCurrency(NexoCurrency currency, string defaultValue);
		[DispId(11008)]
		NexoISOLanguage2A SetDefaultLanguage(NexoISOLanguage2A language, string defaultValue);
		[DispId(11009)]
		bool FromItem(NexoItem item);
		#endregion

		#region inherited from NexoRetailer
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
		[DispId(15505)]
		bool IsUsingJson();
		[DispId(15506)]
		void SetUsingJson(bool f = false);
		#endregion
	}
	[Guid("01101E72-06B5-47BA-B305-611BEEAF3AE4")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoAbort : NexoService, INexoAbort
	{
		#region constructor
		public NexoAbort() : base(MessageCategoryEnumeration.Abort)
		{
			RequestItem = new AbortRequestType();
			ReplyItem = null;
		}
		#endregion

		#region shared properties
		public AbortRequestType RequestData { get => (AbortRequestType)RequestItem; }
		public object ReplyData { get => ReplyItem; }
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
			get => (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), CMisc.Trimmed(RequestData.MessageReference.MessageCategory), NexoValues.None);
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
