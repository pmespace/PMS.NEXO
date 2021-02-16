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
		double RequestRequestedAmount { get; set; }
		[DispId(10)]
		string RequestCurrency { get; set; }
		[DispId(11)]
		string RequestSaleReferenceID { get; set; }

		[DispId(50)]
		string ReplyPOITransactionID { get; set; }
		[DispId(51)]
		string ReplyPOITransactionTimestamp { get; set; }
		[DispId(52)]
		double ReplyAuthorizedAmount { get; set; }
		//double ReplyAuthorizedAmount { get; set; }
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
	[Guid("7EA430E6-824D-4DAC-B512-FA6D76D36FFD")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoPayment : NexoFinancial, INexoFinancial
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
	public class NexoRefund : NexoFinancial, INexoFinancial
	{
		#region constructor
		public NexoRefund()
		{
			RequestData.PaymentData.PaymentType = PaymentTypeEnumeration.Refund.ToString();
		}
		#endregion
	}

	[ComVisible(false)]
	public class NexoFinancial : NexoService, INexoFinancial
	{
		#region constructor
		public NexoFinancial() : base(MessageCategoryEnumeration.Payment)
		{
			RequestItem = new PaymentRequestType();
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
			get => (null != RequestData && null != RequestData.PaymentData ? (PaymentTypeEnumeration)CMisc.GetEnumValue(typeof(PaymentTypeEnumeration), CMisc.Trimmed(RequestData.PaymentData.PaymentType)) : (PaymentTypeEnumeration)NexoValues.None);
			set { if (null != RequestData && null != RequestData.PaymentData) RequestData.PaymentData.PaymentType = CMisc.GetEnumName(typeof(PaymentTypeEnumeration), value); }
		}
		#endregion

		#region request inner properties
		public string RequestSaleTransactionID
		{
			get => (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID ? CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TransactionID) : null);
			set { if (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID) RequestData.SaleData.SaleTransactionID.TransactionID = value; }
		}
		public string RequestSaleTransactionTimestamp
		{
			get => (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID ? CMisc.Trimmed(RequestData.SaleData.SaleTransactionID.TimeStamp) : null);
			set { if (null != RequestData && null != RequestData.SaleData && null != RequestData.SaleData.SaleTransactionID) RequestData.SaleData.SaleTransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; }
		}
		public string RequestOriginalPOITransactionID
		{
			get => (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID ? CMisc.Trimmed(RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TransactionID) : null);
			set { if (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID) RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TransactionID = value; }
		}
		public string RequestOriginalPOITransactionTimestamp
		{
			get => (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID ? CMisc.Trimmed(RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TimeStamp) : null);
			set { if (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction && null != RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID) RequestData.PaymentTransaction.OriginalPOITransaction.POITransactionID.TimeStamp = new NexoISODateTime() { Value = value }.Value; }
		}
		public double RequestRequestedAmount
		{
			get => (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.AmountsReq ? RequestData.PaymentTransaction.AmountsReq.RequestedAmount : 0);
			set { if (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.AmountsReq) RequestData.PaymentTransaction.AmountsReq.RequestedAmount = value; }
		}
		public string RequestCurrency
		{
			get => (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.AmountsReq ? CMisc.Trimmed(RequestData.PaymentTransaction.AmountsReq.Currency) : null);
			set { if (null != RequestData && null != RequestData.PaymentTransaction && null != RequestData.PaymentTransaction.AmountsReq) RequestData.PaymentTransaction.AmountsReq.Currency = new NexoCurrency() { Value = value }.Value; }
		}
		public string RequestSaleReferenceID
		{
			get => (null != RequestData && null != RequestData.SaleData ? CMisc.Trimmed(RequestData.SaleData.SaleReferenceID) : null);
			set { if (null != RequestData && null != RequestData.SaleData) RequestData.SaleData.SaleReferenceID = value; }
		}
		#endregion

		#region reply inner properties
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
		public double ReplyAuthorizedAmount
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.AmountsResp ? ReplyData.PaymentResult.AmountsResp.AuthorizedAmount : 0);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.AmountsResp) ReplyData.PaymentResult.AmountsResp.AuthorizedAmount = value; }
		}
		public PaymentInstrumentTypeEnumeration ReplyPaymentInstrumentType
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData ? (PaymentInstrumentTypeEnumeration)CMisc.GetEnumValue(typeof(PaymentInstrumentTypeEnumeration), CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.PaymentInstrumentType)) : (PaymentInstrumentTypeEnumeration)NexoValues.None);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData) ReplyData.PaymentResult.PaymentInstrumentData.PaymentInstrumentType = CMisc.GetEnumName(typeof(PaymentInstrumentTypeEnumeration), value); }
		}
		public string ReplyPaymentBrand
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData ? CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.CardData.PaymentBrand) : null);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData) ReplyData.PaymentResult.PaymentInstrumentData.CardData.PaymentBrand = value; }
		}
		public string ReplyCardCountryCode
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData ? CMisc.Trimmed(ReplyData.PaymentResult.PaymentInstrumentData.CardData.CardCountryCode) : null);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData) ReplyData.PaymentResult.PaymentInstrumentData.CardData.CardCountryCode = value; }
		}
		public SensitiveCardDataType ReplySensitiveCardData
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData ? ReplyData.PaymentResult.PaymentInstrumentData.CardData.SensitiveCardData : null);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData) ReplyData.PaymentResult.PaymentInstrumentData.CardData.SensitiveCardData = value; }
		}
		public ContentInformationType ReplyProtectedCardData
		{
			get => (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData ? ReplyData.PaymentResult.PaymentInstrumentData.CardData.ProtectedCardData : null);
			set { if (null != ReplyData && null != ReplyData.PaymentResult && null != ReplyData.PaymentResult.PaymentInstrumentData && null != ReplyData.PaymentResult.PaymentInstrumentData.CardData) ReplyData.PaymentResult.PaymentInstrumentData.CardData.ProtectedCardData = value; }
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override void SetReplyFromRequest()
		{
			ReplyData.SaleData.SaleReferenceID = SetDefaultStringValue(ReplyData.SaleData.SaleReferenceID, RequestSaleReferenceID);
			ReplyData.SaleData.SaleTransactionID.TransactionID = SetDefaultStringValue(ReplyData.SaleData.SaleTransactionID.TransactionID, RequestSaleTransactionID);
			ReplyData.SaleData.SaleTransactionID.TimeStamp = SetDefaultStringValue(ReplyData.SaleData.SaleTransactionID.TimeStamp, RequestSaleTransactionTimestamp);
		}
		protected override InternalAction AutoCompleteRequest()
		{
			PaymentType = (PaymentTypeEnumeration)SetDefaultEnumValue(typeof(PaymentTypeEnumeration), PaymentType, PaymentTypeEnumeration.Normal);
			RequestCurrency = SetDefaultStringValue(RequestCurrency, new NexoCurrencyEUR().Value);
			RequestSaleTransactionID = SetDefaultStringValue(RequestSaleTransactionTimestamp, NexoAutoID.ID());
			RequestSaleTransactionTimestamp = SetDefaultStringValue(RequestSaleTransactionTimestamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			//if (null != ReplyData)
			//{
			//	if (null != ReplyData.SaleData)
			//	{
			//		ReplyData.SaleData.SaleReferenceID = RequestSaleReferenceID;
			//		if (null != ReplyData.SaleData.SaleTerminalData)
			//		{
			//			if (null != ReplyData.SaleData.SaleTransactionID)
			//			{
			//				ReplyData.SaleData.SaleTransactionID.TransactionID = RequestSaleTransactionID;
			//				ReplyData.SaleData.SaleTransactionID.TimeStamp = RequestSaleTransactionTimestamp;
			//			}

			//		}
			//	}
			//	if (null != ReplyData.PaymentResult)
			//	{
			//		ReplyData.PaymentResult.PaymentType = CMisc.EnumValueToString(typeof(PaymentTypeEnumeration), PaymentType);
			//	}
			//}


			ReplyData.PaymentResult.PaymentType = CMisc.EnumValueToString(typeof(PaymentTypeEnumeration), PaymentType);

			if (Success)
			{
				ReplyAuthorizedAmount = SetDefaultDoubleValue(ReplyAuthorizedAmount, RequestRequestedAmount);
			}
			else if (Failure)
			{ }
			else if (Partial)
			{
				ReplyAuthorizedAmount = SetDefaultDoubleValue(ReplyAuthorizedAmount, RequestRequestedAmount);
			}

			ReplyPOITransactionID = SetDefaultStringValue(ReplyPOITransactionID, RequestSaleTransactionID, NexoAutoID.ID());
			ReplyPOITransactionTimestamp = SetDefaultStringValue(ReplyPOITransactionTimestamp, RequestSaleTransactionTimestamp, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			return InternalAction.noError;
		}
		#endregion
	}
}
