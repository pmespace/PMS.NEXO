#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum DataSetCategory12Code
	{
		/// <remarks/>
		AQPR,
		/// <remarks/>
		APPR,
		/// <remarks/>
		TXCP,
		/// <remarks/>
		AKCP,
		/// <remarks/>
		DLGT,
		/// <remarks/>
		MGTP,
		/// <remarks/>
		MRPR,
		/// <remarks/>
		SCPR,
		/// <remarks/>
		SWPK,
		/// <remarks/>
		STRP,
		/// <remarks/>
		TRPR,
		/// <remarks/>
		VDPR,
		/// <remarks/>
		PARA,
		/// <remarks/>
		TMSP,
		/// <remarks/>
		CRTF,
		/// <remarks/>
		LOGF,
		/// <remarks/>
		CMRQ,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("1a5e5ac3-a5bc-4a6d-9972-2d7818fa8bf5")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DataSetIdentification7 : IDataSetIdentification7
	{
		private string nmField = default(string);
		private DataSetCategory12Code tpField = default(DataSetCategory12Code);
		private string vrsnField = default(string);
		private string creDtTmField = default(string);
		private bool creDtTmFieldSpecified = default(bool);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string Nm
		{
			get
			{
				return this.nmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.nmField = value;
			}
		}
		/// <remarks/>
		public DataSetCategory12Code Tp
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
		public string Vrsn
		{
			get
			{
				return this.vrsnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.vrsnField = value;
			}
		}
		/// <remarks/>
		public string CreDtTm
		{
			get
			{
				return this.creDtTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.creDtTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - CreDtTmSpecified = true
				this.CreDtTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CreDtTmSpecified
		{
			get
			{
				return this.creDtTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.creDtTmFieldSpecified = value;
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
					this.CreDtTmSpecified = false;
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
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("43831253-11d2-417f-ba87-03b0127400d0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DiagnosisResponse1 : IDiagnosisResponse1
	{
		private string[] lggdSaleIdField = new string[0];
		private StatusReportContent8 pOIStsField = new StatusReportContent8();
		private HostStatus1[] hstStsField = new HostStatus1[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LggdSaleId")]
		public string[] LggdSaleId
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.lggdSaleIdField == null)
								|| (this.lggdSaleIdField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.lggdSaleIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.lggdSaleIdField = new string[0];
				}
				else
				{
					this.lggdSaleIdField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public StatusReportContent8 POISts
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pOIStsField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOIStsField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pOIStsField = new StatusReportContent8();
				}
				else
				{
					this.pOIStsField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HstSts")]
		public HostStatus1[] HstSts
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.hstStsField == null)
								|| (this.hstStsField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.hstStsField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.hstStsField = new HostStatus1[0];
				}
				else
				{
					this.hstStsField = value;
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
				return (this.XSD_HasBeenSetField || this.POISts.XSD_HasBeenSetProperty);
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
					this.POISts = null;
					this.HstSts = null;
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
				if ((this.POISts != null))
				{
					this.POISts.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int LggdSaleIdSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.lggdSaleIdField == null))
			{
				return 0;
			}
			else
			{
				return this.lggdSaleIdField.Length;
			}
			// END ADDED BY XSD
		}
		public string LggdSaleIdGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.lggdSaleIdField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.lggdSaleIdField.Length - 1)
									>= index))
					{
						return this.lggdSaleIdField[index];
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
		public bool LggdSaleIdSetItem(int index, string value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.lggdSaleIdField == default(string[])))
				{
					return false;
				}
				else
				{
					this.lggdSaleIdField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool LggdSaleIdAddItem(string value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.lggdSaleIdField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.lggdSaleIdField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.lggdSaleIdField.Length); i = (i + 1))
					{
						array[i] = lggdSaleIdField[i];
					}
					array[i] = value;
					this.LggdSaleId = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool LggdSaleIdRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.lggdSaleIdField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.lggdSaleIdField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.lggdSaleIdField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = lggdSaleIdField[i];
						}
						for (i = (i + 1); (i < this.lggdSaleIdField.Length); i = (i + 1))
						{
							array[i] = lggdSaleIdField[i];
						}
						this.LggdSaleId = array;
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
		public int HstStsSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.hstStsField == null))
			{
				return 0;
			}
			else
			{
				return this.hstStsField.Length;
			}
			// END ADDED BY XSD
		}
		public HostStatus1 HstStsGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.hstStsField == default(HostStatus1[])))
				{
					return default(HostStatus1);
				}
				else
				{
					if (((this.hstStsField.Length - 1)
									>= index))
					{
						return this.hstStsField[index];
					}
					else
					{
						return default(HostStatus1);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(HostStatus1);
			}
			// END ADDED BY XSD
		}
		public bool HstStsSetItem(int index, HostStatus1 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.hstStsField == default(HostStatus1[])))
				{
					return false;
				}
				else
				{
					this.hstStsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool HstStsAddItem(HostStatus1 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.hstStsField == default(HostStatus1[])))
				{
					return false;
				}
				else
				{
					HostStatus1[] array = new HostStatus1[(this.hstStsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.hstStsField.Length); i = (i + 1))
					{
						array[i] = hstStsField[i];
					}
					array[i] = value;
					this.HstSts = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool HstStsRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.hstStsField == default(HostStatus1[])))
				{
					return false;
				}
				else
				{
					if ((this.hstStsField.Length <= index))
					{
						return false;
					}
					else
					{
						HostStatus1[] array = new HostStatus1[(this.hstStsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = hstStsField[i];
						}
						for (i = (i + 1); (i < this.hstStsField.Length); i = (i + 1))
						{
							array[i] = hstStsField[i];
						}
						this.HstSts = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("1db9a526-5546-4630-939c-696e78aa8156")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StatusReportContent8 : IStatusReportContent8
	{
		private PointOfInteractionCapabilities8 pOICpbltiesField = new PointOfInteractionCapabilities8();
		private PointOfInteractionComponent9[] pOICmpntField = new PointOfInteractionComponent9[0];
		private AttendanceContext1Code attndncCntxtField = default(AttendanceContext1Code);
		private bool attndncCntxtFieldSpecified = default(bool);
		private string pOIDtTmField = default(string);
		private TerminalManagementDataSet25[] dataSetReqrdField = new TerminalManagementDataSet25[0];
		private TMSEvent6[] evtField = new TMSEvent6[0];
		private string[] errsField = new string[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public PointOfInteractionCapabilities8 POICpblties
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pOICpbltiesField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOICpbltiesField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pOICpbltiesField = new PointOfInteractionCapabilities8();
				}
				else
				{
					this.pOICpbltiesField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("POICmpnt")]
		public PointOfInteractionComponent9[] POICmpnt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.pOICmpntField == null)
								|| (this.pOICmpntField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOICmpntField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.pOICmpntField = new PointOfInteractionComponent9[0];
				}
				else
				{
					this.pOICmpntField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public AttendanceContext1Code AttndncCntxt
		{
			get
			{
				return this.attndncCntxtField;
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
		public bool AttndncCntxtSpecified
		{
			get
			{
				return this.attndncCntxtFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.attndncCntxtFieldSpecified = value;
			}
		}
		/// <remarks/>
		public string POIDtTm
		{
			get
			{
				return this.pOIDtTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIDtTmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DataSetReqrd")]
		public TerminalManagementDataSet25[] DataSetReqrd
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.dataSetReqrdField == null)
								|| (this.dataSetReqrdField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dataSetReqrdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.dataSetReqrdField = new TerminalManagementDataSet25[0];
				}
				else
				{
					this.dataSetReqrdField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Evt")]
		public TMSEvent6[] Evt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.evtField == null)
								|| (this.evtField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.evtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.evtField = new TMSEvent6[0];
				}
				else
				{
					this.evtField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Errs")]
		public string[] Errs
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.errsField == null)
								|| (this.errsField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.errsField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.errsField = new string[0];
				}
				else
				{
					this.errsField = value;
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
				return (this.XSD_HasBeenSetField || this.POICpblties.XSD_HasBeenSetProperty);
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
					this.POICpblties = null;
					this.POICmpnt = null;
					this.DataSetReqrd = null;
					this.Evt = null;
					this.AttndncCntxtSpecified = false;
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
				if ((this.POICpblties != null))
				{
					this.POICpblties.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int POICmpntSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.pOICmpntField == null))
			{
				return 0;
			}
			else
			{
				return this.pOICmpntField.Length;
			}
			// END ADDED BY XSD
		}
		public PointOfInteractionComponent9 POICmpntGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.pOICmpntField == default(PointOfInteractionComponent9[])))
				{
					return default(PointOfInteractionComponent9);
				}
				else
				{
					if (((this.pOICmpntField.Length - 1)
									>= index))
					{
						return this.pOICmpntField[index];
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
		public bool POICmpntSetItem(int index, PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.pOICmpntField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					this.pOICmpntField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool POICmpntAddItem(PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.pOICmpntField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOICmpntField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.pOICmpntField.Length); i = (i + 1))
					{
						array[i] = pOICmpntField[i];
					}
					array[i] = value;
					this.POICmpnt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool POICmpntRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.pOICmpntField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					if ((this.pOICmpntField.Length <= index))
					{
						return false;
					}
					else
					{
						PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOICmpntField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = pOICmpntField[i];
						}
						for (i = (i + 1); (i < this.pOICmpntField.Length); i = (i + 1))
						{
							array[i] = pOICmpntField[i];
						}
						this.POICmpnt = array;
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
		public int DataSetReqrdSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.dataSetReqrdField == null))
			{
				return 0;
			}
			else
			{
				return this.dataSetReqrdField.Length;
			}
			// END ADDED BY XSD
		}
		public TerminalManagementDataSet25 DataSetReqrdGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[])))
				{
					return default(TerminalManagementDataSet25);
				}
				else
				{
					if (((this.dataSetReqrdField.Length - 1)
									>= index))
					{
						return this.dataSetReqrdField[index];
					}
					else
					{
						return default(TerminalManagementDataSet25);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TerminalManagementDataSet25);
			}
			// END ADDED BY XSD
		}
		public bool DataSetReqrdSetItem(int index, TerminalManagementDataSet25 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[])))
				{
					return false;
				}
				else
				{
					this.dataSetReqrdField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DataSetReqrdAddItem(TerminalManagementDataSet25 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[])))
				{
					return false;
				}
				else
				{
					TerminalManagementDataSet25[] array = new TerminalManagementDataSet25[(this.dataSetReqrdField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.dataSetReqrdField.Length); i = (i + 1))
					{
						array[i] = dataSetReqrdField[i];
					}
					array[i] = value;
					this.DataSetReqrd = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DataSetReqrdRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[])))
				{
					return false;
				}
				else
				{
					if ((this.dataSetReqrdField.Length <= index))
					{
						return false;
					}
					else
					{
						TerminalManagementDataSet25[] array = new TerminalManagementDataSet25[(this.dataSetReqrdField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = dataSetReqrdField[i];
						}
						for (i = (i + 1); (i < this.dataSetReqrdField.Length); i = (i + 1))
						{
							array[i] = dataSetReqrdField[i];
						}
						this.DataSetReqrd = array;
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
		public int EvtSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.evtField == null))
			{
				return 0;
			}
			else
			{
				return this.evtField.Length;
			}
			// END ADDED BY XSD
		}
		public TMSEvent6 EvtGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.evtField == default(TMSEvent6[])))
				{
					return default(TMSEvent6);
				}
				else
				{
					if (((this.evtField.Length - 1)
									>= index))
					{
						return this.evtField[index];
					}
					else
					{
						return default(TMSEvent6);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TMSEvent6);
			}
			// END ADDED BY XSD
		}
		public bool EvtSetItem(int index, TMSEvent6 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.evtField == default(TMSEvent6[])))
				{
					return false;
				}
				else
				{
					this.evtField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool EvtAddItem(TMSEvent6 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.evtField == default(TMSEvent6[])))
				{
					return false;
				}
				else
				{
					TMSEvent6[] array = new TMSEvent6[(this.evtField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.evtField.Length); i = (i + 1))
					{
						array[i] = evtField[i];
					}
					array[i] = value;
					this.Evt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool EvtRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.evtField == default(TMSEvent6[])))
				{
					return false;
				}
				else
				{
					if ((this.evtField.Length <= index))
					{
						return false;
					}
					else
					{
						TMSEvent6[] array = new TMSEvent6[(this.evtField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = evtField[i];
						}
						for (i = (i + 1); (i < this.evtField.Length); i = (i + 1))
						{
							array[i] = evtField[i];
						}
						this.Evt = array;
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
		public int ErrsSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.errsField == null))
			{
				return 0;
			}
			else
			{
				return this.errsField.Length;
			}
			// END ADDED BY XSD
		}
		public string ErrsGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.errsField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.errsField.Length - 1)
									>= index))
					{
						return this.errsField[index];
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
		public bool ErrsSetItem(int index, string value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.errsField == default(string[])))
				{
					return false;
				}
				else
				{
					this.errsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool ErrsAddItem(string value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.errsField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.errsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.errsField.Length); i = (i + 1))
					{
						array[i] = errsField[i];
					}
					array[i] = value;
					this.Errs = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool ErrsRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.errsField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.errsField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.errsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = errsField[i];
						}
						for (i = (i + 1); (i < this.errsField.Length); i = (i + 1))
						{
							array[i] = errsField[i];
						}
						this.Errs = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("fcc948c1-3749-4ccf-8e4c-f4aa450d36e1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TerminalManagementDataSet25 : ITerminalManagementDataSet25
	{
		private DataSetIdentification7 idField = new DataSetIdentification7();
		private byte[] pOIChllngField = new byte[0];
		private byte[] tMChllngField = new byte[0];
		private CryptographicKey13 ssnKeyField = new CryptographicKey13();
		private byte[] dlgtnProofField = new byte[0];
		private ContentInformationType19 prtctdDlgtnProofField = new ContentInformationType19();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public DataSetIdentification7 Id
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.idField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.idField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.idField = new DataSetIdentification7();
				}
				else
				{
					this.idField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] POIChllng
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.pOIChllngField == null)
								|| (this.pOIChllngField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOIChllngField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.pOIChllngField = new byte[0];
				}
				else
				{
					this.pOIChllngField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] TMChllng
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.tMChllngField == null)
								|| (this.tMChllngField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.tMChllngField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.tMChllngField = new byte[0];
				}
				else
				{
					this.tMChllngField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public CryptographicKey13 SsnKey
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.ssnKeyField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.ssnKeyField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.ssnKeyField = new CryptographicKey13();
				}
				else
				{
					this.ssnKeyField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] DlgtnProof
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.dlgtnProofField == null)
								|| (this.dlgtnProofField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dlgtnProofField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.dlgtnProofField = new byte[0];
				}
				else
				{
					this.dlgtnProofField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ContentInformationType19 PrtctdDlgtnProof
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.prtctdDlgtnProofField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.prtctdDlgtnProofField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.prtctdDlgtnProofField = new ContentInformationType19();
				}
				else
				{
					this.prtctdDlgtnProofField = value;
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
				return (((this.XSD_HasBeenSetField || this.Id.XSD_HasBeenSetProperty)
								|| this.SsnKey.XSD_HasBeenSetProperty)
								|| this.PrtctdDlgtnProof.XSD_HasBeenSetProperty);
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
					this.Id = null;
					this.SsnKey = null;
					this.PrtctdDlgtnProof = null;
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
				if ((this.Id != null))
				{
					this.Id.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.SsnKey != null))
				{
					this.SsnKey.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.PrtctdDlgtnProof != null))
				{
					this.PrtctdDlgtnProof.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("9ed5b640-21c5-4517-9765-d871b66b6ac8")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TMSEvent6 : ITMSEvent6
	{
		private string tmStmpField = default(string);
		private TerminalManagementActionResult4Code rsltField = default(TerminalManagementActionResult4Code);
		private TMSActionIdentification5 actnIdField = new TMSActionIdentification5();
		private string addtlErrInfField = default(string);
		private string termnlMgrIdField = default(string);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string TmStmp
		{
			get
			{
				return this.tmStmpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.tmStmpField = value;
			}
		}
		/// <remarks/>
		public TerminalManagementActionResult4Code Rslt
		{
			get
			{
				return this.rsltField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public TMSActionIdentification5 ActnId
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.actnIdField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.actnIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.actnIdField = new TMSActionIdentification5();
				}
				else
				{
					this.actnIdField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string AddtlErrInf
		{
			get
			{
				return this.addtlErrInfField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.addtlErrInfField = value;
			}
		}
		/// <remarks/>
		public string TermnlMgrId
		{
			get
			{
				return this.termnlMgrIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.termnlMgrIdField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.ActnId.XSD_HasBeenSetProperty);
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
					this.ActnId = null;
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
				if ((this.ActnId != null))
				{
					this.ActnId.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TerminalManagementActionResult4Code
	{
		/// <remarks/>
		ACCD,
		/// <remarks/>
		CNTE,
		/// <remarks/>
		FMTE,
		/// <remarks/>
		INVC,
		/// <remarks/>
		LENE,
		/// <remarks/>
		OVER,
		/// <remarks/>
		MISS,
		/// <remarks/>
		NSUP,
		/// <remarks/>
		SIGE,
		/// <remarks/>
		SUCC,
		/// <remarks/>
		SYNE,
		/// <remarks/>
		TIMO,
		/// <remarks/>
		UKDT,
		/// <remarks/>
		UKRF,
		/// <remarks/>
		INDP,
		/// <remarks/>
		IDMP,
		/// <remarks/>
		DPRU,
		/// <remarks/>
		AERR,
		/// <remarks/>
		CMER,
		/// <remarks/>
		ULER,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d804f6ae-d812-4ab6-a3ba-a01058d9262c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TMSActionIdentification5 : ITMSActionIdentification5
	{
		private TerminalManagementAction4Code actnTpField = default(TerminalManagementAction4Code);
		private DataSetIdentification7 dataSetIdField = new DataSetIdentification7();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public TerminalManagementAction4Code ActnTp
		{
			get
			{
				return this.actnTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DataSetIdentification7 DataSetId
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dataSetIdField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dataSetIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dataSetIdField = new DataSetIdentification7();
				}
				else
				{
					this.dataSetIdField = value;
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
				return (this.XSD_HasBeenSetField || this.DataSetId.XSD_HasBeenSetProperty);
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
					this.DataSetId = null;
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
				if ((this.DataSetId != null))
				{
					this.DataSetId.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TerminalManagementAction4Code
	{
		/// <remarks/>
		DCTV,
		/// <remarks/>
		DELT,
		/// <remarks/>
		DWNL,
		/// <remarks/>
		INST,
		/// <remarks/>
		RSTR,
		/// <remarks/>
		UPLD,
		/// <remarks/>
		UPDT,
		/// <remarks/>
		BIND,
		/// <remarks/>
		RBND,
		/// <remarks/>
		UBND,
		/// <remarks/>
		ACTV,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("81104dd3-4d71-4090-af8d-d25a83147f4a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class HostStatus1 : IHostStatus1
	{
		private string acqrrIdField = default(string);
		private bool rchblField = default(bool);
		private bool rchblFieldSpecified = default(bool);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
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
		public bool Rchbl
		{
			get
			{
				return this.rchblField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rchblField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RchblSpecified = true
				this.RchblSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RchblSpecified
		{
			get
			{
				return this.rchblFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rchblFieldSpecified = value;
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
					this.RchblSpecified = false;
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
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("87a9e812-0d29-450a-86b9-3fba500a4a1f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOISessionManagementResponseV01 : ISaleToPOISessionManagementResponseV01
	{
		private Header37 hdrField = new Header37();
		private SessionManagementResponse2 ssnMgmtRspnField = new SessionManagementResponse2();
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
		public SessionManagementResponse2 SsnMgmtRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.ssnMgmtRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.ssnMgmtRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.ssnMgmtRspnField = new SessionManagementResponse2();
				}
				else
				{
					this.ssnMgmtRspnField = value;
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
								|| this.SsnMgmtRspn.XSD_HasBeenSetProperty)
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
					this.SsnMgmtRspn = null;
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
				if ((this.SsnMgmtRspn != null))
				{
					this.SsnMgmtRspn.XSD_Optimizing = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("627c7542-e212-401d-bfba-d6a807f46420")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SessionManagementResponse2 : ISessionManagementResponse2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private RetailerService5Code svcCnttField = default(RetailerService5Code);
		private LoginResponse1 lgnRspnField = new LoginResponse1();
		private DiagnosisResponse1 dgnssRspnField = new DiagnosisResponse1();
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
		public RetailerService5Code SvcCntt
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
		public LoginResponse1 LgnRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.lgnRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.lgnRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.lgnRspnField = new LoginResponse1();
				}
				else
				{
					this.lgnRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DiagnosisResponse1 DgnssRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dgnssRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dgnssRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dgnssRspnField = new DiagnosisResponse1();
				}
				else
				{
					this.dgnssRspnField = value;
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
								|| this.LgnRspn.XSD_HasBeenSetProperty)
								|| this.DgnssRspn.XSD_HasBeenSetProperty)
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
					this.LgnRspn = null;
					this.DgnssRspn = null;
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
				if ((this.LgnRspn != null))
				{
					this.LgnRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.DgnssRspn != null))
				{
					this.DgnssRspn.XSD_Optimizing = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum RetailerService5Code
	{
		/// <remarks/>
		SMIP,
		/// <remarks/>
		SMOP,
		/// <remarks/>
		SMDP,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("516faad8-11ef-4613-94db-7322864233c3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoginResponse1 : ILoginResponse1
	{
		private string pOIDtTmField = default(string);
		private PointOfInteractionComponent9[] pOISftwrField = new PointOfInteractionComponent9[0];
		private PointOfInteractionCapabilities8 pOICpbltiesField = new PointOfInteractionCapabilities8();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string POIDtTm
		{
			get
			{
				return this.pOIDtTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pOIDtTmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("POISftwr")]
		public PointOfInteractionComponent9[] POISftwr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.pOISftwrField == null)
								|| (this.pOISftwrField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOISftwrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.pOISftwrField = new PointOfInteractionComponent9[0];
				}
				else
				{
					this.pOISftwrField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public PointOfInteractionCapabilities8 POICpblties
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pOICpbltiesField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pOICpbltiesField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pOICpbltiesField = new PointOfInteractionCapabilities8();
				}
				else
				{
					this.pOICpbltiesField = value;
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
				return (this.XSD_HasBeenSetField || this.POICpblties.XSD_HasBeenSetProperty);
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
					this.POISftwr = null;
					this.POICpblties = null;
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
				if ((this.POICpblties != null))
				{
					this.POICpblties.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int POISftwrSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.pOISftwrField == null))
			{
				return 0;
			}
			else
			{
				return this.pOISftwrField.Length;
			}
			// END ADDED BY XSD
		}
		public PointOfInteractionComponent9 POISftwrGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.pOISftwrField == default(PointOfInteractionComponent9[])))
				{
					return default(PointOfInteractionComponent9);
				}
				else
				{
					if (((this.pOISftwrField.Length - 1)
									>= index))
					{
						return this.pOISftwrField[index];
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
		public bool POISftwrSetItem(int index, PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.pOISftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					this.pOISftwrField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool POISftwrAddItem(PointOfInteractionComponent9 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.pOISftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOISftwrField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.pOISftwrField.Length); i = (i + 1))
					{
						array[i] = pOISftwrField[i];
					}
					array[i] = value;
					this.POISftwr = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool POISftwrRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.pOISftwrField == default(PointOfInteractionComponent9[])))
				{
					return false;
				}
				else
				{
					if ((this.pOISftwrField.Length <= index))
					{
						return false;
					}
					else
					{
						PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOISftwrField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = pOISftwrField[i];
						}
						for (i = (i + 1); (i < this.pOISftwrField.Length); i = (i + 1))
						{
							array[i] = pOISftwrField[i];
						}
						this.POISftwr = array;
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
	[System.Runtime.InteropServices.GuidAttribute("cd9c9d42-d144-44d1-ab0c-072d5e9d9165")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDataSetIdentification7
	{
		/// <remarks/>
		[DispId(1)]
		string Nm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		DataSetCategory12Code Tp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Vrsn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string CreDtTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool CreDtTmSpecified
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
	}
	[System.Runtime.InteropServices.GuidAttribute("ce82496a-1be9-4ba5-b160-da1e9dccb69e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDiagnosisResponse1
	{
		/// <remarks/>
		[DispId(1)]
		string[] LggdSaleId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		StatusReportContent8 POISts
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		HostStatus1[] HstSts
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
		int LggdSaleIdSize();
		[DispId(6)]
		string LggdSaleIdGetItem(int index);
		[DispId(7)]
		bool LggdSaleIdSetItem(int index, string value);
		[DispId(8)]
		bool LggdSaleIdAddItem(string value);
		[DispId(9)]
		bool LggdSaleIdRemoveItem(int index);
		[DispId(10)]
		int HstStsSize();
		[DispId(11)]
		HostStatus1 HstStsGetItem(int index);
		[DispId(12)]
		bool HstStsSetItem(int index, HostStatus1 value);
		[DispId(13)]
		bool HstStsAddItem(HostStatus1 value);
		[DispId(14)]
		bool HstStsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("81d0b1fd-1a6a-475b-a9c7-49f9ffc7366f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStatusReportContent8
	{
		/// <remarks/>
		[DispId(1)]
		PointOfInteractionCapabilities8 POICpblties
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		PointOfInteractionComponent9[] POICmpnt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		AttendanceContext1Code AttndncCntxt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool AttndncCntxtSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string POIDtTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		TerminalManagementDataSet25[] DataSetReqrd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		TMSEvent6[] Evt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string[] Errs
		{
			get;
			set;
		}
		[DispId(9)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(10)]
		int POICmpntSize();
		[DispId(11)]
		PointOfInteractionComponent9 POICmpntGetItem(int index);
		[DispId(12)]
		bool POICmpntSetItem(int index, PointOfInteractionComponent9 value);
		[DispId(13)]
		bool POICmpntAddItem(PointOfInteractionComponent9 value);
		[DispId(14)]
		bool POICmpntRemoveItem(int index);
		[DispId(15)]
		int DataSetReqrdSize();
		[DispId(16)]
		TerminalManagementDataSet25 DataSetReqrdGetItem(int index);
		[DispId(17)]
		bool DataSetReqrdSetItem(int index, TerminalManagementDataSet25 value);
		[DispId(18)]
		bool DataSetReqrdAddItem(TerminalManagementDataSet25 value);
		[DispId(19)]
		bool DataSetReqrdRemoveItem(int index);
		[DispId(20)]
		int EvtSize();
		[DispId(21)]
		TMSEvent6 EvtGetItem(int index);
		[DispId(22)]
		bool EvtSetItem(int index, TMSEvent6 value);
		[DispId(23)]
		bool EvtAddItem(TMSEvent6 value);
		[DispId(24)]
		bool EvtRemoveItem(int index);
		[DispId(25)]
		int ErrsSize();
		[DispId(26)]
		string ErrsGetItem(int index);
		[DispId(27)]
		bool ErrsSetItem(int index, string value);
		[DispId(28)]
		bool ErrsAddItem(string value);
		[DispId(29)]
		bool ErrsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("67e547bb-4ea7-453b-8ddd-33a9617066dc")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITerminalManagementDataSet25
	{
		/// <remarks/>
		[DispId(1)]
		DataSetIdentification7 Id
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		byte[] POIChllng
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] TMChllng
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		CryptographicKey13 SsnKey
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] DlgtnProof
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		ContentInformationType19 PrtctdDlgtnProof
		{
			get;
			set;
		}
		[DispId(7)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("f4b06584-e20b-4351-a594-a1351928a961")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITMSEvent6
	{
		/// <remarks/>
		[DispId(1)]
		string TmStmp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		TerminalManagementActionResult4Code Rslt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TMSActionIdentification5 ActnId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string AddtlErrInf
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string TermnlMgrId
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
	}
	[System.Runtime.InteropServices.GuidAttribute("fd249b8e-876e-43f2-b48a-f25bb7377f0e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITMSActionIdentification5
	{
		/// <remarks/>
		[DispId(1)]
		TerminalManagementAction4Code ActnTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		DataSetIdentification7 DataSetId
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
	[System.Runtime.InteropServices.GuidAttribute("0ea313be-459c-49bb-a50d-5faf4b20fecd")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IHostStatus1
	{
		/// <remarks/>
		[DispId(1)]
		string AcqrrId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool Rchbl
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool RchblSpecified
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
	[System.Runtime.InteropServices.GuidAttribute("7fd7be47-7fe5-4fb8-b9ab-c73db0ff5f64")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOISessionManagementResponseV01
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
		SessionManagementResponse2 SsnMgmtRspn
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
	[System.Runtime.InteropServices.GuidAttribute("0c19baf5-8ca0-4fc9-9ed2-2d3219120a42")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISessionManagementResponse2
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
		RetailerService5Code SvcCntt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		LoginResponse1 LgnRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		DiagnosisResponse1 DgnssRspn
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
	[System.Runtime.InteropServices.GuidAttribute("724e5a62-da85-47e8-b232-f3fe52e62c57")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoginResponse1
	{
		/// <remarks/>
		[DispId(1)]
		string POIDtTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		PointOfInteractionComponent9[] POISftwr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		PointOfInteractionCapabilities8 POICpblties
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
		int POISftwrSize();
		[DispId(6)]
		PointOfInteractionComponent9 POISftwrGetItem(int index);
		[DispId(7)]
		bool POISftwrSetItem(int index, PointOfInteractionComponent9 value);
		[DispId(8)]
		bool POISftwrAddItem(PointOfInteractionComponent9 value);
		[DispId(9)]
		bool POISftwrRemoveItem(int index);
	}
}
#endif
