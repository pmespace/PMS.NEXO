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

	[Guid("0010366D-C2CC-4685-A52A-9716D59740F3")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public abstract class NexoActivity : INexoActivity
	{
		#region constructor
		public NexoActivity()
		{
			_sentmessages = new NexoListOfAnyMessages("SENT MESSAGES");
			_receivedmessages = new NexoListOfAnyMessages("RECEIVED MESSAGES");

			SentMessages = new ReadOnlyCollection<NexoAnyMessage>(_sentmessages);
			ReceivedMessages = new ReadOnlyCollection<NexoAnyMessage>(_receivedmessages);
		}
		#endregion

		#region properties
		private NexoListOfAnyMessages _sentmessages { get; set; }
		private NexoListOfAnyMessages _receivedmessages { get; set; }

		public ReadOnlyCollection<NexoAnyMessage> SentMessages { get; }
		public ReadOnlyCollection<NexoAnyMessage> ReceivedMessages { get; }

		//internal CDatabase Database = new CDatabase();
		//internal NexoRetailerServerDatabase DatabaseSettings
		//{
		//	get => _databasesettings;
		//	set
		//	{
		//		if (null != value && value.IsValid)
		//			Database.ConnectionString = value.ConnectionString;
		//		if (Database.IsOpen)
		//			_databasesettings = value;
		//	}
		//}
		//private NexoRetailerServerDatabase _databasesettings = null;
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
				CLog.EXCEPT(ex);
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