using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using COMMON;

namespace Listener.WS
{
	internal class CSettings
	{
		/// <summary>
		/// Port to use to receive web sockets connection
		/// </summary>
		public int WSPort { get => _wsport; set => _wsport = IPEndPoint.MinPort < value && IPEndPoint.MaxPort >= value ? value : DEFAULT_PORT; }
		int _wsport = DEFAULT_PORT;
		public const int DEFAULT_PORT = 13049;
		/// <summary>
		/// Logging severity
		/// </summary>
		public string SeverityToLog { get => _severitytolog.ToString(); set => _severitytolog = (TLog)CMisc.GetEnumValue(typeof(TLog), value, _severitytolog); }
		TLog _severitytolog = TLog.TRACE;
		//public string WSExtension { get => _wsextension; set=>_wsextension= }
		//string _wsextension = DEFAULT_WS_EXTENSION;
		//public const string DEFAULT_WS_EXTENSION = "/ws";
		public override string ToString()
		{
			string s = $"Port: {WSPort}";
			return s;
		}
	}
}
