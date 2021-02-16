using System.Runtime.InteropServices;
using System.Globalization;
using System;
using System.Text.RegularExpressions;
using System.Resources;
using System.Collections.Generic;
using System.Reflection;

#if !NET35
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif

using NEXO.Properties;
using COMMON;

namespace NEXO
{
	[ComVisible(false)]
	public static class MyExtensions
	{
		///// <summary>
		///// Extension making sure the decimal always contains at least one digit (eventually x.0)
		///// </summary>
		///// <param name="value">The double to process</param>
		///// <param name="min">Indicates the minimum number of digits to use</param>
		///// <returns></returns>
		//public static string ToSpecificFormat(this decimal value, uint min = 0)
		//{
		//	var count = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
		//	return value.ToString(count <= min ? "N" + min : "N" + count, CultureInfo.InvariantCulture);
		//}

		/// <summary>
		/// Extension making sure the decimal always contains at least one digit (eventually x.0)
		/// </summary>
		/// <param name="value">The double to process</param>
		/// <param name="min">Indicates the minimum number of digits to use</param>
		/// <param name="decimalSeparator">Indicates the decimal separator to use</param>
		/// <returns></returns>
		public static string ToSpecificFormat(this double value, uint min = 0, string decimalSeparator = ".")
		{
			return value.ToString("0" + (0 != min ? decimalSeparator + new string('0', (int)min) : null), CultureInfo.InvariantCulture);
		}
	}

	//	[ComVisible(false)]
	//	public static class NexoVersion
	//	{
	//#if NEXO30
	//		public static readonly string Long = "Protocol Version 3.0 - Document Version 3.0 - 3 October 2016";
	//		public static readonly string Short = "3.0";
	//		public static readonly string StartName = "nexo30";
	//#elif NEXO31
	//		public static readonly string Long = "Protocol Version 3.1 - Document Version 3.1 - 31 July 2017";
	//		public static readonly string Short = "3.1";
	//		public static readonly string StartName = "nexo31";
	//#endif
	//	}

	//	[ComVisible(false)]
	//	public class NexoVersion
	//	{
	//		public string Version { get; set; }
	//		public string Description { get; set; }
	//		public string ResourceName { get; set; }
	//		public string AssemblyName { get; set; }
	//		public override string ToString()
	//		{
	//			return Version;
	//		}
	//	}

	//	[ComVisible(false)]
	//	public class NexoSupportedVersions : Dictionary<string, NexoVersion>
	//	{
	//		#region constructor
	//		public NexoSupportedVersions()
	//		{
	//			NexoVersion version = new NexoVersion()
	//			{
	//				Description = "Version 3.0 - 3 October 2016",
	//				ResourceName = "nexo30",
	//				AssemblyName = "PMS.NEXO30.dll",
	//				Version = "3.0",
	//			};
	//			Add(version.Version, version);

	//#if !NET35
	//			version = new NexoVersion()
	//			{
	//				Description = "Version 3.1 - 31 July 2017",
	//				ResourceName = "nexo31",
	//				AssemblyName = "PMS.NEXO31.dll",
	//				Version = "3.1",
	//			};
	//			Add(version.Version, version);
	//#endif
	//		}
	//		#endregion
	//	}

	//	[ComVisible(false)]
	//	public static class NexoCurrentVersion
	//	{
	//		public static NexoVersion Version = null;
	//	}

	[ComVisible(true)]
	public enum NexoValues
	{
		None = 0xFFFF,
	}

	[ComVisible(false)]
	public abstract class NexoType
	{
		#region properties
		/// <summary>
		/// Variable name
		/// </summary>
		public string Name { get => _name; set => _name = SetName(value); }
		private string _name = string.Empty;
		#endregion

		#region constuctors
		public NexoType() { }
		public NexoType(string name) { Name = name; }
		#endregion

		#region methods
		/// <summary>
		/// Specify how to set the Name property
		/// </summary>
		/// <param name="value">Actual proposition to set the Name property value</param>
		/// <returns>ACtual value to use</returns>
		protected virtual string SetName(string value) { return value.Trim(); }
		#endregion
	}

	[Guid("81DBF2A7-F56C-4316-A7DA-84A69DD10193")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoTextString
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(3)]
		string DefaultValue { get; }
		[DispId(4)]
		string RegularExpression { get; set; }
		[DispId(5)]
		bool TrimInput { get; set; }
		[DispId(6)]
		bool CaseInsensitive { get; set; }
		[DispId(7)]
		bool PreserveCase { get; set; }
		[DispId(8)]
		bool SetToUpperCase { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }
		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);
	}
	[Guid("8F565B94-FC31-4938-BB9B-3628D74AA348")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoTextString : NexoType, INexoTextString
	{
		#region properties
		/// <summary>
		/// Variable value as a string
		/// </summary>
		public string Value { get => GetValue(_value); set => _value = SetValue(value); }
		private string _value = null;
		/// <summary>
		/// Default value as a string
		/// </summary>
		public string DefaultValue { get => GetDefaultValue(_defaultvalue); protected set => _defaultvalue = SetDefaultValue(value); }
		private string _defaultvalue = null;
		/// <summary>
		/// Regular expression piloting how Value can be set
		/// </summary>
		public string RegularExpression { get => GetRegularExpression(_regex); set => _regex = SetRegularExpression(value); }
		private string _regex = string.Empty;
		/// <summary>
		/// Indicates whether Value is empty
		/// </summary>
		public bool IsEmpty { get => string.IsNullOrEmpty(Value); }
		/// <summary>
		/// Indicates whether last Value assignment was successful or not
		/// </summary>
		public bool IsUnset { get; protected set; } = false;
		/// <summary>
		/// TrimInput value before setting it or not
		/// </summary>
		public virtual bool TrimInput { get; set; } = true;
		/// <summary>
		/// Check case when testing regular expressions
		/// </summary>
		public virtual bool CaseInsensitive { get; set; } = true;
		/// <summary>
		/// Conserve original case when saving data
		/// </summary>
		public virtual bool PreserveCase { get; set; } = true;
		/// <summary>
		/// If case is not kept, determine how to set the value (lowe ror upper case)
		/// </summary>
		public virtual bool SetToUpperCase { get; set; } = false;
		#endregion

		#region constructor
		public NexoTextString() { }
		public NexoTextString(string name, string regex = "") : base(name) { RegularExpression = regex; }
		#endregion

		#region methods
		/// <summary>
		/// Returns the value to exhibit for the <see cref="Value"/> property
		/// </summary>
		/// <param value="value">Current value of the <see cref="Value"/> property</param>
		/// <returns>The actual value to exhibit</returns>
		protected virtual string GetValue(string value) { return value; }
		/// <summary>
		/// Prepare the value to store inside the <see cref="Value"/> property
		/// </summary>
		/// <param name="value">The actual input value, which might need adjustment</param>
		/// <returns>The actual value to store</returns>
		protected virtual string SetValue(string value)
		{
			IsUnset = !TestValue(ref value);
			return value;
		}
		/// <summary>
		/// Validates a string against the current regular expression
		/// </summary>
		/// <param name="value">The string to validate on entry, the validated string on exit (an empty string if the string on entry did not match the regular expression)</param>
		/// <returns>True if the string is valid, false otherwise</returns>
		public bool TestValue(ref string value)
		{
			if (null == value)
				return false;
			string s = AdjustInputData(value);
			value = string.Empty;
			if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(RegularExpression))
			{
				Match match = Regex.Match(s, RegularExpression, (CaseInsensitive ? RegexOptions.IgnoreCase : RegexOptions.None));
				if (match.Success)
					// set the value to store inside the property
					value = match.Value;
				else
					// impossible to set the value
					return false;
			}
			else
				value = s;
			return true;
		}
		/// <summary>
		/// Returns the value to exhibit for the <see cref="DefaultValue"/> property
		/// </summary>
		/// <param value="value">Current value of the <see cref="DefaultValue"/> property</param>
		/// <returns>The actual value to exhibit</returns>
		protected virtual string GetDefaultValue(string value) { return value; }
		/// <summary>
		/// Prepare the value to store inside the <see cref="DefaultValue"/> property
		/// </summary>
		/// <param name="value">The actual input value, which might need adjustment</param>
		/// <returns>The actual value to store</returns>
		protected virtual string SetDefaultValue(string value) { TestValue(ref value); return value; }
		/// <summary>
		/// Returns the value to exhibit for the <see cref="RegularExpression"/> property
		/// Retunr
		/// </summary>
		/// <param value="value">Current value of the <see cref="RegularExpression"/> property</param>
		/// <returns>The actual value to exhibit</returns>
		protected virtual string GetRegularExpression(string value) { return value; }
		/// <summary>
		/// Prepare the value to store inside the <see cref="RegularExpression"/> property
		/// </summary>
		/// <param name="value">The actual input value, which might need adjustment</param>
		/// <returns>The actual value to store</returns>
		protected virtual string SetRegularExpression(string value) { return value.Trim(); }
		/// <summary>
		/// Set the input value according to the desired way to handle it
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		protected virtual string AdjustInputData(string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;
			if (TrimInput)
				value = value.Trim();
			if (CaseInsensitive)
				if (!PreserveCase)
					if (SetToUpperCase)
						value = value.ToUpper();
					else
						value = value.ToLower();
			return value;
		}
		/// <summary>
		/// String representation of the data
		/// </summary>
		/// <returns></returns>
		public override string ToString() { return Value; }
		#endregion
	}

	[Guid("54927BBD-044C-4FF6-90B9-9EF4C97DF13E")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoBooleanType
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(50)]
		bool AsBoolean { get; set; }
	}
	[Guid("C9E4530A-BCB7-437D-B814-D3BF11026D07")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoBoolean : NexoTextString, INexoBooleanType
	{
		#region properties
		public override bool TrimInput { get => true; }
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => false; }
		public override bool SetToUpperCase { get => false; }
		public bool AsBoolean
		{
			get => ToBoolean();
			set => FromBoolean(value);
		}
		#endregion

		#region constructor
		public NexoBoolean() { }
		public NexoBoolean(string name) : base(name) { }
		#endregion

		#region methods
		protected override string GetRegularExpression(string value) { return @"^(true|false)$"; }
		private bool ToBoolean() { return @"true" == (null != Value ? Value.ToLower() : default(bool).ToString()); }
		private void FromBoolean(bool b) { Value = b.ToString().ToLower(); }
		#endregion
	}

	[Guid("D54E0EEC-3021-430A-958A-0CE8CBAF28CF")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoInteger
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(50)]
		int AsInteger { get; set; }
	}
	[Guid("95B80346-5CA9-4F43-98E1-58B4A7C02736")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoInteger : NexoTextString, INexoInteger
	{
		#region properties
		public override bool TrimInput { get => true; }
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => true; }
		public override bool SetToUpperCase { get => false; }
		public virtual int AsInteger
		{
			get => ToInteger();
			set => Value = value.ToString(CultureInfo.InvariantCulture);
		}
		#endregion

		#region constructor
		public NexoInteger() { }
		public NexoInteger(string name) : base(name) { }
		#endregion

		#region methods
		protected override string GetValue(string value)
		{
			try
			{
				int i = int.Parse(value);
				return i.ToString(CultureInfo.InvariantCulture);
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex, "Value: " + value); }
			return null;
		}
		protected override string GetRegularExpression(string value) { return @"^[-+]?([1]?[0-9]{0,9}|20[0-9]{0,8}|21[0-3]?[0-9]{0,7}|214[0-6]?[0-9]{0,6}|2147[0-3]?[0-9]{0,5}|21474[0-7]?[0-9]{0,4}|214748[0-2]?[0-9]{0,3}|2147483[0-5]?[0-9]{0,2}|21474836[0-3]?[0-9]{0,1}|214748364[0-7]?)$"; }
		private int ToInteger()
		{
			try
			{ return int.Parse(Value); }
			catch (Exception)
			{ return 0; }
		}
		#endregion
	}

	[Guid("D6A6402E-7675-4B58-A192-1E5831A63308")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoDecimal
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(50)]
		double AsDecimal { get; set; }
		[DispId(51)]
		uint DecimalPlaces { get; set; }
		[DispId(52)]
		uint Mantis { get; set; }
		[DispId(53)]
		string DecimalSeparator { get; }
	}
	[Guid("6B3992EA-EA2A-40CE-8D32-759442C3733F")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoDecimal : NexoTextString, INexoDecimal
	{
		#region properties
		public virtual uint DecimalPlaces
		{
			get => _decimal;
			set
			{
				if (0 == MaxDecimalPlaces || MaxDecimalPlaces >= value)
				{
					_decimal = value;
					Value = SetValue(Value);
				}
			}
		}
		private uint _decimal = 0;
		public virtual uint Mantis
		{
			get => _mantis;
			set
			{
				if (0 == MaxMantis || MaxMantis >= value)
				{
					_mantis = value;
					Value = SetValue(Value);
				}
			}
		}
		private uint _mantis = 0;
		public string DecimalSeparator { get => @"."; }
		public virtual uint MaxDecimalPlaces
		{
			get => _maxdecimalplaces;
			set
			{
				_maxdecimalplaces = value;
				if (0 != MaxDecimalPlaces && MaxDecimalPlaces < _decimal) _decimal = _maxdecimalplaces;
			}
		}
		private uint _maxdecimalplaces = 0;
		public virtual uint MaxMantis
		{
			get => _maxmantis;
			set
			{
				_maxmantis = value;
				if (0 != MaxMantis && MaxMantis < Mantis) _mantis = _maxmantis;
			}
		}
		private uint _maxmantis = 0;
		/// <summary>
		/// Allows setting and retrieving the decimal value
		/// </summary>
		public double AsDecimal
		{
			get => ToDecimal();
			set
			{
				try
				{
					Value = value.ToSpecificFormat(DecimalPlaces);
					//Value = value.ToString("0" + (0 != DecimalPlaces ? DecimalSeparator + new string('0', (int)DecimalPlaces) : null), CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					IsUnset = true;
				}
			}
		}
		#endregion

		#region constructor
		public NexoDecimal() { }
		public NexoDecimal(string name) : base(name) { }
		#endregion

		#region methods
		protected override string GetValue(string value)
		{
			try
			{
				//return decimal.Parse(value, CultureInfo.InvariantCulture).ToSpecificFormat(DecimalPlaces);
				return double.Parse(value, CultureInfo.InvariantCulture).ToSpecificFormat(DecimalPlaces);
			}
			catch (Exception)
			{ return null; }
		}
		protected override string GetRegularExpression(string value)
		{
			string s = @"^" +
				@"[0-9]" + (0 == MaxMantis && 0 == Mantis ? @"*" : 0 == MaxMantis ? @"{" + Mantis + @",}" : 0 == Mantis ? @"{0," + MaxMantis + @"}" : @"{" + Mantis + "," + MaxMantis + @"}") +
				@"\" + DecimalSeparator + "?" +
				@"[0-9]" + (0 == MaxDecimalPlaces && 0 == DecimalPlaces ? @"*" : 0 == MaxDecimalPlaces ? @"{" + DecimalPlaces + @",}" : 0 == DecimalPlaces ? @"{0," + MaxDecimalPlaces + @"}" : @"{" + DecimalPlaces + "," + MaxDecimalPlaces + @"}") +
				@"$";
			return s;
		}
		//private decimal ToDecimal()
		private double ToDecimal()
		{
			try
			{
				//return decimal.Parse(Value, CultureInfo.InvariantCulture);
				return double.Parse(Value, CultureInfo.InvariantCulture);
			}
			catch (Exception)
			{ return 0; }
		}
		#endregion
	}
	[Guid("7140D640-7DEF-48A8-8C51-F348849BB383")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoSimpleAmount : NexoDecimal, INexoDecimal
	{
		#region constructor
		public NexoSimpleAmount() { Initialize(); }
		public NexoSimpleAmount(string name) : base(name) { Initialize(); }
		private void Initialize() { MaxDecimalPlaces = 6; MaxMantis = 8; }
		#endregion
	}

	[Guid("B1212D60-971B-4FB3-BE41-EC87DD743EFB")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoLabel
	{
		[DispId(1)]
		string Label { get; set; }
		[DispId(100)]
		string ToString();
	}
	/// <summary>
	/// class describing a label
	/// </summary>
	[Guid("313ED1FA-F6E9-402D-803C-F6C2A97AEAB2")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoLabel : INexoLabel
	{
		#region constructor
		public NexoLabel() { }
		public NexoLabel(string label) { Label = label; }
		#endregion

		#region properties
		public string Label { get; set; } = null;
		#endregion

		#region methods
		public override string ToString() { return Label; }
		#endregion
	}
	[Guid("44DD3DF5-C824-4E2D-8727-9F1856EB8019")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoEnumeration
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }

		[DispId(50)]
		int LabelsCount { get; }
		[DispId(51)]
		bool IsLabel(string value);
		[DispId(52)]
		string GetLabel(string value);
		[DispId(53)]
		bool AddLabel(string value);
		[DispId(54)]
		bool RemoveLabel(string value);
	}
	[Guid("DCE824A5-EF4D-4DDF-9F28-ECC997E912B8")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoEnumeration : NexoTextString, INexoEnumeration
	{
		#region constructor
		public NexoEnumeration() { }
		public NexoEnumeration(string name) : base(name) { }
		#endregion

		#region properties
		/// <summary>
		/// JSON items from the resource
		/// </summary>
		private class NexoItems { public List<string> Items { get; set; } }
		/// <summary>
		/// dictionary of all labels valid in this enumeration
		/// </summary>
		[ComVisible(false)]
		public class NexoLabels : Dictionary<string, NexoLabel> { public NexoLabels() : base(StringComparer.CurrentCultureIgnoreCase) { } }
		public NexoLabels Labels { get; private set; } = new NexoLabels();
		/// <summary>
		/// Number of labels inside the list
		/// </summary>
		public int LabelsCount { get => Labels.Count; }
		public override bool TrimInput { get => true; }
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => true; }
		public override bool SetToUpperCase { get => false; }
		#endregion

		#region methods
		protected override string GetRegularExpression(string value) { return string.Empty; }
		/// <summary>
		/// Indicates whether a passed value is valid or not
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool IsLabel(string value)
		{
			try
			{
				string s = Labels[AdjustInputData(value)].Label;
				return true;
			}
			catch (Exception) { }
			return false;
		}
		/// <summary>
		/// Indicates whether a passed value is valid or not
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public string GetLabel(string value)
		{
			try
			{
				string s = Labels[AdjustInputData(value)].Label;
				return s;
			}
			catch (Exception) { }
			return null;
		}
		/// <summary>
		/// Allows to add to the list of existing labels
		/// </summary>
		/// <param name="value"></param>
		/// <returns>TRUE if added, FALSE otherwise</returns>
		public bool AddLabel(string value)
		{
			try
			{
				value = AdjustInputData(value);
				Labels.Add(value, new NexoLabel(value));
				return true;
			}
			catch (Exception) { }
			return false;
		}
		/// <summary>
		/// Allows to remove a label from the list of existing labels
		/// </summary>
		/// <param name="value"></param>
		/// <returns>TRUE if removed, FALSE otherwise</returns>
		public bool RemoveLabel(string value)
		{
			try
			{
				value = AdjustInputData(value);
				Labels.Remove(value);
				return true;
			}
			catch (Exception) { }
			return false;
		}
		protected override string SetValue(string value)
		{
			string valueToStore;
			try
			{
				valueToStore = Labels[value].Label;
				// arrived here the value is valid and is accepted
			}
			catch (Exception ex)
			{
				//CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				// arrived here the value is not valid, we ignore it
				valueToStore = null;
			}
			return valueToStore;
		}
		protected override string SetName(string value)
		{
			value = value.Trim();
			Labels = new NexoLabels();
			// load the associated values, if any...
			try
			{
				// search the enumeration applying to this object, based on passed name
				Type type = null;
				//string[] names = GetEnumType(Assembly.GetExecutingAssembly().GetName().Name + "." + value + "Enumeration", out type);// value + "Enumeration");
				string[] names = GetEnumType("NEXO" + "." + value + "Enumeration", out type);// value + "Enumeration");
				if (null != names && 0 != names.Length)
				{
					// arrived here we can save a list of valid items for that data
					foreach (string k in names)
						try
						{ Labels.Add(k, new NexoLabel(k)); }
						catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
				}
			}
			catch (Exception ex) { CLog.AddException(MethodBase.GetCurrentMethod().Name, ex); }
			return value;
		}
		/// <summary>
		/// Get the enum type linked to the enumeration to represent
		/// </summary>
		/// <param name="enumName">Name of the enum to look for</param>
		/// <param name="type">The enum type found</param>
		/// <returns></returns>
		public static string[] GetEnumType(string enumName, out Type type)
		{
			type = null;
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				type = assembly.GetType(enumName);
				if (null != type && type.IsEnum)
					return Enum.GetNames(type);
			}
			return null;
		}
		public List<string> AllLabels()
		{
			return new List<string>(Labels.Keys);
		}
		#endregion
	}

	[Guid("CF6E62CA-537D-4545-A336-673D288B6D58")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoCluster
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }

		[DispId(50)]
		int LabelsCount { get; }
		[DispId(51)]
		int ValuesCount { get; }
		[DispId(52)]
		bool IsLabel(string value);
		[DispId(53)]
		bool AddLabel(string value);
		[DispId(54)]
		bool RemoveLabel(string value);
		[DispId(55)]
		bool IsLabelSet(string value);
		[DispId(56)]
		string SetLabel(string label);
		[DispId(57)]
		string UnsetLabel(string label);
		[DispId(58)]
		string SetAllLabels();
		[DispId(59)]
		string UnsetAllLabels();
	}
	[Guid("8E5E348A-9E41-44B6-AA24-366B1E0BFAEF")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCluster : NexoEnumeration, INexoCluster
	{
		#region constructor
		public NexoCluster() { }
		public NexoCluster(string name) : base(name) { }
		#endregion

		#region property
		public int ValuesCount { get => Values.Count; }
		private NexoLabels Values { get; set; } = new NexoLabels();
		#endregion

		#region methods
		protected override string GetValue(string value)
		{
			bool first = true;
			string s = string.Empty;
			foreach (KeyValuePair<string, NexoLabel> kv in Values)
			{
				if (!first)
					s += " ";
				s += kv.Key;
				first = false;
			}
			return s;
		}
		/// <summary>
		/// Indicates whether a label is used inside the value part or not
		/// </summary>
		/// <param name="value">The label to look for</param>
		/// <returns>TRUE is part of, FALSE otherwise</returns>
		public bool IsLabelSet(string value)
		{
			try
			{
				value = AdjustInputData(value);
				value = Values[value].Label;
				return true;
			}
			catch (Exception) { }
			return false;
		}
		/// <summary>
		/// Add a label to the list of labels
		/// </summary>
		/// <param name="label">The label to add, it has to be inside the Labels loaded for the data</param>
		/// <returns>The value of the cluster after the operation</returns>
		public string SetLabel(string label)
		{
			label = AdjustInputData(label);
			try
			{
				NexoLabel lbl = Labels[label];
				Values.Add(lbl.Label, lbl);
			}
			catch (Exception) { }
			return Value;
		}
		/// <summary>
		/// Add several labels to the list of labels
		/// </summary>
		/// <param name="labels">The list of labels to add, it has to be inside the Labels loaded for the data</param>
		/// <returns>The value of the cluster after the operation</returns>
		public string SetLabels(string[] labels)
		{
			foreach (string label in labels)
				SetLabel(label);
			return Value;
		}
		/// <summary>
		/// Remove a label from the list of labels
		/// </summary>
		/// <param name="label">The label to remove</param>
		/// <returns>The value of the cluster after the operation</returns>
		public string UnsetLabel(string label)
		{
			label = AdjustInputData(label);
			try
			{
				Values.Remove(label);
			}
			catch (Exception) { }
			return Value;
		}
		/// <summary>
		/// Remove several labels from the list of labels
		/// </summary>
		/// <param name="labels">The labels to remove</param>
		/// <returns>The value of the cluster after the operation</returns>
		public string UnsetLabels(string[] labels)
		{
			foreach (string label in labels)
				UnsetLabel(label);
			return Value;
		}
		/// <summary>
		/// Set all available labels
		/// </summary>
		/// <returns>The value of the cluster after the operation</returns>
		public string SetAllLabels()
		{
			foreach (KeyValuePair<string, NexoLabel> kv in Labels)
				SetLabel(kv.Key);
			return Value;
		}
		/// <summary>
		/// IsUnset all available labels
		/// </summary>
		/// <returns>The value of the cluster after the operation</returns>
		public string UnsetAllLabels()
		{
			foreach (KeyValuePair<string, NexoLabel> kv in Labels)
				UnsetLabel(kv.Key);
			return Value;
		}
		#endregion
	}

	[Guid("380807B4-5276-443B-A8E8-0D88A51199E8")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoLengthDrivenTextString
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(3)]
		string DefaultValue { get; }
		[DispId(4)]
		string RegularExpression { get; set; }
		[DispId(5)]
		bool TrimInput { get; set; }
		[DispId(6)]
		bool CaseInsensitive { get; set; }
		[DispId(7)]
		bool PreserveCase { get; set; }
		[DispId(8)]
		bool SetToUpperCase { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(50)]
		int Min { get; set; }
		[DispId(51)]
		int Max { get; set; }
		[DispId(52)]
		string CharacterSet { get; set; }
	}
	[Guid("D9CF8D0F-FEBB-4FE8-A775-91C0BB6DBF3D")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoLengthDrivenTextString : NexoTextString, INexoLengthDrivenTextString
	{
		#region properties
		/// <summary>
		/// Min length or number of items, depending of the type
		/// </summary>
		public virtual int Min
		{
			get => _min;
			set
			{
				_min = value;
				if (Max < Min)
					_max = value;
			}
		}
		private int _min = 0;
		/// <summary>
		/// Max length or number of items, depending of the type
		/// </summary>
		public virtual int Max
		{
			get => _max;
			set
			{
				_max = value;
				if (Min > Max)
					_min = value;
			}
		}
		private int _max = 0;
		/// <summary>
		/// Regular expression cardinality
		/// </summary>
		protected string MinMax { get => (0 == Min && 0 == Max ? "*" : (0 == Max ? "{" + Min + ",}" : "{" + Min + "," + Max + "}")); }
		/// <summary>
		/// Character set to use for that string
		/// </summary>
		public string CharacterSet { get => GetCharacterSet(_characterset); set => _characterset = SetCharacterSet(value); }
		private string _characterset = string.Empty;
		#endregion

		#region constuctors
		public NexoLengthDrivenTextString() { }
		public NexoLengthDrivenTextString(string name, string characterSet = "", int min = 0, int max = 0) : base(name) { CharacterSet = characterSet; Min = min; Max = max; }
		#endregion

		#region methods
		/// <summary>
		/// Returns the value to exhibit for the <see cref="CharacterSet"/> property
		/// </summary>
		/// <param value="value">Current value of the <see cref="CharacterSet"/> property</param>
		/// <returns>The actual value to exhibit</returns>
		protected virtual string GetCharacterSet(string value) { return value; }
		/// <summary>
		/// Prepare the value to store inside the <see cref="CharacterSet"/> property
		/// </summary>
		/// <param name="value">The actual input value, which might need adjustment</param>
		/// <returns>The actual value to store</returns>
		protected virtual string SetCharacterSet(string value) { return value.Trim(); }
		protected override string GetRegularExpression(string value) { return @"^" + (string.IsNullOrEmpty(CharacterSet) ? @"." : CharacterSet) + MinMax + "$"; ; }
		#endregion
	}

	[Guid("4DEDF6AC-8EF9-41EC-92CD-51A2E7E5FC6F")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoDigitString
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(9)]
		bool IsEmpty { get; }
		[DispId(10)]
		bool IsUnset { get; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(50)]
		int Min { get; set; }
		[DispId(51)]
		int Max { get; set; }
		[DispId(52)]
		string CharacterSet { get; }
	}
	[Guid("09364674-1CA8-4448-8099-35C44F32305E")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoDigitString : NexoLengthDrivenTextString, INexoDigitString
	{
		#region properties
		public override bool TrimInput { get => true; }
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => true; }
		public override bool SetToUpperCase { get => false; }
		#endregion

		#region constructor
		public NexoDigitString() { }
		public NexoDigitString(string name, int min = 0, int max = 0) : base(name, string.Empty, min, max) { }
		#endregion

		#region methods
		protected override string GetCharacterSet(string value) { return @"[0-9]"; }
		#endregion
	}

	[Guid("342FE081-D5F0-475B-AEC6-6374979BBDC7")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoISOData
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);
	}
	[ComVisible(false)]
	public abstract class NexoISOData : NexoLengthDrivenTextString
	{
		#region properties
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => false; }
		public override bool SetToUpperCase { get => true; }
		#endregion

		#region constructor
		public NexoISOData() { }
		public NexoISOData(string name, int min = 0, int max = 0) : base(name, string.Empty) { Min = min; Max = max; }
		#endregion

		#region methods
		protected override string GetCharacterSet(string value) { return @"[A-Z]"; }
		#endregion
	}
	[Guid("D778424B-0BE8-4907-9998-FFBEE38A9D9D")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoISOCurrency3A : NexoISOData, INexoISOData
	{
		#region properties
		public override int Min { get => 3; }
		public override int Max { get => 3; }
		#endregion

		#region constructor
		public NexoISOCurrency3A() { }
		public NexoISOCurrency3A(string name) : base(name, 3, 3) { }
		#endregion
	}
	[Guid("969B3F3F-C827-4244-83AE-0CA5A56CB4DA")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoISOCountry3A : NexoISOData, INexoISOData
	{
		#region properties
		public override int Min { get => 3; }
		public override int Max { get => 3; }
		#endregion

		#region constructor
		public NexoISOCountry3A() { }
		public NexoISOCountry3A(string name) : base(name, 3, 3) { }
		#endregion
	}
	[Guid("6D548B98-DCA5-42B3-8D67-E2796A47AB40")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoISOLanguage2A : NexoISOData, INexoISOData
	{
		#region properties
		public override bool SetToUpperCase { get => false; }
		public override int Min { get => 2; }
		public override int Max { get => 2; }
		#endregion

		#region constructor
		public NexoISOLanguage2A() { Init(); }
		public NexoISOLanguage2A(string name) : base(name, 3, 3) { Init(); }
		private void Init()
		{
			string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
			DefaultValue = (2 == language.Length ? language : "en");
		}
		#endregion
	}
	[ComVisible(false)]
	public abstract class NexoISODateTimeBase : NexoTextString
	{
		#region properties
		public override bool TrimInput { get => true; }
		public override bool CaseInsensitive { get => true; }
		public override bool PreserveCase { get => true; }
		public override bool SetToUpperCase { get => true; }
		/// <summary>
		/// Indicates whether Value must show in UTC
		/// </summary>
		public bool Utc { get; set; } = false;
		protected DateTime Dt
		{
			get => _dt;
			set
			{
				_dt = value;
				long elapsedTicks = _dt.Ticks - new DateTime(_dt.Year, _dt.Month, _dt.Day, _dt.Hour, _dt.Minute, _dt.Second, _dt.Millisecond).Ticks;
				TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
				_dt = _dt.Subtract(elapsedSpan);
			}
		}
		private DateTime _dt = default(DateTime);
		#endregion

		#region constructor
		public NexoISODateTimeBase() { Dt = DateTime.Now; }
		public NexoISODateTimeBase(string name) : base(name) { Dt = DateTime.Now; }
		#endregion

		#region methods
		/// <summary>
		/// Reset the value to the current date and time
		/// </summary>
		public void Reset() { Dt = DateTime.Now; }
		/// <summary>
		/// Get the DateTime from the Value
		/// </summary>
		/// <returns>The DateTime value</returns>
		public DateTime ToDateTime() { return Dt; }
		/// <summary>
		/// Set the Nexo date time from a DateTime
		/// </summary>
		/// <param name="dt">Datetime to use</param>
		/// <returns>The nexo date time set</returns>
		public string FromDateTime(DateTime dt) { Dt = dt; return Value; }
		#endregion
	}

	[Guid("6EA56916-0B9F-48D1-B726-1F26C1897724")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoISODateTime
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(3)]
		bool Utc { get; set; }
		[DispId(4)]
		bool Milliseconds { get; set; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(300)]
		void Reset();
		[DispId(301)]
		DateTime ToDateTime();
		[DispId(302)]
		string FromDateTime(DateTime dt);
	}
	[Guid("91C85C90-6D2B-4762-88BE-B96A9C275DE9")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoISODateTime : NexoISODateTimeBase, INexoISODateTime
	{
		#region properties
		/// <summary>
		/// Indicates whether Value must show milliseconds
		/// </summary>
		public bool Milliseconds { get; set; } = false;
		#endregion

		#region constructor
		public NexoISODateTime() { }
		public NexoISODateTime(string name) : base(name) { }
		#endregion

		#region methods
		protected override string GetValue(string value) { return DateTimeToString(Dt, Utc, Milliseconds); }
		protected override string SetValue(string value) { return DateTimeToString(StringToDateTime(value), Utc, Milliseconds); }
		protected override string GetRegularExpression(string value) { return @"^([0-9]{4}-(0[1-9]|1[0-2])-([0-2][1-9]|3[0-1])T([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9])(\.[0-9]{1,3})?(Z|[+-](([01][0-9])|(2[0-3])):[0-5][0-9])$"; }
		/// <summary>
		/// Get the current date and time
		/// </summary>
		/// <param name="utc">True if the resulting string must show UTC datetime</param>
		/// <param name="milliseconds">True if the resulting string must show milliseconds</param>
		/// <returns>The current date time in Nexo format</returns>
		public static string CurrentDateTime(bool utc = false, bool milliseconds = false) { return DateTimeToString(DateTime.Now, utc, milliseconds); }
		/// <summary>
		/// Convert a DateTime to a Nexo compatible value
		/// </summary>
		/// <param name="dt">DateTime to convert</param>
		/// <param name="utc">True if the resulting string must show UTC datetime</param>
		/// <param name="milliseconds">True if the resulting string must show milliseconds</param>
		/// <returns>The specified date time in Nexo format</returns>
		public static string DateTimeToString(DateTime dt, bool utc = false, bool milliseconds = false)
		{
			// set the time in desired format
			if (utc)
				dt = dt.ToUniversalTime();
			return dt.ToString("yyyy-MM-ddTHH:mm:ss" + (milliseconds ? ".fff" : string.Empty) + (utc ? "Z" : "zzz"));
		}
		/// <summary>
		/// Create a local or UTC DateTime from a Nexo date time
		/// </summary>
		/// <param name="datetime">The string representing a datetime to convert</param>
		/// <returns>The DateTime or 0 if an error has occurred</returns>
		public static DateTime StringToDateTime(string datetime)
		{
			DateTime dt = default(DateTime);
			try
			{ dt = DateTime.Parse(datetime); }
			catch (Exception) { }
			return dt;
		}
		#endregion
	}

	[Guid("880DF188-0670-419D-8E0D-2170D0D537C9")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoISODate
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);

		[DispId(300)]
		void Reset();
		[DispId(301)]
		DateTime ToDateTime();
		[DispId(302)]
		string FromDateTime(DateTime dt);
	}
	[Guid("29E0D16F-F912-4176-BAFB-41A5444F4B10")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoISODate : NexoISODateTimeBase, INexoISODate
	{
		#region properties
		#endregion

		#region constructor
		public NexoISODate() { }
		public NexoISODate(string name) : base(name) { }
		#endregion

		#region methods
		protected override string GetValue(string value) { return DateToString(Dt, Utc); }
		protected override string SetValue(string value) { return DateToString(StringToDate(value), Utc); }
		protected override string GetRegularExpression(string value) { return @"^[0-9]{4}-(0[1-9]|1[0-2])-([0-2][1-9]|3[0-1])$"; }
		/// <summary>
		/// Get the current date
		/// </summary>
		/// <param name="utc">True if expressed in UTC, false if expressed in local</param>
		/// <returns>The current date in Nexo format</returns>
		public static string CurrentDate(bool utc = false) { return DateToString(DateTime.Now, utc); }
		/// <summary>
		/// Convert a DateTime to a Nexo compatible value
		/// </summary>
		/// <param name="dt">The DateTime to convert</param>
		/// <param name="utc">True if date must be expressed in UTC, false if expressed in local</param>
		/// <returns>The specified date in Nexo format</returns>
		public static string DateToString(DateTime dt, bool utc = false)
		{
			// set the time in desired format
			if (utc)
				dt = dt.ToUniversalTime();
			return dt.ToString(Chars.DATE);
		}
		/// <summary>
		/// Convert a date to its datetime representation
		/// </summary>
		/// <param name="date">The date to convert</param>
		/// <returns>The DateTime value or a default value</returns>
		public static DateTime StringToDate(string date)
		{
			DateTime dt = default(DateTime);
			try
			{ dt = DateTime.Parse(date); }
			catch (Exception) { }
			return dt;
		}
		#endregion
	}

	[Guid("C7CAA85A-2A0D-49A7-925A-48A122D76C30")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoNonStringType
	{
		/// <summary>
		/// Variable name
		/// </summary>
		[DispId(1)]
		string Name { get; set; }
		/// <summary>
		/// Variable value as a string
		/// </summary>
		[DispId(2)]
		byte[] Value { get; set; }
		/// <summary>
		/// Size of buffer
		/// </summary>
		[DispId(3)]
		int Size { get; set; }

		[DispId(100)]
		string ToString();
	}
	[Guid("5E5B89AB-BC0A-405D-8DDC-F35C4E92D9A6")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoByteSequence : NexoType, INexoNonStringType
	{
		#region properties
		/// <summary>
		/// Variable value as an array of bytes
		/// </summary>
		public virtual byte[] Value { get; set; } = null;
		/// <summary>
		/// Buffer size
		/// </summary>
		public int Size
		{
			get => _size;
			set
			{
				if (0 > value)
					_size = 0;
				else
					_size = value;
				Value = new byte[Size];
			}
		}
		private int _size = 0;
		#endregion

		#region constuctors
		public NexoByteSequence() { }
		public NexoByteSequence(string name, int size) : base(name) { Size = size; }
		#endregion

		#region methods
		/// <summary>
		/// String representation of the data
		/// </summary>
		/// <returns></returns>
		public override string ToString() { return CMisc.BytesToStr(Value); }
		#endregion
	}

	[Guid("5F12D07E-EA73-4E87-98C6-DDD3A38888C8")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoCurrency
	{
		[DispId(1)]
		string Name { get; set; }
		[DispId(2)]
		string Value { get; set; }
		[DispId(3)]
		uint DecimalPlaces { get; set; }

		[DispId(100)]
		string ToString();
		[DispId(200)]
		bool TestValue(ref string value);
	}
	[Guid("DE4FC2B3-900F-4128-8330-8881A0C36275")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCurrency : NexoISOCurrency3A, INexoCurrency
	{
		#region properties
		/// <summary>
		/// Number of digits in the decimal part
		/// </summary>
		public virtual uint DecimalPlaces { get; set; } = 2;
		#endregion

		#region constuctors
		public NexoCurrency()
		{
			Value = DefaultCurrencySymbol();
			DecimalPlaces = DefaultCurrencyDecimals();
		}
		#endregion

		#region methods
		protected override string GetDefaultValue(string value)
		{
			return DefaultCurrency().Value;
		}
		/// <summary>
		/// Get the default currency as set on the system
		/// </summary>
		/// <returns></returns>
		public static NexoCurrency DefaultCurrency()
		{
			return new NexoCurrency()
			{
				Value = DefaultCurrencySymbol(),
				DecimalPlaces = DefaultCurrencyDecimals()
			};
		}
		/// <summary>
		/// Get the default currency symbol
		/// </summary>
		/// <returns></returns>
		private static string DefaultCurrencySymbol()
		{
			return new RegionInfo(System.Globalization.CultureInfo.CurrentCulture.LCID).ISOCurrencySymbol;
		}
		/// <summary>
		/// Get the default currency decimals
		/// </summary>
		/// <returns></returns>
		private static uint DefaultCurrencyDecimals()
		{
			return (uint)CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalDigits;
		}
		#endregion
	}
	[Guid("64799C07-C801-4276-BF3A-E6AB89A691B3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCurrencyEUR : NexoCurrency, INexoCurrency { public NexoCurrencyEUR() { Value = "EUR"; DecimalPlaces = 2; } }
	[Guid("29167784-C41B-47FF-B1EF-DD855D277C35")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCurrencyUSD : NexoCurrency, INexoCurrency { public NexoCurrencyUSD() { Value = "USD"; DecimalPlaces = 2; } }
	[Guid("03861903-A788-40EF-82A1-27B39C2D57E8")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCurrencyGBP : NexoCurrency, INexoCurrency { public NexoCurrencyGBP() { Value = "GBP"; DecimalPlaces = 2; } }
	[Guid("DE5411DE-BB56-478C-94CD-32E7CD95EC97")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoCurrencyCHF : NexoCurrency, INexoCurrency { public NexoCurrencyCHF() { Value = "CHF"; DecimalPlaces = 2; } }

	[ComVisible(true)]
	public class NexoMessageType : NexoEnumeration, INexoEnumeration { public NexoMessageType() : base(TagsEnumeration.MessageType.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoMessageClass : NexoEnumeration, INexoEnumeration { public NexoMessageClass() : base(TagsEnumeration.MessageClass.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoMessageCategory : NexoEnumeration, INexoEnumeration { public NexoMessageCategory() : base(TagsEnumeration.MessageCategory.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoTerminalEnvironment : NexoEnumeration, INexoEnumeration { public NexoTerminalEnvironment() : base(TagsEnumeration.TerminalEnvironment.ToString()) { DefaultValue = GetLabel(TerminalEnvironmentEnumeration.Attended.ToString()); Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoSaleCapabilities : NexoCluster, INexoCluster { public NexoSaleCapabilities() : base(TagsEnumeration.SaleCapabilities.ToString()) { DefaultValue = SetLabels(new string[] { SaleCapabilitiesEnumeration.ICC.ToString(), SaleCapabilitiesEnumeration.MagStripe.ToString() }); Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoProtocolVersion : NexoDecimal, INexoDecimal { public NexoProtocolVersion(string v = null) : base(TagsEnumeration.ProtocolVersion.ToString()) { DefaultValue = NexoCurrentVersion.Current.Version; Mantis = 1; DecimalPlaces = 1; Value = v ?? DefaultValue; } }

	[ComVisible(true)]
	public class NexoSupportedProtocolVersions : Dictionary<string, NexoProtocolVersion> { }

	[ComVisible(true)]
	public class NexoID : NexoLengthDrivenTextString, INexoLengthDrivenTextString
	{
		public NexoID(string name = "") : base(name) { RegularExpression = string.Empty; Min = 1; Max = 10; }
		protected override string GetDefaultValue(string value)
		{ return NexoAutoID.ID(); }
	}

	[ComVisible(false)]
	public static class NexoAutoID
	{
		public static string ID()
		{
			// get current UTC datetime
			DateTime utc = DateTime.UtcNow;
			// subtract the beginning of the month
			DateTime utc2 = utc.Subtract(new TimeSpan(utc.Day - 1, utc.Hour, utc.Minute, utc.Second, utc.Millisecond));
			// get the number of milliseconds of the TimeSpan between these 2 dates
			uint ui = (uint)(utc - utc2).TotalMilliseconds;
			return ui.ToString("X10");
		}
	}

	[ComVisible(true)]
	public class NexoServiceID : NexoID { public NexoServiceID(string v = "") : base(TagsEnumeration.ServiceID.ToString()) { Value = v; } }

	[ComVisible(true)]
	public class NexoDeviceID : NexoID { public NexoDeviceID(string v = "") : base(TagsEnumeration.DeviceID.ToString()) { Value = v; } }

	[ComVisible(true)]
	public class NexoPOIID : NexoTextString, INexoTextString { public NexoPOIID(string v) : base(TagsEnumeration.POIID.ToString()) { Value = v; } }

	[ComVisible(true)]
	public class NexoSaleID : NexoTextString, INexoTextString { public NexoSaleID(string v) : base(TagsEnumeration.SaleID.ToString()) { Value = v; } }

	[ComVisible(true)]
	public class NexoOperatorLanguage : NexoISOLanguage2A, INexoISOData { public NexoOperatorLanguage() : base(TagsEnumeration.OperatorLanguage.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoResult : NexoEnumeration, INexoEnumeration { public NexoResult() : base(TagsEnumeration.Result.ToString()) { Value = DefaultValue = ResultEnumeration.Success.ToString(); } }

	[ComVisible(true)]
	public class NexoErrorCondition : NexoEnumeration, INexoEnumeration { public NexoErrorCondition() : base(TagsEnumeration.ErrorCondition.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoAdditionalResponse : NexoTextString, INexoTextString { public NexoAdditionalResponse() : base(TagsEnumeration.AdditionalResponse.ToString()) { Value = DefaultValue; } }

	[ComVisible(true)]
	public class NexoGlobalStatus : NexoEnumeration, INexoEnumeration { public NexoGlobalStatus() : base(TagsEnumeration.GlobalStatus.ToString()) { Value = DefaultValue = GlobalStatusEnumeration.OK.ToString(); } }

	[ComVisible(true)]
	public class NexoCertificationCode : NexoTextString, INexoTextString { public NexoCertificationCode() : base(TagsEnumeration.CertificationCode.ToString()) { Value = DefaultValue = "NOT CERTIFIED"; } }

	[ComVisible(true)]
	public class NexoSoftwareVersion : NexoTextString, INexoTextString { public NexoSoftwareVersion() : base(TagsEnumeration.SoftwareVersion.ToString()) { Value = DefaultValue = CMisc.Version(CMisc.VersionType.assemblyInfo); } }

	[ComVisible(true)]
	public class NexoApplicationName : NexoTextString, INexoTextString { public NexoApplicationName() : base(TagsEnumeration.ApplicationName.ToString()) { Value = DefaultValue = Assembly.GetExecutingAssembly().GetName().Name; } }

	[ComVisible(true)]
	public class NexoManufacturerID : NexoTextString, INexoTextString
	{
		public NexoManufacturerID() : base(
#if NEXO30
			TagsEnumeration.ManufacturerID.ToString()
#elif NEXO31
			TagsEnumeration.ProviderIdentification.ToString()
#endif
			)
		{ Value = DefaultValue = Assembly.GetExecutingAssembly().GetName().Name; }
	}

#if ANDROID
	[ComVisible(true)]
	public class NexoPOISerialNumber: NexoTextString { public NexoPOISerialNumber() : base(TagsEnumeration.POISerialNumber.ToString()) { } }
#else
	[ComVisible(true)]
	public class NexoPOISerialNumber : NexoTextString, INexoTextString { public NexoPOISerialNumber() : base(TagsEnumeration.POISerialNumber.ToString()) { DefaultValue = "SerialNumber"; } }
#endif

	[ComVisible(true)]
	public class NexoOperatorID : NexoTextString, INexoTextString { public NexoOperatorID() : base(TagsEnumeration.OperatorID.ToString()) { DefaultValue = Environment.UserName; } }

	[ComVisible(true)]
	public class NexoDateTime : NexoISODateTime, INexoISODateTime { public NexoDateTime() : base(TagsEnumeration.DateTime.ToString()) { } }

	[ComVisible(true)]
	public class NexoInputCommand : NexoEnumeration, INexoEnumeration { public NexoInputCommand() : base(TagsEnumeration.InputCommand.ToString()) { } }

	[ComVisible(true)]
	public class NexoEventToNotify : NexoEnumeration, INexoEnumeration { public NexoEventToNotify() : base(TagsEnumeration.EventToNotify.ToString()) { } }

	[ComVisible(true)]
	public class NexoPaymentIntrumentType : NexoEnumeration, INexoEnumeration { public NexoPaymentIntrumentType() : base(TagsEnumeration.PaymentInstrumentType.ToString()) { Value = DefaultValue = PaymentInstrumentTypeEnumeration.Card.ToString(); } }
}