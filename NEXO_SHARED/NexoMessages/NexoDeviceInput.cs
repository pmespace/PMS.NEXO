using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("2CD13AE4-4DF6-47EC-8487-0BBB017D37ED")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoDeviceInput
	{
		#region owned
		[DispId(1)]
		InputRequestType RequestData { get; }
		[DispId(2)]
		InputResponseType ReplyData { get; }
		[DispId(3)]
		DeviceEnumeration RequestDevice { get; set; }
		[DispId(4)]
		InfoQualifyEnumeration RequestInfoQualify { get; set; }
		[DispId(5)]
		InputCommandEnumeration RequestInputCommand { get; set; }
		[DispId(6)]
		int RequestMaxInputTime { get; set; }
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
	[Guid("AD272143-7CBD-4C8B-A766-EEF8B28197C8")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoDeviceInput : NexoDevice, INexoDeviceInput
	{
		#region constructor
		public NexoDeviceInput() : base(MessageCategoryEnumeration.Input)
		{
			RequestItem = new InputRequestType();
			ReplyItem = new InputResponseType();
		}
		#endregion

		#region shared properties
		public InputRequestType RequestData { get => (InputRequestType)RequestItem; }
		public InputResponseType ReplyData { get => (InputResponseType)ReplyItem; }
		#endregion

		#region request inner properties
		public DeviceEnumeration RequestDevice
		{
			get => (DeviceEnumeration)CMisc.GetEnumValue(typeof(DeviceEnumeration), CMisc.Trimmed(RequestData.InputData.Device), NexoValues.None);
			set => RequestData.InputData.Device = CMisc.GetEnumName(typeof(DeviceEnumeration), value);
		}
		public InfoQualifyEnumeration RequestInfoQualify
		{
			get => (InfoQualifyEnumeration)CMisc.GetEnumValue(typeof(InfoQualifyEnumeration), CMisc.Trimmed(RequestData.InputData.InfoQualify), NexoValues.None);
			set => RequestData.InputData.InfoQualify = CMisc.GetEnumName(typeof(InfoQualifyEnumeration), value);
		}
		public InputCommandEnumeration RequestInputCommand
		{
			get => (InputCommandEnumeration)CMisc.GetEnumValue(typeof(InputCommandEnumeration), CMisc.Trimmed(RequestData.InputData.InputCommand), NexoValues.None);
			set => RequestData.InputData.InputCommand = CMisc.GetEnumName(typeof(InputCommandEnumeration), value);
		}
		public int RequestMaxInputTime
		{
			//get => (int)CMisc.StrToLong(CMisc.Trimmed(RequestData.InputData.MaxInputTime), 0, true);
			//set => RequestData.InputData.MaxInputTime = value;//.ToString();
			get => RequestData.InputData.MaxInputTime;
			set => RequestData.InputData.MaxInputTime = value;
		}
		#endregion

		#region reply inner properties
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return ReplyData.InputResult.Response; }
		protected override void SetResponse(ResponseType r)
		{
			if (null != RequestData.DisplayOutput)
			{
				ReplyData.OutputResult.Device = RequestData.DisplayOutput.Device;
				ReplyData.OutputResult.InfoQualify = RequestData.DisplayOutput.InfoQualify;
				ReplyData.OutputResult.Response = r;
			}
			ReplyData.InputResult.Device = RequestData.InputData.Device;
			ReplyData.InputResult.InfoQualify = RequestData.InputData.InfoQualify;
			ReplyData.InputResult.Response = r;
			//if (ReplyData.InputResult.Response.Result.IsSuccess())
			//{
			//	ReplyData.InputResult.Input.InputCommand = RequestData.InputData.InputCommand;
			//	switch (CMisc.GetEnumValue(typeof(InputCommandEnumeration), ReplyData.InputResult.Input.InputCommand))
			//	{
			//		case InputCommandEnumeration.TextString:
			//		case InputCommandEnumeration.DecimalString:
			//			ReplyData.InputResult.Input.TextInput= = RequestData.InputData.InputCommand;

			//		default:
			//			break;
			//	}
			//}
		}
		protected override void SetReplyFromRequest() { }
		protected override InternalAction AutoCompleteRequest()
		{
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			return InternalAction.noError;
		}
		#endregion
	}
}