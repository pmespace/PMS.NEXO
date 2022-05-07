#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("00eee5e3-94e7-47ab-9572-9c43cfe86171")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReconciliationRequestV02 : ISaleToPOIReconciliationRequestV02 {
        private Header41 hdrField = new Header41();
        private ReconciliationRequest3 rcncltnReqField = new ReconciliationRequest3();
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
        public ReconciliationRequest3 RcncltnReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rcncltnReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rcncltnReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rcncltnReqField = new ReconciliationRequest3();
                }
                else {
                    this.rcncltnReqField = value;
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
                            || ((this.RcncltnReq != null)
                            && this.RcncltnReq.XSD_HasBeenSet))
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
                if ((this.RcncltnReq != null)) {
                    this.RcncltnReq.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("13181559-483f-4ed3-95aa-cd7b5368547b")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationRequest3 : IReconciliationRequest3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private ReconciliationRequestData1 rcncltnReqDataField = new ReconciliationRequestData1();
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
        public ReconciliationRequestData1 RcncltnReqData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rcncltnReqDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rcncltnReqDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rcncltnReqDataField = new ReconciliationRequestData1();
                }
                else {
                    this.rcncltnReqDataField = value;
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
                return ((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.RcncltnReqData != null)
                            && this.RcncltnReqData.XSD_HasBeenSet))
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
                if ((this.RcncltnReqData != null)) {
                    this.RcncltnReqData.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4b9e467d-a919-4e32-b047-971d27a9561e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationRequestData1 : IReconciliationRequestData1 {
        private ReconciliationType1Code rcncltnTpField = default(ReconciliationType1Code);
        private string acqrrIdField = default(string);
        private string pOIRcncltnIdField = default(string);
        private bool rcncltnTpField_XSD_HasBeenSet = false;
        private bool acqrrIdField_XSD_HasBeenSet = false;
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public ReconciliationType1Code RcncltnTp {
            get {
                return this.rcncltnTpField;
            }
        }
        /// <remarks/>
        public string AcqrrId {
            get {
                return this.acqrrIdField;
            }
            set {
                this.acqrrIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.acqrrIdField_XSD_HasBeenSet = (this.acqrrIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false || this.rcncltnTpField_XSD_HasBeenSet)
                            || this.acqrrIdField_XSD_HasBeenSet)
                            || this.pOIRcncltnIdField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.003.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ReconciliationType1Code {
        _begin,
        _none,
        /// <remarks/>
        AREC,
        /// <remarks/>
        ASYN,
        /// <remarks/>
        PREC,
        /// <remarks/>
        SREC,
        _end,
    }
    [System.Runtime.InteropServices.GuidAttribute("09a39c3b-2710-4ad7-8a49-fff5a2bbd53d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReconciliationRequestV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ReconciliationRequest3 RcncltnReq {
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
    [System.Runtime.InteropServices.GuidAttribute("9896af7b-df67-4aa6-9702-e2a166e4c000")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationRequest3 {
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
        ReconciliationRequestData1 RcncltnReqData {
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
        int SplmtryDataSize();
        [DispId(6)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(7)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(8)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(9)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("b4af99ed-701f-45b7-b3e4-43817bdd8c44")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationRequestData1 {
        /// <remarks/>
        [DispId(1)]
        ReconciliationType1Code RcncltnTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        string AcqrrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string POIRcncltnId {
            get;
            set;
        }
    }
}
#endif
