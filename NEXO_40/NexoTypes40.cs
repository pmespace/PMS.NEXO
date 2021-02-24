using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXO
{
	public class ResponseType : ResponseType9 { }

	public class MessageHeaderType : Header37 { }

	public abstract class SaleToPOIRequest { }
	public partial class SaleToPOIAdministrativeRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOIDeviceRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOIEventNotificationV01 : SaleToPOIRequest { }
	public partial class SaleToPOIMessageStatusRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOIReconciliationRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOIReportRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOIServiceRequestV01 : SaleToPOIRequest { }
	public partial class SaleToPOISessionManagementRequestV01 : SaleToPOIRequest { }

	public abstract class SaleToPOIResponse { }
	public partial class SaleToPOIAdministrativeResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOIDeviceResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOIMessageStatusResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOIReconciliationResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOIReportResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOIServiceResponseV01 : SaleToPOIResponse { }
	public partial class SaleToPOISessionManagementResponseV01 : SaleToPOIResponse { }

	public abstract class PaymentRequestType { }
	public abstract class PaymentResponseType { }
}
