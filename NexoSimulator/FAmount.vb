Imports NEXO

Public Class FAmount
	Public Amount As Long = 0

	Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sa As New NexoSimpleAmount
		amountincents.Mask = New String("9"c, sa.Mantis + sa.DecimalPlaces)
	End Sub

	Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
		Amount = Long.Parse(amountincents.Text)
		DialogResult = DialogResult.OK
	End Sub
End Class