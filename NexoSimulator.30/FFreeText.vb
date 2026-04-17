Public Class FFreeText
	Public Caption As String = Nothing
	Public Invite As String = Nothing
	Public Freetext As String = Nothing
	Private Sub FFreeText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Not IsNothing(Caption) Then Text = Caption
		If Not IsNothing(Invite) Then lblInvite.Text = Invite
		SetButtons()
	End Sub

	Sub SetButtons()
		pbAccept.Enabled = 0 <> efText.Text.Length
	End Sub

	Private Sub efText_TextChanged(sender As Object, e As EventArgs) Handles efText.TextChanged
		SetButtons()
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		Freetext = efText.Text
		DialogResult = DialogResult.OK
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		Freetext = Nothing
		DialogResult = DialogResult.Cancel
	End Sub
End Class