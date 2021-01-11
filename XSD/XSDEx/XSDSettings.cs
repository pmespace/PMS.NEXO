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
			PrivateByInternalVisibility = MemberAttributes.Assembly;

			ManageInitFlag = false;
			CreateArrayInitializer = false;
			GetReturnsNullIfArrayIsEmpty = false;
			AutomaticArrays = true;
			EmptyStringArrayToNull = true;

			CreateArrayAccessors = true;
			OptimizeStructs = false;

			DerivedClassName = "NexoSaleToPOIMessage";
		}
		public string Exception; // if an exception occurred it is reported here
		public string ParametersFileName { get; set; }
		public enumLanguage Language;
		public Files Files { get; set; }
		public string Nmspace { get; set; }
		public bool UseTypes { get; set; }
		public bool UseElements { get; set; }
		public bool UseNotations { get; set; }
		public ClassInterfaceType ClassInterface { get; set; }
		public ComInterfaceType ComInterface { get; set; }
		public bool AddDispID { get; set; }
		public bool MakeEnumComVisible { get; set; }
		public bool MakeClassComVisible { get; set; }
		public bool DeclareClassInterface { get; set; }
		public bool ConvertTypes { get; set; }
		public bool DateTimeToString { get; set; }
		public bool NumericToString { get; set; }
		public bool BooleanToString { get; set; }
		public bool CreateArrayInitializer
		{
			get => _providearraysinitializer;
			set
			{
				_providearraysinitializer = value;
				if (_providearraysinitializer)
					AutomaticArrays = false;
			}
		}
		private bool _providearraysinitializer = false;
		public bool GetReturnsNullIfArrayIsEmpty
		{
			get => _sendnullifemptyarray;
			set
			{
				_sendnullifemptyarray = value;
				if (_sendnullifemptyarray)
					AutomaticArrays = false;
			}
		}
		private bool _sendnullifemptyarray = false;
		public bool AutomaticArrays
		{
			get => _automaticallymanagearrays;
			set
			{
				_automaticallymanagearrays = value;
				if (AutomaticArrays)
				{
					CreateArrayInitializer = false;
					GetReturnsNullIfArrayIsEmpty = false;
					EmptyStringArrayToNull = false;
				}
			}
		}
		private bool _automaticallymanagearrays = true;
		public bool PrivateByInternal { get; set; }
		public MemberAttributes PrivateByInternalVisibility { get; set; }
		public bool ManageInitFlag { get; set; }
		public bool EmptyStringArrayToNull
		{
			get => _emptystringarraytonull;
			set
			{
				_emptystringarraytonull = value;
				if (EmptyStringArrayToNull)
				{
					AutomaticArrays = false;
				}
			}
		}
		private bool _emptystringarraytonull = true;
		public bool CreateArrayAccessors { get; set; }
		public bool OptimizeStructs { get; set; }
		public string DerivedClassName { get; set; }
		public string Preprocessor { get; set; }
	}
}
