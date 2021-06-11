#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5272b96c-23e1-4dec-9c3d-e0f232d3adba")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceSendApplicationProtocolDataUnitCardReaderResponse1 : IDeviceSendApplicationProtocolDataUnitCardReaderResponse1
	{
		private byte[] dataField = new byte[0];
		private byte[] cardStsField = new byte[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] Data
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.dataField == null)
								|| (this.dataField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.dataField = new byte[0];
				}
				else
				{
					this.dataField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] CardSts
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.cardStsField == null)
								|| (this.cardStsField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.cardStsField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.cardStsField = new byte[0];
				}
				else
				{
					this.cardStsField = value;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("dc5877fb-cacb-4639-9c96-d45305fca7fa")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIMessageStatusResponseV01 : ISaleToPOIMessageStatusResponseV01
	{
		private Header37 hdrField = new Header37();
		private MessageStatusResponse2 stsRspnField = new MessageStatusResponse2();
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
		public MessageStatusResponse2 StsRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.stsRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.stsRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.stsRspnField = new MessageStatusResponse2();
				}
				else
				{
					this.stsRspnField = value;
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
								|| this.StsRspn.XSD_HasBeenSetProperty)
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
					this.StsRspn = null;
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
				if ((this.StsRspn != null))
				{
					this.StsRspn.XSD_Optimizing = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f1bf93cc-536c-4f4b-bf6f-45ded1a1ab31")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageStatusResponse2 : IMessageStatusResponse2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private MessageStatusResponseData2 msgStsRspnDataField = new MessageStatusResponseData2();
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
		public MessageStatusResponseData2 MsgStsRspnData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.msgStsRspnDataField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.msgStsRspnDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.msgStsRspnDataField = new MessageStatusResponseData2();
				}
				else
				{
					this.msgStsRspnDataField = value;
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
								|| this.MsgStsRspnData.XSD_HasBeenSetProperty)
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
					this.MsgStsRspnData = null;
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
				if ((this.MsgStsRspnData != null))
				{
					this.MsgStsRspnData.XSD_Optimizing = this.XSD_OptimizingField;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b75cd03e-29f0-4f0d-98f0-462c9d452bf6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageStatusResponseData2 : IMessageStatusResponseData2
	{
		private string xchgIdField = default(string);
		private GenericIdentification171 initgPtyField = new GenericIdentification171();
		private ResponseType9 txRspnField = new ResponseType9();
		private LoyaltyResponse1 rpeatdLltyRspnField = new LoyaltyResponse1();
		private PaymentResponse1 rpeatdPmtRspnField = new PaymentResponse1();
		private ReversalResponse1 rpeatdRvslRspnField = new ReversalResponse1();
		private StoredValueResponse2 rpeatdStordValRspnField = new StoredValueResponse2();
		private CardAcquisitionResponse1 rpeatdCardAcqstnRspnField = new CardAcquisitionResponse1();
		private DeviceSendApplicationProtocolDataUnitCardReaderResponse1 rpeatdSndApplPrtcolDataUnitCardRdrRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
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
		public ResponseType9 TxRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.txRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.txRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.txRspnField = new ResponseType9();
				}
				else
				{
					this.txRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public LoyaltyResponse1 RpeatdLltyRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdLltyRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdLltyRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdLltyRspnField = new LoyaltyResponse1();
				}
				else
				{
					this.rpeatdLltyRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public PaymentResponse1 RpeatdPmtRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdPmtRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdPmtRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdPmtRspnField = new PaymentResponse1();
				}
				else
				{
					this.rpeatdPmtRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ReversalResponse1 RpeatdRvslRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdRvslRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdRvslRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdRvslRspnField = new ReversalResponse1();
				}
				else
				{
					this.rpeatdRvslRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public StoredValueResponse2 RpeatdStordValRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdStordValRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdStordValRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdStordValRspnField = new StoredValueResponse2();
				}
				else
				{
					this.rpeatdStordValRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public CardAcquisitionResponse1 RpeatdCardAcqstnRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdCardAcqstnRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdCardAcqstnRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdCardAcqstnRspnField = new CardAcquisitionResponse1();
				}
				else
				{
					this.rpeatdCardAcqstnRspnField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
				}
				else
				{
					this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField = value;
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
				return ((((((((this.XSD_HasBeenSetField || this.InitgPty.XSD_HasBeenSetProperty)
								|| this.TxRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdLltyRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdPmtRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdRvslRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdStordValRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdCardAcqstnRspn.XSD_HasBeenSetProperty)
								|| this.RpeatdSndApplPrtcolDataUnitCardRdrRspn.XSD_HasBeenSetProperty);
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
					this.TxRspn = null;
					this.RpeatdLltyRspn = null;
					this.RpeatdPmtRspn = null;
					this.RpeatdRvslRspn = null;
					this.RpeatdStordValRspn = null;
					this.RpeatdCardAcqstnRspn = null;
					this.RpeatdSndApplPrtcolDataUnitCardRdrRspn = null;
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
				if ((this.InitgPty != null))
				{
					this.InitgPty.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.TxRspn != null))
				{
					this.TxRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdLltyRspn != null))
				{
					this.RpeatdLltyRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdPmtRspn != null))
				{
					this.RpeatdPmtRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdRvslRspn != null))
				{
					this.RpeatdRvslRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdStordValRspn != null))
				{
					this.RpeatdStordValRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdCardAcqstnRspn != null))
				{
					this.RpeatdCardAcqstnRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				if ((this.RpeatdSndApplPrtcolDataUnitCardRdrRspn != null))
				{
					this.RpeatdSndApplPrtcolDataUnitCardRdrRspn.XSD_Optimizing = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("c72b6f52-1122-450a-a767-be032cbdb868")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceSendApplicationProtocolDataUnitCardReaderResponse1
	{
		/// <remarks/>
		[DispId(1)]
		byte[] Data
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		byte[] CardSts
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
	[System.Runtime.InteropServices.GuidAttribute("803a8810-3f75-4ffc-a290-0df747f3e8a7")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIMessageStatusResponseV01
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
		MessageStatusResponse2 StsRspn
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
	[System.Runtime.InteropServices.GuidAttribute("462e403f-3dd1-4388-9b92-2842b720dbb8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageStatusResponse2
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
		MessageStatusResponseData2 MsgStsRspnData
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
	[System.Runtime.InteropServices.GuidAttribute("5e917aa2-81d5-4c35-a128-a42d6235c89f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageStatusResponseData2
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
		ResponseType9 TxRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		LoyaltyResponse1 RpeatdLltyRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		PaymentResponse1 RpeatdPmtRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		ReversalResponse1 RpeatdRvslRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		StoredValueResponse2 RpeatdStordValRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		CardAcquisitionResponse1 RpeatdCardAcqstnRspn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn
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
