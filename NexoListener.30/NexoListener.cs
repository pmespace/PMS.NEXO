//#define USEWSINTERFACE
#define RES

using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using NEXO;
using COMMON;
using NexoListener.Properties;
using Listener;
using Listener.Shared;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace NexoListener
{
	class Program
	{
		#region menu
		private class MenuList : SortedDictionary<char, CMenu> { }
		private delegate bool DFnc(MenuList menu, CMenu entry, char option, object o);
		private delegate Task<bool> DAFnc(MenuList menu, CMenu entry, char option, object o);
		class CMenu
		{
			public string Text { get; set; }
			public DFnc Fnc { get; set; } = null;
			public DAFnc AFnc { get; set; } = null;
		}
		#endregion

		#region const
		private const string LISTENER_SETTINGS_FILE = CListener.DEFAULT_SETTINGS_FILE_NAME;
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

			Console.Title = $"nexo Listener - v{CMisc.Version(CMisc.VersionType.assembly)}";

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
			CLog.Filename = logFile;

#if RES
			CLogger.TRACE(string.Format(Resources.UsingSettingsFile, new object[] { settingsFile }));
#else
			CLogger.TRACE(string.Format($"Usings settings file {0}", new object[] { settingsFile }));
#endif

			MenuList menu = new MenuList();

#if RES
			menu.Add(TEST_LISTENER, new CMenu() { Text = Resources.MenuTestListener, AFnc = TestListener });
#else
			menu.Add(TEST_LISTENER, new CMenu() { Text = "Test listener", AFnc = TestListener });
#endif
#if RES
			menu.Add(TEST_LISTENER_CREATE, new CMenu() { Text = Resources.MenuGenerateListenerTestFile, Fnc = TestListenerCreate });
#else
			menu.Add(TEST_LISTENER_CREATE, new CMenu() { Text = "Generate listener test file", Fnc = TestListenerCreate });
#endif
#if RES
			menu.Add(DISPLAY_SETTINGS, new CMenu() { Text = Resources.MenuDisplaySettings, Fnc = DisplaySettings });
#else
			menu.Add(DISPLAY_SETTINGS, new CMenu() { Text = "Display settings", Fnc = DisplaySettings });
#endif
#if RES
			menu.Add(RELOAD_SETTINGS, new CMenu() { Text = Resources.MenuReloadSettings, Fnc = ReloadSettings });
#else
			menu.Add(RELOAD_SETTINGS, new CMenu() { Text = "Reload settings", Fnc = ReloadSettings });
#endif
#if RES
			//menu.Add(i++.ToString()[0], new CMenu() { Text = ACTIVATE_DISPLAY, Fnc = ActivityDisplay });
#else
#endif
#if RES
			menu.Add('X', new CMenu() { Text = Resources.MenuExit, Fnc = Exit });
#else
			menu.Add('X', new CMenu() { Text = "Exit", Fnc = Exit });
#endif

			// Start listener
			CListener listener = new CListener();
			bool ok = listener.Start(settingsFile).Result;
			TestListenerType testListenerType = new TestListenerType() { FileToUse = LISTENER_TEST_FILE, Port = listener.Port, IP = listener.IP, WSMap = listener.WSMap, WSPort = listener.WSPort };
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
								//ok = entry.Fnc(menu, entry, option, testListenerType);
								var res = entry.AFnc(menu, entry, option, testListenerType);
								ok = true;
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
			{
				Console.Write(m.Key + $"/ ");
				Console.WriteLine($"{m.Value.Text}");
			}
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
#if RES
			Console.WriteLine(escape ? Resources.ESC : c.ToString());
#else
			Console.WriteLine(escape ? "ESC" : c.ToString());
#endif
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
		static async Task<bool> TestListener(MenuList menu, CMenu entry, char option, object o)
		{
			TestListenerType type = (TestListenerType)o;

#if RES
			type.FileToUse = Input(Resources.TestFileToUse, LISTENER_TEST_FILE, out bool isdef);
#else
			type.FileToUse = Input("Test file to use", LISTENER_TEST_FILE, out bool isdef);
#endif
			if (string.IsNullOrEmpty(type.FileToUse))
			{
#if RES
				Console.WriteLine(Resources.InvalidTestFile);
#else
				Console.WriteLine("Invalid test file");
#endif
				return true;
			}

#if RES
			type.IP = Input(Resources.ListenerIP, CStream.Localhost(), out isdef);
#else
			type.IP = Input("Listener IP", CStream.Localhost(), out isdef);
#endif
			if (string.IsNullOrEmpty(type.IP))
			{
#if RES
				Console.WriteLine(Resources.InvalidIP);
#else
				Console.WriteLine("Invalid IP");
#endif
				return true;
			}

			bool useWS = false;
#if USEWSINTERFACE
#if RES
			useWS = CMisc.YesNo(Resources.UseWS, true, true, true, new string[] { Resources.YesL, Resources.YesS }, new string[] { Resources.NoL, Resources.NoS }, true, true);
#else
			useWS = CMisc.YesNo("Use WS", true, true, true, new string[] { "Yes", "Y" }, new string[] { "No", "N" }, true, true);
#endif
			if (useWS)
			{
#if RES
				type.WSMap = Input(Resources.WSMap, type.WSMap, out isdef);
#else
				type.WSMap = Input("WSMap", type.WSMap, out isdef);
#endif
				if (string.IsNullOrEmpty(type.WSMap))
				{
#if RES
					Console.WriteLine(Resources.InvalidWSMap);
#else
					Console.WriteLine("Invalid WSMap");
#endif
					return true;
				}
			}
#endif

			uint uport = 0;
			string sport =
#if RES
					Input(Resources.ListenerPort, useWS ? type.WSPort.ToString() : type.Port.ToString(), out isdef);
#else
					Input("Listener port", useWS ? type.WSPort.ToString() : type.Port.ToString(), out isdef);
#endif
			if (string.IsNullOrEmpty(sport)) return true;
			try
			{
				uport = uint.Parse(sport);
			}
			catch (Exception)
			{
#if RES
				Console.WriteLine(Resources.InvalidPort);
#else
				Console.WriteLine("Invalid port");
#endif
				return true;
			}


			//bool useasync = CMisc.YesNo("Use asynchronous communication", true, false, false, null, null, false);

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
			var request = json.ReadSettings();
			if (null != request)
			{
#if USEWSINTERFACE
				if (!useWS)
				{
#endif
				CStreamClientSettings clientSettings = new CStreamClientSettings() { IP = type.IP, Port = uport, ReceiveTimeout = /*useasync ? 0 :*/ 60, };
				CStreamClientIO streamIO = CStream.Connect(clientSettings);
				if (null != streamIO)
				{
					//CThread thread = null;
					//if (useasync && (null != (thread = CStream.SendAsync(new CStream.SendAsyncType() { OnReply = OnReply, Settings = clientSettings, Parameters = null, ThreadData = null, }, CJson<CListenerRequest>.Serialize(request)))))
					//{
					//	CLogger.Add($"{request} (sent message, asynchronously)");
					//}
					//else if (!useasync && CStream.Send(streamIO, CJson<CListenerRequest>.Serialize(request)))
					if (CStream.Send(streamIO, CJson<CListenerRequest>.Serialize(request)))
					{
						string sreply;
#if RES
						CLogger.TRACE($"{request} ({string.Format(Resources.SentMessage, new object[] { clientSettings.ReceiveTimeout })})");
#else
							CLogger.TRACE($"{request} ({string.Format("message sent to listener, timeout is { 0 } seconds", new object[] { clientSettings.ReceiveTimeout })})");
#endif
						while (!string.IsNullOrEmpty(sreply = CStream.ReceiveAsString(streamIO)))
						{
							var reply = CJson<CListenerReply>.Deserialize(sreply);
#if RES
							CLogger.TRACE($"{reply.Message} ({Resources.ReceivedMessage})");
#else
								CLogger.TRACE($"{reply.Message} (received message from the listener)");
#endif
							if (!reply.Notification)
							{
								CLogger.TRACE($"{reply}");
								break;
							}
						}
					}
					else
					{
#if RES
						CLogger.ERROR(Resources.FailedSendingRequest);
#else
							CLogger.ERROR("Failed sending request");
#endif
					}
				}

#if USEWSINTERFACE
				}
				else
				{
					CancellationTokenSource innerSource = new CancellationTokenSource();
					CancellationToken innerToken = innerSource.Token;
					ClientWebSocket WS = new ClientWebSocket();
					string su = $"ws://{type.IP}:{type.Port}{type.WSMap}";
					await WS.ConnectAsync(new Uri(su), innerToken);
					if (WebSocketState.Open == WS.State)
					{
						await WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(CJson<CListenerRequest>.Serialize(request))), WebSocketMessageType.Text, true, innerToken);
						do
						{
							var res = await CWSListener.ReceiveAsync(WS, innerToken);
							if (!res.IsNullOrEmpty())
							{
								var reply = CJson<CListenerReply>.Deserialize(res);
#if RES
								CLogger.TRACE($"{reply.Message} ({Resources.ReceivedMessage})");
#else
								CLogger.TRACE($"{reply.Message} (received message from the listener message)");
#endif
								if (!reply.Notification)
								{
									CLogger.TRACE($"{reply}");
									innerSource.Cancel();
								}
							}
							else
								innerSource.Cancel();
						}
						while (!innerToken.IsCancellationRequested);
					}
					else
					{
#if RES
						CLogger.ERROR(Resources.FailedSendingRequest);
#else
						CLogger.ERROR("Failed sending request");
#endif
					}
				}
#endif
			}
			else
			{
				request = new CListenerRequest() { ElementsToSend = new CListenerDataElements() { { "test", new CListenerDataElement() { Value = new List<object>() { "test1", "test2" } } } } };
				json.WriteSettings(request, null, false);
			}
			return true;
		}
		class TestListenerType
		{
			public uint Port;
			public string FileToUse;
			public string IP;
			public string WSMap;
			public uint WSPort;
		}
		//private static bool OnReply(byte[] reply, bool error, CThread thread, object parameters)
		//{
		//	string sreply;
		//	while (!string.IsNullOrEmpty(sreply = CStream.Receive(streamIO, out int announcedSize, out bool error)))
		//	{
		//		var reply = CJson<CListenerReply>.Deserialize(sreply, out except);
		//		CLogger.Add($"{reply.ToString()} (received message)");
		//		if (!reply.Notification)
		//			break;
		//	}

		//	return true;
		//}
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
			if (!fi.Exists || CMisc.YesNo($"A test file called {fileToUse} already exists, do you want to override it ?", true, false, true, new string[] { "Yes", "Y" }, new string[] { "No", "N" }, true, true))
			{
				var json = new CJson<CListenerRequest>(fileToUse);
				CListenerRequest req = json.ReadSettings();

				//string ip = Input("POI to reach", (null != req ? req.IP : CStream.Localhost()), out isdef);
				string poi = Input("POI to reach", string.Empty, out isdef);
				if (poi.IsNullOrEmpty()) return true;

				//int port;
				//string sport = Input("POI Port", (null != req ? req.Port.ToString() : "2018"), out isdef);
				//if (null == sport) return true;
				//try
				//{
				//	port = int.Parse(sport);
				//}
				//catch (Exception)
				//{
				//	return true;
				//}

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
					if (!CMisc.YesNo("Normal Payment (otherwise it will be a Refund)", true, true, true, new string[] { "Tes", "Y" }, new string[] { "No", "N" }, true, true))
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
					toSend.Add(dts, new CListenerDataElement() { Value = new List<object>() { value } });
				var toReturn = new CListenerDataElements();
				if (null != dtr)
					toReturn.Add(dtr, new CListenerDataElement());
				var request = new CListenerRequest() { Amount = (isPay ? amount : 0D), PaymentType = (isPay ? pt.ToString() : null), ElementsToSend = toSend, ElementsToReturn = toReturn, POI = poi, Service = service, POIID = poiid, SaleID = saleid };

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
#if RES
			return !CMisc.YesNo(Resources.ConfirmExit, true, true, true, new string[] { "Yes", "Y" }, new string[] { "No", "N" }, true, true);
#else
			return CMisc.YesNo("Confirm exit", true, true, true, new string[] { "Yes", "Y" }, new string[] { "No", "N" }, true, true);
#endif
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
				CLogger.WARNING("No settings modified");
				return true;
			}
			type.Listener.Stop();
			type.Listener = new CListener();
			return type.Listener.Start(type.SettingsFile).Result;
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
		///// <summary>
		///// 
		///// </summary>
		///// <param name="msg"></param>
		///// <returns>True if YES, false if NO</returns>
		//static bool YesNo(string msg)
		//{
		//	Console.WriteLine();
		//	Console.Write(msg + " [Y/N] ");
		//	string yes = "Yy", no = "Nn";
		//	string confirm = yes + no;
		//	char c;
		//	do
		//	{
		//		ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		//		c = keyInfo.KeyChar.ToString().ToUpper()[0];
		//	} while (!confirm.Contains(c));
		//	return yes.Contains(c);
		//}
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
