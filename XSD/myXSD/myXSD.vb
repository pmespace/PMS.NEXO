Imports System.Runtime.Serialization.Formatters.Binary
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Xml.Serialization
Imports System.Xml.Schema
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
Imports Microsoft.VisualBasic
Imports COMMON.WIN32
Imports COMMON
Imports XSDEx

Public Class myXSD

	Private Const MYXSD_SETTINGS As String = "myxsd.json"
	Private Const XSD_SETTINGS As String = "xsd.settings.json"
	Private xsdex As New XSD
	Private statusText As String, updateStatusText As String
	Private thread As CThread
	Private Const WM_EVENT As Integer = Win32.WM_USER + 1
	Private started As DateTime

#Region "serverThread management"
	Private myDelegate As New XSDAddActivity(AddressOf ProcessUI)
	Private Sub ProcessUI(activity As XSDActivity)
		Select Case activity.Evt
			Case XSDActivityEvent.startingProcess
				panelSettings.Enabled = False
				panelGenerateButtons.Enabled = False
				result.Clear()
				ToSettings()
				SetHourglass()
			Case XSDActivityEvent.status
				UpdateStatus(activity.Message)
			Case XSDActivityEvent.message
				Label5.Text = activity.Message
			Case XSDActivityEvent.endingProcess
				If Not String.IsNullOrEmpty(xsdex.Code) Then
					result.AppendText(xsdex.Code)
					Try
						Clipboard.SetText(xsdex.Code)
					Catch ex As Exception
					End Try
				End If
				SetDefaultCursor()
				panelSettings.Enabled = True
				panelGenerateButtons.Enabled = True
		End Select
		'SetButtons()
	End Sub
#End Region

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case m.Msg
			Case WM_EVENT
				Label5.Invoke(myDelegate, New XSDActivity With {.Evt = XSDActivityEvent.endingProcess})
		End Select
		MyBase.WndProc(m)
	End Sub

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
		started = DateTime.Now
	End Sub

	Private Sub SetDefaultCursor()
		Me.Cursor = Cursors.Default
		Dim ts As TimeSpan = DateTime.Now - started
		SetStatus($"Completed ({ts})")
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
		settings.Silent = cbSilent.Checked
		settings.ConvertStringIntegralToIntegral = cbStringToIntegral.Checked
		settings.UseDefaultValueForHasBeenModified = cbUseDefaultValueForHasBeenModified.Checked
		settings.AddDefaultAttributesToEnum = cbAddDefaultToEnum.Checked
		settings.UseEnumBeginEnd = cbAddBeginEnd.Checked

		If rbRetailer.Checked Then
			settings.NamespaceToDeclare = XSDSettings.NameSpace.Retailer
		ElseIf rbAcquirer.Checked Then
			settings.NamespaceToDeclare = XSDSettings.NameSpace.Acquirer
		ElseIf rbTMS.Checked Then
			settings.NamespaceToDeclare = XSDSettings.NameSpace.TMS
		Else
			settings.NamespaceToDeclare = XSDSettings.NameSpace.None
		End If

		settings.UseNullableIntegralTypes = cbuseNullableIntegralTypes.Checked
		settings.UseOptimizingFlag = cbOptimizing.Checked

		settings.RemoveXmlAttribute = cbRemoveAttribute.Checked
		settings.AttributeAsElement = cbCreateAsElement.Checked
		settings.AdaptXmlText = cbAdaptXmlText.Checked
		settings.UseListInsteadOfArray = cbUseList.Checked

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
		cbSilent.Checked = settings.Silent
		cbStringToIntegral.Checked = settings.ConvertStringIntegralToIntegral
		cbUseDefaultValueForHasBeenModified.Checked = settings.UseDefaultValueForHasBeenModified
		cbAddDefaultToEnum.Checked = settings.AddDefaultAttributesToEnum
		cbAddBeginEnd.Checked = settings.UseEnumBeginEnd

		Select Case settings.NamespaceToDeclare
			Case XSDSettings.NameSpace.Retailer
				rbRetailer.Checked = True
			Case XSDSettings.NameSpace.Acquirer
				rbAcquirer.Checked = True
			Case XSDSettings.NameSpace.TMS
				rbTMS.Checked = True
			Case Else
				rbNone.Checked = True
		End Select

		cbuseNullableIntegralTypes.Checked = settings.UseNullableIntegralTypes
		cbOptimizing.Checked = settings.UseOptimizingFlag

		cbRemoveAttribute.Checked = settings.RemoveXmlAttribute
		cbCreateAsElement.Checked = settings.AttributeAsElement
		cbAdaptXmlText.Checked = settings.AdaptXmlText
		cbUseList.Checked = settings.UseListInsteadOfArray

	End Sub

	Private Function GenerateFilesAsyncThread(thread As CThread, o As Object) As Integer
		Dim myParams As myParams = o
		Dim mySettings As New XSD.AnalyseSettings With {.threadData = thread.ThreadData, .mixFiles = myParams.mixfiles, .lbl = Label5, .processUI = AddressOf ProcessUI, .xsdSettings = myParams.xsdSettings}
		If xsdex.AnalyseXSD(mySettings) Then
		End If
		Return ThreadResult.OK
	End Function

	Private Class myParams
		Public mixfiles As Boolean
		Public xsdSettings As XSDSettings
	End Class

	Private Sub GenerateFilesAsync(mixFiles As Boolean)
		Label5.Invoke(myDelegate, New XSDActivity With {.Evt = XSDActivityEvent.startingProcess})
		thread = New CThread
		Dim myParams As New myParams With {.mixfiles = mixFiles, .xsdSettings = ToSettings()}
		thread.Start(AddressOf GenerateFilesAsyncThread,
						 New CThreadData() With
							{
							.StoppedMessage = WM_EVENT,
							.WindowToWarn = Me.Handle
							},
						 myParams,
						 Nothing,
						 True)
	End Sub

	Private Sub pbGenerate_Click(sender As Object, e As EventArgs) Handles pbGenerate.Click
		GenerateFilesAsync(True)
	End Sub

	Private Sub pbGenerateNFiles_Click(sender As Object, e As EventArgs) Handles pbGenerateNFiles.Click
		GenerateFilesAsync(False)
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
		json.WriteSettings(settings, )
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

	Private Sub cbUseList_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseList.CheckedChanged
		cbUseList.Checked = False
	End Sub

	Private Sub convertTypes_CheckedChanged(sender As Object, e As EventArgs) Handles convertTypes.CheckedChanged
		panelTypes.Enabled = convertTypes.Checked
	End Sub

End Class
