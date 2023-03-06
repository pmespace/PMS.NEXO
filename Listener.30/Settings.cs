using COMMON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NEXO;
using Newtonsoft.Json.Linq;
using System.Net;
using Listener.Shared;

namespace Listener
{

	/// <summary>
	/// Main settings class
	/// </summary>
	public class CSettings
	{
		#region constructor
		public CSettings()
		{
			Client = new CSettingsClient();
			Server = new CSettingsServer();
			Nexo = new CSettingsNexo();
			POIs = new CPOIs();
		}
		#endregion

		#region classes
		public class SessionType
		{
			public bool IsLogged { get; set; }
			List<CListenerReply> Activity { get; set; }
		}

		/// <summary>
		/// describes an individual POI
		/// </summary>
		public class CPOI
		{
			public CPOI()
			{
				ConnectionSettings = new CStreamClientSettings();
			}

			public string Label { get; set; }
			public CStreamClientSettings ConnectionSettings { get; set; }

			[JsonIgnore]
			public string FullIP { get => $"{ConnectionSettings.IP}:{ConnectionSettings.Port}"; }

			public override string ToString() { return $"Connection settings: {ConnectionSettings}"; }
		}
		/// <summary>
		/// describes a list of POI known by the listener
		/// </summary>
		public class CPOIs : CDictionary<CPOI>
		{
			/// <summary>
			/// Get the list of POIs to send to the server
			/// </summary>
			/// <returns></returns>
			public CSimplePOIs GetSimplePOIs()
			{
				// get the list of POI and their respective IP addresses
				CSimplePOIs d = new CSimplePOIs();
				foreach (KeyValuePair<string, CPOI> k in this)
					d.Add(new CSimplePOI() { Name = k.Key, FullIP = k.Value.FullIP, Label = k.Value.Label });
				return d;
			}
		}
		#endregion

		#region properties
		/// <summary>
		/// if true the listener runs as a server, if false as a client
		/// </summary>
		public bool RunAsClient
		{
			get => _runasclient;
			set
			{
				_runasclient = value;
				if (RunAsClient)
					Client = null;
				else
					Server = null;
			}
		}
		bool _runasclient = true;
		/// <summary>
		/// log exchanges if true, not logged otherwise
		/// </summary>
		public bool LogExchanges { get; set; } = false;
		/// <summary>
		/// messages are displayed if true, not displayed otherwise
		/// </summary>
		public bool DisplayMessages { get; set; } = false;
		/// <summary>
		/// severity to log
		/// </summary>
		public string Severity { get => _severity.ToString(); set => _severity = (TLog)CMisc.GetEnumValue(typeof(TLog), value, _severity); }
		internal TLog _severity = TLog.TRACE;
		/// <summary>
		/// the list of POIs known by the listener
		/// </summary>
		public CPOIs POIs { get; set; }
		/// <summary>
		/// nexo specific settings
		/// </summary>
		public CSettingsNexo Nexo { get; set; }
		/// <summary>
		/// client mode specific settings
		/// </summary>
		public CSettingsClient Client { get; set; }
		/// <summary>
		/// server mode specific settings
		/// </summary>
		public CSettingsServer Server { get; set; }

		[JsonIgnore]
		private Dictionary<int, SessionType> sessions = new Dictionary<int, SessionType>();
		#endregion

		#region methods
		public override string ToString()
		{
			string s = $"Run as client: {RunAsClient}; Log exchanges: {LogExchanges}; Display messages: {DisplayMessages}{Chars.CRLF}";
			if (null != Client) s += $"{Client}{Chars.CRLF}";
			if (null != Server) s += $"{Server}{Chars.CRLF}";
			if (null != Nexo) s += $"{Nexo}{Chars.CRLF}";
			return s;
		}
		#endregion
	}

	/// <summary>
	/// A listener is server if the sale system directly connects to it to give it commands to execute on a POI
	/// </summary>
	public class CSettingsNexo
	{
		#region constructor
		public CSettingsNexo()
		{
			AutoLoginLogout = true;
			AllowedServices = new CListSring();
			AlwaysSucceedOnNotification = true;
			AlwaysSucceedOnDeviceDisplay = true;
		}
		#endregion

		#region properties
		/// <summary>
		/// if true the listener will automatically send a Login message before sending another command, 
		/// if false the Login message must be explicitely passed to the listener beforehand
		/// </summary>
		public bool AutoLoginLogout { get; set; }
		/// <summary>
		/// Nexo retailer services allowed to be used through the listener
		/// </summary>
		public CListSring AllowedServices { get; set; }
		/// <summary>
		/// if true a notification is always acknowledged, if false it depends on the notification itself
		/// </summary>
		public bool AlwaysSucceedOnNotification { get; set; }
		/// <summary>
		/// if true a DeviceDisplay is always acknowledged, if false it depends on the DeviceDisplay itself
		/// </summary>
		public bool AlwaysSucceedOnDeviceDisplay { get; set; }

		[JsonIgnore]
		public CList<MessageCategoryEnumeration> AllowedCategories { get; set; } = new CList<MessageCategoryEnumeration>();
		#endregion

		#region methods
		public override string ToString()
		{
			string s = $"AutoLoginLogout: {AutoLoginLogout}{Chars.CRLF}";
			s += $"AllowedServices:" + Chars.CRLF + AllowedServices.ToString() + Chars.CRLF;
			return s;
		}
		#endregion
	}

	/// <summary>
	/// A listener is server if the sale system directly connects to it to give it commands to execute on a POI
	/// </summary>
	public class CSettingsServer
	{
		public CSettingsServer()
		{
			Port = 29134;
			AllowedIP = new CListSring();
		}
		/// <summary>
		/// port to call to connect to the listener
		/// </summary>
		public uint Port { get => _port; set => _port = IPEndPoint.MinPort < value && IPEndPoint.MaxPort >= value ? value : _port; }
		uint _port = DEFAULT_PORT;
		public const uint DEFAULT_PORT = 41309;
		/// <summary>
		/// allowed IPs able to connect to the listener
		/// </summary>
		public CListSring AllowedIP { get; set; }

		public override string ToString()
		{
			string s = $"Server port: {Port}{Chars.CRLF}";
			s += $"AllowedIP:" + Chars.CRLF + AllowedIP.ToString() + Chars.CRLF;
			return s;
		}
	}

	/// <summary>
	/// A listener is client if it has to connect to a sale system first in order to be able to receive commands to execute on a POI
	/// </summary>
	public class CSettingsClient
	{
		#region constructor
		public CSettingsClient()
		{
			URI = "URI to call";
			Security = new CSecurity();
		}
		#endregion

		#region classes
		public class CSecurity
		{
			[JsonExtensionData]
			public Dictionary<string, JToken> _extendedData;
		}
		#endregion

		#region properties
		/// <summary>
		/// URI to connect to
		/// </summary>
		public string URI { get; set; }
		/// <summary>
		/// Security object to connect to the server
		/// </summary>
		public CSecurity Security { get; set; }
		/// <summary>
		/// Size of the buffer to use when receiving orders from the server
		/// </summary>
		public uint ReceptionBufferSize { get => _receptionbuffersize; set => _receptionbuffersize = Math.Max(_receptionbuffersize, MIN_RECEPTION_BUFFER_SIZE); }
		uint _receptionbuffersize = MIN_RECEPTION_BUFFER_SIZE;
		const uint MIN_RECEPTION_BUFFER_SIZE = 1024;
		/// <summary>
		/// Maximum number of connection attempts to the WS server, consecutive retries to connect to the server before an error is raised.
		/// When the value is reached the listener stops trying to connect.
		/// A value 0 indicates no maximum number of connect attempts, thus endless attempts.
		/// </summary>
		public uint RetryConnectCounter { get => _retryconnectcounter; set => _retryconnectcounter = Math.Max(_retryconnectcounter, DEFAULT_RETRY_CONNECT_COUNTER); }
		uint _retryconnectcounter = DEFAULT_RETRY_CONNECT_COUNTER;
		const uint DEFAULT_RETRY_CONNECT_COUNTER = 0;
		/// <summary>
		/// Delay between retries to connect to the WS server, it is expressed in seconds and can't be less than <see cref="MIN_DELAY_BETWEEN_RETRIES"/>
		/// </summary>
		public uint DelayBetwenRetries { get => _delaybetwenretries; set => _delaybetwenretries = Math.Min(Math.Max(_delaybetwenretries, MIN_DELAY_BETWEEN_RETRIES), MAX_DELAY_BETWEEN_RETRIES); }
		uint _delaybetwenretries = MIN_DELAY_BETWEEN_RETRIES;
		const uint MIN_DELAY_BETWEEN_RETRIES = 5;
		const uint MAX_DELAY_BETWEEN_RETRIES = 60;
		#endregion

		#region methods
		public override string ToString()
		{
			string s = $"URI: {URI}{Chars.CRLF}";
			return s;
		}
		#endregion
	}

	/// <summary>
	/// base class for several list of strings
	/// </summary>
	public class CListSring : CList<string>
	{
		public override string ToString()
		{
			if (0 == Count)
				return "<none>";

			int i = 0;
			string s = string.Empty;
			foreach (string k in this)
			{
				i++;
				s += $" - {k}" + (i < Count ? Chars.CRLF : string.Empty);
			}
			return s;
		}
	}

	/// <summary>
	/// base class for several list of any kind
	/// </summary>
	public class CList<T> : List<T>
	{
		public CList() { }
		public CList(CList<T> v) : base(v) { }
		public override string ToString()
		{
			if (0 == Count)
				return "<none>";

			int i = 0;
			string s = string.Empty;
			foreach (T k in this)
			{
				i++;
				s += $" - {k}" + (i < Count ? Chars.CRLF : string.Empty);
			}
			return s;
		}
	}

	/// <summary>
	/// base class for several dictionaries of any kind
	/// </summary>
	public class CDictionary<T> : Dictionary<string, T>
	{
		public CDictionary() { }
		public CDictionary(CDictionary<T> v) : base(v) { }
		public override string ToString()
		{
			if (0 == Count)
				return "<none>";

			int i = 0;
			string s = string.Empty;
			foreach (KeyValuePair<string, T> k in this)
			{
				i++;
				s += $" - {k.Key} => {k.Value}" + (i < Count ? Chars.CRLF : string.Empty);
			}
			return s;
		}
	}
}
