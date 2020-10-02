<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProcessing
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.TableLayoutMain = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.information = New System.Windows.Forms.TextBox()
		Me.message = New System.Windows.Forms.TextBox()
		Me.price = New System.Windows.Forms.Label()
		Me.timerBeforeTimeout = New System.Windows.Forms.Timer(Me.components)
		Me.timerBeforeAutoClose = New System.Windows.Forms.Timer(Me.components)
		Me.timerGlobal = New System.Windows.Forms.Timer(Me.components)
		Me.TableLayoutMain.SuspendLayout()
		Me.TableLayoutButtons.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutMain
		'
		Me.TableLayoutMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutMain.ColumnCount = 1
		Me.TableLayoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutMain.Controls.Add(Me.TableLayoutButtons, 0, 2)
		Me.TableLayoutMain.Controls.Add(Me.TableLayoutPanel1, 0, 1)
		Me.TableLayoutMain.Controls.Add(Me.price, 0, 0)
		Me.TableLayoutMain.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutMain.Name = "TableLayoutMain"
		Me.TableLayoutMain.RowCount = 3
		Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutMain.Size = New System.Drawing.Size(798, 359)
		Me.TableLayoutMain.TabIndex = 0
		'
		'TableLayoutButtons
		'
		Me.TableLayoutButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutButtons.AutoSize = True
		Me.TableLayoutButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutButtons.ColumnCount = 1
		Me.TableLayoutButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutButtons.Controls.Add(Me.pbCancel, 0, 0)
		Me.TableLayoutButtons.Location = New System.Drawing.Point(3, 327)
		Me.TableLayoutButtons.Name = "TableLayoutButtons"
		Me.TableLayoutButtons.RowCount = 1
		Me.TableLayoutButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutButtons.Size = New System.Drawing.Size(792, 29)
		Me.TableLayoutButtons.TabIndex = 1
		'
		'pbCancel
		'
		Me.pbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.Location = New System.Drawing.Point(3, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(786, 23)
		Me.pbCancel.TabIndex = 0
		Me.pbCancel.TabStop = False
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.information, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.message, 0, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 76)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(792, 245)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'information
		'
		Me.information.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.information.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.information.Location = New System.Drawing.Point(3, 3)
		Me.information.Multiline = True
		Me.information.Name = "information"
		Me.information.ReadOnly = True
		Me.information.Size = New System.Drawing.Size(786, 116)
		Me.information.TabIndex = 0
		Me.information.TabStop = False
		Me.information.Text = "line"
		Me.information.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'message
		'
		Me.message.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.message.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.message.Location = New System.Drawing.Point(3, 125)
		Me.message.Multiline = True
		Me.message.Name = "message"
		Me.message.ReadOnly = True
		Me.message.Size = New System.Drawing.Size(786, 117)
		Me.message.TabIndex = 1
		Me.message.TabStop = False
		Me.message.Text = "Please wait"
		Me.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'price
		'
		Me.price.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.price.AutoSize = True
		Me.price.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.price.Location = New System.Drawing.Point(3, 0)
		Me.price.Name = "price"
		Me.price.Size = New System.Drawing.Size(792, 73)
		Me.price.TabIndex = 3
		Me.price.Text = "Label1"
		Me.price.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'timerBeforeTimeout
		'
		Me.timerBeforeTimeout.Interval = 1000
		'
		'timerBeforeAutoClose
		'
		'
		'timerGlobal
		'
		'
		'FProcessing
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(822, 383)
		Me.ControlBox = False
		Me.Controls.Add(Me.TableLayoutMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FProcessing"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Please wait..."
		Me.TableLayoutMain.ResumeLayout(False)
		Me.TableLayoutMain.PerformLayout()
		Me.TableLayoutButtons.ResumeLayout(False)
		Me.TableLayoutButtons.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TableLayoutMain As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutButtons As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents pbCancel As System.Windows.Forms.Button
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents information As System.Windows.Forms.TextBox
	Friend WithEvents message As System.Windows.Forms.TextBox
	Friend WithEvents timerBeforeTimeout As System.Windows.Forms.Timer
	Friend WithEvents timerBeforeAutoClose As System.Windows.Forms.Timer
	Friend WithEvents price As Windows.Forms.Label
	Friend WithEvents timerGlobal As Windows.Forms.Timer
End Class
