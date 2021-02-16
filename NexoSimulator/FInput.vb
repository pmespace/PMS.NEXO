Public Class FInput

	Public Caption As String = "Please enter a value"
	Public Invite As String = $"{Caption}:"
	Public Input As String = Nothing

	Private Sub FInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Text = Caption
		lblInput.Text = Invite
		efInput.Text = Input
		efInput.SelectionStart = 0
		efInput.SelectionLength = efInput.Text.Length
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		SaveAndExit()
	End Sub

	Private Sub SaveAndExit()
		Input = efInput.Text
		DialogResult = DialogResult.OK
		Close()
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		If efInput.Text <> Input Then
			Select Case MsgBox("Existing without saving your input" & vbCrLf & "Do you wish to save your data before ?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question)
				Case MsgBoxResult.Yes
					SaveAndExit()
				Case MsgBoxResult.No
					DialogResult = DialogResult.Cancel
					Close()
				Case Else
			End Select
		End If
	End Sub

End Class