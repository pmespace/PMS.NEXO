#define USEWSINTERFACE

using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using NEXO;
using COMMON;
using Listener.App.Properties;
using Listener.Shared;
using Listener.Registry;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace Listener.App
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
			public bool Display { get; set; } = true;
		}
		#endregion

		#region const
		private const string LISTENER_SETTINGS_FILE = CListener.DEFAULT_SETTINGS_FILE_NAME;
		private const string LISTENER_TEST_FILE = "listener.request.json";
		private const string LISTENER_LOG_FILE = "listenerApp.log";

		private const string ACTIVATE_DISPLAY = "Activate activity display";
		private const string DEACTIVATE_DISPLAY = "Deactivate activity display";

		private const string OPTION_SETTINGS_FILE_NAME = "-s";
		private const string OPTION_LOG_FILE_NAME = "-l";
		private const string OPTION_LOG_AUTO_PURGE = "-a";
		private const string OPTION_LOG_NUMBER_OF_FILES = "-n";
		private const string OPTION_START_LISTENER = "-r";

		private const char START_LISTENER = 'S';
		private const char TEST_LISTENER = '0';
		private const char TEST_LISTENER_CREATE = '1';
		private const char DISPLAY_SETTINGS = '2';
		private const char RELOAD_SETTINGS = '3';
		#endregion

		#region properties
		static bool started = false;
		static CListener listener = null;
		static CListenerSettings Settings = null;
		static CListenerRegistry.CListenerRegistrySettings RegSettings = null;
		#endregion

		#region main
		static void Main(string[] args)
		{
			Console.Title = $"ListenerApp - v{CMisc.Version(CMisc.VersionType.assembly)}";

			CLog.Filename = LISTENER_LOG_FILE;

			// read registry
			RegSettings = CListenerRegistry.Read();
			if (default == RegSettings)
			{
				CLogger.ERROR(Resources.FailedReadRegistry);
				return;
			}

			// read listener settings
			Settings = CListener.LoadSettings(RegSettings.FullSettingsFilename, false);
			if (default == Settings)
			{
				CLogger.ERROR(Resources.FailedReadListenerSettings.Format(RegSettings.FullSettingsFilename));
				return;
			}
			CLogger.TRACE(Resources.UsingSettingsFile.Format(new object[] { RegSettings.FullSettingsFilename }));

			#region deprecated
			//// take a list of strings (refer to PathToData) and add it to a dictionary of paths + save the value to use
			//Func<string, string, string, string> CheckOption = (string arg, string option, string data) =>
			//{
			//	try
			//	{
			//		if ((arg.StartsWith(option, true, null)) && option.Length < arg.Length && string.IsNullOrEmpty(data))
			//			return arg.Substring(option.Length);
			//		return data;
			//	}
			//	catch (Exception) { }
			//	return null;
			//};

			//// get start options
			//foreach (string s in args)
			//{
			//	// has the settings file been specified
			//	//if ((s.StartsWith(OPTION_SETTINGS_FILE_NAME, true, null)) && OPTION_SETTINGS_FILE_NAME.Length < s.Length && string.IsNullOrEmpty(settingsFile))
			//	//settingsFile = s.Substring(OPTION_SETTINGS_FILE_NAME.Length);

			//	// has the log file been specified
			//	//if ((s.StartsWith(OPTION_LOG_FILE_NAME, true, null)) && OPTION_LOG_FILE_NAME.Length < s.Length && string.IsNullOrEmpty(logFile))
			//	//	logFile = s.Substring(OPTION_LOG_FILE_NAME.Length);

			//	settingsFile = CheckOption(s, OPTION_SETTINGS_FILE_NAME, settingsFile);
			//	logFile = CheckOption(s, OPTION_LOG_FILE_NAME, logFile);
			//	numberOfFiles = CheckOption(s, OPTION_LOG_NUMBER_OF_FILES, numberOfFiles);
			//	autoPurge = CheckOption(s, OPTION_LOG_AUTO_PURGE, autoPurge);
			//}

			//if (string.IsNullOrEmpty(settingsFile))
			//	settingsFile = LISTENER_SETTINGS_FILE;
			//if (string.IsNullOrEmpty(logFile))
			//	logFile = LISTENER_LOG_FILE;
			//try
			//{
			//	CLog.AutoPurgeLogFiles = bool.Parse(autoPurge);
			//}
			//catch
			//{
			//	CLog.AutoPurgeLogFiles = true;
			//}
			//try
			//{
			//	CLog.NumberOfFilesToKeep = int.Parse(numberOfFiles);
			//}
			//catch
			//{
			//	CLog.NumberOfFilesToKeep = 3;
			//}
			//CLog.Filename = logFile;
			#endregion

			MenuList menu = new MenuList();
			menu.Add(START_LISTENER, new CMenu() { Text = Resources.MenuStartListener, Fnc = StartListener });
			menu.Add(TEST_LISTENER, new CMenu() { Text = Resources.MenuTestListener, AFnc = TestListener });
			menu.Add(TEST_LISTENER_CREATE, new CMenu() { Text = Resources.MenuGenerateListenerTestFile, Fnc = TestListenerCreate });
			menu.Add(DISPLAY_SETTINGS, new CMenu() { Text = Resources.MenuDisplaySettings, Fnc = DisplaySettings });
			menu.Add('X', new CMenu() { Text = Resources.MenuExit, Fnc = Exit });
			var testListenerType = new TestListenerType() { FileToUse = LISTENER_TEST_FILE, Port = Settings.Server.Port, IP = CStream.Localhost(), WSMap = Settings.Server.WSServer.WSMap, WSPort = Settings.Server.WSServer.WSPort };

			bool ok = true;
			while (ok)
			{
				if (!started)
				{
					menu[START_LISTENER].Text = Resources.MenuStartListener;
					menu[START_LISTENER].Fnc = StartListener;
				}
				else
				{
					menu[START_LISTENER].Text = Resources.MenuStopListener;
					menu[START_LISTENER].Fnc = StopListener;
				}
				CMenu entry = DisplayMenu(menu, out char option);
				if (null != entry)
					switch (option)
					{
						case START_LISTENER:
							{
								//ok = entry.Fnc(menu, entry, option, testListenerType);
								if (entry.Fnc(menu, entry, option, testListenerType))
								{
									if (!started)
										menu.Add(RELOAD_SETTINGS, new CMenu() { Text = Resources.MenuReloadSettings, Fnc = ReloadSettings });
									else
										menu.Remove(RELOAD_SETTINGS);
								}
								ok = true;
								break;
							}

						case RELOAD_SETTINGS:
							{
								ReloadSettingsType type = new ReloadSettingsType() { SettingsFile = RegSettings.FullSettingsFilename, Listener = listener };
								if (ok = entry.Fnc(menu, entry, option, type))
								{
									//listener = type.Listener;
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
			listener?.Stop();
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
			Console.WriteLine(escape ? Resources.ESC : c.ToString());
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

			type.FileToUse = Input(Resources.TestFileToUse, LISTENER_TEST_FILE, out bool isdef);
			if (string.IsNullOrEmpty(type.FileToUse))
			{
				Console.WriteLine(Resources.InvalidTestFile);
				return true;
			}

			type.IP = Input(Resources.ListenerIP, CStream.Localhost(), out isdef);
			if (string.IsNullOrEmpty(type.IP))
			{
				Console.WriteLine(Resources.InvalidIP);
				return true;
			}

			bool useWS = false;
#if USEWSINTERFACE
			useWS = CMisc.YesNo(Resources.UseWS, true, true, true, new string[] { Resources.YesL, Resources.YesS }, new string[] { Resources.NoL, Resources.NoS }, true, true);
			if (useWS)
			{
				type.WSMap = Input(Resources.WSMap, type.WSMap, out isdef);
				if (string.IsNullOrEmpty(type.WSMap))
				{
					Console.WriteLine(Resources.InvalidWSMap);
					return true;
				}
			}
#endif

			uint uport = 0;
			string sport = Input(Resources.ListenerPort, useWS ? type.WSPort.ToString() : type.Port.ToString(), out isdef);
			if (string.IsNullOrEmpty(sport)) return true;
			try
			{
				uport = uint.Parse(sport);
			}
			catch (Exception)
			{
				Console.WriteLine(Resources.InvalidPort);
				return true;
			}

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
							CLogger.TRACE($"{request} ({string.Format(Resources.SentMessage, new object[] { clientSettings.ReceiveTimeout })})");
							while (!string.IsNullOrEmpty(sreply = CStream.ReceiveAsString(streamIO)))
							{
								var reply = CJson<CListenerReply>.Deserialize(sreply);
								CLogger.TRACE($"{reply.Message} ({Resources.ReceivedMessage})");
								if (!reply.Notification)
								{
									CLogger.TRACE($"{reply}");
									break;
								}
							}
						}
						else
						{
							CLogger.ERROR(Resources.FailedSendingRequest);
						}
					}

#if USEWSINTERFACE
				}
				else
				{
					CancellationTokenSource innerSource = new CancellationTokenSource();
					CancellationToken innerToken = innerSource.Token;
					ClientWebSocket WS = new ClientWebSocket();
					string su = $"ws://{type.IP}:{uport}{type.WSMap}";
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
								CLogger.TRACE($"{reply.Message} ({Resources.ReceivedMessage})");
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
						CLogger.ERROR(Resources.FailedSendingRequest);
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
			string fileToUse = CMisc.Input(Resources.FileToUse, LISTENER_TEST_FILE, out bool isdef);
			if (fileToUse.IsNullOrEmpty()) return true;

			FileInfo fi = new FileInfo(fileToUse);
			if (!fi.Exists || CMisc.YesNo(Resources.TestFileAlreadyExists.Format(fileToUse), true, false, true, new string[] { Resources.YesL, Resources.YesS }, new string[] { Resources.NoL, Resources.NoS }, true, true))
			{
				var json = new CJson<CListenerRequest>(fileToUse);
				CListenerRequest req = json.ReadSettings();

				//string ip = Input("POI to reach", (null != req ? req.IP : CStream.Localhost()), out isdef);
				string poi = Input(Resources.POIToReach, string.Empty, out isdef);
				if (poi.IsNullOrEmpty()) return true;

				string saleid = Input(Resources.SaleID, (null != req ? req.SaleID : "SaleID"), out isdef);
				if (null == saleid) return true;

				string poiid = Input(Resources.POIID, (null != req ? req.POIID : "POIID"), out isdef);
				if (null == poiid) return true;

				string service = Input(Resources.RetailerServiceToCall, (null != req ? req.Service : MessageCategoryEnumeration.Login.ToString()), out isdef);
				if (null == service) return true;

				bool isLogin = (0 == string.Compare(MessageCategoryEnumeration.Login.ToString(), service, true));
				bool isPay = (0 == string.Compare(MessageCategoryEnumeration.Payment.ToString(), service, true));

				double amount = 0D;
				PaymentTypeEnumeration pt = PaymentTypeEnumeration.Normal;
				if (isPay)
				{
					if (!CMisc.YesNo(Resources.NormalPaymentOrRefund, true, true, true, new string[] { Resources.YesL, Resources.YesS }, new string[] { Resources.NoL, Resources.NoS }, true, true))
						pt = PaymentTypeEnumeration.Refund;

					try
					{
						amount = double.Parse(Input(Resources.Amount, "1", out isdef));
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
				dts = Input(Resources.DataToSend, dts, out isdef);
				if (null != dts)
					value = Input(Resources.ValueFor.Format(dts), value, out isdef);

				string dtr = (isLogin ? "LoginResponse.POISystemData.POISoftware.ManufacturerID" : null);
				//if (0 != req.ElementsToSend.Count)
				//	foreach (KeyValuePair<string, CListenerDataElement> k in req.ElementsToReturn)
				//	{
				//		dtr = k.Key;
				//		break;
				//	}
				dtr = Input(Resources.DataToReturn, dtr, out isdef);

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
		static bool StartListener(MenuList menu, CMenu entry, char option, object o)
		{
			if (started)
				return true;

			// Start listener
			listener = new CListener();
			return started = listener.Start(RegSettings.FullSettingsFilename);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		/// <param name="entry"></param>
		/// <param name="option"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static bool StopListener(MenuList menu, CMenu entry, char option, object o)
		{
			// Start listener
			listener?.Stop();
			//listener = null;
			started = false;
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
			return !CMisc.YesNo(Resources.ConfirmExit, true, true, true, new string[] { Resources.YesL, Resources.YesS }, new string[] { Resources.NoL, Resources.NoS }, true, true);
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
			//ReloadSettingsType type = (ReloadSettingsType)o;
			//type.SettingsFile = Input("Settings file to load", type.SettingsFile, out bool isdef);
			//if (string.IsNullOrEmpty(type.SettingsFile))
			//{
			//	CLogger.WARNING("No settings modified");
			//	return true;
			//}
			//type.Listener.Stop();
			//type.Listener = new CListener();
			//return type.Listener.Start(type.SettingsFile);

			StopListener(null, null, START_LISTENER, null);
			StartListener(null, null, START_LISTENER, null);
			return true;
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
