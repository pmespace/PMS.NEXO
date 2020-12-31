Imports System.Collections.Generic
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports Microsoft.Win32
Imports COMMON
Imports NEXO
Imports NEXO.Client
Imports NEXO.Server
Imports System.IO

Public Class FSimulator

#Region "serverThread management"
	Private Enum ActivityEvent
		none
		serverStarted
		serverStopped
		sentNotification
		sentRequest
		sentReply
		receivedNotification
		receivedRequest
		receivedReply
		updateConnected
		forwardingRequest
		receivingForwardedReply
		message
	End Enum
	Private Class Activity
		Public Property position As Position
		Public Property direction As Direction
		Public Property Message As String
		Public Property Evt As ActivityEvent
	End Class
	Private Delegate Sub AddActivity(Activity As Activity)
	Private myDelegate As New AddActivity(AddressOf ProcessUI)

	Private Sub ProcessUI(activity As Activity)
		If ActivityEvent.none <> activity.Evt Then
			AddLine(activity.position, activity.direction, activity.Message)
			Select Case activity.Evt
				Case ActivityEvent.serverStopped
					If isClosing Then
						Close()
					End If
				Case ActivityEvent.receivedReply
					ResetProcessing()
				Case ActivityEvent.receivedNotification
				Case ActivityEvent.receivedRequest
				Case ActivityEvent.updateConnected
			End Select
		End If
		SetButtons()
	End Sub
#End Region

	Private nexoClients As New NexoRetailerClients
	Private nexoServer As NexoRetailerServer = Nothing
	Private gateway As CStreamServer
	Private Const POIIDToUse As String = "090265130468"
	Private connected As Connected
	Private Enum Position
		client
		gateway
		server
	End Enum
	Private Enum Direction
		left
		none
		right
	End Enum
	Private Const SERVER_SETTINGS_FILE_NAME As String = "server.database.json"
	Private Const SETTINGS_FILE_NAME As String = "nexo.simulator"
	Private Const SETTINGS_FILE_EXT As String = ".json"
	Private Const LOG_FILE_EXT As String = ".log"
	Private json As CJson(Of Settings)
	Private isClosing As Boolean = False
	Private nexoServerID As Integer
	Private Const SERVER_STOPPED_MESSAGE As Integer = Win32.WM_USER + 1
	Private Const SERVER_INFORMATION_MESSAGE As Integer = SERVER_STOPPED_MESSAGE + 1
	Private Const GATEWAY_STOPPED_MESSAGE As Integer = Win32.WM_USER + 50
	Private Const GATEWAY_INFORMATION_MESSAGE As Integer = GATEWAY_STOPPED_MESSAGE + 1
	Private Const CLIENT_STOPPED_MESSAGE As Integer = Win32.WM_USER + 100
	Private Const CLIENT_INFORMATION_MESSAGE As Integer = CLIENT_STOPPED_MESSAGE + 1
	Private ClientCounter As Integer = 0

	Private ReadOnly Property ServerIsRunning() As Boolean
		Get
			If Not IsNothing(nexoServer) Then
				Return nexoServer.IsRunning
			Else
				Return False
			End If
		End Get
	End Property

	Private ReadOnly Property GatewayIsRunning As Boolean
		Get
			Return Not IsNothing(gateway) AndAlso gateway.IsRunning
		End Get
	End Property

	Private Property TextToPrint As String
	Private Property IsProcessing As Boolean = False

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sfn As String = SettingsFileName()
		json = New CJson(Of Settings)(sfn & SETTINGS_FILE_EXT)
		CLog.LogFileName = sfn & LOG_FILE_EXT

		connected = New Connected
		connected.Warn = cbConnected
		connected.Visible = False

		'set the default port
		localServerPort.Value = CStreamSettings.DEFAULT_PORT
		LoadSettings()

		'autostart server if requested
		If cbAutostartServer.Checked Then
			StartServer()
		End If
		If cbAutostartGateway.Checked Then
			StartGateway()
		End If
		SetButtons()
	End Sub

	Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		SaveSettings()
		isClosing = True
		If ServerIsRunning Then StopServer()
		If GatewayIsRunning Then StopGateway()
		e.Cancel = False
		e.Cancel = e.Cancel Or ServerIsRunning Or GatewayIsRunning
	End Sub

	Public Function ServerSettingsFileName() As String
		Return SettingsFileName() & "." & SERVER_SETTINGS_FILE_NAME
	End Function

	Public Function SettingsFileName() As String
		Dim path As String = Registry.GetValue("HKEY_CURRENT_USER\Software\CHECK\Simulator", "Settings", ".\")
		If String.IsNullOrEmpty(path) Then
			path = ".\"
		End If
		Return path & SETTINGS_FILE_NAME
	End Function

	Private Sub LoadSettings()
		Dim settings As Settings = json.ReadSettings()
		If Not settings Is Nothing Then
			cbAutostartServer.Checked = settings.Autostart
			Try
				localServerPort.Value = settings.LocalPort
			Catch ex As Exception
				localServerPort.Value = 2018
			End Try
			Try
				targetPort.Value = settings.Port
			Catch ex As Exception
				targetPort.Value = 2018
			End Try
			efSaleID.Text = settings.SaleID
			serviceid.Text = settings.ServiceID
			deviceid.Text = settings.DeviceID
			efPOIID.Text = settings.POIID
			cbConnected.Checked = settings.Connected
			connected.Location = settings.ConnectedLocation
			targetIP.Text = settings.IP
			rbLocalHost.Checked = settings.Target = TargetsEnum.localhost
			rbGateway.Checked = settings.Target = TargetsEnum.gateway
			rbServer.Checked = settings.Target = TargetsEnum.server
			Try
				timeout.Value = settings.ReceiveTimeout
			Catch ex As Exception
				timeout.Value = 30
			End Try
			If Not IsNothing(settings.WindowState) Then Me.WindowState = settings.WindowState
			If Not IsNothing(settings.Location) Then Me.Location = settings.Location
			If Not IsNothing(settings.Size) Then Me.Size = settings.Size
			command.Text = settings.Command
			Try
				gatewayPort.Value = settings.GatewayPort
			Catch ex As Exception
				gatewayPort.Value = CStreamSettings.DEFAULT_PORT
			End Try
			cbGatewayUseLocalHost.Checked = settings.TerminalLocalHost
			gatewayServerIP.Text = settings.TerminalIP
			gatewayServerPort.Value = settings.TerminalPort
			SetColors(lblClient, settings.ClientColor)
			SetColors(lblGateway, settings.GatewayColor)
			SetColors(lblServer, settings.ServerColor)
			TextToPrint = settings.TextToPrint
			cbInfinite.Checked = settings.Infinite
			Try
				udServerDelay.Value = settings.ServerDelay
			Catch ex As Exception
				udServerDelay.Value = 0
			End Try
			cbSynchronous.Checked = settings.Synchronous
			cbAddReceipt.Checked = settings.AddReceipt
			cbOnelineReceipt.Checked = settings.OneLineReceipt
			cbUseDatabase.Checked = settings.UseDatabase
		End If
	End Sub

	Private Sub SaveSettings()
		Dim settings As Settings = New Settings
		settings.Autostart = cbAutostartServer.Checked
		settings.Port = targetPort.Value
		settings.LocalPort = localServerPort.Value
		settings.POIID = efPOIID.Text
		settings.SaleID = efSaleID.Text
		settings.ServiceID = serviceid.Text
		settings.DeviceID = deviceid.Text
		settings.Connected = cbConnected.Checked
		settings.ConnectedLocation = connected.Location
		settings.IP = targetIP.Text
		If rbLocalHost.Checked Then
			settings.Target = TargetsEnum.localhost
		ElseIf rbGateway.Checked Then
			settings.Target = TargetsEnum.gateway
		ElseIf rbServer.Checked Then
			settings.Target = TargetsEnum.server
		Else
			settings.Target = TargetsEnum.localhost
		End If
		settings.ReceiveTimeout = timeout.Value
		settings.WindowState = Me.WindowState
		settings.Location = Me.Location
		settings.Size = Me.Size
		settings.Command = command.Text
		settings.GatewayPort = gatewayPort.Value
		settings.TerminalIP = gatewayServerIP.Text
		settings.TerminalPort = gatewayServerPort.Value
		settings.TerminalLocalHost = cbGatewayUseLocalHost.Checked
		settings.ClientColor = lblClient.ForeColor
		settings.GatewayColor = lblGateway.ForeColor
		settings.ServerColor = lblServer.ForeColor
		settings.TextToPrint = TextToPrint
		settings.Infinite = cbInfinite.Checked
		settings.ServerDelay = udServerDelay.Value
		settings.Synchronous = cbSynchronous.Checked
		settings.AddReceipt = cbAddReceipt.Checked
		settings.OneLineReceipt = cbOnelineReceipt.Checked
		settings.UseDatabase = cbUseDatabase.Checked

		json.WriteSettings(settings)
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case (m.Msg)
			Case GATEWAY_STOPPED_MESSAGE
				AddLine(Position.gateway, Direction.none, "GATEWAY STOPPED")
				gateway = Nothing
				SetButtons()
			Case SERVER_STOPPED_MESSAGE
				AddLine(Position.server, Direction.none, "SERVER STOPPED")
				SetButtons()
			Case CLIENT_STOPPED_MESSAGE
				Dim c As NexoRetailerClient = GetClientFromID(m.WParam)
				If Not IsNothing(c) Then
					AddLine(Position.client, Direction.none, "CLIENT " & c.ToString & " STOPPED")
					RemoveClient(c)
				End If
				ResetProcessing()
				SetButtons()
		End Select
		MyBase.WndProc(m)
	End Sub

	Private Function AddClient(client As NexoRetailerClient) As Boolean
		Try
			nexoClients.Add(client.Key, client)
			Try
				cbxConnections.SelectedIndex = cbxConnections.Items.Add(client)
				Return True
			Catch ex As Exception
				cbxConnections.Items.Remove(client)
				nexoClients.Remove(client.Key)
			End Try
		Catch ex As Exception
		End Try
		Return False
	End Function

	Private Function RemoveClient(c As NexoRetailerClient) As Boolean
		Try
			If Not IsNothing(c) Then
				cbxConnections.Items.Remove(c)
				nexoClients.Remove(c.Key)
				Return True
			End If
		Catch ex As Exception
		End Try
		Return False
	End Function

	Private Function RemoveClientByID(i As Integer) As Boolean
		Try
			Dim client As NexoRetailerClient = GetClientFromID(i)
			Return RemoveClient(client)
		Catch ex As Exception
		End Try
		Return False
	End Function

	Private Function GetClientFromID(i As Integer) As NexoRetailerClient
		Dim client As NexoRetailerClient = Nothing
		Try
			For Each entry As KeyValuePair(Of String, NexoRetailerClient) In nexoClients
				If entry.Value.ID = i Then
					client = entry.Value
					Exit For
				End If
			Next
		Catch ex As Exception
		End Try
		Return client
	End Function

	Private Sub SetColors(lbl As Label, color As Color)
		Dim lbl1 As Label = Nothing, lbl2 As Label = Nothing
		Dim pnl As Panel = Nothing
		Dim f As Boolean = True
		If lbl Is lblClientHeader Or lbl Is lblClient Then
			lbl1 = lblClient
			lbl2 = lblClientHeader
			pnl = panelClient
		ElseIf lbl Is lblGatewayHeader Or lbl Is lblGateway Then
			lbl1 = lblGateway
			lbl2 = lblGatewayHeader
			pnl = panelGateway
		ElseIf lbl Is lblServerHeader Or lbl Is lblServer Then
			lbl1 = lblServer
			lbl2 = lblServerHeader
			pnl = panelServer
		Else
			f = False
		End If
		If f AndAlso pnl.BackColor <> color Then
			lbl1.ForeColor = color
			lbl2.ForeColor = lbl1.ForeColor
		End If
	End Sub

	Private Sub AdjustBackColor(ctl As Control, container As Control, invert As Boolean)
		If invert Then
			ctl.BackColor = Color.FromArgb(container.BackColor.ToArgb() Xor &HFFFFFF)
		Else
			ctl.BackColor = container.BackColor
		End If
	End Sub

	Private Sub SetButtons()
		'server part
		pbStartServer.Enabled = Not ServerIsRunning
		pbStopServer.Enabled = ServerIsRunning
		pbServerActivity.Enabled = ServerIsRunning
		localServerPort.Enabled = Not ServerIsRunning
		AdjustBackColor(lblServer, panelServer, pbStopServer.Enabled)

		'client part
		panelClientTarget.Enabled = rbServer.Checked
		panelCommands.Enabled = panelRaw.Enabled = 0 <> nexoClients.Count
		CanDisconnect()

		'gateway part
		pbStartGateway.Enabled = Not GatewayIsRunning
		pbStopGateway.Enabled = GatewayIsRunning
		AdjustBackColor(lblGateway, panelGateway, pbStopGateway.Enabled)
		gatewayPort.Enabled = Not GatewayIsRunning
		cbGatewayUseLocalHost.Enabled = Not GatewayIsRunning
		gatewayServerIP.Enabled = Not GatewayIsRunning And Not cbGatewayUseLocalHost.Checked
		gatewayServerPort.Enabled = Not GatewayIsRunning And Not cbGatewayUseLocalHost.Checked

		pbSaveContent.Enabled = 0 <> RichTextBox1.Text.Length

		timeout.Enabled = Not cbInfinite.Checked

		'test gateway configuration
		If (cbGatewayUseLocalHost.Checked AndAlso gatewayPort.Value = localServerPort.Value) Or
		(Not cbGatewayUseLocalHost.Checked AndAlso gatewayPort.Value = localServerPort.Value AndAlso CStream.Localhost() = gatewayServerIP.Text) Then
			gatewayPort.BackColor = Color.Red
		Else
			gatewayPort.BackColor = SystemColors.Window
		End If

		If ServerIsRunning Then
			Text = "Nexo Simulator - CLIENT = SaleID: " & FullSaleID() & " / POIID: " & FullPOIID() & " - SERVER = POIID: " & FullServerPOIID()
		Else
			Text = "Nexo Simulator - CLIENT = SaleID: " & FullSaleID() & " / POIID: " & FullPOIID() & " - SERVER = Inactive"
		End If

		If isClosing Then
			Close()
		End If
	End Sub

	Private Sub SetProcessing()

		IsProcessing = True
		SetButtons()
	End Sub

	Private Sub ResetProcessing()
		IsProcessing = False
		SetButtons()
	End Sub

	Private Sub AddLine(position As Position, r As Direction, s As String, Optional reset As Boolean = False)
		Dim dt As DateTime = Now
		Dim start As Integer = RichTextBox1.TextLength
		Dim txt As String = dt.ToString("s") & ": " & s & vbCrLf
		Select Case r
			Case Direction.left
				txt = "<<< " & txt & " <<<"
			Case Direction.right
				txt = ">>> " & txt & " >>>"
		End Select
		RichTextBox1.SelectionStart = start
		If position = Position.server Then
			RichTextBox1.SelectionColor = lblServerHeader.ForeColor
			RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
		ElseIf position = Position.client Then
			RichTextBox1.SelectionColor = lblClientHeader.ForeColor
			RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
		ElseIf position = Position.gateway Then
			RichTextBox1.SelectionColor = lblGatewayHeader.ForeColor
			RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
		Else
			RichTextBox1.SelectionColor = Color.Black
			RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
		End If
		RichTextBox1.AppendText(txt & vbCrLf)
		RichTextBox1.SelectionLength = RichTextBox1.TextLength - start
		RichTextBox1.ScrollToCaret()
	End Sub

	Private Function MessageLength(s As String) As String
		Return " [" & s.Length & " bytes]"
	End Function

	Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
		Close()
	End Sub

	Private Sub pbStartServer_Click(sender As Object, e As EventArgs) Handles pbStartServer.Click
		StartServer()
	End Sub

	Private Function FullServerPOIID()
		Return POIIDToUse & "@" & CStream.Localhost & ":" & localServerPort.Value.ToString
	End Function

	Private Sub StartServer()
		If Not ServerIsRunning Then
			nexoServer = New NexoRetailerServer(cbUseDatabase.Checked)
			Dim settings As CStreamServerSettings = CStreamServerSettings.Prepare(localServerPort.Value)
			Dim threadData As CThreadData = CThreadData.Prepare(Me.Handle,
																				 SERVER_STOPPED_MESSAGE,
																				 SERVER_INFORMATION_MESSAGE)
			Dim dbSettings As NexoRetailerServerDatabaseSettings = Nothing
			If nexoServer.UseDatabase Then
				dbSettings = NexoRetailerServer.LoadDatabaseSettings(ServerSettingsFileName)
			End If
			Dim startType As NexoRetailerServerSettings = NexoRetailerServerSettings.Prepare(settings,
																												 threadData,
																												 AddressOf ServerOnReceivedRequest,
																												 AddressOf ServerOnReceivedReply,
																												 AddressOf ServerOnReceivedNotification,
																												 AddressOf ServerOnSend,
																												 AddressOf ServerOnStart,
																												 AddressOf ServerOnConnect,
																												 AddressOf ServerOnDisconnect,
																												 AddressOf ServerOnStop,
																												 dbSettings)
			If CThread.NO_THREAD = nexoServer.Start(startType) Then
				RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.message, .Message = "SERVER FAILED TO START"})
				nexoServer = Nothing
			Else
				RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.message, .Message = "SERVER STARTED"})
			End If
			SetButtons()
		End If
	End Sub

	Private Sub StopServer()
		If Not IsNothing(nexoServer) Then
			nexoServer.Stop()
			nexoServer = Nothing
			SetButtons()
		End If
	End Sub

	Private Function ServerOnStart(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "SERVER IS STARTING"})
		Return True
	End Function

	Private Function ServerOnConnect(tcp As TcpClient, threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "CLIENT CONNECTED (" & tcp.Client.RemoteEndPoint.ToString & ")"})
		Return True
	End Function

	Private Sub ServerOnDisconnect(tcp As String, threadData As CThreadData, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "CLIENT DISCONNECTED (" & tcp & ")"})
	End Sub

	Private Function IsRecognized(o As NexoObject, saleid As String, poiid As String)
		Return (o.SaleID = saleid AndAlso o.POIID = poiid) OrElse
							(o.SaleID = saleid AndAlso "*" = poiid) OrElse
							("*" = saleid AndAlso o.POIID = poiid) OrElse
							("*" = saleid AndAlso "*" = poiid)
	End Function

	Private Sub ServerOnReceivedRequest(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		Dim cat As String = toprocess.Category.ToString
		If MessageCategoryEnumeration.Payment = toprocess.Category Then
			Dim tmp As NexoFinancial = toprocess.CurrentObject
			If PaymentTypeEnumeration.Normal <> tmp.PaymentType Then
				cat = tmp.PaymentType.ToString
			End If
		End If
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & cat.ToUpper & " REQUEST" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})

		If Not toprocess.CurrentObject.Success Then
			Return
		End If

		Dim processed As Boolean = False
		Select Case (toprocess.Category)
			Case MessageCategoryEnumeration.Login
				Dim nxo As NexoLogin = toprocess.CurrentObject
				Dim json As New CJson(Of List(Of Login))((SettingsFileName() & "." & nxo.MessageCategory.ToString() & ".json").ToLower())
				Dim data As List(Of Login) = json.ReadSettings(True)
				If Not IsNothing(data) Then
					For Each entry As Login In data
						If IsRecognized(nxo, entry.SaleID, entry.POIID) Then
							nxo.Response = entry.Response
							nxo.ReplyData.POISystemData.POISoftware = entry.POISoftware
							processed = True
							Exit For
						End If
					Next
				Else
					Dim entries As New List(Of Login)
					Dim entry As New Login
					entry.SaleID = "*"
					entry.POIID = "*"
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = Nothing
					entry.Response.AdditionalResponse = Nothing
					entry.POISoftware = New POISoftwareType
					entry.POISoftware.ApplicationName = "Nexo Simulator"
					entry.POISoftware.SoftwareVersion = New NexoSoftwareVersion().DefaultValue
					entry.POISoftware.CertificationCode = New NexoCertificationCode().DefaultValue
					entry.POISoftware.ManufacturerID = New NexoManufacturerID().DefaultValue
					entries.Add(entry)
					json.WriteSettings(entries, True)
				End If
				If nxo.Unknown Then ' Not processed Then
					nxo.Response.Result = ResultEnumeration.Failure.ToString
					nxo.Response.ErrorCondition = ErrorConditionEnumeration.NotAllowed.ToString
				End If

			Case MessageCategoryEnumeration.Logout
				Dim nxo As NexoLogout = toprocess.CurrentObject
				Dim json As New CJson(Of List(Of Logout))((SettingsFileName() & "." & nxo.MessageCategory.ToString() & ".json").ToLower())
				Dim data As List(Of Logout) = json.ReadSettings(True)
				If Not IsNothing(data) Then
					For Each entry As Logout In data
						If IsRecognized(nxo, entry.SaleID, entry.POIID) Then
							nxo.Response = entry.Response
							processed = True
							Exit For
						End If
					Next
				Else
					Dim entries As New List(Of Logout)
					Dim entry As New Logout
					entry.SaleID = "*"
					entry.POIID = "*"
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = Nothing
					entry.Response.AdditionalResponse = Nothing
					entries.Add(entry)
					json.WriteSettings(entries, True)
				End If
				If nxo.Unknown Then ' Not processed Then
					nxo.Response.Result = ResultEnumeration.Failure.ToString
					nxo.Response.ErrorCondition = ErrorConditionEnumeration.NotFound.ToString
				End If

			Case MessageCategoryEnumeration.Input
				Dim nxo As NexoDeviceInput = toprocess.CurrentObject
				Dim json As New CJson(Of List(Of DeviceInput))((SettingsFileName() & "." & nxo.MessageCategory.ToString() & ".json").ToLower())
				Dim data As List(Of DeviceInput) = json.ReadSettings(True)
				If Not IsNothing(data) Then
					For Each entry As DeviceInput In data
						If IsRecognized(nxo, entry.SaleID, entry.POIID) Then
							nxo.ReplyData.InputResult.Input.InputCommand = entry.InputResult.Input.InputCommand
							nxo.ReplyData.InputResult.Input.TextInput = entry.InputResult.Input.TextInput
							nxo.ReplyData.InputResult.Device = entry.InputResult.Device
							nxo.ReplyData.InputResult.InfoQualify = entry.InputResult.InfoQualify
							nxo.Response = entry.Response
							processed = True
							Exit For
						End If
					Next
				Else
					Dim entries As New List(Of DeviceInput)
					'1
					Dim entry As New DeviceInput
					entry.InputResult = New InputResultType
					entry.InputResult.Input = New InputType
					entry.SaleID = "*"
					entry.POIID = "*"
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = Nothing
					entry.Response.AdditionalResponse = Nothing

					entry.InputResult.Device = DeviceEnumeration.CashierInput.ToString
					entry.InputResult.InfoQualify = InfoQualifyEnumeration.Document.ToString
					entry.InputResult.Input.InputCommand = InputCommandEnumeration.TextString.ToString
					entry.InputResult.Input.TextInput = "D0000001D800000000909F000000000000B"
					entries.Add(entry)
					'2
					entry = New DeviceInput
					entry.InputResult = New InputResultType
					entry.InputResult.Input = New InputType
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.InputResult.Input.InputCommand = InputCommandEnumeration.TextString.ToString
					entry.InputResult.Input.TextInput = "D1943749D075000004908F089000075641B"
					entry.InputResult.Device = DeviceEnumeration.CashierInput.ToString
					entry.InputResult.InfoQualify = InfoQualifyEnumeration.Document.ToString
					entries.Add(entry)
					'3
					entry = New DeviceInput
					entry.InputResult = New InputResultType
					entry.InputResult.Input = New InputType
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Failure.ToString
					entry.Response.ErrorCondition = ErrorConditionEnumeration.DeviceOut.ToString
					entry.Response.AdditionalResponse = "Erreur lors de la lecture du chèque"
					'entry.InputResult.Device = ""
					'entry.InputResult.InfoQualify = ""
					'entry.InputResult.Input.InputCommand = ""
					'entry.InputResult.Input.TextInput = ""
					entries.Add(entry)
					'4
					entry = New DeviceInput
					entry.InputResult = New InputResultType
					entry.InputResult.Input = New InputType
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Failure.ToString
					entry.Response.ErrorCondition = ErrorConditionEnumeration.Cancel.ToString
					entry.Response.AdditionalResponse = "Lecture chèque annulée"
					entries.Add(entry)
					json.WriteSettings(entries, True)
				End If
				If nxo.Unknown Then ' Not processed Then
					nxo.Response.Result = ResultEnumeration.Failure.ToString
					nxo.Response.ErrorCondition = ErrorConditionEnumeration.Aborted.ToString
				End If

			Case MessageCategoryEnumeration.Print
				Dim nxo As NexoDevicePrint = toprocess.CurrentObject
				Dim json As New CJson(Of List(Of DevicePrint))((SettingsFileName() & "." & nxo.MessageCategory.ToString() & ".json").ToLower())
				Dim data As List(Of DevicePrint) = json.ReadSettings(True)
				If Not IsNothing(data) Then
					For Each entry As DevicePrint In data
						If IsRecognized(nxo, entry.SaleID, entry.POIID) Then
							nxo.Response = entry.Response
							processed = True
							Exit For
						End If
					Next
				Else
					Dim entries As New List(Of DevicePrint)
					'1
					Dim entry As New DevicePrint
					entry.Response = New ResponseType
					entry.SaleID = "*"
					entry.POIID = "*"
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = Nothing
					entry.Response.AdditionalResponse = Nothing
					entries.Add(entry)
					'2
					entry = New DevicePrint
					entry.Response = New ResponseType
					entry.SaleID = ""
					entry.POIID = ""
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = ErrorConditionEnumeration.DeviceOut.ToString
					entry.Response.AdditionalResponse = "Erreur lors de l'impression du chèque"
					entries.Add(entry)
					'3
					entry = New DevicePrint
					entry.Response = New ResponseType
					entry.SaleID = ""
					entry.POIID = ""
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = ErrorConditionEnumeration.Cancel.ToString
					entry.Response.AdditionalResponse = "Lecteur chèque annulée"
					entries.Add(entry)
					json.WriteSettings(entries, True)
				End If
				If nxo.Unknown Then ' Not processed Then
					nxo.Response.Result = ResultEnumeration.Failure.ToString
					nxo.Response.ErrorCondition = ErrorConditionEnumeration.Aborted.ToString
				End If

			Case MessageCategoryEnumeration.Payment
				Dim nxo As NexoFinancial = toprocess.CurrentObject
				Dim json As New CJson(Of List(Of Financial))((SettingsFileName() & "." & nxo.PaymentType.ToString() & ".json").ToLower())
				Dim data As List(Of Financial) = json.ReadSettings(True)
				If Not IsNothing(data) Then
					For Each entry As Financial In data
						If IsRecognized(nxo, entry.SaleID, entry.POIID) Then
							nxo.ReplyAuthorizedAmount = nxo.RequestRequestedAmount
							nxo.ReplyPaymentBrand = entry.PaymentBrand
							nxo.Response = entry.Response
							processed = True
							Exit For
						End If
					Next
				Else
					Dim entries As New List(Of Financial)
					'1
					Dim entry As New Financial
					entry.SaleID = "*"
					entry.POIID = "*"
					entry.RequestedAmount = 1.0
					entry.PaymentBrand = "CB"
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Success.ToString
					entry.Response.ErrorCondition = Nothing
					entry.Response.AdditionalResponse = Nothing
					entries.Add(entry)
					'2
					entry = New Financial
					entry.SaleID = ""
					entry.POIID = ""
					entry.RequestedAmount = 1.0
					entry.PaymentBrand = "VISA"
					entry.Response = New ResponseType
					entry.Response.Result = ResultEnumeration.Failure.ToString
					entry.Response.ErrorCondition = ErrorConditionEnumeration.NotAllowed.ToString
					entry.Response.AdditionalResponse = "Declined"
					entries.Add(entry)
					json.WriteSettings(entries, True)
				End If
				If nxo.Unknown Then ' Not processed Then
					nxo.Response.Result = ResultEnumeration.Failure.ToString
					nxo.Response.ErrorCondition = ErrorConditionEnumeration.Aborted.ToString
				End If

				'add receipt if required
				If cbAddReceipt.Checked Then
					Dim amountToUse As Double = nxo.RequestRequestedAmount
					Dim resultString As String = "DECLINED TRANSACTION"
					If nxo.Success Then
						amountToUse = nxo.ReplyAuthorizedAmount
						resultString = "ACCEPTED TRANSACTION"
					End If
					Dim clientReceipt As New PaymentReceiptType()
					Dim merchantReceipt As New PaymentReceiptType()
					clientReceipt.DocumentQualifier = DocumentQualifierEnumeration.CustomerReceipt.ToString
					merchantReceipt.DocumentQualifier = DocumentQualifierEnumeration.CashierReceipt.ToString
					clientReceipt.OutputContent.OutputFormat = OutputFormatEnumeration.Text.ToString
					merchantReceipt.OutputContent.OutputFormat = OutputFormatEnumeration.Text.ToString

					'client receipt
					Dim clientText As New List(Of String)
					If nxo.Success Then
						clientText.Add("TRANSACTION ACCEPTED")
					Else
						clientText.Add("TRANSACTION DECLINED")
					End If
					clientText.Add("")
					clientText.Add("CLIENT RECEIPT")
					clientText.Add("AMOUNT: " & amountToUse & " " & nxo.RequestCurrency)
					clientText.Add("")
					If nxo.Success Then
						clientText.Add("THANK YOU")
					Else
						clientText.Add("SORRY")
					End If

					'merchant receipt
					Dim merchantText As New List(Of String)
					If nxo.Success Then
						merchantText.Add("TRANSACTION ACCEPTED")
					Else
						merchantText.Add("TRANSACTION DECLINED")
					End If
					merchantText.Add("")
					merchantText.Add("MERCHANT RECEIPT")
					merchantText.Add("AMOUNT: " & amountToUse & " " & nxo.RequestCurrency)
					merchantText.Add("")
					If nxo.Success Then
						merchantText.Add("GOOD DEAL")
					Else
						merchantText.Add("TOO BAD")
					End If

					If cbOnelineReceipt.Checked Then
						Dim t As String = String.Empty
						For Each s As String In clientText
							t = t & s & vbLf
						Next
						clientReceipt.OutputContent.OutputTextAddItem(New OutputTextType() With {.Value = t})
						t = String.Empty
						For Each s As String In merchantText
							t = t & s & vbLf
						Next
						merchantReceipt.OutputContent.OutputTextAddItem(New OutputTextType() With {.Value = t})
					Else
						For Each s As String In clientText
							clientReceipt.OutputContent.OutputTextAddItem(New OutputTextType() With {.Value = s, .EndOfLineFlag = False})
						Next
						For Each s As String In merchantText
							merchantReceipt.OutputContent.OutputTextAddItem(New OutputTextType() With {.Value = s, .EndOfLineFlag = True})
						Next
					End If

					'set receipts
					nxo.ReplyData.PaymentReceiptAddItem(clientReceipt)
					nxo.ReplyData.PaymentReceiptAddItem(merchantReceipt)
				End If
		End Select
	End Sub

	Private Sub PrepareReceipt(s As String, clientText As List(Of String), merchantText As List(Of String))


	End Sub

	Private Sub ServerOnReceivedReply(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & toprocess.Type.ToString.ToUpper & " RESPONSE" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Sub ServerOnReceivedNotification(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & toprocess.Type.ToString.ToUpper & " NOTIFICATION" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Sub ServerOnSend(xml As String, toprocess As NexoItem, tcp As TcpClient, threadData As CThreadData, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.left, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "SENDING " & toprocess.Type.ToString.ToUpper & " TO " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Function ServerOnStop(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "SERVER IS STOPPING"})
		Return True
	End Function

	Private Sub pbStop_Click(sender As Object, e As EventArgs) Handles pbStopServer.Click
		StopServer()
	End Sub

	Private Sub pbActivity_Click(sender As Object, e As EventArgs) Handles pbServerActivity.Click
		If Not IsNothing(nexoServer) Then
			Dim f As New FActivity(nexoServer)
			f.ShowDialog()
		End If
	End Sub

	Private Sub saleID_TextChanged(sender As Object, e As EventArgs) Handles efSaleID.TextChanged
		SetButtons()
	End Sub

	Private Sub pbConnect_Click(sender As Object, e As EventArgs) Handles pbConnect.Click
		Dim nexoClient As New NexoRetailerClient
		Dim settings As New CStreamClientSettings
		If rbLocalHost.Checked Then
			settings.IP = CStream.Localhost()
			settings.Port = localServerPort.Value
		ElseIf rbGateway.Checked Then
			settings.IP = CStream.Localhost()
			settings.Port = gatewayPort.Value
		Else
			settings.IP = targetIP.Text
			settings.Port = targetPort.Value
		End If
		Dim nexoRetailerClientSettings As New NexoRetailerClientSettings() With
			{
			.StreamClientSettings = settings,
			.OnReceivedRequest = AddressOf ClientOnReceived,
			.OnReceivedNotification = AddressOf ClientOnReceived,
			.OnReceivedReply = AddressOf ClientOnReceived,
			.OnSend = AddressOf ClientOnSend,
			.OnSentRequestStatusChanged = AddressOf ClientOnSentRequestStatusChanged,
			.OnReceivedIgnoredMessage = AddressOf ClientOnReceived,
			.ThreadData = CThreadData.Prepare(Me.Handle,
														 CLIENT_STOPPED_MESSAGE,
														 CLIENT_INFORMATION_MESSAGE),
			.Parameters = Nothing
			}
		If nexoClient.Connect(nexoRetailerClientSettings) Then
			If AddClient(nexoClient) Then
				RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "CLIENT " & nexoClient.KeyClient & " IS CONNECTED TO " & nexoClient.KeyServer})
			End If
		Else
			MessageBox.Show("Connection to " & settings.FullIP & " has failed")
		End If
		SetButtons()
	End Sub

	Public Sub ClientOnSend(xml As String, obj As NexoItem, tcp As TcpClient, threadData As CThreadData, o As Object)
		Dim s As String = obj.Category.ToString
		If MessageCategoryEnumeration.Payment = obj.Category Then
			Dim f As New NexoFinancial()
			f.FromItem(obj)
			If PaymentTypeEnumeration.Normal <> f.PaymentType Then
				's = CMisc.GetEnumName(PaymentTypeEnumeration, f.PaymentType)
				s = f.PaymentType.ToString
			End If
		End If
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SENDING " & s.ToUpper & " " & obj.Type.ToString.ToUpper & " TO " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Public Sub ClientOnReceived(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		Dim msg As String = String.Empty
		Dim activity As ActivityEvent = ActivityEvent.none

		Dim s As String = obj.Type.ToString
		If MessageCategoryEnumeration.Payment = obj.Category Then
			Dim f As New NexoFinancial()
			f.FromItem(obj.Item)
			If PaymentTypeEnumeration.Normal <> f.PaymentType Then
				's = CMisc.GetEnumName(PaymentTypeEnumeration, f.PaymentType)
				s = f.PaymentType.ToString
			End If
		End If
		Dim status As String = Nothing
		If NexoNextAction.nothing = obj.SuggestedAction Then
			status = " HAS BEEN IGNORED"
		End If

		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.left, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "RECEIVED " & obj.Category.ToString.ToUpper & " " & s.ToUpper & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & status & vbCrLf & xml})

		If NexoNextAction.nothing <> obj.SuggestedAction Then
			Select Case obj.Type
				Case MessageTypeEnumeration.Request
				Case MessageTypeEnumeration.Notification
					xml = obj.CurrentObject.SerializedRequest
					activity = ActivityEvent.receivedRequest
					If MessageTypeEnumeration.Request = obj.Type Then
						msg = "RECEIVED REQUEST"
					Else
						msg = "RECEIVED NOTIFICATION"
					End If
				Case MessageTypeEnumeration.Response
					Dim result As ResultEnumeration = DirectCast(CMisc.GetEnumValue(GetType(ResultEnumeration), obj.CurrentObject.Response.Result), ResultEnumeration)
					Select Case obj.CurrentObject.MessageCategory
						Case MessageCategoryEnumeration.Login
							Dim nxo As NexoLogin = obj.CurrentObject
							RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SALEID IS CONNECTED (" & nxo.SaleID & ")"})
						Case MessageCategoryEnumeration.Logout
							Dim nxo As NexoLogout = obj.CurrentObject
							RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SALEID HAS BEEN DISCONNECTED (" & nxo.SaleID & ")"})
					End Select
			End Select
		End If
	End Sub

	Public Sub ClientOnSentRequestStatusChanged(xml As String, obj As NexoObjectToProcess, status As NexoMessageStatus, tcp As TcpClient, threadData As CThreadData, o As Object)
		Dim s As String = Nothing
		Select Case status
			Case NexoMessageStatus.timeout
				s = "TIMED OUT"
			Case NexoMessageStatus.cancelled
				s = "WAS CANCELLED BY USER"
		End Select
		RichTextBox1.Invoke(myDelegate, New Activity() With
								  {
								  .position = Position.client,
								  .Evt = ActivityEvent.updateConnected,
								  .Message = "??? SENT MESSAGE " & obj.Category.ToString.ToUpper & " " & obj.Type.ToString.ToUpper & " TO " & tcp.Client.RemoteEndPoint.ToString & " " & s & " AND HAS BEEN DISMISSED" & MessageLength(xml) & " ???" & vbCrLf & xml
								  })

		''prepare new message (abort ?)
		'Dim abort As New NexoAbort()
		'abort.AbortRequest(obj.CurrentObject)
		'abort.AbortReason = "Timeout"
		'obj.NextObject = abort
	End Sub

	'Public Function ClientOnRawReplyAsync(xml As String) As Boolean
	'	RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.server, .Evt = ActivityEvent.receivedReply, .Message = "=> RECEIVED REPLY" & MessageLength(xml) & vbCrLf & xml})
	'	Return True
	'End Function

	Private Function FullSaleID() As String
		If String.IsNullOrEmpty(efSaleID.Text) Then
			Dim c As NexoRetailerClient = CurrentClient()
			If Not IsNothing(c) Then
				efSaleID.Text = CurrentClient().KeyClient
			End If
		End If
		Dim s As String = efSaleID.Text
		If String.IsNullOrEmpty(s) Then s = "SaleID"
		Return CMisc.Trimmed(s)
	End Function

	Private Function FullPOIID() As String
		'Return CMisc.Trimmed(poiid.Text) ' & "@" & targetip.Text & ":" & targetport.Value.ToString
		'If rbLocalHost.Checked Then
		'	Return CMisc.Trimmed(poiid.Text) & "@" & CStream.Localhost & ":" & localServerPort.Value.ToString
		'ElseIf rbGateway.Checked Then
		'	Return CMisc.Trimmed(poiid.Text) & "@" & CStream.Localhost & ":" & gatewayPort.Value.ToString
		'Else
		'	Return CMisc.Trimmed(poiid.Text) & "@" & targetIP.Text & ":" & targetPort.Value.ToString
		'End If
		If String.IsNullOrEmpty(efPOIID.Text) Then
			Dim c As NexoRetailerClient = CurrentClient()
			If Not IsNothing(c) Then
				efPOIID.Text = CurrentClient().KeyServer
			End If
		End If
		Dim s As String = efPOIID.Text
		If String.IsNullOrEmpty(s) Then s = "POIID"
		Return CMisc.Trimmed(s)
	End Function

	Private Function CurrentClient() As NexoRetailerClient
		Dim item As NexoRetailerClient = cbxConnections.SelectedItem
		If Not IsNothing(item) Then
			Try
				Dim client As NexoRetailerClient = nexoClients(item.Key)
				'arrived here we get an existing client
				Return client
			Catch ex As Exception
			End Try
		End If
		Return Nothing
	End Function

	Private Function GetTimeout() As Integer
		If cbInfinite.Checked Then
			Return CStreamSettings.NO_TIMEOUT
		Else
			Return timeout.Value
		End If
	End Function

	Private Sub DisplaySynchronousExchange(client As NexoRetailerClient, o As NexoObject, s As String)
		Dim q As String = o.SerializedRequest, y As String = o.SerializedReply
		AddLine(Position.client, Direction.right, "SYNCHRONOUSLY SENT " & o.MessageCategory.ToString.ToUpper & " " & " REQUEST TO " & s & MessageLength(q) & vbCrLf & q)
		If client.Received Then
			AddLine(Position.client, Direction.left, "SYNCHRONOUSLY RECEIVED " & o.MessageCategory.ToString.ToUpper & " " & " RESPONSE FROM " & s & MessageLength(y) & vbCrLf & y)
		Else
			Dim sts As String = "TIMEOUT"
			If client.Cancelled Then sts = "CANCELLED"
			AddLine(Position.client, Direction.none, "SYNCHRONOUS  EXCHANGE FAILED WITH STATUS: " & sts)
		End If
	End Sub

	Private Sub pbLogin_Click(sender As Object, e As EventArgs) Handles pbLogin.Click
		'create the NexoLogin object
		Dim o As New NexoLogin()
		o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(serviceid.Text)
		o.RequestApplicationName = Environment.MachineName
		o.RequestManufacturerID = Environment.MachineName
		o.ProtocolVersion = New NexoProtocolVersion().DefaultValue
		o.RequestData.OperatorID = New NexoOperatorID().DefaultValue
		o.RequestCertificationCode = "NotCertified"
		o.RequestSoftwareVersion = New NexoSoftwareVersion().DefaultValue
		Dim s As String = o.SerializedRequest
		Dim client As NexoRetailerClient = CurrentClient()
		Dim f As Boolean = True
		If f = Not IsNothing(client) Then
			If cbSynchronous.Checked Then
				If client.SendRequestSync(o, GetTimeout()) Then
					DisplaySynchronousExchange(client, o, client.KeyServer)
				End If
			Else
				Dim t As Object = client.SendRequest(o, GetTimeout())
				If f = Not IsNothing(t) Then
				End If
			End If
		End If
		If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING LOGIN REQUEST" & MessageLength(s) & vbCrLf & s)
		SetButtons()
	End Sub

	Private Sub pbLogout_Click(sender As Object, e As EventArgs) Handles pbLogout.Click
		'create the NexoLogin object
		Dim o As New NexoLogout()
		o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(serviceid.Text)
		Dim s As String = o.SerializedRequest
		Dim client As NexoRetailerClient = CurrentClient()
		Dim f As Boolean = True
		If f = Not IsNothing(client) Then
			If cbSynchronous.Checked Then
				If client.SendRequestSync(o, GetTimeout()) Then
					DisplaySynchronousExchange(client, o, client.KeyServer)
				End If
			Else
				Dim t As Object = client.SendRequest(o, GetTimeout())
				If f = Not IsNothing(t) Then
				End If
			End If
		End If
		If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING LOGOUT REQUEST" & MessageLength(s) & vbCrLf & s)
		SetButtons()
	End Sub

	Private Sub pbDeviceInput_Click(sender As Object, e As EventArgs) Handles pbDeviceInput.Click
		Dim o As New NexoDeviceInput()
		o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(serviceid.Text)
		o.DeviceID = CMisc.Trimmed(deviceid.Text)
		o.RequestDevice = DeviceEnumeration.CashierInput
		o.RequestInfoQualify = InfoQualifyEnumeration.Document
		o.RequestInputCommand = InputCommandEnumeration.TextString
		Dim deviceTimeout As Integer = timeout.Value
		If cbInfinite.Checked Then
			deviceTimeout = 30
		Else
			If deviceTimeout - 5 <= 0 Then
				deviceTimeout = deviceTimeout + 15
			End If
		End If
		o.RequestData.InputData.MaxInputTime = (deviceTimeout - 5).ToString
		Dim s As String = o.SerializedRequest
		Dim client As NexoRetailerClient = CurrentClient()
		Dim f As Boolean = True
		If f = Not IsNothing(client) Then
			If cbSynchronous.Checked Then
				If client.SendRequestSync(o, GetTimeout()) Then
					DisplaySynchronousExchange(client, o, client.KeyServer)
				End If
			Else
				Dim t As Object = client.SendRequest(o, GetTimeout())
				If f = Not IsNothing(t) Then
				End If
			End If
		End If
		If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING DEVICE INPUT REQUEST" & MessageLength(s) & vbCrLf & s)
		SetButtons()
	End Sub

	Private Sub pbDevicePrint_Click(sender As Object, e As EventArgs) Handles pbDevicePrint.Click
		Dim p As New FTextToPrint
		p.TextToPrint = TextToPrint
		Select Case p.ShowDialog
			Case DialogResult.OK
				TextToPrint = p.TextToPrint
				'create the NexoLogin object
				Dim o As New NexoDevicePrint()
				o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(serviceid.Text)
				o.DeviceID = CMisc.Trimmed(deviceid.Text)
				o.RequestDocumentQualifier = DocumentQualifierEnumeration.Document
				o.RequestResponseMode = ResponseModeEnumeration.PrintEnd
				o.RequestOutputFormat = OutputFormatEnumeration.Text

				Dim outputTextType As New OutputTextType()
				outputTextType.Value = TextToPrint
				o.RequestData.PrintOutput.OutputContent.OutputTextAddItem(outputTextType)
				Dim s As String = o.SerializedRequest
				Dim client As NexoRetailerClient = CurrentClient()
				Dim f As Boolean = True
				If f = Not IsNothing(client) Then
					If cbSynchronous.Checked Then
						If client.SendRequestSync(o, GetTimeout()) Then
							DisplaySynchronousExchange(client, o, client.KeyServer)
						End If
					Else
						Dim t As Object = client.SendRequest(o, GetTimeout())
						If f = Not IsNothing(t) Then
						End If
					End If
				End If
				If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING DEVICE PRINT REQUEST" & MessageLength(s) & vbCrLf & s)
				SetButtons()
		End Select
		p = Nothing
	End Sub

	Private Sub pbPayment_Click(sender As Object, e As EventArgs) Handles pbPayment.Click
		Dim payment As New FAmount
		Select Case payment.ShowDialog
			Case DialogResult.OK
				'create the NexoLogin object
				Dim o As New NexoPayment()
				o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(serviceid.Text)
				o.RequestSaleTransactionID = NexoAutoID.ID
				Dim eur As New NexoCurrencyEUR()
				o.RequestCurrency = eur.Value
				o.RequestRequestedAmount = New NexoSimpleAmount() With {.DecimalPlaces = eur.DecimalPlaces, .AsDecimal = payment.Amount / 100}.AsDecimal
				Dim s As String = o.SerializedRequest
				Dim client As NexoRetailerClient = CurrentClient()
				Dim f As Boolean = True
				If f = Not IsNothing(client) Then
					If cbSynchronous.Checked Then
						If client.SendRequestSync(o, GetTimeout()) Then
							DisplaySynchronousExchange(client, o, client.KeyServer)
						End If
					Else
						Dim t As Object = client.SendRequest(o, GetTimeout())
						If f = Not IsNothing(t) Then
						End If
					End If
				End If
				If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING PAYMENT REQUEST" & MessageLength(s) & vbCrLf & s)
				SetButtons()
		End Select
	End Sub

	Private Sub cbConnected_CheckedChanged(sender As Object, e As EventArgs) Handles cbConnected.CheckedChanged
		connected.Visible = cbConnected.Checked
	End Sub

	Private Sub localIP_CheckedChanged(sender As Object, e As EventArgs)
		SetButtons()
	End Sub

	Private Sub pbFree_Click(sender As Object, e As EventArgs) Handles pbSendFreeMessage.Click
		If Not String.IsNullOrEmpty(command.Text) Then
			Dim client As NexoRetailerClient = CurrentClient()
			If Not IsNothing(client) Then
				Dim o As Object = client.SendRawRequest(command.Text, GetTimeout())
				If Not IsNothing(o) Then
					AddLine(Position.client, Direction.right, "SENDING REQUEST" & MessageLength(command.Text) & vbCrLf & command.Text)
				End If
			End If
		End If
		SetButtons()
	End Sub

	Private Sub pbStartGateway_Click(sender As Object, e As EventArgs) Handles pbStartGateway.Click
		StartGateway()
	End Sub

	Private Sub StartGateway()
		If IsNothing(gateway) Then
			gateway = New CStreamServer() With {.Name = "Gateway"}
		End If
		If Not GatewayIsRunning Then
			gateway.ID = 1
			Dim settings As CStreamServerSettings = CStreamServerSettings.Prepare(gatewayPort.Value)
			Dim threadData As CThreadData = CThreadData.Prepare(Me.Handle,
																				 GATEWAY_STOPPED_MESSAGE,
																				 GATEWAY_INFORMATION_MESSAGE)
			Dim startServerType As CStreamServerStartSettings = CStreamServerStartSettings.Prepare(settings,
																									threadData,
																									AddressOf GatewayOnMessage,
																									AddressOf GatewayOnStart,
																									AddressOf GatewayOnConnect,
																									AddressOf GatewayOnDisconnect,
																									AddressOf GatewayOnStop)
			'AddressOf GatewayOnStop)
			If gateway.StartServer(startServerType) Then
				RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY STARTED"})
			Else
				RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY FAILED TO START"})
			End If
			SetButtons()
		End If
	End Sub

	Private Function GatewayOnMessage(tcp As TcpClient, request As Byte(), ByRef addBufferSize As Boolean, threadData As CThreadData, o As Object) As Byte()
		'the gateway received a request that must be forwarded to the distant server
		Dim settings As New CStreamClientSettings
		If cbGatewayUseLocalHost.Checked Then
			settings.IP = CStream.Localhost
			settings.Port = localServerPort.Value
		Else
			settings.IP = gatewayServerIP.Text
			settings.Port = gatewayServerPort.Value
		End If
		'get the message as a string
		Dim timeout As Boolean
		Dim replySize As Integer
		Dim xmlrequest As String = Encoding.UTF8.GetString(request)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.forwardingRequest, .Message = "FORWARDING REQUEST FROM " & tcp.Client.RemoteEndPoint.ToString & " TO " & settings.FullIP & MessageLength(xmlrequest) & vbCrLf & xmlrequest})
		Dim xmlreply As String = NexoRetailerClient.SendRawRequest(settings, xmlrequest, replySize, timeout)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.receivingForwardedReply, .Message = "FORWARDING REPLY FROM " & settings.FullIP & " TO " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xmlrequest) & vbCrLf & xmlreply})
		'do not forget, we're using nexo hence string messages, the system must add the buffer size when returning the reply
		addBufferSize = True
		Return Encoding.UTF8.GetBytes(xmlreply)
	End Function

	Private Function GatewayOnStart(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY IS STARTING"})
		Return True
	End Function

	Private Function GatewayOnConnect(tcp As TcpClient, threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY CONNECTED"})
		Return True
	End Function

	Private Function GatewayOnDisconnect(tcp As String, threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY CONNECTED"})
		Return True
	End Function

	Private Function GatewayOnStop(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY IS STOPPING"})
		Return True
	End Function

	Private Sub pbStopGateway_Click(sender As Object, e As EventArgs) Handles pbStopGateway.Click
		StopGateway()
	End Sub

	Private Sub StopGateway()
		gateway.StopServer()
		SetButtons()
	End Sub

	Private Sub distantLocalHost_CheckedChanged(sender As Object, e As EventArgs) Handles cbGatewayUseLocalHost.CheckedChanged
		SetButtons()
	End Sub

	Private Sub useGateway_CheckedChanged(sender As Object, e As EventArgs)
		SetButtons()
	End Sub

	Private Sub pbSaveContent_Click(sender As Object, e As EventArgs) Handles pbSaveContent.Click
		SaveContent()
	End Sub

	Private Function SaveContent() As Boolean
		SaveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*"
		SaveFileDialog1.DefaultExt = "rtf"
		SaveFileDialog1.AddExtension = True
		Dim f As Boolean = MsgBoxResult.Ok = SaveFileDialog1.ShowDialog()
		If f Then
			Dim ext As String = Path.GetExtension(SaveFileDialog1.FileName)
			If ext.ToLower = ".rtf" Then
				RichTextBox1.SaveFile(SaveFileDialog1.FileName)
			Else
				RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			End If
			Return True
		End If
		Return False
	End Function

	Private Sub pbSaveSettings_Click(sender As Object, e As EventArgs) Handles pbSaveSettings.Click
		SaveSettings()
	End Sub

	Private Sub pbClear_Click(sender As Object, e As EventArgs) Handles pbClear.Click
		Select Case MsgBox("Save before clearing ?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question)
			Case MsgBoxResult.Yes
				If SaveContent() Then
					RichTextBox1.Clear()
				End If
			Case MsgBoxResult.No
				RichTextBox1.Clear()
			Case MsgBoxResult.Cancel
		End Select
	End Sub

	Private Sub entities_Click(sender As Object, e As EventArgs) Handles lblServer.DoubleClick, lblGateway.DoubleClick, lblClient.DoubleClick, lblServerHeader.DoubleClick, lblGatewayHeader.DoubleClick, lblClientHeader.DoubleClick
		Dim lbl As Label = DirectCast(sender, Label)
		Select Case ColorDialog1.ShowDialog
			Case DialogResult.OK
				SetColors(lbl, ColorDialog1.Color)
		End Select
	End Sub

	Private Sub rbLocalHost_Click(sender As Object, e As EventArgs) Handles rbServer.Click, rbLocalHost.Click, rbGateway.Click
		SetButtons()
	End Sub

	Private Sub cbxConnections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxConnections.SelectedIndexChanged
		CanDisconnect()
	End Sub

	Private Sub CanDisconnect()
		pbDisconnect.Enabled = Not IsNothing(CurrentClient)
	End Sub

	Private Sub pbDisconnect_Click(sender As Object, e As EventArgs) Handles pbDisconnect.Click
		Dim selected As NexoRetailerClient = CurrentClient()
		If RemoveClient(selected) Then
			selected.Disconnect()
			RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "CLIENT " & selected.KeyClient & " IS NOW DISCONNECTED FROM " & selected.KeyServer})
		End If
		SetButtons()
	End Sub

	Private Sub pbRefund_Click(sender As Object, e As EventArgs) Handles pbRefund.Click
		Dim payment As New FAmount
		Select Case payment.ShowDialog
			Case DialogResult.OK
				'create the NexoLogin object
				Dim o As New NexoRefund()
				o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(serviceid.Text)
				o.RequestSaleTransactionID = NexoAutoID.ID
				Dim eur As New NexoCurrencyEUR()
				o.RequestCurrency = eur.Value
				o.RequestRequestedAmount = New NexoSimpleAmount() With {.DecimalPlaces = eur.DecimalPlaces, .AsDecimal = payment.Amount / 100}.AsDecimal
				Dim s As String = o.SerializedRequest
				Dim client As NexoRetailerClient = CurrentClient()
				Dim f As Boolean = True
				If f = Not IsNothing(client) Then
					Dim t As Object = client.SendRequest(o, GetTimeout())
					If f = Not IsNothing(t) Then
					End If
				End If
				If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING REFUND REQUEST" & MessageLength(s) & vbCrLf & s)
				SetButtons()
		End Select
		payment = Nothing
	End Sub

	Private Sub cbInfinite_CheckedChanged(sender As Object, e As EventArgs) Handles cbInfinite.CheckedChanged
		SetButtons()
	End Sub

	Private Sub udServerDelay_ValueChanged(sender As Object, e As EventArgs) Handles udServerDelay.ValueChanged
		If Not IsNothing(nexoServer) Then
			nexoServer.TimerBeforeReply = udServerDelay.Value
		End If
	End Sub

	Private Sub pbDatabaseSettings_Click(sender As Object, e As EventArgs) Handles pbDatabaseSettings.Click
		Dim f As New FServerSettings
		If nexoServer.IsRunning Then
			f.Settings = nexoServer.Settings.DatabaseSettings
		End If
		f.ShowDialog()
		If nexoServer.IsRunning Then
			nexoServer.Settings.DatabaseSettings = f.Settings
		End If
		f.Dispose()
	End Sub

	Private Sub pbBuild_Click(sender As Object, e As EventArgs) Handles pbBuild.Click
		Dim f As New FChoser
		Dim T As Type = Nothing
		If DialogResult.OK = f.ShowDialog() Then
			T = f.nxo
		End If
		f.Dispose()

		If Not IsNothing(T) Then
			Dim g As New FBuilder
			g.T = T
			If DialogResult.OK = g.ShowDialog() Then
			End If
			g.Dispose()
		End If
	End Sub

End Class
