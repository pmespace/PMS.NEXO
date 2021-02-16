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
		[DispId(13)]
		string ProtocolVersion { get; }

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
	[Guid("FC9002AC-12F5-4611-8DBF-8ADAFFA39236")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoLogin : NexoService, INexoLogin
	{
		#region constructor
		public NexoLogin() : base(MessageCategoryEnumeration.Login)
		{
			RequestItem = new LoginRequestType();
			ReplyItem = new LoginResponseType();
		}
		#endregion

		#region shared properties
		public LoginRequestType RequestData { get => (LoginRequestType)RequestItem; }
		public LoginResponseType ReplyData { get => (LoginResponseType)ReplyItem; }
		#endregion

		#region specific properties
		public string ProtocolVersion
		{
			get => (new NexoProtocolVersion(NexoCurrentVersion.Current.Version)).Value;
		}
		#endregion

		#region request inner properties
		public string RequestManufacturerID
		{
#if NEXO30
			get => (null != RequestData && null != RequestData.SaleSoftware ? CMisc.Trimmed(RequestData.SaleSoftware.ManufacturerID) : null);
			set { if (null != RequestData && null != RequestData.SaleSoftware) RequestData.SaleSoftware.ManufacturerID = value; }
#elif NEXO31
			get => (null != RequestData && null != RequestData.SaleSoftware ? CMisc.Trimmed(RequestData.SaleSoftware.ProviderIdentification) : null);
			set { if (null != RequestData && null != RequestData.SaleSoftware) RequestData.SaleSoftware.ProviderIdentification = value; }
#endif
		}
		public string RequestApplicationName
		{
			get => (null != RequestData && null != RequestData.SaleSoftware ? CMisc.Trimmed(RequestData.SaleSoftware.ApplicationName) : null);
			set { if (null != RequestData && null != RequestData.SaleSoftware) RequestData.SaleSoftware.ApplicationName = value; }
		}
		public string RequestSoftwareVersion
		{
			get => (null != RequestData && null != RequestData.SaleSoftware ? CMisc.Trimmed(RequestData.SaleSoftware.SoftwareVersion) : null);
			set { if (null != RequestData && null != RequestData.SaleSoftware) RequestData.SaleSoftware.SoftwareVersion = value; }
		}
		public string RequestCertificationCode
		{
			get => (null != RequestData && null != RequestData.SaleSoftware ? CMisc.Trimmed(RequestData.SaleSoftware.CertificationCode) : null);
			set { if (null != RequestData && null != RequestData.SaleSoftware) RequestData.SaleSoftware.CertificationCode = value; }
		}
		public string RequestTerminalEnvironment
		{
			//get => (null != RequestData && null != RequestData.SaleTerminalData ? CMisc.Trimmed(RequestData.SaleTerminalData.TerminalEnvironment) : null);
			//set { if (null != RequestData && null != RequestData.SaleTerminalData) RequestData.SaleTerminalData.TerminalEnvironment = value; }
			get => CMisc.Trimmed(RequestData.SaleTerminalData.TerminalEnvironment);
			set => RequestData.SaleTerminalData.TerminalEnvironment = new NexoTerminalEnvironment() { Value = value }.Value;
		}
		public string RequestSaleCapabilities
		{
			//get => (null != RequestData && null != RequestData.SaleTerminalData ? CMisc.Trimmed(RequestData.SaleTerminalData.SaleCapabilities) : null);
			//set { if (null != RequestData && null != RequestData.SaleTerminalData) RequestData.SaleTerminalData.SaleCapabilities = value; }
			get => CMisc.Trimmed(RequestData.SaleTerminalData.SaleCapabilities);
			set => RequestData.SaleTerminalData.SaleCapabilities = new NexoSaleCapabilities() { Value = value }.Value;
		}
		public string RequestOperatorID
		{
			get => (null != RequestData ? CMisc.Trimmed(RequestData.OperatorID) : null);
			set { if (null != RequestData) RequestData.OperatorID = value; }
		}
		public string RequestOperatorLanguage
		{
			get => (null != RequestData ? CMisc.Trimmed(RequestData.OperatorLanguage) : null);
			set { if (null != RequestData) RequestData.OperatorLanguage = value; }
		}
		public string RequestDateTime
		{
			get => (null != RequestData ? CMisc.Trimmed(RequestData.DateTime) : null);
			set { if (null != RequestData) RequestData.DateTime = new NexoISODateTime() { Value = value }.Value; }
		}
		#endregion

		#region reply inner properties
		public string ReplyDateTime
		{
			get => (null != ReplyData && null != ReplyData.POISystemData ? CMisc.Trimmed(ReplyData.POISystemData.DateTime) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData) ReplyData.POISystemData.DateTime = new NexoISODateTime() { Value = value }.Value; }
		}
		public string ReplyApplicationName
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware ? CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ApplicationName) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware) ReplyData.POISystemData.POISoftware.ApplicationName = value; }
		}
		public string ReplyManufacturerID
		{
#if NEXO30
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware ? CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ManufacturerID) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware) ReplyData.POISystemData.POISoftware.ManufacturerID = value; }
#elif NEXO31
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware ? CMisc.Trimmed(ReplyData.POISystemData.POISoftware.ProviderIdentification) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware) ReplyData.POISystemData.POISoftware.ProviderIdentification = value; }
#endif
		}
		public string ReplySoftwareVersion
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware ? CMisc.Trimmed(ReplyData.POISystemData.POISoftware.SoftwareVersion) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware) ReplyData.POISystemData.POISoftware.SoftwareVersion = value; }
		}
		public string ReplyCertificationCode
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware ? CMisc.Trimmed(ReplyData.POISystemData.POISoftware.CertificationCode) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POISoftware) ReplyData.POISystemData.POISoftware.CertificationCode = value; }
		}
		public string ReplyTerminalEnvironment
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData ? CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.TerminalEnvironment) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData) ReplyData.POISystemData.POITerminalData.TerminalEnvironment = value; }
		}
		public string ReplyPOICapabilities
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData ? CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.POICapabilities) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData) ReplyData.POISystemData.POITerminalData.POICapabilities = value; }
		}
		public string ReplyPOISerialNumber
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData ? CMisc.Trimmed(ReplyData.POISystemData.POITerminalData.POISerialNumber) : null);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData) ReplyData.POISystemData.POITerminalData.POISerialNumber = value; }
		}
		public GlobalStatusEnumeration ReplyGlobalStatus
		{
			get => (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POIStatus ? (GlobalStatusEnumeration)CMisc.GetEnumValue(typeof(GlobalStatusEnumeration), CMisc.Trimmed(ReplyData.POISystemData.POIStatus.GlobalStatus)) : (GlobalStatusEnumeration)NexoValues.None);
			set { if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POIStatus) ReplyData.POISystemData.POIStatus.GlobalStatus = CMisc.GetEnumName(typeof(GlobalStatusEnumeration), value); }
		}
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.Response; }
		protected override void SetResponse(ResponseType r) { ReplyData.Response = r; }
		protected override void SetReplyFromRequest()
		{
		}
		protected override InternalAction AutoCompleteRequest()
		{
			Request.MessageHeader.ProtocolVersion = ProtocolVersion;
			RequestApplicationName = SetDefaultStringValue(RequestApplicationName, new NexoApplicationName().DefaultValue);
			RequestCertificationCode = SetDefaultStringValue(RequestCertificationCode, new NexoCertificationCode().DefaultValue);
			RequestDateTime = SetDefaultStringValue(RequestDateTime, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));
			RequestManufacturerID = SetDefaultStringValue(RequestManufacturerID, new NexoManufacturerID().DefaultValue);
			RequestOperatorID = SetDefaultStringValue(RequestOperatorID, new NexoOperatorID().DefaultValue);
			RequestOperatorLanguage = SetDefaultStringValue(RequestOperatorLanguage, new NexoOperatorLanguage().DefaultValue);
			RequestSoftwareVersion = SetDefaultStringValue(RequestSoftwareVersion, new NexoSoftwareVersion().DefaultValue);
			//RequestSaleCapabilities = SetDefaultCluster(RequestSaleCapabilities, new NexoSaleCapabilities());
			//RequestTerminalEnvironment = SetDefaultStringValue(RequestTerminalEnvironment, new NexoTerminalEnvironment().DefaultValue);
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			Reply.MessageHeader.ProtocolVersion = ProtocolVersion;
			if (Success)
			{
				ReplyDateTime = SetDefaultStringValue(ReplyDateTime, NexoISODateTime.CurrentDateTime(Utc, AddMilliseconds));

				ReplyManufacturerID = SetDefaultStringValue(ReplyManufacturerID, new NexoManufacturerID().DefaultValue);
				ReplyApplicationName = SetDefaultStringValue(ReplyApplicationName, new NexoApplicationName().DefaultValue);
				ReplySoftwareVersion = SetDefaultStringValue(ReplySoftwareVersion, new NexoSoftwareVersion().DefaultValue);
				ReplyCertificationCode = SetDefaultStringValue(ReplyCertificationCode, new NexoCertificationCode().DefaultValue);

				ReplyPOICapabilities = null;
				ReplyPOISerialNumber = SetDefaultStringValue(ReplyPOISerialNumber, new NexoPOISerialNumber().DefaultValue);
				ReplyGlobalStatus = (GlobalStatusEnumeration)SetDefaultEnumValue(typeof(GlobalStatusEnumeration), ReplyGlobalStatus, CMisc.GetEnumValue(typeof(GlobalStatusEnumeration), new NexoGlobalStatus().DefaultValue));

				if (null != ReplyData && null != ReplyData.POISystemData && null != ReplyData.POISystemData.POITerminalData)
					ReplyData.POISystemData.POITerminalData.TerminalEnvironment = RequestData.SaleTerminalData.TerminalEnvironment;
			}
			return InternalAction.noError;
		}
		#endregion
	}
}
