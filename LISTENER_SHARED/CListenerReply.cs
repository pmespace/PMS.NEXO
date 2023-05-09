using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NEXO;

namespace Listener.Shared
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
		invalidPOIRequested,
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

		nexoDeviceDisplay = 10000,
		nexoNotification,
	}

	public enum ReceiptType
	{
		None,
		CashierReceipt,
		CustomerReceipt,
	}
	public class CReceipts : Dictionary<ReceiptType, List<string>> { }
	public class CPaymentData
	{
		/// <summary>
		/// Brand of the card involved in the transaction, if one was made and if available, null otherwise
		/// </summary>
		public string CardBrand { get => _cardbrand; set => _cardbrand = string.Empty == value ? null : value; }
		string _cardbrand = default;
		/// <summary>
		/// All available receipts received from the POI.
		/// A receipt is a list of strings.
		/// </summary>
		public CReceipts Receipts { get => _receipts; set => _receipts = default != value && 0 == value.Count ? default : value; }
		CReceipts _receipts = default;
	}

	public class CListenerReply
	{
		/// <summary>
		/// True if a notification message, false if a reply to a request
		/// </summary>
		public bool Notification { get; set; } = false;
		/// <summary>
		/// Error code of the message
		/// </summary>
		public ReplyStatus Status { get => _status; set { _status = value; Label = _status.ToString(); } }
		ReplyStatus _status = default;
		/// <summary>
		/// Error code description in clear text
		/// </summary>
		public string Label { get; set; }
		/// <summary>
		/// Message to send to the caller
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Nexo specific error (if a nexo message has been exchanged
		/// </summary>
		public string NexoError { get; set; }
		/// <summary>
		/// Nexo specific error information (if a nexo message has been exchanged
		/// </summary>
		public string NexoInformation { get; set; }
		/// <summary>
		/// Amount of the transaction (if an amount is involved)
		/// </summary>
		public double? Amount { get; set; }
		/// <summary>
		/// Transaction ID as returned by the nexo POI
		/// </summary>
		public TransactionIdentificationType POITransaction { get; set; }
		/// <summary>
		/// Brand of the card involved in the transaction, if one was made and if available, null otherwise
		/// </summary>
		public CPaymentData PaymentData { get => _paymentdata; set => _paymentdata = value; }
		CPaymentData _paymentdata = default;
		/// <summary>
		/// All available receipts received from the POI.
		/// A receipt is a list of strings.
		/// </summary>
		public CReceipts Receipts { get => _receipts; set => _receipts = (null == value || 0 == value.Count ? default : value); }
		CReceipts _receipts = default;
		/// <summary>
		/// The original request as received from the caller
		/// </summary>
		public CListenerRequest Request
		{ get; set; }
		/// <summary>
		/// The original request as a string as received from the caller
		/// </summary>
		public string RequestAsString { get; set; }
		public override string ToString()
		{
			return Message;
		}
	}
}
