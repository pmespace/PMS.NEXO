<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSettings
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
		Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.panelButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbSaveSettings = New System.Windows.Forms.Button()
		Me.pbSave = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.panelSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.panelNexoSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.panelNexoSettingsSalePOI = New System.Windows.Forms.TableLayoutPanel()
		Me.efSaleID = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbSaleIDUSeIP = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cbPOIIDUseIP = New System.Windows.Forms.CheckBox()
		Me.efPOIID = New System.Windows.Forms.TextBox()
		Me.panelServerSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.efServerIP = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.udServerPort = New System.Windows.Forms.NumericUpDown()
		Me.pbTestConnection = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.efApplicationName = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.efSoftwareVersion = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.efManufacturerName = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cbxCurrency = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.udDecimals = New System.Windows.Forms.NumericUpDown()
		Me.cbSynchronousTerminal = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.efCertificationCode = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.udAutocloseDelay = New System.Windows.Forms.NumericUpDown()
		Me.cbAutoclose = New System.Windows.Forms.CheckBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.udMaxTimer = New System.Windows.Forms.NumericUpDown()
		Me.panelMain.SuspendLayout()
		Me.panelButtons.SuspendLayout()
		Me.panelSettings.SuspendLayout()
		Me.panelNexoSettings.SuspendLayout()
		Me.panelNexoSettingsSalePOI.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.panelServerSettings.SuspendLayout()
		CType(Me.udServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel5.SuspendLayout()
		CType(Me.udDecimals, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
		CType(Me.udAutocloseDelay, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.udMaxTimer, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.panelMain.Controls.Add(Me.panelButtons, 0, 1)
		Me.panelMain.Controls.Add(Me.panelSettings, 0, 0)
		Me.panelMain.Location = New System.Drawing.Point(12, 12)
		Me.panelMain.Name = "panelMain"
		Me.panelMain.RowCount = 2
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.Size = New System.Drawing.Size(776, 426)
		Me.panelMain.TabIndex = 0
		'
		'panelButtons
		'
		Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelButtons.AutoSize = True
		Me.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelButtons.ColumnCount = 4
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.Controls.Add(Me.pbSaveSettings, 0, 0)
		Me.panelButtons.Controls.Add(Me.pbSave, 2, 0)
		Me.panelButtons.Controls.Add(Me.pbCancel, 3, 0)
		Me.panelButtons.Location = New System.Drawing.Point(3, 394)
		Me.panelButtons.Name = "panelButtons"
		Me.panelButtons.RowCount = 1
		Me.panelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelButtons.Size = New System.Drawing.Size(770, 29)
		Me.panelButtons.TabIndex = 0
		'
		'pbSaveSettings
		'
		Me.pbSaveSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSaveSettings.AutoSize = True
		Me.pbSaveSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbSaveSettings.Location = New System.Drawing.Point(3, 3)
		Me.pbSaveSettings.Name = "pbSaveSettings"
		Me.pbSaveSettings.Size = New System.Drawing.Size(81, 23)
		Me.pbSaveSettings.TabIndex = 2
		Me.pbSaveSettings.Text = "Save settings"
		Me.pbSaveSettings.UseVisualStyleBackColor = True
		'
		'pbSave
		'
		Me.pbSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSave.AutoSize = True
		Me.pbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSave.Location = New System.Drawing.Point(669, 3)
		Me.pbSave.Name = "pbSave"
		Me.pbSave.Size = New System.Drawing.Size(42, 23)
		Me.pbSave.TabIndex = 0
		Me.pbSave.Text = "&Save"
		Me.pbSave.UseVisualStyleBackColor = True
		'
		'pbCancel
		'
		Me.pbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCancel.AutoSize = True
		Me.pbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbCancel.Location = New System.Drawing.Point(717, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(50, 23)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "&Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
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
		Me.panelSettings.Controls.Add(Me.panelNexoSettings, 0, 0)
		Me.panelSettings.Controls.Add(Me.panelServerSettings, 0, 1)
		Me.panelSettings.Controls.Add(Me.TableLayoutPanel7, 0, 3)
		Me.panelSettings.Location = New System.Drawing.Point(3, 3)
		Me.panelSettings.Name = "panelSettings"
		Me.panelSettings.RowCount = 5
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelSettings.Size = New System.Drawing.Size(770, 385)
		Me.panelSettings.TabIndex = 1
		'
		'panelNexoSettings
		'
		Me.panelNexoSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelNexoSettings.AutoSize = True
		Me.panelNexoSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelNexoSettings.ColumnCount = 3
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel5, 0, 2)
		Me.panelNexoSettings.Controls.Add(Me.panelNexoSettingsSalePOI, 0, 0)
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel4, 1, 0)
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel1, 0, 1)
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel2, 2, 1)
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel3, 1, 1)
		Me.panelNexoSettings.Controls.Add(Me.TableLayoutPanel6, 2, 2)
		Me.panelNexoSettings.Location = New System.Drawing.Point(3, 3)
		Me.panelNexoSettings.Name = "panelNexoSettings"
		Me.panelNexoSettings.RowCount = 4
		Me.panelNexoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelNexoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelNexoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelNexoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelNexoSettings.Size = New System.Drawing.Size(764, 117)
		Me.panelNexoSettings.TabIndex = 0
		'
		'panelNexoSettingsSalePOI
		'
		Me.panelNexoSettingsSalePOI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelNexoSettingsSalePOI.AutoSize = True
		Me.panelNexoSettingsSalePOI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelNexoSettingsSalePOI.ColumnCount = 3
		Me.panelNexoSettingsSalePOI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelNexoSettingsSalePOI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelNexoSettingsSalePOI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelNexoSettingsSalePOI.Controls.Add(Me.efSaleID, 1, 0)
		Me.panelNexoSettingsSalePOI.Controls.Add(Me.Label1, 0, 0)
		Me.panelNexoSettingsSalePOI.Controls.Add(Me.cbSaleIDUSeIP, 2, 0)
		Me.panelNexoSettingsSalePOI.Location = New System.Drawing.Point(3, 3)
		Me.panelNexoSettingsSalePOI.Name = "panelNexoSettingsSalePOI"
		Me.panelNexoSettingsSalePOI.RowCount = 1
		Me.panelNexoSettingsSalePOI.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelNexoSettingsSalePOI.Size = New System.Drawing.Size(248, 26)
		Me.panelNexoSettingsSalePOI.TabIndex = 0
		'
		'efSaleID
		'
		Me.efSaleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efSaleID.Location = New System.Drawing.Point(51, 3)
		Me.efSaleID.Name = "efSaleID"
		Me.efSaleID.Size = New System.Drawing.Size(130, 20)
		Me.efSaleID.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "SaleID:"
		'
		'cbSaleIDUSeIP
		'
		Me.cbSaleIDUSeIP.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbSaleIDUSeIP.AutoSize = True
		Me.cbSaleIDUSeIP.Location = New System.Drawing.Point(187, 4)
		Me.cbSaleIDUSeIP.Name = "cbSaleIDUSeIP"
		Me.cbSaleIDUSeIP.Size = New System.Drawing.Size(58, 17)
		Me.cbSaleIDUSeIP.TabIndex = 2
		Me.cbSaleIDUSeIP.Text = "Use IP"
		Me.cbSaleIDUSeIP.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel4.AutoSize = True
		Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel4.ColumnCount = 3
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.cbPOIIDUseIP, 2, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.efPOIID, 1, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(257, 3)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(248, 26)
		Me.TableLayoutPanel4.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 6)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "POIID:"
		'
		'cbPOIIDUseIP
		'
		Me.cbPOIIDUseIP.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbPOIIDUseIP.AutoSize = True
		Me.cbPOIIDUseIP.Location = New System.Drawing.Point(187, 4)
		Me.cbPOIIDUseIP.Name = "cbPOIIDUseIP"
		Me.cbPOIIDUseIP.Size = New System.Drawing.Size(58, 17)
		Me.cbPOIIDUseIP.TabIndex = 3
		Me.cbPOIIDUseIP.Text = "Use IP"
		Me.cbPOIIDUseIP.UseVisualStyleBackColor = True
		'
		'efPOIID
		'
		Me.efPOIID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efPOIID.Location = New System.Drawing.Point(48, 3)
		Me.efPOIID.Name = "efPOIID"
		Me.efPOIID.Size = New System.Drawing.Size(133, 20)
		Me.efPOIID.TabIndex = 0
		'
		'panelServerSettings
		'
		Me.panelServerSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelServerSettings.AutoSize = True
		Me.panelServerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelServerSettings.ColumnCount = 9
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerSettings.Controls.Add(Me.udMaxTimer, 7, 0)
		Me.panelServerSettings.Controls.Add(Me.Label11, 6, 0)
		Me.panelServerSettings.Controls.Add(Me.efServerIP, 1, 0)
		Me.panelServerSettings.Controls.Add(Me.Label3, 0, 0)
		Me.panelServerSettings.Controls.Add(Me.Label5, 2, 0)
		Me.panelServerSettings.Controls.Add(Me.udServerPort, 3, 0)
		Me.panelServerSettings.Controls.Add(Me.pbTestConnection, 4, 0)
		Me.panelServerSettings.Controls.Add(Me.cbSynchronousTerminal, 5, 0)
		Me.panelServerSettings.Location = New System.Drawing.Point(3, 126)
		Me.panelServerSettings.Name = "panelServerSettings"
		Me.panelServerSettings.RowCount = 1
		Me.panelServerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelServerSettings.Size = New System.Drawing.Size(764, 29)
		Me.panelServerSettings.TabIndex = 2
		'
		'efServerIP
		'
		Me.efServerIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efServerIP.Location = New System.Drawing.Point(72, 4)
		Me.efServerIP.Name = "efServerIP"
		Me.efServerIP.Size = New System.Drawing.Size(105, 20)
		Me.efServerIP.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 8)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 13)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Terminal IP:"
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(183, 8)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Terminal port:"
		'
		'udServerPort
		'
		Me.udServerPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udServerPort.Location = New System.Drawing.Point(260, 4)
		Me.udServerPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udServerPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.udServerPort.Name = "udServerPort"
		Me.udServerPort.Size = New System.Drawing.Size(57, 20)
		Me.udServerPort.TabIndex = 3
		Me.udServerPort.Value = New Decimal(New Integer() {2018, 0, 0, 0})
		'
		'pbTestConnection
		'
		Me.pbTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbTestConnection.AutoSize = True
		Me.pbTestConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbTestConnection.Location = New System.Drawing.Point(323, 3)
		Me.pbTestConnection.Name = "pbTestConnection"
		Me.pbTestConnection.Size = New System.Drawing.Size(94, 23)
		Me.pbTestConnection.TabIndex = 4
		Me.pbTestConnection.Text = "&Test connection"
		Me.pbTestConnection.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.efApplicationName, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 35)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(248, 26)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 6)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 13)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Application name:"
		'
		'efApplicationName
		'
		Me.efApplicationName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efApplicationName.Location = New System.Drawing.Point(100, 3)
		Me.efApplicationName.Name = "efApplicationName"
		Me.efApplicationName.Size = New System.Drawing.Size(145, 20)
		Me.efApplicationName.TabIndex = 0
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
		Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.efSoftwareVersion, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(511, 35)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(250, 26)
		Me.TableLayoutPanel2.TabIndex = 3
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(3, 6)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(89, 13)
		Me.Label6.TabIndex = 1
		Me.Label6.Text = "Software version:"
		'
		'efSoftwareVersion
		'
		Me.efSoftwareVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efSoftwareVersion.Location = New System.Drawing.Point(98, 3)
		Me.efSoftwareVersion.Name = "efSoftwareVersion"
		Me.efSoftwareVersion.Size = New System.Drawing.Size(149, 20)
		Me.efSoftwareVersion.TabIndex = 0
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
		Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.efManufacturerName, 1, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(257, 35)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(248, 26)
		Me.TableLayoutPanel3.TabIndex = 4
		'
		'Label7
		'
		Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(3, 6)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(102, 13)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "Manufacturer name:"
		'
		'efManufacturerName
		'
		Me.efManufacturerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efManufacturerName.Location = New System.Drawing.Point(111, 3)
		Me.efManufacturerName.Name = "efManufacturerName"
		Me.efManufacturerName.Size = New System.Drawing.Size(134, 20)
		Me.efManufacturerName.TabIndex = 0
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel5.AutoSize = True
		Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel5.ColumnCount = 4
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.Controls.Add(Me.udDecimals, 3, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Label9, 2, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.cbxCurrency, 1, 0)
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 67)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 1
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(248, 27)
		Me.TableLayoutPanel5.TabIndex = 5
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(3, 7)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(52, 13)
		Me.Label8.TabIndex = 1
		Me.Label8.Text = "Currency:"
		'
		'cbxCurrency
		'
		Me.cbxCurrency.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxCurrency.FormattingEnabled = True
		Me.cbxCurrency.Items.AddRange(New Object() {"EUR", "USD", "GBP", "CHF"})
		Me.cbxCurrency.Location = New System.Drawing.Point(61, 3)
		Me.cbxCurrency.MaxLength = 3
		Me.cbxCurrency.Name = "cbxCurrency"
		Me.cbxCurrency.Size = New System.Drawing.Size(85, 21)
		Me.cbxCurrency.TabIndex = 2
		'
		'Label9
		'
		Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(152, 7)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(53, 13)
		Me.Label9.TabIndex = 6
		Me.Label9.Text = "Decimals:"
		'
		'udDecimals
		'
		Me.udDecimals.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udDecimals.Location = New System.Drawing.Point(211, 3)
		Me.udDecimals.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
		Me.udDecimals.Name = "udDecimals"
		Me.udDecimals.Size = New System.Drawing.Size(34, 20)
		Me.udDecimals.TabIndex = 6
		Me.udDecimals.Value = New Decimal(New Integer() {9, 0, 0, 0})
		'
		'cbSynchronousTerminal
		'
		Me.cbSynchronousTerminal.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbSynchronousTerminal.AutoSize = True
		Me.cbSynchronousTerminal.Location = New System.Drawing.Point(423, 6)
		Me.cbSynchronousTerminal.Name = "cbSynchronousTerminal"
		Me.cbSynchronousTerminal.Size = New System.Drawing.Size(88, 17)
		Me.cbSynchronousTerminal.TabIndex = 5
		Me.cbSynchronousTerminal.Text = "Synchronous"
		Me.cbSynchronousTerminal.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel6.AutoSize = True
		Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel6.ColumnCount = 2
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.Controls.Add(Me.Label10, 0, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.efCertificationCode, 1, 0)
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(511, 67)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 1
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(250, 27)
		Me.TableLayoutPanel6.TabIndex = 6
		'
		'Label10
		'
		Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(3, 7)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(92, 13)
		Me.Label10.TabIndex = 1
		Me.Label10.Text = "Certification code:"
		'
		'efCertificationCode
		'
		Me.efCertificationCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efCertificationCode.Location = New System.Drawing.Point(101, 3)
		Me.efCertificationCode.Name = "efCertificationCode"
		Me.efCertificationCode.Size = New System.Drawing.Size(146, 20)
		Me.efCertificationCode.TabIndex = 0
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel7.AutoSize = True
		Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel7.ColumnCount = 4
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel7.Controls.Add(Me.Label12, 1, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.udAutocloseDelay, 2, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.cbAutoclose, 0, 0)
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 181)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 1
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(764, 26)
		Me.TableLayoutPanel7.TabIndex = 3
		'
		'Label12
		'
		Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(175, 6)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(117, 13)
		Me.Label12.TabIndex = 2
		Me.Label12.Text = "delay before autoclose:"
		'
		'udAutocloseDelay
		'
		Me.udAutocloseDelay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udAutocloseDelay.Location = New System.Drawing.Point(298, 3)
		Me.udAutocloseDelay.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
		Me.udAutocloseDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.udAutocloseDelay.Name = "udAutocloseDelay"
		Me.udAutocloseDelay.Size = New System.Drawing.Size(57, 20)
		Me.udAutocloseDelay.TabIndex = 3
		Me.udAutocloseDelay.Value = New Decimal(New Integer() {2, 0, 0, 0})
		'
		'cbAutoclose
		'
		Me.cbAutoclose.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbAutoclose.AutoSize = True
		Me.cbAutoclose.Location = New System.Drawing.Point(3, 4)
		Me.cbAutoclose.Name = "cbAutoclose"
		Me.cbAutoclose.Size = New System.Drawing.Size(166, 17)
		Me.cbAutoclose.TabIndex = 4
		Me.cbAutoclose.Text = "Autoclose processing window"
		Me.cbAutoclose.UseVisualStyleBackColor = True
		'
		'Label11
		'
		Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(517, 8)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(104, 13)
		Me.Label11.TabIndex = 4
		Me.Label11.Text = "Max timer (payment):"
		'
		'udMaxTimer
		'
		Me.udMaxTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udMaxTimer.Location = New System.Drawing.Point(627, 4)
		Me.udMaxTimer.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.udMaxTimer.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.udMaxTimer.Name = "udMaxTimer"
		Me.udMaxTimer.Size = New System.Drawing.Size(57, 20)
		Me.udMaxTimer.TabIndex = 4
		Me.udMaxTimer.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'FSettings
		'
		Me.AcceptButton = Me.pbSave
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.pbCancel
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.panelMain)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FSettings"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Nexo Settings"
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.panelSettings.ResumeLayout(False)
		Me.panelSettings.PerformLayout()
		Me.panelNexoSettings.ResumeLayout(False)
		Me.panelNexoSettings.PerformLayout()
		Me.panelNexoSettingsSalePOI.ResumeLayout(False)
		Me.panelNexoSettingsSalePOI.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.panelServerSettings.ResumeLayout(False)
		Me.panelServerSettings.PerformLayout()
		CType(Me.udServerPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		CType(Me.udDecimals, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel7.PerformLayout()
		CType(Me.udAutocloseDelay, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.udMaxTimer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As Windows.Forms.TableLayoutPanel
	Friend WithEvents panelButtons As Windows.Forms.TableLayoutPanel
	Friend WithEvents pbSave As Windows.Forms.Button
	Friend WithEvents pbCancel As Windows.Forms.Button
	Friend WithEvents panelSettings As Windows.Forms.TableLayoutPanel
	Friend WithEvents panelNexoSettings As Windows.Forms.TableLayoutPanel
	Friend WithEvents panelNexoSettingsSalePOI As Windows.Forms.TableLayoutPanel
	Friend WithEvents efSaleID As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents cbSaleIDUSeIP As Windows.Forms.CheckBox
	Friend WithEvents TableLayoutPanel4 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents cbPOIIDUseIP As Windows.Forms.CheckBox
	Friend WithEvents efPOIID As Windows.Forms.TextBox
	Friend WithEvents panelServerSettings As Windows.Forms.TableLayoutPanel
	Friend WithEvents efServerIP As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents udServerPort As Windows.Forms.NumericUpDown
	Friend WithEvents pbTestConnection As Windows.Forms.Button
	Friend WithEvents pbSaveSettings As Windows.Forms.Button
	Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents efApplicationName As Windows.Forms.TextBox
	Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents efSoftwareVersion As Windows.Forms.TextBox
	Friend WithEvents TableLayoutPanel3 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents efManufacturerName As Windows.Forms.TextBox
	Friend WithEvents TableLayoutPanel5 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents cbxCurrency As Windows.Forms.ComboBox
	Friend WithEvents udDecimals As Windows.Forms.NumericUpDown
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents cbSynchronousTerminal As Windows.Forms.CheckBox
	Friend WithEvents TableLayoutPanel6 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents efCertificationCode As Windows.Forms.TextBox
	Friend WithEvents TableLayoutPanel7 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents udAutocloseDelay As Windows.Forms.NumericUpDown
	Friend WithEvents cbAutoclose As Windows.Forms.CheckBox
	Friend WithEvents udMaxTimer As Windows.Forms.NumericUpDown
	Friend WithEvents Label11 As Windows.Forms.Label
End Class
