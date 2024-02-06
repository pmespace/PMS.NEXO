//#define REGEXPATHS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NEXO;
using COMMON;
using System.Net;

namespace Listener.Shared
{
	//public enum EServerType
	//{
	//	socket,
	//	WebSocket,
	//	http,
	//}

	public class CListenerRequestNexo
	{
		/// <summary>
		/// Nexo transaction ID set by the POI
		/// </summary>
		public TransactionIdentificationType POITransaction { get; set; }
		/// <summary>
		/// The message actually sent to the POI to trigger the service
		/// </summary>
		public string NexoMessage { get; internal set; }
	}

	public class CListenerRequest
	{
		public CListenerRequest() { }
		public CListenerRequest(CListenerRequest request) => Clone(request);
		void Clone(CListenerRequest request)
		{
			POI = request.POI;
			Service = request.Service;
			SaleID = request.SaleID;
			POIID = request.POIID;
			PaymentType = request.PaymentType;
			Amount = request.Amount;
			Currency = request.Currency;
			ReceiveTimeout = request.ReceiveTimeout;
			References = new List<string>(request.References);
			ElementsToSend = new CListenerDataElements(request.ElementsToSend);
			ElementsToReturn = new CListenerDataElements(request.ElementsToReturn);
			POITransaction = request.POITransaction;
		}
		/// <summary>
		/// POI to use to perform the service
		/// </summary>
		public string POI { get; set; }
		/// <summary>
		/// Service to activate
		/// </summary>
		public string Service { get; set; }
		/// <summary>
		/// Sale identification
		/// </summary>
		public string SaleID { get; set; }
		/// <summary>
		/// POI identification
		/// </summary>
		public string POIID { get; set; }
		/// <summary>
		/// Type of payment
		/// Useful only if <see cref="Service"/> is "Payment"
		/// </summary>
		public string PaymentType { get; set; }
		/// <summary>
		/// Transaction amount
		/// </summary>
		public double Amount { get; set; }
		/// <summary>
		/// Transaction currency
		/// </summary>
		public string Currency { get; set; } = "EUR";
		/// <summary>
		/// Timeout to use by the listener waiting for the service to complete
		/// </summary>
		public int ReceiveTimeout { get; set; } = 0;
		/// <summary>
		/// A list of references set by the caller
		/// These references will be carried out all along the process
		/// </summary>
		public List<string> References { get; set; }
		/// <summary>
		/// Elements to send to the POI to perform the service
		/// </summary>
		public CListenerDataElements ElementsToSend { get; set; } = new CListenerDataElements();
		/// <summary>
		/// Elements to receive from the POI, set by the service
		/// </summary>
		public CListenerDataElements ElementsToReturn { get; set; } = new CListenerDataElements();

		public TransactionIdentificationType POITransaction { get; set; }
		public string NexoMessage { get; set; }

		///// <summary>
		///// The nexo specific data to use
		///// </summary>
		//public CListenerRequestNexo Nexo { get; set; }

		[JsonExtensionData]
		public Dictionary<string, JToken> ExtendedData;

		public override string ToString()
		{
			string s = string.Empty;
			List<string> ls = ToStringEx();
			for (int i = 0; i < ls.Count; i++)
			{
				s += ls[i] + (i != ls.Count - 1 ? Chars.CRLF : string.Empty);
			}
			return s;
		}
		public List<string> ToStringEx()
		{
			List<string> s = new List<string>();
			s.Add($"Service: {Service}; POI to reach: {POI}; SaleID: {SaleID}; POIID: {POIID}; Amount: {Amount}; Currency: {Currency}; Timeout: {ReceiveTimeout}; "); ;
			if (null != References)
				for (int i = 0; i < References.Count; i++)
					if (!References[i].IsNullOrEmpty())
						s.Add($"Reference{i}: {References[i]}; ");
			s.Add($"Elements to send: {ElementsToSend}");
			s.Add($"Elements to return: {ElementsToReturn}");
			return s;
		}
	}
	//internal class CListenerRequestEx : CListenerRequest
	//{
	//	[JsonRequired]
	//	public EServerType Server { get; set; }
	//}
}
