namespace nexoRetailerListenerService
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IHost host = Host.CreateDefaultBuilder(args)
				 .ConfigureServices(services =>
				 {
					 services.AddHostedService<Worker>();
				 })
#if !DEBUG
				 .UseWindowsService()
#endif
				 .Build();

			host.Run();
		}
	}
}