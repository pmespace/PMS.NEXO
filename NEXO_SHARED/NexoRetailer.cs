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

namespace NEXO
{
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
				CLog.AddException(MethodBase.GetCurrentMethod().Module.Name + "." + MethodBase.GetCurrentMethod().DeclaringType.Name + "." + MethodBase.GetCurrentMethod().Name, ex);
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
				if (UseJson)
				{
					XSaleToPOIRequest x = Deserialize<XSaleToPOIRequest>(xml);
					if (null != x && null != x.SaleToPOIRequest)
					{
						JObject tk = (JObject)x.SaleToPOIRequest.Item;
						switch (CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), x.SaleToPOIRequest.MessageHeader.MessageCategory))
						{
							case MessageCategoryEnumeration.Abort:
								x.SaleToPOIRequest.Item = Deserialize<AbortRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Admin:
								x.SaleToPOIRequest.Item = Deserialize<AdminRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.BalanceInquiry:
								x.SaleToPOIRequest.Item = Deserialize<BalanceInquiryRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Batch:
								x.SaleToPOIRequest.Item = Deserialize<BatchRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardAcquisition:
								x.SaleToPOIRequest.Item = Deserialize<CardAcquisitionRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderAPDU:
								x.SaleToPOIRequest.Item = Deserialize<CardReaderAPDURequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderInit:
								x.SaleToPOIRequest.Item = Deserialize<CardReaderInitRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.CardReaderPowerOff:
								x.SaleToPOIRequest.Item = Deserialize<CardReaderPowerOffRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Diagnosis:
								x.SaleToPOIRequest.Item = Deserialize<DiagnosisRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Display:
								x.SaleToPOIRequest.Item = Deserialize<DisplayRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.EnableService:
								x.SaleToPOIRequest.Item = Deserialize<EnableServiceRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Event:
								x.SaleToPOIRequest.Item = Deserialize<EventNotificationType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.GetTotals:
								x.SaleToPOIRequest.Item = Deserialize<GetTotalsRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Input:
								x.SaleToPOIRequest.Item = Deserialize<InputRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.InputUpdate:
								x.SaleToPOIRequest.Item = Deserialize<InputUpdateType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Login:
								x.SaleToPOIRequest.Item = Deserialize<LoginRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Logout:
								x.SaleToPOIRequest.Item = Deserialize<LogoutRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Loyalty:
								x.SaleToPOIRequest.Item = Deserialize<LoyaltyRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Payment:
								x.SaleToPOIRequest.Item = Deserialize<PaymentRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.PIN:
								x.SaleToPOIRequest.Item = Deserialize<PINRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Print:
								x.SaleToPOIRequest.Item = Deserialize<PrintRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reconciliation:
								x.SaleToPOIRequest.Item = Deserialize<ReconciliationRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Reversal:
								x.SaleToPOIRequest.Item = Deserialize<ReversalRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Sound:
								x.SaleToPOIRequest.Item = Deserialize<SoundRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.StoredValue:
								x.SaleToPOIRequest.Item = Deserialize<StoredValueRequestType>(tk.ToString());
								break;
#if RETAILER31
							case MessageCategoryEnumeration.TransactionReport:
								x.SaleToPOIRequest.Item = Deserialize<TransactionReportRequestType>(tk.ToString());
								break;
#endif
							case MessageCategoryEnumeration.TransactionStatus:
								x.SaleToPOIRequest.Item = Deserialize<TransactionStatusRequestType>(tk.ToString());
								break;
							case MessageCategoryEnumeration.Transmit:
								x.SaleToPOIRequest.Item = Deserialize<TransmitRequestType>(tk.ToString());
								break;
							default:
								return null;
						}
						return x.SaleToPOIRequest;
					}
				}
				else
					return Deserialize<SaleToPOIRequest>(xml);
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
			catch (Exception ex) { CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, Chars.CRLF + "=> XSD: " + xsd); }
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
					s += "(" + i.ToString(fmt) + ") Error type: " + evt.Type.ToString() + " - " + evt.Description + Chars.CRLF;
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
					CLog.Add("Serialized XML message is invalid");
					ok = false;
				}
				string s = EventsList();
				if (!string.IsNullOrEmpty(s) && LogSerialisationEvents)
					CLog.Add(EventsList());
				return (ok ? xml : string.Empty);
			}
			catch (Exception ex) { CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex); return string.Empty; }
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
				//catch (Exception ex) { CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, "Request optimisation"); }
				//finally
				//{
				if (UseJson)
					serialized = Serialize<XSaleToPOIRequest>(new XSaleToPOIRequest() { SaleToPOIRequest = request });
				else
					serialized = Serialize<SaleToPOIRequest>(request);
				//}
			}
			catch (Exception ex)
			{
				CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, "Request processing");
			}
			finally
			{
				//request.XSD_Optimizing = false;
				//SetObjectProperty(request.Item, NexoXSDStrings.NexoOptimizingProperty, request.XSD_Optimizing);
			}
			return serialized;
		}
		class XSaleToPOIRequest { public SaleToPOIRequest SaleToPOIRequest; }
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
				//catch (Exception ex) { CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, "Reply optimisation"); }
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
				CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, "Reply processing");
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
			catch (Exception ex) { CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex); }
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
					return JsonConvert.SerializeObject(data,
						Newtonsoft.Json.Formatting.None,
						new JsonSerializerSettings()
						{
							MissingMemberHandling = MissingMemberHandling.Ignore,
							NullValueHandling = NullValueHandling.Ignore
						});
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
				CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex);
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

			try
			{
				if (isJson)
				{
					return JsonConvert.DeserializeObject<NxT>(data,
						new JsonSerializerSettings()
						{
							MissingMemberHandling = MissingMemberHandling.Ignore,
							NullValueHandling = NullValueHandling.Ignore
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
						return xsSubmit.Deserialize(reader);
				}
			}
			catch (Exception ex)
			{
				CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex);
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
					CLog.AddException($"{MethodBase.GetCurrentMethod().Module.Name}.{MethodBase.GetCurrentMethod().DeclaringType.Name}.{MethodBase.GetCurrentMethod().Name}", ex, $"Object: {type} - Property name: {property} - Value to set: {value}");
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
}