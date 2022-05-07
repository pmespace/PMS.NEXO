using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("DBC11F2F-A231-47BB-9CD1-0B36872B6BB4")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoReversal
	{
		#region owned
		[DispId(1)]
		ReversalRequestType RequestData { get; }
		[DispId(2)]
		ReversalResponseType ReplyData { get; }
		[DispId(3)]
		string RequestOriginalPOITransactionID { get; set; }
		[DispId(4)]
		string RequestOriginalPOITransactionTimestamp { get; set; }
		[DispId(5)]
		string RequestSaleReferenceID { get; set; }
		[DispId(6)]
		double RequestReversedAmount { get; set; }
		[DispId(7)]
		ReversalReasonEnumeration RequestReversalReason { get; set; }
		[DispId(8)]
		string ReplyPOITransactionID { get; set; }
		[DispId(9)]
		string ReplyPOITimestamp { get; set; }
		[DispId(10)]
		double ReplyReversedAmount { get; set; }
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

	[Guid("9DF21BBA-CF43-497C-B0AD-54647E3D8918")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoReversal : NexoService, INexoReversal
	{
		#region constructor
		public NexoReversal() : base(MessageCategoryEnumeration.Reversal)
		{
			RequestItem = new ReversalRequestType();
			ReplyItem = new ReversalResponseType();
			RequestReversedAmount = 0;
		}
		#endregion

		#region properties
		public ReversalRequestType RequestData { get => (ReversalRequestType)RequestItem; }
		public ReversalResponseType ReplyData { get => (ReversalResponseType)ReplyItem; }
		#endregion

		#region request inner properties
		public string RequestOriginalPOITransactionID
		{
			get => CMisc.Trimmed(RequestData.OriginalPOITransaction.POITransactionID.TransactionID);
			set => RequestData.OriginalPOITransaction.POITransactionID.TransactionID = value;
		}
		public string RequestOriginalPOITransactionTimestamp
		{
			get => CMisc.Trimmed(RequestData.OriginalPOITransaction.POITransactionID.TimeStamp);
			set => RequestData.OriginalPOITransaction.POITransactionID.TimeStamp = value;
		}
		public string RequestSaleReferenceID
		{
#if RETAILER30
			get => CMisc.Trimmed(RequestData.SaleReferenceID);
			set => RequestData.SaleReferenceID = value;
#else
		get => CMisc.Trimmed(RequestData.SaleData.SaleReferenceID);
		set => RequestData.SaleData.SaleReferenceID = value;
#endif
		}
		public double RequestReversedAmount
		{
			get => RequestData.ReversedAmount;
			set => RequestData.ReversedAmount = value;
		}
		public ReversalReasonEnumeration RequestReversalReason
		{
			get => (ReversalReasonEnumeration)CMisc.GetEnumValue(typeof(ReversalReasonEnumeration), CMisc.Trimmed(RequestData.ReversalReason), NexoValues.None);
			set => RequestData.ReversalReason = CMisc.GetEnumName(typeof(ReversalReasonEnumeration), value);
		}
		#endregion

		#region reply inner properties
		public string ReplyPOITransactionID
		{
			get => CMisc.Trimmed(ReplyData.POIData.POITransactionID.TransactionID);
			set => ReplyData.POIData.POITransactionID.TransactionID = value;
		}
		public string ReplyPOITimestamp
		{
			get => CMisc.Trimmed(ReplyData.POIData.POITransactionID.TimeStamp);
			set => ReplyData.POIData.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value;
		}
		public double ReplyReversedAmount
		{
			get => ReplyData.ReversedAmount;
			set => ReplyData.ReversedAmount = value;
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override InternalAction AutoCompleteRequest()
		{
			ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);

#if RETAILER30
#elif RETAILER31
			RequestData.SaleData.SaleTransactionID.TimeStamp = SetDefaultStringValue(RequestData.SaleData.SaleTransactionID.TimeStamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
#endif

			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			ReplyPOITimestamp = SetDefaultStringValue(ReplyPOITimestamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			return InternalAction.noError;
		}
		#endregion
	}
}
