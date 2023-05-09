#define KEEPDATA
using COMMON;
using Listener;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.AccessControl;

namespace nexoRetailerListenerService
{
	public class Worker : BackgroundService
	{
		#region constants
		const string BASE_FOLDER = "nexoRetailer30Listener";
		const string LOG_FOLDER = $@"{BASE_FOLDER}\Log";
		const string SETTINGS_FOLDER = $@"{BASE_FOLDER}\Settings";
		const string EVENT_LOG_SOURCE = "nexo Retailer v3.0 Listener";
#if DEBUG
		const string REGISTRY_KEY_SHORT = @"Software\nexoRetailer30Listener";
		const string REGISTRY_KEY = $@"{REGISTRY_KEY_SHORT}\Parameters";
#else
		const string REGISTRY_KEY = @"SYSTEM\CurrentControlSet\Services\nexoRetailer30Listener\Parameters";
#endif
		const string REGISTRY_KEY_SETTINGS_FILE_NAME = @"Settings";
		const string REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT = @"nexo.30.listener.settings.json";
		const string REGISTRY_KEY_LOG_FILE_NAME = @"Log";
		const string REGISTRY_KEY_LOG_FILE_NAME_DEFAULT = @"nexo.30.listener.log";
		#endregion

		#region properties
		string settingsFileName = string.Empty;
		string logFileName = string.Empty;
		CListener? listener = default;
		private readonly ILogger<Worker> _logger;
		#endregion


		public Worker(ILogger<Worker> logger)
		{
			_logger = logger;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				//_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
				//await Task.Delay(1000, stoppingToken);

				try
				{
					RegistryKey? reg = default;
					try
					{
						// access the registry to get the settings file name
#if DEBUG
						reg = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY);
#else
						reg = Registry.LocalMachine.CreateSubKey(REGISTRY_KEY);
#endif
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex);
					}

					if (default != reg)
					{
						//Func<string, string, string> GetStrValue = (string _key_, string _defkey_) => reg.GetValue(_key_, _defkey_).ToString();
						Func<string, string, string> GetStrValue = (string _key_, string _defkey_) =>
						{
							object? __o__ = reg.GetValue(_key_, _defkey_);
							if (null == __o__) return string.Empty;
							else return __o__.ToString();
						};

						settingsFileName = GetStrValue(REGISTRY_KEY_SETTINGS_FILE_NAME, REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT);
						logFileName = GetStrValue(REGISTRY_KEY_LOG_FILE_NAME, REGISTRY_KEY_LOG_FILE_NAME_DEFAULT);
#if !KEEPDATA
						Registry.CurrentUser.DeleteSubKey(REGISTRY_KEY);
						Registry.CurrentUser.DeleteSubKey(REGISTRY_KEY_SHORT);
#endif
					}
					else
					{
						settingsFileName = REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT;
						logFileName = REGISTRY_KEY_LOG_FILE_NAME_DEFAULT;
					}

					// create working folders
					string fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{LOG_FOLDER}";
					var fldLog = Directory.CreateDirectory(fld);
					fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{SETTINGS_FOLDER}";
					var fldSettings = Directory.CreateDirectory(fld);

					// create the listener object
					CLog.LogFileName = $@"{fldLog.FullName}\{logFileName}";
					listener = new CListener();
					listener.Start($@"{fldSettings.FullName}\{settingsFileName}");
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				// the listener failed to start
				listener = default;
			}
		}
		//async Task Run(string settings) => listener?.Start(settings);

		public override async Task StopAsync(CancellationToken cancellationToken)
		{
			Console.WriteLine("Service is being stopped...");
			listener?.Stop();
			//await Stop();
			Console.WriteLine("Service stopped at {DateTimeOffset.Now}");
		}
		//async Task Stop() => listener?.Stop();
	}


	//	public class Worker : BackgroundService
	//	{
	//		#region constants
	//		const string BASE_FOLDER = "nexoRetailer30Listener";
	//		const string LOG_FOLDER = $@"{BASE_FOLDER}\Log";
	//		const string SETTINGS_FOLDER = $@"{BASE_FOLDER}\Settings";
	//		const string EVENT_LOG_SOURCE = "nexo Retailer v3.0 Listener";
	//#if DEBUG
	//		const string REGISTRY_KEY_SHORT = @"Software\nexoRetailer30Listener";
	//		const string REGISTRY_KEY = $@"{REGISTRY_KEY_SHORT}\Parameters";
	//#else
	//		const string REGISTRY_KEY = @"SYSTEM\CurrentControlSet\Services\nexoRetailer30Listener\Parameters";
	//#endif
	//		const string REGISTRY_KEY_SETTINGS_FILE_NAME = @"Settings";
	//		const string REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT = @"nexo.30.listener.settings.json";
	//		const string REGISTRY_KEY_LOG_FILE_NAME = @"Log";
	//		const string REGISTRY_KEY_LOG_FILE_NAME_DEFAULT = @"nexo.30.listener.log";
	//		#endregion

	//		#region properties
	//		string settingsFileName = string.Empty;
	//		string logFileName = string.Empty;
	//		CListener? listener = default;
	//		private readonly ILogger<Worker> _logger;
	//		#endregion


	//		public Worker(ILogger<Worker> logger)
	//		{
	//			_logger = logger;
	//		}

	//		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	//		{
	//			while (!stoppingToken.IsCancellationRequested)
	//			{
	//				//_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
	//				//await Task.Delay(1000, stoppingToken);

	//				try
	//				{
	//					RegistryKey? reg = default;
	//					try
	//					{
	//						// access the registry to get the settings file name
	//#if DEBUG
	//						reg = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY);
	//#else
	//						reg = Registry.LocalMachine.CreateSubKey(REGISTRY_KEY);
	//#endif
	//					}
	//					catch (Exception ex)
	//					{
	//						CLog.EXCEPT(ex);
	//					}

	//					if (default != reg)
	//					{
	//						Func<string, string, string> GetStrValue = (string _key_, string _defkey_) => reg.GetValue(_key_, _defkey_).ToString();

	//						settingsFileName = GetStrValue(REGISTRY_KEY_SETTINGS_FILE_NAME, REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT);
	//						logFileName = GetStrValue(REGISTRY_KEY_LOG_FILE_NAME, REGISTRY_KEY_LOG_FILE_NAME_DEFAULT);
	//#if !KEEPDATA
	//						Registry.CurrentUser.DeleteSubKey(REGISTRY_KEY);
	//						Registry.CurrentUser.DeleteSubKey(REGISTRY_KEY_SHORT);
	//#endif
	//					}
	//					else
	//					{
	//						settingsFileName = REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT;
	//						logFileName = REGISTRY_KEY_LOG_FILE_NAME_DEFAULT;
	//					}

	//					// create working folders
	//					string fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{LOG_FOLDER}";
	//					var fldLog = Directory.CreateDirectory(fld);
	//					fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{SETTINGS_FOLDER}";
	//					var fldSettings = Directory.CreateDirectory(fld);

	//					// create the listener object
	//					CLog.LogFileName = $@"{fldLog.FullName}\{logFileName}";
	//					listener = new CListener();
	//					listener.Start($@"{fldSettings.FullName}\{settingsFileName}");
	//				}
	//				catch (Exception ex)
	//				{
	//					CLog.EXCEPT(ex);
	//				}
	//				// the listener failed to start
	//				listener = default;
	//			}
	//		}
	//		//async Task Run(string settings) => listener?.Start(settings);

	//		public override async Task StopAsync(CancellationToken cancellationToken)
	//		{
	//			Console.WriteLine("Service is being stopped...");
	//			listener?.Stop();
	//			//await Stop();
	//			Console.WriteLine("Service stopped at {DateTimeOffset.Now}");
	//		}
	//		//async Task Stop() => listener?.Stop();
	//	}
}