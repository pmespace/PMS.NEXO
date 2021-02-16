Public Class FConnected

	Public Property Warn As CheckBox

	Private Sub Connected_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		e.Cancel = True
		Me.Visible = False
		Warn.Checked = False
	End Sub

End Class