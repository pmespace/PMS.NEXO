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

using COMMON;

namespace NEXO
{
	[Guid("70469D2A-4EFD-4023-82BB-7F6D382A5D83")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoObject
	{
		#region owned
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
	}
	[Guid("667D198F-874E-457B-9641-C43933F336DB")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public abstract class NexoObject : NexoRetailer, INexoObject
	{
		#region constructors
		protected NexoObject(MessageCategoryEnumeration category)
		{
			// prepare request and response objects
			Request = new SaleToPOIRequest();
			Reply = new SaleToPOIResponse();
			Request.SecurityTrailer = null;
			Request.MessageHeader.MessageType = MessageTypeEnumeration.Request.ToString();
			Reply.SecurityTrailer = null;
			Reply.MessageHeader.MessageType = MessageTypeEnumeration.Response.ToString();
			MessageCategory = category;
			RequestItem = ReplyItem = null;
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
				if (null != _reply)
				{
					NexoMessageHeader mh = new NexoMessageHeader(Request.MessageHeader, null);
					Reply.MessageHeader = mh.MessageHeader;
					Reply.MessageHeader.MessageType = MessageTypeEnumeration.Response.ToString();
					SetReplyFromRequest();
				}
			}
		}
		private SaleToPOIRequest _request = null;
		public SaleToPOIResponse Reply
		{
			get => _reply;
			internal set
			{
				//if (null != value)
				_reply = value;
			}
		}
		private SaleToPOIResponse _reply = null;
		/// <summary>
		/// access to ietm data
		/// </summary>
		protected object RequestItem
		{
			get => Request.Item;
			set => Request.Item = value;
		}
		protected object ReplyItem
		{
			get => Reply.Item;
			set => Reply.Item = value;
		}
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
		public string OriginalServiceID
		{
			get => (null != Request && null != Request.MessageHeader ? Request.MessageHeader.ServiceID : null);
		}
		/// <summary>
		/// The Service to use
		/// </summary>
		public string DeviceID
		{
			get => CMisc.Trimmed(Request.MessageHeader.DeviceID);
			set { Request.MessageHeader.DeviceID = CMisc.Trimmed(value); Reply.MessageHeader.DeviceID = DeviceID; }
		}
		public string OriginalDeviceID
		{
			get => (null != Request && null != Request.MessageHeader ? Request.MessageHeader.DeviceID : null);
		}
		/// <summary>
		/// Gives the final status of the operation
		/// </summary>
		//public bool Success { get => null != GetResponse() && null != GetResponse().Result ? ResultEnumeration.Success.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		//public bool Failure { get => null != GetResponse() && null != GetResponse().Result ? ResultEnumeration.Failure.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		//public bool Partial { get => null != GetResponse() && null != GetResponse().Result ? ResultEnumeration.Partial.ToString().ToLower() == GetResponse().Result.ToLower() : false; }
		public bool Success { get => ResultEnumeration.Success == Result; }
		public bool Failure { get => ResultEnumeration.Failure == Result; }
		public bool Partial { get => ResultEnumeration.Partial == Result; }
		public bool Unknown { get => !Success && !Failure && !Partial; }
		/// <summary>
		/// Indicates the error condition
		/// </summary>
		//public bool Aborted { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.Aborted.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool Busy { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.Busy.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool Cancel { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.Cancel.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool DeviceOut { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.DeviceOut.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool InsertedCard { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.InsertedCard.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool InProgress { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.InProgress.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool LoggedOut { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.LoggedOut.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool MessageFormat { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.MessageFormat.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool NotAllowed { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.NotAllowed.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool NotFound { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.NotFound.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool PaymentRestriction { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.PaymentRestriction.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool Refusal { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.Refusal.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool UnavailableDevice { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.UnavailableDevice.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool UnavailableService { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.UnavailableService.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool InvalidCard { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.InvalidCard.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool UnreachableHost { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.UnreachableHost.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool WrongPIN { get => !Success && (Failure || Partial) && null != GetResponse().ErrorCondition ? ErrorConditionEnumeration.WrongPIN.ToString().ToLower() == GetResponse().ErrorCondition.ToLower() : false; }
		//public bool UnknownError { get => !Success ? !Aborted && !Busy && !Cancel && !DeviceOut && !InsertedCard && !InProgress && !LoggedOut && !MessageFormat && !NotAllowed && !NotFound && !PaymentRestriction && !Refusal && !UnavailableDevice && !UnavailableService && !InvalidCard && !UnreachableHost && !WrongPIN ? true : false : false; }
		public bool Aborted { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Aborted == ErrorCondition : false; }
		public bool Busy { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Busy == ErrorCondition : false; }
		public bool Cancel { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Cancel == ErrorCondition : false; }
		public bool DeviceOut { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.DeviceOut == ErrorCondition : false; }
		public bool InsertedCard { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InsertedCard == ErrorCondition : false; }
		public bool InProgress { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InProgress == ErrorCondition : false; }
		public bool LoggedOut { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.LoggedOut == ErrorCondition : false; }
		public bool MessageFormat { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.MessageFormat == ErrorCondition : false; }
		public bool NotAllowed { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.NotAllowed == ErrorCondition : false; }
		public bool NotFound { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.NotFound == ErrorCondition : false; }
		public bool PaymentRestriction { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.PaymentRestriction == ErrorCondition : false; }
		public bool Refusal { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.Refusal == ErrorCondition : false; }
		public bool UnavailableDevice { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnavailableDevice == ErrorCondition : false; }
		public bool UnavailableService { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnavailableService == ErrorCondition : false; }
		public bool InvalidCard { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.InvalidCard == ErrorCondition : false; }
		public bool UnreachableHost { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.UnreachableHost == ErrorCondition : false; }
		public bool WrongPIN { get => !Success && (Failure || Partial) ? ErrorConditionEnumeration.WrongPIN == ErrorCondition : false; }
		public bool UnknownError { get => !Success ? !Aborted && !Busy && !Cancel && !DeviceOut && !InsertedCard && !InProgress && !LoggedOut && !MessageFormat && !NotAllowed && !NotFound && !PaymentRestriction && !Refusal && !UnavailableDevice && !UnavailableService && !InvalidCard && !UnreachableHost && !WrongPIN ? true : false : false; }
		/// <summary>
		/// Allows to easily manipulate the Result value inside the ResponseType
		/// </summary>
		public ResultEnumeration Result
		{
			get => (null != GetResponse() ? (ResultEnumeration)GetResponseTag<ResultEnumeration>(GetResponse().Result) : (ResultEnumeration)NexoValues.None);
			set { if (null != GetResponse()) GetResponse().Result = SetResponseTag<ResultEnumeration>(GetResponse().Result); }
		}
		/// <summary>
		/// Allows to easily manipulate the ErrorCondition value inside the ResponseType
		/// </summary>
		public ErrorConditionEnumeration ErrorCondition
		{
			get => (null != GetResponse() ? (ErrorConditionEnumeration)GetResponseTag<ErrorConditionEnumeration>(GetResponse().ErrorCondition) : (ErrorConditionEnumeration)NexoValues.None);
			set { if (null != GetResponse()) GetResponse().ErrorCondition = SetResponseTag<ErrorConditionEnumeration>(GetResponse().ErrorCondition); }
		}
		/// <summary>
		/// Allows to easily manipulate the AdditionalResponse value inside the ResponseType
		/// </summary>
		public string AdditionalResponse
		{
			get => (null != GetResponse() ? GetResponse().AdditionalResponse : null);
			set { if (null != GetResponse()) GetResponse().AdditionalResponse = value; }
		}
		#endregion

		#region processing public properties
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
		/// <param name="value">The current cluster data value</param>
		/// <param name="cluster">The cluster to look for entries</param>
		/// <returns>The value to assign to the data</returns>
		public string SetDefaultCluster(string value, NexoCluster cluster)
		{
			if (string.IsNullOrEmpty(value))
			{
				cluster.SetAllLabels().ToString();
				return cluster.Value;
			}
			else
				return value;
		}
		/// <summary>
		/// Allows setting a default value to any unitialised data
		/// </summary>
		/// <param name="value">The data to test, eventually to set</param>
		/// <param name="typeDefaultValue">The data type default value</param>
		/// <param name="defaultValue">The default value if no other value is available</param>
		/// <returns>The value to assign to the data</returns>
		public string SetDefaultStringValue(string value, string defaultValue, string typeDefaultValue = "")
		{
			if (string.IsNullOrEmpty(value))
				if (string.IsNullOrEmpty(typeDefaultValue))
					return defaultValue;
				else
					return typeDefaultValue;
			else
				return value;
		}
		/// <summary>
		/// Allows setting a default value to any unitialised data
		/// </summary>
		/// <param name="value">The data to test, eventually to set</param>
		/// <param name="defaultValue">The default value if no other value is available</param>
		/// <returns>The value to assign to the data</returns>
		public double SetDefaultDoubleValue(double value, double defaultValue = 0)
		{
			if (0 == value)
				return defaultValue;
			else
				return value;
		}
		/// <summary>
		/// Allows setting a default value to any enumerated object
		/// </summary>
		/// <param name="typ">The enum type to consider</param>
		/// <param name="value">The data to test, eventually to set</param>
		/// <param name="defaultValue">The default value if no other value is available</param>
		/// <returns>The value to assign to the data</returns>
		public object SetDefaultEnumValue(Type typ, object value, object defaultValue)
		{
			if (null != value && CMisc.IsEnumValue(typ, value))
				return value;
			else if (null != defaultValue && CMisc.IsEnumValue(typ, defaultValue))
				return value;
			else return NexoValues.None;
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
		/// <param name="value">The data to test, eventually to set</param>
		/// <param name="requestValue">The value to use to set the data if necessary</param>
		/// <returns>The value to assign to the data</returns>
		public string CopyRequestStringValue(string value, string requestValue)
		{
			if (string.IsNullOrEmpty(value))
				if (string.IsNullOrEmpty(requestValue))
					return null;
				else
					return requestValue;
			else
				return value;
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
					ResetResponse(Request, (SaleToPOIResponse)item.Item);
				}
				return true;
			}
			return false;
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
		private object GetResponseTag<TxN>(string tag)
		{
			if (string.IsNullOrEmpty(tag)) return NexoValues.None;
			return CMisc.IsEnumValue(typeof(TxN), CMisc.GetEnumValue(typeof(TxN), tag)) ? CMisc.GetEnumValue(typeof(TxN), tag) : NexoValues.None;
		}
		private string SetResponseTag<TxN>(string tag)
		{
			if (string.IsNullOrEmpty(tag))
				return null;
			Array array = Enum.GetValues(typeof(TxN));
			if (CMisc.IsEnumValue(typeof(TxN), tag))
				return CMisc.EnumValueToString(typeof(TxN), tag);
			return null;
		}
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
			if (IsService || IsEvent)
			{
				ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);
			}
			else if (IsDevice)
			{
				DeviceID = SetDefaultStringValue(DeviceID, new NexoID().DefaultValue);
			}
			return AutoCompleteRequest();
		}
		/// <summary>
		/// Make necessary processing just before sending the response
		/// </summary>
		/// <returns><see cref="InternalAction.noError"/> if processing must continue, any other error value to prevent the message to be sent</returns>
		protected virtual InternalAction AutoCompleteReply() { return InternalAction.noError; }
		private InternalAction AutoCompleteReplyEx()
		{
			ServiceID = OriginalServiceID;
			DeviceID = OriginalDeviceID;
			SetReplyFromRequest();
			return AutoCompleteReply();
		}
		///// <summary>
		///// Perform standard, minimum autocomplete
		///// </summary>
		//private void AutoComplete()
		//{
		//	if (IsService || IsEvent)
		//	{
		//		ServiceID = SetDefaultStringValue(ServiceID, new NexoID().DefaultValue);
		//		OriginalServiceID = ServiceID;
		//	}
		//	else if (IsDevice)
		//	{
		//		DeviceID = SetDefaultStringValue(DeviceID, new NexoID().DefaultValue);
		//		OriginalDeviceID = DeviceID;
		//	}
		//}
		/// <summary>
		/// Prepare a request serializing it in XML.
		/// </summary>
		/// <returns>The request in XML, null if an error has occurred</returns>
		private string SerializeRequest()
		{
			return Serialize(_request);
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
		/// <param name="request"></param>
		/// <returns>True is reset, false otherwise</returns>
		internal bool ResetRequest(SaleToPOIRequest request)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), request.MessageHeader.MessageCategory))
			{
				CopyMessageHeader(request.MessageHeader);
				RequestItem = request.Item;
				return true;
			}
			return false;
		}
		/// <summary>
		/// Hidden function, only for internal use
		/// Allows to set the reply from outside the object
		/// </summary>
		/// <param name="request"></param>
		/// <param name="response"></param>
		/// <returns>True is reset, false otherwise</returns>
		internal bool ResetResponse(SaleToPOIRequest request, SaleToPOIResponse response)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), request.MessageHeader.MessageCategory))
			{
				CopyMessageHeader(request.MessageHeader);
				ReplyItem = response.Item;
				return true;
			}
			return false;
		}
		internal bool CopyMessageHeader(MessageHeaderType mh)
		{
			if (MessageCategory == (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), mh.MessageCategory))
			{
				MessageClass = (MessageClassEnumeration)CMisc.GetEnumValue(typeof(MessageClassEnumeration), mh.MessageClass);
				POIID = mh.POIID;
				SaleID = mh.SaleID;
				ServiceID = mh.ServiceID;
				DeviceID = mh.DeviceID;
				return true;
			}
			return false;
		}
		/// <summary>
		/// Prepare a request serializing it in XML and completing it before sending it
		/// </summary>
		/// <returns>The request in XML, null if an error has occurred</returns>
		internal string SerializeAndCompleteRequest()
		{
			try
			{
				InternalAction error;
				if (InternalAction.noError == (error = AutoCompleteRequestEx()))
				{
					//if (!(RequestItem is LoginRequestType))
					//	Request.MessageHeader.ProtocolVersion = null;
					return Serialize(_request);
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
		internal string SerializeAndCompleteReply()
		{
			try
			{
				InternalAction error;
				if (InternalAction.noError == (error = AutoCompleteReplyEx()))
				{
					//if (!(ReplyItem is LoginRequestType))
					//	Reply.MessageHeader.ProtocolVersion = null;
					return Serialize(Reply);
				}
				else
					CLog.Add("Reply serialization failed with error code: " + error.ToString(), TLog.ERROR);
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
		#endregion
	}

	[ComVisible(false)]
	public abstract class NexoService : NexoObject
	{
		protected NexoService(MessageCategoryEnumeration category) : base(category) { MessageClass = MessageClassEnumeration.Service; }
	}

	[ComVisible(false)]
	public abstract class NexoDevice : NexoObject
	{
		protected NexoDevice(MessageCategoryEnumeration category) : base(category) { MessageClass = MessageClassEnumeration.Device; }
	}

	[ComVisible(false)]
	public abstract class NexoNotification : NexoObject
	{
		protected NexoNotification() : base(MessageCategoryEnumeration.Event) { MessageClass = MessageClassEnumeration.Event; }
	}


}
