using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Listener;
using Microsoft.Win32;
using COMMON;
using Listener.Shared;
using System.IO;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;
using static Listener.CListener;

namespace ListenerService._30
{
	public partial class ListenerService : ServiceBase
	{
		#region declarations
		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);
		#endregion

		#region enums
		public enum ServiceState
		{
			SERVICE_STOPPED = 0x00000001,
			SERVICE_START_PENDING = 0x00000002,
			SERVICE_STOP_PENDING = 0x00000003,
			SERVICE_RUNNING = 0x00000004,
			SERVICE_CONTINUE_PENDING = 0x00000005,
			SERVICE_PAUSE_PENDING = 0x00000006,
			SERVICE_PAUSED = 0x00000007,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct ServiceStatus
		{
			public int dwServiceType;
			public ServiceState dwCurrentState;
			public int dwControlsAccepted;
			public int dwWin32ExitCode;
			public int dwServiceSpecificExitCode;
			public int dwCheckPoint;
			public int dwWaitHint;
		};
		#endregion

		#region constants
		const string LOG_FOLDER = "Log";
		const string SETTINGS_FOLDER = "Settings";
		const string EVENT_LOG_SOURCE = "nexoListenerService.30";
		readonly string REGISTRY_KEY = $"SYSTEM\\CurrentControlSet\\Services\\{EVENT_LOG_SOURCE}\\Parameters";
		const string REGISTRY_KEY_SETTINGS_FILE_NAME = @"Settings";
		const string REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT = @"nexo.listener.service.30.settings.json";
		const string REGISTRY_KEY_LOG_FILE_NAME = @"Log";
		const string REGISTRY_KEY_LOG_FILE_NAME_DEFAULT = @"nexo.listener.service.30.log";
		#endregion

		#region properties
		string settingsFileName = string.Empty;
		string logFileName = string.Empty;
		EventLog eventLog = default;
		CListener listener = default;
		#endregion

		#region generic methods
		public ListenerService()
		{
			InitializeComponent();
			var eventLog = new EventLog();
			if (!EventLog.SourceExists(EVENT_LOG_SOURCE))
			{
				EventLog.CreateEventSource(EVENT_LOG_SOURCE, string.Empty);
			}
			eventLog.Source = EVENT_LOG_SOURCE;
			eventLog.Log = string.Empty;
		}

		protected override void OnStart(string[] args)
		{
			//eventLog.WriteEntry($"starting service");

			//// Update the service state to Start Pending
			//ServiceStatus serviceStatus = new ServiceStatus();
			//serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
			//serviceStatus.dwWaitHint = 100000;
			//SetServiceStatus(this.ServiceHandle, ref serviceStatus);

			if (Start()) return;

			//eventLog.WriteEntry($"failed to start service");
		}

		protected override void OnStop()
		{
			eventLog.WriteEntry($"stopping service");

			listener?.Stop();
		}
		#endregion

		#region methods
		/// <summary>
		/// Starts the service
		/// </summary>
		/// <returns></returns>
		bool Start()
		{
			try
			{
				// access the registry to get the settings file name

				//using (RegistryKey reg = Registry.LocalMachine.CreateSubKey(REGISTRY_KEY))
				//{
				//	Func<string, string, string> GetStrValue = (string _key_, string _defkey_) => reg.GetValue(_key_, _defkey_).ToString();

				//	settingsFileName = GetStrValue(REGISTRY_KEY_SETTINGS_FILE_NAME, REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT);
				//	logFileName = GetStrValue(REGISTRY_KEY_LOG_FILE_NAME, REGISTRY_KEY_LOG_FILE_NAME_DEFAULT);
				//}

				RegistryKey reg = default;
				try
				{
					reg = Registry.LocalMachine.CreateSubKey(REGISTRY_KEY);
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}

				if (default != reg)
				{
					Func<string, string, string> GetStrValue = (string _key_, string _defkey_) => reg.GetValue(_key_, _defkey_).ToString();

					settingsFileName = GetStrValue(REGISTRY_KEY_SETTINGS_FILE_NAME, REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT);
					logFileName = GetStrValue(REGISTRY_KEY_LOG_FILE_NAME, REGISTRY_KEY_LOG_FILE_NAME_DEFAULT);
				}
				else
				{
					settingsFileName = REGISTRY_KEY_SETTINGS_FILE_NAME_DEFAULT;
					logFileName = REGISTRY_KEY_LOG_FILE_NAME_DEFAULT;
				}

				// create working folders
				DirectorySecurity dsec = new DirectorySecurity();
				string fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{LOG_FOLDER}";
				var fldLog = Directory.CreateDirectory(fld);
				fld = $@"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}\{SETTINGS_FOLDER}";
				var fldSettings = Directory.CreateDirectory(fld);

				// create the listener object
				CLog.Filename = $@"{fldLog.FullName}\{logFileName}";
				listener = new CListener();
				if (listener.Start($@"{fldSettings.FullName}\{settingsFileName}"))
					return true;
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			// the listener failed to start
			listener = default;
			return false;
		}
		/// <summary>
		/// Delegate called to report <see cref="CListener"/> object status
		/// </summary>
		/// <param name="sts">status to report</param>
		/// <param name="msg">a text to use</param>
		void SetStatus(CListener.ListenerStatus sts, string msg = default)
		{
			switch (sts)
			{
				case ListenerStatus.Starting:
					eventLog.WriteEntry($"starting processes");
					break;
				case ListenerStatus.Started:
					eventLog.WriteEntry($"processes started");
					break;
				case ListenerStatus.Stopping:
					eventLog.WriteEntry($"stopping processes");
					break;
				case ListenerStatus.Stopped:
					eventLog.WriteEntry($"processes stopped");
					break;
				case ListenerStatus.ConnectingToWSServer:
					eventLog.WriteEntry($"connecting to WS server [{msg}]");
					break;
				case ListenerStatus.ConnectedToWSServer:
					eventLog.WriteEntry($"connected to WS server [{msg}]");
					break;
				case ListenerStatus.ConnectionToWSServerPending:
					eventLog.WriteEntry($"connection to WS server [{msg}] is pending");
					break;
				case ListenerStatus.DisconnectingFromWSServer:
					eventLog.WriteEntry($"disconnecting from WS server [{msg}]");
					break;
				case ListenerStatus.DisconnectedFromWSServer:
					eventLog.WriteEntry($"disconnected from WS server [{msg}]");
					break;
				case ListenerStatus.LoginToWSServer:
					eventLog.WriteEntry($"login to WS server [{msg}]");
					break;
				case ListenerStatus.LoginToWSServerDenied:
					eventLog.WriteEntry($"login to WS server [{msg}] has been denied");
					break;
				case ListenerStatus.LoggedToWSServer:
					eventLog.WriteEntry($"logged to WS server [{msg}]");
					break;
			}
		}
		#endregion
	}
}
