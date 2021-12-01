using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using NEXO;
using COMMON;

namespace NexoListener
{
	class Program
	{
		#region menu
		private class MenuList : SortedDictionary<char, CMenu> { }
		private delegate bool DFnc(MenuList menu, CMenu entry, char option, object o);
		class CMenu
		{
			public string Text { get; set; }
			public DFnc Fnc { get; set; }
		}
		#endregion

		#region const
		private const string LISTENER_SETTINGS_FILE = "listener.settings.json";
		private const string LISTENER_TEST_FILE = "listener.request.json";
		private const string LISTENER_LOG_FILE = "listener.log";

		private const string ACTIVATE_DISPLAY = "Activate activity display";
		private const string DEACTIVATE_DISPLAY = "Deactivate activity display";

		private const string OPTION_SETTINGS_FILE_NAME = "-s";
		private const string OPTION_LOG_FILE_NAME = "-l";
		private const string OPTION_LOG_AUTO_PURGE = "-a";
		private const string OPTION_LOG_NUMBER_OF_FILES = "-n";

		private const char TEST_LISTENER = '0';
		private const char TEST_LISTENER_CREATE = '1';
		private const char DISPLAY_SETTINGS = '2';
		private const char RELOAD_SETTINGS = '3';
		#endregion

		#region main
		static void Main(string[] args)
		{
			string logFile = null;
			string settingsFile = null;
			string autoPurge = null;
			string numberOfFiles = null;

			// take a list of strings (refer to PathToData) and add it to a dictionary of paths + save the value to use
			Func<string, string, string, string> CheckOption = (string arg, string option, string data) =>
			{
				try
				{
					if ((arg.StartsWith(option, true, null)) && option.Length < arg.Length && string.IsNullOrEmpty(data))
						return arg.Substring(option.Length);
					return data;
				}
				catch (Exception) { }
				return null;
			};

			// get start options
			foreach (string s in args)
			{
				// has the settings file been specified
				//if ((s.StartsWith(OPTION_SETTINGS_FILE_NAME, true, null)) && OPTION_SETTINGS_FILE_NAME.Length < s.Length && string.IsNullOrEmpty(settingsFile))
				//settingsFile = s.Substring(OPTION_SETTINGS_FILE_NAME.Length);

				// has the log file been specified
				//if ((s.StartsWith(OPTION_LOG_FILE_NAME, true, null)) && OPTION_LOG_FILE_NAME.Length < s.Length && string.IsNullOrEmpty(logFile))
				//	logFile = s.Substring(OPTION_LOG_FILE_NAME.Length);

				settingsFile = CheckOption(s, OPTION_SETTINGS_FILE_NAME, settingsFile);
				logFile = CheckOption(s, OPTION_LOG_FILE_NAME, logFile);
				numberOfFiles = CheckOption(s, OPTION_LOG_NUMBER_OF_FILES, numberOfFiles);
				autoPurge = CheckOption(s, OPTION_LOG_AUTO_PURGE, autoPurge);
			}

			if (string.IsNullOrEmpty(settingsFile))
				settingsFile = LISTENER_SETTINGS_FILE;
			if (string.IsNullOrEmpty(logFile))
				logFile = LISTENER_LOG_FILE;
			try
			{
				CLog.AutoPurgeLogFiles = bool.Parse(autoPurge);
			}
			catch
			{
				CLog.AutoPurgeLogFiles = true;
			}
			try
			{
				CLog.NumberOfFilesToKeep = int.Parse(numberOfFiles);
			}
			catch
			{
				CLog.NumberOfFilesToKeep = 3;
			}
			CLog.LogFileName = logFile;

			CLogger.Add($"Using settings file: {settingsFile}");

			MenuList menu = new MenuList();
			menu.Add(TEST_LISTENER, new CMenu() { Text = "Test listener", Fnc = TestListener });
			menu.Add(TEST_LISTENER_CREATE, new CMenu() { Text = "Generate listener test file", Fnc = TestListenerCreate });
			menu.Add(DISPLAY_SETTINGS, new CMenu() { Text = "Display settings", Fnc = DisplaySettings });
			menu.Add(RELOAD_SETTINGS, new CMenu() { Text = "Reload settings", Fnc = ReloadSettings });
			//menu.Add(i++.ToString()[0], new CMenu() { Text = ACTIVATE_DISPLAY, Fnc = ActivityDisplay });
			menu.Add('X', new CMenu() { Text = "Exit", Fnc = Exit });

			// Start listener
			CListener listener = new CListener();
			bool ok = listener.Start(settingsFile);
			TestListenerType testListenerType = new TestListenerType() { FileToUse = LISTENER_TEST_FILE, Port = listener.Port, IP = listener.IP };
			while (ok)
			{
				CMenu entry = DisplayMenu(menu, out char option);
				if (null != entry)
					switch (option)
					{
						case RELOAD_SETTINGS:
							{
								ReloadSettingsType type = new ReloadSettingsType() { SettingsFile = settingsFile, Listener = listener };
								if (ok = entry.Fnc(menu, entry, option, type))
								{
									settingsFile = type.SettingsFile;
									listener = type.Listener;
								}
								break;
							}

						case TEST_LISTENER:
							{
								ok = entry.Fnc(menu, entry, option, testListenerType);
								break;
							}

						case DISPLAY_SETTINGS:
							{
								ok = entry.Fnc(menu, entry, option, listener);
								break;
							}

						default:
							ok = entry.Fnc(menu, entry, option, null);
							break;
					}
			}
			listener.Stop();
		}
		#endregion

		#region methods
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="option"></param>
		/// <returns></returns>
		static CMenu DisplayMenu(MenuList menu, out char option)
		{
			Console.WriteLine("");
			foreach (KeyValuePair<char, CMenu> m in menu)
				Console.WriteLine(m.Key + $"/ {m.Value.Text}");
			Console.WriteLine("");
			Console.Write("=> ");
			bool escape = false;
			char c;
			do
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				c = keyInfo.KeyChar.ToString().ToUpper()[0];
				option = c;
				escape = ConsoleKey.Escape == keyInfo.Key;
			} while (!menu.ContainsKey(option) && !escape);
			Console.WriteLine(escape ? "ESC" : c.ToString());
			return escape ? null : menu[option];
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool TestListener(MenuList menu, CMenu entry, char option, object o)
		{
			TestListenerType type = (TestListenerType)o;

			type.FileToUse = Input("File to use", LISTENER_TEST_FILE, out bool isdef);
			if (string.IsNullOrEmpty(type.FileToUse))
			{
				Console.WriteLine("Invalid test file");
				return true;
			}

			type.IP = Input("Listener IP", CStream.Localhost(), out isdef);
			if (string.IsNullOrEmpty(type.IP))
			{
				Console.WriteLine("Invalid IP");
				return true;
			}

			string sport = Input("Listener port to reach", type.Port.ToString(), out isdef);
			if (string.IsNullOrEmpty(sport)) return true;
			try
			{
				type.Port = uint.Parse(sport);
			}
			catch (Exception)
			{
				Console.WriteLine("Invalid port number");
				return true;
			}

			//var json = new CJson<CListenerRequest>(fileToUse);
			//var request = json.ReadSettings(out bool except);
			//if (null != request)
			//{
			//	var sreply = CStream.ConnectSendReceive(new CStreamClientSettings() { IP = ip, Port = port }, CJson<CListenerRequest>.Serialize(request), out int size, out bool error);
			//	if (!string.IsNullOrEmpty(sreply))
			//	{
			//		CLogger.Add(sreply);
			//		var reply = CJson<CListenerReply>.Deserialize(sreply, out except);
			//		CLogger.Add(reply.ToString());
			//	}
			//	else
			//		CLogger.Add("No reply has been received");
			//}

			var json = new CJson<CListenerRequest>(type.FileToUse);
			var request = json.ReadSettings(out bool except);
			if (null != request)
			{
				CStreamClientIO streamIO = CStream.Connect(new CStreamClientSettings() { IP = type.IP, Port = type.Port });
				if (null != streamIO)
				{
					if (CStream.Send(streamIO, CJson<CListenerRequest>.Serialize(request)))
					{
						string sreply;
						while (!string.IsNullOrEmpty(sreply = CStream.Receive(streamIO, out int announcedSize, out bool error)))
						{
							var reply = CJson<CListenerReply>.Deserialize(sreply, out except);
							CLogger.Add($"{reply.ToString()} (received message)");
							if (!reply.Notification)
								break;
						}
					}
				}
			}

			return true;
		}
		class TestListenerType
		{
			public uint Port;
			public string FileToUse;
			public string IP;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool TestListenerCreate(MenuList menu, CMenu entry, char option, object o)
		{
			string fileToUse = Input("File to use", LISTENER_TEST_FILE, out bool isdef);
			if (string.IsNullOrEmpty(fileToUse)) return true;

			FileInfo fi = new FileInfo(fileToUse);
			if (!fi.Exists || YesNo($"A test file called {fileToUse} already exists, do you want to override it ?"))
			{
				var json = new CJson<CListenerRequest>(fileToUse);
				CListenerRequest req = json.ReadSettings(out bool except);

				string ip = Input("POI IP", (null != req ? req.IP : CStream.Localhost()), out isdef);
				if (null == ip) return true;

				int port;
				string sport = Input("POI Port", (null != req ? req.Port.ToString() : "2018"), out isdef);
				if (null == sport) return true;
				try
				{
					port = int.Parse(sport);
				}
				catch (Exception)
				{
					return true;
				}

				string saleid = Input($"Sale ID", (null != req ? req.SaleID : "SaleID"), out isdef);
				if (null == saleid) return true;

				string poiid = Input($"POI ID", (null != req ? req.POIID : "POIID"), out isdef);
				if (null == poiid) return true;

				string service = Input($"Retailer service to call", (null != req ? req.Service : MessageCategoryEnumeration.Login.ToString()), out isdef);
				if (null == service) return true;

				bool isLogin = (0 == string.Compare(MessageCategoryEnumeration.Login.ToString(), service, true));
				bool isPay = (0 == string.Compare(MessageCategoryEnumeration.Payment.ToString(), service, true));

				/*
				bool autologin = false;
				if (!isLogin)
				{
					autologin = YesNo("Autologin");
				}
				*/

				double amount = 0D;
				PaymentTypeEnumeration pt = PaymentTypeEnumeration.Normal;
				if (isPay)
				{
					if (!YesNo("Normal Payment (otherwise it will be a Refund)"))
						pt = PaymentTypeEnumeration.Refund;

					try
					{
						amount = double.Parse(Input("Amount", "1", out isdef));
					}
					catch (Exception)
					{
						amount = 0D;
					}
				}

				string dts = (isLogin ? "LoginRequest.SaleSoftware.ManufacturerID" : null);
				string value = null;
				if (null != dts)
					try
					{
						value = req.ElementsToSend[dts].Value.ToString();
					}
					catch (Exception) { }
				dts = Input("Data to send", dts, out isdef);
				if (null != dts)
					value = Input($"Value for {dts}", value, out isdef);

				string dtr = (isLogin ? "LoginResponse.POISystemData.POISoftware.ManufacturerID" : null);
				//if (0 != req.ElementsToSend.Count)
				//	foreach (KeyValuePair<string, CListenerDataElement> k in req.ElementsToReturn)
				//	{
				//		dtr = k.Key;
				//		break;
				//	}
				dtr = Input("Data to return", dtr, out isdef);

				var toSend = new CListenerDataElements();
				if (null != dts)
					toSend.Add(dts, new CListenerDataElement() { Value = value });
				var toReturn = new CListenerDataElements();
				if (null != dtr)
					toReturn.Add(dtr, new CListenerDataElement());
				var request = new CListenerRequest() { Amount = (isPay ? amount : 0D), PaymentType = (isPay ? pt.ToString() : null), ElementsToSend = toSend, ElementsToReturn = toReturn, IP = ip, Port = port, Service = service, POIID = poiid, SaleID = saleid };

				json.WriteSettings(request);
				Console.WriteLine();
				Console.WriteLine(request.ToString());
			}
			return true;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool Exit(MenuList menu, CMenu entry, char option, object o)
		{
			return !YesNo("Confirm exit ?");
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool ActivityDisplay(MenuList menu, CMenu entry, char option, ref object o)
		{
			try
			{
				if (0 == string.Compare(menu[option].Text, ACTIVATE_DISPLAY, true))
					menu[option].Text = DEACTIVATE_DISPLAY;
				else
					menu[option].Text = ACTIVATE_DISPLAY;
			}
			catch (Exception) { }
			return true;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool ReloadSettings(MenuList menu, CMenu entry, char option, object o)
		{
			ReloadSettingsType type = (ReloadSettingsType)o;
			type.SettingsFile = Input("Settings file to load", type.SettingsFile, out bool isdef);
			if (string.IsNullOrEmpty(type.SettingsFile))
			{
				CLogger.Add("No settings modified", TLog.WARNG);
				return true;
			}
			type.Listener.Stop();
			type.Listener = new CListener();
			return type.Listener.Start(type.SettingsFile);
		}
		class ReloadSettingsType
		{
			public CListener Listener;
			public string SettingsFile;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool DisplaySettings(MenuList menu, CMenu entry, char option, object o)
		{
			Console.WriteLine(o.ToString());
			return true;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="msg"></param>
		/// <returns>True if YES, false if NO</returns>
		static bool YesNo(string msg)
		{
			Console.WriteLine();
			Console.Write(msg + " [Y/N] ");
			string yes = "Yy", no = "Nn";
			string confirm = yes + no;
			char c;
			do
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				c = keyInfo.KeyChar.ToString().ToUpper()[0];
			} while (!confirm.Contains(c));
			return yes.Contains(c);
		}
		static string Input(string msg, string defv, out bool isdef)
		{
			Console.WriteLine();
			Console.Write(msg + (null != defv ? $" [{defv}]" : null) + ": ");
			string s = Console.ReadLine();
			if (isdef = (null != defv && string.IsNullOrEmpty(s)))
			{
				s = defv;
				Console.WriteLine("=> " + s);
			}
			else if (string.IsNullOrEmpty(s))
				s = null;
			return s;
		}
		#endregion
	}
}
