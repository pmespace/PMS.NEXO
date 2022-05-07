#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bf1cefdf-4517-4460-b3cd-190bf8cf8022")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayResponse1 : IDeviceDisplayResponse1 {
        private OutputResult1[] outptRsltField = new OutputResult1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutptRslt")]
        public OutputResult1[] OutptRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.outptRsltField == null)
                            || (this.outptRsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.outptRsltField = new OutputResult1[0];
                }
                else {
                    this.outptRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (false
                            || (this.OutptRsltSize() != 0));
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
                int i = 0;
                for (i = 0; (i < this.OutptRsltSize()); i = (i + 1)) {
                    this.OutptRslt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int OutptRsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.outptRsltField == null)) {
                return 0;
            }
            else {
                return this.outptRsltField.Length;
            }
            // END ADDED BY XSD
        }
        public OutputResult1 OutptRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return default(OutputResult1);
                }
                else {
                    if (((this.outptRsltField.Length - 1)
                                >= index)) {
                        return this.outptRsltField[index];
                    }
                    else {
                        return default(OutputResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(OutputResult1);
            }
            // END ADDED BY XSD
        }
        public bool OutptRsltSetItem(int index, OutputResult1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    this.outptRsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool OutptRsltAddItem(OutputResult1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    OutputResult1[] array = new OutputResult1[(this.outptRsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.outptRsltField.Length); i = (i + 1)) {
                        array[i] = outptRsltField[i];
                    }
                    array[i] = value;
                    this.OutptRslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool OutptRsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    if ((this.outptRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        OutputResult1[] array = new OutputResult1[(this.outptRsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = outptRsltField[i];
                        }
                        for (i = (i + 1); (i < this.outptRsltField.Length); i = (i + 1)) {
                            array[i] = outptRsltField[i];
                        }
                        this.OutptRslt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7d70e99c-3d91-475e-94b6-c98e6d8cc74c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OutputResult1 : IOutputResult1 {
        private UserInterface4Code dvcTpField = default(UserInterface4Code);
        private InformationQualify1Code infQlfrField = default(InformationQualify1Code);
        private ResponseType9 rspnField = new ResponseType9();
        private bool dvcTpField_XSD_HasBeenSet = false;
        private bool infQlfrField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public UserInterface4Code DvcTp {
            get {
                return this.dvcTpField;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || this.dvcTpField_XSD_HasBeenSet)
                            || this.infQlfrField_XSD_HasBeenSet);
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
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("271f56e9-6307-4331-8b4a-4ab567e73061")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderResponse2 : IDeviceInitialisationCardReaderResponse2 {
        private CardDataReading8Code cardNtryMdField = default(CardDataReading8Code);
        private bool cardNtryMdFieldSpecified = false;
        private ICCResetData1 iCCRstDataField = new ICCResetData1();
        private byte[] addtlInfField = new byte[0];
        private bool cardNtryMdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public CardDataReading8Code CardNtryMd {
            get {
                return this.cardNtryMdField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool CardNtryMdSpecified {
            get {
                return this.cardNtryMdFieldSpecified;
            }
            set {
                this.cardNtryMdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ICCResetData1 ICCRstData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.iCCRstDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.iCCRstDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.iCCRstDataField = new ICCResetData1();
                }
                else {
                    this.iCCRstDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] AddtlInf {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.addtlInfField == null)
                            || (this.addtlInfField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.addtlInfField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.addtlInfField = new byte[0];
                }
                else {
                    this.addtlInfField = value;
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
                            || ((this.ICCRstData != null)
                            && this.ICCRstData.XSD_HasBeenSet))
                            || (this.AddtlInfSize() != 0))
                            || this.cardNtryMdField_XSD_HasBeenSet);
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
                if ((this.ICCRstData != null)) {
                    this.ICCRstData.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int AddtlInfSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.addtlInfField == null)) {
                return 0;
            }
            else {
                return this.addtlInfField.Length;
            }
            // END ADDED BY XSD
        }
        public byte AddtlInfGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.addtlInfField.Length - 1)
                                >= index)) {
                        return this.addtlInfField[index];
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
        public bool AddtlInfSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    this.addtlInfField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlInfAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.addtlInfField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.addtlInfField.Length); i = (i + 1)) {
                        array[i] = addtlInfField[i];
                    }
                    array[i] = value;
                    this.AddtlInf = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlInfRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.addtlInfField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.addtlInfField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = addtlInfField[i];
                        }
                        for (i = (i + 1); (i < this.addtlInfField.Length); i = (i + 1)) {
                            array[i] = addtlInfField[i];
                        }
                        this.AddtlInf = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("37ff6258-f2cd-4895-8019-813dd572cad0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ICCResetData1 : IICCResetData1 {
        private byte[] aTRValField = new byte[0];
        private byte[] cardStsField = new byte[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ATRVal {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.aTRValField == null)
                            || (this.aTRValField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.aTRValField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.aTRValField = new byte[0];
                }
                else {
                    this.aTRValField = value;
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
                            || (this.ATRValSize() != 0))
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
        public int ATRValSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.aTRValField == null)) {
                return 0;
            }
            else {
                return this.aTRValField.Length;
            }
            // END ADDED BY XSD
        }
        public byte ATRValGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.aTRValField.Length - 1)
                                >= index)) {
                        return this.aTRValField[index];
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
        public bool ATRValSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    this.aTRValField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ATRValAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.aTRValField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.aTRValField.Length); i = (i + 1)) {
                        array[i] = aTRValField[i];
                    }
                    array[i] = value;
                    this.ATRVal = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ATRValRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.aTRValField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.aTRValField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = aTRValField[i];
                        }
                        for (i = (i + 1); (i < this.aTRValField.Length); i = (i + 1)) {
                            array[i] = aTRValField[i];
                        }
                        this.ATRVal = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c35b6370-2be4-4e26-9742-5eb5d393e668")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputResponse2 : IDeviceInputResponse2 {
        private OutputResult1 outptRsltField = new OutputResult1();
        private InputResult2 inptRsltField = new InputResult2();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public OutputResult1 OutptRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.outptRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptRsltField = new OutputResult1();
                }
                else {
                    this.outptRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public InputResult2 InptRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRsltField = new InputResult2();
                }
                else {
                    this.inptRsltField = value;
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
                            || ((this.OutptRslt != null)
                            && this.OutptRslt.XSD_HasBeenSet))
                            || ((this.InptRslt != null)
                            && this.InptRslt.XSD_HasBeenSet));
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
                if ((this.OutptRslt != null)) {
                    this.OutptRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.InptRslt != null)) {
                    this.InptRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2b0b9ef0-40a9-4159-aca6-245a47ad588c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResult2 : IInputResult2 {
        private SaleCapabilities2Code dvcTpField = default(SaleCapabilities2Code);
        private InformationQualify1Code infQlfrField = default(InformationQualify1Code);
        private InputResultData2 inptRsltDataField = new InputResultData2();
        private bool dvcTpField_XSD_HasBeenSet = false;
        private bool infQlfrField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
        }
        /// <remarks/>
        public InputResultData2 InptRsltData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptRsltDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRsltDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRsltDataField = new InputResultData2();
                }
                else {
                    this.inptRsltDataField = value;
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
                            || ((this.InptRsltData != null)
                            && this.InptRsltData.XSD_HasBeenSet))
                            || this.dvcTpField_XSD_HasBeenSet)
                            || this.infQlfrField_XSD_HasBeenSet);
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
                if ((this.InptRsltData != null)) {
                    this.InptRsltData.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c01c511f-f390-4d8c-97ea-f7c0060315f7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResultData2 : IInputResultData2 {
        private InputCommand1Code inptCmdField = default(InputCommand1Code);
        private bool confdFlgField = default(bool);
        private bool confdFlgFieldSpecified = false;
        private double fctnKeyField = default(double);
        private bool fctnKeyFieldSpecified = false;
        private string inptMsgField = default(string);
        private ContentInformationType23 pwdField = new ContentInformationType23();
        private CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        private bool inptCmdField_XSD_HasBeenSet = false;
        private bool confdFlgField_XSD_HasBeenSet = false;
        private bool fctnKeyField_XSD_HasBeenSet = false;
        private bool inptMsgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
        }
        /// <remarks/>
        public bool ConfdFlg {
            get {
                return this.confdFlgField;
            }
            set {
                this.confdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - ConfdFlgSpecified = true
                this.ConfdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool ConfdFlgSpecified {
            get {
                return this.confdFlgFieldSpecified;
            }
            set {
                this.confdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double FctnKey {
            get {
                return this.fctnKeyField;
            }
            set {
                this.fctnKeyField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - FctnKeySpecified = true
                this.FctnKeySpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool FctnKeySpecified {
            get {
                return this.fctnKeyFieldSpecified;
            }
            set {
                this.fctnKeyFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string InptMsg {
            get {
                return this.inptMsgField;
            }
            set {
                this.inptMsgField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.inptMsgField_XSD_HasBeenSet = (this.inptMsgField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType23 Pwd {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pwdField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pwdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pwdField = new ContentInformationType23();
                }
                else {
                    this.pwdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CapturedSignature1 ImgCaptrdSgntr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.imgCaptrdSgntrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.imgCaptrdSgntrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.imgCaptrdSgntrField = new CapturedSignature1();
                }
                else {
                    this.imgCaptrdSgntrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((((false
                            || ((this.Pwd != null)
                            && this.Pwd.XSD_HasBeenSet))
                            || ((this.ImgCaptrdSgntr != null)
                            && this.ImgCaptrdSgntr.XSD_HasBeenSet))
                            || this.inptCmdField_XSD_HasBeenSet)
                            || this.confdFlgField_XSD_HasBeenSet)
                            || this.fctnKeyField_XSD_HasBeenSet)
                            || this.inptMsgField_XSD_HasBeenSet)
                            || this.ConfdFlgSpecified)
                            || this.FctnKeySpecified);
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
                if ((this.Pwd != null)) {
                    this.Pwd.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.ImgCaptrdSgntr != null)) {
                    this.ImgCaptrdSgntr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ec64da47-5933-4ddf-ad82-156e21b0ea51")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintResponse1 : IDevicePrintResponse1 {
        private DocumentType7Code docQlfrField = default(DocumentType7Code);
        private bool docQlfrField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (false || this.docQlfrField_XSD_HasBeenSet);
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("0987ccc6-6f64-467c-8cc8-f9eae4c243d8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceResponse3 : IDeviceResponse3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService9Code svcCnttField = default(RetailerService9Code);
        private OutputResult1[] dispRspnField = new OutputResult1[0];
        private DeviceInputResponse2 inptRspnField = new DeviceInputResponse2();
        private DevicePrintResponse1 prtRspnField = new DevicePrintResponse1();
        private DeviceSecureInputResponse2 scrInptRspnField = new DeviceSecureInputResponse2();
        private DeviceInitialisationCardReaderResponse2 initlstnCardRdrRspnField = new DeviceInitialisationCardReaderResponse2();
        private DeviceSendApplicationProtocolDataUnitCardReaderResponse1 cardRdrApplPrtcolDataUnitRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
        private DeviceTransmitMessageResponse1 trnsmssnRspnField = new DeviceTransmitMessageResponse1();
        private ResponseType9 rspnField = new ResponseType9();
        private SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        private bool svcCnttField_XSD_HasBeenSet = false;
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
        public RetailerService9Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutptRslt", IsNullable=false)]
        public OutputResult1[] DispRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dispRspnField == null)
                            || (this.dispRspnField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dispRspnField = new OutputResult1[0];
                }
                else {
                    this.dispRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInputResponse2 InptRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRspnField = new DeviceInputResponse2();
                }
                else {
                    this.inptRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DevicePrintResponse1 PrtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.prtRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtRspnField = new DevicePrintResponse1();
                }
                else {
                    this.prtRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceSecureInputResponse2 ScrInptRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.scrInptRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.scrInptRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.scrInptRspnField = new DeviceSecureInputResponse2();
                }
                else {
                    this.scrInptRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderResponse2 InitlstnCardRdrRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.initlstnCardRdrRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.initlstnCardRdrRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.initlstnCardRdrRspnField = new DeviceInitialisationCardReaderResponse2();
                }
                else {
                    this.initlstnCardRdrRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderResponse1 CardRdrApplPrtcolDataUnitRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.cardRdrApplPrtcolDataUnitRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cardRdrApplPrtcolDataUnitRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cardRdrApplPrtcolDataUnitRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
                }
                else {
                    this.cardRdrApplPrtcolDataUnitRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceTransmitMessageResponse1 TrnsmssnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.trnsmssnRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.trnsmssnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.trnsmssnRspnField = new DeviceTransmitMessageResponse1();
                }
                else {
                    this.trnsmssnRspnField = value;
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
                return ((((((((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.InptRspn != null)
                            && this.InptRspn.XSD_HasBeenSet))
                            || ((this.PrtRspn != null)
                            && this.PrtRspn.XSD_HasBeenSet))
                            || ((this.ScrInptRspn != null)
                            && this.ScrInptRspn.XSD_HasBeenSet))
                            || ((this.InitlstnCardRdrRspn != null)
                            && this.InitlstnCardRdrRspn.XSD_HasBeenSet))
                            || ((this.CardRdrApplPrtcolDataUnitRspn != null)
                            && this.CardRdrApplPrtcolDataUnitRspn.XSD_HasBeenSet))
                            || ((this.TrnsmssnRspn != null)
                            && this.TrnsmssnRspn.XSD_HasBeenSet))
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || (this.DispRspnSize() != 0))
                            || (this.SplmtryDataSize() != 0))
                            || this.svcCnttField_XSD_HasBeenSet);
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
                if ((this.InptRspn != null)) {
                    this.InptRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PrtRspn != null)) {
                    this.PrtRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.ScrInptRspn != null)) {
                    this.ScrInptRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.InitlstnCardRdrRspn != null)) {
                    this.InitlstnCardRdrRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.CardRdrApplPrtcolDataUnitRspn != null)) {
                    this.CardRdrApplPrtcolDataUnitRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.TrnsmssnRspn != null)) {
                    this.TrnsmssnRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.DispRspnSize()); i = (i + 1)) {
                    this.DispRspn[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.SplmtryDataSize()); i = (i + 1)) {
                    this.SplmtryData[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int DispRspnSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dispRspnField == null)) {
                return 0;
            }
            else {
                return this.dispRspnField.Length;
            }
            // END ADDED BY XSD
        }
        public OutputResult1 DispRspnGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return default(OutputResult1);
                }
                else {
                    if (((this.dispRspnField.Length - 1)
                                >= index)) {
                        return this.dispRspnField[index];
                    }
                    else {
                        return default(OutputResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(OutputResult1);
            }
            // END ADDED BY XSD
        }
        public bool DispRspnSetItem(int index, OutputResult1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    this.dispRspnField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispRspnAddItem(OutputResult1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    OutputResult1[] array = new OutputResult1[(this.dispRspnField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dispRspnField.Length); i = (i + 1)) {
                        array[i] = dispRspnField[i];
                    }
                    array[i] = value;
                    this.DispRspn = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispRspnRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    if ((this.dispRspnField.Length <= index)) {
                        return false;
                    }
                    else {
                        OutputResult1[] array = new OutputResult1[(this.dispRspnField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dispRspnField[i];
                        }
                        for (i = (i + 1); (i < this.dispRspnField.Length); i = (i + 1)) {
                            array[i] = dispRspnField[i];
                        }
                        this.DispRspn = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService9Code {
        _begin,
        _none,
        /// <remarks/>
        DDYP,
        /// <remarks/>
        DINP,
        /// <remarks/>
        DPRP,
        /// <remarks/>
        DSOP,
        /// <remarks/>
        DSIP,
        /// <remarks/>
        DCIP,
        /// <remarks/>
        DCAP,
        /// <remarks/>
        DCPP,
        /// <remarks/>
        DCOP,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f76c0240-7169-4d46-8419-f36ac23ff197")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputResponse2 : IDeviceSecureInputResponse2 {
        private OnLinePIN7 crdhldrPINField = new OnLinePIN7();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public OnLinePIN7 CrdhldrPIN {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.crdhldrPINField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.crdhldrPINField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.crdhldrPINField = new OnLinePIN7();
                }
                else {
                    this.crdhldrPINField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (false
                            || ((this.CrdhldrPIN != null)
                            && this.CrdhldrPIN.XSD_HasBeenSet));
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
                if ((this.CrdhldrPIN != null)) {
                    this.CrdhldrPIN.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ad557122-e8fd-48c8-8a92-0c27abd6e321")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageResponse1 : IDeviceTransmitMessageResponse1 {
        private byte[] rcvdMsgField = new byte[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] RcvdMsg {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rcvdMsgField == null)
                            || (this.rcvdMsgField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rcvdMsgField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rcvdMsgField = new byte[0];
                }
                else {
                    this.rcvdMsgField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (false
                            || (this.RcvdMsgSize() != 0));
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
        public int RcvdMsgSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rcvdMsgField == null)) {
                return 0;
            }
            else {
                return this.rcvdMsgField.Length;
            }
            // END ADDED BY XSD
        }
        public byte RcvdMsgGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.rcvdMsgField.Length - 1)
                                >= index)) {
                        return this.rcvdMsgField[index];
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
        public bool RcvdMsgSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    this.rcvdMsgField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RcvdMsgAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.rcvdMsgField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rcvdMsgField.Length); i = (i + 1)) {
                        array[i] = rcvdMsgField[i];
                    }
                    array[i] = value;
                    this.RcvdMsg = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RcvdMsgRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.rcvdMsgField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.rcvdMsgField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rcvdMsgField[i];
                        }
                        for (i = (i + 1); (i < this.rcvdMsgField.Length); i = (i + 1)) {
                            array[i] = rcvdMsgField[i];
                        }
                        this.RcvdMsg = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2ed8f589-a027-4a64-9b69-382d373447a3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceResponseV02 : ISaleToPOIDeviceResponseV02 {
        private Header41 hdrField = new Header41();
        private DeviceResponse3 dvcRspnField = new DeviceResponse3();
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
        public DeviceResponse3 DvcRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dvcRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dvcRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dvcRspnField = new DeviceResponse3();
                }
                else {
                    this.dvcRspnField = value;
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
                            || ((this.DvcRspn != null)
                            && this.DvcRspn.XSD_HasBeenSet))
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
                if ((this.DvcRspn != null)) {
                    this.DvcRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6a1a66ef-f347-41d1-ad75-8ca107c9dfb9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceDisplayResponse1 {
        /// <remarks/>
        [DispId(1)]
        OutputResult1[] OutptRslt {
            get;
            set;
        }
        [DispId(2)]
        int OutptRsltSize();
        [DispId(3)]
        OutputResult1 OutptRsltGetItem(int index);
        [DispId(4)]
        bool OutptRsltSetItem(int index, OutputResult1 value);
        [DispId(5)]
        bool OutptRsltAddItem(OutputResult1 value);
        [DispId(6)]
        bool OutptRsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("8ae95948-3711-43f9-8db4-b641eb8fb110")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IOutputResult1 {
        /// <remarks/>
        [DispId(1)]
        UserInterface4Code DvcTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        ResponseType9 Rspn {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("61f9efa6-baed-437f-bd1e-f5f2643f42da")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInitialisationCardReaderResponse2 {
        /// <remarks/>
        [DispId(1)]
        CardDataReading8Code CardNtryMd {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        bool CardNtryMdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ICCResetData1 ICCRstData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        byte[] AddtlInf {
            get;
            set;
        }
        [DispId(5)]
        int AddtlInfSize();
        [DispId(6)]
        byte AddtlInfGetItem(int index);
        [DispId(7)]
        bool AddtlInfSetItem(int index, byte value);
        [DispId(8)]
        bool AddtlInfAddItem(byte value);
        [DispId(9)]
        bool AddtlInfRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("9e4ffcde-fc5b-43e4-93f1-10330da730b5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IICCResetData1 {
        /// <remarks/>
        [DispId(1)]
        byte[] ATRVal {
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
        int ATRValSize();
        [DispId(4)]
        byte ATRValGetItem(int index);
        [DispId(5)]
        bool ATRValSetItem(int index, byte value);
        [DispId(6)]
        bool ATRValAddItem(byte value);
        [DispId(7)]
        bool ATRValRemoveItem(int index);
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
    [System.Runtime.InteropServices.GuidAttribute("9b38827e-d61b-47d3-8a77-6bd2fb55589f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputResponse2 {
        /// <remarks/>
        [DispId(1)]
        OutputResult1 OutptRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InputResult2 InptRslt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("47842b27-67a4-47ca-b099-70948bfbfd0e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResult2 {
        /// <remarks/>
        [DispId(1)]
        SaleCapabilities2Code DvcTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        InputResultData2 InptRsltData {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("573f197e-4e97-4fb4-a44d-e42fbdb152ed")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResultData2 {
        /// <remarks/>
        [DispId(1)]
        InputCommand1Code InptCmd {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        bool ConfdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool ConfdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        double FctnKey {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool FctnKeySpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        string InptMsg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ContentInformationType23 Pwd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        CapturedSignature1 ImgCaptrdSgntr {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("c10c78c7-a38c-466d-ac26-bd114cb01e82")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePrintResponse1 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("cab8c885-e394-4516-b560-9430693782fa")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceResponse3 {
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
        RetailerService9Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        OutputResult1[] DispRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        DeviceInputResponse2 InptRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        DevicePrintResponse1 PrtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        DeviceSecureInputResponse2 ScrInptRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        DeviceInitialisationCardReaderResponse2 InitlstnCardRdrRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceSendApplicationProtocolDataUnitCardReaderResponse1 CardRdrApplPrtcolDataUnitRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        DeviceTransmitMessageResponse1 TrnsmssnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(13)]
        int DispRspnSize();
        [DispId(14)]
        OutputResult1 DispRspnGetItem(int index);
        [DispId(15)]
        bool DispRspnSetItem(int index, OutputResult1 value);
        [DispId(16)]
        bool DispRspnAddItem(OutputResult1 value);
        [DispId(17)]
        bool DispRspnRemoveItem(int index);
        [DispId(18)]
        int SplmtryDataSize();
        [DispId(19)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(20)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(21)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(22)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("42da9b6f-8893-4161-8c52-ee1fc2a695b2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSecureInputResponse2 {
        /// <remarks/>
        [DispId(1)]
        OnLinePIN7 CrdhldrPIN {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("35140967-dcd2-4787-a603-37046122973f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceTransmitMessageResponse1 {
        /// <remarks/>
        [DispId(1)]
        byte[] RcvdMsg {
            get;
            set;
        }
        [DispId(2)]
        int RcvdMsgSize();
        [DispId(3)]
        byte RcvdMsgGetItem(int index);
        [DispId(4)]
        bool RcvdMsgSetItem(int index, byte value);
        [DispId(5)]
        bool RcvdMsgAddItem(byte value);
        [DispId(6)]
        bool RcvdMsgRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("04a3bf0a-e5a5-4213-8826-d44a3a316411")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIDeviceResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        DeviceResponse3 DvcRspn {
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
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TagsEnumeration {
        AbortReason,
        Abrt,
        AbrtRsn,
        AccessedBy,
        AccountNumber,
        AccountType,
        AccptdByCrdhldr,
        AccptdByCrdhldrSpecified,
        AccsCd,
        AccsdBy,
        Acct,
        AcctId,
        AcctNb,
        AcctRef,
        AcctTp,
        AcctTpSpecified,
        Acqrr,
        AcqrrId,
        AcquirerID,
        AcquirerPOIID,
        AcquirerTransactionID,
        ActlAmt,
        ActlAmtSpecified,
        Actn,
        ActnId,
        ActnTp,
        Actv,
        ActvtnDt,
        ActvtnDtSpecified,
        AdditionalInformation,
        AdditionalInput,
        AdditionalProductInfo,
        AdditionalResponse,
        AddtlAvlblPdct,
        AddtlCardData,
        AddtlCtctInf,
        AddtlErrInf,
        AddtlEvtInf,
        AddtlId,
        AddtlInf,
        AddtlInpt,
        AddtlMgmtInf,
        AddtlParams,
        AddtlPdctCd,
        AddtlPdctDesc,
        AddtlRslt,
        AddtlRspnInf,
        AddtlSaleData,
        AddtlSvc,
        AddtlTxData,
        AddtlVhclData,
        AdmstvReq,
        AdmstvRspn,
        AdmstvSvcId,
        Adr,
        AdrDgts,
        AdrLine,
        AdrTp,
        AdrTpSpecified,
        AdrVal,
        AdrVrfctn,
        AggtnTx,
        Algo,
        Algorithm,
        Alignment,
        AllowedLoyaltyBrand,
        AllowedPaymentBrand,
        AllowedProduct,
        AllowedProductCode,
        AllwdLltyBrnd,
        AllwdNtryMd,
        AllwdPdct,
        AllwdPdctCd,
        AllwdPmtBrnd,
        AlnRegnNb,
        AlphaCd,
        AmountsReq,
        AmountsResp,
        Amt,
        AmtGoodsAndSvcs,
        AmtGoodsAndSvcsSpecified,
        AmtLmt,
        AmtLmtSpecified,
        AmtQlfr,
        AmtQlfrSpecified,
        APDUClass,
        APDUData,
        APDUExpectedLength,
        APDUInstruction,
        APDUPar1,
        APDUPar2,
        ApplicationName,
        ApprovalCode,
        ApprvlCd,
        ApprvlCdLngth,
        ApprvlCdLngthSpecified,
        AreaSize,
        Assgnr,
        Assmnt,
        ATRVal,
        ATRValue,
        AttndncCntxt,
        AttndncCntxtSpecified,
        AttndntLang,
        AttndntMsgCpbl,
        AttndntMsgCpblSpecified,
        AttributeType,
        AttributeValue,
        AttrTp,
        AttrVal,
        AuthenticationMethod,
        AuthntcdData,
        Authntcn,
        AuthntcnAddtlInf,
        AuthntcnLvl,
        AuthntcnMtd,
        AuthntcnMtdSpecified,
        AuthntcnRslt,
        AuthntcnRsltSpecified,
        AuthntcnTp,
        AuthntcnVal,
        AuthntcnXmptn,
        AuthntcnXmptnSpecified,
        AuthorizedAmount,
        AuthrsdAmt,
        AuthrsdAmtSpecified,
        AuthstnCd,
        AuthstnNtty,
        AuthstnRslt,
        AvlblFrmt,
        AvlblLang,
        Bal,
        BalNqryReq,
        BalNqryRspn,
        BalSpecified,
        BankID,
        BarcodeType,
        BeepKeyFlag,
        BeepKeyFlg,
        BeepKeyFlgSpecified,
        BirthDt,
        BkId,
        BlckStart,
        BlckStartSpecified,
        BlckStop,
        BlckStopSpecified,
        BldgNb,
        BllgAdr,
        BPddg,
        BPddgSpecified,
        BrcdTp,
        BrcdVal,
        Brnd,
        BtchReq,
        BtchRspn,
        CapturedSignature,
        Card,
        CardAcqstnReq,
        CardAcqstnRspn,
        CardAcquisitionReference,
        CardAcquisitionTransaction,
        CardBrand,
        CardBrnd,
        CardCaptrCpbl,
        CardCaptrCpblSpecified,
        CardCcyCd,
        CardCountryCode,
        CardCtryCd,
        CardData,
        CardDataNtryMd,
        CardDataNtryMdSpecified,
        CardholderPIN,
        CardNtryMd,
        CardNtryMdSpecified,
        CardPdctPrfl,
        CardPdctSubTp,
        CardPdctTp,
        CardPdctTpSpecified,
        CardPres,
        CardPresSpecified,
        CardPrgrmmApld,
        CardPrgrmmPropsd,
        CardRdngCpblties,
        CardRdrAPDUReq,
        CardRdrApplPrtcolDataUnitRspn,
        CardReaderOKFlag,
        CardReaderOKFlagSpecified,
        CardSeqNb,
        CardSeqNumb,
        CardStatusWords,
        CardSts,
        CashBackAmount,
        CashBackAmountSpecified,
        CashBackFlag,
        CashBackFlagSpecified,
        CashHandlingDevice,
        CashHandlingOKFlag,
        Ccy,
        CcyConvs,
        CcyConvsElgblty,
        CcyConvsId,
        CcyConvsRslt,
        Cdtr,
        CdtrId,
        Cert,
        Certificate,
        CertificationCode,
        CharacterHeight,
        CharacterSet,
        CharacterStyle,
        CharacterWidth,
        Charges,
        ChargesSpecified,
        Chck,
        ChckCardNb,
        ChckNb,
        ChckTp,
        ChckTpSpecified,
        ChckTrckData2,
        CheckCardNumber,
        CheckData,
        CheckNumber,
        Chrgs,
        ChrgsSpecified,
        Chrtcs,
        CityOfBirth,
        ClntCert,
        Clss,
        CmltvAmt,
        CmltvAmtSpecified,
        CmonNm,
        CmpltnReqrd,
        CmpltnReqrdSpecified,
        Cmpnt,
        CmpntId,
        Cntt,
        CnttNcrptnAlgo,
        CnttTp,
        Cntxt,
        CoinsOrBills,
        Color,
        Com,
        Commission,
        CommissionSpecified,
        CommunicationOKFlag,
        CommunicationOKFlagSpecified,
        ComssnDtls,
        ComTp,
        ConfdFlg,
        ConfdFlgSpecified,
        ConfirmedFlag,
        ConfirmedFlagSpecified,
        Content,
        ContentEncryptionAlgorithm,
        ContentType,
        ConvertedAmount,
        Convs,
        ConvsDtls,
        Country,
        Cpblties,
        Crdhldr,
        CrdhldrId,
        CrdhldrNm,
        CrdhldrOnLinePIN,
        CrdhldrPIN,
        CrdhldrPres,
        CrdhldrPresSpecified,
        CrdhldrVrfctnCpblties,
        CreDtTm,
        CreDtTmSpecified,
        CritOrdr,
        CshBck,
        CshBckFlg,
        CshBckFlgSpecified,
        CshBckSpecified,
        CshrId,
        CshrLang,
        CstmrCnsnt,
        CstmrCnsntSpecified,
        CstmrDvc,
        CstmrLang,
        CstmrNb,
        CstmrOrdr,
        CstmrOrdrId,
        CstmrOrdrReq,
        CstmrOrdrReqFlg,
        CstmrOrdrReqFlgSpecified,
        CstmrOrdrReqSpecified,
        CstmrSvc,
        CstmrTkn,
        Ctry,
        CtryCd,
        CtryOfBirth,
        CtrySubDvsn,
        CumulativeAmount,
        CumulativeAmountSpecified,
        CurAmt,
        CurAmtSpecified,
        CurBal,
        CurBalSpecified,
        Currency,
        CurrencyConversion,
        CurrentAmount,
        CurrentBalance,
        CurrentBalanceSpecified,
        CustomerApprovedFlag,
        CustomerLanguage,
        CustomerOrder,
        CustomerOrderID,
        CustomerOrderReq,
        Data,
        DataSetId,
        DataSetReqrd,
        DateTime,
        DbtPrefrdFlg,
        DbtPrefrdFlgSpecified,
        Dbtr,
        DbtrId,
        DclrtnDtls,
        Dcml,
        DcmlSpecified,
        DeactvtnDt,
        DeactvtnDtSpecified,
        DebitPreferredFlag,
        Declaration,
        DefaultInputString,
        DefaultSelectedFlag,
        Dept,
        DerivationIdentifier,
        DerivtnId,
        DestinationAddress,
        Device,
        DeviceID,
        DgnssReq,
        DgnssRspn,
        Dgst,
        DgstAlgo,
        DgstAlgoSpecified,
        DgstdData,
        Digest,
        DigestAlgorithm,
        DigitInput,
        DisableCancelFlag,
        DisableCorrectFlag,
        DisableValidFlag,
        DisplayOutput,
        DispOutpt,
        DispReq,
        DispRspn,
        DlgtnProof,
        DlvryDt,
        DlvryDtSpecified,
        DlvryLctn,
        DlvryNoteNb,
        DlvrySvc,
        DlvrySvcSpecified,
        DocQlfr,
        DocumentQualifier,
        DrctDbtCntxt,
        DrvrId,
        DrvrLicLctn,
        DrvrLicNb,
        DrvrLicNm,
        DrvrOrVhclCard,
        DsblCclFlg,
        DsblCclFlgSpecified,
        DsblCrrctFlg,
        DsblCrrctFlgSpecified,
        DsblVldFlg,
        DsblVldFlgSpecified,
        DscndgOrdr,
        DscndgOrdrSpecified,
        Dstn,
        DstnAdr,
        DtAndPlcOfBirth,
        DtldAmt,
        DtOfSgntr,
        DtOfSgntrSpecified,
        DtTm,
        DvcReq,
        DvcRspn,
        DvcTp,
        EanUpc,
        EANUPC,
        Email,
        EmailAdr,
        EncapsulatedContent,
        EncrPINBlock,
        EncryptedContent,
        EncryptedData,
        EncryptedKey,
        EndDate,
        EndDateSpecified,
        EndDt,
        EndDtSpecified,
        EndOfLineFlag,
        EntryMode,
        Envlp,
        EnvlpdData,
        Envt,
        ErrorCondition,
        Errs,
        EventDetails,
        EventToNotify,
        Evt,
        EvtCntxt,
        EvtNtfctn,
        EvtTmStmp,
        EvtToNtfy,
        ExpiryDate,
        ExpiryDateTime,
        ExpiryDateTimeSpecified,
        Fctn,
        FctnKey,
        FctnKeySpecified,
        FctvDt,
        Fees,
        FirstAmount,
        FirstAmountSpecified,
        FirstPaymentDate,
        FllbckInd,
        FllbckIndSpecified,
        Font,
        ForceCstmrSelctnFlg,
        ForceCstmrSelctnFlgSpecified,
        ForceCustomerSelectionFlag,
        ForceEntryMode,
        ForceNtryMd,
        ForceOnlineFlag,
        ForceOnlnFlg,
        ForceOnlnFlgSpecified,
        ForecastedAmount,
        FraudPreventionFlag,
        FraudPreventionFlagSpecified,
        FrcstdAmt,
        FreeSz,
        Frmt,
        FrmtSpecified,
        FromRightToLeftFlag,
        FrstAmt,
        FrstAmtSpecified,
        FrstPmtDt,
        FrstPmtDtSpecified,
        FrstPmtDtTm,
        FrstPmtDtTmSpecified,
        FunctionKey,
        GblCrrctnFlg,
        GblCrrctnFlgSpecified,
        GenericProfile,
        GeogcCordints,
        GeographicCoordinates,
        Geolocation,
        Glctn,
        GlobalCorrectionFlag,
        GlobalStatus,
        GrpId,
        Grtty,
        GrttySpecified,
        Hbmtr,
        HbmtrSpecified,
        Hdr,
        HostDiagnosisFlag,
        HostReconciliationID,
        HostStatus,
        HostTransactionID,
        HstDgnssFlg,
        HstDgnssFlgSpecified,
        HstRcncltnId,
        HstSts,
        HstTxId,
        ICCResetData,
        ICCRltdData,
        ICCRstData,
        Id,
        IdentificationSupport,
        IdentificationType,
        IdntyCardNb,
        IdTp,
        IdTpSpecified,
        ImdtRspnFlg,
        ImdtRspnFlgSpecified,
        IMEI,
        ImgCaptrdSgntr,
        ImgData,
        ImgFrmt,
        ImgRef,
        ImmediateResponseFlag,
        IMSI,
        IndvPmt,
        InfoQualify,
        InfQlfr,
        InfQlfrSpecified,
        InitgPty,
        InitialisationVector,
        InitlstnCardRdrReq,
        InitlstnCardRdrRspn,
        InitlstnVctr,
        InptCmd,
        InptData,
        InptMsg,
        InptNtfctn,
        InptReq,
        InptRslt,
        InptRsltData,
        InptRspn,
        InptTxt,
        Input,
        InputCommand,
        InputData,
        InputResult,
        Instalment,
        InstalmentType1,
        Instlmt,
        InstlmtPlan,
        InstlmtPrd,
        InstlmtPrdSpecified,
        Instr,
        IntegratedPrintFlag,
        IntgrtdPrtFlg,
        IntgrtdPrtFlgSpecified,
        IntrfcNm,
        IntrfcTp,
        IntrfcTpSpecified,
        IntrnlCard,
        IntrnlCardSpecified,
        InvcAmt,
        InvcAmtSpecified,
        InvcNb,
        IsReachableFlag,
        Issr,
        IssrBIN,
        IssrRefData,
        IssrSpecified,
        Issuer,
        IssuerAndSerialNumber,
        Item,
        ItemAmount,
        ItemAmountSpecified,
        ItemElementName,
        ItemID,
        Items,
        ItmAmt,
        ItmAmtSpecified,
        ItmId,
        ItmNb,
        JobNb,
        KEKId,
        KEKIdentifier,
        KeyChckVal,
        KeyEncryptionAlgorithm,
        KeyId,
        KeyIdentifier,
        KeyName,
        KeyNcrptnAlgo,
        KeyReference,
        KeyVal,
        KeyVersion,
        KeyVrsn,
        Labl,
        Lang,
        Language,
        LastPmtDtTm,
        LastPmtDtTmSpecified,
        LastTxFlg,
        LastTxFlgSpecified,
        Lat,
        Latitude,
        LctnAndCtct,
        LctnCtgy,
        LctnCtgySpecified,
        LeavCardFlg,
        LeavCardFlgSpecified,
        LeaveCardFlag,
        LggdSaleId,
        LgnDtTm,
        LgnReq,
        LgnRspn,
        LgtReq,
        LineWidth,
        LineWidthSpecified,
        LltyAcct,
        LltyAcctReq,
        LltyData,
        LltyHdlg,
        LltyHdlgSpecified,
        LltyId,
        LltyReq,
        LltyRslt,
        LltyRspn,
        LltySvrId,
        LltyTxId,
        LltyTxTp,
        LltyTxTtl,
        LltyUnit,
        LltyUnitSpecified,
        LoggedSaleID,
        Long,
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
        MACAlgo,
        MACAlgorithm,
        MaintenanceAllowed,
        MaintenanceRequiredFlag,
        ManufacturerID,
        Markup,
        MarkupSpecified,
        MaskCharactersFlag,
        MaskedMSISDN,
        MaskedPAN,
        MaxAmt,
        MaxAmtSpecified,
        MaxCshBckAmt,
        MaxCshBckAmtSpecified,
        MaxDecimalLength,
        MaximumCashBackAmount,
        MaximumCashBackAmountSpecified,
        MaximumTransmitTime,
        MaxInptTm,
        MaxInptTmSpecified,
        MaxInputTime,
        MaxLength,
        MaxTrnsmssnTm,
        MaxWaitingTime,
        MaxWtgTm,
        MaxWtgTmSpecified,
        MenuBackFlag,
        MenuBckFlg,
        MenuBckFlgSpecified,
        MenuEntry,
        MenuEntryNumber,
        MenuEntryTag,
        MerchantAddress,
        MerchantCategoryCode,
        MerchantCountry,
        MerchantID,
        MerchantName,
        MerchantOverrideFlag,
        Message,
        MessageCategory,
        MessageClass,
        MessageHeader,
        MessageReference,
        MessageType,
        MinAmt,
        MinAmtSpecified,
        MinAmtToDlvr,
        MinAmtToDlvrSpecified,
        MinDispTm,
        MinDispTmSpecified,
        MinimumAmountToDeliver,
        MinimumAmountToDeliverSpecified,
        MinimumDisplayTime,
        MinimumSplitAmount,
        MinimumSplitAmountSpecified,
        MinLength,
        MinSpltAmt,
        MinSpltAmtSpecified,
        Mmry,
        MndtId,
        MndtImg,
        MndtRltdInf,
        MntncAllwd,
        MntncAllwdSpecified,
        MntncId,
        MntncReqrdFlg,
        MntncReqrdFlgSpecified,
        MobCtryCd,
        MobData,
        MobileCountryCode,
        MobileData,
        MobileNetworkCode,
        MobMskdMSISDN,
        MobNtwkCd,
        MplyeeIdNb,
        MplyrIdNb,
        Mrchnt,
        MrchntCtgyCd,
        MrchntOvrrdFlg,
        MrchntOvrrdFlgSpecified,
        MrchntRefData,
        MrkUpDtls,
        MsgCntt,
        MsgCnttSgntr,
        MsgCpblties,
        MsgDstn,
        MsgFctn,
        MsgInErr,
        MsgStsReqData,
        MsgStsRspnData,
        MsgToPres,
        MsgToSnd,
        MSISDN,
        MskdPAN,
        MskGnrtrAlgo,
        Mtd,
        MxScrptLngth,
        MxScrptLngthSpecified,
        Nb,
        NblSvcReq,
        NbOfLines,
        NbOfLinesSpecified,
        NbOfPmts,
        NbOfPmtsSpecified,
        NcpsltdCntt,
        NcrptdCntt,
        NcrptdData,
        NcrptdKey,
        NcrptdPINBlck,
        NcrptnFrmt,
        NcrptnFrmtSpecified,
        Nm,
        NmrcCd,
        NotAllwdPdctCd,
        NotifyCardInputFlag,
        NtfyCardInptFlg,
        NtryMd,
        NtryMdSpecified,
        NtwkTp,
        Number,
        NvrtdXchgRate,
        NvrtdXchgRateSpecified,
        Odmtr,
        OdmtrSpecified,
        OffsetEnd,
        OffsetEndSpecified,
        OffsetStart,
        OffsetStartSpecified,
        OnLineCntxt,
        OnLineCntxtSpecified,
        OnLineCpblties,
        OnLineCpbltiesSpecified,
        OnlineFlag,
        OnLineRsn,
        OnlnFlg,
        OnlnFlgSpecified,
        OpenOrderState,
        OperatorID,
        OperatorLanguage,
        OpnOrdrStat,
        OpnOrdrStatSpecified,
        Oprtr,
        OrgnlAmt,
        OrgnlPmtTx,
        OrgnlPOITx,
        OrgnlTx,
        OrgtrInf,
        OriginalPOITransaction,
        Othr,
        OutptBrcd,
        OutptCntt,
        OutptDisp,
        OutptRslt,
        OutputBarcode,
        OutputContent,
        OutputFormat,
        OutputResult,
        OutputSignature,
        OutputText,
        OutputXHTML,
        OwnerName,
        OwnrNm,
        Packg,
        PackgBlck,
        PackgId,
        PackgLngth,
        PackgLngthSpecified,
        PaidAmount,
        PaidAmountSpecified,
        PAN,
        Param,
        Param1,
        Param2,
        Parameter,
        Params,
        ParamsVrsn,
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
        PdctAmt,
        PdctAmtSgn,
        PdctAmtSgnSpecified,
        PdctCd,
        PdctCdSetId,
        PdctDesc,
        PdctQty,
        PdctQtySpecified,
        PEDOKFlag,
        PEDOKFlagSpecified,
        PerformedTransaction,
        Period,
        PeriodUnit,
        Phne,
        PhysIntrfc,
        PINEncAlgorithm,
        PINFormat,
        PINFrmt,
        PINLngthCpblties,
        PINLngthCpbltiesSpecified,
        PINReqTp,
        PINRequestType1,
        PINVerifMethod,
        PINVrfctnMtd,
        PlainCardData,
        PlanId,
        PlanID,
        PlaySoundReq,
        PlcAndNm,
        PmtAcct,
        PmtAcctRef,
        PmtAcctReq,
        PmtAcqrrData,
        PmtBrnd,
        PmtCntxt,
        PmtInstrmTp,
        PmtRct,
        PmtReq,
        PmtRslt,
        PmtRspn,
        PmtTkn,
        PmtTp,
        PmtTpSpecified,
        PmtTx,
        POI,
        POICapabilities,
        POIChllng,
        POICmpnt,
        POICpblties,
        POIData,
        POIDtTm,
        POIGrpId,
        POIId,
        POIID,
        POIProfile,
        POIRcncltnId,
        POIReconciliationID,
        POISerialNumber,
        POISftwr,
        POISoftware,
        POIStatus,
        POISts,
        POISystemData,
        POITerminalData,
        POITransactionID,
        POITxId,
        PrdUnit,
        PrdUnitSpecified,
        PredefinedContent,
        PrfrmdTx,
        PrinterStatus,
        PrintOutput,
        ProductCode,
        ProductLabel,
        ProtectedCardData,
        ProtectedMobileData,
        ProtectedSignature,
        ProtocolVersion,
        PrsnlData,
        PrtcolNm,
        PrtcolVrsn,
        PrtctdAuthntcnVal,
        PrtctdBal,
        PrtctdCaptrdSgntr,
        PrtctdCardData,
        PrtctdCrdhldrData,
        PrtctdDlgtnProof,
        PrtctdMobData,
        PrtctdVal,
        PrtReq,
        PrtRspn,
        PrvcOfBirth,
        Prvdr,
        PrvdrId,
        PrvtCardData,
        PsptNb,
        PstCd,
        PstCdId,
        PstlAdr,
        PstlCdDgts,
        PurchsOrdrNb,
        Pwd,
        PwrOffCardRdrReq,
        PwrOffMaxWtgTm,
        PwrOffMaxWtgTmSpecified,
        QRCdBinryVal,
        QRCdErrCrrctn,
        QRCdErrCrrctnSpecified,
        QRCdNcodgMd,
        QRCdVrsn,
        QtnDt,
        QtnDtSpecified,
        QtyLmt,
        QtyLmtSpecified,
        Quantity,
        QuantitySpecified,
        Rate,
        RateSpecified,
        Rbt,
        RbtLabl,
        Rbts,
        Rchbl,
        RchblSpecified,
        RcncltnId,
        RcncltnReq,
        RcncltnReqData,
        RcncltnRspn,
        RcncltnRspnData,
        RcncltnTp,
        Rcpt,
        RcptId,
        RcptPty,
        Rct,
        RctRprntFlg,
        RctRprntFlgSpecified,
        RcvdMsg,
        RebateLabel,
        Rebates,
        ReceiptReprintFlag,
        RecipientIdentifier,
        ReconciliationType,
        ReferenceID,
        RefrHrs,
        RegdIdr,
        RegistrationID,
        RegnId,
        RejectedMessage,
        RelativeDistinguishedName,
        RemoveAllFlag,
        RemoveAllFlagSpecified,
        RepeatedMessageResponse,
        ReqdAmt,
        ReqdAmtSpecified,
        ReqdTx,
        ReqrdSgntrFlg,
        ReqrdSgntrFlgSpecified,
        RequestedAmount,
        RequestedAmountSpecified,
        RequestedValidityDate,
        RequiredSignatureFlag,
        Response,
        ResponseMode,
        ResponseRequiredFlag,
        Result,
        ReuseCardDataFlag,
        ReuseCardDataFlg,
        ReuseCardDataFlgSpecified,
        ReversalReason,
        ReversedAmount,
        ReversedAmountSpecified,
        Rjct,
        RjctRsn,
        RlayId,
        RltvDstngshdNm,
        RmngAmt,
        RmngAmtSpecified,
        RmotAccs,
        RmotPty,
        RmvAllFlg,
        RmvAllFlgSpecified,
        RpeatdCardAcqstnRspn,
        RpeatdLltyRspn,
        RpeatdPmtRspn,
        RpeatdRvslRspn,
        RpeatdSndApplPrtcolDataUnitCardRdrRspn,
        RpeatdStordValRspn,
        RplcmntCar,
        RplcmntCarSpecified,
        RptFullSz,
        RptGetTtlsReq,
        RptGetTtlsRspn,
        RptReq,
        RptRspn,
        RptTxReq,
        RptTxRspn,
        RqstrId,
        Rslt,
        RsltgAmt,
        RsltRsn,
        RsltSpecified,
        Rspn,
        RspnMd,
        RspnMdSpecified,
        RspnReqrdFlg,
        RspnReqrdFlgSpecified,
        RspnRsn,
        RspnRsnSpecified,
        RspnToAuthstn,
        RtlrEvt,
        RtlrPmtRslt,
        RvsdAmt,
        RvsdAmtSpecified,
        RvslReq,
        RvslRsn,
        RvslRspn,
        RvslTxRslt,
        SaleCapabilities,
        SaleChanl,
        SaleChannel,
        SaleCntxt,
        SaleCpblties,
        SaleData,
        SaleEnvt,
        SaleId,
        SaleID,
        SaleItem,
        SaleItemRebate,
        SaleItm,
        SaleItmRbt,
        SaleProfile,
        SaleRcncltnId,
        SaleReferenceID,
        SaleRefId,
        SaleRefNb,
        SaleSftwr,
        SaleSoftware,
        SaleTerminalData,
        SaleTermnlData,
        SaleTknScp,
        SaleTknScpSpecified,
        SaleToAcqrrData,
        SaleToAcquirerData,
        SaleToIssrData,
        SaleToIssuerData,
        SaleToPOIAbrt,
        SaleToPOIAdmstvReq,
        SaleToPOIAdmstvRspn,
        SaleToPOIData,
        SaleToPOIDvcReq,
        SaleToPOIDvcRspn,
        SaleToPOIEvtNtfctn,
        SaleToPOIMsgRjctn,
        SaleToPOIMsgStsReq,
        SaleToPOIMsgStsRspn,
        SaleToPOIRcncltnReq,
        SaleToPOIRcncltnRspn,
        SaleToPOIRptReq,
        SaleToPOIRptRspn,
        SaleToPOISsnMgmtReq,
        SaleToPOISsnMgmtRspn,
        SaleToPOISvcReq,
        SaleToPOISvcRspn,
        SaleTransactionID,
        SaleTxId,
        SaltLngth,
        SbcbrIdntyMdls,
        SbcbrIdntyMdlsSpecified,
        SchAnd,
        SchCrit,
        SchmeData,
        SchmeNm,
        SchOr,
        SchOutptOrdr,
        SclSctyNb,
        ScrInptReq,
        ScrInptRspn,
        SctyAccsMdls,
        SctyAccsMdlsSpecified,
        SctyElmt,
        SctyPrfl,
        SctyTrlr,
        SecurityOKFlag,
        SecurityOKFlagSpecified,
        SecurityTrailer,
        SensitiveCardData,
        SensitiveMobileData,
        SeqNb,
        SeqNbSpecified,
        SequenceNumber,
        SerialNumber,
        ServiceID,
        ServiceIdentification,
        ServiceProfiles,
        ServicesEnabled,
        Sgn,
        SgndAttrbts,
        SgndData,
        Sgnr,
        SgnrId,
        SgnSpecified,
        Sgntr,
        SgntrAlgo,
        ShftNb,
        ShiftNumber,
        ShppgAdr,
        ShrtNm,
        Signature,
        SignatureAlgorithm,
        SignaturePoint,
        Signer,
        SignerIdentifier,
        SnstvMobData,
        SoftwareVersion,
        SoundAction,
        SoundActn,
        SoundCntt,
        SoundContent,
        SoundFormat,
        SoundFrmt,
        SoundRef,
        SoundVol,
        SoundVolSpecified,
        SoundVolume,
        SplitPaymentFlag,
        SplmtryData,
        SpltPmt,
        SpltPmtSpecified,
        SpnsrdMrchnt,
        SponsoredMerchant,
        SpprtdOptn,
        SrcCcy,
        Srchrg,
        SrlNb,
        SsnKey,
        SsnMgmtReq,
        SsnMgmtRspn,
        StartColumn,
        StartDate,
        StartDt,
        StartRow,
        StatementReference,
        StdCmplc,
        StordValAcct,
        StordValAcctReq,
        StordValReq,
        StordValRspn,
        StoredValueAccountID,
        StoredValueAccountStatus,
        StoredValueAccountType,
        StoredValueData,
        StoredValueProvider,
        StoredValueResult,
        StoredValueTransactionType,
        StringMask,
        StrtNm,
        Sts,
        StsReq,
        StsRspn,
        StsSpecified,
        SubDept,
        SubTpInf,
        SvcAttr,
        SvcAttrSpecified,
        SvcCd,
        SvcCntt,
        SvcOptn,
        SvcReq,
        SvcRspn,
        SvcsNbld,
        SvcsNbldSpecified,
        SvcTp,
        SvrCert,
        SvrCertIdr,
        SvrData,
        SysAbrt,
        SysNm,
        TaxCode,
        TaxIdNb,
        TaxTp,
        TerminalEnvironment,
        TermnlEnvt,
        TermnlEnvtSpecified,
        TermnlIntgtn,
        TermnlIntgtnSpecified,
        TermnlMgrId,
        TextInput,
        TimeStamp,
        TipAmount,
        TipAmountSpecified,
        Tkn,
        TknAssrncData,
        TknAssrncLvl,
        TknAssrncLvlSpecified,
        TknAssrncMtd,
        TknChrtc,
        TknInittdInd,
        TknInittdIndSpecified,
        TknReqdTp,
        TknReqdTpSpecified,
        TknRqstr,
        TknXpryDt,
        TMChllng,
        TMSCtctDtTm,
        TMSCtctDtTmSpecified,
        TMSCtctLvl,
        TMSId,
        TmStmp,
        TMSTrggr,
        TmZone,
        TokenRequestedType,
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
        Tp,
        TpSpecified,
        Tracblt,
        TracDtTmIn,
        TracDtTmOut,
        TrackData,
        TrackFormat,
        TrackNumb,
        TrainingModeFlag,
        TransactionAction,
        TransactionAmount,
        TransactionConditions,
        TransactionCount,
        TransactionID,
        TransactionToPerform,
        TransactionTotals,
        TransactionType,
        Trck1,
        Trck2,
        Trck3,
        TrckFrmt,
        TrckFrmtSpecified,
        TrckNb,
        TrckNbSpecified,
        TrckVal,
        Trgt,
        TrgtCcy,
        TripNb,
        TrlrFld,
        TrlrFldSpecified,
        TrlrHrs,
        TrlrNb,
        TrngMdFlg,
        TrngMdFlgSpecified,
        TrnsmssnReq,
        TrnsmssnRspn,
        TtlAmt,
        TtlAmtSpecified,
        TtlDtls,
        TtlDtlsSpecified,
        TtlFltr,
        TtlNb,
        TtlNbOfPmts,
        TtlNbOfPmtsSpecified,
        TtlRbt,
        TtlRbtSpecified,
        TtlsGrpId,
        TtlSz,
        TwnNm,
        Tx,
        TxActn,
        TxCaptr,
        TxCaptrSpecified,
        TxChanl,
        TxChanlSpecified,
        TxDtls,
        TxDtTm,
        TxEnvt,
        TxEnvtSpecified,
        TxId,
        TxRef,
        TxRpt,
        TxRspn,
        TxSucss,
        TxSucssSpecified,
        Txt,
        TxToPrfrm,
        TxTp,
        TxTtl,
        TxTtls,
        TxTtlsSet,
        TxVrfctnRslt,
        TypeCode,
        UattnddLvlCtgy,
        Unit,
        UnitNb,
        UnitOfMeasr,
        UnitOfMeasrSpecified,
        UnitOfMeasure,
        UnitPric,
        UnitPrice,
        UnitPriceSpecified,
        UnitPricSgn,
        UnitPricSgnSpecified,
        UnitPricSpecified,
        UnitSpecified,
        UnitValue,
        URLAdr,
        UsrNm,
        UTMCoordinates,
        UTMCordints,
        UTMEastward,
        UTMEstwrd,
        UTMNorthward,
        UTMNrthwrd,
        UTMZone,
        Val,
        ValAddedTax,
        ValAddedTaxSpecified,
        ValidityDate,
        Value,
        Version,
        Vhcl,
        VhclNb,
        VhclTag,
        VhclTagNtryMd,
        VhclTagNtryMdSpecified,
        VldtyDt,
        VldtyDtSpecified,
        VldUntil,
        VldUntilSpecified,
        VrfctnNtty,
        VrfctnNttySpecified,
        Vrsn,
        VrsnNb,
        VrsnSpecified,
        WaitResponseFlag,
        WaitUserValidationFlag,
        WaitUsrVldtnFlg,
        WaitUsrVldtnFlgSpecified,
        WarmResetFlag,
        WarmResetFlagSpecified,
        WarmRstFlg,
        WarmRstFlgSpecified,
        Wllt,
        X,
        XchgId,
        XchgRate,
        XpctdLngth,
        XprtnDt,
        XprtnDtSpecified,
        XpryDt,
        XpryDtSpecified,
        Y,
    }
}
#endif
