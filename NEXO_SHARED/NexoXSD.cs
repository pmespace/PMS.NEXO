using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Linq;
using COMMON;

namespace NEXO
{
	[ComVisible(false)]
	public static class NexoXSDStrings
	{
		public static string XSD = "XSD_";
		public static string NexoOptimizingProperty = $"{XSD}Optimizing";
		public static string NexoOptimizingField = $"_{XSD}Optimizing";
		public static string NexoHasBeenSetProperty = $"{XSD}HasBeenSet";
		public static string NexoHasBeenSetField = $"_{XSD}HasBeenSet";
		public static string NexoDefaultValueForProperty = $"DEFAULT_VALUE";
	}

	public abstract class NexoDummy
	{
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public string MyString { get; set; }
	}
	//public static class NexoTools
	//{
	//	#region methods
	//	///// <summary>
	//	///// 
	//	///// </summary>
	//	///// <param name="initial"></param>
	//	///// <param name="property"></param>
	//	///// <returns></returns>
	//	//private static bool GetBoolPropertyValue(object initial, string property)
	//	//{
	//	//	bool f = false;
	//	//	try
	//	//	{
	//	//		// parse all properties inside this class searching for this same property
	//	//		List<PropertyInfo> properties = initial.GetType().GetProperties().ToList();
	//	//		foreach (PropertyInfo pinfo in properties)
	//	//		{
	//	//			object o = FindRealPropertyObject(initial, pinfo, out Type type);
	//	//			if (null != o)
	//	//			{
	//	//				// is there a similar property ?
	//	//				PropertyInfo pi = type.GetProperty(property);
	//	//				if (null != pi)
	//	//				{
	//	//					// there is, is the object initialised ?
	//	//					object ox = pinfo.GetValue(o, null);
	//	//					if (null != ox)
	//	//					{
	//	//						f |= (bool)pi.GetValue(ox, null);
	//	//						break;
	//	//					}
	//	//				}
	//	//			}
	//	//		}
	//	//	}
	//	//	catch (Exception ex) { }
	//	//	return f;
	//	//}
	//	/// <summary>
	//	/// Allows propagating the value of a bool property from a starting object to its leaves objects
	//	/// That function DOES NOT SET the requested property inside the starting object
	//	/// </summary>
	//	/// <param name="initial">Starting object</param>
	//	/// <param name="property">Property name to look for and to update</param>
	//	/// <param name="value">Value to set</param>
	//	/// <returns>True if the property was found inside the starting object, false otherwise</returns>
	//	public static bool SetBoolPropertyValue(object initial, string property, bool value)
	//	{
	//		try
	//		{
	//			PropertyInfo pi = initial.GetType().GetProperty(property, typeof(bool));
	//			if (null != pi)
	//			{
	//				// parse all properties inside this class searching for this same property
	//				List<PropertyInfo> properties = initial.GetType().GetProperties().ToList();
	//				foreach (PropertyInfo pinfo in properties)
	//				{
	//					// get the object holding the property we're looking for
	//					object target = FindRealPropertyObject(initial, pinfo, out Type type);
	//					if (null != target)
	//					{
	//						pi = type.GetProperty(property, typeof(bool));
	//						if (null != pi)
	//						{
	//							pi.SetValue(target, value, null);
	//						}
	//					}
	//				}
	//				return true;
	//			}
	//		}
	//		catch (Exception ex)
	//		{
	//			CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, $"Object: {initial.GetType()} - Property name: {property}");
	//		}
	//		return false;
	//	}
	//	/// <summary>
	//	/// Return the real object (if any) stored inside a System.Object property
	//	/// </summary>
	//	/// <param name="o">current object containg that property</param>
	//	/// <param name="pinfo">property to look for</param>
	//	/// <param name="type">[OUT] the type of the object stored inside the System.Object (if any, as it may be null)</param>
	//	/// <returns>The real object stored inside a System.Object (if any), the current object if one is stored inside a System.Object, null otherwise</returns>
	//	private static object FindRealPropertyObject(object o, PropertyInfo pinfo, out Type type)
	//	{
	//		object obj = null;
	//		// get the type of the property to check
	//		type = pinfo.PropertyType;
	//		if (IsSystemObject(type) || !IsSystemType(type))
	//		{
	//			// the property is either a System.Object or a non System obejct, get its value to try to find its real type
	//			obj = pinfo.GetValue(o, null);
	//			if (null != obj)
	//				// we found the real type of the object stored inside the System.Object property
	//				type = obj.GetType();
	//		}
	//		return obj;
	//	}
	//	private static bool IsSystemType(Type type)
	//	{
	//		return (0 == string.Compare("system", type.Namespace, true));
	//	}
	//	private static bool IsSystemObject(Type type)
	//	{
	//		return IsSystemType(type) && (0 == string.Compare("object", type.Name, true));
	//	}
	//	private static bool IsArray(Type type)
	//	{
	//		return type.IsArray;
	//	}
	//	#endregion

	//[ComVisible(false)]
	//public abstract class NexoXSD
	//{
	//	#region constructor
	//	public NexoXSD()
	//	{
	//		//NexoHasBeenSetField = NexoOptimizingField = false;
	//	}
	//	#endregion

	//	#region properties
	//	[System.Xml.Serialization.XmlIgnoreAttribute()]
	//	public bool NexoHasBeenSetProperty
	//	{
	//		get => NexoHasBeenSetField;// | GetBoolPropertyValue(this, NexoXSDStrings.NexoHasBeenSetProperty);
	//		set => NexoHasBeenSetField = value;
	//	}
	//	internal bool NexoHasBeenSetField;
	//	[System.Xml.Serialization.XmlIgnoreAttribute()]
	//	public bool NexoOptimizingProperty
	//	{

	//		get => NexoOptimizingField;
	//		set //=> NexoOptimizingField = value;
	//		{
	//			NexoOptimizingField = value;
	//			SetBoolPropertyValue(NexoXSDStrings.NexoOptimizingProperty, NexoOptimizingField);
	//		}
	//	}
	//	internal bool NexoOptimizingField;
	//	#endregion

	//	#region methods
	//	private static bool GetBoolPropertyValue(object initial, string property)
	//	{
	//		bool f = false;
	//		try
	//		{
	//			// parse all properties inside this class searching for this same property
	//			List<PropertyInfo> properties = initial.GetType().GetProperties().ToList();
	//			foreach (PropertyInfo pinfo in properties)
	//			{
	//				object o = FindRealPropertyObject(initial, pinfo, out Type type);
	//				if (null != o)
	//				{
	//					// is there a similar property ?
	//					PropertyInfo pi = type.GetProperty(property);
	//					if (null != pi)
	//					{
	//						// there is, is the object initialised ?
	//						object ox = pinfo.GetValue(o, null);
	//						if (null != ox)
	//						{
	//							f |= (bool)pi.GetValue(ox, null);
	//							break;
	//						}
	//					}
	//				}
	//			}
	//		}
	//		catch (Exception ex) { }
	//		return f;
	//	}
	//	private static void SetBoolPropertyValue(object initial, string property, bool value)
	//	{
	//		try
	//		{
	//			// parse all properties inside this class searching for this same property
	//			List<PropertyInfo> properties = initial.GetType().GetProperties().ToList();
	//			foreach (PropertyInfo pinfo in properties)
	//			{
	//				// get the object holding the property we're looking for
	//				object target = FindRealPropertyObject(initial, pinfo, out Type type);
	//				if (null != target)
	//				{
	//					PropertyInfo pi = type.GetProperty(property, typeof(bool));
	//					if (null != pi)
	//					{
	//						pi.SetValue(target, value, null);
	//					}
	//				}
	//			}
	//		}
	//		catch (Exception ex) { }
	//	}
	//	/// <summary>
	//	/// Return the real object (if any) stored inside a System.Object property
	//	/// </summary>
	//	/// <param name="o">current object containg that property</param>
	//	/// <param name="pinfo">property to look for</param>
	//	/// <param name="type">[OUT] the type of the object stored inside the System.Object (if any, as it may be null)</param>
	//	/// <returns>The real object stored inside a System.Object (if any), the current object if one is stored inside a System.Object, null otherwise</returns>
	//	private static object FindRealPropertyObject(object o, PropertyInfo pinfo, out Type type)
	//	{
	//		object obj = null;
	//		// get the type of the property to check
	//		type = pinfo.PropertyType;
	//		if (IsSystemObject(type) || !IsSystemType(type))
	//		{
	//			// the property is either a System.Object or a non System obejct, get its value to try to find its real type
	//			obj = pinfo.GetValue(o, null);
	//			if (null != obj)
	//				// we found the real type of the object stored inside the System.Object property
	//				type = obj.GetType();
	//		}
	//		return obj;
	//	}
	//	private static bool IsSystemType(Type type)
	//	{
	//		return (0 == string.Compare("system", type.Namespace, true));
	//	}
	//	private static bool IsSystemObject(Type type)
	//	{
	//		return IsSystemType(type) && (0 == string.Compare("object", type.Name, true));
	//	}
	//	private static bool IsArray(Type type)
	//	{
	//		return type.IsArray;
	//	}
	//	#endregion
	//}
}
