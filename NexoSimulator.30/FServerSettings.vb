Imports COMMON
Imports COMMON.ODBC
Imports NEXO.Server
Public Class FServerSettings
	Public Settings As NexoRetailerServerDatabaseSettings = Nothing
	Private modified As Boolean = False
	Public db As New CDatabaseTableManager

	Private Sub FServerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadSettings()
		modified = False
		SetButtons()
	End Sub

	Private Sub LoadSettings()
		If IsNothing(Settings) Then
			Dim json As CJson(Of NexoRetailerServerDatabaseSettings) = New CJson(Of NexoRetailerServerDatabaseSettings)(FSimulator.ServerSettingsFileName)
			Settings = json.ReadSettings()
			If IsNothing(Settings) Then
				Settings = New NexoRetailerServerDatabaseSettings
				json.WriteSettings(Settings)
			End If
		End If

		efConnectionString.Text = Settings.ConnectionString
		efConnectionsTableName.Text = Settings.ConnectionsTableName
		efMessagesTableName.Text = Settings.MessagesTableName
		efEndPointsTableName.Text = Settings.EndPointsTableName
		efSalesTablesName.Text = Settings.SalesTableName
		cbFullSecured.Checked = Settings.Secured
		cbDeclineByDefault.Checked = Settings.DeclineByDefault
		Try
			udDelayBeforeAutoLogout.Value = Settings.DelayBeforeAutoLogout
		Catch ex As Exception
			udDelayBeforeAutoLogout.Maximum = NexoRetailerServerDatabaseSettings.DEFAULT_DELAY_BEFORE_AUTO_LOGOUT
			udDelayBeforeAutoLogout.Value = NexoRetailerServerDatabaseSettings.DEFAULT_DELAY_BEFORE_AUTO_LOGOUT
		End Try
	End Sub

	Private Sub SaveSettings()
		Settings.ConnectionString = efConnectionString.Text
		Settings.ConnectionsTableName = efConnectionsTableName.Text
		Settings.MessagesTableName = efMessagesTableName.Text
		Settings.EndPointsTableName = efEndPointsTableName.Text
		Settings.SalesTableName = efSalesTablesName.Text
		Settings.Secured = cbFullSecured.Checked
		Settings.DeclineByDefault = cbDeclineByDefault.Checked
		Settings.DelayBeforeAutoLogout = udDelayBeforeAutoLogout.Value

		Dim json As CJson(Of NexoRetailerServerDatabaseSettings) = New CJson(Of NexoRetailerServerDatabaseSettings)(FSimulator.ServerSettingsFileName)
		json.WriteSettings(Settings)
		modified = False
		SetButtons()
	End Sub

	Private Sub SetButtons()
		pbSave.Enabled = modified
		pbAccept.Enabled = pbSave.Enabled
		pbConnectionsView.Enabled = db.IsOpen
		pbMessagesView.Enabled = db.IsOpen
		pbEndPointsUpdate.Enabled = db.IsOpen
		pbSalesUpdate.Enabled = db.IsOpen
	End Sub

	Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
		SaveSettings()
	End Sub

	Private Sub efConnectionString_TextChanged(sender As Object, e As EventArgs) Handles efSalesTablesName.TextChanged, efMessagesTableName.TextChanged, efEndPointsTableName.TextChanged, efConnectionString.TextChanged, efConnectionsTableName.TextChanged, cbFullSecured.CheckedChanged, cbDeclineByDefault.CheckedChanged
		modified = True
		If sender Is efConnectionString Then
			efConnectionString.BackColor = SystemColors.Window
			db.ConnectionString = Nothing
		End If
		SetButtons()
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		SaveSettings()
		Close()
	End Sub

	Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
		If modified Then
			Select Case MsgBox("Some data have not been saved, do you want to save them before exiting ?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton1)
				Case MsgBoxResult.Yes
					SaveSettings()
				Case MsgBoxResult.No
					Close()
				Case MsgBoxResult.Yes
			End Select
		Else
			Close()
		End If
	End Sub

	Private Sub pbTest_Click(sender As Object, e As EventArgs) Handles pbTest.Click
		db.ConnectionString = efConnectionString.Text
		If db.IsOpen Then
			efConnectionString.BackColor = Color.LightGreen
		Else
			efConnectionString.BackColor = Color.Crimson
		End If
		SetButtons()
	End Sub

	Private Sub pbConnectionsView_Click(sender As Object, e As EventArgs) Handles pbConnectionsView.Click, pbMessagesView.Click, pbSalesUpdate.Click, pbEndPointsUpdate.Click
		Dim f As New FServerDatabase
		f.DbM = db
		If sender Is pbConnectionsView Then
			f.TableName = efConnectionsTableName.Text
		ElseIf sender Is pbMessagesView Then
			f.TableName = efMessagesTableName.Text
		ElseIf sender Is pbEndPointsUpdate Then
			f.TableName = efEndPointsTableName.Text
			f.AllowUpdate = True
		ElseIf sender Is pbSalesUpdate Then
			f.TableName = efSalesTablesName.Text
			f.AllowUpdate = True
		End If
		If Not String.IsNullOrEmpty(f.TableName) Then
			f.ShowDialog()
		End If
		f.Dispose()
	End Sub

End Class