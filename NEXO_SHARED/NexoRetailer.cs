//#define USECONVERTER
#define USECONTRACT
#define XSALE

using System.Runtime.InteropServices;
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
using System.Collections;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using COMMON;
using NEXO.Properties;
using Newtonsoft.Json.Serialization;
using System.Linq.Expressions;

namespace NEXO
{
	public static partial class JsonExtensions
	{
		static readonly Func<JsonProperty, JsonProperty> ShallowClonePropertyFunc = CreateShallowCloneMethod<JsonProperty>();
		public static JsonProperty ShallowClone(this JsonProperty property)
		{
			if (property == null)
				throw new ArgumentNullException("property");
			return ShallowClonePropertyFunc(property);
		}

		internal static Predicate<T> And<T>(this Predicate<T> first, Predicate<T> second)
		{
			if (second == null)
				return first;
			else if (first == null)
				return second;
			else return v => first(v) && second(v);
		}

		internal static Func<T, T> CreateShallowCloneMethod<T>()
		{
			var method = typeof(T).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			if (method == null)
				throw new ArgumentException(string.Format("No MemberwiseClone() method was found for type {0}", typeof(T)));
			var cloneUntyped = (Func<T, object>)Delegate.CreateDelegate(typeof(Func<T, object>), method);
			return delegate (T obj) { return (T)cloneUntyped(obj); };
		}
	}

	[ComVisible(true)]
	public enum NexoSchemaEventType
	{
		All = 0,
		Error,
		Warning,
	}

	[ComVisible(false)]
	public class NexoSchemaEvent
	{
		public NexoSchemaEvent(NexoSchemaEventType type, string description) { Type = type; Description = description; }
		public NexoSchemaEventType Type { get; private set; }
		public string Description { get; private set; }
		public override string ToString() { return Type.ToString() + ": " + Description; }
	}
	[ComVisible(false)]
	public class NexoSchemaEvents : List<NexoSchemaEvent> { }

	[ComVisible(false)]
	interface INexoRetailer
	{
		#region INexoRetailer
		[DispId(1000)]
		bool SendWithErrors { get; set; }
		[DispId(1001)]
		bool SendWithWarnings { get; set; }
		[DispId(1002)]
		int NbErrors { get; }
		[DispId(1003)]
		bool ContainsErrors { get; }
		[DispId(1004)]
		int NbWarnings { get; }
		[DispId(1005)]
		bool ContainsWarnings { get; }
		[DispId(1006)]
		bool ContainsEvents { get; }
		[DispId(1007)]
		bool BOM { get; set; }
		[DispId(1008)]
		bool LogSerialisationEvents { get; set; }

		[DispId(1100)]
		string ErrorsList();
		[DispId(1102)]
		string WarningsList();
		[DispId(1103)]
		string EventsList();
		[DispId(1104)]
		bool IsUsingJson();
		[DispId(1105)]
		void SetUsingJson(bool f = false);
		#endregion
	}
	[ComVisible(false)]
	public abstract class NexoRetailer : INexoRetailer
	{
		#region constructors
		protected NexoRetailer()
		{
			// load XSD from resources

			////Resources = new ResourceManager("NEXO.Properties.NexoResources", GetType().Assembly);
			//Resources = new ResourceManager(typeof(NexoResources));
			//ResourceSet resourceSet = Resources.GetResourceSet(CultureInfo.CurrentCulture, true, true);
			//XSD = new XmlSchemaSet();
			//foreach (DictionaryEntry entry in resourceSet)
			//{
			//	string resourceKey = entry.Key.ToString();
			//	if (resourceKey.StartsWith(NexoCurrentVersion.Current.ResourceName))
			//		LoadAndSetXSD(resourceKey);
			//}
			//ResetSchemaValidationState();

			//Resources = new ResourceManager("NEXO.Properties.NexoResources", GetType().Assembly);
			try
			{
				Resources = new ResourceManager(typeof(Resources));
				if (null != Resources)
				{
					{
						ResourceSet resourceSet = Resources.GetResourceSet(CultureInfo.CurrentCulture, true, true);
						if (null != resourceSet)
						{
							XSD = new XmlSchemaSet();
							foreach (DictionaryEntry entry in resourceSet)
							{
								string resourceKey = entry.Key.ToString();
								if (resourceKey.StartsWith(NexoCurrentVersion.Current.ResourceName))
									LoadAndSetXSD(resourceKey);
							}
							ResetSchemaValidationState();
						}
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}
		#endregion

		#region properties
		/// <summary>
		/// Schema XSD to validate exhcnaged messages
		/// </summary>
		internal XmlSchemaSet XSD { get; private set; }
		/// <summary>
		/// Indicates whether a message must be sent or not if errors were reported after having applied XSD
		/// </summary>
		public bool SendWithErrors { get; set; } = false;
		/// <summary>
		/// Indicates whether a message must be sent or not if warnings were reported after having applied XSD
		/// </summary>
		public bool SendWithWarnings { get; set; } = true;
		/// <summary>
		/// Number of errors while applying XSD
		/// </summary>
		public int NbErrors { get; private set; } = 0;
		public bool ContainsErrors { get => 0 != NbErrors; }
		/// <summary>
		/// Number of warnings while applying XSD
		/// </summary>
		public int NbWarnings { get; private set; } = 0;
		public bool ContainsWarnings { get => 0 != NbWarnings; }
		/// <summary>
		/// Indicates whether events were found while applying XSD
		/// </summary>
		public bool ContainsEvents { get => ContainsErrors || ContainsWarnings; }
		/// <summary>
		/// List of all events that occurred while applying XSD
		/// </summary>
		private NexoSchemaEvents Events { get; set; } = new NexoSchemaEvents();
		/// <summary>
		/// Resources to use to load XSD
		/// </summary>
		internal ResourceManager Resources { get; private set; }
		/// <summary>
		/// Enable/disable adding the BOM to the serialized string
		/// </summary>
		public bool BOM { get; set; } = false;
		/// <summary>
		/// Indicate whether serialisation events must be stored inside log file
		/// </summary>
		public bool LogSerialisationEvents { get; set; } = false;

		/// <summary>
		/// Flag indicating whether use XML (false) or JSON (true) notation when exchanging messages
		/// </summary>
		static public bool UseJson { get; set; } = false;
		#endregion

		#region public methods
		/// <summary>
		/// A string containing the list of all errors + description
		/// </summary>
		/// <returns></returns>
		public string ErrorsList() { return EventsList(NexoSchemaEventType.Error); }
		/// <summary>
		/// A string containing the list of all warning + description
		/// </summary>
		/// <returns></returns>
		public string WarningsList() { return EventsList(NexoSchemaEventType.Warning); }
		/// <summary>
		/// A string containing the list of all errors and warnings + description
		/// </summary>
		/// <returns></returns>
		public string EventsList() { return EventsList(NexoSchemaEventType.All); }
		/// <summary>
		/// Allows retrieving whether using Json or XML notation
		/// </summary>
		/// <returns>True if Json notation, False is XML</returns>
		public bool IsUsingJson() { return UseJson; }
		/// <summary>
		/// Allows setting the use of Json or XML notation
		/// </summary>
		/// <param name="f">True is use Json, False if use XML (default)</param>
		public void SetUsingJson(bool f = false) { UseJson = f; }

		/// <summary>
		/// Deserialize a <see cref="SaleToPOIRequest"/> from an array of bytes
		/// </summary>
		/// <param name="bxml">The message to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public SaleToPOIRequest DeserializeRequest(byte[] bxml) { return DeserializeRequest(Encoding.UTF8.GetString(bxml)); }
		/// <summary>
		/// Deserialize a <see cref="SaleToPOIRequest"/> from a string
		/// </summary>
		/// <param name="xml">String to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public SaleToPOIRequest DeserializeRequest(string xml)
		{
			try
			{
#if XSALE
				if (UseJson)
				{
					XSaleToPOIRequest x = Deserialize<XSaleToPOIRequest>(xml);
					if (null != x)
					{
						return x.SaleToPOIRequest;
					}
				}
				else
					return Deserialize<SaleToPOIRequest>(xml);
#else
				if (UseJson)
				{
					XSaleToPOIRequest x = Deserialize<XSaleToPOIRequest>(xml);
					if (null != x && null != x)
					{
						JObject tk = (JObject)x.Item;
						switch (CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), x.MessageHeader.MessageCategory))
						{
							case MessageCategoryEnumeration.Abort:
								x.Item = Deserialize<AbortRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Admin:
								x.Item = Deserialize<AdminRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.BalanceInquiry:
								x.Item = Deserialize<BalanceInquiryRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Batch:
								x.Item = Deserialize<BatchRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardAcquisition:
								x.Item = Deserialize<CardAcquisitionRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderAPDU:
								x.Item = Deserialize<CardReaderAPDURequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderInit:
								x.Item = Deserialize<CardReaderInitRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderPowerOff:
								x.Item = Deserialize<CardReaderPowerOffRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Diagnosis:
								x.Item = Deserialize<DiagnosisRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Display:
								x.Item = Deserialize<DisplayRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.EnableService:
								x.Item = Deserialize<EnableServiceRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Event:
								x.Item = Deserialize<EventNotificationType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.GetTotals:
								x.Item = Deserialize<GetTotalsRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Input:
								x.Item = Deserialize<InputRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.InputUpdate:
								x.Item = Deserialize<InputUpdateType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Login:
								x.Item = Deserialize<LoginRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Logout:
								x.Item = Deserialize<LogoutRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Loyalty:
								x.Item = Deserialize<LoyaltyRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Payment:
								x.Item = Deserialize<PaymentRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.PIN:
								x.Item = Deserialize<PINRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Print:
								x.Item = Deserialize<PrintRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reconciliation:
								x.Item = Deserialize<ReconciliationRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reversal:
								x.Item = Deserialize<ReversalRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Sound:
								x.Item = Deserialize<SoundRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.StoredValue:
								x.Item = Deserialize<StoredValueRequestType>(tk.ToString());
								break;
#if RETAILER31
							case MessageCategoryEnumeration.TransactionReport:
								x.Item = Deserialize<TransactionReportRequestType>(tk.ToString());
								break;
#endif
							case MessageCategoryEnumeration.TransactionStatus:
								x.Item = Deserialize<TransactionStatusRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Transmit:
								x.Item = Deserialize<TransmitRequestType>(tk.ToString());
								break;
							default:
								return null;
						}
						return x;
					}
				}
				else
					return Deserialize<SaleToPOIRequest>(xml);
#endif
			}
			catch (Exception) { }
			return null;
		}
		/// <summary>
		/// Deserialize a <see cref="SaleToPOIResponse"/> from an array of bytes
		/// </summary>
		/// <param name="bxml">>The message to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public SaleToPOIResponse DeserializeResponse(byte[] bxml) { return DeserializeResponse(Encoding.UTF8.GetString(bxml)); }
		/// <summary>
		/// Deserialize a <see cref="SaleToPOIResponse"/> from a string
		/// </summary>
		/// <param name="xml">String to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public SaleToPOIResponse DeserializeResponse(string xml)
		{
			try
			{
#if true
				if (UseJson)
				{
					XSaleToPOIResponse x = Deserialize<XSaleToPOIResponse>(xml);
					if (null != x && null != x.SaleToPOIResponse)
					{
						return x.SaleToPOIResponse;
					}
				}
				else
					return Deserialize<SaleToPOIResponse>(xml);
#else
				if (UseJson)
				{
					XSaleToPOIResponse x = Deserialize<XSaleToPOIResponse>(xml);
					if (null != x && null != x.SaleToPOIResponse)
					{
						JObject tk = (JObject)x.SaleToPOIResponse.Item;
						switch (CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), x.SaleToPOIResponse.MessageHeader.MessageCategory))
						{
							case MessageCategoryEnumeration.Admin:
								x.SaleToPOIResponse.Item = Deserialize<AdminResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.BalanceInquiry:
								x.SaleToPOIResponse.Item = Deserialize<BalanceInquiryResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Batch:
								x.SaleToPOIResponse.Item = Deserialize<BatchResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardAcquisition:
								x.SaleToPOIResponse.Item = Deserialize<CardAcquisitionResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderAPDU:
								x.SaleToPOIResponse.Item = Deserialize<CardReaderAPDUResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderInit:
								x.SaleToPOIResponse.Item = Deserialize<CardReaderInitResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderPowerOff:
								x.SaleToPOIResponse.Item = Deserialize<CardReaderPowerOffResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Diagnosis:
								x.SaleToPOIResponse.Item = Deserialize<DiagnosisResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Display:
								x.SaleToPOIResponse.Item = Deserialize<DisplayResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.EnableService:
								x.SaleToPOIResponse.Item = Deserialize<EnableServiceResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.GetTotals:
								x.SaleToPOIResponse.Item = Deserialize<GetTotalsResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Input:
								x.SaleToPOIResponse.Item = Deserialize<InputResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Login:
								x.SaleToPOIResponse.Item = Deserialize<LoginResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Logout:
								x.SaleToPOIResponse.Item = Deserialize<LogoutResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Loyalty:
								x.SaleToPOIResponse.Item = Deserialize<LoyaltyResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Payment:
								x.SaleToPOIResponse.Item = Deserialize<PaymentResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.PIN:
								x.SaleToPOIResponse.Item = Deserialize<PINResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Print:
								x.SaleToPOIResponse.Item = Deserialize<PrintResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reconciliation:
								x.SaleToPOIResponse.Item = Deserialize<ReconciliationResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reversal:
								x.SaleToPOIResponse.Item = Deserialize<ReversalResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Sound:
								x.SaleToPOIResponse.Item = Deserialize<SoundResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.StoredValue:
								x.SaleToPOIResponse.Item = Deserialize<StoredValueResponseType>(tk.ToString());
								break;
#if RETAILER31
							case MessageCategoryEnumeration.TransactionReport:
								x.SaleToPOIResponse.Item = Deserialize<TransactionReportResponseType>(tk.ToString());
								break;
#endif
							case MessageCategoryEnumeration.TransactionStatus:
								x.SaleToPOIResponse.Item = Deserialize<TransactionStatusResponseType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Transmit:
								x.SaleToPOIResponse.Item = Deserialize<TransmitResponseType>(tk.ToString());
								break;
							default:
								return null;
						}
						return x.SaleToPOIResponse;
					}
				}
				else
					return Deserialize<SaleToPOIResponse>(xml);
#endif
			}
			catch (Exception) { }
			return null;
		}
		#endregion

		#region internal classes
		class UTF8StringWriter : StringWriter
		{
			private bool BOM = false;
			public UTF8StringWriter(bool bom) { BOM = bom; }
			public override Encoding Encoding => new UTF8Encoding(BOM);
		}
		#endregion

		#region protected methods
		private bool LoadAndSetXSD(string xsd)
		{
			try
			{
				var byteArray = Resources.GetObject(xsd);
				var stringReader = new StringReader(byteArray.ToString());
				var xmlSchema = new XmlSchema();
				ResetSchemaValidationState();
				xmlSchema = XmlSchema.Read(stringReader, SchemaValidationHandler);
				var xmlSchemeSet = new XmlSchemaSet();
				xmlSchemeSet.Add(xmlSchema);
				if (ContainsErrors || ContainsWarnings)
					throw new Exception(EventsList());
				return true;
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex, $"{Chars.CRLF}=> XSD: {xsd}");
			}
			return false;
		}
		private void ResetSchemaValidationState() { NbErrors = 0; NbWarnings = 0; Events.Clear(); }
		private void SchemaValidationHandler(object sender, ValidationEventArgs e)
		{
			switch (e.Severity)
			{
				case XmlSeverityType.Error:
					NbErrors = NbErrors + 1;
					Events.Add(new NexoSchemaEvent(NexoSchemaEventType.Error, e.Message));
					break;
				case XmlSeverityType.Warning:
					NbWarnings = NbWarnings + 1;
					Events.Add(new NexoSchemaEvent(NexoSchemaEventType.Warning, e.Message));
					break;
			}
		}
		private string EventsList(NexoSchemaEventType type)
		{
			int nbevents = (NexoSchemaEventType.All == type ? NbErrors + NbWarnings : (NexoSchemaEventType.Error == type ? NbErrors : NbWarnings));
			string fmt = new String('0', nbevents);
			string s = string.Empty;
			int i = 1;
			foreach (NexoSchemaEvent evt in Events)
				if (NexoSchemaEventType.All == type || evt.Type == type)
				{
					s += $"({i.ToString(fmt)}) Error type: {evt.Type} - {evt.Description}{Chars.CRLF}";
					i++;
				}
			return s;
		}
		/// <summary>
		/// Validate a xml message
		/// </summary>
		/// <param name="xml">XML message to validate</param>
		/// <returns>The XML message if valid, an empty string if not. Check properties to determine why</returns>
		private string ValidateXML(string xml)
		{
			try
			{
				bool ok = true;
				ResetSchemaValidationState();
				XDocument x = XDocument.Parse(xml);
				x.Validate(XSD, SchemaValidationHandler);
				// if errors or warnings but send is not allowed for these cases, return an empty string
				if ((ContainsErrors && !SendWithErrors) || (ContainsWarnings && !SendWithWarnings))
				{
					CLog.Add($"Serialized XML message is invalid");
					ok = false;
				}
				string s = EventsList();
				if (!string.IsNullOrEmpty(s) && LogSerialisationEvents)
					CLog.Add(EventsList());
				return (ok ? xml : string.Empty);
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				return string.Empty;
			}
		}
		/// <summary>
		/// Deserialize a SaleToPOIXXX from an array of bytes
		/// </summary>
		/// <typeparam name="NxT">The type to deserialize</typeparam>
		/// <param name="bxml">The message to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		private NxT Deserialize<NxT>(byte[] bxml)
		{
			if (null != bxml)
			{
				return Deserialize<NxT>(Encoding.UTF8.GetString(bxml));
			}
			return default;
		}
		/// <summary>
		/// Deserialize a SaleToPOIXXX from a string
		/// </summary>
		/// <typeparam name="NxT">The type to deserialize</typeparam>
		/// <param name="xml">String to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		private NxT Deserialize<NxT>(string xml)
		{
			if (!string.IsNullOrEmpty(xml))
				try
				{
					// validate XML
					if (!UseJson)
						xml = ValidateXML(xml);
					return (NxT)XmlDeserialize<NxT>(xml, UseJson, BOM);
				}
				catch (Exception) { }
			// arrived here an error has occurred
			return default;
		}
		/// <summary>
		/// Optimize and serialize request
		/// </summary>
		/// <returns>The XML string representing the object</returns>
		protected string Serialize(SaleToPOIRequest request)
		{
			string serialized = null;
			try
			{
				//request.XSD_Optimizing = true;// OptimizeXml;
				//try
				//{
				//	SetObjectProperty(request.Item, NexoXSDStrings.NexoOptimizingProperty, request.XSD_Optimizing);
				//}
				//catch (Exception ex) { CLog.EXCEPT(ex, "Request optimisation"); }
				//finally
				//{
				if (UseJson)
#if XSALE
					serialized = Serialize<XSaleToPOIRequest>(new XSaleToPOIRequest() { SaleToPOIRequest = request });
#else
					serialized = Serialize<XSaleToPOIRequest>(request as XSaleToPOIRequest);
#endif
				else
					serialized = Serialize<SaleToPOIRequest>(request);
				//}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex, "Request processing");
			}
			finally
			{
				//request.XSD_Optimizing = false;
				//SetObjectProperty(request.Item, NexoXSDStrings.NexoOptimizingProperty, request.XSD_Optimizing);
			}
			return serialized;
		}
#if XSALE
		class XSaleToPOIRequest { public SaleToPOIRequest SaleToPOIRequest { get; set; } }
#else
		class XSaleToPOIRequest : SaleToPOIRequest { }
#endif
		/// <summary>
		/// Optimize and serialize response
		/// </summary>
		/// <returns>The XML string representing the object</returns>
		protected string Serialize(SaleToPOIResponse reply)
		{
			string serialized = null;
			try
			{
				//reply.XSD_Optimizing = true;// OptimizeXml;
				//try
				//{
				//	SetObjectProperty(reply.Item, NexoXSDStrings.NexoOptimizingProperty, reply.XSD_Optimizing);
				//}
				//catch (Exception ex) { CLog.EXCEPT(ex, "Reply optimisation"); }
				//finally
				//{
				if (UseJson)
					serialized = Serialize<XSaleToPOIResponse>(new XSaleToPOIResponse() { SaleToPOIResponse = reply });
				else
					serialized = Serialize<SaleToPOIResponse>(reply);
				//}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex, "Reply processing");
			}
			finally
			{
				//reply.XSD_Optimizing = false;
				//SetObjectProperty(reply.Item, NexoXSDStrings.NexoOptimizingProperty, reply.XSD_Optimizing);
			}
			return serialized;
		}
		class XSaleToPOIResponse { public SaleToPOIResponse SaleToPOIResponse; }
		/// <summary>
		/// Serialize a SaleToPOIXXX
		/// </summary>
		/// <typeparam name="NxT">The type to serialize</typeparam>
		/// <param name="request">The structure to serialize or null</param>
		/// <returns>The serialized XML or an empty string if an error has occurred</returns>
		private string Serialize<NxT>(NxT request)
		{
			try
			{
				string s = XmlSerialize<NxT>(request, UseJson, BOM, false);
				// return json string
				if (UseJson)
					return s;
				// return xml string
				return ValidateXML(s);
			}
			catch (Exception ex) { CLog.EXCEPT(ex); }
			return null;
		}
		#endregion

		#region static methods
		/// <summary>
		/// Generic serializer
		/// </summary>
		/// <typeparam name="NxT">the class type to serialize</typeparam>
		/// <param name="data">the object to serialize</param>
		/// <param name="toJson">if true serialisation will produce json string, xml string if false</param>
		/// <param name="bom">true if BOM must be added, false otherwise (default)</param>
		/// <param name="ns">true if namespace must be added, false otherwise (default)</param>
		/// <returns>a serialized string or an empty string if an error occurred</returns>
		public static string XmlSerialize<NxT>(NxT data, bool toJson, bool bom = false, bool ns = false)
		{
			if (null == data)
				return null;

			try
			{
				if (toJson)
				{
#if true
					return JsonConvert.SerializeObject(data,
						Newtonsoft.Json.Formatting.None,
						new JsonSerializerSettings()
						{
							MissingMemberHandling = MissingMemberHandling.Ignore,
							NullValueHandling = NullValueHandling.Ignore,
#if USECONVERTER
							Converters = new List<JsonConverter> { new JsonPolymorphicAttribute() },
#endif
#if USECONTRACT
							ContractResolver = JsonPropertyElementResolver.Instance,
#endif
						});
#else
					return JsonConvert.SerializeObject(data,
						Newtonsoft.Json.Formatting.None,
						new JsonPropertyNameFromTypeConverter());
#endif
				}
				else
				{
					// remove version
					XmlWriterSettings settings = new XmlWriterSettings();
					settings.Indent = false;
					settings.CloseOutput = true;
					settings.OmitXmlDeclaration = true;

					XmlSerializer xsSubmit = new XmlSerializer(typeof(NxT));
					using (StringWriter sw = new UTF8StringWriter(bom))
					using (XmlWriter writer = XmlWriter.Create(sw, settings))
					{
						var xmlns = new XmlSerializerNamespaces();
						// removes namespace if requested
						if (!ns)
							xmlns.Add(string.Empty, string.Empty);
						// serialize
						xsSubmit.Serialize(writer, data, xmlns);
						return sw.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				return null;
			}
		}
		/// <summary>
		/// Generic serializer
		/// </summary>
		/// <typeparam name="NxT">the class type to serialize</typeparam>
		/// <param name="isJson">if true deserialisation will be made from json string, from xml string if false</param>
		/// <param name="data">the object to serialize</param>
		/// <param name="bom">true if BOM must be used, false otherwise (default)</param>
		/// <returns>a serialized string or an empty string if an error occurred</returns>
		public static object XmlDeserialize<NxT>(string data, bool isJson, bool bom = false) //where NxT : class
		{
			if (string.IsNullOrEmpty(data))
				return null;

			data.Replace(Chars.CR, "");
			data.Replace(Chars.LF, "");

			try
			{
				if (isJson)
				{
					return JsonConvert.DeserializeObject<NxT>(data,
						new JsonSerializerSettings()
						{
							MissingMemberHandling = MissingMemberHandling.Ignore,
							NullValueHandling = NullValueHandling.Ignore,
#if USECONVERTER
							Converters = new List<JsonConverter> { new JsonPolymorphicAttribute() }
#endif
#if USECONTRACT
							ContractResolver = JsonPropertyElementResolver.Instance,
#endif
						});
				}
				else
				{
					// remove version
					XmlReaderSettings settings = new XmlReaderSettings();
					settings.IgnoreComments = true;
					settings.IgnoreProcessingInstructions = true;
					settings.IgnoreWhitespace = true;
					settings.CloseInput = true;

					XmlSerializer xsSubmit = new XmlSerializer(typeof(NxT));
					using (StreamReader stream = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(data ?? string.Empty)), Encoding.UTF8, bom))
					using (XmlReader reader = XmlReader.Create(stream, settings))
						try
						{
							return xsSubmit.Deserialize(reader);
						}
						catch (Exception)
						{
							// no specific processing as we may not be processing the requested class thus generating an exception, in this case just return null
							return null;
						}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				return null;
			}
		}
		/// <summary>
		/// Set a property value (not an array one) by name inside an object
		/// </summary>
		/// <param name="o">The object to look inside</param>
		/// <param name="property">The property to look for</param>
		/// <param name="value">The value to set</param>
		/// <returns>true if the property value has been set, false otherwise (property not found or property doesn't support the value)</returns>
		private static bool SetObjectProperty(object o, string property, object value)
		{
			// get the type of the object
			Type type = GetRealObjectType(o);
			// search for the requested property inside that object
			PropertyInfo pi = type.GetProperty(property, BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Public);
			if (null != pi)
			{
				try
				{
					// the property has been found, let's setit to the desired value
					pi.SetValue(o, value, null);
					return true;
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex, $"Object: {type} - Property name: {property} - Value to set: {value}");
				}
			}
			return false;
		}
		///// <summary>
		///// Return the real object (if any) stored inside a System.Object property
		///// </summary>
		///// <param name="o">current object containg that property</param>
		///// <param name="pinfo">property to look for</param>
		///// <param name="type">[OUT] the type of the object stored inside the System.Object (if any, as it may be null)</param>
		///// <returns>The real object stored inside a System.Object (if any), the current object if one is stored inside a System.Object, null otherwise</returns>
		//private static void SetPropertyFromObject(object initial, string property, out Type type)
		//{
		//	Func<Type, bool> IsArray = (Type xtype) => { return xtype.IsArray; };
		//	Func<Type, bool> IsSystemType = (Type xtype) => { return (0 == string.Compare("system", xtype.Namespace, true)); };
		//	Func<Type, bool> IsSystemObject = (Type xtype) => { return IsSystemType(xtype) && (0 == string.Compare("object", xtype.Name, true)); };

		//	object target = null;
		//	// get the type of the property to check
		//	type = pinfo.PropertyType;
		//	if (IsSystemObject(type) || !IsSystemType(type))
		//	{
		//		// the property is either a System.Object or a non System obejct, get its value to try to find its real type
		//		target = pinfo.GetValue(initial, null);
		//		if (null != target)
		//			// we found the real type of the object stored inside the System.Object property
		//			type = target.GetType();
		//	}
		//	return target;
		//}
		///// <summary>
		///// Return the real object (if any) stored inside a System.Object property
		///// </summary>
		///// <param name="o">current object containg that property</param>
		///// <param name="pinfo">property to look for</param>
		///// <param name="type">[OUT] the type of the object stored inside the System.Object (if any, as it may be null)</param>
		///// <returns>The real object stored inside a System.Object (if any), the current object if one is stored inside a System.Object, null otherwise</returns>
		//private static object GetPropertyFromObject(object initial, PropertyInfo pinfo, out Type type)
		//{
		//	Func<Type, bool> IsArray = (Type xtype) => { return xtype.IsArray; };
		//	Func<Type, bool> IsSystemType = (Type xtype) => { return (0 == string.Compare("system", xtype.Namespace, true)); };
		//	Func<Type, bool> IsSystemObject = (Type xtype) => { return IsSystemType(xtype) && (0 == string.Compare("object", xtype.Name, true)); };

		//	object target = null;
		//	// get the type of the property to check
		//	type = pinfo.PropertyType;
		//	if (IsSystemObject(type) || !IsSystemType(type))
		//	{
		//		// the property is either a System.Object or a non System obejct, get its value to try to find its real type
		//		target = pinfo.GetValue(initial, null);
		//		if (null != target)
		//			// we found the real type of the object stored inside the System.Object property
		//			type = target.GetType();
		//	}
		//	return target;
		//}
		/// <summary>
		/// Return the real object (if any) stored inside a System.Object property
		/// </summary>
		/// <param name="o">current object containg that property</param>
		/// <returns>The real object stored inside a System.Object (if any), the current object if one is stored inside a System.Object, null otherwise</returns>
		public static Type GetRealObjectType(object o)
		{
			Func<Type, bool> IsArray = (Type xtype) => { return xtype.IsArray; };
			Func<Type, bool> IsSystemType = (Type xtype) => { return (0 == string.Compare("system", xtype.Namespace, true)); };
			Func<Type, bool> IsSystemObject = (Type xtype) => { return IsSystemType(xtype) && (0 == string.Compare("object", xtype.Name, true)); };

			// get the type of the property to check
			Type type = o.GetType();
			if (IsSystemObject(type))
			{
				object obj = o;
				type = obj.GetType();
			}
			return type;
		}
		#endregion
	}

	/// <summary>
	/// Source - https://stackoverflow.com/a/79900545
	/// Posted by dbc, modified by community. See post 'Timeline' for change history
	/// Retrieved 2026-03-04, License - CC BY-SA 4.0
	/// </summary>
	[ComVisible(false)]
	public class JsonPropertyElementResolver : DefaultContractResolver
	{
		public static readonly JsonPropertyElementResolver Instance = new JsonPropertyElementResolver();

		protected override JsonObjectContract CreateObjectContract(Type objectType)
		{
			var contract = base.CreateObjectContract(objectType);

			for (int i = 0; i < contract.Properties.Count; i++)
			{
				var property = contract.Properties[i];
				var valueProvider = property.ValueProvider;
				var attributeProvider = property.AttributeProvider;

				// ...
				if (!property.PropertyName.IsNullOrEmpty() && default != contract.CreatorParameters.GetClosestMatchProperty(property.PropertyName))
				{
					// TODO: decide how to handle polymorphic property names in parameterized objects where the polymorphically named property needs to be passed to the constructor.  
					// Unfortunately Json.NET matches constructor parameters to JSON properties by name which is inconsistent with polymorphic property naming.
					throw new ArgumentException(string.Format("Polymorphically named properties are not supported for parameterized constructors: property \"{0}\", type \"{1}\"", property.PropertyName, contract.UnderlyingType));
				}

				// verify whether the property is valid and is serializable
				if (
					default == attributeProvider || default == valueProvider || property.Ignored
#if SORT_READABLE
						|| !property.Readable
#endif
#if SORT_WRITEABLE
						|| !property.Writable
#endif
					)
					continue;

				// get its XmlElementAttribute
				var xmlElementAttributes = attributeProvider.GetAttributes(typeof(XmlElementAttribute), true);
				if (0 == xmlElementAttributes.Count)
					continue;

				// as there may be several times the same type with different names we must get the eventual XmlChoiceIdentifierAttribute to determine which XmlElementSttaribute to use
				var xmlChoiceIdentifierAttribute = attributeProvider.GetAttributes(typeof(XmlChoiceIdentifierAttribute), true);
				string memberName = default != xmlChoiceIdentifierAttribute && 0 != xmlChoiceIdentifierAttribute.Count ? (xmlChoiceIdentifierAttribute as XmlChoiceIdentifierAttribute).MemberName : default;
				object choiceType = contract.Properties.Where(o => o.PropertyName == memberName).FirstOrDefault();

				/*
				 * create an set of FAKE properties each having the name (ElementName) attached to a type (Type) declared using XmlElementAttribute
				 * none is serialized unless it's type matches the runtime type of the real property of the class, in that case that real property is not serialized and the matching one is,
				 * allowing to serialize a property name as it is described by its type
				 */
				var polymorphicTypes = new HashSet<Type>();
				foreach (var attribute in xmlElementAttributes.Cast<XmlElementAttribute>())
				{
					// if no name (ElementName) or no type (Type) is described in the XmlElementAttribute we do not process the property
					if (default == attribute.Type || attribute.ElementName.IsNullOrEmpty(true))
						continue;

					/*
					 * if the real property's type can't be assigned the type of the FAKE property described in the XmlElementAttribute, raise an exception
					 * this could mostly happen onlyif the real property's type is not object
					 */
					if (default != property.PropertyType && !property.PropertyType.IsAssignableFrom(attribute.Type))
					{
						throw new ArgumentException(string.Format("JsonProperty.PropertyType {0} is not assignable from JsonPolymorphicNameAttribute.PolymorphicType {1}", property.PropertyType, attribute.Type));
					}

					// arrived here we can create a FAKE property using the XmlElementAttribute ElementName and Type
					var newProperty = property.ShallowClone();
					newProperty.PropertyName = attribute.ElementName;
					newProperty.PropertyType = attribute.Type;
#if !SORT_READABLE
					if (property.Readable)
					{
#endif
						// the real property can be read, we assign the FAKE property a predicate helping idenitifying whether it is that one that must be serialized or not
						newProperty.ShouldSerialize = newProperty.ShouldSerialize.And(
							 o =>
							 {
								 // get the value of the real property
								 var value = valueProvider.GetValue(o);
								 /*
								  * the FAKE property must be serialized if:
								  * - the value of the real property is not null
								  * - and the runtgime type of the real property is the one of the FAKE property
								  */
								 return value != null && value.GetType() == attribute.Type && (default == choiceType || choiceType.ToString().Compare(attribute.ElementName));
							 });
#if !SORT_READABLE
					}
					else
					{
						// the real property can't be read, the FAKE property won't be serialized anyway
						newProperty.ShouldSerialize = o => false;
					}
#endif
					//newProperty.ShouldDeserialize = newProperty.ShouldSerialize;

					// insert the FAKE property to the list of properties of this type
					contract.Properties.Insert(++i, newProperty);
					polymorphicTypes.Add(attribute.Type);
				}
				/*
				 * determine whether the real property must be serialized or not
				 * it won't be serialized if a FAKE property exists with the following attributes
				 * - it is of the same type as the real property's runtime type
				 */
				property.ShouldSerialize = property.ShouldSerialize.And(
					 o =>
					 {
						 var value = valueProvider.GetValue(o);
						 /*
						  * TODO: decide what to do if the value is null, since we can't get the concretetype.
						  * for the time being we consider the 
						  */
						 return (default != value && !polymorphicTypes.Contains(value.GetType())) || (default == value && property.NullValueHandling == NullValueHandling.Include);
					 });
				//property.ShouldDeserialize = property.ShouldSerialize;
			}
			return contract;
		}
	}
}