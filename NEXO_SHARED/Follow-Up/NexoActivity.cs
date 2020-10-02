using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;

namespace NEXO
{
	[Guid("1ADB3E04-8743-492B-94C5-4F973C27B951")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoActivity
	{
		[DispId(100)]
		bool AddSentMessage(NexoAnyMessage o);
		[DispId(101)]
		bool AddReceivedMessage(NexoAnyMessage o);
	}

	[Guid("F251ACAA-9421-40B3-84DD-701081C933B7")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public abstract class NexoActivity: INexoActivity
	{
		#region constructor
		public NexoActivity()
		{
			SentMessages = new ReadOnlyCollection<NexoAnyMessage>(_sentmessages);
			ReceivedMessages = new ReadOnlyCollection<NexoAnyMessage>(_receivedmessages);
		}
		#endregion

		#region properties
		/// <summary>
		/// List of messages sent by the entity
		/// </summary>
		private NexoListOfAnyMessages _sentmessages = new NexoListOfAnyMessages("SENT MESSAGES");
		public ReadOnlyCollection<NexoAnyMessage> SentMessages { get; }
		/// <summary>
		/// List of messages received by the entity
		/// </summary>
		private NexoListOfAnyMessages _receivedmessages = new NexoListOfAnyMessages("RECEIVED MESSAGES");
		public ReadOnlyCollection<NexoAnyMessage> ReceivedMessages { get; }
		#endregion

		#region methods
		/// <summary>
		/// Add a message to a list of messages
		/// </summary>
		/// <param name="anymessages">The list of messages to add a message to</param>
		/// <param name="o">The message to add</param>
		/// <returns>True if added, false otherwise</returns>
		private bool AddAnyMessage(NexoListOfAnyMessages anymessages, NexoAnyMessage o)
		{
			try
			{
				anymessages.Add(o);
				return true;
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
			}
			return false;
		}
		public bool AddSentMessage(NexoAnyMessage o)
		{
			return AddAnyMessage(_sentmessages, o);
		}
		public bool AddReceivedMessage(NexoAnyMessage o)
		{
			return AddAnyMessage(_receivedmessages, o);
		}
		#endregion
	}
}