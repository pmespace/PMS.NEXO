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

#if !NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

using NEXO.Properties;
using COMMON;

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
	public class NexoSchemaEvents: List<NexoSchemaEvent> { }

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
		#endregion
	}
	[ComVisible(false)]
	public abstract class NexoRetailer: INexoRetailer
	{
		#region constructors
		protected NexoRetailer()
		{
			// load XSD from resources
			//Resources = new ResourceManager("NEXO.Properties.NexoResources", GetType().Assembly);
			Resources = new ResourceManager(typeof(NexoResources));
			ResourceSet resourceSet = Resources.GetResourceSet(CultureInfo.CurrentCulture, true, true);
			XSD = new XmlSchemaSet();
			foreach (DictionaryEntry entry in resourceSet)
			{
				string resourceKey = entry.Key.ToString();
				if (resourceKey.StartsWith("nexo30"))
					LoadAndSetXSD(resourceKey);
			}
			ResetSchemaValidationState();
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
		/// Indicates whether produced XML must be optimised or not
		/// Optimisation allows dismissinig unchanged tags preventing them to appear in the resulting XML
		/// </summary>
		public bool OptimizeXml { get; set; } = true;
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
		/// Deserialize a SaleToPOIXXX from an array of bytes
		/// </summary>
		/// <typeparam name="NxT">The type to deserialize</typeparam>
		/// <param name="bxml">The message to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public NxT Deserialize<NxT>(byte[] bxml)
		{
			if (null != bxml)
				return Deserialize<NxT>(Encoding.UTF8.GetString(bxml));
			return default;
		}
		/// <summary>
		/// Deserialize a SaleToPOIXXX from a string
		/// </summary>
		/// <typeparam name="NxT">The type to deserialize</typeparam>
		/// <param name="xml">String to deserialize</param>
		/// <returns>The deserialized object or null if an error has occurred</returns>
		public NxT Deserialize<NxT>(string xml)
		{
			if (!string.IsNullOrEmpty(xml))
				try
				{
					// validate XML
					ValidateXML(xml);
					return (NxT)XmlDeserialize<NxT>(xml, BOM);
				}
				catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			// arrived here an error has occurred
			return default;
		}
		#endregion

		#region internal classes
		class UTF8StringWriter: StringWriter
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
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, Chars.CRLF + "=> XSD: " + xsd); }
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
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); return string.Empty; }
		}
		/// <summary>
		/// Optimize and serialize request
		/// </summary>
		/// <returns>The XML string representing the object</returns>
		protected string Serialize(SaleToPOIRequest request)
		{
			try
			{
				string serialized = null;
				if (OptimizeXml)
					Optimize(request, request.Item);
				serialized = Serialize<SaleToPOIRequest>(request);
				return serialized;
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
		/// <summary>
		/// Optimize and serialize response
		/// </summary>
		/// <returns>The XML string representing the object</returns>
		protected string Serialize(SaleToPOIResponse reply)
		{
			try
			{
				string serialized = null;
				if (OptimizeXml)
					Optimize(reply, reply.Item);
				serialized = Serialize<SaleToPOIResponse>(reply);
				return serialized;
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
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
				string s = XmlSerialize<NxT>(request, BOM);
				return ValidateXML(s);
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return null;
		}
		#endregion

		#region static methods
		/// <summary>
		/// Generic serializer
		/// </summary>
		/// <typeparam name="NxT">the class type to serialize</typeparam>
		/// <param name="data">the object to serialize</param>
		/// <param name="bom">true if BOM must be added, false otherwise</param>
		/// <param name="ns">true if namespace must be added, false otherwise</param>
		/// <returns>a serialized string or an empty string if an error occurred</returns>
		static string XmlSerialize<NxT>(NxT data, bool bom = false, bool ns = false)
		{
			if (null == data)
				return null;

			// remove version
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = false;
			settings.CloseOutput = true;
			settings.OmitXmlDeclaration = false;

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
		/// <summary>
		/// Generic serializer
		/// </summary>
		/// <typeparam name="NxT">the class type to serialize</typeparam>
		/// <param name="data">the object to serialize</param>
		/// <param name="bom">true if BOM must be used, false otherwise</param>
		/// <returns>a serialized string or an empty string if an error occurred</returns>
		static object XmlDeserialize<NxT>(string data, bool bom = false) //where NxT : class
		{
			if (string.IsNullOrEmpty(data))
				return null;

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
		/// <summary>
		/// This function will optimize the XML structure to avoid declaring types not initialised (avoiding default values) when serializing a type
		/// </summary>
		/// <param name="o">The initial object to serialize</param>
		/// <param name="data">The structure of the object to optimize, or null. THIS MUST NEVER BE NULL WHEN CALLING THIS FUNCTION FROM OUTSIDE THE FUNCTION ITSELF FROM OUTSIDE, it will always be <see langword="null"/>when called recursively</param>
		/// <returns></returns>
		static bool Optimize(object o, object data)
		{
			// if no object it hasn't been modified
			if (null == o)
				return false;
			bool hasbeenset = false;
			// get the modified flag of the current object
			PropertyInfo pi = o.GetType().GetProperty("xsd" + o.GetType().Name + "InitFlag");
			if (null != pi)
			{
				// get init flag
				hasbeenset = (bool)pi.GetValue(o, null);
				string nmspace = typeof(SaleToPOIRequest).Namespace;
				// look for other objects inside this object
				object targetObject = data ?? o;
				//List<PropertyInfo> properties = (null != data ? data.GetType().GetProperties().ToList() : o.GetType().GetProperties().ToList());
				List<PropertyInfo> properties = targetObject.GetType().GetProperties().ToList();
				foreach (PropertyInfo pinfo in properties)
				{
					//// verify only types defined inside the current namespace, others won't carry the init flaf property
					if (null != pinfo.GetValue(targetObject, null) &&
						(nmspace == pinfo.PropertyType.Namespace ||
						("System" == pinfo.PropertyType.Namespace && pinfo.PropertyType.IsArray)))
					{
						int maxindex = 0;
						bool mustOptimize = true;
						// if array, an empty array indicates not set
						if (pinfo.PropertyType.IsArray)
							mustOptimize = 0 != (maxindex = ((Array)pinfo.GetValue(targetObject, null)).Length) && 1 == pinfo.PropertyType.GetArrayRank();
						// we go inside the property only if optimization is necessary
						if (mustOptimize)
						{
							// we do it only if the property owns other properties (useless otherwise)
							List<PropertyInfo> subproperties = pinfo.GetType().GetProperties().ToList();
							if (null != subproperties && 0 != subproperties.Count)
							{
								bool f = false;
								if (pinfo.PropertyType.IsArray)
								{
									Array array = (Array)pinfo.GetValue(targetObject, null);
									for (int i = 0; i < array.Length; i++)
									{
										object arrayObject = array.GetValue(i);
										f = Optimize(arrayObject, null);
										if (!f)
											//pinfo.SetValue(arrayObject, null, null);
											array.SetValue(null, i);
										hasbeenset = hasbeenset || f;
									}
								}
								else
								{
									// the object owns sub properties, we must recurse this processing
									f = Optimize(pinfo.GetValue(targetObject, null), null);
									if (!f)
										pinfo.SetValue(targetObject, null, null);
									hasbeenset = hasbeenset || f;
								}
							}
						}
					}
				}
			}
			return hasbeenset;
		}
		#endregion
	}
}