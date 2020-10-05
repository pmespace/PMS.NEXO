Imports COMMON

Public Enum TargetsEnum
	_begin
	localhost
	gateway
	server
	_end
End Enum

Public Class Settings
	Public Property SaleID As String
	Public Property ServiceID As String
	Public Property DeviceID As String
	Public Property POIID As String
	Public Property Target As TargetsEnum
		Set(value As TargetsEnum)
			If TargetsEnum._begin < value And TargetsEnum._end > value Then
				_target = value
			End If
		End Set
		Get
			Return _target
		End Get
	End Property
	Private _target As TargetsEnum = TargetsEnum.localhost
	Public Property IP As String
	Public Property Port As UInteger = CStreamSettings.DEFAULT_PORT
	Public Property LocalPort As UInteger
	Public Property Autostart As Boolean = True
	Public Property Connected As Boolean
	Public Property ConnectedLocation As Point
	Public Property GatewayPort As UInteger = CStreamSettings.DEFAULT_PORT
	Public Property TerminalIP As String
	Public Property TerminalPort As UInteger = CStreamSettings.DEFAULT_PORT
	Public Property TerminalLocalHost As Boolean
	Public Property ReceiveTimeout As Integer = 15
	Public Property WindowState As FormWindowState
	Public Property Location As Point
	Public Property Size As Size
	Public Property Command As String
	Public Property ClientColor As Color = SystemColors.ControlText
	Public Property GatewayColor As Color = SystemColors.ControlText
	Public Property ServerColor As Color = SystemColors.ControlText
	Public Property TextToPrint As String
	Public Property Infinite As Boolean
	Public Property ServerDelay As Integer
	Public Property Synchronous As Boolean
End Class
