#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ec6431a9-3e37-4c81-9b59-f1b86abd4177")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayResponse1 : IDeviceDisplayResponse1 {
        private OutputResult1[] outptRsltField = new OutputResult1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return this.XSD_HasBeenSetField;
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8b767709-0813-4d68-8050-78a9ba87c01f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OutputResult1 : IOutputResult1 {
        private UserInterface4Code dvcTpField;
        private InformationQualify1Code infQlfrField;
        private ResponseType9 rspnField = new ResponseType9();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public UserInterface4Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rspnField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.Rspn.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Rspn = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4d125fd7-2cd9-4614-8559-fa4131124245")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderResponse1 : IDeviceInitialisationCardReaderResponse1 {
        private CardDataReading6Code cardNtryMdField;
        private bool cardNtryMdFieldSpecified;
        private ICCResetData1 iCCRstDataField = new ICCResetData1();
        private byte[] addtlInfField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public CardDataReading6Code CardNtryMd {
            get {
                return this.cardNtryMdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cardNtryMdField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - CardNtryMdSpecified = true
                this.CardNtryMdSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.iCCRstDataField.XSD_HasBeenSetProperty == false))) {
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.ICCRstData.XSD_HasBeenSetProperty)
                            || this.CardNtryMdSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.ICCRstData = null;
                    this.CardNtryMdSpecified = false;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.ICCRstData != null)) {
                    this.ICCRstData.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("892557f5-12a4-49f3-997a-22370c615c2c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ICCResetData1 : IICCResetData1 {
        private byte[] aTRValField = new byte[0];
        private byte[] cardStsField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.aTRValField = value;
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cardStsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return this.XSD_HasBeenSetField;
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("74dc05c9-542b-4427-a36d-df3886ae0e60")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputResponse1 : IDeviceInputResponse1 {
        private OutputResult1 outptRsltField = new OutputResult1();
        private InputResult1 inptRsltField = new InputResult1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public OutputResult1 OutptRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.outptRsltField.XSD_HasBeenSetProperty == false))) {
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
        public InputResult1 InptRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptRsltField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRsltField = new InputResult1();
                }
                else {
                    this.inptRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.OutptRslt.XSD_HasBeenSetProperty)
                            || this.InptRslt.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.OutptRslt = null;
                    this.InptRslt = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.OutptRslt != null)) {
                    this.OutptRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InptRslt != null)) {
                    this.InptRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a926edcd-3250-42d3-a8c6-e8368064d106")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResult1 : IInputResult1 {
        private SaleCapabilities2Code dvcTpField;
        private InformationQualify1Code infQlfrField;
        private InputResultData1 inptRsltDataField = new InputResultData1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public InputResultData1 InptRsltData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptRsltDataField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRsltDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRsltDataField = new InputResultData1();
                }
                else {
                    this.inptRsltDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.InptRsltData.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.InptRsltData = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.InptRsltData != null)) {
                    this.InptRsltData.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e068923b-fbd6-4eb1-a5a9-b890f248c2f4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResultData1 : IInputResultData1 {
        private InputCommand1Code inptCmdField;
        private bool confdFlgField;
        private bool confdFlgFieldSpecified;
        private double fctnKeyField;
        private bool fctnKeyFieldSpecified;
        private string inptMsgField;
        private ContentInformationType19 pwdField = new ContentInformationType19();
        private CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.inptCmdField = value;
            }
        }
        /// <remarks/>
        public bool ConfdFlg {
            get {
                return this.confdFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.confdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - ConfdFlgSpecified = true
                this.ConfdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.fctnKeyField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - FctnKeySpecified = true
                this.FctnKeySpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.inptMsgField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType19 Pwd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pwdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pwdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pwdField = new ContentInformationType19();
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.imgCaptrdSgntrField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.Pwd.XSD_HasBeenSetProperty)
                            || this.ImgCaptrdSgntr.XSD_HasBeenSetProperty)
                            || this.ConfdFlgSpecified)
                            || this.FctnKeySpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Pwd = null;
                    this.ImgCaptrdSgntr = null;
                    this.ConfdFlgSpecified = false;
                    this.FctnKeySpecified = false;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Pwd != null)) {
                    this.Pwd.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.ImgCaptrdSgntr != null)) {
                    this.ImgCaptrdSgntr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f120e36e-e608-42d3-a28d-31b48e75c3f0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintResponse1 : IDevicePrintResponse1 {
        private DocumentType7Code docQlfrField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.docQlfrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return this.XSD_HasBeenSetField;
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b322bbea-c10d-4e8c-893d-d7497bb8d13d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceResponse2 : IDeviceResponse2 {
        private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        private CardPaymentContext27 cntxtField = new CardPaymentContext27();
        private RetailerService9Code svcCnttField;
        private OutputResult1[] dispRspnField = new OutputResult1[0];
        private DeviceInputResponse1 inptRspnField = new DeviceInputResponse1();
        private DevicePrintResponse1 prtRspnField = new DevicePrintResponse1();
        private DeviceSecureInputResponse1 scrInptRspnField = new DeviceSecureInputResponse1();
        private DeviceInitialisationCardReaderResponse1 initlstnCardRdrRspnField = new DeviceInitialisationCardReaderResponse1();
        private DeviceSendApplicationProtocolDataUnitCardReaderResponse1 cardRdrApplPrtcolDataUnitRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
        private DeviceTransmitMessageResponse1 trnsmssnRspnField = new DeviceTransmitMessageResponse1();
        private ResponseType9 rspnField = new ResponseType9();
        private SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.envtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.envtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.envtField = new CardPaymentEnvironment73();
                }
                else {
                    this.envtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.cntxtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cntxtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cntxtField = new CardPaymentContext27();
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
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.svcCnttField = value;
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
        public DeviceInputResponse1 InptRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptRspnField = new DeviceInputResponse1();
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.prtRspnField.XSD_HasBeenSetProperty == false))) {
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
        public DeviceSecureInputResponse1 ScrInptRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.scrInptRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.scrInptRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.scrInptRspnField = new DeviceSecureInputResponse1();
                }
                else {
                    this.scrInptRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderResponse1 InitlstnCardRdrRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.initlstnCardRdrRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.initlstnCardRdrRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.initlstnCardRdrRspnField = new DeviceInitialisationCardReaderResponse1();
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.cardRdrApplPrtcolDataUnitRspnField.XSD_HasBeenSetProperty == false))) {
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.trnsmssnRspnField.XSD_HasBeenSetProperty == false))) {
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rspnField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
                            || this.Cntxt.XSD_HasBeenSetProperty)
                            || this.InptRspn.XSD_HasBeenSetProperty)
                            || this.PrtRspn.XSD_HasBeenSetProperty)
                            || this.ScrInptRspn.XSD_HasBeenSetProperty)
                            || this.InitlstnCardRdrRspn.XSD_HasBeenSetProperty)
                            || this.CardRdrApplPrtcolDataUnitRspn.XSD_HasBeenSetProperty)
                            || this.TrnsmssnRspn.XSD_HasBeenSetProperty)
                            || this.Rspn.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Envt = null;
                    this.Cntxt = null;
                    this.InptRspn = null;
                    this.PrtRspn = null;
                    this.ScrInptRspn = null;
                    this.InitlstnCardRdrRspn = null;
                    this.CardRdrApplPrtcolDataUnitRspn = null;
                    this.TrnsmssnRspn = null;
                    this.Rspn = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Envt != null)) {
                    this.Envt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Cntxt != null)) {
                    this.Cntxt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InptRspn != null)) {
                    this.InptRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PrtRspn != null)) {
                    this.PrtRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.ScrInptRspn != null)) {
                    this.ScrInptRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InitlstnCardRdrRspn != null)) {
                    this.InitlstnCardRdrRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.CardRdrApplPrtcolDataUnitRspn != null)) {
                    this.CardRdrApplPrtcolDataUnitRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.TrnsmssnRspn != null)) {
                    this.TrnsmssnRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService9Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("0d532020-1428-4abc-9469-ee829fb05b11")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputResponse1 : IDeviceSecureInputResponse1 {
        private OnLinePIN6 crdhldrPINField = new OnLinePIN6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public OnLinePIN6 CrdhldrPIN {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.crdhldrPINField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.crdhldrPINField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.crdhldrPINField = new OnLinePIN6();
                }
                else {
                    this.crdhldrPINField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.CrdhldrPIN.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.CrdhldrPIN = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.CrdhldrPIN != null)) {
                    this.CrdhldrPIN.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("465ff85a-dae9-4814-8f0a-e704dd3772d2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageResponse1 : IDeviceTransmitMessageResponse1 {
        private byte[] rcvdMsgField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rcvdMsgField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return this.XSD_HasBeenSetField;
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("532219f9-2560-4b2b-a1f5-9cb68c47fd09")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceResponseV01 : ISaleToPOIDeviceResponseV01 {
        private Header37 hdrField = new Header37();
        private DeviceResponse2 dvcRspnField = new DeviceResponse2();
        private ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.hdrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.hdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.hdrField = new Header37();
                }
                else {
                    this.hdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceResponse2 DvcRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dvcRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dvcRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dvcRspnField = new DeviceResponse2();
                }
                else {
                    this.dvcRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.sctyTrlrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.sctyTrlrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.sctyTrlrField = new ContentInformationType18();
                }
                else {
                    this.sctyTrlrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.Hdr.XSD_HasBeenSetProperty)
                            || this.DvcRspn.XSD_HasBeenSetProperty)
                            || this.SctyTrlr.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Hdr = null;
                    this.DvcRspn = null;
                    this.SctyTrlr = null;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        internal bool XSD_OptimizingProperty {
            get {
                // BEGIN ADDED BY XSD - AddGetStatementFromField
                return this.XSD_OptimizingField;
                // END ADDED BY XSD - AddGetStatementFromField
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_OptimizingField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.Hdr != null)) {
                    this.Hdr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.DvcRspn != null)) {
                    this.DvcRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("9de24307-8a41-471c-b1ff-8bd76f3e0744")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int OutptRsltSize();
        [DispId(4)]
        OutputResult1 OutptRsltGetItem(int index);
        [DispId(5)]
        bool OutptRsltSetItem(int index, OutputResult1 value);
        [DispId(6)]
        bool OutptRsltAddItem(OutputResult1 value);
        [DispId(7)]
        bool OutptRsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("e91a8ae5-c1ff-4851-b85d-38a240554546")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IOutputResult1 {
        /// <remarks/>
        [DispId(1)]
        UserInterface4Code DvcTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ResponseType9 Rspn {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("d307856e-ccb2-4d6d-a682-902907abbef0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInitialisationCardReaderResponse1 {
        /// <remarks/>
        [DispId(1)]
        CardDataReading6Code CardNtryMd {
            get;
            set;
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(6)]
        int AddtlInfSize();
        [DispId(7)]
        byte AddtlInfGetItem(int index);
        [DispId(8)]
        bool AddtlInfSetItem(int index, byte value);
        [DispId(9)]
        bool AddtlInfAddItem(byte value);
        [DispId(10)]
        bool AddtlInfRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("273e4acb-c21b-41d3-9d61-87cb5f748857")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(4)]
        int ATRValSize();
        [DispId(5)]
        byte ATRValGetItem(int index);
        [DispId(6)]
        bool ATRValSetItem(int index, byte value);
        [DispId(7)]
        bool ATRValAddItem(byte value);
        [DispId(8)]
        bool ATRValRemoveItem(int index);
        [DispId(9)]
        int CardStsSize();
        [DispId(10)]
        byte CardStsGetItem(int index);
        [DispId(11)]
        bool CardStsSetItem(int index, byte value);
        [DispId(12)]
        bool CardStsAddItem(byte value);
        [DispId(13)]
        bool CardStsRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("4945e30e-25d6-4884-a49f-74f98b5e2211")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputResponse1 {
        /// <remarks/>
        [DispId(1)]
        OutputResult1 OutptRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InputResult1 InptRslt {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("803ee665-23d6-42fa-ae1a-0f6200961260")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResult1 {
        /// <remarks/>
        [DispId(1)]
        SaleCapabilities2Code DvcTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        InputResultData1 InptRsltData {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("3293315c-c812-49a7-97df-272870f79aa1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResultData1 {
        /// <remarks/>
        [DispId(1)]
        InputCommand1Code InptCmd {
            get;
            set;
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
        ContentInformationType19 Pwd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        CapturedSignature1 ImgCaptrdSgntr {
            get;
            set;
        }
        [DispId(9)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4642b668-3c6b-4b2a-b3cc-8c45bf66a78a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePrintResponse1 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
            set;
        }
        [DispId(2)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("922d279e-e89b-444e-bf61-89e3ded4cba3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceResponse2 {
        /// <remarks/>
        [DispId(1)]
        CardPaymentEnvironment73 Envt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentContext27 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        RetailerService9Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        OutputResult1[] DispRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        DeviceInputResponse1 InptRspn {
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
        DeviceSecureInputResponse1 ScrInptRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        DeviceInitialisationCardReaderResponse1 InitlstnCardRdrRspn {
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(14)]
        int DispRspnSize();
        [DispId(15)]
        OutputResult1 DispRspnGetItem(int index);
        [DispId(16)]
        bool DispRspnSetItem(int index, OutputResult1 value);
        [DispId(17)]
        bool DispRspnAddItem(OutputResult1 value);
        [DispId(18)]
        bool DispRspnRemoveItem(int index);
        [DispId(19)]
        int SplmtryDataSize();
        [DispId(20)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(21)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(22)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(23)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("0c1af000-5760-458e-bfc0-280b059a8aa6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSecureInputResponse1 {
        /// <remarks/>
        [DispId(1)]
        OnLinePIN6 CrdhldrPIN {
            get;
            set;
        }
        [DispId(2)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4f453477-33ca-4fe2-a5b1-0ada1164171e")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int RcvdMsgSize();
        [DispId(4)]
        byte RcvdMsgGetItem(int index);
        [DispId(5)]
        bool RcvdMsgSetItem(int index, byte value);
        [DispId(6)]
        bool RcvdMsgAddItem(byte value);
        [DispId(7)]
        bool RcvdMsgRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("647a6e0e-f932-4db8-ae03-cf0fdb654696")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIDeviceResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        DeviceResponse2 DvcRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ContentInformationType18 SctyTrlr {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TagsEnumeration {
        Abrt,
        AbrtRsn,
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
        ActlAmt,
        ActlAmtSpecified,
        Actn,
        ActnId,
        ActnTp,
        Actv,
        ActvtnDt,
        ActvtnDtSpecified,
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
        AllwdLltyBrnd,
        AllwdNtryMd,
        AllwdPdct,
        AllwdPdctCd,
        AllwdPmtBrnd,
        AlnRegnNb,
        AlphaCd,
        Amt,
        AmtGoodsAndSvcs,
        AmtGoodsAndSvcsSpecified,
        AmtLmt,
        AmtLmtSpecified,
        AmtQlfr,
        AmtQlfrSpecified,
        ApprvlCd,
        ApprvlCdLngth,
        ApprvlCdLngthSpecified,
        Assgnr,
        Assmnt,
        ATRVal,
        AttndncCntxt,
        AttndncCntxtSpecified,
        AttndntLang,
        AttndntMsgCpbl,
        AttndntMsgCpblSpecified,
        AttrTp,
        AttrVal,
        AuthntcdData,
        Authntcn,
        AuthntcnAddtlInf,
        AuthntcnLvl,
        AuthntcnMtd,
        AuthntcnRslt,
        AuthntcnRsltSpecified,
        AuthntcnTp,
        AuthntcnVal,
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
        Card,
        CardAcqstnReq,
        CardAcqstnRspn,
        CardBrnd,
        CardCaptrCpbl,
        CardCaptrCpblSpecified,
        CardCcyCd,
        CardCtryCd,
        CardDataNtryMd,
        CardDataNtryMdSpecified,
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
        CardSeqNb,
        CardSts,
        Ccy,
        CcyConvs,
        CcyConvsElgblty,
        CcyConvsId,
        CcyConvsRslt,
        Cdtr,
        CdtrId,
        Cert,
        Chck,
        ChckCardNb,
        ChckNb,
        ChckTp,
        ChckTpSpecified,
        ChckTrckData2,
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
        Com,
        ComssnDtls,
        ComTp,
        ConfdFlg,
        ConfdFlgSpecified,
        Convs,
        ConvsDtls,
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
        CurAmt,
        CurAmtSpecified,
        CurBal,
        CurBalSpecified,
        Data,
        DataSetId,
        DataSetReqrd,
        DbtPrefrdFlg,
        DbtPrefrdFlgSpecified,
        Dbtr,
        DbtrId,
        DclrtnDtls,
        Dcml,
        DcmlSpecified,
        DeactvtnDt,
        DeactvtnDtSpecified,
        Dept,
        DerivtnId,
        DgnssReq,
        DgnssRspn,
        Dgst,
        DgstAlgo,
        DgstAlgoSpecified,
        DgstdData,
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
        EANUPC,
        Email,
        EmailAdr,
        EndDt,
        EndDtSpecified,
        Envlp,
        EnvlpdData,
        Envt,
        Errs,
        Evt,
        EvtCntxt,
        EvtNtfctn,
        EvtTmStmp,
        EvtToNtfy,
        Fctn,
        FctnKey,
        FctnKeySpecified,
        FctvDt,
        Fees,
        FllbckInd,
        FllbckIndSpecified,
        ForceCstmrSelctnFlg,
        ForceCstmrSelctnFlgSpecified,
        ForceNtryMd,
        ForceOnlnFlg,
        ForceOnlnFlgSpecified,
        FrcstdAmt,
        FreeSz,
        Frmt,
        FrmtSpecified,
        FrstAmt,
        FrstAmtSpecified,
        FrstPmtDt,
        FrstPmtDtSpecified,
        FrstPmtDtTm,
        FrstPmtDtTmSpecified,
        GblCrrctnFlg,
        GblCrrctnFlgSpecified,
        GeogcCordints,
        Glctn,
        GrpId,
        Grtty,
        GrttySpecified,
        Hbmtr,
        HbmtrSpecified,
        Hdr,
        HstDgnssFlg,
        HstDgnssFlgSpecified,
        HstRcncltnId,
        HstSts,
        HstTxId,
        ICCRltdData,
        ICCRstData,
        Id,
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
        IMSI,
        IndvPmt,
        InfQlfr,
        InfQlfrSpecified,
        InitgPty,
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
        Instlmt,
        InstlmtPlan,
        InstlmtPrd,
        InstlmtPrdSpecified,
        Instr,
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
        Issr,
        IssrBIN,
        IssrRefData,
        IssrSpecified,
        Item,
        ItemElementName,
        ItmAmt,
        ItmAmtSpecified,
        ItmId,
        ItmNb,
        JobNb,
        KEKId,
        KeyChckVal,
        KeyId,
        KeyNcrptnAlgo,
        KeyVal,
        KeyVrsn,
        Labl,
        Lang,
        LastPmtDtTm,
        LastPmtDtTmSpecified,
        LastTxFlg,
        LastTxFlgSpecified,
        Lat,
        LctnAndCtct,
        LctnCtgy,
        LctnCtgySpecified,
        LeavCardFlg,
        LeavCardFlgSpecified,
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
        Long,
        MAC,
        MACAlgo,
        MaxAmt,
        MaxAmtSpecified,
        MaxCshBckAmt,
        MaxCshBckAmtSpecified,
        MaxInptTm,
        MaxInptTmSpecified,
        MaxTrnsmssnTm,
        MaxWtgTm,
        MaxWtgTmSpecified,
        MenuBckFlg,
        MenuBckFlgSpecified,
        MinAmt,
        MinAmtSpecified,
        MinAmtToDlvr,
        MinAmtToDlvrSpecified,
        MinDispTm,
        MinDispTmSpecified,
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
        NtfyCardInptFlg,
        NtryMd,
        NtryMdSpecified,
        NtwkTp,
        NvrtdXchgRate,
        NvrtdXchgRateSpecified,
        Odmtr,
        OdmtrSpecified,
        OnLineCntxt,
        OnLineCntxtSpecified,
        OnLineCpblties,
        OnLineCpbltiesSpecified,
        OnLineRsn,
        OnlnFlg,
        OnlnFlgSpecified,
        OpnOrdrStat,
        OpnOrdrStatSpecified,
        Oprtr,
        OrgnlAmt,
        OrgnlPmtTx,
        OrgnlPOITx,
        OrgnlTx,
        OrgtrInf,
        Othr,
        OutptBrcd,
        OutptCntt,
        OutptRslt,
        OwnrNm,
        PAN,
        Param,
        Param1,
        Param2,
        Params,
        ParamsVrsn,
        PdctAmt,
        PdctAmtSgn,
        PdctAmtSgnSpecified,
        PdctCd,
        PdctCdSetId,
        PdctDesc,
        PdctQty,
        PdctQtySpecified,
        Phne,
        PhysIntrfc,
        PINFrmt,
        PINLngthCpblties,
        PINLngthCpbltiesSpecified,
        PINReqTp,
        PINVrfctnMtd,
        PlainCardData,
        PlanId,
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
        POIChllng,
        POICmpnt,
        POICpblties,
        POIDtTm,
        POIGrpId,
        POIId,
        POIRcncltnId,
        POISftwr,
        POISts,
        POITxId,
        PrdUnit,
        PrdUnitSpecified,
        PrfrmdTx,
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
        Rate,
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
        RefrHrs,
        RegdIdr,
        RegnId,
        ReqdAmt,
        ReqdAmtSpecified,
        ReqdTx,
        ReqrdSgntrFlg,
        ReqrdSgntrFlgSpecified,
        ReuseCardDataFlg,
        ReuseCardDataFlgSpecified,
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
        SaleChanl,
        SaleCntxt,
        SaleCpblties,
        SaleEnvt,
        SaleId,
        SaleItm,
        SaleItmRbt,
        SaleRcncltnId,
        SaleRefId,
        SaleRefNb,
        SaleSftwr,
        SaleTermnlData,
        SaleTknScp,
        SaleTknScpSpecified,
        SaleToAcqrrData,
        SaleToIssrData,
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
        SeqNb,
        SeqNbSpecified,
        Sgn,
        SgndAttrbts,
        SgndData,
        Sgnr,
        SgnrId,
        SgnSpecified,
        Sgntr,
        SgntrAlgo,
        ShftNb,
        ShppgAdr,
        ShrtNm,
        SnstvMobData,
        SoundActn,
        SoundCntt,
        SoundFrmt,
        SoundRef,
        SoundVol,
        SoundVolSpecified,
        SplmtryData,
        SpltPmt,
        SpltPmtSpecified,
        SpnsrdMrchnt,
        SpprtdOptn,
        SrcCcy,
        Srchrg,
        SrlNb,
        SsnKey,
        SsnMgmtReq,
        SsnMgmtRspn,
        StartDt,
        StdCmplc,
        StordValAcct,
        StordValAcctReq,
        StordValReq,
        StordValRspn,
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
        TaxIdNb,
        TaxTp,
        TermnlEnvt,
        TermnlEnvtSpecified,
        TermnlIntgtn,
        TermnlIntgtnSpecified,
        TermnlMgrId,
        Tkn,
        TknAssrncData,
        TknAssrncLvl,
        TknAssrncLvlSpecified,
        TknChrtc,
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
        Tp,
        TpSpecified,
        Tracblt,
        TracDtTmIn,
        TracDtTmOut,
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
        Txt,
        TxToPrfrm,
        TxTp,
        TxTtl,
        TxTtls,
        TxTtlsSet,
        TxVrfctnRslt,
        UattnddLvlCtgy,
        Unit,
        UnitNb,
        UnitOfMeasr,
        UnitOfMeasrSpecified,
        UnitPric,
        UnitPricSgn,
        UnitPricSgnSpecified,
        UnitPricSpecified,
        UnitSpecified,
        URLAdr,
        UsrNm,
        UTMCordints,
        UTMEstwrd,
        UTMNrthwrd,
        UTMZone,
        Val,
        ValAddedTax,
        ValAddedTaxSpecified,
        Value,
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
        WaitUsrVldtnFlg,
        WaitUsrVldtnFlgSpecified,
        WarmRstFlg,
        WarmRstFlgSpecified,
        Wllt,
        XchgId,
        XchgRate,
        XpctdLngth,
        XprtnDt,
        XprtnDtSpecified,
        XpryDt,
        XpryDtSpecified,
    }
}
#endif
