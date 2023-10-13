Imports System.Text
Imports NEXO
Imports COMMON
Imports Newtonsoft.Json
Imports System.Xml

Public Class FChooser
	Public Data As String = Nothing
	Public UseJson As Boolean = False
	Private IsReady As Boolean = False

	Private Sub FChoser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If NEXO30 Then
		rbTransactionReport.Visible = False
#End If
		efNotation.Text = Data
		cbUseJson.Checked = UseJson
		rbPayment.Checked = True

		CLog.Filename = "nexo.builder.log"

		ToolTip1.SetToolTip(efCoded, "Enter a string compatible with storage inside a Json file" & vbCrLf & "All special characters must be escaped (ex: "" must be coded \"" ")
		ToolTip1.SetToolTip(efTarget, "This is a string whose format is compliant with storage inside a Json file" & vbCrLf & "You can copy and paste it inside a Json file")

		IsReady = True
		SetButtons()
	End Sub

	Private Sub pbCreate_Click(sender As Object, e As EventArgs) Handles pbCreate.Click
		StartBuilder(Nothing)
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		Data = efNotation.Text
		UseJson = cbUseJson.Checked
		Close()
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
#If NEXO31 Then
			ElseIf rbTransactionReport.Checked Then
				nxo = New NexoTransactionReport
#End If
			End If
		End If

		'Visible = False
		'call the builder window
		Dim f As New FBuilder With {.O = nxo, .MakeRequest = cbRequest.Checked}
		Select Case f.ShowDialog()
			Case DialogResult.Yes
				dr = DialogResult.OK
				efNotation.Text = f.Target
				efTarget.Text = JsonConvert.SerializeObject(f.Target)
				efNotTheTarget.Text = JsonConvert.SerializeObject(f.NotTheTarget)
		End Select
		nxo = Nothing
		f.Dispose()
		'Visible = True
		Return dr
	End Function

	Private Function ReplaceChars(orig As String, toreplace As String, replacedby As String)
		If orig.Contains(toreplace) Then
			orig = orig.Replace(toreplace, replacedby)
		End If
		Return orig
	End Function

	Private Sub efXML_TextChanged(sender As Object, e As EventArgs) Handles efNotation.TextChanged
		If IsReady Then
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
			Dim s As String = efNotation.Text
			Dim pos As Integer = efNotation.SelectionStart
			s = ReplaceChars(s, "\""", """")
			s = ReplaceChars(s, Chars.CR, "")
			s = ReplaceChars(s, Chars.LF, "")
			s = ReplaceChars(s, Chars.TAB, "")
			efNotation.Text = s
			Try
				efNotation.SelectionStart = pos
			Catch ex As Exception
				efNotation.SelectionStart = 0
			End Try
			SetButtons()
		End If
	End Sub

	Private Sub SetButtons()
		UseJson = cbUseJson.Checked
		NexoRetailer.UseJson = UseJson

		Dim sz1 As String, sz2 As String
		If cbUseJson.Checked Then
			sz1 = "JSON"
			sz2 = "XML"
		Else
			sz1 = "XML"
			sz2 = "JSON"
		End If
		lblNotation.Text = sz1
		lblTargetNotation.Text = "Coded " & sz1
		lblInverseNotation.Text = "Coded " & sz2
		ToolTip1.SetToolTip(efNotation, "Enter a plain and valid " & sz1 & " text to analyze")

		pbAnalyse.Enabled = Not String.IsNullOrEmpty(efNotation.Text)
		pbAnalyseJson.Enabled = Not String.IsNullOrEmpty(efCoded.Text)
	End Sub

	Private Sub pbCopy_Click(sender As Object, e As EventArgs) Handles pbCopy1.Click
		Clipboard.SetText(efTarget.Text)
	End Sub

	Private Sub pbAnalyse_Click(sender As Object, e As EventArgs) Handles pbAnalyse.Click
		Try
			Dim nxo As NexoObject = Nothing
			Dim item As NexoItem = Nothing
			'efNotation.Text = efNotation.Text.Replace("""", "")
			efNotation.Text = Trim(efNotation.Text)
			CLog.TRACE($"Processing: {efNotation.Text}")
			If Not String.IsNullOrEmpty(efNotation.Text) Then
				item = New NexoItem(efNotation.Text)
				If item.IsValid Then
					nxo = NexoItem.ToNexoObject(item)
					If Not IsNothing(nxo) Then
						cbRequest.Checked = item.IsRequest
						StartBuilder(nxo)
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("An error has occurred")
			CLog.EXCEPT(ex)
		End Try
	End Sub

	Private Sub pbAnalyseJson_Click(sender As Object, e As EventArgs) Handles pbAnalyseJson.Click
		Try
			Dim nxo As NexoObject = Nothing
			Dim item As NexoItem = Nothing
			efCoded.Text = Trim(efCoded.Text)
			If Not String.IsNullOrEmpty(efCoded.Text) Then
				If Not efCoded.Text.StartsWith("""") Then efCoded.Text = """" & efCoded.Text
				If Not efCoded.Text.EndsWith("""") Then efCoded.Text = efCoded.Text & """"
				CLog.TRACE($"Processing: {efCoded.Text}")
				'from json to xml
				Dim sz As String = String.Empty
				Try
					sz = JsonConvert.DeserializeObject(Of String)(efCoded.Text)
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
		Catch ex As Exception
			MsgBox("An error has occurred")
			CLog.EXCEPT(ex)
		End Try
	End Sub

	Private Sub efJSON_TextChanged(sender As Object, e As EventArgs) Handles efCoded.TextChanged
		If IsReady Then
			SetButtons()
		End If
	End Sub

	Private Sub cbUseJson_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseJson.CheckedChanged
		If IsReady Then
			Dim sz As String = efTarget.Text
			efTarget.Text = efNotTheTarget.Text
			efNotTheTarget.Text = sz
			efNotation.Text = Nothing
			efCoded.Text = Nothing
			SetButtons()
		End If
	End Sub

	Private Sub pbCopy2_Click(sender As Object, e As EventArgs) Handles pbCopy2.Click
		Clipboard.SetText(efNotTheTarget.Text)
	End Sub

	Private Sub TranslateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TranslateToolStripMenuItem.Click
		efTarget.Text = JsonConvert.SerializeObject(efNotation.Text)
	End Sub

	Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
		TranslateToolStripMenuItem.Enabled = Not String.IsNullOrEmpty(efNotation.Text)
	End Sub
End Class