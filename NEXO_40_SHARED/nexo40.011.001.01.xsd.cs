#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("eb51ff81-7601-45c7-ab14-05a78e482ea2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AbortData1 : IAbortData1 {
        private string xchgIdField;
        private string abrtRsnField;
        private ActionMessage6 dispOutptField = new ActionMessage6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public string AbrtRsn {
            get {
                return this.abrtRsnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.abrtRsnField = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dispOutptField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage6();
                }
                else {
                    this.dispOutptField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DispOutpt = null;
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("51ec0adf-d846-43a9-8811-43089ebfa81a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIAbortV01 : ISaleToPOIAbortV01 {
        private Header37 hdrField = new Header37();
        private SystemAbort2 abrtField = new SystemAbort2();
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
        public SystemAbort2 Abrt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.abrtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.abrtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.abrtField = new SystemAbort2();
                }
                else {
                    this.abrtField = value;
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
                            || this.Abrt.XSD_HasBeenSetProperty)
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
                    this.Abrt = null;
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
                if ((this.Abrt != null)) {
                    this.Abrt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ca25e061-9bf6-4628-a336-59873cf0e9f8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SystemAbort2 : ISystemAbort2 {
        private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        private CardPaymentContext27 cntxtField = new CardPaymentContext27();
        private AbortData1 sysAbrtField = new AbortData1();
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
        public AbortData1 SysAbrt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.sysAbrtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.sysAbrtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.sysAbrtField = new AbortData1();
                }
                else {
                    this.sysAbrtField = value;
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
                return (((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
                            || this.Cntxt.XSD_HasBeenSetProperty)
                            || this.SysAbrt.XSD_HasBeenSetProperty);
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
                    this.SysAbrt = null;
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
                if ((this.SysAbrt != null)) {
                    this.SysAbrt.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
    [System.Runtime.InteropServices.GuidAttribute("6b40d0a4-3f99-4817-a1a2-28626ebcf520")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAbortData1 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string AbrtRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("e8f3b088-bfe2-4a75-92bf-487ad87f8f63")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIAbortV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        SystemAbort2 Abrt {
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
    [System.Runtime.InteropServices.GuidAttribute("3068e8cb-be83-41ec-995d-19d05b5e5eb4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISystemAbort2 {
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
        AbortData1 SysAbrt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
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
}
#endif