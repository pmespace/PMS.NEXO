<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FActivity
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
		Me.efActivity = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.rbConnected = New System.Windows.Forms.RadioButton()
		Me.rbConnections = New System.Windows.Forms.RadioButton()
		Me.rbCommands = New System.Windows.Forms.RadioButton()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'efActivity
		'
		Me.efActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efActivity.Location = New System.Drawing.Point(3, 32)
		Me.efActivity.Multiline = True
		Me.efActivity.Name = "efActivity"
		Me.efActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.efActivity.Size = New System.Drawing.Size(808, 347)
		Me.efActivity.TabIndex = 0
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
		Me.TableLayoutPanel1.Controls.Add(Me.efActivity, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(814, 382)
		Me.TableLayoutPanel1.TabIndex = 1
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
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.rbConnected, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.rbConnections, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.rbCommands, 0, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(808, 23)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'rbConnected
		'
		Me.rbConnected.AutoSize = True
		Me.rbConnected.Location = New System.Drawing.Point(176, 3)
		Me.rbConnected.Name = "rbConnected"
		Me.rbConnected.Size = New System.Drawing.Size(77, 17)
		Me.rbConnected.TabIndex = 2
		Me.rbConnected.TabStop = True
		Me.rbConnected.Text = "Connected"
		Me.rbConnected.UseVisualStyleBackColor = True
		'
		'rbConnections
		'
		Me.rbConnections.AutoSize = True
		Me.rbConnections.Location = New System.Drawing.Point(86, 3)
		Me.rbConnections.Name = "rbConnections"
		Me.rbConnections.Size = New System.Drawing.Size(84, 17)
		Me.rbConnections.TabIndex = 1
		Me.rbConnections.TabStop = True
		Me.rbConnections.Text = "Connections"
		Me.rbConnections.UseVisualStyleBackColor = True
		'
		'rbCommands
		'
		Me.rbCommands.AutoSize = True
		Me.rbCommands.Location = New System.Drawing.Point(3, 3)
		Me.rbCommands.Name = "rbCommands"
		Me.rbCommands.Size = New System.Drawing.Size(77, 17)
		Me.rbCommands.TabIndex = 0
		Me.rbCommands.TabStop = True
		Me.rbCommands.Text = "Commands"
		Me.rbCommands.UseVisualStyleBackColor = True
		'
		'FActivity
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(838, 406)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "FActivity"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Server activity"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents efActivity As TextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents rbCommands As RadioButton
	Friend WithEvents rbConnected As RadioButton
	Friend WithEvents rbConnections As RadioButton
End Class
