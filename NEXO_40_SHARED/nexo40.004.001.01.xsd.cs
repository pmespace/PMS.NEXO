namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8c0991fd-9116-4bf2-938e-d5a8a13c9f33")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReconciliationResponseV01 : ISaleToPOIReconciliationResponseV01 {
        internal Header37 hdrField = new Header37();
        internal ReconciliationResponse3 rcncltnRspnField = new ReconciliationResponse3();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIReconciliationResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIReconciliationResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public ReconciliationResponse3 RcncltnRspn {
            get {
                return this.rcncltnRspnField;
            }
            set {
                this.xsdSaleToPOIReconciliationResponseV01InitFlagField = true;
                this.rcncltnRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIReconciliationResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIReconciliationResponseV01InitFlag {
            get {
                return this.xsdSaleToPOIReconciliationResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIReconciliationResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("55ee58ab-1617-44e3-aa3d-246e13333b6c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReconciliationResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ReconciliationResponse3 RcncltnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ContentInformationType18 SctyTrlr {
            get;
            set;
        }
        [DispId(7)]
        bool xsdSaleToPOIReconciliationResponseV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b232e757-5bb4-4826-adeb-0e678dec96fc")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationResponse3 : IReconciliationResponse3 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal ReconciliationResponseData1 rcncltnRspnDataField = new ReconciliationResponseData1();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdReconciliationResponse3InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public ReconciliationResponseData1 RcncltnRspnData {
            get {
                return this.rcncltnRspnDataField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = true;
                this.rcncltnRspnDataField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = true;
                this.rspnField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public SupplementaryData1[] SplmtryData {
            get {
                if (((this.splmtryDataField == null)
                            || (this.splmtryDataField.Length == 0))) {
                    return null;
                }
                return this.splmtryDataField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReconciliationResponse3InitFlag {
            get {
                return this.xsdReconciliationResponse3InitFlagField;
            }
            set {
                this.xsdReconciliationResponse3InitFlagField = value;
            }
        }
        public int SplmtryDataSize() {
            if ((this.splmtryDataField == null)) {
                return 0;
            }
            else {
                return this.splmtryDataField.Length;
            }
        }
        public SupplementaryData1 SplmtryDataGetItem(int index) {
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
        }
        public bool SplmtryDataSetItem(int index, SupplementaryData1 value) {
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
        }
        public bool SplmtryDataAddItem(SupplementaryData1 value) {
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
        }
        public bool SplmtryDataRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7f6987d0-6aab-4e29-b6aa-aa7cbcb7b41f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationResponse3 {
        /// <remarks/>
        [DispId(1)]
        CardPaymentEnvironment73 Envt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        CardPaymentContext27 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ReconciliationResponseData1 RcncltnRspnData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(11)]
        bool xsdReconciliationResponse3InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int SplmtryDataSize();
        [DispId(13)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(14)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(15)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(16)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d7140f26-3f27-40b9-8499-07c62078a153")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReconciliationResponseData1 : IReconciliationResponseData1 {
        internal ReconciliationType1Code rcncltnTpField = new ReconciliationType1Code();
        internal string pOIRcncltnIdField;
        internal TransactionTotalsSet1[] txTtlsField = new TransactionTotalsSet1[0];
        internal bool xsdReconciliationResponseData1InitFlagField = false;
        /// <remarks/>
        public ReconciliationType1Code RcncltnTp {
            get {
                return this.rcncltnTpField;
            }
            set {
                this.xsdReconciliationResponseData1InitFlagField = true;
                this.rcncltnTpField = value;
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdReconciliationResponseData1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxTtls")]
        public TransactionTotalsSet1[] TxTtls {
            get {
                if (((this.txTtlsField == null)
                            || (this.txTtlsField.Length == 0))) {
                    return null;
                }
                return this.txTtlsField;
            }
            set {
                this.xsdReconciliationResponseData1InitFlagField = true;
                this.txTtlsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReconciliationResponseData1InitFlag {
            get {
                return this.xsdReconciliationResponseData1InitFlagField;
            }
            set {
                this.xsdReconciliationResponseData1InitFlagField = value;
            }
        }
        public int TxTtlsSize() {
            if ((this.txTtlsField == null)) {
                return 0;
            }
            else {
                return this.txTtlsField.Length;
            }
        }
        public TransactionTotalsSet1 TxTtlsGetItem(int index) {
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
        }
        public bool TxTtlsSetItem(int index, TransactionTotalsSet1 value) {
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
        }
        public bool TxTtlsAddItem(TransactionTotalsSet1 value) {
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
        }
        public bool TxTtlsRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ed242a8e-9791-45b3-8e36-6e622686adb3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReconciliationResponseData1 {
        /// <remarks/>
        [DispId(1)]
        ReconciliationType1Code RcncltnTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TransactionTotalsSet1[] TxTtls {
            get;
            set;
        }
        [DispId(7)]
        bool xsdReconciliationResponseData1InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int TxTtlsSize();
        [DispId(9)]
        TransactionTotalsSet1 TxTtlsGetItem(int index);
        [DispId(10)]
        bool TxTtlsSetItem(int index, TransactionTotalsSet1 value);
        [DispId(11)]
        bool TxTtlsAddItem(TransactionTotalsSet1 value);
        [DispId(12)]
        bool TxTtlsRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d35ecf4b-35d6-45b6-a38e-ce493e6f41e0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransactionTotalsSet1 : ITransactionTotalsSet1 {
        internal PaymentInstrumentType1Code pmtInstrmTpField = new PaymentInstrumentType1Code();
        internal string acqrrIdField;
        internal string rcncltnIdField;
        internal string saleRcncltnIdField;
        internal string brndField;
        internal string pOIIdField;
        internal string saleIdField;
        internal string cshrIdField;
        internal string shftNbField;
        internal Organisation26[] spnsrdMrchntField = new Organisation26[0];
        internal TransactionTotals8 txTtlField = new TransactionTotals8();
        internal LoyaltyTransactionTotals1[] lltyTxTtlField = new LoyaltyTransactionTotals1[0];
        internal bool xsdTransactionTotalsSet1InitFlagField = false;
        /// <remarks/>
        public PaymentInstrumentType1Code PmtInstrmTp {
            get {
                return this.pmtInstrmTpField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.pmtInstrmTpField = value;
            }
        }
        /// <remarks/>
        public string AcqrrId {
            get {
                return this.acqrrIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.acqrrIdField = value;
            }
        }
        /// <remarks/>
        public string RcncltnId {
            get {
                return this.rcncltnIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.rcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string SaleRcncltnId {
            get {
                return this.saleRcncltnIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.saleRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string Brnd {
            get {
                return this.brndField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.brndField = value;
            }
        }
        /// <remarks/>
        public string POIId {
            get {
                return this.pOIIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.pOIIdField = value;
            }
        }
        /// <remarks/>
        public string SaleId {
            get {
                return this.saleIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.saleIdField = value;
            }
        }
        /// <remarks/>
        public string CshrId {
            get {
                return this.cshrIdField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.cshrIdField = value;
            }
        }
        /// <remarks/>
        public string ShftNb {
            get {
                return this.shftNbField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.shftNbField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpnsrdMrchnt")]
        public Organisation26[] SpnsrdMrchnt {
            get {
                if (((this.spnsrdMrchntField == null)
                            || (this.spnsrdMrchntField.Length == 0))) {
                    return null;
                }
                return this.spnsrdMrchntField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.spnsrdMrchntField = value;
            }
        }
        /// <remarks/>
        public TransactionTotals8 TxTtl {
            get {
                return this.txTtlField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.txTtlField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyTxTtl")]
        public LoyaltyTransactionTotals1[] LltyTxTtl {
            get {
                if (((this.lltyTxTtlField == null)
                            || (this.lltyTxTtlField.Length == 0))) {
                    return null;
                }
                return this.lltyTxTtlField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = true;
                this.lltyTxTtlField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTransactionTotalsSet1InitFlag {
            get {
                return this.xsdTransactionTotalsSet1InitFlagField;
            }
            set {
                this.xsdTransactionTotalsSet1InitFlagField = value;
            }
        }
        public int SpnsrdMrchntSize() {
            if ((this.spnsrdMrchntField == null)) {
                return 0;
            }
            else {
                return this.spnsrdMrchntField.Length;
            }
        }
        public Organisation26 SpnsrdMrchntGetItem(int index) {
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
        }
        public bool SpnsrdMrchntSetItem(int index, Organisation26 value) {
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
        }
        public bool SpnsrdMrchntAddItem(Organisation26 value) {
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
        }
        public bool SpnsrdMrchntRemoveItem(int index) {
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
        }
        public int LltyTxTtlSize() {
            if ((this.lltyTxTtlField == null)) {
                return 0;
            }
            else {
                return this.lltyTxTtlField.Length;
            }
        }
        public LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index) {
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
        }
        public bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value) {
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
        }
        public bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value) {
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
        }
        public bool LltyTxTtlRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("3be92d36-e177-4c41-8f39-083c8e603333")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITransactionTotalsSet1 {
        /// <remarks/>
        [DispId(1)]
        PaymentInstrumentType1Code PmtInstrmTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string AcqrrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string RcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string SaleRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string Brnd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        string POIId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        string SaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        Organisation26[] SpnsrdMrchnt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        TransactionTotals8 TxTtl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        LoyaltyTransactionTotals1[] LltyTxTtl {
            get;
            set;
        }
        [DispId(25)]
        bool xsdTransactionTotalsSet1InitFlag {
            get;
            set;
        }
        [DispId(26)]
        int SpnsrdMrchntSize();
        [DispId(27)]
        Organisation26 SpnsrdMrchntGetItem(int index);
        [DispId(28)]
        bool SpnsrdMrchntSetItem(int index, Organisation26 value);
        [DispId(29)]
        bool SpnsrdMrchntAddItem(Organisation26 value);
        [DispId(30)]
        bool SpnsrdMrchntRemoveItem(int index);
        [DispId(31)]
        int LltyTxTtlSize();
        [DispId(32)]
        LoyaltyTransactionTotals1 LltyTxTtlGetItem(int index);
        [DispId(33)]
        bool LltyTxTtlSetItem(int index, LoyaltyTransactionTotals1 value);
        [DispId(34)]
        bool LltyTxTtlAddItem(LoyaltyTransactionTotals1 value);
        [DispId(35)]
        bool LltyTxTtlRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PaymentInstrumentType1Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("296d177b-7c4f-4380-a1b7-6fccf74c7e6e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransactionTotals8 : ITransactionTotals8 {
        internal string pOIGrpIdField;
        internal string cardPdctPrflField;
        internal string ccyField;
        internal TypeTransactionTotals3Code tpField = new TypeTransactionTotals3Code();
        internal double ttlNbField;
        internal double cmltvAmtField;
        internal DetailedAmount15 dtldAmtField = new DetailedAmount15();
        internal bool xsdTransactionTotals8InitFlagField = false;
        /// <remarks/>
        public string POIGrpId {
            get {
                return this.pOIGrpIdField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.pOIGrpIdField = value;
            }
        }
        /// <remarks/>
        public string CardPdctPrfl {
            get {
                return this.cardPdctPrflField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.cardPdctPrflField = value;
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public TypeTransactionTotals3Code Tp {
            get {
                return this.tpField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.tpField = value;
            }
        }
        /// <remarks/>
        public double TtlNb {
            get {
                return this.ttlNbField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.ttlNbField = value;
            }
        }
        /// <remarks/>
        public double CmltvAmt {
            get {
                return this.cmltvAmtField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.cmltvAmtField = value;
            }
        }
        /// <remarks/>
        public DetailedAmount15 DtldAmt {
            get {
                return this.dtldAmtField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = true;
                this.dtldAmtField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTransactionTotals8InitFlag {
            get {
                return this.xsdTransactionTotals8InitFlagField;
            }
            set {
                this.xsdTransactionTotals8InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a7e6160d-78d1-4ea1-b489-e1b133c0a265")]
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
        [DispId(3)]
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
        [DispId(7)]
        TypeTransactionTotals3Code Tp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        double TtlNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        double CmltvAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        DetailedAmount15 DtldAmt {
            get;
            set;
        }
        [DispId(15)]
        bool xsdTransactionTotals8InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TypeTransactionTotals3Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("db60e543-2b2f-4065-b9fe-6e767880314b")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyTransactionTotals1 : ILoyaltyTransactionTotals1 {
        internal string pOIGrpIdField;
        internal AmountUnit1Code lltyUnitField = new AmountUnit1Code();
        internal bool lltyUnitFieldSpecified;
        internal string cardPdctPrflField;
        internal string ccyField;
        internal LoyaltyTypeTransactionTotals1Code txTpField = new LoyaltyTypeTransactionTotals1Code();
        internal double ttlNbField;
        internal double cmltvAmtField;
        internal DetailedAmount15 dtldAmtField = new DetailedAmount15();
        internal bool xsdLoyaltyTransactionTotals1InitFlagField = false;
        /// <remarks/>
        public string POIGrpId {
            get {
                return this.pOIGrpIdField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.pOIGrpIdField = value;
            }
        }
        /// <remarks/>
        public AmountUnit1Code LltyUnit {
            get {
                return this.lltyUnitField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.lltyUnitField = value;
                this.LltyUnitSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LltyUnitSpecified {
            get {
                return this.lltyUnitFieldSpecified;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.lltyUnitFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CardPdctPrfl {
            get {
                return this.cardPdctPrflField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.cardPdctPrflField = value;
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public LoyaltyTypeTransactionTotals1Code TxTp {
            get {
                return this.txTpField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.txTpField = value;
            }
        }
        /// <remarks/>
        public double TtlNb {
            get {
                return this.ttlNbField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.ttlNbField = value;
            }
        }
        /// <remarks/>
        public double CmltvAmt {
            get {
                return this.cmltvAmtField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.cmltvAmtField = value;
            }
        }
        /// <remarks/>
        public DetailedAmount15 DtldAmt {
            get {
                return this.dtldAmtField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = true;
                this.dtldAmtField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoyaltyTransactionTotals1InitFlag {
            get {
                return this.xsdLoyaltyTransactionTotals1InitFlagField;
            }
            set {
                this.xsdLoyaltyTransactionTotals1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0c7f1508-5c5f-4fda-959b-2dc9d3eae730")]
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
        [DispId(3)]
        AmountUnit1Code LltyUnit {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool LltyUnitSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string CardPdctPrfl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        LoyaltyTypeTransactionTotals1Code TxTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        double TtlNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        double CmltvAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        DetailedAmount15 DtldAmt {
            get;
            set;
        }
        [DispId(19)]
        bool xsdLoyaltyTransactionTotals1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.004.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum LoyaltyTypeTransactionTotals1Code {
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
    }
}
