#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7b979b05-ceef-4155-b354-82bbc1f35200")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIReconciliationResponseV01 : ISaleToPOIReconciliationResponseV01
	{
		private Header37 hdrField = new Header37();
		private ReconciliationResponse3 rcncltnRspnField = new ReconciliationResponse3();
		private ContentInformationType18 sctyTrlrField = new ContentInformationType18();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public Header37 Hdr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.hdrField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.hdrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.hdrField = new Header37();
				}
				else
				{
					this.hdrField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ReconciliationResponse3 RcncltnRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rcncltnRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rcncltnRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rcncltnRspnField = new ReconciliationResponse3();
				}
				else
				{
					this.rcncltnRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ContentInformationType18 SctyTrlr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.sctyTrlrField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.sctyTrlrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.sctyTrlrField = new ContentInformationType18();
				}
				else
				{
					this.sctyTrlrField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (((this.XSD_HasBeenSetField || this.Hdr.XSD_HasBeenSetProperty)
								|| this.RcncltnRspn.XSD_HasBeenSetProperty)
								|| this.SctyTrlr.XSD_HasBeenSetProperty);
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.Hdr = null;
					this.RcncltnRspn = null;
					this.SctyTrlr = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.Hdr != null))
				{
					this.Hdr.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RcncltnRspn != null))
				{
					this.RcncltnRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.SctyTrlr != null))
				{
					this.SctyTrlr.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("cd2a2295-3cc8-42fb-a2d8-f6bb5353dd2f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReconciliationResponse3 : IReconciliationResponse3
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private ReconciliationResponseData1 rcncltnRspnDataField = new ReconciliationResponseData1();
		private ResponseType9 rspnField = new ResponseType9();
		private SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public CardPaymentEnvironment73 Envt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.envtField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.envtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.envtField = new CardPaymentEnvironment73();
				}
				else
				{
					this.envtField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public CardPaymentContext27 Cntxt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.cntxtField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.cntxtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.cntxtField = new CardPaymentContext27();
				}
				else
				{
					this.cntxtField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ReconciliationResponseData1 RcncltnRspnData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rcncltnRspnDataField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rcncltnRspnDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rcncltnRspnDataField = new ReconciliationResponseData1();
				}
				else
				{
					this.rcncltnRspnDataField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ResponseType9 Rspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rspnField = new ResponseType9();
				}
				else
				{
					this.rspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
		public SupplementaryData1[] SplmtryData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.splmtryDataField == null)
								|| (this.splmtryDataField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.splmtryDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.splmtryDataField = new SupplementaryData1[0];
				}
				else
				{
					this.splmtryDataField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return ((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
								|| this.Cntxt.XSD_HasBeenSetProperty)
								|| this.RcncltnRspnData.XSD_HasBeenSetProperty)
								|| this.Rspn.XSD_HasBeenSetProperty);
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.Envt = null;
					this.Cntxt = null;
					this.RcncltnRspnData = null;
					this.Rspn = null;
					this.SplmtryData = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.Envt != null))
				{
					this.Envt.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.Cntxt != null))
				{
					this.Cntxt.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RcncltnRspnData != null))
				{
					this.RcncltnRspnData.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.Rspn != null))
				{
					this.Rspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int SplmtryDataSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.splmtryDataField == null))
			{
				return 0;
			}
			else
			{
				return this.splmtryDataField.Length;
			}
			// END ADDED BY XSD
		}
		public SupplementaryData1 SplmtryDataGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.splmtryDataField == default(SupplementaryData1[])))
				{
					return default(SupplementaryData1);
				}
				else
				{
					if (((this.splmtryDataField.Length - 1)
									>= index))
					{
						return this.splmtryDataField[index];
					}
					else
					{
						return default(SupplementaryData1);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SupplementaryData1);
			}
			// END ADDED BY XSD
		}
		public bool SplmtryDataSetItem(int index, SupplementaryData1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.splmtryDataField == default(SupplementaryData1[])))
				{
					return false;
				}
				else
				{
					this.splmtryDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SplmtryDataAddItem(SupplementaryData1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.splmtryDataField == default(SupplementaryData1[])))
				{
					return false;
				}
				else
				{
					SupplementaryData1[] array = new SupplementaryData1[(this.splmtryDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.splmtryDataField.Length); i = (i + 1))
					{
						array[i] = splmtryDataField[i];
					}
					array[i] = value;
					this.SplmtryData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SplmtryDataRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.splmtryDataField == default(SupplementaryData1[])))
				{
					return false;
				}
				else
				{
					if ((this.splmtryDataField.Length <= index))
					{
						return false;
					}
					else
					{
						SupplementaryData1[] array = new SupplementaryData1[(this.splmtryDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = splmtryDataField[i];
						}
						for (i = (i + 1); (i < this.splmtryDataField.Length); i = (i + 1))
						{
							array[i] = splmtryDataField[i];
						}
						this.SplmtryData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f595c132-4e26-4d8a-95e0-476fa168cf67")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReconciliationResponseData1 : IReconciliationResponseData1
	{
		private ReconciliationType1Code rcncltnTpField = default(ReconciliationType1Code);
		private string pOIRcncltnIdField = default(string);
		private TransactionTotalsSet1[] txTtlsField = new TransactionTotalsSet1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public ReconciliationType1Code RcncltnTp
		{
			get
			{
				return this.rcncltnTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string POIRcncltnId
		{
			get
			{
				return this.pOIRcncltnIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIRcncltnIdField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TxTtls")]
		public TransactionTotalsSet1[] TxTtls
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.txTtlsField == null)
								|| (this.txTtlsField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.txTtlsField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.txTtlsField = new TransactionTotalsSet1[0];
				}
				else
				{
					this.txTtlsField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return this.XSD_HasBeenSetField;
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.TxTtls = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				// END ADDED BY XSD
			}
		}
		public int TxTtlsSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.txTtlsField == null))
			{
				return 0;
			}
			else
			{
				return this.txTtlsField.Length;
			}
			// END ADDED BY XSD
		}
		public TransactionTotalsSet1 TxTtlsGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.txTtlsField == default(TransactionTotalsSet1[])))
				{
					return default(TransactionTotalsSet1);
				}
				else
				{
					if (((this.txTtlsField.Length - 1)
									>= index))
					{
						return this.txTtlsField[index];
					}
					else
					{
						return default(TransactionTotalsSet1);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TransactionTotalsSet1);
			}
			// END ADDED BY XSD
		}
		public bool TxTtlsSetItem(int index, TransactionTotalsSet1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.txTtlsField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					this.txTtlsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxTtlsAddItem(TransactionTotalsSet1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.txTtlsField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.txTtlsField.Length); i = (i + 1))
					{
						array[i] = txTtlsField[i];
					}
					array[i] = value;
					this.TxTtls = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxTtlsRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.txTtlsField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					if ((this.txTtlsField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = txTtlsField[i];
						}
						for (i = (i + 1); (i < this.txTtlsField.Length); i = (i + 1))
						{
							array[i] = txTtlsField[i];
						}
						this.TxTtls = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bd1ea642-2d72-4ead-a320-8edf4a6efc03")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionTotalsSet1 : ITransactionTotalsSet1
	{
		private PaymentInstrumentType1Code pmtInstrmTpField = default(PaymentInstrumentType1Code);
		private string acqrrIdField = default(string);
		private string rcncltnIdField = default(string);
		private string saleRcncltnIdField = default(string);
		private string brndField = default(string);
		private string pOIIdField = default(string);
		private string saleIdField = default(string);
		private string cshrIdField = default(string);
		private string shftNbField = default(string);
		private Organisation26[] spnsrdMrchntField = new Organisation26[0];
		private TransactionTotals8 txTtlField = new TransactionTotals8();
		private LoyaltyTransactionTotals1[] lltyTxTtlField = new LoyaltyTransactionTotals1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public PaymentInstrumentType1Code PmtInstrmTp
		{
			get
			{
				return this.pmtInstrmTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string AcqrrId
		{
			get
			{
				return this.acqrrIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.acqrrIdField = value;
			}
		}
		/// <remarks/>
		public string RcncltnId
		{
			get
			{
				return this.rcncltnIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rcncltnIdField = value;
			}
		}
		/// <remarks/>
		public string SaleRcncltnId
		{
			get
			{
				return this.saleRcncltnIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.saleRcncltnIdField = value;
			}
		}
		/// <remarks/>
		public string Brnd
		{
			get
			{
				return this.brndField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.brndField = value;
			}
		}
		/// <remarks/>
		public string POIId
		{
			get
			{
				return this.pOIIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIIdField = value;
			}
		}
		/// <remarks/>
		public string SaleId
		{
			get
			{
				return this.saleIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.saleIdField = value;
			}
		}
		/// <remarks/>
		public string CshrId
		{
			get
			{
				return this.cshrIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cshrIdField = value;
			}
		}
		/// <remarks/>
		public string ShftNb
		{
			get
			{
				return this.shftNbField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.shftNbField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SpnsrdMrchnt")]
		public Organisation26[] SpnsrdMrchnt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.spnsrdMrchntField == null)
								|| (this.spnsrdMrchntField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.spnsrdMrchntField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.spnsrdMrchntField = new Organisation26[0];
				}
				else
				{
					this.spnsrdMrchntField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public TransactionTotals8 TxTtl
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.txTtlField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.txTtlField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.txTtlField = new TransactionTotals8();
				}
				else
				{
					this.txTtlField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LltyTxTtl")]
		public LoyaltyTransactionTotals1[] LltyTxTtl
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.lltyTxTtlField == null)
								|| (this.lltyTxTtlField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.lltyTxTtlField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.lltyTxTtlField = new LoyaltyTransactionTotals1[0];
				}
				else
				{
					this.lltyTxTtlField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.TxTtl.XSD_HasBeenSetProperty);
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.SpnsrdMrchnt = null;
					this.TxTtl = null;
					this.LltyTxTtl = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.TxTtl != null))
				{
					this.TxTtl.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int SpnsrdMrchntSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.spnsrdMrchntField == null))
			{
				return 0;
			}
			else
			{
				return this.spnsrdMrchntField.Length;
			}
			// END ADDED BY XSD
		}
		public Organisation26 SpnsrdMrchntGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.spnsrdMrchntField == default(Organisation26[])))
				{
					return default(Organisation26);
				}
				else
				{
					if (((this.spnsrdMrchntField.Length - 1)
									>= index))
					{
						return this.spnsrdMrchntField[index];
					}
					else
					{
						return default(Organisation26);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(Organisation26);
			}
			// END ADDED BY XSD
		}
		public bool SpnsrdMrchntSetItem(int index, Organisation26 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.spnsrdMrchntField == default(Organisation26[])))
				{
					return false;
				}
				else
				{
					this.spnsrdMrchntField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SpnsrdMrchntAddItem(Organisation26 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.spnsrdMrchntField == default(Organisation26[])))
				{
					return false;
				}
				else
				{
					Organisation26[] array = new Organisation26[(this.spnsrdMrchntField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.spnsrdMrchntField.Length); i = (i + 1))
					{
						array[i] = spnsrdMrchntField[i];
					}
					array[i] = value;
					this.SpnsrdMrchnt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SpnsrdMrchntRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.spnsrdMrchntField == default(Organisation26[])))
				{
					return false;
				}
				else
				{
					if ((this.spnsrdMrchntField.Length <= index))
					{
						return false;
					}
					else
					{
						Organisation26[] array = new Organisation26[(this.spnsrdMrchntField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = spnsrdMrchntField[i];
						}
						for (i = (i + 1); (i < this.spnsrdMrchntField.Length); i = (i + 1))
						{
							array[i] = spnsrdMrchntField[i];
						}
						this.SpnsrdMrchnt = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public int LltyTxTtlSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.lltyTxTtlField == null))
			{
				return 0;
			}
			else
			{
				return this.lltyTxTtlField.Length;
			}
			// END ADDED BY XSD
		}
		public LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[])))
				{
					return default(LoyaltyTransactionTotals1);
				}
				else
				{
					if (((this.lltyTxTtlField.Length - 1)
									>= index))
					{
						return this.lltyTxTtlField[index];
					}
					else
					{
						return default(LoyaltyTransactionTotals1);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyTransactionTotals1);
			}
			// END ADDED BY XSD
		}
		public bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[])))
				{
					return false;
				}
				else
				{
					this.lltyTxTtlField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[])))
				{
					return false;
				}
				else
				{
					LoyaltyTransactionTotals1[] array = new LoyaltyTransactionTotals1[(this.lltyTxTtlField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.lltyTxTtlField.Length); i = (i + 1))
					{
						array[i] = lltyTxTtlField[i];
					}
					array[i] = value;
					this.LltyTxTtl = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool LltyTxTtlRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[])))
				{
					return false;
				}
				else
				{
					if ((this.lltyTxTtlField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyTransactionTotals1[] array = new LoyaltyTransactionTotals1[(this.lltyTxTtlField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = lltyTxTtlField[i];
						}
						for (i = (i + 1); (i < this.lltyTxTtlField.Length); i = (i + 1))
						{
							array[i] = lltyTxTtlField[i];
						}
						this.LltyTxTtl = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PaymentInstrumentType1Code
	{
		/// <remarks/>
		CARD,
		/// <remarks/>
		CASH,
		/// <remarks/>
		CHCK,
		/// <remarks/>
		LOYT,
		/// <remarks/>
		SVAC,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("fa5ff6bd-adb0-4bc1-a73b-7a512baf346b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionTotals8 : ITransactionTotals8
	{
		private string pOIGrpIdField = default(string);
		private string cardPdctPrflField = default(string);
		private string ccyField = default(string);
		private TypeTransactionTotals3Code tpField = default(TypeTransactionTotals3Code);
		private double ttlNbField = default(double);
		private double cmltvAmtField = default(double);
		private DetailedAmount15 dtldAmtField = new DetailedAmount15();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string POIGrpId
		{
			get
			{
				return this.pOIGrpIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIGrpIdField = value;
			}
		}
		/// <remarks/>
		public string CardPdctPrfl
		{
			get
			{
				return this.cardPdctPrflField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cardPdctPrflField = value;
			}
		}
		/// <remarks/>
		public string Ccy
		{
			get
			{
				return this.ccyField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ccyField = value;
			}
		}
		/// <remarks/>
		public TypeTransactionTotals3Code Tp
		{
			get
			{
				return this.tpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public double TtlNb
		{
			get
			{
				return this.ttlNbField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ttlNbField = value;
			}
		}
		/// <remarks/>
		public double CmltvAmt
		{
			get
			{
				return this.cmltvAmtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cmltvAmtField = value;
			}
		}
		/// <remarks/>
		public DetailedAmount15 DtldAmt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dtldAmtField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dtldAmtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dtldAmtField = new DetailedAmount15();
				}
				else
				{
					this.dtldAmtField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.DtldAmt.XSD_HasBeenSetProperty);
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.DtldAmt = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.DtldAmt != null))
				{
					this.DtldAmt.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TypeTransactionTotals3Code
	{
		/// <remarks/>
		CRDT,
		/// <remarks/>
		CRDR,
		/// <remarks/>
		DEBT,
		/// <remarks/>
		DBTR,
		/// <remarks/>
		DECL,
		/// <remarks/>
		FAIL,
		/// <remarks/>
		RESV,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c35e9132-09ab-4879-b551-71c3a9fd9224")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyTransactionTotals1 : ILoyaltyTransactionTotals1
	{
		private string pOIGrpIdField = default(string);
		private AmountUnit1Code lltyUnitField = default(AmountUnit1Code);
		private bool lltyUnitFieldSpecified = default(bool);
		private string cardPdctPrflField = default(string);
		private string ccyField = default(string);
		private LoyaltyTypeTransactionTotals1Code txTpField = default(LoyaltyTypeTransactionTotals1Code);
		private double ttlNbField = default(double);
		private double cmltvAmtField = default(double);
		private DetailedAmount15 dtldAmtField = new DetailedAmount15();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string POIGrpId
		{
			get
			{
				return this.pOIGrpIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIGrpIdField = value;
			}
		}
		/// <remarks/>
		public AmountUnit1Code LltyUnit
		{
			get
			{
				return this.lltyUnitField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool LltyUnitSpecified
		{
			get
			{
				return this.lltyUnitFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.lltyUnitFieldSpecified = value;
			}
		}
		/// <remarks/>
		public string CardPdctPrfl
		{
			get
			{
				return this.cardPdctPrflField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cardPdctPrflField = value;
			}
		}
		/// <remarks/>
		public string Ccy
		{
			get
			{
				return this.ccyField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ccyField = value;
			}
		}
		/// <remarks/>
		public LoyaltyTypeTransactionTotals1Code TxTp
		{
			get
			{
				return this.txTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public double TtlNb
		{
			get
			{
				return this.ttlNbField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ttlNbField = value;
			}
		}
		/// <remarks/>
		public double CmltvAmt
		{
			get
			{
				return this.cmltvAmtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cmltvAmtField = value;
			}
		}
		/// <remarks/>
		public DetailedAmount15 DtldAmt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dtldAmtField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dtldAmtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dtldAmtField = new DetailedAmount15();
				}
				else
				{
					this.dtldAmtField = value;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.DtldAmt.XSD_HasBeenSetProperty);
				// END ADDED BY XSD
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_HasBeenSetField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.XSD_HasBeenSetField == false))
				{
					this.DtldAmt = null;
					this.LltyUnitSpecified = false;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_Optimizing
		{
			get
			{
				// BEGIN ADDED BY XSD - AddGetStatementFromField
				return this.XSD_OptimizingField;
				// END ADDED BY XSD - AddGetStatementFromField
			}
			set
			{
				// BEGIN ADDED BY XSD - AddSetStatementFromValue
				this.XSD_OptimizingField = value;
				// END ADDED BY XSD - AddSetStatementFromValue
				// BEGIN ADDED BY XSD
				if ((this.DtldAmt != null))
				{
					this.DtldAmt.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum LoyaltyTypeTransactionTotals1Code
	{
		/// <remarks/>
		AWRD,
		/// <remarks/>
		REBA,
		/// <remarks/>
		REDE,
		/// <remarks/>
		AWRR,
		/// <remarks/>
		REBR,
		/// <remarks/>
		REDR,
	}
	[System.Runtime.InteropServices.GuidAttribute("52247193-6321-4c1e-845a-87fe1abd4274")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIReconciliationResponseV01
	{
		/// <remarks/>
		[DispId(1)]
		Header37 Hdr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		ReconciliationResponse3 RcncltnRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		ContentInformationType18 SctyTrlr
		{
			get;
			set;
		}
		[DispId(4)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("fe88b2e3-4db5-4fb3-91a7-288bf9db1302")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReconciliationResponse3
	{
		/// <remarks/>
		[DispId(1)]
		CardPaymentEnvironment73 Envt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		CardPaymentContext27 Cntxt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		ReconciliationResponseData1 RcncltnRspnData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		ResponseType9 Rspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		SupplementaryData1[] SplmtryData
		{
			get;
			set;
		}
		[DispId(6)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(7)]
		int SplmtryDataSize();
		[DispId(8)]
		SupplementaryData1 SplmtryDataGetItem(int index);
		[DispId(9)]
		bool SplmtryDataSetItem(int index, SupplementaryData1 value);
		[DispId(10)]
		bool SplmtryDataAddItem(SupplementaryData1 value);
		[DispId(11)]
		bool SplmtryDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("343f9948-90ab-4516-a615-83ffa67917d4")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReconciliationResponseData1
	{
		/// <remarks/>
		[DispId(1)]
		ReconciliationType1Code RcncltnTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		string POIRcncltnId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionTotalsSet1[] TxTtls
		{
			get;
			set;
		}
		[DispId(4)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(5)]
		int TxTtlsSize();
		[DispId(6)]
		TransactionTotalsSet1 TxTtlsGetItem(int index);
		[DispId(7)]
		bool TxTtlsSetItem(int index, TransactionTotalsSet1 value);
		[DispId(8)]
		bool TxTtlsAddItem(TransactionTotalsSet1 value);
		[DispId(9)]
		bool TxTtlsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("850692d9-8190-4c57-a702-2512e1fb27a5")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionTotalsSet1
	{
		/// <remarks/>
		[DispId(1)]
		PaymentInstrumentType1Code PmtInstrmTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		string AcqrrId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string RcncltnId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string SaleRcncltnId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string Brnd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string POIId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string SaleId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string CshrId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ShftNb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		Organisation26[] SpnsrdMrchnt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		TransactionTotals8 TxTtl
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		LoyaltyTransactionTotals1[] LltyTxTtl
		{
			get;
			set;
		}
		[DispId(13)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(14)]
		int SpnsrdMrchntSize();
		[DispId(15)]
		Organisation26 SpnsrdMrchntGetItem(int index);
		[DispId(16)]
		bool SpnsrdMrchntSetItem(int index, Organisation26 value);
		[DispId(17)]
		bool SpnsrdMrchntAddItem(Organisation26 value);
		[DispId(18)]
		bool SpnsrdMrchntRemoveItem(int index);
		[DispId(19)]
		int LltyTxTtlSize();
		[DispId(20)]
		LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index);
		[DispId(21)]
		bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value);
		[DispId(22)]
		bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value);
		[DispId(23)]
		bool LltyTxTtlRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5a5c5b88-bc82-4248-b672-bd3bdc88f8a0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionTotals8
	{
		/// <remarks/>
		[DispId(1)]
		string POIGrpId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		string CardPdctPrfl
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Ccy
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		TypeTransactionTotals3Code Tp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		double TtlNb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		double CmltvAmt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		DetailedAmount15 DtldAmt
		{
			get;
			set;
		}
		[DispId(8)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("1ca865b4-b90d-4081-a9f8-81722c3a6a41")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyTransactionTotals1
	{
		/// <remarks/>
		[DispId(1)]
		string POIGrpId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		AmountUnit1Code LltyUnit
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool LltyUnitSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string CardPdctPrfl
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string Ccy
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		LoyaltyTypeTransactionTotals1Code TxTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		double TtlNb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		double CmltvAmt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		DetailedAmount15 DtldAmt
		{
			get;
			set;
		}
		[DispId(10)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
}
#endif
