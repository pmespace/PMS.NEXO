<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFreeText
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.lblInvite = New System.Windows.Forms.Label()
		Me.efText = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 126)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.pbCancel)
		Me.FlowLayoutPanel1.Controls.Add(Me.pbAccept)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 87)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(794, 36)
		Me.FlowLayoutPanel1.TabIndex = 0
		'
		'pbCancel
		'
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbCancel.Location = New System.Drawing.Point(723, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(68, 30)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'pbAccept
		'
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(648, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(69, 30)
		Me.pbAccept.TabIndex = 0
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.lblInvite, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.efText, 1, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 78)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'lblInvite
		'
		Me.lblInvite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblInvite.AutoSize = True
		Me.lblInvite.Location = New System.Drawing.Point(3, 29)
		Me.lblInvite.Name = "lblInvite"
		Me.lblInvite.Size = New System.Drawing.Size(114, 20)
		Me.lblInvite.TabIndex = 0
		Me.lblInvite.Text = "Enter free text:"
		'
		'efText
		'
		Me.efText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efText.Location = New System.Drawing.Point(123, 26)
		Me.efText.Name = "efText"
		Me.efText.Size = New System.Drawing.Size(668, 26)
		Me.efText.TabIndex = 1
		'
		'FFreeText
		'
		Me.AcceptButton = Me.pbAccept
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.pbCancel
		Me.ClientSize = New System.Drawing.Size(800, 126)
		Me.ControlBox = False
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FFreeText"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Enter free text"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents pbCancel As Button
	Friend WithEvents pbAccept As Button
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents lblInvite As Label
	Friend WithEvents efText As TextBox
End Class
