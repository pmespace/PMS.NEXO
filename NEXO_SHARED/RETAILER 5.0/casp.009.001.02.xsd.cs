#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("db55c919-ac81-4ab6-816b-4a7af7d80ef4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CriteriaOrder1 : ICriteriaOrder1 {
        private string trgtField = default(string);
        private bool trgtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                this.trgtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.trgtField_XSD_HasBeenSet = (this.trgtField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (false || this.trgtField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e976c7bd-1571-4dd6-b59a-17840b9b8b24")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReportRequestV02 : ISaleToPOIReportRequestV02 {
        private Header41 hdrField = new Header41();
        private ReportRequest3 rptReqField = new ReportRequest3();
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
        public ReportRequest3 RptReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptReqField = new ReportRequest3();
                }
                else {
                    this.rptReqField = value;
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
                            || ((this.RptReq != null)
                            && this.RptReq.XSD_HasBeenSet))
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
                if ((this.RptReq != null)) {
                    this.RptReq.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8c2a9a07-8f0f-44b7-88a1-975dc8d395e8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportRequest3 : IReportRequest3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService6Code svcCnttField = default(RetailerService6Code);
        private ReportTransactionRequest1 rptTxReqField = new ReportTransactionRequest1();
        private ReportGetTotalsRequest1 rptGetTtlsReqField = new ReportGetTotalsRequest1();
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
        public RetailerService6Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        public ReportTransactionRequest1 RptTxReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptTxReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptTxReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptTxReqField = new ReportTransactionRequest1();
                }
                else {
                    this.rptTxReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ReportGetTotalsRequest1 RptGetTtlsReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptGetTtlsReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptGetTtlsReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptGetTtlsReqField = new ReportGetTotalsRequest1();
                }
                else {
                    this.rptGetTtlsReqField = value;
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
                return ((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.RptTxReq != null)
                            && this.RptTxReq.XSD_HasBeenSet))
                            || ((this.RptGetTtlsReq != null)
                            && this.RptGetTtlsReq.XSD_HasBeenSet))
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
                if ((this.RptTxReq != null)) {
                    this.RptTxReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RptGetTtlsReq != null)) {
                    this.RptGetTtlsReq.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService6Code {
        _begin,
        _none,
        /// <remarks/>
        RPTQ,
        /// <remarks/>
        RPAQ,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("6a828399-d4b9-490b-80f2-0b33cf8c1e5e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportTransactionRequest1 : IReportTransactionRequest1 {
        private SearchAnd1[][][] schCritField = new SearchAnd1[0];
        private CriteriaOrder1[] schOutptOrdrField = new CriteriaOrder1[0];
        private bool dscndgOrdrField = default(bool);
        private bool dscndgOrdrFieldSpecified = false;
        private double blckStartField = default(double);
        private bool blckStartFieldSpecified = false;
        private double blckStopField = default(double);
        private bool blckStopFieldSpecified = false;
        private bool dscndgOrdrField_XSD_HasBeenSet = false;
        private bool blckStartField_XSD_HasBeenSet = false;
        private bool blckStopField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SchOr", typeof(SearchAnd1[]), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SchAnd", typeof(SearchAnd1), IsNullable=false, NestingLevel=1)]
        public SearchAnd1[][][] SchCrit {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.schCritField == null)
                            || (this.schCritField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.schCritField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.schCritField = new SearchAnd1[0][][];
                }
                else {
                    this.schCritField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CritOrdr", IsNullable=false)]
        public CriteriaOrder1[] SchOutptOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.schOutptOrdrField == null)
                            || (this.schOutptOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.schOutptOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.schOutptOrdrField = new CriteriaOrder1[0];
                }
                else {
                    this.schOutptOrdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool DscndgOrdr {
            get {
                return this.dscndgOrdrField;
            }
            set {
                this.dscndgOrdrField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - DscndgOrdrSpecified = true
                this.DscndgOrdrSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool DscndgOrdrSpecified {
            get {
                return this.dscndgOrdrFieldSpecified;
            }
            set {
                this.dscndgOrdrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double BlckStart {
            get {
                return this.blckStartField;
            }
            set {
                this.blckStartField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - BlckStartSpecified = true
                this.BlckStartSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool BlckStartSpecified {
            get {
                return this.blckStartFieldSpecified;
            }
            set {
                this.blckStartFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double BlckStop {
            get {
                return this.blckStopField;
            }
            set {
                this.blckStopField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - BlckStopSpecified = true
                this.BlckStopSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool BlckStopSpecified {
            get {
                return this.blckStopFieldSpecified;
            }
            set {
                this.blckStopFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((((false
                            || (this.SchCritSize() != 0))
                            || (this.SchOutptOrdrSize() != 0))
                            || this.dscndgOrdrField_XSD_HasBeenSet)
                            || this.blckStartField_XSD_HasBeenSet)
                            || this.blckStopField_XSD_HasBeenSet)
                            || this.DscndgOrdrSpecified)
                            || this.BlckStartSpecified)
                            || this.BlckStopSpecified);
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
                for (i = 0; (i < this.SchCritSize()); i = (i + 1)) {
                    this.SchCrit[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.SchOutptOrdrSize()); i = (i + 1)) {
                    this.SchOutptOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SchCritSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.schCritField == null)) {
                return 0;
            }
            else {
                return this.schCritField.Length;
            }
            // END ADDED BY XSD
        }
        public SearchAnd1 SchCritGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.schCritField == default(SearchAnd1[][][]))) {
                    return default(SearchAnd1);
                }
                else {
                    if (((this.schCritField.Length - 1)
                                >= index)) {
                        return this.schCritField[index];
                    }
                    else {
                        return default(SearchAnd1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(SearchAnd1);
            }
            // END ADDED BY XSD
        }
        public bool SchCritSetItem(int index, SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.schCritField == default(SearchAnd1[][][]))) {
                    return false;
                }
                else {
                    this.schCritField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchCritAddItem(SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.schCritField == default(SearchAnd1[][][]))) {
                    return false;
                }
                else {
                    SearchAnd1[][][] array = new SearchAnd1[(this.schCritField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.schCritField.Length); i = (i + 1)) {
                        array[i] = schCritField[i];
                    }
                    array[i] = value;
                    this.SchCrit = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchCritRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.schCritField == default(SearchAnd1[][][]))) {
                    return false;
                }
                else {
                    if ((this.schCritField.Length <= index)) {
                        return false;
                    }
                    else {
                        SearchAnd1[][][] array = new SearchAnd1[(this.schCritField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = schCritField[i];
                        }
                        for (i = (i + 1); (i < this.schCritField.Length); i = (i + 1)) {
                            array[i] = schCritField[i];
                        }
                        this.SchCrit = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int SchOutptOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.schOutptOrdrField == null)) {
                return 0;
            }
            else {
                return this.schOutptOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CriteriaOrder1 SchOutptOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.schOutptOrdrField == default(CriteriaOrder1[]))) {
                    return default(CriteriaOrder1);
                }
                else {
                    if (((this.schOutptOrdrField.Length - 1)
                                >= index)) {
                        return this.schOutptOrdrField[index];
                    }
                    else {
                        return default(CriteriaOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CriteriaOrder1);
            }
            // END ADDED BY XSD
        }
        public bool SchOutptOrdrSetItem(int index, CriteriaOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.schOutptOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    this.schOutptOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchOutptOrdrAddItem(CriteriaOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.schOutptOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    CriteriaOrder1[] array = new CriteriaOrder1[(this.schOutptOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.schOutptOrdrField.Length); i = (i + 1)) {
                        array[i] = schOutptOrdrField[i];
                    }
                    array[i] = value;
                    this.SchOutptOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchOutptOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.schOutptOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.schOutptOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CriteriaOrder1[] array = new CriteriaOrder1[(this.schOutptOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = schOutptOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.schOutptOrdrField.Length); i = (i + 1)) {
                            array[i] = schOutptOrdrField[i];
                        }
                        this.SchOutptOrdr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ca52e6a3-03b2-48fa-9dd1-293023b63a2d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchAnd1 : ISearchAnd1 {
        private string trgtField = default(string);
        private Operator1Code oprtrField = default(Operator1Code);
        private string valField = default(string);
        private bool trgtField_XSD_HasBeenSet = false;
        private bool oprtrField_XSD_HasBeenSet = false;
        private bool valField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                this.trgtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.trgtField_XSD_HasBeenSet = (this.trgtField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public Operator1Code Oprtr {
            get {
                return this.oprtrField;
            }
        }
        /// <remarks/>
        public string Val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.valField_XSD_HasBeenSet = (this.valField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false || this.trgtField_XSD_HasBeenSet)
                            || this.oprtrField_XSD_HasBeenSet)
                            || this.valField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Operator1Code {
        _begin,
        _none,
        /// <remarks/>
        SMAL,
        /// <remarks/>
        SMEQ,
        /// <remarks/>
        GREA,
        /// <remarks/>
        GREQ,
        /// <remarks/>
        EQAL,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("dcd25cc5-2614-4e1c-b363-2904830681f3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportGetTotalsRequest1 : IReportGetTotalsRequest1 {
        private TotalDetails1Code ttlDtlsField = default(TotalDetails1Code);
        private bool ttlDtlsFieldSpecified = false;
        private TotalFilter1 ttlFltrField = new TotalFilter1();
        private bool ttlDtlsField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TotalDetails1Code TtlDtls {
            get {
                return this.ttlDtlsField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool TtlDtlsSpecified {
            get {
                return this.ttlDtlsFieldSpecified;
            }
            set {
                this.ttlDtlsFieldSpecified = value;
            }
        }
        /// <remarks/>
        public TotalFilter1 TtlFltr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.ttlFltrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ttlFltrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ttlFltrField = new TotalFilter1();
                }
                else {
                    this.ttlFltrField = value;
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
                            || ((this.TtlFltr != null)
                            && this.TtlFltr.XSD_HasBeenSet))
                            || this.ttlDtlsField_XSD_HasBeenSet);
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
                if ((this.TtlFltr != null)) {
                    this.TtlFltr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TotalDetails1Code {
        _begin,
        _none,
        /// <remarks/>
        OPID,
        /// <remarks/>
        PIID,
        /// <remarks/>
        TGID,
        /// <remarks/>
        SNID,
        /// <remarks/>
        SAID,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7ea83db8-06b5-4739-b484-ebc492d4116a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TotalFilter1 : ITotalFilter1 {
        private string pOIIdField = default(string);
        private string saleIdField = default(string);
        private string cshrIdField = default(string);
        private string shftNbField = default(string);
        private string ttlsGrpIdField = default(string);
        private bool pOIIdField_XSD_HasBeenSet = false;
        private bool saleIdField_XSD_HasBeenSet = false;
        private bool cshrIdField_XSD_HasBeenSet = false;
        private bool shftNbField_XSD_HasBeenSet = false;
        private bool ttlsGrpIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string POIId {
            get {
                return this.pOIIdField;
            }
            set {
                this.pOIIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIIdField_XSD_HasBeenSet = (this.pOIIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string SaleId {
            get {
                return this.saleIdField;
            }
            set {
                this.saleIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.saleIdField_XSD_HasBeenSet = (this.saleIdField != default(string));
                // END ADDED BY XSD
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false || this.pOIIdField_XSD_HasBeenSet)
                            || this.saleIdField_XSD_HasBeenSet)
                            || this.cshrIdField_XSD_HasBeenSet)
                            || this.shftNbField_XSD_HasBeenSet)
                            || this.ttlsGrpIdField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("6fdad2ac-f98d-4aef-9f9e-e2797f13707b")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchCriteria1 : ISearchCriteria1 {
        private SearchAnd1[][] schOrField = new SearchAnd1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SchAnd", typeof(SearchAnd1), IsNullable=false)]
        public SearchAnd1[][] SchOr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.schOrField == null)
                            || (this.schOrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.schOrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.schOrField = new SearchAnd1[0][];
                }
                else {
                    this.schOrField = value;
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
                            || (this.SchOrSize() != 0));
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
                for (i = 0; (i < this.SchOrSize()); i = (i + 1)) {
                    this.SchOr[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SchOrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.schOrField == null)) {
                return 0;
            }
            else {
                return this.schOrField.Length;
            }
            // END ADDED BY XSD
        }
        public SearchAnd1 SchOrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.schOrField == default(SearchAnd1[][]))) {
                    return default(SearchAnd1);
                }
                else {
                    if (((this.schOrField.Length - 1)
                                >= index)) {
                        return this.schOrField[index];
                    }
                    else {
                        return default(SearchAnd1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(SearchAnd1);
            }
            // END ADDED BY XSD
        }
        public bool SchOrSetItem(int index, SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.schOrField == default(SearchAnd1[][]))) {
                    return false;
                }
                else {
                    this.schOrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchOrAddItem(SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.schOrField == default(SearchAnd1[][]))) {
                    return false;
                }
                else {
                    SearchAnd1[][] array = new SearchAnd1[(this.schOrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.schOrField.Length); i = (i + 1)) {
                        array[i] = schOrField[i];
                    }
                    array[i] = value;
                    this.SchOr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchOrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.schOrField == default(SearchAnd1[][]))) {
                    return false;
                }
                else {
                    if ((this.schOrField.Length <= index)) {
                        return false;
                    }
                    else {
                        SearchAnd1[][] array = new SearchAnd1[(this.schOrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = schOrField[i];
                        }
                        for (i = (i + 1); (i < this.schOrField.Length); i = (i + 1)) {
                            array[i] = schOrField[i];
                        }
                        this.SchOr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2fe880c5-f65b-419a-b9fc-d4d4e5e6c4c8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOr1 : ISearchOr1 {
        private SearchAnd1[] schAndField = new SearchAnd1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SchAnd")]
        public SearchAnd1[] SchAnd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.schAndField == null)
                            || (this.schAndField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.schAndField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.schAndField = new SearchAnd1[0];
                }
                else {
                    this.schAndField = value;
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
                            || (this.SchAndSize() != 0));
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
                for (i = 0; (i < this.SchAndSize()); i = (i + 1)) {
                    this.SchAnd[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SchAndSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.schAndField == null)) {
                return 0;
            }
            else {
                return this.schAndField.Length;
            }
            // END ADDED BY XSD
        }
        public SearchAnd1 SchAndGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.schAndField == default(SearchAnd1[]))) {
                    return default(SearchAnd1);
                }
                else {
                    if (((this.schAndField.Length - 1)
                                >= index)) {
                        return this.schAndField[index];
                    }
                    else {
                        return default(SearchAnd1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(SearchAnd1);
            }
            // END ADDED BY XSD
        }
        public bool SchAndSetItem(int index, SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.schAndField == default(SearchAnd1[]))) {
                    return false;
                }
                else {
                    this.schAndField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchAndAddItem(SearchAnd1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.schAndField == default(SearchAnd1[]))) {
                    return false;
                }
                else {
                    SearchAnd1[] array = new SearchAnd1[(this.schAndField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.schAndField.Length); i = (i + 1)) {
                        array[i] = schAndField[i];
                    }
                    array[i] = value;
                    this.SchAnd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SchAndRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.schAndField == default(SearchAnd1[]))) {
                    return false;
                }
                else {
                    if ((this.schAndField.Length <= index)) {
                        return false;
                    }
                    else {
                        SearchAnd1[] array = new SearchAnd1[(this.schAndField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = schAndField[i];
                        }
                        for (i = (i + 1); (i < this.schAndField.Length); i = (i + 1)) {
                            array[i] = schAndField[i];
                        }
                        this.SchAnd = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4d6c3734-c1f4-4169-b75b-a6d59e0342f8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOutputOrder1 : ISearchOutputOrder1 {
        private CriteriaOrder1[] critOrdrField = new CriteriaOrder1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CritOrdr")]
        public CriteriaOrder1[] CritOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.critOrdrField == null)
                            || (this.critOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.critOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.critOrdrField = new CriteriaOrder1[0];
                }
                else {
                    this.critOrdrField = value;
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
                            || (this.CritOrdrSize() != 0));
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
                for (i = 0; (i < this.CritOrdrSize()); i = (i + 1)) {
                    this.CritOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int CritOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.critOrdrField == null)) {
                return 0;
            }
            else {
                return this.critOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CriteriaOrder1 CritOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.critOrdrField == default(CriteriaOrder1[]))) {
                    return default(CriteriaOrder1);
                }
                else {
                    if (((this.critOrdrField.Length - 1)
                                >= index)) {
                        return this.critOrdrField[index];
                    }
                    else {
                        return default(CriteriaOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CriteriaOrder1);
            }
            // END ADDED BY XSD
        }
        public bool CritOrdrSetItem(int index, CriteriaOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.critOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    this.critOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CritOrdrAddItem(CriteriaOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.critOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    CriteriaOrder1[] array = new CriteriaOrder1[(this.critOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.critOrdrField.Length); i = (i + 1)) {
                        array[i] = critOrdrField[i];
                    }
                    array[i] = value;
                    this.CritOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CritOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.critOrdrField == default(CriteriaOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.critOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CriteriaOrder1[] array = new CriteriaOrder1[(this.critOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = critOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.critOrdrField.Length); i = (i + 1)) {
                            array[i] = critOrdrField[i];
                        }
                        this.CritOrdr = array;
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
    [System.Runtime.InteropServices.GuidAttribute("15b56f26-dabc-4c97-91e0-0ac6d8b0b38b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICriteriaOrder1 {
        /// <remarks/>
        [DispId(1)]
        string Trgt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("b7d42640-98b0-4d18-ad33-0bea9846a993")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReportRequestV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ReportRequest3 RptReq {
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
    [System.Runtime.InteropServices.GuidAttribute("9607e64f-e22b-41a0-8b6a-ce0f16afb38d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportRequest3 {
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
        RetailerService6Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        ReportTransactionRequest1 RptTxReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ReportGetTotalsRequest1 RptGetTtlsReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        SupplementaryData1[] SplmtryData {
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
    [System.Runtime.InteropServices.GuidAttribute("69c11992-ce1c-45dd-b4ae-dbdaabe8b1da")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportTransactionRequest1 {
        /// <remarks/>
        [DispId(1)]
        SearchAnd1[][][] SchCrit {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CriteriaOrder1[] SchOutptOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool DscndgOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool DscndgOrdrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        double BlckStart {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        bool BlckStartSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        double BlckStop {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        bool BlckStopSpecified {
            get;
            set;
        }
        [DispId(9)]
        int SchCritSize();
        [DispId(10)]
        SearchAnd1 SchCritGetItem(int index);
        [DispId(11)]
        bool SchCritSetItem(int index, SearchAnd1 value);
        [DispId(12)]
        bool SchCritAddItem(SearchAnd1 value);
        [DispId(13)]
        bool SchCritRemoveItem(int index);
        [DispId(14)]
        int SchOutptOrdrSize();
        [DispId(15)]
        CriteriaOrder1 SchOutptOrdrGetItem(int index);
        [DispId(16)]
        bool SchOutptOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(17)]
        bool SchOutptOrdrAddItem(CriteriaOrder1 value);
        [DispId(18)]
        bool SchOutptOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("e29ae91e-e814-426c-90a2-24084ade37e3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchAnd1 {
        /// <remarks/>
        [DispId(1)]
        string Trgt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        Operator1Code Oprtr {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        string Val {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2af496ff-dc6c-4d98-8c98-f2ffd699cd88")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportGetTotalsRequest1 {
        /// <remarks/>
        [DispId(1)]
        TotalDetails1Code TtlDtls {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        bool TtlDtlsSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TotalFilter1 TtlFltr {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("c71c60d0-e33a-4baf-94f8-3700f2154392")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITotalFilter1 {
        /// <remarks/>
        [DispId(1)]
        string POIId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string SaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string TtlsGrpId {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2b2d009e-4a33-4388-aee8-6bb6feea6f15")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchCriteria1 {
        /// <remarks/>
        [DispId(1)]
        SearchAnd1[][] SchOr {
            get;
            set;
        }
        [DispId(2)]
        int SchOrSize();
        [DispId(3)]
        SearchAnd1 SchOrGetItem(int index);
        [DispId(4)]
        bool SchOrSetItem(int index, SearchAnd1 value);
        [DispId(5)]
        bool SchOrAddItem(SearchAnd1 value);
        [DispId(6)]
        bool SchOrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("54cb5b58-8168-48b0-9eae-d4444ba7cd2a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchOr1 {
        /// <remarks/>
        [DispId(1)]
        SearchAnd1[] SchAnd {
            get;
            set;
        }
        [DispId(2)]
        int SchAndSize();
        [DispId(3)]
        SearchAnd1 SchAndGetItem(int index);
        [DispId(4)]
        bool SchAndSetItem(int index, SearchAnd1 value);
        [DispId(5)]
        bool SchAndAddItem(SearchAnd1 value);
        [DispId(6)]
        bool SchAndRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("71777609-fe1d-413f-b212-da47308f70eb")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchOutputOrder1 {
        /// <remarks/>
        [DispId(1)]
        CriteriaOrder1[] CritOrdr {
            get;
            set;
        }
        [DispId(2)]
        int CritOrdrSize();
        [DispId(3)]
        CriteriaOrder1 CritOrdrGetItem(int index);
        [DispId(4)]
        bool CritOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(5)]
        bool CritOrdrAddItem(CriteriaOrder1 value);
        [DispId(6)]
        bool CritOrdrRemoveItem(int index);
    }
}
#endif
