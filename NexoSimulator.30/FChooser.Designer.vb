<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FChooser
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
		Me.rbLogin = New System.Windows.Forms.RadioButton()
		Me.rbLogout = New System.Windows.Forms.RadioButton()
		Me.rbPayment = New System.Windows.Forms.RadioButton()
		Me.rbReversal = New System.Windows.Forms.RadioButton()
		Me.rbAbort = New System.Windows.Forms.RadioButton()
		Me.rbAdmin = New System.Windows.Forms.RadioButton()
		Me.rbBalanceInquiry = New System.Windows.Forms.RadioButton()
		Me.rbBatch = New System.Windows.Forms.RadioButton()
		Me.rbCardAcquisition = New System.Windows.Forms.RadioButton()
		Me.rbCardReaderAPDU = New System.Windows.Forms.RadioButton()
		Me.rbCardReaderInit = New System.Windows.Forms.RadioButton()
		Me.rbCardReaderPowerOff = New System.Windows.Forms.RadioButton()
		Me.rbDisplay = New System.Windows.Forms.RadioButton()
		Me.rbInput = New System.Windows.Forms.RadioButton()
		Me.rbPrint = New System.Windows.Forms.RadioButton()
		Me.rbSound = New System.Windows.Forms.RadioButton()
		Me.rbDiagnosis = New System.Windows.Forms.RadioButton()
		Me.rbEnableService = New System.Windows.Forms.RadioButton()
		Me.rbEvent = New System.Windows.Forms.RadioButton()
		Me.rbGetTotals = New System.Windows.Forms.RadioButton()
		Me.rbLoyalty = New System.Windows.Forms.RadioButton()
		Me.rbPIN = New System.Windows.Forms.RadioButton()
		Me.rbReconciliation = New System.Windows.Forms.RadioButton()
		Me.rbStoredValue = New System.Windows.Forms.RadioButton()
		Me.rbTransactionStatus = New System.Windows.Forms.RadioButton()
		Me.rbTransmit = New System.Windows.Forms.RadioButton()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.cbRequest = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbCreate = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.lblInverseNotation = New System.Windows.Forms.Label()
		Me.pbAnalyseJson = New System.Windows.Forms.Button()
		Me.efCoded = New System.Windows.Forms.TextBox()
		Me.efNotation = New System.Windows.Forms.TextBox()
		Me.pbAnalyse = New System.Windows.Forms.Button()
		Me.pbCopy1 = New System.Windows.Forms.Button()
		Me.lblNotation = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.efTarget = New System.Windows.Forms.TextBox()
		Me.cbUseJson = New System.Windows.Forms.CheckBox()
		Me.efNotTheTarget = New System.Windows.Forms.TextBox()
		Me.lblTargetNotation = New System.Windows.Forms.Label()
		Me.pbCopy2 = New System.Windows.Forms.Button()
		Me.rbTransactionReport = New System.Windows.Forms.RadioButton()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'rbLogin
		'
		Me.rbLogin.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbLogin.AutoSize = True
		Me.rbLogin.Location = New System.Drawing.Point(3, 188)
		Me.rbLogin.Name = "rbLogin"
		Me.rbLogin.Size = New System.Drawing.Size(51, 17)
		Me.rbLogin.TabIndex = 2
		Me.rbLogin.TabStop = True
		Me.rbLogin.Text = "Login"
		Me.rbLogin.UseVisualStyleBackColor = True
		'
		'rbLogout
		'
		Me.rbLogout.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbLogout.AutoSize = True
		Me.rbLogout.Location = New System.Drawing.Point(115, 188)
		Me.rbLogout.Name = "rbLogout"
		Me.rbLogout.Size = New System.Drawing.Size(58, 17)
		Me.rbLogout.TabIndex = 3
		Me.rbLogout.TabStop = True
		Me.rbLogout.Text = "Logout"
		Me.rbLogout.UseVisualStyleBackColor = True
		'
		'rbPayment
		'
		Me.rbPayment.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbPayment.AutoSize = True
		Me.rbPayment.Checked = True
		Me.rbPayment.Location = New System.Drawing.Point(3, 211)
		Me.rbPayment.Name = "rbPayment"
		Me.rbPayment.Size = New System.Drawing.Size(106, 17)
		Me.rbPayment.TabIndex = 4
		Me.rbPayment.TabStop = True
		Me.rbPayment.Text = "Payment/Refund"
		Me.rbPayment.UseVisualStyleBackColor = True
		'
		'rbReversal
		'
		Me.rbReversal.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbReversal.AutoSize = True
		Me.rbReversal.Location = New System.Drawing.Point(115, 211)
		Me.rbReversal.Name = "rbReversal"
		Me.rbReversal.Size = New System.Drawing.Size(67, 17)
		Me.rbReversal.TabIndex = 5
		Me.rbReversal.TabStop = True
		Me.rbReversal.Text = "Reversal"
		Me.rbReversal.UseVisualStyleBackColor = True
		'
		'rbAbort
		'
		Me.rbAbort.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbAbort.AutoSize = True
		Me.rbAbort.Location = New System.Drawing.Point(3, 280)
		Me.rbAbort.Name = "rbAbort"
		Me.rbAbort.Size = New System.Drawing.Size(50, 17)
		Me.rbAbort.TabIndex = 14
		Me.rbAbort.TabStop = True
		Me.rbAbort.Text = "Abort"
		Me.rbAbort.UseVisualStyleBackColor = True
		'
		'rbAdmin
		'
		Me.rbAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbAdmin.AutoSize = True
		Me.rbAdmin.Location = New System.Drawing.Point(115, 280)
		Me.rbAdmin.Name = "rbAdmin"
		Me.rbAdmin.Size = New System.Drawing.Size(54, 17)
		Me.rbAdmin.TabIndex = 15
		Me.rbAdmin.TabStop = True
		Me.rbAdmin.Text = "Admin"
		Me.rbAdmin.UseVisualStyleBackColor = True
		'
		'rbBalanceInquiry
		'
		Me.rbBalanceInquiry.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbBalanceInquiry.AutoSize = True
		Me.rbBalanceInquiry.Location = New System.Drawing.Point(115, 303)
		Me.rbBalanceInquiry.Name = "rbBalanceInquiry"
		Me.rbBalanceInquiry.Size = New System.Drawing.Size(97, 17)
		Me.rbBalanceInquiry.TabIndex = 18
		Me.rbBalanceInquiry.TabStop = True
		Me.rbBalanceInquiry.Text = "Balance inquiry"
		Me.rbBalanceInquiry.UseVisualStyleBackColor = True
		'
		'rbBatch
		'
		Me.rbBatch.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbBatch.AutoSize = True
		Me.rbBatch.Location = New System.Drawing.Point(3, 303)
		Me.rbBatch.Name = "rbBatch"
		Me.rbBatch.Size = New System.Drawing.Size(53, 17)
		Me.rbBatch.TabIndex = 17
		Me.rbBatch.TabStop = True
		Me.rbBatch.Text = "Batch"
		Me.rbBatch.UseVisualStyleBackColor = True
		'
		'rbCardAcquisition
		'
		Me.rbCardAcquisition.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbCardAcquisition.AutoSize = True
		Me.rbCardAcquisition.Location = New System.Drawing.Point(115, 257)
		Me.rbCardAcquisition.Name = "rbCardAcquisition"
		Me.rbCardAcquisition.Size = New System.Drawing.Size(100, 17)
		Me.rbCardAcquisition.TabIndex = 10
		Me.rbCardAcquisition.TabStop = True
		Me.rbCardAcquisition.Text = "Card acquisition"
		Me.rbCardAcquisition.UseVisualStyleBackColor = True
		'
		'rbCardReaderAPDU
		'
		Me.rbCardReaderAPDU.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbCardReaderAPDU.AutoSize = True
		Me.rbCardReaderAPDU.Location = New System.Drawing.Point(221, 257)
		Me.rbCardReaderAPDU.Name = "rbCardReaderAPDU"
		Me.rbCardReaderAPDU.Size = New System.Drawing.Size(113, 17)
		Me.rbCardReaderAPDU.TabIndex = 11
		Me.rbCardReaderAPDU.TabStop = True
		Me.rbCardReaderAPDU.Text = "Card reader APDU"
		Me.rbCardReaderAPDU.UseVisualStyleBackColor = True
		'
		'rbCardReaderInit
		'
		Me.rbCardReaderInit.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbCardReaderInit.AutoSize = True
		Me.rbCardReaderInit.Location = New System.Drawing.Point(3, 257)
		Me.rbCardReaderInit.Name = "rbCardReaderInit"
		Me.rbCardReaderInit.Size = New System.Drawing.Size(96, 17)
		Me.rbCardReaderInit.TabIndex = 9
		Me.rbCardReaderInit.TabStop = True
		Me.rbCardReaderInit.Text = "Card reader init"
		Me.rbCardReaderInit.UseVisualStyleBackColor = True
		'
		'rbCardReaderPowerOff
		'
		Me.rbCardReaderPowerOff.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbCardReaderPowerOff.AutoSize = True
		Me.rbCardReaderPowerOff.Location = New System.Drawing.Point(340, 257)
		Me.rbCardReaderPowerOff.Name = "rbCardReaderPowerOff"
		Me.rbCardReaderPowerOff.Size = New System.Drawing.Size(127, 17)
		Me.rbCardReaderPowerOff.TabIndex = 12
		Me.rbCardReaderPowerOff.TabStop = True
		Me.rbCardReaderPowerOff.Text = "Card reader power off"
		Me.rbCardReaderPowerOff.UseVisualStyleBackColor = True
		'
		'rbDisplay
		'
		Me.rbDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbDisplay.AutoSize = True
		Me.rbDisplay.Location = New System.Drawing.Point(3, 326)
		Me.rbDisplay.Name = "rbDisplay"
		Me.rbDisplay.Size = New System.Drawing.Size(59, 17)
		Me.rbDisplay.TabIndex = 22
		Me.rbDisplay.TabStop = True
		Me.rbDisplay.Text = "Display"
		Me.rbDisplay.UseVisualStyleBackColor = True
		'
		'rbInput
		'
		Me.rbInput.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbInput.AutoSize = True
		Me.rbInput.Location = New System.Drawing.Point(115, 326)
		Me.rbInput.Name = "rbInput"
		Me.rbInput.Size = New System.Drawing.Size(49, 17)
		Me.rbInput.TabIndex = 23
		Me.rbInput.TabStop = True
		Me.rbInput.Text = "Input"
		Me.rbInput.UseVisualStyleBackColor = True
		'
		'rbPrint
		'
		Me.rbPrint.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbPrint.AutoSize = True
		Me.rbPrint.Location = New System.Drawing.Point(221, 326)
		Me.rbPrint.Name = "rbPrint"
		Me.rbPrint.Size = New System.Drawing.Size(46, 17)
		Me.rbPrint.TabIndex = 24
		Me.rbPrint.TabStop = True
		Me.rbPrint.Text = "Print"
		Me.rbPrint.UseVisualStyleBackColor = True
		'
		'rbSound
		'
		Me.rbSound.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbSound.AutoSize = True
		Me.rbSound.Location = New System.Drawing.Point(340, 326)
		Me.rbSound.Name = "rbSound"
		Me.rbSound.Size = New System.Drawing.Size(56, 17)
		Me.rbSound.TabIndex = 25
		Me.rbSound.TabStop = True
		Me.rbSound.Text = "Sound"
		Me.rbSound.UseVisualStyleBackColor = True
		'
		'rbDiagnosis
		'
		Me.rbDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbDiagnosis.AutoSize = True
		Me.rbDiagnosis.Location = New System.Drawing.Point(3, 349)
		Me.rbDiagnosis.Name = "rbDiagnosis"
		Me.rbDiagnosis.Size = New System.Drawing.Size(71, 17)
		Me.rbDiagnosis.TabIndex = 26
		Me.rbDiagnosis.TabStop = True
		Me.rbDiagnosis.Text = "Diagnosis"
		Me.rbDiagnosis.UseVisualStyleBackColor = True
		'
		'rbEnableService
		'
		Me.rbEnableService.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbEnableService.AutoSize = True
		Me.rbEnableService.Location = New System.Drawing.Point(221, 280)
		Me.rbEnableService.Name = "rbEnableService"
		Me.rbEnableService.Size = New System.Drawing.Size(95, 17)
		Me.rbEnableService.TabIndex = 16
		Me.rbEnableService.TabStop = True
		Me.rbEnableService.Text = "Enable service"
		Me.rbEnableService.UseVisualStyleBackColor = True
		'
		'rbEvent
		'
		Me.rbEvent.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbEvent.AutoSize = True
		Me.rbEvent.Location = New System.Drawing.Point(115, 349)
		Me.rbEvent.Name = "rbEvent"
		Me.rbEvent.Size = New System.Drawing.Size(53, 17)
		Me.rbEvent.TabIndex = 27
		Me.rbEvent.TabStop = True
		Me.rbEvent.Text = "Event"
		Me.rbEvent.UseVisualStyleBackColor = True
		'
		'rbGetTotals
		'
		Me.rbGetTotals.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbGetTotals.AutoSize = True
		Me.rbGetTotals.Location = New System.Drawing.Point(221, 303)
		Me.rbGetTotals.Name = "rbGetTotals"
		Me.rbGetTotals.Size = New System.Drawing.Size(70, 17)
		Me.rbGetTotals.TabIndex = 19
		Me.rbGetTotals.TabStop = True
		Me.rbGetTotals.Text = "Get totals"
		Me.rbGetTotals.UseVisualStyleBackColor = True
		'
		'rbLoyalty
		'
		Me.rbLoyalty.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbLoyalty.AutoSize = True
		Me.rbLoyalty.Location = New System.Drawing.Point(3, 234)
		Me.rbLoyalty.Name = "rbLoyalty"
		Me.rbLoyalty.Size = New System.Drawing.Size(58, 17)
		Me.rbLoyalty.TabIndex = 7
		Me.rbLoyalty.TabStop = True
		Me.rbLoyalty.Text = "Loyalty"
		Me.rbLoyalty.UseVisualStyleBackColor = True
		'
		'rbPIN
		'
		Me.rbPIN.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbPIN.AutoSize = True
		Me.rbPIN.Location = New System.Drawing.Point(473, 257)
		Me.rbPIN.Name = "rbPIN"
		Me.rbPIN.Size = New System.Drawing.Size(43, 17)
		Me.rbPIN.TabIndex = 13
		Me.rbPIN.TabStop = True
		Me.rbPIN.Text = "PIN"
		Me.rbPIN.UseVisualStyleBackColor = True
		'
		'rbReconciliation
		'
		Me.rbReconciliation.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbReconciliation.AutoSize = True
		Me.rbReconciliation.Location = New System.Drawing.Point(221, 211)
		Me.rbReconciliation.Name = "rbReconciliation"
		Me.rbReconciliation.Size = New System.Drawing.Size(92, 17)
		Me.rbReconciliation.TabIndex = 6
		Me.rbReconciliation.TabStop = True
		Me.rbReconciliation.Text = "Reconciliation"
		Me.rbReconciliation.UseVisualStyleBackColor = True
		'
		'rbStoredValue
		'
		Me.rbStoredValue.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbStoredValue.AutoSize = True
		Me.rbStoredValue.Location = New System.Drawing.Point(115, 234)
		Me.rbStoredValue.Name = "rbStoredValue"
		Me.rbStoredValue.Size = New System.Drawing.Size(85, 17)
		Me.rbStoredValue.TabIndex = 8
		Me.rbStoredValue.TabStop = True
		Me.rbStoredValue.Text = "Stored value"
		Me.rbStoredValue.UseVisualStyleBackColor = True
		'
		'rbTransactionStatus
		'
		Me.rbTransactionStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbTransactionStatus.AutoSize = True
		Me.rbTransactionStatus.Location = New System.Drawing.Point(340, 303)
		Me.rbTransactionStatus.Name = "rbTransactionStatus"
		Me.rbTransactionStatus.Size = New System.Drawing.Size(112, 17)
		Me.rbTransactionStatus.TabIndex = 20
		Me.rbTransactionStatus.TabStop = True
		Me.rbTransactionStatus.Text = "Transaction status"
		Me.rbTransactionStatus.UseVisualStyleBackColor = True
		'
		'rbTransmit
		'
		Me.rbTransmit.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbTransmit.AutoSize = True
		Me.rbTransmit.Location = New System.Drawing.Point(473, 303)
		Me.rbTransmit.Name = "rbTransmit"
		Me.rbTransmit.Size = New System.Drawing.Size(65, 17)
		Me.rbTransmit.TabIndex = 21
		Me.rbTransmit.TabStop = True
		Me.rbTransmit.Text = "Transmit"
		Me.rbTransmit.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 6
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.rbStoredValue, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbEvent, 1, 10)
		Me.TableLayoutPanel1.Controls.Add(Me.cbRequest, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.rbDiagnosis, 0, 10)
		Me.TableLayoutPanel1.Controls.Add(Me.rbBalanceInquiry, 1, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.rbEnableService, 2, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.rbTransmit, 4, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.rbAdmin, 1, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.rbBatch, 0, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.rbSound, 3, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.rbGetTotals, 2, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPrint, 2, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.rbInput, 1, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.rbDisplay, 0, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.rbAbort, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.rbTransactionStatus, 3, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPayment, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLogout, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLogin, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderAPDU, 2, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardAcquisition, 1, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderInit, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderPowerOff, 3, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPIN, 4, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLoyalty, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 12)
		Me.TableLayoutPanel1.Controls.Add(Me.rbReversal, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.rbReconciliation, 2, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.rbTransactionReport, 3, 10)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 13
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 408)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'cbRequest
		'
		Me.cbRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbRequest.AutoSize = True
		Me.cbRequest.Checked = True
		Me.cbRequest.CheckState = System.Windows.Forms.CheckState.Checked
		Me.TableLayoutPanel1.SetColumnSpan(Me.cbRequest, 2)
		Me.cbRequest.Location = New System.Drawing.Point(3, 165)
		Me.cbRequest.Name = "cbRequest"
		Me.cbRequest.Size = New System.Drawing.Size(212, 17)
		Me.cbRequest.TabIndex = 1
		Me.cbRequest.Text = "Generate request"
		Me.cbRequest.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 4
		Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 6)
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.pbCreate, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbCancel, 3, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 376)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 29)
		Me.TableLayoutPanel2.TabIndex = 29
		'
		'pbCreate
		'
		Me.pbCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCreate.AutoSize = True
		Me.pbCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCreate.Location = New System.Drawing.Point(443, 3)
		Me.pbCreate.Name = "pbCreate"
		Me.pbCreate.Size = New System.Drawing.Size(48, 23)
		Me.pbCreate.TabIndex = 0
		Me.pbCreate.Text = "Create"
		Me.pbCreate.UseVisualStyleBackColor = True
		'
		'pbCancel
		'
		Me.pbCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCancel.AutoSize = True
		Me.pbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCancel.Location = New System.Drawing.Point(497, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(43, 23)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "Close"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 3
		Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 5)
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.lblInverseNotation, 0, 4)
		Me.TableLayoutPanel3.Controls.Add(Me.pbAnalyseJson, 2, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.efCoded, 1, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.efNotation, 1, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.pbAnalyse, 2, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.pbCopy1, 2, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.lblNotation, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.efTarget, 1, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.cbUseJson, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.efNotTheTarget, 1, 4)
		Me.TableLayoutPanel3.Controls.Add(Me.lblTargetNotation, 0, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.pbCopy2, 2, 4)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 5
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(535, 136)
		Me.TableLayoutPanel3.TabIndex = 0
		'
		'lblInverseNotation
		'
		Me.lblInverseNotation.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.lblInverseNotation.AutoSize = True
		Me.lblInverseNotation.Location = New System.Drawing.Point(12, 115)
		Me.lblInverseNotation.Name = "lblInverseNotation"
		Me.lblInverseNotation.Size = New System.Drawing.Size(29, 13)
		Me.lblInverseNotation.TabIndex = 9
		Me.lblInverseNotation.Text = "XML"
		'
		'pbAnalyseJson
		'
		Me.pbAnalyseJson.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAnalyseJson.AutoSize = True
		Me.pbAnalyseJson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAnalyseJson.Location = New System.Drawing.Point(478, 52)
		Me.pbAnalyseJson.Name = "pbAnalyseJson"
		Me.pbAnalyseJson.Size = New System.Drawing.Size(54, 23)
		Me.pbAnalyseJson.TabIndex = 4
		Me.pbAnalyseJson.Text = "Analyse"
		Me.pbAnalyseJson.UseVisualStyleBackColor = True
		'
		'efCoded
		'
		Me.efCoded.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efCoded.Location = New System.Drawing.Point(47, 53)
		Me.efCoded.Multiline = True
		Me.efCoded.Name = "efCoded"
		Me.efCoded.Size = New System.Drawing.Size(425, 20)
		Me.efCoded.TabIndex = 3
		Me.efCoded.WordWrap = False
		'
		'efNotation
		'
		Me.efNotation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efNotation.Location = New System.Drawing.Point(47, 26)
		Me.efNotation.Multiline = True
		Me.efNotation.Name = "efNotation"
		Me.efNotation.Size = New System.Drawing.Size(425, 20)
		Me.efNotation.TabIndex = 1
		Me.efNotation.WordWrap = False
		'
		'pbAnalyse
		'
		Me.pbAnalyse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbAnalyse.AutoSize = True
		Me.pbAnalyse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbAnalyse.Location = New System.Drawing.Point(478, 26)
		Me.pbAnalyse.Name = "pbAnalyse"
		Me.pbAnalyse.Size = New System.Drawing.Size(54, 20)
		Me.pbAnalyse.TabIndex = 2
		Me.pbAnalyse.Text = "Analyse"
		Me.pbAnalyse.UseVisualStyleBackColor = True
		'
		'pbCopy1
		'
		Me.pbCopy1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCopy1.AutoSize = True
		Me.pbCopy1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCopy1.Location = New System.Drawing.Point(478, 81)
		Me.pbCopy1.Name = "pbCopy1"
		Me.pbCopy1.Size = New System.Drawing.Size(54, 23)
		Me.pbCopy1.TabIndex = 6
		Me.pbCopy1.Text = "Copy"
		Me.pbCopy1.UseVisualStyleBackColor = True
		'
		'lblNotation
		'
		Me.lblNotation.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.lblNotation.AutoSize = True
		Me.lblNotation.Location = New System.Drawing.Point(12, 29)
		Me.lblNotation.Name = "lblNotation"
		Me.lblNotation.Size = New System.Drawing.Size(29, 13)
		Me.lblNotation.TabIndex = 4
		Me.lblNotation.Text = "XML"
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(38, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Coded"
		'
		'efTarget
		'
		Me.efTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efTarget.Location = New System.Drawing.Point(47, 82)
		Me.efTarget.Name = "efTarget"
		Me.efTarget.ReadOnly = True
		Me.efTarget.Size = New System.Drawing.Size(425, 20)
		Me.efTarget.TabIndex = 5
		'
		'cbUseJson
		'
		Me.cbUseJson.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.cbUseJson.AutoSize = True
		Me.TableLayoutPanel3.SetColumnSpan(Me.cbUseJson, 2)
		Me.cbUseJson.Location = New System.Drawing.Point(3, 3)
		Me.cbUseJson.Name = "cbUseJson"
		Me.cbUseJson.Size = New System.Drawing.Size(70, 17)
		Me.cbUseJson.TabIndex = 0
		Me.cbUseJson.Text = "Use Json"
		Me.cbUseJson.UseVisualStyleBackColor = True
		'
		'efNotTheTarget
		'
		Me.efNotTheTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.efNotTheTarget.Location = New System.Drawing.Point(47, 111)
		Me.efNotTheTarget.Name = "efNotTheTarget"
		Me.efNotTheTarget.ReadOnly = True
		Me.efNotTheTarget.Size = New System.Drawing.Size(425, 20)
		Me.efNotTheTarget.TabIndex = 8
		'
		'lblTargetNotation
		'
		Me.lblTargetNotation.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.lblTargetNotation.AutoSize = True
		Me.lblTargetNotation.Location = New System.Drawing.Point(12, 86)
		Me.lblTargetNotation.Name = "lblTargetNotation"
		Me.lblTargetNotation.Size = New System.Drawing.Size(29, 13)
		Me.lblTargetNotation.TabIndex = 10
		Me.lblTargetNotation.Text = "XML"
		'
		'pbCopy2
		'
		Me.pbCopy2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCopy2.AutoSize = True
		Me.pbCopy2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCopy2.Location = New System.Drawing.Point(478, 110)
		Me.pbCopy2.Name = "pbCopy2"
		Me.pbCopy2.Size = New System.Drawing.Size(54, 23)
		Me.pbCopy2.TabIndex = 11
		Me.pbCopy2.Text = "Copy"
		Me.pbCopy2.UseVisualStyleBackColor = True
		'
		'rbTransactionReport
		'
		Me.rbTransactionReport.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.rbTransactionReport.AutoSize = True
		Me.rbTransactionReport.Location = New System.Drawing.Point(340, 349)
		Me.rbTransactionReport.Name = "rbTransactionReport"
		Me.rbTransactionReport.Size = New System.Drawing.Size(111, 17)
		Me.rbTransactionReport.TabIndex = 28
		Me.rbTransactionReport.TabStop = True
		Me.rbTransactionReport.Text = "Transaction report"
		Me.rbTransactionReport.UseVisualStyleBackColor = True
		'
		'ToolTip1
		'
		'
		'FChooser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(573, 432)
		Me.ControlBox = False
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FChooser"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Choose message to create"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents rbPayment As RadioButton
	Friend WithEvents rbReversal As RadioButton
	Friend WithEvents rbAbort As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents rbBalanceInquiry As RadioButton
	Friend WithEvents rbBatch As RadioButton
	Friend WithEvents rbCardAcquisition As RadioButton
	Friend WithEvents rbCardReaderAPDU As RadioButton
	Friend WithEvents rbCardReaderInit As RadioButton
	Friend WithEvents rbCardReaderPowerOff As RadioButton
	Friend WithEvents rbDisplay As RadioButton
	Friend WithEvents rbInput As RadioButton
	Friend WithEvents rbPrint As RadioButton
	Friend WithEvents rbSound As RadioButton
	Friend WithEvents rbDiagnosis As RadioButton
	Friend WithEvents rbEnableService As RadioButton
	Friend WithEvents rbEvent As RadioButton
	Friend WithEvents rbGetTotals As RadioButton
	Friend WithEvents rbLoyalty As RadioButton
	Friend WithEvents rbPIN As RadioButton
	Friend WithEvents rbReconciliation As RadioButton
	Friend WithEvents rbStoredValue As RadioButton
	Friend WithEvents rbTransactionStatus As RadioButton
	Friend WithEvents rbTransmit As RadioButton
	Friend WithEvents rbLogin As RadioButton
	Friend WithEvents rbLogout As RadioButton
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents pbCreate As Button
	Friend WithEvents pbCancel As Button
	Friend WithEvents cbRequest As CheckBox
	Friend WithEvents efNotation As TextBox
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents pbAnalyse As Button
	Friend WithEvents efTarget As TextBox
	Friend WithEvents pbCopy1 As Button
	Friend WithEvents rbTransactionReport As RadioButton
	Friend WithEvents pbAnalyseJson As Button
	Friend WithEvents efCoded As TextBox
	Friend WithEvents lblNotation As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents cbUseJson As CheckBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents lblInverseNotation As Label
	Friend WithEvents efNotTheTarget As TextBox
	Friend WithEvents lblTargetNotation As Label
	Friend WithEvents pbCopy2 As Button
End Class
