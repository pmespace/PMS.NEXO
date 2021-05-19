<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConnectionSettings
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
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.efServerName = New System.Windows.Forms.TextBox()
		Me.cbUseCertificate = New System.Windows.Forms.CheckBox()
		Me.efRequest = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.udTimer = New System.Windows.Forms.NumericUpDown()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.cbRemoteCertificateNotAvailable = New System.Windows.Forms.CheckBox()
		Me.cbRemoteCertificateNameMismatch = New System.Windows.Forms.CheckBox()
		Me.cbRemoteCertificateChainErrors = New System.Windows.Forms.CheckBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbAccept = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.udTimer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
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
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(607, 164)
		Me.TableLayoutPanel1.TabIndex = 0
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
		Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.efServerName, 1, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.cbUseCertificate, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.efRequest, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.udTimer, 1, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 1, 3)
		Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 5
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(601, 123)
		Me.TableLayoutPanel2.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(55, 58)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(96, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Timer (in seconds):"
		'
		'efServerName
		'
		Me.efServerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efServerName.Location = New System.Drawing.Point(157, 29)
		Me.efServerName.Name = "efServerName"
		Me.efServerName.Size = New System.Drawing.Size(441, 20)
		Me.efServerName.TabIndex = 5
		'
		'cbUseCertificate
		'
		Me.cbUseCertificate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbUseCertificate.AutoSize = True
		Me.cbUseCertificate.Location = New System.Drawing.Point(3, 30)
		Me.cbUseCertificate.Name = "cbUseCertificate"
		Me.cbUseCertificate.Size = New System.Drawing.Size(148, 17)
		Me.cbUseCertificate.TabIndex = 7
		Me.cbUseCertificate.Text = "Use certificate"
		Me.cbUseCertificate.UseVisualStyleBackColor = True
		'
		'efRequest
		'
		Me.efRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efRequest.Location = New System.Drawing.Point(157, 3)
		Me.efRequest.Name = "efRequest"
		Me.efRequest.Size = New System.Drawing.Size(441, 20)
		Me.efRequest.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(148, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Pre-connection request string:"
		'
		'udTimer
		'
		Me.udTimer.Location = New System.Drawing.Point(157, 55)
		Me.udTimer.Name = "udTimer"
		Me.udTimer.Size = New System.Drawing.Size(70, 20)
		Me.udTimer.TabIndex = 9
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.cbRemoteCertificateNotAvailable)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbRemoteCertificateNameMismatch)
		Me.FlowLayoutPanel1.Controls.Add(Me.cbRemoteCertificateChainErrors)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(157, 81)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(441, 23)
		Me.FlowLayoutPanel1.TabIndex = 10
		'
		'cbRemoteCertificateNotAvailable
		'
		Me.cbRemoteCertificateNotAvailable.AutoSize = True
		Me.cbRemoteCertificateNotAvailable.Location = New System.Drawing.Point(3, 3)
		Me.cbRemoteCertificateNotAvailable.Name = "cbRemoteCertificateNotAvailable"
		Me.cbRemoteCertificateNotAvailable.Size = New System.Drawing.Size(136, 17)
		Me.cbRemoteCertificateNotAvailable.TabIndex = 0
		Me.cbRemoteCertificateNotAvailable.Text = "Certificate not available"
		Me.cbRemoteCertificateNotAvailable.UseVisualStyleBackColor = True
		'
		'cbRemoteCertificateNameMismatch
		'
		Me.cbRemoteCertificateNameMismatch.AutoSize = True
		Me.cbRemoteCertificateNameMismatch.Location = New System.Drawing.Point(145, 3)
		Me.cbRemoteCertificateNameMismatch.Name = "cbRemoteCertificateNameMismatch"
		Me.cbRemoteCertificateNameMismatch.Size = New System.Drawing.Size(149, 17)
		Me.cbRemoteCertificateNameMismatch.TabIndex = 1
		Me.cbRemoteCertificateNameMismatch.Text = "Certificate name mismatch"
		Me.cbRemoteCertificateNameMismatch.UseVisualStyleBackColor = True
		'
		'cbRemoteCertificateChainErrors
		'
		Me.cbRemoteCertificateChainErrors.AutoSize = True
		Me.cbRemoteCertificateChainErrors.Location = New System.Drawing.Point(300, 3)
		Me.cbRemoteCertificateChainErrors.Name = "cbRemoteCertificateChainErrors"
		Me.cbRemoteCertificateChainErrors.Size = New System.Drawing.Size(131, 17)
		Me.cbRemoteCertificateChainErrors.TabIndex = 2
		Me.cbRemoteCertificateChainErrors.Text = "Certificate chain errors"
		Me.cbRemoteCertificateChainErrors.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(116, 86)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(35, 13)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Allow:"
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 3
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.pbAccept, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.pbCancel, 2, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 132)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(601, 29)
		Me.TableLayoutPanel3.TabIndex = 9
		'
		'pbAccept
		'
		Me.pbAccept.AutoSize = True
		Me.pbAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAccept.Location = New System.Drawing.Point(491, 3)
		Me.pbAccept.Name = "pbAccept"
		Me.pbAccept.Size = New System.Drawing.Size(51, 23)
		Me.pbAccept.TabIndex = 0
		Me.pbAccept.Text = "Accept"
		Me.pbAccept.UseVisualStyleBackColor = True
		'
		'pbCancel
		'
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.Location = New System.Drawing.Point(548, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(50, 23)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'FConnectionSettings
		'
		Me.AcceptButton = Me.pbAccept
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(631, 188)
		Me.ControlBox = False
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FConnectionSettings"
		Me.Text = "Pre-connection settings"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		CType(Me.udTimer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents efServerName As TextBox
	Friend WithEvents efRequest As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents cbUseCertificate As CheckBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents pbAccept As Button
	Friend WithEvents pbCancel As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents udTimer As NumericUpDown
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents cbRemoteCertificateNotAvailable As CheckBox
	Friend WithEvents cbRemoteCertificateNameMismatch As CheckBox
	Friend WithEvents cbRemoteCertificateChainErrors As CheckBox
	Friend WithEvents Label3 As Label
End Class
