using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSDEx
{
	/// <summary>
	/// list of file names to use to create the XSD
	/// </summary>
	public class Files : List<string> { }

	public enum XSDActivityEvent
	{
		none,
		status,
		message,
		startingProcess,
		endingProcess,
	}

	public delegate void XSDAddActivity(XSDActivity activity);
	public class XSDActivity
	{
		public string Message;
		public XSDActivityEvent Evt;
	}

	/// <summary>
	/// Supported languages
	/// </summary>
	public enum enumLanguage
	{
		csharp,
		vb,
	}

	/// <summary>
	/// XSDEx working settings
	/// </summary>
	public class XSDSettings
	{
		public XSDSettings()
		{
			Language = enumLanguage.csharp;
			Files = new Files();
			Nmspace = null;
			UseTypes = true;
			UseElements = true;
			UseNotations = true;
			ClassInterface = ClassInterfaceType.None;
			ComInterface = ComInterfaceType.InterfaceIsDual;
			MakeEnumComVisible = true;
			MakeClassComVisible = true;
			DateTimeToString = true;
			NumericToString = false;
			BooleanToString = false;
			ConvertTypes = false;
			AddDispID = true;
			DeclareClassInterface = true;
			PrivateByInternal = true;

			ArrayCreateInitializer = false;
			ArrayGetReturnsNullEmpty = false;
			CreateArrayAccessors = true;
		}
		public enum NameSpace
		{
			Retailer,
			Acquirer,
			TMS,
			None,
		}
		public string Exception; // if an exception occurred it is reported here
		public string ParametersFileName { get; set; }
		public enumLanguage Language;
		public Files Files { get; set; }
		public string Nmspace { get; set; }
		/// <summary>
		/// Indicate use Types from inside the XSD
		/// </summary>
		public bool UseTypes { get; set; }
		/// <summary>
		/// Indicate use Elements from inside the XSD
		/// </summary>
		public bool UseElements { get; set; }
		/// <summary>
		/// Indicate use Notations inside the XSD
		/// </summary>
		public bool UseNotations { get; set; }
		/// <summary>
		/// Interface type to use when generating the interface
		/// </summary>
		public ClassInterfaceType ClassInterface { get; set; }
		/// <summary>
		/// Com interface to use when generating the classes
		/// </summary>
		public ComInterfaceType ComInterface { get; set; }
		/// <summary>
		/// Indicate whether DisopID must be added or not
		/// </summary>
		public bool AddDispID { get; set; }
		/// <summary>
		/// Indicate whether enums must be made COM visible
		/// </summary>
		public bool MakeEnumComVisible { get; set; }
		/// <summary>
		/// Indicate whether classes must be made COM visible
		/// </summary>
		public bool MakeClassComVisible { get; set; }
		/// <summary>
		/// Indicates an interface must be created for a class
		/// </summary>
		public bool DeclareClassInterface { get; set; }
		/// <summary>
		/// Indicate class type conversion must be analysed or not (impacts XSDParams)
		/// </summary>
		public bool ConvertTypes { get; set; }
		public bool DateTimeToString { get; set; }
		public bool NumericToString { get; set; }
		public bool BooleanToString { get; set; }
		/// <summary>
		/// Create an array initializer at the field level or not
		/// </summary>
		public bool ArrayCreateInitializer
		{
			get => _providearraysinitializer;
			set
			{
				_providearraysinitializer = value;
			}
		}
		private bool _providearraysinitializer = false;
		/// <summary>
		/// Get returns null if an array is empty
		/// </summary>
		public bool ArrayGetReturnsNullEmpty
		{
			get => _sendnullifemptyarray;
			set
			{
				_sendnullifemptyarray = value;
			}
		}
		private bool _sendnullifemptyarray = false;
		/// <summary>
		/// Replace private by internal
		/// </summary>
		public bool PrivateByInternal { get; set; }
		/// <summary>
		/// Indicate whether array accessors must be created or not
		/// </summary>
		public bool CreateArrayAccessors { get; set; }
		/// <summary>
		/// name of preprocessor directive to use
		/// </summary>
		public string Preprocessor { get; set; }
		/// <summary>
		/// Indicate whether messages must be displayed while processing
		/// </summary>
		public bool Silent { get; set; } = true;
		/// <summary>
		/// Allows replacing string representing an integral type to the integral type
		/// </summary>
		public bool ConvertStringIntegralToIntegral { get; set; } = false;
		/// <summary>
		/// Allows testing whether a data has been set using its default value (true) or its type's default value (false)
		/// </summary>
		public bool UseDefaultValueForHasBeenModified { get; set; } = false;
		/// <summary>
		/// Allows generating enum default attributes (_node, _begin, _end)
		/// </summary>
		public bool AddDefaultAttributesToEnum { get; set; } = true;
		public bool UseEnumBeginEnd { get; set; } = true;
		/// <summary>
		/// Type of namespace to create
		/// </summary>
		public NameSpace NamespaceToDeclare { get; set; } = NameSpace.None;
		/// <summary>
		/// Use nullable integral types for properties
		/// </summary>
		public bool UseNullableIntegralTypes { get; set; } = true;
		public bool UseOptimizingFlag { get; set; } = true;
	}
}
