Imports System.Windows.Forms
Imports System.Drawing
Imports COMMON

Public Class FSettings
	Public Settings As Settings
	Private modified As Boolean = False
	Private path As String = String.Empty
	Private Const DEFAULT_PORT As Integer = 2018
	Private Const SETTINGS_FILE_NAME As String = "nexocom.settings.json"

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles efPOIID.TextChanged, efSaleID.TextChanged, efServerIP.TextChanged
		modified = True
		If sender Is efServerIP Then
			SetServerColors(SystemColors.Window)
		ElseIf sender Is cbSaleIDUSeIP Then
			If DirectCast(sender, CheckBox).Checked Then
				efSaleID.Text = CStream.Localhost
			End If
		ElseIf sender Is cbPOIIDUseIP Then
			If DirectCast(sender, CheckBox).Checked Then
				efPOIID.Text = CStream.Localhost
			End If
		End If
	End Sub

	Private Sub cbSaleIDUSeIP_CheckedChanged(sender As Object, e As EventArgs) Handles cbSaleIDUSeIP.CheckedChanged, cbPOIIDUseIP.CheckedChanged
		modified = True
	End Sub

	Private Sub serverPort_ValueChanged(sender As Object, e As EventArgs) Handles udServerPort.ValueChanged
		modified = True
	End Sub

	Private Sub FParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadSettings()
		cbSynchronousTerminal.Enabled = False
		cbSynchronousTerminal.Checked = True
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
		efServerIP.BackColor = c
		udServerPort.BackColor = c
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

	Private Function SettingsFileName() As String
		Return path & SETTINGS_FILE_NAME
	End Function

	Private Sub SaveSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettingsFileName()
		Settings.POIID = efPOIID.Text
		Settings.POIIDUseIP = cbPOIIDUseIP.Checked
		Settings.SaleID = efSaleID.Text
		Settings.SaleIDUseIP = cbSaleIDUSeIP.Checked
		Settings.ServerIP = efServerIP.Text
		Settings.ServerPort = udServerPort.Value
		Settings.Synchronous = cbSynchronousTerminal.Checked
		Settings.ApplicationName = efApplicationName.Text
		Settings.ManufacturerName = efManufacturerName.Text
		Settings.SoftwareVersion = efSoftwareVersion.Text
		Settings.CertificationCode = efCertificationCode.Text
		Settings.Currency = cbxCurrency.SelectedItem.ToString
		Settings.Decimals = udDecimals.Value
		Settings.Autoclose = cbAutoclose.Checked
		Settings.AutocloseDelay = udAutocloseDelay.Value
		Settings.MaxTimer = udMaxTimer.Value
		json.WriteSettings(Settings, True)
		modified = False
	End Sub

	Private Sub LoadSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettingsFileName()
		Settings = json.ReadSettings()
		If Not IsNothing(Settings) Then
			efPOIID.Text = Settings.POIID
			cbPOIIDUseIP.Checked = Settings.POIIDUseIP
			efSaleID.Text = Settings.SaleID
			cbSaleIDUSeIP.Checked = Settings.SaleIDUseIP
			efServerIP.Text = Settings.ServerIP
			Try
				udServerPort.Value = Settings.ServerPort
			Catch ex As Exception
				udServerPort.Value = DEFAULT_PORT
			End Try
			cbSynchronousTerminal.Checked = Settings.Synchronous
			efApplicationName.Text = Settings.ApplicationName
			efManufacturerName.Text = Settings.ManufacturerName
			efSoftwareVersion.Text = Settings.SoftwareVersion
			efCertificationCode.Text = Settings.CertificationCode
			cbxCurrency.SelectedItem = Settings.Currency
			If IsNothing(cbxCurrency.SelectedItem) Then
				cbxCurrency.SelectedIndex = 0
			End If
			Try
				udDecimals.Value = Settings.Decimals
			Catch ex As Exception
				udDecimals.Value = 2
			End Try
			cbAutoclose.Checked = Settings.Autoclose
			Try
				udAutocloseDelay.Value = Settings.AutocloseDelay
			Catch ex As Exception
				udAutocloseDelay.Value = 2
			End Try
			Try
				udMaxTimer.Value = Settings.MaxTimer
			Catch ex As Exception
				udMaxTimer.Value = 5
			End Try
		Else
			Settings = New Settings
			SaveSettings()
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