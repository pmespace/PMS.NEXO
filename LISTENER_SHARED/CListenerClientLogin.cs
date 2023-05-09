using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using COMMON;

namespace Listener.Shared
{
	/// <summary>
	/// describe a POI sent to the server
	/// </summary>
	public class CSimplePOI
	{
		public string Name { get; set; }
		public string FullIP { get; set; }
		public string Label { get; set; }
	}
	/// <summary>
	/// describe how simple POIs are sent to the server
	/// </summary>
	public class CSimplePOIs : List<CSimplePOI> { }
	/// <summary>
	/// base data contained in any login request to a server
	/// </summary>
	public class CListenerClientLoginRequest
	{
		public CSimplePOIs SimplePOIs { get; set; }
		public string MACAddress { get; set; }
		[JsonExtensionData]
		public Dictionary<string, JToken> _extendedData;
	}
	/// <summary>
	/// base data contained in any login response from a server
	/// </summary>
	public class CListenerClientLoginResponse
	{
		/// <summary>
		/// true means access is granted, false means access is denied
		/// </summary>
		public bool Granted { get; set; }
		[JsonExtensionData]
		public Dictionary<string, JToken> _extendedData;
	}
}
