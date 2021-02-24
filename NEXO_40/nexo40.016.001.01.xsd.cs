#if NEXO40
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bb806f88-f2fe-4fac-bc99-771bf31b7253")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceDisplayRequest1 : IDeviceDisplayRequest1
	{
		private ActionMessage6[] dispOutptField = new ActionMessage6[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DispOutpt")]
		public ActionMessage6[] DispOutpt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.dispOutptField == null)
								|| (this.dispOutptField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dispOutptField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.dispOutptField = new ActionMessage6[0];
				}
				else
				{
					this.dispOutptField = value;
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
					this.DispOutpt = null;
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
		public int DispOutptSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.dispOutptField == null))
			{
				return 0;
			}
			else
			{
				return this.dispOutptField.Length;
			}
			// END ADDED BY XSD
		}
		public ActionMessage6 DispOutptGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.dispOutptField == default(ActionMessage6[])))
				{
					return default(ActionMessage6);
				}
				else
				{
					if (((this.dispOutptField.Length - 1)
									>= index))
					{
						return this.dispOutptField[index];
					}
					else
					{
						return default(ActionMessage6);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(ActionMessage6);
			}
			// END ADDED BY XSD
		}
		public bool DispOutptSetItem(int index, ActionMessage6 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.dispOutptField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					this.dispOutptField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DispOutptAddItem(ActionMessage6 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.dispOutptField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					ActionMessage6[] array = new ActionMessage6[(this.dispOutptField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.dispOutptField.Length); i = (i + 1))
					{
						array[i] = dispOutptField[i];
					}
					array[i] = value;
					this.DispOutpt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DispOutptRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.dispOutptField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					if ((this.dispOutptField.Length <= index))
					{
						return false;
					}
					else
					{
						ActionMessage6[] array = new ActionMessage6[(this.dispOutptField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = dispOutptField[i];
						}
						for (i = (i + 1); (i < this.dispOutptField.Length); i = (i + 1))
						{
							array[i] = dispOutptField[i];
						}
						this.DispOutpt = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b6bc94af-a4f5-4c87-8feb-bd6042d9e180")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceInitialisationCardReaderRequest1 : IDeviceInitialisationCardReaderRequest1
	{
		private bool warmRstFlgField = default(bool);
		private bool warmRstFlgFieldSpecified = default(bool);
		private CardDataReading6Code[] forceNtryMdField = new CardDataReading6Code[0];
		private bool leavCardFlgField = default(bool);
		private bool leavCardFlgFieldSpecified = default(bool);
		private double maxWtgTmField = default(double);
		private bool maxWtgTmFieldSpecified = default(bool);
		private ActionMessage6 dispOutptField = new ActionMessage6();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public bool WarmRstFlg
		{
			get
			{
				return this.warmRstFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.warmRstFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - WarmRstFlgSpecified = true
				this.WarmRstFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool WarmRstFlgSpecified
		{
			get
			{
				return this.warmRstFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.warmRstFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ForceNtryMd")]
		public CardDataReading6Code[] ForceNtryMd
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.forceNtryMdField == null)
								|| (this.forceNtryMdField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.forceNtryMdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool LeavCardFlg
		{
			get
			{
				return this.leavCardFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.leavCardFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - LeavCardFlgSpecified = true
				this.LeavCardFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool LeavCardFlgSpecified
		{
			get
			{
				return this.leavCardFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.leavCardFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public double MaxWtgTm
		{
			get
			{
				return this.maxWtgTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
				this.MaxWtgTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MaxWtgTmSpecified
		{
			get
			{
				return this.maxWtgTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmFieldSpecified = value;
			}
		}
		/// <remarks/>
		public ActionMessage6 DispOutpt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dispOutptField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dispOutptField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dispOutptField = new ActionMessage6();
				}
				else
				{
					this.dispOutptField = value;
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
				return (this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty);
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
					this.DispOutpt = null;
					this.WarmRstFlgSpecified = false;
					this.LeavCardFlgSpecified = false;
					this.MaxWtgTmSpecified = false;
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
				if ((this.DispOutpt != null))
				{
					this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int ForceNtryMdSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.forceNtryMdField == null))
			{
				return 0;
			}
			else
			{
				return this.forceNtryMdField.Length;
			}
			// END ADDED BY XSD
		}
		public CardDataReading6Code ForceNtryMdGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.forceNtryMdField == default(CardDataReading6Code[])))
				{
					return default(CardDataReading6Code);
				}
				else
				{
					if (((this.forceNtryMdField.Length - 1)
									>= index))
					{
						return this.forceNtryMdField[index];
					}
					else
					{
						return default(CardDataReading6Code);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CardDataReading6Code);
			}
			// END ADDED BY XSD
		}
		public bool ForceNtryMdSetItem(int index, CardDataReading6Code value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.forceNtryMdField == default(CardDataReading6Code[])))
				{
					return false;
				}
				else
				{
					this.forceNtryMdField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool ForceNtryMdAddItem(CardDataReading6Code value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.forceNtryMdField == default(CardDataReading6Code[])))
				{
					return false;
				}
				else
				{
					CardDataReading6Code[] array = new CardDataReading6Code[(this.forceNtryMdField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.forceNtryMdField.Length); i = (i + 1))
					{
						array[i] = forceNtryMdField[i];
					}
					array[i] = value;
					this.ForceNtryMd = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool ForceNtryMdRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.forceNtryMdField == default(CardDataReading6Code[])))
				{
					return false;
				}
				else
				{
					if ((this.forceNtryMdField.Length <= index))
					{
						return false;
					}
					else
					{
						CardDataReading6Code[] array = new CardDataReading6Code[(this.forceNtryMdField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = forceNtryMdField[i];
						}
						for (i = (i + 1); (i < this.forceNtryMdField.Length); i = (i + 1))
						{
							array[i] = forceNtryMdField[i];
						}
						this.ForceNtryMd = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("728a785b-aac9-4026-8465-8edd318e0775")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceInputNotification1 : IDeviceInputNotification1
	{
		private string xchgIdField = default(string);
		private ActionMessage6 outptCnttField = new ActionMessage6();
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
		public ActionMessage6 OutptCntt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.outptCnttField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.outptCnttField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.outptCnttField = new ActionMessage6();
				}
				else
				{
					this.outptCnttField = value;
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
				return (this.XSD_HasBeenSetField || this.OutptCntt.XSD_HasBeenSetProperty);
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
					this.OutptCntt = null;
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
				if ((this.OutptCntt != null))
				{
					this.OutptCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7ac447c2-c337-4c0f-8a93-45afe3085b76")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceInputRequest1 : IDeviceInputRequest1
	{
		private ActionMessage6 dispOutptField = new ActionMessage6();
		private InputData1 inptDataField = new InputData1();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public ActionMessage6 DispOutpt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dispOutptField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dispOutptField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dispOutptField = new ActionMessage6();
				}
				else
				{
					this.dispOutptField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public InputData1 InptData
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.inptDataField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.inptDataField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.inptDataField = new InputData1();
				}
				else
				{
					this.inptDataField = value;
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
				return ((this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty)
								|| this.InptData.XSD_HasBeenSetProperty);
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
					this.DispOutpt = null;
					this.InptData = null;
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
				if ((this.DispOutpt != null))
				{
					this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.InptData != null))
				{
					this.InptData.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("3a7412ab-b7a8-463c-ae99-e73e8cfa6f0b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputData1 : IInputData1
	{
		private SaleCapabilities2Code dvcTpField = default(SaleCapabilities2Code);
		private InformationQualify1Code infQlfrField = default(InformationQualify1Code);
		private InputCommand1Code inptCmdField = default(InputCommand1Code);
		private bool ntfyCardInptFlgField = default(bool);
		private double maxInptTmField = default(double);
		private bool maxInptTmFieldSpecified = default(bool);
		private ActionMessage6 inptTxtField = new ActionMessage6();
		private bool imdtRspnFlgField = default(bool);
		private bool imdtRspnFlgFieldSpecified = default(bool);
		private bool waitUsrVldtnFlgField = default(bool);
		private bool waitUsrVldtnFlgFieldSpecified = default(bool);
		private bool beepKeyFlgField = default(bool);
		private bool beepKeyFlgFieldSpecified = default(bool);
		private bool gblCrrctnFlgField = default(bool);
		private bool gblCrrctnFlgFieldSpecified = default(bool);
		private bool dsblCclFlgField = default(bool);
		private bool dsblCclFlgFieldSpecified = default(bool);
		private bool dsblCrrctFlgField = default(bool);
		private bool dsblCrrctFlgFieldSpecified = default(bool);
		private bool dsblVldFlgField = default(bool);
		private bool dsblVldFlgFieldSpecified = default(bool);
		private bool menuBckFlgField = default(bool);
		private bool menuBckFlgFieldSpecified = default(bool);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public SaleCapabilities2Code DvcTp
		{
			get
			{
				return this.dvcTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public InformationQualify1Code InfQlfr
		{
			get
			{
				return this.infQlfrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public InputCommand1Code InptCmd
		{
			get
			{
				return this.inptCmdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool NtfyCardInptFlg
		{
			get
			{
				return this.ntfyCardInptFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.ntfyCardInptFlgField = value;
			}
		}
		/// <remarks/>
		public double MaxInptTm
		{
			get
			{
				return this.maxInptTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxInptTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxInptTmSpecified = true
				this.MaxInptTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MaxInptTmSpecified
		{
			get
			{
				return this.maxInptTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxInptTmFieldSpecified = value;
			}
		}
		/// <remarks/>
		public ActionMessage6 InptTxt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.inptTxtField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.inptTxtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.inptTxtField = new ActionMessage6();
				}
				else
				{
					this.inptTxtField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool ImdtRspnFlg
		{
			get
			{
				return this.imdtRspnFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.imdtRspnFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - ImdtRspnFlgSpecified = true
				this.ImdtRspnFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ImdtRspnFlgSpecified
		{
			get
			{
				return this.imdtRspnFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.imdtRspnFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool WaitUsrVldtnFlg
		{
			get
			{
				return this.waitUsrVldtnFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.waitUsrVldtnFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - WaitUsrVldtnFlgSpecified = true
				this.WaitUsrVldtnFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool WaitUsrVldtnFlgSpecified
		{
			get
			{
				return this.waitUsrVldtnFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.waitUsrVldtnFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool BeepKeyFlg
		{
			get
			{
				return this.beepKeyFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.beepKeyFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BeepKeyFlgSpecified = true
				this.BeepKeyFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BeepKeyFlgSpecified
		{
			get
			{
				return this.beepKeyFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.beepKeyFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool GblCrrctnFlg
		{
			get
			{
				return this.gblCrrctnFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.gblCrrctnFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - GblCrrctnFlgSpecified = true
				this.GblCrrctnFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GblCrrctnFlgSpecified
		{
			get
			{
				return this.gblCrrctnFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.gblCrrctnFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool DsblCclFlg
		{
			get
			{
				return this.dsblCclFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblCclFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblCclFlgSpecified = true
				this.DsblCclFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DsblCclFlgSpecified
		{
			get
			{
				return this.dsblCclFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblCclFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool DsblCrrctFlg
		{
			get
			{
				return this.dsblCrrctFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblCrrctFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblCrrctFlgSpecified = true
				this.DsblCrrctFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DsblCrrctFlgSpecified
		{
			get
			{
				return this.dsblCrrctFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblCrrctFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool DsblVldFlg
		{
			get
			{
				return this.dsblVldFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblVldFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblVldFlgSpecified = true
				this.DsblVldFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DsblVldFlgSpecified
		{
			get
			{
				return this.dsblVldFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.dsblVldFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool MenuBckFlg
		{
			get
			{
				return this.menuBckFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.menuBckFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MenuBckFlgSpecified = true
				this.MenuBckFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MenuBckFlgSpecified
		{
			get
			{
				return this.menuBckFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.menuBckFlgFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XSD_HasBeenSetProperty
		{
			get
			{
				// BEGIN ADDED BY XSD
				return (this.XSD_HasBeenSetField || this.InptTxt.XSD_HasBeenSetProperty);
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
					this.InptTxt = null;
					this.MaxInptTmSpecified = false;
					this.ImdtRspnFlgSpecified = false;
					this.WaitUsrVldtnFlgSpecified = false;
					this.BeepKeyFlgSpecified = false;
					this.GblCrrctnFlgSpecified = false;
					this.DsblCclFlgSpecified = false;
					this.DsblCrrctFlgSpecified = false;
					this.DsblVldFlgSpecified = false;
					this.MenuBckFlgSpecified = false;
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
				if ((this.InptTxt != null))
				{
					this.InptTxt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SaleCapabilities2Code
	{
		/// <remarks/>
		CHIN,
		/// <remarks/>
		CUIN,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum InputCommand1Code
	{
		/// <remarks/>
		DCSG,
		/// <remarks/>
		DGSG,
		/// <remarks/>
		GAKY,
		/// <remarks/>
		GCNF,
		/// <remarks/>
		GFKY,
		/// <remarks/>
		GMNE,
		/// <remarks/>
		PSWD,
		/// <remarks/>
		SITE,
		/// <remarks/>
		TXSG,
		/// <remarks/>
		HTML,
		/// <remarks/>
		SIGN,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("fd665284-a8af-4827-b95e-a029ec391024")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DevicePlaySoundRequest1 : IDevicePlaySoundRequest1
	{
		private ResponseMode1Code rspnMdField = default(ResponseMode1Code);
		private bool rspnMdFieldSpecified = default(bool);
		private SoundAction1Code soundActnField = default(SoundAction1Code);
		private double soundVolField = default(double);
		private bool soundVolFieldSpecified = default(bool);
		private SoundContent1 soundCnttField = new SoundContent1();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public ResponseMode1Code RspnMd
		{
			get
			{
				return this.rspnMdField;
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
		public bool RspnMdSpecified
		{
			get
			{
				return this.rspnMdFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.rspnMdFieldSpecified = value;
			}
		}
		/// <remarks/>
		public SoundAction1Code SoundActn
		{
			get
			{
				return this.soundActnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public double SoundVol
		{
			get
			{
				return this.soundVolField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.soundVolField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - SoundVolSpecified = true
				this.SoundVolSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SoundVolSpecified
		{
			get
			{
				return this.soundVolFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.soundVolFieldSpecified = value;
			}
		}
		/// <remarks/>
		public SoundContent1 SoundCntt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.soundCnttField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.soundCnttField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.soundCnttField = new SoundContent1();
				}
				else
				{
					this.soundCnttField = value;
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
				return (this.XSD_HasBeenSetField || this.SoundCntt.XSD_HasBeenSetProperty);
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
					this.SoundCntt = null;
					this.RspnMdSpecified = false;
					this.SoundVolSpecified = false;
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
				if ((this.SoundCntt != null))
				{
					this.SoundCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ResponseMode1Code
	{
		/// <remarks/>
		IMMD,
		/// <remarks/>
		NREQ,
		/// <remarks/>
		PEND,
		/// <remarks/>
		SEND,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SoundAction1Code
	{
		/// <remarks/>
		DVOL,
		/// <remarks/>
		STAS,
		/// <remarks/>
		STOS,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("46608a73-9d26-4f7f-9797-77310733ae51")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SoundContent1 : ISoundContent1
	{
		private SoundFormat1Code soundFrmtField = default(SoundFormat1Code);
		private string langField = default(string);
		private string soundRefField = default(string);
		private string txtField = default(string);
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public SoundFormat1Code SoundFrmt
		{
			get
			{
				return this.soundFrmtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string Lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.langField = value;
			}
		}
		/// <remarks/>
		public string SoundRef
		{
			get
			{
				return this.soundRefField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.soundRefField = value;
			}
		}
		/// <remarks/>
		public string Txt
		{
			get
			{
				return this.txtField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.txtField = value;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SoundFormat1Code
	{
		/// <remarks/>
		MSGR,
		/// <remarks/>
		SNDR,
		/// <remarks/>
		TEXT,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("622b07e9-b124-4dec-9b67-fa265612139b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DevicePoweroffCardReaderRequest1 : IDevicePoweroffCardReaderRequest1
	{
		private double pwrOffMaxWtgTmField = default(double);
		private bool pwrOffMaxWtgTmFieldSpecified = default(bool);
		private ActionMessage6 dispOutptField = new ActionMessage6();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public double PwrOffMaxWtgTm
		{
			get
			{
				return this.pwrOffMaxWtgTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pwrOffMaxWtgTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - PwrOffMaxWtgTmSpecified = true
				this.PwrOffMaxWtgTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PwrOffMaxWtgTmSpecified
		{
			get
			{
				return this.pwrOffMaxWtgTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pwrOffMaxWtgTmFieldSpecified = value;
			}
		}
		/// <remarks/>
		public ActionMessage6 DispOutpt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dispOutptField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dispOutptField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dispOutptField = new ActionMessage6();
				}
				else
				{
					this.dispOutptField = value;
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
				return (this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty);
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
					this.DispOutpt = null;
					this.PwrOffMaxWtgTmSpecified = false;
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
				if ((this.DispOutpt != null))
				{
					this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("99e0d8f8-ecfa-4999-93d4-5fb061a204d6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DevicePrintRequest1 : IDevicePrintRequest1
	{
		private DocumentType7Code docQlfrField = default(DocumentType7Code);
		private ResponseMode1Code rspnMdField = default(ResponseMode1Code);
		private bool intgrtdPrtFlgField = default(bool);
		private bool intgrtdPrtFlgFieldSpecified = default(bool);
		private bool reqrdSgntrFlgField = default(bool);
		private bool reqrdSgntrFlgFieldSpecified = default(bool);
		private ActionMessage6 outptCnttField = new ActionMessage6();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public DocumentType7Code DocQlfr
		{
			get
			{
				return this.docQlfrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public ResponseMode1Code RspnMd
		{
			get
			{
				return this.rspnMdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public bool IntgrtdPrtFlg
		{
			get
			{
				return this.intgrtdPrtFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.intgrtdPrtFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - IntgrtdPrtFlgSpecified = true
				this.IntgrtdPrtFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IntgrtdPrtFlgSpecified
		{
			get
			{
				return this.intgrtdPrtFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.intgrtdPrtFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool ReqrdSgntrFlg
		{
			get
			{
				return this.reqrdSgntrFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.reqrdSgntrFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - ReqrdSgntrFlgSpecified = true
				this.ReqrdSgntrFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ReqrdSgntrFlgSpecified
		{
			get
			{
				return this.reqrdSgntrFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.reqrdSgntrFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public ActionMessage6 OutptCntt
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.outptCnttField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.outptCnttField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.outptCnttField = new ActionMessage6();
				}
				else
				{
					this.outptCnttField = value;
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
				return (this.XSD_HasBeenSetField || this.OutptCntt.XSD_HasBeenSetProperty);
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
					this.OutptCntt = null;
					this.IntgrtdPrtFlgSpecified = false;
					this.ReqrdSgntrFlgSpecified = false;
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
				if ((this.OutptCntt != null))
				{
					this.OutptCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("01b89e70-3806-41f1-8aab-cb384b574697")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceRequest2 : IDeviceRequest2
	{
		private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
		private CardPaymentContext27 cntxtField = new CardPaymentContext27();
		private RetailerService8Code svcCnttField = default(RetailerService8Code);
		private ActionMessage6[] dispReqField = new ActionMessage6[0];
		private DeviceInputRequest1 inptReqField = new DeviceInputRequest1();
		private DevicePrintRequest1 prtReqField = new DevicePrintRequest1();
		private DevicePlaySoundRequest1 playSoundReqField = new DevicePlaySoundRequest1();
		private DeviceSecureInputRequest1 scrInptReqField = new DeviceSecureInputRequest1();
		private DeviceInitialisationCardReaderRequest1 initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest1();
		private DeviceSendApplicationProtocolDataUnitCardReaderRequest1 cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
		private DevicePoweroffCardReaderRequest1 pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest1();
		private DeviceTransmitMessageRequest1 trnsmssnReqField = new DeviceTransmitMessageRequest1();
		private DeviceInputNotification1 inptNtfctnField = new DeviceInputNotification1();
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
		public RetailerService8Code SvcCntt
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
		[System.Xml.Serialization.XmlArrayItemAttribute("DispOutpt", IsNullable = false)]
		public ActionMessage6[] DispReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.dispReqField == null)
								|| (this.dispReqField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dispReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.dispReqField = new ActionMessage6[0];
				}
				else
				{
					this.dispReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceInputRequest1 InptReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.inptReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.inptReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.inptReqField = new DeviceInputRequest1();
				}
				else
				{
					this.inptReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DevicePrintRequest1 PrtReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.prtReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.prtReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.prtReqField = new DevicePrintRequest1();
				}
				else
				{
					this.prtReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DevicePlaySoundRequest1 PlaySoundReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.playSoundReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.playSoundReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.playSoundReqField = new DevicePlaySoundRequest1();
				}
				else
				{
					this.playSoundReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceSecureInputRequest1 ScrInptReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.scrInptReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.scrInptReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.scrInptReqField = new DeviceSecureInputRequest1();
				}
				else
				{
					this.scrInptReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.initlstnCardRdrReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.initlstnCardRdrReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest1();
				}
				else
				{
					this.initlstnCardRdrReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.cardRdrAPDUReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.cardRdrAPDUReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
				}
				else
				{
					this.cardRdrAPDUReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.pwrOffCardRdrReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.pwrOffCardRdrReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest1();
				}
				else
				{
					this.pwrOffCardRdrReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceTransmitMessageRequest1 TrnsmssnReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.trnsmssnReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.trnsmssnReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.trnsmssnReqField = new DeviceTransmitMessageRequest1();
				}
				else
				{
					this.trnsmssnReqField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public DeviceInputNotification1 InptNtfctn
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.inptNtfctnField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.inptNtfctnField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.inptNtfctnField = new DeviceInputNotification1();
				}
				else
				{
					this.inptNtfctnField = value;
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
				return (((((((((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
								|| this.Cntxt.XSD_HasBeenSetProperty)
								|| this.InptReq.XSD_HasBeenSetProperty)
								|| this.PrtReq.XSD_HasBeenSetProperty)
								|| this.PlaySoundReq.XSD_HasBeenSetProperty)
								|| this.ScrInptReq.XSD_HasBeenSetProperty)
								|| this.InitlstnCardRdrReq.XSD_HasBeenSetProperty)
								|| this.CardRdrAPDUReq.XSD_HasBeenSetProperty)
								|| this.PwrOffCardRdrReq.XSD_HasBeenSetProperty)
								|| this.TrnsmssnReq.XSD_HasBeenSetProperty)
								|| this.InptNtfctn.XSD_HasBeenSetProperty);
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
					this.DispReq = null;
					this.InptReq = null;
					this.PrtReq = null;
					this.PlaySoundReq = null;
					this.ScrInptReq = null;
					this.InitlstnCardRdrReq = null;
					this.CardRdrAPDUReq = null;
					this.PwrOffCardRdrReq = null;
					this.TrnsmssnReq = null;
					this.InptNtfctn = null;
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
				if ((this.InptReq != null))
				{
					this.InptReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.PrtReq != null))
				{
					this.PrtReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.PlaySoundReq != null))
				{
					this.PlaySoundReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.ScrInptReq != null))
				{
					this.ScrInptReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.InitlstnCardRdrReq != null))
				{
					this.InitlstnCardRdrReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.CardRdrAPDUReq != null))
				{
					this.CardRdrAPDUReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.PwrOffCardRdrReq != null))
				{
					this.PwrOffCardRdrReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.TrnsmssnReq != null))
				{
					this.TrnsmssnReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.InptNtfctn != null))
				{
					this.InptNtfctn.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
		public int DispReqSize()
		{
			// BEGIN ADDED BY XSD - array Size accessor
			if ((this.dispReqField == null))
			{
				return 0;
			}
			else
			{
				return this.dispReqField.Length;
			}
			// END ADDED BY XSD
		}
		public ActionMessage6 DispReqGetItem(int index)
		{
			// BEGIN ADDED BY XSD - array GetItem accessor
			try
			{
				if ((this.dispReqField == default(ActionMessage6[])))
				{
					return default(ActionMessage6);
				}
				else
				{
					if (((this.dispReqField.Length - 1)
									>= index))
					{
						return this.dispReqField[index];
					}
					else
					{
						return default(ActionMessage6);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(ActionMessage6);
			}
			// END ADDED BY XSD
		}
		public bool DispReqSetItem(int index, ActionMessage6 value)
		{
			// BEGIN ADDED BY XSD - array SetItem accessor
			try
			{
				if ((this.dispReqField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					this.dispReqField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DispReqAddItem(ActionMessage6 value)
		{
			// BEGIN ADDED BY XSD - array AddItem accessor
			try
			{
				if ((this.dispReqField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					ActionMessage6[] array = new ActionMessage6[(this.dispReqField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.dispReqField.Length); i = (i + 1))
					{
						array[i] = dispReqField[i];
					}
					array[i] = value;
					this.DispReq = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
			// END ADDED BY XSD
		}
		public bool DispReqRemoveItem(int index)
		{
			// BEGIN ADDED BY XSD - array RemoveItem accessor
			try
			{
				if ((this.dispReqField == default(ActionMessage6[])))
				{
					return false;
				}
				else
				{
					if ((this.dispReqField.Length <= index))
					{
						return false;
					}
					else
					{
						ActionMessage6[] array = new ActionMessage6[(this.dispReqField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = dispReqField[i];
						}
						for (i = (i + 1); (i < this.dispReqField.Length); i = (i + 1))
						{
							array[i] = dispReqField[i];
						}
						this.DispReq = array;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum RetailerService8Code
	{
		/// <remarks/>
		DDYQ,
		/// <remarks/>
		DINQ,
		/// <remarks/>
		DPRQ,
		/// <remarks/>
		DSOQ,
		/// <remarks/>
		DSIQ,
		/// <remarks/>
		DCIQ,
		/// <remarks/>
		DCAQ,
		/// <remarks/>
		DCPQ,
		/// <remarks/>
		DCOQ,
		/// <remarks/>
		DINO,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c8547572-3b10-4c5d-ad68-a91491767509")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceSecureInputRequest1 : IDeviceSecureInputRequest1
	{
		private PINRequestType1Code pINReqTpField = default(PINRequestType1Code);
		private string pINVrfctnMtdField = default(string);
		private double maxWtgTmField = default(double);
		private bool maxWtgTmFieldSpecified = default(bool);
		private bool beepKeyFlgField = default(bool);
		private bool beepKeyFlgFieldSpecified = default(bool);
		private OnLinePIN6 crdhldrPINField = new OnLinePIN6();
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public PINRequestType1Code PINReqTp
		{
			get
			{
				return this.pINReqTpField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public string PINVrfctnMtd
		{
			get
			{
				return this.pINVrfctnMtdField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.pINVrfctnMtdField = value;
			}
		}
		/// <remarks/>
		public double MaxWtgTm
		{
			get
			{
				return this.maxWtgTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
				this.MaxWtgTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MaxWtgTmSpecified
		{
			get
			{
				return this.maxWtgTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmFieldSpecified = value;
			}
		}
		/// <remarks/>
		public bool BeepKeyFlg
		{
			get
			{
				return this.beepKeyFlgField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.beepKeyFlgField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BeepKeyFlgSpecified = true
				this.BeepKeyFlgSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BeepKeyFlgSpecified
		{
			get
			{
				return this.beepKeyFlgFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.beepKeyFlgFieldSpecified = value;
			}
		}
		/// <remarks/>
		public OnLinePIN6 CrdhldrPIN
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.crdhldrPINField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.crdhldrPINField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.crdhldrPINField = new OnLinePIN6();
				}
				else
				{
					this.crdhldrPINField = value;
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
				return (this.XSD_HasBeenSetField || this.CrdhldrPIN.XSD_HasBeenSetProperty);
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
					this.CrdhldrPIN = null;
					this.MaxWtgTmSpecified = false;
					this.BeepKeyFlgSpecified = false;
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
				if ((this.CrdhldrPIN != null))
				{
					this.CrdhldrPIN.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PINRequestType1Code
	{
		/// <remarks/>
		PIAE,
		/// <remarks/>
		PIAV,
		/// <remarks/>
		PIVO,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("93772b34-7202-45ae-b100-09ef72044aa0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceSendApplicationProtocolDataUnitCardReaderRequest1 : IDeviceSendApplicationProtocolDataUnitCardReaderRequest1
	{
		private byte[] clssField = new byte[0];
		private byte[] instrField = new byte[0];
		private byte[] param1Field = new byte[0];
		private byte[] param2Field = new byte[0];
		private byte[] dataField = new byte[0];
		private byte[] xpctdLngthField = new byte[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] Clss
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.clssField == null)
								|| (this.clssField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.clssField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.clssField = new byte[0];
				}
				else
				{
					this.clssField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] Instr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.instrField == null)
								|| (this.instrField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.instrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.instrField = new byte[0];
				}
				else
				{
					this.instrField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] Param1
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.param1Field == null)
								|| (this.param1Field.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.param1Field;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.param1Field = new byte[0];
				}
				else
				{
					this.param1Field = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] Param2
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.param2Field == null)
								|| (this.param2Field.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.param2Field;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.param2Field = new byte[0];
				}
				else
				{
					this.param2Field = value;
				}
				// END ADDED BY XSD
			}
		}
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
		public byte[] XpctdLngth
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.xpctdLngthField == null)
								|| (this.xpctdLngthField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.xpctdLngthField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.xpctdLngthField = new byte[0];
				}
				else
				{
					this.xpctdLngthField = value;
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
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("59d6beb8-c96b-4de8-ad32-2001080578ef")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DeviceTransmitMessageRequest1 : IDeviceTransmitMessageRequest1
	{
		private NetworkParameters5 dstnAdrField = new NetworkParameters5();
		private double maxTrnsmssnTmField = default(double);
		private double maxWtgTmField = default(double);
		private bool maxWtgTmFieldSpecified = default(bool);
		private byte[] msgToSndField = new byte[0];
		private bool XSD_HasBeenSetField = false;
		private bool XSD_OptimizingField = false;
		/// <remarks/>
		public NetworkParameters5 DstnAdr
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dstnAdrField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dstnAdrField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dstnAdrField = new NetworkParameters5();
				}
				else
				{
					this.dstnAdrField = value;
				}
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		public double MaxTrnsmssnTm
		{
			get
			{
				return this.maxTrnsmssnTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxTrnsmssnTmField = value;
			}
		}
		/// <remarks/>
		public double MaxWtgTm
		{
			get
			{
				return this.maxWtgTmField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmField = value;
				// BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
				this.MaxWtgTmSpecified = true;
				// END ADDED BY XSD
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MaxWtgTmSpecified
		{
			get
			{
				return this.maxWtgTmFieldSpecified;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				this.maxWtgTmFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
		public byte[] MsgToSnd
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.msgToSndField == null)
								|| (this.msgToSndField.Length == 0)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.msgToSndField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent array from being null
				if ((value == null))
				{
					this.msgToSndField = new byte[0];
				}
				else
				{
					this.msgToSndField = value;
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
				return (this.XSD_HasBeenSetField || this.DstnAdr.XSD_HasBeenSetProperty);
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
					this.DstnAdr = null;
					this.MaxWtgTmSpecified = false;
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
				if ((this.DstnAdr != null))
				{
					this.DstnAdr.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "3.0.0.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ec4443dc-75b4-4235-b844-5e408baa030c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIDeviceRequestV01 : ISaleToPOIDeviceRequestV01
	{
		private Header37 hdrField = new Header37();
		private DeviceRequest2 dvcReqField = new DeviceRequest2();
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
		public DeviceRequest2 DvcReq
		{
			get
			{
				// BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
				if (((this.XSD_OptimizingField == true)
								&& (this.dvcReqField.XSD_HasBeenSetProperty == false)))
				{
					return null;
				}
				// END ADDED BY XSD
				return this.dvcReqField;
			}
			set
			{
				// BEGIN ADDED BY XSD - indicate system value has been changed
				this.XSD_HasBeenSetField = true;
				// END ADDED BY XSD
				// BEGIN ADDED BY XSD - prevent class from being null
				if ((value == null))
				{
					this.dvcReqField = new DeviceRequest2();
				}
				else
				{
					this.dvcReqField = value;
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
								|| this.DvcReq.XSD_HasBeenSetProperty)
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
					this.DvcReq = null;
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
				if ((this.DvcReq != null))
				{
					this.DvcReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				if ((this.SctyTrlr != null))
				{
					this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
				}
				// END ADDED BY XSD
			}
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("34ccc5fb-ede9-4519-b39a-3b5007ca9718")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceDisplayRequest1
	{
		/// <remarks/>
		[DispId(1)]
		ActionMessage6[] DispOutpt
		{
			get;
			set;
		}
		[DispId(2)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
		[DispId(3)]
		int DispOutptSize();
		[DispId(4)]
		ActionMessage6 DispOutptGetItem(int index);
		[DispId(5)]
		bool DispOutptSetItem(int index, ActionMessage6 value);
		[DispId(6)]
		bool DispOutptAddItem(ActionMessage6 value);
		[DispId(7)]
		bool DispOutptRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("90148223-0167-457e-8dfe-a4cd7866bf7b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceInitialisationCardReaderRequest1
	{
		/// <remarks/>
		[DispId(1)]
		bool WarmRstFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool WarmRstFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		CardDataReading6Code[] ForceNtryMd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool LeavCardFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool LeavCardFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		double MaxWtgTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		bool MaxWtgTmSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		ActionMessage6 DispOutpt
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
		int ForceNtryMdSize();
		[DispId(11)]
		CardDataReading6Code ForceNtryMdGetItem(int index);
		[DispId(12)]
		bool ForceNtryMdSetItem(int index, CardDataReading6Code value);
		[DispId(13)]
		bool ForceNtryMdAddItem(CardDataReading6Code value);
		[DispId(14)]
		bool ForceNtryMdRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5b4cd89b-7b6d-436e-8ab1-46b611e2e678")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceInputNotification1
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
		ActionMessage6 OutptCntt
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
	[System.Runtime.InteropServices.GuidAttribute("bfdee5d6-5caa-447f-b38b-5f7961567cd2")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceInputRequest1
	{
		/// <remarks/>
		[DispId(1)]
		ActionMessage6 DispOutpt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		InputData1 InptData
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
	[System.Runtime.InteropServices.GuidAttribute("06b9ce30-fbcd-422e-9514-7d0faea93bca")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputData1
	{
		/// <remarks/>
		[DispId(1)]
		SaleCapabilities2Code DvcTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		InformationQualify1Code InfQlfr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		InputCommand1Code InptCmd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool NtfyCardInptFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		double MaxInptTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool MaxInptTmSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		ActionMessage6 InptTxt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		bool ImdtRspnFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		bool ImdtRspnFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool WaitUsrVldtnFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool WaitUsrVldtnFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool BeepKeyFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool BeepKeyFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		bool GblCrrctnFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		bool GblCrrctnFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		bool DsblCclFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		bool DsblCclFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		bool DsblCrrctFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		bool DsblCrrctFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		bool DsblVldFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		bool DsblVldFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		bool MenuBckFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		bool MenuBckFlgSpecified
		{
			get;
			set;
		}
		[DispId(24)]
		bool XSD_HasBeenSetProperty
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("6c37c5b9-68a5-4dee-a554-b57157bf2a15")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDevicePlaySoundRequest1
	{
		/// <remarks/>
		[DispId(1)]
		ResponseMode1Code RspnMd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool RspnMdSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SoundAction1Code SoundActn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		double SoundVol
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool SoundVolSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		SoundContent1 SoundCntt
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
	[System.Runtime.InteropServices.GuidAttribute("b143d524-34bd-4d65-81dc-d3b2ac434596")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISoundContent1
	{
		/// <remarks/>
		[DispId(1)]
		SoundFormat1Code SoundFrmt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		string Lang
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string SoundRef
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string Txt
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
	}
	[System.Runtime.InteropServices.GuidAttribute("8a687b3a-cb45-4cf8-9dad-ab775edd558c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDevicePoweroffCardReaderRequest1
	{
		/// <remarks/>
		[DispId(1)]
		double PwrOffMaxWtgTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		bool PwrOffMaxWtgTmSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		ActionMessage6 DispOutpt
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
	[System.Runtime.InteropServices.GuidAttribute("a45a7d01-d76c-44e1-b415-b36e0044d212")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDevicePrintRequest1
	{
		/// <remarks/>
		[DispId(1)]
		DocumentType7Code DocQlfr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		ResponseMode1Code RspnMd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool IntgrtdPrtFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool IntgrtdPrtFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool ReqrdSgntrFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool ReqrdSgntrFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		ActionMessage6 OutptCntt
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
	[System.Runtime.InteropServices.GuidAttribute("65047900-e6fa-4116-87ef-3e29d10b2860")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceRequest2
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
		RetailerService8Code SvcCntt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		ActionMessage6[] DispReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		DeviceInputRequest1 InptReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		DevicePrintRequest1 PrtReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		DevicePlaySoundRequest1 PlaySoundReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		DeviceSecureInputRequest1 ScrInptReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		DeviceTransmitMessageRequest1 TrnsmssnReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		DeviceInputNotification1 InptNtfctn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		SupplementaryData1[] SplmtryData
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
		int DispReqSize();
		[DispId(17)]
		ActionMessage6 DispReqGetItem(int index);
		[DispId(18)]
		bool DispReqSetItem(int index, ActionMessage6 value);
		[DispId(19)]
		bool DispReqAddItem(ActionMessage6 value);
		[DispId(20)]
		bool DispReqRemoveItem(int index);
		[DispId(21)]
		int SplmtryDataSize();
		[DispId(22)]
		SupplementaryData1 SplmtryDataGetItem(int index);
		[DispId(23)]
		bool SplmtryDataSetItem(int index, SupplementaryData1 value);
		[DispId(24)]
		bool SplmtryDataAddItem(SupplementaryData1 value);
		[DispId(25)]
		bool SplmtryDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("91e0e724-d174-45c0-b6f1-96c981abd15a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceSecureInputRequest1
	{
		/// <remarks/>
		[DispId(1)]
		PINRequestType1Code PINReqTp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		string PINVrfctnMtd
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double MaxWtgTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool MaxWtgTmSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool BeepKeyFlg
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool BeepKeyFlgSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		OnLinePIN6 CrdhldrPIN
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
	[System.Runtime.InteropServices.GuidAttribute("391172f5-8dc0-4de4-b9d3-d9f00227afe5")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceSendApplicationProtocolDataUnitCardReaderRequest1
	{
		/// <remarks/>
		[DispId(1)]
		byte[] Clss
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		byte[] Instr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] Param1
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		byte[] Param2
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] Data
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		byte[] XpctdLngth
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
	[System.Runtime.InteropServices.GuidAttribute("de7ead25-de24-4d49-994d-8929aa8eaaaa")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDeviceTransmitMessageRequest1
	{
		/// <remarks/>
		[DispId(1)]
		NetworkParameters5 DstnAdr
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(2)]
		double MaxTrnsmssnTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double MaxWtgTm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool MaxWtgTmSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] MsgToSnd
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
	[System.Runtime.InteropServices.GuidAttribute("b1af4762-3433-426a-bd59-289135575555")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIDeviceRequestV01
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
		DeviceRequest2 DvcReq
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
}
#endif
