using System;
using System.Diagnostics;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using COMMON;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Threading;
using Listener;
using Listener.WS;
using Listener.Shared;
using System.Reflection;

namespace WSServer
{
	internal class Program
	{
		static WebSocket WS = default;
		static void Main(string[] args)
		{
			Console.Title = $"WSServer - v{CMisc.Version(CMisc.VersionType.assembly)}";

			int index;
			string logFileName = CWSListener.DEFAULT_LOG_FILE_NAME;
			string WSSettingsFileName = CWSListener.DEFAULT_SETTINGS_FILE_NAME;
			string listenerSettingsFileName = CListener.DEFAULT_SETTINGS_FILE_NAME;
			string argLogFile = "l", argLogFileEx = "<log file name>", argLog = argLogFile + argLogFileEx;
			string argWSFile = "s", argWSFileEx = "<web sockets server settings file name>", argWS = argWSFile + argWSFileEx;
			string argRunListener = "r", argListenerFileEx = "<listener settings file name>", argListener = $"{argRunListener}[{argListenerFileEx}]";

			// listener server settings file name
			if (default != CMisc.SearchInArgs(args, "?", out index))
			{
				Console.WriteLine($"{System.IO.Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)} [-{argLog}] [-{argWS}] [-{argListener}]");
				Console.WriteLine(Chars.TAB + $"-{argLog} where {argLogFileEx} is the file path and name of the log file to create (default is {logFileName})");
				Console.WriteLine(Chars.TAB + $"-{argWS} where {argWSFileEx} is the file path and name of the settings file to use for the web socket server (default is {WSSettingsFileName})");
				Console.WriteLine(Chars.TAB + $"-{argListener} indicates the listener must be started alongside the web socket server, {argListenerFileEx} if present is the file path and name of the settings file to use for the listener (default is {listenerSettingsFileName})");
				return;
			}

			// get program options
			string option;

			if (!(option = CMisc.SearchInArgs(args, argLogFile, out index)).IsNullOrEmpty())
				logFileName = option;

			if (!(option = CMisc.SearchInArgs(args, argWSFile, out index)).IsNullOrEmpty())
				WSSettingsFileName = option;

			bool runListener = true, listenerIsRunning = false;
			option = CMisc.SearchInArgs(args, argRunListener, out index);
			if (default == option)
			{
				runListener = false;
			}
			else if (!option.IsNullOrEmpty())
			{
				listenerSettingsFileName = option;
			}

			CLog.LogFileName = logFileName;

			// eventually WS server
			ManualResetEvent started = new ManualResetEvent(false), ended = new ManualResetEvent(false);
			CSynchronize waits = new CSynchronize();
			waits.Add(started);
			waits.Add(ended);
			CWSListener.StartWSServer(WSSettingsFileName, started, ended);
			if (0 == (index = waits.WaitAny()))
			{
				// eventually start listener
				CListener listener = default;
				if (runListener)
				{
					listener = new CListener();
					listenerIsRunning = listener.Start(listenerSettingsFileName);
				}

				ConsoleKeyInfo key;
				do
				{
					Console.WriteLine($"Press ESC to stop server, T to start");
					key = Console.ReadKey();
					if (ConsoleKey.T == key.Key)
						TestListener(listener);
				} while (ConsoleKey.Escape != key.Key);
			}
			Console.WriteLine("Bye bye...");
		}

		static void TestListener(CListener listener)
		{
			if (default == CWSListener.WS)
			{
				Console.WriteLine("No client to send a message to...");
				return;
			}

			string fileToUse = CMisc.Input("File to use", "listener.request.json", out bool isdef);
			if (fileToUse.IsNullOrEmpty())
			{
				Console.WriteLine("Invalid test file");
				return;
			}
			ManualResetEvent evt = new ManualResetEvent(false);
			CWSListener.SendRequest(fileToUse, evt);
			evt.WaitOne();
		}
	}
}