#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c65486b5-f84d-4220-9204-faf0ada8ea89")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIMessageStatusRequestV01 : ISaleToPOIMessageStatusRequestV01
	{
		private Header37 hdrField = new Header37();
		private MessageStatusRequest2 stsReqField = new MessageStatusRequest2();
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
		public MessageStatusRequest2 StsReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.stsReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.stsReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.stsReqField = new MessageStatusRequest2();
				}
				else
				{
					this.stsReqField = value;
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
								|| this.StsReq.XSD_HasBeenSetProperty)
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
					this.StsReq = null;
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
				if ((this.StsReq != null))
				{
					this.StsReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("38f9c0f4-0c0c-4157-b6a6-49562952c449")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageStatusRequest2 : IMessageStatusRequest2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private MessageStatusRequestData1 msgStsReqDataField = new MessageStatusRequestData1();
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
		public MessageStatusRequestData1 MsgStsReqData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.msgStsReqDataField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.msgStsReqDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.msgStsReqDataField = new MessageStatusRequestData1();
				}
				else
				{
					this.msgStsReqDataField = value;
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
				return (((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
								|| this.Cntxt.XSD_HasBeenSetProperty)
								|| this.MsgStsReqData.XSD_HasBeenSetProperty);
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
					this.MsgStsReqData = null;
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
				if ((this.MsgStsReqData != null))
				{
					this.MsgStsReqData.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("fceedf2c-df64-4d30-9779-5a80d794e5ce")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageStatusRequestData1 : IMessageStatusRequestData1
	{
		private string xchgIdField = default(string);
		private GenericIdentification171 initgPtyField = new GenericIdentification171();
		private bool rctRprntFlgField = default(bool);
		private bool rctRprntFlgFieldSpecified = default(bool);
		private DocumentType7Code[] docQlfrField = new DocumentType7Code[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public string XchgId
		{
			get
			{
				return this.xchgIdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.xchgIdField = value;
			}
		}
		/// <remarks/>
		public GenericIdentification171 InitgPty
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.initgPtyField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.initgPtyField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.initgPtyField = new GenericIdentification171();
				}
				else
				{
					this.initgPtyField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool RctRprntFlg
		{
			get
			{
				return this.rctRprntFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rctRprntFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RctRprntFlgSpecified = true
				this.RctRprntFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RctRprntFlgSpecified
		{
			get
			{
				return this.rctRprntFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rctRprntFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocQlfr")]
		public DocumentType7Code[] DocQlfr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.docQlfrField == null)
								|| (this.docQlfrField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.docQlfrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.InitgPty.XSD_HasBeenSetProperty);
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
					this.InitgPty = null;
					this.RctRprntFlgSpecified = false;
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
				if ((this.InitgPty != null))
				{
					this.InitgPty.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int DocQlfrSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.docQlfrField == null))
			{
				return 0;
			}
			else
			{
				return this.docQlfrField.Length;
			}
			// END ADDED BY XSD
		}
		public DocumentType7Code DocQlfrGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.docQlfrField == default(DocumentType7Code[])))
				{
					return default(DocumentType7Code);
				}
				else
				{
					if (((this.docQlfrField.Length - 1)
									>= index))
					{
						return this.docQlfrField[index];
					}
					else
					{
						return default(DocumentType7Code);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(DocumentType7Code);
			}
			// END ADDED BY XSD
		}
		public bool DocQlfrSetItem(int index, DocumentType7Code value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.docQlfrField == default(DocumentType7Code[])))
				{
					return false;
				}
				else
				{
					this.docQlfrField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DocQlfrAddItem(DocumentType7Code value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.docQlfrField == default(DocumentType7Code[])))
				{
					return false;
				}
				else
				{
					DocumentType7Code[] array = new DocumentType7Code[(this.docQlfrField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.docQlfrField.Length); i = (i + 1))
					{
						array[i] = docQlfrField[i];
					}
					array[i] = value;
					this.DocQlfr = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DocQlfrRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.docQlfrField == default(DocumentType7Code[])))
				{
					return false;
				}
				else
				{
					if ((this.docQlfrField.Length <= index))
					{
						return false;
					}
					else
					{
						DocumentType7Code[] array = new DocumentType7Code[(this.docQlfrField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = docQlfrField[i];
						}
						for (i = (i + 1); (i < this.docQlfrField.Length); i = (i + 1))
						{
							array[i] = docQlfrField[i];
						}
						this.DocQlfr = array;
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
	[System.Runtime.InteropServices.GuidAttribute("e33bb314-5156-458b-bb88-e5f24a2d0441")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIMessageStatusRequestV01
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
		MessageStatusRequest2 StsReq
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
	[System.Runtime.InteropServices.GuidAttribute("207498ef-408e-4ea6-80fe-a4beb0a3460b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageStatusRequest2
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
		MessageStatusRequestData1 MsgStsReqData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		SupplementaryData1[] SplmtryData
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
		int SplmtryDataSize();
		[DispId(7)]
		SupplementaryData1 SplmtryDataGetItem(int index);
		[DispId(8)]
		bool SplmtryDataSetItem(int index, SupplementaryData1 value);
		[DispId(9)]
		bool SplmtryDataAddItem(SupplementaryData1 value);
		[DispId(10)]
		bool SplmtryDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("f6e0e349-8ca3-4bbc-9291-edb4704d2186")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageStatusRequestData1
	{
		/// <remarks/>
		[DispId(1)]
		string XchgId
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		GenericIdentification171 InitgPty
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool RctRprntFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool RctRprntFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		DocumentType7Code[] DocQlfr
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
		int DocQlfrSize();
		[DispId(8)]
		DocumentType7Code DocQlfrGetItem(int index);
		[DispId(9)]
		bool DocQlfrSetItem(int index, DocumentType7Code value);
		[DispId(10)]
		bool DocQlfrAddItem(DocumentType7Code value);
		[DispId(11)]
		bool DocQlfrRemoveItem(int index);
	}
}
#endif