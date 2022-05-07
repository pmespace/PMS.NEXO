#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CustomerOrderRequest1Code {
        _begin,
        _none,
        /// <remarks/>
        BOTH,
        /// <remarks/>
        CLSD,
        /// <remarks/>
        OPEN,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("692db5cc-be24-47ad-9347-ae7dc4c98167")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DiagnosisRequest1 : IDiagnosisRequest1 {
        private bool hstDgnssFlgField = default(bool);
        private bool hstDgnssFlgFieldSpecified = false;
        private string[] acqrrIdField = new string[0];
        private bool hstDgnssFlgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public bool HstDgnssFlg {
            get {
                return this.hstDgnssFlgField;
            }
            set {
                this.hstDgnssFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - HstDgnssFlgSpecified = true
                this.HstDgnssFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool HstDgnssFlgSpecified {
            get {
                return this.hstDgnssFlgFieldSpecified;
            }
            set {
                this.hstDgnssFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcqrrId")]
        public string[] AcqrrId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.acqrrIdField == null)
                            || (this.acqrrIdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.acqrrIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.acqrrIdField = new string[0];
                }
                else {
                    this.acqrrIdField = value;
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
                            || (this.AcqrrIdSize() != 0))
                            || this.hstDgnssFlgField_XSD_HasBeenSet)
                            || this.HstDgnssFlgSpecified);
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
        public int AcqrrIdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.acqrrIdField == null)) {
                return 0;
            }
            else {
                return this.acqrrIdField.Length;
            }
            // END ADDED BY XSD
        }
        public string AcqrrIdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.acqrrIdField == default(string[]))) {
                    return default(string);
                }
                else {
                    if (((this.acqrrIdField.Length - 1)
                                >= index)) {
                        return this.acqrrIdField[index];
                    }
                    else {
                        return default(string);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(string);
            }
            // END ADDED BY XSD
        }
        public bool AcqrrIdSetItem(int index, string value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.acqrrIdField == default(string[]))) {
                    return false;
                }
                else {
                    this.acqrrIdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AcqrrIdAddItem(string value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.acqrrIdField == default(string[]))) {
                    return false;
                }
                else {
                    string[] array = new string[(this.acqrrIdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.acqrrIdField.Length); i = (i + 1)) {
                        array[i] = acqrrIdField[i];
                    }
                    array[i] = value;
                    this.AcqrrId = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AcqrrIdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.acqrrIdField == default(string[]))) {
                    return false;
                }
                else {
                    if ((this.acqrrIdField.Length <= index)) {
                        return false;
                    }
                    else {
                        string[] array = new string[(this.acqrrIdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = acqrrIdField[i];
                        }
                        for (i = (i + 1); (i < this.acqrrIdField.Length); i = (i + 1)) {
                            array[i] = acqrrIdField[i];
                        }
                        this.AcqrrId = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d9e82dab-522e-4859-b334-fbe2883be74f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOISessionManagementRequestV02 : ISaleToPOISessionManagementRequestV02 {
        private Header41 hdrField = new Header41();
        private SessionManagementRequest3 ssnMgmtReqField = new SessionManagementRequest3();
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
        public SessionManagementRequest3 SsnMgmtReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.ssnMgmtReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ssnMgmtReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ssnMgmtReqField = new SessionManagementRequest3();
                }
                else {
                    this.ssnMgmtReqField = value;
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
                            || ((this.SsnMgmtReq != null)
                            && this.SsnMgmtReq.XSD_HasBeenSet))
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
                if ((this.SsnMgmtReq != null)) {
                    this.SsnMgmtReq.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2ad768e6-c316-44e4-a890-ec619bcc6f81")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SessionManagementRequest3 : ISessionManagementRequest3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService4Code svcCnttField = default(RetailerService4Code);
        private LoginRequest2 lgnReqField = new LoginRequest2();
        private LogoutRequest1 lgtReqField = new LogoutRequest1();
        private DiagnosisRequest1 dgnssReqField = new DiagnosisRequest1();
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
        public RetailerService4Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        public LoginRequest2 LgnReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lgnReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lgnReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lgnReqField = new LoginRequest2();
                }
                else {
                    this.lgnReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LogoutRequest1 LgtReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lgtReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lgtReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lgtReqField = new LogoutRequest1();
                }
                else {
                    this.lgtReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DiagnosisRequest1 DgnssReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dgnssReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dgnssReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dgnssReqField = new DiagnosisRequest1();
                }
                else {
                    this.dgnssReqField = value;
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
                return (((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.LgnReq != null)
                            && this.LgnReq.XSD_HasBeenSet))
                            || ((this.LgtReq != null)
                            && this.LgtReq.XSD_HasBeenSet))
                            || ((this.DgnssReq != null)
                            && this.DgnssReq.XSD_HasBeenSet))
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
                if ((this.LgnReq != null)) {
                    this.LgnReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.LgtReq != null)) {
                    this.LgtReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.DgnssReq != null)) {
                    this.DgnssReq.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService4Code {
        _begin,
        _none,
        /// <remarks/>
        SMIQ,
        /// <remarks/>
        SMOQ,
        /// <remarks/>
        SMDQ,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("457382f5-e5a4-4781-8057-54e8973962f6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoginRequest2 : ILoginRequest2 {
        private string lgnDtTmField = default(string);
        private PointOfInteractionComponent10[] saleSftwrField = new PointOfInteractionComponent10[0];
        private SaleTerminalData1 saleTermnlDataField = new SaleTerminalData1();
        private bool trngMdFlgField = default(bool);
        private bool trngMdFlgFieldSpecified = false;
        private string cshrIdField = default(string);
        private string cshrLangField = default(string);
        private string shftNbField = default(string);
        private SaleTokenScope1Code tknReqdTpField = default(SaleTokenScope1Code);
        private bool tknReqdTpFieldSpecified = false;
        private CustomerOrderRequest1Code cstmrOrdrReqField = default(CustomerOrderRequest1Code);
        private bool cstmrOrdrReqFieldSpecified = false;
        private PointOfInteractionComponentIdentification1 pOIIdField = new PointOfInteractionComponentIdentification1();
        private string ttlsGrpIdField = default(string);
        private ActionMessage7 outptDispField = new ActionMessage7();
        private bool lgnDtTmField_XSD_HasBeenSet = false;
        private bool trngMdFlgField_XSD_HasBeenSet = false;
        private bool cshrIdField_XSD_HasBeenSet = false;
        private bool cshrLangField_XSD_HasBeenSet = false;
        private bool shftNbField_XSD_HasBeenSet = false;
        private bool tknReqdTpField_XSD_HasBeenSet = false;
        private bool cstmrOrdrReqField_XSD_HasBeenSet = false;
        private bool ttlsGrpIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string LgnDtTm {
            get {
                return this.lgnDtTmField;
            }
            set {
                this.lgnDtTmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.lgnDtTmField_XSD_HasBeenSet = (this.lgnDtTmField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleSftwr")]
        public PointOfInteractionComponent10[] SaleSftwr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.saleSftwrField == null)
                            || (this.saleSftwrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleSftwrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.saleSftwrField = new PointOfInteractionComponent10[0];
                }
                else {
                    this.saleSftwrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public SaleTerminalData1 SaleTermnlData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleTermnlDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleTermnlDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleTermnlDataField = new SaleTerminalData1();
                }
                else {
                    this.saleTermnlDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool TrngMdFlg {
            get {
                return this.trngMdFlgField;
            }
            set {
                this.trngMdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - TrngMdFlgSpecified = true
                this.TrngMdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool TrngMdFlgSpecified {
            get {
                return this.trngMdFlgFieldSpecified;
            }
            set {
                this.trngMdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CshrId {
            get {
                return this.cshrIdField;
            }
            set {
                this.cshrIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cshrIdField_XSD_HasBeenSet = (this.cshrIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string CshrLang {
            get {
                return this.cshrLangField;
            }
            set {
                this.cshrLangField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cshrLangField_XSD_HasBeenSet = (this.cshrLangField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string ShftNb {
            get {
                return this.shftNbField;
            }
            set {
                this.shftNbField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.shftNbField_XSD_HasBeenSet = (this.shftNbField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public SaleTokenScope1Code TknReqdTp {
            get {
                return this.tknReqdTpField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool TknReqdTpSpecified {
            get {
                return this.tknReqdTpFieldSpecified;
            }
            set {
                this.tknReqdTpFieldSpecified = value;
            }
        }
        /// <remarks/>
        public CustomerOrderRequest1Code CstmrOrdrReq {
            get {
                return this.cstmrOrdrReqField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool CstmrOrdrReqSpecified {
            get {
                return this.cstmrOrdrReqFieldSpecified;
            }
            set {
                this.cstmrOrdrReqFieldSpecified = value;
            }
        }
        /// <remarks/>
        public PointOfInteractionComponentIdentification1 POIId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOIIdField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOIIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOIIdField = new PointOfInteractionComponentIdentification1();
                }
                else {
                    this.pOIIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string TtlsGrpId {
            get {
                return this.ttlsGrpIdField;
            }
            set {
                this.ttlsGrpIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ttlsGrpIdField_XSD_HasBeenSet = (this.ttlsGrpIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ActionMessage7 OutptDisp {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.outptDispField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptDispField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptDispField = new ActionMessage7();
                }
                else {
                    this.outptDispField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((((((false
                            || ((this.SaleTermnlData != null)
                            && this.SaleTermnlData.XSD_HasBeenSet))
                            || ((this.POIId != null)
                            && this.POIId.XSD_HasBeenSet))
                            || ((this.OutptDisp != null)
                            && this.OutptDisp.XSD_HasBeenSet))
                            || (this.SaleSftwrSize() != 0))
                            || this.lgnDtTmField_XSD_HasBeenSet)
                            || this.trngMdFlgField_XSD_HasBeenSet)
                            || this.cshrIdField_XSD_HasBeenSet)
                            || this.cshrLangField_XSD_HasBeenSet)
                            || this.shftNbField_XSD_HasBeenSet)
                            || this.tknReqdTpField_XSD_HasBeenSet)
                            || this.cstmrOrdrReqField_XSD_HasBeenSet)
                            || this.ttlsGrpIdField_XSD_HasBeenSet)
                            || this.TrngMdFlgSpecified);
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
                if ((this.SaleTermnlData != null)) {
                    this.SaleTermnlData.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.POIId != null)) {
                    this.POIId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.OutptDisp != null)) {
                    this.OutptDisp.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.SaleSftwrSize()); i = (i + 1)) {
                    this.SaleSftwr[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SaleSftwrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.saleSftwrField == null)) {
                return 0;
            }
            else {
                return this.saleSftwrField.Length;
            }
            // END ADDED BY XSD
        }
        public PointOfInteractionComponent10 SaleSftwrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent10[]))) {
                    return default(PointOfInteractionComponent10);
                }
                else {
                    if (((this.saleSftwrField.Length - 1)
                                >= index)) {
                        return this.saleSftwrField[index];
                    }
                    else {
                        return default(PointOfInteractionComponent10);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionComponent10);
            }
            // END ADDED BY XSD
        }
        public bool SaleSftwrSetItem(int index, PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    this.saleSftwrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SaleSftwrAddItem(PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.saleSftwrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.saleSftwrField.Length); i = (i + 1)) {
                        array[i] = saleSftwrField[i];
                    }
                    array[i] = value;
                    this.SaleSftwr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SaleSftwrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    if ((this.saleSftwrField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.saleSftwrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = saleSftwrField[i];
                        }
                        for (i = (i + 1); (i < this.saleSftwrField.Length); i = (i + 1)) {
                            array[i] = saleSftwrField[i];
                        }
                        this.SaleSftwr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("420dbd62-b0ac-4a13-b606-0f047c34e003")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleTerminalData1 : ISaleTerminalData1 {
        private AttendanceContext1Code termnlEnvtField = default(AttendanceContext1Code);
        private bool termnlEnvtFieldSpecified = false;
        private string saleRcncltnIdField = default(string);
        private bool termnlEnvtField_XSD_HasBeenSet = false;
        private bool saleRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public AttendanceContext1Code TermnlEnvt {
            get {
                return this.termnlEnvtField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool TermnlEnvtSpecified {
            get {
                return this.termnlEnvtFieldSpecified;
            }
            set {
                this.termnlEnvtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string SaleRcncltnId {
            get {
                return this.saleRcncltnIdField;
            }
            set {
                this.saleRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.saleRcncltnIdField_XSD_HasBeenSet = (this.saleRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((false || this.termnlEnvtField_XSD_HasBeenSet)
                            || this.saleRcncltnIdField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d00b076c-2e48-4050-9972-a179f9e7fbd6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LogoutRequest1 : ILogoutRequest1 {
        private bool mntncAllwdField = default(bool);
        private bool mntncAllwdFieldSpecified = false;
        private bool mntncAllwdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public bool MntncAllwd {
            get {
                return this.mntncAllwdField;
            }
            set {
                this.mntncAllwdField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MntncAllwdSpecified = true
                this.MntncAllwdSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool MntncAllwdSpecified {
            get {
                return this.mntncAllwdFieldSpecified;
            }
            set {
                this.mntncAllwdFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((false || this.mntncAllwdField_XSD_HasBeenSet)
                            || this.MntncAllwdSpecified);
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
    [System.Runtime.InteropServices.GuidAttribute("5a3a679b-091a-4642-a2a2-911b7ffabcfb")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDiagnosisRequest1 {
        /// <remarks/>
        [DispId(1)]
        bool HstDgnssFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool HstDgnssFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string[] AcqrrId {
            get;
            set;
        }
        [DispId(4)]
        int AcqrrIdSize();
        [DispId(5)]
        string AcqrrIdGetItem(int index);
        [DispId(6)]
        bool AcqrrIdSetItem(int index, string value);
        [DispId(7)]
        bool AcqrrIdAddItem(string value);
        [DispId(8)]
        bool AcqrrIdRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("44d2f09f-6168-414a-9b4a-ec182b9b0435")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOISessionManagementRequestV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        SessionManagementRequest3 SsnMgmtReq {
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
    [System.Runtime.InteropServices.GuidAttribute("55b943c9-8436-4f9d-b66d-d77295f986f1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISessionManagementRequest3 {
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
        RetailerService4Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        LoginRequest2 LgnReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        LogoutRequest1 LgtReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        DiagnosisRequest1 DgnssReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(8)]
        int SplmtryDataSize();
        [DispId(9)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(10)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(11)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(12)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("2206c518-ff74-4416-adc2-85cb94991eea")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoginRequest2 {
        /// <remarks/>
        [DispId(1)]
        string LgnDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        PointOfInteractionComponent10[] SaleSftwr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SaleTerminalData1 SaleTermnlData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool TrngMdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool TrngMdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string CshrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        SaleTokenScope1Code TknReqdTp {
            get;
        }
        /// <remarks/>
        [DispId(10)]
        bool TknReqdTpSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        CustomerOrderRequest1Code CstmrOrdrReq {
            get;
        }
        /// <remarks/>
        [DispId(12)]
        bool CstmrOrdrReqSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        PointOfInteractionComponentIdentification1 POIId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(14)]
        string TtlsGrpId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        ActionMessage7 OutptDisp {
            get;
            set;
        }
        [DispId(16)]
        int SaleSftwrSize();
        [DispId(17)]
        PointOfInteractionComponent10 SaleSftwrGetItem(int index);
        [DispId(18)]
        bool SaleSftwrSetItem(int index, PointOfInteractionComponent10 value);
        [DispId(19)]
        bool SaleSftwrAddItem(PointOfInteractionComponent10 value);
        [DispId(20)]
        bool SaleSftwrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("1595c010-0775-45f3-b3c2-030bcf0a2b5e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleTerminalData1 {
        /// <remarks/>
        [DispId(1)]
        AttendanceContext1Code TermnlEnvt {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        bool TermnlEnvtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string SaleRcncltnId {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4e8705cd-67fd-41dc-a000-c67f453eed60")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILogoutRequest1 {
        /// <remarks/>
        [DispId(1)]
        bool MntncAllwd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool MntncAllwdSpecified {
            get;
            set;
        }
    }
}
#endif
