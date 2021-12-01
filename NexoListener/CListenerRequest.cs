using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NEXO;
using COMMON;

namespace NexoListener
{
	public struct CListenerDataElement
	{
		public object Value;
		public bool Status;
		public string Message;
	}
	public class CListenerDataElements : Dictionary<string, CListenerDataElement>
	{
		public CListenerDataElements() { }
		public CListenerDataElements(CListenerDataElements data) : base(data) { }
		public CListenerDataElements(Dictionary<string, CListenerDataElement> data) : base(data) { }
	}

	public class CListenerRequest
	{
		public string IP { get; set; }
		public int Port { get; set; }
		//public bool AutoLoginLogout { get; set; } = false;
		public string Service { get; set; }
		public string SaleID { get; set; }
		public string POIID { get; set; }
		public string PaymentType { get; set; }
		public double Amount { get; set; }
		public string Currency { get; set; } = "EUR";
		public TransactionIdentificationType POITransaction { get; set; }
		public CListenerDataElements ElementsToSend { get; set; } = new CListenerDataElements();
		public CListenerDataElements ElementsToReturn { get; set; } = new CListenerDataElements();

		public override string ToString()
		{
			string s = null;
			s = $"Service: {Service}, SaleID: {SaleID}, POIID: {POIID}";//, Autologin: {AutoLoginLogout }";

			s += (0 != ElementsToSend.Count ? $"{Chars.CRLF}To send:" : null);
			foreach (KeyValuePair<string, CListenerDataElement> k in ElementsToSend)
				s += Chars.CRLF + $" - {k.Key}: {k.Value.Value}";

			s += (0 != ElementsToReturn.Count ? $"{Chars.CRLF}To return:" : null);
			foreach (KeyValuePair<string, CListenerDataElement> k in ElementsToReturn)
				s += Chars.CRLF + $" - {k.Key}";

			return s;
		}
	}
}
