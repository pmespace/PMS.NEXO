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
	class XSDTypeConversion
	{
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
		public XSDTypeConversions TypeConversions { get; set; }
		public XSDTypeConversions ArrayConversions { get; set; }
		public XSDTypesWithSpecialProcessing TypesWithoutInitializer { get; set; }
		public XSDTypesWithSpecialProcessing ArrayTypesWithoutInitializer { get; set; }
		public XSDTypesWithSpecialProcessing ArrayTypesWithoutAccessors { get; set; }
	}
}
