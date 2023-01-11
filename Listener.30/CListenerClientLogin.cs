using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Listener
{
	/// <summary>
	/// base data contained in any login request to a server
	/// </summary>
	public class CListenerClientLoginRequest
	{
		public CSettings.CSimplePOIs POIs { get; set; }
		public string MACAddress { get; set; }
		[JsonExtensionData]
		public Dictionary<string, JToken> _extendedData;
	}
	///// <summary>
	///// security settings to connect through a token
	///// </summary>
	//public class CListenerClientLoginRequestToken : CListenerClientLoginRequest
	//{
	//	public string Token { get; set; }
	//}
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
