using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("85FADEEB-5156-405B-87EE-54D9AE22E316")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoCardAcquisition
	{
		#region owned
		[DispId(1)]
		CardAcquisitionRequestType RequestData { get; }
		[DispId(2)]
		CardAcquisitionResponseType ReplyData { get; }
		[DispId(3)]
		string RequestSaleTransactionID { get; set; }
		[DispId(4)]
		string RequestSaleTransactionTimestamp { get; set; }

		[DispId(50)]
		string ReplyPOITransactionID { get; set; }
		[DispId(51)]
		string ReplyPOITransactionTimestamp { get; set; }
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
	[Guid("041378C7-7530-40FF-865C-5B2F92661375")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCardAcquisition: NexoService, INexoCardAcquisition
	{
		#region constructor
		public NexoCardAcquisition() : base(MessageCategoryEnumeration.CardAcquisition)
		{
			RequestType = typeof(CardAcquisitionRequestType);
			RequestItem = new CardAcquisitionRequestType();
			ReplyType = typeof(CardAcquisitionResponseType);
			ReplyItem = new CardAcquisitionResponseType();
		}
		#endregion

		#region shared properties
		public CardAcquisitionRequestType RequestData { get => (CardAcquisitionRequestType)RequestItem; }
		public CardAcquisitionResponseType ReplyData { get => (CardAcquisitionResponseType)ReplyItem; }
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
			set { RequestData.SaleData.SaleTransactionID.TimeStamp = value; ReplyData.SaleData.SaleTransactionID.TransactionID = RequestSaleTransactionTimestamp; }
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
			set => ReplyData.POIData.POITransactionID.TimeStamp = value;
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

