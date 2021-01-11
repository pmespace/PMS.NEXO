using System;
using System.Collections.Generic;
using System.Text;

namespace NEXO
{
	/// <summary>
	/// Abstract class used to extend the <see cref="SaleToPOIRequest"/> and <see cref="SaleToPOIResponse"/> classes
	/// </summary>
	public abstract class NexoSaleToPOIMessages
	{
		public NexoSaleToPOIMessages() { }
	}

	public partial class SaleToPOIRequest : NexoSaleToPOIMessages
	{ }
	public partial class SaleToPOIResponse : NexoSaleToPOIMessages
	{ }
}
