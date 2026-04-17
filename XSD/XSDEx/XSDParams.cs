using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XSDEx
{
	/// <summary>
	/// Type conversions
	/// </summary>
	class XSDTypeConversion
	{
		[JsonExtensionData]
		public Dictionary<string, object> AdditionalProperties { get; set; }
		public string TargetType { get; set; }
		public int Rank { get; set; }
	}
	class XSDTypeConversions : Dictionary<string, XSDTypeConversion> { }
	/// <summary>
	/// Arrays with no initializers
	/// </summary>
	class XSDTypesWithSpecialProcessing : List<string> { }
	/// <summary>
	/// Json parameters file
	/// </summary>
	class XSDParams
	{
		[JsonExtensionData]
		public Dictionary<string, object> AdditionalProperties { get; set; }

		public XSDTypeConversions TypeConversions { get; set; }
		public XSDTypeConversions ArrayConversions { get; set; }
		public XSDTypesWithSpecialProcessing TypesWithoutInitializer { get; set; }
		public XSDTypesWithSpecialProcessing ArrayTypesWithoutInitializer { get; set; }
		public XSDTypesWithSpecialProcessing ArrayTypesWithoutAccessors { get; set; }
	}
}
