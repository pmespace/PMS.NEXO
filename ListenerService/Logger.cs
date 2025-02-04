using COMMON;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener.Service
{
	static internal class Logger
	{
		public static string Log(ILogger<Worker> logger, string msg, TLog tlog = TLog.DEBUG)
		{
			try { logger.Log(FromTLog(tlog), msg, null); }
			catch (Exception) { }
			return CLog.Add(msg, tlog);
		}
		static LogLevel FromTLog(TLog tlog)
		{
			switch (tlog)
			{
				case TLog.ERROR:
					return LogLevel.Critical;
				case TLog.EXCPT:
					return LogLevel.Error;
				case TLog.WARNG:
					return LogLevel.Warning;
				case TLog.TRACE:
					return LogLevel.Trace;
				case TLog.DEBUG:
					return LogLevel.Debug;
				case TLog.DISPL:
					return LogLevel.None;
				case TLog.INFOR:
				default:
					return LogLevel.Information;
			}
		}
	}
}
