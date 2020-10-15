using System.Runtime.InteropServices;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	[Guid("529FFD3D-658C-49C5-85A3-66799AAA5E34")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoDeviceInputUpdate
	{
		#region owned
		[DispId(1)]
		InputUpdateType RequestData { get; }
		[DispId(3)]
		string RequestMessageReferenceServiceID { get; set; }
		[DispId(4)]
		string RequestMessageReferenceDeviceID { get; set; }
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
	[Guid("64462157-3AE0-441D-B7E9-71B2B8892A66")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoDeviceInputUpdate: NexoDevice, INexoDeviceInputUpdate
	{
		#region constructor
		public NexoDeviceInputUpdate() : base(MessageCategoryEnumeration.InputUpdate)
		{
			RequestType = typeof(InputUpdateType);
			RequestItem = new InputUpdateType();
			ReplyType = null;
			ReplyItem = null;
		}
		#endregion

		#region shared properties
		public InputUpdateType RequestData { get => (InputUpdateType)RequestItem; }
		public object ReplyData { get => Reply.Item; }
		#endregion

		#region request inner properties
		public string RequestMessageReferenceServiceID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.ServiceID);
			set => RequestData.MessageReference.ServiceID = value;
		}
		public string RequestMessageReferenceDeviceID
		{
			get => CMisc.Trimmed(RequestData.MessageReference.DeviceID);
			set => RequestData.MessageReference.DeviceID = value;
		}
		#endregion

		#region reply inner properties
		#endregion

		#region methods
		protected override ResponseType GetResponse() { return null; }
		protected override void SetResponse(ResponseType r) { }
		protected override InternalAction AutoCompleteRequest()
		{
			DeviceID = SetDefaultStringValue(DeviceID, new NexoID().DefaultValue);
			return InternalAction.noError;
		}
		protected override InternalAction AutoCompleteReply()
		{
			return InternalAction.noError;
		}
		#endregion
	}
}