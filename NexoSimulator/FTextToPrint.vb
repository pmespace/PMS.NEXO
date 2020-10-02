Public Class FTextToPrint

	Public TextToPrint As String = String.Empty

	Private Sub SetLabels()
		nbchars.Text = RichTextBox1.TextLength.ToString
		position.Text = (RichTextBox1.SelectionStart + 1).ToString
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		TextToPrint = RichTextBox1.Text
	End Sub

	Private Sub FTextToPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SetLabels()
	End Sub

	Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
		SetLabels()
	End Sub

	Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
		SetLabels()
	End Sub

End Class