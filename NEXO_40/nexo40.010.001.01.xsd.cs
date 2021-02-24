#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("3abf8ac2-00a4-4127-aea2-cef6dddbb0a4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIReportResponseV01 : ISaleToPOIReportResponseV01
	{
		private Header37 hdrField = new Header37();
		private ReportResponse2 rptRspnField = new ReportResponse2();
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
		public ReportResponse2 RptRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rptRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rptRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rptRspnField = new ReportResponse2();
				}
				else
				{
					this.rptRspnField = value;
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
								|| this.RptRspn.XSD_HasBeenSetProperty)
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
					this.RptRspn = null;
					this.SctyTrlr = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_OptimizingProperty
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
					this.Hdr.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.RptRspn != null))
				{
					this.RptRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.SctyTrlr != null))
				{
					this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("09b31bbb-9571-4ac8-8d57-3a75799412af")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReportResponse2 : IReportResponse2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private RetailerService7Code svcCnttField = default(RetailerService7Code);
		private ReportTransactionResponse1 rptTxRspnField = new ReportTransactionResponse1();
		private ReportGetTotalsResponse1 rptGetTtlsRspnField = new ReportGetTotalsResponse1();
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
		public RetailerService7Code SvcCntt
		{
			get
			{
				return this.svcCnttField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ReportTransactionResponse1 RptTxRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rptTxRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rptTxRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rptTxRspnField = new ReportTransactionResponse1();
				}
				else
				{
					this.rptTxRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ReportGetTotalsResponse1 RptGetTtlsRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rptGetTtlsRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rptGetTtlsRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rptGetTtlsRspnField = new ReportGetTotalsResponse1();
				}
				else
				{
					this.rptGetTtlsRspnField = value;
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
				return (((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
								|| this.Cntxt.XSD_HasBeenSetProperty)
								|| this.RptTxRspn.XSD_HasBeenSetProperty)
								|| this.RptGetTtlsRspn.XSD_HasBeenSetProperty)
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
					this.RptTxRspn = null;
					this.RptGetTtlsRspn = null;
					this.Rspn = null;
					this.SplmtryData = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_OptimizingProperty
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
					this.Envt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.Cntxt != null))
				{
					this.Cntxt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.RptTxRspn != null))
				{
					this.RptTxRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.RptGetTtlsRspn != null))
				{
					this.RptGetTtlsRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.Rspn != null))
				{
					this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum RetailerService7Code
	{
		/// <remarks/>
		RPTP,
		/// <remarks/>
		RPAP,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("301ff24b-1e50-46b0-bbf0-928ee75e188b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReportTransactionResponse1 : IReportTransactionResponse1
	{
		private double rptFullSzField = default(double);
		private double blckStartField = default(double);
		private double blckStopField = default(double);
		private PointOfInteractionTransactionReport1[] txRptField = new PointOfInteractionTransactionReport1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public double RptFullSz
		{
			get
			{
				return this.rptFullSzField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rptFullSzField = value;
			}
		}
		/// <remarks/>
		public double BlckStart
		{
			get
			{
				return this.blckStartField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.blckStartField = value;
			}
		}
		/// <remarks/>
		public double BlckStop
		{
			get
			{
				return this.blckStopField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.blckStopField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TxRpt")]
		public PointOfInteractionTransactionReport1[] TxRpt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.txRptField == null)
								|| (this.txRptField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.txRptField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.txRptField = new PointOfInteractionTransactionReport1[0];
				}
				else
				{
					this.txRptField = value;
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
					this.TxRpt = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_OptimizingProperty
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
		public int TxRptSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.txRptField == null))
			{
				return 0;
			}
			else
			{
				return this.txRptField.Length;
			}
			// END ADDED BY XSD
		}
		public PointOfInteractionTransactionReport1 TxRptGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.txRptField == default(PointOfInteractionTransactionReport1[])))
				{
					return default(PointOfInteractionTransactionReport1);
				}
				else
				{
					if (((this.txRptField.Length - 1)
									>= index))
					{
						return this.txRptField[index];
					}
					else
					{
						return default(PointOfInteractionTransactionReport1);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PointOfInteractionTransactionReport1);
			}
			// END ADDED BY XSD
		}
		public bool TxRptSetItem(int index, PointOfInteractionTransactionReport1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.txRptField == default(PointOfInteractionTransactionReport1[])))
				{
					return false;
				}
				else
				{
					this.txRptField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxRptAddItem(PointOfInteractionTransactionReport1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.txRptField == default(PointOfInteractionTransactionReport1[])))
				{
					return false;
				}
				else
				{
					PointOfInteractionTransactionReport1[] array = new PointOfInteractionTransactionReport1[(this.txRptField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.txRptField.Length); i = (i + 1))
					{
						array[i] = txRptField[i];
					}
					array[i] = value;
					this.TxRpt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxRptRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.txRptField == default(PointOfInteractionTransactionReport1[])))
				{
					return false;
				}
				else
				{
					if ((this.txRptField.Length <= index))
					{
						return false;
					}
					else
					{
						PointOfInteractionTransactionReport1[] array = new PointOfInteractionTransactionReport1[(this.txRptField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = txRptField[i];
						}
						for (i = (i + 1); (i < this.txRptField.Length); i = (i + 1))
						{
							array[i] = txRptField[i];
						}
						this.TxRpt = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a793aed5-86f0-4b62-9998-b86f047ba07f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PointOfInteractionTransactionReport1 : IPointOfInteractionTransactionReport1
	{
		private ResponseType9 rspnField = new ResponseType9();
		private PaymentResponse1 pmtRspnField = new PaymentResponse1();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
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
		public PaymentResponse1 PmtRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pmtRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pmtRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pmtRspnField = new PaymentResponse1();
				}
				else
				{
					this.pmtRspnField = value;
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
				return ((this.XSD_HasBeenSetField || this.Rspn.XSD_HasBeenSetProperty)
								|| this.PmtRspn.XSD_HasBeenSetProperty);
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
					this.Rspn = null;
					this.PmtRspn = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_OptimizingProperty
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
				if ((this.Rspn != null))
				{
					this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.PmtRspn != null))
				{
					this.PmtRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2371a719-ab28-4219-9f60-493a75f4ca1a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReportGetTotalsResponse1 : IReportGetTotalsResponse1
	{
		private string pOIRcncltnIdField = default(string);
		private TransactionTotalsSet1[] txTtlsSetField = new TransactionTotalsSet1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
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
		[System.Xml.Serialization.XmlElementAttribute("TxTtlsSet")]
		public TransactionTotalsSet1[] TxTtlsSet
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.txTtlsSetField == null)
								|| (this.txTtlsSetField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.txTtlsSetField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.txTtlsSetField = new TransactionTotalsSet1[0];
				}
				else
				{
					this.txTtlsSetField = value;
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
					this.TxTtlsSet = null;
				}
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		internal bool XSD_OptimizingProperty
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
		public int TxTtlsSetSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.txTtlsSetField == null))
			{
				return 0;
			}
			else
			{
				return this.txTtlsSetField.Length;
			}
			// END ADDED BY XSD
		}
		public TransactionTotalsSet1 TxTtlsSetGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.txTtlsSetField == default(TransactionTotalsSet1[])))
				{
					return default(TransactionTotalsSet1);
				}
				else
				{
					if (((this.txTtlsSetField.Length - 1)
									>= index))
					{
						return this.txTtlsSetField[index];
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
		public bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.txTtlsSetField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					this.txTtlsSetField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxTtlsSetAddItem(TransactionTotalsSet1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.txTtlsSetField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.txTtlsSetField.Length); i = (i + 1))
					{
						array[i] = txTtlsSetField[i];
					}
					array[i] = value;
					this.TxTtlsSet = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool TxTtlsSetRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.txTtlsSetField == default(TransactionTotalsSet1[])))
				{
					return false;
				}
				else
				{
					if ((this.txTtlsSetField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = txTtlsSetField[i];
						}
						for (i = (i + 1); (i < this.txTtlsSetField.Length); i = (i + 1))
						{
							array[i] = txTtlsSetField[i];
						}
						this.TxTtlsSet = array;
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
	[System.Runtime.InteropServices.GuidAttribute("12ee82a4-b4c5-4f27-b055-ef0cb0c63d22")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIReportResponseV01
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
		ReportResponse2 RptRspn
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
	[System.Runtime.InteropServices.GuidAttribute("47723b6c-8ca9-4d09-9972-21e71cb63eda")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReportResponse2
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
		RetailerService7Code SvcCntt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		ReportTransactionResponse1 RptTxRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		ReportGetTotalsResponse1 RptGetTtlsRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		ResponseType9 Rspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		SupplementaryData1[] SplmtryData
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
		[DispId(9)]
		int SplmtryDataSize();
		[DispId(10)]
		SupplementaryData1 SplmtryDataGetItem(int index);
		[DispId(11)]
		bool SplmtryDataSetItem(int index, SupplementaryData1 value);
		[DispId(12)]
		bool SplmtryDataAddItem(SupplementaryData1 value);
		[DispId(13)]
		bool SplmtryDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("700b4219-4b1d-4ae3-8214-f8583d56705b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReportTransactionResponse1
	{
		/// <remarks/>
		[DispId(1)]
		double RptFullSz
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		double BlckStart
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double BlckStop
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		PointOfInteractionTransactionReport1[] TxRpt
		{
			get;
			set;
		}
		[DispId(5)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(6)]
		int TxRptSize();
		[DispId(7)]
		PointOfInteractionTransactionReport1 TxRptGetItem(int index);
		[DispId(8)]
		bool TxRptSetItem(int index, PointOfInteractionTransactionReport1 value);
		[DispId(9)]
		bool TxRptAddItem(PointOfInteractionTransactionReport1 value);
		[DispId(10)]
		bool TxRptRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2f48f64f-244f-4172-8bb0-214e3992dfa0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPointOfInteractionTransactionReport1
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType9 Rspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		PaymentResponse1 PmtRspn
		{
			get;
			set;
		}
		[DispId(3)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("63eacd6b-fd5f-46cc-8aaf-bebaa230ab85")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReportGetTotalsResponse1
	{
		/// <remarks/>
		[DispId(1)]
		string POIRcncltnId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		TransactionTotalsSet1[] TxTtlsSet
		{
			get;
			set;
		}
		[DispId(3)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(4)]
		int TxTtlsSetSize();
		[DispId(5)]
		TransactionTotalsSet1 TxTtlsSetGetItem(int index);
		[DispId(6)]
		bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value);
		[DispId(7)]
		bool TxTtlsSetAddItem(TransactionTotalsSet1 value);
		[DispId(8)]
		bool TxTtlsSetRemoveItem(int index);
	}
}
#endif
