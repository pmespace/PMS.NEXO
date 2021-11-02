using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
	}

	public class CListenerReply
	{
		public ReplyStatus Status { get; set; }
		public string Label { get; set; }
		public string Message { get; set; }
		public string NexoError { get; set; }
		public string NexoInformation { get; set; }
		public CListenerRequest Request { get; set; }
	}
}
