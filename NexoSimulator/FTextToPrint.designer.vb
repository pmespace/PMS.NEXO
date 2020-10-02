<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTextToPrint
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
		Me.panelnput = New System.Windows.Forms.TableLayoutPanel()
		Me.panelPositions = New System.Windows.Forms.TableLayoutPanel()
		Me.position = New System.Windows.Forms.Label()
		Me.nbchars = New System.Windows.Forms.Label()
		Me.panelButtons = New System.Windows.Forms.TableLayoutPanel()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.panelMain.SuspendLayout()
		Me.panelnput.SuspendLayout()
		Me.panelPositions.SuspendLayout()
		Me.panelButtons.SuspendLayout()
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
		Me.panelMain.Controls.Add(Me.panelnput, 0, 0)
		Me.panelMain.Controls.Add(Me.panelButtons, 0, 1)
		Me.panelMain.Location = New System.Drawing.Point(12, 12)
		Me.panelMain.Name = "panelMain"
		Me.panelMain.RowCount = 2
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelMain.Size = New System.Drawing.Size(900, 149)
		Me.panelMain.TabIndex = 0
		'
		'panelnput
		'
		Me.panelnput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelnput.AutoSize = True
		Me.panelnput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelnput.ColumnCount = 1
		Me.panelnput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelnput.Controls.Add(Me.panelPositions, 0, 1)
		Me.panelnput.Controls.Add(Me.RichTextBox1, 0, 0)
		Me.panelnput.Location = New System.Drawing.Point(3, 3)
		Me.panelnput.Name = "panelnput"
		Me.panelnput.RowCount = 2
		Me.panelnput.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelnput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelnput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelnput.Size = New System.Drawing.Size(894, 108)
		Me.panelnput.TabIndex = 0
		'
		'panelPositions
		'
		Me.panelPositions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelPositions.AutoSize = True
		Me.panelPositions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelPositions.ColumnCount = 2
		Me.panelPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelPositions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.panelPositions.Controls.Add(Me.Label2, 1, 0)
		Me.panelPositions.Controls.Add(Me.position, 1, 1)
		Me.panelPositions.Controls.Add(Me.nbchars, 0, 1)
		Me.panelPositions.Controls.Add(Me.Label1, 0, 0)
		Me.panelPositions.Location = New System.Drawing.Point(3, 37)
		Me.panelPositions.Name = "panelPositions"
		Me.panelPositions.RowCount = 2
		Me.panelPositions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelPositions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelPositions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.panelPositions.Size = New System.Drawing.Size(888, 68)
		Me.panelPositions.TabIndex = 1
		'
		'position
		'
		Me.position.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.position.AutoSize = True
		Me.position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.position.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.position.Location = New System.Drawing.Point(447, 20)
		Me.position.Name = "position"
		Me.position.Size = New System.Drawing.Size(438, 48)
		Me.position.TabIndex = 1
		Me.position.Text = "Label2"
		Me.position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nbchars
		'
		Me.nbchars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.nbchars.AutoSize = True
		Me.nbchars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nbchars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.nbchars.Location = New System.Drawing.Point(3, 20)
		Me.nbchars.Name = "nbchars"
		Me.nbchars.Size = New System.Drawing.Size(438, 48)
		Me.nbchars.TabIndex = 0
		Me.nbchars.Text = "Label1"
		Me.nbchars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panelButtons
		'
		Me.panelButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panelButtons.AutoSize = True
		Me.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panelButtons.ColumnCount = 3
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.panelButtons.Controls.Add(Me.pbAccept, 1, 0)
		Me.panelButtons.Controls.Add(Me.pbCancel, 2, 0)
		Me.panelButtons.Location = New System.Drawing.Point(3, 117)
		Me.panelButtons.Name = "panelButtons"
		Me.panelButtons.RowCount = 1
		Me.panelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.panelButtons.Size = New System.Drawing.Size(894, 29)
		Me.panelButtons.TabIndex = 1
		'
		'pbAccept
		'
		Me.pbAccept.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(784, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(51, 23)
		Me.pbAccept.TabIndex = 0
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'pbCancel
		'
		Me.pbCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.pbCancel.Location = New System.Drawing.Point(841, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(50, 23)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
		Me.RichTextBox1.MaxLength = 80
		Me.RichTextBox1.Multiline = False
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.RichTextBox1.Size = New System.Drawing.Size(888, 28)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
		'
		'Label1
		'
		Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(438, 20)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Characters"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(447, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(438, 20)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Position"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FTextToPrint
		'
		Me.AcceptButton = Me.pbAccept
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.pbCancel
		Me.ClientSize = New System.Drawing.Size(924, 173)
		Me.ControlBox = False
		Me.Controls.Add(Me.panelMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FTextToPrint"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Text to print"
		Me.panelMain.ResumeLayout(False)
		Me.panelMain.PerformLayout()
		Me.panelnput.ResumeLayout(False)
		Me.panelnput.PerformLayout()
		Me.panelPositions.ResumeLayout(False)
		Me.panelPositions.PerformLayout()
		Me.panelButtons.ResumeLayout(False)
		Me.panelButtons.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents panelMain As TableLayoutPanel
	Friend WithEvents panelButtons As TableLayoutPanel
	Friend WithEvents panelnput As TableLayoutPanel
	Friend WithEvents panelPositions As TableLayoutPanel
	Friend WithEvents position As Label
	Friend WithEvents nbchars As Label
	Friend WithEvents pbAccept As Button
	Friend WithEvents pbCancel As Button
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
End Class
