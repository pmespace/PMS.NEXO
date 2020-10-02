using System;
using System.Net;
using System.Net.Sockets;
using COMMON;
using NEXO;

namespace NEXO
{
	public class NexoMessage: NexoKey
	{
		#region constructor
		public NexoMessage(SaleToPOIRequest request, string xml, bool incoming)
		{
			Reply = null;
			Request = request;
			Initialise(xml, incoming);
		}
		public NexoMessage(SaleToPOIResponse response, string xml, bool incoming)
		{
			Request = null;
			Reply = response;
			Initialise(xml, incoming);
		}
		private void Initialise(string xml, bool incoming)
		{
			Timestamp = DateTime.Now;
			Incoming = incoming;
			XML = xml;
			Key = GetKey(this);
			Description = GetDescription();
		}
		#endregion

		#region properties
		/// <summary>
		/// Indicates whether this is a request or not
		/// </summary>
		public bool IsRequest { get => null != Request; }
		/// <summary>
		/// indicates whether incoming (from a sale) or outgoing (to a sale) request
		/// </summary>
		public bool Incoming { get; private set; }
		/// <summary>
		/// Insertion timestamp
		/// </summary>
		public DateTime Timestamp { get; private set; }
		/// <summary>
		/// Request message
		/// </summary>
		public SaleToPOIRequest Request { get; }
		public SaleToPOIResponse Reply { get; }
		public string XML { get; private set; }
		#endregion

		#region methods
		public static string GetKey(NexoMessage o)
		{
			MessageHeaderType mh = o.IsRequest ? o.Request.MessageHeader : o.Reply.MessageHeader;
			const string SEP = ".";
			return CMisc.Trimmed(mh.MessageClass)
				+ SEP + CMisc.Trimmed(mh.MessageCategory)
				+ SEP + CMisc.Trimmed(mh.SaleID)
				+ SEP + CMisc.Trimmed(mh.POIID)
				+ SEP + CMisc.Trimmed(mh.ServiceID)
				+ SEP + CMisc.Trimmed(mh.DeviceID);
		}
		public static string GetDescription()
		{
			return "Message";
		}
		public override string ToString(bool addkey)
		{
			return ToString(addkey, Timestamp.ToString(Chars.DATETIMEEX) + SEP + (IsRequest ? "Request: " : "Response: ") + XML);
		}
		#endregion
	}

	public class NexoDictionaryOfMessages: NexoDictionaryOfObjects<NexoMessage>
	{
		public NexoDictionaryOfMessages() : base("EXCHANGED MESSAGES") { }
	}
}
