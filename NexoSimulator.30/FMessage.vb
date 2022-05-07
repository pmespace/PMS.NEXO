Public Class FMessage
	Public Message As String
	Public Duration As Integer

	Private Sub FMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblMessage.Text = Message
		Timer1.Interval = Duration * 1000
		Timer1.Start()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Timer1.Stop()
		Close()
	End Sub
End Class