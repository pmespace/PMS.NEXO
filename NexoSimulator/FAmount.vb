Imports NEXO

Public Class FAmount
	Public Amount As Long = 0

	Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sa As New NexoSimpleAmount
		amountincents.Mask = New String("9"c, sa.Mantis + sa.DecimalPlaces)
	End Sub

	Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
		Dim l As Long = 0
		Try
			l = Long.Parse(amountincents.Text)
		Catch ex As Exception
		End Try
		If 0 <> l Then
			Amount = Long.Parse(amountincents.Text)
			DialogResult = DialogResult.OK
		End If
	End Sub
End Class