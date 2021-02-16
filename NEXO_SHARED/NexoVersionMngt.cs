using System.Collections.Generic;
using System.Reflection;
using System;
using COMMON;

namespace NEXO
{
	public class NexoVersion
	{
		public NexoVersion() { NexoAssembly = Assembly.GetAssembly(this.GetType()); }
		public string Version { get; internal set; }
		public string Description { get; internal set; }
		public string ResourceName { get; internal set; }
		public string AssemblyName { get; internal set; }
		public Assembly NexoAssembly { get; private set; }
		public override string ToString()
		{
			return Version;
		}
	}

	public static class NexoCurrentVersion
	{
		public readonly static NexoVersion Current =
#if NEXO30
			new NexoVersion()
			{
				Description = "Version 3.0 - 3rd October 2016",
				ResourceName = "nexo30",
				AssemblyName = "PMS.NEXO30.dll",
				Version = "3.0",
			};
#elif NEXO31
			new NexoVersion()
			{
				Description = "Version 3.1 - 31st July 2017",
				ResourceName = "nexo31",
				Version = "3.1",
				AssemblyName = "PMS.NEXO31.dll",
			};
#else
			null;
#endif
	}
}
