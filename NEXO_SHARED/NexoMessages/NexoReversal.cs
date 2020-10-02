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
		decimal RequestReversedAmount { get; set; }
		[DispId(7)]
		string RequestReversalReason { get; set; }
		[DispId(8)]
		string ReplyPOITransactionID { get; set; }
		[DispId(9)]
		string ReplyPOITimestamp { get; set; }
		[DispId(10)]
		decimal ReplyReversedAmount { get; set; }
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

	[Guid("9DF21BBA-CF43-497C-B0AD-54647E3D8918")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoReversal: NexoService, INexoReversal
	{
		#region constructor
		public NexoReversal() : base(MessageCategoryEnumeration.Reversal)
		{
			RequestType = typeof(ReversalRequestType);
			RequestItem = new ReversalRequestType();
			ReplyType = typeof(ReversalResponseType);
			ReplyItem = new ReversalResponseType();
			RequestReversedAmount = 0M;
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
			set { RequestData.OriginalPOITransaction.POITransactionID.TransactionID = value; ReplyData.OriginalPOITransaction.POITransactionID.TransactionID = RequestOriginalPOITransactionID; }
		}
		public string RequestOriginalPOITransactionTimestamp
		{
			get => CMisc.Trimmed(RequestData.OriginalPOITransaction.POITransactionID.TimeStamp);
			set { RequestData.OriginalPOITransaction.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; ReplyData.OriginalPOITransaction.POITransactionID.TimeStamp = RequestOriginalPOITransactionTimestamp; }
		}
		public string RequestSaleReferenceID
		{
#if NEXO30
			get => CMisc.Trimmed(RequestData.SaleReferenceID);
			set => RequestData.SaleReferenceID = value;
#else
			get => CMisc.Trimmed(RequestData.SaleData.SaleReferenceID);
			set => RequestData.SaleData.SaleReferenceID = value;
#endif
		}
		public decimal RequestReversedAmount
		{
			get => RequestData.ReversedAmountSpecified ? RequestData.ReversedAmount : 0;
			set => RequestData.ReversedAmount = value;
		}
		public string RequestReversalReason
		{
			get => CMisc.Trimmed(RequestData.ReversalReason);
			set => RequestData.ReversalReason = value;
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
		public decimal ReplyReversedAmount
		{
			get => ReplyData.ReversedAmountSpecified ? ReplyData.ReversedAmount : 0;
			set => ReplyData.ReversedAmount = value;
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override InternalAction AutoCompleteRequest()
		{
			ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);
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
