﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSimulator
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
		Me.PanelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.panelButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbClose = New System.Windows.Forms.Button()
		Me.pbClear = New System.Windows.Forms.Button()
		Me.pbSaveContent = New System.Windows.Forms.Button()
		Me.pbSaveSettings = New System.Windows.Forms.Button()
		Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.lblGatewayHeader = New System.Windows.Forms.Label()
		Me.lblServerHeader = New System.Windows.Forms.Label()
		Me.lblClientHeader = New System.Windows.Forms.Label()
		Me.panelClientButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.panelOptions = New System.Windows.Forms.TableLayoutPanel()
		Me.panelCommands = New System.Windows.Forms.TableLayoutPanel()
		Me.pbResponseFolder = New System.Windows.Forms.Button()
		Me.cbSynchronous = New System.Windows.Forms.CheckBox()
		Me.cbUseJson = New System.Windows.Forms.CheckBox()
		Me.cbOptimize = New System.Windows.Forms.CheckBox()
		Me.panelCommandButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbDeviceInput = New System.Windows.Forms.Button()
		Me.pbLogin = New System.Windows.Forms.Button()
		Me.pbDevicePrint = New System.Windows.Forms.Button()
		Me.pbLogout = New System.Windows.Forms.Button()
		Me.pbRefund = New System.Windows.Forms.Button()
		Me.pbPayment = New System.Windows.Forms.Button()
		Me.pbReversal = New System.Windows.Forms.Button()
		Me.panelGateway = New System.Windows.Forms.TableLayoutPanel()
		Me.serverToReachPanel14 = New System.Windows.Forms.TableLayoutPanel()
		Me.panelGatewayPort = New System.Windows.Forms.TableLayoutPanel()
		Me.udGatewayPort = New System.Windows.Forms.NumericUpDown()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.cbGatewayUseLocalHost = New System.Windows.Forms.CheckBox()
		Me.panelGatewayServer = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.efGatewayServerIP = New System.Windows.Forms.TextBox()
		Me.panelGatewayDistantPort = New System.Windows.Forms.TableLayoutPanel()
		Me.udGatewayServerPort = New System.Windows.Forms.NumericUpDown()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblGateway = New System.Windows.Forms.Label()
		Me.panelGatewayButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.cbAutostartGateway = New System.Windows.Forms.CheckBox()
		Me.pbStopGateway = New System.Windows.Forms.Button()
		Me.pbStartGateway = New System.Windows.Forms.Button()
		Me.panelServer = New System.Windows.Forms.TableLayoutPanel()
		Me.lblServer = New System.Windows.Forms.Label()
		Me.cbConnected = New System.Windows.Forms.CheckBox()
		Me.panelServerButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.cbAutostartServer = New System.Windows.Forms.CheckBox()
		Me.pbStopServer = New System.Windows.Forms.Button()
		Me.pbStartServer = New System.Windows.Forms.Button()
		Me.pbServerActivity = New System.Windows.Forms.Button()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.udServerDelay = New System.Windows.Forms.NumericUpDown()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.pbDatabaseSettings = New System.Windows.Forms.Button()
		Me.cbUseDatabase = New System.Windows.Forms.CheckBox()
		Me.panelServerPort = New System.Windows.Forms.TableLayoutPanel()
		Me.udLocalServerPort = New System.Windows.Forms.NumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.panelClient = New System.Windows.Forms.TableLayoutPanel()
		Me.lblClient = New System.Windows.Forms.Label()
		Me.panelClientNexo = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
		Me.efDeviceID = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.efServiceID = New System.Windows.Forms.TextBox()
		Me.device = New System.Windows.Forms.Label()
		Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.efPOIID = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
		Me.efSaleID = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbUseConnectionSettings = New System.Windows.Forms.CheckBox()
		Me.efConnectionReply = New System.Windows.Forms.TextBox()
		Me.pbConnectionSettings = New System.Windows.Forms.Button()
		Me.panelClientServer = New System.Windows.Forms.TableLayoutPanel()
		Me.panelClientTimeout = New System.Windows.Forms.TableLayoutPanel()
		Me.udTimeout = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cbInfinite = New System.Windows.Forms.CheckBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.panelClientTarget = New System.Windows.Forms.TableLayoutPanel()
		Me.PanelIPPort = New System.Windows.Forms.TableLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.efTargetIP = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.udTargetPort = New System.Windows.Forms.NumericUpDown()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.panelClientButtons1 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbConnect = New System.Windows.Forms.Button()
		Me.pbDisconnect = New System.Windows.Forms.Button()
		Me.cbxConnections = New System.Windows.Forms.ComboBox()
		Me.panelClientTargets = New System.Windows.Forms.TableLayoutPanel()
		Me.rbServer = New System.Windows.Forms.RadioButton()
		Me.rbGateway = New System.Windows.Forms.RadioButton()
		Me.rbLocalHost = New System.Windows.Forms.RadioButton()
		Me.panelRaw = New System.Windows.Forms.TableLayoutPanel()
		Me.pbSendFreeMessage = New System.Windows.Forms.Button()
		Me.lblFreeMessage = New System.Windows.Forms.Label()
		Me.pbBuild = New System.Windows.Forms.Button()
		Me.cbxCommands = New System.Windows.Forms.ComboBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pbAdd = New System.Windows.Forms.Button()
		Me.efCommand = New System.Windows.Forms.TextBox()
		Me.pbRemove = New System.Windows.Forms.Button()
		Me.pbSendRequest = New System.Windows.Forms.Button()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.cbxLog = New System.Windows.Forms.ComboBox()
		Me.PanelMain.SuspendLayout()
		Me.panelButtons.SuspendLayout()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
		Me.panelOptions.SuspendLayout()
		Me.panelCommands.SuspendLayout()
		Me.panelCommandButtons.SuspendLayout()
		Me.panelGateway.SuspendLayout()
		Me.serverToReachPanel14.SuspendLayout()
		Me.panelGatewayPort.SuspendLayout()
		CType(Me.udGatewayPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelGatewayServer.SuspendLayout()
		Me.TableLayoutPanel12.SuspendLayout()
		Me.panelGatewayDistantPort.SuspendLayout()
		CType(Me.udGatewayServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelGatewayButtons.SuspendLayout()
		Me.panelServer.SuspendLayout()
		Me.panelServerButtons.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.udServerDelay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelServerPort.SuspendLayout()
		CType(Me.udLocalServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelClient.SuspendLayout()
		Me.panelClientNexo.SuspendLayout()
		Me.TableLayoutPanel10.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.TableLayoutPanel8.SuspendLayout()
		Me.TableLayoutPanel9.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.panelClientServer.SuspendLayout()
		Me.panelClientTimeout.SuspendLayout()
		CType(Me.udTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelClientTarget.SuspendLayout()
		Me.PanelIPPort.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.udTargetPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panelClientButtons1.SuspendLayout()
		Me.panelClientTargets.SuspendLayout()
		Me.panelRaw.SuspendLayout()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelMain
		'
		Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PanelMain.AutoSize = True
		Me.PanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.PanelMain.ColumnCount = 1
		Me.PanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.PanelMain.Controls.Add(Me.panelButtons, 0, 3)
		Me.PanelMain.Controls.Add(Me.TableLayoutPanel6, 0, 2)
		Me.PanelMain.Controls.Add(Me.panelClientButtons, 0, 1)
		Me.PanelMain.Controls.Add(Me.panelOptions, 0, 0)
		Me.PanelMain.Location = New System.Drawing.Point(12, 12)
		Me.PanelMain.Name = "PanelMain"
		Me.PanelMain.RowCount = 4
		Me.PanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.PanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.PanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.PanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.PanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.PanelMain.Size = New System.Drawing.Size(1044, 484)
		Me.PanelMain.TabIndex = 0
		'
		'panelButtons
		'
		Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelButtons.AutoSize = True
		Me.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelButtons.ColumnCount = 6
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.Controls.Add(Me.pbClose, 5, 0)
		Me.panelButtons.Controls.Add(Me.pbClear, 3, 0)
		Me.panelButtons.Controls.Add(Me.pbSaveContent, 4, 0)
		Me.panelButtons.Controls.Add(Me.pbSaveSettings, 2, 0)
		Me.panelButtons.Controls.Add(Me.cbxLog, 0, 0)
		Me.panelButtons.Location = New System.Drawing.Point(3, 452)
		Me.panelButtons.Name = "panelButtons"
		Me.panelButtons.RowCount = 1
		Me.panelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelButtons.Size = New System.Drawing.Size(1038, 29)
		Me.panelButtons.TabIndex = 3
		'
		'pbClose
		'
		Me.pbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbClose.AutoSize = True
		Me.pbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClose.Location = New System.Drawing.Point(992, 3)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(43, 23)
		Me.pbClose.TabIndex = 4
		Me.pbClose.Text = "Close"
		Me.pbClose.UseVisualStyleBackColor = True
		'
		'pbClear
		'
		Me.pbClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbClear.AutoSize = True
		Me.pbClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClear.Location = New System.Drawing.Point(808, 3)
		Me.pbClear.Name = "pbClear"
		Me.pbClear.Size = New System.Drawing.Size(91, 23)
		Me.pbClear.TabIndex = 2
		Me.pbClear.Text = "Clear messages"
		Me.pbClear.UseVisualStyleBackColor = True
		'
		'pbSaveContent
		'
		Me.pbSaveContent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSaveContent.AutoSize = True
		Me.pbSaveContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSaveContent.Location = New System.Drawing.Point(905, 3)
		Me.pbSaveContent.Name = "pbSaveContent"
		Me.pbSaveContent.Size = New System.Drawing.Size(81, 23)
		Me.pbSaveContent.TabIndex = 3
		Me.pbSaveContent.Text = "Save content"
		Me.pbSaveContent.UseVisualStyleBackColor = True
		'
		'pbSaveSettings
		'
		Me.pbSaveSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSaveSettings.AutoSize = True
		Me.pbSaveSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSaveSettings.Location = New System.Drawing.Point(721, 3)
		Me.pbSaveSettings.Name = "pbSaveSettings"
		Me.pbSaveSettings.Size = New System.Drawing.Size(81, 23)
		Me.pbSaveSettings.TabIndex = 1
		Me.pbSaveSettings.Text = "Save settings"
		Me.pbSaveSettings.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel6.AutoSize = True
		Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel6.ColumnCount = 1
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.Controls.Add(Me.RichTextBox1, 0, 1)
		Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 0)
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 279)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 2
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(1038, 167)
		Me.TableLayoutPanel6.TabIndex = 2
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RichTextBox1.Location = New System.Drawing.Point(3, 29)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ReadOnly = True
		Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
		Me.RichTextBox1.Size = New System.Drawing.Size(1032, 135)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel7.AutoSize = True
		Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel7.ColumnCount = 3
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.Controls.Add(Me.lblGatewayHeader, 0, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.lblServerHeader, 2, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.lblClientHeader, 0, 0)
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 1
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(1032, 20)
		Me.TableLayoutPanel7.TabIndex = 6
		'
		'lblGatewayHeader
		'
		Me.lblGatewayHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblGatewayHeader.AutoSize = True
		Me.lblGatewayHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGatewayHeader.ForeColor = System.Drawing.Color.Crimson
		Me.lblGatewayHeader.Location = New System.Drawing.Point(347, 0)
		Me.lblGatewayHeader.Name = "lblGatewayHeader"
		Me.lblGatewayHeader.Size = New System.Drawing.Size(338, 20)
		Me.lblGatewayHeader.TabIndex = 3
		Me.lblGatewayHeader.Text = "Gateway"
		Me.lblGatewayHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblServerHeader
		'
		Me.lblServerHeader.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.lblServerHeader.AutoSize = True
		Me.lblServerHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblServerHeader.ForeColor = System.Drawing.Color.Crimson
		Me.lblServerHeader.Location = New System.Drawing.Point(968, 0)
		Me.lblServerHeader.Name = "lblServerHeader"
		Me.lblServerHeader.Size = New System.Drawing.Size(61, 20)
		Me.lblServerHeader.TabIndex = 2
		Me.lblServerHeader.Text = "Server"
		Me.lblServerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblClientHeader
		'
		Me.lblClientHeader.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblClientHeader.AutoSize = True
		Me.lblClientHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClientHeader.ForeColor = System.Drawing.Color.RoyalBlue
		Me.lblClientHeader.Location = New System.Drawing.Point(3, 0)
		Me.lblClientHeader.Name = "lblClientHeader"
		Me.lblClientHeader.Size = New System.Drawing.Size(55, 20)
		Me.lblClientHeader.TabIndex = 1
		Me.lblClientHeader.Text = "Client"
		Me.lblClientHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panelClientButtons
		'
		Me.panelClientButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientButtons.AutoSize = True
		Me.panelClientButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientButtons.ColumnCount = 1
		Me.panelClientButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientButtons.Location = New System.Drawing.Point(3, 273)
		Me.panelClientButtons.Name = "panelClientButtons"
		Me.panelClientButtons.RowCount = 2
		Me.panelClientButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelClientButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelClientButtons.Size = New System.Drawing.Size(1038, 1)
		Me.panelClientButtons.TabIndex = 0
		'
		'panelOptions
		'
		Me.panelOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelOptions.AutoSize = True
		Me.panelOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelOptions.ColumnCount = 1
		Me.panelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelOptions.Controls.Add(Me.panelCommands, 0, 4)
		Me.panelOptions.Controls.Add(Me.panelGateway, 0, 2)
		Me.panelOptions.Controls.Add(Me.panelServer, 0, 1)
		Me.panelOptions.Controls.Add(Me.panelClient, 0, 0)
		Me.panelOptions.Controls.Add(Me.panelRaw, 0, 3)
		Me.panelOptions.Location = New System.Drawing.Point(3, 3)
		Me.panelOptions.Name = "panelOptions"
		Me.panelOptions.RowCount = 5
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelOptions.Size = New System.Drawing.Size(1038, 264)
		Me.panelOptions.TabIndex = 4
		'
		'panelCommands
		'
		Me.panelCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelCommands.AutoSize = True
		Me.panelCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelCommands.ColumnCount = 6
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommands.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommands.Controls.Add(Me.pbResponseFolder, 2, 0)
		Me.panelCommands.Controls.Add(Me.cbSynchronous, 3, 0)
		Me.panelCommands.Controls.Add(Me.cbUseJson, 5, 0)
		Me.panelCommands.Controls.Add(Me.cbOptimize, 4, 0)
		Me.panelCommands.Controls.Add(Me.panelCommandButtons, 0, 0)
		Me.panelCommands.Location = New System.Drawing.Point(3, 226)
		Me.panelCommands.Name = "panelCommands"
		Me.panelCommands.RowCount = 1
		Me.panelCommands.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelCommands.Size = New System.Drawing.Size(1032, 35)
		Me.panelCommands.TabIndex = 8
		'
		'pbResponseFolder
		'
		Me.pbResponseFolder.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.pbResponseFolder.AutoSize = True
		Me.pbResponseFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbResponseFolder.Location = New System.Drawing.Point(693, 6)
		Me.pbResponseFolder.Name = "pbResponseFolder"
		Me.pbResponseFolder.Size = New System.Drawing.Size(94, 23)
		Me.pbResponseFolder.TabIndex = 7
		Me.pbResponseFolder.Text = "Response folder"
		Me.pbResponseFolder.UseVisualStyleBackColor = True
		'
		'cbSynchronous
		'
		Me.cbSynchronous.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbSynchronous.AutoSize = True
		Me.cbSynchronous.Location = New System.Drawing.Point(793, 9)
		Me.cbSynchronous.Name = "cbSynchronous"
		Me.cbSynchronous.Size = New System.Drawing.Size(88, 17)
		Me.cbSynchronous.TabIndex = 9
		Me.cbSynchronous.Text = "Synchronous"
		Me.cbSynchronous.UseVisualStyleBackColor = True
		'
		'cbUseJson
		'
		Me.cbUseJson.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbUseJson.AutoSize = True
		Me.cbUseJson.Location = New System.Drawing.Point(959, 9)
		Me.cbUseJson.Name = "cbUseJson"
		Me.cbUseJson.Size = New System.Drawing.Size(70, 17)
		Me.cbUseJson.TabIndex = 11
		Me.cbUseJson.Text = "Use Json"
		Me.cbUseJson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cbUseJson.UseVisualStyleBackColor = True
		'
		'cbOptimize
		'
		Me.cbOptimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbOptimize.AutoSize = True
		Me.cbOptimize.Checked = True
		Me.cbOptimize.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbOptimize.Enabled = False
		Me.cbOptimize.Location = New System.Drawing.Point(887, 9)
		Me.cbOptimize.Name = "cbOptimize"
		Me.cbOptimize.Size = New System.Drawing.Size(66, 17)
		Me.cbOptimize.TabIndex = 10
		Me.cbOptimize.Text = "Optimize"
		Me.cbOptimize.UseVisualStyleBackColor = True
		'
		'panelCommandButtons
		'
		Me.panelCommandButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelCommandButtons.AutoSize = True
		Me.panelCommandButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelCommandButtons.ColumnCount = 7
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelCommandButtons.Controls.Add(Me.pbDeviceInput, 6, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbLogin, 0, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbDevicePrint, 5, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbLogout, 1, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbRefund, 4, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbPayment, 2, 0)
		Me.panelCommandButtons.Controls.Add(Me.pbReversal, 3, 0)
		Me.panelCommandButtons.Location = New System.Drawing.Point(3, 3)
		Me.panelCommandButtons.Name = "panelCommandButtons"
		Me.panelCommandButtons.RowCount = 1
		Me.panelCommandButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelCommandButtons.Size = New System.Drawing.Size(457, 29)
		Me.panelCommandButtons.TabIndex = 12
		'
		'pbDeviceInput
		'
		Me.pbDeviceInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbDeviceInput.AutoSize = True
		Me.pbDeviceInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbDeviceInput.Location = New System.Drawing.Point(376, 3)
		Me.pbDeviceInput.Name = "pbDeviceInput"
		Me.pbDeviceInput.Size = New System.Drawing.Size(78, 23)
		Me.pbDeviceInput.TabIndex = 6
		Me.pbDeviceInput.Text = "Device Input"
		Me.pbDeviceInput.UseVisualStyleBackColor = True
		'
		'pbLogin
		'
		Me.pbLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbLogin.AutoSize = True
		Me.pbLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbLogin.Location = New System.Drawing.Point(3, 3)
		Me.pbLogin.Name = "pbLogin"
		Me.pbLogin.Size = New System.Drawing.Size(43, 23)
		Me.pbLogin.TabIndex = 0
		Me.pbLogin.Text = "Login"
		Me.pbLogin.UseVisualStyleBackColor = True
		'
		'pbDevicePrint
		'
		Me.pbDevicePrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbDevicePrint.AutoSize = True
		Me.pbDevicePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbDevicePrint.Location = New System.Drawing.Point(295, 3)
		Me.pbDevicePrint.Name = "pbDevicePrint"
		Me.pbDevicePrint.Size = New System.Drawing.Size(75, 23)
		Me.pbDevicePrint.TabIndex = 5
		Me.pbDevicePrint.Text = "Device Print"
		Me.pbDevicePrint.UseVisualStyleBackColor = True
		'
		'pbLogout
		'
		Me.pbLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbLogout.AutoSize = True
		Me.pbLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbLogout.Location = New System.Drawing.Point(52, 3)
		Me.pbLogout.Name = "pbLogout"
		Me.pbLogout.Size = New System.Drawing.Size(50, 23)
		Me.pbLogout.TabIndex = 1
		Me.pbLogout.Text = "Logout"
		Me.pbLogout.UseVisualStyleBackColor = True
		'
		'pbRefund
		'
		Me.pbRefund.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbRefund.AutoSize = True
		Me.pbRefund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbRefund.Location = New System.Drawing.Point(237, 3)
		Me.pbRefund.Name = "pbRefund"
		Me.pbRefund.Size = New System.Drawing.Size(52, 23)
		Me.pbRefund.TabIndex = 4
		Me.pbRefund.Text = "Refund"
		Me.pbRefund.UseVisualStyleBackColor = True
		'
		'pbPayment
		'
		Me.pbPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbPayment.AutoSize = True
		Me.pbPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbPayment.Location = New System.Drawing.Point(108, 3)
		Me.pbPayment.Name = "pbPayment"
		Me.pbPayment.Size = New System.Drawing.Size(58, 23)
		Me.pbPayment.TabIndex = 2
		Me.pbPayment.Text = "Payment"
		Me.pbPayment.UseVisualStyleBackColor = True
		'
		'pbReversal
		'
		Me.pbReversal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbReversal.AutoSize = True
		Me.pbReversal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbReversal.Enabled = False
		Me.pbReversal.Location = New System.Drawing.Point(172, 3)
		Me.pbReversal.Name = "pbReversal"
		Me.pbReversal.Size = New System.Drawing.Size(59, 23)
		Me.pbReversal.TabIndex = 3
		Me.pbReversal.Text = "Reversal"
		Me.pbReversal.UseVisualStyleBackColor = True
		'
		'panelGateway
		'
		Me.panelGateway.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGateway.AutoSize = True
		Me.panelGateway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGateway.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.panelGateway.ColumnCount = 3
		Me.panelGateway.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGateway.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGateway.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGateway.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelGateway.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelGateway.Controls.Add(Me.serverToReachPanel14, 1, 0)
		Me.panelGateway.Controls.Add(Me.lblGateway, 0, 0)
		Me.panelGateway.Controls.Add(Me.panelGatewayButtons, 2, 0)
		Me.panelGateway.Location = New System.Drawing.Point(3, 141)
		Me.panelGateway.Name = "panelGateway"
		Me.panelGateway.RowCount = 1
		Me.panelGateway.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelGateway.Size = New System.Drawing.Size(1032, 44)
		Me.panelGateway.TabIndex = 1
		'
		'serverToReachPanel14
		'
		Me.serverToReachPanel14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.serverToReachPanel14.AutoSize = True
		Me.serverToReachPanel14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.serverToReachPanel14.ColumnCount = 3
		Me.serverToReachPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.serverToReachPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.serverToReachPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.serverToReachPanel14.Controls.Add(Me.panelGatewayPort, 0, 0)
		Me.serverToReachPanel14.Controls.Add(Me.cbGatewayUseLocalHost, 1, 0)
		Me.serverToReachPanel14.Controls.Add(Me.panelGatewayServer, 2, 0)
		Me.serverToReachPanel14.Location = New System.Drawing.Point(157, 3)
		Me.serverToReachPanel14.Name = "serverToReachPanel14"
		Me.serverToReachPanel14.RowCount = 1
		Me.serverToReachPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.serverToReachPanel14.Size = New System.Drawing.Size(523, 38)
		Me.serverToReachPanel14.TabIndex = 0
		'
		'panelGatewayPort
		'
		Me.panelGatewayPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGatewayPort.AutoSize = True
		Me.panelGatewayPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGatewayPort.ColumnCount = 2
		Me.panelGatewayPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayPort.Controls.Add(Me.udGatewayPort, 1, 0)
		Me.panelGatewayPort.Controls.Add(Me.Label12, 0, 0)
		Me.panelGatewayPort.Location = New System.Drawing.Point(3, 3)
		Me.panelGatewayPort.Name = "panelGatewayPort"
		Me.panelGatewayPort.RowCount = 1
		Me.panelGatewayPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayPort.Size = New System.Drawing.Size(138, 32)
		Me.panelGatewayPort.TabIndex = 9
		'
		'udGatewayPort
		'
		Me.udGatewayPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udGatewayPort.AutoSize = True
		Me.udGatewayPort.Location = New System.Drawing.Point(82, 6)
		Me.udGatewayPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udGatewayPort.Name = "udGatewayPort"
		Me.udGatewayPort.Size = New System.Drawing.Size(53, 20)
		Me.udGatewayPort.TabIndex = 0
		Me.udGatewayPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label12
		'
		Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(3, 9)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(73, 13)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "Gateway port:"
		'
		'cbGatewayUseLocalHost
		'
		Me.cbGatewayUseLocalHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbGatewayUseLocalHost.AutoSize = True
		Me.cbGatewayUseLocalHost.Location = New System.Drawing.Point(147, 10)
		Me.cbGatewayUseLocalHost.Name = "cbGatewayUseLocalHost"
		Me.cbGatewayUseLocalHost.Size = New System.Drawing.Size(114, 17)
		Me.cbGatewayUseLocalHost.TabIndex = 0
		Me.cbGatewayUseLocalHost.Text = "Target local server"
		Me.cbGatewayUseLocalHost.UseVisualStyleBackColor = True
		'
		'panelGatewayServer
		'
		Me.panelGatewayServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGatewayServer.AutoSize = True
		Me.panelGatewayServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGatewayServer.ColumnCount = 2
		Me.panelGatewayServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayServer.Controls.Add(Me.TableLayoutPanel12, 0, 0)
		Me.panelGatewayServer.Controls.Add(Me.panelGatewayDistantPort, 1, 0)
		Me.panelGatewayServer.Location = New System.Drawing.Point(267, 3)
		Me.panelGatewayServer.Name = "panelGatewayServer"
		Me.panelGatewayServer.RowCount = 1
		Me.panelGatewayServer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayServer.Size = New System.Drawing.Size(253, 32)
		Me.panelGatewayServer.TabIndex = 1
		'
		'TableLayoutPanel12
		'
		Me.TableLayoutPanel12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel12.AutoSize = True
		Me.TableLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel12.ColumnCount = 2
		Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel12.Controls.Add(Me.Label6, 0, 0)
		Me.TableLayoutPanel12.Controls.Add(Me.efGatewayServerIP, 1, 0)
		Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
		Me.TableLayoutPanel12.RowCount = 1
		Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel12.Size = New System.Drawing.Size(114, 26)
		Me.TableLayoutPanel12.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(3, 6)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(17, 13)
		Me.Label6.TabIndex = 1
		Me.Label6.Text = "IP"
		'
		'efGatewayServerIP
		'
		Me.efGatewayServerIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efGatewayServerIP.Location = New System.Drawing.Point(26, 3)
		Me.efGatewayServerIP.Name = "efGatewayServerIP"
		Me.efGatewayServerIP.Size = New System.Drawing.Size(85, 20)
		Me.efGatewayServerIP.TabIndex = 0
		'
		'panelGatewayDistantPort
		'
		Me.panelGatewayDistantPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGatewayDistantPort.AutoSize = True
		Me.panelGatewayDistantPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGatewayDistantPort.ColumnCount = 2
		Me.panelGatewayDistantPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayDistantPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayDistantPort.Controls.Add(Me.udGatewayServerPort, 1, 0)
		Me.panelGatewayDistantPort.Controls.Add(Me.Label11, 0, 0)
		Me.panelGatewayDistantPort.Location = New System.Drawing.Point(123, 3)
		Me.panelGatewayDistantPort.Name = "panelGatewayDistantPort"
		Me.panelGatewayDistantPort.RowCount = 1
		Me.panelGatewayDistantPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayDistantPort.Size = New System.Drawing.Size(127, 26)
		Me.panelGatewayDistantPort.TabIndex = 1
		'
		'udGatewayServerPort
		'
		Me.udGatewayServerPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udGatewayServerPort.AutoSize = True
		Me.udGatewayServerPort.Location = New System.Drawing.Point(71, 3)
		Me.udGatewayServerPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udGatewayServerPort.Name = "udGatewayServerPort"
		Me.udGatewayServerPort.Size = New System.Drawing.Size(53, 20)
		Me.udGatewayServerPort.TabIndex = 1
		Me.udGatewayServerPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label11
		'
		Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(3, 6)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(62, 13)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "Server port:"
		'
		'lblGateway
		'
		Me.lblGateway.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblGateway.AutoSize = True
		Me.lblGateway.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGateway.Location = New System.Drawing.Point(3, 0)
		Me.lblGateway.Name = "lblGateway"
		Me.lblGateway.Size = New System.Drawing.Size(148, 44)
		Me.lblGateway.TabIndex = 12
		Me.lblGateway.Text = "Gateway settings"
		Me.lblGateway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panelGatewayButtons
		'
		Me.panelGatewayButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelGatewayButtons.AutoSize = True
		Me.panelGatewayButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelGatewayButtons.ColumnCount = 3
		Me.panelGatewayButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelGatewayButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayButtons.Controls.Add(Me.cbAutostartGateway, 2, 0)
		Me.panelGatewayButtons.Controls.Add(Me.pbStopGateway, 0, 0)
		Me.panelGatewayButtons.Controls.Add(Me.pbStartGateway, 0, 0)
		Me.panelGatewayButtons.Location = New System.Drawing.Point(686, 3)
		Me.panelGatewayButtons.Name = "panelGatewayButtons"
		Me.panelGatewayButtons.RowCount = 1
		Me.panelGatewayButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelGatewayButtons.Size = New System.Drawing.Size(343, 38)
		Me.panelGatewayButtons.TabIndex = 0
		'
		'cbAutostartGateway
		'
		Me.cbAutostartGateway.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbAutostartGateway.AutoSize = True
		Me.cbAutostartGateway.Location = New System.Drawing.Point(93, 10)
		Me.cbAutostartGateway.Name = "cbAutostartGateway"
		Me.cbAutostartGateway.Size = New System.Drawing.Size(68, 17)
		Me.cbAutostartGateway.TabIndex = 2
		Me.cbAutostartGateway.Text = "Autostart"
		Me.cbAutostartGateway.UseVisualStyleBackColor = True
		'
		'pbStopGateway
		'
		Me.pbStopGateway.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbStopGateway.AutoSize = True
		Me.pbStopGateway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbStopGateway.Location = New System.Drawing.Point(48, 7)
		Me.pbStopGateway.Name = "pbStopGateway"
		Me.pbStopGateway.Size = New System.Drawing.Size(39, 23)
		Me.pbStopGateway.TabIndex = 1
		Me.pbStopGateway.Text = "Stop"
		Me.pbStopGateway.UseVisualStyleBackColor = True
		'
		'pbStartGateway
		'
		Me.pbStartGateway.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbStartGateway.AutoSize = True
		Me.pbStartGateway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbStartGateway.Location = New System.Drawing.Point(3, 7)
		Me.pbStartGateway.Name = "pbStartGateway"
		Me.pbStartGateway.Size = New System.Drawing.Size(39, 23)
		Me.pbStartGateway.TabIndex = 0
		Me.pbStartGateway.Text = "Start"
		Me.pbStartGateway.UseVisualStyleBackColor = True
		'
		'panelServer
		'
		Me.panelServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelServer.AutoSize = True
		Me.panelServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.panelServer.ColumnCount = 4
		Me.panelServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServer.Controls.Add(Me.lblServer, 0, 0)
		Me.panelServer.Controls.Add(Me.cbConnected, 2, 0)
		Me.panelServer.Controls.Add(Me.panelServerButtons, 3, 0)
		Me.panelServer.Controls.Add(Me.panelServerPort, 1, 0)
		Me.panelServer.Location = New System.Drawing.Point(3, 97)
		Me.panelServer.Name = "panelServer"
		Me.panelServer.RowCount = 1
		Me.panelServer.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelServer.Size = New System.Drawing.Size(1032, 38)
		Me.panelServer.TabIndex = 0
		'
		'lblServer
		'
		Me.lblServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblServer.AutoSize = True
		Me.lblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblServer.Location = New System.Drawing.Point(3, 0)
		Me.lblServer.Name = "lblServer"
		Me.lblServer.Size = New System.Drawing.Size(178, 38)
		Me.lblServer.TabIndex = 6
		Me.lblServer.Text = "Local Server settings"
		Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cbConnected
		'
		Me.cbConnected.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbConnected.AutoSize = True
		Me.cbConnected.Location = New System.Drawing.Point(287, 10)
		Me.cbConnected.Name = "cbConnected"
		Me.cbConnected.Size = New System.Drawing.Size(78, 17)
		Me.cbConnected.TabIndex = 1
		Me.cbConnected.Text = "Connected"
		Me.cbConnected.UseVisualStyleBackColor = True
		'
		'panelServerButtons
		'
		Me.panelServerButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelServerButtons.AutoSize = True
		Me.panelServerButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelServerButtons.ColumnCount = 8
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelServerButtons.Controls.Add(Me.cbAutostartServer, 3, 0)
		Me.panelServerButtons.Controls.Add(Me.pbStopServer, 1, 0)
		Me.panelServerButtons.Controls.Add(Me.pbStartServer, 0, 0)
		Me.panelServerButtons.Controls.Add(Me.pbServerActivity, 2, 0)
		Me.panelServerButtons.Controls.Add(Me.TableLayoutPanel2, 4, 0)
		Me.panelServerButtons.Controls.Add(Me.pbDatabaseSettings, 6, 0)
		Me.panelServerButtons.Controls.Add(Me.cbUseDatabase, 5, 0)
		Me.panelServerButtons.Location = New System.Drawing.Point(371, 3)
		Me.panelServerButtons.Name = "panelServerButtons"
		Me.panelServerButtons.RowCount = 1
		Me.panelServerButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerButtons.Size = New System.Drawing.Size(658, 32)
		Me.panelServerButtons.TabIndex = 2
		'
		'cbAutostartServer
		'
		Me.cbAutostartServer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbAutostartServer.AutoSize = True
		Me.cbAutostartServer.Location = New System.Drawing.Point(183, 7)
		Me.cbAutostartServer.Name = "cbAutostartServer"
		Me.cbAutostartServer.Size = New System.Drawing.Size(68, 17)
		Me.cbAutostartServer.TabIndex = 3
		Me.cbAutostartServer.Text = "Autostart"
		Me.cbAutostartServer.UseVisualStyleBackColor = True
		'
		'pbStopServer
		'
		Me.pbStopServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbStopServer.AutoSize = True
		Me.pbStopServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbStopServer.Location = New System.Drawing.Point(48, 4)
		Me.pbStopServer.Name = "pbStopServer"
		Me.pbStopServer.Size = New System.Drawing.Size(39, 23)
		Me.pbStopServer.TabIndex = 1
		Me.pbStopServer.Text = "Stop"
		Me.pbStopServer.UseVisualStyleBackColor = True
		'
		'pbStartServer
		'
		Me.pbStartServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbStartServer.AutoSize = True
		Me.pbStartServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbStartServer.Location = New System.Drawing.Point(3, 4)
		Me.pbStartServer.Name = "pbStartServer"
		Me.pbStartServer.Size = New System.Drawing.Size(39, 23)
		Me.pbStartServer.TabIndex = 0
		Me.pbStartServer.Text = "Start"
		Me.pbStartServer.UseVisualStyleBackColor = True
		'
		'pbServerActivity
		'
		Me.pbServerActivity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbServerActivity.AutoSize = True
		Me.pbServerActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbServerActivity.Location = New System.Drawing.Point(93, 4)
		Me.pbServerActivity.Name = "pbServerActivity"
		Me.pbServerActivity.Size = New System.Drawing.Size(84, 23)
		Me.pbServerActivity.TabIndex = 2
		Me.pbServerActivity.Text = "Server activity"
		Me.pbServerActivity.UseVisualStyleBackColor = True
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
		Me.TableLayoutPanel2.Controls.Add(Me.udServerDelay, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(257, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(84, 26)
		Me.TableLayoutPanel2.TabIndex = 4
		'
		'udServerDelay
		'
		Me.udServerDelay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udServerDelay.AutoSize = True
		Me.udServerDelay.Location = New System.Drawing.Point(46, 3)
		Me.udServerDelay.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
		Me.udServerDelay.Name = "udServerDelay"
		Me.udServerDelay.Size = New System.Drawing.Size(35, 20)
		Me.udServerDelay.TabIndex = 0
		Me.udServerDelay.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label10
		'
		Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(3, 6)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(37, 13)
		Me.Label10.TabIndex = 0
		Me.Label10.Text = "Delay:"
		'
		'pbDatabaseSettings
		'
		Me.pbDatabaseSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbDatabaseSettings.AutoSize = True
		Me.pbDatabaseSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbDatabaseSettings.Location = New System.Drawing.Point(445, 4)
		Me.pbDatabaseSettings.Name = "pbDatabaseSettings"
		Me.pbDatabaseSettings.Size = New System.Drawing.Size(55, 23)
		Me.pbDatabaseSettings.TabIndex = 7
		Me.pbDatabaseSettings.Text = "Settings"
		Me.pbDatabaseSettings.UseVisualStyleBackColor = True
		'
		'cbUseDatabase
		'
		Me.cbUseDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbUseDatabase.AutoSize = True
		Me.cbUseDatabase.Location = New System.Drawing.Point(347, 7)
		Me.cbUseDatabase.Name = "cbUseDatabase"
		Me.cbUseDatabase.Size = New System.Drawing.Size(92, 17)
		Me.cbUseDatabase.TabIndex = 6
		Me.cbUseDatabase.Text = "Use database"
		Me.cbUseDatabase.UseVisualStyleBackColor = True
		'
		'panelServerPort
		'
		Me.panelServerPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelServerPort.AutoSize = True
		Me.panelServerPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelServerPort.ColumnCount = 2
		Me.panelServerPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerPort.Controls.Add(Me.udLocalServerPort, 1, 0)
		Me.panelServerPort.Controls.Add(Me.Label1, 0, 0)
		Me.panelServerPort.Location = New System.Drawing.Point(187, 3)
		Me.panelServerPort.Name = "panelServerPort"
		Me.panelServerPort.RowCount = 1
		Me.panelServerPort.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerPort.Size = New System.Drawing.Size(94, 32)
		Me.panelServerPort.TabIndex = 0
		'
		'udLocalServerPort
		'
		Me.udLocalServerPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udLocalServerPort.AutoSize = True
		Me.udLocalServerPort.Location = New System.Drawing.Point(38, 6)
		Me.udLocalServerPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udLocalServerPort.Name = "udLocalServerPort"
		Me.udLocalServerPort.Size = New System.Drawing.Size(53, 20)
		Me.udLocalServerPort.TabIndex = 0
		Me.udLocalServerPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Port:"
		'
		'panelClient
		'
		Me.panelClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClient.AutoSize = True
		Me.panelClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.panelClient.ColumnCount = 2
		Me.panelClient.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClient.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClient.Controls.Add(Me.lblClient, 0, 0)
		Me.panelClient.Controls.Add(Me.panelClientNexo, 1, 0)
		Me.panelClient.Controls.Add(Me.panelClientServer, 0, 1)
		Me.panelClient.Location = New System.Drawing.Point(3, 3)
		Me.panelClient.Name = "panelClient"
		Me.panelClient.RowCount = 2
		Me.panelClient.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelClient.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelClient.Size = New System.Drawing.Size(1032, 88)
		Me.panelClient.TabIndex = 2
		'
		'lblClient
		'
		Me.lblClient.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblClient.AutoSize = True
		Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClient.Location = New System.Drawing.Point(3, 12)
		Me.lblClient.Name = "lblClient"
		Me.lblClient.Size = New System.Drawing.Size(124, 20)
		Me.lblClient.TabIndex = 7
		Me.lblClient.Text = "Client settings"
		'
		'panelClientNexo
		'
		Me.panelClientNexo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientNexo.AutoSize = True
		Me.panelClientNexo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientNexo.ColumnCount = 5
		Me.panelClientNexo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientNexo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientNexo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientNexo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientNexo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientNexo.Controls.Add(Me.TableLayoutPanel10, 3, 0)
		Me.panelClientNexo.Controls.Add(Me.TableLayoutPanel4, 2, 0)
		Me.panelClientNexo.Controls.Add(Me.TableLayoutPanel8, 0, 0)
		Me.panelClientNexo.Controls.Add(Me.TableLayoutPanel9, 1, 0)
		Me.panelClientNexo.Controls.Add(Me.TableLayoutPanel3, 4, 0)
		Me.panelClientNexo.Location = New System.Drawing.Point(133, 3)
		Me.panelClientNexo.Name = "panelClientNexo"
		Me.panelClientNexo.RowCount = 1
		Me.panelClientNexo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientNexo.Size = New System.Drawing.Size(896, 38)
		Me.panelClientNexo.TabIndex = 8
		'
		'TableLayoutPanel10
		'
		Me.TableLayoutPanel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel10.AutoSize = True
		Me.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel10.ColumnCount = 2
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel10.Controls.Add(Me.efDeviceID, 1, 0)
		Me.TableLayoutPanel10.Controls.Add(Me.Label4, 0, 0)
		Me.TableLayoutPanel10.Location = New System.Drawing.Point(405, 6)
		Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
		Me.TableLayoutPanel10.RowCount = 1
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel10.Size = New System.Drawing.Size(137, 26)
		Me.TableLayoutPanel10.TabIndex = 3
		'
		'efDeviceID
		'
		Me.efDeviceID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efDeviceID.Location = New System.Drawing.Point(64, 3)
		Me.efDeviceID.Name = "efDeviceID"
		Me.efDeviceID.Size = New System.Drawing.Size(70, 20)
		Me.efDeviceID.TabIndex = 0
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 6)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "DeviceID:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel4.AutoSize = True
		Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel4.ColumnCount = 2
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.efServiceID, 1, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.device, 0, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(260, 6)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(139, 26)
		Me.TableLayoutPanel4.TabIndex = 2
		'
		'efServiceID
		'
		Me.efServiceID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efServiceID.Location = New System.Drawing.Point(66, 3)
		Me.efServiceID.Name = "efServiceID"
		Me.efServiceID.Size = New System.Drawing.Size(70, 20)
		Me.efServiceID.TabIndex = 0
		'
		'device
		'
		Me.device.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.device.AutoSize = True
		Me.device.Location = New System.Drawing.Point(3, 6)
		Me.device.Name = "device"
		Me.device.Size = New System.Drawing.Size(57, 13)
		Me.device.TabIndex = 1
		Me.device.Text = "ServiceID:"
		Me.device.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel8
		'
		Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel8.AutoSize = True
		Me.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel8.ColumnCount = 2
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel8.Controls.Add(Me.efPOIID, 1, 0)
		Me.TableLayoutPanel8.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 6)
		Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
		Me.TableLayoutPanel8.RowCount = 1
		Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel8.Size = New System.Drawing.Size(121, 26)
		Me.TableLayoutPanel8.TabIndex = 0
		'
		'efPOIID
		'
		Me.efPOIID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efPOIID.Location = New System.Drawing.Point(48, 3)
		Me.efPOIID.Name = "efPOIID"
		Me.efPOIID.Size = New System.Drawing.Size(70, 20)
		Me.efPOIID.TabIndex = 0
		Me.efPOIID.Text = "myPOI"
		'
		'Label2
		'
		Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 6)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "POIID:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel9
		'
		Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel9.AutoSize = True
		Me.TableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel9.ColumnCount = 2
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel9.Controls.Add(Me.efSaleID, 1, 0)
		Me.TableLayoutPanel9.Controls.Add(Me.Label3, 0, 0)
		Me.TableLayoutPanel9.Location = New System.Drawing.Point(130, 6)
		Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
		Me.TableLayoutPanel9.RowCount = 1
		Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel9.Size = New System.Drawing.Size(124, 26)
		Me.TableLayoutPanel9.TabIndex = 1
		'
		'efSaleID
		'
		Me.efSaleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efSaleID.Location = New System.Drawing.Point(51, 3)
		Me.efSaleID.Name = "efSaleID"
		Me.efSaleID.Size = New System.Drawing.Size(70, 20)
		Me.efSaleID.TabIndex = 0
		Me.efSaleID.Text = "mySale"
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 6)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "SaleID:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 3
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.cbUseConnectionSettings, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.efConnectionReply, 2, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.pbConnectionSettings, 1, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(548, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(345, 32)
		Me.TableLayoutPanel3.TabIndex = 4
		'
		'cbUseConnectionSettings
		'
		Me.cbUseConnectionSettings.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbUseConnectionSettings.AutoSize = True
		Me.cbUseConnectionSettings.Location = New System.Drawing.Point(3, 7)
		Me.cbUseConnectionSettings.Name = "cbUseConnectionSettings"
		Me.cbUseConnectionSettings.Size = New System.Drawing.Size(119, 17)
		Me.cbUseConnectionSettings.TabIndex = 0
		Me.cbUseConnectionSettings.Text = "Use pre-connection"
		Me.cbUseConnectionSettings.UseVisualStyleBackColor = True
		'
		'efConnectionReply
		'
		Me.efConnectionReply.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efConnectionReply.Location = New System.Drawing.Point(189, 6)
		Me.efConnectionReply.Name = "efConnectionReply"
		Me.efConnectionReply.Size = New System.Drawing.Size(153, 20)
		Me.efConnectionReply.TabIndex = 2
		'
		'pbConnectionSettings
		'
		Me.pbConnectionSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbConnectionSettings.AutoSize = True
		Me.pbConnectionSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbConnectionSettings.Location = New System.Drawing.Point(128, 4)
		Me.pbConnectionSettings.Name = "pbConnectionSettings"
		Me.pbConnectionSettings.Size = New System.Drawing.Size(55, 23)
		Me.pbConnectionSettings.TabIndex = 1
		Me.pbConnectionSettings.Text = "Settings"
		Me.pbConnectionSettings.UseVisualStyleBackColor = True
		'
		'panelClientServer
		'
		Me.panelClientServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientServer.AutoSize = True
		Me.panelClientServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientServer.ColumnCount = 5
		Me.panelClient.SetColumnSpan(Me.panelClientServer, 2)
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientServer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelClientServer.Controls.Add(Me.panelClientTimeout, 3, 0)
		Me.panelClientServer.Controls.Add(Me.Label7, 0, 0)
		Me.panelClientServer.Controls.Add(Me.panelClientTarget, 2, 0)
		Me.panelClientServer.Controls.Add(Me.panelClientButtons1, 4, 0)
		Me.panelClientServer.Controls.Add(Me.panelClientTargets, 1, 0)
		Me.panelClientServer.Location = New System.Drawing.Point(3, 47)
		Me.panelClientServer.Name = "panelClientServer"
		Me.panelClientServer.RowCount = 1
		Me.panelClientServer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientServer.Size = New System.Drawing.Size(1026, 38)
		Me.panelClientServer.TabIndex = 9
		'
		'panelClientTimeout
		'
		Me.panelClientTimeout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientTimeout.AutoSize = True
		Me.panelClientTimeout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientTimeout.ColumnCount = 3
		Me.panelClientTimeout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTimeout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientTimeout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTimeout.Controls.Add(Me.udTimeout, 1, 0)
		Me.panelClientTimeout.Controls.Add(Me.Label8, 0, 0)
		Me.panelClientTimeout.Controls.Add(Me.cbInfinite, 2, 0)
		Me.panelClientTimeout.Location = New System.Drawing.Point(567, 3)
		Me.panelClientTimeout.Name = "panelClientTimeout"
		Me.panelClientTimeout.RowCount = 1
		Me.panelClientTimeout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientTimeout.Size = New System.Drawing.Size(176, 32)
		Me.panelClientTimeout.TabIndex = 2
		'
		'udTimeout
		'
		Me.udTimeout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udTimeout.AutoSize = True
		Me.udTimeout.Location = New System.Drawing.Point(57, 6)
		Me.udTimeout.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udTimeout.Name = "udTimeout"
		Me.udTimeout.Size = New System.Drawing.Size(53, 20)
		Me.udTimeout.TabIndex = 0
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(3, 9)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(48, 13)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "Timeout:"
		'
		'cbInfinite
		'
		Me.cbInfinite.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbInfinite.AutoSize = True
		Me.cbInfinite.Location = New System.Drawing.Point(116, 7)
		Me.cbInfinite.Name = "cbInfinite"
		Me.cbInfinite.Size = New System.Drawing.Size(57, 17)
		Me.cbInfinite.TabIndex = 1
		Me.cbInfinite.Text = "Infinite"
		Me.cbInfinite.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(3, 12)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(95, 13)
		Me.Label7.TabIndex = 5
		Me.Label7.Text = "Server to reach"
		'
		'panelClientTarget
		'
		Me.panelClientTarget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientTarget.AutoSize = True
		Me.panelClientTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientTarget.ColumnCount = 2
		Me.panelClientTarget.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTarget.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTarget.Controls.Add(Me.PanelIPPort, 0, 0)
		Me.panelClientTarget.Controls.Add(Me.TableLayoutPanel1, 1, 0)
		Me.panelClientTarget.Location = New System.Drawing.Point(334, 3)
		Me.panelClientTarget.Name = "panelClientTarget"
		Me.panelClientTarget.RowCount = 1
		Me.panelClientTarget.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientTarget.Size = New System.Drawing.Size(227, 32)
		Me.panelClientTarget.TabIndex = 1
		'
		'PanelIPPort
		'
		Me.PanelIPPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PanelIPPort.AutoSize = True
		Me.PanelIPPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.PanelIPPort.ColumnCount = 2
		Me.PanelIPPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.PanelIPPort.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.PanelIPPort.Controls.Add(Me.Label5, 0, 0)
		Me.PanelIPPort.Controls.Add(Me.efTargetIP, 1, 0)
		Me.PanelIPPort.Location = New System.Drawing.Point(3, 3)
		Me.PanelIPPort.Name = "PanelIPPort"
		Me.PanelIPPort.RowCount = 1
		Me.PanelIPPort.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.PanelIPPort.Size = New System.Drawing.Size(121, 26)
		Me.PanelIPPort.TabIndex = 2
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 6)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(17, 13)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "IP"
		'
		'efTargetIP
		'
		Me.efTargetIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efTargetIP.Location = New System.Drawing.Point(26, 3)
		Me.efTargetIP.Name = "efTargetIP"
		Me.efTargetIP.Size = New System.Drawing.Size(92, 20)
		Me.efTargetIP.TabIndex = 0
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
		Me.TableLayoutPanel1.Controls.Add(Me.udTargetPort, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(130, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(94, 26)
		Me.TableLayoutPanel1.TabIndex = 6
		'
		'udTargetPort
		'
		Me.udTargetPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.udTargetPort.AutoSize = True
		Me.udTargetPort.Location = New System.Drawing.Point(38, 3)
		Me.udTargetPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.udTargetPort.Name = "udTargetPort"
		Me.udTargetPort.Size = New System.Drawing.Size(53, 20)
		Me.udTargetPort.TabIndex = 0
		Me.udTargetPort.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label9
		'
		Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(3, 6)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(29, 13)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "Port:"
		'
		'panelClientButtons1
		'
		Me.panelClientButtons1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientButtons1.AutoSize = True
		Me.panelClientButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientButtons1.ColumnCount = 3
		Me.panelClientButtons1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientButtons1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientButtons1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientButtons1.Controls.Add(Me.pbConnect, 0, 0)
		Me.panelClientButtons1.Controls.Add(Me.pbDisconnect, 2, 0)
		Me.panelClientButtons1.Controls.Add(Me.cbxConnections, 1, 0)
		Me.panelClientButtons1.Location = New System.Drawing.Point(749, 3)
		Me.panelClientButtons1.Name = "panelClientButtons1"
		Me.panelClientButtons1.RowCount = 1
		Me.panelClientButtons1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientButtons1.Size = New System.Drawing.Size(274, 32)
		Me.panelClientButtons1.TabIndex = 8
		'
		'pbConnect
		'
		Me.pbConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbConnect.AutoSize = True
		Me.pbConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbConnect.Location = New System.Drawing.Point(3, 4)
		Me.pbConnect.Name = "pbConnect"
		Me.pbConnect.Size = New System.Drawing.Size(57, 23)
		Me.pbConnect.TabIndex = 4
		Me.pbConnect.Text = "Connect"
		Me.pbConnect.UseVisualStyleBackColor = True
		'
		'pbDisconnect
		'
		Me.pbDisconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbDisconnect.AutoSize = True
		Me.pbDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbDisconnect.Location = New System.Drawing.Point(200, 4)
		Me.pbDisconnect.Name = "pbDisconnect"
		Me.pbDisconnect.Size = New System.Drawing.Size(71, 23)
		Me.pbDisconnect.TabIndex = 7
		Me.pbDisconnect.Text = "Disconnect"
		Me.pbDisconnect.UseVisualStyleBackColor = True
		'
		'cbxConnections
		'
		Me.cbxConnections.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbxConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxConnections.FormattingEnabled = True
		Me.cbxConnections.Location = New System.Drawing.Point(66, 5)
		Me.cbxConnections.Name = "cbxConnections"
		Me.cbxConnections.Size = New System.Drawing.Size(128, 21)
		Me.cbxConnections.TabIndex = 6
		'
		'panelClientTargets
		'
		Me.panelClientTargets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelClientTargets.AutoSize = True
		Me.panelClientTargets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelClientTargets.ColumnCount = 3
		Me.panelClientTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelClientTargets.Controls.Add(Me.rbServer, 2, 0)
		Me.panelClientTargets.Controls.Add(Me.rbGateway, 1, 0)
		Me.panelClientTargets.Controls.Add(Me.rbLocalHost, 0, 0)
		Me.panelClientTargets.Location = New System.Drawing.Point(104, 3)
		Me.panelClientTargets.Name = "panelClientTargets"
		Me.panelClientTargets.RowCount = 1
		Me.panelClientTargets.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelClientTargets.Size = New System.Drawing.Size(224, 32)
		Me.panelClientTargets.TabIndex = 4
		'
		'rbServer
		'
		Me.rbServer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbServer.AutoSize = True
		Me.rbServer.Location = New System.Drawing.Point(156, 7)
		Me.rbServer.Name = "rbServer"
		Me.rbServer.Size = New System.Drawing.Size(65, 17)
		Me.rbServer.TabIndex = 2
		Me.rbServer.TabStop = True
		Me.rbServer.Text = "Terminal"
		Me.rbServer.UseVisualStyleBackColor = True
		'
		'rbGateway
		'
		Me.rbGateway.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbGateway.AutoSize = True
		Me.rbGateway.Location = New System.Drawing.Point(83, 7)
		Me.rbGateway.Name = "rbGateway"
		Me.rbGateway.Size = New System.Drawing.Size(67, 17)
		Me.rbGateway.TabIndex = 1
		Me.rbGateway.TabStop = True
		Me.rbGateway.Text = "Gateway"
		Me.rbGateway.UseVisualStyleBackColor = True
		'
		'rbLocalHost
		'
		Me.rbLocalHost.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbLocalHost.AutoSize = True
		Me.rbLocalHost.Location = New System.Drawing.Point(3, 7)
		Me.rbLocalHost.Name = "rbLocalHost"
		Me.rbLocalHost.Size = New System.Drawing.Size(74, 17)
		Me.rbLocalHost.TabIndex = 0
		Me.rbLocalHost.TabStop = True
		Me.rbLocalHost.Text = "Local host"
		Me.rbLocalHost.UseVisualStyleBackColor = True
		'
		'panelRaw
		'
		Me.panelRaw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelRaw.AutoSize = True
		Me.panelRaw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelRaw.ColumnCount = 8
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelRaw.Controls.Add(Me.pbSendFreeMessage, 6, 0)
		Me.panelRaw.Controls.Add(Me.lblFreeMessage, 0, 0)
		Me.panelRaw.Controls.Add(Me.pbBuild, 5, 0)
		Me.panelRaw.Controls.Add(Me.cbxCommands, 2, 0)
		Me.panelRaw.Controls.Add(Me.pbAdd, 1, 0)
		Me.panelRaw.Controls.Add(Me.efCommand, 4, 0)
		Me.panelRaw.Controls.Add(Me.pbRemove, 3, 0)
		Me.panelRaw.Controls.Add(Me.pbSendRequest, 7, 0)
		Me.panelRaw.Location = New System.Drawing.Point(3, 191)
		Me.panelRaw.Name = "panelRaw"
		Me.panelRaw.RowCount = 1
		Me.panelRaw.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelRaw.Size = New System.Drawing.Size(1032, 29)
		Me.panelRaw.TabIndex = 3
		'
		'pbSendFreeMessage
		'
		Me.pbSendFreeMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSendFreeMessage.AutoSize = True
		Me.pbSendFreeMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSendFreeMessage.Location = New System.Drawing.Point(880, 3)
		Me.pbSendFreeMessage.Name = "pbSendFreeMessage"
		Me.pbSendFreeMessage.Size = New System.Drawing.Size(62, 23)
		Me.pbSendFreeMessage.TabIndex = 5
		Me.pbSendFreeMessage.Text = "Send raw"
		Me.pbSendFreeMessage.UseVisualStyleBackColor = True
		'
		'lblFreeMessage
		'
		Me.lblFreeMessage.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.lblFreeMessage.AutoSize = True
		Me.lblFreeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFreeMessage.Location = New System.Drawing.Point(3, 4)
		Me.lblFreeMessage.Name = "lblFreeMessage"
		Me.lblFreeMessage.Size = New System.Drawing.Size(123, 20)
		Me.lblFreeMessage.TabIndex = 13
		Me.lblFreeMessage.Text = "Free message"
		'
		'pbBuild
		'
		Me.pbBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbBuild.AutoSize = True
		Me.pbBuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbBuild.Location = New System.Drawing.Point(834, 3)
		Me.pbBuild.Name = "pbBuild"
		Me.pbBuild.Size = New System.Drawing.Size(40, 23)
		Me.pbBuild.TabIndex = 4
		Me.pbBuild.Text = "Build"
		Me.pbBuild.UseVisualStyleBackColor = True
		'
		'cbxCommands
		'
		Me.cbxCommands.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbxCommands.ContextMenuStrip = Me.ContextMenuStrip1
		Me.cbxCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxCommands.FormattingEnabled = True
		Me.cbxCommands.Location = New System.Drawing.Point(174, 4)
		Me.cbxCommands.Name = "cbxCommands"
		Me.cbxCommands.Size = New System.Drawing.Size(145, 21)
		Me.cbxCommands.TabIndex = 1
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 26)
		'
		'RenameToolStripMenuItem
		'
		Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
		Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
		Me.RenameToolStripMenuItem.Text = "Rename..."
		'
		'pbAdd
		'
		Me.pbAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAdd.AutoSize = True
		Me.pbAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAdd.Location = New System.Drawing.Point(132, 3)
		Me.pbAdd.Name = "pbAdd"
		Me.pbAdd.Size = New System.Drawing.Size(36, 23)
		Me.pbAdd.TabIndex = 0
		Me.pbAdd.Text = "Add"
		Me.pbAdd.UseVisualStyleBackColor = True
		'
		'efCommand
		'
		Me.efCommand.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efCommand.Location = New System.Drawing.Point(379, 4)
		Me.efCommand.Multiline = True
		Me.efCommand.Name = "efCommand"
		Me.efCommand.Size = New System.Drawing.Size(449, 20)
		Me.efCommand.TabIndex = 3
		Me.efCommand.WordWrap = False
		'
		'pbRemove
		'
		Me.pbRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbRemove.AutoSize = True
		Me.pbRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbRemove.Location = New System.Drawing.Point(325, 3)
		Me.pbRemove.Name = "pbRemove"
		Me.pbRemove.Size = New System.Drawing.Size(48, 23)
		Me.pbRemove.TabIndex = 2
		Me.pbRemove.Text = "Delete"
		Me.pbRemove.UseVisualStyleBackColor = True
		'
		'pbSendRequest
		'
		Me.pbSendRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSendRequest.AutoSize = True
		Me.pbSendRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSendRequest.Location = New System.Drawing.Point(948, 3)
		Me.pbSendRequest.Name = "pbSendRequest"
		Me.pbSendRequest.Size = New System.Drawing.Size(81, 23)
		Me.pbSendRequest.TabIndex = 14
		Me.pbSendRequest.Text = "Send request"
		Me.pbSendRequest.UseVisualStyleBackColor = True
		'
		'cbxLog
		'
		Me.cbxLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbxLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxLog.FormattingEnabled = True
		Me.cbxLog.Location = New System.Drawing.Point(3, 4)
		Me.cbxLog.Name = "cbxLog"
		Me.cbxLog.Size = New System.Drawing.Size(121, 21)
		Me.cbxLog.TabIndex = 5
		'
		'FSimulator
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1068, 509)
		Me.Controls.Add(Me.PanelMain)
		Me.MinimumSize = New System.Drawing.Size(1084, 548)
		Me.Name = "FSimulator"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NEXO Retailer Simulator"
		Me.PanelMain.ResumeLayout(False)
		Me.PanelMain.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel7.PerformLayout()
		Me.panelOptions.ResumeLayout(False)
		Me.panelOptions.PerformLayout()
		Me.panelCommands.ResumeLayout(False)
		Me.panelCommands.PerformLayout()
		Me.panelCommandButtons.ResumeLayout(False)
		Me.panelCommandButtons.PerformLayout()
		Me.panelGateway.ResumeLayout(False)
		Me.panelGateway.PerformLayout()
		Me.serverToReachPanel14.ResumeLayout(False)
		Me.serverToReachPanel14.PerformLayout()
		Me.panelGatewayPort.ResumeLayout(False)
		Me.panelGatewayPort.PerformLayout()
		CType(Me.udGatewayPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelGatewayServer.ResumeLayout(False)
		Me.panelGatewayServer.PerformLayout()
		Me.TableLayoutPanel12.ResumeLayout(False)
		Me.TableLayoutPanel12.PerformLayout()
		Me.panelGatewayDistantPort.ResumeLayout(False)
		Me.panelGatewayDistantPort.PerformLayout()
		CType(Me.udGatewayServerPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelGatewayButtons.ResumeLayout(False)
		Me.panelGatewayButtons.PerformLayout()
		Me.panelServer.ResumeLayout(False)
		Me.panelServer.PerformLayout()
		Me.panelServerButtons.ResumeLayout(False)
		Me.panelServerButtons.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		CType(Me.udServerDelay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelServerPort.ResumeLayout(False)
		Me.panelServerPort.PerformLayout()
		CType(Me.udLocalServerPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelClient.ResumeLayout(False)
		Me.panelClient.PerformLayout()
		Me.panelClientNexo.ResumeLayout(False)
		Me.panelClientNexo.PerformLayout()
		Me.TableLayoutPanel10.ResumeLayout(False)
		Me.TableLayoutPanel10.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.TableLayoutPanel8.ResumeLayout(False)
		Me.TableLayoutPanel8.PerformLayout()
		Me.TableLayoutPanel9.ResumeLayout(False)
		Me.TableLayoutPanel9.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.panelClientServer.ResumeLayout(False)
		Me.panelClientServer.PerformLayout()
		Me.panelClientTimeout.ResumeLayout(False)
		Me.panelClientTimeout.PerformLayout()
		CType(Me.udTimeout, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelClientTarget.ResumeLayout(False)
		Me.panelClientTarget.PerformLayout()
		Me.PanelIPPort.ResumeLayout(False)
		Me.PanelIPPort.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me.udTargetPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panelClientButtons1.ResumeLayout(False)
		Me.panelClientButtons1.PerformLayout()
		Me.panelClientTargets.ResumeLayout(False)
		Me.panelClientTargets.PerformLayout()
		Me.panelRaw.ResumeLayout(False)
		Me.panelRaw.PerformLayout()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PanelMain As TableLayoutPanel
	Friend WithEvents panelButtons As TableLayoutPanel
	Friend WithEvents cbAutostartServer As CheckBox
	Friend WithEvents pbClose As Button
	Friend WithEvents panelClientButtons As TableLayoutPanel
	Friend WithEvents pbLogin As Button
	Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
	Friend WithEvents lblServerHeader As Label
	Friend WithEvents lblClientHeader As Label
	Friend WithEvents pbLogout As Button
	Friend WithEvents pbPayment As Button
	Friend WithEvents pbReversal As Button
	Friend WithEvents pbDevicePrint As Button
	Friend WithEvents pbDeviceInput As Button
	Friend WithEvents pbRefund As Button
	Friend WithEvents panelCommands As TableLayoutPanel
	Friend WithEvents pbSendFreeMessage As Button
	Friend WithEvents panelOptions As TableLayoutPanel
	Friend WithEvents panelServer As TableLayoutPanel
	Friend WithEvents pbStartServer As Button
	Friend WithEvents panelServerPort As TableLayoutPanel
	Friend WithEvents udLocalServerPort As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents cbConnected As CheckBox
	Friend WithEvents pbServerActivity As Button
	Friend WithEvents pbStopServer As Button
	Friend WithEvents serverToReachPanel14 As TableLayoutPanel
	Friend WithEvents panelClientTimeout As TableLayoutPanel
	Friend WithEvents udTimeout As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents udTargetPort As NumericUpDown
	Friend WithEvents Label9 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents PanelIPPort As TableLayoutPanel
	Friend WithEvents Label5 As Label
	Friend WithEvents efTargetIP As TextBox
	Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
	Friend WithEvents efPOIID As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
	Friend WithEvents efDeviceID As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents efServiceID As TextBox
	Friend WithEvents device As Label
	Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
	Friend WithEvents efSaleID As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents panelGatewayDistantPort As TableLayoutPanel
	Friend WithEvents udGatewayServerPort As NumericUpDown
	Friend WithEvents Label11 As Label
	Friend WithEvents panelGateway As TableLayoutPanel
	Friend WithEvents panelGatewayPort As TableLayoutPanel
	Friend WithEvents udGatewayPort As NumericUpDown
	Friend WithEvents Label12 As Label
	Friend WithEvents panelGatewayButtons As TableLayoutPanel
	Friend WithEvents pbStopGateway As Button
	Friend WithEvents pbStartGateway As Button
	Friend WithEvents cbGatewayUseLocalHost As CheckBox
	Friend WithEvents pbSaveContent As Button
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents pbSaveSettings As Button
	Friend WithEvents pbClear As Button
	Friend WithEvents lblServer As Label
	Friend WithEvents panelServerButtons As TableLayoutPanel
	Friend WithEvents lblGateway As Label
	Friend WithEvents lblGatewayHeader As Label
	Friend WithEvents ColorDialog1 As ColorDialog
	Friend WithEvents cbAutostartGateway As CheckBox
	Friend WithEvents panelClient As TableLayoutPanel
	Friend WithEvents lblClient As Label
	Friend WithEvents panelClientNexo As TableLayoutPanel
	Friend WithEvents panelClientServer As TableLayoutPanel
	Friend WithEvents panelRaw As TableLayoutPanel
	Friend WithEvents lblFreeMessage As Label
	Friend WithEvents panelClientButtons1 As TableLayoutPanel
	Friend WithEvents pbConnect As Button
	Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
	Friend WithEvents Label6 As Label
	Friend WithEvents efGatewayServerIP As TextBox
	Friend WithEvents panelGatewayServer As TableLayoutPanel
	Friend WithEvents panelClientTarget As TableLayoutPanel
	Friend WithEvents panelClientTargets As TableLayoutPanel
	Friend WithEvents rbServer As RadioButton
	Friend WithEvents rbGateway As RadioButton
	Friend WithEvents rbLocalHost As RadioButton
	Friend WithEvents cbxConnections As ComboBox
	Friend WithEvents pbDisconnect As Button
	Friend WithEvents cbInfinite As CheckBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents udServerDelay As NumericUpDown
	Friend WithEvents Label10 As Label
	Friend WithEvents cbSynchronous As CheckBox
	Friend WithEvents cbOptimize As CheckBox
	Friend WithEvents cbUseJson As CheckBox
	Friend WithEvents pbDatabaseSettings As Button
	Friend WithEvents pbBuild As Button
	Friend WithEvents cbUseDatabase As CheckBox
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents cbUseConnectionSettings As CheckBox
	Friend WithEvents efConnectionReply As TextBox
	Friend WithEvents pbConnectionSettings As Button
	Friend WithEvents pbAdd As Button
	Friend WithEvents pbRemove As Button
	Friend WithEvents cbxCommands As ComboBox
	Friend WithEvents efCommand As TextBox
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents pbSendRequest As Button
	Friend WithEvents pbResponseFolder As Button
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents panelCommandButtons As TableLayoutPanel
	Friend WithEvents cbxLog As ComboBox
End Class