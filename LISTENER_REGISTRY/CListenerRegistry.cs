using COMMON;
using Microsoft.Win32;
using System;
using System.IO;

namespace Listener.Registry
{
	static public class CListenerRegistry
	{
		#region classes
		public class CListenerRegistrySettings
		{
			public string LogFilename { get; set; } = REGISTRY_KEY_LOG_FILE_NAME_DEFAULT;
			public string LogFilenameFolder { get; internal set; } = string.Empty;
			public string FullLogFilename { get; internal set; } = string.Empty;
			public string SettingsFilename { get; set; } = REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT;
			public string SettingsFilenameFolder { get; internal set; } = string.Empty;
			public string FullSettingsFilename { get; internal set; } = string.Empty;
			public TLog SeverityToLog { get; set; } = TLog.TRACE;
			public int NumberOfFilesToKeep { get => _numberoffilestokeep; set => _numberoffilestokeep = value; }
			internal int _numberoffilestokeep = CLog.KEEP_ALL_FILES;
			public uint Timer { get => _timer; set => _timer = value; }
			internal uint _timer = REGISTRY_KEY_STOP_TIMER_DEFAULT;
		}
		#endregion

		#region constants
		public const string BASE_PMS = "PMS";
		public const string BASE_NAME = "Listener";
		public static string BASE_SERVICE_NAME = $"{BASE_PMS}.{BASE_NAME}";
		public static string BASE_FOLDER = BASE_SERVICE_NAME;
		public static string LOG_FOLDER = $@"{BASE_FOLDER}\Log";
		public static string SETTINGS_FOLDER = $@"{BASE_FOLDER}\Settings";
		public static string EVENT_LOG_SOURCE = BASE_SERVICE_NAME;

#if DEBUG
		public static string REGISTRY_KEY_SHORT = $@"Software\{BASE_PMS}\{BASE_NAME}";
#else
		public static string REGISTRY_KEY_SHORT = $@"SYSTEM\CurrentControlSet\Services\{BASE_FOLDER}";
#endif
		public static string REGISTRY_KEY = $@"{REGISTRY_KEY_SHORT}\Parameters";

		public const string REGISTRY_KEY_SETTINGS_FILE_NAME = @"SettingsFilename";
		public static readonly string REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT = $@"{BASE_FOLDER.ToLower()}.settings.json";
		public const string REGISTRY_KEY_LOG_FILE_NAME = @"LogFilename";
		public static readonly string REGISTRY_KEY_LOG_FILE_NAME_DEFAULT = $@"{BASE_FOLDER.ToLower()}.log";
		public const string REGISTRY_KEY_NB_LOG_FILES_TO_KEEP = @"LogFilesToKeep";
		public const int REGISTRY_KEY_NB_LOG_FILES_TO_KEEP_DEFAULT = CLog.KEEP_ALL_FILES;
		public const string REGISTRY_KEY_SEVERITY_LEVEL = @"SeverityLevel";
		public static readonly string REGISTRY_KEY_SEVERITY_LEVEL_DEFAULT = TLog.TRACE.ToString();
		public const string REGISTRY_KEY_STOP_TIMER = @"StopTimer";
		public const int REGISTRY_KEY_STOP_TIMER_DEFAULT = 5_000;

		public const string ARGS_SETTINGS_FILE_NAME = "f";
		public const string ARGS_LOG_FILE_NAME = "l";
		public const string ARGS_SEVERITY_LEVEL = "s";
		public const string ARGS_TIMER_TO_USE = "t";
		public const string ARGS_FILES_TO_KEEP = "k";
		#endregion

		#region properties
		#endregion

		#region methods
		/// <summary>
		/// Allows reading the registry and retrieving settings to use or used by the listener
		/// </summary>
		/// <param name="args">Potentially a list of arguments</param>
		/// <returns>
		/// A <see cref="CListenerRegistrySettings"/> object if successful, null otherwise
		/// </returns>
		public static CListenerRegistrySettings Read(string[] args = null)
		{
			try
			{
				CListenerRegistrySettings regSettings = new CListenerRegistrySettings();

				/*
				 * access the registry to get the settings file name
				 */
				try
				{
					RegistryKey reg = default;
#if DEBUG
					reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGISTRY_KEY);
#else
					reg = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(REGISTRY_KEY);
#endif

					/* 
					 * fetch registry values
					 */
					if (default != reg)
					{
						Func<string, string, string> GetStrValue = (string _key_, string _defkey_) =>
						{
							object __o__ = reg.GetValue(_key_, _defkey_);
							if (null == __o__)
								return string.Empty;
							else
								return __o__.ToString();
						};
						Func<string, int, int> GetIntValue = (string _key_, int _defkey_) =>
						{
							object __o__ = reg.GetValue(_key_, _defkey_);
							if (null == __o__)
								return _defkey_;
							else if (int.TryParse(__o__.ToString(), out int result))
								return result;
							return _defkey_;
						};

						regSettings.SettingsFilename = GetStrValue(REGISTRY_KEY_SETTINGS_FILE_NAME, REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT);
						CLog.TRACE($"settings = {regSettings.SettingsFilename}");
						regSettings.LogFilename = GetStrValue(REGISTRY_KEY_LOG_FILE_NAME, REGISTRY_KEY_LOG_FILE_NAME_DEFAULT);
						regSettings.SeverityToLog = (TLog)CMisc.GetEnumValue(typeof(TLog), GetStrValue(REGISTRY_KEY_SEVERITY_LEVEL, REGISTRY_KEY_SEVERITY_LEVEL_DEFAULT), TLog.TRACE);
						regSettings.NumberOfFilesToKeep = GetIntValue(REGISTRY_KEY_NB_LOG_FILES_TO_KEEP, REGISTRY_KEY_NB_LOG_FILES_TO_KEEP_DEFAULT);
						regSettings.Timer = (uint)GetIntValue(REGISTRY_KEY_STOP_TIMER, (int)REGISTRY_KEY_STOP_TIMER_DEFAULT);
					}

					/*
					 * test whether some parameters were set by params
					 */
					if (null != args && 0 != args.Length)
					{
						string s;
						if (!(s = CMisc.SearchInArgs(args, ARGS_SETTINGS_FILE_NAME, out int index)).IsNullOrEmpty())
							regSettings.SettingsFilename = s;
						if (!(s = CMisc.SearchInArgs(args, ARGS_LOG_FILE_NAME, out index)).IsNullOrEmpty())
							regSettings.LogFilename = s;
						if (!(s = CMisc.SearchInArgs(args, ARGS_SEVERITY_LEVEL, out index)).IsNullOrEmpty())
							regSettings.SeverityToLog = (TLog)CMisc.GetEnumValue(typeof(TLog), s, regSettings.SeverityToLog);
						if (!(s = CMisc.SearchInArgs(args, ARGS_TIMER_TO_USE, out index)).IsNullOrEmpty())
							uint.TryParse(s, out regSettings._timer);
						if (!(s = CMisc.SearchInArgs(args, ARGS_FILES_TO_KEEP, out index)).IsNullOrEmpty())
							int.TryParse(s, out regSettings._numberoffilestokeep);
					}

					/*
					 * save registry values
					 */
					try
					{
						reg.SetValue(REGISTRY_KEY_SETTINGS_FILE_NAME, regSettings.SettingsFilename);
						reg.SetValue(REGISTRY_KEY_LOG_FILE_NAME, regSettings.LogFilename);
						reg.SetValue(REGISTRY_KEY_SEVERITY_LEVEL, regSettings.SeverityToLog.ToString());
						reg.SetValue(REGISTRY_KEY_NB_LOG_FILES_TO_KEEP, regSettings.NumberOfFilesToKeep);
						reg.SetValue(REGISTRY_KEY_STOP_TIMER, regSettings.Timer);
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex);
					}

					/*
					 * get working folders
					 */
					Func<string, string> FinalFolderName = (string fullName) => fullName + (!fullName.EndsWith(Path.DirectorySeparatorChar) ? new string(Path.DirectorySeparatorChar, 1) : string.Empty);

					string fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{LOG_FOLDER}";
					var fldLog = Directory.CreateDirectory(fld);
					regSettings.LogFilenameFolder = FinalFolderName(fldLog.FullName);
					fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{SETTINGS_FOLDER}";
					var fldSettings = Directory.CreateDirectory(fld);
					regSettings.SettingsFilenameFolder = FinalFolderName(fldSettings.FullName);

					/*
					 * set full file names
					 */
					regSettings.FullLogFilename = $@"{regSettings.LogFilenameFolder}{regSettings.LogFilename}";
					regSettings.FullSettingsFilename = $@"{regSettings.SettingsFilenameFolder}{regSettings.SettingsFilename}";

					/*
					 * final result
					 */
					CLog.Filename = regSettings.FullLogFilename;
					CLog.SeverityToLog = regSettings.SeverityToLog;
					CLog.NumberOfFilesToKeep = regSettings.NumberOfFilesToKeep;

					FileInfo fi = new FileInfo(regSettings.FullSettingsFilename);
					return fi.Exists ? regSettings : null;
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return null;
		}
		#endregion
	}
}