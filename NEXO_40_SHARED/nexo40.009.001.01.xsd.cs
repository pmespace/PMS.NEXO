namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("6cf5d0ba-c842-4157-a74e-5182e06c7cf4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CriteriaOrder1 : ICriteriaOrder1 {
        internal string trgtField;
        internal bool xsdCriteriaOrder1InitFlagField = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                this.xsdCriteriaOrder1InitFlagField = true;
                this.trgtField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdCriteriaOrder1InitFlag {
            get {
                return this.xsdCriteriaOrder1InitFlagField;
            }
            set {
                this.xsdCriteriaOrder1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("22f3ba7e-46bb-48f7-be97-a2f7cbe55e54")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICriteriaOrder1 {
        /// <remarks/>
        [DispId(1)]
        string Trgt {
            get;
            set;
        }
        [DispId(3)]
        bool xsdCriteriaOrder1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d8992913-77cd-48ff-9593-890b3c5d4966")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReportRequestV01 : ISaleToPOIReportRequestV01 {
        internal Header37 hdrField = new Header37();
        internal ReportRequest2 rptReqField = new ReportRequest2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIReportRequestV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIReportRequestV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public ReportRequest2 RptReq {
            get {
                return this.rptReqField;
            }
            set {
                this.xsdSaleToPOIReportRequestV01InitFlagField = true;
                this.rptReqField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIReportRequestV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIReportRequestV01InitFlag {
            get {
                return this.xsdSaleToPOIReportRequestV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIReportRequestV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("facebd80-eca5-4993-a78a-4282af0d788d")]
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
        [DispId(3)]
        ReportRequest2 RptReq {
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
        bool xsdSaleToPOIReportRequestV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("37ce7eed-af06-4150-8d70-cd93a6a51af1")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportRequest2 : IReportRequest2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService6Code svcCnttField = new RetailerService6Code();
        internal ReportTransactionRequest1 rptTxReqField = new ReportTransactionRequest1();
        internal ReportGetTotalsRequest1 rptGetTtlsReqField = new ReportGetTotalsRequest1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdReportRequest2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdReportRequest2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdReportRequest2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService6Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdReportRequest2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        public ReportTransactionRequest1 RptTxReq {
            get {
                return this.rptTxReqField;
            }
            set {
                this.xsdReportRequest2InitFlagField = true;
                this.rptTxReqField = value;
            }
        }
        /// <remarks/>
        public ReportGetTotalsRequest1 RptGetTtlsReq {
            get {
                return this.rptGetTtlsReqField;
            }
            set {
                this.xsdReportRequest2InitFlagField = true;
                this.rptGetTtlsReqField = value;
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
                this.xsdReportRequest2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportRequest2InitFlag {
            get {
                return this.xsdReportRequest2InitFlagField;
            }
            set {
                this.xsdReportRequest2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("5481fef6-ce5b-48e3-b8b3-b8f15cb29ef2")]
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
        [DispId(3)]
        CardPaymentContext27 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        RetailerService6Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ReportTransactionRequest1 RptTxReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        ReportGetTotalsRequest1 RptGetTtlsReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(13)]
        bool xsdReportRequest2InitFlag {
            get;
            set;
        }
        [DispId(14)]
        int SplmtryDataSize();
        [DispId(15)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(16)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(17)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(18)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b2a31215-dd7c-4b2d-9b2b-16f182540dd8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportTransactionRequest1 : IReportTransactionRequest1 {
        internal SearchAnd1[][][] schCritField = new SearchAnd1[0];
        internal CriteriaOrder1[] schOutptOrdrField = new CriteriaOrder1[0];
        internal bool dscndgOrdrField;
        internal bool dscndgOrdrFieldSpecified;
        internal double blckStartField;
        internal bool blckStartFieldSpecified;
        internal double blckStopField;
        internal bool blckStopFieldSpecified;
        internal bool xsdReportTransactionRequest1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SchOr", typeof(SearchAnd1[]), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SchAnd", typeof(SearchAnd1), IsNullable=false, NestingLevel=1)]
        public SearchAnd1[][][] SchCrit {
            get {
                if (((this.schCritField == null)
                            || (this.schCritField.Length == 0))) {
                    return null;
                }
                return this.schCritField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.schCritField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CritOrdr", IsNullable=false)]
        public CriteriaOrder1[] SchOutptOrdr {
            get {
                if (((this.schOutptOrdrField == null)
                            || (this.schOutptOrdrField.Length == 0))) {
                    return null;
                }
                return this.schOutptOrdrField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.schOutptOrdrField = value;
            }
        }
        /// <remarks/>
        public bool DscndgOrdr {
            get {
                return this.dscndgOrdrField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.dscndgOrdrField = value;
                this.DscndgOrdrSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DscndgOrdrSpecified {
            get {
                return this.dscndgOrdrFieldSpecified;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.dscndgOrdrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double BlckStart {
            get {
                return this.blckStartField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.blckStartField = value;
                this.BlckStartSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlckStartSpecified {
            get {
                return this.blckStartFieldSpecified;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.blckStartFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double BlckStop {
            get {
                return this.blckStopField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.blckStopField = value;
                this.BlckStopSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlckStopSpecified {
            get {
                return this.blckStopFieldSpecified;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = true;
                this.blckStopFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportTransactionRequest1InitFlag {
            get {
                return this.xsdReportTransactionRequest1InitFlagField;
            }
            set {
                this.xsdReportTransactionRequest1InitFlagField = value;
            }
        }
        public int SchCritSize() {
            if ((this.schCritField == null)) {
                return 0;
            }
            else {
                return this.schCritField.Length;
            }
        }
        public SearchAnd1 SchCritGetItem(int index) {
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
        }
        public bool SchCritSetItem(int index, SearchAnd1 value) {
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
        }
        public bool SchCritAddItem(SearchAnd1 value) {
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
        }
        public bool SchCritRemoveItem(int index) {
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
        }
        public int SchOutptOrdrSize() {
            if ((this.schOutptOrdrField == null)) {
                return 0;
            }
            else {
                return this.schOutptOrdrField.Length;
            }
        }
        public CriteriaOrder1 SchOutptOrdrGetItem(int index) {
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
        }
        public bool SchOutptOrdrSetItem(int index, CriteriaOrder1 value) {
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
        }
        public bool SchOutptOrdrAddItem(CriteriaOrder1 value) {
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
        }
        public bool SchOutptOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("19e0df43-1f79-4714-ba63-bb6c3bf645a9")]
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
        [DispId(3)]
        CriteriaOrder1[] SchOutptOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool DscndgOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool DscndgOrdrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        double BlckStart {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool BlckStartSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        double BlckStop {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool BlckStopSpecified {
            get;
            set;
        }
        [DispId(17)]
        bool xsdReportTransactionRequest1InitFlag {
            get;
            set;
        }
        [DispId(18)]
        int SchCritSize();
        [DispId(19)]
        SearchAnd1 SchCritGetItem(int index);
        [DispId(20)]
        bool SchCritSetItem(int index, SearchAnd1 value);
        [DispId(21)]
        bool SchCritAddItem(SearchAnd1 value);
        [DispId(22)]
        bool SchCritRemoveItem(int index);
        [DispId(23)]
        int SchOutptOrdrSize();
        [DispId(24)]
        CriteriaOrder1 SchOutptOrdrGetItem(int index);
        [DispId(25)]
        bool SchOutptOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(26)]
        bool SchOutptOrdrAddItem(CriteriaOrder1 value);
        [DispId(27)]
        bool SchOutptOrdrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("63f05890-513e-40a1-839d-0a080e1a2353")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchAnd1 : ISearchAnd1 {
        internal string trgtField;
        internal Operator1Code oprtrField = new Operator1Code();
        internal string valField;
        internal bool xsdSearchAnd1InitFlagField = false;
        /// <remarks/>
        public string Trgt {
            get {
                return this.trgtField;
            }
            set {
                this.xsdSearchAnd1InitFlagField = true;
                this.trgtField = value;
            }
        }
        /// <remarks/>
        public Operator1Code Oprtr {
            get {
                return this.oprtrField;
            }
            set {
                this.xsdSearchAnd1InitFlagField = true;
                this.oprtrField = value;
            }
        }
        /// <remarks/>
        public string Val {
            get {
                return this.valField;
            }
            set {
                this.xsdSearchAnd1InitFlagField = true;
                this.valField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSearchAnd1InitFlag {
            get {
                return this.xsdSearchAnd1InitFlagField;
            }
            set {
                this.xsdSearchAnd1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("1a64181c-7e4a-46e3-9336-2b080779929c")]
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
        [DispId(3)]
        Operator1Code Oprtr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string Val {
            get;
            set;
        }
        [DispId(7)]
        bool xsdSearchAnd1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e9adbe7a-b9d0-4fc1-a82b-f3c03ad8b4ce")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportGetTotalsRequest1 : IReportGetTotalsRequest1 {
        internal TotalDetails1Code ttlDtlsField = new TotalDetails1Code();
        internal bool ttlDtlsFieldSpecified;
        internal TotalFilter1 ttlFltrField = new TotalFilter1();
        internal bool xsdReportGetTotalsRequest1InitFlagField = false;
        /// <remarks/>
        public TotalDetails1Code TtlDtls {
            get {
                return this.ttlDtlsField;
            }
            set {
                this.xsdReportGetTotalsRequest1InitFlagField = true;
                this.ttlDtlsField = value;
                this.TtlDtlsSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlDtlsSpecified {
            get {
                return this.ttlDtlsFieldSpecified;
            }
            set {
                this.xsdReportGetTotalsRequest1InitFlagField = true;
                this.ttlDtlsFieldSpecified = value;
            }
        }
        /// <remarks/>
        public TotalFilter1 TtlFltr {
            get {
                return this.ttlFltrField;
            }
            set {
                this.xsdReportGetTotalsRequest1InitFlagField = true;
                this.ttlFltrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportGetTotalsRequest1InitFlag {
            get {
                return this.xsdReportGetTotalsRequest1InitFlagField;
            }
            set {
                this.xsdReportGetTotalsRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("94fd4559-b1ce-4741-9d2a-9ca9c7182d62")]
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
        [DispId(3)]
        bool TtlDtlsSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TotalFilter1 TtlFltr {
            get;
            set;
        }
        [DispId(7)]
        bool xsdReportGetTotalsRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b9d4944e-790f-42cd-a2fc-ce714bfb00f7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TotalFilter1 : ITotalFilter1 {
        internal string pOIIdField;
        internal string saleIdField;
        internal string cshrIdField;
        internal string shftNbField;
        internal string ttlsGrpIdField;
        internal bool xsdTotalFilter1InitFlagField = false;
        /// <remarks/>
        public string POIId {
            get {
                return this.pOIIdField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = true;
                this.pOIIdField = value;
            }
        }
        /// <remarks/>
        public string SaleId {
            get {
                return this.saleIdField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = true;
                this.saleIdField = value;
            }
        }
        /// <remarks/>
        public string CshrId {
            get {
                return this.cshrIdField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = true;
                this.cshrIdField = value;
            }
        }
        /// <remarks/>
        public string ShftNb {
            get {
                return this.shftNbField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = true;
                this.shftNbField = value;
            }
        }
        /// <remarks/>
        public string TtlsGrpId {
            get {
                return this.ttlsGrpIdField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = true;
                this.ttlsGrpIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTotalFilter1InitFlag {
            get {
                return this.xsdTotalFilter1InitFlagField;
            }
            set {
                this.xsdTotalFilter1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("dab6af88-a616-413e-981b-dbbda15aa921")]
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
        [DispId(3)]
        string SaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string TtlsGrpId {
            get;
            set;
        }
        [DispId(11)]
        bool xsdTotalFilter1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("86ebbc60-847d-452b-bf97-f987a5285125")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchCriteria1 : ISearchCriteria1 {
        internal SearchAnd1[][] schOrField = new SearchAnd1[0];
        internal bool xsdSearchCriteria1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SchAnd", typeof(SearchAnd1), IsNullable=false)]
        public SearchAnd1[][] SchOr {
            get {
                if (((this.schOrField == null)
                            || (this.schOrField.Length == 0))) {
                    return null;
                }
                return this.schOrField;
            }
            set {
                this.xsdSearchCriteria1InitFlagField = true;
                this.schOrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSearchCriteria1InitFlag {
            get {
                return this.xsdSearchCriteria1InitFlagField;
            }
            set {
                this.xsdSearchCriteria1InitFlagField = value;
            }
        }
        public int SchOrSize() {
            if ((this.schOrField == null)) {
                return 0;
            }
            else {
                return this.schOrField.Length;
            }
        }
        public SearchAnd1 SchOrGetItem(int index) {
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
        }
        public bool SchOrSetItem(int index, SearchAnd1 value) {
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
        }
        public bool SchOrAddItem(SearchAnd1 value) {
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
        }
        public bool SchOrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("5890cd21-426e-4b71-823b-c9a73e3bf8ed")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchCriteria1 {
        /// <remarks/>
        [DispId(1)]
        SearchAnd1[][] SchOr {
            get;
            set;
        }
        [DispId(3)]
        bool xsdSearchCriteria1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int SchOrSize();
        [DispId(5)]
        SearchAnd1 SchOrGetItem(int index);
        [DispId(6)]
        bool SchOrSetItem(int index, SearchAnd1 value);
        [DispId(7)]
        bool SchOrAddItem(SearchAnd1 value);
        [DispId(8)]
        bool SchOrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c7906d8d-e3c8-4101-9953-4e4d44b30dac")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOr1 : ISearchOr1 {
        internal SearchAnd1[] schAndField = new SearchAnd1[0];
        internal bool xsdSearchOr1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SchAnd")]
        public SearchAnd1[] SchAnd {
            get {
                if (((this.schAndField == null)
                            || (this.schAndField.Length == 0))) {
                    return null;
                }
                return this.schAndField;
            }
            set {
                this.xsdSearchOr1InitFlagField = true;
                this.schAndField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSearchOr1InitFlag {
            get {
                return this.xsdSearchOr1InitFlagField;
            }
            set {
                this.xsdSearchOr1InitFlagField = value;
            }
        }
        public int SchAndSize() {
            if ((this.schAndField == null)) {
                return 0;
            }
            else {
                return this.schAndField.Length;
            }
        }
        public SearchAnd1 SchAndGetItem(int index) {
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
        }
        public bool SchAndSetItem(int index, SearchAnd1 value) {
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
        }
        public bool SchAndAddItem(SearchAnd1 value) {
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
        }
        public bool SchAndRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("87d707bd-7f63-4404-ae77-e3da9b718d67")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchOr1 {
        /// <remarks/>
        [DispId(1)]
        SearchAnd1[] SchAnd {
            get;
            set;
        }
        [DispId(3)]
        bool xsdSearchOr1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int SchAndSize();
        [DispId(5)]
        SearchAnd1 SchAndGetItem(int index);
        [DispId(6)]
        bool SchAndSetItem(int index, SearchAnd1 value);
        [DispId(7)]
        bool SchAndAddItem(SearchAnd1 value);
        [DispId(8)]
        bool SchAndRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.009.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("85af5d85-fd7a-4506-a91d-f0f9ff36fd10")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SearchOutputOrder1 : ISearchOutputOrder1 {
        internal CriteriaOrder1[] critOrdrField = new CriteriaOrder1[0];
        internal bool xsdSearchOutputOrder1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CritOrdr")]
        public CriteriaOrder1[] CritOrdr {
            get {
                if (((this.critOrdrField == null)
                            || (this.critOrdrField.Length == 0))) {
                    return null;
                }
                return this.critOrdrField;
            }
            set {
                this.xsdSearchOutputOrder1InitFlagField = true;
                this.critOrdrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSearchOutputOrder1InitFlag {
            get {
                return this.xsdSearchOutputOrder1InitFlagField;
            }
            set {
                this.xsdSearchOutputOrder1InitFlagField = value;
            }
        }
        public int CritOrdrSize() {
            if ((this.critOrdrField == null)) {
                return 0;
            }
            else {
                return this.critOrdrField.Length;
            }
        }
        public CriteriaOrder1 CritOrdrGetItem(int index) {
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
        }
        public bool CritOrdrSetItem(int index, CriteriaOrder1 value) {
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
        }
        public bool CritOrdrAddItem(CriteriaOrder1 value) {
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
        }
        public bool CritOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("196c72f0-5f33-4e6a-954e-d75cdc62688f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISearchOutputOrder1 {
        /// <remarks/>
        [DispId(1)]
        CriteriaOrder1[] CritOrdr {
            get;
            set;
        }
        [DispId(3)]
        bool xsdSearchOutputOrder1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int CritOrdrSize();
        [DispId(5)]
        CriteriaOrder1 CritOrdrGetItem(int index);
        [DispId(6)]
        bool CritOrdrSetItem(int index, CriteriaOrder1 value);
        [DispId(7)]
        bool CritOrdrAddItem(CriteriaOrder1 value);
        [DispId(8)]
        bool CritOrdrRemoveItem(int index);
    }
}
