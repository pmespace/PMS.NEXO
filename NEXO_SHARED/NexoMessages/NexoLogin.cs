using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml;
using System;
using COMMON;

namespace NEXO
{
	[Guid("4B77D218-D00F-4C13-9652-F0E9E11F3BF3")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoLogin
	{
		#region owned
		[DispId(1)]
		LoginRequestType RequestData { get; }
		[DispId(2)]
		LoginResponseType ReplyData { get; }

		[DispId(4)]
		string RequestManufacturerID { get; set; }
		[DispId(5)]
		string RequestApplicationName { get; set; }
		[DispId(6)]
		string RequestSoftwareVersion { get; set; }
		[DispId(7)]
		string RequestCertificationCode { get; set; }
		[DispId(8)]
		string RequestTerminalEnvironment { get; set; }
		[DispId(9)]
		string RequestSaleCapabilities { get; set; }
		[DispId(10)]
		string RequestOperatorID { get; set; }
		[DispId(11)]
		string RequestOperatorLanguage { get; set; }
		[DispId(12)]
		string RequestDateTime { get; set; }

		[DispId(50)]
		string ReplyDateTime { get; set; }
		[DispId(51)]
		string ReplyApplicationName { get; set; }
		[DispId(52)]
		string ReplySoftwareVersion { get; set; }
		[DispId(53)]
		string ReplyCertificationCode { get; set; }
		[DispId(54)]
		string ReplyTerminalEnvironment { get; }
		[DispId(55)]
		string ReplyPOICapabilities { get; set; }
		[DispId(56)]
		string ReplyPOISerialNumber { get; set; }
		[DispId(57)]
		GlobalStatusEnumeration ReplyGlobalStatus { get; set; }
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
	[Guid("FC9002AC-12F5-4611-8DBF-8ADAFFA39236")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoLogin: NexoService, INexoLogin
	{
		#region constructor
		public NexoLogin() : base(MessageCategoryEnumeration.Login)
		{
			RequestItem = new LoginRequestType();
			ReplyItem = new LoginResponseType();
			ProtocolVersion = (new NexoProtocolVersion(NexoVersion.Short)).Value;
		}
		#endregion

		#region shared properties
		public LoginRequestType RequestData { get => (LoginRequestType)RequestItem; }
		public LoginResponseType ReplyData { get => (LoginResponseType)ReplyItem; }
		#endregion

		#region request inner properties
		public string RequestManufacturerID
		{
#if NEXO30
			get => CMisc.Trimmed(RequestData.SaleSoftware.ManufacturerID);
			set => RequestData.SaleSoftware.ManufacturerID = value;
#else
			get => CMisc.Trimmed(RequestData.SaleSoftware.ProviderIdentification);
			set => RequestData.SaleSoftware.ProviderIdentification = value;
#endif
		}
		public string RequestApplicationName
		{
			get => CMisc.Trimmed(RequestData.SaleSoftware.ApplicationName);
			set => RequestData.SaleSoftware.ApplicationName = value;
		}
		public string RequestSoftwareVersion
		{
			get => CMisc.Trimmed(RequestData.SaleSoftware.SoftwareVersion);
			set => RequestData.SaleSoftware.SoftwareVersion = value;
		}
		public string RequestCertificationCode
		{
			get => CMisc.Trimmed(RequestData.SaleSoftware.CertificationCode);
			set => RequestData.SaleSoftware.CertificationCode = value;
		}
		public string RequestTerminalEnvironment
		{
			get => CMisc.Trimmed(RequestData.SaleTerminalData.TerminalEnvironment);
			set => RequestData.SaleTerminalData.TerminalEnvironment = value;
		}
		public string RequestSaleCapabilities
		{
			get => CMisc.Trimmed(RequestData.SaleTerminalData.SaleCapabilities);
			set => RequestData.SaleTerminalData.SaleCapabilities = value;
		}
		public string RequestOperatorID
		{
			get => CMisc.Trimmed(RequestData.OperatorID);
			set => RequestData.OperatorID = value;
		}
		public string RequestOperatorLanguage
		{
			get => CMisc.Trimmed(RequestData.OperatorLanguage);
			set => RequestData.OperatorLanguage = value;
		}
		public string RequestDateTime
		{
			get => CMisc.Trimmed(RequestData.DateTime);
			set => RequestData.DateTime = new NexoISODateTime() { Value = value }.Value;
		}
		#endregion

		#region reply inner properties
		public string ReplyDateTime
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.DateTime);
			set => ReplyData.POISystemData.DateTime = new NexoISODateTime() { Value = value }.Value;
		}
		public string ReplyApplicationName
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ApplicationName);
			set => ReplyData.POISystemData.POISoftware.ApplicationName = value;
		}
		public string ReplyManufacturerID
		{
#if NEXO30
			get => CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ManufacturerID);
			set => ReplyData.POISystemData.POISoftware.ManufacturerID = value;
#else
			get => CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ProviderIdentification);
			set => ReplyData.POISystemData.POISoftware.ProviderIdentification = value;
#endif
		}
		public string ReplySoftwareVersion
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POISoftware.SoftwareVersion);
			set => ReplyData.POISystemData.POISoftware.SoftwareVersion = value;
		}
		public string ReplyCertificationCode
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POISoftware.CertificationCode);
			set => ReplyData.POISystemData.POISoftware.CertificationCode = value;
		}
		public string ReplyTerminalEnvironment
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.TerminalEnvironment);
			set => ReplyData.POISystemData.POITerminalData.TerminalEnvironment = value;
		}
		public string ReplyPOICapabilities
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.POICapabilities);
			set => ReplyData.POISystemData.POITerminalData.POICapabilities = value;
		}
		public string ReplyPOISerialNumber
		{
			get => CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.POISerialNumber);
			set => ReplyData.POISystemData.POITerminalData.POISerialNumber = value;
		}
		public GlobalStatusEnumeration ReplyGlobalStatus
		{
			get => (GlobalStatusEnumeration)CMisc.GetEnumValue(typeof(GlobalStatusEnumeration), CMisc.Trimmed(ReplyData.POISystemData.POIStatus.GlobalStatus));
			set => ReplyData.POISystemData.POIStatus.GlobalStatus = CMisc.GetEnumName(typeof(GlobalStatusEnumeration), value);
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override InternalAction AutoCompleteRequest()
		{
			RequestApplicationName = SetDefaultStringValue(RequestApplicationName, new NexoApplicationName().DefaultValue);
			RequestCertificationCode = SetDefaultStringValue(RequestCertificationCode, new NexoCertificationCode().DefaultValue);
			RequestDateTime = SetDefaultStringValue(RequestDateTime, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			RequestManufacturerID = SetDefaultStringValue(RequestManufacturerID, new NexoManufacturerID().DefaultValue);
			RequestOperatorID = SetDefaultStringValue(RequestOperatorID, new NexoOperatorID().DefaultValue);
			RequestOperatorLanguage = SetDefaultStringValue(RequestOperatorLanguage, new NexoOperatorLanguage().DefaultValue);
			//RequestSaleCapabilities = SetDefaultCluster(RequestSaleCapabilities, new NexoSaleCapabilities());
			RequestSoftwareVersion = SetDefaultStringValue(RequestSoftwareVersion, new NexoSoftwareVersion().DefaultValue);
			//RequestTerminalEnvironment = SetDefaultStringValue(RequestTerminalEnvironment, new NexoTerminalEnvironment().DefaultValue);
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			ReplyManufacturerID = SetDefaultStringValue(ReplyManufacturerID, new NexoManufacturerID().DefaultValue);
			ReplyApplicationName = SetDefaultStringValue(ReplyApplicationName, new NexoApplicationName().DefaultValue);
			ReplyCertificationCode = SetDefaultStringValue(ReplyCertificationCode, new NexoCertificationCode().DefaultValue);
			ReplyDateTime = SetDefaultStringValue(ReplyDateTime, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			//ReplyGlobalStatus = SetDefaultStringValue(ReplyGlobalStatus, new NexoGlobalStatus().DefaultValue);
			ReplyPOICapabilities = null;
			ReplyPOISerialNumber = SetDefaultStringValue(ReplyPOISerialNumber, new NexoPOISerialNumber().DefaultValue);
			ReplySoftwareVersion = SetDefaultStringValue(ReplySoftwareVersion, new NexoSoftwareVersion().DefaultValue);
			return InternalAction.noError;
		}
		#endregion
	}
}
