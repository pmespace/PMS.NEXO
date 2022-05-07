Imports NEXO.Client
Imports System.Net.Security
Public Class FConnectionSettings
	Public Settings As SettingsConnectionSettings
	Private modified As Boolean = False

	Private Sub FPreConnectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		efRequest.Text = Settings.RequestString
		efServerName.Text = Settings.ServerName
		cbUseCertificate.Checked = Settings.UseCertificate
		Try
			udTimer.Value = Settings.ConnectionTimer
		Catch ex As Exception
			udTimer.Value = 0
		End Try
		cbRemoteCertificateNotAvailable.Checked = Settings.AllowedSslErrors And SslPolicyErrors.RemoteCertificateNotAvailable
		cbRemoteCertificateNameMismatch.Checked = Settings.AllowedSslErrors And SslPolicyErrors.RemoteCertificateNameMismatch
		cbRemoteCertificateChainErrors.Checked = Settings.AllowedSslErrors And SslPolicyErrors.RemoteCertificateChainErrors
		modified = False
		SetButtons()
	End Sub

	Private Sub HasBeenModified(sender As Object, e As EventArgs) Handles efServerName.TextChanged, efRequest.TextChanged, cbUseCertificate.CheckedChanged, udTimer.ValueChanged, cbRemoteCertificateNotAvailable.CheckedChanged, cbRemoteCertificateNameMismatch.CheckedChanged, cbRemoteCertificateChainErrors.CheckedChanged
		modified = True
		SetButtons()
	End Sub

	Private Sub SetButtons()
		pbAccept.Enabled = modified
		If modified Then
			pbCancel.Text = "Cancel"
		Else
			pbCancel.Text = "Close"
		End If
		efServerName.Enabled = cbUseCertificate.Checked
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		DialogResult = DialogResult.OK
		Settings.RequestString = efRequest.Text
		Settings.ServerName = efServerName.Text
		Settings.UseCertificate = cbUseCertificate.Checked
		Settings.ConnectionTimer = udTimer.Value
		Settings.AllowedSslErrors = SslPolicyErrors.None
		Settings.AllowedSslErrors = SslPolicyErrors.None Or (cbRemoteCertificateNotAvailable.Checked And SslPolicyErrors.RemoteCertificateNotAvailable) Or
			(cbRemoteCertificateNameMismatch.Checked And SslPolicyErrors.RemoteCertificateNameMismatch) Or (cbRemoteCertificateChainErrors.Checked And SslPolicyErrors.RemoteCertificateChainErrors)
		Close()
	End Sub
End Class