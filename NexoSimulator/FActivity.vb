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
		rbCommands.Checked = True
		UpdateView()
	End Sub

	Private Sub UpdateView()
		'If rbCommands.Checked Then
		'	efActivity.Text = server.Commands.ToString
		'ElseIf rbConnections.Checked Then
		'	efActivity.Text = server.Sessions.ToString
		'ElseIf rbConnected.Checked Then
		'	efActivity.Text = server.Connected.ToString
		'End If
	End Sub

	Private Sub rbCommands_Click(sender As Object, e As EventArgs) Handles rbConnections.Click, rbConnected.Click, rbCommands.Click
		UpdateView()
	End Sub
End Class