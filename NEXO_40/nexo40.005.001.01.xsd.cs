#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CustomerOrderRequest1Code
	{
		/// <remarks/>
		BOTH,
		/// <remarks/>
		CLSD,
		/// <remarks/>
		OPEN,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d6d00395-fab3-4cc2-9d35-be59d97a18e8")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DiagnosisRequest1 : IDiagnosisRequest1
	{
		private bool hstDgnssFlgField = default(bool);
		private bool hstDgnssFlgFieldSpecified = default(bool);
		private string[] acqrrIdField = new string[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public bool HstDgnssFlg
		{
			get
			{
				return this.hstDgnssFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.hstDgnssFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - HstDgnssFlgSpecified = true
				this.HstDgnssFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool HstDgnssFlgSpecified
		{
			get
			{
				return this.hstDgnssFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.hstDgnssFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AcqrrId")]
		public string[] AcqrrId
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.acqrrIdField == null)
								|| (this.acqrrIdField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.acqrrIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.acqrrIdField = new string[0];
				}
				else
				{
					this.acqrrIdField = value;
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
					this.HstDgnssFlgSpecified = false;
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
		public int AcqrrIdSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.acqrrIdField == null))
			{
				return 0;
			}
			else
			{
				return this.acqrrIdField.Length;
			}
			// END ADDED BY XSD
		}
		public string AcqrrIdGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.acqrrIdField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.acqrrIdField.Length - 1)
									>= index))
					{
						return this.acqrrIdField[index];
					}
					else
					{
						return default(string);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(string);
			}
			// END ADDED BY XSD
		}
		public bool AcqrrIdSetItem(int index, string value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.acqrrIdField == default(string[])))
				{
					return false;
				}
				else
				{
					this.acqrrIdField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool AcqrrIdAddItem(string value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.acqrrIdField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.acqrrIdField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.acqrrIdField.Length); i = (i + 1))
					{
						array[i] = acqrrIdField[i];
					}
					array[i] = value;
					this.AcqrrId = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool AcqrrIdRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.acqrrIdField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.acqrrIdField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.acqrrIdField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = acqrrIdField[i];
						}
						for (i = (i + 1); (i < this.acqrrIdField.Length); i = (i + 1))
						{
							array[i] = acqrrIdField[i];
						}
						this.AcqrrId = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d45b5665-f95c-481d-8667-8e0aaa0ef719")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOISessionManagementRequestV01 : ISaleToPOISessionManagementRequestV01
	{
		private Header37 hdrField = new Header37();
		private SessionManagementRequest2 ssnMgmtReqField = new SessionManagementRequest2();
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
		public SessionManagementRequest2 SsnMgmtReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.ssnMgmtReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.ssnMgmtReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.ssnMgmtReqField = new SessionManagementRequest2();
				}
				else
				{
					this.ssnMgmtReqField = value;
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
								|| this.SsnMgmtReq.XSD_HasBeenSetProperty)
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
					this.SsnMgmtReq = null;
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
				if ((this.SsnMgmtReq != null))
				{
					this.SsnMgmtReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("53725bfa-2959-4326-b0e5-3a2a2a5e070e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SessionManagementRequest2 : ISessionManagementRequest2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private RetailerService4Code svcCnttField = default(RetailerService4Code);
		private LoginRequest1 lgnReqField = new LoginRequest1();
		private LogoutRequest1 lgtReqField = new LogoutRequest1();
		private DiagnosisRequest1 dgnssReqField = new DiagnosisRequest1();
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
		public RetailerService4Code SvcCntt
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
		public LoginRequest1 LgnReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.lgnReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.lgnReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.lgnReqField = new LoginRequest1();
				}
				else
				{
					this.lgnReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public LogoutRequest1 LgtReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.lgtReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.lgtReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.lgtReqField = new LogoutRequest1();
				}
				else
				{
					this.lgtReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DiagnosisRequest1 DgnssReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dgnssReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dgnssReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dgnssReqField = new DiagnosisRequest1();
				}
				else
				{
					this.dgnssReqField = value;
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
								|| this.LgnReq.XSD_HasBeenSetProperty)
								|| this.LgtReq.XSD_HasBeenSetProperty)
								|| this.DgnssReq.XSD_HasBeenSetProperty);
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
					this.LgnReq = null;
					this.LgtReq = null;
					this.DgnssReq = null;
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
				if ((this.LgnReq != null))
				{
					this.LgnReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.LgtReq != null))
				{
					this.LgtReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.DgnssReq != null))
				{
					this.DgnssReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum RetailerService4Code
	{
		/// <remarks/>
		SMIQ,
		/// <remarks/>
		SMOQ,
		/// <remarks/>
		SMDQ,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2f3838b7-6c23-4c2a-bb11-1fd4fde8b95b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoginRequest1 : ILoginRequest1
	{
		private string lgnDtTmField = default(string);
		private PointOfInteractionComponent9[] saleSftwrField = new PointOfInteractionComponent9[0];
		private SaleTerminalData1 saleTermnlDataField = new SaleTerminalData1();
		private bool trngMdFlgField = default(bool);
		private bool trngMdFlgFieldSpecified = default(bool);
		private string cshrIdField = default(string);
		private string cshrLangField = default(string);
		private string shftNbField = default(string);
		private SaleTokenScope1Code tknReqdTpField = default(SaleTokenScope1Code);
		private bool tknReqdTpFieldSpecified = default(bool);
		private CustomerOrderRequest1Code cstmrOrdrReqField = default(CustomerOrderRequest1Code);
		private bool cstmrOrdrReqFieldSpecified = default(bool);
		private PointOfInteractionComponentIdentification1 pOIIdField = new PointOfInteractionComponentIdentification1();
		private string ttlsGrpIdField = default(string);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string LgnDtTm
		{
			get
			{
				return this.lgnDtTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.lgnDtTmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SaleSftwr")]
		public PointOfInteractionComponent9[] SaleSftwr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.saleSftwrField == null)
								|| (this.saleSftwrField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.saleSftwrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.saleSftwrField = new PointOfInteractionComponent9[0];
				}
				else
				{
					this.saleSftwrField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public SaleTerminalData1 SaleTermnlData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.saleTermnlDataField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.saleTermnlDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.saleTermnlDataField = new SaleTerminalData1();
				}
				else
				{
					this.saleTermnlDataField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool TrngMdFlg
		{
			get
			{
				return this.trngMdFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.trngMdFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - TrngMdFlgSpecified = true
				this.TrngMdFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TrngMdFlgSpecified
		{
			get
			{
				return this.trngMdFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.trngMdFlgFieldSpecified = value;
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
		public string CshrLang
		{
			get
			{
				return this.cshrLangField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cshrLangField = value;
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
		public SaleTokenScope1Code TknReqdTp
		{
			get
			{
				return this.tknReqdTpField;
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
		public bool TknReqdTpSpecified
		{
			get
			{
				return this.tknReqdTpFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.tknReqdTpFieldSpecified = value;
			}
		}
		/// <remarks/>
		public CustomerOrderRequest1Code CstmrOrdrReq
		{
			get
			{
				return this.cstmrOrdrReqField;
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
		public bool CstmrOrdrReqSpecified
		{
			get
			{
				return this.cstmrOrdrReqFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.cstmrOrdrReqFieldSpecified = value;
			}
		}
		/// <remarks/>
		public PointOfInteractionComponentIdentification1 POIId
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pOIIdField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOIIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pOIIdField = new PointOfInteractionComponentIdentification1();
				}
				else
				{
					this.pOIIdField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string TtlsGrpId
		{
			get
			{
				return this.ttlsGrpIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ttlsGrpIdField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return ((this.XSD_HasBeenSetField || this.SaleTermnlData.XSD_HasBeenSetProperty)
								|| this.POIId.XSD_HasBeenSetProperty);
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
					this.SaleSftwr = null;
					this.SaleTermnlData = null;
					this.POIId = null;
					this.TrngMdFlgSpecified = false;
					this.TknReqdTpSpecified = false;
					this.CstmrOrdrReqSpecified = false;
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
				if ((this.SaleTermnlData != null))
				{
					this.SaleTermnlData.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.POIId != null))
				{
					this.POIId.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int SaleSftwrSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.saleSftwrField == null))
			{
				return 0;
			}
			else
			{
				return this.saleSftwrField.Length;
			}
			// END ADDED BY XSD
		}
		public PointOfInteractionComponent9 SaleSftwrGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.saleSftwrField == default(PointOfInteractionComponent9[])))
				{
					return default(PointOfInteractionComponent9);
				}
				else
				{
					if (((this.saleSftwrField.Length - 1)
									>= index))
					{
						return this.saleSftwrField[index];
					}
					else
					{
						return default(PointOfInteractionComponent9);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PointOfInteractionComponent9);
			}
			// END ADDED BY XSD
		}
		public bool SaleSftwrSetItem(int index, PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.saleSftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					this.saleSftwrField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SaleSftwrAddItem(PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.saleSftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.saleSftwrField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.saleSftwrField.Length); i = (i + 1))
					{
						array[i] = saleSftwrField[i];
					}
					array[i] = value;
					this.SaleSftwr = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool SaleSftwrRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.saleSftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					if ((this.saleSftwrField.Length <= index))
					{
						return false;
					}
					else
					{
						PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.saleSftwrField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = saleSftwrField[i];
						}
						for (i = (i + 1); (i < this.saleSftwrField.Length); i = (i + 1))
						{
							array[i] = saleSftwrField[i];
						}
						this.SaleSftwr = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("47613a9a-127e-4a4a-8d11-d2d9fe2d600a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleTerminalData1 : ISaleTerminalData1
	{
		private AttendanceContext1Code termnlEnvtField = default(AttendanceContext1Code);
		private bool termnlEnvtFieldSpecified = default(bool);
		private string saleRcncltnIdField = default(string);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public AttendanceContext1Code TermnlEnvt
		{
			get
			{
				return this.termnlEnvtField;
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
		public bool TermnlEnvtSpecified
		{
			get
			{
				return this.termnlEnvtFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.termnlEnvtFieldSpecified = value;
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
					this.TermnlEnvtSpecified = false;
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
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5ff80fe6-37ce-4821-a4f7-cd1d800d39e6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LogoutRequest1 : ILogoutRequest1
	{
		private bool mntncAllwdField = default(bool);
		private bool mntncAllwdFieldSpecified = default(bool);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public bool MntncAllwd
		{
			get
			{
				return this.mntncAllwdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.mntncAllwdField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MntncAllwdSpecified = true
				this.MntncAllwdSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MntncAllwdSpecified
		{
			get
			{
				return this.mntncAllwdFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.mntncAllwdFieldSpecified = value;
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
					this.MntncAllwdSpecified = false;
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
	}
	[System.Runtime.InteropServices.GuidAttribute("ce8dd52f-ffe8-493c-b362-c0520a4bfa10")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDiagnosisRequest1
	{
		/// <remarks/>
		[DispId(1)]
		bool HstDgnssFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool HstDgnssFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string[] AcqrrId
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
		int AcqrrIdSize();
		[DispId(6)]
		string AcqrrIdGetItem(int index);
		[DispId(7)]
		bool AcqrrIdSetItem(int index, string value);
		[DispId(8)]
		bool AcqrrIdAddItem(string value);
		[DispId(9)]
		bool AcqrrIdRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("b71dfd51-c23f-4650-bc16-c9adeeaba7a7")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOISessionManagementRequestV01
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
		SessionManagementRequest2 SsnMgmtReq
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
	[System.Runtime.InteropServices.GuidAttribute("92d62a16-b683-494e-9eeb-4c15b505bd90")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISessionManagementRequest2
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
		RetailerService4Code SvcCntt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		LoginRequest1 LgnReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LogoutRequest1 LgtReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		DiagnosisRequest1 DgnssReq
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
	[System.Runtime.InteropServices.GuidAttribute("5638faa9-3251-45c7-8181-5ba745d7fa0a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoginRequest1
	{
		/// <remarks/>
		[DispId(1)]
		string LgnDtTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		PointOfInteractionComponent9[] SaleSftwr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleTerminalData1 SaleTermnlData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool TrngMdFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool TrngMdFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string CshrId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string CshrLang
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string ShftNb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		SaleTokenScope1Code TknReqdTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool TknReqdTpSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		CustomerOrderRequest1Code CstmrOrdrReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool CstmrOrdrReqSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		PointOfInteractionComponentIdentification1 POIId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string TtlsGrpId
		{
			get;
			set;
		}
		[DispId(15)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(16)]
		int SaleSftwrSize();
		[DispId(17)]
		PointOfInteractionComponent9 SaleSftwrGetItem(int index);
		[DispId(18)]
		bool SaleSftwrSetItem(int index, PointOfInteractionComponent9 value);
		[DispId(19)]
		bool SaleSftwrAddItem(PointOfInteractionComponent9 value);
		[DispId(20)]
		bool SaleSftwrRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("c74b0078-0bde-4fb2-b66c-464863fc7a1d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleTerminalData1
	{
		/// <remarks/>
		[DispId(1)]
		AttendanceContext1Code TermnlEnvt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool TermnlEnvtSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string SaleRcncltnId
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
	[System.Runtime.InteropServices.GuidAttribute("d887a0a3-c3fc-4d2b-9254-9178dfdef366")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILogoutRequest1
	{
		/// <remarks/>
		[DispId(1)]
		bool MntncAllwd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool MntncAllwdSpecified
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
}
#endif
