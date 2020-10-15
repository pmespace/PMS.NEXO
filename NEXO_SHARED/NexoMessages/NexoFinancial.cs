using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("D649B63E-68DC-41F0-8531-09C6A98DAC6E")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoFinancial
	{
		#region owned
		[DispId(1)]
		PaymentRequestType RequestData { get; }
		[DispId(2)]
		PaymentResponseType ReplyData { get; }
		[DispId(5)]
		string RequestSaleTransactionID { get; set; }
		[DispId(6)]
		string RequestSaleTransactionTimestamp { get; set; }
		[DispId(7)]
		string RequestOriginalPOITransactionID { get; set; }
		[DispId(8)]
		string RequestOriginalPOITransactionTimestamp { get; set; }
		[DispId(9)]
		decimal RequestRequestedAmount { get; set; }
		[DispId(10)]
		string RequestCurrency { get; set; }

		[DispId(50)]
		string ReplyPOITransactionID { get; set; }
		[DispId(51)]
		string ReplyPOITransactionTimestamp { get; set; }
		[DispId(52)]
		decimal ReplyAuthorizedAmount { get; set; }
		[DispId(53)]
		PaymentInstrumentTypeEnumeration ReplyPaymentInstrumentType { get; set; }
		[DispId(54)]
		string ReplyPaymentBrand { get; set; }
		[DispId(55)]
		string ReplyCardCountryCode { get; set; }
		[DispId(56)]
		SensitiveCardDataType ReplySensitiveCardData { get; set; }
		[DispId(57)]
		ContentInformationType ReplyProtectedCardData { get; set; }

		[DispId(500)]
		bool Accepted { get; }
		[DispId(501)]
		PaymentTypeEnumeration PaymentType { get; }
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
		[DispId(10053)]
		bool Unknown { get; }

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
	[Guid("7EA430E6-824D-4DAC-B512-FA6D76D36FFD")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoPayment: NexoFinancial, INexoFinancial
	{
		#region constructor
		public NexoPayment()
		{
			RequestData.PaymentData.PaymentType = PaymentTypeEnumeration.Normal.ToString();
		}
		#endregion
	}
	[Guid("5C61E8A0-651D-4F96-94BB-942BF557FD10")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRefund: NexoFinancial, INexoFinancial
	{
		#region constructor
		public NexoRefund()
		{
			RequestData.PaymentData.PaymentType = PaymentTypeEnumeration.Refund.ToString();
		}
		#endregion
	}

	[ComVisible(false)]
	public class NexoFinancial: NexoService, INexoFinancial
	{
		#region constructor
		public NexoFinancial() : base(MessageCategoryEnumeration.Payment)
		{
			RequestType = typeof(PaymentRequestType);
			RequestItem = new PaymentRequestType();
			ReplyType = typeof(PaymentResponseType);
			ReplyItem = new PaymentResponseType();
		}
		#endregion

		#region shared  properties
		private const int ENTRY_MODE_MIN = 1;
		public PaymentRequestType RequestData { get => (PaymentRequestType)RequestItem; }
		public PaymentResponseType ReplyData { get => (PaymentResponseType)ReplyItem; }
		#endregion

		#region common properties
		public bool Accepted { get => Success; }
		public PaymentTypeEnumeration PaymentType
		{
			get => (PaymentTypeEnumeration)CMisc.GetEnumValue(typeof(PaymentTypeEnumeration), CMisc.Trimmed(RequestData.PaymentData.PaymentType));
			set => RequestData.PaymentData.PaymentType = CMisc.GetEnumName(typeof(PaymentTypeEnumeration), value);
		}
		#endregion

		#region request inner properties
		public string RequestSaleTransactionID
		{
			get => CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TransactionID);
			set { RequestData.SaleData.SaleTransactionID.TransactionID = value; ReplyData.SaleData.SaleTransactionID.TransactionID = RequestSaleTransactionID; }
		}
		public string RequestSaleTransactionTimestamp
		{
			get => CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TimeStamp);
			set { RequestData.SaleData.SaleTransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; ReplyData.SaleData.SaleTransactionID.TimeStamp = RequestSaleTransactionTimestamp; }
		}
		public string RequestOriginalPOITransactionID
		{
			get => CMisc.Trimmed(RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TransactionID);
			set => RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TransactionID = value;
		}
		public string RequestOriginalPOITransactionTimestamp
		{
			get => CMisc.Trimmed(RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TimeStamp);
			set => RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value;
		}
		public decimal RequestRequestedAmount
		{
			get => RequestData.PaymentTransaction.AmountsReq.RequestedAmount;
			set => RequestData.PaymentTransaction.AmountsReq.RequestedAmount = value;
		}
		public string RequestCurrency
		{
			get => CMisc.Trimmed(RequestData.PaymentTransaction.AmountsReq.Currency);
			set => RequestData.PaymentTransaction.AmountsReq.Currency = new NexoCurrency() { Value = value }.Value;
		}
		#endregion

		#region reply inner properties
		public string ReplyPOITransactionID
		{
			get => CMisc.Trimmed(ReplyData.POIData.POITransactionID.TransactionID);
			set => ReplyData.POIData.POITransactionID.TransactionID = value;
		}
		public string ReplyPOITransactionTimestamp
		{
			get => CMisc.Trimmed(ReplyData.POIData.POITransactionID.TimeStamp);
			set => ReplyData.POIData.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value;
		}
		public decimal ReplyAuthorizedAmount
		{
			get => ReplyData.PaymentResult.AmountsResp.AuthorizedAmount;
			set => ReplyData.PaymentResult.AmountsResp.AuthorizedAmount = value;
		}
		public PaymentInstrumentTypeEnumeration ReplyPaymentInstrumentType
		{
			get => (PaymentInstrumentTypeEnumeration)CMisc.GetEnumValue(typeof(PaymentInstrumentTypeEnumeration), CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.PaymentInstrumentType));
			set => ReplyData.PaymentResult.PaymentInstrumentData.PaymentInstrumentType = CMisc.GetEnumName(typeof(PaymentInstrumentTypeEnumeration), value);
		}
		public string ReplyPaymentBrand
		{
			get => CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.CardData.PaymentBrand);
			set => ReplyData.PaymentResult.PaymentInstrumentData.CardData.PaymentBrand = value;
		}
		public string ReplyCardCountryCode
		{
			get => CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.CardData.CardCountryCode);
			set => ReplyData.PaymentResult.PaymentInstrumentData.CardData.CardCountryCode = value;
		}
		public SensitiveCardDataType ReplySensitiveCardData
		{
			get => ReplyData.PaymentResult.PaymentInstrumentData.CardData.SensitiveCardData;
			set => ReplyData.PaymentResult.PaymentInstrumentData.CardData.SensitiveCardData = value;
		}
		public ContentInformationType ReplyProtectedCardData
		{
			get => ReplyData.PaymentResult.PaymentInstrumentData.CardData.ProtectedCardData;
			set => ReplyData.PaymentResult.PaymentInstrumentData.CardData.ProtectedCardData = value;
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override void SetReplyFromRequest()
		{
			RequestSaleTransactionID = RequestSaleTransactionID;
			RequestSaleTransactionTimestamp = RequestSaleTransactionTimestamp;
		}
		protected override InternalAction AutoCompleteRequest()
		{
			RequestCurrency = SetDefaultStringValue(RequestCurrency, new NexoCurrencyEUR().Value);
			RequestSaleTransactionID = SetDefaultStringValue(RequestSaleTransactionTimestamp, NexoAutoID.ID());
			RequestSaleTransactionTimestamp = SetDefaultStringValue(RequestSaleTransactionTimestamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			ReplyPOITransactionID = SetDefaultStringValue(ReplyPOITransactionID, RequestSaleTransactionID, NexoAutoID.ID());
			ReplyPOITransactionTimestamp = SetDefaultStringValue(ReplyPOITransactionTimestamp, RequestSaleTransactionTimestamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			return InternalAction.noError;
		}
		#endregion
	}
}
