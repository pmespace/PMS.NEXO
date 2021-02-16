#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("67a9f0de-7ef8-4cf3-9f82-cfb29b44ec93")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CriteriaOrder1 : ICriteriaOrder1 {
        private string trgtField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.trgtField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b0115f37-4c81-49ba-8b6a-3b8ac264884a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReportRequestV01 : ISaleToPOIReportRequestV01 {
        private Header37 hdrField = new Header37();
        private ReportRequest2 rptReqField = new ReportRequest2();
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
        public ReportRequest2 RptReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rptReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptReqField = new ReportRequest2();
                }
                else {
                    this.rptReqField = value;
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
                            || this.RptReq.XSD_HasBeenSetProperty)
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
                    this.RptReq = null;
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
                if ((this.RptReq != null)) {
                    this.RptReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b49df343-a223-4439-9037-9cb6ad2eaae0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportRequest2 : IReportRequest2 {
        private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        private CardPaymentContext27 cntxtField = new CardPaymentContext27();
        private RetailerService6Code svcCnttField;
        private ReportTransactionRequest1 rptTxReqField = new ReportTransactionRequest1();
        private ReportGetTotalsRequest1 rptGetTtlsReqField = new ReportGetTotalsRequest1();
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
        public RetailerService6Code SvcCntt {
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
        public ReportTransactionRequest1 RptTxReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rptTxReqField.XSD_HasBeenSetProperty == false))) {
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rptGetTtlsReqField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
                            || this.Cntxt.XSD_HasBeenSetProperty)
                            || this.RptTxReq.XSD_HasBeenSetProperty)
                            || this.RptGetTtlsReq.XSD_HasBeenSetProperty);
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
                    this.RptTxReq = null;
                    this.RptGetTtlsReq = null;
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
                if ((this.RptTxReq != null)) {
                    this.RptTxReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.RptGetTtlsReq != null)) {
                    this.RptGetTtlsReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService6Code {
        /// <remarks/>
        RPTQ,
        /// <remarks/>
        RPAQ,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("21bde6d8-d5d6-4436-aa1b-86dafda135b8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportTransactionRequest1 : IReportTransactionRequest1 {
        private SearchAnd1[][][] schCritField = new SearchAnd1[0];
        private CriteriaOrder1[] schOutptOrdrField = new CriteriaOrder1[0];
        private bool dscndgOrdrField;
        private bool dscndgOrdrFieldSpecified;
        private double blckStartField;
        private bool blckStartFieldSpecified;
        private double blckStopField;
        private bool blckStopFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dscndgOrdrField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DscndgOrdrSpecified = true
                this.DscndgOrdrSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.blckStartField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BlckStartSpecified = true
                this.BlckStartSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.blckStopField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BlckStopSpecified = true
                this.BlckStopSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlckStopSpecified {
            get {
                return this.blckStopFieldSpecified;
            }
            set {
                this.blckStopFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.DscndgOrdrSpecified)
                            || this.BlckStartSpecified)
                            || this.BlckStopSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DscndgOrdrSpecified = false;
                    this.BlckStartSpecified = false;
                    this.BlckStopSpecified = false;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("cee9dea3-6303-45f1-8a8e-ea9eaf920fcd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchAnd1 : ISearchAnd1 {
        private string trgtField;
        private Operator1Code oprtrField;
        private string valField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.trgtField = value;
            }
        }
        /// <remarks/>
        public Operator1Code Oprtr {
            get {
                return this.oprtrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.oprtrField = value;
            }
        }
        /// <remarks/>
        public string Val {
            get {
                return this.valField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.valField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Operator1Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("49842ae5-e456-42fb-99f1-3d63bd92654a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportGetTotalsRequest1 : IReportGetTotalsRequest1 {
        private TotalDetails1Code ttlDtlsField;
        private bool ttlDtlsFieldSpecified;
        private TotalFilter1 ttlFltrField = new TotalFilter1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TotalDetails1Code TtlDtls {
            get {
                return this.ttlDtlsField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ttlDtlsField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - TtlDtlsSpecified = true
                this.TtlDtlsSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.ttlFltrField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.TtlFltr.XSD_HasBeenSetProperty)
                            || this.TtlDtlsSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.TtlFltr = null;
                    this.TtlDtlsSpecified = false;
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
                if ((this.TtlFltr != null)) {
                    this.TtlFltr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TotalDetails1Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c52bf99f-8488-4b33-bd21-143fc07a46c2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TotalFilter1 : ITotalFilter1 {
        private string pOIIdField;
        private string saleIdField;
        private string cshrIdField;
        private string shftNbField;
        private string ttlsGrpIdField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string POIId {
            get {
                return this.pOIIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIIdField = value;
            }
        }
        /// <remarks/>
        public string SaleId {
            get {
                return this.saleIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.saleIdField = value;
            }
        }
        /// <remarks/>
        public string CshrId {
            get {
                return this.cshrIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cshrIdField = value;
            }
        }
        /// <remarks/>
        public string ShftNb {
            get {
                return this.shftNbField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.shftNbField = value;
            }
        }
        /// <remarks/>
        public string TtlsGrpId {
            get {
                return this.ttlsGrpIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ttlsGrpIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("128b4482-0dae-4aa8-bf17-e333767e39a7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchCriteria1 : ISearchCriteria1 {
        private SearchAnd1[][] schOrField = new SearchAnd1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e97b143f-a1fd-4dc8-9078-55ef88c66987")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOr1 : ISearchOr1 {
        private SearchAnd1[] schAndField = new SearchAnd1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8c8fda9c-6edc-4f93-87fb-754d1ecff7dc")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOutputOrder1 : ISearchOutputOrder1 {
        private CriteriaOrder1[] critOrdrField = new CriteriaOrder1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
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
    [System.Runtime.InteropServices.GuidAttribute("3e0b10f6-1482-46bb-b1c3-662d4185138d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICriteriaOrder1 {
        /// <remarks/>
        [DispId(1)]
        string Trgt {
            get;
            set;
        }
        [DispId(2)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8dc56f6a-ad17-49b8-82be-6052202d0984")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReportRequestV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ReportRequest2 RptReq {
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
    [System.Runtime.InteropServices.GuidAttribute("5afa5fb0-1457-44fe-9451-47a90dc4b097")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportRequest2 {
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
        RetailerService6Code SvcCntt {
            get;
            set;
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
        bool XSD_HasBeenSetProperty {
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
    [System.Runtime.InteropServices.GuidAttribute("d8cc0a6f-d2a6-40f1-af4f-bd43f92e1be8")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(10)]
        int SchCritSize();
        [DispId(11)]
        SearchAnd1 SchCritGetItem(int index);
        [DispId(12)]
        bool SchCritSetItem(int index, SearchAnd1 value);
        [DispId(13)]
        bool SchCritAddItem(SearchAnd1 value);
        [DispId(14)]
        bool SchCritRemoveItem(int index);
        [DispId(15)]
        int SchOutptOrdrSize();
        [DispId(16)]
        CriteriaOrder1 SchOutptOrdrGetItem(int index);
        [DispId(17)]
        bool SchOutptOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(18)]
        bool SchOutptOrdrAddItem(CriteriaOrder1 value);
        [DispId(19)]
        bool SchOutptOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("0ef27489-74f3-48b6-b3d6-aa4cf5c97a26")]
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
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string Val {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2268167f-8214-4c45-8740-e4eac00314b2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportGetTotalsRequest1 {
        /// <remarks/>
        [DispId(1)]
        TotalDetails1Code TtlDtls {
            get;
            set;
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
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6127b2cb-8e4e-4d6d-9b91-0c32ec275020")]
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
        [DispId(6)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("db94e21c-775e-41a4-b1ca-8a58832249c1")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int SchOrSize();
        [DispId(4)]
        SearchAnd1 SchOrGetItem(int index);
        [DispId(5)]
        bool SchOrSetItem(int index, SearchAnd1 value);
        [DispId(6)]
        bool SchOrAddItem(SearchAnd1 value);
        [DispId(7)]
        bool SchOrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("4066eefe-84cf-4bfc-ad80-4f03c0b04205")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int SchAndSize();
        [DispId(4)]
        SearchAnd1 SchAndGetItem(int index);
        [DispId(5)]
        bool SchAndSetItem(int index, SearchAnd1 value);
        [DispId(6)]
        bool SchAndAddItem(SearchAnd1 value);
        [DispId(7)]
        bool SchAndRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("1ad21fe3-1255-4923-9d57-374b234497a5")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int CritOrdrSize();
        [DispId(4)]
        CriteriaOrder1 CritOrdrGetItem(int index);
        [DispId(5)]
        bool CritOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(6)]
        bool CritOrdrAddItem(CriteriaOrder1 value);
        [DispId(7)]
        bool CritOrdrRemoveItem(int index);
    }
}
#endif
