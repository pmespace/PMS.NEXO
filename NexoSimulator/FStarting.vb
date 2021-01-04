Public Class FStarting
	Private Const lbl As String = "Please wait while simulator is starting"
	Private ticks As Integer = 0

	Private Sub FStarting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label1.Text = lbl
		Timer1.Interval = 500
		Timer1.Start()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label1.Text = lbl + New String(".", ticks)
		ticks += 1
		If ticks > 3 Then ticks = 0
	End Sub

End Class