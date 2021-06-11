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
		#endregion
	}
	[ComVisible(false)]
	public abstract class NexoRetailer : INexoRetailer
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
				if (resourceKey.StartsWith(NexoCurrentVersion.Current.ResourceName))
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
				catch (Exception ex) { /*CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);*/ }
			// arrived here an error has occurred
			return default;
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
			string serialized = null;
			try
			{
				request.XSD_Optimizing = OptimizeXml;
				try
				{
					SetObjectProperty(request.Item, NexoXSDStrings.NexoOptimizingProperty, request.XSD_Optimizing);
					//if (OptimizeXml)
					//	Optimize(request, request.Item, true);
				}
				catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Request optimisation"); }
				finally
				{
					serialized = Serialize<SaleToPOIRequest>(request);
					//try
					//{
					//	if (OptimizeXml)
					//		Optimize(request, request.Item, false);
					//}
					//catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Request de-optimisation"); }
				}
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Request processing");
			}
			finally
			{
				request.XSD_Optimizing = false;
				SetObjectProperty(request.Item, NexoXSDStrings.NexoOptimizingProperty, request.XSD_Optimizing);
			}
			return serialized;
		}
		/// <summary>
		/// Optimize and serialize response
		/// </summary>
		/// <returns>The XML string representing the object</returns>
		protected string Serialize(SaleToPOIResponse reply)
		{
			string serialized = null;
			try
			{
				reply.XSD_Optimizing = OptimizeXml;
				try
				{
					SetObjectProperty(reply.Item, NexoXSDStrings.NexoOptimizingProperty, reply.XSD_Optimizing);
					//if (OptimizeXml)
					//	Optimize(reply, reply.Item, true);
				}
				catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Reply optimisation"); }
				finally
				{
					serialized = Serialize<SaleToPOIResponse>(reply);
					//try
					//{
					//	if (OptimizeXml)
					//		Optimize(reply, reply.Item, false);
					//}
					//catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Reply de-optimisation"); }
				}
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Reply processing");
			}
			finally
			{
				reply.XSD_Optimizing = false;
				SetObjectProperty(reply.Item, NexoXSDStrings.NexoOptimizingProperty, reply.XSD_Optimizing);
			}
			return serialized;
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
		public static string XmlSerialize<NxT>(NxT data, bool bom = false, bool ns = false)
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
		public static object XmlDeserialize<NxT>(string data, bool bom = false) //where NxT : class
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
		/// <param name="o">The initial object to serialize (usually a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIResponse"/>)</param>
		/// <param name="data">The structure of the specific nexo object to optimize (Login, Payment,...). THIS PARAMETER MUST NEVER BE NULL WHEN CALLING THIS FUNCTION, only recursive calls can set the parameter to null</param>
		/// <param name="optimize">Indicates whether optimisation must be turned on or off</param>
		/// <returns></returns>
		public static bool Optimize(object o, object data, bool optimize)
		{
			//// if no object it hasn't been modified
			//if (null == o)
			//	return false;
			//bool hasbeenset = false;
			//// get the modified flag of the current object
			//PropertyInfo pi = o.GetType().GetProperty(Strings.NexoHasBeenSetProperty);
			//if (null != pi)
			//{
			//	// get init flag
			//	hasbeenset = (bool)pi.GetValue(o, null);
			//	string nmspace = typeof(SaleToPOIRequest).Namespace;
			//	// look for other objects inside this object
			//	object targetObject = data ?? o;
			//	List<PropertyInfo> properties = targetObject.GetType().GetProperties().ToList();
			//	foreach (PropertyInfo pinfo in properties)
			//	{
			//		// verify only types defined inside the current namespace, others won't carry the set flag property
			//		if (null != pinfo.GetValue(targetObject, null) &&
			//			(nmspace == pinfo.PropertyType.Namespace ||
			//			("System" == pinfo.PropertyType.Namespace && pinfo.PropertyType.IsArray)))
			//		{
			//			int maxindex = 0;
			//			bool mustOptimize = true;
			//			// if array, an empty array indicates not set
			//			if (pinfo.PropertyType.IsArray)
			//				mustOptimize = 0 != (maxindex = ((Array)pinfo.GetValue(targetObject, null)).Length) && 1 == pinfo.PropertyType.GetArrayRank();
			//			// we go inside the property only if optimization is necessary
			//			if (mustOptimize)
			//			{
			//				// we do it only if the property owns other properties (useless otherwise)
			//				List<PropertyInfo> subproperties = pinfo.GetType().GetProperties().ToList();
			//				if (null != subproperties && 0 != subproperties.Count)
			//				{
			//					bool f = false;
			//					if (pinfo.PropertyType.IsArray)
			//					{
			//						Array array = (Array)pinfo.GetValue(targetObject, null);
			//						for (int i = 0; i < array.Length; i++)
			//						{
			//							object arrayObject = array.GetValue(i);
			//							f = Optimize(arrayObject, null);
			//							if (!f)
			//								array.SetValue(null, i);
			//							hasbeenset = hasbeenset || f;
			//						}
			//					}
			//					//else
			//					//{
			//					//	// the object owns sub properties, we must recurse this processing
			//					//	f = Optimize(pinfo.GetValue(targetObject, null), null);
			//					//	if (!f)
			//					//		pinfo.SetValue(targetObject, null, null);
			//					//	hasbeenset = hasbeenset || f;
			//					//}
			//					else if (pinfo.PropertyType.IsClass)
			//					{
			//						// the object owns sub properties, we must recurse this processing
			//						f = Optimize(pinfo.GetValue(targetObject, null), null);
			//						if (!f)
			//							pinfo.SetValue(targetObject, null, null);
			//						hasbeenset = hasbeenset || f;
			//					}
			//				}
			//			}
			//		}
			//	}
			//}
			//return hasbeenset;

			//// if no object it hasn't been modified
			//if (null == o) return false;

			//// get the modified flag of the current object
			//bool hasbeenset = false;
			//PropertyInfo pi = o.GetType().GetProperty(NexoXSDStrings.NexoHasBeenSetProperty);
			//if (null != pi)
			//{
			//	// get init flag
			//	hasbeenset = (bool)pi.GetValue(o, null);
			//	string nmspace = typeof(SaleToPOIRequest).Namespace;
			//	// look for other objects inside this object
			//	object targetObject = o;// data ?? o;
			//	List<PropertyInfo> properties = targetObject.GetType().GetProperties().ToList();
			//	foreach (PropertyInfo pinfo in properties)
			//	{
			//		object obj = o;
			//		Type type = pinfo.PropertyType;
			//		if (IsSystemObject(pinfo))
			//		{
			//			obj = pinfo.GetValue(o, null);
			//			if (null != obj)
			//				type = obj.GetType();
			//		}
			//		// verify only types defined inside the current namespace, others won't carry the set flag property
			//		if (null != obj &&
			//			  //(nmspace == pinfo.PropertyType.Namespace ||
			//			  //("System" == pinfo.PropertyType.Namespace && pinfo.PropertyType.IsArray)))
			//			  (nmspace == type.Namespace ||
			//			  ("System" == type.Namespace && type.IsArray)))
			//		{
			//			int maxindex = 0;
			//			bool mustOptimize = true;
			//			// if array, an empty array indicates not set
			//			if (pinfo.PropertyType.IsArray)
			//			{
			//				if (null != pinfo.GetValue(targetObject, null))
			//					mustOptimize = 0 != (maxindex = ((Array)pinfo.GetValue(targetObject, null)).Length) && 1 == pinfo.PropertyType.GetArrayRank();
			//				else
			//					mustOptimize = false;
			//			}
			//			// we go inside the property only if optimization is necessary
			//			if (mustOptimize)
			//			{
			//				// we do it only if the property owns other properties (useless otherwise)
			//				List<PropertyInfo> subproperties = pinfo.GetType().GetProperties().ToList();
			//				if (null != subproperties && 0 != subproperties.Count)
			//				{
			//					bool f = false;
			//					if (pinfo.PropertyType.IsArray)
			//					{
			//						Array array = (Array)pinfo.GetValue(targetObject, null);
			//						for (int i = 0; i < array.Length; i++)
			//						{
			//							object arrayObject = array.GetValue(i);
			//							f = Optimize(arrayObject, null, optimize);
			//							//if (!f)
			//							//	array.SetValue(null, i);
			//							hasbeenset = hasbeenset || f;
			//						}
			//					}
			//					//else
			//					//{
			//					//	// the object owns sub properties, we must recurse this processing
			//					//	f = Optimize(pinfo.GetValue(targetObject, null), null);
			//					//	if (!f)
			//					//		pinfo.SetValue(targetObject, null, null);
			//					//	hasbeenset = hasbeenset || f;
			//					//}
			//					else if (pinfo.PropertyType.IsClass)
			//					{
			//						// the object owns sub properties, we must recurse this processing
			//						f = Optimize(pinfo.GetValue(targetObject, null), null, optimize);
			//						//if (!f)
			//						//	pinfo.SetValue(targetObject, null, null);
			//						hasbeenset = hasbeenset || f;
			//					}
			//				}
			//			}
			//		}
			//	}

			//	//if (null != optimizing)
			//	//	optimizing.SetValue(targetObject, false, null);
			//	pi.SetValue(o, hasbeenset, null);



			//	//List<PropertyInfo> internalproperties = targetObject.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).ToList();

			//	//PropertyInfo optimizing = null;
			//	//try
			//	//{
			//	//	// indicate we're optimizing
			//	//	foreach (PropertyInfo prop in internalproperties)
			//	//		if (0 == string.Compare(prop.Name, Strings.OptimizingClassProperty, true))
			//	//		{
			//	//			optimizing = prop;
			//	//			optimizing.SetValue(targetObject, optimize, null);
			//	//			break;
			//	//		}
			//	//	if (null == optimizing)
			//	//	{
			//	//		// strange
			//	//	}
			//}
			//return hasbeenset;

			return true;
		}
		///// <summary>
		///// Allows propagating the value of a bool property from a starting object to its leaves objects
		///// That function DOES NOT SET the requested property inside the starting object
		///// </summary>
		///// <param name="initial">Starting object</param>
		///// <param name="property">Property name to look for and to update</param>
		///// <param name="value">Value to set</param>
		///// <returns>True if the property was found inside the starting object, false otherwise</returns>
		//public static bool SetBoolPropertyValue(object initial, string property, bool value)
		//{
		//	try
		//	{
		//		PropertyInfo pi = initial.GetType().GetProperty(property, typeof(bool));
		//		if (null != pi)
		//		{
		//			// parse all properties inside this class searching for this same property
		//			List<PropertyInfo> properties = initial.GetType().GetProperties().ToList();
		//			foreach (PropertyInfo pinfo in properties)
		//			{
		//				// get the object holding the property we're looking for
		//				object target = FindRealPropertyObject(initial, pinfo, out Type type);
		//				if (null != target)
		//				{
		//					pi = type.GetProperty(property, typeof(bool));
		//					if (null != pi)
		//					{
		//						pi.SetValue(target, value, null);
		//					}
		//				}
		//			}
		//			return true;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, $"Object: {initial.GetType()} - Property name: {property}");
		//	}
		//	return false;
		//}
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
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, $"Object: {type} - Property name: {property} - Value to set: {value}");
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
		//private static bool IsSystemType(Type type)
		//{
		//	return (0 == string.Compare("system", type.Namespace, true));
		//}
		//private static bool IsSystemObject(Type type)
		//{
		//	return IsSystemType(type) && (0 == string.Compare("object", type.Name, true));
		//}
		//private static bool IsArray(Type type)
		//{
		//	return type.IsArray;
		//}
		#endregion
	}
}