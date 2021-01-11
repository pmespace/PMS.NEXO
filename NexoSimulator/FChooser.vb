Imports NEXO

Public Class FChooser
	Public XML As String = Nothing

	Private Sub FChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		efXML.Text = XML
		rbPayment.Checked = True
		SetButtons()
	End Sub

	Private Sub pbCreate_Click(sender As Object, e As EventArgs) Handles pbCreate.Click
		StartBuilder(Nothing)
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		Close()
	End Sub

	Private Sub pbAnalyse_Click(sender As Object, e As EventArgs) Handles pbAnalyse.Click
		Dim nxo As NexoObject = Nothing
		Dim item As NexoItem = Nothing
		If Not String.IsNullOrEmpty(efXML.Text) Then
			'deserialize the XML string
			Dim o As Object = NexoRetailer.XmlDeserialize(Of SaleToPOIRequest)(efXML.Text)
			item = New NexoItem(efXML.Text)
			If Not IsNothing(item) Then
				nxo = NexoItem.ToNexoObject(item)
				If Not IsNothing(nxo) Then
					cbRequest.Checked = item.IsRequest
					StartBuilder(nxo)
				End If
			End If
		End If
	End Sub

	Private Function StartBuilder(nxo As NexoObject) As DialogResult
		Dim dr As DialogResult = DialogResult.None

		If IsNothing(nxo) Then
			If rbAbort.Checked Then
				nxo = New NexoAbort
			ElseIf rbAdmin.Checked Then
				nxo = New NexoAdmin
			ElseIf rbBalanceInquiry.Checked Then
				nxo = New NexoBalanceInquiry
			ElseIf rbBatch.Checked Then
				nxo = New NexoBatch
			ElseIf rbCardAcquisition.Checked Then
				nxo = New NexoCardAcquisition
			ElseIf rbCardReaderAPDU.Checked Then
				nxo = New NexoCardReaderAPDU
			ElseIf rbCardReaderInit.Checked Then
				nxo = New NexoCardReaderInit
			ElseIf rbCardReaderPowerOff.Checked Then
				nxo = New NexoCardReaderPowerOFF
			ElseIf rbDiagnosis.Checked Then
				nxo = New NexoDiagnosis
			ElseIf rbDisplay.Checked Then
				nxo = New NexoDeviceDisplay
			ElseIf rbEnableService.Checked Then
				nxo = New NexoEnableService
			ElseIf rbEvent.Checked Then
				nxo = New NexoEvent
			ElseIf rbGetTotals.Checked Then
				nxo = New NexoGetTotals
			ElseIf rbInput.Checked Then
				nxo = New NexoDeviceInput
			ElseIf rbLogin.Checked Then
				nxo = New NexoLogin
			ElseIf rbLogout.Checked Then
				nxo = New NexoLogout
			ElseIf rbLoyalty.Checked Then
				nxo = New NexoLoyalty
			ElseIf rbPayment.Checked Then
				nxo = New NexoPayment
			ElseIf rbPIN.Checked Then
				nxo = New NexoPIN
			ElseIf rbPrint.Checked Then
				nxo = New NexoDevicePrint
			ElseIf rbReconciliation.Checked Then
				nxo = New NexoReconciliation
			ElseIf rbReversal.Checked Then
				nxo = New NexoReversal
			ElseIf rbSound.Checked Then
				nxo = New NexoDeviceSound
			ElseIf rbStoredValue.Checked Then
				nxo = New NexoStoredValue
			ElseIf rbTransactionStatus.Checked Then
				nxo = New NexoTransactionStatus
			ElseIf rbTransmit.Checked Then
				nxo = New NexoTransmit
			End If
		End If

		Visible = False
		'call the builder window
		Dim f As New FBuilder
		f.O = nxo
		f.MakeRequest = cbRequest.Checked
		Select Case f.ShowDialog()
			Case DialogResult.Yes
				dr = DialogResult.OK
				Close()
				Return dr
		End Select
		nxo = Nothing
		Visible = True
		Return dr
	End Function

	Private Sub efXML_TextChanged(sender As Object, e As EventArgs) Handles efXML.TextChanged
		SetButtons()
	End Sub

	Private Sub SetButtons()
		pbAnalyse.Enabled = Not String.IsNullOrEmpty(efXML.Text)
	End Sub

End Class