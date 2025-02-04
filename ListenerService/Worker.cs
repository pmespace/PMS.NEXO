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
using Microsoft.Extensions.Hosting;

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
		CListener listener = default;
		readonly ILogger<Worker> _logger;
		readonly IHostApplicationLifetime _hostApplicationLifetime;
		#endregion

		//public Worker(ILogger<Worker> logger)
		public Worker(IHostApplicationLifetime hostApplicationLifetime, ILogger<Worker> logger)
		{
			_logger = logger;
			_hostApplicationLifetime = hostApplicationLifetime;

			//try
			//{
			//	bool ok = false;
			//	try
			//	{
			//		ok = EventLog.SourceExists(CListenerRegistry.EVENT_LOG_SOURCE);
			//	}
			//	catch (Exception) { }
			//	if (!ok)
			//	{
			//		try
			//		{
			//			EventLog.CreateEventSource(CListenerRegistry.EVENT_LOG_SOURCE, string.Empty);
			//			ok = true;
			//		}
			//		catch (Exception) { }
			//	}
			//	if (ok)
			//	{
			//		eventLog = new EventLog();
			//		eventLog.Source = CListenerRegistry.EVENT_LOG_SOURCE;
			//		eventLog.Log = string.Empty;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	CLog.EXCEPT(ex);
			//}
		}

		protected override async Task ExecuteAsync(CancellationToken token)
		{
			token.Register(OnStop);

			//// start the listener itself
			//try
			//{
			//	Logger.Log(_logger, Resources.WorkerServiceIsStarting);
			//	listener = new CListener();
			//	if (listener.Start(Program.RegSettings.FullSettingsFilename, SetStatus))
			//	{
			//		Logger.Log(_logger, Resources.WorkerServiceIsRunning.Format(CListenerRegistry.BASE_NAME));
			//		listener.StoppedEvent.WaitOne();
			//		finalResult = true;
			//	}
			//	else
			//	{
			//		// the listener failed to start
			//		Logger.Log(_logger, Resources.WorkerServiceDidNotStart, TLog.ERROR);
			//		listener = default;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Logger.Log(_logger, Resources.WorkerServiceNotStarted, TLog.EXCPT);
			//	CLog.EXCEPT(ex);
			//}
			//_hostApplicationLifetime.StopApplication();
			//Environment.Exit(finalResult ? 0 : 1);

			bool ok = false;

			// start the listener itself
			try
			{
				Logger.Log(_logger, Resources.WorkerServiceIsStarting);
				listener = new CListener();
				if (await listener.Start(Program.RegSettings.FullSettingsFilename, SetStatus))
					//if (listener.Start(Program.RegSettings.FullSettingsFilename, SetStatus).Result)
				{
					ok = true;
					Logger.Log(_logger, Resources.WorkerServiceIsRunning.Format(CListenerRegistry.BASE_NAME));
					//listener.StoppedEvent.WaitOne();
					//while (!token.IsCancellationRequested)
					//	await Task.Delay(1000);
				}
				else
				{
					// the listener failed to start
					Logger.Log(_logger, Resources.WorkerServiceDidNotStart, TLog.ERROR);
					listener = default;
				}
			}
			catch (Exception ex)
			{
				Logger.Log(_logger, Resources.WorkerServiceNotStarted, TLog.EXCPT);
				CLog.EXCEPT(ex);
			}
			if (!ok)
			{
				_hostApplicationLifetime.StopApplication();
				Environment.Exit(1);
			}
			CLog.DEBUG("fermé 1");
		}

		public async override Task StopAsync(CancellationToken token)
		{
			CLog.DEBUG("stop 1");
			Logger.Log(_logger, Resources.WorkerServiceIsStopping);
			listener?.Stop();
			Logger.Log(_logger, Resources.WorkerServiceIsStopped);
			CLog.DEBUG("stop 2");
		}

		/// <summary>
		/// Action called when the service cancellationtoken is set
		/// </summary>
		void OnStop()
		{
			Logger.Log(_logger, Resources.WorkerServiceIsStopping);
			//listener?.StoppedEvent.Set();
			listener?.Stop();
			Logger.Log(_logger, Resources.WorkerServiceIsStopped);
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
				case CListener.ListenerStatus.Starting:
					Logger.Log(_logger, Resources.WorkerStartingProcesses);
					break;
				case CListener.ListenerStatus.Started:
					Logger.Log(_logger, Resources.WorkerProcessesStarted);
					break;
				case CListener.ListenerStatus.NotStarted:
					Logger.Log(_logger, Resources.WorkerProcessesNotStarted);
					break;
				case CListener.ListenerStatus.Stopping:
					Logger.Log(_logger, Resources.WorkerStoppingProcesses);
					break;
				case CListener.ListenerStatus.Stopped:
					Logger.Log(_logger, Resources.WorkerProcessesStopped);
					break;
				case CListener.ListenerStatus.ConnectingToWSServer:
					Logger.Log(_logger, Resources.WorkerConnectingToWSServer.Format(msg));
					break;
				case CListener.ListenerStatus.ConnectedToWSServer:
					Logger.Log(_logger, Resources.WorkerConnectedToWSServer.Format(msg));
					break;
				case CListener.ListenerStatus.ConnectionToWSServerPending:
					Logger.Log(_logger, Resources.WorkerConnectionToWSServerIsPending.Format(msg));
					break;
				case CListener.ListenerStatus.DisconnectingFromWSServer:
					Logger.Log(_logger, Resources.WorketDisconnectingFromWSServer.Format(msg));
					break;
				case CListener.ListenerStatus.DisconnectedFromWSServer:
					Logger.Log(_logger, Resources.WorkerDisconnectedFromWSServer.Format(msg));
					break;
				case CListener.ListenerStatus.LoginToWSServer:
					Logger.Log(_logger, Resources.WorkerLoginToWSServer.Format(msg));
					break;
				case CListener.ListenerStatus.LoginToWSServerDenied:
					Logger.Log(_logger, Resources.WorkerLoginDenied.Format(msg));
					break;
				case CListener.ListenerStatus.LoggedToWSServer:
					Logger.Log(_logger, Resources.WorkerLogged.Format(msg));
					break;
			}
		}
	}
}