#define KEEPDATA

using COMMON;
using Listener;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Listener.Registry;
using Listener.Service.Properties;
using System.ServiceProcess;

namespace Listener.Service
{
	public class Worker : BackgroundService
	{
		#region declarations
		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);

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
		#endregion

		#region properties
		//string settingsFileName = string.Empty;
		//string logFileName = string.Empty;

		CListener listener = default;
		EventLog eventLog = default;

		readonly ILogger<Worker> _logger;
		readonly IHostApplicationLifetime _hostApplicationLifetime;
		#endregion

		//public Worker(ILogger<Worker> logger)
		public Worker(IHostApplicationLifetime hostApplicationLifetime, ILogger<Worker> logger)
		{
			_logger = logger;
			_hostApplicationLifetime = hostApplicationLifetime;

			try
			{
				bool ok = false;
				try
				{
					ok = EventLog.SourceExists(CListenerRegistry.EVENT_LOG_SOURCE);
				}
				catch (Exception) { }
				if (!ok)
				{
					try
					{
						EventLog.CreateEventSource(CListenerRegistry.EVENT_LOG_SOURCE, string.Empty);
						ok = true;
					}
					catch (Exception) { }
				}
				if (ok)
				{
					eventLog = new EventLog();
					eventLog.Source = CListenerRegistry.EVENT_LOG_SOURCE;
					eventLog.Log = string.Empty;
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			//bool ok = false;

			//// start the listener itself
			//try
			//{
			//	Logger.Log(eventLog, Resources.WorkerServiceIsStarting);
			//	listener = new CListener();
			//	if (!(ok = listener.Start(Program.RegSettings.FullSettingsFilename, SetStatus)))
			//	{
			//		// the listener failed to start
			//		Logger.Log(eventLog, Resources.WorkerServiceDidNotStart);
			//		listener = default;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Logger.Log(eventLog, Resources.WorkerServiceNotStarted, TLog.EXCPT);
			//	CLog.EXCEPT(ex);
			//}

			////if (canRun)
			//if (ok)
			//	while (!stoppingToken.IsCancellationRequested)
			//	{
			//		//_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
			//		//_logger.LogInformation(Resources.WorkerServiceIsRunning.Format(BASE_NAME), DateTimeOffset.Now);
			//		Logger.Log(eventLog, Resources.WorkerServiceIsRunning.Format(CListenerRegistry.BASE_NAME));
			//		await Task.Delay((int)Program.RegSettings.Timer, stoppingToken);
			//	}
			//else
			//{
			//	Logger.Log(eventLog, Resources.WorkerServiceNotStarted, TLog.EXCPT);
			//	_hostApplicationLifetime.StopApplication();
			//}

			bool ok = false;

			// start the listener itself
			try
			{
				Logger.Log(eventLog, Resources.WorkerServiceIsStarting);
				listener = new CListener();
				try
				{
					if (listener.Start(Program.RegSettings.FullSettingsFilename, SetStatus))
					{
						Logger.Log(eventLog, Resources.WorkerServiceIsRunning.Format(CListenerRegistry.BASE_NAME));
						try
						{
							listener.StoppedEvent.WaitOne();
						}
						catch (Exception ex)
						{
							CLog.EXCEPT(ex);
						}
					}
					else
					{
						// the listener failed to start
						Logger.Log(eventLog, Resources.WorkerServiceDidNotStart);
						listener = default;
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}

			}
			catch (Exception ex)
			{
				Logger.Log(eventLog, Resources.WorkerServiceNotStarted, TLog.EXCPT);
				CLog.EXCEPT(ex);
			}

			//_hostApplicationLifetime.StopApplication();
		}

		public override async Task StopAsync(CancellationToken cancellationToken)
		{
			Logger.Log(eventLog, Resources.WorkerServiceIsStopping);
			listener?.Stop();
			Logger.Log(eventLog, Resources.WorkerServiceIsStopped);
		}

		/// <summary>
		/// Delegate called to report <see cref="CListener"/> object status
		/// </summary>
		/// <param name="sts">status to report</param>
		/// <param name="msg">a text to use</param>
		void SetStatus(CListener.ListenerStatus sts, string msg = default)
		{
			if (null != eventLog)
			{
				switch (sts)
				{
					case CListener.ListenerStatus.Starting:
						eventLog.WriteEntry($"starting processes");
						break;
					case CListener.ListenerStatus.Started:
						eventLog.WriteEntry($"processes started");
						break;
					case CListener.ListenerStatus.NotStarted:
						eventLog.WriteEntry($"processes not started");
						break;
					case CListener.ListenerStatus.Stopping:
						eventLog.WriteEntry($"stopping processes");
						break;
					case CListener.ListenerStatus.Stopped:
						eventLog.WriteEntry($"processes stopped");
						break;
					case CListener.ListenerStatus.ConnectingToWSServer:
						eventLog.WriteEntry($"connecting to WS server [{msg}]");
						break;
					case CListener.ListenerStatus.ConnectedToWSServer:
						eventLog.WriteEntry($"connected to WS server [{msg}]");
						break;
					case CListener.ListenerStatus.ConnectionToWSServerPending:
						eventLog.WriteEntry($"connection to WS server [{msg}] is pending");
						break;
					case CListener.ListenerStatus.DisconnectingFromWSServer:
						eventLog.WriteEntry($"disconnecting from WS server [{msg}]");
						break;
					case CListener.ListenerStatus.DisconnectedFromWSServer:
						eventLog.WriteEntry($"disconnected from WS server [{msg}]");
						break;
					case CListener.ListenerStatus.LoginToWSServer:
						eventLog.WriteEntry($"login to WS server [{msg}]");
						break;
					case CListener.ListenerStatus.LoginToWSServerDenied:
						eventLog.WriteEntry($"login to WS server [{msg}] has been denied");
						break;
					case CListener.ListenerStatus.LoggedToWSServer:
						eventLog.WriteEntry($"logged to WS server [{msg}]");
						break;
				}
			}
		}
	}
}