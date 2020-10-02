Imports System.Drawing
Imports COMMON

Public Class FParameters
	Private modified As Boolean = False
	Private path As String = String.Empty
	Private Const DEFAULT_PORT As Integer = 2018
	Private Const SETTINGS_FILE_NAME As String = "nexocom.settings.json"

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles POIID.TextChanged, saleID.TextChanged, serverIP.TextChanged
		modified = True
		If sender Is serverIP Then
			SetServerColors(SystemColors.Window)
		End If
	End Sub

	Private Sub cbSaleIDUSeIP_CheckedChanged(sender As Object, e As EventArgs) Handles cbSaleIDUSeIP.CheckedChanged, cbPOIIDUseIP.CheckedChanged
		modified = True
	End Sub

	Private Sub serverPort_ValueChanged(sender As Object, e As EventArgs) Handles serverPort.ValueChanged
		modified = True
	End Sub

	Private Sub FParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadSettings()
		SetButtons()
	End Sub

	Private Sub SetButtons()
		pbSave.Enabled = modified
		pbSaveSettings.Enabled = pbSave.Enabled
	End Sub

	Private Sub pbTestConnection_Click(sender As Object, e As EventArgs) Handles pbTestConnection.Click
		If True Then
			SetServerColors(Color.Green)
		Else
			SetServerColors(Color.Red)
		End If
	End Sub

	Private Sub SetServerColors(c As Color)
		serverIP.BackColor = c
		serverPort.BackColor = c
	End Sub

	Private Sub FParameters_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
		If modified Then
			Select Case MsgBox("Some settings have been modified." & vbCrLf & "Do you want to save them ?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question)
				Case MsgBoxResult.Yes
					SaveSettings()
					e.Cancel = False
					DialogResult = MsgBoxResult.Ok
				Case MsgBoxResult.No
					e.Cancel = False
					DialogResult = MsgBoxResult.Cancel
				Case MsgBoxResult.Cancel
					e.Cancel = True
					DialogResult = MsgBoxResult.Ignore
			End Select
		Else
			DialogResult = MsgBoxResult.Ok
		End If
	End Sub

	Private Function SettigsFileName() As String
		Return path & SETTINGS_FILE_NAME
	End Function

	Private Sub SaveSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettigsFileName()
		Dim settings As New Settings
		settings.POIID = POIID.Text
		settings.POIIDUseIP = cbPOIIDUseIP.Checked
		settings.SaleID = saleID.Text
		settings.SaleIDUseIP = cbSaleIDUSeIP.Checked
		settings.ServerIP = serverIP.Text
		settings.ServerPort = serverPort.Value
		json.WriteSettings(settings)
		modified = False
	End Sub

	Private Sub LoadSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettigsFileName()
		Dim settings As Settings = json.ReadSettings()
		If Not IsNothing(settings) Then
			POIID.Text = settings.POIID
			cbPOIIDUseIP.Checked = settings.POIIDUseIP
			saleID.Text = settings.SaleID
			cbSaleIDUSeIP.Checked = settings.SaleIDUseIP
			serverIP.Text = settings.ServerIP
			Try
				serverPort.Value = settings.ServerPort
			Catch ex As Exception
				serverPort.Value = DEFAULT_PORT
			End Try
		End If
		modified = False
	End Sub

	Private Sub pbSaveSettings_Click(sender As Object, e As EventArgs) Handles pbSaveSettings.Click
		SaveSettings()
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		DialogResult = MsgBoxResult.Abort
		Close()
	End Sub

	Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
		SaveSettings()
		DialogResult = MsgBoxResult.Ok
		Close()
	End Sub
End Class