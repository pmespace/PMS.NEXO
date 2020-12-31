<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAmount
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
		Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.amountincents = New System.Windows.Forms.MaskedTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.ok = New System.Windows.Forms.Button()
		Me.cancel = New System.Windows.Forms.Button()
		Me.panelMain.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
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
		Me.panelMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
		Me.panelMain.Controls.Add(Me.TableLayoutPanel2, 0, 2)
		Me.panelMain.Location = New System.Drawing.Point(12, 12)
		Me.panelMain.Name = "panelMain"
		Me.panelMain.RowCount = 3
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelMain.Size = New System.Drawing.Size(208, 73)
		Me.panelMain.TabIndex = 0
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
		Me.TableLayoutPanel1.Controls.Add(Me.amountincents, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(202, 26)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'amountincents
		'
		Me.amountincents.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.amountincents.Location = New System.Drawing.Point(114, 3)
		Me.amountincents.Mask = "999999999999"
		Me.amountincents.Name = "amountincents"
		Me.amountincents.RejectInputOnFirstFailure = True
		Me.amountincents.ResetOnPrompt = False
		Me.amountincents.ResetOnSpace = False
		Me.amountincents.Size = New System.Drawing.Size(85, 20)
		Me.amountincents.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Amount (IN CENTS):"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.ok, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.cancel, 2, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 41)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(202, 29)
		Me.TableLayoutPanel2.TabIndex = 3
		'
		'ok
		'
		Me.ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ok.AutoSize = True
		Me.ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ok.Location = New System.Drawing.Point(111, 3)
		Me.ok.Name = "ok"
		Me.ok.Size = New System.Drawing.Size(32, 23)
		Me.ok.TabIndex = 0
		Me.ok.Text = "OK"
		Me.ok.UseVisualStyleBackColor = True
		'
		'cancel
		'
		Me.cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cancel.AutoSize = True
		Me.cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cancel.Location = New System.Drawing.Point(149, 3)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(50, 23)
		Me.cancel.TabIndex = 1
		Me.cancel.Text = "Cancel"
		Me.cancel.UseVisualStyleBackColor = True
		'
		'FAmount
		'
		Me.AcceptButton = Me.ok
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.cancel
		Me.ClientSize = New System.Drawing.Size(232, 97)
		Me.ControlBox = False
		Me.Controls.Add(Me.panelMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FAmount"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Payment"
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents amountincents As MaskedTextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents ok As Button
	Friend WithEvents cancel As Button
End Class
