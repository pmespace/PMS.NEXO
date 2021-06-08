Imports System.Text
Imports NEXO
Imports COMMON
Imports Newtonsoft.Json
Imports System.Xml

Public Class FChooser
	Public XML As String = Nothing

	Private Sub FChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If NEXO30 Then
		rbTransactionReport.Visible = False
#End If
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
		efXML.Text = Trim(efXML.Text)
		If Not String.IsNullOrEmpty(efXML.Text) Then
			item = New NexoItem(efXML.Text)
			If item.IsValid Then
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
				nxo = New NexoFinancial
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
#If NEXO31 Then
			ElseIf rbTransactionReport.Checked Then
				nxo = New NexoTransactionReport
#End If
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
				efXML.Text = Clipboard.GetText
				efXMLJson.Text = JsonConvert.SerializeObject(Clipboard.GetText)
		End Select
		nxo = Nothing
		Visible = True
		Return dr
	End Function

	Private Function ReplaceChars(orig As String, toreplace As String, replacedby As String)
		If orig.Contains(toreplace) Then
			orig = orig.Replace(toreplace, replacedby)
		End If
		Return orig
	End Function

	Private Sub efXML_TextChanged(sender As Object, e As EventArgs) Handles efXML.TextChanged
		'Dim s = efXML.Text
		'If s.Contains("\""") Then
		'	Dim pos As Integer = efXML.SelectionStart
		'	s = s.Replace("\""", """")
		'	efXML.Text = s
		'	Try
		'		efXML.SelectionStart = pos - 1
		'	Catch ex As Exception
		'		efXML.SelectionStart = 0
		'	End Try
		Dim s As String = efXML.Text
		Dim pos As Integer = efXML.SelectionStart
		s = ReplaceChars(s, "\""", """")
		s = ReplaceChars(s, Chars.CR, "")
		s = ReplaceChars(s, Chars.LF, "")
		s = ReplaceChars(s, Chars.TAB, "")
		efXML.Text = s
		Try
			efXML.SelectionStart = pos - 1
		Catch ex As Exception
			efXML.SelectionStart = 0
		End Try
		SetButtons()
	End Sub

	Private Sub SetButtons()
		pbAnalyse.Enabled = Not String.IsNullOrEmpty(efXML.Text)
		pbAnalyseJson.Enabled = Not String.IsNullOrEmpty(efJSON.Text)
	End Sub

	Private Sub pbCopy_Click(sender As Object, e As EventArgs) Handles pbCopy.Click
		Clipboard.SetText(efXMLJson.Text)
	End Sub

	Private Sub pbAnalyseJson_Click(sender As Object, e As EventArgs) Handles pbAnalyseJson.Click
		Dim nxo As NexoObject = Nothing
		Dim item As NexoItem = Nothing
		efJSON.Text = Trim(efJSON.Text)
		If Not String.IsNullOrEmpty(efJSON.Text) Then
			If Not efJSON.Text.StartsWith("""") Then efJSON.Text = """" & efJSON.Text
			If Not efJSON.Text.EndsWith("""") Then efJSON.Text = efJSON.Text & """"
			'from json to xml
			Dim sz As String = String.Empty
			Try
				sz = JsonConvert.DeserializeObject(Of String)(efJSON.Text)
			Catch ex As Exception
			End Try
			item = New NexoItem(sz)
			If item.IsValid Then
				nxo = NexoItem.ToNexoObject(item)
				If Not IsNothing(nxo) Then
					cbRequest.Checked = item.IsRequest
					StartBuilder(nxo)
				End If
			End If
		End If
	End Sub

	Private Sub efJSON_TextChanged(sender As Object, e As EventArgs) Handles efJSON.TextChanged
		SetButtons()
	End Sub
End Class