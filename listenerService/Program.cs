using COMMON;
using Listener.Registry;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.WindowsServices;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;

namespace Listener.Service
{
	public class Program
	{
		#region properties
		public static CListenerRegistry.CListenerRegistrySettings RegSettings = null;
		#endregion

		public static void Main(string[] args)
		{
			RegSettings = CListenerRegistry.Read(args);
			if (null != RegSettings)
			{
				CLog.DEBUG("program 1");
				//CLog.Filename = RegSettings.FullLogFilename;
				//CLog.SeverityToLog = RegSettings.SeverityToLog;
				//CLog.NumberOfFilesToKeep = RegSettings.NumberOfFilesToKeep;

				IHost host = Host.CreateDefaultBuilder(args)
					.ConfigureLogging(options =>
					{
						if (OperatingSystem.IsWindows())
						{
							options.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Information);
						}
					})
					.ConfigureServices(services =>
					{
						services.AddHostedService<Worker>();
						if (OperatingSystem.IsWindows())
						{
							services.Configure<EventLogSettings>(config =>
							{
								if (OperatingSystem.IsWindows())
								{
									//config.LogName = CListenerRegistry.BASE_SERVICE_NAME;
									//config.SourceName = CListenerRegistry.BASE_NAME;
								}
							});
							services.AddWindowsService();
						}
					})
					.UseWindowsService()
					.Build();
				host.Run();
				CLog.DEBUG("fermé 2");
			}
		}
	}
}