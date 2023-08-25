using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using COMMON;

namespace NEXO
{
	/// <summary>
	/// This allows containing messages that can be received and will processed after an initial request has been sent
	/// Once a request has been sent to a server replies (either responses or requests) not contained inside such object shall be ignored
	/// </summary>
	public class NexoAcceptedCommands : Dictionary<MessageCategoryEnumeration, MessageTypeEnumeration> { }

	[Guid("B7773C1A-8091-4B2A-A54E-74E686E5F91E")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoItem
	{
		#region INexoItem
		[DispId(1)]
		object Item { get; }
		[DispId(2)]
		string XML { get; }
		[DispId(3)]
		bool IsRequest { get; }
		[DispId(4)]
		bool IsReply { get; }
		[DispId(5)]
		bool IsNotification { get; }
		[DispId(6)]
		MessageTypeEnumeration Type { get; }
		[DispId(7)]
		MessageCategoryEnumeration Category { get; }
		[DispId(8)]
		MessageClassEnumeration Class { get; }
		[DispId(9)]
		bool IsService { get; }
		[DispId(10)]
		bool IsDevice { get; }
		[DispId(11)]
		bool IsEvent { get; }
		[DispId(12)]
		bool IsValid { get; }
		[DispId(13)]
		bool IsRequestValidForServer { get; }
		[DispId(14)]
		bool IsRequestValidForClient { get; }
		[DispId(15)]
		bool ReplyRequired { get; }
		[DispId(16)]
		bool SupportsAbort { get; }

		[DispId(100)]
		string ToString();
		[DispId(101)]
		bool MatchesRequest(NexoItem item);
		#endregion
	}
	[Guid("390237C2-5337-4EBE-8B1E-E395611FEC82")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoItem : NexoRetailer, INexoItem
	{
		#region constructor
		/// <summary>
		/// Create an item from a request
		/// </summary>
		/// <param name="msg"></param>
		public NexoItem(SaleToPOIRequest msg)
		{
			if (null != msg
				&& null != msg.MessageHeader
				&& null != msg.Item
				&& IdentifyNexoObject(msg.MessageHeader))
			{
				Request = msg;
				XML = Serialize(Request);
				SaleToPOI = AllocateObject(Category);
			}
		}
		/// <summary>
		/// Create an item from a reply
		/// </summary>
		/// <param name="msg"></param>
		public NexoItem(SaleToPOIResponse msg)
		{
			if (null != msg
				&& null != msg.MessageHeader
				&& null != msg.Item
				&& IdentifyNexoObject(msg.MessageHeader))
			{
				Reply = msg;
				XML = Serialize(Reply);
				SaleToPOI = AllocateObject(Category);
			}
		}
		/// <summary>
		/// Create an item from an existing XML message
		/// </summary>
		public NexoItem(string xml)
		{
			// try deserializing the mesage to a request
			//SaleToPOIRequest request = Deserialize<SaleToPOIRequest>(xml);
			SaleToPOIRequest request = DeserializeRequest(xml);
			if (ValidMsg(request)
				&& IdentifyNexoObject(request.MessageHeader))
			{
				Request = request;
				XML = xml;
				SaleToPOI = AllocateObject(Category);
			}
			else
			{
				// try deserializing the mesage to a response
				//SaleToPOIResponse reply = Deserialize<SaleToPOIResponse>(xml);
				SaleToPOIResponse reply = DeserializeResponse(xml);
				if (ValidMsg(reply)
					&& IdentifyNexoObject(reply.MessageHeader))
				//&& IdentifyNexoObject((MessageCategoryEnumeration)Enum.Parse(typeof(MessageCategoryEnumeration), reply.MessageHeader.MessageCategory)))
				{
					Reply = reply;
					XML = xml;
					SaleToPOI = AllocateObject(Category);
				}
			}
		}
		private bool ValidMsg(SaleToPOIRequest msg)
		{
			return null != msg
				&& null != msg.MessageHeader
				&& null != msg.Item;
		}
		private bool ValidMsg(SaleToPOIResponse msg)
		{
			return null != msg
				&& null != msg.MessageHeader
				&& null != msg.Item;
		}
		#endregion

		#region properties
		/// <summary>
		/// Request and Response (Reply) to manipulate
		/// </summary>
		//public object Item { get => (IsRequest ? (object)SaleToPOI.Request : (IsReply ? (object)SaleToPOI.Reply : null)); }
		private NexoObject SaleToPOI { get; set; } = null;
		public object Item { get => (IsRequest ? (object)Request : (IsReply ? (object)Reply : null)); }
		private SaleToPOIRequest Request = null;
		private SaleToPOIResponse Reply = null;
		public string XML { get; } = null;
		/// <summary>
		/// Indicates the type of teh item
		/// </summary>
		public bool IsRequest { get => null != Request; }
		public bool IsReply { get => null != Reply; }
		public bool IsNotification { get => IsRequest && MessageCategoryEnumeration.Event == Category; }
		public MessageTypeEnumeration Type { get => (IsNotification ? MessageTypeEnumeration.Notification : (IsRequest ? MessageTypeEnumeration.Request : (IsReply ? MessageTypeEnumeration.Response : (MessageTypeEnumeration)CMisc.UNKNOWN))); }
		/// <summary>
		/// category of the message
		/// </summary>
		public MessageCategoryEnumeration Category { get; private set; }
		/// <summary>
		/// class of the message
		/// </summary>
		public MessageClassEnumeration Class { get; private set; }
		/// <summary>
		/// Indicates the class of the message
		/// </summary>
		public bool IsService { get => MessageClassEnumeration.Service == Class; }
		public bool IsDevice { get => MessageClassEnumeration.Device == Class; }
		public bool IsEvent { get => MessageClassEnumeration.Event == Class; }
		/// <summary>
		/// indicates whether the message is managed or not
		/// an unmanaged message shall be ignored
		/// </summary>
		public bool IsValid { get => (IsRequest || IsReply) && (MessageCategoryEnumeration)CMisc.UNKNOWN != Category; }
		/// <summary>
		/// Indicates whether a request can be processed or not, depending on the type of the receiver
		/// </summary>
		public bool IsRequestValidForServer { get => true; }
		public bool IsRequestValidForClient { get => MessageClassEnumeration.Device == Class || MessageClassEnumeration.Event == Class; }
		/// <summary>
		/// Indicates whether a reply must be sent after having received this message
		/// </summary>
		public bool ReplyRequired { get; private set; } /* => IsValid && 0 != Answers.Count; } */
		/// <summary>
		/// Indicates whether an abort can be sent after the request
		/// </summary>
		public bool SupportsAbort { get; private set; }
		#endregion

		#region public methods
		public override string ToString()
		{
			return XML;
		}
		/// <summary>
		/// Verifies whether an item is the response of a request or not
		/// </summary>
		/// <param name="item">item to check against counterpart</param>
		/// <returns>true if response to a request, false otherwise</returns>
		public bool MatchesRequest(NexoItem item)
		{
			MessageHeaderType requestmh, replymh;
			if (IsRequest && item.IsReply)
			{
				requestmh = Request.MessageHeader;
				replymh = item.Reply.MessageHeader;
			}
			else if (IsReply && item.IsRequest)
			{
				requestmh = item.Request.MessageHeader;
				replymh = Reply.MessageHeader;
			}
			else
			{
				CLog.Add($"Messages do not match - Invalid message type", TLog.WARNG);
				return false;

			}
			bool f = requestmh.MessageCategory == replymh.MessageCategory
				&& requestmh.MessageClass == replymh.MessageClass
				&& requestmh.POIID == replymh.POIID
				&& requestmh.SaleID == replymh.SaleID
				&& requestmh.ServiceID == replymh.ServiceID
				&& requestmh.DeviceID == replymh.DeviceID;
			if (!f)
				CLog.Add("Messages do not match - " +
					 (requestmh.MessageCategory != replymh.MessageCategory ? "Category: " + requestmh.MessageCategory.ToString() + " <> " + replymh.MessageCategory.ToString() : null) +
					 (requestmh.MessageClass != replymh.MessageClass ? "Class: " + requestmh.MessageClass.ToString() + " <> " + replymh.MessageClass.ToString() : null) +
					 (requestmh.POIID != replymh.POIID ? "POIID: " + requestmh.POIID + " <> " + replymh.POIID : null) +
					 (requestmh.SaleID != replymh.SaleID ? "SaleID: " + requestmh.SaleID + " <> " + replymh.SaleID : null) +
					 (requestmh.ServiceID != replymh.ServiceID ? "ServiceID: " + requestmh.ServiceID + " <> " + replymh.ServiceID : null) +
					 (requestmh.DeviceID != replymh.DeviceID ? "DeviceID: " + requestmh.DeviceID + " <> " + replymh.DeviceID : null));
			return f;
		}
		#endregion

		#region private methods
		/// <summary>
		/// Create the nexo object as requested
		/// </summary>
		/// <param name="mh">Message headr of the message</param>
		private bool IdentifyNexoObject(MessageHeaderType mh)
		{
			SupportsAbort = false;
			ReplyRequired = true;

			//// by default every request accepts receiving a notification event in return
			//Answers = new NexoAcceptedCommands();

			Category = (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), mh.MessageCategory, CMisc.UNKNOWN);
			Class = (MessageClassEnumeration)CMisc.GetEnumValue(typeof(MessageClassEnumeration), mh.MessageClass, CMisc.UNKNOWN);
			MessageTypeEnumeration mtype = (MessageTypeEnumeration)CMisc.GetEnumValue(typeof(MessageTypeEnumeration), mh.MessageType, CMisc.UNKNOWN);

			//if ((MessageCategoryEnumeration)CMisc.UNKNOWN == Category
			//	|| (MessageClassEnumeration)CMisc.UNKNOWN == Class
			//	|| (MessageTypeEnumeration)CMisc.UNKNOWN == mtype)
			//	return false;

			// verify category
			switch (Category)
			{
				case MessageCategoryEnumeration.Abort:
					ReplyRequired = false;
					break;
				case MessageCategoryEnumeration.Admin:
					break;
				case MessageCategoryEnumeration.BalanceInquiry:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Batch:
					break;
				case MessageCategoryEnumeration.CardAcquisition:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.CardReaderAPDU:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.CardReaderInit:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.CardReaderPowerOff:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Diagnosis:
					break;
				case MessageCategoryEnumeration.Display:
					break;
				case MessageCategoryEnumeration.EnableService:
					break;
				case MessageCategoryEnumeration.Event:
					ReplyRequired = false;
					break;
				case MessageCategoryEnumeration.GetTotals:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Input:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.InputUpdate:
					ReplyRequired = false;
					break;
				case MessageCategoryEnumeration.Login:
					break;
				case MessageCategoryEnumeration.Logout:
					break;
				case MessageCategoryEnumeration.Loyalty:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Payment:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.PIN:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Print:
					break;
				case MessageCategoryEnumeration.Reconciliation:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Reversal:
					SupportsAbort = true;
					break;
				case MessageCategoryEnumeration.Sound:
					break;
				case MessageCategoryEnumeration.StoredValue:
					SupportsAbort = true;
					break;
#if RETAILER31
				case MessageCategoryEnumeration.TransactionReport:
					break;
#endif
				case MessageCategoryEnumeration.TransactionStatus:
					break;
				case MessageCategoryEnumeration.Transmit:
					break;

				default:
					Category = (MessageCategoryEnumeration)CMisc.UNKNOWN;
					break;
			}

			return ((MessageCategoryEnumeration)CMisc.UNKNOWN != Category
				&& (MessageClassEnumeration)CMisc.UNKNOWN != Class
				&& (MessageTypeEnumeration)CMisc.UNKNOWN != mtype);
		}
		#endregion

		#region static
		/// <summary>
		/// ALlocate a Nexo object
		/// </summary>
		/// <param name="category">The type of Nexo object to allocated</param>
		/// <returns>The created object, null if an error occurred</returns>
		public static NexoObject AllocateObject(MessageCategoryEnumeration category)
		{
			switch (category)
			{
				case MessageCategoryEnumeration.Abort:
					return new NexoAbort();
				case MessageCategoryEnumeration.Admin:
					return new NexoAdmin();
				case MessageCategoryEnumeration.BalanceInquiry:
					return new NexoBalanceInquiry();
				case MessageCategoryEnumeration.Batch:
					return new NexoBatch();
				case MessageCategoryEnumeration.CardAcquisition:
					return new NexoCardAcquisition();
				case MessageCategoryEnumeration.CardReaderAPDU:
					return new NexoCardReaderAPDU();
				case MessageCategoryEnumeration.CardReaderInit:
					return new NexoCardReaderInit();
				case MessageCategoryEnumeration.CardReaderPowerOff:
					return new NexoCardReaderPowerOFF();
				case MessageCategoryEnumeration.Diagnosis:
					return new NexoDiagnosis();
				case MessageCategoryEnumeration.Display:
					return new NexoDeviceDisplay();
				case MessageCategoryEnumeration.EnableService:
					return new NexoEnableService();
				case MessageCategoryEnumeration.Event:
					return new NexoEvent();
				case MessageCategoryEnumeration.GetTotals:
					return new NexoGetTotals();
				case MessageCategoryEnumeration.Input:
					return new NexoDeviceInput();
				case MessageCategoryEnumeration.InputUpdate:
					return new NexoDeviceInputUpdate();
				case MessageCategoryEnumeration.Login:
					return new NexoLogin();
				case MessageCategoryEnumeration.Logout:
					return new NexoLogout();
				case MessageCategoryEnumeration.Loyalty:
					return new NexoLoyalty();
				case MessageCategoryEnumeration.Payment:
					return new NexoPayment();
				case MessageCategoryEnumeration.PIN:
					return new NexoPIN();
				case MessageCategoryEnumeration.Print:
					return new NexoDevicePrint();
				case MessageCategoryEnumeration.Reconciliation:
					return new NexoReconciliation();
				case MessageCategoryEnumeration.Reversal:
					return new NexoReversal();
				case MessageCategoryEnumeration.Sound:
					return new NexoDeviceSound();
				case MessageCategoryEnumeration.StoredValue:
					return new NexoStoredValue();
#if RETAILER31
				case MessageCategoryEnumeration.TransactionReport:
					return new NexoTransactionReport();
#endif
				case MessageCategoryEnumeration.TransactionStatus:
					return new NexoTransactionStatus();
				case MessageCategoryEnumeration.Transmit:
					return new NexoTransmit();
			}
			return null;
		}
		/// <summary>
		/// Create a <see cref="NexoObject"/> from an item
		/// BEWARE not all fields are set as if using "new Nexo..."
		/// </summary>
		/// <param name="item">The <see cref="NexoItem"/> to use to create the <see cref="NexoObject"/></param>
		/// <returns>A <see cref="NexoObject"/> if successfull, null otherwise</returns>
		public static NexoObject ToNexoObject(NexoItem item)
		{
			if (null != item)
			{
				NexoObject o = AllocateObject(item.Category);
				if (null != o)
				{
					o.FromItem(item);
				}
				return o;
			}
			return null;
		}
		#endregion
	}
}
