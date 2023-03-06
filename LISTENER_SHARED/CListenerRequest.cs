using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NEXO;
using COMMON;

namespace Listener.Shared
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
		public override string ToString()
		{
			string s = string.Empty;
			s += (0 == Count ? $"<none>" : string.Empty) + Chars.CRLF;
			foreach (KeyValuePair<string, CListenerDataElement> k in this)
				s += $" - {k.Key}{(null != k.Value.Value ? ": {k.Value.Value}" : string.Empty)}" + Chars.CRLF;
			return s;
		}
	}

	public class CListenerRequest
	{
		public string POI { get; set; }
		public string Service { get; set; }
		public string SaleID { get; set; }
		public string POIID { get; set; }
		public string PaymentType { get; set; }
		public double Amount { get; set; }
		public string Currency { get; set; } = "EUR";
		public int ReceiveTimeout { get; set; } = 0;
		public TransactionIdentificationType POITransaction { get; set; }
		public CListenerDataElements ElementsToSend { get; set; } = new CListenerDataElements();
		public CListenerDataElements ElementsToReturn { get; set; } = new CListenerDataElements();

		public override string ToString()
		{
			string s = null;
			s = $"Service: {Service}; POI to reach: {POI}; SaleID: {SaleID}; POIID: {POIID}; Currency: {Currency}; Timeout: {ReceiveTimeout}" + Chars.CRLF;
			s += $"Elements to send: {ElementsToSend}";
			s += $"Elements to return: {ElementsToReturn}";
			return s;
		}
	}
}
