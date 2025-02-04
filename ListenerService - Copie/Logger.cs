using COMMON;
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
		public static string Log(EventLog eventLog, string msg, TLog tlog = TLog.DEBUG)
		{
			eventLog.WriteEntry(msg, FromTLog(tlog));
			return CLog.Add(msg, tlog);
		}
		static EventLogEntryType FromTLog(TLog tlog)
		{
			switch (tlog)
			{
				case TLog.ERROR:
				case TLog.EXCPT:
					return EventLogEntryType.Error;
				case TLog.WARNG:
					return EventLogEntryType.Warning;
				default: return EventLogEntryType.Information;
			}
		}
	}
}
