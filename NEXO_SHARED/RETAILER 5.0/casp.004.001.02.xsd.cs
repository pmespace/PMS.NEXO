#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c1df7f46-7e04-4ba4-be1c-d176a21d9918")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReconciliationResponseV02 : ISaleToPOIReconciliationResponseV02 {
        private Header41 hdrField = new Header41();
        private ReconciliationResponse4 rcncltnRspnField = new ReconciliationResponse4();
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
        public ReconciliationResponse4 RcncltnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rcncltnRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rcncltnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rcncltnRspnField = new ReconciliationResponse4();
                }
                else {
                    this.rcncltnRspnField = value;
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
                            || ((this.RcncltnRspn != null)
                            && this.RcncltnRspn.XSD_HasBeenSet))
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
                if ((this.RcncltnRspn != null)) {
                    this.RcncltnRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3da250e2-94f1-4b52-9bd2-0533952b44c8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationResponse4 : IReconciliationResponse4 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private ReconciliationResponseData1 rcncltnRspnDataField = new ReconciliationResponseData1();
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
        public ReconciliationResponseData1 RcncltnRspnData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rcncltnRspnDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rcncltnRspnDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rcncltnRspnDataField = new ReconciliationResponseData1();
                }
                else {
                    this.rcncltnRspnDataField = value;
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
                            || ((this.RcncltnRspnData != null)
                            && this.RcncltnRspnData.XSD_HasBeenSet))
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
                if ((this.RcncltnRspnData != null)) {
                    this.RcncltnRspnData.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("511ed7f7-f10c-4e82-9d95-1d2d6085bb9e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationResponseData1 : IReconciliationResponseData1 {
        private ReconciliationType1Code rcncltnTpField = default(ReconciliationType1Code);
        private string pOIRcncltnIdField = default(string);
        private TransactionTotalsSet1[] txTtlsField = new TransactionTotalsSet1[0];
        private bool rcncltnTpField_XSD_HasBeenSet = false;
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public ReconciliationType1Code RcncltnTp {
            get {
                return this.rcncltnTpField;
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
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxTtls")]
        public TransactionTotalsSet1[] TxTtls {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.txTtlsField == null)
                            || (this.txTtlsField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txTtlsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.txTtlsField = new TransactionTotalsSet1[0];
                }
                else {
                    this.txTtlsField = value;
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
                            || (this.TxTtlsSize() != 0))
                            || this.rcncltnTpField_XSD_HasBeenSet)
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
                for (i = 0; (i < this.TxTtlsSize()); i = (i + 1)) {
                    this.TxTtls[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int TxTtlsSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.txTtlsField == null)) {
                return 0;
            }
            else {
                return this.txTtlsField.Length;
            }
            // END ADDED BY XSD
        }
        public TransactionTotalsSet1 TxTtlsGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.txTtlsField == default(TransactionTotalsSet1[]))) {
                    return default(TransactionTotalsSet1);
                }
                else {
                    if (((this.txTtlsField.Length - 1)
                                >= index)) {
                        return this.txTtlsField[index];
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
        public bool TxTtlsSetItem(int index, TransactionTotalsSet1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.txTtlsField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    this.txTtlsField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxTtlsAddItem(TransactionTotalsSet1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.txTtlsField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txTtlsField.Length); i = (i + 1)) {
                        array[i] = txTtlsField[i];
                    }
                    array[i] = value;
                    this.TxTtls = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxTtlsRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.txTtlsField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    if ((this.txTtlsField.Length <= index)) {
                        return false;
                    }
                    else {
                        TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txTtlsField[i];
                        }
                        for (i = (i + 1); (i < this.txTtlsField.Length); i = (i + 1)) {
                            array[i] = txTtlsField[i];
                        }
                        this.TxTtls = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bbdc29aa-70a0-43c8-b023-5a8dd51c82d1")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransactionTotalsSet1 : ITransactionTotalsSet1 {
        private PaymentInstrumentType1Code pmtInstrmTpField = default(PaymentInstrumentType1Code);
        private string acqrrIdField = default(string);
        private string rcncltnIdField = default(string);
        private string saleRcncltnIdField = default(string);
        private string brndField = default(string);
        private string pOIIdField = default(string);
        private string saleIdField = default(string);
        private string cshrIdField = default(string);
        private string shftNbField = default(string);
        private Organisation26[] spnsrdMrchntField = new Organisation26[0];
        private TransactionTotals8 txTtlField = new TransactionTotals8();
        private LoyaltyTransactionTotals1[] lltyTxTtlField = new LoyaltyTransactionTotals1[0];
        private bool pmtInstrmTpField_XSD_HasBeenSet = false;
        private bool acqrrIdField_XSD_HasBeenSet = false;
        private bool rcncltnIdField_XSD_HasBeenSet = false;
        private bool saleRcncltnIdField_XSD_HasBeenSet = false;
        private bool brndField_XSD_HasBeenSet = false;
        private bool pOIIdField_XSD_HasBeenSet = false;
        private bool saleIdField_XSD_HasBeenSet = false;
        private bool cshrIdField_XSD_HasBeenSet = false;
        private bool shftNbField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public PaymentInstrumentType1Code PmtInstrmTp {
            get {
                return this.pmtInstrmTpField;
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
        public string RcncltnId {
            get {
                return this.rcncltnIdField;
            }
            set {
                this.rcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.rcncltnIdField_XSD_HasBeenSet = (this.rcncltnIdField != default(string));
                // END ADDED BY XSD
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
        /// <remarks/>
        public string Brnd {
            get {
                return this.brndField;
            }
            set {
                this.brndField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.brndField_XSD_HasBeenSet = (this.brndField != default(string));
                // END ADDED BY XSD
            }
        }
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
        [System.Xml.Serialization.XmlElementAttribute("SpnsrdMrchnt")]
        public Organisation26[] SpnsrdMrchnt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.spnsrdMrchntField == null)
                            || (this.spnsrdMrchntField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.spnsrdMrchntField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.spnsrdMrchntField = new Organisation26[0];
                }
                else {
                    this.spnsrdMrchntField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionTotals8 TxTtl {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.txTtlField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txTtlField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.txTtlField = new TransactionTotals8();
                }
                else {
                    this.txTtlField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyTxTtl")]
        public LoyaltyTransactionTotals1[] LltyTxTtl {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.lltyTxTtlField == null)
                            || (this.lltyTxTtlField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyTxTtlField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.lltyTxTtlField = new LoyaltyTransactionTotals1[0];
                }
                else {
                    this.lltyTxTtlField = value;
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
                            || ((this.TxTtl != null)
                            && this.TxTtl.XSD_HasBeenSet))
                            || (this.SpnsrdMrchntSize() != 0))
                            || (this.LltyTxTtlSize() != 0))
                            || this.pmtInstrmTpField_XSD_HasBeenSet)
                            || this.acqrrIdField_XSD_HasBeenSet)
                            || this.rcncltnIdField_XSD_HasBeenSet)
                            || this.saleRcncltnIdField_XSD_HasBeenSet)
                            || this.brndField_XSD_HasBeenSet)
                            || this.pOIIdField_XSD_HasBeenSet)
                            || this.saleIdField_XSD_HasBeenSet)
                            || this.cshrIdField_XSD_HasBeenSet)
                            || this.shftNbField_XSD_HasBeenSet);
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
                if ((this.TxTtl != null)) {
                    this.TxTtl.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.SpnsrdMrchntSize()); i = (i + 1)) {
                    this.SpnsrdMrchnt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.LltyTxTtlSize()); i = (i + 1)) {
                    this.LltyTxTtl[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int SpnsrdMrchntSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.spnsrdMrchntField == null)) {
                return 0;
            }
            else {
                return this.spnsrdMrchntField.Length;
            }
            // END ADDED BY XSD
        }
        public Organisation26 SpnsrdMrchntGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.spnsrdMrchntField == default(Organisation26[]))) {
                    return default(Organisation26);
                }
                else {
                    if (((this.spnsrdMrchntField.Length - 1)
                                >= index)) {
                        return this.spnsrdMrchntField[index];
                    }
                    else {
                        return default(Organisation26);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Organisation26);
            }
            // END ADDED BY XSD
        }
        public bool SpnsrdMrchntSetItem(int index, Organisation26 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.spnsrdMrchntField == default(Organisation26[]))) {
                    return false;
                }
                else {
                    this.spnsrdMrchntField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SpnsrdMrchntAddItem(Organisation26 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.spnsrdMrchntField == default(Organisation26[]))) {
                    return false;
                }
                else {
                    Organisation26[] array = new Organisation26[(this.spnsrdMrchntField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.spnsrdMrchntField.Length); i = (i + 1)) {
                        array[i] = spnsrdMrchntField[i];
                    }
                    array[i] = value;
                    this.SpnsrdMrchnt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SpnsrdMrchntRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.spnsrdMrchntField == default(Organisation26[]))) {
                    return false;
                }
                else {
                    if ((this.spnsrdMrchntField.Length <= index)) {
                        return false;
                    }
                    else {
                        Organisation26[] array = new Organisation26[(this.spnsrdMrchntField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = spnsrdMrchntField[i];
                        }
                        for (i = (i + 1); (i < this.spnsrdMrchntField.Length); i = (i + 1)) {
                            array[i] = spnsrdMrchntField[i];
                        }
                        this.SpnsrdMrchnt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int LltyTxTtlSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.lltyTxTtlField == null)) {
                return 0;
            }
            else {
                return this.lltyTxTtlField.Length;
            }
            // END ADDED BY XSD
        }
        public LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[]))) {
                    return default(LoyaltyTransactionTotals1);
                }
                else {
                    if (((this.lltyTxTtlField.Length - 1)
                                >= index)) {
                        return this.lltyTxTtlField[index];
                    }
                    else {
                        return default(LoyaltyTransactionTotals1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyTransactionTotals1);
            }
            // END ADDED BY XSD
        }
        public bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[]))) {
                    return false;
                }
                else {
                    this.lltyTxTtlField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[]))) {
                    return false;
                }
                else {
                    LoyaltyTransactionTotals1[] array = new LoyaltyTransactionTotals1[(this.lltyTxTtlField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.lltyTxTtlField.Length); i = (i + 1)) {
                        array[i] = lltyTxTtlField[i];
                    }
                    array[i] = value;
                    this.LltyTxTtl = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyTxTtlRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.lltyTxTtlField == default(LoyaltyTransactionTotals1[]))) {
                    return false;
                }
                else {
                    if ((this.lltyTxTtlField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyTransactionTotals1[] array = new LoyaltyTransactionTotals1[(this.lltyTxTtlField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = lltyTxTtlField[i];
                        }
                        for (i = (i + 1); (i < this.lltyTxTtlField.Length); i = (i + 1)) {
                            array[i] = lltyTxTtlField[i];
                        }
                        this.LltyTxTtl = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PaymentInstrumentType1Code {
        _begin,
        _none,
        /// <remarks/>
        CARD,
        /// <remarks/>
        CASH,
        /// <remarks/>
        CHCK,
        /// <remarks/>
        LOYT,
        /// <remarks/>
        SVAC,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7e210be3-60f1-4c6e-be54-0206505dce34")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransactionTotals8 : ITransactionTotals8 {
        private string pOIGrpIdField = default(string);
        private string cardPdctPrflField = default(string);
        private string ccyField = default(string);
        private TypeTransactionTotals3Code tpField = default(TypeTransactionTotals3Code);
        private double ttlNbField = default(double);
        private double cmltvAmtField = default(double);
        private DetailedAmount15 dtldAmtField = new DetailedAmount15();
        private bool pOIGrpIdField_XSD_HasBeenSet = false;
        private bool cardPdctPrflField_XSD_HasBeenSet = false;
        private bool ccyField_XSD_HasBeenSet = false;
        private bool tpField_XSD_HasBeenSet = false;
        private bool ttlNbField_XSD_HasBeenSet = false;
        private bool cmltvAmtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string POIGrpId {
            get {
                return this.pOIGrpIdField;
            }
            set {
                this.pOIGrpIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIGrpIdField_XSD_HasBeenSet = (this.pOIGrpIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string CardPdctPrfl {
            get {
                return this.cardPdctPrflField;
            }
            set {
                this.cardPdctPrflField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cardPdctPrflField_XSD_HasBeenSet = (this.cardPdctPrflField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.ccyField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ccyField_XSD_HasBeenSet = (this.ccyField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TypeTransactionTotals3Code Tp {
            get {
                return this.tpField;
            }
        }
        /// <remarks/>
        public double TtlNb {
            get {
                return this.ttlNbField;
            }
            set {
                this.ttlNbField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ttlNbField_XSD_HasBeenSet = (this.ttlNbField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double CmltvAmt {
            get {
                return this.cmltvAmtField;
            }
            set {
                this.cmltvAmtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cmltvAmtField_XSD_HasBeenSet = (this.cmltvAmtField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DetailedAmount15 DtldAmt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dtldAmtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dtldAmtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dtldAmtField = new DetailedAmount15();
                }
                else {
                    this.dtldAmtField = value;
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
                            || ((this.DtldAmt != null)
                            && this.DtldAmt.XSD_HasBeenSet))
                            || this.pOIGrpIdField_XSD_HasBeenSet)
                            || this.cardPdctPrflField_XSD_HasBeenSet)
                            || this.ccyField_XSD_HasBeenSet)
                            || this.tpField_XSD_HasBeenSet)
                            || this.ttlNbField_XSD_HasBeenSet)
                            || this.cmltvAmtField_XSD_HasBeenSet);
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
                if ((this.DtldAmt != null)) {
                    this.DtldAmt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TypeTransactionTotals3Code {
        _begin,
        _none,
        /// <remarks/>
        CRDT,
        /// <remarks/>
        CRDR,
        /// <remarks/>
        DEBT,
        /// <remarks/>
        DBTR,
        /// <remarks/>
        DECL,
        /// <remarks/>
        FAIL,
        /// <remarks/>
        RESV,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("701c96e3-05d3-4d91-af97-a43a786642ff")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyTransactionTotals1 : ILoyaltyTransactionTotals1 {
        private string pOIGrpIdField = default(string);
        private AmountUnit1Code lltyUnitField = default(AmountUnit1Code);
        private bool lltyUnitFieldSpecified = false;
        private string cardPdctPrflField = default(string);
        private string ccyField = default(string);
        private LoyaltyTypeTransactionTotals1Code txTpField = default(LoyaltyTypeTransactionTotals1Code);
        private double ttlNbField = default(double);
        private double cmltvAmtField = default(double);
        private DetailedAmount15 dtldAmtField = new DetailedAmount15();
        private bool pOIGrpIdField_XSD_HasBeenSet = false;
        private bool lltyUnitField_XSD_HasBeenSet = false;
        private bool cardPdctPrflField_XSD_HasBeenSet = false;
        private bool ccyField_XSD_HasBeenSet = false;
        private bool txTpField_XSD_HasBeenSet = false;
        private bool ttlNbField_XSD_HasBeenSet = false;
        private bool cmltvAmtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string POIGrpId {
            get {
                return this.pOIGrpIdField;
            }
            set {
                this.pOIGrpIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIGrpIdField_XSD_HasBeenSet = (this.pOIGrpIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public AmountUnit1Code LltyUnit {
            get {
                return this.lltyUnitField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool LltyUnitSpecified {
            get {
                return this.lltyUnitFieldSpecified;
            }
            set {
                this.lltyUnitFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CardPdctPrfl {
            get {
                return this.cardPdctPrflField;
            }
            set {
                this.cardPdctPrflField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cardPdctPrflField_XSD_HasBeenSet = (this.cardPdctPrflField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.ccyField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ccyField_XSD_HasBeenSet = (this.ccyField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyTypeTransactionTotals1Code TxTp {
            get {
                return this.txTpField;
            }
        }
        /// <remarks/>
        public double TtlNb {
            get {
                return this.ttlNbField;
            }
            set {
                this.ttlNbField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ttlNbField_XSD_HasBeenSet = (this.ttlNbField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double CmltvAmt {
            get {
                return this.cmltvAmtField;
            }
            set {
                this.cmltvAmtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cmltvAmtField_XSD_HasBeenSet = (this.cmltvAmtField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DetailedAmount15 DtldAmt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dtldAmtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dtldAmtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dtldAmtField = new DetailedAmount15();
                }
                else {
                    this.dtldAmtField = value;
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
                            || ((this.DtldAmt != null)
                            && this.DtldAmt.XSD_HasBeenSet))
                            || this.pOIGrpIdField_XSD_HasBeenSet)
                            || this.lltyUnitField_XSD_HasBeenSet)
                            || this.cardPdctPrflField_XSD_HasBeenSet)
                            || this.ccyField_XSD_HasBeenSet)
                            || this.txTpField_XSD_HasBeenSet)
                            || this.ttlNbField_XSD_HasBeenSet)
                            || this.cmltvAmtField_XSD_HasBeenSet);
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
                if ((this.DtldAmt != null)) {
                    this.DtldAmt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum LoyaltyTypeTransactionTotals1Code {
        _begin,
        _none,
        /// <remarks/>
        AWRD,
        /// <remarks/>
        REBA,
        /// <remarks/>
        REDE,
        /// <remarks/>
        AWRR,
        /// <remarks/>
        REBR,
        /// <remarks/>
        REDR,
        _end,
    }
    [System.Runtime.InteropServices.GuidAttribute("9f9c711a-d462-4c55-b90e-f1f384f5d9da")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReconciliationResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ReconciliationResponse4 RcncltnRspn {
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
    [System.Runtime.InteropServices.GuidAttribute("8384b375-e4a2-4d67-b06e-8e6a614fcbd5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationResponse4 {
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
        ReconciliationResponseData1 RcncltnRspnData {
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
    [System.Runtime.InteropServices.GuidAttribute("68515e12-84d0-442d-85e0-0b601db6337e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationResponseData1 {
        /// <remarks/>
        [DispId(1)]
        ReconciliationType1Code RcncltnTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionTotalsSet1[] TxTtls {
            get;
            set;
        }
        [DispId(4)]
        int TxTtlsSize();
        [DispId(5)]
        TransactionTotalsSet1 TxTtlsGetItem(int index);
        [DispId(6)]
        bool TxTtlsSetItem(int index, TransactionTotalsSet1 value);
        [DispId(7)]
        bool TxTtlsAddItem(TransactionTotalsSet1 value);
        [DispId(8)]
        bool TxTtlsRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("4798238b-5d64-4047-a1fa-5388ffac6610")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITransactionTotalsSet1 {
        /// <remarks/>
        [DispId(1)]
        PaymentInstrumentType1Code PmtInstrmTp {
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
        string RcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string SaleRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string Brnd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        string POIId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string SaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        Organisation26[] SpnsrdMrchnt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        TransactionTotals8 TxTtl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        LoyaltyTransactionTotals1[] LltyTxTtl {
            get;
            set;
        }
        [DispId(13)]
        int SpnsrdMrchntSize();
        [DispId(14)]
        Organisation26 SpnsrdMrchntGetItem(int index);
        [DispId(15)]
        bool SpnsrdMrchntSetItem(int index, Organisation26 value);
        [DispId(16)]
        bool SpnsrdMrchntAddItem(Organisation26 value);
        [DispId(17)]
        bool SpnsrdMrchntRemoveItem(int index);
        [DispId(18)]
        int LltyTxTtlSize();
        [DispId(19)]
        LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index);
        [DispId(20)]
        bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value);
        [DispId(21)]
        bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value);
        [DispId(22)]
        bool LltyTxTtlRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("f7c0cdc9-ed76-4804-bb8f-6a2b3be87793")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITransactionTotals8 {
        /// <remarks/>
        [DispId(1)]
        string POIGrpId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string CardPdctPrfl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        TypeTransactionTotals3Code Tp {
            get;
        }
        /// <remarks/>
        [DispId(5)]
        double TtlNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        double CmltvAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        DetailedAmount15 DtldAmt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ed5856d0-f8c7-4dce-b005-14f799b8580b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyTransactionTotals1 {
        /// <remarks/>
        [DispId(1)]
        string POIGrpId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        AmountUnit1Code LltyUnit {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        bool LltyUnitSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string CardPdctPrfl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        LoyaltyTypeTransactionTotals1Code TxTp {
            get;
        }
        /// <remarks/>
        [DispId(7)]
        double TtlNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        double CmltvAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DetailedAmount15 DtldAmt {
            get;
            set;
        }
    }
}
#endif
