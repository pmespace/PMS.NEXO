#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c0108e21-b883-4e3b-8fe1-830e772dfaa4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSendApplicationProtocolDataUnitCardReaderResponse1 : IDeviceSendApplicationProtocolDataUnitCardReaderResponse1 {
        private byte[] dataField = new byte[0];
        private byte[] cardStsField = new byte[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Data {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dataField == null)
                            || (this.dataField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dataField = new byte[0];
                }
                else {
                    this.dataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] CardSts {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.cardStsField == null)
                            || (this.cardStsField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cardStsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.cardStsField = new byte[0];
                }
                else {
                    this.cardStsField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((false
                            || (this.DataSize() != 0))
                            || (this.CardStsSize() != 0));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_Optimizing {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this._XSD_Optimizing;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this._XSD_Optimizing = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                // END ADDED BY XSD
            }
        }
        public int DataSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dataField == null)) {
                return 0;
            }
            else {
                return this.dataField.Length;
            }
            // END ADDED BY XSD
        }
        public byte DataGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.dataField.Length - 1)
                                >= index)) {
                        return this.dataField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool DataSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    this.dataField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DataAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.dataField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dataField.Length); i = (i + 1)) {
                        array[i] = dataField[i];
                    }
                    array[i] = value;
                    this.Data = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DataRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.dataField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.dataField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        for (i = (i + 1); (i < this.dataField.Length); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        this.Data = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int CardStsSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.cardStsField == null)) {
                return 0;
            }
            else {
                return this.cardStsField.Length;
            }
            // END ADDED BY XSD
        }
        public byte CardStsGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.cardStsField.Length - 1)
                                >= index)) {
                        return this.cardStsField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool CardStsSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    this.cardStsField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CardStsAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.cardStsField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cardStsField.Length); i = (i + 1)) {
                        array[i] = cardStsField[i];
                    }
                    array[i] = value;
                    this.CardSts = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CardStsRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.cardStsField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.cardStsField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cardStsField[i];
                        }
                        for (i = (i + 1); (i < this.cardStsField.Length); i = (i + 1)) {
                            array[i] = cardStsField[i];
                        }
                        this.CardSts = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("49595fc0-5820-42bd-a5d5-2b46cdcd0f86")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageStatusResponseV02 : ISaleToPOIMessageStatusResponseV02 {
        private Header41 hdrField = new Header41();
        private MessageStatusResponse3 stsRspnField = new MessageStatusResponse3();
        private ContentInformationType21 sctyTrlrField = new ContentInformationType21();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public Header41 Hdr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.hdrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.hdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.hdrField = new Header41();
                }
                else {
                    this.hdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public MessageStatusResponse3 StsRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.stsRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.stsRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.stsRspnField = new MessageStatusResponse3();
                }
                else {
                    this.stsRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType21 SctyTrlr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.sctyTrlrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.sctyTrlrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.sctyTrlrField = new ContentInformationType21();
                }
                else {
                    this.sctyTrlrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false
                            || ((this.Hdr != null)
                            && this.Hdr.XSD_HasBeenSet))
                            || ((this.StsRspn != null)
                            && this.StsRspn.XSD_HasBeenSet))
                            || ((this.SctyTrlr != null)
                            && this.SctyTrlr.XSD_HasBeenSet));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_Optimizing {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this._XSD_Optimizing;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this._XSD_Optimizing = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Hdr != null)) {
                    this.Hdr.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.StsRspn != null)) {
                    this.StsRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d6d57f15-d7e5-4981-84fa-00829e2d4add")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusResponse3 : IMessageStatusResponse3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private MessageStatusResponseData3 msgStsRspnDataField = new MessageStatusResponseData3();
        private ResponseType9 rspnField = new ResponseType9();
        private SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public CardPaymentEnvironment75 Envt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.envtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.envtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.envtField = new CardPaymentEnvironment75();
                }
                else {
                    this.envtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardPaymentContext28 Cntxt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.cntxtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cntxtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cntxtField = new CardPaymentContext28();
                }
                else {
                    this.cntxtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public MessageStatusResponseData3 MsgStsRspnData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.msgStsRspnDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgStsRspnDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.msgStsRspnDataField = new MessageStatusResponseData3();
                }
                else {
                    this.msgStsRspnDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rspnField = new ResponseType9();
                }
                else {
                    this.rspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public SupplementaryData1[] SplmtryData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.splmtryDataField == null)
                            || (this.splmtryDataField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.splmtryDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.splmtryDataField = new SupplementaryData1[0];
                }
                else {
                    this.splmtryDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.MsgStsRspnData != null)
                            && this.MsgStsRspnData.XSD_HasBeenSet))
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || (this.SplmtryDataSize() != 0));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_Optimizing {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this._XSD_Optimizing;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this._XSD_Optimizing = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Envt != null)) {
                    this.Envt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Cntxt != null)) {
                    this.Cntxt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.MsgStsRspnData != null)) {
                    this.MsgStsRspnData.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.SplmtryDataSize()); i = (i + 1)) {
                    this.SplmtryData[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SplmtryDataSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.splmtryDataField == null)) {
                return 0;
            }
            else {
                return this.splmtryDataField.Length;
            }
            // END ADDED BY XSD
        }
        public SupplementaryData1 SplmtryDataGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.splmtryDataField == default(SupplementaryData1[]))) {
                    return default(SupplementaryData1);
                }
                else {
                    if (((this.splmtryDataField.Length - 1)
                                >= index)) {
                        return this.splmtryDataField[index];
                    }
                    else {
                        return default(SupplementaryData1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(SupplementaryData1);
            }
            // END ADDED BY XSD
        }
        public bool SplmtryDataSetItem(int index, SupplementaryData1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.splmtryDataField == default(SupplementaryData1[]))) {
                    return false;
                }
                else {
                    this.splmtryDataField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SplmtryDataAddItem(SupplementaryData1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.splmtryDataField == default(SupplementaryData1[]))) {
                    return false;
                }
                else {
                    SupplementaryData1[] array = new SupplementaryData1[(this.splmtryDataField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.splmtryDataField.Length); i = (i + 1)) {
                        array[i] = splmtryDataField[i];
                    }
                    array[i] = value;
                    this.SplmtryData = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SplmtryDataRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.splmtryDataField == default(SupplementaryData1[]))) {
                    return false;
                }
                else {
                    if ((this.splmtryDataField.Length <= index)) {
                        return false;
                    }
                    else {
                        SupplementaryData1[] array = new SupplementaryData1[(this.splmtryDataField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = splmtryDataField[i];
                        }
                        for (i = (i + 1); (i < this.splmtryDataField.Length); i = (i + 1)) {
                            array[i] = splmtryDataField[i];
                        }
                        this.SplmtryData = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ac6f12c0-fd61-4216-938b-b5ebb69b77cb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusResponseData3 : IMessageStatusResponseData3 {
        private string xchgIdField = default(string);
        private GenericIdentification177 initgPtyField = new GenericIdentification177();
        private ResponseType9 txRspnField = new ResponseType9();
        private LoyaltyResponse2 rpeatdLltyRspnField = new LoyaltyResponse2();
        private PaymentResponse2 rpeatdPmtRspnField = new PaymentResponse2();
        private ReversalResponse3 rpeatdRvslRspnField = new ReversalResponse3();
        private StoredValueResponse3 rpeatdStordValRspnField = new StoredValueResponse3();
        private CardAcquisitionResponse2 rpeatdCardAcqstnRspnField = new CardAcquisitionResponse2();
        private DeviceSendApplicationProtocolDataUnitCardReaderResponse1 rpeatdSndApplPrtcolDataUnitCardRdrRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
        private bool xchgIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xchgIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.xchgIdField_XSD_HasBeenSet = (this.xchgIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public GenericIdentification177 InitgPty {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.initgPtyField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.initgPtyField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.initgPtyField = new GenericIdentification177();
                }
                else {
                    this.initgPtyField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ResponseType9 TxRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.txRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.txRspnField = new ResponseType9();
                }
                else {
                    this.txRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyResponse2 RpeatdLltyRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdLltyRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdLltyRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdLltyRspnField = new LoyaltyResponse2();
                }
                else {
                    this.rpeatdLltyRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public PaymentResponse2 RpeatdPmtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdPmtRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdPmtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdPmtRspnField = new PaymentResponse2();
                }
                else {
                    this.rpeatdPmtRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ReversalResponse3 RpeatdRvslRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdRvslRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdRvslRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdRvslRspnField = new ReversalResponse3();
                }
                else {
                    this.rpeatdRvslRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public StoredValueResponse3 RpeatdStordValRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdStordValRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdStordValRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdStordValRspnField = new StoredValueResponse3();
                }
                else {
                    this.rpeatdStordValRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardAcquisitionResponse2 RpeatdCardAcqstnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdCardAcqstnRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdCardAcqstnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdCardAcqstnRspnField = new CardAcquisitionResponse2();
                }
                else {
                    this.rpeatdCardAcqstnRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
                }
                else {
                    this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((false
                            || ((this.InitgPty != null)
                            && this.InitgPty.XSD_HasBeenSet))
                            || ((this.TxRspn != null)
                            && this.TxRspn.XSD_HasBeenSet))
                            || ((this.RpeatdLltyRspn != null)
                            && this.RpeatdLltyRspn.XSD_HasBeenSet))
                            || ((this.RpeatdPmtRspn != null)
                            && this.RpeatdPmtRspn.XSD_HasBeenSet))
                            || ((this.RpeatdRvslRspn != null)
                            && this.RpeatdRvslRspn.XSD_HasBeenSet))
                            || ((this.RpeatdStordValRspn != null)
                            && this.RpeatdStordValRspn.XSD_HasBeenSet))
                            || ((this.RpeatdCardAcqstnRspn != null)
                            && this.RpeatdCardAcqstnRspn.XSD_HasBeenSet))
                            || ((this.RpeatdSndApplPrtcolDataUnitCardRdrRspn != null)
                            && this.RpeatdSndApplPrtcolDataUnitCardRdrRspn.XSD_HasBeenSet))
                            || this.xchgIdField_XSD_HasBeenSet);
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_Optimizing {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this._XSD_Optimizing;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this._XSD_Optimizing = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.InitgPty != null)) {
                    this.InitgPty.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.TxRspn != null)) {
                    this.TxRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdLltyRspn != null)) {
                    this.RpeatdLltyRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdPmtRspn != null)) {
                    this.RpeatdPmtRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdRvslRspn != null)) {
                    this.RpeatdRvslRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdStordValRspn != null)) {
                    this.RpeatdStordValRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdCardAcqstnRspn != null)) {
                    this.RpeatdCardAcqstnRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RpeatdSndApplPrtcolDataUnitCardRdrRspn != null)) {
                    this.RpeatdSndApplPrtcolDataUnitCardRdrRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("338ba489-7de3-4ab2-8262-32258e7fe5ed")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSendApplicationProtocolDataUnitCardReaderResponse1 {
        /// <remarks/>
        [DispId(1)]
        byte[] Data {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        byte[] CardSts {
            get;
            set;
        }
        [DispId(3)]
        int DataSize();
        [DispId(4)]
        byte DataGetItem(int index);
        [DispId(5)]
        bool DataSetItem(int index, byte value);
        [DispId(6)]
        bool DataAddItem(byte value);
        [DispId(7)]
        bool DataRemoveItem(int index);
        [DispId(8)]
        int CardStsSize();
        [DispId(9)]
        byte CardStsGetItem(int index);
        [DispId(10)]
        bool CardStsSetItem(int index, byte value);
        [DispId(11)]
        bool CardStsAddItem(byte value);
        [DispId(12)]
        bool CardStsRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("ff5b95ba-e86f-4c7c-9fe8-d1419bdb7ce7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIMessageStatusResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        MessageStatusResponse3 StsRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ContentInformationType21 SctyTrlr {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ac213c27-7233-4b20-984b-f6941d29484a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusResponse3 {
        /// <remarks/>
        [DispId(1)]
        CardPaymentEnvironment75 Envt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentContext28 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        MessageStatusResponseData3 MsgStsRspnData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        SupplementaryData1[] SplmtryData {
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
    [System.Runtime.InteropServices.GuidAttribute("8f2df7f4-796a-4cb2-add1-d3f6a67574a5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusResponseData3 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        GenericIdentification177 InitgPty {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ResponseType9 TxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        LoyaltyResponse2 RpeatdLltyRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        PaymentResponse2 RpeatdPmtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        ReversalResponse3 RpeatdRvslRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        StoredValueResponse3 RpeatdStordValRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        CardAcquisitionResponse2 RpeatdCardAcqstnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn {
            get;
            set;
        }
    }
}
#endif
