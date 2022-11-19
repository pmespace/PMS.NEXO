<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FBuilder
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBuilder))
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.pbExpandAll = New System.Windows.Forms.Button()
		Me.cbOptimize = New System.Windows.Forms.CheckBox()
		Me.TreeView1 = New System.Windows.Forms.TreeView()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.SetValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ResetvalueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InsertItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TreeView1, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(819, 459)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 5
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.pbAccept, 3, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbCancel, 4, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbExpandAll, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.cbOptimize, 1, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 427)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(813, 29)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'pbAccept
		'
		Me.pbAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(703, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(51, 23)
		Me.pbAccept.TabIndex = 2
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'pbCancel
		'
		Me.pbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.Location = New System.Drawing.Point(760, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(50, 23)
		Me.pbCancel.TabIndex = 3
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'pbExpandAll
		'
		Me.pbExpandAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbExpandAll.AutoSize = True
		Me.pbExpandAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbExpandAll.Location = New System.Drawing.Point(3, 3)
		Me.pbExpandAll.Name = "pbExpandAll"
		Me.pbExpandAll.Size = New System.Drawing.Size(66, 23)
		Me.pbExpandAll.TabIndex = 0
		Me.pbExpandAll.Text = "Expand all"
		Me.pbExpandAll.UseVisualStyleBackColor = True
		'
		'cbOptimize
		'
		Me.cbOptimize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbOptimize.Checked = True
		Me.cbOptimize.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbOptimize.Location = New System.Drawing.Point(75, 3)
		Me.cbOptimize.Name = "cbOptimize"
		Me.cbOptimize.Size = New System.Drawing.Size(81, 23)
		Me.cbOptimize.TabIndex = 1
		Me.cbOptimize.Text = "Optimize"
		Me.cbOptimize.UseVisualStyleBackColor = True
		'
		'TreeView1
		'
		Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TreeView1.ImageIndex = 0
		Me.TreeView1.ImageList = Me.ImageList1
		Me.TreeView1.LabelEdit = True
		Me.TreeView1.Location = New System.Drawing.Point(3, 3)
		Me.TreeView1.Name = "TreeView1"
		Me.TreeView1.SelectedImageIndex = 0
		Me.TreeView1.Size = New System.Drawing.Size(813, 418)
		Me.TreeView1.TabIndex = 0
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList1.Images.SetKeyName(0, "home")
		Me.ImageList1.Images.SetKeyName(1, "array")
		Me.ImageList1.Images.SetKeyName(2, "arrayitem")
		Me.ImageList1.Images.SetKeyName(3, "tree")
		Me.ImageList1.Images.SetKeyName(4, "leaf")
		Me.ImageList1.Images.SetKeyName(5, "question")
		Me.ImageList1.Images.SetKeyName(6, "type")
		Me.ImageList1.Images.SetKeyName(7, "value")
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetValueToolStripMenuItem, Me.ResetvalueToolStripMenuItem, Me.AddItemToolStripMenuItem, Me.InsertItemToolStripMenuItem, Me.RemoveItemToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 114)
		'
		'SetValueToolStripMenuItem
		'
		Me.SetValueToolStripMenuItem.Name = "SetValueToolStripMenuItem"
		Me.SetValueToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.SetValueToolStripMenuItem.Text = "Set value"
		'
		'ResetvalueToolStripMenuItem
		'
		Me.ResetvalueToolStripMenuItem.Name = "ResetvalueToolStripMenuItem"
		Me.ResetvalueToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.ResetvalueToolStripMenuItem.Text = "Reset value"
		'
		'AddItemToolStripMenuItem
		'
		Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
		Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.AddItemToolStripMenuItem.Text = "Add item"
		'
		'InsertItemToolStripMenuItem
		'
		Me.InsertItemToolStripMenuItem.Name = "InsertItemToolStripMenuItem"
		Me.InsertItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.InsertItemToolStripMenuItem.Text = "Insert item"
		'
		'RemoveItemToolStripMenuItem
		'
		Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
		Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.RemoveItemToolStripMenuItem.Text = "Remove item"
		'
		'FBuilder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 483)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.MinimizeBox = False
		Me.Name = "FBuilder"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Saleto POI request builder"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents pbAccept As Button
	Friend WithEvents pbCancel As Button
	Friend WithEvents TreeView1 As TreeView
	Friend WithEvents pbExpandAll As Button
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents SetValueToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ResetvalueToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RemoveItemToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents cbOptimize As CheckBox
	Friend WithEvents InsertItemToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImageList1 As ImageList
End Class
