Imports NEXO

Public Class FChoser
	Public nxo As Type = Nothing

	Private Sub pbCreate_Click(sender As Object, e As EventArgs) Handles pbCreate.Click
		If rbAbort.Checked Then
			nxo = GetType(AbortRequestType)
		ElseIf rbAdmin.Checked Then
			nxo = GetType(AdminRequestType)
		ElseIf rbBalanceInquiry.Checked Then
			nxo = GetType(BalanceInquiryRequestType)
		ElseIf rbBatch.Checked Then
			nxo = GetType(BatchRequestType)
		ElseIf rbCardAcquisition.Checked Then
			nxo = GetType(CardAcquisitionRequestType)
		ElseIf rbCardReaderAPDU.Checked Then
			nxo = GetType(CardReaderAPDURequestType)
		ElseIf rbCardReaderInit.Checked Then
			nxo = GetType(CardReaderInitRequestType)
		ElseIf rbCardReaderPowerOff.Checked Then
			nxo = GetType(CardReaderPowerOffRequestType)
		ElseIf rbDiagnosis.Checked Then
			nxo = GetType(DiagnosisRequestType)
		ElseIf rbDisplay.Checked Then
			nxo = GetType(DisplayRequestType)
		ElseIf rbEnableService.Checked Then
			nxo = GetType(EnableServiceRequestType)
		ElseIf rbEvent.Checked Then
			nxo = GetType(EventNotificationType)
		ElseIf rbGetTotals.Checked Then
			nxo = GetType(GetTotalsRequestType)
		ElseIf rbInput.Checked Then
			nxo = GetType(InputRequestType)
		ElseIf rbLogin.Checked Then
			nxo = GetType(LoginRequestType)
		ElseIf rbLogout.Checked Then
			nxo = GetType(LogoutRequestType)
		ElseIf rbLoyalty.Checked Then
			nxo = GetType(LoyaltyRequestType)
		ElseIf rbPayment.Checked Then
			nxo = GetType(PaymentRequestType)
		ElseIf rbPIN.Checked Then
			nxo = GetType(PINRequestType)
		ElseIf rbPrint.Checked Then
			nxo = GetType(PrintRequestType)
		ElseIf rbReconciliation.Checked Then
			nxo = GetType(ReconciliationRequestType)
		ElseIf rbReversal.Checked Then
			nxo = GetType(ReversalRequestType)
		ElseIf rbSound.Checked Then
			nxo = GetType(SoundRequestType)
		ElseIf rbStoredValue.Checked Then
			nxo = GetType(StoredValueRequestType)
		ElseIf rbTransactionStatus.Checked Then
			nxo = GetType(TransactionStatusRequestType)
		ElseIf rbTransmit.Checked Then
			nxo = GetType(TransmitRequestType)
		End If
		DialogResult = DialogResult.OK
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		DialogResult = DialogResult.Cancel
	End Sub

	Private Sub FChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbPayment.Checked = True
	End Sub
End Class