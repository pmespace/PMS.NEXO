using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO.Client
{
	[Guid("BC3BD01B-95AA-4D4A-B2A1-3AB16231142D")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerClientActivity
	{
		#region INexoRetailerClientActivity
		#endregion
	}
	[Guid("6CEE4921-3084-40F3-A919-A8CF3D443A03")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerClientActivity: NexoActivity, INexoRetailerClientActivity
	{
		#region constructor
		public NexoRetailerClientActivity() { }
		#endregion

		#region properties
		#endregion

		#region methods
		#endregion
	}
}