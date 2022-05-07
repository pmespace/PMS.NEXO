using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NEXO;

namespace NexoListener
{
	public enum ReplyStatus
	{
		Success,
		Failure,
		Partial,
		noError,
		serviceNotSupported,
		mandatoryObjectNotSet,
		invalidRequest,
		invalidService,
		invalidPOIID,
		invalidSaleID,
		invalidValue,
		failedToConnectToPOI,
		exchangeError,
		timeout,
		cancelled,
		unknownError,

		asynchronousMessage = 100,
		waitingToGainAccessToPOI,
		accessToPOIHasBeenGranted,

		login = 500,
		logout,
		beginPayment,
		endPayment,
		beginOtherPayment,
		endOtherPayment,
		beginRefund,
		endRefund,
		beginReversal,
		endReversal,
		beginReconciliation,
		endReconciliation,
		beginAbort,
		endAbort,
		beginOtherService = 600,
		endOtherService,
	}

	public class CListenerReply
	{
		public bool Notification { get; set; } = false;
		public ReplyStatus Status { get; set; }
		public string Label { get; set; }
		public string Message { get; set; }
		public string NexoError { get; set; }
		public string NexoInformation { get; set; }
		public double Amount { get; set; }
		public TransactionIdentificationType POITransaction { get; set; }
		public CListenerRequest Request { get; set; }
		public override string ToString()
		{
			return Message;
		}
	}
}
