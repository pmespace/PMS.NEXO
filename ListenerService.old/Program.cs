using COMMON;
using Listener.Registry;

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
				CLog.Filename = RegSettings.FullLogFilename;
				CLog.SeverityToLog = RegSettings.SeverityToLog;
				CLog.NumberOfFilesToKeep = RegSettings.NumberOfFilesToKeep;

				IHost host = Host.CreateDefaultBuilder(args)
					 .ConfigureServices(services =>
					 {
						 services.AddHostedService<Worker>();
					 })
					 .UseWindowsService()
					 .Build();
				host.Run();
			}
		}
	}
}