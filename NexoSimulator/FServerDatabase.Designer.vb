<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FServerDatabase
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FServerDatabase))
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.DataSet1 = New System.Data.DataSet()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbSave = New System.Windows.Forms.Button()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.pbClose = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BindingNavigator1.SuspendLayout()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.DataSource = Me.BindingSource1
		Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.Size = New System.Drawing.Size(986, 464)
		Me.DataGridView1.TabIndex = 0
		'
		'BindingNavigator1
		'
		Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
		Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
		Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
		Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
		Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.BindingNavigator1.Name = "BindingNavigator1"
		Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
		Me.BindingNavigator1.Size = New System.Drawing.Size(992, 25)
		Me.BindingNavigator1.TabIndex = 1
		Me.BindingNavigator1.Text = "BindingNavigator1"
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'DataSet1
		'
		Me.DataSet1.DataSetName = "NewDataSet"
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
		Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(992, 505)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 4
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.pbSave, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbAccept, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbClose, 3, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 473)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(986, 29)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'pbSave
		'
		Me.pbSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbSave.AutoSize = True
		Me.pbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbSave.Location = New System.Drawing.Point(835, 3)
		Me.pbSave.Name = "pbSave"
		Me.pbSave.Size = New System.Drawing.Size(42, 23)
		Me.pbSave.TabIndex = 0
		Me.pbSave.Text = "Save"
		Me.pbSave.UseVisualStyleBackColor = True
		'
		'pbAccept
		'
		Me.pbAccept.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(883, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(51, 23)
		Me.pbAccept.TabIndex = 1
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'pbClose
		'
		Me.pbClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbClose.AutoSize = True
		Me.pbClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbClose.Location = New System.Drawing.Point(940, 3)
		Me.pbClose.Name = "pbClose"
		Me.pbClose.Size = New System.Drawing.Size(43, 23)
		Me.pbClose.TabIndex = 2
		Me.pbClose.Text = "Close"
		Me.pbClose.UseVisualStyleBackColor = True
		'
		'FServerDatabase
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(992, 533)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.BindingNavigator1)
		Me.Name = "FServerDatabase"
		Me.Text = "Database data"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.BindingNavigator1.ResumeLayout(False)
		Me.BindingNavigator1.PerformLayout()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents BindingNavigator1 As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents DataSet1 As DataSet
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents pbSave As Button
	Friend WithEvents pbAccept As Button
	Friend WithEvents pbClose As Button
End Class
