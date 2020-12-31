<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FChoser
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
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.pbCreate = New System.Windows.Forms.Button()
		Me.pbCancel = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'rbLogin
		'
		Me.rbLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbLogin.AutoSize = True
		Me.rbLogin.Location = New System.Drawing.Point(3, 3)
		Me.rbLogin.Name = "rbLogin"
		Me.rbLogin.Size = New System.Drawing.Size(106, 17)
		Me.rbLogin.TabIndex = 0
		Me.rbLogin.TabStop = True
		Me.rbLogin.Text = "Login"
		Me.rbLogin.UseVisualStyleBackColor = True
		'
		'rbLogout
		'
		Me.rbLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbLogout.AutoSize = True
		Me.rbLogout.Location = New System.Drawing.Point(115, 3)
		Me.rbLogout.Name = "rbLogout"
		Me.rbLogout.Size = New System.Drawing.Size(100, 17)
		Me.rbLogout.TabIndex = 1
		Me.rbLogout.TabStop = True
		Me.rbLogout.Text = "Logout"
		Me.rbLogout.UseVisualStyleBackColor = True
		'
		'rbPayment
		'
		Me.rbPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbPayment.AutoSize = True
		Me.rbPayment.Checked = True
		Me.rbPayment.Location = New System.Drawing.Point(3, 26)
		Me.rbPayment.Name = "rbPayment"
		Me.rbPayment.Size = New System.Drawing.Size(106, 17)
		Me.rbPayment.TabIndex = 2
		Me.rbPayment.TabStop = True
		Me.rbPayment.Text = "Payment/Refund"
		Me.rbPayment.UseVisualStyleBackColor = True
		'
		'rbReversal
		'
		Me.rbReversal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbReversal.AutoSize = True
		Me.rbReversal.Location = New System.Drawing.Point(115, 26)
		Me.rbReversal.Name = "rbReversal"
		Me.rbReversal.Size = New System.Drawing.Size(100, 17)
		Me.rbReversal.TabIndex = 4
		Me.rbReversal.TabStop = True
		Me.rbReversal.Text = "Reversal"
		Me.rbReversal.UseVisualStyleBackColor = True
		'
		'rbAbort
		'
		Me.rbAbort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbAbort.AutoSize = True
		Me.rbAbort.Location = New System.Drawing.Point(3, 95)
		Me.rbAbort.Name = "rbAbort"
		Me.rbAbort.Size = New System.Drawing.Size(106, 17)
		Me.rbAbort.TabIndex = 13
		Me.rbAbort.TabStop = True
		Me.rbAbort.Text = "Abort"
		Me.rbAbort.UseVisualStyleBackColor = True
		'
		'rbAdmin
		'
		Me.rbAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbAdmin.AutoSize = True
		Me.rbAdmin.Location = New System.Drawing.Point(115, 95)
		Me.rbAdmin.Name = "rbAdmin"
		Me.rbAdmin.Size = New System.Drawing.Size(100, 17)
		Me.rbAdmin.TabIndex = 14
		Me.rbAdmin.TabStop = True
		Me.rbAdmin.Text = "Admin"
		Me.rbAdmin.UseVisualStyleBackColor = True
		'
		'rbBalanceInquiry
		'
		Me.rbBalanceInquiry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbBalanceInquiry.AutoSize = True
		Me.rbBalanceInquiry.Location = New System.Drawing.Point(115, 118)
		Me.rbBalanceInquiry.Name = "rbBalanceInquiry"
		Me.rbBalanceInquiry.Size = New System.Drawing.Size(100, 17)
		Me.rbBalanceInquiry.TabIndex = 17
		Me.rbBalanceInquiry.TabStop = True
		Me.rbBalanceInquiry.Text = "Balance inquiry"
		Me.rbBalanceInquiry.UseVisualStyleBackColor = True
		'
		'rbBatch
		'
		Me.rbBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbBatch.AutoSize = True
		Me.rbBatch.Location = New System.Drawing.Point(3, 118)
		Me.rbBatch.Name = "rbBatch"
		Me.rbBatch.Size = New System.Drawing.Size(106, 17)
		Me.rbBatch.TabIndex = 16
		Me.rbBatch.TabStop = True
		Me.rbBatch.Text = "Batch"
		Me.rbBatch.UseVisualStyleBackColor = True
		'
		'rbCardAcquisition
		'
		Me.rbCardAcquisition.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbCardAcquisition.AutoSize = True
		Me.rbCardAcquisition.Location = New System.Drawing.Point(115, 72)
		Me.rbCardAcquisition.Name = "rbCardAcquisition"
		Me.rbCardAcquisition.Size = New System.Drawing.Size(100, 17)
		Me.rbCardAcquisition.TabIndex = 9
		Me.rbCardAcquisition.TabStop = True
		Me.rbCardAcquisition.Text = "Card acquisition"
		Me.rbCardAcquisition.UseVisualStyleBackColor = True
		'
		'rbCardReaderAPDU
		'
		Me.rbCardReaderAPDU.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbCardReaderAPDU.AutoSize = True
		Me.rbCardReaderAPDU.Location = New System.Drawing.Point(221, 72)
		Me.rbCardReaderAPDU.Name = "rbCardReaderAPDU"
		Me.rbCardReaderAPDU.Size = New System.Drawing.Size(113, 17)
		Me.rbCardReaderAPDU.TabIndex = 10
		Me.rbCardReaderAPDU.TabStop = True
		Me.rbCardReaderAPDU.Text = "Card reader APDU"
		Me.rbCardReaderAPDU.UseVisualStyleBackColor = True
		'
		'rbCardReaderInit
		'
		Me.rbCardReaderInit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbCardReaderInit.AutoSize = True
		Me.rbCardReaderInit.Location = New System.Drawing.Point(3, 72)
		Me.rbCardReaderInit.Name = "rbCardReaderInit"
		Me.rbCardReaderInit.Size = New System.Drawing.Size(106, 17)
		Me.rbCardReaderInit.TabIndex = 8
		Me.rbCardReaderInit.TabStop = True
		Me.rbCardReaderInit.Text = "Card reader init"
		Me.rbCardReaderInit.UseVisualStyleBackColor = True
		'
		'rbCardReaderPowerOff
		'
		Me.rbCardReaderPowerOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbCardReaderPowerOff.AutoSize = True
		Me.rbCardReaderPowerOff.Location = New System.Drawing.Point(340, 72)
		Me.rbCardReaderPowerOff.Name = "rbCardReaderPowerOff"
		Me.rbCardReaderPowerOff.Size = New System.Drawing.Size(127, 17)
		Me.rbCardReaderPowerOff.TabIndex = 11
		Me.rbCardReaderPowerOff.TabStop = True
		Me.rbCardReaderPowerOff.Text = "Card reader power off"
		Me.rbCardReaderPowerOff.UseVisualStyleBackColor = True
		'
		'rbDisplay
		'
		Me.rbDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbDisplay.AutoSize = True
		Me.rbDisplay.Location = New System.Drawing.Point(3, 141)
		Me.rbDisplay.Name = "rbDisplay"
		Me.rbDisplay.Size = New System.Drawing.Size(106, 17)
		Me.rbDisplay.TabIndex = 21
		Me.rbDisplay.TabStop = True
		Me.rbDisplay.Text = "Display"
		Me.rbDisplay.UseVisualStyleBackColor = True
		'
		'rbInput
		'
		Me.rbInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbInput.AutoSize = True
		Me.rbInput.Location = New System.Drawing.Point(115, 141)
		Me.rbInput.Name = "rbInput"
		Me.rbInput.Size = New System.Drawing.Size(100, 17)
		Me.rbInput.TabIndex = 22
		Me.rbInput.TabStop = True
		Me.rbInput.Text = "Input"
		Me.rbInput.UseVisualStyleBackColor = True
		'
		'rbPrint
		'
		Me.rbPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbPrint.AutoSize = True
		Me.rbPrint.Location = New System.Drawing.Point(221, 141)
		Me.rbPrint.Name = "rbPrint"
		Me.rbPrint.Size = New System.Drawing.Size(113, 17)
		Me.rbPrint.TabIndex = 23
		Me.rbPrint.TabStop = True
		Me.rbPrint.Text = "Print"
		Me.rbPrint.UseVisualStyleBackColor = True
		'
		'rbSound
		'
		Me.rbSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbSound.AutoSize = True
		Me.rbSound.Location = New System.Drawing.Point(340, 141)
		Me.rbSound.Name = "rbSound"
		Me.rbSound.Size = New System.Drawing.Size(127, 17)
		Me.rbSound.TabIndex = 24
		Me.rbSound.TabStop = True
		Me.rbSound.Text = "Sound"
		Me.rbSound.UseVisualStyleBackColor = True
		'
		'rbDiagnosis
		'
		Me.rbDiagnosis.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbDiagnosis.AutoSize = True
		Me.rbDiagnosis.Location = New System.Drawing.Point(3, 164)
		Me.rbDiagnosis.Name = "rbDiagnosis"
		Me.rbDiagnosis.Size = New System.Drawing.Size(106, 17)
		Me.rbDiagnosis.TabIndex = 25
		Me.rbDiagnosis.TabStop = True
		Me.rbDiagnosis.Text = "Diagnosis"
		Me.rbDiagnosis.UseVisualStyleBackColor = True
		'
		'rbEnableService
		'
		Me.rbEnableService.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbEnableService.AutoSize = True
		Me.rbEnableService.Location = New System.Drawing.Point(221, 95)
		Me.rbEnableService.Name = "rbEnableService"
		Me.rbEnableService.Size = New System.Drawing.Size(113, 17)
		Me.rbEnableService.TabIndex = 15
		Me.rbEnableService.TabStop = True
		Me.rbEnableService.Text = "Enable service"
		Me.rbEnableService.UseVisualStyleBackColor = True
		'
		'rbEvent
		'
		Me.rbEvent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbEvent.AutoSize = True
		Me.rbEvent.Location = New System.Drawing.Point(115, 164)
		Me.rbEvent.Name = "rbEvent"
		Me.rbEvent.Size = New System.Drawing.Size(100, 17)
		Me.rbEvent.TabIndex = 26
		Me.rbEvent.TabStop = True
		Me.rbEvent.Text = "Event"
		Me.rbEvent.UseVisualStyleBackColor = True
		'
		'rbGetTotals
		'
		Me.rbGetTotals.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbGetTotals.AutoSize = True
		Me.rbGetTotals.Location = New System.Drawing.Point(221, 118)
		Me.rbGetTotals.Name = "rbGetTotals"
		Me.rbGetTotals.Size = New System.Drawing.Size(113, 17)
		Me.rbGetTotals.TabIndex = 18
		Me.rbGetTotals.TabStop = True
		Me.rbGetTotals.Text = "Get totals"
		Me.rbGetTotals.UseVisualStyleBackColor = True
		'
		'rbLoyalty
		'
		Me.rbLoyalty.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbLoyalty.AutoSize = True
		Me.rbLoyalty.Location = New System.Drawing.Point(3, 49)
		Me.rbLoyalty.Name = "rbLoyalty"
		Me.rbLoyalty.Size = New System.Drawing.Size(106, 17)
		Me.rbLoyalty.TabIndex = 6
		Me.rbLoyalty.TabStop = True
		Me.rbLoyalty.Text = "Loyalty"
		Me.rbLoyalty.UseVisualStyleBackColor = True
		'
		'rbPIN
		'
		Me.rbPIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbPIN.AutoSize = True
		Me.rbPIN.Location = New System.Drawing.Point(473, 72)
		Me.rbPIN.Name = "rbPIN"
		Me.rbPIN.Size = New System.Drawing.Size(65, 17)
		Me.rbPIN.TabIndex = 12
		Me.rbPIN.TabStop = True
		Me.rbPIN.Text = "PIN"
		Me.rbPIN.UseVisualStyleBackColor = True
		'
		'rbReconciliation
		'
		Me.rbReconciliation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbReconciliation.AutoSize = True
		Me.rbReconciliation.Location = New System.Drawing.Point(221, 26)
		Me.rbReconciliation.Name = "rbReconciliation"
		Me.rbReconciliation.Size = New System.Drawing.Size(113, 17)
		Me.rbReconciliation.TabIndex = 5
		Me.rbReconciliation.TabStop = True
		Me.rbReconciliation.Text = "Reconciliation"
		Me.rbReconciliation.UseVisualStyleBackColor = True
		'
		'rbStoredValue
		'
		Me.rbStoredValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbStoredValue.AutoSize = True
		Me.rbStoredValue.Location = New System.Drawing.Point(115, 49)
		Me.rbStoredValue.Name = "rbStoredValue"
		Me.rbStoredValue.Size = New System.Drawing.Size(100, 17)
		Me.rbStoredValue.TabIndex = 7
		Me.rbStoredValue.TabStop = True
		Me.rbStoredValue.Text = "Stored value"
		Me.rbStoredValue.UseVisualStyleBackColor = True
		'
		'rbTransactionStatus
		'
		Me.rbTransactionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbTransactionStatus.AutoSize = True
		Me.rbTransactionStatus.Location = New System.Drawing.Point(340, 118)
		Me.rbTransactionStatus.Name = "rbTransactionStatus"
		Me.rbTransactionStatus.Size = New System.Drawing.Size(127, 17)
		Me.rbTransactionStatus.TabIndex = 19
		Me.rbTransactionStatus.TabStop = True
		Me.rbTransactionStatus.Text = "Transaction status"
		Me.rbTransactionStatus.UseVisualStyleBackColor = True
		'
		'rbTransmit
		'
		Me.rbTransmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rbTransmit.AutoSize = True
		Me.rbTransmit.Location = New System.Drawing.Point(473, 118)
		Me.rbTransmit.Name = "rbTransmit"
		Me.rbTransmit.Size = New System.Drawing.Size(65, 17)
		Me.rbTransmit.TabIndex = 20
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
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.rbStoredValue, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.rbEvent, 1, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.rbDiagnosis, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.rbBalanceInquiry, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbEnableService, 2, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.rbTransmit, 4, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbAdmin, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.rbBatch, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbSound, 3, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbGetTotals, 2, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPrint, 2, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbInput, 1, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbDisplay, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.rbAbort, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.rbTransactionStatus, 3, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPayment, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLogout, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLogin, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderAPDU, 2, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardAcquisition, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderInit, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbCardReaderPowerOff, 3, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbPIN, 4, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.rbLoyalty, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.rbReversal, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.rbReconciliation, 2, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 10
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
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(545, 221)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 6)
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.pbCreate, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.pbCancel, 2, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 189)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(539, 29)
		Me.TableLayoutPanel2.TabIndex = 27
		'
		'pbCreate
		'
		Me.pbCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbCreate.AutoSize = True
		Me.pbCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.pbCreate.Location = New System.Drawing.Point(432, 3)
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
		Me.pbCancel.Location = New System.Drawing.Point(486, 3)
		Me.pbCancel.Name = "pbCancel"
		Me.pbCancel.Size = New System.Drawing.Size(50, 23)
		Me.pbCancel.TabIndex = 1
		Me.pbCancel.Text = "Cancel"
		Me.pbCancel.UseVisualStyleBackColor = True
		'
		'FChoser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(569, 245)
		Me.ControlBox = False
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FChoser"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Choose message to create"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
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
End Class
