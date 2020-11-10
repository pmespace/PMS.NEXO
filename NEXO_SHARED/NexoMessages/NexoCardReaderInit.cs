using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("424AC59E-6B02-46F1-97AD-F4DAF1BEBDCE")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoCardReaderInit
	{
		#region owned
		[DispId(1)]
		CardReaderInitRequestType RequestData { get; }
		[DispId(2)]
		CardReaderInitResponseType ReplyData { get; }
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
		[DispId(10035)]
		string ProtocolVersion { get; set; }
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
		string AdditionalResponse { get; }

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
	[Guid("0A1903C6-2989-4D33-AE3E-82ABDACD894F")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCardReaderInit: NexoService, INexoCardReaderInit
	{
		#region constructor
		public NexoCardReaderInit() : base(MessageCategoryEnumeration.CardReaderInit)
		{
			RequestItem = new CardReaderInitRequestType();
			ReplyItem = new CardReaderInitResponseType();
		}
		#endregion

		#region shared properties
		public CardReaderInitRequestType RequestData { get => (CardReaderInitRequestType)RequestItem; }
		public CardReaderInitResponseType ReplyData { get => (CardReaderInitResponseType)ReplyItem; }
		#endregion

		#region request inner properties
		#endregion

		#region reply inner properties
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

