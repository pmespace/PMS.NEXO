#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("de9c4846-372b-40e2-a13a-0da646240f83")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReportResponseV02 : ISaleToPOIReportResponseV02 {
        private Header41 hdrField = new Header41();
        private ReportResponse3 rptRspnField = new ReportResponse3();
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
        public ReportResponse3 RptRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptRspnField = new ReportResponse3();
                }
                else {
                    this.rptRspnField = value;
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
                            || ((this.RptRspn != null)
                            && this.RptRspn.XSD_HasBeenSet))
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
                if ((this.RptRspn != null)) {
                    this.RptRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f7b9a63f-a160-4fc0-9f83-e0e28cdb65cd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportResponse3 : IReportResponse3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService7Code svcCnttField = default(RetailerService7Code);
        private ReportTransactionResponse2 rptTxRspnField = new ReportTransactionResponse2();
        private ReportGetTotalsResponse1 rptGetTtlsRspnField = new ReportGetTotalsResponse1();
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
        public RetailerService7Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        public ReportTransactionResponse2 RptTxRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptTxRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptTxRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptTxRspnField = new ReportTransactionResponse2();
                }
                else {
                    this.rptTxRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ReportGetTotalsResponse1 RptGetTtlsRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rptGetTtlsRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rptGetTtlsRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rptGetTtlsRspnField = new ReportGetTotalsResponse1();
                }
                else {
                    this.rptGetTtlsRspnField = value;
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
                return (((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.RptTxRspn != null)
                            && this.RptTxRspn.XSD_HasBeenSet))
                            || ((this.RptGetTtlsRspn != null)
                            && this.RptGetTtlsRspn.XSD_HasBeenSet))
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
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
                if ((this.RptTxRspn != null)) {
                    this.RptTxRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RptGetTtlsRspn != null)) {
                    this.RptGetTtlsRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService7Code {
        _begin,
        _none,
        /// <remarks/>
        RPTP,
        /// <remarks/>
        RPAP,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("55bed6f7-2b35-4b79-b9ff-81053b9ebfbd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportTransactionResponse2 : IReportTransactionResponse2 {
        private double rptFullSzField = default(double);
        private double blckStartField = default(double);
        private double blckStopField = default(double);
        private PointOfInteractionTransactionReport2[] txRptField = new PointOfInteractionTransactionReport2[0];
        private bool rptFullSzField_XSD_HasBeenSet = false;
        private bool blckStartField_XSD_HasBeenSet = false;
        private bool blckStopField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public double RptFullSz {
            get {
                return this.rptFullSzField;
            }
            set {
                this.rptFullSzField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.rptFullSzField_XSD_HasBeenSet = (this.rptFullSzField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double BlckStart {
            get {
                return this.blckStartField;
            }
            set {
                this.blckStartField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.blckStartField_XSD_HasBeenSet = (this.blckStartField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double BlckStop {
            get {
                return this.blckStopField;
            }
            set {
                this.blckStopField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.blckStopField_XSD_HasBeenSet = (this.blckStopField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxRpt")]
        public PointOfInteractionTransactionReport2[] TxRpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.txRptField == null)
                            || (this.txRptField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txRptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.txRptField = new PointOfInteractionTransactionReport2[0];
                }
                else {
                    this.txRptField = value;
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
                            || (this.TxRptSize() != 0))
                            || this.rptFullSzField_XSD_HasBeenSet)
                            || this.blckStartField_XSD_HasBeenSet)
                            || this.blckStopField_XSD_HasBeenSet);
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
                for (i = 0; (i < this.TxRptSize()); i = (i + 1)) {
                    this.TxRpt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int TxRptSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.txRptField == null)) {
                return 0;
            }
            else {
                return this.txRptField.Length;
            }
            // END ADDED BY XSD
        }
        public PointOfInteractionTransactionReport2 TxRptGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport2[]))) {
                    return default(PointOfInteractionTransactionReport2);
                }
                else {
                    if (((this.txRptField.Length - 1)
                                >= index)) {
                        return this.txRptField[index];
                    }
                    else {
                        return default(PointOfInteractionTransactionReport2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionTransactionReport2);
            }
            // END ADDED BY XSD
        }
        public bool TxRptSetItem(int index, PointOfInteractionTransactionReport2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport2[]))) {
                    return false;
                }
                else {
                    this.txRptField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxRptAddItem(PointOfInteractionTransactionReport2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport2[]))) {
                    return false;
                }
                else {
                    PointOfInteractionTransactionReport2[] array = new PointOfInteractionTransactionReport2[(this.txRptField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txRptField.Length); i = (i + 1)) {
                        array[i] = txRptField[i];
                    }
                    array[i] = value;
                    this.TxRpt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxRptRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport2[]))) {
                    return false;
                }
                else {
                    if ((this.txRptField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionTransactionReport2[] array = new PointOfInteractionTransactionReport2[(this.txRptField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txRptField[i];
                        }
                        for (i = (i + 1); (i < this.txRptField.Length); i = (i + 1)) {
                            array[i] = txRptField[i];
                        }
                        this.TxRpt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("36e30c1f-91fa-4c85-bffb-9b7654c46d2f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PointOfInteractionTransactionReport2 : IPointOfInteractionTransactionReport2 {
        private ResponseType9 rspnField = new ResponseType9();
        private PaymentResponse2 pmtRspnField = new PaymentResponse2();
        private bool _XSD_Optimizing = false;
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
        public PaymentResponse2 PmtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pmtRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtRspnField = new PaymentResponse2();
                }
                else {
                    this.pmtRspnField = value;
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
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || ((this.PmtRspn != null)
                            && this.PmtRspn.XSD_HasBeenSet));
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
                if ((this.PmtRspn != null)) {
                    this.PmtRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8b0175e0-60c3-4c39-883a-29172f2fca18")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportGetTotalsResponse1 : IReportGetTotalsResponse1 {
        private string pOIRcncltnIdField = default(string);
        private TransactionTotalsSet1[] txTtlsSetField = new TransactionTotalsSet1[0];
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
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
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxTtlsSet")]
        public TransactionTotalsSet1[] TxTtlsSet {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.txTtlsSetField == null)
                            || (this.txTtlsSetField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txTtlsSetField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.txTtlsSetField = new TransactionTotalsSet1[0];
                }
                else {
                    this.txTtlsSetField = value;
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
                            || (this.TxTtlsSetSize() != 0))
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
                int i = 0;
                for (i = 0; (i < this.TxTtlsSetSize()); i = (i + 1)) {
                    this.TxTtlsSet[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int TxTtlsSetSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.txTtlsSetField == null)) {
                return 0;
            }
            else {
                return this.txTtlsSetField.Length;
            }
            // END ADDED BY XSD
        }
        public TransactionTotalsSet1 TxTtlsSetGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return default(TransactionTotalsSet1);
                }
                else {
                    if (((this.txTtlsSetField.Length - 1)
                                >= index)) {
                        return this.txTtlsSetField[index];
                    }
                    else {
                        return default(TransactionTotalsSet1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TransactionTotalsSet1);
            }
            // END ADDED BY XSD
        }
        public bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    this.txTtlsSetField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxTtlsSetAddItem(TransactionTotalsSet1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txTtlsSetField.Length); i = (i + 1)) {
                        array[i] = txTtlsSetField[i];
                    }
                    array[i] = value;
                    this.TxTtlsSet = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxTtlsSetRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    if ((this.txTtlsSetField.Length <= index)) {
                        return false;
                    }
                    else {
                        TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txTtlsSetField[i];
                        }
                        for (i = (i + 1); (i < this.txTtlsSetField.Length); i = (i + 1)) {
                            array[i] = txTtlsSetField[i];
                        }
                        this.TxTtlsSet = array;
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
    [System.Runtime.InteropServices.GuidAttribute("77137e99-bf8b-467b-a899-33afa35cc2a8")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReportResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ReportResponse3 RptRspn {
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
    [System.Runtime.InteropServices.GuidAttribute("9156b8a6-19ba-47f0-9444-5f461a14e0fa")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportResponse3 {
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
        RetailerService7Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        ReportTransactionResponse2 RptTxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ReportGetTotalsResponse1 RptGetTtlsRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        ResponseType9 Rspn {
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
    [System.Runtime.InteropServices.GuidAttribute("a1d41abc-aac3-4193-8b05-de4bd2e484ed")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportTransactionResponse2 {
        /// <remarks/>
        [DispId(1)]
        double RptFullSz {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        double BlckStart {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        double BlckStop {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        PointOfInteractionTransactionReport2[] TxRpt {
            get;
            set;
        }
        [DispId(5)]
        int TxRptSize();
        [DispId(6)]
        PointOfInteractionTransactionReport2 TxRptGetItem(int index);
        [DispId(7)]
        bool TxRptSetItem(int index, PointOfInteractionTransactionReport2 value);
        [DispId(8)]
        bool TxRptAddItem(PointOfInteractionTransactionReport2 value);
        [DispId(9)]
        bool TxRptRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("7614453d-f490-4b43-a138-5eb5768dd73d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPointOfInteractionTransactionReport2 {
        /// <remarks/>
        [DispId(1)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        PaymentResponse2 PmtRspn {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("41c65fc3-4e62-49b7-a851-79ee959c1288")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportGetTotalsResponse1 {
        /// <remarks/>
        [DispId(1)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        TransactionTotalsSet1[] TxTtlsSet {
            get;
            set;
        }
        [DispId(3)]
        int TxTtlsSetSize();
        [DispId(4)]
        TransactionTotalsSet1 TxTtlsSetGetItem(int index);
        [DispId(5)]
        bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value);
        [DispId(6)]
        bool TxTtlsSetAddItem(TransactionTotalsSet1 value);
        [DispId(7)]
        bool TxTtlsSetRemoveItem(int index);
    }
}
#endif
