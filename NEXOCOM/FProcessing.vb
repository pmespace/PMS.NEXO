Imports System.Drawing
Imports System.Windows.Forms
Imports NEXO
Imports NEXO.Client
Imports COMMON
Imports System.Net.Sockets
Imports System.Threading

#Const NOCOLOR = True


Public Class FProcessing

	Public Enum ProcessingResult
		_none
		accepted
		declined
	End Enum
	Public Response As ResponseType = New ResponseType
	Public Result As ProcessingResult = ProcessingResult._none

	Private Const HEADER As String = "Processing Window: "
	Private nexoCom As NEXOCOM
	Private actionToPerform As Action
	Private actionIsComplete As Boolean = False
	Private timerToUse As UInteger = CStreamClientSettings.NO_TIMEOUT
	Private amountToUse As Decimal
	Private Const CANCEL_BUTTON_TEXT As String = "Cancel"
	Private Const CLOSE_BUTTON_TEXT As String = "Close"
	Private fOK As Boolean
	Private back As Color, fore As Color
	Private globalTicks As Integer = 0
	Private stackOfActions As Stack(Of Action) = New Stack(Of Action)
	Private currentAction As Action
	Private Const ONE_SECOND As Integer = 1000
	Private myLock As Object = New Object

	Private Property Caption As String
		Get
			Return _caption
		End Get
		Set(value As String)
			_caption = CLog.Add(HEADER & value).ToUpper
			If Not String.IsNullOrEmpty(_caption) Then
				Me.Text = _caption
			End If
		End Set
	End Property
	Private _caption As String = Nothing

	Private canStart As Boolean = False

	Private Property canBeCancelled As Boolean
		Get
			Return canStart AndAlso _canbecancelled
		End Get
		Set(value As Boolean)
			_canbecancelled = value
		End Set
	End Property
	Private _canbecancelled As Boolean = False

	Private Property isComplete As Boolean
		Get
			Return _iscomplete
		End Get
		Set(value As Boolean)
			Monitor.Enter(myLock)
			Try
				If value AndAlso Not hasBeenCancelled And Not hasTimedOut Then
					_iscomplete = True
					canBeCancelled = False
				Else
					_iscomplete = False
				End If
			Catch ex As Exception
			Finally
				Monitor.Exit(myLock)
			End Try
		End Set
	End Property
	Private _iscomplete As Boolean = False

	Private Property hasTimedOut As Boolean
		Get
			Return canStart AndAlso _hastimedout
		End Get
		Set(value As Boolean)
			Monitor.Enter(myLock)
			Try
				If value AndAlso Not hasBeenCancelled And Not isComplete Then
					_hastimedout = True
					canBeCancelled = False
				Else
					_hastimedout = False
				End If
			Catch ex As Exception
			Finally
				Monitor.Exit(myLock)
			End Try
		End Set
	End Property
	Private _hastimedout As Boolean = False

	Private Property hasBeenCancelled As Boolean
		Get
			Return canStart AndAlso _hasbeencancelled
		End Get
		Set(value As Boolean)
			Monitor.Enter(myLock)
			Try
				If value AndAlso Not hasTimedOut And Not isComplete Then
					_hasbeencancelled = True
					canBeCancelled = False
				Else
					_hasbeencancelled = False
				End If
			Catch ex As Exception
			Finally
				Monitor.Exit(myLock)
			End Try
		End Set
	End Property
	Private _hasbeencancelled As Boolean = False

	Private Const RESULT_OK As Integer = 0
	Private Const RESULT_KO As Integer = 1

	Private Const WM_BASE As UInteger = Win32.WM_USER + 209
	Private Const WM_START As UInteger = WM_BASE + 1
	Private Const WM_STOP As UInteger = WM_BASE + 2
	Private Const WM_ACTION As UInteger = WM_BASE + 50
	Private Const WM_RECEIVED As UInteger = WM_START + 100
	Private Const WM_TIMER As UInteger = WM_START + 150
	Private Const WM_ERROR As UInteger = WM_START + 200

	Private Const WM_LOGIN As UInteger = WM_ACTION + 1
	Private Const WM_LOGOUT As UInteger = WM_ACTION + 2
	Private Const WM_PAYMENT As UInteger = WM_ACTION + 3
	Private Const WM_REFUND As UInteger = WM_ACTION + 4
	Private Const WM_REVERSAL As UInteger = WM_ACTION + 5

	Private Const WM_RECEIVED_REPLY As UInteger = WM_RECEIVED + 1
	Private Const WM_RECEIVED_REQUEST As UInteger = WM_RECEIVED + 2
	Private Const WM_RECEIVED_NOTIFICATION As UInteger = WM_RECEIVED + 3

	Private Const WM_START_TIMEOUT_TIMER As UInteger = WM_TIMER + 1
	Private Const WM_TIMEOUT As UInteger = WM_TIMER + 2
	Private Const WM_START_AUTOCLOSE_TIMER As UInteger = WM_TIMER + 3
	Private Const WM_AUTOCLOSE As UInteger = WM_TIMER + 4

	Public Enum Action
		_begin = -1
		_none
		payment
		refund
		login
		logout
		reversal
		_end
	End Enum

#Region "serverThread management"
	Private Enum ActivityEvent
		_none
		starting
		stopping
		notificationSent
		notificationReceived
		requestSent
		requestReceived
		replySent
		replyReceived
		timerTimout
		timerAutoclose
		message
	End Enum
	Private Class Activity
		Public Property Evt As ActivityEvent = ActivityEvent._none
		Public Property Message As String = Nothing
	End Class
	Private Delegate Sub AddActivity(Activity As Activity)
	Private myDelegate As AddActivity = New AddActivity(AddressOf ProcessUI)

	Private Sub ProcessUI(activity As Activity)
		If ActivityEvent._none <> activity.Evt Then
			If Not IsNothing(activity.Message) Then
				message.Text = activity.Message
			End If
			Select Case activity.Evt
				Case ActivityEvent.stopping
			End Select
		End If
	End Sub

#End Region

	Public Sub New(ByRef a As NEXOCOM, action As Action, timer As UInteger, Optional amount As Decimal = 0, Optional txnRef As String = Nothing)
		MyBase.New
		InitializeComponent()
		nexoCom = a
		nexoCom.NexoClient.Settings.OnSentRequestStatusChanged = AddressOf OnSentRequestError
		nexoCom.NexoClient.Settings.OnReceivedNotification = AddressOf OnReceivedNotification
		nexoCom.NexoClient.Settings.OnReceivedRequest = AddressOf OnReceivedRequest
		nexoCom.NexoClient.Settings.OnReceivedReply = AddressOf OnReceivedReply
		canBeCancelled = Not nexoCom.Settings.Synchronous

		'set the stack of actions to perform
		If Action._begin < action AndAlso Action._end > action Then
			'the action is known and can be processed
			stackOfActions.Push(action)
			If Action.login = action Then
				If nexoCom.NexoClient.Connected Then
					stackOfActions.Pop()
				End If
			ElseIf Action.logout = action Then
				If Not nexoCom.NexoClient.Connected Then
					stackOfActions.Pop()
				End If
			ElseIf Not nexoCom.NexoClient.Connected Then
				stackOfActions.Push(Action.login)
			End If
		End If
		canStart = 0 <> stackOfActions.Count
		amountToUse = amount
	End Sub

	Private Sub PostMessage(msg As UInteger, Optional wparam As Integer = 0, Optional lparam As Integer = 0)
		Win32.PostMessage(Me.Handle, msg, wparam, lparam)
	End Sub

	Private Sub SendMessage(msg As UInteger, Optional wparam As Integer = 0, Optional lparam As Integer = 0)
		Win32.SendMessage(Me.Handle, msg, wparam, lparam)
	End Sub

	Private Sub FProcessing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		nexoCom.SetOwner(Me)
		message.Text = ""
		information.Text = ""
		back = message.BackColor
		fore = message.ForeColor
		If nexoCom.Settings.Synchronous Then
			pbCancel.Text = CLOSE_BUTTON_TEXT
		Else
			pbCancel.Text = CANCEL_BUTTON_TEXT
		End If
		'start processing
		If canStart Then
			PostMessage(WM_START)
		Else
			PostMessage(WM_STOP)
		End If
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case (m.Msg)
			Case WM_START
				Caption = "STARTING PROCESSING"
				timerGlobal = New Windows.Forms.Timer
				timerGlobal.Interval = ONE_SECOND
				timerGlobal.Start()
				PostMessage(WM_ACTION)

			Case WM_STOP
				Caption = "STOPPING PROCESSING"
				DialogResult = DialogResult.Abort
				Close()

			Case WM_ERROR
				Dim s As String = "Invalid action (" & currentAction.ToString & ") to perform" & vbCrLf & "Operation is cancelled"
				CLog.Add(HEADER & s, TLog.ERROR)
				message.Text = s

			Case WM_ACTION
				Try
					currentAction = stackOfActions.Pop()
				Catch ex As Exception
					currentAction = Action._none
				End Try
				Dim t As Integer = timerToUse
				'will be false only if the action can't be processed
				Dim f As Boolean = Not IsNothing(currentAction)
				If f Then
					Select Case currentAction
						Case Action.login
							PostMessage(WM_LOGIN)
						Case Action.logout
							PostMessage(WM_LOGOUT)
						Case Action.payment
							If nexoCom.Settings.Synchronous Then t = nexoCom.Settings.MaxTimer * 60 * ONE_SECOND
							PostMessage(WM_PAYMENT)
						Case Action.refund
							If nexoCom.Settings.Synchronous Then t = nexoCom.Settings.MaxTimer * 60 * ONE_SECOND
							PostMessage(WM_REFUND)
						Case Action.reversal
							PostMessage(WM_REVERSAL)
						Case Else
							f = False
					End Select
					'if the action can be processed
					If f Then
						isComplete = False
						hasTimedOut = False
						hasBeenCancelled = False
						timerBeforeTimeout = New Windows.Forms.Timer()
						timerBeforeTimeout.Tag = t
						timerBeforeTimeout.Interval = ONE_SECOND
					Else
						PostMessage(WM_AUTOCLOSE)
					End If
				End If

			Case WM_LOGIN
				Me.Text = Caption = "LOGGING IN SALE " & nexoCom.Settings.SaleID & " TO " & nexoCom.Settings.POIID
				pbCancel.Enabled = Not nexoCom.Settings.Synchronous
				Dim o As New NexoLogin()
				o.SaleID = nexoCom.Settings.SaleID
				o.POIID = nexoCom.Settings.POIID
				o.RequestApplicationName = nexoCom.Settings.ApplicationName
				o.RequestManufacturerID = nexoCom.Settings.ManufacturerName
				o.ProtocolVersion = New NexoProtocolVersion().DefaultValue
				o.RequestData.OperatorID = New NexoOperatorID().DefaultValue
				o.RequestCertificationCode = "NotCertified"
				o.RequestSoftwareVersion = nexoCom.Settings.SoftwareVersion
				Dim result As NexoRetailerClientHandle = nexoCom.NexoClient.SendRequest(o, timerToUse)
				If Not IsNothing(result) Then
					SendMessage(WM_START_TIMEOUT_TIMER)
				End If

			Case WM_LOGOUT
				Me.Text = Caption = "LOGGING OUT SALE " & nexoCom.Settings.SaleID & " FROM " & nexoCom.Settings.POIID
				pbCancel.Enabled = Not nexoCom.Settings.Synchronous
				Dim o As New NexoLogout()
				o.SaleID = nexoCom.Settings.SaleID
				o.POIID = nexoCom.Settings.POIID
				Dim result As NexoRetailerClientHandle = nexoCom.NexoClient.SendRequest(o, timerToUse)
				If Not IsNothing(result) Then
					SendMessage(WM_START_TIMEOUT_TIMER)
				End If

			Case WM_PAYMENT
				Me.Text = Caption = "PAYMENT FROM SALE " & nexoCom.Settings.SaleID & " TO " & nexoCom.Settings.POIID
				pbCancel.Enabled = Not nexoCom.Settings.Synchronous
				Dim o As New NexoPayment()
				o.SaleID = nexoCom.Settings.SaleID
				o.POIID = nexoCom.Settings.POIID
				o.RequestSaleTransactionID = NexoAutoID.ID
				o.RequestCurrency = New NexoCurrency() With {.Value = nexoCom.Settings.Currency}.Value
				o.RequestRequestedAmount = New NexoSimpleAmount() With {.DecimalPlaces = nexoCom.Settings.Decimals, .AsDecimal = amountToUse / 10 ^ nexoCom.Settings.Decimals}.AsDecimal
				Dim result As NexoRetailerClientHandle = nexoCom.NexoClient.SendRequest(o, timerToUse)
				If Not IsNothing(result) Then
					If pbCancel.Enabled Then
						SendMessage(WM_START_TIMEOUT_TIMER)
					Else
					End If
				End If

			Case WM_REFUND
				Me.Text = Caption = "REFUND FROM SALE " & nexoCom.Settings.SaleID & " TO " & nexoCom.Settings.POIID
				pbCancel.Enabled = Not nexoCom.Settings.Synchronous
				Dim o As New NexoRefund()
				o.SaleID = nexoCom.Settings.SaleID
				o.POIID = nexoCom.Settings.POIID
				o.RequestSaleTransactionID = NexoAutoID.ID
				o.RequestCurrency = New NexoCurrency() With {.Value = nexoCom.Settings.Currency}.Value
				o.RequestRequestedAmount = New NexoSimpleAmount() With {.DecimalPlaces = nexoCom.Settings.Decimals, .AsDecimal = amountToUse / 10 ^ nexoCom.Settings.Decimals}.AsDecimal
				Dim result As NexoRetailerClientHandle = nexoCom.NexoClient.SendRequest(o, timerToUse)
				If Not IsNothing(result) Then
					If pbCancel.Enabled Then
						SendMessage(WM_START_TIMEOUT_TIMER)
					Else
					End If
				End If

			Case WM_START_TIMEOUT_TIMER
				timerBeforeTimeout = New Windows.Forms.Timer
				timerBeforeTimeout.Interval = ONE_SECOND
				timerBeforeTimeout.Start()

			Case WM_TIMEOUT
				SendMessage(WM_START_AUTOCLOSE_TIMER)

			Case WM_START_AUTOCLOSE_TIMER
				pbCancel.Enabled = True
				pbCancel.Focus()
				If (hasTimedOut OrElse isComplete) AndAlso nexoCom.Settings.Autoclose Then
					SetCancelButtonText(True)
					timerBeforeAutoClose = New Windows.Forms.Timer
					timerBeforeAutoClose.Interval = ONE_SECOND
					timerBeforeAutoClose.Tag = nexoCom.Settings.AutocloseDelay
				Else
					SetCancelButtonText(False)
				End If

			Case WM_AUTOCLOSE

			Case WM_RECEIVED_NOTIFICATION, WM_RECEIVED_REPLY, WM_RECEIVED_REQUEST
				timerBeforeTimeout.Stop()
				If Not hasTimedOut AndAlso Not hasBeenCancelled Then
					isComplete = True
					canBeCancelled = False
					Select Case m.Msg
						Case WM_RECEIVED_NOTIFICATION
							'to be completed
						Case WM_RECEIVED_REPLY

						Case WM_RECEIVED_REQUEST
							'to be completed
					End Select
					'process reception
					If nexoCom.Settings.Autoclose Then
						timerBeforeAutoClose.Start()
					End If
				End If
				SendMessage(WM_START_AUTOCLOSE_TIMER)

				'			Case nexoCom.NexoClient.WMThreadStopped
				'				'window has been signaled, stop timer and enable close button
				'				timerBeforeTimeout.Stop()
				'				pbCancel.Enabled = True
				'				pbCancel.Text = CLOSE_BUTTON_TEXT
				'				If CBool(m.WParam) Then
				'					Result = CApbe.enumDlgResult.Success
				'#If NOCOLOR Then
				'					message.BackColor = Color.Green
				'					message.ForeColor = Color.Yellow

				'#End If
				'				Else
				'					Result = CApbe.enumDlgResult.Failure
				'#If NOCOLOR Then
				'					message.BackColor = Color.Red
				'					message.ForeColor = Color.Yellow
				'#End If
				'				End If
				'				'put focus on close button
				'				pbCancel.Focus()
				'				'if autoclose wait delay before closing, otherwise do nothing and wait for user to close the window
				'				If nexoCom.NexoClient.AutoCloseWindowToSignal Then
				'					timerBeforeAutoClose.Tag = nexoCom.NexoClient.DelayBeforeAutoCloseWindowToSignal
				'					If 0 <> nexoCom.NexoClient.DelayBeforeAutoCloseWindowToSignal Then
				'						timerBeforeAutoClose.Interval = CApbe.ONESECOND
				'					Else
				'						timerBeforeAutoClose.Interval = 1
				'					End If
				'					timerBeforeAutoClose.Start()
				'				End If

				'#If NOCOLOR Then
				'#Else
				'			Case nexocom.NexoClient.WMChangeBackground
				'				Select Case m.WParam
				'					Case CApbe.enumApbeColor.critical
				'						message.BackColor = Color.DarkRed
				'						message.ForeColor = Color.White
				'					Case CApbe.enumApbeColor.failed
				'						message.BackColor = Color.Red
				'						message.ForeColor = Color.White
				'					Case CApbe.enumApbeColor.information
				'						message.BackColor = Color.Yellow
				'						message.ForeColor = Color.Black
				'					Case CApbe.enumApbeColor.reset
				'						message.BackColor = back
				'						message.ForeColor = fore
				'					Case CApbe.enumApbeColor.success
				'						message.BackColor = Color.Green
				'						message.ForeColor = Color.White
				'					Case CApbe.enumApbeColor.warning
				'						message.BackColor = Color.Orange
				'						message.ForeColor = Color.Black
				'				End Select
				'#End If

		End Select
		MyBase.WndProc(m)
	End Sub

	Private Function MessageDescription(o As NexoObjectToProcess, xml As String)
		Return " " & o.Category.ToString.ToUpper & " " & o.Type.ToString.ToUpper & " [" & xml.Length & "]" & vbCrLf & xml
	End Function

	Public Sub OnReceivedReply(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		isComplete = True
		If isComplete Then
			message.Invoke(myDelegate, New Activity() With {.Evt = ActivityEvent.replyReceived, .Message = "Received" & MessageDescription(obj, xml)})
			Dim res As Boolean = obj.CurrentObject.Success
			'processing
			If MessageCategoryEnumeration.Login = obj.Category Then
			ElseIf MessageCategoryEnumeration.Logout = obj.Category Then
			ElseIf MessageCategoryEnumeration.Payment = obj.Category Then
			ElseIf MessageCategoryEnumeration.Reversal = obj.Category Then
			End If
			PostMessage(WM_RECEIVED_REPLY, res)
		End If
	End Sub

	Public Sub OnReceivedRequest(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		message.Invoke(myDelegate, New Activity() With {.Evt = ActivityEvent.replyReceived, .Message = "Received" & MessageDescription(obj, xml)})
		PostMessage(WM_RECEIVED_REQUEST, RESULT_OK)
	End Sub

	Public Sub OnReceivedNotification(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		message.Invoke(myDelegate, New Activity() With {.Evt = ActivityEvent.replyReceived, .Message = "Received" & MessageDescription(obj, xml)})
		PostMessage(WM_RECEIVED_NOTIFICATION, RESULT_OK)
	End Sub

	Public Sub OnSentRequestError(xml As String, obj As NexoObjectToProcess, tcp As TcpClient, threadData As CThreadData, o As Object)
		hasTimedOut = True
		If hasTimedOut Then
			Dim msg As String = String.Empty
			message.Invoke(myDelegate, New Activity() With {.Evt = ActivityEvent.timerTimout, .Message = "The operation timed out and has been cancelled"})
			'verifying current processing
			If MessageCategoryEnumeration.Login = obj.Category Then
			ElseIf MessageCategoryEnumeration.Logout = obj.Category Then
			ElseIf MessageCategoryEnumeration.Payment = obj.Category Then
			ElseIf MessageCategoryEnumeration.Reversal = obj.Category Then
			End If
		End If

		''prepare new message (abort ?)
		'Dim abort As New NexoAbort()
		'abort.AbortRequest(obj.CurrentObject)
		'abort.AbortReason = "Timeout"
		'obj.NextObject = abort
		'PostMessage(WM_STOP)
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		If canBeCancelled Then
			'cancel action
			hasBeenCancelled = True
			If hasBeenCancelled Then
				DialogResult = DialogResult.Cancel
				Close()
			End If
		Else
			'arrived it can only be a close button which was pressed
			Caption = "MANUALLY CLOSING WINDOW"
			DialogResult = DialogResult.OK
			Close()
		End If
	End Sub
	Private Sub timerBeforeTimeout_Tick(sender As Object, e As EventArgs) Handles timerBeforeTimeout.Tick
		'allows displaying remaining time before timeout
		If Not hasTimedOut AndAlso 0 < CInt(timerBeforeTimeout.Tag) Then
			timerBeforeTimeout.Tag = CInt(timerBeforeTimeout.Tag) - 1
		Else
			hasTimedOut = True
			timerBeforeTimeout.Tag = 0
			timerBeforeTimeout.Stop()
			timerBeforeTimeout.Dispose()
			pbCancel.Enabled = True
			PostMessage(WM_TIMEOUT)
		End If
		If canBeCancelled And Not hasTimedOut Then
			pbCancel.Text = CANCEL_BUTTON_TEXT & " in " & CInt(timerBeforeTimeout.Tag) & " seconds"
		Else
			pbCancel.Text = CLOSE_BUTTON_TEXT & " in " & CInt(timerBeforeTimeout.Tag) & " seconds"
		End If
	End Sub

	Private Sub StartAutocloseTimer()
		pbCancel.Focus()
		If (hasTimedOut OrElse isComplete) AndAlso nexoCom.Settings.Autoclose Then
			SetCancelButtonText(True)
			timerBeforeAutoClose = New Windows.Forms.Timer
			timerBeforeAutoClose.Interval = ONE_SECOND
			timerBeforeAutoClose.Tag = nexoCom.Settings.AutocloseDelay
		Else
			SetCancelButtonText(False)
		End If
	End Sub

	Private Sub SetCancelButtonText(autoclose As Boolean)
		If autoclose Then
			pbCancel.Text = CLOSE_BUTTON_TEXT & " in " & CInt(timerBeforeAutoClose.Tag) & " seconds"
		Else
			pbCancel.Text = CLOSE_BUTTON_TEXT
		End If
	End Sub

	'display to delay before window autoclose
	Private Sub timerBeforeAutoClose_Tick(sender As Object, e As EventArgs) Handles timerBeforeAutoClose.Tick
		If 0 <= CInt(timerBeforeAutoClose.Tag) Then
			SetCancelButtonText(True)
			timerBeforeAutoClose.Tag = CInt(timerBeforeAutoClose.Tag) - 1
		Else
			Caption = "AUTOMATICALLY CLOSING WINDOW"
			DialogResult = DialogResult.OK
			Close()
		End If
	End Sub

	'display the global duration of the operation until the window is closed
	Private Sub timerGlobal_Tick(sender As Object, e As EventArgs) Handles timerGlobal.Tick
		Dim minutes As Integer
		Dim hours As Integer
		Dim seconds As Integer
		Dim delay As String = ""
		globalTicks += 1
		hours = (globalTicks \ 60) \ 60
		minutes = (globalTicks - (hours * 60)) \ 60
		seconds = globalTicks Mod 60
		If hours <> 0 Then delay = hours & " hours "
		If minutes <> 0 Then delay &= minutes & " minutes "
		delay &= seconds & " seconds "
		Me.Text = Caption & " - " & delay
	End Sub

	Private Sub FProcessing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		timerBeforeAutoClose.Stop()
		timerBeforeTimeout.Stop()
		timerGlobal.Stop()
		message.Text = ""
		information.Text = ""
	End Sub

	Private Sub FProcessing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		CLog.Add(HEADER & "RESULT CODE: " & DialogResult.ToString)
		nexoCom.ResetOwner(Me)
	End Sub

End Class