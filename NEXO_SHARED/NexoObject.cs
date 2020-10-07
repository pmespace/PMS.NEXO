using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if !NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

using NEXO.Properties;
using COMMON;

namespace NEXO
{
	[Guid("70469D2A-4EFD-4023-82BB-7F6D382A5D83")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoObject
	{
		#region INexoObject
		[DispId(7001)]
		SaleToPOIRequest Request { get; }
		[DispId(7002)]
		SaleToPOIResponse Reply { get; }
		[DispId(7003)]
		object RequestItem { get; }
		[DispId(7004)]
		object ReplyItem { get; }
		[DispId(7005)]
		string SerializedRequest { get; }
		[DispId(7006)]
		string SerializedReply { get; }
		[DispId(7007)]
		ResponseType Response { get; set; }
		[DispId(7008)]
		MessageCategoryEnumeration MessageCategory { get; }
		[DispId(7009)]
		MessageClassEnumeration MessageClass { get; }
		[DispId(7010)]
		bool IsService { get; }
		[DispId(7011)]
		bool IsDevice { get; }
		[DispId(7012)]
		bool IsEvent { get; }
		[DispId(7013)]
		string ProtocolVersion { get; set; }
		[DispId(7014)]
		string SaleID { get; set; }
		[DispId(7015)]
		string POIID { get; set; }
		[DispId(7016)]
		string ServiceID { get; set; }
		[DispId(7017)]
		string DeviceID { get; set; }
		[DispId(7018)]
		bool Success { get; }
		[DispId(7019)]
		bool Failure { get; }
		[DispId(7020)]
		bool Partial { get; }
		[DispId(7021)]
		bool Aborted { get; }
		[DispId(7022)]
		bool Busy { get; }
		[DispId(7023)]
		bool Cancel { get; }
		[DispId(7024)]
		bool DeviceOut { get; }
		[DispId(7025)]
		bool InsertedCard { get; }
		[DispId(7026)]
		bool InProgress { get; }
		[DispId(7027)]
		bool LoggedOut { get; }
		[DispId(7028)]
		bool MessageFormat { get; }
		[DispId(7029)]
		bool NotAllowed { get; }
		[DispId(7030)]
		bool NotFound { get; }
		[DispId(7031)]
		bool PaymentRestriction { get; }
		[DispId(7032)]
		bool Refusal { get; }
		[DispId(7033)]
		bool UnavailableDevice { get; }
		[DispId(7034)]
		bool UnavailableService { get; }
		[DispId(7035)]
		bool InvalidCard { get; }
		[DispId(7036)]
		bool UnreachableHost { get; }
		[DispId(7037)]
		bool WrongPIN { get; }
		[DispId(7038)]
		bool UnknownError { get; }
		[DispId(7039)]
		string AdditionalResponse { get; }

		[DispId(7050)]
		bool AddMilliseconds { get; set; }
		[DispId(7051)]
		bool Utc { get; set; }

		[DispId(7100)]
		string ToString();
		[DispId(7101)]
		string AutoID();
		[DispId(7102)]
		bool RequestFromXml(string xml);
		[DispId(7103)]
		bool ReplyFromXml(string xml);
		[DispId(7104)]
		bool FromItem(NexoItem item);
		[DispId(7105)]
		string SerializeAndCompleteRequest();
		[DispId(7106)]
		string SerializeAndCompleteReply();
		#endregion
	}
	[Guid("667D198F-874E-457B-9641-C43933F336DB")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public abstract class NexoObject: NexoRetailer, INexoObject
	{
		#region constructors
		protected NexoObject(MessageCategoryEnumeration category)
		{
			// prepare request and response objects
			Request = new SaleToPOIRequest();
			Reply = new SaleToPOIResponse();
			Request.MessageHeader = new MessageHeaderType();
			Reply.MessageHeader = new MessageHeaderType();
			Request.SecurityTrailer = null;
			Request.MessageHeader.MessageType = MessageTypeEnumeration.Request.ToString();
			Reply.SecurityTrailer = null;
			Reply.MessageHeader.MessageType = MessageTypeEnumeration.Response.ToString();
			MessageCategory = category;
		}
		#endregion

		#region nexo pure properties
		/// <summary>
		/// Request and Reply messages
		/// </summary>
		public SaleToPOIRequest Request
		{
			get => _request;
			internal set
			{
				_request = value;
				if (null != Reply)
				{
					NexoMessageHeader mh = new NexoMessageHeader(Request.MessageHeader, null);
					Reply.MessageHeader = mh.MessageHeader;
					Reply.MessageHeader.MessageType = MessageTypeEnumeration.Response.ToString();
					SetReplyFromRequest();
				}
			}
		}
		private SaleToPOIRequest _request = null;
		public SaleToPOIResponse Reply { get; internal set; }
		/// <summary>
		/// request and Reply types required for optimisation
		/// </summary>
		public Type RequestType { get; internal set; }
		public Type ReplyType { get; internal set; }
		/// <summary>
		/// access to ietm data
		/// </summary>
		public object RequestItem { get => Request.Item; protected set => Request.Item = value; }
		public object ReplyItem { get => Reply.Item; protected set => Reply.Item = value; }
		/// <summary>
		/// Serialized request and reply
		/// </summary>
		public string SerializedRequest { get => SerializeRequest(); }
		public string SerializedReply { get => SerializeReply(); }
		/// <summary>
		/// The response MessageHeader
		/// </summary>
		public ResponseType Response
		{
			get => null != ReplyItem ? GetResponse() : null;
			set
			{
				if (null != ReplyItem)
				{
					SetResponse(value);
				}
			}
		}
		/// <summary>
		/// The message category to use 
		/// </summary>		
		public MessageCategoryEnumeration MessageCategory
		{
			get => (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), CMisc.Trimmed(Request.MessageHeader.MessageCategory));
			protected set { Request.MessageHeader.MessageCategory = CMisc.GetEnumName(typeof(MessageCategoryEnumeration), value); Reply.MessageHeader.MessageCategory = Request.MessageHeader.MessageCategory; }
		}
		/// <summary>
		/// The message class to use 
		/// </summary>		
		public MessageClassEnumeration MessageClass
		{
			get => (MessageClassEnumeration)CMisc.GetEnumValue(typeof(MessageClassEnumeration), CMisc.Trimmed(Request.MessageHeader.MessageClass));
			internal set { Request.MessageHeader.MessageClass = CMisc.GetEnumName(typeof(MessageClassEnumeration), value); Reply.MessageHeader.MessageClass = Request.MessageHeader.MessageClass; }
		}
		/// <summary>
		/// Indicates the class of the message
		/// </summary>
		public bool IsService { get => MessageClassEnumeration.Service == MessageClass; }
		public bool IsDevice { get => MessageClassEnumeration.Device == MessageClass; }
		public bool IsEvent { get => MessageClassEnumeration.Event == MessageClass; }
		/// <summary>
		/// The protocol to use
		/// </summary>
		public string ProtocolVersion
		{
			get => MessageCategoryEnumeration.Login == MessageCategory ? CMisc.Trimmed(Request.MessageHeader.ProtocolVersion) : null;
			set { Request.MessageHeader.ProtocolVersion = CMisc.Trimmed(value); Reply.MessageHeader.ProtocolVersion = null; }
		}
		/// <summary>
		/// The sale ID. It can be set only once
		/// </summary>
		public string SaleID
		{
			get => CMisc.Trimmed(Request.MessageHeader.SaleID);
			set { Request.MessageHeader.SaleID = CMisc.Trimmed(value); Reply.MessageHeader.SaleID = SaleID; }
		}
		/// <summary>
		/// The POI ID. It can be set only once
		/// </summary>
		public string POIID
		{
			get => CMisc.Trimmed(Request.MessageHeader.POIID);
			set { Request.MessageHeader.POIID = CMisc.Trimmed(value); Reply.MessageHeader.POIID = POIID; }
		}
		/// <summary>
		/// The Service to use
		/// </summary>
		public string ServiceID
		{
			get => CMisc.Trimmed(Request.MessageHeader.ServiceID);
			set { Request.MessageHeader.ServiceID = CMisc.Trimmed(value); Reply.MessageHeader.ServiceID = ServiceID; }
		}
		/// <summary>
		/// The Service to use
		/// </summary>
		public string DeviceID
		{
			get => CMisc.Trimmed(Request.MessageHeader.DeviceID);
			set { Request.MessageHeader.DeviceID = CMisc.Trimmed(value); Reply.MessageHeader.DeviceID = DeviceID; }
		}
		/// <summary>
		/// Gives the final status of the operation
		/// </summary>
		public bool Success { get => null != GetResponse() ? ResultEnumeration.Success.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		public bool Failure { get => null != GetResponse() ? ResultEnumeration.Failure.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		public bool Partial { get => null != GetResponse() ? ResultEnumeration.Partial.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		/// <summary>
		/// Indicates the error condition
		/// </summary>
		public bool Aborted { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Aborted.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool Busy { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Busy.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool Cancel { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Cancel.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool DeviceOut { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.DeviceOut.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool InsertedCard { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InsertedCard.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool InProgress { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InProgress.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool LoggedOut { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.LoggedOut.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool MessageFormat { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.MessageFormat.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool NotAllowed { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.NotAllowed.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool NotFound { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.NotFound.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool PaymentRestriction { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.PaymentRestriction.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool Refusal { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Refusal.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool UnavailableDevice { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnavailableDevice.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool UnavailableService { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnavailableService.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool InvalidCard { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InvalidCard.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool UnreachableHost { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnreachableHost.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool WrongPIN { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.WrongPIN.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		public bool UnknownError { get => !Success ? !Aborted && !Busy && !Cancel && !DeviceOut && !InsertedCard && !InProgress && !LoggedOut && !MessageFormat && !NotAllowed && !NotFound && !PaymentRestriction && !Refusal && !UnavailableDevice && !UnavailableService && !InvalidCard && !UnreachableHost && !WrongPIN ? true : false : false; }
		/// <summary>
		/// Addition response data
		/// </summary>
		public string AdditionalResponse { get => !Success && (Failure || Partial) ? GetResponse().AdditionalResponse : null; }
		#endregion

		#region processing public properties
		///// <summary>
		///// THIS IS A XSDEx GENERATED VARIABLE WHICH IS MEANT TO BE USED ONLY BY THIS CLASS
		///// </summary>
		//private myXSDClassType myXSDClass = new myXSDClassType();
		/// <summary>
		/// Indicates whether milliseconds must be added to any datetime value
		/// </summary>
		public bool AddMilliseconds { get; set; } = false;
		/// <summary>
		/// Indicates whether datetimes must be UTC or locale
		/// </summary>
		public bool Utc { get; set; } = false;
		#endregion

		#region public methods
		/// <summary>
		/// Returns the last serialized object (request or reply)
		/// </summary>
		/// <returns>The last serialized object or null if no object seralized yet</returns>
		public override string ToString()
		{
			if (string.IsNullOrEmpty(SerializedReply))
				if (string.IsNullOrEmpty(SerializedRequest))
					return null;
				else
					return SerializedRequest;
			else
				return SerializedReply;
		}
		/// <summary>
		/// An automatic value which can be used to uniquely set the ServiceID or DeviceID
		/// An ID generated with this routine is guaranteed to be unique within a month but not beyond
		/// </summary>
		/// <returns>A unique (within a month) value to set a xID in a message</returns>
		public string AutoID()
		{
			return new NexoID().DefaultValue;
		}
		/// <summary>
		/// Set the default value of a cluster type
		/// The dault value is ALL cluster entries packed together
		/// </summary>
		/// <param name="data">The current cluster data value</param>
		/// <param name="cluster">The cluster to look for entries</param>
		/// <returns>The value to assign to the data</returns>
		public string SetDefaultCluster(string data, NexoCluster cluster)
		{
			if (string.IsNullOrEmpty(data))
			{
				cluster.SetAllLabels().ToString();
				return cluster.Value;
			}
			else
				return data;
		}
		/// <summary>
		/// Allows setting a default value to any unitialised data
		/// </summary>
		/// <param name="data">The data to test, eventually to set</param>
		/// <param name="typeDefaultValue">The data type default value</param>
		/// <param name="defaultValue">The default value if no other value is available</param>
		/// <returns>The value to assign to the data</returns>
		public string SetDefaultStringValue(string data, string defaultValue, string typeDefaultValue = "")
		{
			if (string.IsNullOrEmpty(data))
				if (string.IsNullOrEmpty(typeDefaultValue))
					return defaultValue;
				else
					return typeDefaultValue;
			else
				return data;
		}
		/// <summary>
		/// Allows setting a default value to a datetime
		/// </summary>
		/// <param name="dt">the datetime value already set</param>
		/// <param name="utc">indicates whether creating a new datetime must be in UTC or not</param>
		/// <returns>The date time to use</returns>
		public DateTime SetDefaultDateTime(DateTime dt, bool utc = false)
		{
			if (default == dt)
				return NexoISODateTime.StringToDateTime(NexoISODateTime.CurrentDateTime(utc));
			return dt;
		}
		/// <summary>
		/// Allows setting a default value to a datetime
		/// </summary>
		/// <param name="dt">the datetime value already set</param>
		/// <param name="defaultValue">default value to use</param>
		/// <returns>The date time to use</returns>
		public NexoISODateTime SetDefaultDateTime(NexoISODateTime dt, string defaultValue)
		{
			if (string.IsNullOrEmpty(dt.Value))
				return new NexoISODateTime() { Value = defaultValue };
			return dt;
		}
		/// <summary>
		/// Allows setting a default value to any uninitialised data
		/// </summary>
		/// <param name="data">The data to test, eventually to set</param>
		/// <param name="requestValue">The value to use to set the data if necessary</param>
		/// <returns>The value to assign to the data</returns>
		public string CopyRequestStringValue(string data, string requestValue)
		{
			if (string.IsNullOrEmpty(data))
				if (string.IsNullOrEmpty(requestValue))
					return null;
				else
					return requestValue;
			else
				return data;
		}
		/// <summary>
		/// Allows setting a default value to a currency
		/// </summary>
		/// <param name="currency">the datetime value already set</param>
		/// <param name="defaultValue">default value to use</param>
		/// <returns>The date time to use</returns>
		public NexoCurrency SetDefaultCurrency(NexoCurrency currency, string defaultValue)
		{
			if (string.IsNullOrEmpty(currency.Value))
				return new NexoCurrency() { Value = defaultValue };
			return currency;
		}
		/// <summary>
		/// Allows setting a default value to a language
		/// </summary>
		/// <param name="language">the datetime value already set</param>
		/// <param name="defaultValue">default value to use</param>
		/// <returns>The date time to use</returns>
		public NexoISOLanguage2A SetDefaultLanguage(NexoISOLanguage2A language, string defaultValue)
		{
			if (string.IsNullOrEmpty(language.Value))
				return new NexoISOLanguage2A() { Value = defaultValue };
			return language;
		}
		/// <summary>
		/// Set the request from an externally received XML buffer
		/// </summary>
		/// <param name="xml">XML buffer to deserialize</param>
		/// <returns>true if successful, false otherwise</returns>
		public bool RequestFromXml(string xml)
		{
			SaleToPOIRequest o = Deserialize<SaleToPOIRequest>(xml);
			if (null != o)
			{
				Request = o;
			}
			return false;
		}
		/// <summary>
		/// Set the reply from an externally received XML buffer
		/// </summary>
		/// <param name="xml">XML buffer to deserialize</param>
		/// <returns>true if successful, false otherwise</returns>
		public bool ReplyFromXml(string xml)
		{
			SaleToPOIResponse o = Deserialize<SaleToPOIResponse>(xml);
			if (null != o)
			{
				Reply = o;
			}
			return false;
		}
		/// <summary>
		/// Allows initialising an object from an item
		/// </summary>
		/// <param name="item"></param>
		/// <returns>true if successful, false otherwise</returns>
		public bool FromItem(NexoItem item)
		{
			if (MessageCategory == item.Category)
			{
				if (item.IsRequest)
				{
					ResetRequest((SaleToPOIRequest)item.Item);
				}
				else
				{
					ResetResponse((SaleToPOIResponse)item.Item);
				}
				return true;
			}
			return false;
		}
		/// <summary>
		/// Prepare a request serializing it in XML and completing it before sending it
		/// </summary>
		/// <returns>The request in XML, null if an error has occurred</returns>
		public string SerializeAndCompleteRequest()
		{
			try
			{
				InternalAction error;
				if (InternalAction.noError == (error = AutoCompleteRequestEx()))
				{
					return Serialize(Request);
				}
				else
					CLog.Add("Request serialization failed with error code: " + error.ToString(), TLog.ERROR);
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
		/// <summary>
		/// Prepare a reply serializing it in XML and completing it before sending it
		/// </summary>
		/// <returns>The reply in XML, null if an error has occurred</returns>
		public string SerializeAndCompleteReply()
		{
			try
			{
				InternalAction error;
				if (InternalAction.noError == (error = AutoCompleteReplyEx()))
				{
					return Serialize(Reply);
				}
				else
					CLog.Add("Reply serialization failed with error code: " + error.ToString(), TLog.ERROR);
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
		#endregion

		#region protected & must be overriden methods
		protected enum InternalAction
		{
			noError = 0,
			unknownError,
			abortByUser,
			abortBySystem,
		}
		/// <summary>
		/// Retrieves Reponse object from the reply
		/// </summary>
		/// <returns>Response object if available, null otherwise</returns>
		protected abstract ResponseType GetResponse();
		/// <summary>
		/// Set Response object reference
		/// </summary>
		/// <param name="r">The Response object to use to set the Response object</param>
		protected abstract void SetResponse(ResponseType r);
		/// <summary>
		/// Allows copying data from the request to the reply.
		/// By default nothing is copied.
		/// </summary>
		protected virtual void SetReplyFromRequest() { }
		/// <summary>
		/// Make necessary processing just before sending the request
		/// </summary>
		/// <returns><see cref="InternalAction.noError"/> if processing must continue, any other error value to prevent the message to be sent</returns>
		protected virtual InternalAction AutoCompleteRequest() { return InternalAction.noError; }
		private InternalAction AutoCompleteRequestEx()
		{
			AutoComplete();
			return AutoCompleteRequest();
		}
		/// <summary>
		/// Make necessary processing just before sending the response
		/// </summary>
		/// <returns><see cref="InternalAction.noError"/> if processing must continue, any other error value to prevent the message to be sent</returns>
		protected virtual InternalAction AutoCompleteReply() { return InternalAction.noError; }
		private InternalAction AutoCompleteReplyEx()
		{
			AutoComplete();
			SetReplyFromRequest();
			if (null != Response)
			{
				Response.Result = SetDefaultStringValue(Response.Result, ResultEnumeration.Success.ToString());
				if (ResultEnumeration.Success.ToString().ToLower() == Response.Result.ToLower())
				{
					Response.ErrorCondition = null;
					Response.AdditionalResponse = null;
				}
			}
			return AutoCompleteReply();
		}
		/// <summary>
		/// Perform standard, minimum autocomplete
		/// </summary>
		private void AutoComplete()
		{
			if (IsService || IsEvent)
			{
				ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);
			}
			else if (IsDevice)
			{
				DeviceID = SetDefaultStringValue(DeviceID, new NexoID().DefaultValue);
			}
		}
		/// <summary>
		/// Prepare a request serializing it in XML.
		/// </summary>
		/// <returns>The request in XML, null if an error has occurred</returns>
		private string SerializeRequest()
		{
			return Serialize(Request);
		}
		/// <summary>
		/// Prepare a reply serializing it in XML.
		/// </summary>
		/// <returns>The reply in XML, null if an error has occurred</returns>
		private string SerializeReply()
		{
			return Serialize(Reply);
		}
		/// <summary>
		/// Hidden function, only for internal use
		/// Allows to set the request from outside the object
		/// </summary>
		/// <param name="req"></param>
		/// <returns>True is reset, false otherwise</returns>
		internal bool ResetRequest(SaleToPOIRequest req)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), req.MessageHeader.MessageCategory))
			{
				CopyMessageHeader(req.MessageHeader);
				RequestItem = req.Item;
				return true;
			}
			return false;
		}
		/// <summary>
		/// Hidden function, only for internal use
		/// Allows to set the request from outside the object
		/// </summary>
		/// <param name="req"></param>
		/// <returns>True is reset, false otherwise</returns>
		internal bool ResetResponse(SaleToPOIResponse req)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), req.MessageHeader.MessageCategory))
			{
				CopyMessageHeader(req.MessageHeader);
				ReplyItem = req.Item;
				return true;
			}
			return false;
		}
		internal bool CopyMessageHeader(MessageHeaderType mh)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), mh.MessageCategory))
			{
				ProtocolVersion = mh.ProtocolVersion;
				MessageClass = (MessageClassEnumeration)CMisc.GetEnumValue(typeof(MessageClassEnumeration), mh.MessageClass);
				POIID = mh.POIID;
				SaleID = mh.SaleID;
				ServiceID = mh.ServiceID;
				DeviceID = mh.DeviceID;
				return true;
			}
			return false;
		}
		#endregion
	}

	[ComVisible(false)]
	public abstract class NexoService: NexoObject
	{
		protected NexoService(MessageCategoryEnumeration category) : base(category) { MessageClass = MessageClassEnumeration.Service; }
	}

	[ComVisible(false)]
	public abstract class NexoDevice: NexoObject
	{
		protected NexoDevice(MessageCategoryEnumeration category) : base(category) { MessageClass = MessageClassEnumeration.Device; }
	}

	[ComVisible(false)]
	public abstract class NexoNotification: NexoObject
	{
		protected NexoNotification() : base(MessageCategoryEnumeration.Event) { MessageClass = MessageClassEnumeration.Event; }
	}

	[ComVisible(true)]
	public enum NexoNextAction
	{
		/// <summary>
		/// abort the operation, the message is dismissed without further processing
		/// </summary>
		nothing,
		/// <summary>
		/// a REPLY has been received, the exchange is final and no more sent (automatically)
		/// </summary>
		final,
		/// <summary>
		/// a REQUEST has been received, no REPLY should be sent back
		/// </summary>
		noReply,
		/// <summary>
		/// a REQUEST has been received, a REPLY should be sent back
		/// </summary>
		sendReply,
		/// <summary>
		/// a REQUEST has been received, a REPLY with an error <see cref="ResponseType"/> should be sent back
		/// </summary>
		sendReplyWithError,
		/// <summary>
		/// a REQUEST or a REPLY has been received, a REQUEST should be sent back
		/// </summary>
		sendRequest,
		/// <summary>
		/// a REQUEST or a REPLY has been received, a NOIFICATION should be sent back
		/// </summary>
		sendNotification,
	}

	[Guid("4DA003CE-49BF-4831-83EB-3DAEA2072370")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoObjectToProcess
	{
		#region INexoObjectToProcess
		NexoObject CurrentObject { get; }
		NexoObject NextObject { get; set; }
		int NextTimer { get; set; }
		NexoItem Item { get; }
		MessageTypeEnumeration Type { get; }
		MessageCategoryEnumeration Category { get; }
		NexoNextAction SuggestedAction { get; }
		bool CanModifyAction { get; }
		NexoNextAction Action { get; set; }
		#endregion
	}
	[Guid("195F55CA-64B2-4E61-A1DB-9964557DE450")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoObjectToProcess: INexoObjectToProcess
	{
		#region constructor
		public NexoObjectToProcess(NexoItem item)
		{
			Item = item;
			CanModifyAction = true;
			Action = NexoNextAction.nothing;
			CurrentObject = NexoItem.AllocateObject(item.Category);
			if (item.IsRequest || item.IsNotification)
			{
				CurrentObject.Request = (SaleToPOIRequest)item.Item;
			}
			else if (item.IsReply)
			{
				CurrentObject.Reply = (SaleToPOIResponse)item.Item;
			}
		}
		#endregion

		#region properties
		/// <summary>
		/// The message to process
		/// </summary>
		public NexoObject CurrentObject
		{
			get => _currentobject;
			protected set => _currentobject = value;
		}
		private NexoObject _currentobject;
		/// <summary>
		/// A potential message which will follow the processed one
		/// </summary>
		public NexoObject NextObject
		{
			get => nextmessage;
			set => nextmessage = value;
		}
		private NexoObject nextmessage = null;
		public int NextTimer { get; set; } = CStreamClientSettings.NO_TIMEOUT;
		/// <summary>
		/// The message to process
		/// </summary>
		public NexoItem Item
		{
			get => _item;
			protected set => _item = value;
		}
		private NexoItem _item;
		public MessageTypeEnumeration Type { get => Item.Type; }
		public MessageCategoryEnumeration Category { get => Item.Category; }
		/// <summary>
		/// Indicates which action is expected next (suggested by the framework)
		/// </summary>
		public NexoNextAction SuggestedAction
		{
			get => _suggestedaction;
			internal set
			{
				_suggestedaction = (NexoNextAction)CMisc.GetEnumValue(typeof(NexoNextAction), value, NexoNextAction.nothing);
				Action = SuggestedAction;
			}
		}
		private NexoNextAction _suggestedaction = NexoNextAction.nothing;
		/// <summary>
		/// Flag indicating whether the application can or or modify the <see cref="SuggestedAction"/> by the server
		/// </summary>
		public bool CanModifyAction { get; internal set; }
		/// <summary>
		/// Indicates which action is going to be made (decided by the application)
		/// </summary>
		public NexoNextAction Action
		{
			get => _action;
			set
			{
				if (CanModifyAction)
					switch (SuggestedAction)
					{
						case NexoNextAction.nothing:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									break;
							}
							break;

						case NexoNextAction.final:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									break;
							}
							break;

						case NexoNextAction.noReply:
							switch (value)
							{
								case NexoNextAction.noReply:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									break;
							}
							break;

						case NexoNextAction.sendReply:
						case NexoNextAction.sendReplyWithError:
							switch (value)
							{
								case NexoNextAction.sendReply:
								case NexoNextAction.sendReplyWithError:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									break;
							}
							break;

						case NexoNextAction.sendRequest:
						case NexoNextAction.sendNotification:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									break;
							}
							break;
					}
			}
		}
		private NexoNextAction _action = NexoNextAction.nothing;
		#endregion
	}

	[ComVisible(true)]
	public class QueueOfNexoObjectToProcess: Queue<NexoObjectToProcess> { }

	[ComVisible(true)]
	public class StackOfNexoObjectToProcess: Stack<NexoObjectToProcess> { }
}
