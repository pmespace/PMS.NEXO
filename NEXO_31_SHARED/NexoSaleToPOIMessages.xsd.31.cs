#if NEXO31
namespace NEXO
{
	using System.Runtime.Serialization;
	using System.Runtime.InteropServices;
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum AlgorithmEnumeration
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-retail-cbc-mac")]
		idretailcbcmac,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-retail-cbc-mac-sha-256")]
		idretailcbcmacsha256,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-ukpt-wrap ")]
		idukptwrap,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-dukpt-wrap")]
		iddukptwrap,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("des-ede3-ecb")]
		desede3ecb,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("des-ede3-cbc")]
		desede3cbc,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-sha256")]
		idsha256,
		/// <remarks/>
		sha256WithRSAEncryption,
		/// <remarks/>
		rsaEncryption,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum AttributeTypeEnumeration
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-at-commonName")]
		idatcommonName,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-at-localityName")]
		idatlocalityName,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-at-organizationName")]
		idatorganizationName,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-at-organizationalUnitName")]
		idatorganizationalUnitName,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-at-countryName")]
		idatcountryName,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("09552739-e4aa-46bb-aaf8-8cf708e6a8e1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AuthenticatedDataType : IAuthenticatedDataType
	{
		internal object[] itemsField = new object[0];
		internal AlgorithmIdentifier mACAlgorithmField = new AlgorithmIdentifier();
		internal EncapsulatedContentType encapsulatedContentField = new EncapsulatedContentType();
		internal string versionField;
		internal byte[] mACField = new byte[0];
		internal bool xsdAuthenticatedDataTypeInitFlagField = false;
		public AuthenticatedDataType()
		{
			this.versionField = "v0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("KEK", typeof(KEKType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("KeyTransport", typeof(KeyTransportType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object[] Items
		{
			get
			{
				if (((this.itemsField == null)
								|| (this.itemsField.Length == 0)))
				{
					return null;
				}
				return this.itemsField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = true;
				this.itemsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier MACAlgorithm
		{
			get
			{
				return this.mACAlgorithmField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = true;
				this.mACAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncapsulatedContentType EncapsulatedContent
		{
			get
			{
				return this.encapsulatedContentField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = true;
				this.encapsulatedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v0")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] MAC
		{
			get
			{
				if (((this.mACField == null)
								|| (this.mACField.Length == 0)))
				{
					return null;
				}
				return this.mACField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = true;
				this.mACField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAuthenticatedDataTypeInitFlag
		{
			get
			{
				return this.xsdAuthenticatedDataTypeInitFlagField;
			}
			set
			{
				this.xsdAuthenticatedDataTypeInitFlagField = value;
			}
		}
		public int ItemsSize()
		{
			if ((this.itemsField == null))
			{
				return 0;
			}
			else
			{
				return this.itemsField.Length;
			}
		}
		public object ItemsGetItem(int index)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return default(object);
				}
				else
				{
					if (((this.itemsField.Length - 1)
									>= index))
					{
						return this.itemsField[index];
					}
					else
					{
						return default(object);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(object);
			}
		}
		public bool ItemsSetItem(int index, object value)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					this.itemsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ItemsAddItem(object value)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					object[] array = new object[(this.itemsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.itemsField.Length); i = (i + 1))
					{
						array[i] = itemsField[i];
					}
					array[i] = value;
					this.Items = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ItemsRemoveItem(int index)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					if ((this.itemsField.Length <= index))
					{
						return false;
					}
					else
					{
						object[] array = new object[(this.itemsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = itemsField[i];
						}
						for (i = (i + 1); (i < this.itemsField.Length); i = (i + 1))
						{
							array[i] = itemsField[i];
						}
						this.Items = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int MACSize()
		{
			if ((this.mACField == null))
			{
				return 0;
			}
			else
			{
				return this.mACField.Length;
			}
		}
		public byte MACGetItem(int index)
		{
			try
			{
				if ((this.mACField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.mACField.Length - 1)
									>= index))
					{
						return this.mACField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool MACSetItem(int index, byte value)
		{
			try
			{
				if ((this.mACField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.mACField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MACAddItem(byte value)
		{
			try
			{
				if ((this.mACField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.mACField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.mACField.Length); i = (i + 1))
					{
						array[i] = mACField[i];
					}
					array[i] = value;
					this.MAC = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MACRemoveItem(int index)
		{
			try
			{
				if ((this.mACField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.mACField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.mACField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = mACField[i];
						}
						for (i = (i + 1); (i < this.mACField.Length); i = (i + 1))
						{
							array[i] = mACField[i];
						}
						this.MAC = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("917489d3-2aa2-4877-b761-7dca8e2b16dc")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class KEKType : IKEKType
	{
		internal KEKIdentifierType kEKIdentifierField = new KEKIdentifierType();
		internal AlgorithmIdentifier keyEncryptionAlgorithmField = new AlgorithmIdentifier();
		internal string versionField;
		internal byte[] encryptedKeyField = new byte[0];
		internal bool xsdKEKTypeInitFlagField = false;
		public KEKType()
		{
			this.versionField = "v4";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public KEKIdentifierType KEKIdentifier
		{
			get
			{
				return this.kEKIdentifierField;
			}
			set
			{
				this.xsdKEKTypeInitFlagField = true;
				this.kEKIdentifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithmField;
			}
			set
			{
				this.xsdKEKTypeInitFlagField = true;
				this.keyEncryptionAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v4")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdKEKTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] EncryptedKey
		{
			get
			{
				if (((this.encryptedKeyField == null)
								|| (this.encryptedKeyField.Length == 0)))
				{
					return null;
				}
				return this.encryptedKeyField;
			}
			set
			{
				this.xsdKEKTypeInitFlagField = true;
				this.encryptedKeyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdKEKTypeInitFlag
		{
			get
			{
				return this.xsdKEKTypeInitFlagField;
			}
			set
			{
				this.xsdKEKTypeInitFlagField = value;
			}
		}
		public int EncryptedKeySize()
		{
			if ((this.encryptedKeyField == null))
			{
				return 0;
			}
			else
			{
				return this.encryptedKeyField.Length;
			}
		}
		public byte EncryptedKeyGetItem(int index)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.encryptedKeyField.Length - 1)
									>= index))
					{
						return this.encryptedKeyField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool EncryptedKeySetItem(int index, byte value)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.encryptedKeyField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedKeyAddItem(byte value)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.encryptedKeyField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.encryptedKeyField.Length); i = (i + 1))
					{
						array[i] = encryptedKeyField[i];
					}
					array[i] = value;
					this.EncryptedKey = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedKeyRemoveItem(int index)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.encryptedKeyField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.encryptedKeyField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = encryptedKeyField[i];
						}
						for (i = (i + 1); (i < this.encryptedKeyField.Length); i = (i + 1))
						{
							array[i] = encryptedKeyField[i];
						}
						this.EncryptedKey = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("721d6e74-6fc2-4f32-b2ff-7c308dfac2a0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class KEKIdentifierType : IKEKIdentifierType
	{
		internal string keyIdentifierField;
		internal string keyVersionField;
		internal byte[] derivationIdentifierField = new byte[0];
		internal bool xsdKEKIdentifierTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string KeyIdentifier
		{
			get
			{
				return this.keyIdentifierField;
			}
			set
			{
				this.xsdKEKIdentifierTypeInitFlagField = true;
				this.keyIdentifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string KeyVersion
		{
			get
			{
				return this.keyVersionField;
			}
			set
			{
				this.xsdKEKIdentifierTypeInitFlagField = true;
				this.keyVersionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] DerivationIdentifier
		{
			get
			{
				if (((this.derivationIdentifierField == null)
								|| (this.derivationIdentifierField.Length == 0)))
				{
					return null;
				}
				return this.derivationIdentifierField;
			}
			set
			{
				this.xsdKEKIdentifierTypeInitFlagField = true;
				this.derivationIdentifierField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdKEKIdentifierTypeInitFlag
		{
			get
			{
				return this.xsdKEKIdentifierTypeInitFlagField;
			}
			set
			{
				this.xsdKEKIdentifierTypeInitFlagField = value;
			}
		}
		public int DerivationIdentifierSize()
		{
			if ((this.derivationIdentifierField == null))
			{
				return 0;
			}
			else
			{
				return this.derivationIdentifierField.Length;
			}
		}
		public byte DerivationIdentifierGetItem(int index)
		{
			try
			{
				if ((this.derivationIdentifierField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.derivationIdentifierField.Length - 1)
									>= index))
					{
						return this.derivationIdentifierField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool DerivationIdentifierSetItem(int index, byte value)
		{
			try
			{
				if ((this.derivationIdentifierField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.derivationIdentifierField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DerivationIdentifierAddItem(byte value)
		{
			try
			{
				if ((this.derivationIdentifierField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.derivationIdentifierField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.derivationIdentifierField.Length); i = (i + 1))
					{
						array[i] = derivationIdentifierField[i];
					}
					array[i] = value;
					this.DerivationIdentifier = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DerivationIdentifierRemoveItem(int index)
		{
			try
			{
				if ((this.derivationIdentifierField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.derivationIdentifierField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.derivationIdentifierField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = derivationIdentifierField[i];
						}
						for (i = (i + 1); (i < this.derivationIdentifierField.Length); i = (i + 1))
						{
							array[i] = derivationIdentifierField[i];
						}
						this.DerivationIdentifier = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b708a23f-5532-4af2-b82c-eecfb7abef9e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DisplayResponseType : IDisplayResponseType
	{
		internal OutputResultType[] outputResultField = new OutputResultType[0];
		internal bool xsdDisplayResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OutputResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputResultType[] OutputResult
		{
			get
			{
				if (((this.outputResultField == null)
								|| (this.outputResultField.Length == 0)))
				{
					return null;
				}
				return this.outputResultField;
			}
			set
			{
				this.xsdDisplayResponseTypeInitFlagField = true;
				this.outputResultField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDisplayResponseTypeInitFlag
		{
			get
			{
				return this.xsdDisplayResponseTypeInitFlagField;
			}
			set
			{
				this.xsdDisplayResponseTypeInitFlagField = value;
			}
		}
		public int OutputResultSize()
		{
			if ((this.outputResultField == null))
			{
				return 0;
			}
			else
			{
				return this.outputResultField.Length;
			}
		}
		public OutputResultType OutputResultGetItem(int index)
		{
			try
			{
				if ((this.outputResultField == default(OutputResultType[])))
				{
					return default(OutputResultType);
				}
				else
				{
					if (((this.outputResultField.Length - 1)
									>= index))
					{
						return this.outputResultField[index];
					}
					else
					{
						return default(OutputResultType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(OutputResultType);
			}
		}
		public bool OutputResultSetItem(int index, OutputResultType value)
		{
			try
			{
				if ((this.outputResultField == default(OutputResultType[])))
				{
					return false;
				}
				else
				{
					this.outputResultField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputResultAddItem(OutputResultType value)
		{
			try
			{
				if ((this.outputResultField == default(OutputResultType[])))
				{
					return false;
				}
				else
				{
					OutputResultType[] array = new OutputResultType[(this.outputResultField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputResultField.Length); i = (i + 1))
					{
						array[i] = outputResultField[i];
					}
					array[i] = value;
					this.OutputResult = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputResultRemoveItem(int index)
		{
			try
			{
				if ((this.outputResultField == default(OutputResultType[])))
				{
					return false;
				}
				else
				{
					if ((this.outputResultField.Length <= index))
					{
						return false;
					}
					else
					{
						OutputResultType[] array = new OutputResultType[(this.outputResultField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputResultField[i];
						}
						for (i = (i + 1); (i < this.outputResultField.Length); i = (i + 1))
						{
							array[i] = outputResultField[i];
						}
						this.OutputResult = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("1e5fc5e0-5f51-4cd3-a4ea-57c9ed5244ca")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class OutputResultType : IOutputResultType
	{
		internal ResponseType responseField = new ResponseType();
		internal string deviceField;
		internal string infoQualifyField;
		internal bool xsdOutputResultTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdOutputResultTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Device
		{
			get
			{
				return this.deviceField;
			}
			set
			{
				this.xsdOutputResultTypeInitFlagField = true;
				this.deviceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InfoQualify
		{
			get
			{
				return this.infoQualifyField;
			}
			set
			{
				this.xsdOutputResultTypeInitFlagField = true;
				this.infoQualifyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdOutputResultTypeInitFlag
		{
			get
			{
				return this.xsdOutputResultTypeInitFlagField;
			}
			set
			{
				this.xsdOutputResultTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("67a47403-54f8-4d87-9bb1-3ab57bf032ab")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ResponseType : IResponseType
	{
		internal string additionalResponseField;
		internal string resultField;
		internal string errorConditionField;
		internal bool xsdResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AdditionalResponse
		{
			get
			{
				return this.additionalResponseField;
			}
			set
			{
				this.xsdResponseTypeInitFlagField = true;
				this.additionalResponseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Result
		{
			get
			{
				return this.resultField;
			}
			set
			{
				this.xsdResponseTypeInitFlagField = true;
				this.resultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ErrorCondition
		{
			get
			{
				return this.errorConditionField;
			}
			set
			{
				this.xsdResponseTypeInitFlagField = true;
				this.errorConditionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdResponseTypeInitFlag
		{
			get
			{
				return this.xsdResponseTypeInitFlagField;
			}
			set
			{
				this.xsdResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("88cb4a37-b1fe-40d4-829a-72ab56a2ec04")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DisplayRequestType : IDisplayRequestType
	{
		internal DisplayOutputType[] displayOutputField = new DisplayOutputType[0];
		internal bool xsdDisplayRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DisplayOutput", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType[] DisplayOutput
		{
			get
			{
				if (((this.displayOutputField == null)
								|| (this.displayOutputField.Length == 0)))
				{
					return null;
				}
				return this.displayOutputField;
			}
			set
			{
				this.xsdDisplayRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDisplayRequestTypeInitFlag
		{
			get
			{
				return this.xsdDisplayRequestTypeInitFlagField;
			}
			set
			{
				this.xsdDisplayRequestTypeInitFlagField = value;
			}
		}
		public int DisplayOutputSize()
		{
			if ((this.displayOutputField == null))
			{
				return 0;
			}
			else
			{
				return this.displayOutputField.Length;
			}
		}
		public DisplayOutputType DisplayOutputGetItem(int index)
		{
			try
			{
				if ((this.displayOutputField == default(DisplayOutputType[])))
				{
					return default(DisplayOutputType);
				}
				else
				{
					if (((this.displayOutputField.Length - 1)
									>= index))
					{
						return this.displayOutputField[index];
					}
					else
					{
						return default(DisplayOutputType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(DisplayOutputType);
			}
		}
		public bool DisplayOutputSetItem(int index, DisplayOutputType value)
		{
			try
			{
				if ((this.displayOutputField == default(DisplayOutputType[])))
				{
					return false;
				}
				else
				{
					this.displayOutputField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DisplayOutputAddItem(DisplayOutputType value)
		{
			try
			{
				if ((this.displayOutputField == default(DisplayOutputType[])))
				{
					return false;
				}
				else
				{
					DisplayOutputType[] array = new DisplayOutputType[(this.displayOutputField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.displayOutputField.Length); i = (i + 1))
					{
						array[i] = displayOutputField[i];
					}
					array[i] = value;
					this.DisplayOutput = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DisplayOutputRemoveItem(int index)
		{
			try
			{
				if ((this.displayOutputField == default(DisplayOutputType[])))
				{
					return false;
				}
				else
				{
					if ((this.displayOutputField.Length <= index))
					{
						return false;
					}
					else
					{
						DisplayOutputType[] array = new DisplayOutputType[(this.displayOutputField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = displayOutputField[i];
						}
						for (i = (i + 1); (i < this.displayOutputField.Length); i = (i + 1))
						{
							array[i] = displayOutputField[i];
						}
						this.DisplayOutput = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c1ecc289-e954-478a-a1d0-3ed95bf7a68e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DisplayOutputType : IDisplayOutputType
	{
		internal OutputContentType outputContentField = new OutputContentType();
		internal MenuEntryType[] menuEntryField = new MenuEntryType[0];
		internal byte[] outputSignatureField = new byte[0];
		internal bool responseRequiredFlagField;
		internal string minimumDisplayTimeField;
		internal string deviceField;
		internal string infoQualifyField;
		internal bool xsdDisplayOutputTypeInitFlagField = false;
		public DisplayOutputType()
		{
			this.responseRequiredFlagField = true;
			this.minimumDisplayTimeField = "0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputContentType OutputContent
		{
			get
			{
				return this.outputContentField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.outputContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MenuEntry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MenuEntryType[] MenuEntry
		{
			get
			{
				if (((this.menuEntryField == null)
								|| (this.menuEntryField.Length == 0)))
				{
					return null;
				}
				return this.menuEntryField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.menuEntryField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] OutputSignature
		{
			get
			{
				if (((this.outputSignatureField == null)
								|| (this.outputSignatureField.Length == 0)))
				{
					return null;
				}
				return this.outputSignatureField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.outputSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool ResponseRequiredFlag
		{
			get
			{
				return this.responseRequiredFlagField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.responseRequiredFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		[System.ComponentModel.DefaultValueAttribute("0")]
		public string MinimumDisplayTime
		{
			get
			{
				return this.minimumDisplayTimeField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.minimumDisplayTimeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Device
		{
			get
			{
				return this.deviceField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.deviceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InfoQualify
		{
			get
			{
				return this.infoQualifyField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = true;
				this.infoQualifyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDisplayOutputTypeInitFlag
		{
			get
			{
				return this.xsdDisplayOutputTypeInitFlagField;
			}
			set
			{
				this.xsdDisplayOutputTypeInitFlagField = value;
			}
		}
		public int MenuEntrySize()
		{
			if ((this.menuEntryField == null))
			{
				return 0;
			}
			else
			{
				return this.menuEntryField.Length;
			}
		}
		public MenuEntryType MenuEntryGetItem(int index)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return default(MenuEntryType);
				}
				else
				{
					if (((this.menuEntryField.Length - 1)
									>= index))
					{
						return this.menuEntryField[index];
					}
					else
					{
						return default(MenuEntryType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(MenuEntryType);
			}
		}
		public bool MenuEntrySetItem(int index, MenuEntryType value)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					this.menuEntryField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MenuEntryAddItem(MenuEntryType value)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					MenuEntryType[] array = new MenuEntryType[(this.menuEntryField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.menuEntryField.Length); i = (i + 1))
					{
						array[i] = menuEntryField[i];
					}
					array[i] = value;
					this.MenuEntry = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MenuEntryRemoveItem(int index)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					if ((this.menuEntryField.Length <= index))
					{
						return false;
					}
					else
					{
						MenuEntryType[] array = new MenuEntryType[(this.menuEntryField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = menuEntryField[i];
						}
						for (i = (i + 1); (i < this.menuEntryField.Length); i = (i + 1))
						{
							array[i] = menuEntryField[i];
						}
						this.MenuEntry = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int OutputSignatureSize()
		{
			if ((this.outputSignatureField == null))
			{
				return 0;
			}
			else
			{
				return this.outputSignatureField.Length;
			}
		}
		public byte OutputSignatureGetItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.outputSignatureField.Length - 1)
									>= index))
					{
						return this.outputSignatureField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool OutputSignatureSetItem(int index, byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.outputSignatureField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureAddItem(byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.outputSignatureField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputSignatureField.Length); i = (i + 1))
					{
						array[i] = outputSignatureField[i];
					}
					array[i] = value;
					this.OutputSignature = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureRemoveItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.outputSignatureField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.outputSignatureField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						for (i = (i + 1); (i < this.outputSignatureField.Length); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						this.OutputSignature = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("1fce0736-97b9-4334-a05c-e85fb06263f3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class OutputContentType : IOutputContentType
	{
		internal PredefinedContentType predefinedContentField = new PredefinedContentType();
		internal OutputTextType[] outputTextField = new OutputTextType[0];
		internal byte[] outputXHTMLField = new byte[0];
		internal OutputBarcodeType outputBarcodeField = new OutputBarcodeType();
		internal string outputFormatField;
		internal bool xsdOutputContentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PredefinedContentType PredefinedContent
		{
			get
			{
				return this.predefinedContentField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = true;
				this.predefinedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OutputText", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputTextType[] OutputText
		{
			get
			{
				if (((this.outputTextField == null)
								|| (this.outputTextField.Length == 0)))
				{
					return null;
				}
				return this.outputTextField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = true;
				this.outputTextField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] OutputXHTML
		{
			get
			{
				if (((this.outputXHTMLField == null)
								|| (this.outputXHTMLField.Length == 0)))
				{
					return null;
				}
				return this.outputXHTMLField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = true;
				this.outputXHTMLField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputBarcodeType OutputBarcode
		{
			get
			{
				return this.outputBarcodeField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = true;
				this.outputBarcodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OutputFormat
		{
			get
			{
				return this.outputFormatField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = true;
				this.outputFormatField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdOutputContentTypeInitFlag
		{
			get
			{
				return this.xsdOutputContentTypeInitFlagField;
			}
			set
			{
				this.xsdOutputContentTypeInitFlagField = value;
			}
		}
		public int OutputTextSize()
		{
			if ((this.outputTextField == null))
			{
				return 0;
			}
			else
			{
				return this.outputTextField.Length;
			}
		}
		public OutputTextType OutputTextGetItem(int index)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return default(OutputTextType);
				}
				else
				{
					if (((this.outputTextField.Length - 1)
									>= index))
					{
						return this.outputTextField[index];
					}
					else
					{
						return default(OutputTextType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(OutputTextType);
			}
		}
		public bool OutputTextSetItem(int index, OutputTextType value)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					this.outputTextField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputTextAddItem(OutputTextType value)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					OutputTextType[] array = new OutputTextType[(this.outputTextField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputTextField.Length); i = (i + 1))
					{
						array[i] = outputTextField[i];
					}
					array[i] = value;
					this.OutputText = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputTextRemoveItem(int index)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					if ((this.outputTextField.Length <= index))
					{
						return false;
					}
					else
					{
						OutputTextType[] array = new OutputTextType[(this.outputTextField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputTextField[i];
						}
						for (i = (i + 1); (i < this.outputTextField.Length); i = (i + 1))
						{
							array[i] = outputTextField[i];
						}
						this.OutputText = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int OutputXHTMLSize()
		{
			if ((this.outputXHTMLField == null))
			{
				return 0;
			}
			else
			{
				return this.outputXHTMLField.Length;
			}
		}
		public byte OutputXHTMLGetItem(int index)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.outputXHTMLField.Length - 1)
									>= index))
					{
						return this.outputXHTMLField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool OutputXHTMLSetItem(int index, byte value)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.outputXHTMLField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputXHTMLAddItem(byte value)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.outputXHTMLField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputXHTMLField.Length); i = (i + 1))
					{
						array[i] = outputXHTMLField[i];
					}
					array[i] = value;
					this.OutputXHTML = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputXHTMLRemoveItem(int index)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.outputXHTMLField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.outputXHTMLField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputXHTMLField[i];
						}
						for (i = (i + 1); (i < this.outputXHTMLField.Length); i = (i + 1))
						{
							array[i] = outputXHTMLField[i];
						}
						this.OutputXHTML = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f7e52c57-cf50-48cb-8a2f-a5f1707c04df")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PredefinedContentType : IPredefinedContentType
	{
		internal string referenceIDField;
		internal string languageField;
		internal bool xsdPredefinedContentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ReferenceID
		{
			get
			{
				return this.referenceIDField;
			}
			set
			{
				this.xsdPredefinedContentTypeInitFlagField = true;
				this.referenceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.xsdPredefinedContentTypeInitFlagField = true;
				this.languageField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPredefinedContentTypeInitFlag
		{
			get
			{
				return this.xsdPredefinedContentTypeInitFlagField;
			}
			set
			{
				this.xsdPredefinedContentTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("60fd4f61-a2e4-4b84-af14-c535b9c6bc05")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class OutputTextType : IOutputTextType
	{
		internal string characterSetField;
		internal string fontField;
		internal string startRowField;
		internal string startColumnField;
		internal string colorField;
		internal string characterWidthField;
		internal string characterHeightField;
		internal string characterStyleField;
		internal string alignmentField;
		internal bool endOfLineFlagField;
		internal string valueField;
		internal bool xsdOutputTextTypeInitFlagField = false;
		public OutputTextType()
		{
			this.endOfLineFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string CharacterSet
		{
			get
			{
				return this.characterSetField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.characterSetField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.fontField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string StartRow
		{
			get
			{
				return this.startRowField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.startRowField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string StartColumn
		{
			get
			{
				return this.startColumnField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.startColumnField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.colorField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CharacterWidth
		{
			get
			{
				return this.characterWidthField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.characterWidthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CharacterHeight
		{
			get
			{
				return this.characterHeightField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.characterHeightField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CharacterStyle
		{
			get
			{
				return this.characterStyleField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.characterStyleField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Alignment
		{
			get
			{
				return this.alignmentField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.alignmentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool EndOfLineFlag
		{
			get
			{
				return this.endOfLineFlagField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.endOfLineFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdOutputTextTypeInitFlag
		{
			get
			{
				return this.xsdOutputTextTypeInitFlagField;
			}
			set
			{
				this.xsdOutputTextTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("38b0c7d5-4a88-42c3-9326-4db93421af1c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class OutputBarcodeType : IOutputBarcodeType
	{
		internal string barcodeValueField;
		internal byte[] qRCodeBinaryValueField = new byte[0];
		internal string barcodeTypeField;
		internal string qRCodeVersionField;
		internal QRCodeEncodingModeEnumeration qRCodeEncodingModeField = new QRCodeEncodingModeEnumeration();
		internal bool qRCodeEncodingModeFieldSpecified;
		internal QRCodeErrorCorrectionEnumeration qRCodeErrorCorrectionField = new QRCodeErrorCorrectionEnumeration();
		internal bool qRCodeErrorCorrectionFieldSpecified;
		internal bool xsdOutputBarcodeTypeInitFlagField = false;
		public OutputBarcodeType()
		{
			this.barcodeTypeField = "EAN13";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string BarcodeValue
		{
			get
			{
				return this.barcodeValueField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.barcodeValueField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] QRCodeBinaryValue
		{
			get
			{
				if (((this.qRCodeBinaryValueField == null)
								|| (this.qRCodeBinaryValueField.Length == 0)))
				{
					return null;
				}
				return this.qRCodeBinaryValueField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeBinaryValueField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("EAN13")]
		public string BarcodeType
		{
			get
			{
				return this.barcodeTypeField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.barcodeTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string QRCodeVersion
		{
			get
			{
				return this.qRCodeVersionField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeVersionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public QRCodeEncodingModeEnumeration QRCodeEncodingMode
		{
			get
			{
				return this.qRCodeEncodingModeField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeEncodingModeField = value;
				this.QRCodeEncodingModeSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool QRCodeEncodingModeSpecified
		{
			get
			{
				return this.qRCodeEncodingModeFieldSpecified;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeEncodingModeFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public QRCodeErrorCorrectionEnumeration QRCodeErrorCorrection
		{
			get
			{
				return this.qRCodeErrorCorrectionField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeErrorCorrectionField = value;
				this.QRCodeErrorCorrectionSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool QRCodeErrorCorrectionSpecified
		{
			get
			{
				return this.qRCodeErrorCorrectionFieldSpecified;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = true;
				this.qRCodeErrorCorrectionFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdOutputBarcodeTypeInitFlag
		{
			get
			{
				return this.xsdOutputBarcodeTypeInitFlagField;
			}
			set
			{
				this.xsdOutputBarcodeTypeInitFlagField = value;
			}
		}
		public int QRCodeBinaryValueSize()
		{
			if ((this.qRCodeBinaryValueField == null))
			{
				return 0;
			}
			else
			{
				return this.qRCodeBinaryValueField.Length;
			}
		}
		public byte QRCodeBinaryValueGetItem(int index)
		{
			try
			{
				if ((this.qRCodeBinaryValueField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.qRCodeBinaryValueField.Length - 1)
									>= index))
					{
						return this.qRCodeBinaryValueField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool QRCodeBinaryValueSetItem(int index, byte value)
		{
			try
			{
				if ((this.qRCodeBinaryValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.qRCodeBinaryValueField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool QRCodeBinaryValueAddItem(byte value)
		{
			try
			{
				if ((this.qRCodeBinaryValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.qRCodeBinaryValueField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.qRCodeBinaryValueField.Length); i = (i + 1))
					{
						array[i] = qRCodeBinaryValueField[i];
					}
					array[i] = value;
					this.QRCodeBinaryValue = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool QRCodeBinaryValueRemoveItem(int index)
		{
			try
			{
				if ((this.qRCodeBinaryValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.qRCodeBinaryValueField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.qRCodeBinaryValueField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = qRCodeBinaryValueField[i];
						}
						for (i = (i + 1); (i < this.qRCodeBinaryValueField.Length); i = (i + 1))
						{
							array[i] = qRCodeBinaryValueField[i];
						}
						this.QRCodeBinaryValue = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum QRCodeEncodingModeEnumeration
	{
		/// <remarks/>
		Numeric,
		/// <remarks/>
		Alphanumeric,
		/// <remarks/>
		Binary,
		/// <remarks/>
		Kanji,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum QRCodeErrorCorrectionEnumeration
	{
		/// <remarks/>
		L,
		/// <remarks/>
		M,
		/// <remarks/>
		Q,
		/// <remarks/>
		H,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7d079288-fed3-43e6-9099-b96629ef16ba")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MenuEntryType : IMenuEntryType
	{
		internal PredefinedContentType predefinedContentField = new PredefinedContentType();
		internal OutputTextType[] outputTextField = new OutputTextType[0];
		internal byte[] outputXHTMLField = new byte[0];
		internal string menuEntryTagField;
		internal string outputFormatField;
		internal bool defaultSelectedFlagField;
		internal bool xsdMenuEntryTypeInitFlagField = false;
		public MenuEntryType()
		{
			this.menuEntryTagField = "Selectable";
			this.defaultSelectedFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PredefinedContentType PredefinedContent
		{
			get
			{
				return this.predefinedContentField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.predefinedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OutputText", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputTextType[] OutputText
		{
			get
			{
				if (((this.outputTextField == null)
								|| (this.outputTextField.Length == 0)))
				{
					return null;
				}
				return this.outputTextField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.outputTextField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] OutputXHTML
		{
			get
			{
				if (((this.outputXHTMLField == null)
								|| (this.outputXHTMLField.Length == 0)))
				{
					return null;
				}
				return this.outputXHTMLField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.outputXHTMLField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Selectable")]
		public string MenuEntryTag
		{
			get
			{
				return this.menuEntryTagField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.menuEntryTagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OutputFormat
		{
			get
			{
				return this.outputFormatField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.outputFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DefaultSelectedFlag
		{
			get
			{
				return this.defaultSelectedFlagField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = true;
				this.defaultSelectedFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdMenuEntryTypeInitFlag
		{
			get
			{
				return this.xsdMenuEntryTypeInitFlagField;
			}
			set
			{
				this.xsdMenuEntryTypeInitFlagField = value;
			}
		}
		public int OutputTextSize()
		{
			if ((this.outputTextField == null))
			{
				return 0;
			}
			else
			{
				return this.outputTextField.Length;
			}
		}
		public OutputTextType OutputTextGetItem(int index)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return default(OutputTextType);
				}
				else
				{
					if (((this.outputTextField.Length - 1)
									>= index))
					{
						return this.outputTextField[index];
					}
					else
					{
						return default(OutputTextType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(OutputTextType);
			}
		}
		public bool OutputTextSetItem(int index, OutputTextType value)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					this.outputTextField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputTextAddItem(OutputTextType value)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					OutputTextType[] array = new OutputTextType[(this.outputTextField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputTextField.Length); i = (i + 1))
					{
						array[i] = outputTextField[i];
					}
					array[i] = value;
					this.OutputText = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputTextRemoveItem(int index)
		{
			try
			{
				if ((this.outputTextField == default(OutputTextType[])))
				{
					return false;
				}
				else
				{
					if ((this.outputTextField.Length <= index))
					{
						return false;
					}
					else
					{
						OutputTextType[] array = new OutputTextType[(this.outputTextField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputTextField[i];
						}
						for (i = (i + 1); (i < this.outputTextField.Length); i = (i + 1))
						{
							array[i] = outputTextField[i];
						}
						this.OutputText = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int OutputXHTMLSize()
		{
			if ((this.outputXHTMLField == null))
			{
				return 0;
			}
			else
			{
				return this.outputXHTMLField.Length;
			}
		}
		public byte OutputXHTMLGetItem(int index)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.outputXHTMLField.Length - 1)
									>= index))
					{
						return this.outputXHTMLField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool OutputXHTMLSetItem(int index, byte value)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.outputXHTMLField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputXHTMLAddItem(byte value)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.outputXHTMLField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputXHTMLField.Length); i = (i + 1))
					{
						array[i] = outputXHTMLField[i];
					}
					array[i] = value;
					this.OutputXHTML = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputXHTMLRemoveItem(int index)
		{
			try
			{
				if ((this.outputXHTMLField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.outputXHTMLField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.outputXHTMLField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputXHTMLField[i];
						}
						for (i = (i + 1); (i < this.outputXHTMLField.Length); i = (i + 1))
						{
							array[i] = outputXHTMLField[i];
						}
						this.OutputXHTML = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("4e86338a-627f-4425-a469-0ce50c51b40e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AlgorithmIdentifier : IAlgorithmIdentifier
	{
		internal ParameterType parameterField = new ParameterType();
		internal string algorithmField;
		internal bool xsdAlgorithmIdentifierInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ParameterType Parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.xsdAlgorithmIdentifierInitFlagField = true;
				this.parameterField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Algorithm
		{
			get
			{
				return this.algorithmField;
			}
			set
			{
				this.xsdAlgorithmIdentifierInitFlagField = true;
				this.algorithmField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAlgorithmIdentifierInitFlag
		{
			get
			{
				return this.xsdAlgorithmIdentifierInitFlagField;
			}
			set
			{
				this.xsdAlgorithmIdentifierInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d9f721ae-0f71-43ca-b99c-08fdc3b68737")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ParameterType : IParameterType
	{
		internal byte[] initialisationVectorField = new byte[0];
		internal bool xsdParameterTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] InitialisationVector
		{
			get
			{
				if (((this.initialisationVectorField == null)
								|| (this.initialisationVectorField.Length == 0)))
				{
					return null;
				}
				return this.initialisationVectorField;
			}
			set
			{
				this.xsdParameterTypeInitFlagField = true;
				this.initialisationVectorField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdParameterTypeInitFlag
		{
			get
			{
				return this.xsdParameterTypeInitFlagField;
			}
			set
			{
				this.xsdParameterTypeInitFlagField = value;
			}
		}
		public int InitialisationVectorSize()
		{
			if ((this.initialisationVectorField == null))
			{
				return 0;
			}
			else
			{
				return this.initialisationVectorField.Length;
			}
		}
		public byte InitialisationVectorGetItem(int index)
		{
			try
			{
				if ((this.initialisationVectorField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.initialisationVectorField.Length - 1)
									>= index))
					{
						return this.initialisationVectorField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool InitialisationVectorSetItem(int index, byte value)
		{
			try
			{
				if ((this.initialisationVectorField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.initialisationVectorField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool InitialisationVectorAddItem(byte value)
		{
			try
			{
				if ((this.initialisationVectorField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.initialisationVectorField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.initialisationVectorField.Length); i = (i + 1))
					{
						array[i] = initialisationVectorField[i];
					}
					array[i] = value;
					this.InitialisationVector = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool InitialisationVectorRemoveItem(int index)
		{
			try
			{
				if ((this.initialisationVectorField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.initialisationVectorField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.initialisationVectorField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = initialisationVectorField[i];
						}
						for (i = (i + 1); (i < this.initialisationVectorField.Length); i = (i + 1))
						{
							array[i] = initialisationVectorField[i];
						}
						this.InitialisationVector = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("53bd16ea-f223-415b-b6a6-30f02dd1bb4c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class KeyTransportType : IKeyTransportType
	{
		internal RecipientIdentifierType recipientIdentifierField = new RecipientIdentifierType();
		internal AlgorithmIdentifier keyEncryptionAlgorithmField = new AlgorithmIdentifier();
		internal string versionField;
		internal byte[] encryptedKeyField = new byte[0];
		internal bool xsdKeyTransportTypeInitFlagField = false;
		public KeyTransportType()
		{
			this.versionField = "v0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RecipientIdentifierType RecipientIdentifier
		{
			get
			{
				return this.recipientIdentifierField;
			}
			set
			{
				this.xsdKeyTransportTypeInitFlagField = true;
				this.recipientIdentifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithmField;
			}
			set
			{
				this.xsdKeyTransportTypeInitFlagField = true;
				this.keyEncryptionAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v0")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdKeyTransportTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] EncryptedKey
		{
			get
			{
				if (((this.encryptedKeyField == null)
								|| (this.encryptedKeyField.Length == 0)))
				{
					return null;
				}
				return this.encryptedKeyField;
			}
			set
			{
				this.xsdKeyTransportTypeInitFlagField = true;
				this.encryptedKeyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdKeyTransportTypeInitFlag
		{
			get
			{
				return this.xsdKeyTransportTypeInitFlagField;
			}
			set
			{
				this.xsdKeyTransportTypeInitFlagField = value;
			}
		}
		public int EncryptedKeySize()
		{
			if ((this.encryptedKeyField == null))
			{
				return 0;
			}
			else
			{
				return this.encryptedKeyField.Length;
			}
		}
		public byte EncryptedKeyGetItem(int index)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.encryptedKeyField.Length - 1)
									>= index))
					{
						return this.encryptedKeyField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool EncryptedKeySetItem(int index, byte value)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.encryptedKeyField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedKeyAddItem(byte value)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.encryptedKeyField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.encryptedKeyField.Length); i = (i + 1))
					{
						array[i] = encryptedKeyField[i];
					}
					array[i] = value;
					this.EncryptedKey = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedKeyRemoveItem(int index)
		{
			try
			{
				if ((this.encryptedKeyField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.encryptedKeyField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.encryptedKeyField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = encryptedKeyField[i];
						}
						for (i = (i + 1); (i < this.encryptedKeyField.Length); i = (i + 1))
						{
							array[i] = encryptedKeyField[i];
						}
						this.EncryptedKey = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2b8732d9-6b68-450a-a7f3-5fb73c0a5525")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class RecipientIdentifierType : IRecipientIdentifierType
	{
		internal IssuerAndSerialNumberType issuerAndSerialNumberField = new IssuerAndSerialNumberType();
		internal bool xsdRecipientIdentifierTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public IssuerAndSerialNumberType IssuerAndSerialNumber
		{
			get
			{
				return this.issuerAndSerialNumberField;
			}
			set
			{
				this.xsdRecipientIdentifierTypeInitFlagField = true;
				this.issuerAndSerialNumberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdRecipientIdentifierTypeInitFlag
		{
			get
			{
				return this.xsdRecipientIdentifierTypeInitFlagField;
			}
			set
			{
				this.xsdRecipientIdentifierTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2b236418-5d38-4fbb-b334-9cc28d0b7b58")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class IssuerAndSerialNumberType : IIssuerAndSerialNumberType
	{
		internal RelativeDistinguishedNameType[] issuerField = new RelativeDistinguishedNameType[0];
		internal string serialNumberField;
		internal bool xsdIssuerAndSerialNumberTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("RelativeDistinguishedName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public RelativeDistinguishedNameType[] Issuer
		{
			get
			{
				if (((this.issuerField == null)
								|| (this.issuerField.Length == 0)))
				{
					return null;
				}
				return this.issuerField;
			}
			set
			{
				this.xsdIssuerAndSerialNumberTypeInitFlagField = true;
				this.issuerField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
		public string SerialNumber
		{
			get
			{
				return this.serialNumberField;
			}
			set
			{
				this.xsdIssuerAndSerialNumberTypeInitFlagField = true;
				this.serialNumberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdIssuerAndSerialNumberTypeInitFlag
		{
			get
			{
				return this.xsdIssuerAndSerialNumberTypeInitFlagField;
			}
			set
			{
				this.xsdIssuerAndSerialNumberTypeInitFlagField = value;
			}
		}
		public int IssuerSize()
		{
			if ((this.issuerField == null))
			{
				return 0;
			}
			else
			{
				return this.issuerField.Length;
			}
		}
		public RelativeDistinguishedNameType IssuerGetItem(int index)
		{
			try
			{
				if ((this.issuerField == default(RelativeDistinguishedNameType[])))
				{
					return default(RelativeDistinguishedNameType);
				}
				else
				{
					if (((this.issuerField.Length - 1)
									>= index))
					{
						return this.issuerField[index];
					}
					else
					{
						return default(RelativeDistinguishedNameType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(RelativeDistinguishedNameType);
			}
		}
		public bool IssuerSetItem(int index, RelativeDistinguishedNameType value)
		{
			try
			{
				if ((this.issuerField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					this.issuerField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool IssuerAddItem(RelativeDistinguishedNameType value)
		{
			try
			{
				if ((this.issuerField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					RelativeDistinguishedNameType[] array = new RelativeDistinguishedNameType[(this.issuerField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.issuerField.Length); i = (i + 1))
					{
						array[i] = issuerField[i];
					}
					array[i] = value;
					this.Issuer = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool IssuerRemoveItem(int index)
		{
			try
			{
				if ((this.issuerField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					if ((this.issuerField.Length <= index))
					{
						return false;
					}
					else
					{
						RelativeDistinguishedNameType[] array = new RelativeDistinguishedNameType[(this.issuerField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = issuerField[i];
						}
						for (i = (i + 1); (i < this.issuerField.Length); i = (i + 1))
						{
							array[i] = issuerField[i];
						}
						this.Issuer = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ceeb1da2-31a5-4c54-a3a8-4e0cc82c5e18")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class RelativeDistinguishedNameType : IRelativeDistinguishedNameType
	{
		internal string attributeTypeField;
		internal string attributeValueField;
		internal bool xsdRelativeDistinguishedNameTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AttributeType
		{
			get
			{
				return this.attributeTypeField;
			}
			set
			{
				this.xsdRelativeDistinguishedNameTypeInitFlagField = true;
				this.attributeTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AttributeValue
		{
			get
			{
				return this.attributeValueField;
			}
			set
			{
				this.xsdRelativeDistinguishedNameTypeInitFlagField = true;
				this.attributeValueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdRelativeDistinguishedNameTypeInitFlag
		{
			get
			{
				return this.xsdRelativeDistinguishedNameTypeInitFlagField;
			}
			set
			{
				this.xsdRelativeDistinguishedNameTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f67bbac3-bbfa-4968-8725-0ff5d7c0bd95")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EncapsulatedContentType : IEncapsulatedContentType
	{
		internal byte[] contentField = new byte[0];
		internal string contentTypeField;
		internal bool xsdEncapsulatedContentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] Content
		{
			get
			{
				if (((this.contentField == null)
								|| (this.contentField.Length == 0)))
				{
					return null;
				}
				return this.contentField;
			}
			set
			{
				this.xsdEncapsulatedContentTypeInitFlagField = true;
				this.contentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ContentType
		{
			get
			{
				return this.contentTypeField;
			}
			set
			{
				this.xsdEncapsulatedContentTypeInitFlagField = true;
				this.contentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEncapsulatedContentTypeInitFlag
		{
			get
			{
				return this.xsdEncapsulatedContentTypeInitFlagField;
			}
			set
			{
				this.xsdEncapsulatedContentTypeInitFlagField = value;
			}
		}
		public int ContentSize()
		{
			if ((this.contentField == null))
			{
				return 0;
			}
			else
			{
				return this.contentField.Length;
			}
		}
		public byte ContentGetItem(int index)
		{
			try
			{
				if ((this.contentField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.contentField.Length - 1)
									>= index))
					{
						return this.contentField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool ContentSetItem(int index, byte value)
		{
			try
			{
				if ((this.contentField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.contentField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ContentAddItem(byte value)
		{
			try
			{
				if ((this.contentField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.contentField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.contentField.Length); i = (i + 1))
					{
						array[i] = contentField[i];
					}
					array[i] = value;
					this.Content = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ContentRemoveItem(int index)
		{
			try
			{
				if ((this.contentField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.contentField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.contentField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = contentField[i];
						}
						for (i = (i + 1); (i < this.contentField.Length); i = (i + 1))
						{
							array[i] = contentField[i];
						}
						this.Content = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ContentTypeEnumeration
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-data")]
		iddata,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-signedData")]
		idsignedData,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-envelopedData")]
		idenvelopedData,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-digestedData")]
		iddigestedData,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-encryptedData")]
		idencryptedData,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("id-ct-authData")]
		idctauthData,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("9197ac05-3796-44aa-80be-3fcabc3a4011")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DigestedDataType : IDigestedDataType
	{
		internal AlgorithmIdentifier digestAlgorithmField = new AlgorithmIdentifier();
		internal EncapsulatedContentType encapsulatedContentField = new EncapsulatedContentType();
		internal byte[] digestField = new byte[0];
		internal string versionField;
		internal bool xsdDigestedDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digestAlgorithmField;
			}
			set
			{
				this.xsdDigestedDataTypeInitFlagField = true;
				this.digestAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncapsulatedContentType EncapsulatedContent
		{
			get
			{
				return this.encapsulatedContentField;
			}
			set
			{
				this.xsdDigestedDataTypeInitFlagField = true;
				this.encapsulatedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] Digest
		{
			get
			{
				if (((this.digestField == null)
								|| (this.digestField.Length == 0)))
				{
					return null;
				}
				return this.digestField;
			}
			set
			{
				this.xsdDigestedDataTypeInitFlagField = true;
				this.digestField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdDigestedDataTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDigestedDataTypeInitFlag
		{
			get
			{
				return this.xsdDigestedDataTypeInitFlagField;
			}
			set
			{
				this.xsdDigestedDataTypeInitFlagField = value;
			}
		}
		public int DigestSize()
		{
			if ((this.digestField == null))
			{
				return 0;
			}
			else
			{
				return this.digestField.Length;
			}
		}
		public byte DigestGetItem(int index)
		{
			try
			{
				if ((this.digestField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.digestField.Length - 1)
									>= index))
					{
						return this.digestField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool DigestSetItem(int index, byte value)
		{
			try
			{
				if ((this.digestField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.digestField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DigestAddItem(byte value)
		{
			try
			{
				if ((this.digestField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.digestField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.digestField.Length); i = (i + 1))
					{
						array[i] = digestField[i];
					}
					array[i] = value;
					this.Digest = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DigestRemoveItem(int index)
		{
			try
			{
				if ((this.digestField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.digestField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.digestField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = digestField[i];
						}
						for (i = (i + 1); (i < this.digestField.Length); i = (i + 1))
						{
							array[i] = digestField[i];
						}
						this.Digest = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("227cd1be-6672-42ac-a5c5-46ddd6209bd6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EncryptedContentType : IEncryptedContentType
	{
		internal AlgorithmIdentifier contentEncryptionAlgorithmField = new AlgorithmIdentifier();
		internal byte[] encryptedDataField = new byte[0];
		internal string contentTypeField;
		internal bool xsdEncryptedContentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier ContentEncryptionAlgorithm
		{
			get
			{
				return this.contentEncryptionAlgorithmField;
			}
			set
			{
				this.xsdEncryptedContentTypeInitFlagField = true;
				this.contentEncryptionAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] EncryptedData
		{
			get
			{
				if (((this.encryptedDataField == null)
								|| (this.encryptedDataField.Length == 0)))
				{
					return null;
				}
				return this.encryptedDataField;
			}
			set
			{
				this.xsdEncryptedContentTypeInitFlagField = true;
				this.encryptedDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ContentType
		{
			get
			{
				return this.contentTypeField;
			}
			set
			{
				this.xsdEncryptedContentTypeInitFlagField = true;
				this.contentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEncryptedContentTypeInitFlag
		{
			get
			{
				return this.xsdEncryptedContentTypeInitFlagField;
			}
			set
			{
				this.xsdEncryptedContentTypeInitFlagField = value;
			}
		}
		public int EncryptedDataSize()
		{
			if ((this.encryptedDataField == null))
			{
				return 0;
			}
			else
			{
				return this.encryptedDataField.Length;
			}
		}
		public byte EncryptedDataGetItem(int index)
		{
			try
			{
				if ((this.encryptedDataField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.encryptedDataField.Length - 1)
									>= index))
					{
						return this.encryptedDataField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool EncryptedDataSetItem(int index, byte value)
		{
			try
			{
				if ((this.encryptedDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.encryptedDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedDataAddItem(byte value)
		{
			try
			{
				if ((this.encryptedDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.encryptedDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.encryptedDataField.Length); i = (i + 1))
					{
						array[i] = encryptedDataField[i];
					}
					array[i] = value;
					this.EncryptedData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EncryptedDataRemoveItem(int index)
		{
			try
			{
				if ((this.encryptedDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.encryptedDataField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.encryptedDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = encryptedDataField[i];
						}
						for (i = (i + 1); (i < this.encryptedDataField.Length); i = (i + 1))
						{
							array[i] = encryptedDataField[i];
						}
						this.EncryptedData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("147591d7-fb4d-4cd5-abdb-967b6c2f6ad4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EnvelopedDataType : IEnvelopedDataType
	{
		internal object[] itemsField = new object[0];
		internal EncryptedContentType encryptedContentField = new EncryptedContentType();
		internal string versionField;
		internal bool xsdEnvelopedDataTypeInitFlagField = false;
		public EnvelopedDataType()
		{
			this.versionField = "v0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("KEK", typeof(KEKType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("KeyTransport", typeof(KeyTransportType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object[] Items
		{
			get
			{
				if (((this.itemsField == null)
								|| (this.itemsField.Length == 0)))
				{
					return null;
				}
				return this.itemsField;
			}
			set
			{
				this.xsdEnvelopedDataTypeInitFlagField = true;
				this.itemsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncryptedContentType EncryptedContent
		{
			get
			{
				return this.encryptedContentField;
			}
			set
			{
				this.xsdEnvelopedDataTypeInitFlagField = true;
				this.encryptedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v0")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdEnvelopedDataTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEnvelopedDataTypeInitFlag
		{
			get
			{
				return this.xsdEnvelopedDataTypeInitFlagField;
			}
			set
			{
				this.xsdEnvelopedDataTypeInitFlagField = value;
			}
		}
		public int ItemsSize()
		{
			if ((this.itemsField == null))
			{
				return 0;
			}
			else
			{
				return this.itemsField.Length;
			}
		}
		public object ItemsGetItem(int index)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return default(object);
				}
				else
				{
					if (((this.itemsField.Length - 1)
									>= index))
					{
						return this.itemsField[index];
					}
					else
					{
						return default(object);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(object);
			}
		}
		public bool ItemsSetItem(int index, object value)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					this.itemsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ItemsAddItem(object value)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					object[] array = new object[(this.itemsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.itemsField.Length); i = (i + 1))
					{
						array[i] = itemsField[i];
					}
					array[i] = value;
					this.Items = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ItemsRemoveItem(int index)
		{
			try
			{
				if ((this.itemsField == default(object[])))
				{
					return false;
				}
				else
				{
					if ((this.itemsField.Length <= index))
					{
						return false;
					}
					else
					{
						object[] array = new object[(this.itemsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = itemsField[i];
						}
						for (i = (i + 1); (i < this.itemsField.Length); i = (i + 1))
						{
							array[i] = itemsField[i];
						}
						this.Items = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("db86e0d0-4082-44c0-b8d5-c804d2fbfd85")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class IssuerType : IIssuerType
	{
		internal RelativeDistinguishedNameType[] relativeDistinguishedNameField = new RelativeDistinguishedNameType[0];
		internal bool xsdIssuerTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RelativeDistinguishedName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RelativeDistinguishedNameType[] RelativeDistinguishedName
		{
			get
			{
				if (((this.relativeDistinguishedNameField == null)
								|| (this.relativeDistinguishedNameField.Length == 0)))
				{
					return null;
				}
				return this.relativeDistinguishedNameField;
			}
			set
			{
				this.xsdIssuerTypeInitFlagField = true;
				this.relativeDistinguishedNameField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdIssuerTypeInitFlag
		{
			get
			{
				return this.xsdIssuerTypeInitFlagField;
			}
			set
			{
				this.xsdIssuerTypeInitFlagField = value;
			}
		}
		public int RelativeDistinguishedNameSize()
		{
			if ((this.relativeDistinguishedNameField == null))
			{
				return 0;
			}
			else
			{
				return this.relativeDistinguishedNameField.Length;
			}
		}
		public RelativeDistinguishedNameType RelativeDistinguishedNameGetItem(int index)
		{
			try
			{
				if ((this.relativeDistinguishedNameField == default(RelativeDistinguishedNameType[])))
				{
					return default(RelativeDistinguishedNameType);
				}
				else
				{
					if (((this.relativeDistinguishedNameField.Length - 1)
									>= index))
					{
						return this.relativeDistinguishedNameField[index];
					}
					else
					{
						return default(RelativeDistinguishedNameType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(RelativeDistinguishedNameType);
			}
		}
		public bool RelativeDistinguishedNameSetItem(int index, RelativeDistinguishedNameType value)
		{
			try
			{
				if ((this.relativeDistinguishedNameField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					this.relativeDistinguishedNameField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool RelativeDistinguishedNameAddItem(RelativeDistinguishedNameType value)
		{
			try
			{
				if ((this.relativeDistinguishedNameField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					RelativeDistinguishedNameType[] array = new RelativeDistinguishedNameType[(this.relativeDistinguishedNameField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.relativeDistinguishedNameField.Length); i = (i + 1))
					{
						array[i] = relativeDistinguishedNameField[i];
					}
					array[i] = value;
					this.RelativeDistinguishedName = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool RelativeDistinguishedNameRemoveItem(int index)
		{
			try
			{
				if ((this.relativeDistinguishedNameField == default(RelativeDistinguishedNameType[])))
				{
					return false;
				}
				else
				{
					if ((this.relativeDistinguishedNameField.Length <= index))
					{
						return false;
					}
					else
					{
						RelativeDistinguishedNameType[] array = new RelativeDistinguishedNameType[(this.relativeDistinguishedNameField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = relativeDistinguishedNameField[i];
						}
						for (i = (i + 1); (i < this.relativeDistinguishedNameField.Length); i = (i + 1))
						{
							array[i] = relativeDistinguishedNameField[i];
						}
						this.RelativeDistinguishedName = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("53c59c08-c469-40c9-a5a0-e907f7bb06a0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class NamedKeyEncryptedDataType : INamedKeyEncryptedDataType
	{
		internal string keyNameField;
		internal EncryptedContentType encryptedContentField = new EncryptedContentType();
		internal string versionField;
		internal bool xsdNamedKeyEncryptedDataTypeInitFlagField = false;
		public NamedKeyEncryptedDataType()
		{
			this.versionField = "v0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string KeyName
		{
			get
			{
				return this.keyNameField;
			}
			set
			{
				this.xsdNamedKeyEncryptedDataTypeInitFlagField = true;
				this.keyNameField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncryptedContentType EncryptedContent
		{
			get
			{
				return this.encryptedContentField;
			}
			set
			{
				this.xsdNamedKeyEncryptedDataTypeInitFlagField = true;
				this.encryptedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v0")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdNamedKeyEncryptedDataTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdNamedKeyEncryptedDataTypeInitFlag
		{
			get
			{
				return this.xsdNamedKeyEncryptedDataTypeInitFlagField;
			}
			set
			{
				this.xsdNamedKeyEncryptedDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("9441a2cc-7434-4db3-a3df-341510ab0617")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SignedDataType : ISignedDataType
	{
		internal AlgorithmIdentifier[] digestAlgorithmField = new AlgorithmIdentifier[0];
		internal EncapsulatedContentType encapsulatedContentField = new EncapsulatedContentType();
		internal byte[][] certificateField;
		internal SignerType[] signerField = new SignerType[0];
		internal string versionField;
		internal bool xsdSignedDataTypeInitFlagField = false;
		public SignedDataType()
		{
			this.versionField = "v1";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DigestAlgorithm", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier[] DigestAlgorithm
		{
			get
			{
				if (((this.digestAlgorithmField == null)
								|| (this.digestAlgorithmField.Length == 0)))
				{
					return null;
				}
				return this.digestAlgorithmField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = true;
				this.digestAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public EncapsulatedContentType EncapsulatedContent
		{
			get
			{
				return this.encapsulatedContentField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = true;
				this.encapsulatedContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Certificate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[][] Certificate
		{
			get
			{
				return this.certificateField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = true;
				this.certificateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Signer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SignerType[] Signer
		{
			get
			{
				if (((this.signerField == null)
								|| (this.signerField.Length == 0)))
				{
					return null;
				}
				return this.signerField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = true;
				this.signerField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v1")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSignedDataTypeInitFlag
		{
			get
			{
				return this.xsdSignedDataTypeInitFlagField;
			}
			set
			{
				this.xsdSignedDataTypeInitFlagField = value;
			}
		}
		public int DigestAlgorithmSize()
		{
			if ((this.digestAlgorithmField == null))
			{
				return 0;
			}
			else
			{
				return this.digestAlgorithmField.Length;
			}
		}
		public AlgorithmIdentifier DigestAlgorithmGetItem(int index)
		{
			try
			{
				if ((this.digestAlgorithmField == default(AlgorithmIdentifier[])))
				{
					return default(AlgorithmIdentifier);
				}
				else
				{
					if (((this.digestAlgorithmField.Length - 1)
									>= index))
					{
						return this.digestAlgorithmField[index];
					}
					else
					{
						return default(AlgorithmIdentifier);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(AlgorithmIdentifier);
			}
		}
		public bool DigestAlgorithmSetItem(int index, AlgorithmIdentifier value)
		{
			try
			{
				if ((this.digestAlgorithmField == default(AlgorithmIdentifier[])))
				{
					return false;
				}
				else
				{
					this.digestAlgorithmField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DigestAlgorithmAddItem(AlgorithmIdentifier value)
		{
			try
			{
				if ((this.digestAlgorithmField == default(AlgorithmIdentifier[])))
				{
					return false;
				}
				else
				{
					AlgorithmIdentifier[] array = new AlgorithmIdentifier[(this.digestAlgorithmField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.digestAlgorithmField.Length); i = (i + 1))
					{
						array[i] = digestAlgorithmField[i];
					}
					array[i] = value;
					this.DigestAlgorithm = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DigestAlgorithmRemoveItem(int index)
		{
			try
			{
				if ((this.digestAlgorithmField == default(AlgorithmIdentifier[])))
				{
					return false;
				}
				else
				{
					if ((this.digestAlgorithmField.Length <= index))
					{
						return false;
					}
					else
					{
						AlgorithmIdentifier[] array = new AlgorithmIdentifier[(this.digestAlgorithmField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = digestAlgorithmField[i];
						}
						for (i = (i + 1); (i < this.digestAlgorithmField.Length); i = (i + 1))
						{
							array[i] = digestAlgorithmField[i];
						}
						this.DigestAlgorithm = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int SignerSize()
		{
			if ((this.signerField == null))
			{
				return 0;
			}
			else
			{
				return this.signerField.Length;
			}
		}
		public SignerType SignerGetItem(int index)
		{
			try
			{
				if ((this.signerField == default(SignerType[])))
				{
					return default(SignerType);
				}
				else
				{
					if (((this.signerField.Length - 1)
									>= index))
					{
						return this.signerField[index];
					}
					else
					{
						return default(SignerType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SignerType);
			}
		}
		public bool SignerSetItem(int index, SignerType value)
		{
			try
			{
				if ((this.signerField == default(SignerType[])))
				{
					return false;
				}
				else
				{
					this.signerField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignerAddItem(SignerType value)
		{
			try
			{
				if ((this.signerField == default(SignerType[])))
				{
					return false;
				}
				else
				{
					SignerType[] array = new SignerType[(this.signerField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.signerField.Length); i = (i + 1))
					{
						array[i] = signerField[i];
					}
					array[i] = value;
					this.Signer = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignerRemoveItem(int index)
		{
			try
			{
				if ((this.signerField == default(SignerType[])))
				{
					return false;
				}
				else
				{
					if ((this.signerField.Length <= index))
					{
						return false;
					}
					else
					{
						SignerType[] array = new SignerType[(this.signerField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = signerField[i];
						}
						for (i = (i + 1); (i < this.signerField.Length); i = (i + 1))
						{
							array[i] = signerField[i];
						}
						this.Signer = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0a40af1d-92bc-44b3-aa42-6750e58cabe6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SignerType : ISignerType
	{
		internal SignerIdentifierType signerIdentifierField = new SignerIdentifierType();
		internal AlgorithmIdentifier digestAlgorithmField = new AlgorithmIdentifier();
		internal AlgorithmIdentifier signatureAlgorithmField = new AlgorithmIdentifier();
		internal byte[] signatureField = new byte[0];
		internal string versionField;
		internal bool xsdSignerTypeInitFlagField = false;
		public SignerType()
		{
			this.versionField = "v1";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SignerIdentifierType SignerIdentifier
		{
			get
			{
				return this.signerIdentifierField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = true;
				this.signerIdentifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digestAlgorithmField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = true;
				this.digestAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.signatureAlgorithmField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = true;
				this.signatureAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] Signature
		{
			get
			{
				if (((this.signatureField == null)
								|| (this.signatureField.Length == 0)))
				{
					return null;
				}
				return this.signatureField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = true;
				this.signatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("v1")]
		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = true;
				this.versionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSignerTypeInitFlag
		{
			get
			{
				return this.xsdSignerTypeInitFlagField;
			}
			set
			{
				this.xsdSignerTypeInitFlagField = value;
			}
		}
		public int SignatureSize()
		{
			if ((this.signatureField == null))
			{
				return 0;
			}
			else
			{
				return this.signatureField.Length;
			}
		}
		public byte SignatureGetItem(int index)
		{
			try
			{
				if ((this.signatureField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.signatureField.Length - 1)
									>= index))
					{
						return this.signatureField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool SignatureSetItem(int index, byte value)
		{
			try
			{
				if ((this.signatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.signatureField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignatureAddItem(byte value)
		{
			try
			{
				if ((this.signatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.signatureField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.signatureField.Length); i = (i + 1))
					{
						array[i] = signatureField[i];
					}
					array[i] = value;
					this.Signature = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignatureRemoveItem(int index)
		{
			try
			{
				if ((this.signatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.signatureField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.signatureField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = signatureField[i];
						}
						for (i = (i + 1); (i < this.signatureField.Length); i = (i + 1))
						{
							array[i] = signatureField[i];
						}
						this.Signature = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c7ea9027-b278-4b76-bc6d-5cbc50ea476b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SignerIdentifierType : ISignerIdentifierType
	{
		internal IssuerAndSerialNumberType issuerAndSerialNumberField = new IssuerAndSerialNumberType();
		internal bool xsdSignerIdentifierTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public IssuerAndSerialNumberType IssuerAndSerialNumber
		{
			get
			{
				return this.issuerAndSerialNumberField;
			}
			set
			{
				this.xsdSignerIdentifierTypeInitFlagField = true;
				this.issuerAndSerialNumberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSignerIdentifierTypeInitFlag
		{
			get
			{
				return this.xsdSignerIdentifierTypeInitFlagField;
			}
			set
			{
				this.xsdSignerIdentifierTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum VersionEnumeration
	{
		/// <remarks/>
		v0,
		/// <remarks/>
		v1,
		/// <remarks/>
		v2,
		/// <remarks/>
		v3,
		/// <remarks/>
		v4,
		/// <remarks/>
		v5,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("20f40d28-4036-4233-b30f-fb735422bc63")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ContentInformationType : IContentInformationType
	{
		internal object itemField;
		internal string contentTypeField;
		internal bool xsdContentInformationTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AuthenticatedData", typeof(AuthenticatedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("DigestedData", typeof(DigestedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("EnvelopedData", typeof(EnvelopedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("NamedKeyEncryptedData", typeof(NamedKeyEncryptedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SignedData", typeof(SignedDataType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.xsdContentInformationTypeInitFlagField = true;
				this.itemField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ContentType
		{
			get
			{
				return this.contentTypeField;
			}
			set
			{
				this.xsdContentInformationTypeInitFlagField = true;
				this.contentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdContentInformationTypeInitFlag
		{
			get
			{
				return this.xsdContentInformationTypeInitFlagField;
			}
			set
			{
				this.xsdContentInformationTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7c5e08dc-1522-45eb-9fd3-4b0ff529b52a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AbortRequestType : IAbortRequestType
	{
		internal MessageReferenceType messageReferenceField = new MessageReferenceType();
		internal string abortReasonField;
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal bool xsdAbortRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageReferenceType MessageReference
		{
			get
			{
				return this.messageReferenceField;
			}
			set
			{
				this.xsdAbortRequestTypeInitFlagField = true;
				this.messageReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AbortReason
		{
			get
			{
				return this.abortReasonField;
			}
			set
			{
				this.xsdAbortRequestTypeInitFlagField = true;
				this.abortReasonField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdAbortRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAbortRequestTypeInitFlag
		{
			get
			{
				return this.xsdAbortRequestTypeInitFlagField;
			}
			set
			{
				this.xsdAbortRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("4741df62-083c-4233-a2f9-3e67df1277c5")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageReferenceType : IMessageReferenceType
	{
		internal string messageCategoryField;
		internal string serviceIDField;
		internal string deviceIDField;
		internal string saleIDField;
		internal string pOIIDField;
		internal bool xsdMessageReferenceTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MessageCategory
		{
			get
			{
				return this.messageCategoryField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = true;
				this.messageCategoryField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ServiceID
		{
			get
			{
				return this.serviceIDField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = true;
				this.serviceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DeviceID
		{
			get
			{
				return this.deviceIDField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = true;
				this.deviceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleID
		{
			get
			{
				return this.saleIDField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = true;
				this.saleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdMessageReferenceTypeInitFlag
		{
			get
			{
				return this.xsdMessageReferenceTypeInitFlagField;
			}
			set
			{
				this.xsdMessageReferenceTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum AccountTypeEnumeration
	{
		/// <remarks/>
		Default,
		/// <remarks/>
		Savings,
		/// <remarks/>
		Checking,
		/// <remarks/>
		CreditCard,
		/// <remarks/>
		Universal,
		/// <remarks/>
		Investment,
		/// <remarks/>
		CardTotals,
		/// <remarks/>
		EpurseCard,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e60dbdd8-e4b3-45ce-b790-9e048b7cb890")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AdminRequestType : IAdminRequestType
	{
		internal string serviceIdentificationField;
		internal bool xsdAdminRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ServiceIdentification
		{
			get
			{
				return this.serviceIdentificationField;
			}
			set
			{
				this.xsdAdminRequestTypeInitFlagField = true;
				this.serviceIdentificationField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAdminRequestTypeInitFlag
		{
			get
			{
				return this.xsdAdminRequestTypeInitFlagField;
			}
			set
			{
				this.xsdAdminRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("02e36819-a403-4d87-9ecc-593e4fe2a904")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AdminResponseType : IAdminResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal bool xsdAdminResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdAdminResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAdminResponseTypeInitFlag
		{
			get
			{
				return this.xsdAdminResponseTypeInitFlagField;
			}
			set
			{
				this.xsdAdminResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum AlignmentEnumeration
	{
		/// <remarks/>
		Left,
		/// <remarks/>
		Right,
		/// <remarks/>
		Centred,
		/// <remarks/>
		Justified,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7adeb2a5-fcab-4b6c-ad95-476b70870fc9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AllowedProductType : IAllowedProductType
	{
		internal string productLabelField;
		internal string additionalProductInfoField;
		internal string productCodeField;
		internal string eanUpcField;
		internal bool xsdAllowedProductTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ProductLabel
		{
			get
			{
				return this.productLabelField;
			}
			set
			{
				this.xsdAllowedProductTypeInitFlagField = true;
				this.productLabelField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AdditionalProductInfo
		{
			get
			{
				return this.additionalProductInfoField;
			}
			set
			{
				this.xsdAllowedProductTypeInitFlagField = true;
				this.additionalProductInfoField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProductCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.xsdAllowedProductTypeInitFlagField = true;
				this.productCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EanUpc
		{
			get
			{
				return this.eanUpcField;
			}
			set
			{
				this.xsdAllowedProductTypeInitFlagField = true;
				this.eanUpcField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAllowedProductTypeInitFlag
		{
			get
			{
				return this.xsdAllowedProductTypeInitFlagField;
			}
			set
			{
				this.xsdAllowedProductTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("42fd6dc7-6225-46df-8070-55588584893d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AmountsReqType : IAmountsReqType
	{
		internal string currencyField;
		internal double requestedAmountField;
		internal bool requestedAmountFieldSpecified;
		internal double cashBackAmountField;
		internal bool cashBackAmountFieldSpecified;
		internal double tipAmountField;
		internal bool tipAmountFieldSpecified;
		internal double paidAmountField;
		internal bool paidAmountFieldSpecified;
		internal double minimumAmountToDeliverField;
		internal bool minimumAmountToDeliverFieldSpecified;
		internal double maximumCashBackAmountField;
		internal bool maximumCashBackAmountFieldSpecified;
		internal double minimumSplitAmountField;
		internal bool minimumSplitAmountFieldSpecified;
		internal bool xsdAmountsReqTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double RequestedAmount
		{
			get
			{
				return this.requestedAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.requestedAmountField = value;
				this.RequestedAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RequestedAmountSpecified
		{
			get
			{
				return this.requestedAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.requestedAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CashBackAmount
		{
			get
			{
				return this.cashBackAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.cashBackAmountField = value;
				this.CashBackAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CashBackAmountSpecified
		{
			get
			{
				return this.cashBackAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.cashBackAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TipAmount
		{
			get
			{
				return this.tipAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.tipAmountField = value;
				this.TipAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TipAmountSpecified
		{
			get
			{
				return this.tipAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.tipAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double PaidAmount
		{
			get
			{
				return this.paidAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.paidAmountField = value;
				this.PaidAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PaidAmountSpecified
		{
			get
			{
				return this.paidAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.paidAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double MinimumAmountToDeliver
		{
			get
			{
				return this.minimumAmountToDeliverField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.minimumAmountToDeliverField = value;
				this.MinimumAmountToDeliverSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MinimumAmountToDeliverSpecified
		{
			get
			{
				return this.minimumAmountToDeliverFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.minimumAmountToDeliverFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double MaximumCashBackAmount
		{
			get
			{
				return this.maximumCashBackAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.maximumCashBackAmountField = value;
				this.MaximumCashBackAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MaximumCashBackAmountSpecified
		{
			get
			{
				return this.maximumCashBackAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.maximumCashBackAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double MinimumSplitAmount
		{
			get
			{
				return this.minimumSplitAmountField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.minimumSplitAmountField = value;
				this.MinimumSplitAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MinimumSplitAmountSpecified
		{
			get
			{
				return this.minimumSplitAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = true;
				this.minimumSplitAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAmountsReqTypeInitFlag
		{
			get
			{
				return this.xsdAmountsReqTypeInitFlagField;
			}
			set
			{
				this.xsdAmountsReqTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("dc086691-25a1-4bd8-9588-c2d9d76cdf98")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AmountsRespType : IAmountsRespType
	{
		internal string currencyField;
		internal double authorizedAmountField;
		internal double totalRebatesAmountField;
		internal bool totalRebatesAmountFieldSpecified;
		internal double totalFeesAmountField;
		internal bool totalFeesAmountFieldSpecified;
		internal double cashBackAmountField;
		internal bool cashBackAmountFieldSpecified;
		internal double tipAmountField;
		internal bool tipAmountFieldSpecified;
		internal bool xsdAmountsRespTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double AuthorizedAmount
		{
			get
			{
				return this.authorizedAmountField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.authorizedAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TotalRebatesAmount
		{
			get
			{
				return this.totalRebatesAmountField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.totalRebatesAmountField = value;
				this.TotalRebatesAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalRebatesAmountSpecified
		{
			get
			{
				return this.totalRebatesAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.totalRebatesAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TotalFeesAmount
		{
			get
			{
				return this.totalFeesAmountField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.totalFeesAmountField = value;
				this.TotalFeesAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalFeesAmountSpecified
		{
			get
			{
				return this.totalFeesAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.totalFeesAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CashBackAmount
		{
			get
			{
				return this.cashBackAmountField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.cashBackAmountField = value;
				this.CashBackAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CashBackAmountSpecified
		{
			get
			{
				return this.cashBackAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.cashBackAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TipAmount
		{
			get
			{
				return this.tipAmountField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.tipAmountField = value;
				this.TipAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TipAmountSpecified
		{
			get
			{
				return this.tipAmountFieldSpecified;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = true;
				this.tipAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAmountsRespTypeInitFlag
		{
			get
			{
				return this.xsdAmountsRespTypeInitFlagField;
			}
			set
			{
				this.xsdAmountsRespTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a0577dab-3e36-4c88-9763-38dd4d9bd614")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AreaSizeType : IAreaSizeType
	{
		internal string xField;
		internal string yField;
		internal bool xsdAreaSizeTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string X
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xsdAreaSizeTypeInitFlagField = true;
				this.xField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.xsdAreaSizeTypeInitFlagField = true;
				this.yField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAreaSizeTypeInitFlag
		{
			get
			{
				return this.xsdAreaSizeTypeInitFlagField;
			}
			set
			{
				this.xsdAreaSizeTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum AuthenticationMethodEnumeration
	{
		/// <remarks/>
		Bypass,
		/// <remarks/>
		ManualVerification,
		/// <remarks/>
		MerchantAuthentication,
		/// <remarks/>
		OfflinePIN,
		/// <remarks/>
		OnLinePIN,
		/// <remarks/>
		PaperSignature,
		/// <remarks/>
		SecuredChannel,
		/// <remarks/>
		SecureCertificate,
		/// <remarks/>
		SecureNoCertificate,
		/// <remarks/>
		SignatureCapture,
		/// <remarks/>
		UnknownMethod,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bf44348c-4f89-4578-a5ad-634c696c23bd")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class BalanceInquiryRequestType : IBalanceInquiryRequestType
	{
		internal PaymentAccountReqType paymentAccountReqField = new PaymentAccountReqType();
		internal LoyaltyAccountReqType loyaltyAccountReqField = new LoyaltyAccountReqType();
		internal bool xsdBalanceInquiryRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentAccountReqType PaymentAccountReq
		{
			get
			{
				return this.paymentAccountReqField;
			}
			set
			{
				this.xsdBalanceInquiryRequestTypeInitFlagField = true;
				this.paymentAccountReqField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountReqType LoyaltyAccountReq
		{
			get
			{
				return this.loyaltyAccountReqField;
			}
			set
			{
				this.xsdBalanceInquiryRequestTypeInitFlagField = true;
				this.loyaltyAccountReqField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdBalanceInquiryRequestTypeInitFlag
		{
			get
			{
				return this.xsdBalanceInquiryRequestTypeInitFlagField;
			}
			set
			{
				this.xsdBalanceInquiryRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c4d00591-2ffa-4a4a-9a78-592333c9c003")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentAccountReqType : IPaymentAccountReqType
	{
		internal TransactionIdentificationType cardAcquisitionReferenceField = new TransactionIdentificationType();
		internal PaymentInstrumentDataType paymentInstrumentDataField = new PaymentInstrumentDataType();
		internal string accountTypeField;
		internal bool xsdPaymentAccountReqTypeInitFlagField = false;
		public PaymentAccountReqType()
		{
			this.accountTypeField = "Default";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType CardAcquisitionReference
		{
			get
			{
				return this.cardAcquisitionReferenceField;
			}
			set
			{
				this.xsdPaymentAccountReqTypeInitFlagField = true;
				this.cardAcquisitionReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentInstrumentDataType PaymentInstrumentData
		{
			get
			{
				return this.paymentInstrumentDataField;
			}
			set
			{
				this.xsdPaymentAccountReqTypeInitFlagField = true;
				this.paymentInstrumentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Default")]
		public string AccountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.xsdPaymentAccountReqTypeInitFlagField = true;
				this.accountTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentAccountReqTypeInitFlag
		{
			get
			{
				return this.xsdPaymentAccountReqTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentAccountReqTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2a58eddb-0ca9-4536-97c4-bbabda4f3e58")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionIdentificationType : ITransactionIdentificationType
	{
		internal string transactionIDField;
		internal string timeStampField;
		internal bool xsdTransactionIdentificationTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TransactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.xsdTransactionIdentificationTypeInitFlagField = true;
				this.transactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TimeStamp
		{
			get
			{
				return this.timeStampField;
			}
			set
			{
				this.xsdTransactionIdentificationTypeInitFlagField = true;
				this.timeStampField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionIdentificationTypeInitFlag
		{
			get
			{
				return this.xsdTransactionIdentificationTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionIdentificationTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0dca4ad4-0af0-4e48-bca6-2838859a3a41")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentInstrumentDataType : IPaymentInstrumentDataType
	{
		internal CardDataType cardDataField = new CardDataType();
		internal CheckDataType checkDataField = new CheckDataType();
		internal MobileDataType mobileDataField = new MobileDataType();
		internal string paymentInstrumentTypeField;
		internal bool xsdPaymentInstrumentDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CardDataType CardData
		{
			get
			{
				return this.cardDataField;
			}
			set
			{
				this.xsdPaymentInstrumentDataTypeInitFlagField = true;
				this.cardDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CheckDataType CheckData
		{
			get
			{
				return this.checkDataField;
			}
			set
			{
				this.xsdPaymentInstrumentDataTypeInitFlagField = true;
				this.checkDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MobileDataType MobileData
		{
			get
			{
				return this.mobileDataField;
			}
			set
			{
				this.xsdPaymentInstrumentDataTypeInitFlagField = true;
				this.mobileDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentInstrumentType
		{
			get
			{
				return this.paymentInstrumentTypeField;
			}
			set
			{
				this.xsdPaymentInstrumentDataTypeInitFlagField = true;
				this.paymentInstrumentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentInstrumentDataTypeInitFlag
		{
			get
			{
				return this.xsdPaymentInstrumentDataTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentInstrumentDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("06a020d7-81af-4141-b386-e0a1884111c4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardDataType : ICardDataType
	{
		internal ContentInformationType protectedCardDataField = new ContentInformationType();
		internal SensitiveCardDataType sensitiveCardDataField = new SensitiveCardDataType();
		internal string[] allowedProductCodeField = new string[0];
		internal AllowedProductType[] allowedProductField = new AllowedProductType[0];
		internal PaymentTokenType paymentTokenField = new PaymentTokenType();
		internal CustomerOrderType[] customerOrderField = new CustomerOrderType[0];
		internal string paymentBrandField;
		internal string maskedPANField;
		internal string paymentAccountRefField;
		internal string[] entryModeField = new string[0];
		internal string cardCountryCodeField;
		internal bool xsdCardDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType ProtectedCardData
		{
			get
			{
				return this.protectedCardDataField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.protectedCardDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SensitiveCardDataType SensitiveCardData
		{
			get
			{
				return this.sensitiveCardDataField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.sensitiveCardDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedProductCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AllowedProductCode
		{
			get
			{
				if (((this.allowedProductCodeField == null)
								|| (this.allowedProductCodeField.Length == 0)))
				{
					return null;
				}
				return this.allowedProductCodeField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.allowedProductCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedProduct", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AllowedProductType[] AllowedProduct
		{
			get
			{
				if (((this.allowedProductField == null)
								|| (this.allowedProductField.Length == 0)))
				{
					return null;
				}
				return this.allowedProductField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.allowedProductField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentTokenType PaymentToken
		{
			get
			{
				return this.paymentTokenField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.paymentTokenField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CustomerOrderType[] CustomerOrder
		{
			get
			{
				if (((this.customerOrderField == null)
								|| (this.customerOrderField.Length == 0)))
				{
					return null;
				}
				return this.customerOrderField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.customerOrderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentBrand
		{
			get
			{
				return this.paymentBrandField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.paymentBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MaskedPAN
		{
			get
			{
				return this.maskedPANField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.maskedPANField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentAccountRef
		{
			get
			{
				return this.paymentAccountRefField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.paymentAccountRefField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] EntryMode
		{
			get
			{
				if (((this.entryModeField == null)
								|| (this.entryModeField.Length == 0)))
				{
					return null;
				}
				return this.entryModeField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.entryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CardCountryCode
		{
			get
			{
				return this.cardCountryCodeField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = true;
				this.cardCountryCodeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardDataTypeInitFlag
		{
			get
			{
				return this.xsdCardDataTypeInitFlagField;
			}
			set
			{
				this.xsdCardDataTypeInitFlagField = value;
			}
		}
		public int AllowedProductCodeSize()
		{
			if ((this.allowedProductCodeField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedProductCodeField.Length;
			}
		}
		public string AllowedProductCodeGetItem(int index)
		{
			try
			{
				if ((this.allowedProductCodeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.allowedProductCodeField.Length - 1)
									>= index))
					{
						return this.allowedProductCodeField[index];
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
		}
		public bool AllowedProductCodeSetItem(int index, string value)
		{
			try
			{
				if ((this.allowedProductCodeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.allowedProductCodeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedProductCodeAddItem(string value)
		{
			try
			{
				if ((this.allowedProductCodeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.allowedProductCodeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedProductCodeField.Length); i = (i + 1))
					{
						array[i] = allowedProductCodeField[i];
					}
					array[i] = value;
					this.AllowedProductCode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedProductCodeRemoveItem(int index)
		{
			try
			{
				if ((this.allowedProductCodeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedProductCodeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.allowedProductCodeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedProductCodeField[i];
						}
						for (i = (i + 1); (i < this.allowedProductCodeField.Length); i = (i + 1))
						{
							array[i] = allowedProductCodeField[i];
						}
						this.AllowedProductCode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int AllowedProductSize()
		{
			if ((this.allowedProductField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedProductField.Length;
			}
		}
		public AllowedProductType AllowedProductGetItem(int index)
		{
			try
			{
				if ((this.allowedProductField == default(AllowedProductType[])))
				{
					return default(AllowedProductType);
				}
				else
				{
					if (((this.allowedProductField.Length - 1)
									>= index))
					{
						return this.allowedProductField[index];
					}
					else
					{
						return default(AllowedProductType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(AllowedProductType);
			}
		}
		public bool AllowedProductSetItem(int index, AllowedProductType value)
		{
			try
			{
				if ((this.allowedProductField == default(AllowedProductType[])))
				{
					return false;
				}
				else
				{
					this.allowedProductField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedProductAddItem(AllowedProductType value)
		{
			try
			{
				if ((this.allowedProductField == default(AllowedProductType[])))
				{
					return false;
				}
				else
				{
					AllowedProductType[] array = new AllowedProductType[(this.allowedProductField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedProductField.Length); i = (i + 1))
					{
						array[i] = allowedProductField[i];
					}
					array[i] = value;
					this.AllowedProduct = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedProductRemoveItem(int index)
		{
			try
			{
				if ((this.allowedProductField == default(AllowedProductType[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedProductField.Length <= index))
					{
						return false;
					}
					else
					{
						AllowedProductType[] array = new AllowedProductType[(this.allowedProductField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedProductField[i];
						}
						for (i = (i + 1); (i < this.allowedProductField.Length); i = (i + 1))
						{
							array[i] = allowedProductField[i];
						}
						this.AllowedProduct = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CustomerOrderSize()
		{
			if ((this.customerOrderField == null))
			{
				return 0;
			}
			else
			{
				return this.customerOrderField.Length;
			}
		}
		public CustomerOrderType CustomerOrderGetItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return default(CustomerOrderType);
				}
				else
				{
					if (((this.customerOrderField.Length - 1)
									>= index))
					{
						return this.customerOrderField[index];
					}
					else
					{
						return default(CustomerOrderType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CustomerOrderType);
			}
		}
		public bool CustomerOrderSetItem(int index, CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					this.customerOrderField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderAddItem(CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.customerOrderField.Length); i = (i + 1))
					{
						array[i] = customerOrderField[i];
					}
					array[i] = value;
					this.CustomerOrder = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderRemoveItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					if ((this.customerOrderField.Length <= index))
					{
						return false;
					}
					else
					{
						CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						for (i = (i + 1); (i < this.customerOrderField.Length); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						this.CustomerOrder = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int EntryModeSize()
		{
			if ((this.entryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.entryModeField.Length;
			}
		}
		public string EntryModeGetItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.entryModeField.Length - 1)
									>= index))
					{
						return this.entryModeField[index];
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
		}
		public bool EntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.entryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeAddItem(string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.entryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.entryModeField.Length); i = (i + 1))
					{
						array[i] = entryModeField[i];
					}
					array[i] = value;
					this.EntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.entryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.entryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						for (i = (i + 1); (i < this.entryModeField.Length); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						this.EntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7be9648b-76f2-4bf5-8e21-91b81f31e486")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SensitiveCardDataType : ISensitiveCardDataType
	{
		internal TrackDataType[] trackDataField = new TrackDataType[0];
		internal string pANField;
		internal string cardSeqNumbField;
		internal string expiryDateField;
		internal bool xsdSensitiveCardDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TrackData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TrackDataType[] TrackData
		{
			get
			{
				if (((this.trackDataField == null)
								|| (this.trackDataField.Length == 0)))
				{
					return null;
				}
				return this.trackDataField;
			}
			set
			{
				this.xsdSensitiveCardDataTypeInitFlagField = true;
				this.trackDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PAN
		{
			get
			{
				return this.pANField;
			}
			set
			{
				this.xsdSensitiveCardDataTypeInitFlagField = true;
				this.pANField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CardSeqNumb
		{
			get
			{
				return this.cardSeqNumbField;
			}
			set
			{
				this.xsdSensitiveCardDataTypeInitFlagField = true;
				this.cardSeqNumbField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ExpiryDate
		{
			get
			{
				return this.expiryDateField;
			}
			set
			{
				this.xsdSensitiveCardDataTypeInitFlagField = true;
				this.expiryDateField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSensitiveCardDataTypeInitFlag
		{
			get
			{
				return this.xsdSensitiveCardDataTypeInitFlagField;
			}
			set
			{
				this.xsdSensitiveCardDataTypeInitFlagField = value;
			}
		}
		public int TrackDataSize()
		{
			if ((this.trackDataField == null))
			{
				return 0;
			}
			else
			{
				return this.trackDataField.Length;
			}
		}
		public TrackDataType TrackDataGetItem(int index)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return default(TrackDataType);
				}
				else
				{
					if (((this.trackDataField.Length - 1)
									>= index))
					{
						return this.trackDataField[index];
					}
					else
					{
						return default(TrackDataType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TrackDataType);
			}
		}
		public bool TrackDataSetItem(int index, TrackDataType value)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					this.trackDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TrackDataAddItem(TrackDataType value)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					TrackDataType[] array = new TrackDataType[(this.trackDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.trackDataField.Length); i = (i + 1))
					{
						array[i] = trackDataField[i];
					}
					array[i] = value;
					this.TrackData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TrackDataRemoveItem(int index)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					if ((this.trackDataField.Length <= index))
					{
						return false;
					}
					else
					{
						TrackDataType[] array = new TrackDataType[(this.trackDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = trackDataField[i];
						}
						for (i = (i + 1); (i < this.trackDataField.Length); i = (i + 1))
						{
							array[i] = trackDataField[i];
						}
						this.TrackData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("90d2a9b7-0784-49e0-8bfa-159e9e09d238")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TrackDataType : ITrackDataType
	{
		internal string trackNumbField;
		internal string trackFormatField;
		internal string valueField;
		internal bool xsdTrackDataTypeInitFlagField = false;
		public TrackDataType()
		{
			this.trackNumbField = "2";
			this.trackFormatField = "ISO";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		[System.ComponentModel.DefaultValueAttribute("2")]
		public string TrackNumb
		{
			get
			{
				return this.trackNumbField;
			}
			set
			{
				this.xsdTrackDataTypeInitFlagField = true;
				this.trackNumbField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("ISO")]
		public string TrackFormat
		{
			get
			{
				return this.trackFormatField;
			}
			set
			{
				this.xsdTrackDataTypeInitFlagField = true;
				this.trackFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdTrackDataTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTrackDataTypeInitFlag
		{
			get
			{
				return this.xsdTrackDataTypeInitFlagField;
			}
			set
			{
				this.xsdTrackDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("da6d9db8-ddbf-42c8-b237-c4620759daa3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentTokenType : IPaymentTokenType
	{
		internal string tokenRequestedTypeField;
		internal string tokenValueField;
		internal string expiryDateTimeField;
		internal bool expiryDateTimeFieldSpecified;
		internal bool xsdPaymentTokenTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TokenRequestedType
		{
			get
			{
				return this.tokenRequestedTypeField;
			}
			set
			{
				this.xsdPaymentTokenTypeInitFlagField = true;
				this.tokenRequestedTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TokenValue
		{
			get
			{
				return this.tokenValueField;
			}
			set
			{
				this.xsdPaymentTokenTypeInitFlagField = true;
				this.tokenValueField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ExpiryDateTime
		{
			get
			{
				return this.expiryDateTimeField;
			}
			set
			{
				this.xsdPaymentTokenTypeInitFlagField = true;
				this.expiryDateTimeField = value;
				this.ExpiryDateTimeSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ExpiryDateTimeSpecified
		{
			get
			{
				return this.expiryDateTimeFieldSpecified;
			}
			set
			{
				this.xsdPaymentTokenTypeInitFlagField = true;
				this.expiryDateTimeFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentTokenTypeInitFlag
		{
			get
			{
				return this.xsdPaymentTokenTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentTokenTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("df392690-64c4-4998-9530-b5a569a958c4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CustomerOrderType : ICustomerOrderType
	{
		internal string additionalInformationField;
		internal string customerOrderIDField;
		internal bool openOrderStateField;
		internal string startDateField;
		internal string endDateField;
		internal bool endDateFieldSpecified;
		internal double forecastedAmountField;
		internal double currentAmountField;
		internal bool currentAmountFieldSpecified;
		internal string currencyField;
		internal string accessedByField;
		internal bool xsdCustomerOrderTypeInitFlagField = false;
		public CustomerOrderType()
		{
			this.openOrderStateField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AdditionalInformation
		{
			get
			{
				return this.additionalInformationField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.additionalInformationField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerOrderID
		{
			get
			{
				return this.customerOrderIDField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.customerOrderIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool OpenOrderState
		{
			get
			{
				return this.openOrderStateField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.openOrderStateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.startDateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.endDateField = value;
				this.EndDateSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool EndDateSpecified
		{
			get
			{
				return this.endDateFieldSpecified;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.endDateFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ForecastedAmount
		{
			get
			{
				return this.forecastedAmountField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.forecastedAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CurrentAmount
		{
			get
			{
				return this.currentAmountField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.currentAmountField = value;
				this.CurrentAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CurrentAmountSpecified
		{
			get
			{
				return this.currentAmountFieldSpecified;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.currentAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AccessedBy
		{
			get
			{
				return this.accessedByField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = true;
				this.accessedByField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCustomerOrderTypeInitFlag
		{
			get
			{
				return this.xsdCustomerOrderTypeInitFlagField;
			}
			set
			{
				this.xsdCustomerOrderTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c1468557-fb4f-48de-9ea9-de9e6fd006c9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CheckDataType : ICheckDataType
	{
		internal string bankIDField;
		internal string accountNumberField;
		internal string checkNumberField;
		internal TrackDataType trackDataField = new TrackDataType();
		internal string checkCardNumberField;
		internal string typeCodeField;
		internal string countryField;
		internal bool xsdCheckDataTypeInitFlagField = false;
		public CheckDataType()
		{
			this.typeCodeField = "Personal";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string BankID
		{
			get
			{
				return this.bankIDField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.bankIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AccountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.accountNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string CheckNumber
		{
			get
			{
				return this.checkNumberField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.checkNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TrackDataType TrackData
		{
			get
			{
				return this.trackDataField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.trackDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string CheckCardNumber
		{
			get
			{
				return this.checkCardNumberField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.checkCardNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Personal")]
		public string TypeCode
		{
			get
			{
				return this.typeCodeField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.typeCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = true;
				this.countryField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCheckDataTypeInitFlag
		{
			get
			{
				return this.xsdCheckDataTypeInitFlagField;
			}
			set
			{
				this.xsdCheckDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("3b46ca4d-319c-4c88-8474-0a827caec585")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MobileDataType : IMobileDataType
	{
		internal string mobileCountryCodeField;
		internal GeolocationType geolocationField = new GeolocationType();
		internal ContentInformationType protectedMobileDataField = new ContentInformationType();
		internal SensitiveMobileDataType sensitiveMobileDataField = new SensitiveMobileDataType();
		internal string mobileNetworkCodeField;
		internal string maskedMSISDNField;
		internal bool xsdMobileDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string MobileCountryCode
		{
			get
			{
				return this.mobileCountryCodeField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.mobileCountryCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GeolocationType Geolocation
		{
			get
			{
				return this.geolocationField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.geolocationField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType ProtectedMobileData
		{
			get
			{
				return this.protectedMobileDataField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.protectedMobileDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SensitiveMobileDataType SensitiveMobileData
		{
			get
			{
				return this.sensitiveMobileDataField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.sensitiveMobileDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MobileNetworkCode
		{
			get
			{
				return this.mobileNetworkCodeField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.mobileNetworkCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MaskedMSISDN
		{
			get
			{
				return this.maskedMSISDNField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = true;
				this.maskedMSISDNField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdMobileDataTypeInitFlag
		{
			get
			{
				return this.xsdMobileDataTypeInitFlagField;
			}
			set
			{
				this.xsdMobileDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("af4e172b-887f-4751-89f2-f9083b00a2f9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class GeolocationType : IGeolocationType
	{
		internal GeographicCoordinatesType geographicCoordinatesField = new GeographicCoordinatesType();
		internal UTMCoordinatesType uTMCoordinatesField = new UTMCoordinatesType();
		internal bool xsdGeolocationTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GeographicCoordinatesType GeographicCoordinates
		{
			get
			{
				return this.geographicCoordinatesField;
			}
			set
			{
				this.xsdGeolocationTypeInitFlagField = true;
				this.geographicCoordinatesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public UTMCoordinatesType UTMCoordinates
		{
			get
			{
				return this.uTMCoordinatesField;
			}
			set
			{
				this.xsdGeolocationTypeInitFlagField = true;
				this.uTMCoordinatesField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdGeolocationTypeInitFlag
		{
			get
			{
				return this.xsdGeolocationTypeInitFlagField;
			}
			set
			{
				this.xsdGeolocationTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b42e31fe-a6bc-42b2-a335-fd4ca0e25edd")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class GeographicCoordinatesType : IGeographicCoordinatesType
	{
		internal string latitudeField;
		internal string longitudeField;
		internal bool xsdGeographicCoordinatesTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Latitude
		{
			get
			{
				return this.latitudeField;
			}
			set
			{
				this.xsdGeographicCoordinatesTypeInitFlagField = true;
				this.latitudeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Longitude
		{
			get
			{
				return this.longitudeField;
			}
			set
			{
				this.xsdGeographicCoordinatesTypeInitFlagField = true;
				this.longitudeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdGeographicCoordinatesTypeInitFlag
		{
			get
			{
				return this.xsdGeographicCoordinatesTypeInitFlagField;
			}
			set
			{
				this.xsdGeographicCoordinatesTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("117f11b8-02a5-4e31-b9c9-093012f029b3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class UTMCoordinatesType : IUTMCoordinatesType
	{
		internal string uTMZoneField;
		internal string uTMEastwardField;
		internal string uTMNorthwardField;
		internal bool xsdUTMCoordinatesTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UTMZone
		{
			get
			{
				return this.uTMZoneField;
			}
			set
			{
				this.xsdUTMCoordinatesTypeInitFlagField = true;
				this.uTMZoneField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UTMEastward
		{
			get
			{
				return this.uTMEastwardField;
			}
			set
			{
				this.xsdUTMCoordinatesTypeInitFlagField = true;
				this.uTMEastwardField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UTMNorthward
		{
			get
			{
				return this.uTMNorthwardField;
			}
			set
			{
				this.xsdUTMCoordinatesTypeInitFlagField = true;
				this.uTMNorthwardField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdUTMCoordinatesTypeInitFlag
		{
			get
			{
				return this.xsdUTMCoordinatesTypeInitFlagField;
			}
			set
			{
				this.xsdUTMCoordinatesTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("49fe2a08-2141-4ed0-85ba-8c0aaac93b4d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SensitiveMobileDataType : ISensitiveMobileDataType
	{
		internal string mSISDNField;
		internal string iMSIField;
		internal string iMEIField;
		internal bool xsdSensitiveMobileDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MSISDN
		{
			get
			{
				return this.mSISDNField;
			}
			set
			{
				this.xsdSensitiveMobileDataTypeInitFlagField = true;
				this.mSISDNField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IMSI
		{
			get
			{
				return this.iMSIField;
			}
			set
			{
				this.xsdSensitiveMobileDataTypeInitFlagField = true;
				this.iMSIField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IMEI
		{
			get
			{
				return this.iMEIField;
			}
			set
			{
				this.xsdSensitiveMobileDataTypeInitFlagField = true;
				this.iMEIField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSensitiveMobileDataTypeInitFlag
		{
			get
			{
				return this.xsdSensitiveMobileDataTypeInitFlagField;
			}
			set
			{
				this.xsdSensitiveMobileDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("758071f5-4534-4611-9abf-301c036dd045")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAccountReqType : ILoyaltyAccountReqType
	{
		internal TransactionIdentificationType cardAcquisitionReferenceField = new TransactionIdentificationType();
		internal LoyaltyAccountIDType loyaltyAccountIDField = new LoyaltyAccountIDType();
		internal bool xsdLoyaltyAccountReqTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType CardAcquisitionReference
		{
			get
			{
				return this.cardAcquisitionReferenceField;
			}
			set
			{
				this.xsdLoyaltyAccountReqTypeInitFlagField = true;
				this.cardAcquisitionReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountIDType LoyaltyAccountID
		{
			get
			{
				return this.loyaltyAccountIDField;
			}
			set
			{
				this.xsdLoyaltyAccountReqTypeInitFlagField = true;
				this.loyaltyAccountIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAccountReqTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAccountReqTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAccountReqTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bac54ad4-1b30-4a97-a323-34a3016e3b29")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAccountIDType : ILoyaltyAccountIDType
	{
		internal string[] entryModeField = new string[0];
		internal string identificationTypeField;
		internal string identificationSupportField;
		internal string valueField;
		internal bool xsdLoyaltyAccountIDTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] EntryMode
		{
			get
			{
				if (((this.entryModeField == null)
								|| (this.entryModeField.Length == 0)))
				{
					return null;
				}
				return this.entryModeField;
			}
			set
			{
				this.xsdLoyaltyAccountIDTypeInitFlagField = true;
				this.entryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IdentificationType
		{
			get
			{
				return this.identificationTypeField;
			}
			set
			{
				this.xsdLoyaltyAccountIDTypeInitFlagField = true;
				this.identificationTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IdentificationSupport
		{
			get
			{
				return this.identificationSupportField;
			}
			set
			{
				this.xsdLoyaltyAccountIDTypeInitFlagField = true;
				this.identificationSupportField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdLoyaltyAccountIDTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAccountIDTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAccountIDTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAccountIDTypeInitFlagField = value;
			}
		}
		public int EntryModeSize()
		{
			if ((this.entryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.entryModeField.Length;
			}
		}
		public string EntryModeGetItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.entryModeField.Length - 1)
									>= index))
					{
						return this.entryModeField[index];
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
		}
		public bool EntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.entryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeAddItem(string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.entryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.entryModeField.Length); i = (i + 1))
					{
						array[i] = entryModeField[i];
					}
					array[i] = value;
					this.EntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.entryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.entryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						for (i = (i + 1); (i < this.entryModeField.Length); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						this.EntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("98be0a94-40a4-412e-899b-db24a6166ef0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class BalanceInquiryResponseType : IBalanceInquiryResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal PaymentAccountStatusType paymentAccountStatusField = new PaymentAccountStatusType();
		internal LoyaltyAccountStatusType loyaltyAccountStatusField = new LoyaltyAccountStatusType();
		internal bool xsdBalanceInquiryResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdBalanceInquiryResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentAccountStatusType PaymentAccountStatus
		{
			get
			{
				return this.paymentAccountStatusField;
			}
			set
			{
				this.xsdBalanceInquiryResponseTypeInitFlagField = true;
				this.paymentAccountStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountStatusType LoyaltyAccountStatus
		{
			get
			{
				return this.loyaltyAccountStatusField;
			}
			set
			{
				this.xsdBalanceInquiryResponseTypeInitFlagField = true;
				this.loyaltyAccountStatusField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdBalanceInquiryResponseTypeInitFlag
		{
			get
			{
				return this.xsdBalanceInquiryResponseTypeInitFlagField;
			}
			set
			{
				this.xsdBalanceInquiryResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0a3249b1-1c4b-4abb-800d-a1e8e4dd20a2")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentAccountStatusType : IPaymentAccountStatusType
	{
		internal PaymentInstrumentDataType paymentInstrumentDataField = new PaymentInstrumentDataType();
		internal PaymentAcquirerDataType paymentAcquirerDataField = new PaymentAcquirerDataType();
		internal LoyaltyAccountStatusType loyaltyAccountStatusField = new LoyaltyAccountStatusType();
		internal string currencyField;
		internal double currentBalanceField;
		internal bool currentBalanceFieldSpecified;
		internal bool xsdPaymentAccountStatusTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentInstrumentDataType PaymentInstrumentData
		{
			get
			{
				return this.paymentInstrumentDataField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.paymentInstrumentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentAcquirerDataType PaymentAcquirerData
		{
			get
			{
				return this.paymentAcquirerDataField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.paymentAcquirerDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountStatusType LoyaltyAccountStatus
		{
			get
			{
				return this.loyaltyAccountStatusField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.loyaltyAccountStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CurrentBalance
		{
			get
			{
				return this.currentBalanceField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.currentBalanceField = value;
				this.CurrentBalanceSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CurrentBalanceSpecified
		{
			get
			{
				return this.currentBalanceFieldSpecified;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = true;
				this.currentBalanceFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentAccountStatusTypeInitFlag
		{
			get
			{
				return this.xsdPaymentAccountStatusTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentAccountStatusTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d8f7ba83-a745-46f6-baff-6a6acf5031eb")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentAcquirerDataType : IPaymentAcquirerDataType
	{
		internal TransactionIdentificationType acquirerTransactionIDField = new TransactionIdentificationType();
		internal string approvalCodeField;
		internal string acquirerIDField;
		internal string merchantIDField;
		internal string acquirerPOIIDField;
		internal bool xsdPaymentAcquirerDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType AcquirerTransactionID
		{
			get
			{
				return this.acquirerTransactionIDField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = true;
				this.acquirerTransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ApprovalCode
		{
			get
			{
				return this.approvalCodeField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = true;
				this.approvalCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcquirerID
		{
			get
			{
				return this.acquirerIDField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MerchantID
		{
			get
			{
				return this.merchantIDField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = true;
				this.merchantIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcquirerPOIID
		{
			get
			{
				return this.acquirerPOIIDField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = true;
				this.acquirerPOIIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentAcquirerDataTypeInitFlag
		{
			get
			{
				return this.xsdPaymentAcquirerDataTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentAcquirerDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b8288ffe-8334-4abb-a8a5-bab573eabe37")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAccountStatusType : ILoyaltyAccountStatusType
	{
		internal LoyaltyAccountType loyaltyAccountField = new LoyaltyAccountType();
		internal double currentBalanceField;
		internal bool currentBalanceFieldSpecified;
		internal string loyaltyUnitField;
		internal string currencyField;
		internal bool xsdLoyaltyAccountStatusTypeInitFlagField = false;
		public LoyaltyAccountStatusType()
		{
			this.loyaltyUnitField = "Point";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountType LoyaltyAccount
		{
			get
			{
				return this.loyaltyAccountField;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = true;
				this.loyaltyAccountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CurrentBalance
		{
			get
			{
				return this.currentBalanceField;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = true;
				this.currentBalanceField = value;
				this.CurrentBalanceSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CurrentBalanceSpecified
		{
			get
			{
				return this.currentBalanceFieldSpecified;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = true;
				this.currentBalanceFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Point")]
		public string LoyaltyUnit
		{
			get
			{
				return this.loyaltyUnitField;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = true;
				this.loyaltyUnitField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAccountStatusTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAccountStatusTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAccountStatusTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("9ddbc1f4-6fd8-4407-940f-df3a686808d7")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAccountType : ILoyaltyAccountType
	{
		internal LoyaltyAccountIDType loyaltyAccountIDField = new LoyaltyAccountIDType();
		internal string loyaltyBrandField;
		internal bool xsdLoyaltyAccountTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountIDType LoyaltyAccountID
		{
			get
			{
				return this.loyaltyAccountIDField;
			}
			set
			{
				this.xsdLoyaltyAccountTypeInitFlagField = true;
				this.loyaltyAccountIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string LoyaltyBrand
		{
			get
			{
				return this.loyaltyBrandField;
			}
			set
			{
				this.xsdLoyaltyAccountTypeInitFlagField = true;
				this.loyaltyBrandField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAccountTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAccountTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAccountTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum BarcodeTypeEnumeration
	{
		/// <remarks/>
		EAN8,
		/// <remarks/>
		EAN13,
		/// <remarks/>
		UPCA,
		/// <remarks/>
		Code25,
		/// <remarks/>
		Code128,
		/// <remarks/>
		PDF417,
		/// <remarks/>
		QRCODE,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("45ec1860-ca90-40c1-89a2-16f985f5d4c1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class BatchRequestType : IBatchRequestType
	{
		internal TransactionToPerformType[] transactionToPerformField = new TransactionToPerformType[0];
		internal bool removeAllFlagField;
		internal bool removeAllFlagFieldSpecified;
		internal bool xsdBatchRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransactionToPerform", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionToPerformType[] TransactionToPerform
		{
			get
			{
				if (((this.transactionToPerformField == null)
								|| (this.transactionToPerformField.Length == 0)))
				{
					return null;
				}
				return this.transactionToPerformField;
			}
			set
			{
				this.xsdBatchRequestTypeInitFlagField = true;
				this.transactionToPerformField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool RemoveAllFlag
		{
			get
			{
				return this.removeAllFlagField;
			}
			set
			{
				this.xsdBatchRequestTypeInitFlagField = true;
				this.removeAllFlagField = value;
				this.RemoveAllFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RemoveAllFlagSpecified
		{
			get
			{
				return this.removeAllFlagFieldSpecified;
			}
			set
			{
				this.xsdBatchRequestTypeInitFlagField = true;
				this.removeAllFlagFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdBatchRequestTypeInitFlag
		{
			get
			{
				return this.xsdBatchRequestTypeInitFlagField;
			}
			set
			{
				this.xsdBatchRequestTypeInitFlagField = value;
			}
		}
		public int TransactionToPerformSize()
		{
			if ((this.transactionToPerformField == null))
			{
				return 0;
			}
			else
			{
				return this.transactionToPerformField.Length;
			}
		}
		public TransactionToPerformType TransactionToPerformGetItem(int index)
		{
			try
			{
				if ((this.transactionToPerformField == default(TransactionToPerformType[])))
				{
					return default(TransactionToPerformType);
				}
				else
				{
					if (((this.transactionToPerformField.Length - 1)
									>= index))
					{
						return this.transactionToPerformField[index];
					}
					else
					{
						return default(TransactionToPerformType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TransactionToPerformType);
			}
		}
		public bool TransactionToPerformSetItem(int index, TransactionToPerformType value)
		{
			try
			{
				if ((this.transactionToPerformField == default(TransactionToPerformType[])))
				{
					return false;
				}
				else
				{
					this.transactionToPerformField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionToPerformAddItem(TransactionToPerformType value)
		{
			try
			{
				if ((this.transactionToPerformField == default(TransactionToPerformType[])))
				{
					return false;
				}
				else
				{
					TransactionToPerformType[] array = new TransactionToPerformType[(this.transactionToPerformField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.transactionToPerformField.Length); i = (i + 1))
					{
						array[i] = transactionToPerformField[i];
					}
					array[i] = value;
					this.TransactionToPerform = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionToPerformRemoveItem(int index)
		{
			try
			{
				if ((this.transactionToPerformField == default(TransactionToPerformType[])))
				{
					return false;
				}
				else
				{
					if ((this.transactionToPerformField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionToPerformType[] array = new TransactionToPerformType[(this.transactionToPerformField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = transactionToPerformField[i];
						}
						for (i = (i + 1); (i < this.transactionToPerformField.Length); i = (i + 1))
						{
							array[i] = transactionToPerformField[i];
						}
						this.TransactionToPerform = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("20d90960-6fde-47bb-88c0-c4b88095809f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionToPerformType : ITransactionToPerformType
	{
		internal object itemField;
		internal bool xsdTransactionToPerformTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyRequest", typeof(LoyaltyRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PaymentRequest", typeof(PaymentRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReversalRequest", typeof(ReversalRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.xsdTransactionToPerformTypeInitFlagField = true;
				this.itemField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionToPerformTypeInitFlag
		{
			get
			{
				return this.xsdTransactionToPerformTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionToPerformTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("de948e4b-d88b-4989-9678-1ca0b5586c01")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyRequestType : ILoyaltyRequestType
	{
		internal SaleDataType saleDataField = new SaleDataType();
		internal LoyaltyTransactionType loyaltyTransactionField = new LoyaltyTransactionType();
		internal LoyaltyDataType[] loyaltyDataField = new LoyaltyDataType[0];
		internal bool xsdLoyaltyRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdLoyaltyRequestTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyTransactionType LoyaltyTransaction
		{
			get
			{
				return this.loyaltyTransactionField;
			}
			set
			{
				this.xsdLoyaltyRequestTypeInitFlagField = true;
				this.loyaltyTransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyDataType[] LoyaltyData
		{
			get
			{
				if (((this.loyaltyDataField == null)
								|| (this.loyaltyDataField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyDataField;
			}
			set
			{
				this.xsdLoyaltyRequestTypeInitFlagField = true;
				this.loyaltyDataField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyRequestTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyRequestTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyRequestTypeInitFlagField = value;
			}
		}
		public int LoyaltyDataSize()
		{
			if ((this.loyaltyDataField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyDataField.Length;
			}
		}
		public LoyaltyDataType LoyaltyDataGetItem(int index)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return default(LoyaltyDataType);
				}
				else
				{
					if (((this.loyaltyDataField.Length - 1)
									>= index))
					{
						return this.loyaltyDataField[index];
					}
					else
					{
						return default(LoyaltyDataType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyDataType);
			}
		}
		public bool LoyaltyDataSetItem(int index, LoyaltyDataType value)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyDataAddItem(LoyaltyDataType value)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					LoyaltyDataType[] array = new LoyaltyDataType[(this.loyaltyDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyDataField.Length); i = (i + 1))
					{
						array[i] = loyaltyDataField[i];
					}
					array[i] = value;
					this.LoyaltyData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyDataRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyDataField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyDataType[] array = new LoyaltyDataType[(this.loyaltyDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyDataField[i];
						}
						for (i = (i + 1); (i < this.loyaltyDataField.Length); i = (i + 1))
						{
							array[i] = loyaltyDataField[i];
						}
						this.LoyaltyData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("26c67c2b-a156-47d2-b171-866b02da87b4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleDataType : ISaleDataType
	{
		internal TransactionIdentificationType saleTransactionIDField = new TransactionIdentificationType();
		internal SaleTerminalDataType saleTerminalDataField = new SaleTerminalDataType();
		internal SponsoredMerchantType[] sponsoredMerchantField = new SponsoredMerchantType[0];
		internal string saleToPOIDataField;
		internal string saleToAcquirerDataField;
		internal SaleToIssuerDataType saleToIssuerDataField = new SaleToIssuerDataType();
		internal string operatorIDField;
		internal string operatorLanguageField;
		internal string shiftNumberField;
		internal string saleReferenceIDField;
		internal string tokenRequestedTypeField;
		internal string customerOrderIDField;
		internal string[] customerOrderReqField = new string[0];
		internal bool xsdSaleDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType SaleTransactionID
		{
			get
			{
				return this.saleTransactionIDField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleTransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleTerminalDataType SaleTerminalData
		{
			get
			{
				return this.saleTerminalDataField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleTerminalDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SponsoredMerchant", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SponsoredMerchantType[] SponsoredMerchant
		{
			get
			{
				if (((this.sponsoredMerchantField == null)
								|| (this.sponsoredMerchantField.Length == 0)))
				{
					return null;
				}
				return this.sponsoredMerchantField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.sponsoredMerchantField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SaleToPOIData
		{
			get
			{
				return this.saleToPOIDataField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleToPOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SaleToAcquirerData
		{
			get
			{
				return this.saleToAcquirerDataField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleToAcquirerDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleToIssuerDataType SaleToIssuerData
		{
			get
			{
				return this.saleToIssuerDataField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleToIssuerDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorID
		{
			get
			{
				return this.operatorIDField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.operatorIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorLanguage
		{
			get
			{
				return this.operatorLanguageField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.operatorLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShiftNumber
		{
			get
			{
				return this.shiftNumberField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.shiftNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleReferenceID
		{
			get
			{
				return this.saleReferenceIDField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.saleReferenceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TokenRequestedType
		{
			get
			{
				return this.tokenRequestedTypeField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.tokenRequestedTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerOrderID
		{
			get
			{
				return this.customerOrderIDField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.customerOrderIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] CustomerOrderReq
		{
			get
			{
				if (((this.customerOrderReqField == null)
								|| (this.customerOrderReqField.Length == 0)))
				{
					return null;
				}
				return this.customerOrderReqField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = true;
				this.customerOrderReqField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleDataTypeInitFlag
		{
			get
			{
				return this.xsdSaleDataTypeInitFlagField;
			}
			set
			{
				this.xsdSaleDataTypeInitFlagField = value;
			}
		}
		public int SponsoredMerchantSize()
		{
			if ((this.sponsoredMerchantField == null))
			{
				return 0;
			}
			else
			{
				return this.sponsoredMerchantField.Length;
			}
		}
		public SponsoredMerchantType SponsoredMerchantGetItem(int index)
		{
			try
			{
				if ((this.sponsoredMerchantField == default(SponsoredMerchantType[])))
				{
					return default(SponsoredMerchantType);
				}
				else
				{
					if (((this.sponsoredMerchantField.Length - 1)
									>= index))
					{
						return this.sponsoredMerchantField[index];
					}
					else
					{
						return default(SponsoredMerchantType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SponsoredMerchantType);
			}
		}
		public bool SponsoredMerchantSetItem(int index, SponsoredMerchantType value)
		{
			try
			{
				if ((this.sponsoredMerchantField == default(SponsoredMerchantType[])))
				{
					return false;
				}
				else
				{
					this.sponsoredMerchantField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SponsoredMerchantAddItem(SponsoredMerchantType value)
		{
			try
			{
				if ((this.sponsoredMerchantField == default(SponsoredMerchantType[])))
				{
					return false;
				}
				else
				{
					SponsoredMerchantType[] array = new SponsoredMerchantType[(this.sponsoredMerchantField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.sponsoredMerchantField.Length); i = (i + 1))
					{
						array[i] = sponsoredMerchantField[i];
					}
					array[i] = value;
					this.SponsoredMerchant = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SponsoredMerchantRemoveItem(int index)
		{
			try
			{
				if ((this.sponsoredMerchantField == default(SponsoredMerchantType[])))
				{
					return false;
				}
				else
				{
					if ((this.sponsoredMerchantField.Length <= index))
					{
						return false;
					}
					else
					{
						SponsoredMerchantType[] array = new SponsoredMerchantType[(this.sponsoredMerchantField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = sponsoredMerchantField[i];
						}
						for (i = (i + 1); (i < this.sponsoredMerchantField.Length); i = (i + 1))
						{
							array[i] = sponsoredMerchantField[i];
						}
						this.SponsoredMerchant = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CustomerOrderReqSize()
		{
			if ((this.customerOrderReqField == null))
			{
				return 0;
			}
			else
			{
				return this.customerOrderReqField.Length;
			}
		}
		public string CustomerOrderReqGetItem(int index)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.customerOrderReqField.Length - 1)
									>= index))
					{
						return this.customerOrderReqField[index];
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
		}
		public bool CustomerOrderReqSetItem(int index, string value)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					this.customerOrderReqField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderReqAddItem(string value)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.customerOrderReqField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.customerOrderReqField.Length); i = (i + 1))
					{
						array[i] = customerOrderReqField[i];
					}
					array[i] = value;
					this.CustomerOrderReq = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderReqRemoveItem(int index)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.customerOrderReqField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.customerOrderReqField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = customerOrderReqField[i];
						}
						for (i = (i + 1); (i < this.customerOrderReqField.Length); i = (i + 1))
						{
							array[i] = customerOrderReqField[i];
						}
						this.CustomerOrderReq = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c759b64e-c43c-4fd1-931d-1c455a37f3b3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleTerminalDataType : ISaleTerminalDataType
	{
		internal string saleCapabilitiesField;
		internal SaleProfileType saleProfileField = new SaleProfileType();
		internal string terminalEnvironmentField;
		internal string totalsGroupIDField;
		internal bool xsdSaleTerminalDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SaleCapabilities
		{
			get
			{
				return this.saleCapabilitiesField;
			}
			set
			{
				this.xsdSaleTerminalDataTypeInitFlagField = true;
				this.saleCapabilitiesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleProfileType SaleProfile
		{
			get
			{
				return this.saleProfileField;
			}
			set
			{
				this.xsdSaleTerminalDataTypeInitFlagField = true;
				this.saleProfileField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TerminalEnvironment
		{
			get
			{
				return this.terminalEnvironmentField;
			}
			set
			{
				this.xsdSaleTerminalDataTypeInitFlagField = true;
				this.terminalEnvironmentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalsGroupID
		{
			get
			{
				return this.totalsGroupIDField;
			}
			set
			{
				this.xsdSaleTerminalDataTypeInitFlagField = true;
				this.totalsGroupIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleTerminalDataTypeInitFlag
		{
			get
			{
				return this.xsdSaleTerminalDataTypeInitFlagField;
			}
			set
			{
				this.xsdSaleTerminalDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2bc70a7a-97f8-410f-875b-f1c4d2e342f1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleProfileType : ISaleProfileType
	{
		internal string serviceProfilesField;
		internal string genericProfileField;
		internal bool xsdSaleProfileTypeInitFlagField = false;
		public SaleProfileType()
		{
			this.genericProfileField = "Standard";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ServiceProfiles
		{
			get
			{
				return this.serviceProfilesField;
			}
			set
			{
				this.xsdSaleProfileTypeInitFlagField = true;
				this.serviceProfilesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Standard")]
		public string GenericProfile
		{
			get
			{
				return this.genericProfileField;
			}
			set
			{
				this.xsdSaleProfileTypeInitFlagField = true;
				this.genericProfileField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleProfileTypeInitFlag
		{
			get
			{
				return this.xsdSaleProfileTypeInitFlagField;
			}
			set
			{
				this.xsdSaleProfileTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b2dbc5a8-53c2-4064-9c8c-b85130edd9ed")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SponsoredMerchantType : ISponsoredMerchantType
	{
		internal string commonNameField;
		internal string addressField;
		internal string countryCodeField;
		internal string merchantCategoryCodeField;
		internal string registeredIdentifierField;
		internal bool xsdSponsoredMerchantTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CommonName
		{
			get
			{
				return this.commonNameField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = true;
				this.commonNameField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = true;
				this.addressField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CountryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = true;
				this.countryCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MerchantCategoryCode
		{
			get
			{
				return this.merchantCategoryCodeField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = true;
				this.merchantCategoryCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string RegisteredIdentifier
		{
			get
			{
				return this.registeredIdentifierField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = true;
				this.registeredIdentifierField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSponsoredMerchantTypeInitFlag
		{
			get
			{
				return this.xsdSponsoredMerchantTypeInitFlagField;
			}
			set
			{
				this.xsdSponsoredMerchantTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("95b305c4-e2dd-4972-9083-0294a7fb7c18")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToIssuerDataType : ISaleToIssuerDataType
	{
		internal string statementReferenceField;
		internal bool xsdSaleToIssuerDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string StatementReference
		{
			get
			{
				return this.statementReferenceField;
			}
			set
			{
				this.xsdSaleToIssuerDataTypeInitFlagField = true;
				this.statementReferenceField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleToIssuerDataTypeInitFlag
		{
			get
			{
				return this.xsdSaleToIssuerDataTypeInitFlagField;
			}
			set
			{
				this.xsdSaleToIssuerDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d0edb27a-cf26-4981-8bb2-c130a083028f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyTransactionType : ILoyaltyTransactionType
	{
		internal OriginalPOITransactionType originalPOITransactionField = new OriginalPOITransactionType();
		internal TransactionConditionsType transactionConditionsField = new TransactionConditionsType();
		internal SaleItemType[] saleItemField = new SaleItemType[0];
		internal string loyaltyTransactionType1Field;
		internal string currencyField;
		internal double totalAmountField;
		internal bool totalAmountFieldSpecified;
		internal bool xsdLoyaltyTransactionTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OriginalPOITransactionType OriginalPOITransaction
		{
			get
			{
				return this.originalPOITransactionField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.originalPOITransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionConditionsType TransactionConditions
		{
			get
			{
				return this.transactionConditionsField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.transactionConditionsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SaleItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleItemType[] SaleItem
		{
			get
			{
				if (((this.saleItemField == null)
								|| (this.saleItemField.Length == 0)))
				{
					return null;
				}
				return this.saleItemField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.saleItemField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("LoyaltyTransactionType")]
		public string LoyaltyTransactionType1
		{
			get
			{
				return this.loyaltyTransactionType1Field;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.loyaltyTransactionType1Field = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TotalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.totalAmountField = value;
				this.TotalAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalAmountSpecified
		{
			get
			{
				return this.totalAmountFieldSpecified;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = true;
				this.totalAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyTransactionTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyTransactionTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyTransactionTypeInitFlagField = value;
			}
		}
		public int SaleItemSize()
		{
			if ((this.saleItemField == null))
			{
				return 0;
			}
			else
			{
				return this.saleItemField.Length;
			}
		}
		public SaleItemType SaleItemGetItem(int index)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return default(SaleItemType);
				}
				else
				{
					if (((this.saleItemField.Length - 1)
									>= index))
					{
						return this.saleItemField[index];
					}
					else
					{
						return default(SaleItemType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SaleItemType);
			}
		}
		public bool SaleItemSetItem(int index, SaleItemType value)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					this.saleItemField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemAddItem(SaleItemType value)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					SaleItemType[] array = new SaleItemType[(this.saleItemField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.saleItemField.Length); i = (i + 1))
					{
						array[i] = saleItemField[i];
					}
					array[i] = value;
					this.SaleItem = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemRemoveItem(int index)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					if ((this.saleItemField.Length <= index))
					{
						return false;
					}
					else
					{
						SaleItemType[] array = new SaleItemType[(this.saleItemField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = saleItemField[i];
						}
						for (i = (i + 1); (i < this.saleItemField.Length); i = (i + 1))
						{
							array[i] = saleItemField[i];
						}
						this.SaleItem = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a0c44de8-3e33-4748-8aac-9b56acbf7336")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class OriginalPOITransactionType : IOriginalPOITransactionType
	{
		internal TransactionIdentificationType pOITransactionIDField = new TransactionIdentificationType();
		internal string approvalCodeField;
		internal TransactionIdentificationType hostTransactionIDField = new TransactionIdentificationType();
		internal string saleIDField;
		internal string pOIIDField;
		internal bool reuseCardDataFlagField;
		internal string customerLanguageField;
		internal string acquirerIDField;
		internal bool lastTransactionFlagField;
		internal bool lastTransactionFlagFieldSpecified;
		internal bool xsdOriginalPOITransactionTypeInitFlagField = false;
		public OriginalPOITransactionType()
		{
			this.reuseCardDataFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType POITransactionID
		{
			get
			{
				return this.pOITransactionIDField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.pOITransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ApprovalCode
		{
			get
			{
				return this.approvalCodeField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.approvalCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType HostTransactionID
		{
			get
			{
				return this.hostTransactionIDField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.hostTransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleID
		{
			get
			{
				return this.saleIDField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.saleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool ReuseCardDataFlag
		{
			get
			{
				return this.reuseCardDataFlagField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.reuseCardDataFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcquirerID
		{
			get
			{
				return this.acquirerIDField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool LastTransactionFlag
		{
			get
			{
				return this.lastTransactionFlagField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.lastTransactionFlagField = value;
				this.LastTransactionFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool LastTransactionFlagSpecified
		{
			get
			{
				return this.lastTransactionFlagFieldSpecified;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = true;
				this.lastTransactionFlagFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdOriginalPOITransactionTypeInitFlag
		{
			get
			{
				return this.xsdOriginalPOITransactionTypeInitFlagField;
			}
			set
			{
				this.xsdOriginalPOITransactionTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d5546160-6e3d-4b0f-abee-a82a2784b4b2")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionConditionsType : ITransactionConditionsType
	{
		internal string[] allowedPaymentBrandField = new string[0];
		internal string[] acquirerIDField = new string[0];
		internal string[] allowedLoyaltyBrandField = new string[0];
		internal string[] forceEntryModeField = new string[0];
		internal bool debitPreferredFlagField;
		internal string loyaltyHandlingField;
		internal string customerLanguageField;
		internal bool forceOnlineFlagField;
		internal string merchantCategoryCodeField;
		internal bool xsdTransactionConditionsTypeInitFlagField = false;
		public TransactionConditionsType()
		{
			this.debitPreferredFlagField = false;
			this.loyaltyHandlingField = "Forbidden";
			this.forceOnlineFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedPaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AllowedPaymentBrand
		{
			get
			{
				if (((this.allowedPaymentBrandField == null)
								|| (this.allowedPaymentBrandField.Length == 0)))
				{
					return null;
				}
				return this.allowedPaymentBrandField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.allowedPaymentBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AcquirerID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AcquirerID
		{
			get
			{
				if (((this.acquirerIDField == null)
								|| (this.acquirerIDField.Length == 0)))
				{
					return null;
				}
				return this.acquirerIDField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedLoyaltyBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AllowedLoyaltyBrand
		{
			get
			{
				if (((this.allowedLoyaltyBrandField == null)
								|| (this.allowedLoyaltyBrandField.Length == 0)))
				{
					return null;
				}
				return this.allowedLoyaltyBrandField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.allowedLoyaltyBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] ForceEntryMode
		{
			get
			{
				if (((this.forceEntryModeField == null)
								|| (this.forceEntryModeField.Length == 0)))
				{
					return null;
				}
				return this.forceEntryModeField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.forceEntryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DebitPreferredFlag
		{
			get
			{
				return this.debitPreferredFlagField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.debitPreferredFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Forbidden")]
		public string LoyaltyHandling
		{
			get
			{
				return this.loyaltyHandlingField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.loyaltyHandlingField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ForceOnlineFlag
		{
			get
			{
				return this.forceOnlineFlagField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.forceOnlineFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MerchantCategoryCode
		{
			get
			{
				return this.merchantCategoryCodeField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = true;
				this.merchantCategoryCodeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionConditionsTypeInitFlag
		{
			get
			{
				return this.xsdTransactionConditionsTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionConditionsTypeInitFlagField = value;
			}
		}
		public int AllowedPaymentBrandSize()
		{
			if ((this.allowedPaymentBrandField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedPaymentBrandField.Length;
			}
		}
		public string AllowedPaymentBrandGetItem(int index)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.allowedPaymentBrandField.Length - 1)
									>= index))
					{
						return this.allowedPaymentBrandField[index];
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
		}
		public bool AllowedPaymentBrandSetItem(int index, string value)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					this.allowedPaymentBrandField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedPaymentBrandAddItem(string value)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.allowedPaymentBrandField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedPaymentBrandField.Length); i = (i + 1))
					{
						array[i] = allowedPaymentBrandField[i];
					}
					array[i] = value;
					this.AllowedPaymentBrand = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedPaymentBrandRemoveItem(int index)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedPaymentBrandField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.allowedPaymentBrandField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedPaymentBrandField[i];
						}
						for (i = (i + 1); (i < this.allowedPaymentBrandField.Length); i = (i + 1))
						{
							array[i] = allowedPaymentBrandField[i];
						}
						this.AllowedPaymentBrand = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int AcquirerIDSize()
		{
			if ((this.acquirerIDField == null))
			{
				return 0;
			}
			else
			{
				return this.acquirerIDField.Length;
			}
		}
		public string AcquirerIDGetItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.acquirerIDField.Length - 1)
									>= index))
					{
						return this.acquirerIDField[index];
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
		}
		public bool AcquirerIDSetItem(int index, string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					this.acquirerIDField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDAddItem(string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.acquirerIDField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.acquirerIDField.Length); i = (i + 1))
					{
						array[i] = acquirerIDField[i];
					}
					array[i] = value;
					this.AcquirerID = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDRemoveItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.acquirerIDField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.acquirerIDField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						for (i = (i + 1); (i < this.acquirerIDField.Length); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						this.AcquirerID = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int AllowedLoyaltyBrandSize()
		{
			if ((this.allowedLoyaltyBrandField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedLoyaltyBrandField.Length;
			}
		}
		public string AllowedLoyaltyBrandGetItem(int index)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.allowedLoyaltyBrandField.Length - 1)
									>= index))
					{
						return this.allowedLoyaltyBrandField[index];
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
		}
		public bool AllowedLoyaltyBrandSetItem(int index, string value)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					this.allowedLoyaltyBrandField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedLoyaltyBrandAddItem(string value)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.allowedLoyaltyBrandField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedLoyaltyBrandField.Length); i = (i + 1))
					{
						array[i] = allowedLoyaltyBrandField[i];
					}
					array[i] = value;
					this.AllowedLoyaltyBrand = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedLoyaltyBrandRemoveItem(int index)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedLoyaltyBrandField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.allowedLoyaltyBrandField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedLoyaltyBrandField[i];
						}
						for (i = (i + 1); (i < this.allowedLoyaltyBrandField.Length); i = (i + 1))
						{
							array[i] = allowedLoyaltyBrandField[i];
						}
						this.AllowedLoyaltyBrand = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int ForceEntryModeSize()
		{
			if ((this.forceEntryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.forceEntryModeField.Length;
			}
		}
		public string ForceEntryModeGetItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.forceEntryModeField.Length - 1)
									>= index))
					{
						return this.forceEntryModeField[index];
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
		}
		public bool ForceEntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.forceEntryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeAddItem(string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.forceEntryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.forceEntryModeField.Length); i = (i + 1))
					{
						array[i] = forceEntryModeField[i];
					}
					array[i] = value;
					this.ForceEntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.forceEntryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.forceEntryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						for (i = (i + 1); (i < this.forceEntryModeField.Length); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						this.ForceEntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5d5732cd-998f-4636-bb5f-5dfb37d3d41a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleItemType : ISaleItemType
	{
		internal string unitOfMeasureField;
		internal double quantityField;
		internal bool quantityFieldSpecified;
		internal double unitPriceField;
		internal bool unitPriceFieldSpecified;
		internal string taxCodeField;
		internal string saleChannelField;
		internal string productLabelField;
		internal string additionalProductInfoField;
		internal string itemIDField;
		internal string productCodeField;
		internal string eanUpcField;
		internal double itemAmountField;
		internal bool xsdSaleItemTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UnitOfMeasure
		{
			get
			{
				return this.unitOfMeasureField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.unitOfMeasureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.quantityField = value;
				this.QuantitySpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.quantityFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double UnitPrice
		{
			get
			{
				return this.unitPriceField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.unitPriceField = value;
				this.UnitPriceSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool UnitPriceSpecified
		{
			get
			{
				return this.unitPriceFieldSpecified;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.unitPriceFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TaxCode
		{
			get
			{
				return this.taxCodeField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.taxCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SaleChannel
		{
			get
			{
				return this.saleChannelField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.saleChannelField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ProductLabel
		{
			get
			{
				return this.productLabelField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.productLabelField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AdditionalProductInfo
		{
			get
			{
				return this.additionalProductInfoField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.additionalProductInfoField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ItemID
		{
			get
			{
				return this.itemIDField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.itemIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProductCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.productCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EanUpc
		{
			get
			{
				return this.eanUpcField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.eanUpcField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = true;
				this.itemAmountField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleItemTypeInitFlag
		{
			get
			{
				return this.xsdSaleItemTypeInitFlagField;
			}
			set
			{
				this.xsdSaleItemTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c806d02b-a405-4044-b5ba-62ac38f5c73d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyDataType : ILoyaltyDataType
	{
		internal TransactionIdentificationType cardAcquisitionReferenceField = new TransactionIdentificationType();
		internal LoyaltyAccountIDType loyaltyAccountIDField = new LoyaltyAccountIDType();
		internal LoyaltyAmountType loyaltyAmountField = new LoyaltyAmountType();
		internal bool xsdLoyaltyDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType CardAcquisitionReference
		{
			get
			{
				return this.cardAcquisitionReferenceField;
			}
			set
			{
				this.xsdLoyaltyDataTypeInitFlagField = true;
				this.cardAcquisitionReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountIDType LoyaltyAccountID
		{
			get
			{
				return this.loyaltyAccountIDField;
			}
			set
			{
				this.xsdLoyaltyDataTypeInitFlagField = true;
				this.loyaltyAccountIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAmountType LoyaltyAmount
		{
			get
			{
				return this.loyaltyAmountField;
			}
			set
			{
				this.xsdLoyaltyDataTypeInitFlagField = true;
				this.loyaltyAmountField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyDataTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyDataTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d0c1b7bb-4b24-4ac0-aeb5-1ffc859fe72f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAmountType : ILoyaltyAmountType
	{
		internal string loyaltyUnitField;
		internal string currencyField;
		internal double valueField;
		internal bool xsdLoyaltyAmountTypeInitFlagField = false;
		public LoyaltyAmountType()
		{
			this.loyaltyUnitField = "Point";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Point")]
		public string LoyaltyUnit
		{
			get
			{
				return this.loyaltyUnitField;
			}
			set
			{
				this.xsdLoyaltyAmountTypeInitFlagField = true;
				this.loyaltyUnitField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdLoyaltyAmountTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public double Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdLoyaltyAmountTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAmountTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAmountTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAmountTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("8b8ffc81-576c-4de2-ae7c-e77ba3fb733f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentRequestType : IPaymentRequestType
	{
		internal SaleDataType saleDataField = new SaleDataType();
		internal PaymentTransactionType paymentTransactionField = new PaymentTransactionType();
		internal PaymentDataType paymentDataField = new PaymentDataType();
		internal LoyaltyDataType[] loyaltyDataField = new LoyaltyDataType[0];
		internal bool xsdPaymentRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdPaymentRequestTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentTransactionType PaymentTransaction
		{
			get
			{
				return this.paymentTransactionField;
			}
			set
			{
				this.xsdPaymentRequestTypeInitFlagField = true;
				this.paymentTransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentDataType PaymentData
		{
			get
			{
				return this.paymentDataField;
			}
			set
			{
				this.xsdPaymentRequestTypeInitFlagField = true;
				this.paymentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyDataType[] LoyaltyData
		{
			get
			{
				if (((this.loyaltyDataField == null)
								|| (this.loyaltyDataField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyDataField;
			}
			set
			{
				this.xsdPaymentRequestTypeInitFlagField = true;
				this.loyaltyDataField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentRequestTypeInitFlag
		{
			get
			{
				return this.xsdPaymentRequestTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentRequestTypeInitFlagField = value;
			}
		}
		public int LoyaltyDataSize()
		{
			if ((this.loyaltyDataField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyDataField.Length;
			}
		}
		public LoyaltyDataType LoyaltyDataGetItem(int index)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return default(LoyaltyDataType);
				}
				else
				{
					if (((this.loyaltyDataField.Length - 1)
									>= index))
					{
						return this.loyaltyDataField[index];
					}
					else
					{
						return default(LoyaltyDataType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyDataType);
			}
		}
		public bool LoyaltyDataSetItem(int index, LoyaltyDataType value)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyDataAddItem(LoyaltyDataType value)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					LoyaltyDataType[] array = new LoyaltyDataType[(this.loyaltyDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyDataField.Length); i = (i + 1))
					{
						array[i] = loyaltyDataField[i];
					}
					array[i] = value;
					this.LoyaltyData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyDataRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyDataField == default(LoyaltyDataType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyDataField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyDataType[] array = new LoyaltyDataType[(this.loyaltyDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyDataField[i];
						}
						for (i = (i + 1); (i < this.loyaltyDataField.Length); i = (i + 1))
						{
							array[i] = loyaltyDataField[i];
						}
						this.LoyaltyData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("90415d15-0be0-448d-99d9-43d98d66aac7")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentTransactionType : IPaymentTransactionType
	{
		internal AmountsReqType amountsReqField = new AmountsReqType();
		internal OriginalPOITransactionType originalPOITransactionField = new OriginalPOITransactionType();
		internal TransactionConditionsType transactionConditionsField = new TransactionConditionsType();
		internal SaleItemType[] saleItemField = new SaleItemType[0];
		internal bool xsdPaymentTransactionTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AmountsReqType AmountsReq
		{
			get
			{
				return this.amountsReqField;
			}
			set
			{
				this.xsdPaymentTransactionTypeInitFlagField = true;
				this.amountsReqField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OriginalPOITransactionType OriginalPOITransaction
		{
			get
			{
				return this.originalPOITransactionField;
			}
			set
			{
				this.xsdPaymentTransactionTypeInitFlagField = true;
				this.originalPOITransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionConditionsType TransactionConditions
		{
			get
			{
				return this.transactionConditionsField;
			}
			set
			{
				this.xsdPaymentTransactionTypeInitFlagField = true;
				this.transactionConditionsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SaleItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleItemType[] SaleItem
		{
			get
			{
				if (((this.saleItemField == null)
								|| (this.saleItemField.Length == 0)))
				{
					return null;
				}
				return this.saleItemField;
			}
			set
			{
				this.xsdPaymentTransactionTypeInitFlagField = true;
				this.saleItemField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentTransactionTypeInitFlag
		{
			get
			{
				return this.xsdPaymentTransactionTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentTransactionTypeInitFlagField = value;
			}
		}
		public int SaleItemSize()
		{
			if ((this.saleItemField == null))
			{
				return 0;
			}
			else
			{
				return this.saleItemField.Length;
			}
		}
		public SaleItemType SaleItemGetItem(int index)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return default(SaleItemType);
				}
				else
				{
					if (((this.saleItemField.Length - 1)
									>= index))
					{
						return this.saleItemField[index];
					}
					else
					{
						return default(SaleItemType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SaleItemType);
			}
		}
		public bool SaleItemSetItem(int index, SaleItemType value)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					this.saleItemField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemAddItem(SaleItemType value)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					SaleItemType[] array = new SaleItemType[(this.saleItemField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.saleItemField.Length); i = (i + 1))
					{
						array[i] = saleItemField[i];
					}
					array[i] = value;
					this.SaleItem = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemRemoveItem(int index)
		{
			try
			{
				if ((this.saleItemField == default(SaleItemType[])))
				{
					return false;
				}
				else
				{
					if ((this.saleItemField.Length <= index))
					{
						return false;
					}
					else
					{
						SaleItemType[] array = new SaleItemType[(this.saleItemField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = saleItemField[i];
						}
						for (i = (i + 1); (i < this.saleItemField.Length); i = (i + 1))
						{
							array[i] = saleItemField[i];
						}
						this.SaleItem = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("67b46dfe-e84d-4974-89b3-dc55cfdd803a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentDataType : IPaymentDataType
	{
		internal TransactionIdentificationType cardAcquisitionReferenceField = new TransactionIdentificationType();
		internal string requestedValidityDateField;
		internal InstalmentType instalmentField = new InstalmentType();
		internal CustomerOrderType customerOrderField = new CustomerOrderType();
		internal PaymentInstrumentDataType paymentInstrumentDataField = new PaymentInstrumentDataType();
		internal string paymentTypeField;
		internal bool splitPaymentFlagField;
		internal bool xsdPaymentDataTypeInitFlagField = false;
		public PaymentDataType()
		{
			this.paymentTypeField = "Normal";
			this.splitPaymentFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType CardAcquisitionReference
		{
			get
			{
				return this.cardAcquisitionReferenceField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.cardAcquisitionReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string RequestedValidityDate
		{
			get
			{
				return this.requestedValidityDateField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.requestedValidityDateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InstalmentType Instalment
		{
			get
			{
				return this.instalmentField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.instalmentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CustomerOrderType CustomerOrder
		{
			get
			{
				return this.customerOrderField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.customerOrderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentInstrumentDataType PaymentInstrumentData
		{
			get
			{
				return this.paymentInstrumentDataField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.paymentInstrumentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Normal")]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.paymentTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool SplitPaymentFlag
		{
			get
			{
				return this.splitPaymentFlagField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = true;
				this.splitPaymentFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentDataTypeInitFlag
		{
			get
			{
				return this.xsdPaymentDataTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("91108da6-94a2-411e-b4d7-dbb472d5a347")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InstalmentType : IInstalmentType
	{
		internal string instalmentType1Field;
		internal string sequenceNumberField;
		internal string planIDField;
		internal string periodField;
		internal string periodUnitField;
		internal string firstPaymentDateField;
		internal string totalNbOfPaymentsField;
		internal double cumulativeAmountField;
		internal bool cumulativeAmountFieldSpecified;
		internal double firstAmountField;
		internal bool firstAmountFieldSpecified;
		internal double chargesField;
		internal bool chargesFieldSpecified;
		internal bool xsdInstalmentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InstalmentType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string InstalmentType1
		{
			get
			{
				return this.instalmentType1Field;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.instalmentType1Field = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string SequenceNumber
		{
			get
			{
				return this.sequenceNumberField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.sequenceNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PlanID
		{
			get
			{
				return this.planIDField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.planIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string Period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.periodField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PeriodUnit
		{
			get
			{
				return this.periodUnitField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.periodUnitField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string FirstPaymentDate
		{
			get
			{
				return this.firstPaymentDateField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.firstPaymentDateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string TotalNbOfPayments
		{
			get
			{
				return this.totalNbOfPaymentsField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.totalNbOfPaymentsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CumulativeAmount
		{
			get
			{
				return this.cumulativeAmountField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.cumulativeAmountField = value;
				this.CumulativeAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CumulativeAmountSpecified
		{
			get
			{
				return this.cumulativeAmountFieldSpecified;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.cumulativeAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double FirstAmount
		{
			get
			{
				return this.firstAmountField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.firstAmountField = value;
				this.FirstAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool FirstAmountSpecified
		{
			get
			{
				return this.firstAmountFieldSpecified;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.firstAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double Charges
		{
			get
			{
				return this.chargesField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.chargesField = value;
				this.ChargesSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ChargesSpecified
		{
			get
			{
				return this.chargesFieldSpecified;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = true;
				this.chargesFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInstalmentTypeInitFlag
		{
			get
			{
				return this.xsdInstalmentTypeInitFlagField;
			}
			set
			{
				this.xsdInstalmentTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d13c8b32-2792-456f-82c8-54f92492161f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReversalRequestType : IReversalRequestType
	{
		internal SaleDataType saleDataField = new SaleDataType();
		internal OriginalPOITransactionType originalPOITransactionField = new OriginalPOITransactionType();
		internal CustomerOrderType customerOrderField = new CustomerOrderType();
		internal string reversalReasonField;
		internal double reversedAmountField;
		internal bool reversedAmountFieldSpecified;
		internal bool xsdReversalRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OriginalPOITransactionType OriginalPOITransaction
		{
			get
			{
				return this.originalPOITransactionField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.originalPOITransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CustomerOrderType CustomerOrder
		{
			get
			{
				return this.customerOrderField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.customerOrderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ReversalReason
		{
			get
			{
				return this.reversalReasonField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.reversalReasonField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ReversedAmount
		{
			get
			{
				return this.reversedAmountField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.reversedAmountField = value;
				this.ReversedAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ReversedAmountSpecified
		{
			get
			{
				return this.reversedAmountFieldSpecified;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = true;
				this.reversedAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdReversalRequestTypeInitFlag
		{
			get
			{
				return this.xsdReversalRequestTypeInitFlagField;
			}
			set
			{
				this.xsdReversalRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("538b800e-eb45-4c92-8088-d1e988cd1a48")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class BatchResponseType : IBatchResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal PerformedTransactionType[] performedTransactionField = new PerformedTransactionType[0];
		internal bool xsdBatchResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdBatchResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PerformedTransaction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PerformedTransactionType[] PerformedTransaction
		{
			get
			{
				if (((this.performedTransactionField == null)
								|| (this.performedTransactionField.Length == 0)))
				{
					return null;
				}
				return this.performedTransactionField;
			}
			set
			{
				this.xsdBatchResponseTypeInitFlagField = true;
				this.performedTransactionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdBatchResponseTypeInitFlag
		{
			get
			{
				return this.xsdBatchResponseTypeInitFlagField;
			}
			set
			{
				this.xsdBatchResponseTypeInitFlagField = value;
			}
		}
		public int PerformedTransactionSize()
		{
			if ((this.performedTransactionField == null))
			{
				return 0;
			}
			else
			{
				return this.performedTransactionField.Length;
			}
		}
		public PerformedTransactionType PerformedTransactionGetItem(int index)
		{
			try
			{
				if ((this.performedTransactionField == default(PerformedTransactionType[])))
				{
					return default(PerformedTransactionType);
				}
				else
				{
					if (((this.performedTransactionField.Length - 1)
									>= index))
					{
						return this.performedTransactionField[index];
					}
					else
					{
						return default(PerformedTransactionType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PerformedTransactionType);
			}
		}
		public bool PerformedTransactionSetItem(int index, PerformedTransactionType value)
		{
			try
			{
				if ((this.performedTransactionField == default(PerformedTransactionType[])))
				{
					return false;
				}
				else
				{
					this.performedTransactionField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PerformedTransactionAddItem(PerformedTransactionType value)
		{
			try
			{
				if ((this.performedTransactionField == default(PerformedTransactionType[])))
				{
					return false;
				}
				else
				{
					PerformedTransactionType[] array = new PerformedTransactionType[(this.performedTransactionField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.performedTransactionField.Length); i = (i + 1))
					{
						array[i] = performedTransactionField[i];
					}
					array[i] = value;
					this.PerformedTransaction = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PerformedTransactionRemoveItem(int index)
		{
			try
			{
				if ((this.performedTransactionField == default(PerformedTransactionType[])))
				{
					return false;
				}
				else
				{
					if ((this.performedTransactionField.Length <= index))
					{
						return false;
					}
					else
					{
						PerformedTransactionType[] array = new PerformedTransactionType[(this.performedTransactionField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = performedTransactionField[i];
						}
						for (i = (i + 1); (i < this.performedTransactionField.Length); i = (i + 1))
						{
							array[i] = performedTransactionField[i];
						}
						this.PerformedTransaction = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("cdc53792-6706-45d5-93be-d01dafc93877")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PerformedTransactionType : IPerformedTransactionType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal PaymentResultType paymentResultField = new PaymentResultType();
		internal LoyaltyResultType[] loyaltyResultField = new LoyaltyResultType[0];
		internal double reversedAmountField;
		internal bool reversedAmountFieldSpecified;
		internal bool xsdPerformedTransactionTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentResultType PaymentResult
		{
			get
			{
				return this.paymentResultField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.paymentResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyResultType[] LoyaltyResult
		{
			get
			{
				if (((this.loyaltyResultField == null)
								|| (this.loyaltyResultField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyResultField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.loyaltyResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ReversedAmount
		{
			get
			{
				return this.reversedAmountField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.reversedAmountField = value;
				this.ReversedAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ReversedAmountSpecified
		{
			get
			{
				return this.reversedAmountFieldSpecified;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = true;
				this.reversedAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPerformedTransactionTypeInitFlag
		{
			get
			{
				return this.xsdPerformedTransactionTypeInitFlagField;
			}
			set
			{
				this.xsdPerformedTransactionTypeInitFlagField = value;
			}
		}
		public int LoyaltyResultSize()
		{
			if ((this.loyaltyResultField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyResultField.Length;
			}
		}
		public LoyaltyResultType LoyaltyResultGetItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return default(LoyaltyResultType);
				}
				else
				{
					if (((this.loyaltyResultField.Length - 1)
									>= index))
					{
						return this.loyaltyResultField[index];
					}
					else
					{
						return default(LoyaltyResultType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyResultType);
			}
		}
		public bool LoyaltyResultSetItem(int index, LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyResultField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultAddItem(LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyResultField.Length); i = (i + 1))
					{
						array[i] = loyaltyResultField[i];
					}
					array[i] = value;
					this.LoyaltyResult = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyResultField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						for (i = (i + 1); (i < this.loyaltyResultField.Length); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						this.LoyaltyResult = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("701cfa67-4bd3-4a71-863e-b5245c0e0432")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POIDataType : IPOIDataType
	{
		internal TransactionIdentificationType pOITransactionIDField = new TransactionIdentificationType();
		internal string pOIReconciliationIDField;
		internal bool xsdPOIDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType POITransactionID
		{
			get
			{
				return this.pOITransactionIDField;
			}
			set
			{
				this.xsdPOIDataTypeInitFlagField = true;
				this.pOITransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIReconciliationID
		{
			get
			{
				return this.pOIReconciliationIDField;
			}
			set
			{
				this.xsdPOIDataTypeInitFlagField = true;
				this.pOIReconciliationIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOIDataTypeInitFlag
		{
			get
			{
				return this.xsdPOIDataTypeInitFlagField;
			}
			set
			{
				this.xsdPOIDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ed4489ce-cbda-435c-adb4-e570f3e5c970")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentResultType : IPaymentResultType
	{
		internal PaymentInstrumentDataType paymentInstrumentDataField = new PaymentInstrumentDataType();
		internal AmountsRespType amountsRespField = new AmountsRespType();
		internal InstalmentType instalmentField = new InstalmentType();
		internal CurrencyConversionType[] currencyConversionField = new CurrencyConversionType[0];
		internal CapturedSignatureType capturedSignatureField = new CapturedSignatureType();
		internal ContentInformationType protectedSignatureField = new ContentInformationType();
		internal PaymentAcquirerDataType paymentAcquirerDataField = new PaymentAcquirerDataType();
		internal string paymentTypeField;
		internal bool merchantOverrideFlagField;
		internal string customerLanguageField;
		internal bool onlineFlagField;
		internal string[] authenticationMethodField = new string[0];
		internal string validityDateField;
		internal bool xsdPaymentResultTypeInitFlagField = false;
		public PaymentResultType()
		{
			this.paymentTypeField = "Normal";
			this.merchantOverrideFlagField = false;
			this.onlineFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentInstrumentDataType PaymentInstrumentData
		{
			get
			{
				return this.paymentInstrumentDataField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.paymentInstrumentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AmountsRespType AmountsResp
		{
			get
			{
				return this.amountsRespField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.amountsRespField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InstalmentType Instalment
		{
			get
			{
				return this.instalmentField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.instalmentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CurrencyConversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CurrencyConversionType[] CurrencyConversion
		{
			get
			{
				if (((this.currencyConversionField == null)
								|| (this.currencyConversionField.Length == 0)))
				{
					return null;
				}
				return this.currencyConversionField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.currencyConversionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CapturedSignatureType CapturedSignature
		{
			get
			{
				return this.capturedSignatureField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.capturedSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType ProtectedSignature
		{
			get
			{
				return this.protectedSignatureField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.protectedSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentAcquirerDataType PaymentAcquirerData
		{
			get
			{
				return this.paymentAcquirerDataField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.paymentAcquirerDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Normal")]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.paymentTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool MerchantOverrideFlag
		{
			get
			{
				return this.merchantOverrideFlagField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.merchantOverrideFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool OnlineFlag
		{
			get
			{
				return this.onlineFlagField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.onlineFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] AuthenticationMethod
		{
			get
			{
				if (((this.authenticationMethodField == null)
								|| (this.authenticationMethodField.Length == 0)))
				{
					return null;
				}
				return this.authenticationMethodField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.authenticationMethodField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ValidityDate
		{
			get
			{
				return this.validityDateField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = true;
				this.validityDateField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentResultTypeInitFlag
		{
			get
			{
				return this.xsdPaymentResultTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentResultTypeInitFlagField = value;
			}
		}
		public int CurrencyConversionSize()
		{
			if ((this.currencyConversionField == null))
			{
				return 0;
			}
			else
			{
				return this.currencyConversionField.Length;
			}
		}
		public CurrencyConversionType CurrencyConversionGetItem(int index)
		{
			try
			{
				if ((this.currencyConversionField == default(CurrencyConversionType[])))
				{
					return default(CurrencyConversionType);
				}
				else
				{
					if (((this.currencyConversionField.Length - 1)
									>= index))
					{
						return this.currencyConversionField[index];
					}
					else
					{
						return default(CurrencyConversionType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CurrencyConversionType);
			}
		}
		public bool CurrencyConversionSetItem(int index, CurrencyConversionType value)
		{
			try
			{
				if ((this.currencyConversionField == default(CurrencyConversionType[])))
				{
					return false;
				}
				else
				{
					this.currencyConversionField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CurrencyConversionAddItem(CurrencyConversionType value)
		{
			try
			{
				if ((this.currencyConversionField == default(CurrencyConversionType[])))
				{
					return false;
				}
				else
				{
					CurrencyConversionType[] array = new CurrencyConversionType[(this.currencyConversionField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.currencyConversionField.Length); i = (i + 1))
					{
						array[i] = currencyConversionField[i];
					}
					array[i] = value;
					this.CurrencyConversion = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CurrencyConversionRemoveItem(int index)
		{
			try
			{
				if ((this.currencyConversionField == default(CurrencyConversionType[])))
				{
					return false;
				}
				else
				{
					if ((this.currencyConversionField.Length <= index))
					{
						return false;
					}
					else
					{
						CurrencyConversionType[] array = new CurrencyConversionType[(this.currencyConversionField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = currencyConversionField[i];
						}
						for (i = (i + 1); (i < this.currencyConversionField.Length); i = (i + 1))
						{
							array[i] = currencyConversionField[i];
						}
						this.CurrencyConversion = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int AuthenticationMethodSize()
		{
			if ((this.authenticationMethodField == null))
			{
				return 0;
			}
			else
			{
				return this.authenticationMethodField.Length;
			}
		}
		public string AuthenticationMethodGetItem(int index)
		{
			try
			{
				if ((this.authenticationMethodField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.authenticationMethodField.Length - 1)
									>= index))
					{
						return this.authenticationMethodField[index];
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
		}
		public bool AuthenticationMethodSetItem(int index, string value)
		{
			try
			{
				if ((this.authenticationMethodField == default(string[])))
				{
					return false;
				}
				else
				{
					this.authenticationMethodField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AuthenticationMethodAddItem(string value)
		{
			try
			{
				if ((this.authenticationMethodField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.authenticationMethodField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.authenticationMethodField.Length); i = (i + 1))
					{
						array[i] = authenticationMethodField[i];
					}
					array[i] = value;
					this.AuthenticationMethod = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AuthenticationMethodRemoveItem(int index)
		{
			try
			{
				if ((this.authenticationMethodField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.authenticationMethodField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.authenticationMethodField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = authenticationMethodField[i];
						}
						for (i = (i + 1); (i < this.authenticationMethodField.Length); i = (i + 1))
						{
							array[i] = authenticationMethodField[i];
						}
						this.AuthenticationMethod = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("37d9c91e-c38e-4d5e-a1f0-e52b72d9e94c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CurrencyConversionType : ICurrencyConversionType
	{
		internal AmountType convertedAmountField = new AmountType();
		internal double commissionField;
		internal bool commissionFieldSpecified;
		internal string declarationField;
		internal bool customerApprovedFlagField;
		internal double rateField;
		internal bool rateFieldSpecified;
		internal double markupField;
		internal bool markupFieldSpecified;
		internal bool xsdCurrencyConversionTypeInitFlagField = false;
		public CurrencyConversionType()
		{
			this.customerApprovedFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AmountType ConvertedAmount
		{
			get
			{
				return this.convertedAmountField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.convertedAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double Commission
		{
			get
			{
				return this.commissionField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.commissionField = value;
				this.CommissionSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CommissionSpecified
		{
			get
			{
				return this.commissionFieldSpecified;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.commissionFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Declaration
		{
			get
			{
				return this.declarationField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.declarationField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool CustomerApprovedFlag
		{
			get
			{
				return this.customerApprovedFlagField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.customerApprovedFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double Rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.rateField = value;
				this.RateSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RateSpecified
		{
			get
			{
				return this.rateFieldSpecified;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.rateFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double Markup
		{
			get
			{
				return this.markupField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.markupField = value;
				this.MarkupSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MarkupSpecified
		{
			get
			{
				return this.markupFieldSpecified;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = true;
				this.markupFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCurrencyConversionTypeInitFlag
		{
			get
			{
				return this.xsdCurrencyConversionTypeInitFlagField;
			}
			set
			{
				this.xsdCurrencyConversionTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2d69db03-9d20-4811-b056-e94e2e1b8ba2")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class AmountType : IAmountType
	{
		internal string currencyField;
		internal double valueField;
		internal bool xsdAmountTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdAmountTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public double Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdAmountTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdAmountTypeInitFlag
		{
			get
			{
				return this.xsdAmountTypeInitFlagField;
			}
			set
			{
				this.xsdAmountTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("13df9af5-52f3-4833-9f39-79f7bc2f6a01")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CapturedSignatureType : ICapturedSignatureType
	{
		internal RawSignatureType rawSignatureField = new RawSignatureType();
		internal SignatureImageType signatureImageField = new SignatureImageType();
		internal bool xsdCapturedSignatureTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RawSignatureType RawSignature
		{
			get
			{
				return this.rawSignatureField;
			}
			set
			{
				this.xsdCapturedSignatureTypeInitFlagField = true;
				this.rawSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SignatureImageType SignatureImage
		{
			get
			{
				return this.signatureImageField;
			}
			set
			{
				this.xsdCapturedSignatureTypeInitFlagField = true;
				this.signatureImageField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCapturedSignatureTypeInitFlag
		{
			get
			{
				return this.xsdCapturedSignatureTypeInitFlagField;
			}
			set
			{
				this.xsdCapturedSignatureTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("8419b462-2d63-4425-8574-4ee22d135b5d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class RawSignatureType : IRawSignatureType
	{
		internal AreaSizeType areaSizeField = new AreaSizeType();
		internal SignaturePointType[] signaturePointField = new SignaturePointType[0];
		internal bool xsdRawSignatureTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AreaSizeType AreaSize
		{
			get
			{
				return this.areaSizeField;
			}
			set
			{
				this.xsdRawSignatureTypeInitFlagField = true;
				this.areaSizeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SignaturePoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SignaturePointType[] SignaturePoint
		{
			get
			{
				if (((this.signaturePointField == null)
								|| (this.signaturePointField.Length == 0)))
				{
					return null;
				}
				return this.signaturePointField;
			}
			set
			{
				this.xsdRawSignatureTypeInitFlagField = true;
				this.signaturePointField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdRawSignatureTypeInitFlag
		{
			get
			{
				return this.xsdRawSignatureTypeInitFlagField;
			}
			set
			{
				this.xsdRawSignatureTypeInitFlagField = value;
			}
		}
		public int SignaturePointSize()
		{
			if ((this.signaturePointField == null))
			{
				return 0;
			}
			else
			{
				return this.signaturePointField.Length;
			}
		}
		public SignaturePointType SignaturePointGetItem(int index)
		{
			try
			{
				if ((this.signaturePointField == default(SignaturePointType[])))
				{
					return default(SignaturePointType);
				}
				else
				{
					if (((this.signaturePointField.Length - 1)
									>= index))
					{
						return this.signaturePointField[index];
					}
					else
					{
						return default(SignaturePointType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SignaturePointType);
			}
		}
		public bool SignaturePointSetItem(int index, SignaturePointType value)
		{
			try
			{
				if ((this.signaturePointField == default(SignaturePointType[])))
				{
					return false;
				}
				else
				{
					this.signaturePointField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignaturePointAddItem(SignaturePointType value)
		{
			try
			{
				if ((this.signaturePointField == default(SignaturePointType[])))
				{
					return false;
				}
				else
				{
					SignaturePointType[] array = new SignaturePointType[(this.signaturePointField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.signaturePointField.Length); i = (i + 1))
					{
						array[i] = signaturePointField[i];
					}
					array[i] = value;
					this.SignaturePoint = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SignaturePointRemoveItem(int index)
		{
			try
			{
				if ((this.signaturePointField == default(SignaturePointType[])))
				{
					return false;
				}
				else
				{
					if ((this.signaturePointField.Length <= index))
					{
						return false;
					}
					else
					{
						SignaturePointType[] array = new SignaturePointType[(this.signaturePointField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = signaturePointField[i];
						}
						for (i = (i + 1); (i < this.signaturePointField.Length); i = (i + 1))
						{
							array[i] = signaturePointField[i];
						}
						this.SignaturePoint = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("18c2eec7-0c60-410c-8313-2205806ec22f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SignaturePointType : ISignaturePointType
	{
		internal string xField;
		internal string yField;
		internal bool xsdSignaturePointTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string X
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xsdSignaturePointTypeInitFlagField = true;
				this.xField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.xsdSignaturePointTypeInitFlagField = true;
				this.yField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSignaturePointTypeInitFlag
		{
			get
			{
				return this.xsdSignaturePointTypeInitFlagField;
			}
			set
			{
				this.xsdSignaturePointTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d40b25ac-f894-4357-a5ff-45e74e99212b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SignatureImageType : ISignatureImageType
	{
		internal string imageFormatField;
		internal byte[] imageDataField = new byte[0];
		internal string imageReferenceField;
		internal bool xsdSignatureImageTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ImageFormat
		{
			get
			{
				return this.imageFormatField;
			}
			set
			{
				this.xsdSignatureImageTypeInitFlagField = true;
				this.imageFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] ImageData
		{
			get
			{
				if (((this.imageDataField == null)
								|| (this.imageDataField.Length == 0)))
				{
					return null;
				}
				return this.imageDataField;
			}
			set
			{
				this.xsdSignatureImageTypeInitFlagField = true;
				this.imageDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ImageReference
		{
			get
			{
				return this.imageReferenceField;
			}
			set
			{
				this.xsdSignatureImageTypeInitFlagField = true;
				this.imageReferenceField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSignatureImageTypeInitFlag
		{
			get
			{
				return this.xsdSignatureImageTypeInitFlagField;
			}
			set
			{
				this.xsdSignatureImageTypeInitFlagField = value;
			}
		}
		public int ImageDataSize()
		{
			if ((this.imageDataField == null))
			{
				return 0;
			}
			else
			{
				return this.imageDataField.Length;
			}
		}
		public byte ImageDataGetItem(int index)
		{
			try
			{
				if ((this.imageDataField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.imageDataField.Length - 1)
									>= index))
					{
						return this.imageDataField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool ImageDataSetItem(int index, byte value)
		{
			try
			{
				if ((this.imageDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.imageDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ImageDataAddItem(byte value)
		{
			try
			{
				if ((this.imageDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.imageDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.imageDataField.Length); i = (i + 1))
					{
						array[i] = imageDataField[i];
					}
					array[i] = value;
					this.ImageData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ImageDataRemoveItem(int index)
		{
			try
			{
				if ((this.imageDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.imageDataField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.imageDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = imageDataField[i];
						}
						for (i = (i + 1); (i < this.imageDataField.Length); i = (i + 1))
						{
							array[i] = imageDataField[i];
						}
						this.ImageData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("863c8d37-9045-45b8-8974-d16f39c53ce4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyResultType : ILoyaltyResultType
	{
		internal LoyaltyAccountType loyaltyAccountField = new LoyaltyAccountType();
		internal LoyaltyAmountType loyaltyAmountField = new LoyaltyAmountType();
		internal LoyaltyAcquirerDataType loyaltyAcquirerDataField = new LoyaltyAcquirerDataType();
		internal RebatesType rebatesField = new RebatesType();
		internal double currentBalanceField;
		internal bool currentBalanceFieldSpecified;
		internal bool xsdLoyaltyResultTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountType LoyaltyAccount
		{
			get
			{
				return this.loyaltyAccountField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.loyaltyAccountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAmountType LoyaltyAmount
		{
			get
			{
				return this.loyaltyAmountField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.loyaltyAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAcquirerDataType LoyaltyAcquirerData
		{
			get
			{
				return this.loyaltyAcquirerDataField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.loyaltyAcquirerDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RebatesType Rebates
		{
			get
			{
				return this.rebatesField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.rebatesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CurrentBalance
		{
			get
			{
				return this.currentBalanceField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.currentBalanceField = value;
				this.CurrentBalanceSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CurrentBalanceSpecified
		{
			get
			{
				return this.currentBalanceFieldSpecified;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = true;
				this.currentBalanceFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyResultTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyResultTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyResultTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("abd276cb-4014-4a91-91c6-9af895a0c1f8")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyAcquirerDataType : ILoyaltyAcquirerDataType
	{
		internal string approvalCodeField;
		internal TransactionIdentificationType loyaltyTransactionIDField = new TransactionIdentificationType();
		internal string loyaltyAcquirerIDField;
		internal string hostReconciliationIDField;
		internal bool xsdLoyaltyAcquirerDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ApprovalCode
		{
			get
			{
				return this.approvalCodeField;
			}
			set
			{
				this.xsdLoyaltyAcquirerDataTypeInitFlagField = true;
				this.approvalCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType LoyaltyTransactionID
		{
			get
			{
				return this.loyaltyTransactionIDField;
			}
			set
			{
				this.xsdLoyaltyAcquirerDataTypeInitFlagField = true;
				this.loyaltyTransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string LoyaltyAcquirerID
		{
			get
			{
				return this.loyaltyAcquirerIDField;
			}
			set
			{
				this.xsdLoyaltyAcquirerDataTypeInitFlagField = true;
				this.loyaltyAcquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string HostReconciliationID
		{
			get
			{
				return this.hostReconciliationIDField;
			}
			set
			{
				this.xsdLoyaltyAcquirerDataTypeInitFlagField = true;
				this.hostReconciliationIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyAcquirerDataTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyAcquirerDataTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyAcquirerDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d0796fe9-382a-4db8-8830-ae9383075110")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class RebatesType : IRebatesType
	{
		internal double totalRebateField;
		internal bool totalRebateFieldSpecified;
		internal string rebateLabelField;
		internal SaleItemRebateType[] saleItemRebateField = new SaleItemRebateType[0];
		internal bool xsdRebatesTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double TotalRebate
		{
			get
			{
				return this.totalRebateField;
			}
			set
			{
				this.xsdRebatesTypeInitFlagField = true;
				this.totalRebateField = value;
				this.TotalRebateSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalRebateSpecified
		{
			get
			{
				return this.totalRebateFieldSpecified;
			}
			set
			{
				this.xsdRebatesTypeInitFlagField = true;
				this.totalRebateFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string RebateLabel
		{
			get
			{
				return this.rebateLabelField;
			}
			set
			{
				this.xsdRebatesTypeInitFlagField = true;
				this.rebateLabelField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SaleItemRebate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleItemRebateType[] SaleItemRebate
		{
			get
			{
				if (((this.saleItemRebateField == null)
								|| (this.saleItemRebateField.Length == 0)))
				{
					return null;
				}
				return this.saleItemRebateField;
			}
			set
			{
				this.xsdRebatesTypeInitFlagField = true;
				this.saleItemRebateField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdRebatesTypeInitFlag
		{
			get
			{
				return this.xsdRebatesTypeInitFlagField;
			}
			set
			{
				this.xsdRebatesTypeInitFlagField = value;
			}
		}
		public int SaleItemRebateSize()
		{
			if ((this.saleItemRebateField == null))
			{
				return 0;
			}
			else
			{
				return this.saleItemRebateField.Length;
			}
		}
		public SaleItemRebateType SaleItemRebateGetItem(int index)
		{
			try
			{
				if ((this.saleItemRebateField == default(SaleItemRebateType[])))
				{
					return default(SaleItemRebateType);
				}
				else
				{
					if (((this.saleItemRebateField.Length - 1)
									>= index))
					{
						return this.saleItemRebateField[index];
					}
					else
					{
						return default(SaleItemRebateType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SaleItemRebateType);
			}
		}
		public bool SaleItemRebateSetItem(int index, SaleItemRebateType value)
		{
			try
			{
				if ((this.saleItemRebateField == default(SaleItemRebateType[])))
				{
					return false;
				}
				else
				{
					this.saleItemRebateField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemRebateAddItem(SaleItemRebateType value)
		{
			try
			{
				if ((this.saleItemRebateField == default(SaleItemRebateType[])))
				{
					return false;
				}
				else
				{
					SaleItemRebateType[] array = new SaleItemRebateType[(this.saleItemRebateField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.saleItemRebateField.Length); i = (i + 1))
					{
						array[i] = saleItemRebateField[i];
					}
					array[i] = value;
					this.SaleItemRebate = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SaleItemRebateRemoveItem(int index)
		{
			try
			{
				if ((this.saleItemRebateField == default(SaleItemRebateType[])))
				{
					return false;
				}
				else
				{
					if ((this.saleItemRebateField.Length <= index))
					{
						return false;
					}
					else
					{
						SaleItemRebateType[] array = new SaleItemRebateType[(this.saleItemRebateField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = saleItemRebateField[i];
						}
						for (i = (i + 1); (i < this.saleItemRebateField.Length); i = (i + 1))
						{
							array[i] = saleItemRebateField[i];
						}
						this.SaleItemRebate = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b2e56f80-05ca-4f32-bec3-f2c6b6400dfa")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleItemRebateType : ISaleItemRebateType
	{
		internal string unitOfMeasureField;
		internal double quantityField;
		internal bool quantityFieldSpecified;
		internal string rebateLabelField;
		internal string itemIDField;
		internal string productCodeField;
		internal string eanUpcField;
		internal double itemAmountField;
		internal bool itemAmountFieldSpecified;
		internal bool xsdSaleItemRebateTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string UnitOfMeasure
		{
			get
			{
				return this.unitOfMeasureField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.unitOfMeasureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.quantityField = value;
				this.QuantitySpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.quantityFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string RebateLabel
		{
			get
			{
				return this.rebateLabelField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.rebateLabelField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ItemID
		{
			get
			{
				return this.itemIDField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.itemIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProductCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.productCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EanUpc
		{
			get
			{
				return this.eanUpcField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.eanUpcField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.itemAmountField = value;
				this.ItemAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ItemAmountSpecified
		{
			get
			{
				return this.itemAmountFieldSpecified;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = true;
				this.itemAmountFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleItemRebateTypeInitFlag
		{
			get
			{
				return this.xsdSaleItemRebateTypeInitFlagField;
			}
			set
			{
				this.xsdSaleItemRebateTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e724a3cc-39c1-4491-ad45-1220fd2b202c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardAcquisitionRequestType : ICardAcquisitionRequestType
	{
		internal SaleDataType saleDataField = new SaleDataType();
		internal CardAcquisitionTransactionType cardAcquisitionTransactionField = new CardAcquisitionTransactionType();
		internal bool xsdCardAcquisitionRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdCardAcquisitionRequestTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CardAcquisitionTransactionType CardAcquisitionTransaction
		{
			get
			{
				return this.cardAcquisitionTransactionField;
			}
			set
			{
				this.xsdCardAcquisitionRequestTypeInitFlagField = true;
				this.cardAcquisitionTransactionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardAcquisitionRequestTypeInitFlag
		{
			get
			{
				return this.xsdCardAcquisitionRequestTypeInitFlagField;
			}
			set
			{
				this.xsdCardAcquisitionRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0a046ffd-b3b4-4ab7-9422-70ff8bfe57dc")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardAcquisitionTransactionType : ICardAcquisitionTransactionType
	{
		internal string[] allowedPaymentBrandField = new string[0];
		internal string[] allowedLoyaltyBrandField = new string[0];
		internal string[] forceEntryModeField = new string[0];
		internal string loyaltyHandlingField;
		internal string customerLanguageField;
		internal bool forceCustomerSelectionFlagField;
		internal double totalAmountField;
		internal bool totalAmountFieldSpecified;
		internal string paymentTypeField;
		internal bool cashBackFlagField;
		internal bool cashBackFlagFieldSpecified;
		internal bool xsdCardAcquisitionTransactionTypeInitFlagField = false;
		public CardAcquisitionTransactionType()
		{
			this.loyaltyHandlingField = "Allowed";
			this.forceCustomerSelectionFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedPaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AllowedPaymentBrand
		{
			get
			{
				if (((this.allowedPaymentBrandField == null)
								|| (this.allowedPaymentBrandField.Length == 0)))
				{
					return null;
				}
				return this.allowedPaymentBrandField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.allowedPaymentBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AllowedLoyaltyBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AllowedLoyaltyBrand
		{
			get
			{
				if (((this.allowedLoyaltyBrandField == null)
								|| (this.allowedLoyaltyBrandField.Length == 0)))
				{
					return null;
				}
				return this.allowedLoyaltyBrandField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.allowedLoyaltyBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] ForceEntryMode
		{
			get
			{
				if (((this.forceEntryModeField == null)
								|| (this.forceEntryModeField.Length == 0)))
				{
					return null;
				}
				return this.forceEntryModeField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.forceEntryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Allowed")]
		public string LoyaltyHandling
		{
			get
			{
				return this.loyaltyHandlingField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.loyaltyHandlingField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ForceCustomerSelectionFlag
		{
			get
			{
				return this.forceCustomerSelectionFlagField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.forceCustomerSelectionFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TotalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.totalAmountField = value;
				this.TotalAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TotalAmountSpecified
		{
			get
			{
				return this.totalAmountFieldSpecified;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.totalAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.paymentTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CashBackFlag
		{
			get
			{
				return this.cashBackFlagField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.cashBackFlagField = value;
				this.CashBackFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CashBackFlagSpecified
		{
			get
			{
				return this.cashBackFlagFieldSpecified;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = true;
				this.cashBackFlagFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardAcquisitionTransactionTypeInitFlag
		{
			get
			{
				return this.xsdCardAcquisitionTransactionTypeInitFlagField;
			}
			set
			{
				this.xsdCardAcquisitionTransactionTypeInitFlagField = value;
			}
		}
		public int AllowedPaymentBrandSize()
		{
			if ((this.allowedPaymentBrandField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedPaymentBrandField.Length;
			}
		}
		public string AllowedPaymentBrandGetItem(int index)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.allowedPaymentBrandField.Length - 1)
									>= index))
					{
						return this.allowedPaymentBrandField[index];
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
		}
		public bool AllowedPaymentBrandSetItem(int index, string value)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					this.allowedPaymentBrandField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedPaymentBrandAddItem(string value)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.allowedPaymentBrandField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedPaymentBrandField.Length); i = (i + 1))
					{
						array[i] = allowedPaymentBrandField[i];
					}
					array[i] = value;
					this.AllowedPaymentBrand = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedPaymentBrandRemoveItem(int index)
		{
			try
			{
				if ((this.allowedPaymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedPaymentBrandField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.allowedPaymentBrandField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedPaymentBrandField[i];
						}
						for (i = (i + 1); (i < this.allowedPaymentBrandField.Length); i = (i + 1))
						{
							array[i] = allowedPaymentBrandField[i];
						}
						this.AllowedPaymentBrand = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int AllowedLoyaltyBrandSize()
		{
			if ((this.allowedLoyaltyBrandField == null))
			{
				return 0;
			}
			else
			{
				return this.allowedLoyaltyBrandField.Length;
			}
		}
		public string AllowedLoyaltyBrandGetItem(int index)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.allowedLoyaltyBrandField.Length - 1)
									>= index))
					{
						return this.allowedLoyaltyBrandField[index];
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
		}
		public bool AllowedLoyaltyBrandSetItem(int index, string value)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					this.allowedLoyaltyBrandField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedLoyaltyBrandAddItem(string value)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.allowedLoyaltyBrandField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.allowedLoyaltyBrandField.Length); i = (i + 1))
					{
						array[i] = allowedLoyaltyBrandField[i];
					}
					array[i] = value;
					this.AllowedLoyaltyBrand = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AllowedLoyaltyBrandRemoveItem(int index)
		{
			try
			{
				if ((this.allowedLoyaltyBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.allowedLoyaltyBrandField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.allowedLoyaltyBrandField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = allowedLoyaltyBrandField[i];
						}
						for (i = (i + 1); (i < this.allowedLoyaltyBrandField.Length); i = (i + 1))
						{
							array[i] = allowedLoyaltyBrandField[i];
						}
						this.AllowedLoyaltyBrand = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int ForceEntryModeSize()
		{
			if ((this.forceEntryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.forceEntryModeField.Length;
			}
		}
		public string ForceEntryModeGetItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.forceEntryModeField.Length - 1)
									>= index))
					{
						return this.forceEntryModeField[index];
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
		}
		public bool ForceEntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.forceEntryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeAddItem(string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.forceEntryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.forceEntryModeField.Length); i = (i + 1))
					{
						array[i] = forceEntryModeField[i];
					}
					array[i] = value;
					this.ForceEntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.forceEntryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.forceEntryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						for (i = (i + 1); (i < this.forceEntryModeField.Length); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						this.ForceEntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("690a3228-7195-45fd-87df-75162cb300c7")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardAcquisitionResponseType : ICardAcquisitionResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal string[] paymentBrandField = new string[0];
		internal PaymentInstrumentDataType paymentInstrumentDataField = new PaymentInstrumentDataType();
		internal LoyaltyAccountType[] loyaltyAccountField = new LoyaltyAccountType[0];
		internal CustomerOrderType[] customerOrderField = new CustomerOrderType[0];
		internal bool xsdCardAcquisitionResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentBrand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PaymentBrand
		{
			get
			{
				if (((this.paymentBrandField == null)
								|| (this.paymentBrandField.Length == 0)))
				{
					return null;
				}
				return this.paymentBrandField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.paymentBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentInstrumentDataType PaymentInstrumentData
		{
			get
			{
				return this.paymentInstrumentDataField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.paymentInstrumentDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyAccount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyAccountType[] LoyaltyAccount
		{
			get
			{
				if (((this.loyaltyAccountField == null)
								|| (this.loyaltyAccountField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyAccountField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.loyaltyAccountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CustomerOrderType[] CustomerOrder
		{
			get
			{
				if (((this.customerOrderField == null)
								|| (this.customerOrderField.Length == 0)))
				{
					return null;
				}
				return this.customerOrderField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = true;
				this.customerOrderField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardAcquisitionResponseTypeInitFlag
		{
			get
			{
				return this.xsdCardAcquisitionResponseTypeInitFlagField;
			}
			set
			{
				this.xsdCardAcquisitionResponseTypeInitFlagField = value;
			}
		}
		public int PaymentBrandSize()
		{
			if ((this.paymentBrandField == null))
			{
				return 0;
			}
			else
			{
				return this.paymentBrandField.Length;
			}
		}
		public string PaymentBrandGetItem(int index)
		{
			try
			{
				if ((this.paymentBrandField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.paymentBrandField.Length - 1)
									>= index))
					{
						return this.paymentBrandField[index];
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
		}
		public bool PaymentBrandSetItem(int index, string value)
		{
			try
			{
				if ((this.paymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					this.paymentBrandField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentBrandAddItem(string value)
		{
			try
			{
				if ((this.paymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.paymentBrandField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.paymentBrandField.Length); i = (i + 1))
					{
						array[i] = paymentBrandField[i];
					}
					array[i] = value;
					this.PaymentBrand = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentBrandRemoveItem(int index)
		{
			try
			{
				if ((this.paymentBrandField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.paymentBrandField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.paymentBrandField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = paymentBrandField[i];
						}
						for (i = (i + 1); (i < this.paymentBrandField.Length); i = (i + 1))
						{
							array[i] = paymentBrandField[i];
						}
						this.PaymentBrand = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int LoyaltyAccountSize()
		{
			if ((this.loyaltyAccountField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyAccountField.Length;
			}
		}
		public LoyaltyAccountType LoyaltyAccountGetItem(int index)
		{
			try
			{
				if ((this.loyaltyAccountField == default(LoyaltyAccountType[])))
				{
					return default(LoyaltyAccountType);
				}
				else
				{
					if (((this.loyaltyAccountField.Length - 1)
									>= index))
					{
						return this.loyaltyAccountField[index];
					}
					else
					{
						return default(LoyaltyAccountType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyAccountType);
			}
		}
		public bool LoyaltyAccountSetItem(int index, LoyaltyAccountType value)
		{
			try
			{
				if ((this.loyaltyAccountField == default(LoyaltyAccountType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyAccountField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyAccountAddItem(LoyaltyAccountType value)
		{
			try
			{
				if ((this.loyaltyAccountField == default(LoyaltyAccountType[])))
				{
					return false;
				}
				else
				{
					LoyaltyAccountType[] array = new LoyaltyAccountType[(this.loyaltyAccountField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyAccountField.Length); i = (i + 1))
					{
						array[i] = loyaltyAccountField[i];
					}
					array[i] = value;
					this.LoyaltyAccount = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyAccountRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyAccountField == default(LoyaltyAccountType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyAccountField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyAccountType[] array = new LoyaltyAccountType[(this.loyaltyAccountField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyAccountField[i];
						}
						for (i = (i + 1); (i < this.loyaltyAccountField.Length); i = (i + 1))
						{
							array[i] = loyaltyAccountField[i];
						}
						this.LoyaltyAccount = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CustomerOrderSize()
		{
			if ((this.customerOrderField == null))
			{
				return 0;
			}
			else
			{
				return this.customerOrderField.Length;
			}
		}
		public CustomerOrderType CustomerOrderGetItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return default(CustomerOrderType);
				}
				else
				{
					if (((this.customerOrderField.Length - 1)
									>= index))
					{
						return this.customerOrderField[index];
					}
					else
					{
						return default(CustomerOrderType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CustomerOrderType);
			}
		}
		public bool CustomerOrderSetItem(int index, CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					this.customerOrderField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderAddItem(CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.customerOrderField.Length); i = (i + 1))
					{
						array[i] = customerOrderField[i];
					}
					array[i] = value;
					this.CustomerOrder = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderRemoveItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					if ((this.customerOrderField.Length <= index))
					{
						return false;
					}
					else
					{
						CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						for (i = (i + 1); (i < this.customerOrderField.Length); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						this.CustomerOrder = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("46f3c0f1-9772-4d60-b1c7-6fdc68c7745b")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardholderPINType : ICardholderPINType
	{
		internal ContentInformationType encrPINBlockField = new ContentInformationType();
		internal string pINFormatField;
		internal string additionalInputField;
		internal bool xsdCardholderPINTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType EncrPINBlock
		{
			get
			{
				return this.encrPINBlockField;
			}
			set
			{
				this.xsdCardholderPINTypeInitFlagField = true;
				this.encrPINBlockField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PINFormat
		{
			get
			{
				return this.pINFormatField;
			}
			set
			{
				this.xsdCardholderPINTypeInitFlagField = true;
				this.pINFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AdditionalInput
		{
			get
			{
				return this.additionalInputField;
			}
			set
			{
				this.xsdCardholderPINTypeInitFlagField = true;
				this.additionalInputField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardholderPINTypeInitFlag
		{
			get
			{
				return this.xsdCardholderPINTypeInitFlagField;
			}
			set
			{
				this.xsdCardholderPINTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("8c754dd4-c481-44be-bc6b-73eaf6884a70")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderAPDURequestType : ICardReaderAPDURequestType
	{
		internal byte[] aPDUDataField = new byte[0];
		internal byte[] aPDUClassField = new byte[0];
		internal byte[] aPDUInstructionField = new byte[0];
		internal byte[] aPDUPar1Field = new byte[0];
		internal byte[] aPDUPar2Field = new byte[0];
		internal byte[] aPDUExpectedLengthField = new byte[0];
		internal bool xsdCardReaderAPDURequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] APDUData
		{
			get
			{
				if (((this.aPDUDataField == null)
								|| (this.aPDUDataField.Length == 0)))
				{
					return null;
				}
				return this.aPDUDataField;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] APDUClass
		{
			get
			{
				if (((this.aPDUClassField == null)
								|| (this.aPDUClassField.Length == 0)))
				{
					return null;
				}
				return this.aPDUClassField;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUClassField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] APDUInstruction
		{
			get
			{
				if (((this.aPDUInstructionField == null)
								|| (this.aPDUInstructionField.Length == 0)))
				{
					return null;
				}
				return this.aPDUInstructionField;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUInstructionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] APDUPar1
		{
			get
			{
				if (((this.aPDUPar1Field == null)
								|| (this.aPDUPar1Field.Length == 0)))
				{
					return null;
				}
				return this.aPDUPar1Field;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUPar1Field = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] APDUPar2
		{
			get
			{
				if (((this.aPDUPar2Field == null)
								|| (this.aPDUPar2Field.Length == 0)))
				{
					return null;
				}
				return this.aPDUPar2Field;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUPar2Field = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] APDUExpectedLength
		{
			get
			{
				if (((this.aPDUExpectedLengthField == null)
								|| (this.aPDUExpectedLengthField.Length == 0)))
				{
					return null;
				}
				return this.aPDUExpectedLengthField;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = true;
				this.aPDUExpectedLengthField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderAPDURequestTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderAPDURequestTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderAPDURequestTypeInitFlagField = value;
			}
		}
		public int APDUDataSize()
		{
			if ((this.aPDUDataField == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUDataField.Length;
			}
		}
		public byte APDUDataGetItem(int index)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUDataField.Length - 1)
									>= index))
					{
						return this.aPDUDataField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUDataSetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUDataAddItem(byte value)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUDataField.Length); i = (i + 1))
					{
						array[i] = aPDUDataField[i];
					}
					array[i] = value;
					this.APDUData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUDataRemoveItem(int index)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUDataField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUDataField[i];
						}
						for (i = (i + 1); (i < this.aPDUDataField.Length); i = (i + 1))
						{
							array[i] = aPDUDataField[i];
						}
						this.APDUData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int APDUClassSize()
		{
			if ((this.aPDUClassField == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUClassField.Length;
			}
		}
		public byte APDUClassGetItem(int index)
		{
			try
			{
				if ((this.aPDUClassField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUClassField.Length - 1)
									>= index))
					{
						return this.aPDUClassField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUClassSetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUClassField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUClassField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUClassAddItem(byte value)
		{
			try
			{
				if ((this.aPDUClassField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUClassField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUClassField.Length); i = (i + 1))
					{
						array[i] = aPDUClassField[i];
					}
					array[i] = value;
					this.APDUClass = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUClassRemoveItem(int index)
		{
			try
			{
				if ((this.aPDUClassField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUClassField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUClassField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUClassField[i];
						}
						for (i = (i + 1); (i < this.aPDUClassField.Length); i = (i + 1))
						{
							array[i] = aPDUClassField[i];
						}
						this.APDUClass = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int APDUInstructionSize()
		{
			if ((this.aPDUInstructionField == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUInstructionField.Length;
			}
		}
		public byte APDUInstructionGetItem(int index)
		{
			try
			{
				if ((this.aPDUInstructionField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUInstructionField.Length - 1)
									>= index))
					{
						return this.aPDUInstructionField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUInstructionSetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUInstructionField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUInstructionField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUInstructionAddItem(byte value)
		{
			try
			{
				if ((this.aPDUInstructionField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUInstructionField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUInstructionField.Length); i = (i + 1))
					{
						array[i] = aPDUInstructionField[i];
					}
					array[i] = value;
					this.APDUInstruction = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUInstructionRemoveItem(int index)
		{
			try
			{
				if ((this.aPDUInstructionField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUInstructionField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUInstructionField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUInstructionField[i];
						}
						for (i = (i + 1); (i < this.aPDUInstructionField.Length); i = (i + 1))
						{
							array[i] = aPDUInstructionField[i];
						}
						this.APDUInstruction = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int APDUPar1Size()
		{
			if ((this.aPDUPar1Field == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUPar1Field.Length;
			}
		}
		public byte APDUPar1GetItem(int index)
		{
			try
			{
				if ((this.aPDUPar1Field == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUPar1Field.Length - 1)
									>= index))
					{
						return this.aPDUPar1Field[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUPar1SetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUPar1Field == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUPar1Field[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUPar1AddItem(byte value)
		{
			try
			{
				if ((this.aPDUPar1Field == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUPar1Field.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUPar1Field.Length); i = (i + 1))
					{
						array[i] = aPDUPar1Field[i];
					}
					array[i] = value;
					this.APDUPar1 = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUPar1RemoveItem(int index)
		{
			try
			{
				if ((this.aPDUPar1Field == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUPar1Field.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUPar1Field.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUPar1Field[i];
						}
						for (i = (i + 1); (i < this.aPDUPar1Field.Length); i = (i + 1))
						{
							array[i] = aPDUPar1Field[i];
						}
						this.APDUPar1 = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int APDUPar2Size()
		{
			if ((this.aPDUPar2Field == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUPar2Field.Length;
			}
		}
		public byte APDUPar2GetItem(int index)
		{
			try
			{
				if ((this.aPDUPar2Field == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUPar2Field.Length - 1)
									>= index))
					{
						return this.aPDUPar2Field[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUPar2SetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUPar2Field == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUPar2Field[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUPar2AddItem(byte value)
		{
			try
			{
				if ((this.aPDUPar2Field == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUPar2Field.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUPar2Field.Length); i = (i + 1))
					{
						array[i] = aPDUPar2Field[i];
					}
					array[i] = value;
					this.APDUPar2 = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUPar2RemoveItem(int index)
		{
			try
			{
				if ((this.aPDUPar2Field == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUPar2Field.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUPar2Field.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUPar2Field[i];
						}
						for (i = (i + 1); (i < this.aPDUPar2Field.Length); i = (i + 1))
						{
							array[i] = aPDUPar2Field[i];
						}
						this.APDUPar2 = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int APDUExpectedLengthSize()
		{
			if ((this.aPDUExpectedLengthField == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUExpectedLengthField.Length;
			}
		}
		public byte APDUExpectedLengthGetItem(int index)
		{
			try
			{
				if ((this.aPDUExpectedLengthField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUExpectedLengthField.Length - 1)
									>= index))
					{
						return this.aPDUExpectedLengthField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUExpectedLengthSetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUExpectedLengthField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUExpectedLengthField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUExpectedLengthAddItem(byte value)
		{
			try
			{
				if ((this.aPDUExpectedLengthField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUExpectedLengthField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUExpectedLengthField.Length); i = (i + 1))
					{
						array[i] = aPDUExpectedLengthField[i];
					}
					array[i] = value;
					this.APDUExpectedLength = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUExpectedLengthRemoveItem(int index)
		{
			try
			{
				if ((this.aPDUExpectedLengthField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUExpectedLengthField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUExpectedLengthField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUExpectedLengthField[i];
						}
						for (i = (i + 1); (i < this.aPDUExpectedLengthField.Length); i = (i + 1))
						{
							array[i] = aPDUExpectedLengthField[i];
						}
						this.APDUExpectedLength = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("68c9e8cc-76dc-4e79-8c64-13b8db76dafa")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderAPDUResponseType : ICardReaderAPDUResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal byte[] aPDUDataField = new byte[0];
		internal byte[] cardStatusWordsField = new byte[0];
		internal bool xsdCardReaderAPDUResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdCardReaderAPDUResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] APDUData
		{
			get
			{
				if (((this.aPDUDataField == null)
								|| (this.aPDUDataField.Length == 0)))
				{
					return null;
				}
				return this.aPDUDataField;
			}
			set
			{
				this.xsdCardReaderAPDUResponseTypeInitFlagField = true;
				this.aPDUDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] CardStatusWords
		{
			get
			{
				if (((this.cardStatusWordsField == null)
								|| (this.cardStatusWordsField.Length == 0)))
				{
					return null;
				}
				return this.cardStatusWordsField;
			}
			set
			{
				this.xsdCardReaderAPDUResponseTypeInitFlagField = true;
				this.cardStatusWordsField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderAPDUResponseTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderAPDUResponseTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderAPDUResponseTypeInitFlagField = value;
			}
		}
		public int APDUDataSize()
		{
			if ((this.aPDUDataField == null))
			{
				return 0;
			}
			else
			{
				return this.aPDUDataField.Length;
			}
		}
		public byte APDUDataGetItem(int index)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aPDUDataField.Length - 1)
									>= index))
					{
						return this.aPDUDataField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool APDUDataSetItem(int index, byte value)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aPDUDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUDataAddItem(byte value)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aPDUDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aPDUDataField.Length); i = (i + 1))
					{
						array[i] = aPDUDataField[i];
					}
					array[i] = value;
					this.APDUData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool APDUDataRemoveItem(int index)
		{
			try
			{
				if ((this.aPDUDataField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aPDUDataField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aPDUDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aPDUDataField[i];
						}
						for (i = (i + 1); (i < this.aPDUDataField.Length); i = (i + 1))
						{
							array[i] = aPDUDataField[i];
						}
						this.APDUData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CardStatusWordsSize()
		{
			if ((this.cardStatusWordsField == null))
			{
				return 0;
			}
			else
			{
				return this.cardStatusWordsField.Length;
			}
		}
		public byte CardStatusWordsGetItem(int index)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.cardStatusWordsField.Length - 1)
									>= index))
					{
						return this.cardStatusWordsField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool CardStatusWordsSetItem(int index, byte value)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.cardStatusWordsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CardStatusWordsAddItem(byte value)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.cardStatusWordsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.cardStatusWordsField.Length); i = (i + 1))
					{
						array[i] = cardStatusWordsField[i];
					}
					array[i] = value;
					this.CardStatusWords = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CardStatusWordsRemoveItem(int index)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.cardStatusWordsField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.cardStatusWordsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = cardStatusWordsField[i];
						}
						for (i = (i + 1); (i < this.cardStatusWordsField.Length); i = (i + 1))
						{
							array[i] = cardStatusWordsField[i];
						}
						this.CardStatusWords = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ca165259-af8a-4868-80ea-750399201230")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderInitRequestType : ICardReaderInitRequestType
	{
		internal string[] forceEntryModeField = new string[0];
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal bool warmResetFlagField;
		internal bool warmResetFlagFieldSpecified;
		internal bool leaveCardFlagField;
		internal string maxWaitingTimeField;
		internal bool xsdCardReaderInitRequestTypeInitFlagField = false;
		public CardReaderInitRequestType()
		{
			this.leaveCardFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ForceEntryMode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] ForceEntryMode
		{
			get
			{
				if (((this.forceEntryModeField == null)
								|| (this.forceEntryModeField.Length == 0)))
				{
					return null;
				}
				return this.forceEntryModeField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.forceEntryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool WarmResetFlag
		{
			get
			{
				return this.warmResetFlagField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.warmResetFlagField = value;
				this.WarmResetFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool WarmResetFlagSpecified
		{
			get
			{
				return this.warmResetFlagFieldSpecified;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.warmResetFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool LeaveCardFlag
		{
			get
			{
				return this.leaveCardFlagField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.leaveCardFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxWaitingTime
		{
			get
			{
				return this.maxWaitingTimeField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = true;
				this.maxWaitingTimeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderInitRequestTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderInitRequestTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderInitRequestTypeInitFlagField = value;
			}
		}
		public int ForceEntryModeSize()
		{
			if ((this.forceEntryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.forceEntryModeField.Length;
			}
		}
		public string ForceEntryModeGetItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.forceEntryModeField.Length - 1)
									>= index))
					{
						return this.forceEntryModeField[index];
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
		}
		public bool ForceEntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.forceEntryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeAddItem(string value)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.forceEntryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.forceEntryModeField.Length); i = (i + 1))
					{
						array[i] = forceEntryModeField[i];
					}
					array[i] = value;
					this.ForceEntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ForceEntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.forceEntryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.forceEntryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.forceEntryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						for (i = (i + 1); (i < this.forceEntryModeField.Length); i = (i + 1))
						{
							array[i] = forceEntryModeField[i];
						}
						this.ForceEntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("39e14924-9c7f-44f5-ad9a-00bc8dce48a5")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderInitResponseType : ICardReaderInitResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal TrackDataType[] trackDataField = new TrackDataType[0];
		internal ICCResetDataType iCCResetDataField = new ICCResetDataType();
		internal string[] entryModeField = new string[0];
		internal bool xsdCardReaderInitResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdCardReaderInitResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TrackData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TrackDataType[] TrackData
		{
			get
			{
				if (((this.trackDataField == null)
								|| (this.trackDataField.Length == 0)))
				{
					return null;
				}
				return this.trackDataField;
			}
			set
			{
				this.xsdCardReaderInitResponseTypeInitFlagField = true;
				this.trackDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ICCResetDataType ICCResetData
		{
			get
			{
				return this.iCCResetDataField;
			}
			set
			{
				this.xsdCardReaderInitResponseTypeInitFlagField = true;
				this.iCCResetDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] EntryMode
		{
			get
			{
				if (((this.entryModeField == null)
								|| (this.entryModeField.Length == 0)))
				{
					return null;
				}
				return this.entryModeField;
			}
			set
			{
				this.xsdCardReaderInitResponseTypeInitFlagField = true;
				this.entryModeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderInitResponseTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderInitResponseTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderInitResponseTypeInitFlagField = value;
			}
		}
		public int TrackDataSize()
		{
			if ((this.trackDataField == null))
			{
				return 0;
			}
			else
			{
				return this.trackDataField.Length;
			}
		}
		public TrackDataType TrackDataGetItem(int index)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return default(TrackDataType);
				}
				else
				{
					if (((this.trackDataField.Length - 1)
									>= index))
					{
						return this.trackDataField[index];
					}
					else
					{
						return default(TrackDataType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TrackDataType);
			}
		}
		public bool TrackDataSetItem(int index, TrackDataType value)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					this.trackDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TrackDataAddItem(TrackDataType value)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					TrackDataType[] array = new TrackDataType[(this.trackDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.trackDataField.Length); i = (i + 1))
					{
						array[i] = trackDataField[i];
					}
					array[i] = value;
					this.TrackData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TrackDataRemoveItem(int index)
		{
			try
			{
				if ((this.trackDataField == default(TrackDataType[])))
				{
					return false;
				}
				else
				{
					if ((this.trackDataField.Length <= index))
					{
						return false;
					}
					else
					{
						TrackDataType[] array = new TrackDataType[(this.trackDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = trackDataField[i];
						}
						for (i = (i + 1); (i < this.trackDataField.Length); i = (i + 1))
						{
							array[i] = trackDataField[i];
						}
						this.TrackData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int EntryModeSize()
		{
			if ((this.entryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.entryModeField.Length;
			}
		}
		public string EntryModeGetItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.entryModeField.Length - 1)
									>= index))
					{
						return this.entryModeField[index];
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
		}
		public bool EntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.entryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeAddItem(string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.entryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.entryModeField.Length); i = (i + 1))
					{
						array[i] = entryModeField[i];
					}
					array[i] = value;
					this.EntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.entryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.entryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						for (i = (i + 1); (i < this.entryModeField.Length); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						this.EntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("94cf750f-8493-4a1b-adde-dc9dd728b6e0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ICCResetDataType : IICCResetDataType
	{
		internal byte[] aTRValueField = new byte[0];
		internal byte[] cardStatusWordsField = new byte[0];
		internal bool xsdICCResetDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] ATRValue
		{
			get
			{
				if (((this.aTRValueField == null)
								|| (this.aTRValueField.Length == 0)))
				{
					return null;
				}
				return this.aTRValueField;
			}
			set
			{
				this.xsdICCResetDataTypeInitFlagField = true;
				this.aTRValueField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
		public byte[] CardStatusWords
		{
			get
			{
				if (((this.cardStatusWordsField == null)
								|| (this.cardStatusWordsField.Length == 0)))
				{
					return null;
				}
				return this.cardStatusWordsField;
			}
			set
			{
				this.xsdICCResetDataTypeInitFlagField = true;
				this.cardStatusWordsField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdICCResetDataTypeInitFlag
		{
			get
			{
				return this.xsdICCResetDataTypeInitFlagField;
			}
			set
			{
				this.xsdICCResetDataTypeInitFlagField = value;
			}
		}
		public int ATRValueSize()
		{
			if ((this.aTRValueField == null))
			{
				return 0;
			}
			else
			{
				return this.aTRValueField.Length;
			}
		}
		public byte ATRValueGetItem(int index)
		{
			try
			{
				if ((this.aTRValueField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.aTRValueField.Length - 1)
									>= index))
					{
						return this.aTRValueField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool ATRValueSetItem(int index, byte value)
		{
			try
			{
				if ((this.aTRValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.aTRValueField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ATRValueAddItem(byte value)
		{
			try
			{
				if ((this.aTRValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.aTRValueField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.aTRValueField.Length); i = (i + 1))
					{
						array[i] = aTRValueField[i];
					}
					array[i] = value;
					this.ATRValue = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool ATRValueRemoveItem(int index)
		{
			try
			{
				if ((this.aTRValueField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.aTRValueField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.aTRValueField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = aTRValueField[i];
						}
						for (i = (i + 1); (i < this.aTRValueField.Length); i = (i + 1))
						{
							array[i] = aTRValueField[i];
						}
						this.ATRValue = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CardStatusWordsSize()
		{
			if ((this.cardStatusWordsField == null))
			{
				return 0;
			}
			else
			{
				return this.cardStatusWordsField.Length;
			}
		}
		public byte CardStatusWordsGetItem(int index)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.cardStatusWordsField.Length - 1)
									>= index))
					{
						return this.cardStatusWordsField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool CardStatusWordsSetItem(int index, byte value)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.cardStatusWordsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CardStatusWordsAddItem(byte value)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.cardStatusWordsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.cardStatusWordsField.Length); i = (i + 1))
					{
						array[i] = cardStatusWordsField[i];
					}
					array[i] = value;
					this.CardStatusWords = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CardStatusWordsRemoveItem(int index)
		{
			try
			{
				if ((this.cardStatusWordsField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.cardStatusWordsField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.cardStatusWordsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = cardStatusWordsField[i];
						}
						for (i = (i + 1); (i < this.cardStatusWordsField.Length); i = (i + 1))
						{
							array[i] = cardStatusWordsField[i];
						}
						this.CardStatusWords = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bca2023c-5cff-4722-9772-fdd208824344")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderPowerOffRequestType : ICardReaderPowerOffRequestType
	{
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal string maxWaitingTimeField;
		internal bool xsdCardReaderPowerOffRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdCardReaderPowerOffRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxWaitingTime
		{
			get
			{
				return this.maxWaitingTimeField;
			}
			set
			{
				this.xsdCardReaderPowerOffRequestTypeInitFlagField = true;
				this.maxWaitingTimeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderPowerOffRequestTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderPowerOffRequestTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderPowerOffRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ef5147a3-d5aa-46d3-95d7-3e89c737dbf3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CardReaderPowerOffResponseType : ICardReaderPowerOffResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal bool xsdCardReaderPowerOffResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdCardReaderPowerOffResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCardReaderPowerOffResponseTypeInitFlag
		{
			get
			{
				return this.xsdCardReaderPowerOffResponseTypeInitFlagField;
			}
			set
			{
				this.xsdCardReaderPowerOffResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0c56bbd3-00a4-4e34-b5b3-2b548ae7cb79")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CashHandlingDeviceType : ICashHandlingDeviceType
	{
		internal CoinsOrBillsType[] coinsOrBillsField = new CoinsOrBillsType[0];
		internal bool cashHandlingOKFlagField;
		internal string currencyField;
		internal bool xsdCashHandlingDeviceTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CoinsOrBills", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CoinsOrBillsType[] CoinsOrBills
		{
			get
			{
				if (((this.coinsOrBillsField == null)
								|| (this.coinsOrBillsField.Length == 0)))
				{
					return null;
				}
				return this.coinsOrBillsField;
			}
			set
			{
				this.xsdCashHandlingDeviceTypeInitFlagField = true;
				this.coinsOrBillsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CashHandlingOKFlag
		{
			get
			{
				return this.cashHandlingOKFlagField;
			}
			set
			{
				this.xsdCashHandlingDeviceTypeInitFlagField = true;
				this.cashHandlingOKFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdCashHandlingDeviceTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCashHandlingDeviceTypeInitFlag
		{
			get
			{
				return this.xsdCashHandlingDeviceTypeInitFlagField;
			}
			set
			{
				this.xsdCashHandlingDeviceTypeInitFlagField = value;
			}
		}
		public int CoinsOrBillsSize()
		{
			if ((this.coinsOrBillsField == null))
			{
				return 0;
			}
			else
			{
				return this.coinsOrBillsField.Length;
			}
		}
		public CoinsOrBillsType CoinsOrBillsGetItem(int index)
		{
			try
			{
				if ((this.coinsOrBillsField == default(CoinsOrBillsType[])))
				{
					return default(CoinsOrBillsType);
				}
				else
				{
					if (((this.coinsOrBillsField.Length - 1)
									>= index))
					{
						return this.coinsOrBillsField[index];
					}
					else
					{
						return default(CoinsOrBillsType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CoinsOrBillsType);
			}
		}
		public bool CoinsOrBillsSetItem(int index, CoinsOrBillsType value)
		{
			try
			{
				if ((this.coinsOrBillsField == default(CoinsOrBillsType[])))
				{
					return false;
				}
				else
				{
					this.coinsOrBillsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CoinsOrBillsAddItem(CoinsOrBillsType value)
		{
			try
			{
				if ((this.coinsOrBillsField == default(CoinsOrBillsType[])))
				{
					return false;
				}
				else
				{
					CoinsOrBillsType[] array = new CoinsOrBillsType[(this.coinsOrBillsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.coinsOrBillsField.Length); i = (i + 1))
					{
						array[i] = coinsOrBillsField[i];
					}
					array[i] = value;
					this.CoinsOrBills = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CoinsOrBillsRemoveItem(int index)
		{
			try
			{
				if ((this.coinsOrBillsField == default(CoinsOrBillsType[])))
				{
					return false;
				}
				else
				{
					if ((this.coinsOrBillsField.Length <= index))
					{
						return false;
					}
					else
					{
						CoinsOrBillsType[] array = new CoinsOrBillsType[(this.coinsOrBillsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = coinsOrBillsField[i];
						}
						for (i = (i + 1); (i < this.coinsOrBillsField.Length); i = (i + 1))
						{
							array[i] = coinsOrBillsField[i];
						}
						this.CoinsOrBills = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a2989af5-0772-4d86-bfe1-a3305c179dd5")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CoinsOrBillsType : ICoinsOrBillsType
	{
		internal double unitValueField;
		internal string numberField;
		internal bool xsdCoinsOrBillsTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double UnitValue
		{
			get
			{
				return this.unitValueField;
			}
			set
			{
				this.xsdCoinsOrBillsTypeInitFlagField = true;
				this.unitValueField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string Number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.xsdCoinsOrBillsTypeInitFlagField = true;
				this.numberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCoinsOrBillsTypeInitFlag
		{
			get
			{
				return this.xsdCoinsOrBillsTypeInitFlagField;
			}
			set
			{
				this.xsdCoinsOrBillsTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CharacterHeightEnumeration
	{
		/// <remarks/>
		SingleHeight,
		/// <remarks/>
		DoubleHeight,
		/// <remarks/>
		HalfHeight,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CharacterStyleEnumeration
	{
		/// <remarks/>
		Normal,
		/// <remarks/>
		Bold,
		/// <remarks/>
		Italic,
		/// <remarks/>
		Underlined,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CharacterWidthEnumeration
	{
		/// <remarks/>
		SingleWidth,
		/// <remarks/>
		DoubleWidth,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CheckTypeCodeEnumeration
	{
		/// <remarks/>
		Personal,
		/// <remarks/>
		Company,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ColorEnumeration
	{
		/// <remarks/>
		White,
		/// <remarks/>
		Black,
		/// <remarks/>
		Red,
		/// <remarks/>
		Green,
		/// <remarks/>
		Blue,
		/// <remarks/>
		Yellow,
		/// <remarks/>
		Magenta,
		/// <remarks/>
		Cyan,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a22d1718-87f6-409b-a750-641c5290add0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class CriteriaOrderType : ICriteriaOrderType
	{
		internal string targetField;
		internal bool xsdCriteriaOrderTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.xsdCriteriaOrderTypeInitFlagField = true;
				this.targetField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdCriteriaOrderTypeInitFlag
		{
			get
			{
				return this.xsdCriteriaOrderTypeInitFlagField;
			}
			set
			{
				this.xsdCriteriaOrderTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum CustomerOrderReqEnumeration
	{
		/// <remarks/>
		Open,
		/// <remarks/>
		Closed,
		/// <remarks/>
		Both,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum DeviceEnumeration
	{
		/// <remarks/>
		CashierDisplay,
		/// <remarks/>
		CustomerDisplay,
		/// <remarks/>
		CashierInput,
		/// <remarks/>
		CustomerInput,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5e95151a-6064-49d8-b4af-de6e7ce89ba9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DiagnosisRequestType : IDiagnosisRequestType
	{
		internal string[] acquirerIDField = new string[0];
		internal string pOIIDField;
		internal bool hostDiagnosisFlagField;
		internal bool xsdDiagnosisRequestTypeInitFlagField = false;
		public DiagnosisRequestType()
		{
			this.hostDiagnosisFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AcquirerID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AcquirerID
		{
			get
			{
				if (((this.acquirerIDField == null)
								|| (this.acquirerIDField.Length == 0)))
				{
					return null;
				}
				return this.acquirerIDField;
			}
			set
			{
				this.xsdDiagnosisRequestTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdDiagnosisRequestTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool HostDiagnosisFlag
		{
			get
			{
				return this.hostDiagnosisFlagField;
			}
			set
			{
				this.xsdDiagnosisRequestTypeInitFlagField = true;
				this.hostDiagnosisFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDiagnosisRequestTypeInitFlag
		{
			get
			{
				return this.xsdDiagnosisRequestTypeInitFlagField;
			}
			set
			{
				this.xsdDiagnosisRequestTypeInitFlagField = value;
			}
		}
		public int AcquirerIDSize()
		{
			if ((this.acquirerIDField == null))
			{
				return 0;
			}
			else
			{
				return this.acquirerIDField.Length;
			}
		}
		public string AcquirerIDGetItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.acquirerIDField.Length - 1)
									>= index))
					{
						return this.acquirerIDField[index];
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
		}
		public bool AcquirerIDSetItem(int index, string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					this.acquirerIDField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDAddItem(string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.acquirerIDField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.acquirerIDField.Length); i = (i + 1))
					{
						array[i] = acquirerIDField[i];
					}
					array[i] = value;
					this.AcquirerID = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDRemoveItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.acquirerIDField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.acquirerIDField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						for (i = (i + 1); (i < this.acquirerIDField.Length); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						this.AcquirerID = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("ed597a05-fc5e-4b8d-aa87-750295aba4ea")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class DiagnosisResponseType : IDiagnosisResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal string[] loggedSaleIDField = new string[0];
		internal POIStatusType pOIStatusField = new POIStatusType();
		internal HostStatusType[] hostStatusField = new HostStatusType[0];
		internal bool xsdDiagnosisResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdDiagnosisResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoggedSaleID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] LoggedSaleID
		{
			get
			{
				if (((this.loggedSaleIDField == null)
								|| (this.loggedSaleIDField.Length == 0)))
				{
					return null;
				}
				return this.loggedSaleIDField;
			}
			set
			{
				this.xsdDiagnosisResponseTypeInitFlagField = true;
				this.loggedSaleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIStatusType POIStatus
		{
			get
			{
				return this.pOIStatusField;
			}
			set
			{
				this.xsdDiagnosisResponseTypeInitFlagField = true;
				this.pOIStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("HostStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public HostStatusType[] HostStatus
		{
			get
			{
				if (((this.hostStatusField == null)
								|| (this.hostStatusField.Length == 0)))
				{
					return null;
				}
				return this.hostStatusField;
			}
			set
			{
				this.xsdDiagnosisResponseTypeInitFlagField = true;
				this.hostStatusField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdDiagnosisResponseTypeInitFlag
		{
			get
			{
				return this.xsdDiagnosisResponseTypeInitFlagField;
			}
			set
			{
				this.xsdDiagnosisResponseTypeInitFlagField = value;
			}
		}
		public int LoggedSaleIDSize()
		{
			if ((this.loggedSaleIDField == null))
			{
				return 0;
			}
			else
			{
				return this.loggedSaleIDField.Length;
			}
		}
		public string LoggedSaleIDGetItem(int index)
		{
			try
			{
				if ((this.loggedSaleIDField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.loggedSaleIDField.Length - 1)
									>= index))
					{
						return this.loggedSaleIDField[index];
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
		}
		public bool LoggedSaleIDSetItem(int index, string value)
		{
			try
			{
				if ((this.loggedSaleIDField == default(string[])))
				{
					return false;
				}
				else
				{
					this.loggedSaleIDField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoggedSaleIDAddItem(string value)
		{
			try
			{
				if ((this.loggedSaleIDField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.loggedSaleIDField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loggedSaleIDField.Length); i = (i + 1))
					{
						array[i] = loggedSaleIDField[i];
					}
					array[i] = value;
					this.LoggedSaleID = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoggedSaleIDRemoveItem(int index)
		{
			try
			{
				if ((this.loggedSaleIDField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.loggedSaleIDField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.loggedSaleIDField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loggedSaleIDField[i];
						}
						for (i = (i + 1); (i < this.loggedSaleIDField.Length); i = (i + 1))
						{
							array[i] = loggedSaleIDField[i];
						}
						this.LoggedSaleID = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int HostStatusSize()
		{
			if ((this.hostStatusField == null))
			{
				return 0;
			}
			else
			{
				return this.hostStatusField.Length;
			}
		}
		public HostStatusType HostStatusGetItem(int index)
		{
			try
			{
				if ((this.hostStatusField == default(HostStatusType[])))
				{
					return default(HostStatusType);
				}
				else
				{
					if (((this.hostStatusField.Length - 1)
									>= index))
					{
						return this.hostStatusField[index];
					}
					else
					{
						return default(HostStatusType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(HostStatusType);
			}
		}
		public bool HostStatusSetItem(int index, HostStatusType value)
		{
			try
			{
				if ((this.hostStatusField == default(HostStatusType[])))
				{
					return false;
				}
				else
				{
					this.hostStatusField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool HostStatusAddItem(HostStatusType value)
		{
			try
			{
				if ((this.hostStatusField == default(HostStatusType[])))
				{
					return false;
				}
				else
				{
					HostStatusType[] array = new HostStatusType[(this.hostStatusField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.hostStatusField.Length); i = (i + 1))
					{
						array[i] = hostStatusField[i];
					}
					array[i] = value;
					this.HostStatus = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool HostStatusRemoveItem(int index)
		{
			try
			{
				if ((this.hostStatusField == default(HostStatusType[])))
				{
					return false;
				}
				else
				{
					if ((this.hostStatusField.Length <= index))
					{
						return false;
					}
					else
					{
						HostStatusType[] array = new HostStatusType[(this.hostStatusField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = hostStatusField[i];
						}
						for (i = (i + 1); (i < this.hostStatusField.Length); i = (i + 1))
						{
							array[i] = hostStatusField[i];
						}
						this.HostStatus = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a34ae524-6b1f-493a-86f8-4400de478323")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POIStatusType : IPOIStatusType
	{
		internal CashHandlingDeviceType[] cashHandlingDeviceField = new CashHandlingDeviceType[0];
		internal string globalStatusField;
		internal bool securityOKFlagField;
		internal bool securityOKFlagFieldSpecified;
		internal bool pEDOKFlagField;
		internal bool pEDOKFlagFieldSpecified;
		internal bool cardReaderOKFlagField;
		internal bool cardReaderOKFlagFieldSpecified;
		internal string printerStatusField;
		internal bool communicationOKFlagField;
		internal bool communicationOKFlagFieldSpecified;
		internal bool fraudPreventionFlagField;
		internal bool fraudPreventionFlagFieldSpecified;
		internal bool xsdPOIStatusTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CashHandlingDevice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CashHandlingDeviceType[] CashHandlingDevice
		{
			get
			{
				if (((this.cashHandlingDeviceField == null)
								|| (this.cashHandlingDeviceField.Length == 0)))
				{
					return null;
				}
				return this.cashHandlingDeviceField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.cashHandlingDeviceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string GlobalStatus
		{
			get
			{
				return this.globalStatusField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.globalStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool SecurityOKFlag
		{
			get
			{
				return this.securityOKFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.securityOKFlagField = value;
				this.SecurityOKFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SecurityOKFlagSpecified
		{
			get
			{
				return this.securityOKFlagFieldSpecified;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.securityOKFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool PEDOKFlag
		{
			get
			{
				return this.pEDOKFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.pEDOKFlagField = value;
				this.PEDOKFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PEDOKFlagSpecified
		{
			get
			{
				return this.pEDOKFlagFieldSpecified;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.pEDOKFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CardReaderOKFlag
		{
			get
			{
				return this.cardReaderOKFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.cardReaderOKFlagField = value;
				this.CardReaderOKFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CardReaderOKFlagSpecified
		{
			get
			{
				return this.cardReaderOKFlagFieldSpecified;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.cardReaderOKFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PrinterStatus
		{
			get
			{
				return this.printerStatusField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.printerStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CommunicationOKFlag
		{
			get
			{
				return this.communicationOKFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.communicationOKFlagField = value;
				this.CommunicationOKFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CommunicationOKFlagSpecified
		{
			get
			{
				return this.communicationOKFlagFieldSpecified;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.communicationOKFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool FraudPreventionFlag
		{
			get
			{
				return this.fraudPreventionFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.fraudPreventionFlagField = value;
				this.FraudPreventionFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool FraudPreventionFlagSpecified
		{
			get
			{
				return this.fraudPreventionFlagFieldSpecified;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = true;
				this.fraudPreventionFlagFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOIStatusTypeInitFlag
		{
			get
			{
				return this.xsdPOIStatusTypeInitFlagField;
			}
			set
			{
				this.xsdPOIStatusTypeInitFlagField = value;
			}
		}
		public int CashHandlingDeviceSize()
		{
			if ((this.cashHandlingDeviceField == null))
			{
				return 0;
			}
			else
			{
				return this.cashHandlingDeviceField.Length;
			}
		}
		public CashHandlingDeviceType CashHandlingDeviceGetItem(int index)
		{
			try
			{
				if ((this.cashHandlingDeviceField == default(CashHandlingDeviceType[])))
				{
					return default(CashHandlingDeviceType);
				}
				else
				{
					if (((this.cashHandlingDeviceField.Length - 1)
									>= index))
					{
						return this.cashHandlingDeviceField[index];
					}
					else
					{
						return default(CashHandlingDeviceType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CashHandlingDeviceType);
			}
		}
		public bool CashHandlingDeviceSetItem(int index, CashHandlingDeviceType value)
		{
			try
			{
				if ((this.cashHandlingDeviceField == default(CashHandlingDeviceType[])))
				{
					return false;
				}
				else
				{
					this.cashHandlingDeviceField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CashHandlingDeviceAddItem(CashHandlingDeviceType value)
		{
			try
			{
				if ((this.cashHandlingDeviceField == default(CashHandlingDeviceType[])))
				{
					return false;
				}
				else
				{
					CashHandlingDeviceType[] array = new CashHandlingDeviceType[(this.cashHandlingDeviceField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.cashHandlingDeviceField.Length); i = (i + 1))
					{
						array[i] = cashHandlingDeviceField[i];
					}
					array[i] = value;
					this.CashHandlingDevice = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CashHandlingDeviceRemoveItem(int index)
		{
			try
			{
				if ((this.cashHandlingDeviceField == default(CashHandlingDeviceType[])))
				{
					return false;
				}
				else
				{
					if ((this.cashHandlingDeviceField.Length <= index))
					{
						return false;
					}
					else
					{
						CashHandlingDeviceType[] array = new CashHandlingDeviceType[(this.cashHandlingDeviceField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = cashHandlingDeviceField[i];
						}
						for (i = (i + 1); (i < this.cashHandlingDeviceField.Length); i = (i + 1))
						{
							array[i] = cashHandlingDeviceField[i];
						}
						this.CashHandlingDevice = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("48740e91-841b-4d9c-8637-1e972d9fbbf9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class HostStatusType : IHostStatusType
	{
		internal string acquirerIDField;
		internal bool isReachableFlagField;
		internal bool xsdHostStatusTypeInitFlagField = false;
		public HostStatusType()
		{
			this.isReachableFlagField = true;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcquirerID
		{
			get
			{
				return this.acquirerIDField;
			}
			set
			{
				this.xsdHostStatusTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool IsReachableFlag
		{
			get
			{
				return this.isReachableFlagField;
			}
			set
			{
				this.xsdHostStatusTypeInitFlagField = true;
				this.isReachableFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdHostStatusTypeInitFlag
		{
			get
			{
				return this.xsdHostStatusTypeInitFlagField;
			}
			set
			{
				this.xsdHostStatusTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum DocumentQualifierEnumeration
	{
		/// <remarks/>
		SaleReceipt,
		/// <remarks/>
		CashierReceipt,
		/// <remarks/>
		CustomerReceipt,
		/// <remarks/>
		Document,
		/// <remarks/>
		Voucher,
		/// <remarks/>
		Journal,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("cb316b22-e1fe-421d-b669-1f98ed3c4dde")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EnableServiceRequestType : IEnableServiceRequestType
	{
		internal string servicesEnabledField;
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal string transactionActionField;
		internal bool xsdEnableServiceRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ServicesEnabled
		{
			get
			{
				return this.servicesEnabledField;
			}
			set
			{
				this.xsdEnableServiceRequestTypeInitFlagField = true;
				this.servicesEnabledField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdEnableServiceRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TransactionAction
		{
			get
			{
				return this.transactionActionField;
			}
			set
			{
				this.xsdEnableServiceRequestTypeInitFlagField = true;
				this.transactionActionField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEnableServiceRequestTypeInitFlag
		{
			get
			{
				return this.xsdEnableServiceRequestTypeInitFlagField;
			}
			set
			{
				this.xsdEnableServiceRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("67fcc55c-6fe1-4415-a27d-c485c7c65fe7")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EnableServiceResponseType : IEnableServiceResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal bool xsdEnableServiceResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdEnableServiceResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEnableServiceResponseTypeInitFlag
		{
			get
			{
				return this.xsdEnableServiceResponseTypeInitFlagField;
			}
			set
			{
				this.xsdEnableServiceResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum EntryModeEnumeration
	{
		/// <remarks/>
		RFID,
		/// <remarks/>
		Keyed,
		/// <remarks/>
		Manual,
		/// <remarks/>
		File,
		/// <remarks/>
		Scanned,
		/// <remarks/>
		MagStripe,
		/// <remarks/>
		ICC,
		/// <remarks/>
		SynchronousICC,
		/// <remarks/>
		Tapped,
		/// <remarks/>
		Contactless,
		/// <remarks/>
		Mobile,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ErrorConditionEnumeration
	{
		/// <remarks/>
		Aborted,
		/// <remarks/>
		Busy,
		/// <remarks/>
		Cancel,
		/// <remarks/>
		DeviceOut,
		/// <remarks/>
		InsertedCard,
		/// <remarks/>
		InProgress,
		/// <remarks/>
		LoggedOut,
		/// <remarks/>
		MessageFormat,
		/// <remarks/>
		NotAllowed,
		/// <remarks/>
		NotFound,
		/// <remarks/>
		PaymentRestriction,
		/// <remarks/>
		Refusal,
		/// <remarks/>
		UnavailableDevice,
		/// <remarks/>
		UnavailableService,
		/// <remarks/>
		InvalidCard,
		/// <remarks/>
		UnreachableHost,
		/// <remarks/>
		WrongPIN,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("09efe8c7-8210-4ae7-810f-53b8b7214e9f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class EventNotificationType : IEventNotificationType
	{
		internal string eventDetailsField;
		internal byte[] rejectedMessageField = new byte[0];
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal string timeStampField;
		internal string eventToNotifyField;
		internal bool maintenanceRequiredFlagField;
		internal string customerLanguageField;
		internal bool xsdEventNotificationTypeInitFlagField = false;
		public EventNotificationType()
		{
			this.maintenanceRequiredFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string EventDetails
		{
			get
			{
				return this.eventDetailsField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.eventDetailsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] RejectedMessage
		{
			get
			{
				if (((this.rejectedMessageField == null)
								|| (this.rejectedMessageField.Length == 0)))
				{
					return null;
				}
				return this.rejectedMessageField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.rejectedMessageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TimeStamp
		{
			get
			{
				return this.timeStampField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.timeStampField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EventToNotify
		{
			get
			{
				return this.eventToNotifyField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.eventToNotifyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool MaintenanceRequiredFlag
		{
			get
			{
				return this.maintenanceRequiredFlagField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.maintenanceRequiredFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdEventNotificationTypeInitFlag
		{
			get
			{
				return this.xsdEventNotificationTypeInitFlagField;
			}
			set
			{
				this.xsdEventNotificationTypeInitFlagField = value;
			}
		}
		public int RejectedMessageSize()
		{
			if ((this.rejectedMessageField == null))
			{
				return 0;
			}
			else
			{
				return this.rejectedMessageField.Length;
			}
		}
		public byte RejectedMessageGetItem(int index)
		{
			try
			{
				if ((this.rejectedMessageField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.rejectedMessageField.Length - 1)
									>= index))
					{
						return this.rejectedMessageField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool RejectedMessageSetItem(int index, byte value)
		{
			try
			{
				if ((this.rejectedMessageField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.rejectedMessageField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool RejectedMessageAddItem(byte value)
		{
			try
			{
				if ((this.rejectedMessageField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.rejectedMessageField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.rejectedMessageField.Length); i = (i + 1))
					{
						array[i] = rejectedMessageField[i];
					}
					array[i] = value;
					this.RejectedMessage = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool RejectedMessageRemoveItem(int index)
		{
			try
			{
				if ((this.rejectedMessageField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.rejectedMessageField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.rejectedMessageField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = rejectedMessageField[i];
						}
						for (i = (i + 1); (i < this.rejectedMessageField.Length); i = (i + 1))
						{
							array[i] = rejectedMessageField[i];
						}
						this.RejectedMessage = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum EventToNotifyEnumeration
	{
		/// <remarks/>
		BeginMaintenance,
		/// <remarks/>
		EndMaintenance,
		/// <remarks/>
		Shutdown,
		/// <remarks/>
		Initialised,
		/// <remarks/>
		OutOfOrder,
		/// <remarks/>
		Completed,
		/// <remarks/>
		Abort,
		/// <remarks/>
		SaleWakeUp,
		/// <remarks/>
		SaleAdmin,
		/// <remarks/>
		CustomerLanguage,
		/// <remarks/>
		KeyPressed,
		/// <remarks/>
		SecurityAlarm,
		/// <remarks/>
		StopAssistance,
		/// <remarks/>
		CardInserted,
		/// <remarks/>
		CardRemoved,
		/// <remarks/>
		Reject,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ForceEntryModeEnumeration
	{
		/// <remarks/>
		RFID,
		/// <remarks/>
		Keyed,
		/// <remarks/>
		Manual,
		/// <remarks/>
		File,
		/// <remarks/>
		Scanned,
		/// <remarks/>
		MagStripe,
		/// <remarks/>
		ICC,
		/// <remarks/>
		SynchronousICC,
		/// <remarks/>
		Tapped,
		/// <remarks/>
		Contactless,
		/// <remarks/>
		CheckReader,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum GenericProfileEnumeration
	{
		/// <remarks/>
		Basic,
		/// <remarks/>
		Standard,
		/// <remarks/>
		Extended,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("03e17c5b-c6bc-4f06-b58d-cfc828c6caf5")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class GetTotalsRequestType : IGetTotalsRequestType
	{
		internal string totalDetailsField;
		internal TotalFilterType totalFilterField = new TotalFilterType();
		internal bool xsdGetTotalsRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TotalDetails
		{
			get
			{
				return this.totalDetailsField;
			}
			set
			{
				this.xsdGetTotalsRequestTypeInitFlagField = true;
				this.totalDetailsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TotalFilterType TotalFilter
		{
			get
			{
				return this.totalFilterField;
			}
			set
			{
				this.xsdGetTotalsRequestTypeInitFlagField = true;
				this.totalFilterField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdGetTotalsRequestTypeInitFlag
		{
			get
			{
				return this.xsdGetTotalsRequestTypeInitFlagField;
			}
			set
			{
				this.xsdGetTotalsRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("30af081f-2ec6-465d-9d5f-a1c7963866c1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TotalFilterType : ITotalFilterType
	{
		internal string pOIIDField;
		internal string saleIDField;
		internal string operatorIDField;
		internal string shiftNumberField;
		internal string totalsGroupIDField;
		internal bool xsdTotalFilterTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleID
		{
			get
			{
				return this.saleIDField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = true;
				this.saleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorID
		{
			get
			{
				return this.operatorIDField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = true;
				this.operatorIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShiftNumber
		{
			get
			{
				return this.shiftNumberField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = true;
				this.shiftNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalsGroupID
		{
			get
			{
				return this.totalsGroupIDField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = true;
				this.totalsGroupIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTotalFilterTypeInitFlag
		{
			get
			{
				return this.xsdTotalFilterTypeInitFlagField;
			}
			set
			{
				this.xsdTotalFilterTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("3374bfe5-4c57-453e-8329-36ebb2b860cd")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class GetTotalsResponseType : IGetTotalsResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal TransactionTotalsType[] transactionTotalsField = new TransactionTotalsType[0];
		internal string pOIReconciliationIDField;
		internal bool xsdGetTotalsResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdGetTotalsResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransactionTotals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionTotalsType[] TransactionTotals
		{
			get
			{
				if (((this.transactionTotalsField == null)
								|| (this.transactionTotalsField.Length == 0)))
				{
					return null;
				}
				return this.transactionTotalsField;
			}
			set
			{
				this.xsdGetTotalsResponseTypeInitFlagField = true;
				this.transactionTotalsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIReconciliationID
		{
			get
			{
				return this.pOIReconciliationIDField;
			}
			set
			{
				this.xsdGetTotalsResponseTypeInitFlagField = true;
				this.pOIReconciliationIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdGetTotalsResponseTypeInitFlag
		{
			get
			{
				return this.xsdGetTotalsResponseTypeInitFlagField;
			}
			set
			{
				this.xsdGetTotalsResponseTypeInitFlagField = value;
			}
		}
		public int TransactionTotalsSize()
		{
			if ((this.transactionTotalsField == null))
			{
				return 0;
			}
			else
			{
				return this.transactionTotalsField.Length;
			}
		}
		public TransactionTotalsType TransactionTotalsGetItem(int index)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return default(TransactionTotalsType);
				}
				else
				{
					if (((this.transactionTotalsField.Length - 1)
									>= index))
					{
						return this.transactionTotalsField[index];
					}
					else
					{
						return default(TransactionTotalsType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TransactionTotalsType);
			}
		}
		public bool TransactionTotalsSetItem(int index, TransactionTotalsType value)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					this.transactionTotalsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionTotalsAddItem(TransactionTotalsType value)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					TransactionTotalsType[] array = new TransactionTotalsType[(this.transactionTotalsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.transactionTotalsField.Length); i = (i + 1))
					{
						array[i] = transactionTotalsField[i];
					}
					array[i] = value;
					this.TransactionTotals = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionTotalsRemoveItem(int index)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					if ((this.transactionTotalsField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionTotalsType[] array = new TransactionTotalsType[(this.transactionTotalsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = transactionTotalsField[i];
						}
						for (i = (i + 1); (i < this.transactionTotalsField.Length); i = (i + 1))
						{
							array[i] = transactionTotalsField[i];
						}
						this.TransactionTotals = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("4f747b31-e698-4ff2-ba09-06e7483db28c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionTotalsType : ITransactionTotalsType
	{
		internal PaymentTotalsType[] paymentTotalsField = new PaymentTotalsType[0];
		internal LoyaltyTotalsType[] loyaltyTotalsField = new LoyaltyTotalsType[0];
		internal string paymentInstrumentTypeField;
		internal string acquirerIDField;
		internal string errorConditionField;
		internal string hostReconciliationIDField;
		internal string cardBrandField;
		internal string pOIIDField;
		internal string saleIDField;
		internal string operatorIDField;
		internal string shiftNumberField;
		internal string totalsGroupIDField;
		internal string paymentCurrencyField;
		internal string loyaltyUnitField;
		internal string loyaltyCurrencyField;
		internal bool xsdTransactionTotalsTypeInitFlagField = false;
		public TransactionTotalsType()
		{
			this.loyaltyUnitField = "Point";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentTotals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentTotalsType[] PaymentTotals
		{
			get
			{
				if (((this.paymentTotalsField == null)
								|| (this.paymentTotalsField.Length == 0)))
				{
					return null;
				}
				return this.paymentTotalsField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.paymentTotalsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyTotals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyTotalsType[] LoyaltyTotals
		{
			get
			{
				if (((this.loyaltyTotalsField == null)
								|| (this.loyaltyTotalsField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyTotalsField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.loyaltyTotalsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentInstrumentType
		{
			get
			{
				return this.paymentInstrumentTypeField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.paymentInstrumentTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcquirerID
		{
			get
			{
				return this.acquirerIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ErrorCondition
		{
			get
			{
				return this.errorConditionField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.errorConditionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string HostReconciliationID
		{
			get
			{
				return this.hostReconciliationIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.hostReconciliationIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CardBrand
		{
			get
			{
				return this.cardBrandField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.cardBrandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleID
		{
			get
			{
				return this.saleIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.saleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorID
		{
			get
			{
				return this.operatorIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.operatorIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShiftNumber
		{
			get
			{
				return this.shiftNumberField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.shiftNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalsGroupID
		{
			get
			{
				return this.totalsGroupIDField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.totalsGroupIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentCurrency
		{
			get
			{
				return this.paymentCurrencyField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.paymentCurrencyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Point")]
		public string LoyaltyUnit
		{
			get
			{
				return this.loyaltyUnitField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.loyaltyUnitField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string LoyaltyCurrency
		{
			get
			{
				return this.loyaltyCurrencyField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = true;
				this.loyaltyCurrencyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionTotalsTypeInitFlag
		{
			get
			{
				return this.xsdTransactionTotalsTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionTotalsTypeInitFlagField = value;
			}
		}
		public int PaymentTotalsSize()
		{
			if ((this.paymentTotalsField == null))
			{
				return 0;
			}
			else
			{
				return this.paymentTotalsField.Length;
			}
		}
		public PaymentTotalsType PaymentTotalsGetItem(int index)
		{
			try
			{
				if ((this.paymentTotalsField == default(PaymentTotalsType[])))
				{
					return default(PaymentTotalsType);
				}
				else
				{
					if (((this.paymentTotalsField.Length - 1)
									>= index))
					{
						return this.paymentTotalsField[index];
					}
					else
					{
						return default(PaymentTotalsType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PaymentTotalsType);
			}
		}
		public bool PaymentTotalsSetItem(int index, PaymentTotalsType value)
		{
			try
			{
				if ((this.paymentTotalsField == default(PaymentTotalsType[])))
				{
					return false;
				}
				else
				{
					this.paymentTotalsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentTotalsAddItem(PaymentTotalsType value)
		{
			try
			{
				if ((this.paymentTotalsField == default(PaymentTotalsType[])))
				{
					return false;
				}
				else
				{
					PaymentTotalsType[] array = new PaymentTotalsType[(this.paymentTotalsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.paymentTotalsField.Length); i = (i + 1))
					{
						array[i] = paymentTotalsField[i];
					}
					array[i] = value;
					this.PaymentTotals = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentTotalsRemoveItem(int index)
		{
			try
			{
				if ((this.paymentTotalsField == default(PaymentTotalsType[])))
				{
					return false;
				}
				else
				{
					if ((this.paymentTotalsField.Length <= index))
					{
						return false;
					}
					else
					{
						PaymentTotalsType[] array = new PaymentTotalsType[(this.paymentTotalsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = paymentTotalsField[i];
						}
						for (i = (i + 1); (i < this.paymentTotalsField.Length); i = (i + 1))
						{
							array[i] = paymentTotalsField[i];
						}
						this.PaymentTotals = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int LoyaltyTotalsSize()
		{
			if ((this.loyaltyTotalsField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyTotalsField.Length;
			}
		}
		public LoyaltyTotalsType LoyaltyTotalsGetItem(int index)
		{
			try
			{
				if ((this.loyaltyTotalsField == default(LoyaltyTotalsType[])))
				{
					return default(LoyaltyTotalsType);
				}
				else
				{
					if (((this.loyaltyTotalsField.Length - 1)
									>= index))
					{
						return this.loyaltyTotalsField[index];
					}
					else
					{
						return default(LoyaltyTotalsType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyTotalsType);
			}
		}
		public bool LoyaltyTotalsSetItem(int index, LoyaltyTotalsType value)
		{
			try
			{
				if ((this.loyaltyTotalsField == default(LoyaltyTotalsType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyTotalsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyTotalsAddItem(LoyaltyTotalsType value)
		{
			try
			{
				if ((this.loyaltyTotalsField == default(LoyaltyTotalsType[])))
				{
					return false;
				}
				else
				{
					LoyaltyTotalsType[] array = new LoyaltyTotalsType[(this.loyaltyTotalsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyTotalsField.Length); i = (i + 1))
					{
						array[i] = loyaltyTotalsField[i];
					}
					array[i] = value;
					this.LoyaltyTotals = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyTotalsRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyTotalsField == default(LoyaltyTotalsType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyTotalsField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyTotalsType[] array = new LoyaltyTotalsType[(this.loyaltyTotalsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyTotalsField[i];
						}
						for (i = (i + 1); (i < this.loyaltyTotalsField.Length); i = (i + 1))
						{
							array[i] = loyaltyTotalsField[i];
						}
						this.LoyaltyTotals = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("c09d5b73-300b-43de-b304-90421eb8df88")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentTotalsType : IPaymentTotalsType
	{
		internal string transactionTypeField;
		internal string transactionCountField;
		internal double transactionAmountField;
		internal bool xsdPaymentTotalsTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TransactionType
		{
			get
			{
				return this.transactionTypeField;
			}
			set
			{
				this.xsdPaymentTotalsTypeInitFlagField = true;
				this.transactionTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string TransactionCount
		{
			get
			{
				return this.transactionCountField;
			}
			set
			{
				this.xsdPaymentTotalsTypeInitFlagField = true;
				this.transactionCountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TransactionAmount
		{
			get
			{
				return this.transactionAmountField;
			}
			set
			{
				this.xsdPaymentTotalsTypeInitFlagField = true;
				this.transactionAmountField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentTotalsTypeInitFlag
		{
			get
			{
				return this.xsdPaymentTotalsTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentTotalsTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a6660c2e-b579-4046-9066-55b143b4f311")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyTotalsType : ILoyaltyTotalsType
	{
		internal string transactionTypeField;
		internal string transactionCountField;
		internal double transactionAmountField;
		internal bool xsdLoyaltyTotalsTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TransactionType
		{
			get
			{
				return this.transactionTypeField;
			}
			set
			{
				this.xsdLoyaltyTotalsTypeInitFlagField = true;
				this.transactionTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string TransactionCount
		{
			get
			{
				return this.transactionCountField;
			}
			set
			{
				this.xsdLoyaltyTotalsTypeInitFlagField = true;
				this.transactionCountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double TransactionAmount
		{
			get
			{
				return this.transactionAmountField;
			}
			set
			{
				this.xsdLoyaltyTotalsTypeInitFlagField = true;
				this.transactionAmountField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyTotalsTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyTotalsTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyTotalsTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum GlobalStatusEnumeration
	{
		/// <remarks/>
		OK,
		/// <remarks/>
		Busy,
		/// <remarks/>
		Maintenance,
		/// <remarks/>
		Unreachable,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum IdentificationSupportEnumeration
	{
		/// <remarks/>
		NoCard,
		/// <remarks/>
		LoyaltyCard,
		/// <remarks/>
		HybridCard,
		/// <remarks/>
		LinkedCard,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum IdentificationTypeEnumeration
	{
		/// <remarks/>
		PAN,
		/// <remarks/>
		ISOTrack2,
		/// <remarks/>
		BarCode,
		/// <remarks/>
		AccountNumber,
		/// <remarks/>
		PhoneNumber,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum InfoQualifyEnumeration
	{
		/// <remarks/>
		Status,
		/// <remarks/>
		Error,
		/// <remarks/>
		Display,
		/// <remarks/>
		Sound,
		/// <remarks/>
		Input,
		/// <remarks/>
		POIReplication,
		/// <remarks/>
		CustomerAssistance,
		/// <remarks/>
		Receipt,
		/// <remarks/>
		Document,
		/// <remarks/>
		Voucher,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("0376d967-af77-46bc-a7c8-822d90411278")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputType : IInputType
	{
		internal bool confirmedFlagField;
		internal bool confirmedFlagFieldSpecified;
		internal string functionKeyField;
		internal string textInputField;
		internal string digitInputField;
		internal ContentInformationType passwordField = new ContentInformationType();
		internal string menuEntryNumberField;
		internal string inputCommandField;
		internal bool xsdInputTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool ConfirmedFlag
		{
			get
			{
				return this.confirmedFlagField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.confirmedFlagField = value;
				this.ConfirmedFlagSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ConfirmedFlagSpecified
		{
			get
			{
				return this.confirmedFlagFieldSpecified;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.confirmedFlagFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string FunctionKey
		{
			get
			{
				return this.functionKeyField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.functionKeyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TextInput
		{
			get
			{
				return this.textInputField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.textInputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DigitInput
		{
			get
			{
				return this.digitInputField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.digitInputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.passwordField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
		public string MenuEntryNumber
		{
			get
			{
				return this.menuEntryNumberField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.menuEntryNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InputCommand
		{
			get
			{
				return this.inputCommandField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = true;
				this.inputCommandField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputTypeInitFlag
		{
			get
			{
				return this.xsdInputTypeInitFlagField;
			}
			set
			{
				this.xsdInputTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum InputCommandEnumeration
	{
		/// <remarks/>
		GetAnyKey,
		/// <remarks/>
		GetConfirmation,
		/// <remarks/>
		SiteManager,
		/// <remarks/>
		TextString,
		/// <remarks/>
		DigitString,
		/// <remarks/>
		DecimalString,
		/// <remarks/>
		GetFunctionKey,
		/// <remarks/>
		GetMenuEntry,
		/// <remarks/>
		Password,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d8dea142-8d77-442d-845d-3b7d4d91cd23")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputDataType : IInputDataType
	{
		internal string defaultInputStringField;
		internal string stringMaskField;
		internal string deviceField;
		internal string infoQualifyField;
		internal string inputCommandField;
		internal bool notifyCardInputFlagField;
		internal string maxInputTimeField;
		internal bool immediateResponseFlagField;
		internal string minLengthField;
		internal string maxLengthField;
		internal string maxDecimalLengthField;
		internal bool waitUserValidationFlagField;
		internal bool fromRightToLeftFlagField;
		internal bool maskCharactersFlagField;
		internal bool beepKeyFlagField;
		internal bool globalCorrectionFlagField;
		internal bool disableCancelFlagField;
		internal bool disableCorrectFlagField;
		internal bool disableValidFlagField;
		internal bool menuBackFlagField;
		internal bool xsdInputDataTypeInitFlagField = false;
		public InputDataType()
		{
			this.notifyCardInputFlagField = false;
			this.immediateResponseFlagField = false;
			this.waitUserValidationFlagField = true;
			this.fromRightToLeftFlagField = false;
			this.maskCharactersFlagField = false;
			this.beepKeyFlagField = false;
			this.globalCorrectionFlagField = false;
			this.disableCancelFlagField = false;
			this.disableCorrectFlagField = false;
			this.disableValidFlagField = false;
			this.menuBackFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DefaultInputString
		{
			get
			{
				return this.defaultInputStringField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.defaultInputStringField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string StringMask
		{
			get
			{
				return this.stringMaskField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.stringMaskField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Device
		{
			get
			{
				return this.deviceField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.deviceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InfoQualify
		{
			get
			{
				return this.infoQualifyField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.infoQualifyField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InputCommand
		{
			get
			{
				return this.inputCommandField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.inputCommandField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool NotifyCardInputFlag
		{
			get
			{
				return this.notifyCardInputFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.notifyCardInputFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxInputTime
		{
			get
			{
				return this.maxInputTimeField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.maxInputTimeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ImmediateResponseFlag
		{
			get
			{
				return this.immediateResponseFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.immediateResponseFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MinLength
		{
			get
			{
				return this.minLengthField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.minLengthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxLength
		{
			get
			{
				return this.maxLengthField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.maxLengthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxDecimalLength
		{
			get
			{
				return this.maxDecimalLengthField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.maxDecimalLengthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(true)]
		public bool WaitUserValidationFlag
		{
			get
			{
				return this.waitUserValidationFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.waitUserValidationFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool FromRightToLeftFlag
		{
			get
			{
				return this.fromRightToLeftFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.fromRightToLeftFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool MaskCharactersFlag
		{
			get
			{
				return this.maskCharactersFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.maskCharactersFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool BeepKeyFlag
		{
			get
			{
				return this.beepKeyFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.beepKeyFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool GlobalCorrectionFlag
		{
			get
			{
				return this.globalCorrectionFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.globalCorrectionFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DisableCancelFlag
		{
			get
			{
				return this.disableCancelFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.disableCancelFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DisableCorrectFlag
		{
			get
			{
				return this.disableCorrectFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.disableCorrectFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DisableValidFlag
		{
			get
			{
				return this.disableValidFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.disableValidFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool MenuBackFlag
		{
			get
			{
				return this.menuBackFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = true;
				this.menuBackFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputDataTypeInitFlag
		{
			get
			{
				return this.xsdInputDataTypeInitFlagField;
			}
			set
			{
				this.xsdInputDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("12e4d4be-e654-4c28-bd6b-d77ddfe19ed7")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputRequestType : IInputRequestType
	{
		internal DisplayOutputType displayOutputField = new DisplayOutputType();
		internal InputDataType inputDataField = new InputDataType();
		internal bool xsdInputRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public DisplayOutputType DisplayOutput
		{
			get
			{
				return this.displayOutputField;
			}
			set
			{
				this.xsdInputRequestTypeInitFlagField = true;
				this.displayOutputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InputDataType InputData
		{
			get
			{
				return this.inputDataField;
			}
			set
			{
				this.xsdInputRequestTypeInitFlagField = true;
				this.inputDataField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputRequestTypeInitFlag
		{
			get
			{
				return this.xsdInputRequestTypeInitFlagField;
			}
			set
			{
				this.xsdInputRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7f8cc5d6-8144-481c-b00d-e4fff74e6d60")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputResponseType : IInputResponseType
	{
		internal OutputResultType outputResultField = new OutputResultType();
		internal InputResultType inputResultField = new InputResultType();
		internal bool xsdInputResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputResultType OutputResult
		{
			get
			{
				return this.outputResultField;
			}
			set
			{
				this.xsdInputResponseTypeInitFlagField = true;
				this.outputResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InputResultType InputResult
		{
			get
			{
				return this.inputResultField;
			}
			set
			{
				this.xsdInputResponseTypeInitFlagField = true;
				this.inputResultField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputResponseTypeInitFlag
		{
			get
			{
				return this.xsdInputResponseTypeInitFlagField;
			}
			set
			{
				this.xsdInputResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("14f07578-c95b-474d-96c6-99eed2c7bf68")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputResultType : IInputResultType
	{
		internal ResponseType responseField = new ResponseType();
		internal InputType inputField = new InputType();
		internal string deviceField;
		internal string infoQualifyField;
		internal bool xsdInputResultTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdInputResultTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public InputType Input
		{
			get
			{
				return this.inputField;
			}
			set
			{
				this.xsdInputResultTypeInitFlagField = true;
				this.inputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Device
		{
			get
			{
				return this.deviceField;
			}
			set
			{
				this.xsdInputResultTypeInitFlagField = true;
				this.deviceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string InfoQualify
		{
			get
			{
				return this.infoQualifyField;
			}
			set
			{
				this.xsdInputResultTypeInitFlagField = true;
				this.infoQualifyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputResultTypeInitFlag
		{
			get
			{
				return this.xsdInputResultTypeInitFlagField;
			}
			set
			{
				this.xsdInputResultTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7d502b9f-ad16-408f-936b-46cceab1ab0c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class InputUpdateType : IInputUpdateType
	{
		internal MessageReferenceType messageReferenceField = new MessageReferenceType();
		internal OutputContentType outputContentField = new OutputContentType();
		internal MenuEntryType[] menuEntryField = new MenuEntryType[0];
		internal byte[] outputSignatureField = new byte[0];
		internal string minLengthField;
		internal string maxLengthField;
		internal string maxDecimalLengthField;
		internal bool xsdInputUpdateTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageReferenceType MessageReference
		{
			get
			{
				return this.messageReferenceField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.messageReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputContentType OutputContent
		{
			get
			{
				return this.outputContentField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.outputContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("MenuEntry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MenuEntryType[] MenuEntry
		{
			get
			{
				if (((this.menuEntryField == null)
								|| (this.menuEntryField.Length == 0)))
				{
					return null;
				}
				return this.menuEntryField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.menuEntryField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] OutputSignature
		{
			get
			{
				if (((this.outputSignatureField == null)
								|| (this.outputSignatureField.Length == 0)))
				{
					return null;
				}
				return this.outputSignatureField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.outputSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MinLength
		{
			get
			{
				return this.minLengthField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.minLengthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxLength
		{
			get
			{
				return this.maxLengthField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.maxLengthField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxDecimalLength
		{
			get
			{
				return this.maxDecimalLengthField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = true;
				this.maxDecimalLengthField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdInputUpdateTypeInitFlag
		{
			get
			{
				return this.xsdInputUpdateTypeInitFlagField;
			}
			set
			{
				this.xsdInputUpdateTypeInitFlagField = value;
			}
		}
		public int MenuEntrySize()
		{
			if ((this.menuEntryField == null))
			{
				return 0;
			}
			else
			{
				return this.menuEntryField.Length;
			}
		}
		public MenuEntryType MenuEntryGetItem(int index)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return default(MenuEntryType);
				}
				else
				{
					if (((this.menuEntryField.Length - 1)
									>= index))
					{
						return this.menuEntryField[index];
					}
					else
					{
						return default(MenuEntryType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(MenuEntryType);
			}
		}
		public bool MenuEntrySetItem(int index, MenuEntryType value)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					this.menuEntryField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MenuEntryAddItem(MenuEntryType value)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					MenuEntryType[] array = new MenuEntryType[(this.menuEntryField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.menuEntryField.Length); i = (i + 1))
					{
						array[i] = menuEntryField[i];
					}
					array[i] = value;
					this.MenuEntry = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MenuEntryRemoveItem(int index)
		{
			try
			{
				if ((this.menuEntryField == default(MenuEntryType[])))
				{
					return false;
				}
				else
				{
					if ((this.menuEntryField.Length <= index))
					{
						return false;
					}
					else
					{
						MenuEntryType[] array = new MenuEntryType[(this.menuEntryField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = menuEntryField[i];
						}
						for (i = (i + 1); (i < this.menuEntryField.Length); i = (i + 1))
						{
							array[i] = menuEntryField[i];
						}
						this.MenuEntry = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int OutputSignatureSize()
		{
			if ((this.outputSignatureField == null))
			{
				return 0;
			}
			else
			{
				return this.outputSignatureField.Length;
			}
		}
		public byte OutputSignatureGetItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.outputSignatureField.Length - 1)
									>= index))
					{
						return this.outputSignatureField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool OutputSignatureSetItem(int index, byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.outputSignatureField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureAddItem(byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.outputSignatureField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputSignatureField.Length); i = (i + 1))
					{
						array[i] = outputSignatureField[i];
					}
					array[i] = value;
					this.OutputSignature = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureRemoveItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.outputSignatureField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.outputSignatureField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						for (i = (i + 1); (i < this.outputSignatureField.Length); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						this.OutputSignature = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum InstalmentTypeEnumeration
	{
		/// <remarks/>
		DeferredInstalments,
		/// <remarks/>
		EqualInstalments,
		/// <remarks/>
		InequalInstalments,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d3c80176-ebb9-4da2-be47-89ed427e9e14")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoginRequestType : ILoginRequestType
	{
		internal string dateTimeField;
		internal SaleSoftwareType saleSoftwareField = new SaleSoftwareType();
		internal SaleTerminalDataType saleTerminalDataField = new SaleTerminalDataType();
		internal bool trainingModeFlagField;
		internal string operatorLanguageField;
		internal string operatorIDField;
		internal string shiftNumberField;
		internal string tokenRequestedTypeField;
		internal string[] customerOrderReqField = new string[0];
		internal string pOISerialNumberField;
		internal bool xsdLoginRequestTypeInitFlagField = false;
		public LoginRequestType()
		{
			this.trainingModeFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.dateTimeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleSoftwareType SaleSoftware
		{
			get
			{
				return this.saleSoftwareField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.saleSoftwareField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleTerminalDataType SaleTerminalData
		{
			get
			{
				return this.saleTerminalDataField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.saleTerminalDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool TrainingModeFlag
		{
			get
			{
				return this.trainingModeFlagField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.trainingModeFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorLanguage
		{
			get
			{
				return this.operatorLanguageField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.operatorLanguageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperatorID
		{
			get
			{
				return this.operatorIDField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.operatorIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShiftNumber
		{
			get
			{
				return this.shiftNumberField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.shiftNumberField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TokenRequestedType
		{
			get
			{
				return this.tokenRequestedTypeField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.tokenRequestedTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] CustomerOrderReq
		{
			get
			{
				if (((this.customerOrderReqField == null)
								|| (this.customerOrderReqField.Length == 0)))
				{
					return null;
				}
				return this.customerOrderReqField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.customerOrderReqField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POISerialNumber
		{
			get
			{
				return this.pOISerialNumberField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = true;
				this.pOISerialNumberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoginRequestTypeInitFlag
		{
			get
			{
				return this.xsdLoginRequestTypeInitFlagField;
			}
			set
			{
				this.xsdLoginRequestTypeInitFlagField = value;
			}
		}
		public int CustomerOrderReqSize()
		{
			if ((this.customerOrderReqField == null))
			{
				return 0;
			}
			else
			{
				return this.customerOrderReqField.Length;
			}
		}
		public string CustomerOrderReqGetItem(int index)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.customerOrderReqField.Length - 1)
									>= index))
					{
						return this.customerOrderReqField[index];
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
		}
		public bool CustomerOrderReqSetItem(int index, string value)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					this.customerOrderReqField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderReqAddItem(string value)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.customerOrderReqField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.customerOrderReqField.Length); i = (i + 1))
					{
						array[i] = customerOrderReqField[i];
					}
					array[i] = value;
					this.CustomerOrderReq = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderReqRemoveItem(int index)
		{
			try
			{
				if ((this.customerOrderReqField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.customerOrderReqField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.customerOrderReqField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = customerOrderReqField[i];
						}
						for (i = (i + 1); (i < this.customerOrderReqField.Length); i = (i + 1))
						{
							array[i] = customerOrderReqField[i];
						}
						this.CustomerOrderReq = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5930759b-5b9b-4833-a689-b4181b4843de")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleSoftwareType : ISaleSoftwareType
	{
		internal string providerIdentificationField;
		internal string applicationNameField;
		internal string softwareVersionField;
		internal string certificationCodeField;
		internal string componentDescriptionField;
		internal string componentTypeField;
		internal bool xsdSaleSoftwareTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProviderIdentification
		{
			get
			{
				return this.providerIdentificationField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.providerIdentificationField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ApplicationName
		{
			get
			{
				return this.applicationNameField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.applicationNameField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SoftwareVersion
		{
			get
			{
				return this.softwareVersionField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.softwareVersionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CertificationCode
		{
			get
			{
				return this.certificationCodeField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.certificationCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ComponentDescription
		{
			get
			{
				return this.componentDescriptionField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.componentDescriptionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ComponentType
		{
			get
			{
				return this.componentTypeField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = true;
				this.componentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleSoftwareTypeInitFlag
		{
			get
			{
				return this.xsdSaleSoftwareTypeInitFlagField;
			}
			set
			{
				this.xsdSaleSoftwareTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("58c7ddbf-59be-46d3-abe5-0f8f81e1b05f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoginResponseType : ILoginResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal POISystemDataType pOISystemDataField = new POISystemDataType();
		internal bool xsdLoginResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdLoginResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POISystemDataType POISystemData
		{
			get
			{
				return this.pOISystemDataField;
			}
			set
			{
				this.xsdLoginResponseTypeInitFlagField = true;
				this.pOISystemDataField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoginResponseTypeInitFlag
		{
			get
			{
				return this.xsdLoginResponseTypeInitFlagField;
			}
			set
			{
				this.xsdLoginResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("b6549c25-81f7-4520-af59-4a746c65ed45")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POISystemDataType : IPOISystemDataType
	{
		internal string dateTimeField;
		internal POISoftwareType pOISoftwareField = new POISoftwareType();
		internal POITerminalDataType pOITerminalDataField = new POITerminalDataType();
		internal POIStatusType pOIStatusField = new POIStatusType();
		internal bool tokenRequestStatusField;
		internal bool tokenRequestStatusFieldSpecified;
		internal bool customerOrderStatusField;
		internal bool customerOrderStatusFieldSpecified;
		internal bool xsdPOISystemDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string DateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.dateTimeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POISoftwareType POISoftware
		{
			get
			{
				return this.pOISoftwareField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.pOISoftwareField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POITerminalDataType POITerminalData
		{
			get
			{
				return this.pOITerminalDataField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.pOITerminalDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIStatusType POIStatus
		{
			get
			{
				return this.pOIStatusField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.pOIStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool TokenRequestStatus
		{
			get
			{
				return this.tokenRequestStatusField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.tokenRequestStatusField = value;
				this.TokenRequestStatusSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TokenRequestStatusSpecified
		{
			get
			{
				return this.tokenRequestStatusFieldSpecified;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.tokenRequestStatusFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool CustomerOrderStatus
		{
			get
			{
				return this.customerOrderStatusField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.customerOrderStatusField = value;
				this.CustomerOrderStatusSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CustomerOrderStatusSpecified
		{
			get
			{
				return this.customerOrderStatusFieldSpecified;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = true;
				this.customerOrderStatusFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOISystemDataTypeInitFlag
		{
			get
			{
				return this.xsdPOISystemDataTypeInitFlagField;
			}
			set
			{
				this.xsdPOISystemDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("74b65ce5-7c46-4556-a1c2-6c940d0344ee")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POISoftwareType : IPOISoftwareType
	{
		internal string providerIdentificationField;
		internal string applicationNameField;
		internal string softwareVersionField;
		internal string certificationCodeField;
		internal string componentDescriptionField;
		internal string componentTypeField;
		internal bool xsdPOISoftwareTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProviderIdentification
		{
			get
			{
				return this.providerIdentificationField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.providerIdentificationField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ApplicationName
		{
			get
			{
				return this.applicationNameField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.applicationNameField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SoftwareVersion
		{
			get
			{
				return this.softwareVersionField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.softwareVersionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CertificationCode
		{
			get
			{
				return this.certificationCodeField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.certificationCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ComponentDescription
		{
			get
			{
				return this.componentDescriptionField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.componentDescriptionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ComponentType
		{
			get
			{
				return this.componentTypeField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = true;
				this.componentTypeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOISoftwareTypeInitFlag
		{
			get
			{
				return this.xsdPOISoftwareTypeInitFlagField;
			}
			set
			{
				this.xsdPOISoftwareTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("bead7cd6-5670-4b62-b2a8-4409d9c56a38")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POITerminalDataType : IPOITerminalDataType
	{
		internal string pOICapabilitiesField;
		internal POIProfileType pOIProfileField = new POIProfileType();
		internal string terminalEnvironmentField;
		internal string pOISerialNumberField;
		internal bool xsdPOITerminalDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string POICapabilities
		{
			get
			{
				return this.pOICapabilitiesField;
			}
			set
			{
				this.xsdPOITerminalDataTypeInitFlagField = true;
				this.pOICapabilitiesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIProfileType POIProfile
		{
			get
			{
				return this.pOIProfileField;
			}
			set
			{
				this.xsdPOITerminalDataTypeInitFlagField = true;
				this.pOIProfileField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TerminalEnvironment
		{
			get
			{
				return this.terminalEnvironmentField;
			}
			set
			{
				this.xsdPOITerminalDataTypeInitFlagField = true;
				this.terminalEnvironmentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POISerialNumber
		{
			get
			{
				return this.pOISerialNumberField;
			}
			set
			{
				this.xsdPOITerminalDataTypeInitFlagField = true;
				this.pOISerialNumberField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOITerminalDataTypeInitFlag
		{
			get
			{
				return this.xsdPOITerminalDataTypeInitFlagField;
			}
			set
			{
				this.xsdPOITerminalDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("25bcf9e6-0779-4f8b-ac54-132dcc46c912")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class POIProfileType : IPOIProfileType
	{
		internal string serviceProfilesField;
		internal string genericProfileField;
		internal bool xsdPOIProfileTypeInitFlagField = false;
		public POIProfileType()
		{
			this.genericProfileField = "Standard";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ServiceProfiles
		{
			get
			{
				return this.serviceProfilesField;
			}
			set
			{
				this.xsdPOIProfileTypeInitFlagField = true;
				this.serviceProfilesField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("Standard")]
		public string GenericProfile
		{
			get
			{
				return this.genericProfileField;
			}
			set
			{
				this.xsdPOIProfileTypeInitFlagField = true;
				this.genericProfileField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPOIProfileTypeInitFlag
		{
			get
			{
				return this.xsdPOIProfileTypeInitFlagField;
			}
			set
			{
				this.xsdPOIProfileTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("074aaa47-c6c7-475a-9cc1-8e565828aaf1")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LogoutRequestType : ILogoutRequestType
	{
		internal bool maintenanceAllowedField;
		internal bool xsdLogoutRequestTypeInitFlagField = false;
		public LogoutRequestType()
		{
			this.maintenanceAllowedField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool MaintenanceAllowed
		{
			get
			{
				return this.maintenanceAllowedField;
			}
			set
			{
				this.xsdLogoutRequestTypeInitFlagField = true;
				this.maintenanceAllowedField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLogoutRequestTypeInitFlag
		{
			get
			{
				return this.xsdLogoutRequestTypeInitFlagField;
			}
			set
			{
				this.xsdLogoutRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("28ded6dc-c018-4d53-860c-f7f98d6d558f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LogoutResponseType : ILogoutResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal bool xsdLogoutResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdLogoutResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLogoutResponseTypeInitFlag
		{
			get
			{
				return this.xsdLogoutResponseTypeInitFlagField;
			}
			set
			{
				this.xsdLogoutResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum LoyaltyHandlingEnumeration
	{
		/// <remarks/>
		Forbidden,
		/// <remarks/>
		Processed,
		/// <remarks/>
		Allowed,
		/// <remarks/>
		Proposed,
		/// <remarks/>
		Required,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f2d1be5f-b2d4-4a2a-bdcb-17d130c0e410")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class LoyaltyResponseType : ILoyaltyResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal LoyaltyResultType[] loyaltyResultField = new LoyaltyResultType[0];
		internal PaymentReceiptType[] paymentReceiptField = new PaymentReceiptType[0];
		internal bool xsdLoyaltyResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyResultType[] LoyaltyResult
		{
			get
			{
				if (((this.loyaltyResultField == null)
								|| (this.loyaltyResultField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyResultField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = true;
				this.loyaltyResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentReceipt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentReceiptType[] PaymentReceipt
		{
			get
			{
				if (((this.paymentReceiptField == null)
								|| (this.paymentReceiptField.Length == 0)))
				{
					return null;
				}
				return this.paymentReceiptField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = true;
				this.paymentReceiptField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdLoyaltyResponseTypeInitFlag
		{
			get
			{
				return this.xsdLoyaltyResponseTypeInitFlagField;
			}
			set
			{
				this.xsdLoyaltyResponseTypeInitFlagField = value;
			}
		}
		public int LoyaltyResultSize()
		{
			if ((this.loyaltyResultField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyResultField.Length;
			}
		}
		public LoyaltyResultType LoyaltyResultGetItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return default(LoyaltyResultType);
				}
				else
				{
					if (((this.loyaltyResultField.Length - 1)
									>= index))
					{
						return this.loyaltyResultField[index];
					}
					else
					{
						return default(LoyaltyResultType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyResultType);
			}
		}
		public bool LoyaltyResultSetItem(int index, LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyResultField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultAddItem(LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyResultField.Length); i = (i + 1))
					{
						array[i] = loyaltyResultField[i];
					}
					array[i] = value;
					this.LoyaltyResult = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyResultField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						for (i = (i + 1); (i < this.loyaltyResultField.Length); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						this.LoyaltyResult = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int PaymentReceiptSize()
		{
			if ((this.paymentReceiptField == null))
			{
				return 0;
			}
			else
			{
				return this.paymentReceiptField.Length;
			}
		}
		public PaymentReceiptType PaymentReceiptGetItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return default(PaymentReceiptType);
				}
				else
				{
					if (((this.paymentReceiptField.Length - 1)
									>= index))
					{
						return this.paymentReceiptField[index];
					}
					else
					{
						return default(PaymentReceiptType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PaymentReceiptType);
			}
		}
		public bool PaymentReceiptSetItem(int index, PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					this.paymentReceiptField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptAddItem(PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.paymentReceiptField.Length); i = (i + 1))
					{
						array[i] = paymentReceiptField[i];
					}
					array[i] = value;
					this.PaymentReceipt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptRemoveItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					if ((this.paymentReceiptField.Length <= index))
					{
						return false;
					}
					else
					{
						PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						for (i = (i + 1); (i < this.paymentReceiptField.Length); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						this.PaymentReceipt = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a0511fc6-e582-4de8-8c95-1560966da6c4")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentReceiptType : IPaymentReceiptType
	{
		internal OutputContentType outputContentField = new OutputContentType();
		internal string documentQualifierField;
		internal bool integratedPrintFlagField;
		internal bool requiredSignatureFlagField;
		internal bool xsdPaymentReceiptTypeInitFlagField = false;
		public PaymentReceiptType()
		{
			this.integratedPrintFlagField = false;
			this.requiredSignatureFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputContentType OutputContent
		{
			get
			{
				return this.outputContentField;
			}
			set
			{
				this.xsdPaymentReceiptTypeInitFlagField = true;
				this.outputContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DocumentQualifier
		{
			get
			{
				return this.documentQualifierField;
			}
			set
			{
				this.xsdPaymentReceiptTypeInitFlagField = true;
				this.documentQualifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IntegratedPrintFlag
		{
			get
			{
				return this.integratedPrintFlagField;
			}
			set
			{
				this.xsdPaymentReceiptTypeInitFlagField = true;
				this.integratedPrintFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool RequiredSignatureFlag
		{
			get
			{
				return this.requiredSignatureFlagField;
			}
			set
			{
				this.xsdPaymentReceiptTypeInitFlagField = true;
				this.requiredSignatureFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentReceiptTypeInitFlag
		{
			get
			{
				return this.xsdPaymentReceiptTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentReceiptTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum LoyaltyTransactionTypeEnumeration
	{
		/// <remarks/>
		Award,
		/// <remarks/>
		Rebate,
		/// <remarks/>
		Redemption,
		/// <remarks/>
		AwardRefund,
		/// <remarks/>
		RebateRefund,
		/// <remarks/>
		RedemptionRefund,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum LoyaltyUnitEnumeration
	{
		/// <remarks/>
		Point,
		/// <remarks/>
		Monetary,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum MenuEntryTagEnumeration
	{
		/// <remarks/>
		Selectable,
		/// <remarks/>
		NonSelectable,
		/// <remarks/>
		SubMenu,
		/// <remarks/>
		NonSelectableSubMenu,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum MessageCategoryEnumeration
	{
		/// <remarks/>
		Abort,
		/// <remarks/>
		Admin,
		/// <remarks/>
		BalanceInquiry,
		/// <remarks/>
		Batch,
		/// <remarks/>
		CardAcquisition,
		/// <remarks/>
		CardReaderAPDU,
		/// <remarks/>
		CardReaderInit,
		/// <remarks/>
		CardReaderPowerOff,
		/// <remarks/>
		Diagnosis,
		/// <remarks/>
		Display,
		/// <remarks/>
		EnableService,
		/// <remarks/>
		Event,
		/// <remarks/>
		GetTotals,
		/// <remarks/>
		Input,
		/// <remarks/>
		InputUpdate,
		/// <remarks/>
		Login,
		/// <remarks/>
		Logout,
		/// <remarks/>
		Loyalty,
		/// <remarks/>
		Payment,
		/// <remarks/>
		PIN,
		/// <remarks/>
		Print,
		/// <remarks/>
		Reconciliation,
		/// <remarks/>
		Reversal,
		/// <remarks/>
		Sound,
		/// <remarks/>
		StoredValue,
		/// <remarks/>
		TransactionReport,
		/// <remarks/>
		TransactionStatus,
		/// <remarks/>
		Transmit,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum MessageClassEnumeration
	{
		/// <remarks/>
		Service,
		/// <remarks/>
		Device,
		/// <remarks/>
		Event,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("5e9fa431-dbee-4177-b109-c9cdc6f7d24d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class MessageHeaderType : IMessageHeaderType
	{
		internal string protocolVersionField;
		internal string messageClassField;
		internal string messageCategoryField;
		internal string messageTypeField;
		internal string serviceIDField;
		internal string deviceIDField;
		internal string saleIDField;
		internal string pOIIDField;
		internal bool xsdMessageHeaderTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProtocolVersion
		{
			get
			{
				return this.protocolVersionField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.protocolVersionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MessageClass
		{
			get
			{
				return this.messageClassField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.messageClassField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MessageCategory
		{
			get
			{
				return this.messageCategoryField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.messageCategoryField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string MessageType
		{
			get
			{
				return this.messageTypeField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.messageTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ServiceID
		{
			get
			{
				return this.serviceIDField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.serviceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DeviceID
		{
			get
			{
				return this.deviceIDField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.deviceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SaleID
		{
			get
			{
				return this.saleIDField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.saleIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIID
		{
			get
			{
				return this.pOIIDField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = true;
				this.pOIIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdMessageHeaderTypeInitFlag
		{
			get
			{
				return this.xsdMessageHeaderTypeInitFlagField;
			}
			set
			{
				this.xsdMessageHeaderTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum MessageTypeEnumeration
	{
		/// <remarks/>
		Request,
		/// <remarks/>
		Response,
		/// <remarks/>
		Notification,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum OperatorEnumeration
	{
		/// <remarks/>
		EQ,
		/// <remarks/>
		LE,
		/// <remarks/>
		LT,
		/// <remarks/>
		GE,
		/// <remarks/>
		GT,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum OutputFormatEnumeration
	{
		/// <remarks/>
		MessageRef,
		/// <remarks/>
		Text,
		/// <remarks/>
		XHTML,
		/// <remarks/>
		BarCode,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PaymentInstrumentTypeEnumeration
	{
		/// <remarks/>
		Card,
		/// <remarks/>
		Check,
		/// <remarks/>
		Mobile,
		/// <remarks/>
		StoredValue,
		/// <remarks/>
		Cash,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("60e754e0-8145-45e2-89d6-1283554c9341")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PaymentResponseType : IPaymentResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal PaymentResultType paymentResultField = new PaymentResultType();
		internal LoyaltyResultType[] loyaltyResultField = new LoyaltyResultType[0];
		internal PaymentReceiptType[] paymentReceiptField = new PaymentReceiptType[0];
		internal CustomerOrderType[] customerOrderField = new CustomerOrderType[0];
		internal bool xsdPaymentResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentResultType PaymentResult
		{
			get
			{
				return this.paymentResultField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.paymentResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public LoyaltyResultType[] LoyaltyResult
		{
			get
			{
				if (((this.loyaltyResultField == null)
								|| (this.loyaltyResultField.Length == 0)))
				{
					return null;
				}
				return this.loyaltyResultField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.loyaltyResultField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentReceipt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentReceiptType[] PaymentReceipt
		{
			get
			{
				if (((this.paymentReceiptField == null)
								|| (this.paymentReceiptField.Length == 0)))
				{
					return null;
				}
				return this.paymentReceiptField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.paymentReceiptField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CustomerOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CustomerOrderType[] CustomerOrder
		{
			get
			{
				if (((this.customerOrderField == null)
								|| (this.customerOrderField.Length == 0)))
				{
					return null;
				}
				return this.customerOrderField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = true;
				this.customerOrderField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPaymentResponseTypeInitFlag
		{
			get
			{
				return this.xsdPaymentResponseTypeInitFlagField;
			}
			set
			{
				this.xsdPaymentResponseTypeInitFlagField = value;
			}
		}
		public int LoyaltyResultSize()
		{
			if ((this.loyaltyResultField == null))
			{
				return 0;
			}
			else
			{
				return this.loyaltyResultField.Length;
			}
		}
		public LoyaltyResultType LoyaltyResultGetItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return default(LoyaltyResultType);
				}
				else
				{
					if (((this.loyaltyResultField.Length - 1)
									>= index))
					{
						return this.loyaltyResultField[index];
					}
					else
					{
						return default(LoyaltyResultType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(LoyaltyResultType);
			}
		}
		public bool LoyaltyResultSetItem(int index, LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					this.loyaltyResultField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultAddItem(LoyaltyResultType value)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.loyaltyResultField.Length); i = (i + 1))
					{
						array[i] = loyaltyResultField[i];
					}
					array[i] = value;
					this.LoyaltyResult = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool LoyaltyResultRemoveItem(int index)
		{
			try
			{
				if ((this.loyaltyResultField == default(LoyaltyResultType[])))
				{
					return false;
				}
				else
				{
					if ((this.loyaltyResultField.Length <= index))
					{
						return false;
					}
					else
					{
						LoyaltyResultType[] array = new LoyaltyResultType[(this.loyaltyResultField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						for (i = (i + 1); (i < this.loyaltyResultField.Length); i = (i + 1))
						{
							array[i] = loyaltyResultField[i];
						}
						this.LoyaltyResult = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int PaymentReceiptSize()
		{
			if ((this.paymentReceiptField == null))
			{
				return 0;
			}
			else
			{
				return this.paymentReceiptField.Length;
			}
		}
		public PaymentReceiptType PaymentReceiptGetItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return default(PaymentReceiptType);
				}
				else
				{
					if (((this.paymentReceiptField.Length - 1)
									>= index))
					{
						return this.paymentReceiptField[index];
					}
					else
					{
						return default(PaymentReceiptType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PaymentReceiptType);
			}
		}
		public bool PaymentReceiptSetItem(int index, PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					this.paymentReceiptField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptAddItem(PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.paymentReceiptField.Length); i = (i + 1))
					{
						array[i] = paymentReceiptField[i];
					}
					array[i] = value;
					this.PaymentReceipt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptRemoveItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					if ((this.paymentReceiptField.Length <= index))
					{
						return false;
					}
					else
					{
						PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						for (i = (i + 1); (i < this.paymentReceiptField.Length); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						this.PaymentReceipt = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public int CustomerOrderSize()
		{
			if ((this.customerOrderField == null))
			{
				return 0;
			}
			else
			{
				return this.customerOrderField.Length;
			}
		}
		public CustomerOrderType CustomerOrderGetItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return default(CustomerOrderType);
				}
				else
				{
					if (((this.customerOrderField.Length - 1)
									>= index))
					{
						return this.customerOrderField[index];
					}
					else
					{
						return default(CustomerOrderType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CustomerOrderType);
			}
		}
		public bool CustomerOrderSetItem(int index, CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					this.customerOrderField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderAddItem(CustomerOrderType value)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.customerOrderField.Length); i = (i + 1))
					{
						array[i] = customerOrderField[i];
					}
					array[i] = value;
					this.CustomerOrder = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CustomerOrderRemoveItem(int index)
		{
			try
			{
				if ((this.customerOrderField == default(CustomerOrderType[])))
				{
					return false;
				}
				else
				{
					if ((this.customerOrderField.Length <= index))
					{
						return false;
					}
					else
					{
						CustomerOrderType[] array = new CustomerOrderType[(this.customerOrderField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						for (i = (i + 1); (i < this.customerOrderField.Length); i = (i + 1))
						{
							array[i] = customerOrderField[i];
						}
						this.CustomerOrder = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PaymentTypeEnumeration
	{
		/// <remarks/>
		Normal,
		/// <remarks/>
		Refund,
		/// <remarks/>
		OneTimeReservation,
		/// <remarks/>
		FirstReservation,
		/// <remarks/>
		UpdateReservation,
		/// <remarks/>
		Completion,
		/// <remarks/>
		CashAdvance,
		/// <remarks/>
		CashDeposit,
		/// <remarks/>
		Recurring,
		/// <remarks/>
		Instalment,
		/// <remarks/>
		IssuerInstalment,
		/// <remarks/>
		PaidOut,
		/// <remarks/>
		VoiceAuthorisation,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PeriodUnitEnumeration
	{
		/// <remarks/>
		Daily,
		/// <remarks/>
		Weekly,
		/// <remarks/>
		Monthly,
		/// <remarks/>
		Annual,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PINFormatEnumeration
	{
		/// <remarks/>
		ISO0,
		/// <remarks/>
		ISO1,
		/// <remarks/>
		ISO2,
		/// <remarks/>
		ISO3,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2cb5469a-13bc-4921-a20c-71499a9cf247")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PINRequestType : IPINRequestType
	{
		internal CardholderPINType cardholderPINField = new CardholderPINType();
		internal string pINRequestType1Field;
		internal string pINVerifMethodField;
		internal string additionalInputField;
		internal string pINEncAlgorithmField;
		internal string pINFormatField;
		internal string keyReferenceField;
		internal string maxWaitingTimeField;
		internal bool xsdPINRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CardholderPINType CardholderPIN
		{
			get
			{
				return this.cardholderPINField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.cardholderPINField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("PINRequestType")]
		public string PINRequestType1
		{
			get
			{
				return this.pINRequestType1Field;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.pINRequestType1Field = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PINVerifMethod
		{
			get
			{
				return this.pINVerifMethodField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.pINVerifMethodField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AdditionalInput
		{
			get
			{
				return this.additionalInputField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.additionalInputField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PINEncAlgorithm
		{
			get
			{
				return this.pINEncAlgorithmField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.pINEncAlgorithmField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PINFormat
		{
			get
			{
				return this.pINFormatField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.pINFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string KeyReference
		{
			get
			{
				return this.keyReferenceField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.keyReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaxWaitingTime
		{
			get
			{
				return this.maxWaitingTimeField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = true;
				this.maxWaitingTimeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPINRequestTypeInitFlag
		{
			get
			{
				return this.xsdPINRequestTypeInitFlagField;
			}
			set
			{
				this.xsdPINRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PINRequestTypeEnumeration
	{
		/// <remarks/>
		PINVerify,
		/// <remarks/>
		PINVerifyOnly,
		/// <remarks/>
		PINEnter,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e8ca05b5-fa76-4500-8f02-ddd98af140dc")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PINResponseType : IPINResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal CardholderPINType cardholderPINField = new CardholderPINType();
		internal bool xsdPINResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdPINResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CardholderPINType CardholderPIN
		{
			get
			{
				return this.cardholderPINField;
			}
			set
			{
				this.xsdPINResponseTypeInitFlagField = true;
				this.cardholderPINField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPINResponseTypeInitFlag
		{
			get
			{
				return this.xsdPINResponseTypeInitFlagField;
			}
			set
			{
				this.xsdPINResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum POICapabilitiesEnumeration
	{
		/// <remarks/>
		CashierDisplay,
		/// <remarks/>
		CashierError,
		/// <remarks/>
		CashierInput,
		/// <remarks/>
		CustomerDisplay,
		/// <remarks/>
		CustomerError,
		/// <remarks/>
		CustomerInput,
		/// <remarks/>
		PrinterReceipt,
		/// <remarks/>
		PrinterDocument,
		/// <remarks/>
		PrinterVoucher,
		/// <remarks/>
		MagStripe,
		/// <remarks/>
		ICC,
		/// <remarks/>
		EMVContactless,
		/// <remarks/>
		CashHandling,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum PrinterStatusEnumeration
	{
		/// <remarks/>
		OK,
		/// <remarks/>
		PaperLow,
		/// <remarks/>
		NoPaper,
		/// <remarks/>
		PaperJam,
		/// <remarks/>
		OutOfOrder,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("6d8b12cd-3e1c-44c8-8576-77bd2c09b67e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PrintOutputType : IPrintOutputType
	{
		internal OutputContentType outputContentField = new OutputContentType();
		internal byte[] outputSignatureField = new byte[0];
		internal string documentQualifierField;
		internal string responseModeField;
		internal bool integratedPrintFlagField;
		internal bool requiredSignatureFlagField;
		internal bool xsdPrintOutputTypeInitFlagField = false;
		public PrintOutputType()
		{
			this.integratedPrintFlagField = false;
			this.requiredSignatureFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OutputContentType OutputContent
		{
			get
			{
				return this.outputContentField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.outputContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] OutputSignature
		{
			get
			{
				if (((this.outputSignatureField == null)
								|| (this.outputSignatureField.Length == 0)))
				{
					return null;
				}
				return this.outputSignatureField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.outputSignatureField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DocumentQualifier
		{
			get
			{
				return this.documentQualifierField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.documentQualifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ResponseMode
		{
			get
			{
				return this.responseModeField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.responseModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool IntegratedPrintFlag
		{
			get
			{
				return this.integratedPrintFlagField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.integratedPrintFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool RequiredSignatureFlag
		{
			get
			{
				return this.requiredSignatureFlagField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = true;
				this.requiredSignatureFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPrintOutputTypeInitFlag
		{
			get
			{
				return this.xsdPrintOutputTypeInitFlagField;
			}
			set
			{
				this.xsdPrintOutputTypeInitFlagField = value;
			}
		}
		public int OutputSignatureSize()
		{
			if ((this.outputSignatureField == null))
			{
				return 0;
			}
			else
			{
				return this.outputSignatureField.Length;
			}
		}
		public byte OutputSignatureGetItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.outputSignatureField.Length - 1)
									>= index))
					{
						return this.outputSignatureField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool OutputSignatureSetItem(int index, byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.outputSignatureField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureAddItem(byte value)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.outputSignatureField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.outputSignatureField.Length); i = (i + 1))
					{
						array[i] = outputSignatureField[i];
					}
					array[i] = value;
					this.OutputSignature = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool OutputSignatureRemoveItem(int index)
		{
			try
			{
				if ((this.outputSignatureField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.outputSignatureField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.outputSignatureField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						for (i = (i + 1); (i < this.outputSignatureField.Length); i = (i + 1))
						{
							array[i] = outputSignatureField[i];
						}
						this.OutputSignature = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("d4187341-2df6-4881-8bf9-81ad21f080e3")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PrintRequestType : IPrintRequestType
	{
		internal PrintOutputType printOutputField = new PrintOutputType();
		internal bool xsdPrintRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PrintOutputType PrintOutput
		{
			get
			{
				return this.printOutputField;
			}
			set
			{
				this.xsdPrintRequestTypeInitFlagField = true;
				this.printOutputField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPrintRequestTypeInitFlag
		{
			get
			{
				return this.xsdPrintRequestTypeInitFlagField;
			}
			set
			{
				this.xsdPrintRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("aa0b886a-961a-4177-89d3-21e41640fb6a")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class PrintResponseType : IPrintResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal string documentQualifierField;
		internal bool xsdPrintResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdPrintResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DocumentQualifier
		{
			get
			{
				return this.documentQualifierField;
			}
			set
			{
				this.xsdPrintResponseTypeInitFlagField = true;
				this.documentQualifierField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdPrintResponseTypeInitFlag
		{
			get
			{
				return this.xsdPrintResponseTypeInitFlagField;
			}
			set
			{
				this.xsdPrintResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e0ede1a6-d1b2-4292-9f1f-37a4000368ca")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReconciliationRequestType : IReconciliationRequestType
	{
		internal string[] acquirerIDField = new string[0];
		internal string reconciliationTypeField;
		internal string pOIReconciliationIDField;
		internal bool xsdReconciliationRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AcquirerID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] AcquirerID
		{
			get
			{
				if (((this.acquirerIDField == null)
								|| (this.acquirerIDField.Length == 0)))
				{
					return null;
				}
				return this.acquirerIDField;
			}
			set
			{
				this.xsdReconciliationRequestTypeInitFlagField = true;
				this.acquirerIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ReconciliationType
		{
			get
			{
				return this.reconciliationTypeField;
			}
			set
			{
				this.xsdReconciliationRequestTypeInitFlagField = true;
				this.reconciliationTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIReconciliationID
		{
			get
			{
				return this.pOIReconciliationIDField;
			}
			set
			{
				this.xsdReconciliationRequestTypeInitFlagField = true;
				this.pOIReconciliationIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdReconciliationRequestTypeInitFlag
		{
			get
			{
				return this.xsdReconciliationRequestTypeInitFlagField;
			}
			set
			{
				this.xsdReconciliationRequestTypeInitFlagField = value;
			}
		}
		public int AcquirerIDSize()
		{
			if ((this.acquirerIDField == null))
			{
				return 0;
			}
			else
			{
				return this.acquirerIDField.Length;
			}
		}
		public string AcquirerIDGetItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.acquirerIDField.Length - 1)
									>= index))
					{
						return this.acquirerIDField[index];
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
		}
		public bool AcquirerIDSetItem(int index, string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					this.acquirerIDField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDAddItem(string value)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.acquirerIDField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.acquirerIDField.Length); i = (i + 1))
					{
						array[i] = acquirerIDField[i];
					}
					array[i] = value;
					this.AcquirerID = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool AcquirerIDRemoveItem(int index)
		{
			try
			{
				if ((this.acquirerIDField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.acquirerIDField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.acquirerIDField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						for (i = (i + 1); (i < this.acquirerIDField.Length); i = (i + 1))
						{
							array[i] = acquirerIDField[i];
						}
						this.AcquirerID = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a909bf81-7a65-4daa-8527-0f173fa1b7f0")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReconciliationResponseType : IReconciliationResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal TransactionTotalsType[] transactionTotalsField = new TransactionTotalsType[0];
		internal string reconciliationTypeField;
		internal string pOIReconciliationIDField;
		internal bool xsdReconciliationResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdReconciliationResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransactionTotals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionTotalsType[] TransactionTotals
		{
			get
			{
				if (((this.transactionTotalsField == null)
								|| (this.transactionTotalsField.Length == 0)))
				{
					return null;
				}
				return this.transactionTotalsField;
			}
			set
			{
				this.xsdReconciliationResponseTypeInitFlagField = true;
				this.transactionTotalsField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ReconciliationType
		{
			get
			{
				return this.reconciliationTypeField;
			}
			set
			{
				this.xsdReconciliationResponseTypeInitFlagField = true;
				this.reconciliationTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string POIReconciliationID
		{
			get
			{
				return this.pOIReconciliationIDField;
			}
			set
			{
				this.xsdReconciliationResponseTypeInitFlagField = true;
				this.pOIReconciliationIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdReconciliationResponseTypeInitFlag
		{
			get
			{
				return this.xsdReconciliationResponseTypeInitFlagField;
			}
			set
			{
				this.xsdReconciliationResponseTypeInitFlagField = value;
			}
		}
		public int TransactionTotalsSize()
		{
			if ((this.transactionTotalsField == null))
			{
				return 0;
			}
			else
			{
				return this.transactionTotalsField.Length;
			}
		}
		public TransactionTotalsType TransactionTotalsGetItem(int index)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return default(TransactionTotalsType);
				}
				else
				{
					if (((this.transactionTotalsField.Length - 1)
									>= index))
					{
						return this.transactionTotalsField[index];
					}
					else
					{
						return default(TransactionTotalsType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TransactionTotalsType);
			}
		}
		public bool TransactionTotalsSetItem(int index, TransactionTotalsType value)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					this.transactionTotalsField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionTotalsAddItem(TransactionTotalsType value)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					TransactionTotalsType[] array = new TransactionTotalsType[(this.transactionTotalsField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.transactionTotalsField.Length); i = (i + 1))
					{
						array[i] = transactionTotalsField[i];
					}
					array[i] = value;
					this.TransactionTotals = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionTotalsRemoveItem(int index)
		{
			try
			{
				if ((this.transactionTotalsField == default(TransactionTotalsType[])))
				{
					return false;
				}
				else
				{
					if ((this.transactionTotalsField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionTotalsType[] array = new TransactionTotalsType[(this.transactionTotalsField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = transactionTotalsField[i];
						}
						for (i = (i + 1); (i < this.transactionTotalsField.Length); i = (i + 1))
						{
							array[i] = transactionTotalsField[i];
						}
						this.TransactionTotals = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ReconciliationTypeEnumeration
	{
		/// <remarks/>
		SaleReconciliation,
		/// <remarks/>
		AcquirerSynchronisation,
		/// <remarks/>
		AcquirerReconciliation,
		/// <remarks/>
		PreviousReconciliation,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("94fcfd76-6853-4a36-8e08-56eb2a4617bf")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class RepeatedMessageResponseType : IRepeatedMessageResponseType
	{
		internal MessageHeaderType messageHeaderField = new MessageHeaderType();
		internal object itemField;
		internal bool xsdRepeatedMessageResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageHeaderType MessageHeader
		{
			get
			{
				return this.messageHeaderField;
			}
			set
			{
				this.xsdRepeatedMessageResponseTypeInitFlagField = true;
				this.messageHeaderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CardAcquisitionResponse", typeof(CardAcquisitionResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderAPDUResponse", typeof(CardReaderAPDUResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyResponse", typeof(LoyaltyResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PaymentResponse", typeof(PaymentResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReversalResponse", typeof(ReversalResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("StoredValueResponse", typeof(StoredValueResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.xsdRepeatedMessageResponseTypeInitFlagField = true;
				this.itemField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdRepeatedMessageResponseTypeInitFlag
		{
			get
			{
				return this.xsdRepeatedMessageResponseTypeInitFlagField;
			}
			set
			{
				this.xsdRepeatedMessageResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7b57f183-c1cd-40b9-8728-a3a92f77f4a8")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class ReversalResponseType : IReversalResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal POIDataType pOIDataField = new POIDataType();
		internal OriginalPOITransactionType originalPOITransactionField = new OriginalPOITransactionType();
		internal PaymentReceiptType[] paymentReceiptField = new PaymentReceiptType[0];
		internal double reversedAmountField;
		internal bool reversedAmountFieldSpecified;
		internal string customerOrderIDField;
		internal bool xsdReversalResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OriginalPOITransactionType OriginalPOITransaction
		{
			get
			{
				return this.originalPOITransactionField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.originalPOITransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PaymentReceipt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentReceiptType[] PaymentReceipt
		{
			get
			{
				if (((this.paymentReceiptField == null)
								|| (this.paymentReceiptField.Length == 0)))
				{
					return null;
				}
				return this.paymentReceiptField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.paymentReceiptField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ReversedAmount
		{
			get
			{
				return this.reversedAmountField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.reversedAmountField = value;
				this.ReversedAmountSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ReversedAmountSpecified
		{
			get
			{
				return this.reversedAmountFieldSpecified;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.reversedAmountFieldSpecified = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerOrderID
		{
			get
			{
				return this.customerOrderIDField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = true;
				this.customerOrderIDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdReversalResponseTypeInitFlag
		{
			get
			{
				return this.xsdReversalResponseTypeInitFlagField;
			}
			set
			{
				this.xsdReversalResponseTypeInitFlagField = value;
			}
		}
		public int PaymentReceiptSize()
		{
			if ((this.paymentReceiptField == null))
			{
				return 0;
			}
			else
			{
				return this.paymentReceiptField.Length;
			}
		}
		public PaymentReceiptType PaymentReceiptGetItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return default(PaymentReceiptType);
				}
				else
				{
					if (((this.paymentReceiptField.Length - 1)
									>= index))
					{
						return this.paymentReceiptField[index];
					}
					else
					{
						return default(PaymentReceiptType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(PaymentReceiptType);
			}
		}
		public bool PaymentReceiptSetItem(int index, PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					this.paymentReceiptField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptAddItem(PaymentReceiptType value)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.paymentReceiptField.Length); i = (i + 1))
					{
						array[i] = paymentReceiptField[i];
					}
					array[i] = value;
					this.PaymentReceipt = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool PaymentReceiptRemoveItem(int index)
		{
			try
			{
				if ((this.paymentReceiptField == default(PaymentReceiptType[])))
				{
					return false;
				}
				else
				{
					if ((this.paymentReceiptField.Length <= index))
					{
						return false;
					}
					else
					{
						PaymentReceiptType[] array = new PaymentReceiptType[(this.paymentReceiptField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						for (i = (i + 1); (i < this.paymentReceiptField.Length); i = (i + 1))
						{
							array[i] = paymentReceiptField[i];
						}
						this.PaymentReceipt = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("a3402fe3-2bda-4026-9b67-d45a2b494155")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueResponseType : IStoredValueResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal StoredValueResultType[] storedValueResultField = new StoredValueResultType[0];
		internal bool xsdStoredValueResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdStoredValueResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdStoredValueResponseTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdStoredValueResponseTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StoredValueResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StoredValueResultType[] StoredValueResult
		{
			get
			{
				if (((this.storedValueResultField == null)
								|| (this.storedValueResultField.Length == 0)))
				{
					return null;
				}
				return this.storedValueResultField;
			}
			set
			{
				this.xsdStoredValueResponseTypeInitFlagField = true;
				this.storedValueResultField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueResponseTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueResponseTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueResponseTypeInitFlagField = value;
			}
		}
		public int StoredValueResultSize()
		{
			if ((this.storedValueResultField == null))
			{
				return 0;
			}
			else
			{
				return this.storedValueResultField.Length;
			}
		}
		public StoredValueResultType StoredValueResultGetItem(int index)
		{
			try
			{
				if ((this.storedValueResultField == default(StoredValueResultType[])))
				{
					return default(StoredValueResultType);
				}
				else
				{
					if (((this.storedValueResultField.Length - 1)
									>= index))
					{
						return this.storedValueResultField[index];
					}
					else
					{
						return default(StoredValueResultType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(StoredValueResultType);
			}
		}
		public bool StoredValueResultSetItem(int index, StoredValueResultType value)
		{
			try
			{
				if ((this.storedValueResultField == default(StoredValueResultType[])))
				{
					return false;
				}
				else
				{
					this.storedValueResultField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool StoredValueResultAddItem(StoredValueResultType value)
		{
			try
			{
				if ((this.storedValueResultField == default(StoredValueResultType[])))
				{
					return false;
				}
				else
				{
					StoredValueResultType[] array = new StoredValueResultType[(this.storedValueResultField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.storedValueResultField.Length); i = (i + 1))
					{
						array[i] = storedValueResultField[i];
					}
					array[i] = value;
					this.StoredValueResult = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool StoredValueResultRemoveItem(int index)
		{
			try
			{
				if ((this.storedValueResultField == default(StoredValueResultType[])))
				{
					return false;
				}
				else
				{
					if ((this.storedValueResultField.Length <= index))
					{
						return false;
					}
					else
					{
						StoredValueResultType[] array = new StoredValueResultType[(this.storedValueResultField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = storedValueResultField[i];
						}
						for (i = (i + 1); (i < this.storedValueResultField.Length); i = (i + 1))
						{
							array[i] = storedValueResultField[i];
						}
						this.StoredValueResult = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("67b9b06e-09e6-45d7-b8f6-d5cbb3d92d0c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueResultType : IStoredValueResultType
	{
		internal StoredValueAccountStatusType storedValueAccountStatusField = new StoredValueAccountStatusType();
		internal TransactionIdentificationType hostTransactionIDField = new TransactionIdentificationType();
		internal string storedValueTransactionTypeField;
		internal string productCodeField;
		internal string eanUpcField;
		internal double itemAmountField;
		internal string currencyField;
		internal bool xsdStoredValueResultTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StoredValueAccountStatusType StoredValueAccountStatus
		{
			get
			{
				return this.storedValueAccountStatusField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.storedValueAccountStatusField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionIdentificationType HostTransactionID
		{
			get
			{
				return this.hostTransactionIDField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.hostTransactionIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StoredValueTransactionType
		{
			get
			{
				return this.storedValueTransactionTypeField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.storedValueTransactionTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProductCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.productCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EanUpc
		{
			get
			{
				return this.eanUpcField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.eanUpcField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.itemAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueResultTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueResultTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueResultTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("cced41f5-70b1-460b-a4e2-e3bb2fd5df45")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueAccountStatusType : IStoredValueAccountStatusType
	{
		internal StoredValueAccountIDType storedValueAccountIDField = new StoredValueAccountIDType();
		internal double currentBalanceField;
		internal bool currentBalanceFieldSpecified;
		internal bool xsdStoredValueAccountStatusTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StoredValueAccountIDType StoredValueAccountID
		{
			get
			{
				return this.storedValueAccountIDField;
			}
			set
			{
				this.xsdStoredValueAccountStatusTypeInitFlagField = true;
				this.storedValueAccountIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double CurrentBalance
		{
			get
			{
				return this.currentBalanceField;
			}
			set
			{
				this.xsdStoredValueAccountStatusTypeInitFlagField = true;
				this.currentBalanceField = value;
				this.CurrentBalanceSpecified = true;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool CurrentBalanceSpecified
		{
			get
			{
				return this.currentBalanceFieldSpecified;
			}
			set
			{
				this.xsdStoredValueAccountStatusTypeInitFlagField = true;
				this.currentBalanceFieldSpecified = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueAccountStatusTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueAccountStatusTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueAccountStatusTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e1cfd5b1-076b-4dea-847c-5013b158b39e")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueAccountIDType : IStoredValueAccountIDType
	{
		internal string storedValueAccountTypeField;
		internal string storedValueProviderField;
		internal string ownerNameField;
		internal string expiryDateField;
		internal string[] entryModeField = new string[0];
		internal string identificationTypeField;
		internal string valueField;
		internal bool xsdStoredValueAccountIDTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StoredValueAccountType
		{
			get
			{
				return this.storedValueAccountTypeField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.storedValueAccountTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StoredValueProvider
		{
			get
			{
				return this.storedValueProviderField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.storedValueProviderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OwnerName
		{
			get
			{
				return this.ownerNameField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.ownerNameField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ExpiryDate
		{
			get
			{
				return this.expiryDateField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.expiryDateField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string[] EntryMode
		{
			get
			{
				if (((this.entryModeField == null)
								|| (this.entryModeField.Length == 0)))
				{
					return null;
				}
				return this.entryModeField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.entryModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IdentificationType
		{
			get
			{
				return this.identificationTypeField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.identificationTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueAccountIDTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueAccountIDTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueAccountIDTypeInitFlagField = value;
			}
		}
		public int EntryModeSize()
		{
			if ((this.entryModeField == null))
			{
				return 0;
			}
			else
			{
				return this.entryModeField.Length;
			}
		}
		public string EntryModeGetItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.entryModeField.Length - 1)
									>= index))
					{
						return this.entryModeField[index];
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
		}
		public bool EntryModeSetItem(int index, string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					this.entryModeField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeAddItem(string value)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.entryModeField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.entryModeField.Length); i = (i + 1))
					{
						array[i] = entryModeField[i];
					}
					array[i] = value;
					this.EntryMode = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool EntryModeRemoveItem(int index)
		{
			try
			{
				if ((this.entryModeField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.entryModeField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.entryModeField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						for (i = (i + 1); (i < this.entryModeField.Length); i = (i + 1))
						{
							array[i] = entryModeField[i];
						}
						this.EntryMode = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ResponseModeEnumeration
	{
		/// <remarks/>
		NotRequired,
		/// <remarks/>
		Immediate,
		/// <remarks/>
		PrintEnd,
		/// <remarks/>
		SoundEnd,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ResultEnumeration
	{
		/// <remarks/>
		Success,
		/// <remarks/>
		Failure,
		/// <remarks/>
		Partial,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ReversalReasonEnumeration
	{
		/// <remarks/>
		CustCancel,
		/// <remarks/>
		MerchantCancel,
		/// <remarks/>
		Malfunction,
		/// <remarks/>
		Unable2Compl,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SaleCapabilitiesEnumeration
	{
		/// <remarks/>
		CashierStatus,
		/// <remarks/>
		CashierError,
		/// <remarks/>
		CashierDisplay,
		/// <remarks/>
		POIReplication,
		/// <remarks/>
		CashierInput,
		/// <remarks/>
		CustomerAssistance,
		/// <remarks/>
		CustomerDisplay,
		/// <remarks/>
		CustomerError,
		/// <remarks/>
		CustomerInput,
		/// <remarks/>
		PrinterReceipt,
		/// <remarks/>
		PrinterDocument,
		/// <remarks/>
		PrinterVoucher,
		/// <remarks/>
		MagStripe,
		/// <remarks/>
		ICC,
		/// <remarks/>
		EMVContactless,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("73cf4d0a-f3f1-44ac-8ec6-9f4cd880effe")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SearchANDType : ISearchANDType
	{
		internal string targetField;
		internal OperatorEnumeration operatorField = new OperatorEnumeration();
		internal string valueField;
		internal bool xsdSearchANDTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.xsdSearchANDTypeInitFlagField = true;
				this.targetField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OperatorEnumeration Operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.xsdSearchANDTypeInitFlagField = true;
				this.operatorField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdSearchANDTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSearchANDTypeInitFlag
		{
			get
			{
				return this.xsdSearchANDTypeInitFlagField;
			}
			set
			{
				this.xsdSearchANDTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("06851301-ee5a-4e6e-97c8-eb3434939a45")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SearchCriteriasType : ISearchCriteriasType
	{
		internal SearchANDType[][] searchORField;
		internal bool xsdSearchCriteriasTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SearchAND", typeof(SearchANDType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public SearchANDType[][] SearchOR
		{
			get
			{
				return this.searchORField;
			}
			set
			{
				this.xsdSearchCriteriasTypeInitFlagField = true;
				this.searchORField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSearchCriteriasTypeInitFlag
		{
			get
			{
				return this.xsdSearchCriteriasTypeInitFlagField;
			}
			set
			{
				this.xsdSearchCriteriasTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e3a4600c-73c4-4814-be3d-ad79ea9773d6")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SearchORType : ISearchORType
	{
		internal SearchANDType[] searchANDField = new SearchANDType[0];
		internal bool xsdSearchORTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SearchAND", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SearchANDType[] SearchAND
		{
			get
			{
				if (((this.searchANDField == null)
								|| (this.searchANDField.Length == 0)))
				{
					return null;
				}
				return this.searchANDField;
			}
			set
			{
				this.xsdSearchORTypeInitFlagField = true;
				this.searchANDField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSearchORTypeInitFlag
		{
			get
			{
				return this.xsdSearchORTypeInitFlagField;
			}
			set
			{
				this.xsdSearchORTypeInitFlagField = value;
			}
		}
		public int SearchANDSize()
		{
			if ((this.searchANDField == null))
			{
				return 0;
			}
			else
			{
				return this.searchANDField.Length;
			}
		}
		public SearchANDType SearchANDGetItem(int index)
		{
			try
			{
				if ((this.searchANDField == default(SearchANDType[])))
				{
					return default(SearchANDType);
				}
				else
				{
					if (((this.searchANDField.Length - 1)
									>= index))
					{
						return this.searchANDField[index];
					}
					else
					{
						return default(SearchANDType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(SearchANDType);
			}
		}
		public bool SearchANDSetItem(int index, SearchANDType value)
		{
			try
			{
				if ((this.searchANDField == default(SearchANDType[])))
				{
					return false;
				}
				else
				{
					this.searchANDField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SearchANDAddItem(SearchANDType value)
		{
			try
			{
				if ((this.searchANDField == default(SearchANDType[])))
				{
					return false;
				}
				else
				{
					SearchANDType[] array = new SearchANDType[(this.searchANDField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.searchANDField.Length); i = (i + 1))
					{
						array[i] = searchANDField[i];
					}
					array[i] = value;
					this.SearchAND = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SearchANDRemoveItem(int index)
		{
			try
			{
				if ((this.searchANDField == default(SearchANDType[])))
				{
					return false;
				}
				else
				{
					if ((this.searchANDField.Length <= index))
					{
						return false;
					}
					else
					{
						SearchANDType[] array = new SearchANDType[(this.searchANDField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = searchANDField[i];
						}
						for (i = (i + 1); (i < this.searchANDField.Length); i = (i + 1))
						{
							array[i] = searchANDField[i];
						}
						this.SearchAND = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("f863a4da-4868-4862-8b96-e5e1a4d8274d")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SearchOutputOrderType : ISearchOutputOrderType
	{
		internal CriteriaOrderType[] criteriaOrderField = new CriteriaOrderType[0];
		internal bool xsdSearchOutputOrderTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CriteriaOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CriteriaOrderType[] CriteriaOrder
		{
			get
			{
				if (((this.criteriaOrderField == null)
								|| (this.criteriaOrderField.Length == 0)))
				{
					return null;
				}
				return this.criteriaOrderField;
			}
			set
			{
				this.xsdSearchOutputOrderTypeInitFlagField = true;
				this.criteriaOrderField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSearchOutputOrderTypeInitFlag
		{
			get
			{
				return this.xsdSearchOutputOrderTypeInitFlagField;
			}
			set
			{
				this.xsdSearchOutputOrderTypeInitFlagField = value;
			}
		}
		public int CriteriaOrderSize()
		{
			if ((this.criteriaOrderField == null))
			{
				return 0;
			}
			else
			{
				return this.criteriaOrderField.Length;
			}
		}
		public CriteriaOrderType CriteriaOrderGetItem(int index)
		{
			try
			{
				if ((this.criteriaOrderField == default(CriteriaOrderType[])))
				{
					return default(CriteriaOrderType);
				}
				else
				{
					if (((this.criteriaOrderField.Length - 1)
									>= index))
					{
						return this.criteriaOrderField[index];
					}
					else
					{
						return default(CriteriaOrderType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CriteriaOrderType);
			}
		}
		public bool CriteriaOrderSetItem(int index, CriteriaOrderType value)
		{
			try
			{
				if ((this.criteriaOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					this.criteriaOrderField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CriteriaOrderAddItem(CriteriaOrderType value)
		{
			try
			{
				if ((this.criteriaOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					CriteriaOrderType[] array = new CriteriaOrderType[(this.criteriaOrderField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.criteriaOrderField.Length); i = (i + 1))
					{
						array[i] = criteriaOrderField[i];
					}
					array[i] = value;
					this.CriteriaOrder = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool CriteriaOrderRemoveItem(int index)
		{
			try
			{
				if ((this.criteriaOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					if ((this.criteriaOrderField.Length <= index))
					{
						return false;
					}
					else
					{
						CriteriaOrderType[] array = new CriteriaOrderType[(this.criteriaOrderField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = criteriaOrderField[i];
						}
						for (i = (i + 1); (i < this.criteriaOrderField.Length); i = (i + 1))
						{
							array[i] = criteriaOrderField[i];
						}
						this.CriteriaOrder = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ServicesEnabledEnumeration
	{
		/// <remarks/>
		CardAcquisition,
		/// <remarks/>
		Payment,
		/// <remarks/>
		Loyalty,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum ServiceProfilesEnumeration
	{
		/// <remarks/>
		Synchro,
		/// <remarks/>
		Batch,
		/// <remarks/>
		OneTimeRes,
		/// <remarks/>
		Reservation,
		/// <remarks/>
		Loyalty,
		/// <remarks/>
		StoredValue,
		/// <remarks/>
		PIN,
		/// <remarks/>
		CardReader,
		/// <remarks/>
		Sound,
		/// <remarks/>
		Communication,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SoundActionEnumeration
	{
		/// <remarks/>
		StartSound,
		/// <remarks/>
		StopSound,
		/// <remarks/>
		SetDefaultVolume,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("7984e954-ea01-4633-b17f-f688fc726e5c")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SoundContentType : ISoundContentType
	{
		internal string soundFormatField;
		internal string languageField;
		internal string referenceIDField;
		internal string valueField;
		internal bool xsdSoundContentTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SoundFormat
		{
			get
			{
				return this.soundFormatField;
			}
			set
			{
				this.xsdSoundContentTypeInitFlagField = true;
				this.soundFormatField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.xsdSoundContentTypeInitFlagField = true;
				this.languageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ReferenceID
		{
			get
			{
				return this.referenceIDField;
			}
			set
			{
				this.xsdSoundContentTypeInitFlagField = true;
				this.referenceIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.xsdSoundContentTypeInitFlagField = true;
				this.valueField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSoundContentTypeInitFlag
		{
			get
			{
				return this.xsdSoundContentTypeInitFlagField;
			}
			set
			{
				this.xsdSoundContentTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("8081f7ee-814c-4c43-bcf2-6de1ce2dd0fe")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SoundRequestType : ISoundRequestType
	{
		internal SoundContentType soundContentField = new SoundContentType();
		internal string responseModeField;
		internal string soundActionField;
		internal string soundVolumeField;
		internal bool xsdSoundRequestTypeInitFlagField = false;
		public SoundRequestType()
		{
			this.responseModeField = "NotRequired";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SoundContentType SoundContent
		{
			get
			{
				return this.soundContentField;
			}
			set
			{
				this.xsdSoundRequestTypeInitFlagField = true;
				this.soundContentField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute("NotRequired")]
		public string ResponseMode
		{
			get
			{
				return this.responseModeField;
			}
			set
			{
				this.xsdSoundRequestTypeInitFlagField = true;
				this.responseModeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SoundAction
		{
			get
			{
				return this.soundActionField;
			}
			set
			{
				this.xsdSoundRequestTypeInitFlagField = true;
				this.soundActionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string SoundVolume
		{
			get
			{
				return this.soundVolumeField;
			}
			set
			{
				this.xsdSoundRequestTypeInitFlagField = true;
				this.soundVolumeField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSoundRequestTypeInitFlag
		{
			get
			{
				return this.xsdSoundRequestTypeInitFlagField;
			}
			set
			{
				this.xsdSoundRequestTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("1236e09e-6ddd-4c2a-a16a-12553d22a367")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SoundResponseType : ISoundResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal bool xsdSoundResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdSoundResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSoundResponseTypeInitFlag
		{
			get
			{
				return this.xsdSoundResponseTypeInitFlagField;
			}
			set
			{
				this.xsdSoundResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum SoundFormatEnumeration
	{
		/// <remarks/>
		SoundRef,
		/// <remarks/>
		MessageRef,
		/// <remarks/>
		Text,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum StoredValueAccountTypeEnumeration
	{
		/// <remarks/>
		GiftCard,
		/// <remarks/>
		PhoneCard,
		/// <remarks/>
		Other,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("4243473e-bad2-4009-9553-5be496b8f489")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueDataType : IStoredValueDataType
	{
		internal StoredValueAccountIDType storedValueAccountIDField = new StoredValueAccountIDType();
		internal OriginalPOITransactionType originalPOITransactionField = new OriginalPOITransactionType();
		internal string storedValueProviderField;
		internal string storedValueTransactionTypeField;
		internal string productCodeField;
		internal string eanUpcField;
		internal double itemAmountField;
		internal string currencyField;
		internal bool xsdStoredValueDataTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StoredValueAccountIDType StoredValueAccountID
		{
			get
			{
				return this.storedValueAccountIDField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.storedValueAccountIDField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OriginalPOITransactionType OriginalPOITransaction
		{
			get
			{
				return this.originalPOITransactionField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.originalPOITransactionField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StoredValueProvider
		{
			get
			{
				return this.storedValueProviderField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.storedValueProviderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string StoredValueTransactionType
		{
			get
			{
				return this.storedValueTransactionTypeField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.storedValueTransactionTypeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProductCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.productCodeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string EanUpc
		{
			get
			{
				return this.eanUpcField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.eanUpcField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public double ItemAmount
		{
			get
			{
				return this.itemAmountField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.itemAmountField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = true;
				this.currencyField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueDataTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueDataTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueDataTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("34e964a3-cb45-4cce-86ff-1f837b8ab8b9")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class StoredValueRequestType : IStoredValueRequestType
	{
		internal SaleDataType saleDataField = new SaleDataType();
		internal StoredValueDataType[] storedValueDataField = new StoredValueDataType[0];
		internal string customerLanguageField;
		internal bool xsdStoredValueRequestTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdStoredValueRequestTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("StoredValueData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public StoredValueDataType[] StoredValueData
		{
			get
			{
				if (((this.storedValueDataField == null)
								|| (this.storedValueDataField.Length == 0)))
				{
					return null;
				}
				return this.storedValueDataField;
			}
			set
			{
				this.xsdStoredValueRequestTypeInitFlagField = true;
				this.storedValueDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CustomerLanguage
		{
			get
			{
				return this.customerLanguageField;
			}
			set
			{
				this.xsdStoredValueRequestTypeInitFlagField = true;
				this.customerLanguageField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdStoredValueRequestTypeInitFlag
		{
			get
			{
				return this.xsdStoredValueRequestTypeInitFlagField;
			}
			set
			{
				this.xsdStoredValueRequestTypeInitFlagField = value;
			}
		}
		public int StoredValueDataSize()
		{
			if ((this.storedValueDataField == null))
			{
				return 0;
			}
			else
			{
				return this.storedValueDataField.Length;
			}
		}
		public StoredValueDataType StoredValueDataGetItem(int index)
		{
			try
			{
				if ((this.storedValueDataField == default(StoredValueDataType[])))
				{
					return default(StoredValueDataType);
				}
				else
				{
					if (((this.storedValueDataField.Length - 1)
									>= index))
					{
						return this.storedValueDataField[index];
					}
					else
					{
						return default(StoredValueDataType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(StoredValueDataType);
			}
		}
		public bool StoredValueDataSetItem(int index, StoredValueDataType value)
		{
			try
			{
				if ((this.storedValueDataField == default(StoredValueDataType[])))
				{
					return false;
				}
				else
				{
					this.storedValueDataField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool StoredValueDataAddItem(StoredValueDataType value)
		{
			try
			{
				if ((this.storedValueDataField == default(StoredValueDataType[])))
				{
					return false;
				}
				else
				{
					StoredValueDataType[] array = new StoredValueDataType[(this.storedValueDataField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.storedValueDataField.Length); i = (i + 1))
					{
						array[i] = storedValueDataField[i];
					}
					array[i] = value;
					this.StoredValueData = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool StoredValueDataRemoveItem(int index)
		{
			try
			{
				if ((this.storedValueDataField == default(StoredValueDataType[])))
				{
					return false;
				}
				else
				{
					if ((this.storedValueDataField.Length <= index))
					{
						return false;
					}
					else
					{
						StoredValueDataType[] array = new StoredValueDataType[(this.storedValueDataField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = storedValueDataField[i];
						}
						for (i = (i + 1); (i < this.storedValueDataField.Length); i = (i + 1))
						{
							array[i] = storedValueDataField[i];
						}
						this.StoredValueData = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum StoredValueTransactionTypeEnumeration
	{
		/// <remarks/>
		Reserve,
		/// <remarks/>
		Activate,
		/// <remarks/>
		Load,
		/// <remarks/>
		Unload,
		/// <remarks/>
		Reverse,
		/// <remarks/>
		Duplicate,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TerminalEnvironmentEnumeration
	{
		/// <remarks/>
		Attended,
		/// <remarks/>
		SemiAttended,
		/// <remarks/>
		Unattended,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TokenRequestedTypeEnumeration
	{
		/// <remarks/>
		Transaction,
		/// <remarks/>
		Customer,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TotalDetailsEnumeration
	{
		/// <remarks/>
		POIID,
		/// <remarks/>
		SaleID,
		/// <remarks/>
		OperatorID,
		/// <remarks/>
		ShiftNumber,
		/// <remarks/>
		TotalsGroupID,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TrackFormatEnumeration
	{
		/// <remarks/>
		ISO,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("JIS-I")]
		JISI,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("JIS-II")]
		JISII,
		/// <remarks/>
		AAMVA,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("CMC-7")]
		CMC7,
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("E-13B")]
		E13B,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2cefa351-47cf-4e65-a525-a9c58ec7c5eb")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransmitRequestType : ITransmitRequestType
	{
		internal byte[] messageField = new byte[0];
		internal bool waitResponseFlagField;
		internal string maximumTransmitTimeField;
		internal string destinationAddressField;
		internal bool xsdTransmitRequestTypeInitFlagField = false;
		public TransmitRequestType()
		{
			this.waitResponseFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] Message
		{
			get
			{
				if (((this.messageField == null)
								|| (this.messageField.Length == 0)))
				{
					return null;
				}
				return this.messageField;
			}
			set
			{
				this.xsdTransmitRequestTypeInitFlagField = true;
				this.messageField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool WaitResponseFlag
		{
			get
			{
				return this.waitResponseFlagField;
			}
			set
			{
				this.xsdTransmitRequestTypeInitFlagField = true;
				this.waitResponseFlagField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string MaximumTransmitTime
		{
			get
			{
				return this.maximumTransmitTimeField;
			}
			set
			{
				this.xsdTransmitRequestTypeInitFlagField = true;
				this.maximumTransmitTimeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DestinationAddress
		{
			get
			{
				return this.destinationAddressField;
			}
			set
			{
				this.xsdTransmitRequestTypeInitFlagField = true;
				this.destinationAddressField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransmitRequestTypeInitFlag
		{
			get
			{
				return this.xsdTransmitRequestTypeInitFlagField;
			}
			set
			{
				this.xsdTransmitRequestTypeInitFlagField = value;
			}
		}
		public int MessageSize()
		{
			if ((this.messageField == null))
			{
				return 0;
			}
			else
			{
				return this.messageField.Length;
			}
		}
		public byte MessageGetItem(int index)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.messageField.Length - 1)
									>= index))
					{
						return this.messageField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool MessageSetItem(int index, byte value)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.messageField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MessageAddItem(byte value)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.messageField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.messageField.Length); i = (i + 1))
					{
						array[i] = messageField[i];
					}
					array[i] = value;
					this.Message = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MessageRemoveItem(int index)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.messageField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.messageField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = messageField[i];
						}
						for (i = (i + 1); (i < this.messageField.Length); i = (i + 1))
						{
							array[i] = messageField[i];
						}
						this.Message = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("2daf7c16-4f0f-425c-8be5-75a3e6b73afd")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransmitResponseType : ITransmitResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal byte[] messageField = new byte[0];
		internal bool xsdTransmitResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdTransmitResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary")]
		public byte[] Message
		{
			get
			{
				if (((this.messageField == null)
								|| (this.messageField.Length == 0)))
				{
					return null;
				}
				return this.messageField;
			}
			set
			{
				this.xsdTransmitResponseTypeInitFlagField = true;
				this.messageField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransmitResponseTypeInitFlag
		{
			get
			{
				return this.xsdTransmitResponseTypeInitFlagField;
			}
			set
			{
				this.xsdTransmitResponseTypeInitFlagField = value;
			}
		}
		public int MessageSize()
		{
			if ((this.messageField == null))
			{
				return 0;
			}
			else
			{
				return this.messageField.Length;
			}
		}
		public byte MessageGetItem(int index)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return default(byte);
				}
				else
				{
					if (((this.messageField.Length - 1)
									>= index))
					{
						return this.messageField[index];
					}
					else
					{
						return default(byte);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(byte);
			}
		}
		public bool MessageSetItem(int index, byte value)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					this.messageField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MessageAddItem(byte value)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					byte[] array = new byte[(this.messageField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.messageField.Length); i = (i + 1))
					{
						array[i] = messageField[i];
					}
					array[i] = value;
					this.Message = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool MessageRemoveItem(int index)
		{
			try
			{
				if ((this.messageField == default(byte[])))
				{
					return false;
				}
				else
				{
					if ((this.messageField.Length <= index))
					{
						return false;
					}
					else
					{
						byte[] array = new byte[(this.messageField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = messageField[i];
						}
						for (i = (i + 1); (i < this.messageField.Length); i = (i + 1))
						{
							array[i] = messageField[i];
						}
						this.Message = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("6259d0d0-6009-4481-b673-9e58befbad16")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionReportType : ITransactionReportType
	{
		internal ResponseType responseField = new ResponseType();
		internal SaleDataType saleDataField = new SaleDataType();
		internal POIDataType pOIDataField = new POIDataType();
		internal PaymentResultType paymentResultField = new PaymentResultType();
		internal bool xsdTransactionReportTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdTransactionReportTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SaleDataType SaleData
		{
			get
			{
				return this.saleDataField;
			}
			set
			{
				this.xsdTransactionReportTypeInitFlagField = true;
				this.saleDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public POIDataType POIData
		{
			get
			{
				return this.pOIDataField;
			}
			set
			{
				this.xsdTransactionReportTypeInitFlagField = true;
				this.pOIDataField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public PaymentResultType PaymentResult
		{
			get
			{
				return this.paymentResultField;
			}
			set
			{
				this.xsdTransactionReportTypeInitFlagField = true;
				this.paymentResultField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionReportTypeInitFlag
		{
			get
			{
				return this.xsdTransactionReportTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionReportTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("adfb8acb-2b20-4121-adeb-6532687c8208")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionReportRequestType : ITransactionReportRequestType
	{
		internal SearchANDType[][] searchCriteriasField;
		internal CriteriaOrderType[] searchOutputOrderField = new CriteriaOrderType[0];
		internal bool descendingOrderField;
		internal string blockStartField;
		internal string blockStopField;
		internal bool xsdTransactionReportRequestTypeInitFlagField = false;
		public TransactionReportRequestType()
		{
			this.descendingOrderField = false;
			this.blockStartField = "0";
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SearchOR", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SearchAND", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false, NestingLevel = 1)]
		public SearchANDType[][] SearchCriterias
		{
			get
			{
				return this.searchCriteriasField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = true;
				this.searchCriteriasField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("CriteriaOrder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public CriteriaOrderType[] SearchOutputOrder
		{
			get
			{
				if (((this.searchOutputOrderField == null)
								|| (this.searchOutputOrderField.Length == 0)))
				{
					return null;
				}
				return this.searchOutputOrderField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = true;
				this.searchOutputOrderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool DescendingOrder
		{
			get
			{
				return this.descendingOrderField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = true;
				this.descendingOrderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		[System.ComponentModel.DefaultValueAttribute("0")]
		public string BlockStart
		{
			get
			{
				return this.blockStartField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = true;
				this.blockStartField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string BlockStop
		{
			get
			{
				return this.blockStopField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = true;
				this.blockStopField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionReportRequestTypeInitFlag
		{
			get
			{
				return this.xsdTransactionReportRequestTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionReportRequestTypeInitFlagField = value;
			}
		}
		public int SearchOutputOrderSize()
		{
			if ((this.searchOutputOrderField == null))
			{
				return 0;
			}
			else
			{
				return this.searchOutputOrderField.Length;
			}
		}
		public CriteriaOrderType SearchOutputOrderGetItem(int index)
		{
			try
			{
				if ((this.searchOutputOrderField == default(CriteriaOrderType[])))
				{
					return default(CriteriaOrderType);
				}
				else
				{
					if (((this.searchOutputOrderField.Length - 1)
									>= index))
					{
						return this.searchOutputOrderField[index];
					}
					else
					{
						return default(CriteriaOrderType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(CriteriaOrderType);
			}
		}
		public bool SearchOutputOrderSetItem(int index, CriteriaOrderType value)
		{
			try
			{
				if ((this.searchOutputOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					this.searchOutputOrderField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SearchOutputOrderAddItem(CriteriaOrderType value)
		{
			try
			{
				if ((this.searchOutputOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					CriteriaOrderType[] array = new CriteriaOrderType[(this.searchOutputOrderField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.searchOutputOrderField.Length); i = (i + 1))
					{
						array[i] = searchOutputOrderField[i];
					}
					array[i] = value;
					this.SearchOutputOrder = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool SearchOutputOrderRemoveItem(int index)
		{
			try
			{
				if ((this.searchOutputOrderField == default(CriteriaOrderType[])))
				{
					return false;
				}
				else
				{
					if ((this.searchOutputOrderField.Length <= index))
					{
						return false;
					}
					else
					{
						CriteriaOrderType[] array = new CriteriaOrderType[(this.searchOutputOrderField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = searchOutputOrderField[i];
						}
						for (i = (i + 1); (i < this.searchOutputOrderField.Length); i = (i + 1))
						{
							array[i] = searchOutputOrderField[i];
						}
						this.SearchOutputOrder = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("313d952f-9813-4ed7-8584-16674ab73d7f")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionReportResponseType : ITransactionReportResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal TransactionReportType[] transactionReportField = new TransactionReportType[0];
		internal string reportFullSizeField;
		internal string blockStartField;
		internal string blockStopField;
		internal bool xsdTransactionReportResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TransactionReport", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TransactionReportType[] TransactionReport
		{
			get
			{
				if (((this.transactionReportField == null)
								|| (this.transactionReportField.Length == 0)))
				{
					return null;
				}
				return this.transactionReportField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = true;
				this.transactionReportField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string ReportFullSize
		{
			get
			{
				return this.reportFullSizeField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = true;
				this.reportFullSizeField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string BlockStart
		{
			get
			{
				return this.blockStartField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = true;
				this.blockStartField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string BlockStop
		{
			get
			{
				return this.blockStopField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = true;
				this.blockStopField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionReportResponseTypeInitFlag
		{
			get
			{
				return this.xsdTransactionReportResponseTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionReportResponseTypeInitFlagField = value;
			}
		}
		public int TransactionReportSize()
		{
			if ((this.transactionReportField == null))
			{
				return 0;
			}
			else
			{
				return this.transactionReportField.Length;
			}
		}
		public TransactionReportType TransactionReportGetItem(int index)
		{
			try
			{
				if ((this.transactionReportField == default(TransactionReportType[])))
				{
					return default(TransactionReportType);
				}
				else
				{
					if (((this.transactionReportField.Length - 1)
									>= index))
					{
						return this.transactionReportField[index];
					}
					else
					{
						return default(TransactionReportType);
					}
				}
			}
			catch (System.Exception ex)
			{
				return default(TransactionReportType);
			}
		}
		public bool TransactionReportSetItem(int index, TransactionReportType value)
		{
			try
			{
				if ((this.transactionReportField == default(TransactionReportType[])))
				{
					return false;
				}
				else
				{
					this.transactionReportField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionReportAddItem(TransactionReportType value)
		{
			try
			{
				if ((this.transactionReportField == default(TransactionReportType[])))
				{
					return false;
				}
				else
				{
					TransactionReportType[] array = new TransactionReportType[(this.transactionReportField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.transactionReportField.Length); i = (i + 1))
					{
						array[i] = transactionReportField[i];
					}
					array[i] = value;
					this.TransactionReport = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool TransactionReportRemoveItem(int index)
		{
			try
			{
				if ((this.transactionReportField == default(TransactionReportType[])))
				{
					return false;
				}
				else
				{
					if ((this.transactionReportField.Length <= index))
					{
						return false;
					}
					else
					{
						TransactionReportType[] array = new TransactionReportType[(this.transactionReportField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = transactionReportField[i];
						}
						for (i = (i + 1); (i < this.transactionReportField.Length); i = (i + 1))
						{
							array[i] = transactionReportField[i];
						}
						this.TransactionReport = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("e01a332e-63aa-4c6b-a12c-1d823fa1da60")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionStatusRequestType : ITransactionStatusRequestType
	{
		internal MessageReferenceType messageReferenceField = new MessageReferenceType();
		internal string[] documentQualifierField = new string[0];
		internal bool receiptReprintFlagField;
		internal bool xsdTransactionStatusRequestTypeInitFlagField = false;
		public TransactionStatusRequestType()
		{
			this.receiptReprintFlagField = false;
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageReferenceType MessageReference
		{
			get
			{
				return this.messageReferenceField;
			}
			set
			{
				this.xsdTransactionStatusRequestTypeInitFlagField = true;
				this.messageReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DocumentQualifier", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] DocumentQualifier
		{
			get
			{
				if (((this.documentQualifierField == null)
								|| (this.documentQualifierField.Length == 0)))
				{
					return null;
				}
				return this.documentQualifierField;
			}
			set
			{
				this.xsdTransactionStatusRequestTypeInitFlagField = true;
				this.documentQualifierField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool ReceiptReprintFlag
		{
			get
			{
				return this.receiptReprintFlagField;
			}
			set
			{
				this.xsdTransactionStatusRequestTypeInitFlagField = true;
				this.receiptReprintFlagField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionStatusRequestTypeInitFlag
		{
			get
			{
				return this.xsdTransactionStatusRequestTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionStatusRequestTypeInitFlagField = value;
			}
		}
		public int DocumentQualifierSize()
		{
			if ((this.documentQualifierField == null))
			{
				return 0;
			}
			else
			{
				return this.documentQualifierField.Length;
			}
		}
		public string DocumentQualifierGetItem(int index)
		{
			try
			{
				if ((this.documentQualifierField == default(string[])))
				{
					return default(string);
				}
				else
				{
					if (((this.documentQualifierField.Length - 1)
									>= index))
					{
						return this.documentQualifierField[index];
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
		}
		public bool DocumentQualifierSetItem(int index, string value)
		{
			try
			{
				if ((this.documentQualifierField == default(string[])))
				{
					return false;
				}
				else
				{
					this.documentQualifierField[index] = value;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DocumentQualifierAddItem(string value)
		{
			try
			{
				if ((this.documentQualifierField == default(string[])))
				{
					return false;
				}
				else
				{
					string[] array = new string[(this.documentQualifierField.Length + 1)];
					int i = 0;
					for (i = 0; (i < this.documentQualifierField.Length); i = (i + 1))
					{
						array[i] = documentQualifierField[i];
					}
					array[i] = value;
					this.DocumentQualifier = array;
					return true;
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
		public bool DocumentQualifierRemoveItem(int index)
		{
			try
			{
				if ((this.documentQualifierField == default(string[])))
				{
					return false;
				}
				else
				{
					if ((this.documentQualifierField.Length <= index))
					{
						return false;
					}
					else
					{
						string[] array = new string[(this.documentQualifierField.Length - 1)];
						int i = 0;
						for (i = 0; (i < index); i = (i + 1))
						{
							array[i] = documentQualifierField[i];
						}
						for (i = (i + 1); (i < this.documentQualifierField.Length); i = (i + 1))
						{
							array[i] = documentQualifierField[i];
						}
						this.DocumentQualifier = array;
						return true;
					}
				}
			}
			catch (System.Exception ex)
			{
				return false;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	[System.Runtime.InteropServices.GuidAttribute("dc5cd12b-8500-4ae0-9f06-46a1b2babdee")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class TransactionStatusResponseType : ITransactionStatusResponseType
	{
		internal ResponseType responseField = new ResponseType();
		internal MessageReferenceType messageReferenceField = new MessageReferenceType();
		internal RepeatedMessageResponseType repeatedMessageResponseField = new RepeatedMessageResponseType();
		internal bool xsdTransactionStatusResponseTypeInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ResponseType Response
		{
			get
			{
				return this.responseField;
			}
			set
			{
				this.xsdTransactionStatusResponseTypeInitFlagField = true;
				this.responseField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageReferenceType MessageReference
		{
			get
			{
				return this.messageReferenceField;
			}
			set
			{
				this.xsdTransactionStatusResponseTypeInitFlagField = true;
				this.messageReferenceField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public RepeatedMessageResponseType RepeatedMessageResponse
		{
			get
			{
				return this.repeatedMessageResponseField;
			}
			set
			{
				this.xsdTransactionStatusResponseTypeInitFlagField = true;
				this.repeatedMessageResponseField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdTransactionStatusResponseTypeInitFlag
		{
			get
			{
				return this.xsdTransactionStatusResponseTypeInitFlagField;
			}
			set
			{
				this.xsdTransactionStatusResponseTypeInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TransactionActionEnumeration
	{
		/// <remarks/>
		StartTransaction,
		/// <remarks/>
		AbortTransaction,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TransactionTypeEnumeration
	{
		/// <remarks/>
		Debit,
		/// <remarks/>
		Credit,
		/// <remarks/>
		ReverseDebit,
		/// <remarks/>
		ReverseCredit,
		/// <remarks/>
		OneTimeReservation,
		/// <remarks/>
		CompletedDeffered,
		/// <remarks/>
		FirstReservation,
		/// <remarks/>
		UpdateReservation,
		/// <remarks/>
		CompletedReservation,
		/// <remarks/>
		CashAdvance,
		/// <remarks/>
		IssuerInstalment,
		/// <remarks/>
		Declined,
		/// <remarks/>
		Failed,
		/// <remarks/>
		Award,
		/// <remarks/>
		ReverseAward,
		/// <remarks/>
		Redemption,
		/// <remarks/>
		ReverseRedemption,
		/// <remarks/>
		Rebate,
		/// <remarks/>
		ReverseRebate,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum UnitOfMeasureEnumeration
	{
		/// <remarks/>
		Case,
		/// <remarks/>
		Foot,
		/// <remarks/>
		UKGallon,
		/// <remarks/>
		USGallon,
		/// <remarks/>
		Gram,
		/// <remarks/>
		Inch,
		/// <remarks/>
		Kilogram,
		/// <remarks/>
		Pound,
		/// <remarks/>
		Meter,
		/// <remarks/>
		Centimetre,
		/// <remarks/>
		Litre,
		/// <remarks/>
		Centilitre,
		/// <remarks/>
		Ounce,
		/// <remarks/>
		Quart,
		/// <remarks/>
		Pint,
		/// <remarks/>
		Mile,
		/// <remarks/>
		Kilometre,
		/// <remarks/>
		Yard,
		/// <remarks/>
		Other,
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.GuidAttribute("ce61040c-806b-4a3d-be70-63c47f0eb1a2")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIRequest : ISaleToPOIRequest
	{
		internal MessageHeaderType messageHeaderField = new MessageHeaderType();
		internal object itemField;
		internal ContentInformationType securityTrailerField = new ContentInformationType();
		internal bool xsdSaleToPOIRequestInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageHeaderType MessageHeader
		{
			get
			{
				return this.messageHeaderField;
			}
			set
			{
				this.xsdSaleToPOIRequestInitFlagField = true;
				this.messageHeaderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AbortRequest", typeof(AbortRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("AdminRequest", typeof(AdminRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("BalanceInquiryRequest", typeof(BalanceInquiryRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("BatchRequest", typeof(BatchRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardAcquisitionRequest", typeof(CardAcquisitionRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderAPDURequest", typeof(CardReaderAPDURequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderInitRequest", typeof(CardReaderInitRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderPowerOffRequest", typeof(CardReaderPowerOffRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("DiagnosisRequest", typeof(DiagnosisRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("DisplayRequest", typeof(DisplayRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("EnableServiceRequest", typeof(EnableServiceRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("EventNotification", typeof(EventNotificationType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("GetTotalsRequest", typeof(GetTotalsRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InputRequest", typeof(InputRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InputUpdate", typeof(InputUpdateType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LoginRequest", typeof(LoginRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LogoutRequest", typeof(LogoutRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyRequest", typeof(LoyaltyRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PINRequest", typeof(PINRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PaymentRequest", typeof(PaymentRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PrintRequest", typeof(PrintRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReconciliationRequest", typeof(ReconciliationRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReversalRequest", typeof(ReversalRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SoundRequest", typeof(SoundRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("StoredValueRequest", typeof(StoredValueRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransactionReportRequest", typeof(TransactionReportRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransactionStatusRequest", typeof(TransactionStatusRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransmitRequest", typeof(TransmitRequestType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.xsdSaleToPOIRequestInitFlagField = true;
				this.itemField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType SecurityTrailer
		{
			get
			{
				return this.securityTrailerField;
			}
			set
			{
				this.xsdSaleToPOIRequestInitFlagField = true;
				this.securityTrailerField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleToPOIRequestInitFlag
		{
			get
			{
				return this.xsdSaleToPOIRequestInitFlagField;
			}
			set
			{
				this.xsdSaleToPOIRequestInitFlagField = value;
			}
		}
	}
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.11.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Runtime.InteropServices.GuidAttribute("a1574231-2e43-42bc-b65d-c9cda4293d91")]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class SaleToPOIResponse : ISaleToPOIResponse
	{
		internal MessageHeaderType messageHeaderField = new MessageHeaderType();
		internal object itemField;
		internal ContentInformationType securityTrailerField = new ContentInformationType();
		internal bool xsdSaleToPOIResponseInitFlagField = false;
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MessageHeaderType MessageHeader
		{
			get
			{
				return this.messageHeaderField;
			}
			set
			{
				this.xsdSaleToPOIResponseInitFlagField = true;
				this.messageHeaderField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdminResponse", typeof(AdminResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("BalanceInquiryResponse", typeof(BalanceInquiryResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("BatchResponse", typeof(BatchResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardAcquisitionResponse", typeof(CardAcquisitionResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderAPDUResponse", typeof(CardReaderAPDUResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderInitResponse", typeof(CardReaderInitResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("CardReaderPowerOffResponse", typeof(CardReaderPowerOffResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("DiagnosisResponse", typeof(DiagnosisResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("DisplayResponse", typeof(DisplayResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("EnableServiceResponse", typeof(EnableServiceResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("GetTotalsResponse", typeof(GetTotalsResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("InputResponse", typeof(InputResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LoginResponse", typeof(LoginResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LogoutResponse", typeof(LogoutResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("LoyaltyResponse", typeof(LoyaltyResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PINResponse", typeof(PINResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PaymentResponse", typeof(PaymentResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("PrintResponse", typeof(PrintResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReconciliationResponse", typeof(ReconciliationResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("ReversalResponse", typeof(ReversalResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("SoundResponse", typeof(SoundResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("StoredValueResponse", typeof(StoredValueResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransactionReportResponse", typeof(TransactionReportResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransactionStatusResponse", typeof(TransactionStatusResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TransmitResponse", typeof(TransmitResponseType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.xsdSaleToPOIResponseInitFlagField = true;
				this.itemField = value;
			}
		}
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ContentInformationType SecurityTrailer
		{
			get
			{
				return this.securityTrailerField;
			}
			set
			{
				this.xsdSaleToPOIResponseInitFlagField = true;
				this.securityTrailerField = value;
			}
		}
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool xsdSaleToPOIResponseInitFlag
		{
			get
			{
				return this.xsdSaleToPOIResponseInitFlagField;
			}
			set
			{
				this.xsdSaleToPOIResponseInitFlagField = value;
			}
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9c5d534c-ba59-4937-b7dc-fe228cd0ba42")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAuthenticatedDataType
	{
		/// <remarks/>
		[DispId(2)]
		object[] Items
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		AlgorithmIdentifier MACAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		EncapsulatedContentType EncapsulatedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string Version
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		byte[] MAC
		{
			get;
			set;
		}
		[DispId(12)]
		bool xsdAuthenticatedDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(13)]
		int ItemsSize();
		[DispId(14)]
		object ItemsGetItem(int index);
		[DispId(15)]
		bool ItemsSetItem(int index, object value);
		[DispId(16)]
		bool ItemsAddItem(object value);
		[DispId(17)]
		bool ItemsRemoveItem(int index);
		[DispId(18)]
		int MACSize();
		[DispId(19)]
		byte MACGetItem(int index);
		[DispId(20)]
		bool MACSetItem(int index, byte value);
		[DispId(21)]
		bool MACAddItem(byte value);
		[DispId(22)]
		bool MACRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5b5dc2ef-c25f-4d09-91f4-2a45427aa01a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IKEKType
	{
		/// <remarks/>
		[DispId(2)]
		KEKIdentifierType KEKIdentifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Version
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		byte[] EncryptedKey
		{
			get;
			set;
		}
		[DispId(10)]
		bool xsdKEKTypeInitFlag
		{
			get;
			set;
		}
		[DispId(11)]
		int EncryptedKeySize();
		[DispId(12)]
		byte EncryptedKeyGetItem(int index);
		[DispId(13)]
		bool EncryptedKeySetItem(int index, byte value);
		[DispId(14)]
		bool EncryptedKeyAddItem(byte value);
		[DispId(15)]
		bool EncryptedKeyRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("cae35a01-6724-49bf-a8e5-5fb777269ea0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IKEKIdentifierType
	{
		/// <remarks/>
		[DispId(1)]
		string KeyIdentifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string KeyVersion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] DerivationIdentifier
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdKEKIdentifierTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int DerivationIdentifierSize();
		[DispId(9)]
		byte DerivationIdentifierGetItem(int index);
		[DispId(10)]
		bool DerivationIdentifierSetItem(int index, byte value);
		[DispId(11)]
		bool DerivationIdentifierAddItem(byte value);
		[DispId(12)]
		bool DerivationIdentifierRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("7375da09-3dc1-429c-9a0f-55acd9f5be30")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDisplayResponseType
	{
		/// <remarks/>
		[DispId(1)]
		OutputResultType[] OutputResult
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdDisplayResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int OutputResultSize();
		[DispId(5)]
		OutputResultType OutputResultGetItem(int index);
		[DispId(6)]
		bool OutputResultSetItem(int index, OutputResultType value);
		[DispId(7)]
		bool OutputResultAddItem(OutputResultType value);
		[DispId(8)]
		bool OutputResultRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("cd212cb7-83c0-41ae-8685-0665e4bdd15d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IOutputResultType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Device
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string InfoQualify
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdOutputResultTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("57f6189b-ae81-44b6-803b-8a5cb1d227ba")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IResponseType
	{
		/// <remarks/>
		[DispId(1)]
		string AdditionalResponse
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Result
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ErrorCondition
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d11b36ce-edaa-4b0c-90e6-e6b63d9f5e9c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDisplayRequestType
	{
		/// <remarks/>
		[DispId(1)]
		DisplayOutputType[] DisplayOutput
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdDisplayRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int DisplayOutputSize();
		[DispId(5)]
		DisplayOutputType DisplayOutputGetItem(int index);
		[DispId(6)]
		bool DisplayOutputSetItem(int index, DisplayOutputType value);
		[DispId(7)]
		bool DisplayOutputAddItem(DisplayOutputType value);
		[DispId(8)]
		bool DisplayOutputRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("17c615e6-28e2-4381-8499-1f20b4a7d0e1")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDisplayOutputType
	{
		/// <remarks/>
		[DispId(2)]
		OutputContentType OutputContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		MenuEntryType[] MenuEntry
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		byte[] OutputSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		bool ResponseRequiredFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string MinimumDisplayTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string Device
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string InfoQualify
		{
			get;
			set;
		}
		[DispId(16)]
		bool xsdDisplayOutputTypeInitFlag
		{
			get;
			set;
		}
		[DispId(17)]
		int MenuEntrySize();
		[DispId(18)]
		MenuEntryType MenuEntryGetItem(int index);
		[DispId(19)]
		bool MenuEntrySetItem(int index, MenuEntryType value);
		[DispId(20)]
		bool MenuEntryAddItem(MenuEntryType value);
		[DispId(21)]
		bool MenuEntryRemoveItem(int index);
		[DispId(22)]
		int OutputSignatureSize();
		[DispId(23)]
		byte OutputSignatureGetItem(int index);
		[DispId(24)]
		bool OutputSignatureSetItem(int index, byte value);
		[DispId(25)]
		bool OutputSignatureAddItem(byte value);
		[DispId(26)]
		bool OutputSignatureRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("787a3f7e-8d2a-43ab-8711-50326f686f36")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IOutputContentType
	{
		/// <remarks/>
		[DispId(1)]
		PredefinedContentType PredefinedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OutputTextType[] OutputText
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] OutputXHTML
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		OutputBarcodeType OutputBarcode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string OutputFormat
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdOutputContentTypeInitFlag
		{
			get;
			set;
		}
		[DispId(12)]
		int OutputTextSize();
		[DispId(13)]
		OutputTextType OutputTextGetItem(int index);
		[DispId(14)]
		bool OutputTextSetItem(int index, OutputTextType value);
		[DispId(15)]
		bool OutputTextAddItem(OutputTextType value);
		[DispId(16)]
		bool OutputTextRemoveItem(int index);
		[DispId(17)]
		int OutputXHTMLSize();
		[DispId(18)]
		byte OutputXHTMLGetItem(int index);
		[DispId(19)]
		bool OutputXHTMLSetItem(int index, byte value);
		[DispId(20)]
		bool OutputXHTMLAddItem(byte value);
		[DispId(21)]
		bool OutputXHTMLRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("514e7f70-aa36-436c-8597-27875c978bbf")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPredefinedContentType
	{
		/// <remarks/>
		[DispId(1)]
		string ReferenceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Language
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdPredefinedContentTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("13d72f10-8aeb-445f-9449-be124b9abbc6")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IOutputTextType
	{
		/// <remarks/>
		[DispId(2)]
		string CharacterSet
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string Font
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string StartRow
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string StartColumn
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string Color
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string CharacterWidth
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string CharacterHeight
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		string CharacterStyle
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string Alignment
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		bool EndOfLineFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		string Value
		{
			get;
			set;
		}
		[DispId(24)]
		bool xsdOutputTextTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("08707b3b-fddf-4a15-b2e9-79ea871df271")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IOutputBarcodeType
	{
		/// <remarks/>
		[DispId(2)]
		string BarcodeValue
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		byte[] QRCodeBinaryValue
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string BarcodeType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string QRCodeVersion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		QRCodeEncodingModeEnumeration QRCodeEncodingMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool QRCodeEncodingModeSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		QRCodeErrorCorrectionEnumeration QRCodeErrorCorrection
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		bool QRCodeErrorCorrectionSpecified
		{
			get;
			set;
		}
		[DispId(18)]
		bool xsdOutputBarcodeTypeInitFlag
		{
			get;
			set;
		}
		[DispId(19)]
		int QRCodeBinaryValueSize();
		[DispId(20)]
		byte QRCodeBinaryValueGetItem(int index);
		[DispId(21)]
		bool QRCodeBinaryValueSetItem(int index, byte value);
		[DispId(22)]
		bool QRCodeBinaryValueAddItem(byte value);
		[DispId(23)]
		bool QRCodeBinaryValueRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("0d5860a4-d9c7-4e58-aa55-7a4a6d4af309")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMenuEntryType
	{
		/// <remarks/>
		[DispId(2)]
		PredefinedContentType PredefinedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		OutputTextType[] OutputText
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		byte[] OutputXHTML
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string MenuEntryTag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string OutputFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool DefaultSelectedFlag
		{
			get;
			set;
		}
		[DispId(14)]
		bool xsdMenuEntryTypeInitFlag
		{
			get;
			set;
		}
		[DispId(15)]
		int OutputTextSize();
		[DispId(16)]
		OutputTextType OutputTextGetItem(int index);
		[DispId(17)]
		bool OutputTextSetItem(int index, OutputTextType value);
		[DispId(18)]
		bool OutputTextAddItem(OutputTextType value);
		[DispId(19)]
		bool OutputTextRemoveItem(int index);
		[DispId(20)]
		int OutputXHTMLSize();
		[DispId(21)]
		byte OutputXHTMLGetItem(int index);
		[DispId(22)]
		bool OutputXHTMLSetItem(int index, byte value);
		[DispId(23)]
		bool OutputXHTMLAddItem(byte value);
		[DispId(24)]
		bool OutputXHTMLRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("bd554f90-6863-4e13-a066-11f8bdcb24cb")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAlgorithmIdentifier
	{
		/// <remarks/>
		[DispId(1)]
		ParameterType Parameter
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Algorithm
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdAlgorithmIdentifierInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("4d134f6d-548e-4ebf-9a37-11cd2f681a0e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IParameterType
	{
		/// <remarks/>
		[DispId(1)]
		byte[] InitialisationVector
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdParameterTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int InitialisationVectorSize();
		[DispId(5)]
		byte InitialisationVectorGetItem(int index);
		[DispId(6)]
		bool InitialisationVectorSetItem(int index, byte value);
		[DispId(7)]
		bool InitialisationVectorAddItem(byte value);
		[DispId(8)]
		bool InitialisationVectorRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("1f4638bf-a6f0-424c-bd40-46d7fb84511f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IKeyTransportType
	{
		/// <remarks/>
		[DispId(2)]
		RecipientIdentifierType RecipientIdentifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Version
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		byte[] EncryptedKey
		{
			get;
			set;
		}
		[DispId(10)]
		bool xsdKeyTransportTypeInitFlag
		{
			get;
			set;
		}
		[DispId(11)]
		int EncryptedKeySize();
		[DispId(12)]
		byte EncryptedKeyGetItem(int index);
		[DispId(13)]
		bool EncryptedKeySetItem(int index, byte value);
		[DispId(14)]
		bool EncryptedKeyAddItem(byte value);
		[DispId(15)]
		bool EncryptedKeyRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("441bdd7c-0b67-4dae-849c-bac60e86f734")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IRecipientIdentifierType
	{
		/// <remarks/>
		[DispId(1)]
		IssuerAndSerialNumberType IssuerAndSerialNumber
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdRecipientIdentifierTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("6e2f02f3-e864-47e1-b718-c4193dc3a641")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IIssuerAndSerialNumberType
	{
		/// <remarks/>
		[DispId(1)]
		RelativeDistinguishedNameType[] Issuer
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string SerialNumber
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdIssuerAndSerialNumberTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int IssuerSize();
		[DispId(7)]
		RelativeDistinguishedNameType IssuerGetItem(int index);
		[DispId(8)]
		bool IssuerSetItem(int index, RelativeDistinguishedNameType value);
		[DispId(9)]
		bool IssuerAddItem(RelativeDistinguishedNameType value);
		[DispId(10)]
		bool IssuerRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("cc92d693-bccc-433a-ac3c-b82ac1562939")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IRelativeDistinguishedNameType
	{
		/// <remarks/>
		[DispId(1)]
		string AttributeType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string AttributeValue
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdRelativeDistinguishedNameTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d0ee6118-5047-45b4-ad4c-b1e24f71ad36")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEncapsulatedContentType
	{
		/// <remarks/>
		[DispId(1)]
		byte[] Content
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ContentType
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdEncapsulatedContentTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int ContentSize();
		[DispId(7)]
		byte ContentGetItem(int index);
		[DispId(8)]
		bool ContentSetItem(int index, byte value);
		[DispId(9)]
		bool ContentAddItem(byte value);
		[DispId(10)]
		bool ContentRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("0773115e-45f1-4766-ac20-81ae7f57573f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDigestedDataType
	{
		/// <remarks/>
		[DispId(1)]
		AlgorithmIdentifier DigestAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		EncapsulatedContentType EncapsulatedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] Digest
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string Version
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdDigestedDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int DigestSize();
		[DispId(11)]
		byte DigestGetItem(int index);
		[DispId(12)]
		bool DigestSetItem(int index, byte value);
		[DispId(13)]
		bool DigestAddItem(byte value);
		[DispId(14)]
		bool DigestRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("71ec9701-18f1-44b3-8e29-aa98b1377e04")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEncryptedContentType
	{
		/// <remarks/>
		[DispId(1)]
		AlgorithmIdentifier ContentEncryptionAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] EncryptedData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ContentType
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdEncryptedContentTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int EncryptedDataSize();
		[DispId(9)]
		byte EncryptedDataGetItem(int index);
		[DispId(10)]
		bool EncryptedDataSetItem(int index, byte value);
		[DispId(11)]
		bool EncryptedDataAddItem(byte value);
		[DispId(12)]
		bool EncryptedDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("b9e310ac-bc61-4bf7-b62a-52a9ac8b6a23")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEnvelopedDataType
	{
		/// <remarks/>
		[DispId(2)]
		object[] Items
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		EncryptedContentType EncryptedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Version
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdEnvelopedDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(9)]
		int ItemsSize();
		[DispId(10)]
		object ItemsGetItem(int index);
		[DispId(11)]
		bool ItemsSetItem(int index, object value);
		[DispId(12)]
		bool ItemsAddItem(object value);
		[DispId(13)]
		bool ItemsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("7f29cd40-93dd-4704-9a86-9a82749d92ed")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IIssuerType
	{
		/// <remarks/>
		[DispId(1)]
		RelativeDistinguishedNameType[] RelativeDistinguishedName
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdIssuerTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int RelativeDistinguishedNameSize();
		[DispId(5)]
		RelativeDistinguishedNameType RelativeDistinguishedNameGetItem(int index);
		[DispId(6)]
		bool RelativeDistinguishedNameSetItem(int index, RelativeDistinguishedNameType value);
		[DispId(7)]
		bool RelativeDistinguishedNameAddItem(RelativeDistinguishedNameType value);
		[DispId(8)]
		bool RelativeDistinguishedNameRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("4b7b8132-a57f-44f7-aca6-9589c69976a1")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface INamedKeyEncryptedDataType
	{
		/// <remarks/>
		[DispId(2)]
		string KeyName
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		EncryptedContentType EncryptedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Version
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdNamedKeyEncryptedDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9d6fef8b-69fc-47f8-9d80-f61f5afbcb0f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISignedDataType
	{
		/// <remarks/>
		[DispId(2)]
		AlgorithmIdentifier[] DigestAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		EncapsulatedContentType EncapsulatedContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		byte[][] Certificate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		SignerType[] Signer
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string Version
		{
			get;
			set;
		}
		[DispId(12)]
		bool xsdSignedDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(13)]
		int DigestAlgorithmSize();
		[DispId(14)]
		AlgorithmIdentifier DigestAlgorithmGetItem(int index);
		[DispId(15)]
		bool DigestAlgorithmSetItem(int index, AlgorithmIdentifier value);
		[DispId(16)]
		bool DigestAlgorithmAddItem(AlgorithmIdentifier value);
		[DispId(17)]
		bool DigestAlgorithmRemoveItem(int index);
		[DispId(18)]
		int SignerSize();
		[DispId(19)]
		SignerType SignerGetItem(int index);
		[DispId(20)]
		bool SignerSetItem(int index, SignerType value);
		[DispId(21)]
		bool SignerAddItem(SignerType value);
		[DispId(22)]
		bool SignerRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("579a2158-d453-4586-a331-8df0450695a3")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISignerType
	{
		/// <remarks/>
		[DispId(2)]
		SignerIdentifierType SignerIdentifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		AlgorithmIdentifier DigestAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		AlgorithmIdentifier SignatureAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		byte[] Signature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string Version
		{
			get;
			set;
		}
		[DispId(12)]
		bool xsdSignerTypeInitFlag
		{
			get;
			set;
		}
		[DispId(13)]
		int SignatureSize();
		[DispId(14)]
		byte SignatureGetItem(int index);
		[DispId(15)]
		bool SignatureSetItem(int index, byte value);
		[DispId(16)]
		bool SignatureAddItem(byte value);
		[DispId(17)]
		bool SignatureRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("05e85c3a-a29d-45f0-a69d-0d5055f06453")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISignerIdentifierType
	{
		/// <remarks/>
		[DispId(1)]
		IssuerAndSerialNumberType IssuerAndSerialNumber
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSignerIdentifierTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("91f20984-8f4d-47a7-a4bb-447e4217fe6b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IContentInformationType
	{
		/// <remarks/>
		[DispId(1)]
		object Item
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ContentType
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdContentInformationTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("6975de10-21d0-459f-9133-57a07760c8cf")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAbortRequestType
	{
		/// <remarks/>
		[DispId(1)]
		MessageReferenceType MessageReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string AbortReason
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdAbortRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("6721fb08-8b6a-4110-80d1-60b8eb376464")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageReferenceType
	{
		/// <remarks/>
		[DispId(1)]
		string MessageCategory
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ServiceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string DeviceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string SaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string POIID
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdMessageReferenceTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("145f1411-23bc-4bbf-b463-6ddf26acec22")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAdminRequestType
	{
		/// <remarks/>
		[DispId(1)]
		string ServiceIdentification
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdAdminRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9781818e-19a2-4a1c-a356-07a812152f37")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAdminResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdAdminResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("09f16d35-1722-45b8-9921-6a9be9e6f08d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAllowedProductType
	{
		/// <remarks/>
		[DispId(1)]
		string ProductLabel
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string AdditionalProductInfo
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string EanUpc
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdAllowedProductTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("5801d821-6566-47a3-aefe-49f745ca1293")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAmountsReqType
	{
		/// <remarks/>
		[DispId(1)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double RequestedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool RequestedAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		double CashBackAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		bool CashBackAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		double TipAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool TipAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		double PaidAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		bool PaidAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		double MinimumAmountToDeliver
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		bool MinimumAmountToDeliverSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		double MaximumCashBackAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(25)]
		bool MaximumCashBackAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(27)]
		double MinimumSplitAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(29)]
		bool MinimumSplitAmountSpecified
		{
			get;
			set;
		}
		[DispId(31)]
		bool xsdAmountsReqTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("8d66508c-54a0-46fa-8615-fe850b544de5")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAmountsRespType
	{
		/// <remarks/>
		[DispId(1)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double AuthorizedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		double TotalRebatesAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		bool TotalRebatesAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		double TotalFeesAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool TotalFeesAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		double CashBackAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		bool CashBackAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		double TipAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		bool TipAmountSpecified
		{
			get;
			set;
		}
		[DispId(21)]
		bool xsdAmountsRespTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("74773ea2-c93f-4738-87a5-d4ff4baa88d8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAreaSizeType
	{
		/// <remarks/>
		[DispId(1)]
		string X
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Y
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdAreaSizeTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("54b3f210-441d-4bab-919b-4e709e9c1419")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IBalanceInquiryRequestType
	{
		/// <remarks/>
		[DispId(1)]
		PaymentAccountReqType PaymentAccountReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		LoyaltyAccountReqType LoyaltyAccountReq
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdBalanceInquiryRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("62652354-9913-4fa2-985f-8315683c7ef7")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentAccountReqType
	{
		/// <remarks/>
		[DispId(2)]
		TransactionIdentificationType CardAcquisitionReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		PaymentInstrumentDataType PaymentInstrumentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string AccountType
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdPaymentAccountReqTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("cf161552-ca4c-4ab2-a103-43907bbd9b4b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionIdentificationType
	{
		/// <remarks/>
		[DispId(1)]
		string TransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string TimeStamp
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdTransactionIdentificationTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("c0952eeb-2c90-40d5-94fe-a4aead449252")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentInstrumentDataType
	{
		/// <remarks/>
		[DispId(1)]
		CardDataType CardData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		CheckDataType CheckData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		MobileDataType MobileData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string PaymentInstrumentType
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdPaymentInstrumentDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("848b0b86-9a04-4cd2-9ed2-fea240c5dda9")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardDataType
	{
		/// <remarks/>
		[DispId(1)]
		ContentInformationType ProtectedCardData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SensitiveCardDataType SensitiveCardData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string[] AllowedProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		AllowedProductType[] AllowedProduct
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		PaymentTokenType PaymentToken
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		CustomerOrderType[] CustomerOrder
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string PaymentBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string MaskedPAN
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		string PaymentAccountRef
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		string[] EntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		string CardCountryCode
		{
			get;
			set;
		}
		[DispId(23)]
		bool xsdCardDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(24)]
		int AllowedProductCodeSize();
		[DispId(25)]
		string AllowedProductCodeGetItem(int index);
		[DispId(26)]
		bool AllowedProductCodeSetItem(int index, string value);
		[DispId(27)]
		bool AllowedProductCodeAddItem(string value);
		[DispId(28)]
		bool AllowedProductCodeRemoveItem(int index);
		[DispId(29)]
		int AllowedProductSize();
		[DispId(30)]
		AllowedProductType AllowedProductGetItem(int index);
		[DispId(31)]
		bool AllowedProductSetItem(int index, AllowedProductType value);
		[DispId(32)]
		bool AllowedProductAddItem(AllowedProductType value);
		[DispId(33)]
		bool AllowedProductRemoveItem(int index);
		[DispId(34)]
		int CustomerOrderSize();
		[DispId(35)]
		CustomerOrderType CustomerOrderGetItem(int index);
		[DispId(36)]
		bool CustomerOrderSetItem(int index, CustomerOrderType value);
		[DispId(37)]
		bool CustomerOrderAddItem(CustomerOrderType value);
		[DispId(38)]
		bool CustomerOrderRemoveItem(int index);
		[DispId(39)]
		int EntryModeSize();
		[DispId(40)]
		string EntryModeGetItem(int index);
		[DispId(41)]
		bool EntryModeSetItem(int index, string value);
		[DispId(42)]
		bool EntryModeAddItem(string value);
		[DispId(43)]
		bool EntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("ab4c8349-d8f7-4d35-beb7-5c6533948bd3")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISensitiveCardDataType
	{
		/// <remarks/>
		[DispId(1)]
		TrackDataType[] TrackData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string PAN
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string CardSeqNumb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string ExpiryDate
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdSensitiveCardDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int TrackDataSize();
		[DispId(11)]
		TrackDataType TrackDataGetItem(int index);
		[DispId(12)]
		bool TrackDataSetItem(int index, TrackDataType value);
		[DispId(13)]
		bool TrackDataAddItem(TrackDataType value);
		[DispId(14)]
		bool TrackDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("37839af0-ed74-4985-ad26-c2f3bf7a1751")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITrackDataType
	{
		/// <remarks/>
		[DispId(2)]
		string TrackNumb
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string TrackFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Value
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdTrackDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("bf9db338-28a7-4de3-9fc7-c8d6aff1880c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentTokenType
	{
		/// <remarks/>
		[DispId(1)]
		string TokenRequestedType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string TokenValue
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ExpiryDateTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		bool ExpiryDateTimeSpecified
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdPaymentTokenTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("0f763faf-e87a-4e07-a1ac-663db5ea1f56")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICustomerOrderType
	{
		/// <remarks/>
		[DispId(2)]
		string AdditionalInformation
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string CustomerOrderID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool OpenOrderState
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string StartDate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string EndDate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool EndDateSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		double ForecastedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		double CurrentAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		bool CurrentAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		string AccessedBy
		{
			get;
			set;
		}
		[DispId(24)]
		bool xsdCustomerOrderTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("26c12999-a54a-446c-86a0-19c897eaea6c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICheckDataType
	{
		/// <remarks/>
		[DispId(2)]
		string BankID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string AccountNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string CheckNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		TrackDataType TrackData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string CheckCardNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string TypeCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string Country
		{
			get;
			set;
		}
		[DispId(16)]
		bool xsdCheckDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("ced937c3-322b-4774-8c85-4bc72fb0d07c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMobileDataType
	{
		/// <remarks/>
		[DispId(1)]
		string MobileCountryCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		GeolocationType Geolocation
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		ContentInformationType ProtectedMobileData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		SensitiveMobileDataType SensitiveMobileData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string MobileNetworkCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string MaskedMSISDN
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdMobileDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("574c22c3-fb1c-4110-83e0-9809bd37b070")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IGeolocationType
	{
		/// <remarks/>
		[DispId(1)]
		GeographicCoordinatesType GeographicCoordinates
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		UTMCoordinatesType UTMCoordinates
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdGeolocationTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("8df0021f-60dd-4db8-96ec-0e2c6f1eaa94")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IGeographicCoordinatesType
	{
		/// <remarks/>
		[DispId(1)]
		string Latitude
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Longitude
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdGeographicCoordinatesTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("2ce4a2f9-bca5-4939-ba58-5b199a49488d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IUTMCoordinatesType
	{
		/// <remarks/>
		[DispId(1)]
		string UTMZone
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string UTMEastward
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string UTMNorthward
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdUTMCoordinatesTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("7b9aa2b5-0a10-4ac9-a526-61caa0dd7c26")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISensitiveMobileDataType
	{
		/// <remarks/>
		[DispId(1)]
		string MSISDN
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string IMSI
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string IMEI
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdSensitiveMobileDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("483e91fd-9e12-461d-9ebe-1e9121f4f128")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAccountReqType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionIdentificationType CardAcquisitionReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		LoyaltyAccountIDType LoyaltyAccountID
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdLoyaltyAccountReqTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("a7e26a8f-c5c1-4c31-8add-742815eb0709")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAccountIDType
	{
		/// <remarks/>
		[DispId(1)]
		string[] EntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string IdentificationType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string IdentificationSupport
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string Value
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdLoyaltyAccountIDTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int EntryModeSize();
		[DispId(11)]
		string EntryModeGetItem(int index);
		[DispId(12)]
		bool EntryModeSetItem(int index, string value);
		[DispId(13)]
		bool EntryModeAddItem(string value);
		[DispId(14)]
		bool EntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("64af584c-8c37-498c-813a-de78aba92fd2")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IBalanceInquiryResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		PaymentAccountStatusType PaymentAccountStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LoyaltyAccountStatusType LoyaltyAccountStatus
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdBalanceInquiryResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("f982a680-b9a5-4dc0-967b-2a8c36559af7")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentAccountStatusType
	{
		/// <remarks/>
		[DispId(1)]
		PaymentInstrumentDataType PaymentInstrumentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		PaymentAcquirerDataType PaymentAcquirerData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LoyaltyAccountStatusType LoyaltyAccountStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		double CurrentBalance
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool CurrentBalanceSpecified
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdPaymentAccountStatusTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("155c8c89-225e-49af-bbc5-4502ec9e9a68")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentAcquirerDataType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionIdentificationType AcquirerTransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ApprovalCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string MerchantID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string AcquirerPOIID
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdPaymentAcquirerDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9c2a238f-13f3-4d33-8e50-4f0801a2da96")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAccountStatusType
	{
		/// <remarks/>
		[DispId(2)]
		LoyaltyAccountType LoyaltyAccount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		double CurrentBalance
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool CurrentBalanceSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string LoyaltyUnit
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string Currency
		{
			get;
			set;
		}
		[DispId(12)]
		bool xsdLoyaltyAccountStatusTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("ae6385ac-d66e-4046-af87-4be3c6d21e2f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAccountType
	{
		/// <remarks/>
		[DispId(1)]
		LoyaltyAccountIDType LoyaltyAccountID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string LoyaltyBrand
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdLoyaltyAccountTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("779bff0e-6dd6-4a16-b5e5-2d0e801d7049")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IBatchRequestType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionToPerformType[] TransactionToPerform
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool RemoveAllFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool RemoveAllFlagSpecified
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdBatchRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int TransactionToPerformSize();
		[DispId(9)]
		TransactionToPerformType TransactionToPerformGetItem(int index);
		[DispId(10)]
		bool TransactionToPerformSetItem(int index, TransactionToPerformType value);
		[DispId(11)]
		bool TransactionToPerformAddItem(TransactionToPerformType value);
		[DispId(12)]
		bool TransactionToPerformRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2df6efac-969e-4f71-bba4-56ea0fff580f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionToPerformType
	{
		/// <remarks/>
		[DispId(1)]
		object Item
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdTransactionToPerformTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9ea8bd73-6e1b-4472-b2ae-b47d1180d8fd")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyRequestType
	{
		/// <remarks/>
		[DispId(1)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		LoyaltyTransactionType LoyaltyTransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LoyaltyDataType[] LoyaltyData
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdLoyaltyRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int LoyaltyDataSize();
		[DispId(9)]
		LoyaltyDataType LoyaltyDataGetItem(int index);
		[DispId(10)]
		bool LoyaltyDataSetItem(int index, LoyaltyDataType value);
		[DispId(11)]
		bool LoyaltyDataAddItem(LoyaltyDataType value);
		[DispId(12)]
		bool LoyaltyDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("b70f5176-57ea-4827-9b29-cc78f41c7d90")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleDataType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionIdentificationType SaleTransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleTerminalDataType SaleTerminalData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		SponsoredMerchantType[] SponsoredMerchant
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string SaleToPOIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string SaleToAcquirerData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		SaleToIssuerDataType SaleToIssuerData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string OperatorID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string OperatorLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		string ShiftNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		string SaleReferenceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		string TokenRequestedType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		string CustomerOrderID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(25)]
		string[] CustomerOrderReq
		{
			get;
			set;
		}
		[DispId(27)]
		bool xsdSaleDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(28)]
		int SponsoredMerchantSize();
		[DispId(29)]
		SponsoredMerchantType SponsoredMerchantGetItem(int index);
		[DispId(30)]
		bool SponsoredMerchantSetItem(int index, SponsoredMerchantType value);
		[DispId(31)]
		bool SponsoredMerchantAddItem(SponsoredMerchantType value);
		[DispId(32)]
		bool SponsoredMerchantRemoveItem(int index);
		[DispId(33)]
		int CustomerOrderReqSize();
		[DispId(34)]
		string CustomerOrderReqGetItem(int index);
		[DispId(35)]
		bool CustomerOrderReqSetItem(int index, string value);
		[DispId(36)]
		bool CustomerOrderReqAddItem(string value);
		[DispId(37)]
		bool CustomerOrderReqRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("31b8ebf5-d70b-4e92-87c4-8898c13c9021")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleTerminalDataType
	{
		/// <remarks/>
		[DispId(1)]
		string SaleCapabilities
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleProfileType SaleProfile
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string TerminalEnvironment
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string TotalsGroupID
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdSaleTerminalDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("5e9a1c9a-7a19-487a-9832-8e13c214e457")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleProfileType
	{
		/// <remarks/>
		[DispId(2)]
		string ServiceProfiles
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string GenericProfile
		{
			get;
			set;
		}
		[DispId(6)]
		bool xsdSaleProfileTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("2c5d0458-d7fb-4dac-9062-0666149f4c16")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISponsoredMerchantType
	{
		/// <remarks/>
		[DispId(1)]
		string CommonName
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Address
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string CountryCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string MerchantCategoryCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string RegisteredIdentifier
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdSponsoredMerchantTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("50d21ff5-07e9-4376-9a29-c622440bcf86")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToIssuerDataType
	{
		/// <remarks/>
		[DispId(1)]
		string StatementReference
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSaleToIssuerDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("c7b2ee45-7575-483a-945d-d21647d61b69")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyTransactionType
	{
		/// <remarks/>
		[DispId(1)]
		OriginalPOITransactionType OriginalPOITransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionConditionsType TransactionConditions
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		SaleItemType[] SaleItem
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string LoyaltyTransactionType1
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		double TotalAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool TotalAmountSpecified
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdLoyaltyTransactionTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int SaleItemSize();
		[DispId(17)]
		SaleItemType SaleItemGetItem(int index);
		[DispId(18)]
		bool SaleItemSetItem(int index, SaleItemType value);
		[DispId(19)]
		bool SaleItemAddItem(SaleItemType value);
		[DispId(20)]
		bool SaleItemRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5d7ff012-a03f-4cea-8b5a-f663a9ed6f74")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IOriginalPOITransactionType
	{
		/// <remarks/>
		[DispId(2)]
		TransactionIdentificationType POITransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string ApprovalCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		TransactionIdentificationType HostTransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string SaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string POIID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool ReuseCardDataFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string CustomerLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		string AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		bool LastTransactionFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		bool LastTransactionFlagSpecified
		{
			get;
			set;
		}
		[DispId(22)]
		bool xsdOriginalPOITransactionTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("1a063ffe-9a45-4a50-85ce-a07117331616")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionConditionsType
	{
		/// <remarks/>
		[DispId(2)]
		string[] AllowedPaymentBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string[] AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string[] AllowedLoyaltyBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string[] ForceEntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool DebitPreferredFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string LoyaltyHandling
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string CustomerLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		bool ForceOnlineFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string MerchantCategoryCode
		{
			get;
			set;
		}
		[DispId(20)]
		bool xsdTransactionConditionsTypeInitFlag
		{
			get;
			set;
		}
		[DispId(21)]
		int AllowedPaymentBrandSize();
		[DispId(22)]
		string AllowedPaymentBrandGetItem(int index);
		[DispId(23)]
		bool AllowedPaymentBrandSetItem(int index, string value);
		[DispId(24)]
		bool AllowedPaymentBrandAddItem(string value);
		[DispId(25)]
		bool AllowedPaymentBrandRemoveItem(int index);
		[DispId(26)]
		int AcquirerIDSize();
		[DispId(27)]
		string AcquirerIDGetItem(int index);
		[DispId(28)]
		bool AcquirerIDSetItem(int index, string value);
		[DispId(29)]
		bool AcquirerIDAddItem(string value);
		[DispId(30)]
		bool AcquirerIDRemoveItem(int index);
		[DispId(31)]
		int AllowedLoyaltyBrandSize();
		[DispId(32)]
		string AllowedLoyaltyBrandGetItem(int index);
		[DispId(33)]
		bool AllowedLoyaltyBrandSetItem(int index, string value);
		[DispId(34)]
		bool AllowedLoyaltyBrandAddItem(string value);
		[DispId(35)]
		bool AllowedLoyaltyBrandRemoveItem(int index);
		[DispId(36)]
		int ForceEntryModeSize();
		[DispId(37)]
		string ForceEntryModeGetItem(int index);
		[DispId(38)]
		bool ForceEntryModeSetItem(int index, string value);
		[DispId(39)]
		bool ForceEntryModeAddItem(string value);
		[DispId(40)]
		bool ForceEntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2898e89f-45b3-4a78-96a6-55fbfb3a59ed")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleItemType
	{
		/// <remarks/>
		[DispId(1)]
		string UnitOfMeasure
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double Quantity
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool QuantitySpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		double UnitPrice
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		bool UnitPriceSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string TaxCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string SaleChannel
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string ProductLabel
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		string AdditionalProductInfo
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		string ItemID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		string ProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		string EanUpc
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(25)]
		double ItemAmount
		{
			get;
			set;
		}
		[DispId(27)]
		bool xsdSaleItemTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("ec5b2836-a68b-4cc8-8951-bea13cd6c439")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyDataType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionIdentificationType CardAcquisitionReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		LoyaltyAccountIDType LoyaltyAccountID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LoyaltyAmountType LoyaltyAmount
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdLoyaltyDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b6413947-5d62-458c-ace3-bc7ca1ce75c2")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAmountType
	{
		/// <remarks/>
		[DispId(2)]
		string LoyaltyUnit
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		double Value
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdLoyaltyAmountTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("c88d97c2-5fa1-4501-91b6-ac4a68b38eac")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentRequestType
	{
		/// <remarks/>
		[DispId(1)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		PaymentTransactionType PaymentTransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		PaymentDataType PaymentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		LoyaltyDataType[] LoyaltyData
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdPaymentRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int LoyaltyDataSize();
		[DispId(11)]
		LoyaltyDataType LoyaltyDataGetItem(int index);
		[DispId(12)]
		bool LoyaltyDataSetItem(int index, LoyaltyDataType value);
		[DispId(13)]
		bool LoyaltyDataAddItem(LoyaltyDataType value);
		[DispId(14)]
		bool LoyaltyDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("a0c19762-6bdc-4ea0-8a4a-928b86378749")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentTransactionType
	{
		/// <remarks/>
		[DispId(1)]
		AmountsReqType AmountsReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OriginalPOITransactionType OriginalPOITransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		TransactionConditionsType TransactionConditions
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		SaleItemType[] SaleItem
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdPaymentTransactionTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int SaleItemSize();
		[DispId(11)]
		SaleItemType SaleItemGetItem(int index);
		[DispId(12)]
		bool SaleItemSetItem(int index, SaleItemType value);
		[DispId(13)]
		bool SaleItemAddItem(SaleItemType value);
		[DispId(14)]
		bool SaleItemRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("f487e82d-a688-417f-90ec-44f12dd585ef")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentDataType
	{
		/// <remarks/>
		[DispId(2)]
		TransactionIdentificationType CardAcquisitionReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string RequestedValidityDate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		InstalmentType Instalment
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		CustomerOrderType CustomerOrder
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		PaymentInstrumentDataType PaymentInstrumentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string PaymentType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		bool SplitPaymentFlag
		{
			get;
			set;
		}
		[DispId(16)]
		bool xsdPaymentDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("dcda0ba7-bba3-4470-bb1f-b9fd622f2c17")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInstalmentType
	{
		/// <remarks/>
		[DispId(1)]
		string InstalmentType1
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string SequenceNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string PlanID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string Period
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string PeriodUnit
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string FirstPaymentDate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string TotalNbOfPayments
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		double CumulativeAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		bool CumulativeAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		double FirstAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		bool FirstAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		double Charges
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(25)]
		bool ChargesSpecified
		{
			get;
			set;
		}
		[DispId(27)]
		bool xsdInstalmentTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b16a6e5a-8ac4-4846-9b47-bfc8896b9732")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReversalRequestType
	{
		/// <remarks/>
		[DispId(1)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OriginalPOITransactionType OriginalPOITransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		CustomerOrderType CustomerOrder
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string ReversalReason
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		double ReversedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool ReversedAmountSpecified
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdReversalRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("e5f1ec27-e3a5-4938-aa84-d16df2b55f0c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IBatchResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		PerformedTransactionType[] PerformedTransaction
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdBatchResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int PerformedTransactionSize();
		[DispId(7)]
		PerformedTransactionType PerformedTransactionGetItem(int index);
		[DispId(8)]
		bool PerformedTransactionSetItem(int index, PerformedTransactionType value);
		[DispId(9)]
		bool PerformedTransactionAddItem(PerformedTransactionType value);
		[DispId(10)]
		bool PerformedTransactionRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("310550cf-63b3-4476-b5d6-fee26cc1c078")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPerformedTransactionType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		PaymentResultType PaymentResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		LoyaltyResultType[] LoyaltyResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		double ReversedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool ReversedAmountSpecified
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdPerformedTransactionTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int LoyaltyResultSize();
		[DispId(17)]
		LoyaltyResultType LoyaltyResultGetItem(int index);
		[DispId(18)]
		bool LoyaltyResultSetItem(int index, LoyaltyResultType value);
		[DispId(19)]
		bool LoyaltyResultAddItem(LoyaltyResultType value);
		[DispId(20)]
		bool LoyaltyResultRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("c29ce3fd-17fa-4cda-9c01-5777f237570b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOIDataType
	{
		/// <remarks/>
		[DispId(1)]
		TransactionIdentificationType POITransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string POIReconciliationID
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdPOIDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("1d911c23-7ec9-4e33-95f8-df2b2bac94da")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentResultType
	{
		/// <remarks/>
		[DispId(2)]
		PaymentInstrumentDataType PaymentInstrumentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		AmountsRespType AmountsResp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		InstalmentType Instalment
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		CurrencyConversionType[] CurrencyConversion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		CapturedSignatureType CapturedSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		ContentInformationType ProtectedSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		PaymentAcquirerDataType PaymentAcquirerData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		string PaymentType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		bool MerchantOverrideFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		string CustomerLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		bool OnlineFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(24)]
		string[] AuthenticationMethod
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(26)]
		string ValidityDate
		{
			get;
			set;
		}
		[DispId(28)]
		bool xsdPaymentResultTypeInitFlag
		{
			get;
			set;
		}
		[DispId(29)]
		int CurrencyConversionSize();
		[DispId(30)]
		CurrencyConversionType CurrencyConversionGetItem(int index);
		[DispId(31)]
		bool CurrencyConversionSetItem(int index, CurrencyConversionType value);
		[DispId(32)]
		bool CurrencyConversionAddItem(CurrencyConversionType value);
		[DispId(33)]
		bool CurrencyConversionRemoveItem(int index);
		[DispId(34)]
		int AuthenticationMethodSize();
		[DispId(35)]
		string AuthenticationMethodGetItem(int index);
		[DispId(36)]
		bool AuthenticationMethodSetItem(int index, string value);
		[DispId(37)]
		bool AuthenticationMethodAddItem(string value);
		[DispId(38)]
		bool AuthenticationMethodRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("a99f164d-e7f6-40c4-a323-60ada9f5fea0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICurrencyConversionType
	{
		/// <remarks/>
		[DispId(2)]
		AmountType ConvertedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		double Commission
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool CommissionSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string Declaration
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool CustomerApprovedFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		double Rate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		bool RateSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		double Markup
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		bool MarkupSpecified
		{
			get;
			set;
		}
		[DispId(20)]
		bool xsdCurrencyConversionTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("4cd5dd9a-fa07-4546-8357-061a3289698b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IAmountType
	{
		/// <remarks/>
		[DispId(1)]
		string Currency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double Value
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdAmountTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("e025f597-3515-4e48-9b89-3c2dc75d7635")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICapturedSignatureType
	{
		/// <remarks/>
		[DispId(1)]
		RawSignatureType RawSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SignatureImageType SignatureImage
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdCapturedSignatureTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("1d6d6cde-ffdb-4b61-9fc4-72446ddb12cf")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IRawSignatureType
	{
		/// <remarks/>
		[DispId(1)]
		AreaSizeType AreaSize
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SignaturePointType[] SignaturePoint
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdRawSignatureTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int SignaturePointSize();
		[DispId(7)]
		SignaturePointType SignaturePointGetItem(int index);
		[DispId(8)]
		bool SignaturePointSetItem(int index, SignaturePointType value);
		[DispId(9)]
		bool SignaturePointAddItem(SignaturePointType value);
		[DispId(10)]
		bool SignaturePointRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("a46d446b-d903-4f95-9b6f-cb32011cfc21")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISignaturePointType
	{
		/// <remarks/>
		[DispId(1)]
		string X
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Y
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdSignaturePointTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("1bc7f0cc-e26e-407e-b4f3-af21889b95c3")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISignatureImageType
	{
		/// <remarks/>
		[DispId(1)]
		string ImageFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] ImageData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ImageReference
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdSignatureImageTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int ImageDataSize();
		[DispId(9)]
		byte ImageDataGetItem(int index);
		[DispId(10)]
		bool ImageDataSetItem(int index, byte value);
		[DispId(11)]
		bool ImageDataAddItem(byte value);
		[DispId(12)]
		bool ImageDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("1325a214-3dee-4c5b-8e58-bae6499b91cd")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyResultType
	{
		/// <remarks/>
		[DispId(1)]
		LoyaltyAccountType LoyaltyAccount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		LoyaltyAmountType LoyaltyAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		LoyaltyAcquirerDataType LoyaltyAcquirerData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		RebatesType Rebates
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		double CurrentBalance
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool CurrentBalanceSpecified
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdLoyaltyResultTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d8f66d4d-5a0d-4c22-9d44-c2e883728680")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyAcquirerDataType
	{
		/// <remarks/>
		[DispId(1)]
		string ApprovalCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionIdentificationType LoyaltyTransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string LoyaltyAcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string HostReconciliationID
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdLoyaltyAcquirerDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9dce3413-f97f-4149-8f1f-766fab0fae50")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IRebatesType
	{
		/// <remarks/>
		[DispId(1)]
		double TotalRebate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool TotalRebateSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string RebateLabel
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		SaleItemRebateType[] SaleItemRebate
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdRebatesTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int SaleItemRebateSize();
		[DispId(11)]
		SaleItemRebateType SaleItemRebateGetItem(int index);
		[DispId(12)]
		bool SaleItemRebateSetItem(int index, SaleItemRebateType value);
		[DispId(13)]
		bool SaleItemRebateAddItem(SaleItemRebateType value);
		[DispId(14)]
		bool SaleItemRebateRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("56b9d49d-4683-4414-8137-f123c427c38e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleItemRebateType
	{
		/// <remarks/>
		[DispId(1)]
		string UnitOfMeasure
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double Quantity
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool QuantitySpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string RebateLabel
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ItemID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string ProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string EanUpc
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		double ItemAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		bool ItemAmountSpecified
		{
			get;
			set;
		}
		[DispId(19)]
		bool xsdSaleItemRebateTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("148695b0-f1c7-4a3d-977c-e99b1aec7093")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardAcquisitionRequestType
	{
		/// <remarks/>
		[DispId(1)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		CardAcquisitionTransactionType CardAcquisitionTransaction
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdCardAcquisitionRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("f18164ce-5239-4ac6-98d3-ee6a5fe2b106")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardAcquisitionTransactionType
	{
		/// <remarks/>
		[DispId(2)]
		string[] AllowedPaymentBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string[] AllowedLoyaltyBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string[] ForceEntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string LoyaltyHandling
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string CustomerLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool ForceCustomerSelectionFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		double TotalAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		bool TotalAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string PaymentType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		bool CashBackFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		bool CashBackFlagSpecified
		{
			get;
			set;
		}
		[DispId(24)]
		bool xsdCardAcquisitionTransactionTypeInitFlag
		{
			get;
			set;
		}
		[DispId(25)]
		int AllowedPaymentBrandSize();
		[DispId(26)]
		string AllowedPaymentBrandGetItem(int index);
		[DispId(27)]
		bool AllowedPaymentBrandSetItem(int index, string value);
		[DispId(28)]
		bool AllowedPaymentBrandAddItem(string value);
		[DispId(29)]
		bool AllowedPaymentBrandRemoveItem(int index);
		[DispId(30)]
		int AllowedLoyaltyBrandSize();
		[DispId(31)]
		string AllowedLoyaltyBrandGetItem(int index);
		[DispId(32)]
		bool AllowedLoyaltyBrandSetItem(int index, string value);
		[DispId(33)]
		bool AllowedLoyaltyBrandAddItem(string value);
		[DispId(34)]
		bool AllowedLoyaltyBrandRemoveItem(int index);
		[DispId(35)]
		int ForceEntryModeSize();
		[DispId(36)]
		string ForceEntryModeGetItem(int index);
		[DispId(37)]
		bool ForceEntryModeSetItem(int index, string value);
		[DispId(38)]
		bool ForceEntryModeAddItem(string value);
		[DispId(39)]
		bool ForceEntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("c3d78cab-e05a-41e1-b2dc-00d3da0c2ee0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardAcquisitionResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string[] PaymentBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		PaymentInstrumentDataType PaymentInstrumentData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		LoyaltyAccountType[] LoyaltyAccount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		CustomerOrderType[] CustomerOrder
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdCardAcquisitionResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int PaymentBrandSize();
		[DispId(17)]
		string PaymentBrandGetItem(int index);
		[DispId(18)]
		bool PaymentBrandSetItem(int index, string value);
		[DispId(19)]
		bool PaymentBrandAddItem(string value);
		[DispId(20)]
		bool PaymentBrandRemoveItem(int index);
		[DispId(21)]
		int LoyaltyAccountSize();
		[DispId(22)]
		LoyaltyAccountType LoyaltyAccountGetItem(int index);
		[DispId(23)]
		bool LoyaltyAccountSetItem(int index, LoyaltyAccountType value);
		[DispId(24)]
		bool LoyaltyAccountAddItem(LoyaltyAccountType value);
		[DispId(25)]
		bool LoyaltyAccountRemoveItem(int index);
		[DispId(26)]
		int CustomerOrderSize();
		[DispId(27)]
		CustomerOrderType CustomerOrderGetItem(int index);
		[DispId(28)]
		bool CustomerOrderSetItem(int index, CustomerOrderType value);
		[DispId(29)]
		bool CustomerOrderAddItem(CustomerOrderType value);
		[DispId(30)]
		bool CustomerOrderRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("e4bc528c-2e4e-4cb5-9573-807164cd64c6")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardholderPINType
	{
		/// <remarks/>
		[DispId(1)]
		ContentInformationType EncrPINBlock
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string PINFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string AdditionalInput
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdCardholderPINTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("98e1b72f-fa7b-414a-9e97-b49ccbd78933")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderAPDURequestType
	{
		/// <remarks/>
		[DispId(1)]
		byte[] APDUData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] APDUClass
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] APDUInstruction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		byte[] APDUPar1
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		byte[] APDUPar2
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		byte[] APDUExpectedLength
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdCardReaderAPDURequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(14)]
		int APDUDataSize();
		[DispId(15)]
		byte APDUDataGetItem(int index);
		[DispId(16)]
		bool APDUDataSetItem(int index, byte value);
		[DispId(17)]
		bool APDUDataAddItem(byte value);
		[DispId(18)]
		bool APDUDataRemoveItem(int index);
		[DispId(19)]
		int APDUClassSize();
		[DispId(20)]
		byte APDUClassGetItem(int index);
		[DispId(21)]
		bool APDUClassSetItem(int index, byte value);
		[DispId(22)]
		bool APDUClassAddItem(byte value);
		[DispId(23)]
		bool APDUClassRemoveItem(int index);
		[DispId(24)]
		int APDUInstructionSize();
		[DispId(25)]
		byte APDUInstructionGetItem(int index);
		[DispId(26)]
		bool APDUInstructionSetItem(int index, byte value);
		[DispId(27)]
		bool APDUInstructionAddItem(byte value);
		[DispId(28)]
		bool APDUInstructionRemoveItem(int index);
		[DispId(29)]
		int APDUPar1Size();
		[DispId(30)]
		byte APDUPar1GetItem(int index);
		[DispId(31)]
		bool APDUPar1SetItem(int index, byte value);
		[DispId(32)]
		bool APDUPar1AddItem(byte value);
		[DispId(33)]
		bool APDUPar1RemoveItem(int index);
		[DispId(34)]
		int APDUPar2Size();
		[DispId(35)]
		byte APDUPar2GetItem(int index);
		[DispId(36)]
		bool APDUPar2SetItem(int index, byte value);
		[DispId(37)]
		bool APDUPar2AddItem(byte value);
		[DispId(38)]
		bool APDUPar2RemoveItem(int index);
		[DispId(39)]
		int APDUExpectedLengthSize();
		[DispId(40)]
		byte APDUExpectedLengthGetItem(int index);
		[DispId(41)]
		bool APDUExpectedLengthSetItem(int index, byte value);
		[DispId(42)]
		bool APDUExpectedLengthAddItem(byte value);
		[DispId(43)]
		bool APDUExpectedLengthRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("36f2ea9b-44e5-4c4b-bf57-b4c0d0aacf78")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderAPDUResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] APDUData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		byte[] CardStatusWords
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdCardReaderAPDUResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int APDUDataSize();
		[DispId(9)]
		byte APDUDataGetItem(int index);
		[DispId(10)]
		bool APDUDataSetItem(int index, byte value);
		[DispId(11)]
		bool APDUDataAddItem(byte value);
		[DispId(12)]
		bool APDUDataRemoveItem(int index);
		[DispId(13)]
		int CardStatusWordsSize();
		[DispId(14)]
		byte CardStatusWordsGetItem(int index);
		[DispId(15)]
		bool CardStatusWordsSetItem(int index, byte value);
		[DispId(16)]
		bool CardStatusWordsAddItem(byte value);
		[DispId(17)]
		bool CardStatusWordsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("49a64e31-efac-4563-b273-745953c252e8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderInitRequestType
	{
		/// <remarks/>
		[DispId(2)]
		string[] ForceEntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool WarmResetFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		bool WarmResetFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool LeaveCardFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string MaxWaitingTime
		{
			get;
			set;
		}
		[DispId(14)]
		bool xsdCardReaderInitRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(15)]
		int ForceEntryModeSize();
		[DispId(16)]
		string ForceEntryModeGetItem(int index);
		[DispId(17)]
		bool ForceEntryModeSetItem(int index, string value);
		[DispId(18)]
		bool ForceEntryModeAddItem(string value);
		[DispId(19)]
		bool ForceEntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("3e343c35-36e6-47ae-a2e0-ddd7b48c7fe7")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderInitResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TrackDataType[] TrackData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		ICCResetDataType ICCResetData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string[] EntryMode
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdCardReaderInitResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int TrackDataSize();
		[DispId(11)]
		TrackDataType TrackDataGetItem(int index);
		[DispId(12)]
		bool TrackDataSetItem(int index, TrackDataType value);
		[DispId(13)]
		bool TrackDataAddItem(TrackDataType value);
		[DispId(14)]
		bool TrackDataRemoveItem(int index);
		[DispId(15)]
		int EntryModeSize();
		[DispId(16)]
		string EntryModeGetItem(int index);
		[DispId(17)]
		bool EntryModeSetItem(int index, string value);
		[DispId(18)]
		bool EntryModeAddItem(string value);
		[DispId(19)]
		bool EntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("33e9f8e7-b40e-4a13-a66f-eadd477fed0d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IICCResetDataType
	{
		/// <remarks/>
		[DispId(1)]
		byte[] ATRValue
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] CardStatusWords
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdICCResetDataTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int ATRValueSize();
		[DispId(7)]
		byte ATRValueGetItem(int index);
		[DispId(8)]
		bool ATRValueSetItem(int index, byte value);
		[DispId(9)]
		bool ATRValueAddItem(byte value);
		[DispId(10)]
		bool ATRValueRemoveItem(int index);
		[DispId(11)]
		int CardStatusWordsSize();
		[DispId(12)]
		byte CardStatusWordsGetItem(int index);
		[DispId(13)]
		bool CardStatusWordsSetItem(int index, byte value);
		[DispId(14)]
		bool CardStatusWordsAddItem(byte value);
		[DispId(15)]
		bool CardStatusWordsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("43cc62d1-61e9-4a04-8843-345c002a43e8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderPowerOffRequestType
	{
		/// <remarks/>
		[DispId(1)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string MaxWaitingTime
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdCardReaderPowerOffRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("a27b0fb7-9d2d-4c7d-91e1-5d77789bb286")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICardReaderPowerOffResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdCardReaderPowerOffResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("2d0385e6-27e0-43f6-b686-4701635eb201")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICashHandlingDeviceType
	{
		/// <remarks/>
		[DispId(1)]
		CoinsOrBillsType[] CoinsOrBills
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool CashHandlingOKFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string Currency
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdCashHandlingDeviceTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int CoinsOrBillsSize();
		[DispId(9)]
		CoinsOrBillsType CoinsOrBillsGetItem(int index);
		[DispId(10)]
		bool CoinsOrBillsSetItem(int index, CoinsOrBillsType value);
		[DispId(11)]
		bool CoinsOrBillsAddItem(CoinsOrBillsType value);
		[DispId(12)]
		bool CoinsOrBillsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("9e6ff95d-614a-4b35-9396-4016c8c73eea")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICoinsOrBillsType
	{
		/// <remarks/>
		[DispId(1)]
		double UnitValue
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Number
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdCoinsOrBillsTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("558e815b-b550-4897-9a09-177f957bd925")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ICriteriaOrderType
	{
		/// <remarks/>
		[DispId(1)]
		string Target
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdCriteriaOrderTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("14f4dd3a-1308-4a24-a14c-7eb3e4e490cb")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDiagnosisRequestType
	{
		/// <remarks/>
		[DispId(2)]
		string[] AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string POIID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool HostDiagnosisFlag
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdDiagnosisRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(9)]
		int AcquirerIDSize();
		[DispId(10)]
		string AcquirerIDGetItem(int index);
		[DispId(11)]
		bool AcquirerIDSetItem(int index, string value);
		[DispId(12)]
		bool AcquirerIDAddItem(string value);
		[DispId(13)]
		bool AcquirerIDRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2063f30c-0fdc-4fd5-9545-7ce3b06da00b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IDiagnosisResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string[] LoggedSaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIStatusType POIStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		HostStatusType[] HostStatus
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdDiagnosisResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int LoggedSaleIDSize();
		[DispId(11)]
		string LoggedSaleIDGetItem(int index);
		[DispId(12)]
		bool LoggedSaleIDSetItem(int index, string value);
		[DispId(13)]
		bool LoggedSaleIDAddItem(string value);
		[DispId(14)]
		bool LoggedSaleIDRemoveItem(int index);
		[DispId(15)]
		int HostStatusSize();
		[DispId(16)]
		HostStatusType HostStatusGetItem(int index);
		[DispId(17)]
		bool HostStatusSetItem(int index, HostStatusType value);
		[DispId(18)]
		bool HostStatusAddItem(HostStatusType value);
		[DispId(19)]
		bool HostStatusRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("36338317-85d4-48e5-b5f8-aa06bdf48025")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOIStatusType
	{
		/// <remarks/>
		[DispId(1)]
		CashHandlingDeviceType[] CashHandlingDevice
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string GlobalStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool SecurityOKFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		bool SecurityOKFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		bool PEDOKFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool PEDOKFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool CardReaderOKFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		bool CardReaderOKFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(17)]
		string PrinterStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(19)]
		bool CommunicationOKFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(21)]
		bool CommunicationOKFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(23)]
		bool FraudPreventionFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(25)]
		bool FraudPreventionFlagSpecified
		{
			get;
			set;
		}
		[DispId(27)]
		bool xsdPOIStatusTypeInitFlag
		{
			get;
			set;
		}
		[DispId(28)]
		int CashHandlingDeviceSize();
		[DispId(29)]
		CashHandlingDeviceType CashHandlingDeviceGetItem(int index);
		[DispId(30)]
		bool CashHandlingDeviceSetItem(int index, CashHandlingDeviceType value);
		[DispId(31)]
		bool CashHandlingDeviceAddItem(CashHandlingDeviceType value);
		[DispId(32)]
		bool CashHandlingDeviceRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("852f5f63-59fc-44d6-8b70-3b7e3e251579")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IHostStatusType
	{
		/// <remarks/>
		[DispId(2)]
		string AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool IsReachableFlag
		{
			get;
			set;
		}
		[DispId(6)]
		bool xsdHostStatusTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("4e979164-154c-4c87-a869-b4c2fccf4118")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEnableServiceRequestType
	{
		/// <remarks/>
		[DispId(1)]
		string ServicesEnabled
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string TransactionAction
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdEnableServiceRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("077e6af8-db73-4e07-b9e1-aaf435b6b63e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEnableServiceResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdEnableServiceResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("c2981470-76c3-4ba5-bc92-48df4f09ace8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IEventNotificationType
	{
		/// <remarks/>
		[DispId(2)]
		string EventDetails
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		byte[] RejectedMessage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string TimeStamp
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string EventToNotify
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool MaintenanceRequiredFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string CustomerLanguage
		{
			get;
			set;
		}
		[DispId(16)]
		bool xsdEventNotificationTypeInitFlag
		{
			get;
			set;
		}
		[DispId(17)]
		int RejectedMessageSize();
		[DispId(18)]
		byte RejectedMessageGetItem(int index);
		[DispId(19)]
		bool RejectedMessageSetItem(int index, byte value);
		[DispId(20)]
		bool RejectedMessageAddItem(byte value);
		[DispId(21)]
		bool RejectedMessageRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("719097e5-25e5-41bb-90e1-9d99be1dfd98")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IGetTotalsRequestType
	{
		/// <remarks/>
		[DispId(1)]
		string TotalDetails
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TotalFilterType TotalFilter
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdGetTotalsRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("4135da82-fec4-41e8-b657-83ad400c55d8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITotalFilterType
	{
		/// <remarks/>
		[DispId(1)]
		string POIID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string SaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string OperatorID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string ShiftNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string TotalsGroupID
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdTotalFilterTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("a7efdb8b-df3d-4cee-ba1b-bb5cb5190adf")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IGetTotalsResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionTotalsType[] TransactionTotals
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string POIReconciliationID
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdGetTotalsResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int TransactionTotalsSize();
		[DispId(9)]
		TransactionTotalsType TransactionTotalsGetItem(int index);
		[DispId(10)]
		bool TransactionTotalsSetItem(int index, TransactionTotalsType value);
		[DispId(11)]
		bool TransactionTotalsAddItem(TransactionTotalsType value);
		[DispId(12)]
		bool TransactionTotalsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("4f186cbc-3b98-4421-9181-259032beb68d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionTotalsType
	{
		/// <remarks/>
		[DispId(2)]
		PaymentTotalsType[] PaymentTotals
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		LoyaltyTotalsType[] LoyaltyTotals
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string PaymentInstrumentType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string ErrorCondition
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string HostReconciliationID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string CardBrand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		string POIID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string SaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		string OperatorID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		string ShiftNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(24)]
		string TotalsGroupID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(26)]
		string PaymentCurrency
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(28)]
		string LoyaltyUnit
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(30)]
		string LoyaltyCurrency
		{
			get;
			set;
		}
		[DispId(32)]
		bool xsdTransactionTotalsTypeInitFlag
		{
			get;
			set;
		}
		[DispId(33)]
		int PaymentTotalsSize();
		[DispId(34)]
		PaymentTotalsType PaymentTotalsGetItem(int index);
		[DispId(35)]
		bool PaymentTotalsSetItem(int index, PaymentTotalsType value);
		[DispId(36)]
		bool PaymentTotalsAddItem(PaymentTotalsType value);
		[DispId(37)]
		bool PaymentTotalsRemoveItem(int index);
		[DispId(38)]
		int LoyaltyTotalsSize();
		[DispId(39)]
		LoyaltyTotalsType LoyaltyTotalsGetItem(int index);
		[DispId(40)]
		bool LoyaltyTotalsSetItem(int index, LoyaltyTotalsType value);
		[DispId(41)]
		bool LoyaltyTotalsAddItem(LoyaltyTotalsType value);
		[DispId(42)]
		bool LoyaltyTotalsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2a6a77ff-eed7-4c70-ade4-6c61e793a9d8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentTotalsType
	{
		/// <remarks/>
		[DispId(1)]
		string TransactionType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string TransactionCount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		double TransactionAmount
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdPaymentTotalsTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("7fa6c2aa-72b6-4d42-bde5-c30ea711119f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyTotalsType
	{
		/// <remarks/>
		[DispId(1)]
		string TransactionType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string TransactionCount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		double TransactionAmount
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdLoyaltyTotalsTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("39889972-a2bf-400e-9952-fc0a7637b091")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputType
	{
		/// <remarks/>
		[DispId(1)]
		bool ConfirmedFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		bool ConfirmedFlagSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string FunctionKey
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string TextInput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string DigitInput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		ContentInformationType Password
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string MenuEntryNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string InputCommand
		{
			get;
			set;
		}
		[DispId(17)]
		bool xsdInputTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("a908e659-d54a-40ae-9e3a-4eb098aa96eb")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputDataType
	{
		/// <remarks/>
		[DispId(2)]
		string DefaultInputString
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string StringMask
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string Device
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string InfoQualify
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string InputCommand
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool NotifyCardInputFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string MaxInputTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		bool ImmediateResponseFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string MinLength
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		string MaxLength
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(22)]
		string MaxDecimalLength
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(24)]
		bool WaitUserValidationFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(26)]
		bool FromRightToLeftFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(28)]
		bool MaskCharactersFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(30)]
		bool BeepKeyFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(32)]
		bool GlobalCorrectionFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(34)]
		bool DisableCancelFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(36)]
		bool DisableCorrectFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(38)]
		bool DisableValidFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(40)]
		bool MenuBackFlag
		{
			get;
			set;
		}
		[DispId(42)]
		bool xsdInputDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b240a1ae-8f16-4a02-8857-5e820f698721")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputRequestType
	{
		/// <remarks/>
		[DispId(1)]
		DisplayOutputType DisplayOutput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		InputDataType InputData
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdInputRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("faef83c7-81c7-49f9-b03a-dc2401ed0d22")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputResponseType
	{
		/// <remarks/>
		[DispId(1)]
		OutputResultType OutputResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		InputResultType InputResult
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdInputResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b367ea45-09d4-4f40-aaaf-eadbf82f60bb")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputResultType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		InputType Input
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string Device
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string InfoQualify
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdInputResultTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("e543e5e7-df51-4250-9437-f7dbf8469017")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IInputUpdateType
	{
		/// <remarks/>
		[DispId(1)]
		MessageReferenceType MessageReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OutputContentType OutputContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		MenuEntryType[] MenuEntry
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		byte[] OutputSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string MinLength
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string MaxLength
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string MaxDecimalLength
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdInputUpdateTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int MenuEntrySize();
		[DispId(17)]
		MenuEntryType MenuEntryGetItem(int index);
		[DispId(18)]
		bool MenuEntrySetItem(int index, MenuEntryType value);
		[DispId(19)]
		bool MenuEntryAddItem(MenuEntryType value);
		[DispId(20)]
		bool MenuEntryRemoveItem(int index);
		[DispId(21)]
		int OutputSignatureSize();
		[DispId(22)]
		byte OutputSignatureGetItem(int index);
		[DispId(23)]
		bool OutputSignatureSetItem(int index, byte value);
		[DispId(24)]
		bool OutputSignatureAddItem(byte value);
		[DispId(25)]
		bool OutputSignatureRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("c4b097cf-8b67-49b8-8e11-4c1e46726203")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoginRequestType
	{
		/// <remarks/>
		[DispId(2)]
		string DateTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		SaleSoftwareType SaleSoftware
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		SaleTerminalDataType SaleTerminalData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		bool TrainingModeFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string OperatorLanguage
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		string OperatorID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(14)]
		string ShiftNumber
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(16)]
		string TokenRequestedType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(18)]
		string[] CustomerOrderReq
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(20)]
		string POISerialNumber
		{
			get;
			set;
		}
		[DispId(22)]
		bool xsdLoginRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(23)]
		int CustomerOrderReqSize();
		[DispId(24)]
		string CustomerOrderReqGetItem(int index);
		[DispId(25)]
		bool CustomerOrderReqSetItem(int index, string value);
		[DispId(26)]
		bool CustomerOrderReqAddItem(string value);
		[DispId(27)]
		bool CustomerOrderReqRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("3a997c76-34e0-4d63-8c80-b97cb18ee2ed")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleSoftwareType
	{
		/// <remarks/>
		[DispId(1)]
		string ProviderIdentification
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ApplicationName
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string SoftwareVersion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string CertificationCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ComponentDescription
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string ComponentType
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdSaleSoftwareTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("e3f71364-212b-470e-b6cc-eac8ae1718db")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoginResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		POISystemDataType POISystemData
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdLoginResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b2611ad9-116d-4665-8131-39250dc2f08b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOISystemDataType
	{
		/// <remarks/>
		[DispId(1)]
		string DateTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		POISoftwareType POISoftware
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POITerminalDataType POITerminalData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		POIStatusType POIStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		bool TokenRequestStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool TokenRequestStatusSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		bool CustomerOrderStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		bool CustomerOrderStatusSpecified
		{
			get;
			set;
		}
		[DispId(17)]
		bool xsdPOISystemDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("4ab448ff-0c92-49d4-b8ea-8db6aa34ad91")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOISoftwareType
	{
		/// <remarks/>
		[DispId(1)]
		string ProviderIdentification
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ApplicationName
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string SoftwareVersion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string CertificationCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ComponentDescription
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string ComponentType
		{
			get;
			set;
		}
		[DispId(13)]
		bool xsdPOISoftwareTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("62865441-58ab-4df2-894c-84813e00d63c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOITerminalDataType
	{
		/// <remarks/>
		[DispId(1)]
		string POICapabilities
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		POIProfileType POIProfile
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string TerminalEnvironment
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string POISerialNumber
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdPOITerminalDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("0a6b6499-2dd8-4252-b66b-4cb5e8567020")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPOIProfileType
	{
		/// <remarks/>
		[DispId(2)]
		string ServiceProfiles
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string GenericProfile
		{
			get;
			set;
		}
		[DispId(6)]
		bool xsdPOIProfileTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("f8b2a4a1-181b-403e-a71f-627b4c5480ae")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILogoutRequestType
	{
		/// <remarks/>
		[DispId(2)]
		bool MaintenanceAllowed
		{
			get;
			set;
		}
		[DispId(4)]
		bool xsdLogoutRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b27204bb-e34c-468f-91d1-71b440ace862")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILogoutResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdLogoutResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("b1e0d17e-4ae2-4325-91a1-6abbeff2732e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ILoyaltyResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		LoyaltyResultType[] LoyaltyResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		PaymentReceiptType[] PaymentReceipt
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdLoyaltyResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(12)]
		int LoyaltyResultSize();
		[DispId(13)]
		LoyaltyResultType LoyaltyResultGetItem(int index);
		[DispId(14)]
		bool LoyaltyResultSetItem(int index, LoyaltyResultType value);
		[DispId(15)]
		bool LoyaltyResultAddItem(LoyaltyResultType value);
		[DispId(16)]
		bool LoyaltyResultRemoveItem(int index);
		[DispId(17)]
		int PaymentReceiptSize();
		[DispId(18)]
		PaymentReceiptType PaymentReceiptGetItem(int index);
		[DispId(19)]
		bool PaymentReceiptSetItem(int index, PaymentReceiptType value);
		[DispId(20)]
		bool PaymentReceiptAddItem(PaymentReceiptType value);
		[DispId(21)]
		bool PaymentReceiptRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("c15f4454-a79f-4589-98ed-687afad31857")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentReceiptType
	{
		/// <remarks/>
		[DispId(2)]
		OutputContentType OutputContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string DocumentQualifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool IntegratedPrintFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		bool RequiredSignatureFlag
		{
			get;
			set;
		}
		[DispId(10)]
		bool xsdPaymentReceiptTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("fcf305e1-ad59-499d-91f1-6e160755bf1d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IMessageHeaderType
	{
		/// <remarks/>
		[DispId(1)]
		string ProtocolVersion
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string MessageClass
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string MessageCategory
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string MessageType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ServiceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string DeviceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string SaleID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string POIID
		{
			get;
			set;
		}
		[DispId(17)]
		bool xsdMessageHeaderTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("a7f52916-2e1c-4eb9-b662-5d31c262827a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPaymentResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		PaymentResultType PaymentResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		LoyaltyResultType[] LoyaltyResult
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		PaymentReceiptType[] PaymentReceipt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		CustomerOrderType[] CustomerOrder
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdPaymentResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int LoyaltyResultSize();
		[DispId(17)]
		LoyaltyResultType LoyaltyResultGetItem(int index);
		[DispId(18)]
		bool LoyaltyResultSetItem(int index, LoyaltyResultType value);
		[DispId(19)]
		bool LoyaltyResultAddItem(LoyaltyResultType value);
		[DispId(20)]
		bool LoyaltyResultRemoveItem(int index);
		[DispId(21)]
		int PaymentReceiptSize();
		[DispId(22)]
		PaymentReceiptType PaymentReceiptGetItem(int index);
		[DispId(23)]
		bool PaymentReceiptSetItem(int index, PaymentReceiptType value);
		[DispId(24)]
		bool PaymentReceiptAddItem(PaymentReceiptType value);
		[DispId(25)]
		bool PaymentReceiptRemoveItem(int index);
		[DispId(26)]
		int CustomerOrderSize();
		[DispId(27)]
		CustomerOrderType CustomerOrderGetItem(int index);
		[DispId(28)]
		bool CustomerOrderSetItem(int index, CustomerOrderType value);
		[DispId(29)]
		bool CustomerOrderAddItem(CustomerOrderType value);
		[DispId(30)]
		bool CustomerOrderRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("937b151b-4b4a-4c97-988e-3ade7320d225")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPINRequestType
	{
		/// <remarks/>
		[DispId(1)]
		CardholderPINType CardholderPIN
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string PINRequestType1
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string PINVerifMethod
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string AdditionalInput
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string PINEncAlgorithm
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string PINFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string KeyReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string MaxWaitingTime
		{
			get;
			set;
		}
		[DispId(17)]
		bool xsdPINRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("65a00b39-c8ca-4422-9abf-32d8692b788b")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPINResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		CardholderPINType CardholderPIN
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdPINResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("fb84da39-92ee-4e08-ba7b-cb26588d7655")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPrintOutputType
	{
		/// <remarks/>
		[DispId(2)]
		OutputContentType OutputContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		byte[] OutputSignature
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string DocumentQualifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string ResponseMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		bool IntegratedPrintFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(12)]
		bool RequiredSignatureFlag
		{
			get;
			set;
		}
		[DispId(14)]
		bool xsdPrintOutputTypeInitFlag
		{
			get;
			set;
		}
		[DispId(15)]
		int OutputSignatureSize();
		[DispId(16)]
		byte OutputSignatureGetItem(int index);
		[DispId(17)]
		bool OutputSignatureSetItem(int index, byte value);
		[DispId(18)]
		bool OutputSignatureAddItem(byte value);
		[DispId(19)]
		bool OutputSignatureRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2ed2fd9e-6dd7-443e-97d2-9a47e0729f71")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPrintRequestType
	{
		/// <remarks/>
		[DispId(1)]
		PrintOutputType PrintOutput
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdPrintRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("cbf350b8-45d5-4479-943f-a8507985926d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IPrintResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string DocumentQualifier
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdPrintResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9d006d52-6bcf-40d6-a976-df6af60b0a34")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReconciliationRequestType
	{
		/// <remarks/>
		[DispId(1)]
		string[] AcquirerID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string ReconciliationType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string POIReconciliationID
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdReconciliationRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int AcquirerIDSize();
		[DispId(9)]
		string AcquirerIDGetItem(int index);
		[DispId(10)]
		bool AcquirerIDSetItem(int index, string value);
		[DispId(11)]
		bool AcquirerIDAddItem(string value);
		[DispId(12)]
		bool AcquirerIDRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5132adbd-1de2-40b7-b315-f5dd74e61055")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReconciliationResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionTotalsType[] TransactionTotals
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ReconciliationType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string POIReconciliationID
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdReconciliationResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int TransactionTotalsSize();
		[DispId(11)]
		TransactionTotalsType TransactionTotalsGetItem(int index);
		[DispId(12)]
		bool TransactionTotalsSetItem(int index, TransactionTotalsType value);
		[DispId(13)]
		bool TransactionTotalsAddItem(TransactionTotalsType value);
		[DispId(14)]
		bool TransactionTotalsRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("4d3493b1-b767-4829-8113-a5cf2e72c084")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IRepeatedMessageResponseType
	{
		/// <remarks/>
		[DispId(1)]
		MessageHeaderType MessageHeader
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		object Item
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdRepeatedMessageResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("bc566189-eb47-48d3-966e-2821b8ed72d6")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IReversalResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		OriginalPOITransactionType OriginalPOITransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		PaymentReceiptType[] PaymentReceipt
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		double ReversedAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		bool ReversedAmountSpecified
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string CustomerOrderID
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdReversalResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int PaymentReceiptSize();
		[DispId(17)]
		PaymentReceiptType PaymentReceiptGetItem(int index);
		[DispId(18)]
		bool PaymentReceiptSetItem(int index, PaymentReceiptType value);
		[DispId(19)]
		bool PaymentReceiptAddItem(PaymentReceiptType value);
		[DispId(20)]
		bool PaymentReceiptRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("158a477c-e982-450f-b4cc-d732bd5cc244")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		StoredValueResultType[] StoredValueResult
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdStoredValueResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(10)]
		int StoredValueResultSize();
		[DispId(11)]
		StoredValueResultType StoredValueResultGetItem(int index);
		[DispId(12)]
		bool StoredValueResultSetItem(int index, StoredValueResultType value);
		[DispId(13)]
		bool StoredValueResultAddItem(StoredValueResultType value);
		[DispId(14)]
		bool StoredValueResultRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("4bcd944c-9715-4d9c-84f8-018afefa1100")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueResultType
	{
		/// <remarks/>
		[DispId(1)]
		StoredValueAccountStatusType StoredValueAccountStatus
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionIdentificationType HostTransactionID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string StoredValueTransactionType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string ProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string EanUpc
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		double ItemAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string Currency
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdStoredValueResultTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("e54a41e1-648d-46bf-ac40-614279d62a1d")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueAccountStatusType
	{
		/// <remarks/>
		[DispId(1)]
		StoredValueAccountIDType StoredValueAccountID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		double CurrentBalance
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		bool CurrentBalanceSpecified
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdStoredValueAccountStatusTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d6d2cb8d-bc0c-4a10-a568-9b13a3635ec8")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueAccountIDType
	{
		/// <remarks/>
		[DispId(1)]
		string StoredValueAccountType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string StoredValueProvider
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string OwnerName
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string ExpiryDate
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string[] EntryMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string IdentificationType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		string Value
		{
			get;
			set;
		}
		[DispId(15)]
		bool xsdStoredValueAccountIDTypeInitFlag
		{
			get;
			set;
		}
		[DispId(16)]
		int EntryModeSize();
		[DispId(17)]
		string EntryModeGetItem(int index);
		[DispId(18)]
		bool EntryModeSetItem(int index, string value);
		[DispId(19)]
		bool EntryModeAddItem(string value);
		[DispId(20)]
		bool EntryModeRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("e791ad35-7353-489e-8a04-8d528a6b2597")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISearchANDType
	{
		/// <remarks/>
		[DispId(1)]
		string Target
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OperatorEnumeration Operator
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string Value
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdSearchANDTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("0caec16b-5d8b-427a-a7ed-8fb084d20157")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISearchCriteriasType
	{
		/// <remarks/>
		[DispId(1)]
		SearchANDType[][] SearchOR
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSearchCriteriasTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("eb72ff4d-9d78-4eec-9879-d0c1e9bc7544")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISearchORType
	{
		/// <remarks/>
		[DispId(1)]
		SearchANDType[] SearchAND
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSearchORTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int SearchANDSize();
		[DispId(5)]
		SearchANDType SearchANDGetItem(int index);
		[DispId(6)]
		bool SearchANDSetItem(int index, SearchANDType value);
		[DispId(7)]
		bool SearchANDAddItem(SearchANDType value);
		[DispId(8)]
		bool SearchANDRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("5542fe67-1387-431d-8358-159f910dfe6a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISearchOutputOrderType
	{
		/// <remarks/>
		[DispId(1)]
		CriteriaOrderType[] CriteriaOrder
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSearchOutputOrderTypeInitFlag
		{
			get;
			set;
		}
		[DispId(4)]
		int CriteriaOrderSize();
		[DispId(5)]
		CriteriaOrderType CriteriaOrderGetItem(int index);
		[DispId(6)]
		bool CriteriaOrderSetItem(int index, CriteriaOrderType value);
		[DispId(7)]
		bool CriteriaOrderAddItem(CriteriaOrderType value);
		[DispId(8)]
		bool CriteriaOrderRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("192b4bb3-eb3a-43bc-8309-254eea160e86")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISoundContentType
	{
		/// <remarks/>
		[DispId(1)]
		string SoundFormat
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		string Language
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ReferenceID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string Value
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdSoundContentTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d4f83caf-6bda-461b-b4b4-07d3c5951bc6")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISoundRequestType
	{
		/// <remarks/>
		[DispId(2)]
		SoundContentType SoundContent
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string ResponseMode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string SoundAction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string SoundVolume
		{
			get;
			set;
		}
		[DispId(10)]
		bool xsdSoundRequestTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("cfa955fd-7f5f-4ca0-9a0b-e6debe7de869")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISoundResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		[DispId(3)]
		bool xsdSoundResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("5be1bebf-8445-4adf-a5c0-cb043f927bcb")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueDataType
	{
		/// <remarks/>
		[DispId(1)]
		StoredValueAccountIDType StoredValueAccountID
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		OriginalPOITransactionType OriginalPOITransaction
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string StoredValueProvider
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string StoredValueTransactionType
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string ProductCode
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(11)]
		string EanUpc
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(13)]
		double ItemAmount
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(15)]
		string Currency
		{
			get;
			set;
		}
		[DispId(17)]
		bool xsdStoredValueDataTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9b5c34d3-7f92-4c50-a970-c9cdee46ac9e")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface IStoredValueRequestType
	{
		/// <remarks/>
		[DispId(1)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		StoredValueDataType[] StoredValueData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string CustomerLanguage
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdStoredValueRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(8)]
		int StoredValueDataSize();
		[DispId(9)]
		StoredValueDataType StoredValueDataGetItem(int index);
		[DispId(10)]
		bool StoredValueDataSetItem(int index, StoredValueDataType value);
		[DispId(11)]
		bool StoredValueDataAddItem(StoredValueDataType value);
		[DispId(12)]
		bool StoredValueDataRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("8858f558-9f01-42a4-84a8-ee3e025d799a")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransmitRequestType
	{
		/// <remarks/>
		[DispId(2)]
		byte[] Message
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		bool WaitResponseFlag
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		string MaximumTransmitTime
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string DestinationAddress
		{
			get;
			set;
		}
		[DispId(10)]
		bool xsdTransmitRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(11)]
		int MessageSize();
		[DispId(12)]
		byte MessageGetItem(int index);
		[DispId(13)]
		bool MessageSetItem(int index, byte value);
		[DispId(14)]
		bool MessageAddItem(byte value);
		[DispId(15)]
		bool MessageRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("0772c833-eef6-4f1d-8872-f8f591b12ef6")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransmitResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		byte[] Message
		{
			get;
			set;
		}
		[DispId(5)]
		bool xsdTransmitResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(6)]
		int MessageSize();
		[DispId(7)]
		byte MessageGetItem(int index);
		[DispId(8)]
		bool MessageSetItem(int index, byte value);
		[DispId(9)]
		bool MessageAddItem(byte value);
		[DispId(10)]
		bool MessageRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("9c2cf03b-c5b4-4ae9-8931-02289ed109a0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionReportType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		SaleDataType SaleData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		POIDataType POIData
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		PaymentResultType PaymentResult
		{
			get;
			set;
		}
		[DispId(9)]
		bool xsdTransactionReportTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("9fbcb5b5-1771-4f55-81a8-486b661fed6c")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionReportRequestType
	{
		/// <remarks/>
		[DispId(2)]
		SearchANDType[][] SearchCriterias
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		CriteriaOrderType[] SearchOutputOrder
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool DescendingOrder
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(8)]
		string BlockStart
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(10)]
		string BlockStop
		{
			get;
			set;
		}
		[DispId(12)]
		bool xsdTransactionReportRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(13)]
		int SearchOutputOrderSize();
		[DispId(14)]
		CriteriaOrderType SearchOutputOrderGetItem(int index);
		[DispId(15)]
		bool SearchOutputOrderSetItem(int index, CriteriaOrderType value);
		[DispId(16)]
		bool SearchOutputOrderAddItem(CriteriaOrderType value);
		[DispId(17)]
		bool SearchOutputOrderRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("0674e814-9710-4c25-86e9-0dd6a0544b56")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionReportResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		TransactionReportType[] TransactionReport
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		string ReportFullSize
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(7)]
		string BlockStart
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(9)]
		string BlockStop
		{
			get;
			set;
		}
		[DispId(11)]
		bool xsdTransactionReportResponseTypeInitFlag
		{
			get;
			set;
		}
		[DispId(12)]
		int TransactionReportSize();
		[DispId(13)]
		TransactionReportType TransactionReportGetItem(int index);
		[DispId(14)]
		bool TransactionReportSetItem(int index, TransactionReportType value);
		[DispId(15)]
		bool TransactionReportAddItem(TransactionReportType value);
		[DispId(16)]
		bool TransactionReportRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("2ef8c679-a3ad-4ba6-aa31-604f2ccd0196")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionStatusRequestType
	{
		/// <remarks/>
		[DispId(2)]
		MessageReferenceType MessageReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(4)]
		string[] DocumentQualifier
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(6)]
		bool ReceiptReprintFlag
		{
			get;
			set;
		}
		[DispId(8)]
		bool xsdTransactionStatusRequestTypeInitFlag
		{
			get;
			set;
		}
		[DispId(9)]
		int DocumentQualifierSize();
		[DispId(10)]
		string DocumentQualifierGetItem(int index);
		[DispId(11)]
		bool DocumentQualifierSetItem(int index, string value);
		[DispId(12)]
		bool DocumentQualifierAddItem(string value);
		[DispId(13)]
		bool DocumentQualifierRemoveItem(int index);
	}
	[System.Runtime.InteropServices.GuidAttribute("678fa3cd-ab1c-43e9-ad61-31680424ccc0")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ITransactionStatusResponseType
	{
		/// <remarks/>
		[DispId(1)]
		ResponseType Response
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		MessageReferenceType MessageReference
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		RepeatedMessageResponseType RepeatedMessageResponse
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdTransactionStatusResponseTypeInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("d4af795f-ffd2-4b56-9e3a-62ad4b62130f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIRequest
	{
		/// <remarks/>
		[DispId(1)]
		MessageHeaderType MessageHeader
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		object Item
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		ContentInformationType SecurityTrailer
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdSaleToPOIRequestInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.GuidAttribute("f29960e3-63ab-44f8-a601-7f07282ac54f")]
	[System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public interface ISaleToPOIResponse
	{
		/// <remarks/>
		[DispId(1)]
		MessageHeaderType MessageHeader
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(3)]
		object Item
		{
			get;
			set;
		}
		/// <remarks/>
		[DispId(5)]
		ContentInformationType SecurityTrailer
		{
			get;
			set;
		}
		[DispId(7)]
		bool xsdSaleToPOIResponseInitFlag
		{
			get;
			set;
		}
	}
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public enum TagsEnumeration
	{
		AbortReason,
		AccessedBy,
		AccountNumber,
		AccountType,
		AcquirerID,
		AcquirerPOIID,
		AcquirerTransactionID,
		AdditionalInformation,
		AdditionalInput,
		AdditionalProductInfo,
		AdditionalResponse,
		Address,
		Algorithm,
		Alignment,
		AllowedLoyaltyBrand,
		AllowedPaymentBrand,
		AllowedProduct,
		AllowedProductCode,
		AmountsReq,
		AmountsResp,
		APDUClass,
		APDUData,
		APDUExpectedLength,
		APDUInstruction,
		APDUPar1,
		APDUPar2,
		ApplicationName,
		ApprovalCode,
		AreaSize,
		ATRValue,
		AttributeType,
		AttributeValue,
		AuthenticationMethod,
		AuthorizedAmount,
		BankID,
		BarcodeType,
		BarcodeValue,
		BeepKeyFlag,
		BlockStart,
		BlockStop,
		CapturedSignature,
		CardAcquisitionReference,
		CardAcquisitionTransaction,
		CardBrand,
		CardCountryCode,
		CardData,
		CardholderPIN,
		CardReaderOKFlag,
		CardReaderOKFlagSpecified,
		CardSeqNumb,
		CardStatusWords,
		CashBackAmount,
		CashBackAmountSpecified,
		CashBackFlag,
		CashBackFlagSpecified,
		CashHandlingDevice,
		CashHandlingOKFlag,
		Certificate,
		CertificationCode,
		CharacterHeight,
		CharacterSet,
		CharacterStyle,
		CharacterWidth,
		Charges,
		ChargesSpecified,
		CheckCardNumber,
		CheckData,
		CheckNumber,
		CoinsOrBills,
		Color,
		Commission,
		CommissionSpecified,
		CommonName,
		CommunicationOKFlag,
		CommunicationOKFlagSpecified,
		ComponentDescription,
		ComponentType,
		ConfirmedFlag,
		ConfirmedFlagSpecified,
		Content,
		ContentEncryptionAlgorithm,
		ContentType,
		ConvertedAmount,
		Country,
		CountryCode,
		CriteriaOrder,
		CumulativeAmount,
		CumulativeAmountSpecified,
		Currency,
		CurrencyConversion,
		CurrentAmount,
		CurrentAmountSpecified,
		CurrentBalance,
		CurrentBalanceSpecified,
		CustomerApprovedFlag,
		CustomerLanguage,
		CustomerOrder,
		CustomerOrderID,
		CustomerOrderReq,
		CustomerOrderStatus,
		CustomerOrderStatusSpecified,
		DateTime,
		DebitPreferredFlag,
		Declaration,
		DefaultInputString,
		DefaultSelectedFlag,
		DerivationIdentifier,
		DescendingOrder,
		DestinationAddress,
		Device,
		DeviceID,
		Digest,
		DigestAlgorithm,
		DigitInput,
		DisableCancelFlag,
		DisableCorrectFlag,
		DisableValidFlag,
		DisplayOutput,
		DocumentQualifier,
		EanUpc,
		EncapsulatedContent,
		EncrPINBlock,
		EncryptedContent,
		EncryptedData,
		EncryptedKey,
		EndDate,
		EndDateSpecified,
		EndOfLineFlag,
		EntryMode,
		ErrorCondition,
		EventDetails,
		EventToNotify,
		ExpiryDate,
		ExpiryDateTime,
		ExpiryDateTimeSpecified,
		FirstAmount,
		FirstAmountSpecified,
		FirstPaymentDate,
		Font,
		ForceCustomerSelectionFlag,
		ForceEntryMode,
		ForceOnlineFlag,
		ForecastedAmount,
		FraudPreventionFlag,
		FraudPreventionFlagSpecified,
		FromRightToLeftFlag,
		FunctionKey,
		GenericProfile,
		GeographicCoordinates,
		Geolocation,
		GlobalCorrectionFlag,
		GlobalStatus,
		HostDiagnosisFlag,
		HostReconciliationID,
		HostStatus,
		HostTransactionID,
		ICCResetData,
		IdentificationSupport,
		IdentificationType,
		ImageData,
		ImageFormat,
		ImageReference,
		IMEI,
		ImmediateResponseFlag,
		IMSI,
		InfoQualify,
		InitialisationVector,
		Input,
		InputCommand,
		InputData,
		InputResult,
		Instalment,
		InstalmentType1,
		IntegratedPrintFlag,
		IsReachableFlag,
		Issuer,
		IssuerAndSerialNumber,
		Item,
		ItemAmount,
		ItemAmountSpecified,
		ItemID,
		Items,
		KEKIdentifier,
		KeyEncryptionAlgorithm,
		KeyIdentifier,
		KeyName,
		KeyReference,
		KeyVersion,
		Language,
		LastTransactionFlag,
		LastTransactionFlagSpecified,
		Latitude,
		LeaveCardFlag,
		LoggedSaleID,
		Longitude,
		LoyaltyAccount,
		LoyaltyAccountID,
		LoyaltyAccountReq,
		LoyaltyAccountStatus,
		LoyaltyAcquirerData,
		LoyaltyAcquirerID,
		LoyaltyAmount,
		LoyaltyBrand,
		LoyaltyCurrency,
		LoyaltyData,
		LoyaltyHandling,
		LoyaltyResult,
		LoyaltyTotals,
		LoyaltyTransaction,
		LoyaltyTransactionID,
		LoyaltyTransactionType1,
		LoyaltyUnit,
		MAC,
		MACAlgorithm,
		MaintenanceAllowed,
		MaintenanceRequiredFlag,
		Markup,
		MarkupSpecified,
		MaskCharactersFlag,
		MaskedMSISDN,
		MaskedPAN,
		MaxDecimalLength,
		MaximumCashBackAmount,
		MaximumCashBackAmountSpecified,
		MaximumTransmitTime,
		MaxInputTime,
		MaxLength,
		MaxWaitingTime,
		MenuBackFlag,
		MenuEntry,
		MenuEntryNumber,
		MenuEntryTag,
		MerchantCategoryCode,
		MerchantID,
		MerchantOverrideFlag,
		Message,
		MessageCategory,
		MessageClass,
		MessageHeader,
		MessageReference,
		MessageType,
		MinimumAmountToDeliver,
		MinimumAmountToDeliverSpecified,
		MinimumDisplayTime,
		MinimumSplitAmount,
		MinimumSplitAmountSpecified,
		MinLength,
		MobileCountryCode,
		MobileData,
		MobileNetworkCode,
		MSISDN,
		NotifyCardInputFlag,
		Number,
		OnlineFlag,
		OpenOrderState,
		Operator,
		OperatorID,
		OperatorLanguage,
		OriginalPOITransaction,
		OutputBarcode,
		OutputContent,
		OutputFormat,
		OutputResult,
		OutputSignature,
		OutputText,
		OutputXHTML,
		OwnerName,
		PaidAmount,
		PaidAmountSpecified,
		PAN,
		Parameter,
		Password,
		PaymentAccountRef,
		PaymentAccountReq,
		PaymentAccountStatus,
		PaymentAcquirerData,
		PaymentBrand,
		PaymentCurrency,
		PaymentData,
		PaymentInstrumentData,
		PaymentInstrumentType,
		PaymentReceipt,
		PaymentResult,
		PaymentToken,
		PaymentTotals,
		PaymentTransaction,
		PaymentType,
		PEDOKFlag,
		PEDOKFlagSpecified,
		PerformedTransaction,
		Period,
		PeriodUnit,
		PINEncAlgorithm,
		PINFormat,
		PINRequestType1,
		PINVerifMethod,
		PlanID,
		POICapabilities,
		POIData,
		POIID,
		POIProfile,
		POIReconciliationID,
		POISerialNumber,
		POISoftware,
		POIStatus,
		POISystemData,
		POITerminalData,
		POITransactionID,
		PredefinedContent,
		PrinterStatus,
		PrintOutput,
		ProductCode,
		ProductLabel,
		ProtectedCardData,
		ProtectedMobileData,
		ProtectedSignature,
		ProtocolVersion,
		ProviderIdentification,
		QRCodeBinaryValue,
		QRCodeEncodingMode,
		QRCodeEncodingModeSpecified,
		QRCodeErrorCorrection,
		QRCodeErrorCorrectionSpecified,
		QRCodeVersion,
		Quantity,
		QuantitySpecified,
		Rate,
		RateSpecified,
		RawSignature,
		RebateLabel,
		Rebates,
		ReceiptReprintFlag,
		RecipientIdentifier,
		ReconciliationType,
		ReferenceID,
		RegisteredIdentifier,
		RejectedMessage,
		RelativeDistinguishedName,
		RemoveAllFlag,
		RemoveAllFlagSpecified,
		RepeatedMessageResponse,
		ReportFullSize,
		RequestedAmount,
		RequestedAmountSpecified,
		RequestedValidityDate,
		RequiredSignatureFlag,
		Response,
		ResponseMode,
		ResponseRequiredFlag,
		Result,
		ReuseCardDataFlag,
		ReversalReason,
		ReversedAmount,
		ReversedAmountSpecified,
		SaleCapabilities,
		SaleChannel,
		SaleData,
		SaleID,
		SaleItem,
		SaleItemRebate,
		SaleProfile,
		SaleReferenceID,
		SaleSoftware,
		SaleTerminalData,
		SaleToAcquirerData,
		SaleToIssuerData,
		SaleToPOIData,
		SaleTransactionID,
		SearchAND,
		SearchCriterias,
		SearchOR,
		SearchOutputOrder,
		SecurityOKFlag,
		SecurityOKFlagSpecified,
		SecurityTrailer,
		SensitiveCardData,
		SensitiveMobileData,
		SequenceNumber,
		SerialNumber,
		ServiceID,
		ServiceIdentification,
		ServiceProfiles,
		ServicesEnabled,
		ShiftNumber,
		Signature,
		SignatureAlgorithm,
		SignatureImage,
		SignaturePoint,
		Signer,
		SignerIdentifier,
		SoftwareVersion,
		SoundAction,
		SoundContent,
		SoundFormat,
		SoundVolume,
		SplitPaymentFlag,
		SponsoredMerchant,
		StartColumn,
		StartDate,
		StartRow,
		StatementReference,
		StoredValueAccountID,
		StoredValueAccountStatus,
		StoredValueAccountType,
		StoredValueData,
		StoredValueProvider,
		StoredValueResult,
		StoredValueTransactionType,
		StringMask,
		Target,
		TaxCode,
		TerminalEnvironment,
		TextInput,
		TimeStamp,
		TipAmount,
		TipAmountSpecified,
		TokenRequestedType,
		TokenRequestStatus,
		TokenRequestStatusSpecified,
		TokenValue,
		TotalAmount,
		TotalAmountSpecified,
		TotalDetails,
		TotalFeesAmount,
		TotalFeesAmountSpecified,
		TotalFilter,
		TotalNbOfPayments,
		TotalRebate,
		TotalRebatesAmount,
		TotalRebatesAmountSpecified,
		TotalRebateSpecified,
		TotalsGroupID,
		TrackData,
		TrackFormat,
		TrackNumb,
		TrainingModeFlag,
		TransactionAction,
		TransactionAmount,
		TransactionConditions,
		TransactionCount,
		TransactionID,
		TransactionReport,
		TransactionToPerform,
		TransactionTotals,
		TransactionType,
		TypeCode,
		UnitOfMeasure,
		UnitPrice,
		UnitPriceSpecified,
		UnitValue,
		UTMCoordinates,
		UTMEastward,
		UTMNorthward,
		UTMZone,
		ValidityDate,
		Value,
		Version,
		WaitResponseFlag,
		WaitUserValidationFlag,
		WarmResetFlag,
		WarmResetFlagSpecified,
		X,
		Y,
	}
}
#endif
