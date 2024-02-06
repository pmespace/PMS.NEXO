<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myXSD
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.panelButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbClose = New System.Windows.Forms.Button()
		Me.status = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.panelGenerateButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbGenerate = New System.Windows.Forms.Button()
		Me.pbSave = New System.Windows.Forms.Button()
		Me.pbGenerateNFiles = New System.Windows.Forms.Button()
		Me.panelSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.panelFiles = New System.Windows.Forms.TableLayoutPanel()
		Me.files = New System.Windows.Forms.ListBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RemoveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveAllFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pbFiles = New System.Windows.Forms.Button()
		Me.panelOptions = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.enumVisible = New System.Windows.Forms.CheckBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.createInterface = New System.Windows.Forms.CheckBox()
		Me.classVisible = New System.Windows.Forms.CheckBox()
		Me.panelInterface = New System.Windows.Forms.TableLayoutPanel()
		Me.comInterface = New System.Windows.Forms.ComboBox()
		Me.addDispid = New System.Windows.Forms.CheckBox()
		Me.panelCOM = New System.Windows.Forms.TableLayoutPanel()
		Me.classInterface = New System.Windows.Forms.ComboBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.nmspace = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.efPreprocessor = New System.Windows.Forms.TextBox()
		Me.cbSilent = New System.Windows.Forms.CheckBox()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.csharp = New System.Windows.Forms.RadioButton()
		Me.vb = New System.Windows.Forms.RadioButton()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.rbRetailer = New System.Windows.Forms.RadioButton()
		Me.rbAcquirer = New System.Windows.Forms.RadioButton()
		Me.rbTMS = New System.Windows.Forms.RadioButton()
		Me.rbNone = New System.Windows.Forms.RadioButton()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.convertTypes = New System.Windows.Forms.CheckBox()
		Me.panelTypes = New System.Windows.Forms.TableLayoutPanel()
		Me.convertBoolean = New System.Windows.Forms.CheckBox()
		Me.convertNumeric = New System.Windows.Forms.CheckBox()
		Me.convertDateTime = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbNotations = New System.Windows.Forms.CheckBox()
		Me.cbTypes = New System.Windows.Forms.CheckBox()
		Me.cbElements = New System.Windows.Forms.CheckBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.arrayInitializer = New System.Windows.Forms.CheckBox()
		Me.nullIfEmptyArray = New System.Windows.Forms.CheckBox()
		Me.privateByInternal = New System.Windows.Forms.CheckBox()
		Me.cbStringToIntegral = New System.Windows.Forms.CheckBox()
		Me.cbUseDefaultValueForHasBeenModified = New System.Windows.Forms.CheckBox()
		Me.cbAddDefaultToEnum = New System.Windows.Forms.CheckBox()
		Me.cbAddBeginEnd = New System.Windows.Forms.CheckBox()
		Me.cbuseNullableIntegralTypes = New System.Windows.Forms.CheckBox()
		Me.cbOptimizing = New System.Windows.Forms.CheckBox()
		Me.cbRemoveAttribute = New System.Windows.Forms.CheckBox()
		Me.cbCreateAsElement = New System.Windows.Forms.CheckBox()
		Me.cbAdaptXmlText = New System.Windows.Forms.CheckBox()
		Me.cbUseList = New System.Windows.Forms.CheckBox()
		Me.result = New System.Windows.Forms.TextBox()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.panelMain.SuspendLayout()
		Me.panelButtons.SuspendLayout()
		Me.panelGenerateButtons.SuspendLayout()
		Me.panelSettings.SuspendLayout()
		Me.panelFiles.SuspendLayout()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.panelOptions.SuspendLayout()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.panelInterface.SuspendLayout()
		Me.panelCOM.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.panelTypes.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'panelMain
		'
		Me.panelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelMain.AutoSize = True
		Me.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelMain.ColumnCount = 1
		Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.Controls.Add(Me.panelButtons, 0, 2)
		Me.panelMain.Controls.Add(Me.panelSettings, 0, 0)
		Me.panelMain.Controls.Add(Me.result, 0, 1)
		Me.panelMain.Location = New System.Drawing.Point(12, 12)
		Me.panelMain.Name = "panelMain"
		Me.panelMain.RowCount = 3
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.Size = New System.Drawing.Size(922, 417)
		Me.panelMain.TabIndex = 0
		'
		'panelButtons
		'
		Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelButtons.AutoSize = True
		Me.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelButtons.ColumnCount = 8
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.Controls.Add(Me.pbClose, 7, 0)
		Me.panelButtons.Controls.Add(Me.status, 0, 0)
		Me.panelButtons.Controls.Add(Me.Label5, 1, 0)
		Me.panelButtons.Controls.Add(Me.panelGenerateButtons, 3, 0)
		Me.panelButtons.Location = New System.Drawing.Point(3, 379)
		Me.panelButtons.Name = "panelButtons"
		Me.panelButtons.RowCount = 1
		Me.panelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.Size = New System.Drawing.Size(916, 35)
		Me.panelButtons.TabIndex = 1
		'
		'pbClose
		'
		Me.pbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbClose.AutoSize = True
		Me.pbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbClose.Location = New System.Drawing.Point(870, 6)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(43, 23)
		Me.pbClose.TabIndex = 3
		Me.pbClose.Text = "Close"
		Me.pbClose.UseVisualStyleBackColor = True
		'
		'status
		'
		Me.status.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.status.AutoSize = True
		Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status.Location = New System.Drawing.Point(3, 9)
		Me.status.Name = "status"
		Me.status.Size = New System.Drawing.Size(54, 16)
		Me.status.TabIndex = 0
		Me.status.Text = "Label4"
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(63, 11)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(528, 13)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "Label5"
		'
		'panelGenerateButtons
		'
		Me.panelGenerateButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGenerateButtons.AutoSize = True
		Me.panelGenerateButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGenerateButtons.ColumnCount = 3
		Me.panelGenerateButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGenerateButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGenerateButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGenerateButtons.Controls.Add(Me.pbGenerate, 0, 0)
		Me.panelGenerateButtons.Controls.Add(Me.pbSave, 2, 0)
		Me.panelGenerateButtons.Controls.Add(Me.pbGenerateNFiles, 1, 0)
		Me.panelGenerateButtons.Location = New System.Drawing.Point(597, 3)
		Me.panelGenerateButtons.Name = "panelGenerateButtons"
		Me.panelGenerateButtons.RowCount = 1
		Me.panelGenerateButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGenerateButtons.Size = New System.Drawing.Size(267, 29)
		Me.panelGenerateButtons.TabIndex = 2
		'
		'pbGenerate
		'
		Me.pbGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbGenerate.AutoSize = True
		Me.pbGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbGenerate.Location = New System.Drawing.Point(3, 3)
		Me.pbGenerate.Name = "pbGenerate"
		Me.pbGenerate.Size = New System.Drawing.Size(86, 23)
		Me.pbGenerate.TabIndex = 0
		Me.pbGenerate.Text = "Generate 1 file"
		Me.pbGenerate.UseVisualStyleBackColor = True
		'
		'pbSave
		'
		Me.pbSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSave.AutoSize = True
		Me.pbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSave.Location = New System.Drawing.Point(194, 3)
		Me.pbSave.Name = "pbSave"
		Me.pbSave.Size = New System.Drawing.Size(70, 23)
		Me.pbSave.TabIndex = 2
		Me.pbSave.Text = "Save to file"
		Me.pbSave.UseVisualStyleBackColor = True
		'
		'pbGenerateNFiles
		'
		Me.pbGenerateNFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbGenerateNFiles.AutoSize = True
		Me.pbGenerateNFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbGenerateNFiles.Location = New System.Drawing.Point(95, 3)
		Me.pbGenerateNFiles.Name = "pbGenerateNFiles"
		Me.pbGenerateNFiles.Size = New System.Drawing.Size(93, 23)
		Me.pbGenerateNFiles.TabIndex = 1
		Me.pbGenerateNFiles.Text = "Generate N files"
		Me.pbGenerateNFiles.UseVisualStyleBackColor = True
		'
		'panelSettings
		'
		Me.panelSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelSettings.AutoSize = True
		Me.panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelSettings.ColumnCount = 1
		Me.panelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelSettings.Controls.Add(Me.panelFiles, 0, 0)
		Me.panelSettings.Controls.Add(Me.panelOptions, 0, 1)
		Me.panelSettings.Location = New System.Drawing.Point(3, 3)
		Me.panelSettings.Name = "panelSettings"
		Me.panelSettings.RowCount = 2
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelSettings.Size = New System.Drawing.Size(916, 277)
		Me.panelSettings.TabIndex = 0
		'
		'panelFiles
		'
		Me.panelFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelFiles.AutoSize = True
		Me.panelFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelFiles.ColumnCount = 2
		Me.panelFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelFiles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelFiles.Controls.Add(Me.files, 1, 0)
		Me.panelFiles.Controls.Add(Me.pbFiles, 0, 0)
		Me.panelFiles.Location = New System.Drawing.Point(3, 3)
		Me.panelFiles.Name = "panelFiles"
		Me.panelFiles.RowCount = 1
		Me.panelFiles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelFiles.Size = New System.Drawing.Size(910, 67)
		Me.panelFiles.TabIndex = 0
		'
		'files
		'
		Me.files.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.files.ContextMenuStrip = Me.ContextMenuStrip1
		Me.files.FormattingEnabled = True
		Me.files.IntegralHeight = False
		Me.files.Location = New System.Drawing.Point(84, 3)
		Me.files.Name = "files"
		Me.files.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.files.Size = New System.Drawing.Size(938, 61)
		Me.files.TabIndex = 1
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveFileToolStripMenuItem, Me.RemoveAllFilesToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 48)
		'
		'RemoveFileToolStripMenuItem
		'
		Me.RemoveFileToolStripMenuItem.Name = "RemoveFileToolStripMenuItem"
		Me.RemoveFileToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
		Me.RemoveFileToolStripMenuItem.Text = "Remove selected file(s)"
		'
		'RemoveAllFilesToolStripMenuItem
		'
		Me.RemoveAllFilesToolStripMenuItem.Name = "RemoveAllFilesToolStripMenuItem"
		Me.RemoveAllFilesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
		Me.RemoveAllFilesToolStripMenuItem.Text = "Remove all files"
		'
		'pbFiles
		'
		Me.pbFiles.Location = New System.Drawing.Point(3, 3)
		Me.pbFiles.Name = "pbFiles"
		Me.pbFiles.Size = New System.Drawing.Size(75, 23)
		Me.pbFiles.TabIndex = 0
		Me.pbFiles.Text = "Choose files"
		Me.pbFiles.UseVisualStyleBackColor = True
		'
		'panelOptions
		'
		Me.panelOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelOptions.AutoSize = True
		Me.panelOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelOptions.ColumnCount = 1
		Me.panelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel6, 0, 2)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel1, 0, 0)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel2, 0, 3)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel3, 0, 1)
		Me.panelOptions.Controls.Add(Me.FlowLayoutPanel1, 0, 4)
		Me.panelOptions.Location = New System.Drawing.Point(3, 76)
		Me.panelOptions.Name = "panelOptions"
		Me.panelOptions.RowCount = 5
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelOptions.Size = New System.Drawing.Size(910, 198)
		Me.panelOptions.TabIndex = 1
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel6.AutoSize = True
		Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel6.ColumnCount = 6
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.Controls.Add(Me.enumVisible, 5, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.createInterface, 3, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.classVisible, 1, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.panelInterface, 4, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.panelCOM, 2, 0)
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 75)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 1
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(904, 33)
		Me.TableLayoutPanel6.TabIndex = 2
		'
		'enumVisible
		'
		Me.enumVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.enumVisible.AutoSize = True
		Me.enumVisible.Location = New System.Drawing.Point(786, 8)
		Me.enumVisible.Name = "enumVisible"
		Me.enumVisible.Size = New System.Drawing.Size(115, 17)
		Me.enumVisible.TabIndex = 6
		Me.enumVisible.Text = "Make enum Visible"
		Me.enumVisible.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 10)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "COM visibility"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'createInterface
		'
		Me.createInterface.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.createInterface.AutoSize = True
		Me.createInterface.Location = New System.Drawing.Point(387, 8)
		Me.createInterface.Name = "createInterface"
		Me.createInterface.Size = New System.Drawing.Size(102, 17)
		Me.createInterface.TabIndex = 4
		Me.createInterface.Text = "Create Interface"
		Me.createInterface.UseVisualStyleBackColor = True
		'
		'classVisible
		'
		Me.classVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.classVisible.AutoSize = True
		Me.classVisible.Location = New System.Drawing.Point(78, 8)
		Me.classVisible.Name = "classVisible"
		Me.classVisible.Size = New System.Drawing.Size(112, 17)
		Me.classVisible.TabIndex = 1
		Me.classVisible.Text = "Make class visible"
		Me.classVisible.UseVisualStyleBackColor = True
		'
		'panelInterface
		'
		Me.panelInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelInterface.AutoSize = True
		Me.panelInterface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelInterface.ColumnCount = 2
		Me.panelInterface.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelInterface.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelInterface.Controls.Add(Me.comInterface, 0, 0)
		Me.panelInterface.Controls.Add(Me.addDispid, 1, 0)
		Me.panelInterface.Location = New System.Drawing.Point(495, 3)
		Me.panelInterface.Name = "panelInterface"
		Me.panelInterface.RowCount = 1
		Me.panelInterface.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelInterface.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
		Me.panelInterface.Size = New System.Drawing.Size(285, 27)
		Me.panelInterface.TabIndex = 7
		'
		'comInterface
		'
		Me.comInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comInterface.FormattingEnabled = True
		Me.comInterface.Items.AddRange(New Object() {"InterfaceIsDual", "InterfaceIsIUnknown", "InterfaceIsIDispatch"})
		Me.comInterface.Location = New System.Drawing.Point(3, 3)
		Me.comInterface.Name = "comInterface"
		Me.comInterface.Size = New System.Drawing.Size(185, 21)
		Me.comInterface.TabIndex = 5
		'
		'addDispid
		'
		Me.addDispid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.addDispid.AutoSize = True
		Me.addDispid.Location = New System.Drawing.Point(194, 5)
		Me.addDispid.Name = "addDispid"
		Me.addDispid.Size = New System.Drawing.Size(88, 17)
		Me.addDispid.TabIndex = 3
		Me.addDispid.Text = "Add DispId"
		Me.addDispid.UseVisualStyleBackColor = True
		'
		'panelCOM
		'
		Me.panelCOM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelCOM.AutoSize = True
		Me.panelCOM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelCOM.ColumnCount = 1
		Me.panelCOM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCOM.Controls.Add(Me.classInterface, 0, 0)
		Me.panelCOM.Location = New System.Drawing.Point(196, 3)
		Me.panelCOM.Name = "panelCOM"
		Me.panelCOM.RowCount = 1
		Me.panelCOM.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelCOM.Size = New System.Drawing.Size(185, 27)
		Me.panelCOM.TabIndex = 8
		'
		'classInterface
		'
		Me.classInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.classInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.classInterface.FormattingEnabled = True
		Me.classInterface.Items.AddRange(New Object() {"None", "AutoDispatch", "AutoDual"})
		Me.classInterface.Location = New System.Drawing.Point(3, 3)
		Me.classInterface.Name = "classInterface"
		Me.classInterface.Size = New System.Drawing.Size(179, 21)
		Me.classInterface.TabIndex = 2
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 8
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.nmspace, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.efPreprocessor, 4, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.cbSilent, 7, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 5, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 2, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(904, 31)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'nmspace
		'
		Me.nmspace.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.nmspace.Location = New System.Drawing.Point(76, 5)
		Me.nmspace.Name = "nmspace"
		Me.nmspace.Size = New System.Drawing.Size(103, 20)
		Me.nmspace.TabIndex = 0
		Me.nmspace.Text = "NEXO"
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Namespace:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(441, 9)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 13)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Preprocessor:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Label4.Visible = False
		'
		'efPreprocessor
		'
		Me.efPreprocessor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efPreprocessor.Location = New System.Drawing.Point(519, 5)
		Me.efPreprocessor.Name = "efPreprocessor"
		Me.efPreprocessor.Size = New System.Drawing.Size(90, 20)
		Me.efPreprocessor.TabIndex = 2
		Me.efPreprocessor.Visible = False
		'
		'cbSilent
		'
		Me.cbSilent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbSilent.AutoSize = True
		Me.cbSilent.Location = New System.Drawing.Point(849, 7)
		Me.cbSilent.Name = "cbSilent"
		Me.cbSilent.Size = New System.Drawing.Size(52, 17)
		Me.cbSilent.TabIndex = 3
		Me.cbSilent.Text = "Silent"
		Me.cbSilent.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel3.AutoSize = True
		Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FlowLayoutPanel3.Controls.Add(Me.csharp)
		Me.FlowLayoutPanel3.Controls.Add(Me.vb)
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(615, 3)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(117, 25)
		Me.FlowLayoutPanel3.TabIndex = 6
		Me.FlowLayoutPanel3.WrapContents = False
		'
		'csharp
		'
		Me.csharp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.csharp.AutoSize = True
		Me.csharp.Checked = True
		Me.csharp.Location = New System.Drawing.Point(3, 3)
		Me.csharp.Name = "csharp"
		Me.csharp.Size = New System.Drawing.Size(39, 17)
		Me.csharp.TabIndex = 0
		Me.csharp.TabStop = True
		Me.csharp.Text = "C#"
		Me.csharp.UseVisualStyleBackColor = True
		'
		'vb
		'
		Me.vb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.vb.AutoSize = True
		Me.vb.Location = New System.Drawing.Point(48, 3)
		Me.vb.Name = "vb"
		Me.vb.Size = New System.Drawing.Size(64, 17)
		Me.vb.TabIndex = 1
		Me.vb.Text = "VB.NET"
		Me.vb.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.FlowLayoutPanel2.Controls.Add(Me.rbRetailer)
		Me.FlowLayoutPanel2.Controls.Add(Me.rbAcquirer)
		Me.FlowLayoutPanel2.Controls.Add(Me.rbTMS)
		Me.FlowLayoutPanel2.Controls.Add(Me.rbNone)
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(185, 3)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(250, 25)
		Me.FlowLayoutPanel2.TabIndex = 5
		Me.FlowLayoutPanel2.WrapContents = False
		'
		'rbRetailer
		'
		Me.rbRetailer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbRetailer.AutoSize = True
		Me.rbRetailer.Location = New System.Drawing.Point(3, 3)
		Me.rbRetailer.Name = "rbRetailer"
		Me.rbRetailer.Size = New System.Drawing.Size(61, 17)
		Me.rbRetailer.TabIndex = 0
		Me.rbRetailer.TabStop = True
		Me.rbRetailer.Text = "Retailer"
		Me.rbRetailer.UseVisualStyleBackColor = True
		'
		'rbAcquirer
		'
		Me.rbAcquirer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbAcquirer.AutoSize = True
		Me.rbAcquirer.Location = New System.Drawing.Point(70, 3)
		Me.rbAcquirer.Name = "rbAcquirer"
		Me.rbAcquirer.Size = New System.Drawing.Size(64, 17)
		Me.rbAcquirer.TabIndex = 1
		Me.rbAcquirer.TabStop = True
		Me.rbAcquirer.Text = "Acquirer"
		Me.rbAcquirer.UseVisualStyleBackColor = True
		'
		'rbTMS
		'
		Me.rbTMS.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbTMS.AutoSize = True
		Me.rbTMS.Location = New System.Drawing.Point(140, 3)
		Me.rbTMS.Name = "rbTMS"
		Me.rbTMS.Size = New System.Drawing.Size(48, 17)
		Me.rbTMS.TabIndex = 3
		Me.rbTMS.TabStop = True
		Me.rbTMS.Text = "TMS"
		Me.rbTMS.UseVisualStyleBackColor = True
		'
		'rbNone
		'
		Me.rbNone.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbNone.AutoSize = True
		Me.rbNone.Location = New System.Drawing.Point(194, 3)
		Me.rbNone.Name = "rbNone"
		Me.rbNone.Size = New System.Drawing.Size(51, 17)
		Me.rbNone.TabIndex = 2
		Me.rbNone.TabStop = True
		Me.rbNone.Text = "None"
		Me.rbNone.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.convertTypes, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.panelTypes, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 114)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(904, 29)
		Me.TableLayoutPanel2.TabIndex = 3
		'
		'convertTypes
		'
		Me.convertTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertTypes.AutoSize = True
		Me.convertTypes.Location = New System.Drawing.Point(3, 6)
		Me.convertTypes.Name = "convertTypes"
		Me.convertTypes.Size = New System.Drawing.Size(131, 17)
		Me.convertTypes.TabIndex = 0
		Me.convertTypes.Text = "Convert types to string"
		Me.convertTypes.UseVisualStyleBackColor = True
		'
		'panelTypes
		'
		Me.panelTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelTypes.AutoSize = True
		Me.panelTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelTypes.ColumnCount = 3
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelTypes.Controls.Add(Me.convertBoolean, 2, 0)
		Me.panelTypes.Controls.Add(Me.convertNumeric, 1, 0)
		Me.panelTypes.Controls.Add(Me.convertDateTime, 0, 0)
		Me.panelTypes.Location = New System.Drawing.Point(140, 3)
		Me.panelTypes.Name = "panelTypes"
		Me.panelTypes.RowCount = 1
		Me.panelTypes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelTypes.Size = New System.Drawing.Size(220, 23)
		Me.panelTypes.TabIndex = 9
		'
		'convertBoolean
		'
		Me.convertBoolean.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertBoolean.AutoSize = True
		Me.convertBoolean.Location = New System.Drawing.Point(152, 3)
		Me.convertBoolean.Name = "convertBoolean"
		Me.convertBoolean.Size = New System.Drawing.Size(65, 17)
		Me.convertBoolean.TabIndex = 2
		Me.convertBoolean.Text = "Boolean"
		Me.convertBoolean.UseVisualStyleBackColor = True
		'
		'convertNumeric
		'
		Me.convertNumeric.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertNumeric.AutoSize = True
		Me.convertNumeric.Location = New System.Drawing.Point(81, 3)
		Me.convertNumeric.Name = "convertNumeric"
		Me.convertNumeric.Size = New System.Drawing.Size(65, 17)
		Me.convertNumeric.TabIndex = 1
		Me.convertNumeric.Text = "Numeric"
		Me.convertNumeric.UseVisualStyleBackColor = True
		'
		'convertDateTime
		'
		Me.convertDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertDateTime.AutoSize = True
		Me.convertDateTime.Location = New System.Drawing.Point(3, 3)
		Me.convertDateTime.Name = "convertDateTime"
		Me.convertDateTime.Size = New System.Drawing.Size(72, 17)
		Me.convertDateTime.TabIndex = 0
		Me.convertDateTime.Text = "DateTime"
		Me.convertDateTime.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 40)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(904, 29)
		Me.TableLayoutPanel3.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Objects to add"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel4.AutoSize = True
		Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel4.ColumnCount = 4
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.cbNotations, 2, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.cbTypes, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.cbElements, 1, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(85, 3)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(816, 23)
		Me.TableLayoutPanel4.TabIndex = 9
		'
		'cbNotations
		'
		Me.cbNotations.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbNotations.AutoSize = True
		Me.cbNotations.Location = New System.Drawing.Point(178, 3)
		Me.cbNotations.Name = "cbNotations"
		Me.cbNotations.Size = New System.Drawing.Size(91, 17)
		Me.cbNotations.TabIndex = 2
		Me.cbNotations.Text = "Use notations"
		Me.cbNotations.UseVisualStyleBackColor = True
		'
		'cbTypes
		'
		Me.cbTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbTypes.AutoSize = True
		Me.cbTypes.Location = New System.Drawing.Point(3, 3)
		Me.cbTypes.Name = "cbTypes"
		Me.cbTypes.Size = New System.Drawing.Size(73, 17)
		Me.cbTypes.TabIndex = 0
		Me.cbTypes.Text = "Use types"
		Me.cbTypes.UseVisualStyleBackColor = True
		'
		'cbElements
		'
		Me.cbElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbElements.AutoSize = True
		Me.cbElements.Location = New System.Drawing.Point(82, 3)
		Me.cbElements.Name = "cbElements"
		Me.cbElements.Size = New System.Drawing.Size(90, 17)
		Me.cbElements.TabIndex = 1
		Me.cbElements.Text = "Use elements"
		Me.cbElements.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.arrayInitializer)
		Me.FlowLayoutPanel1.Controls.Add(Me.nullIfEmptyArray)
		Me.FlowLayoutPanel1.Controls.Add(Me.privateByInternal)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbStringToIntegral)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbUseDefaultValueForHasBeenModified)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbAddDefaultToEnum)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbAddBeginEnd)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbuseNullableIntegralTypes)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbOptimizing)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbRemoveAttribute)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbCreateAsElement)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbAdaptXmlText)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbUseList)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 149)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(904, 46)
		Me.FlowLayoutPanel1.TabIndex = 5
		'
		'arrayInitializer
		'
		Me.arrayInitializer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.arrayInitializer.AutoSize = True
		Me.arrayInitializer.Location = New System.Drawing.Point(3, 3)
		Me.arrayInitializer.Name = "arrayInitializer"
		Me.arrayInitializer.Size = New System.Drawing.Size(140, 17)
		Me.arrayInitializer.TabIndex = 0
		Me.arrayInitializer.Text = "Create an array initializer"
		Me.arrayInitializer.UseVisualStyleBackColor = True
		'
		'nullIfEmptyArray
		'
		Me.nullIfEmptyArray.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.nullIfEmptyArray.AutoSize = True
		Me.nullIfEmptyArray.Location = New System.Drawing.Point(149, 3)
		Me.nullIfEmptyArray.Name = "nullIfEmptyArray"
		Me.nullIfEmptyArray.Size = New System.Drawing.Size(184, 17)
		Me.nullIfEmptyArray.TabIndex = 1
		Me.nullIfEmptyArray.Text = "Get will return null if array is empty"
		Me.nullIfEmptyArray.UseVisualStyleBackColor = True
		'
		'privateByInternal
		'
		Me.privateByInternal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.privateByInternal.AutoSize = True
		Me.privateByInternal.Location = New System.Drawing.Point(339, 3)
		Me.privateByInternal.Name = "privateByInternal"
		Me.privateByInternal.Size = New System.Drawing.Size(152, 17)
		Me.privateByInternal.TabIndex = 2
		Me.privateByInternal.Text = "Replace private by internal"
		Me.privateByInternal.UseVisualStyleBackColor = True
		'
		'cbStringToIntegral
		'
		Me.cbStringToIntegral.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbStringToIntegral.AutoSize = True
		Me.cbStringToIntegral.Enabled = False
		Me.cbStringToIntegral.Location = New System.Drawing.Point(497, 3)
		Me.cbStringToIntegral.Name = "cbStringToIntegral"
		Me.cbStringToIntegral.Size = New System.Drawing.Size(102, 17)
		Me.cbStringToIntegral.TabIndex = 3
		Me.cbStringToIntegral.Text = "String to integral"
		Me.cbStringToIntegral.UseVisualStyleBackColor = True
		'
		'cbUseDefaultValueForHasBeenModified
		'
		Me.cbUseDefaultValueForHasBeenModified.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbUseDefaultValueForHasBeenModified.AutoSize = True
		Me.cbUseDefaultValueForHasBeenModified.Location = New System.Drawing.Point(605, 3)
		Me.cbUseDefaultValueForHasBeenModified.Name = "cbUseDefaultValueForHasBeenModified"
		Me.cbUseDefaultValueForHasBeenModified.Size = New System.Drawing.Size(162, 17)
		Me.cbUseDefaultValueForHasBeenModified.TabIndex = 4
		Me.cbUseDefaultValueForHasBeenModified.Text = "Use default value if available"
		Me.cbUseDefaultValueForHasBeenModified.UseVisualStyleBackColor = True
		'
		'cbAddDefaultToEnum
		'
		Me.cbAddDefaultToEnum.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbAddDefaultToEnum.AutoSize = True
		Me.cbAddDefaultToEnum.Location = New System.Drawing.Point(773, 3)
		Me.cbAddDefaultToEnum.Name = "cbAddDefaultToEnum"
		Me.cbAddDefaultToEnum.Size = New System.Drawing.Size(121, 17)
		Me.cbAddDefaultToEnum.TabIndex = 5
		Me.cbAddDefaultToEnum.Text = "Add default to enum"
		Me.cbAddDefaultToEnum.UseVisualStyleBackColor = True
		'
		'cbAddBeginEnd
		'
		Me.cbAddBeginEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbAddBeginEnd.AutoSize = True
		Me.cbAddBeginEnd.Location = New System.Drawing.Point(3, 26)
		Me.cbAddBeginEnd.Name = "cbAddBeginEnd"
		Me.cbAddBeginEnd.Size = New System.Drawing.Size(138, 17)
		Me.cbAddBeginEnd.TabIndex = 10
		Me.cbAddBeginEnd.Text = "Add begin/end to enum"
		Me.cbAddBeginEnd.UseVisualStyleBackColor = True
		'
		'cbuseNullableIntegralTypes
		'
		Me.cbuseNullableIntegralTypes.AutoSize = True
		Me.cbuseNullableIntegralTypes.Location = New System.Drawing.Point(147, 26)
		Me.cbuseNullableIntegralTypes.Name = "cbuseNullableIntegralTypes"
		Me.cbuseNullableIntegralTypes.Size = New System.Drawing.Size(149, 17)
		Me.cbuseNullableIntegralTypes.TabIndex = 11
		Me.cbuseNullableIntegralTypes.Text = "Use nullable integral types"
		Me.cbuseNullableIntegralTypes.UseVisualStyleBackColor = True
		'
		'cbOptimizing
		'
		Me.cbOptimizing.AutoSize = True
		Me.cbOptimizing.Location = New System.Drawing.Point(302, 26)
		Me.cbOptimizing.Name = "cbOptimizing"
		Me.cbOptimizing.Size = New System.Drawing.Size(94, 17)
		Me.cbOptimizing.TabIndex = 12
		Me.cbOptimizing.Text = "Use optimizing"
		Me.cbOptimizing.UseVisualStyleBackColor = True
		'
		'cbRemoveAttribute
		'
		Me.cbRemoveAttribute.AutoSize = True
		Me.cbRemoveAttribute.Enabled = False
		Me.cbRemoveAttribute.Location = New System.Drawing.Point(402, 26)
		Me.cbRemoveAttribute.Name = "cbRemoveAttribute"
		Me.cbRemoveAttribute.Size = New System.Drawing.Size(125, 17)
		Me.cbRemoveAttribute.TabIndex = 13
		Me.cbRemoveAttribute.Text = "Remove XmlAttribute"
		Me.cbRemoveAttribute.UseVisualStyleBackColor = True
		'
		'cbCreateAsElement
		'
		Me.cbCreateAsElement.AutoSize = True
		Me.cbCreateAsElement.Location = New System.Drawing.Point(533, 26)
		Me.cbCreateAsElement.Name = "cbCreateAsElement"
		Me.cbCreateAsElement.Size = New System.Drawing.Size(119, 17)
		Me.cbCreateAsElement.TabIndex = 14
		Me.cbCreateAsElement.Text = "Attribute as element"
		Me.cbCreateAsElement.UseVisualStyleBackColor = True
		'
		'cbAdaptXmlText
		'
		Me.cbAdaptXmlText.AutoSize = True
		Me.cbAdaptXmlText.Location = New System.Drawing.Point(658, 26)
		Me.cbAdaptXmlText.Name = "cbAdaptXmlText"
		Me.cbAdaptXmlText.Size = New System.Drawing.Size(95, 17)
		Me.cbAdaptXmlText.TabIndex = 15
		Me.cbAdaptXmlText.Text = "Adapt XmlText"
		Me.cbAdaptXmlText.UseVisualStyleBackColor = True
		'
		'cbUseList
		'
		Me.cbUseList.AutoSize = True
		Me.cbUseList.Enabled = False
		Me.cbUseList.Location = New System.Drawing.Point(759, 26)
		Me.cbUseList.Name = "cbUseList"
		Me.cbUseList.Size = New System.Drawing.Size(64, 17)
		Me.cbUseList.TabIndex = 16
		Me.cbUseList.Text = "Use List"
		Me.cbUseList.UseVisualStyleBackColor = True
		'
		'result
		'
		Me.result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.result.Location = New System.Drawing.Point(3, 286)
		Me.result.Multiline = True
		Me.result.Name = "result"
		Me.result.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.result.Size = New System.Drawing.Size(916, 87)
		Me.result.TabIndex = 0
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.DefaultExt = "xsd"
		Me.OpenFileDialog1.Filter = "XSD files|*.xsd|All files|*.*"
		Me.OpenFileDialog1.Multiselect = True
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.RestoreDirectory = True
		'
		'myXSD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.pbClose
		Me.ClientSize = New System.Drawing.Size(946, 443)
		Me.Controls.Add(Me.panelMain)
		Me.Name = "myXSD"
		Me.Text = "myXSD generator"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.panelGenerateButtons.ResumeLayout(False)
		Me.panelGenerateButtons.PerformLayout()
		Me.panelSettings.ResumeLayout(False)
		Me.panelSettings.PerformLayout()
		Me.panelFiles.ResumeLayout(False)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.panelOptions.ResumeLayout(False)
		Me.panelOptions.PerformLayout()
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.panelInterface.ResumeLayout(False)
		Me.panelInterface.PerformLayout()
		Me.panelCOM.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.panelTypes.ResumeLayout(False)
		Me.panelTypes.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As TableLayoutPanel
	Friend WithEvents panelButtons As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents panelSettings As TableLayoutPanel
	Friend WithEvents panelFiles As TableLayoutPanel
	Friend WithEvents files As ListBox
	Friend WithEvents pbFiles As Button
	Friend WithEvents panelOptions As TableLayoutPanel
	Friend WithEvents result As TextBox
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents pbClose As Button
	Friend WithEvents pbGenerate As Button
	Friend WithEvents pbSave As Button
	Friend WithEvents nmspace As TextBox
	Friend WithEvents vb As RadioButton
	Friend WithEvents csharp As RadioButton
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents RemoveFileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RemoveAllFilesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents cbTypes As CheckBox
	Friend WithEvents cbElements As CheckBox
	Friend WithEvents cbNotations As CheckBox
	Friend WithEvents convertDateTime As CheckBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents convertTypes As CheckBox
	Friend WithEvents convertBoolean As CheckBox
	Friend WithEvents convertNumeric As CheckBox
	Friend WithEvents panelTypes As TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents arrayInitializer As CheckBox
	Friend WithEvents nullIfEmptyArray As CheckBox
	Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
	Friend WithEvents Label3 As Label
	Friend WithEvents classVisible As CheckBox
	Friend WithEvents addDispid As CheckBox
	Friend WithEvents createInterface As CheckBox
	Friend WithEvents classInterface As ComboBox
	Friend WithEvents enumVisible As CheckBox
	Friend WithEvents comInterface As ComboBox
	Friend WithEvents privateByInternal As CheckBox
	Friend WithEvents status As Label
	Friend WithEvents efPreprocessor As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents pbGenerateNFiles As Button
	Friend WithEvents panelInterface As TableLayoutPanel
	Friend WithEvents panelCOM As TableLayoutPanel
	Friend WithEvents Label5 As Label
	Friend WithEvents panelGenerateButtons As TableLayoutPanel
	Friend WithEvents cbSilent As CheckBox
	Friend WithEvents cbStringToIntegral As CheckBox
	Friend WithEvents cbUseDefaultValueForHasBeenModified As CheckBox
	Friend WithEvents cbAddDefaultToEnum As CheckBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents cbAddBeginEnd As CheckBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents rbRetailer As RadioButton
	Friend WithEvents rbAcquirer As RadioButton
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents rbNone As RadioButton
	Friend WithEvents rbTMS As RadioButton
	Friend WithEvents cbuseNullableIntegralTypes As CheckBox
	Friend WithEvents cbOptimizing As CheckBox
	Friend WithEvents cbRemoveAttribute As CheckBox
	Friend WithEvents cbCreateAsElement As CheckBox
	Friend WithEvents cbAdaptXmlText As CheckBox
	Friend WithEvents cbUseList As CheckBox
End Class
