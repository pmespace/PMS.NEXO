<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FParameters
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
		Me.pbSave = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.panelNexoSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.saleID = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbSaleIDUSeIP = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cbPOIIDUseIP = New System.Windows.Forms.CheckBox()
		Me.POIID = New System.Windows.Forms.TextBox()
		Me.panelServerSettings = New System.Windows.Forms.TableLayoutPanel()
		Me.serverIP = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.serverPort = New System.Windows.Forms.NumericUpDown()
		Me.pbTestConnection = New System.Windows.Forms.Button()
		Me.pbSaveSettings = New System.Windows.Forms.Button()
		Me.panelMain.SuspendLayout()
		Me.panelButtons.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.panelNexoSettings.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.panelServerSettings.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.serverPort, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.panelMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
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
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(770, 385)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.panelNexoSettings, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(764, 32)
		Me.TableLayoutPanel2.TabIndex = 0
		'
		'panelNexoSettings
		'
		Me.panelNexoSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelNexoSettings.AutoSize = True
		Me.panelNexoSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelNexoSettings.ColumnCount = 3
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelNexoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelNexoSettings.Controls.Add(Me.saleID, 1, 0)
		Me.panelNexoSettings.Controls.Add(Me.Label1, 0, 0)
		Me.panelNexoSettings.Controls.Add(Me.cbSaleIDUSeIP, 2, 0)
		Me.panelNexoSettings.Location = New System.Drawing.Point(3, 3)
		Me.panelNexoSettings.Name = "panelNexoSettings"
		Me.panelNexoSettings.RowCount = 1
		Me.panelNexoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelNexoSettings.Size = New System.Drawing.Size(376, 26)
		Me.panelNexoSettings.TabIndex = 0
		'
		'saleID
		'
		Me.saleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.saleID.Location = New System.Drawing.Point(51, 3)
		Me.saleID.Name = "saleID"
		Me.saleID.Size = New System.Drawing.Size(258, 20)
		Me.saleID.TabIndex = 0
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
		Me.cbSaleIDUSeIP.Location = New System.Drawing.Point(315, 4)
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
		Me.TableLayoutPanel4.Controls.Add(Me.POIID, 1, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(385, 3)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(376, 26)
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
		Me.cbPOIIDUseIP.Location = New System.Drawing.Point(315, 4)
		Me.cbPOIIDUseIP.Name = "cbPOIIDUseIP"
		Me.cbPOIIDUseIP.Size = New System.Drawing.Size(58, 17)
		Me.cbPOIIDUseIP.TabIndex = 3
		Me.cbPOIIDUseIP.Text = "Use IP"
		Me.cbPOIIDUseIP.UseVisualStyleBackColor = True
		'
		'POIID
		'
		Me.POIID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.POIID.Location = New System.Drawing.Point(48, 3)
		Me.POIID.Name = "POIID"
		Me.POIID.Size = New System.Drawing.Size(261, 20)
		Me.POIID.TabIndex = 0
		'
		'panelServerSettings
		'
		Me.panelServerSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelServerSettings.AutoSize = True
		Me.panelServerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelServerSettings.ColumnCount = 6
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelServerSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelServerSettings.Controls.Add(Me.serverIP, 1, 0)
		Me.panelServerSettings.Controls.Add(Me.Label3, 0, 0)
		Me.panelServerSettings.Controls.Add(Me.Label5, 2, 0)
		Me.panelServerSettings.Controls.Add(Me.serverPort, 3, 0)
		Me.panelServerSettings.Controls.Add(Me.pbTestConnection, 4, 0)
		Me.panelServerSettings.Location = New System.Drawing.Point(3, 3)
		Me.panelServerSettings.Name = "panelServerSettings"
		Me.panelServerSettings.RowCount = 1
		Me.panelServerSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelServerSettings.Size = New System.Drawing.Size(758, 29)
		Me.panelServerSettings.TabIndex = 2
		'
		'serverIP
		'
		Me.serverIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.serverIP.Location = New System.Drawing.Point(72, 4)
		Me.serverIP.Name = "serverIP"
		Me.serverIP.Size = New System.Drawing.Size(105, 20)
		Me.serverIP.TabIndex = 0
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
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.panelServerSettings, 0, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 41)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(764, 35)
		Me.TableLayoutPanel3.TabIndex = 4
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
		'serverPort
		'
		Me.serverPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.serverPort.Location = New System.Drawing.Point(260, 4)
		Me.serverPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.serverPort.Name = "serverPort"
		Me.serverPort.Size = New System.Drawing.Size(57, 20)
		Me.serverPort.TabIndex = 3
		Me.serverPort.Value = New Decimal(New Integer() {2018, 0, 0, 0})
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
		'FParameters
		'
		Me.AcceptButton = Me.pbSave
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.pbCancel
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.panelMain)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FParameters"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Nexo Settings"
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.panelNexoSettings.ResumeLayout(False)
		Me.panelNexoSettings.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.panelServerSettings.ResumeLayout(False)
		Me.panelServerSettings.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.serverPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As Windows.Forms.TableLayoutPanel
	Friend WithEvents panelButtons As Windows.Forms.TableLayoutPanel
	Friend WithEvents pbSave As Windows.Forms.Button
	Friend WithEvents pbCancel As Windows.Forms.Button
	Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
	Friend WithEvents panelNexoSettings As Windows.Forms.TableLayoutPanel
	Friend WithEvents saleID As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents cbSaleIDUSeIP As Windows.Forms.CheckBox
	Friend WithEvents TableLayoutPanel4 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents cbPOIIDUseIP As Windows.Forms.CheckBox
	Friend WithEvents POIID As Windows.Forms.TextBox
	Friend WithEvents panelServerSettings As Windows.Forms.TableLayoutPanel
	Friend WithEvents serverIP As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents TableLayoutPanel3 As Windows.Forms.TableLayoutPanel
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents serverPort As Windows.Forms.NumericUpDown
	Friend WithEvents pbTestConnection As Windows.Forms.Button
	Friend WithEvents pbSaveSettings As Windows.Forms.Button
End Class
