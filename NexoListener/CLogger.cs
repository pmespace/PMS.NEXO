using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON;

namespace NexoListener
{
	static class CLogger
	{
		public static string Add(string text, TLog tlog = TLog.INFOR) { Console.WriteLine(CLog.Add(text, tlog)); return text; }
		public static string Display(string text) { Console.WriteLine(text); return text; }
	}
}
