using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("C69EE5BC-630A-4D1F-990B-0D0984E07F08")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoLoyalty
	{
		#region owned
		[DispId(1)]
		LoyaltyRequestType RequestData { get; }
		[DispId(2)]
		LoyaltyResponseType ReplyData { get; }
		[DispId(3)]
		string RequestSaleTransactionID { get; set; }
		[DispId(4)]
		string RequestSaleTransactionTimestamp { get; set; }
		[DispId(5)]
		string RequestOriginalPOITransactionID { get; set; }
		[DispId(6)]
		string RequestOriginalPOITransactionTimestamp { get; set; }
		[DispId(7)]
		string RequestLoyaltyTransactionType { get; set; }

		[DispId(51)]
		string ReplySaleTransactionID { get; set; }
		[DispId(52)]
		string ReplySaleTransactionTimestamp { get; set; }
		[DispId(53)]
		string ReplyPOITransactionID { get; set; }
		[DispId(54)]
		string ReplyPOITransactionTimestamp { get; set; }
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
		#endregion
	}
	[Guid("B1DB0498-3008-4E26-B04D-1833C36147A4")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoLoyalty : NexoService, INexoLoyalty
	{
		#region constructor
		public NexoLoyalty() : base(MessageCategoryEnumeration.Loyalty)
		{
			RequestItem = new LoyaltyRequestType();
			ReplyItem = new LoyaltyResponseType();
		}
		#endregion

		#region shared properties
		public LoyaltyRequestType RequestData { get => (LoyaltyRequestType)RequestItem; }
		public LoyaltyResponseType ReplyData { get => (LoyaltyResponseType)ReplyItem; }
		#endregion

		#region request inner properties
		public string RequestSaleTransactionID
		{
			get => (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID ? CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TransactionID) : null);
			set { if (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID) { RequestData.SaleData.SaleTransactionID.TransactionID = value; ReplySaleTransactionID = RequestSaleTransactionID; } }
		}
		public string RequestSaleTransactionTimestamp
		{
			get => (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID ? CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TimeStamp) : null);
			set { if (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID) { RequestData.SaleData.SaleTransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; ReplySaleTransactionTimestamp = RequestSaleTransactionTimestamp; } }
		}
		public string RequestOriginalPOITransactionID
		{
			get => (null != RequestData && null != RequestData.LoyaltyTransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID ? CMisc.Trimmed(RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID.TransactionID) : null);
			set { if (null != RequestData && null != RequestData.LoyaltyTransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID) RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID.TransactionID = value; }
		}
		public string RequestOriginalPOITransactionTimestamp
		{
			get => (null != RequestData && null != RequestData.LoyaltyTransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID ? CMisc.Trimmed(RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID.TimeStamp) : null);
			set { if (null != RequestData && null != RequestData.LoyaltyTransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction && null != RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID) RequestData.LoyaltyTransaction.OriginalPOITransaction.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; }
		}
		public string RequestLoyaltyTransactionType
		{
			get => (null != RequestData && null != RequestData.LoyaltyTransaction ? CMisc.Trimmed(RequestData.LoyaltyTransaction.LoyaltyTransactionType1) : null);
			set { if (null != RequestData && null != RequestData.LoyaltyTransaction) RequestData.LoyaltyTransaction.LoyaltyTransactionType1 = value; }
		}
		#endregion

		#region reply inner properties
		public string ReplySaleTransactionID
		{
			get => (null != ReplyData && null != ReplyData.SaleData && null != ReplyData.SaleData.SaleTransactionID ? CMisc.Trimmed(ReplyData.SaleData.SaleTransactionID.TransactionID) : null);
			set { if (null != ReplyData && null != ReplyData.SaleData && null != ReplyData.SaleData.SaleTransactionID) ReplyData.SaleData.SaleTransactionID.TransactionID = value; }
		}
		public string ReplySaleTransactionTimestamp
		{
			get => (null != ReplyData && null != ReplyData.SaleData && null != ReplyData.SaleData.SaleTransactionID ? CMisc.Trimmed(ReplyData.SaleData.SaleTransactionID.TimeStamp) : null);
			set { if (null != ReplyData && null != ReplyData.SaleData && null != ReplyData.SaleData.SaleTransactionID) ReplyData.SaleData.SaleTransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; }
		}
		public string ReplyPOITransactionID
		{
			get => (null != ReplyData && null != ReplyData.POIData && null != ReplyData.POIData.POITransactionID ? CMisc.Trimmed(ReplyData.POIData.POITransactionID.TransactionID) : null);
			set { if (null != ReplyData && null != ReplyData.POIData && null != ReplyData.POIData.POITransactionID) ReplyData.POIData.POITransactionID.TransactionID = value; }
		}
		public string ReplyPOITransactionTimestamp
		{
			get => (null != ReplyData && null != ReplyData.POIData && null != ReplyData.POIData.POITransactionID ? CMisc.Trimmed(ReplyData.POIData.POITransactionID.TimeStamp) : null);
			set { if (null != ReplyData && null != ReplyData.POIData && null != ReplyData.POIData.POITransactionID) ReplyData.POIData.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; }
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
		#endregion
	}
}

