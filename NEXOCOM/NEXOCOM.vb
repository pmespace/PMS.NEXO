Imports System.Windows.Forms
Imports NEXO
Imports NEXO.Client
Imports COMMON

<ComClass(NEXOCOM.ClassId, NEXOCOM.InterfaceId, NEXOCOM.EventsId)>
Public Class NEXOCOM

#Region "GUID"
	Public Shadows Const ClassId As String = "C86AC303-6A19-4FE6-91CC-99D9BE369EE5"
	Public Shadows Const InterfaceId As String = "24B500EF-FCF4-4438-9541-2EEB99BEF014"
	Public Shadows Const EventsId As String = "CAA36F19-2D91-4121-8DC9-166BFF4A3D51"
#End Region

#Region "constructor"
	Public Sub New()
		MyBase.New()
		Initialise()
	End Sub
	Private Sub Initialise()
		_NexoClient = New NexoRetailerClient()
		_Login = New NexoLogin
		_Payment = New NexoPayment
		_Refund = New NexoRefund
		_Logout = New NexoLogout

	End Sub
#End Region

#Region "public properties"
	Public Property MainWindow As IntPtr = IntPtr.Zero
	Public Property Settings As Settings = Nothing
	Public Property SaleID As String
	Public Property POIID As String
	Public ReadOnly Property Login As NexoLogin
	Public ReadOnly Property Payment As NexoPayment
	Public ReadOnly Property Refund As NexoRefund
	Public ReadOnly Property Logout As NexoLogout
	Public ReadOnly Property NexoClient As NexoRetailerClient
#End Region

#Region "public methods"
	Public Function DisplaySettings() As DialogResult
		Dim f As New FSettings
		DisplaySettings = f.ShowDialog()
		If DialogResult.OK = DisplaySettings Then
			Settings = f.Settings
		End If
		f.Dispose()
	End Function

	Public Function DisplayProcessing(action As FProcessing.Action, amount As Decimal) As DialogResult
		If Not IsNothing(Settings) AndAlso 0 <> amount Then
			Dim f As New FProcessing(Me, action, amount)
			DisplayProcessing = f.ShowDialog()
			If DialogResult.OK = DisplaySettings() Then
			End If
			f.Dispose()
		Else
			DisplayProcessing = DialogResult.Abort
		End If
		Return DisplayProcessing
	End Function
#End Region

#Region "private properties"
	Private path As String = String.Empty
	Private Const DEFAULT_PORT As Integer = 2018
	Private Const SETTINGS_FILE_NAME As String = "nexocom.settings.json"
#End Region

#Region "private methods"
	Private Function SettingsFileName() As String
		Return path & SETTINGS_FILE_NAME
	End Function

#Region "window stack management"
	Private Class StackOfWindows
		Private lifo As Stack
		Public Sub New()
			lifo = New Stack
		End Sub
		Public Sub Push(value As IntPtr)
			If IntPtr.Zero <> value Then
				lifo.Push(value)
			End If
		End Sub
		Public Function Pop() As IntPtr
			Pop = IntPtr.Zero
			If 0 <> lifo.Count Then
				Pop = CType(lifo.Pop, IntPtr)
			End If
		End Function
		Public Function Peek() As IntPtr
			Peek = IntPtr.Zero
			If 0 <> lifo.Count Then
				Peek = CType(lifo.Peek, IntPtr)
			End If
		End Function
		ReadOnly Property Count() As Integer
			Get
				Return lifo.Count
			End Get
		End Property
	End Class
	Private windowsStack As New StackOfWindows
	Friend Function SetOwner(f As Form) As Boolean
		If IntPtr.Zero <> f.Handle Then
			If 0 <> windowsStack.Count Then
				Win32.SetWindowLongPtr(f.Handle, Win32.SWL.GWLP_HWNDPARENT, windowsStack.Peek)
			Else
				Win32.SetWindowLongPtr(f.Handle, Win32.SWL.GWLP_HWNDPARENT, MainWindow)
			End If
			SetOwner = True
			windowsStack.Push(f.Handle)
		Else
			SetOwner = False
		End If
	End Function
	Friend Sub ResetOwner(f As Form)
		If 0 <> windowsStack.Count Then
			windowsStack.Pop()
		End If
	End Sub
#End Region

	Private Sub LoadSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettingsFileName()
		Settings = json.ReadSettings()
		If IsNothing(Settings) Then
			Settings = New Settings
			SaveSettings()
		End If
	End Sub

	Private Sub SaveSettings()
		Dim json As New CJson(Of Settings)()
		json.FileName = SettingsFileName()
		json.WriteSettings(Settings, True)
	End Sub

	'Private Function ConnectToServer()

#End Region

End Class
