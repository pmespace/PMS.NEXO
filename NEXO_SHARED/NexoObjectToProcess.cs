using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;

namespace NEXO
{
	[ComVisible(true)]
	public enum NexoNextAction
	{
		/// <summary>
		/// abort the operation, the message is dismissed without further processing
		/// </summary>
		nothing,
		/// <summary>
		/// a REPLY has been received, the exchange is final and no more sent (automatically)
		/// </summary>
		final,
		/// <summary>
		/// a REQUEST has been received for which no REPLY should be sent back
		/// </summary>
		noReply,
		/// <summary>
		/// a REQUEST has been received, a REPLY should be sent back
		/// </summary>
		sendReply,
		/// <summary>
		/// a REQUEST or a REPLY has been received, a REQUEST should be sent back
		/// </summary>
		sendRequest,
		/// <summary>
		/// a REQUEST or a REPLY has been received, a NOIFICATION should be sent back
		/// </summary>
		sendNotification,
	}

	[Guid("4DA003CE-49BF-4831-83EB-3DAEA2072370")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoObjectToProcess
	{
		#region INexoObjectToProcess
		[DispId(1)]
		NexoObject CurrentObject { get; }
		[DispId(2)]
		NexoObject NextObject { get; set; }
		[DispId(3)]
		int NextTimer { get; set; }
		[DispId(4)]
		NexoItem Item { get; }
		[DispId(5)]
		MessageTypeEnumeration Type { get; }
		[DispId(6)]
		MessageCategoryEnumeration Category { get; }
		[DispId(7)]
		NexoNextAction SuggestedAction { get; }
		[DispId(8)]
		bool CanModifyAction { get; }
		[DispId(9)]
		NexoNextAction Action { get; set; }
		#endregion
	}
	[Guid("195F55CA-64B2-4E61-A1DB-9964557DE450")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoObjectToProcess : INexoObjectToProcess
	{
		#region constructor
		public NexoObjectToProcess(NexoItem item)
		{
			Item = item;
			CanModifyAction = true;
			Action = NexoNextAction.nothing;
			SuggestedAction = NexoNextAction.nothing;
			CurrentObject = NexoItem.AllocateObject(item.Category);
			CurrentObject.FromItem(item);
			//Response = new NexoResponseType(CurrentObject.Response);
		}
		#endregion

		#region properties
		/// <summary>
		/// The message to process
		/// </summary>
		public NexoObject CurrentObject
		{
			get => _currentobject;
			protected set => _currentobject = value;
		}
		private NexoObject _currentobject;
		/// <summary>
		/// A potential message which will follow the processed one
		/// </summary>
		public NexoObject NextObject
		{
			get => nextmessage;
			set => nextmessage = value;
		}
		private NexoObject nextmessage = null;
		public int NextTimer { get; set; } = CStreamClientSettings.NO_TIMEOUT;
		/// <summary>
		/// The message to process
		/// </summary>
		public NexoItem Item
		{
			get => _item;
			protected set => _item = value;
		}
		private NexoItem _item;
		public MessageTypeEnumeration Type { get => Item.Type; }
		public MessageCategoryEnumeration Category { get => Item.Category; }
		/// <summary>
		/// Indicates which action is expected next (suggested by the framework)
		/// </summary>
		public NexoNextAction SuggestedAction
		{
			get => _suggestedaction;
			internal set
			{
				_suggestedaction = (CMisc.IsEnumValue(typeof(NexoNextAction), value) ? value : NexoNextAction.nothing);
				_action = _suggestedaction;
			}
		}
		private NexoNextAction _suggestedaction = NexoNextAction.nothing;
		/// <summary>
		/// Flag indicating whether the application can or or modify the <see cref="SuggestedAction"/> by the server
		/// </summary>
		public bool CanModifyAction { get; internal set; }
		/// <summary>
		/// Indicates which action is going to be made (decided by the application)
		/// </summary>
		public NexoNextAction Action
		{
			get => _action;
			set
			{
				ActionError = true;
				if (CanModifyAction)
					switch (SuggestedAction)
					{
						case NexoNextAction.nothing:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									ActionError = false;
									break;
							}
							break;

						case NexoNextAction.final:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									ActionError = false;
									break;
							}
							break;

						case NexoNextAction.noReply:
							switch (value)
							{
								case NexoNextAction.noReply:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									ActionError = false;
									break;
							}
							break;

						case NexoNextAction.sendReply:
							//case NexoNextAction.sendReplyWithError:
							switch (value)
							{
								case NexoNextAction.sendReply:
								//case NexoNextAction.sendReplyWithError:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									ActionError = false;
									break;
							}
							break;

						case NexoNextAction.sendRequest:
						case NexoNextAction.sendNotification:
							switch (value)
							{
								case NexoNextAction.final:
								case NexoNextAction.sendRequest:
								case NexoNextAction.sendNotification:
									_action = value;
									ActionError = false;
									break;
							}
							break;
					}
			}
		}
		private NexoNextAction _action = NexoNextAction.nothing;
		/// <summary>
		/// Fllag indicating whether the message must be sent to the calling app for further processing
		/// </summary>
		internal bool PassToApp = true;
		/// <summary>
		/// Indicates if an error has occured somewhere
		/// </summary>
		public bool ActionError { get; private set; } = false;
		///// <summary>
		///// The object which will contain the reponse returned to the caller
		///// That object will be used to set the reply message response data, overwriting it
		///// </summary>
		//public NexoResponseType Response { get; private set; }
		#endregion

		#region methods
		public override string ToString() => $"{Item}; CanModifyAction={CanModifyAction}; SuggestedAction={SuggestedAction}; Action={Action}";
		#endregion
	}

	[ComVisible(false)]
	public class QueueOfNexoObjectToProcess : Queue<NexoObjectToProcess> { }

	[ComVisible(false)]
	public class StackOfNexoObjectToProcess : Stack<NexoObjectToProcess> { }
}
