namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CustomerOrderRequest1Code {
        /// <remarks/>
        BOTH,
        /// <remarks/>
        CLSD,
        /// <remarks/>
        OPEN,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("cec76e0d-30a2-4155-a0aa-6e825330d37a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DiagnosisRequest1 : IDiagnosisRequest1 {
        internal bool hstDgnssFlgField;
        internal bool hstDgnssFlgFieldSpecified;
        internal string[] acqrrIdField = new string[0];
        internal bool xsdDiagnosisRequest1InitFlagField = false;
        /// <remarks/>
        public bool HstDgnssFlg {
            get {
                return this.hstDgnssFlgField;
            }
            set {
                this.xsdDiagnosisRequest1InitFlagField = true;
                this.hstDgnssFlgField = value;
                this.HstDgnssFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HstDgnssFlgSpecified {
            get {
                return this.hstDgnssFlgFieldSpecified;
            }
            set {
                this.xsdDiagnosisRequest1InitFlagField = true;
                this.hstDgnssFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcqrrId")]
        public string[] AcqrrId {
            get {
                if (((this.acqrrIdField == null)
                            || (this.acqrrIdField.Length == 0))) {
                    return null;
                }
                return this.acqrrIdField;
            }
            set {
                this.xsdDiagnosisRequest1InitFlagField = true;
                this.acqrrIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDiagnosisRequest1InitFlag {
            get {
                return this.xsdDiagnosisRequest1InitFlagField;
            }
            set {
                this.xsdDiagnosisRequest1InitFlagField = value;
            }
        }
        public int AcqrrIdSize() {
            if ((this.acqrrIdField == null)) {
                return 0;
            }
            else {
                return this.acqrrIdField.Length;
            }
        }
        public string AcqrrIdGetItem(int index) {
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
        }
        public bool AcqrrIdSetItem(int index, string value) {
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
        }
        public bool AcqrrIdAddItem(string value) {
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
        }
        public bool AcqrrIdRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("3fc9d6ce-b928-4c07-b217-cd0eca4804f5")]
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
        [DispId(3)]
        bool HstDgnssFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string[] AcqrrId {
            get;
            set;
        }
        [DispId(7)]
        bool xsdDiagnosisRequest1InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int AcqrrIdSize();
        [DispId(9)]
        string AcqrrIdGetItem(int index);
        [DispId(10)]
        bool AcqrrIdSetItem(int index, string value);
        [DispId(11)]
        bool AcqrrIdAddItem(string value);
        [DispId(12)]
        bool AcqrrIdRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a4020247-ce3e-41b0-aced-a7b6bf0e3a55")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOISessionManagementRequestV01 : ISaleToPOISessionManagementRequestV01 {
        internal Header37 hdrField = new Header37();
        internal SessionManagementRequest2 ssnMgmtReqField = new SessionManagementRequest2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOISessionManagementRequestV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOISessionManagementRequestV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public SessionManagementRequest2 SsnMgmtReq {
            get {
                return this.ssnMgmtReqField;
            }
            set {
                this.xsdSaleToPOISessionManagementRequestV01InitFlagField = true;
                this.ssnMgmtReqField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOISessionManagementRequestV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOISessionManagementRequestV01InitFlag {
            get {
                return this.xsdSaleToPOISessionManagementRequestV01InitFlagField;
            }
            set {
                this.xsdSaleToPOISessionManagementRequestV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("9b15b9ca-2187-4338-bb61-720e380167c6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOISessionManagementRequestV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SessionManagementRequest2 SsnMgmtReq {
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
        bool xsdSaleToPOISessionManagementRequestV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("52ebf472-2a8e-4537-bc0f-80a9bdf1f4a4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SessionManagementRequest2 : ISessionManagementRequest2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService4Code svcCnttField = new RetailerService4Code();
        internal LoginRequest1 lgnReqField = new LoginRequest1();
        internal LogoutRequest1 lgtReqField = new LogoutRequest1();
        internal DiagnosisRequest1 dgnssReqField = new DiagnosisRequest1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdSessionManagementRequest2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService4Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        public LoginRequest1 LgnReq {
            get {
                return this.lgnReqField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.lgnReqField = value;
            }
        }
        /// <remarks/>
        public LogoutRequest1 LgtReq {
            get {
                return this.lgtReqField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.lgtReqField = value;
            }
        }
        /// <remarks/>
        public DiagnosisRequest1 DgnssReq {
            get {
                return this.dgnssReqField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.dgnssReqField = value;
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
                this.xsdSessionManagementRequest2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSessionManagementRequest2InitFlag {
            get {
                return this.xsdSessionManagementRequest2InitFlagField;
            }
            set {
                this.xsdSessionManagementRequest2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("812b8926-3bfa-4168-b487-1edad78a3beb")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISessionManagementRequest2 {
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
        RetailerService4Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoginRequest1 LgnReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        LogoutRequest1 LgtReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        DiagnosisRequest1 DgnssReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(15)]
        bool xsdSessionManagementRequest2InitFlag {
            get;
            set;
        }
        [DispId(16)]
        int SplmtryDataSize();
        [DispId(17)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(18)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(19)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(20)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService4Code {
        /// <remarks/>
        SMIQ,
        /// <remarks/>
        SMOQ,
        /// <remarks/>
        SMDQ,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7a97c42c-5d4d-4317-a490-8386039da429")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoginRequest1 : ILoginRequest1 {
        internal string lgnDtTmField;
        internal PointOfInteractionComponent9[] saleSftwrField = new PointOfInteractionComponent9[0];
        internal SaleTerminalData1 saleTermnlDataField = new SaleTerminalData1();
        internal bool trngMdFlgField;
        internal bool trngMdFlgFieldSpecified;
        internal string cshrIdField;
        internal string cshrLangField;
        internal string shftNbField;
        internal SaleTokenScope1Code tknReqdTpField = new SaleTokenScope1Code();
        internal bool tknReqdTpFieldSpecified;
        internal CustomerOrderRequest1Code cstmrOrdrReqField = new CustomerOrderRequest1Code();
        internal bool cstmrOrdrReqFieldSpecified;
        internal PointOfInteractionComponentIdentification1 pOIIdField = new PointOfInteractionComponentIdentification1();
        internal string ttlsGrpIdField;
        internal bool xsdLoginRequest1InitFlagField = false;
        /// <remarks/>
        public string LgnDtTm {
            get {
                return this.lgnDtTmField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.lgnDtTmField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleSftwr")]
        public PointOfInteractionComponent9[] SaleSftwr {
            get {
                if (((this.saleSftwrField == null)
                            || (this.saleSftwrField.Length == 0))) {
                    return null;
                }
                return this.saleSftwrField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.saleSftwrField = value;
            }
        }
        /// <remarks/>
        public SaleTerminalData1 SaleTermnlData {
            get {
                return this.saleTermnlDataField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.saleTermnlDataField = value;
            }
        }
        /// <remarks/>
        public bool TrngMdFlg {
            get {
                return this.trngMdFlgField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.trngMdFlgField = value;
                this.TrngMdFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TrngMdFlgSpecified {
            get {
                return this.trngMdFlgFieldSpecified;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.trngMdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CshrId {
            get {
                return this.cshrIdField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.cshrIdField = value;
            }
        }
        /// <remarks/>
        public string CshrLang {
            get {
                return this.cshrLangField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.cshrLangField = value;
            }
        }
        /// <remarks/>
        public string ShftNb {
            get {
                return this.shftNbField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.shftNbField = value;
            }
        }
        /// <remarks/>
        public SaleTokenScope1Code TknReqdTp {
            get {
                return this.tknReqdTpField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.tknReqdTpField = value;
                this.TknReqdTpSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TknReqdTpSpecified {
            get {
                return this.tknReqdTpFieldSpecified;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.tknReqdTpFieldSpecified = value;
            }
        }
        /// <remarks/>
        public CustomerOrderRequest1Code CstmrOrdrReq {
            get {
                return this.cstmrOrdrReqField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.cstmrOrdrReqField = value;
                this.CstmrOrdrReqSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CstmrOrdrReqSpecified {
            get {
                return this.cstmrOrdrReqFieldSpecified;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.cstmrOrdrReqFieldSpecified = value;
            }
        }
        /// <remarks/>
        public PointOfInteractionComponentIdentification1 POIId {
            get {
                return this.pOIIdField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.pOIIdField = value;
            }
        }
        /// <remarks/>
        public string TtlsGrpId {
            get {
                return this.ttlsGrpIdField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = true;
                this.ttlsGrpIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoginRequest1InitFlag {
            get {
                return this.xsdLoginRequest1InitFlagField;
            }
            set {
                this.xsdLoginRequest1InitFlagField = value;
            }
        }
        public int SaleSftwrSize() {
            if ((this.saleSftwrField == null)) {
                return 0;
            }
            else {
                return this.saleSftwrField.Length;
            }
        }
        public PointOfInteractionComponent9 SaleSftwrGetItem(int index) {
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent9[]))) {
                    return default(PointOfInteractionComponent9);
                }
                else {
                    if (((this.saleSftwrField.Length - 1)
                                >= index)) {
                        return this.saleSftwrField[index];
                    }
                    else {
                        return default(PointOfInteractionComponent9);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionComponent9);
            }
        }
        public bool SaleSftwrSetItem(int index, PointOfInteractionComponent9 value) {
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent9[]))) {
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
        }
        public bool SaleSftwrAddItem(PointOfInteractionComponent9 value) {
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.saleSftwrField.Length + 1)];
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
        }
        public bool SaleSftwrRemoveItem(int index) {
            try {
                if ((this.saleSftwrField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    if ((this.saleSftwrField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.saleSftwrField.Length - 1)];
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("43b7bcee-fe41-4b96-bbdb-c8b1a0a773a7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoginRequest1 {
        /// <remarks/>
        [DispId(1)]
        string LgnDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PointOfInteractionComponent9[] SaleSftwr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        SaleTerminalData1 SaleTermnlData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool TrngMdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool TrngMdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        string CshrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        string CshrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        string ShftNb {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        SaleTokenScope1Code TknReqdTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        bool TknReqdTpSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        CustomerOrderRequest1Code CstmrOrdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        bool CstmrOrdrReqSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(25)]
        PointOfInteractionComponentIdentification1 POIId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(27)]
        string TtlsGrpId {
            get;
            set;
        }
        [DispId(29)]
        bool xsdLoginRequest1InitFlag {
            get;
            set;
        }
        [DispId(30)]
        int SaleSftwrSize();
        [DispId(31)]
        PointOfInteractionComponent9 SaleSftwrGetItem(int index);
        [DispId(32)]
        bool SaleSftwrSetItem(int index, PointOfInteractionComponent9 value);
        [DispId(33)]
        bool SaleSftwrAddItem(PointOfInteractionComponent9 value);
        [DispId(34)]
        bool SaleSftwrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("0e15b335-52c7-4a51-8db1-1df1ddd7114d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleTerminalData1 : ISaleTerminalData1 {
        internal AttendanceContext1Code termnlEnvtField = new AttendanceContext1Code();
        internal bool termnlEnvtFieldSpecified;
        internal string saleRcncltnIdField;
        internal bool xsdSaleTerminalData1InitFlagField = false;
        /// <remarks/>
        public AttendanceContext1Code TermnlEnvt {
            get {
                return this.termnlEnvtField;
            }
            set {
                this.xsdSaleTerminalData1InitFlagField = true;
                this.termnlEnvtField = value;
                this.TermnlEnvtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TermnlEnvtSpecified {
            get {
                return this.termnlEnvtFieldSpecified;
            }
            set {
                this.xsdSaleTerminalData1InitFlagField = true;
                this.termnlEnvtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string SaleRcncltnId {
            get {
                return this.saleRcncltnIdField;
            }
            set {
                this.xsdSaleTerminalData1InitFlagField = true;
                this.saleRcncltnIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleTerminalData1InitFlag {
            get {
                return this.xsdSaleTerminalData1InitFlagField;
            }
            set {
                this.xsdSaleTerminalData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8f6557e9-95c2-4acc-8f27-31fc27d95169")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleTerminalData1 {
        /// <remarks/>
        [DispId(1)]
        AttendanceContext1Code TermnlEnvt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool TermnlEnvtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string SaleRcncltnId {
            get;
            set;
        }
        [DispId(7)]
        bool xsdSaleTerminalData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.005.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("05746a5b-8b33-463b-8c2d-696b5b8b7cc4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LogoutRequest1 : ILogoutRequest1 {
        internal bool mntncAllwdField;
        internal bool mntncAllwdFieldSpecified;
        internal bool xsdLogoutRequest1InitFlagField = false;
        /// <remarks/>
        public bool MntncAllwd {
            get {
                return this.mntncAllwdField;
            }
            set {
                this.xsdLogoutRequest1InitFlagField = true;
                this.mntncAllwdField = value;
                this.MntncAllwdSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntncAllwdSpecified {
            get {
                return this.mntncAllwdFieldSpecified;
            }
            set {
                this.xsdLogoutRequest1InitFlagField = true;
                this.mntncAllwdFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLogoutRequest1InitFlag {
            get {
                return this.xsdLogoutRequest1InitFlagField;
            }
            set {
                this.xsdLogoutRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("72a620dd-1c85-4b8c-af05-e9b4be704130")]
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
        [DispId(3)]
        bool MntncAllwdSpecified {
            get;
            set;
        }
        [DispId(5)]
        bool xsdLogoutRequest1InitFlag {
            get;
            set;
        }
    }
}
