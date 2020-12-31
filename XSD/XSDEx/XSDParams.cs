using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSDEx
	{
	/// <summary>
	/// Type conversions
	/// </summary>
	class XSDTargetType
		{
		public string TargetType { get; set; }
		public string TargetProperty { get; set; }
		}
	class XSDTypeConversions: Dictionary<string, XSDTargetType> { }
	/// <summary>
	/// Arrays with no initializers
	/// </summary>
	class XSDArraysWithoutInitializer: List<string> { }
	class XSDField
		{
		public string Type { get; set; }
		}
	/// <summary>
	/// Properties array whose fields must not have any initializer
	/// </summary>
	class XSDFieldsWithoutInitializer: Dictionary<string, XSDField> { }
	/// <summary>
	/// Json parameters file
	/// </summary>
	class XSDParams
		{
		public XSDTypeConversions TypeConversions { get; set; }
		public XSDArraysWithoutInitializer ArraysWithoutInitializer { get; set; }
		public XSDFieldsWithoutInitializer FieldsWithoutInitializer { get; set; }
		}
	}
