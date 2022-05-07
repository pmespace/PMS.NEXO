<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FServerSettings
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.pbClose = New System.Windows.Forms.Button()
		Me.pbSave = New System.Windows.Forms.Button()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.efConnectionString = New System.Windows.Forms.TextBox()
		Me.pbTest = New System.Windows.Forms.Button()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.efEndPointsTableName = New System.Windows.Forms.TextBox()
		Me.pbEndPointsUpdate = New System.Windows.Forms.Button()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbSalesUpdate = New System.Windows.Forms.Button()
		Me.efSalesTablesName = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbConnectionsView = New System.Windows.Forms.Button()
		Me.efConnectionsTableName = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbMessagesView = New System.Windows.Forms.Button()
		Me.efMessagesTableName = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbFullSecured = New System.Windows.Forms.CheckBox()
		Me.cbDeclineByDefault = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.udDelayBeforeAutoLogout = New System.Windows.Forms.NumericUpDown()
		Me.panelMain.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel8.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.TableLayoutPanel5.SuspendLayout()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
		Me.TableLayoutPanel9.SuspendLayout()
		Me.TableLayoutPanel10.SuspendLayout()
		CType(Me.udDelayBeforeAutoLogout, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.panelMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
		Me.panelMain.Controls.Add(Me.TableLayoutPanel3, 0, 0)
		Me.panelMain.Controls.Add(Me.TableLayoutPanel2, 0, 1)
		Me.panelMain.Location = New System.Drawing.Point(12, 12)
		Me.panelMain.Name = "panelMain"
		Me.panelMain.RowCount = 3
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.Size = New System.Drawing.Size(588, 188)
		Me.panelMain.TabIndex = 0
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 4
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.pbAccept, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.pbClose, 3, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.pbSave, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 156)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(582, 29)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'pbAccept
		'
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(479, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(51, 23)
		Me.pbAccept.TabIndex = 1
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'pbClose
		'
		Me.pbClose.AutoSize = True
		Me.pbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClose.Location = New System.Drawing.Point(536, 3)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(43, 23)
		Me.pbClose.TabIndex = 2
		Me.pbClose.Text = "Close"
		Me.pbClose.UseVisualStyleBackColor = True
		'
		'pbSave
		'
		Me.pbSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSave.AutoSize = True
		Me.pbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSave.Location = New System.Drawing.Point(431, 3)
		Me.pbSave.Name = "pbSave"
		Me.pbSave.Size = New System.Drawing.Size(42, 23)
		Me.pbSave.TabIndex = 0
		Me.pbSave.Text = "Save"
		Me.pbSave.UseVisualStyleBackColor = True
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
		Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel8, 1, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(582, 35)
		Me.TableLayoutPanel3.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 11)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(92, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Connection string:"
		'
		'TableLayoutPanel8
		'
		Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel8.AutoSize = True
		Me.TableLayoutPanel8.ColumnCount = 2
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel8.Controls.Add(Me.efConnectionString, 0, 0)
		Me.TableLayoutPanel8.Controls.Add(Me.pbTest, 1, 0)
		Me.TableLayoutPanel8.Location = New System.Drawing.Point(101, 3)
		Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
		Me.TableLayoutPanel8.RowCount = 1
		Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel8.Size = New System.Drawing.Size(478, 29)
		Me.TableLayoutPanel8.TabIndex = 0
		'
		'efConnectionString
		'
		Me.efConnectionString.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efConnectionString.Location = New System.Drawing.Point(3, 4)
		Me.efConnectionString.Name = "efConnectionString"
		Me.efConnectionString.Size = New System.Drawing.Size(428, 20)
		Me.efConnectionString.TabIndex = 0
		'
		'pbTest
		'
		Me.pbTest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbTest.AutoSize = True
		Me.pbTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbTest.Location = New System.Drawing.Point(437, 3)
		Me.pbTest.Name = "pbTest"
		Me.pbTest.Size = New System.Drawing.Size(38, 23)
		Me.pbTest.TabIndex = 1
		Me.pbTest.Text = "Test"
		Me.pbTest.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 4
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 3, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 3, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel9, 0, 2)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 44)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 3
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(582, 106)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(299, 11)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(113, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Messages table name:"
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 11)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Connections table name:"
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 46)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(115, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "End points table name:"
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(321, 46)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(91, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Sales table name:"
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel4.AutoSize = True
		Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel4.ColumnCount = 2
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.Controls.Add(Me.efEndPointsTableName, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.pbEndPointsUpdate, 1, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(133, 38)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(160, 29)
		Me.TableLayoutPanel4.TabIndex = 2
		'
		'efEndPointsTableName
		'
		Me.efEndPointsTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efEndPointsTableName.Location = New System.Drawing.Point(3, 4)
		Me.efEndPointsTableName.Name = "efEndPointsTableName"
		Me.efEndPointsTableName.Size = New System.Drawing.Size(96, 20)
		Me.efEndPointsTableName.TabIndex = 0
		'
		'pbEndPointsUpdate
		'
		Me.pbEndPointsUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbEndPointsUpdate.AutoSize = True
		Me.pbEndPointsUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbEndPointsUpdate.Location = New System.Drawing.Point(105, 3)
		Me.pbEndPointsUpdate.Name = "pbEndPointsUpdate"
		Me.pbEndPointsUpdate.Size = New System.Drawing.Size(52, 23)
		Me.pbEndPointsUpdate.TabIndex = 1
		Me.pbEndPointsUpdate.Text = "Update"
		Me.pbEndPointsUpdate.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel5.AutoSize = True
		Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel5.ColumnCount = 2
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.Controls.Add(Me.pbSalesUpdate, 1, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.efSalesTablesName, 0, 0)
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(418, 38)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 1
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(161, 29)
		Me.TableLayoutPanel5.TabIndex = 3
		'
		'pbSalesUpdate
		'
		Me.pbSalesUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSalesUpdate.AutoSize = True
		Me.pbSalesUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSalesUpdate.Location = New System.Drawing.Point(106, 3)
		Me.pbSalesUpdate.Name = "pbSalesUpdate"
		Me.pbSalesUpdate.Size = New System.Drawing.Size(52, 23)
		Me.pbSalesUpdate.TabIndex = 1
		Me.pbSalesUpdate.Text = "Update"
		Me.pbSalesUpdate.UseVisualStyleBackColor = True
		'
		'efSalesTablesName
		'
		Me.efSalesTablesName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efSalesTablesName.Location = New System.Drawing.Point(3, 4)
		Me.efSalesTablesName.Name = "efSalesTablesName"
		Me.efSalesTablesName.Size = New System.Drawing.Size(97, 20)
		Me.efSalesTablesName.TabIndex = 0
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel6.AutoSize = True
		Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel6.ColumnCount = 2
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel6.Controls.Add(Me.pbConnectionsView, 1, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.efConnectionsTableName, 0, 0)
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(133, 3)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 1
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(160, 29)
		Me.TableLayoutPanel6.TabIndex = 0
		'
		'pbConnectionsView
		'
		Me.pbConnectionsView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbConnectionsView.AutoSize = True
		Me.pbConnectionsView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbConnectionsView.Location = New System.Drawing.Point(117, 3)
		Me.pbConnectionsView.Name = "pbConnectionsView"
		Me.pbConnectionsView.Size = New System.Drawing.Size(40, 23)
		Me.pbConnectionsView.TabIndex = 1
		Me.pbConnectionsView.Text = "View"
		Me.pbConnectionsView.UseVisualStyleBackColor = True
		'
		'efConnectionsTableName
		'
		Me.efConnectionsTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efConnectionsTableName.Location = New System.Drawing.Point(3, 4)
		Me.efConnectionsTableName.Name = "efConnectionsTableName"
		Me.efConnectionsTableName.Size = New System.Drawing.Size(108, 20)
		Me.efConnectionsTableName.TabIndex = 0
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel7.AutoSize = True
		Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel7.ColumnCount = 2
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.Controls.Add(Me.pbMessagesView, 1, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.efMessagesTableName, 0, 0)
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(418, 3)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 1
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(161, 29)
		Me.TableLayoutPanel7.TabIndex = 1
		'
		'pbMessagesView
		'
		Me.pbMessagesView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbMessagesView.AutoSize = True
		Me.pbMessagesView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbMessagesView.Location = New System.Drawing.Point(118, 3)
		Me.pbMessagesView.Name = "pbMessagesView"
		Me.pbMessagesView.Size = New System.Drawing.Size(40, 23)
		Me.pbMessagesView.TabIndex = 1
		Me.pbMessagesView.Text = "View"
		Me.pbMessagesView.UseVisualStyleBackColor = True
		'
		'efMessagesTableName
		'
		Me.efMessagesTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efMessagesTableName.Location = New System.Drawing.Point(3, 4)
		Me.efMessagesTableName.Name = "efMessagesTableName"
		Me.efMessagesTableName.Size = New System.Drawing.Size(109, 20)
		Me.efMessagesTableName.TabIndex = 0
		'
		'TableLayoutPanel9
		'
		Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel9.AutoSize = True
		Me.TableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel9.ColumnCount = 3
		Me.TableLayoutPanel2.SetColumnSpan(Me.TableLayoutPanel9, 4)
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel9.Controls.Add(Me.cbFullSecured, 1, 0)
		Me.TableLayoutPanel9.Controls.Add(Me.cbDeclineByDefault, 2, 0)
		Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 0, 0)
		Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 73)
		Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
		Me.TableLayoutPanel9.RowCount = 2
		Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel9.Size = New System.Drawing.Size(576, 30)
		Me.TableLayoutPanel9.TabIndex = 5
		'
		'cbFullSecured
		'
		Me.cbFullSecured.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbFullSecured.AutoSize = True
		Me.cbFullSecured.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cbFullSecured.Location = New System.Drawing.Point(375, 7)
		Me.cbFullSecured.Name = "cbFullSecured"
		Me.cbFullSecured.Size = New System.Drawing.Size(81, 17)
		Me.cbFullSecured.TabIndex = 0
		Me.cbFullSecured.Text = "Full security"
		Me.cbFullSecured.UseVisualStyleBackColor = True
		'
		'cbDeclineByDefault
		'
		Me.cbDeclineByDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbDeclineByDefault.AutoSize = True
		Me.cbDeclineByDefault.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cbDeclineByDefault.Location = New System.Drawing.Point(462, 7)
		Me.cbDeclineByDefault.Name = "cbDeclineByDefault"
		Me.cbDeclineByDefault.Size = New System.Drawing.Size(111, 17)
		Me.cbDeclineByDefault.TabIndex = 1
		Me.cbDeclineByDefault.Text = "Decline by default"
		Me.cbDeclineByDefault.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel10
		'
		Me.TableLayoutPanel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel10.AutoSize = True
		Me.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel10.ColumnCount = 2
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel10.Controls.Add(Me.Label6, 0, 0)
		Me.TableLayoutPanel10.Controls.Add(Me.udDelayBeforeAutoLogout, 1, 0)
		Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
		Me.TableLayoutPanel10.RowCount = 1
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel10.Size = New System.Drawing.Size(366, 26)
		Me.TableLayoutPanel10.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(3, 6)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(126, 13)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Delay before auto logout:"
		'
		'udDelayBeforeAutoLogout
		'
		Me.udDelayBeforeAutoLogout.Location = New System.Drawing.Point(135, 3)
		Me.udDelayBeforeAutoLogout.Name = "udDelayBeforeAutoLogout"
		Me.udDelayBeforeAutoLogout.Size = New System.Drawing.Size(71, 20)
		Me.udDelayBeforeAutoLogout.TabIndex = 0
		'
		'FServerSettings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(612, 212)
		Me.ControlBox = False
		Me.Controls.Add(Me.panelMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FServerSettings"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Server database settings"
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel8.ResumeLayout(False)
		Me.TableLayoutPanel8.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel7.PerformLayout()
		Me.TableLayoutPanel9.ResumeLayout(False)
		Me.TableLayoutPanel9.PerformLayout()
		Me.TableLayoutPanel10.ResumeLayout(False)
		Me.TableLayoutPanel10.PerformLayout()
		CType(Me.udDelayBeforeAutoLogout, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As TableLayoutPanel
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents efConnectionString As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents pbAccept As Button
	Friend WithEvents pbClose As Button
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents efSalesTablesName As TextBox
	Friend WithEvents efEndPointsTableName As TextBox
	Friend WithEvents efMessagesTableName As TextBox
	Friend WithEvents efConnectionsTableName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
	Friend WithEvents pbTest As Button
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents pbEndPointsUpdate As Button
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents pbSalesUpdate As Button
	Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
	Friend WithEvents pbConnectionsView As Button
	Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
	Friend WithEvents pbMessagesView As Button
	Friend WithEvents pbSave As Button
	Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
	Friend WithEvents cbFullSecured As CheckBox
	Friend WithEvents cbDeclineByDefault As CheckBox
	Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
	Friend WithEvents Label6 As Label
	Friend WithEvents udDelayBeforeAutoLogout As NumericUpDown
End Class
