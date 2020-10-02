using System;
using System.Collections.Generic;
using System.Text;

namespace NEXO
{
	public abstract class NexoSaleToPOIMessages
	{
		public NexoSaleToPOIMessages()
		{
			Generating = false;
		}
		internal bool Generating { get => _generating; set => _generating = value; }
		private static bool _generating = false;
	}

	public partial class SaleToPOIRequest: NexoSaleToPOIMessages
	{ }
	public partial class SaleToPOIResponse: NexoSaleToPOIMessages
	{ }
}
