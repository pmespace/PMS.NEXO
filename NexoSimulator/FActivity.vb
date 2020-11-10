Imports COMMON
Imports NEXO.Server
Imports NEXO

Public Class FActivity
	Private server As NexoRetailerServer
	Public Sub New(s As NexoRetailerServer)
		InitializeComponent()
		server = s
	End Sub

	Private Sub FActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbReceivedMessages.Checked = True
		UpdateView()
	End Sub

	Private Sub UpdateView()
		If rbReceivedMessages.Checked Then
			efActivity.Text = server.Activity.ReceivedMessages.ToString
		ElseIf rbSentMessages.Checked Then
			efActivity.Text = server.Activity.SentMessages.ToString
		ElseIf rbConnections.Checked Then
			efActivity.Text = server.Activity.EndPoints.ToString
		ElseIf rbConnected.Checked Then
			efActivity.Text = server.Activity.Clients.ToString
		End If
	End Sub

	Private Sub rbCommands_Click(sender As Object, e As EventArgs) Handles rbConnections.Click, rbConnected.Click, rbReceivedMessages.Click
		UpdateView()
	End Sub

End Class