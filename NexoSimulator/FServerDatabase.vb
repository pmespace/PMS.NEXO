Imports System.Data.OleDb
Imports COMMON
Public Class FServerDatabase
	Public AllowUpdate As Boolean = False
	Public TableName As String
	Public DbM As New CDatabaseTableManager

	Private dataTable As New DataTable
	Private dataAdapter As OleDbDataAdapter = Nothing
	Private commandBuilder As OleDbCommandBuilder = Nothing


	Private Sub FServerDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If AllowUpdate Then
			DataGridView1.ReadOnly = False
			DataGridView1.AllowUserToAddRows = True
			DataGridView1.AllowUserToDeleteRows = True
		End If
		RefreshData()
	End Sub

	Private Sub RefreshData()
		DataGridView1.Columns.Clear()
		DataGridView1.AutoGenerateColumns = True
		dataTable = DbM.FillTable($"SELECT * FROM {TableName}")
		DataGridView1.DataSource = dataTable
	End Sub

	Private Sub UpdateData()
		Try
			'dataAdapter.Update(dataTable)
			DbM.UpdateData(dataTable)
		Catch ex As Exception
			RefreshData()
		End Try
	End Sub

	Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
		DataGridView1.EndEdit()
		UpdateData()
	End Sub

	Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
		Close()
	End Sub

End Class