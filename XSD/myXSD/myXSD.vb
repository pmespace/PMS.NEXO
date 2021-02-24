Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.Xml.Schema
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports COMMON
Imports XSDEx

Public Class myXSD

	Private Const MYXSD_SETTINGS As String = "myxsd.json"
	Private Const XSD_SETTINGS As String = "xsd.settings.json"
	Private xsdex As New XSD
	Private statusText As String, updateStatusText As String

#Region "serverThread management"
	'Private Enum ActivityEvent
	'	none
	'	message
	'	startingProcess
	'	endingProcess
	'End Enum
	'Private Class Activity
	'	Public Property Message As String
	'	Public Property Evt As ActivityEvent
	'End Class
	Private Delegate Sub AddActivity(Activity As Activity)
	Private myDelegate As New AddActivity(AddressOf ProcessUI)

	Private Sub ProcessUI(activity As Activity)
		If ActivityEvent.none <> activity.Evt Then
			UpdateStatus(activity.Message)
		End If
		SetButtons()
	End Sub
#End Region

	Private Sub DisplayStatus()
		status.Text = statusText
		If Not String.IsNullOrEmpty(updateStatusText) Then
			status.Text &= $" [{updateStatusText}]"
		End If
		status.Update()
	End Sub

	Private Sub UpdateStatus(s As String)
		updateStatusText = s
		status.Text = $"{statusText} [{updateStatusText}]"
		status.Update()
	End Sub

	Private Sub SetStatus(s As String)
		statusText = s
		status.Text = statusText
		status.Update()
	End Sub

	Private Sub SetHourglass()
		Me.Cursor = Cursors.WaitCursor
		SetStatus("Running")
	End Sub

	Private Sub SetDefaultCursor()
		Me.Cursor = Cursors.Default
		SetStatus("Completed")
	End Sub

	Private Sub SetButtons()
		pbGenerate.Enabled = (0 <> files.Items.Count)
		pbSave.Enabled = 0 <> result.TextLength
		SetStatus(String.Empty)
	End Sub

	Private Sub pbFiles_Click(sender As Object, e As EventArgs) Handles pbFiles.Click
		Select Case OpenFileDialog1.ShowDialog
			Case DialogResult.OK
				Dim l As List(Of String) = OpenFileDialog1.FileNames.ToList
				PopulateFiles(l)
		End Select
	End Sub

	Private Function ToSettings() As XSDSettings
		Dim settings As New XSDSettings
		settings.Files.Clear()
		For Each f As String In files.Items
			settings.Files.Add(f)
		Next
		settings.ParametersFileName = "xsd.params.json"
		settings.AddDispID = addDispid.Checked
		settings.BooleanToString = convertBoolean.Checked

		If classInterface.SelectedValue = ClassInterfaceType.AutoDispatch.ToString Then
			settings.ClassInterface = ClassInterfaceType.AutoDispatch
		ElseIf classInterface.SelectedValue = ClassInterfaceType.AutoDual.ToString Then
			settings.ClassInterface = ClassInterfaceType.AutoDual
		Else
			settings.ClassInterface = ClassInterfaceType.None
		End If

		If comInterface.SelectedValue = ComInterfaceType.InterfaceIsDual.ToString Then
			settings.ComInterface = ComInterfaceType.InterfaceIsDual
		ElseIf comInterface.SelectedValue = ComInterfaceType.InterfaceIsIDispatch.ToString Then
			settings.ComInterface = ComInterfaceType.InterfaceIsIDispatch
		ElseIf comInterface.SelectedValue = ComInterfaceType.InterfaceIsIInspectable.ToString Then
			settings.ComInterface = ComInterfaceType.InterfaceIsIInspectable
		Else
			settings.ComInterface = ComInterfaceType.InterfaceIsIUnknown
		End If

		settings.ConvertTypes = convertTypes.Checked
		settings.DateTimeToString = convertDateTime.Checked
		settings.DeclareClassInterface = createInterface.Checked
		If csharp.Checked Then
			settings.Language = enumLanguage.csharp
		Else
			settings.Language = enumLanguage.vb
		End If
		settings.MakeClassComVisible = classVisible.Checked
		settings.MakeEnumComVisible = enumVisible.Checked
		settings.Nmspace = nmspace.Text
		settings.NumericToString = convertNumeric.Checked
		settings.ArrayCreateInitializer = arrayInitializer.Checked
		settings.ArrayGetReturnsNullEmpty = nullIfEmptyArray.Checked
		settings.UseElements = cbElements.Checked
		settings.UseNotations = cbNotations.Checked
		settings.UseTypes = cbTypes.Checked
		settings.PrivateByInternal = privateByInternal.Checked
		settings.Preprocessor = efPreprocessor.Text

		Dim json As New CJson(Of XSDSettings)(XSD_SETTINGS)
		json.WriteSettings(settings)
		Return settings
	End Function

	Private Sub FromSettings()
		Dim json As New CJson(Of XSDSettings)(XSD_SETTINGS)
		Dim settings As XSDSettings = json.ReadSettings()
		If IsNothing(settings) Then
			settings = New XSDSettings
		End If
		If (Not IsNothing(settings.Files)) Then
			files.Items.Clear()
			PopulateFiles(settings.Files)
		End If
		addDispid.Checked = settings.AddDispID
		convertBoolean.Checked = settings.BooleanToString
		classInterface.SelectedItem = settings.ClassInterface.ToString
		comInterface.SelectedItem = settings.ComInterface.ToString
		convertTypes.Checked = settings.ConvertTypes
		convertDateTime.Checked = settings.DateTimeToString
		createInterface.Checked = settings.DeclareClassInterface

		Select Case settings.Language
			Case enumLanguage.csharp
				csharp.Checked = True
			Case Else
				vb.Checked = True
		End Select

		classVisible.Checked = settings.MakeClassComVisible
		enumVisible.Checked = settings.MakeEnumComVisible
		nmspace.Text = settings.Nmspace
		convertNumeric.Checked = settings.NumericToString
		arrayInitializer.Checked = settings.ArrayCreateInitializer
		nullIfEmptyArray.Checked = settings.ArrayGetReturnsNullEmpty
		cbElements.Checked = settings.UseElements
		cbNotations.Checked = settings.UseNotations
		cbTypes.Checked = settings.UseTypes
		privateByInternal.Checked = settings.PrivateByInternal
		efPreprocessor.Text = settings.Preprocessor
	End Sub

	Private Sub GenerateFiles(mixFiles As Boolean)
		panelSettings.Enabled = False
		result.Clear()
		ToSettings()
		SetHourglass()
		'FromSettings()
		If xsdex.AnalyseXSD(ToSettings(), mixFiles, Label5) Then
			result.AppendText(xsdex.Code)
			Try
				Clipboard.SetText(xsdex.Code)
			Catch ex As Exception
			End Try
		End If
		SetDefaultCursor()
		panelSettings.Enabled = True
	End Sub

	Private Sub pbGenerate_Click(sender As Object, e As EventArgs) Handles pbGenerate.Click
		GenerateFiles(True)
	End Sub

	Private Sub pbGenerateNFiles_Click(sender As Object, e As EventArgs) Handles pbGenerateNFiles.Click
		GenerateFiles(False)
	End Sub

	Private Shared Function CloneMember(ByVal m As CodeTypeMember) As CodeTypeMember
		Dim ms = New MemoryStream()
		Dim formatter = New BinaryFormatter()
		formatter.Serialize(ms, m)
		ms.Seek(0, SeekOrigin.Begin)
		Return TryCast(formatter.Deserialize(ms), CodeTypeMember)
	End Function

	Private Shared Sub AddGuid(ByVal attrs As CodeAttributeDeclarationCollection)
		Dim guid As New Guid
		attrs.Add(New CodeAttributeDeclaration(New CodeTypeReference("System.Runtime.InteropServices.GuidAttribute"), New CodeAttributeArgument(New CodePrimitiveExpression(Guid.NewGuid.ToString))))
	End Sub

	Private Shared Sub AddComVisibleTrue(ByVal attrs As CodeAttributeDeclarationCollection)
		attrs.Add(New CodeAttributeDeclaration(New CodeTypeReference("System.Runtime.InteropServices.ComVisibleAttribute"), {New CodeAttributeArgument(New CodePrimitiveExpression(True))}))
	End Sub

	Private Shared Sub AddClassInterfaceNone(ByVal attrs As CodeAttributeDeclarationCollection)
		attrs.Add(New CodeAttributeDeclaration(New CodeTypeReference("System.Runtime.InteropServices.ClassInterface"), {New CodeAttributeArgument(New CodeFieldReferenceExpression(New CodeTypeReferenceExpression("System.Runtime.InteropServices.ClassInterfaceType"), ClassInterfaceType.None.ToString()))}))
	End Sub

	Private Shared Sub AddInterfaceTypeIsDual(ByVal attrs As CodeAttributeDeclarationCollection)
		attrs.Add(New CodeAttributeDeclaration(New CodeTypeReference("System.Runtime.InteropServices.InterfaceTypeAttribute"), {New CodeAttributeArgument(New CodeFieldReferenceExpression(New CodeTypeReferenceExpression("System.Runtime.InteropServices.ComInterfaceType"), ComInterfaceType.InterfaceIsDual.ToString()))}))
	End Sub

	Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
		If csharp.Checked Then
			SaveFileDialog1.DefaultExt = "cs"
		Else
			SaveFileDialog1.DefaultExt = "vb"
		End If
		SaveFileDialog1.FileName = files.Items(files.Items.Count - 1).ToString & "." & SaveFileDialog1.DefaultExt
		Select Case SaveFileDialog1.ShowDialog
			Case DialogResult.OK
				Using stream = New StreamWriter(SaveFileDialog1.FileName)
					stream.WriteLine(result.Text)
				End Using
		End Select
	End Sub

	Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
		Close()
	End Sub

	Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		files.Items.Clear()
		Dim json As New CJson(Of Settings)(MYXSD_SETTINGS)
		Dim settings As Settings = json.ReadSettings()
		If IsNothing(settings) Then
			settings = New Settings
		End If
		OpenFileDialog1.InitialDirectory = settings.Directory
		FromSettings()
		SetButtons()
	End Sub

	Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		ToSettings()
		Dim settings As New Settings
		settings.Directory = OpenFileDialog1.InitialDirectory
		Dim json As New CJson(Of Settings)(MYXSD_SETTINGS)
		json.WriteSettings(settings)
	End Sub

	Private Sub ContextMenuStrip1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
		RemoveFileToolStripMenuItem.Enabled = 0 <> files.SelectedItems.Count
		RemoveAllFilesToolStripMenuItem.Enabled = 0 <> files.Items.Count
	End Sub

	Private Sub RemoveAllFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllFilesToolStripMenuItem.Click
		files.Items.Clear()
		SetButtons()
	End Sub

	Private Sub RemoveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFileToolStripMenuItem.Click
		For i As Integer = files.SelectedIndices.Count - 1 To 0 Step -1
			files.Items.RemoveAt(files.SelectedIndices.Item(i))
		Next
		SetButtons()
	End Sub

	Private Sub PopulateFiles(l As List(Of String))
		For Each f As String In l
			If Not files.Items.Contains(f) Then
				files.Items.Add(f)
			End If
		Next
		SetButtons()
	End Sub

	Private Sub result_TextChanged(sender As Object, e As EventArgs) Handles result.TextChanged
		SetButtons()
	End Sub

	Private Sub classVisible_CheckedChanged(sender As Object, e As EventArgs) Handles classVisible.CheckedChanged
		panelCOM.Enabled = classVisible.Checked
	End Sub

	Private Sub createInterface_CheckedChanged(sender As Object, e As EventArgs) Handles createInterface.CheckedChanged
		panelInterface.Enabled = createInterface.Checked
	End Sub

	Private Sub status_TextChanged(sender As Object, e As EventArgs) Handles status.TextChanged
		Label5.Text = String.Empty
	End Sub

	Private Sub convertTypes_CheckedChanged(sender As Object, e As EventArgs) Handles convertTypes.CheckedChanged
		panelTypes.Enabled = convertTypes.Checked
	End Sub

End Class
