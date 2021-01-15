<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myXSD
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.panelButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbClose = New System.Windows.Forms.Button()
		Me.pbGenerate = New System.Windows.Forms.Button()
		Me.pbSave = New System.Windows.Forms.Button()
		Me.status = New System.Windows.Forms.Label()
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
		Me.comInterface = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.addDispid = New System.Windows.Forms.CheckBox()
		Me.createInterface = New System.Windows.Forms.CheckBox()
		Me.classInterface = New System.Windows.Forms.ComboBox()
		Me.classVisible = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.panelLanguage = New System.Windows.Forms.TableLayoutPanel()
		Me.vb = New System.Windows.Forms.RadioButton()
		Me.csharp = New System.Windows.Forms.RadioButton()
		Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.nmspace = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
		Me.efPreprocessor = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.convertTypes = New System.Windows.Forms.CheckBox()
		Me.panelTypes = New System.Windows.Forms.TableLayoutPanel()
		Me.convertDateTime = New System.Windows.Forms.CheckBox()
		Me.convertBoolean = New System.Windows.Forms.CheckBox()
		Me.convertNumeric = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbNotations = New System.Windows.Forms.CheckBox()
		Me.cbTypes = New System.Windows.Forms.CheckBox()
		Me.cbElements = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.automaticArrays = New System.Windows.Forms.CheckBox()
		Me.manageInit = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.arrayInitializer = New System.Windows.Forms.CheckBox()
		Me.nullIfEmptyArray = New System.Windows.Forms.CheckBox()
		Me.privateByInternal = New System.Windows.Forms.CheckBox()
		Me.result = New System.Windows.Forms.TextBox()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.panelMain.SuspendLayout()
		Me.panelButtons.SuspendLayout()
		Me.panelSettings.SuspendLayout()
		Me.panelFiles.SuspendLayout()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.panelOptions.SuspendLayout()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.panelLanguage.SuspendLayout()
		Me.TableLayoutPanel8.SuspendLayout()
		Me.TableLayoutPanel9.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.panelTypes.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.TableLayoutPanel5.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
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
		Me.panelMain.Size = New System.Drawing.Size(842, 376)
		Me.panelMain.TabIndex = 0
		'
		'panelButtons
		'
		Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelButtons.AutoSize = True
		Me.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelButtons.ColumnCount = 5
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.Controls.Add(Me.pbClose, 4, 0)
		Me.panelButtons.Controls.Add(Me.pbGenerate, 1, 0)
		Me.panelButtons.Controls.Add(Me.pbSave, 3, 0)
		Me.panelButtons.Controls.Add(Me.status, 0, 0)
		Me.panelButtons.Controls.Add(Me.pbGenerateNFiles, 2, 0)
		Me.panelButtons.Location = New System.Drawing.Point(3, 344)
		Me.panelButtons.Name = "panelButtons"
		Me.panelButtons.RowCount = 1
		Me.panelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.Size = New System.Drawing.Size(836, 29)
		Me.panelButtons.TabIndex = 1
		'
		'pbClose
		'
		Me.pbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbClose.AutoSize = True
		Me.pbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbClose.Location = New System.Drawing.Point(790, 3)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(43, 23)
		Me.pbClose.TabIndex = 3
		Me.pbClose.Text = "Close"
		Me.pbClose.UseVisualStyleBackColor = True
		'
		'pbGenerate
		'
		Me.pbGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbGenerate.AutoSize = True
		Me.pbGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbGenerate.Location = New System.Drawing.Point(523, 3)
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
		Me.pbSave.Location = New System.Drawing.Point(714, 3)
		Me.pbSave.Name = "pbSave"
		Me.pbSave.Size = New System.Drawing.Size(70, 23)
		Me.pbSave.TabIndex = 2
		Me.pbSave.Text = "Save to file"
		Me.pbSave.UseVisualStyleBackColor = True
		'
		'status
		'
		Me.status.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.status.AutoSize = True
		Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status.Location = New System.Drawing.Point(3, 6)
		Me.status.Name = "status"
		Me.status.Size = New System.Drawing.Size(514, 16)
		Me.status.TabIndex = 3
		Me.status.Text = "Label4"
		'
		'pbGenerateNFiles
		'
		Me.pbGenerateNFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbGenerateNFiles.AutoSize = True
		Me.pbGenerateNFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbGenerateNFiles.Location = New System.Drawing.Point(615, 3)
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
		Me.panelSettings.Size = New System.Drawing.Size(836, 214)
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
		Me.panelFiles.Size = New System.Drawing.Size(830, 67)
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
		Me.files.Size = New System.Drawing.Size(924, 61)
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
		Me.panelOptions.ColumnCount = 2
		Me.panelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel6, 0, 1)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel1, 0, 0)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel2, 0, 2)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel3, 1, 0)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel5, 1, 3)
		Me.panelOptions.Controls.Add(Me.TableLayoutPanel7, 0, 3)
		Me.panelOptions.Location = New System.Drawing.Point(3, 76)
		Me.panelOptions.Name = "panelOptions"
		Me.panelOptions.RowCount = 4
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.Size = New System.Drawing.Size(830, 135)
		Me.panelOptions.TabIndex = 1
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel6.AutoSize = True
		Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel6.ColumnCount = 7
		Me.panelOptions.SetColumnSpan(Me.TableLayoutPanel6, 2)
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.Controls.Add(Me.enumVisible, 6, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.comInterface, 5, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.addDispid, 3, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.createInterface, 4, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.classInterface, 2, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.classVisible, 1, 0)
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 41)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 1
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(824, 27)
		Me.TableLayoutPanel6.TabIndex = 2
		'
		'enumVisible
		'
		Me.enumVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.enumVisible.AutoSize = True
		Me.enumVisible.Location = New System.Drawing.Point(706, 5)
		Me.enumVisible.Name = "enumVisible"
		Me.enumVisible.Size = New System.Drawing.Size(115, 17)
		Me.enumVisible.TabIndex = 6
		Me.enumVisible.Text = "Make enum Visible"
		Me.enumVisible.UseVisualStyleBackColor = True
		'
		'comInterface
		'
		Me.comInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comInterface.FormattingEnabled = True
		Me.comInterface.Items.AddRange(New Object() {"InterfaceIsDual", "InterfaceIsIUnknown", "InterfaceIsIDispatch"})
		Me.comInterface.Location = New System.Drawing.Point(547, 3)
		Me.comInterface.Name = "comInterface"
		Me.comInterface.Size = New System.Drawing.Size(153, 21)
		Me.comInterface.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 7)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "COM visibility"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'addDispid
		'
		Me.addDispid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.addDispid.AutoSize = True
		Me.addDispid.Location = New System.Drawing.Point(355, 5)
		Me.addDispid.Name = "addDispid"
		Me.addDispid.Size = New System.Drawing.Size(78, 17)
		Me.addDispid.TabIndex = 3
		Me.addDispid.Text = "Add DispId"
		Me.addDispid.UseVisualStyleBackColor = True
		'
		'createInterface
		'
		Me.createInterface.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.createInterface.AutoSize = True
		Me.createInterface.Location = New System.Drawing.Point(439, 5)
		Me.createInterface.Name = "createInterface"
		Me.createInterface.Size = New System.Drawing.Size(102, 17)
		Me.createInterface.TabIndex = 4
		Me.createInterface.Text = "Create Interface"
		Me.createInterface.UseVisualStyleBackColor = True
		'
		'classInterface
		'
		Me.classInterface.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.classInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.classInterface.FormattingEnabled = True
		Me.classInterface.Items.AddRange(New Object() {"None", "AutoDispatch", "AutoDual"})
		Me.classInterface.Location = New System.Drawing.Point(196, 3)
		Me.classInterface.Name = "classInterface"
		Me.classInterface.Size = New System.Drawing.Size(153, 21)
		Me.classInterface.TabIndex = 2
		'
		'classVisible
		'
		Me.classVisible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.classVisible.AutoSize = True
		Me.classVisible.Location = New System.Drawing.Point(78, 5)
		Me.classVisible.Name = "classVisible"
		Me.classVisible.Size = New System.Drawing.Size(112, 17)
		Me.classVisible.TabIndex = 1
		Me.classVisible.Text = "Make class visible"
		Me.classVisible.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.panelLanguage, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel9, 2, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(409, 32)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'panelLanguage
		'
		Me.panelLanguage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelLanguage.AutoSize = True
		Me.panelLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelLanguage.ColumnCount = 2
		Me.panelLanguage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelLanguage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelLanguage.Controls.Add(Me.vb, 1, 0)
		Me.panelLanguage.Controls.Add(Me.csharp, 0, 0)
		Me.panelLanguage.Location = New System.Drawing.Point(134, 3)
		Me.panelLanguage.Name = "panelLanguage"
		Me.panelLanguage.RowCount = 1
		Me.panelLanguage.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelLanguage.Size = New System.Drawing.Size(140, 26)
		Me.panelLanguage.TabIndex = 1
		'
		'vb
		'
		Me.vb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.vb.AutoSize = True
		Me.vb.Location = New System.Drawing.Point(73, 4)
		Me.vb.Name = "vb"
		Me.vb.Size = New System.Drawing.Size(64, 17)
		Me.vb.TabIndex = 1
		Me.vb.Text = "VB.NET"
		Me.vb.UseVisualStyleBackColor = True
		'
		'csharp
		'
		Me.csharp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.csharp.AutoSize = True
		Me.csharp.Checked = True
		Me.csharp.Location = New System.Drawing.Point(3, 4)
		Me.csharp.Name = "csharp"
		Me.csharp.Size = New System.Drawing.Size(64, 17)
		Me.csharp.TabIndex = 0
		Me.csharp.TabStop = True
		Me.csharp.Text = "C#"
		Me.csharp.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel8
		'
		Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel8.AutoSize = True
		Me.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel8.ColumnCount = 2
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel8.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel8.Controls.Add(Me.nmspace, 1, 0)
		Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
		Me.TableLayoutPanel8.RowCount = 1
		Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel8.Size = New System.Drawing.Size(125, 26)
		Me.TableLayoutPanel8.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Namespace:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'nmspace
		'
		Me.nmspace.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.nmspace.Location = New System.Drawing.Point(76, 3)
		Me.nmspace.Name = "nmspace"
		Me.nmspace.Size = New System.Drawing.Size(46, 20)
		Me.nmspace.TabIndex = 0
		Me.nmspace.Text = "myXSD"
		'
		'TableLayoutPanel9
		'
		Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel9.AutoSize = True
		Me.TableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel9.ColumnCount = 2
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel9.Controls.Add(Me.efPreprocessor, 0, 0)
		Me.TableLayoutPanel9.Controls.Add(Me.Label4, 0, 0)
		Me.TableLayoutPanel9.Location = New System.Drawing.Point(280, 3)
		Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
		Me.TableLayoutPanel9.RowCount = 1
		Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel9.Size = New System.Drawing.Size(126, 26)
		Me.TableLayoutPanel9.TabIndex = 2
		'
		'efPreprocessor
		'
		Me.efPreprocessor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efPreprocessor.Location = New System.Drawing.Point(81, 3)
		Me.efPreprocessor.Name = "efPreprocessor"
		Me.efPreprocessor.ReadOnly = True
		Me.efPreprocessor.Size = New System.Drawing.Size(42, 20)
		Me.efPreprocessor.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 6)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 13)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Preprocessor:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.convertTypes, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.panelTypes, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 74)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(409, 29)
		Me.TableLayoutPanel2.TabIndex = 3
		'
		'convertTypes
		'
		Me.convertTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertTypes.AutoSize = True
		Me.convertTypes.Location = New System.Drawing.Point(3, 6)
		Me.convertTypes.Name = "convertTypes"
		Me.convertTypes.Size = New System.Drawing.Size(91, 17)
		Me.convertTypes.TabIndex = 0
		Me.convertTypes.Text = "Convert types"
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
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.panelTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.panelTypes.Controls.Add(Me.convertDateTime, 0, 0)
		Me.panelTypes.Controls.Add(Me.convertBoolean, 2, 0)
		Me.panelTypes.Controls.Add(Me.convertNumeric, 1, 0)
		Me.panelTypes.Location = New System.Drawing.Point(100, 3)
		Me.panelTypes.Name = "panelTypes"
		Me.panelTypes.RowCount = 1
		Me.panelTypes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelTypes.Size = New System.Drawing.Size(306, 23)
		Me.panelTypes.TabIndex = 9
		'
		'convertDateTime
		'
		Me.convertDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertDateTime.AutoSize = True
		Me.convertDateTime.Location = New System.Drawing.Point(3, 3)
		Me.convertDateTime.Name = "convertDateTime"
		Me.convertDateTime.Size = New System.Drawing.Size(96, 17)
		Me.convertDateTime.TabIndex = 0
		Me.convertDateTime.Text = "DateTime"
		Me.convertDateTime.UseVisualStyleBackColor = True
		'
		'convertBoolean
		'
		Me.convertBoolean.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertBoolean.AutoSize = True
		Me.convertBoolean.Location = New System.Drawing.Point(207, 3)
		Me.convertBoolean.Name = "convertBoolean"
		Me.convertBoolean.Size = New System.Drawing.Size(96, 17)
		Me.convertBoolean.TabIndex = 2
		Me.convertBoolean.Text = "Boolean"
		Me.convertBoolean.UseVisualStyleBackColor = True
		'
		'convertNumeric
		'
		Me.convertNumeric.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.convertNumeric.AutoSize = True
		Me.convertNumeric.Location = New System.Drawing.Point(105, 3)
		Me.convertNumeric.Name = "convertNumeric"
		Me.convertNumeric.Size = New System.Drawing.Size(96, 17)
		Me.convertNumeric.TabIndex = 1
		Me.convertNumeric.Text = "Numeric"
		Me.convertNumeric.UseVisualStyleBackColor = True
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
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(418, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(409, 32)
		Me.TableLayoutPanel3.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 9)
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
		Me.TableLayoutPanel4.ColumnCount = 3
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TableLayoutPanel4.Controls.Add(Me.cbNotations, 2, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.cbTypes, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.cbElements, 1, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(85, 3)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(321, 26)
		Me.TableLayoutPanel4.TabIndex = 9
		'
		'cbNotations
		'
		Me.cbNotations.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbNotations.AutoSize = True
		Me.cbNotations.Location = New System.Drawing.Point(216, 4)
		Me.cbNotations.Name = "cbNotations"
		Me.cbNotations.Size = New System.Drawing.Size(102, 17)
		Me.cbNotations.TabIndex = 2
		Me.cbNotations.Text = "Use notations"
		Me.cbNotations.UseVisualStyleBackColor = True
		'
		'cbTypes
		'
		Me.cbTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbTypes.AutoSize = True
		Me.cbTypes.Location = New System.Drawing.Point(3, 4)
		Me.cbTypes.Name = "cbTypes"
		Me.cbTypes.Size = New System.Drawing.Size(100, 17)
		Me.cbTypes.TabIndex = 0
		Me.cbTypes.Text = "Use types"
		Me.cbTypes.UseVisualStyleBackColor = True
		'
		'cbElements
		'
		Me.cbElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbElements.AutoSize = True
		Me.cbElements.Location = New System.Drawing.Point(109, 4)
		Me.cbElements.Name = "cbElements"
		Me.cbElements.Size = New System.Drawing.Size(101, 17)
		Me.cbElements.TabIndex = 1
		Me.cbElements.Text = "Use elements"
		Me.cbElements.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel5.AutoSize = True
		Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel5.ColumnCount = 3
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel5.Controls.Add(Me.automaticArrays, 0, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.manageInit, 0, 0)
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(418, 109)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 1
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(409, 23)
		Me.TableLayoutPanel5.TabIndex = 5
		'
		'automaticArrays
		'
		Me.automaticArrays.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.automaticArrays.AutoSize = True
		Me.automaticArrays.Location = New System.Drawing.Point(110, 3)
		Me.automaticArrays.Name = "automaticArrays"
		Me.automaticArrays.Size = New System.Drawing.Size(160, 17)
		Me.automaticArrays.TabIndex = 2
		Me.automaticArrays.Text = "Automatically manage arrays"
		Me.automaticArrays.UseVisualStyleBackColor = True
		'
		'manageInit
		'
		Me.manageInit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.manageInit.AutoSize = True
		Me.manageInit.Location = New System.Drawing.Point(3, 3)
		Me.manageInit.Name = "manageInit"
		Me.manageInit.Size = New System.Drawing.Size(101, 17)
		Me.manageInit.TabIndex = 1
		Me.manageInit.Text = "Manage init flag"
		Me.manageInit.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel7.AutoSize = True
		Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel7.ColumnCount = 3
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.Controls.Add(Me.arrayInitializer, 0, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.nullIfEmptyArray, 1, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.privateByInternal, 2, 0)
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 109)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 1
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(409, 23)
		Me.TableLayoutPanel7.TabIndex = 4
		'
		'arrayInitializer
		'
		Me.arrayInitializer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.arrayInitializer.AutoSize = True
		Me.arrayInitializer.Location = New System.Drawing.Point(3, 3)
		Me.arrayInitializer.Name = "arrayInitializer"
		Me.arrayInitializer.Size = New System.Drawing.Size(92, 17)
		Me.arrayInitializer.TabIndex = 0
		Me.arrayInitializer.Text = "Array initializer"
		Me.arrayInitializer.UseVisualStyleBackColor = True
		'
		'nullIfEmptyArray
		'
		Me.nullIfEmptyArray.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.nullIfEmptyArray.AutoSize = True
		Me.nullIfEmptyArray.Location = New System.Drawing.Point(101, 3)
		Me.nullIfEmptyArray.Name = "nullIfEmptyArray"
		Me.nullIfEmptyArray.Size = New System.Drawing.Size(142, 17)
		Me.nullIfEmptyArray.TabIndex = 1
		Me.nullIfEmptyArray.Text = "Return null if empty array"
		Me.nullIfEmptyArray.UseVisualStyleBackColor = True
		'
		'privateByInternal
		'
		Me.privateByInternal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.privateByInternal.AutoSize = True
		Me.privateByInternal.Location = New System.Drawing.Point(249, 3)
		Me.privateByInternal.Name = "privateByInternal"
		Me.privateByInternal.Size = New System.Drawing.Size(157, 17)
		Me.privateByInternal.TabIndex = 2
		Me.privateByInternal.Text = "Private by Internal"
		Me.privateByInternal.UseVisualStyleBackColor = True
		'
		'result
		'
		Me.result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.result.Location = New System.Drawing.Point(3, 223)
		Me.result.Multiline = True
		Me.result.Name = "result"
		Me.result.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.result.Size = New System.Drawing.Size(836, 115)
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
		Me.ClientSize = New System.Drawing.Size(866, 402)
		Me.Controls.Add(Me.panelMain)
		Me.Name = "myXSD"
		Me.Text = "myXSD generator"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.panelSettings.ResumeLayout(False)
		Me.panelSettings.PerformLayout()
		Me.panelFiles.ResumeLayout(False)
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.panelOptions.ResumeLayout(False)
		Me.panelOptions.PerformLayout()
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.panelLanguage.ResumeLayout(False)
		Me.panelLanguage.PerformLayout()
		Me.TableLayoutPanel8.ResumeLayout(False)
		Me.TableLayoutPanel8.PerformLayout()
		Me.TableLayoutPanel9.ResumeLayout(False)
		Me.TableLayoutPanel9.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.panelTypes.ResumeLayout(False)
		Me.panelTypes.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel7.PerformLayout()
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
	Friend WithEvents panelLanguage As TableLayoutPanel
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
	Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
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
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents manageInit As CheckBox
	Friend WithEvents automaticArrays As CheckBox
	Friend WithEvents status As Label
	Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
	Friend WithEvents efPreprocessor As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents pbGenerateNFiles As Button
End Class
