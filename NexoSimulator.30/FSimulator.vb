Imports System.Collections.Generic
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports Microsoft.Win32
Imports System.IO
Imports System.Xml.Serialization
Imports System.Reflection
Imports NEXO
Imports NEXO.Server
Imports NEXO.Client
Imports COMMON
Imports COMMON.ODBC
Imports COMMON.WIN32

Public Class FSimulator

#Region "data"
	Private nexoClients As New NexoRetailerClients
	Private nexoServer As NexoRetailerServer = Nothing
	Private gateway As CStreamServer
	Private Const POIIDToUse As String = "090265130468"
	Private connected As FConnected
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
	Private Const REGISTRY_KEY As String = "HKEY_CURRENT_USER\Software\PMS\NEXO\Simulator"
	Private Const REGISTRY_VALUE_SETTINGS As String = "Settings"
	Private Const SERVER_SETTINGS_FILE_NAME As String = "server.database.json"
	Private Const SETTINGS_FILE_NAME As String = "nexo.simulator"
	Private Const SETTINGS_FILE_EXT As String = ".json"
	Private Const LOG_FILE_EXT As String = ".log"
	Private Const WILDCARD As String = "*"
	Private Const USERVAR As String = "$value$"
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
	Private ConnectionSettings As SettingsConnectionSettings
	Private Class ContextType
		Public Property SaleReferenceID As String
	End Class
	Private context As New ContextType

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
#End Region

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
		Public Property direction As Direction = Direction.none
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

	Private Sub AddLine(position As Position, r As Direction, s As String, Optional reset As Boolean = False)
		Dim dt As DateTime = Now
		Dim start As Integer = RichTextBox1.TextLength
		Dim txt As String = dt.ToString("s") & ": " & s & vbCrLf
		Select Case r
			Case Direction.left
				txt = $"<<< {txt} <<<"
			Case Direction.right
				txt = $">>> {txt} >>>"
			Case Direction.none
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
#End Region

#Region "window management"
	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sfn As String = SettingsFileName()
		json = New CJson(Of Settings)(sfn & SETTINGS_FILE_EXT)
		CLog.LogFileName = sfn & LOG_FILE_EXT

		connected = New FConnected
		connected.Warn = cbConnected
		connected.Visible = False

		'set the default port
		udLocalServerPort.Value = CStreamSettings.DEFAULT_PORT
		LoadSettings()

		'autostart server if requested
		If cbAutostartServer.Checked Then
			StartServer()
		End If
		If cbAutostartGateway.Checked Then
			StartGateway()
		End If

		ToolTip1.SetToolTip(pbResponseFolder, SettingsPath)
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
#End Region

#Region "settings"
	Public Function ServerSettingsFileName() As String
		Return SettingsFileName() & "." & SERVER_SETTINGS_FILE_NAME
	End Function

	Public Function SettingsFileName() As String
		Return SettingsPath() & SETTINGS_FILE_NAME
	End Function

	Public Function SettingsPath() As String
		Dim path As String = Registry.GetValue(REGISTRY_KEY, REGISTRY_VALUE_SETTINGS, ".\")
		If String.IsNullOrEmpty(path) Then
			path = ".\"
		End If
		If path.EndsWith("\") Then
			Return path
		Else
			Return path & "\"
		End If
	End Function

	Public Sub SetSettingsPath(s As String)
		Registry.SetValue(REGISTRY_KEY, REGISTRY_VALUE_SETTINGS, s)
		ToolTip1.SetToolTip(pbResponseFolder, SettingsPath)
	End Sub

	Private Sub LoadSettings()
		Dim except As Boolean
		Dim settings As Settings = json.ReadSettings(except)
		If IsNothing(settings) Then settings = New Settings
		If Not settings Is Nothing Then
			cbAutostartServer.Checked = settings.Autostart
			Try
				udLocalServerPort.Value = settings.LocalPort
			Catch ex As Exception
				udLocalServerPort.Value = 2018
			End Try
			Try
				udTargetPort.Value = settings.Port
			Catch ex As Exception
				udTargetPort.Value = 2018
			End Try
			efSaleID.Text = settings.SaleID
			efServiceID.Text = settings.ServiceID
			efDeviceID.Text = settings.DeviceID
			efPOIID.Text = settings.POIID
			cbConnected.Checked = settings.Connected
			connected.Location = settings.ConnectedLocation
			efTargetIP.Text = settings.IP
			rbLocalHost.Checked = settings.Target = TargetsEnum.localhost
			rbGateway.Checked = settings.Target = TargetsEnum.gateway
			rbServer.Checked = settings.Target = TargetsEnum.server
			Try
				udTimeout.Value = settings.ReceiveTimeout
			Catch ex As Exception
				udTimeout.Value = 30
			End Try
			If Not IsNothing(settings.WindowState) Then Me.WindowState = settings.WindowState
			If Not IsNothing(settings.Location) Then Me.Location = settings.Location
			If Not IsNothing(settings.Size) Then Me.Size = settings.Size

			'available free commands
			cbxCommands.Items.AddRange(settings.Commands.ToArray)
			If 0 < cbxCommands.Items.Count Then
				If 0 <= settings.CommandIndex AndAlso settings.CommandIndex < cbxCommands.Items.Count Then
					cbxCommands.SelectedIndex = settings.CommandIndex
				ElseIf 0 > settings.CommandIndex Then
					cbxCommands.SelectedIndex = 0
				ElseIf cbxCommands.Items.Count <= settings.CommandIndex Then
					cbxCommands.SelectedIndex = cbxCommands.Items.Count - 1
				End If
			Else
				cbxCommands.SelectedIndex = -1
			End If

			Try
				udGatewayPort.Value = settings.GatewayPort
			Catch ex As Exception
				udGatewayPort.Value = CStreamSettings.DEFAULT_PORT
			End Try
			cbGatewayUseLocalHost.Checked = settings.TerminalLocalHost
			efGatewayServerIP.Text = settings.TerminalIP
			udGatewayServerPort.Value = settings.TerminalPort
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
			cbUseJson.Checked = settings.UseJson
			NexoRetailer.UseJson = cbUseJson.Checked
			cbUseDatabase.Checked = settings.UseDatabase

			cbUseConnectionSettings.Checked = settings.UsePreConnection

			ConnectionSettings = settings.ConnectionSettings
			If IsNothing(ConnectionSettings) Then ConnectionSettings = New SettingsConnectionSettings

		End If
	End Sub

	Private Sub SaveSettings()
		Dim settings As Settings = New Settings
		settings.Autostart = cbAutostartServer.Checked
		settings.Port = udTargetPort.Value
		settings.LocalPort = udLocalServerPort.Value
		settings.POIID = efPOIID.Text
		settings.SaleID = efSaleID.Text
		settings.ServiceID = efServiceID.Text
		settings.DeviceID = efDeviceID.Text
		settings.Connected = cbConnected.Checked
		settings.ConnectedLocation = connected.Location
		settings.IP = efTargetIP.Text
		If rbLocalHost.Checked Then
			settings.Target = TargetsEnum.localhost
		ElseIf rbGateway.Checked Then
			settings.Target = TargetsEnum.gateway
		ElseIf rbServer.Checked Then
			settings.Target = TargetsEnum.server
		Else
			settings.Target = TargetsEnum.localhost
		End If
		settings.ReceiveTimeout = udTimeout.Value
		settings.WindowState = Me.WindowState
		settings.Location = Me.Location
		settings.Size = Me.Size

		settings.Commands.Clear()
		For Each command As Command In cbxCommands.Items
			settings.Commands.Add(command)
		Next
		settings.CommandIndex = cbxCommands.SelectedIndex

		settings.GatewayPort = udGatewayPort.Value
		settings.TerminalIP = efGatewayServerIP.Text
		settings.TerminalPort = udGatewayServerPort.Value
		settings.TerminalLocalHost = cbGatewayUseLocalHost.Checked
		settings.ClientColor = lblClient.ForeColor
		settings.GatewayColor = lblGateway.ForeColor
		settings.ServerColor = lblServer.ForeColor
		settings.TextToPrint = TextToPrint
		settings.Infinite = cbInfinite.Checked
		settings.ServerDelay = udServerDelay.Value
		settings.Synchronous = cbSynchronous.Checked
		settings.UseJson = cbUseJson.Checked
		settings.UseDatabase = cbUseDatabase.Checked

		settings.UsePreConnection = cbUseConnectionSettings.Checked
		settings.ConnectionSettings = ConnectionSettings

		json.WriteSettings(settings)
	End Sub
#End Region

#Region "client management"
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
#End Region

#Region "interface management"
	Private Sub SetButtons()
		'server part
		pbStartServer.Enabled = Not ServerIsRunning
		pbStopServer.Enabled = ServerIsRunning
		pbServerActivity.Enabled = ServerIsRunning
		udLocalServerPort.Enabled = Not ServerIsRunning
		AdjustBackColor(lblServer, panelServer, pbStopServer.Enabled)

		'client part
		panelClientTarget.Enabled = rbServer.Checked

		'free commands
		pbSendFreeMessage.Enabled = 0 <> nexoClients.Count
		pbSendRequest.Enabled = pbSendFreeMessage.Enabled
		cbxCommands.Enabled = 0 <> cbxCommands.Items.Count

		'existing buttons
		panelCommandButtons.Enabled = pbSendFreeMessage.Enabled
		CanDisconnect()

		'gateway part
		pbStartGateway.Enabled = Not GatewayIsRunning
		pbStopGateway.Enabled = GatewayIsRunning
		AdjustBackColor(lblGateway, panelGateway, pbStopGateway.Enabled)
		udGatewayPort.Enabled = Not GatewayIsRunning
		cbGatewayUseLocalHost.Enabled = Not GatewayIsRunning
		efGatewayServerIP.Enabled = Not GatewayIsRunning And Not cbGatewayUseLocalHost.Checked
		udGatewayServerPort.Enabled = Not GatewayIsRunning And Not cbGatewayUseLocalHost.Checked

		pbSaveContent.Enabled = 0 <> RichTextBox1.Text.Length

		udTimeout.Enabled = Not cbInfinite.Checked

		'test gateway configuration
		If (cbGatewayUseLocalHost.Checked AndAlso udGatewayPort.Value = udLocalServerPort.Value) Or
		(Not cbGatewayUseLocalHost.Checked AndAlso udGatewayPort.Value = udLocalServerPort.Value AndAlso CStream.Localhost() = efGatewayServerIP.Text) Then
			udGatewayPort.BackColor = Color.Red
		Else
			udGatewayPort.BackColor = SystemColors.Window
		End If

		Text = $"Nexo Simulator v{NexoCurrentVersion.Current.Version} - CLIENT = SaleID: {FullSaleID()} / POIID: {FullPOIID()} - SERVER = "
		If ServerIsRunning Then
			Text &= $"{FullServerPOIID()}"
		Else
			Text = "Inactive"
		End If

		If isClosing Then
			Close()
		End If

		pbBuild.Enabled = 0 < cbxCommands.Items.Count

		pbConnectionSettings.Enabled = cbUseConnectionSettings.Checked
	End Sub

	Private Sub SetProcessing()

		IsProcessing = True
		SetButtons()
	End Sub

	Private Sub ResetProcessing()
		IsProcessing = False
		SetButtons()
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
#End Region

#Region "server management"
	Private Sub pbStartServer_Click(sender As Object, e As EventArgs) Handles pbStartServer.Click
		StartServer()
	End Sub

	Private Function FullServerPOIID()
		Return POIIDToUse & "@" & CStream.Localhost & ":" & udLocalServerPort.Value.ToString
	End Function

	Private Sub StartServer()
		If Not ServerIsRunning Then
			nexoServer = New NexoRetailerServer(cbUseDatabase.Checked)
			Dim settings As New CStreamServerSettings With
				{
				.Port = udLocalServerPort.Value
				}
			Dim threadData As New CThreadData With
				{
				.WindowToWarn = Me.Handle,
				.StoppedMessage = SERVER_STOPPED_MESSAGE,
				.InformationMessage = SERVER_INFORMATION_MESSAGE
				}
			Dim dbSettings As NexoRetailerServerDatabaseSettings = Nothing
			If nexoServer.UseDatabase Then
				dbSettings = NexoRetailerServer.LoadDatabaseSettings(ServerSettingsFileName)
			End If
			Dim startType As New NexoRetailerServerSettings With
						{
						.StreamServerSettings = settings,
						.ThreadData = threadData,
						.OnStart = AddressOf ServerOnStart,
						.OnConnect = AddressOf ServerOnConnect,
						.OnDisconnect = AddressOf ServerOnDisconnect,
						.OnReceivedRequest = AddressOf ServerOnReceivedRequest,
						.OnReceivedReply = AddressOf ServerOnReceivedReply,
						.OnReceivedNotification = AddressOf ServerOnReceivedNotification,
						.OnSend = AddressOf ServerOnSend,
						.OnStop = AddressOf ServerOnStop,
						.DatabaseSettings = dbSettings
						}
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

	Private Function ServerOnConnect(tcp As TcpClient, thread As CThread, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.updateConnected, .Message = "CLIENT CONNECTED (" & tcp.Client.RemoteEndPoint.ToString & ")"})
		Return True
	End Function

	Private Sub ServerOnDisconnect(tcp As String, thread As CThread, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.updateConnected, .Message = "CLIENT DISCONNECTED (" & tcp & ")"})
	End Sub

	Private Function IsRecognized(o As NexoObject, key As SimulatorResponse, allowWildCard As Boolean)
		Return (o.SaleID = key.SaleID AndAlso o.POIID = key.POIID AndAlso Not allowWildCard) OrElse
							(o.SaleID = key.SaleID AndAlso WILDCARD = key.POIID AndAlso allowWildCard) OrElse
							(WILDCARD = key.SaleID AndAlso o.POIID = key.POIID AndAlso allowWildCard) OrElse
							(WILDCARD = key.SaleID AndAlso WILDCARD = key.POIID AndAlso allowWildCard)
	End Function

	Class SimulatorResponse
		Public Index As Integer
		Public SaleID As String
		Public POIID As String
		Public Name As String
		Public Value As Object
		'Public Message As String
		Public XML As String
		Public JSON As String
	End Class
	Class SimulatorResponses
		Inherits List(Of SimulatorResponse)
	End Class

	Private Sub ServerOnReceivedRequest(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, thread As CThread, o As Object)
		'determine category with a name to use to select the response
		Dim cat As String = toprocess.Category.ToString
		If MessageCategoryEnumeration.Payment = toprocess.Category Then
			Dim tmp As NexoPayment = toprocess.CurrentObject
			If PaymentTypeEnumeration.Normal <> tmp.PaymentType Then
				cat = tmp.PaymentType.ToString
			End If
		End If

		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & cat.ToUpper & " REQUEST" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})

		'if the request is proposed declined by the library we do not process the message any further
		If Not toprocess.CurrentObject.Success Then
			Return
		End If

		'if automatic mode let's run with it
		'<<<>>>

		'search the json file containing the response for that message category
		Dim json As New CJson(Of SimulatorResponses)(($"{SettingsFileName()}.response.{cat}.json").ToLower())
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = $"Trying to use {json.FileName}" & vbCrLf})

		'get records from this file
		Dim except As Boolean
		Dim data As SimulatorResponses = json.ReadSettings(except, True)
		If IsNothing(data) AndAlso Not except Then
			'no data at all, create a file with the fields inside for later update
			Dim l As New SimulatorResponses
			l.Add(New SimulatorResponse With
				{
				.SaleID = toprocess.CurrentObject.Request.MessageHeader.SaleID,
				.POIID = toprocess.CurrentObject.Request.MessageHeader.POIID,
				.Name = Nothing,
				.Value = Nothing,
				.XML = Nothing,
				.JSON = Nothing
				})
			l.Add(New SimulatorResponse With
				{
				.SaleID = toprocess.CurrentObject.Request.MessageHeader.SaleID,
				.POIID = toprocess.CurrentObject.Request.MessageHeader.POIID,
				.Name = "any data name",
				.Value = "any value",
				.XML = Nothing,
				.JSON = Nothing
				})
			json.WriteSettings(l, True)
			'nothing else is done, the server decides of the action and simply returns the received message with a failure
			NoAnswer(toprocess)
		ElseIf except Then
			RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = $"INVALID {json.FileName} FILE" & vbCrLf})
			NoAnswer(toprocess)
		Else
			Dim response As SimulatorResponse = Nothing
			Dim secondary As Object = Nothing

			'exact responses (SaleID, POIID, Value)
			'Dim responsesExact = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, False) AndAlso v.Value = secondary Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending
			Dim responsesExact = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, False) AndAlso SearchNamedValue(toprocess.CurrentObject.Request, v.Name, secondary) AndAlso v.Value = secondary Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending, v.Index Descending
			'almost exact (SaleID, POIID)
			Dim responsesAlmost = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, False) Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending, v.Index Descending
			'partial responses (using wildcards, Value)
			Dim responsesPartial = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, True) AndAlso SearchNamedValue(toprocess.CurrentObject.Request, v.Name, secondary) AndAlso v.Value.ToString = secondary.ToString Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending, v.Index Descending
			'partial responses (using wildcards, Value is wildcard too)
			Dim responsesPartialFull = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, True) AndAlso SearchNamedValue(toprocess.CurrentObject.Request, v.Name, secondary) AndAlso v.Value.ToString = WILDCARD Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending, v.Index Descending
			'scarce responses (using wildcards)
			Dim responsesScarce = From v In data Where Not IsNothing(v) AndAlso IsRecognized(toprocess.CurrentObject, v, True) Select v Order By v.SaleID Descending, v.POIID Descending, v.Value Descending, v.Index Descending

			'choose the response to use
			If 0 <> responsesExact.Count Then
				response = responsesExact(0)
			ElseIf 0 <> responsesAlmost.Count Then
				response = responsesAlmost(0)
			ElseIf 0 <> responsesPartial.Count Then
				response = responsesPartial(0)
			ElseIf 0 <> responsesPartialFull.Count Then
				response = responsesPartialFull(0)
			ElseIf 0 <> responsesScarce.Count Then
				response = responsesScarce(0)
			End If

			'do we have a response ?
			If Not IsNothing(response) Then
				Dim sz As String
				If cbUseJson.Checked Then
					sz = response.JSON
				Else
					sz = response.XML
				End If
				If Not IsNothing(sz) Then
					'eventually replace the user var
					If Not IsNothing(secondary) AndAlso Not String.IsNullOrEmpty(secondary.ToString) Then
						sz = sz.Replace(USERVAR, secondary.ToString)
					End If
					'deserialize the response
					Dim item As New NexoItem(sz)
					If item.IsValid Then
						'is the response is valid against the expected message we save it to send it back to the caller
						If toprocess.Category = item.Category Then
							toprocess.CurrentObject.FromItem(item)
							Return
						End If
					End If
				End If
			End If
			'no answer is available, return an error
			NoAnswer(toprocess)
		End If
	End Sub

	Private Sub NoAnswer(toprocess As NexoObjectToProcess)
		'no answer is available, return an error
		toprocess.CurrentObject.Result = ResultEnumeration.Failure
		toprocess.CurrentObject.ErrorCondition = ErrorConditionEnumeration.NotFound
		toprocess.CurrentObject.AdditionalResponse = "[SIMULATOR] No message found to send back for this request"
	End Sub

	Private Sub PrepareReceipt(s As String, clientText As List(Of String), merchantText As List(Of String))

	End Sub

	Private Sub ServerOnReceivedReply(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, thread As CThread, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & toprocess.Type.ToString.ToUpper & " RESPONSE" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Sub ServerOnReceivedNotification(xml As String, toprocess As NexoObjectToProcess, tcp As TcpClient, thread As CThread, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "RECEIVED " & toprocess.Type.ToString.ToUpper & " NOTIFICATION" & " FROM " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Sub ServerOnSend(xml As String, toprocess As NexoItem, tcp As TcpClient, thread As CThread, threadData As CThreadData, o As Object)
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.left, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "SENDING " & toprocess.Type.ToString.ToUpper & " To " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Private Function ServerOnStop(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.server, .Evt = ActivityEvent.receivedRequest, .Message = "SERVER IS STOPPING"})
		Return True
	End Function

	Private Function SearchNamedValue(o As Object, name As String, ByRef value As Object) As Boolean
		If IsNothing(o) OrElse IsNothing(name) Then Return Nothing
		'list all properties inside the object
		Dim properties As List(Of PropertyInfo) = o.GetType().GetProperties().ToList()
		Dim methods As List(Of MethodInfo) = o.GetType().GetMethods().ToList()
		For Each p As PropertyInfo In properties
			If Not p.PropertyType.IsArray AndAlso MemberTypes.Property = p.MemberType AndAlso p.PropertyType.IsPublic AndAlso Not p.Name.StartsWith(NexoXSDStrings.XSD) Then
				Dim pValue As Object = p.GetValue(o, Nothing)
				Dim pValuetype As Type = p.PropertyType
				If Not IsNothing(pValue) Then
					pValuetype = pValue.GetType()
				End If
				If 0 = String.Compare("System", pValuetype.Namespace, True) AndAlso 0 = String.Compare(p.Name, name, True) Then
					'we found the data to use, get its value and return it
					value = p.GetValue(o, Nothing)
					Return True
				ElseIf 0 <> String.Compare("System", pValuetype.Namespace, True) Then
					If SearchNamedValue(pValue, name, value) Then Return True
				End If
			End If
		Next
		Return False
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
#End Region

#Region "client management"
	Private Sub pbConnect_Click(sender As Object, e As EventArgs) Handles pbConnect.Click
		If cbUseConnectionSettings.Checked Then
			If MsgBoxResult.No = MsgBox($"Beware you're trying to connect using pre-connexion settings.{vbCrLf}Do you wish to continue ?", MsgBoxStyle.YesNo) Then
				Return
			End If
		End If
		ResetPreConnection()
		Dim nexoClient As New NexoRetailerClient
		Dim settings As New CStreamClientSettings
		If rbLocalHost.Checked Then
			settings.IP = CStream.Localhost()
			settings.Port = udLocalServerPort.Value
		ElseIf rbGateway.Checked Then
			settings.IP = CStream.Localhost()
			settings.Port = udGatewayPort.Value
		Else
			settings.IP = efTargetIP.Text
			settings.Port = udTargetPort.Value
		End If
		'specific connection settings
		Dim csettings As New NexoRetailerClientConnectionSettings() With
			{
			.OnConnectionRequest = AddressOf ClientOnConnectionRequest,
			.OnConnectionReply = AddressOf ClientOnConnectionReply,
			.ConnectionTimer = ConnectionSettings.ConnectionTimer
			}
		If cbUseConnectionSettings.Checked Then
			If ConnectionSettings.UseCertificate Then
				settings.ServerName = ConnectionSettings.ServerName
			End If
			settings.AllowedSslErrors = ConnectionSettings.AllowedSslErrors
		Else
			csettings = Nothing
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
			.ThreadData = New CThreadData() With
				{
				.WindowToWarn = Me.Handle,
				.StoppedMessage = CLIENT_STOPPED_MESSAGE,
				.InformationMessage = CLIENT_INFORMATION_MESSAGE
				},
			.ConnectionSettings = csettings,
			.Parameters = Nothing
			}
		Cursor.Current = Cursors.WaitCursor
		If nexoClient.Connect(nexoRetailerClientSettings) Then
			If AddClient(nexoClient) Then
				RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "CLIENT " & nexoClient.KeyClient & " IS CONNECTED TO " & nexoClient.KeyServer})
			End If
		Else
			MessageBox.Show("Connection to " & settings.FullIP & " has failed")
		End If
		Cursor.Current = Cursors.Default
		SetButtons()
	End Sub

	Public Function ClientOnConnectionRequest(settings As CStreamClientSettings) As Object
		Return ConnectionSettings.RequestString
	End Function

	<Serializable, XmlRoot(ElementName:="connect")>
	Class ConnectReply
		Public Property status As Integer
	End Class
	Private Const CONNECT_STATUS_OK As Integer = 0
	Private Const CONNECT_STATUS_KO As Integer = -1
	Public Function ClientOnConnectionReply(o As Object) As Boolean
		If Not IsNothing(o) Then
			'deserialize the request
			Dim xml As String = o.ToString()
			efConnectionReply.Text = xml
			Try
				Dim reply As ConnectReply = NexoRetailer.XmlDeserialize(Of ConnectReply)(xml, cbUseJson.Checked, False)
				If 0 = reply.status Then
					efConnectionReply.BackColor = Color.LightGreen
					Return True
				Else
					efConnectionReply.BackColor = Color.Crimson
				End If
			Catch ex As Exception
				efConnectionReply.BackColor = Color.Crimson
			End Try
		Else
			efConnectionReply.BackColor = Color.Crimson
		End If
		Return False
	End Function

	Public Sub ClientOnSend(xml As String, obj As NexoItem, tcp As TcpClient, thread As CThread, threadData As CThreadData, o As Object)
		Dim s As String = obj.Category.ToString
		If MessageCategoryEnumeration.Payment = obj.Category Then
			Dim f As New NexoPayment()
			f.FromItem(obj)
			If PaymentTypeEnumeration.Normal <> f.PaymentType Then
				's = CMisc.GetEnumName(PaymentTypeEnumeration, f.PaymentType)
				s = $"{f.PaymentType}"
			End If
		End If
		RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.right, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SENDING " & s.ToUpper & " " & obj.Type.ToString.ToUpper & " TO " & tcp.Client.RemoteEndPoint.ToString & MessageLength(xml) & vbCrLf & xml})
	End Sub

	Public Sub ClientOnReceived(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, thread As CThread, o As Object)
		Dim msg As String = String.Empty
		Dim activity As ActivityEvent = ActivityEvent.none

		Dim s As String = obj.Type.ToString
		If MessageCategoryEnumeration.Payment = obj.Category Then
			Dim f As New NexoPayment()
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
							If Not IsNothing(nxo.Response) AndAlso nxo.Success Then
								RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SALEID IS CONNECTED (" & nxo.SaleID & ")"})
							Else
								RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SALEID IS NOT CONNECTED (" & nxo.SaleID & ")"})
							End If
						Case MessageCategoryEnumeration.Logout
							Dim nxo As NexoLogout = obj.CurrentObject
							RichTextBox1.Invoke(myDelegate, New Activity() With {.direction = Direction.none, .position = Position.client, .Evt = ActivityEvent.updateConnected, .Message = "SALEID HAS BEEN DISCONNECTED (" & nxo.SaleID & ")"})
					End Select
			End Select
		End If
	End Sub

	Public Sub ClientOnSentRequestStatusChanged(xml As String, obj As NexoObjectToProcess, status As NexoMessageStatus, tcp As TcpClient, thread As CThread, o As Object)
		Dim s As String = Nothing
		Select Case status
			Case NexoMessageStatus.timeout
				s = "TIMED OUT"
			Case NexoMessageStatus.cancelled
				s = "WAS CANCELLED BY USER"
		End Select
		RichTextBox1.Invoke(myDelegate, New Activity() With
								  {
								  .direction = Direction.none,
								  .position = Position.client,
								  .Evt = ActivityEvent.updateConnected,
								  .Message = "??? SENT MESSAGE " & obj.Category.ToString.ToUpper & " " & obj.Type.ToString.ToUpper & " TO " & tcp.Client.RemoteEndPoint.ToString & " " & s & " AND HAS BEEN DISMISSED" & MessageLength(xml) & " ???" & vbCrLf & xml
								  })

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
			Return udTimeout.Value
		End If
	End Function
#End Region

#Region "gateway management"
	Private Sub pbStartGateway_Click(sender As Object, e As EventArgs) Handles pbStartGateway.Click
		StartGateway()
	End Sub

	Private Sub pbStopGateway_Click(sender As Object, e As EventArgs) Handles pbStopGateway.Click
		StopGateway()
	End Sub

	Private Sub StopGateway()
		gateway.StopServer()
		SetButtons()
	End Sub

	Private Sub StartGateway()
		If IsNothing(gateway) Then
			gateway = New CStreamServer() With {.Name = "Gateway"}
		End If
		If Not GatewayIsRunning Then
			gateway.ID = 1
			Dim settings As New CStreamServerSettings With {.Port = udGatewayPort.Value}
			Dim threadData As New CThreadData With {.WindowToWarn = Me.Handle, .StoppedMessage = GATEWAY_STOPPED_MESSAGE, .InformationMessage = GATEWAY_INFORMATION_MESSAGE}
			Dim startServerType As New CStreamServerStartSettings With
				{
				.StreamServerSettings = settings,
				.ThreadData = threadData,
				.OnMessage = AddressOf GatewayOnMessage,
				.OnStart = AddressOf GatewayOnStart,
				.OnConnect = AddressOf GatewayOnConnect,
				.OnDisconnect = AddressOf GatewayOnDisconnect,
				.OnStop = AddressOf GatewayOnStop
				}
			'AddressOf GatewayOnStop)
			If gateway.StartServer(startServerType) Then
				RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY STARTED"})
			Else
				RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY FAILED TO START"})
			End If
			SetButtons()
		End If
	End Sub

	Private Function GatewayOnMessage(tcp As TcpClient, request As Byte(), ByRef addBufferSize As Boolean, thread As CThread, parameters As Object, ox As Object) As Byte()
		'the gateway received a request that must be forwarded to the distant server
		Dim settings As New CStreamClientSettings
		If cbGatewayUseLocalHost.Checked Then
			settings.IP = CStream.Localhost
			settings.Port = udLocalServerPort.Value
		Else
			settings.IP = efGatewayServerIP.Text
			settings.Port = udGatewayServerPort.Value
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

	Private Function GatewayOnConnect(tcp As TcpClient, thread As CThread, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY CONNECTED"})
		Return True
	End Function

	Private Function GatewayOnDisconnect(tcp As String, thread As CThread, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY CONNECTED"})
		Return True
	End Function

	Private Function GatewayOnStop(threadData As CThreadData, o As Object) As Boolean
		RichTextBox1.Invoke(myDelegate, New Activity() With {.position = Position.gateway, .Evt = ActivityEvent.message, .Message = "GATEWAY IS STOPPING"})
		Return True
	End Function
#End Region

#Region "free commands management"
	Private Sub pbFree_Click(sender As Object, e As EventArgs) Handles pbSendFreeMessage.Click, pbSendRequest.Click
		If Not String.IsNullOrEmpty(efCommand.Text) Then
			Dim client As NexoRetailerClient = CurrentClient()
			If Not IsNothing(client) Then
				If DirectCast(sender, Button).Equals(pbSendFreeMessage) Then
					Dim o As Object = client.SendRawRequest(efCommand.Text, GetTimeout(), False)
					If Not IsNothing(o) Then
						'AddLine(Position.client, Direction.right, "SENDING REQUEST" & MessageLength(command.Text) & vbCrLf & command.Text)
					End If
				Else
					Dim item As New NexoItem(efCommand.Text)
					If item.IsValid AndAlso item.IsRequest Then
						Dim o As NexoObject = NexoItem.AllocateObject(item.Category)
						o.FromItem(item)
						o.SaleID = FullSaleID()
						o.POIID = FullPOIID()
						o.ServiceID = CMisc.Trimmed(efServiceID.Text)
						If (item.IsDevice) Then
							o.DeviceID = CMisc.Trimmed(efDeviceID.Text)
						End If
						Dim ox As Object = client.SendRawRequest(o.SerializedRequest, GetTimeout())
						'Dim t = client.SendRequest(o.Request)
						'If IsNothing(t) Then
						'	AddLine(Position.client, Direction.none, $"ERROR SENDING {item.Category} REQUEST" & MessageLength(item.XML) & vbCrLf & item.XML)
						'End If
					End If
				End If
			End If
		End If
		SetButtons()
	End Sub

	Private Sub pbAdd_Click(sender As Object, e As EventArgs) Handles pbAdd.Click
		AddCommand()
	End Sub

	Private Sub cbxCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCommands.SelectedIndexChanged
		If -1 <> cbxCommands.SelectedIndex Then
			efCommand.Text = DirectCast(cbxCommands.Items(cbxCommands.SelectedIndex), Command).Command
		Else
			EraseCommand()
		End If
		SetButtons()
	End Sub

	Private Sub pbRemove_Click(sender As Object, e As EventArgs) Handles pbRemove.Click
		If 0 < cbxCommands.Items.Count Then
			RemoveCommand()
		End If
	End Sub

	Private Sub SaveCommand(index As Integer)
		If -1 <> index Then
			DirectCast(cbxCommands.Items(index), Command).Name = cbxCommands.Text
			DirectCast(cbxCommands.Items(index), Command).Command = efCommand.Text
		End If
	End Sub

	Private Sub EraseCommand()
		cbxCommands.Text = Nothing
		efCommand.Text = Nothing
	End Sub

	Private Sub AddCommand()
		cbxCommands.SelectedIndex = cbxCommands.Items.Add(New Command With {.Name = $"item {cbxCommands.Items.Count + 1}", .Command = Nothing, .UseJson = cbUseJson.Checked})
		SetButtons()
	End Sub

	Private Sub RemoveCommand()
		Dim index As Integer = cbxCommands.SelectedIndex
		If -1 <> index Then
			cbxCommands.Items.RemoveAt(index)
			If 0 < cbxCommands.Items.Count Then
				If cbxCommands.Items.Count >= index + 1 Then
					cbxCommands.SelectedIndex = index
				Else
					cbxCommands.SelectedIndex = cbxCommands.Items.Count - 1
				End If
			Else
				cbxCommands.SelectedIndex = -1
				EraseCommand()
			End If
		End If
		SetButtons()
	End Sub

	Private Sub cbxCommands_EnabledChanged(sender As Object, e As EventArgs) Handles cbxCommands.EnabledChanged
		efCommand.Enabled = cbxCommands.Enabled
		pbRemove.Enabled = cbxCommands.Enabled
	End Sub

	Private Sub NameCommand()
		If -1 <> cbxCommands.SelectedIndex Then
			Dim f As New FInput
			f.Caption = "Please name your command"
			f.Invite = $"{f.Caption}:"
			f.Input = DirectCast(cbxCommands.Items(cbxCommands.SelectedIndex), Command).Name
			Select Case f.ShowDialog
				Case DialogResult.OK
					DirectCast(cbxCommands.Items(cbxCommands.SelectedIndex), Command).Name = f.Input
					DirectCast(cbxCommands.Items(cbxCommands.SelectedIndex), ComboBox).Refresh()
			End Select
		End If
	End Sub

	Private Function ReplaceChars(orig As String, toreplace As String, replacedby As String)
		If orig.Contains(toreplace) Then
			orig = orig.Replace(toreplace, replacedby)
		End If
		Return orig
	End Function

	Private Sub efCommand_TextChanged(sender As Object, e As EventArgs) Handles efCommand.TextChanged
		Dim s As String = efCommand.Text
		Dim pos As Integer = efCommand.SelectionStart
		s = ReplaceChars(s, "\""", """")
		s = ReplaceChars(s, Chars.CR, "")
		s = ReplaceChars(s, Chars.LF, "")
		s = ReplaceChars(s, Chars.TAB, "")
		efCommand.Text = s
		Try
			efCommand.SelectionStart = pos - 1
		Catch ex As Exception
			efCommand.SelectionStart = 0
		End Try
		If -1 <> cbxCommands.SelectedIndex Then
			DirectCast(cbxCommands.Items(cbxCommands.SelectedIndex), Command).Command = efCommand.Text
		End If
	End Sub

	Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
		NameCommand()
	End Sub

	Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
		e.Cancel = -1 = cbxCommands.SelectedIndex
	End Sub

	Private Sub pbBuild_Click(sender As Object, e As EventArgs) Handles pbBuild.Click
		Dim cmd As Command = cbxCommands.Items(cbxCommands.SelectedIndex)
		Dim f As New FChooser With {.Data = cmd.Command}
		If String.IsNullOrEmpty(f.Data) Then
			f.UseJson = NexoRetailer.UseJson
		Else
			f.UseJson = cmd.UseJson
		End If
		f.ShowDialog()
		If Not String.IsNullOrEmpty(f.Data) Then
			cmd.UseJson = f.UseJson
			cmd.Command = f.Data
			cbxCommands.Items(cbxCommands.SelectedIndex) = cmd
			efCommand.Text = cmd.Command
			NexoRetailer.UseJson = cmd.UseJson
			cbUseJson.Checked = NexoRetailer.UseJson
		End If
		f.Dispose()
	End Sub
#End Region

#Region "nexo pre-defined messages"
	Private Sub pbLogin_Click(sender As Object, e As EventArgs) Handles pbLogin.Click
		'create the NexoLogin object
		Dim o As New NexoLogin()
		'o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(efServiceID.Text)
		o.RequestApplicationName = Environment.MachineName
		o.RequestManufacturerID = Environment.MachineName
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
		'o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(efServiceID.Text)
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
		'o.OptimizeXml = cbOptimize.Checked
		o.SaleID = FullSaleID()
		o.POIID = FullPOIID()
		o.ServiceID = CMisc.Trimmed(efServiceID.Text)
		o.DeviceID = CMisc.Trimmed(efDeviceID.Text)
		o.RequestDevice = DeviceEnumeration.CashierInput
		o.RequestInfoQualify = InfoQualifyEnumeration.Document
		o.RequestInputCommand = InputCommandEnumeration.TextString
		Dim deviceTimeout As Integer = udTimeout.Value
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
			Case DialogResult.Yes
				TextToPrint = p.TextToPrint
				'create the NexoLogin object
				Dim o As New NexoDevicePrint()
				'o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(efServiceID.Text)
				o.DeviceID = CMisc.Trimmed(efDeviceID.Text)
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
				'o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(efServiceID.Text)
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

	Private Sub pbRefund_Click(sender As Object, e As EventArgs) Handles pbRefund.Click
		Dim payment As New FAmount
		Select Case payment.ShowDialog
			Case DialogResult.OK
				'create the NexoLogin object
				Dim o As New NexoPayment(PaymentTypeEnumeration.Refund)
				'o.OptimizeXml = cbOptimize.Checked
				o.SaleID = FullSaleID()
				o.POIID = FullPOIID()
				o.ServiceID = CMisc.Trimmed(efServiceID.Text)
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

	Private Sub pbReversal_Click(sender As Object, e As EventArgs) Handles pbReversal.Click
		'Dim payment As New FAmount
		'Select Case payment.ShowDialog
		'	Case DialogResult.OK
		'		'create the NexoLogin object
		'		Dim o As New NexoReversal()
		'		o.OptimizeXml = cbOptimize.Checked
		'		o.SaleID = FullSaleID()
		'		o.POIID = FullPOIID()
		'		o.ServiceID = CMisc.Trimmed(efServiceID.Text)
		'		o.RequestSaleTransactionID = NexoAutoID.ID
		'		Dim eur As New NexoCurrencyEUR()
		'		o.RequestCurrency = eur.Value
		'		o.RequestRequestedAmount = New NexoSimpleAmount() With {.DecimalPlaces = eur.DecimalPlaces, .AsDecimal = payment.Amount / 100}.AsDecimal
		'		Dim s As String = o.SerializedRequest
		'		Dim client As NexoRetailerClient = CurrentClient()
		'		Dim f As Boolean = True
		'		If f = Not IsNothing(client) Then
		'			Dim t As Object = client.SendRequest(o, GetTimeout())
		'			If f = Not IsNothing(t) Then
		'			End If
		'		End If
		'		If Not f Then AddLine(Position.client, Direction.none, "ERROR SENDING REFUND REQUEST" & MessageLength(s) & vbCrLf & s)
		'		SetButtons()
		'End Select
		'payment = Nothing
	End Sub
#End Region

#Region "pre-connection management"
	Private Sub ResetPreConnection()
		efConnectionReply.BackColor = SystemColors.Window
	End Sub

	Private Sub cbPreConnect_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseConnectionSettings.CheckedChanged
		ResetPreConnection()
		SetButtons()
	End Sub

	Private Sub pbPreConnectionSettings_Click(sender As Object, e As EventArgs) Handles pbConnectionSettings.Click
		Dim f As New FConnectionSettings
		f.Settings = ConnectionSettings
		Select Case f.ShowDialog()
			Case DialogResult.OK
				ConnectionSettings = f.Settings
		End Select
		f.Dispose()
	End Sub
#End Region

#Region "miscellaneous"
	Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
		Close()
	End Sub

	Private Sub saleID_TextChanged(sender As Object, e As EventArgs) Handles efSaleID.TextChanged
		SetButtons()
	End Sub

	Private Sub cbConnected_CheckedChanged(sender As Object, e As EventArgs) Handles cbConnected.CheckedChanged
		connected.Visible = cbConnected.Checked
	End Sub

	Private Sub localIP_CheckedChanged(sender As Object, e As EventArgs)
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

	Private Sub cbInfinite_CheckedChanged(sender As Object, e As EventArgs) Handles cbInfinite.CheckedChanged
		SetButtons()
	End Sub

	Private Sub udServerDelay_ValueChanged(sender As Object, e As EventArgs) Handles udServerDelay.ValueChanged
		If Not IsNothing(nexoServer) Then
			nexoServer.TimerBeforeReply = udServerDelay.Value
		End If
	End Sub

	Private Sub cbOptimize_CheckedChanged(sender As Object, e As EventArgs) Handles cbOptimize.CheckedChanged
		If Not cbOptimize.Checked Then
			Select Case MsgBox("Are you sure you want to disable optimisation ? Not optimised messages may generate errors when received.",
									 MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question)
				Case MsgBoxResult.No
					cbOptimize.Checked = True
			End Select
		End If
	End Sub

	Private Sub cbUseJson_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseJson.CheckedChanged
		NexoRetailer.UseJson = cbUseJson.Checked
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles pbResponseFolder.Click
		FolderBrowserDialog1.SelectedPath = SettingsPath()
		If DialogResult.OK = FolderBrowserDialog1.ShowDialog Then
			SetSettingsPath(FolderBrowserDialog1.SelectedPath)
		End If
	End Sub

#End Region

End Class
