namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DataSetCategory12Code {
        /// <remarks/>
        AQPR,
        /// <remarks/>
        APPR,
        /// <remarks/>
        TXCP,
        /// <remarks/>
        AKCP,
        /// <remarks/>
        DLGT,
        /// <remarks/>
        MGTP,
        /// <remarks/>
        MRPR,
        /// <remarks/>
        SCPR,
        /// <remarks/>
        SWPK,
        /// <remarks/>
        STRP,
        /// <remarks/>
        TRPR,
        /// <remarks/>
        VDPR,
        /// <remarks/>
        PARA,
        /// <remarks/>
        TMSP,
        /// <remarks/>
        CRTF,
        /// <remarks/>
        LOGF,
        /// <remarks/>
        CMRQ,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c0d8f8d0-9614-4975-9e90-bbc41ef77f42")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DataSetIdentification7 : IDataSetIdentification7 {
        internal string nmField;
        internal DataSetCategory12Code tpField = new DataSetCategory12Code();
        internal string vrsnField;
        internal string creDtTmField;
        internal bool creDtTmFieldSpecified;
        internal bool xsdDataSetIdentification7InitFlagField = false;
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = true;
                this.nmField = value;
            }
        }
        /// <remarks/>
        public DataSetCategory12Code Tp {
            get {
                return this.tpField;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = true;
                this.tpField = value;
            }
        }
        /// <remarks/>
        public string Vrsn {
            get {
                return this.vrsnField;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = true;
                this.vrsnField = value;
            }
        }
        /// <remarks/>
        public string CreDtTm {
            get {
                return this.creDtTmField;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = true;
                this.creDtTmField = value;
                this.CreDtTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreDtTmSpecified {
            get {
                return this.creDtTmFieldSpecified;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = true;
                this.creDtTmFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDataSetIdentification7InitFlag {
            get {
                return this.xsdDataSetIdentification7InitFlagField;
            }
            set {
                this.xsdDataSetIdentification7InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("89acc408-6095-4076-993a-26ba99ea7db5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDataSetIdentification7 {
        /// <remarks/>
        [DispId(1)]
        string Nm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        DataSetCategory12Code Tp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string Vrsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string CreDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool CreDtTmSpecified {
            get;
            set;
        }
        [DispId(11)]
        bool xsdDataSetIdentification7InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("5bd27c10-9a7f-4dc3-b402-ec4de2ae461e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DiagnosisResponse1 : IDiagnosisResponse1 {
        internal string[] lggdSaleIdField = new string[0];
        internal StatusReportContent8 pOIStsField = new StatusReportContent8();
        internal HostStatus1[] hstStsField = new HostStatus1[0];
        internal bool xsdDiagnosisResponse1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LggdSaleId")]
        public string[] LggdSaleId {
            get {
                if (((this.lggdSaleIdField == null)
                            || (this.lggdSaleIdField.Length == 0))) {
                    return null;
                }
                return this.lggdSaleIdField;
            }
            set {
                this.xsdDiagnosisResponse1InitFlagField = true;
                this.lggdSaleIdField = value;
            }
        }
        /// <remarks/>
        public StatusReportContent8 POISts {
            get {
                return this.pOIStsField;
            }
            set {
                this.xsdDiagnosisResponse1InitFlagField = true;
                this.pOIStsField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HstSts")]
        public HostStatus1[] HstSts {
            get {
                if (((this.hstStsField == null)
                            || (this.hstStsField.Length == 0))) {
                    return null;
                }
                return this.hstStsField;
            }
            set {
                this.xsdDiagnosisResponse1InitFlagField = true;
                this.hstStsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDiagnosisResponse1InitFlag {
            get {
                return this.xsdDiagnosisResponse1InitFlagField;
            }
            set {
                this.xsdDiagnosisResponse1InitFlagField = value;
            }
        }
        public int LggdSaleIdSize() {
            if ((this.lggdSaleIdField == null)) {
                return 0;
            }
            else {
                return this.lggdSaleIdField.Length;
            }
        }
        public string LggdSaleIdGetItem(int index) {
            try {
                if ((this.lggdSaleIdField == default(string[]))) {
                    return default(string);
                }
                else {
                    if (((this.lggdSaleIdField.Length - 1)
                                >= index)) {
                        return this.lggdSaleIdField[index];
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
        public bool LggdSaleIdSetItem(int index, string value) {
            try {
                if ((this.lggdSaleIdField == default(string[]))) {
                    return false;
                }
                else {
                    this.lggdSaleIdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool LggdSaleIdAddItem(string value) {
            try {
                if ((this.lggdSaleIdField == default(string[]))) {
                    return false;
                }
                else {
                    string[] array = new string[(this.lggdSaleIdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.lggdSaleIdField.Length); i = (i + 1)) {
                        array[i] = lggdSaleIdField[i];
                    }
                    array[i] = value;
                    this.LggdSaleId = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool LggdSaleIdRemoveItem(int index) {
            try {
                if ((this.lggdSaleIdField == default(string[]))) {
                    return false;
                }
                else {
                    if ((this.lggdSaleIdField.Length <= index)) {
                        return false;
                    }
                    else {
                        string[] array = new string[(this.lggdSaleIdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = lggdSaleIdField[i];
                        }
                        for (i = (i + 1); (i < this.lggdSaleIdField.Length); i = (i + 1)) {
                            array[i] = lggdSaleIdField[i];
                        }
                        this.LggdSaleId = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int HstStsSize() {
            if ((this.hstStsField == null)) {
                return 0;
            }
            else {
                return this.hstStsField.Length;
            }
        }
        public HostStatus1 HstStsGetItem(int index) {
            try {
                if ((this.hstStsField == default(HostStatus1[]))) {
                    return default(HostStatus1);
                }
                else {
                    if (((this.hstStsField.Length - 1)
                                >= index)) {
                        return this.hstStsField[index];
                    }
                    else {
                        return default(HostStatus1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(HostStatus1);
            }
        }
        public bool HstStsSetItem(int index, HostStatus1 value) {
            try {
                if ((this.hstStsField == default(HostStatus1[]))) {
                    return false;
                }
                else {
                    this.hstStsField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool HstStsAddItem(HostStatus1 value) {
            try {
                if ((this.hstStsField == default(HostStatus1[]))) {
                    return false;
                }
                else {
                    HostStatus1[] array = new HostStatus1[(this.hstStsField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.hstStsField.Length); i = (i + 1)) {
                        array[i] = hstStsField[i];
                    }
                    array[i] = value;
                    this.HstSts = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool HstStsRemoveItem(int index) {
            try {
                if ((this.hstStsField == default(HostStatus1[]))) {
                    return false;
                }
                else {
                    if ((this.hstStsField.Length <= index)) {
                        return false;
                    }
                    else {
                        HostStatus1[] array = new HostStatus1[(this.hstStsField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = hstStsField[i];
                        }
                        for (i = (i + 1); (i < this.hstStsField.Length); i = (i + 1)) {
                            array[i] = hstStsField[i];
                        }
                        this.HstSts = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("f79f306d-dc2c-4059-be0f-68e5a9f71eac")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDiagnosisResponse1 {
        /// <remarks/>
        [DispId(1)]
        string[] LggdSaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        StatusReportContent8 POISts {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        HostStatus1[] HstSts {
            get;
            set;
        }
        [DispId(7)]
        bool xsdDiagnosisResponse1InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int LggdSaleIdSize();
        [DispId(9)]
        string LggdSaleIdGetItem(int index);
        [DispId(10)]
        bool LggdSaleIdSetItem(int index, string value);
        [DispId(11)]
        bool LggdSaleIdAddItem(string value);
        [DispId(12)]
        bool LggdSaleIdRemoveItem(int index);
        [DispId(13)]
        int HstStsSize();
        [DispId(14)]
        HostStatus1 HstStsGetItem(int index);
        [DispId(15)]
        bool HstStsSetItem(int index, HostStatus1 value);
        [DispId(16)]
        bool HstStsAddItem(HostStatus1 value);
        [DispId(17)]
        bool HstStsRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a5e213cf-d25c-4361-8512-26439f0e5ad9")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StatusReportContent8 : IStatusReportContent8 {
        internal PointOfInteractionCapabilities8 pOICpbltiesField = new PointOfInteractionCapabilities8();
        internal PointOfInteractionComponent9[] pOICmpntField = new PointOfInteractionComponent9[0];
        internal AttendanceContext1Code attndncCntxtField = new AttendanceContext1Code();
        internal bool attndncCntxtFieldSpecified;
        internal string pOIDtTmField;
        internal TerminalManagementDataSet25[] dataSetReqrdField = new TerminalManagementDataSet25[0];
        internal TMSEvent6[] evtField = new TMSEvent6[0];
        internal string[] errsField = new string[0];
        internal bool xsdStatusReportContent8InitFlagField = false;
        /// <remarks/>
        public PointOfInteractionCapabilities8 POICpblties {
            get {
                return this.pOICpbltiesField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.pOICpbltiesField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POICmpnt")]
        public PointOfInteractionComponent9[] POICmpnt {
            get {
                if (((this.pOICmpntField == null)
                            || (this.pOICmpntField.Length == 0))) {
                    return null;
                }
                return this.pOICmpntField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.pOICmpntField = value;
            }
        }
        /// <remarks/>
        public AttendanceContext1Code AttndncCntxt {
            get {
                return this.attndncCntxtField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.attndncCntxtField = value;
                this.AttndncCntxtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttndncCntxtSpecified {
            get {
                return this.attndncCntxtFieldSpecified;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.attndncCntxtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string POIDtTm {
            get {
                return this.pOIDtTmField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.pOIDtTmField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSetReqrd")]
        public TerminalManagementDataSet25[] DataSetReqrd {
            get {
                if (((this.dataSetReqrdField == null)
                            || (this.dataSetReqrdField.Length == 0))) {
                    return null;
                }
                return this.dataSetReqrdField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.dataSetReqrdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Evt")]
        public TMSEvent6[] Evt {
            get {
                if (((this.evtField == null)
                            || (this.evtField.Length == 0))) {
                    return null;
                }
                return this.evtField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.evtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errs")]
        public string[] Errs {
            get {
                if (((this.errsField == null)
                            || (this.errsField.Length == 0))) {
                    return null;
                }
                return this.errsField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = true;
                this.errsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdStatusReportContent8InitFlag {
            get {
                return this.xsdStatusReportContent8InitFlagField;
            }
            set {
                this.xsdStatusReportContent8InitFlagField = value;
            }
        }
        public int POICmpntSize() {
            if ((this.pOICmpntField == null)) {
                return 0;
            }
            else {
                return this.pOICmpntField.Length;
            }
        }
        public PointOfInteractionComponent9 POICmpntGetItem(int index) {
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent9[]))) {
                    return default(PointOfInteractionComponent9);
                }
                else {
                    if (((this.pOICmpntField.Length - 1)
                                >= index)) {
                        return this.pOICmpntField[index];
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
        public bool POICmpntSetItem(int index, PointOfInteractionComponent9 value) {
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    this.pOICmpntField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POICmpntAddItem(PointOfInteractionComponent9 value) {
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOICmpntField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.pOICmpntField.Length); i = (i + 1)) {
                        array[i] = pOICmpntField[i];
                    }
                    array[i] = value;
                    this.POICmpnt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POICmpntRemoveItem(int index) {
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    if ((this.pOICmpntField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOICmpntField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = pOICmpntField[i];
                        }
                        for (i = (i + 1); (i < this.pOICmpntField.Length); i = (i + 1)) {
                            array[i] = pOICmpntField[i];
                        }
                        this.POICmpnt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int DataSetReqrdSize() {
            if ((this.dataSetReqrdField == null)) {
                return 0;
            }
            else {
                return this.dataSetReqrdField.Length;
            }
        }
        public TerminalManagementDataSet25 DataSetReqrdGetItem(int index) {
            try {
                if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[]))) {
                    return default(TerminalManagementDataSet25);
                }
                else {
                    if (((this.dataSetReqrdField.Length - 1)
                                >= index)) {
                        return this.dataSetReqrdField[index];
                    }
                    else {
                        return default(TerminalManagementDataSet25);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TerminalManagementDataSet25);
            }
        }
        public bool DataSetReqrdSetItem(int index, TerminalManagementDataSet25 value) {
            try {
                if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[]))) {
                    return false;
                }
                else {
                    this.dataSetReqrdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DataSetReqrdAddItem(TerminalManagementDataSet25 value) {
            try {
                if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[]))) {
                    return false;
                }
                else {
                    TerminalManagementDataSet25[] array = new TerminalManagementDataSet25[(this.dataSetReqrdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dataSetReqrdField.Length); i = (i + 1)) {
                        array[i] = dataSetReqrdField[i];
                    }
                    array[i] = value;
                    this.DataSetReqrd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DataSetReqrdRemoveItem(int index) {
            try {
                if ((this.dataSetReqrdField == default(TerminalManagementDataSet25[]))) {
                    return false;
                }
                else {
                    if ((this.dataSetReqrdField.Length <= index)) {
                        return false;
                    }
                    else {
                        TerminalManagementDataSet25[] array = new TerminalManagementDataSet25[(this.dataSetReqrdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dataSetReqrdField[i];
                        }
                        for (i = (i + 1); (i < this.dataSetReqrdField.Length); i = (i + 1)) {
                            array[i] = dataSetReqrdField[i];
                        }
                        this.DataSetReqrd = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int EvtSize() {
            if ((this.evtField == null)) {
                return 0;
            }
            else {
                return this.evtField.Length;
            }
        }
        public TMSEvent6 EvtGetItem(int index) {
            try {
                if ((this.evtField == default(TMSEvent6[]))) {
                    return default(TMSEvent6);
                }
                else {
                    if (((this.evtField.Length - 1)
                                >= index)) {
                        return this.evtField[index];
                    }
                    else {
                        return default(TMSEvent6);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TMSEvent6);
            }
        }
        public bool EvtSetItem(int index, TMSEvent6 value) {
            try {
                if ((this.evtField == default(TMSEvent6[]))) {
                    return false;
                }
                else {
                    this.evtField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool EvtAddItem(TMSEvent6 value) {
            try {
                if ((this.evtField == default(TMSEvent6[]))) {
                    return false;
                }
                else {
                    TMSEvent6[] array = new TMSEvent6[(this.evtField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.evtField.Length); i = (i + 1)) {
                        array[i] = evtField[i];
                    }
                    array[i] = value;
                    this.Evt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool EvtRemoveItem(int index) {
            try {
                if ((this.evtField == default(TMSEvent6[]))) {
                    return false;
                }
                else {
                    if ((this.evtField.Length <= index)) {
                        return false;
                    }
                    else {
                        TMSEvent6[] array = new TMSEvent6[(this.evtField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = evtField[i];
                        }
                        for (i = (i + 1); (i < this.evtField.Length); i = (i + 1)) {
                            array[i] = evtField[i];
                        }
                        this.Evt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int ErrsSize() {
            if ((this.errsField == null)) {
                return 0;
            }
            else {
                return this.errsField.Length;
            }
        }
        public string ErrsGetItem(int index) {
            try {
                if ((this.errsField == default(string[]))) {
                    return default(string);
                }
                else {
                    if (((this.errsField.Length - 1)
                                >= index)) {
                        return this.errsField[index];
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
        public bool ErrsSetItem(int index, string value) {
            try {
                if ((this.errsField == default(string[]))) {
                    return false;
                }
                else {
                    this.errsField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool ErrsAddItem(string value) {
            try {
                if ((this.errsField == default(string[]))) {
                    return false;
                }
                else {
                    string[] array = new string[(this.errsField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.errsField.Length); i = (i + 1)) {
                        array[i] = errsField[i];
                    }
                    array[i] = value;
                    this.Errs = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool ErrsRemoveItem(int index) {
            try {
                if ((this.errsField == default(string[]))) {
                    return false;
                }
                else {
                    if ((this.errsField.Length <= index)) {
                        return false;
                    }
                    else {
                        string[] array = new string[(this.errsField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = errsField[i];
                        }
                        for (i = (i + 1); (i < this.errsField.Length); i = (i + 1)) {
                            array[i] = errsField[i];
                        }
                        this.Errs = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("40aa1aa4-c027-4103-9d9d-7e7d3532dce4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IStatusReportContent8 {
        /// <remarks/>
        [DispId(1)]
        PointOfInteractionCapabilities8 POICpblties {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PointOfInteractionComponent9[] POICmpnt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        AttendanceContext1Code AttndncCntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool AttndncCntxtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string POIDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        TerminalManagementDataSet25[] DataSetReqrd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        TMSEvent6[] Evt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        string[] Errs {
            get;
            set;
        }
        [DispId(17)]
        bool xsdStatusReportContent8InitFlag {
            get;
            set;
        }
        [DispId(18)]
        int POICmpntSize();
        [DispId(19)]
        PointOfInteractionComponent9 POICmpntGetItem(int index);
        [DispId(20)]
        bool POICmpntSetItem(int index, PointOfInteractionComponent9 value);
        [DispId(21)]
        bool POICmpntAddItem(PointOfInteractionComponent9 value);
        [DispId(22)]
        bool POICmpntRemoveItem(int index);
        [DispId(23)]
        int DataSetReqrdSize();
        [DispId(24)]
        TerminalManagementDataSet25 DataSetReqrdGetItem(int index);
        [DispId(25)]
        bool DataSetReqrdSetItem(int index, TerminalManagementDataSet25 value);
        [DispId(26)]
        bool DataSetReqrdAddItem(TerminalManagementDataSet25 value);
        [DispId(27)]
        bool DataSetReqrdRemoveItem(int index);
        [DispId(28)]
        int EvtSize();
        [DispId(29)]
        TMSEvent6 EvtGetItem(int index);
        [DispId(30)]
        bool EvtSetItem(int index, TMSEvent6 value);
        [DispId(31)]
        bool EvtAddItem(TMSEvent6 value);
        [DispId(32)]
        bool EvtRemoveItem(int index);
        [DispId(33)]
        int ErrsSize();
        [DispId(34)]
        string ErrsGetItem(int index);
        [DispId(35)]
        bool ErrsSetItem(int index, string value);
        [DispId(36)]
        bool ErrsAddItem(string value);
        [DispId(37)]
        bool ErrsRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("97dfa567-a561-43e5-bf91-4697cf5b3568")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TerminalManagementDataSet25 : ITerminalManagementDataSet25 {
        internal DataSetIdentification7 idField = new DataSetIdentification7();
        internal byte[] pOIChllngField = new byte[0];
        internal byte[] tMChllngField = new byte[0];
        internal CryptographicKey13 ssnKeyField = new CryptographicKey13();
        internal byte[] dlgtnProofField = new byte[0];
        internal ContentInformationType19 prtctdDlgtnProofField = new ContentInformationType19();
        internal bool xsdTerminalManagementDataSet25InitFlagField = false;
        /// <remarks/>
        public DataSetIdentification7 Id {
            get {
                return this.idField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.idField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] POIChllng {
            get {
                if (((this.pOIChllngField == null)
                            || (this.pOIChllngField.Length == 0))) {
                    return null;
                }
                return this.pOIChllngField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.pOIChllngField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] TMChllng {
            get {
                if (((this.tMChllngField == null)
                            || (this.tMChllngField.Length == 0))) {
                    return null;
                }
                return this.tMChllngField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.tMChllngField = value;
            }
        }
        /// <remarks/>
        public CryptographicKey13 SsnKey {
            get {
                return this.ssnKeyField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.ssnKeyField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DlgtnProof {
            get {
                if (((this.dlgtnProofField == null)
                            || (this.dlgtnProofField.Length == 0))) {
                    return null;
                }
                return this.dlgtnProofField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.dlgtnProofField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType19 PrtctdDlgtnProof {
            get {
                return this.prtctdDlgtnProofField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = true;
                this.prtctdDlgtnProofField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTerminalManagementDataSet25InitFlag {
            get {
                return this.xsdTerminalManagementDataSet25InitFlagField;
            }
            set {
                this.xsdTerminalManagementDataSet25InitFlagField = value;
            }
        }
        public int POIChllngSize() {
            if ((this.pOIChllngField == null)) {
                return 0;
            }
            else {
                return this.pOIChllngField.Length;
            }
        }
        public byte POIChllngGetItem(int index) {
            try {
                if ((this.pOIChllngField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.pOIChllngField.Length - 1)
                                >= index)) {
                        return this.pOIChllngField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
        }
        public bool POIChllngSetItem(int index, byte value) {
            try {
                if ((this.pOIChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    this.pOIChllngField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POIChllngAddItem(byte value) {
            try {
                if ((this.pOIChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.pOIChllngField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.pOIChllngField.Length); i = (i + 1)) {
                        array[i] = pOIChllngField[i];
                    }
                    array[i] = value;
                    this.POIChllng = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POIChllngRemoveItem(int index) {
            try {
                if ((this.pOIChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.pOIChllngField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.pOIChllngField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = pOIChllngField[i];
                        }
                        for (i = (i + 1); (i < this.pOIChllngField.Length); i = (i + 1)) {
                            array[i] = pOIChllngField[i];
                        }
                        this.POIChllng = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int TMChllngSize() {
            if ((this.tMChllngField == null)) {
                return 0;
            }
            else {
                return this.tMChllngField.Length;
            }
        }
        public byte TMChllngGetItem(int index) {
            try {
                if ((this.tMChllngField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.tMChllngField.Length - 1)
                                >= index)) {
                        return this.tMChllngField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
        }
        public bool TMChllngSetItem(int index, byte value) {
            try {
                if ((this.tMChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    this.tMChllngField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TMChllngAddItem(byte value) {
            try {
                if ((this.tMChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.tMChllngField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.tMChllngField.Length); i = (i + 1)) {
                        array[i] = tMChllngField[i];
                    }
                    array[i] = value;
                    this.TMChllng = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TMChllngRemoveItem(int index) {
            try {
                if ((this.tMChllngField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.tMChllngField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.tMChllngField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = tMChllngField[i];
                        }
                        for (i = (i + 1); (i < this.tMChllngField.Length); i = (i + 1)) {
                            array[i] = tMChllngField[i];
                        }
                        this.TMChllng = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int DlgtnProofSize() {
            if ((this.dlgtnProofField == null)) {
                return 0;
            }
            else {
                return this.dlgtnProofField.Length;
            }
        }
        public byte DlgtnProofGetItem(int index) {
            try {
                if ((this.dlgtnProofField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.dlgtnProofField.Length - 1)
                                >= index)) {
                        return this.dlgtnProofField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
        }
        public bool DlgtnProofSetItem(int index, byte value) {
            try {
                if ((this.dlgtnProofField == default(byte[]))) {
                    return false;
                }
                else {
                    this.dlgtnProofField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DlgtnProofAddItem(byte value) {
            try {
                if ((this.dlgtnProofField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.dlgtnProofField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dlgtnProofField.Length); i = (i + 1)) {
                        array[i] = dlgtnProofField[i];
                    }
                    array[i] = value;
                    this.DlgtnProof = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DlgtnProofRemoveItem(int index) {
            try {
                if ((this.dlgtnProofField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.dlgtnProofField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.dlgtnProofField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dlgtnProofField[i];
                        }
                        for (i = (i + 1); (i < this.dlgtnProofField.Length); i = (i + 1)) {
                            array[i] = dlgtnProofField[i];
                        }
                        this.DlgtnProof = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("35d9b913-bbfd-4254-b782-23169a75d3d8")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITerminalManagementDataSet25 {
        /// <remarks/>
        [DispId(1)]
        DataSetIdentification7 Id {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        byte[] POIChllng {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] TMChllng {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        CryptographicKey13 SsnKey {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        byte[] DlgtnProof {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        ContentInformationType19 PrtctdDlgtnProof {
            get;
            set;
        }
        [DispId(13)]
        bool xsdTerminalManagementDataSet25InitFlag {
            get;
            set;
        }
        [DispId(14)]
        int POIChllngSize();
        [DispId(15)]
        byte POIChllngGetItem(int index);
        [DispId(16)]
        bool POIChllngSetItem(int index, byte value);
        [DispId(17)]
        bool POIChllngAddItem(byte value);
        [DispId(18)]
        bool POIChllngRemoveItem(int index);
        [DispId(19)]
        int TMChllngSize();
        [DispId(20)]
        byte TMChllngGetItem(int index);
        [DispId(21)]
        bool TMChllngSetItem(int index, byte value);
        [DispId(22)]
        bool TMChllngAddItem(byte value);
        [DispId(23)]
        bool TMChllngRemoveItem(int index);
        [DispId(24)]
        int DlgtnProofSize();
        [DispId(25)]
        byte DlgtnProofGetItem(int index);
        [DispId(26)]
        bool DlgtnProofSetItem(int index, byte value);
        [DispId(27)]
        bool DlgtnProofAddItem(byte value);
        [DispId(28)]
        bool DlgtnProofRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1813f9d2-1e77-4ffd-90b4-25f07bca10bb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSEvent6 : ITMSEvent6 {
        internal string tmStmpField;
        internal TerminalManagementActionResult4Code rsltField = new TerminalManagementActionResult4Code();
        internal TMSActionIdentification5 actnIdField = new TMSActionIdentification5();
        internal string addtlErrInfField;
        internal string termnlMgrIdField;
        internal bool xsdTMSEvent6InitFlagField = false;
        /// <remarks/>
        public string TmStmp {
            get {
                return this.tmStmpField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = true;
                this.tmStmpField = value;
            }
        }
        /// <remarks/>
        public TerminalManagementActionResult4Code Rslt {
            get {
                return this.rsltField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = true;
                this.rsltField = value;
            }
        }
        /// <remarks/>
        public TMSActionIdentification5 ActnId {
            get {
                return this.actnIdField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = true;
                this.actnIdField = value;
            }
        }
        /// <remarks/>
        public string AddtlErrInf {
            get {
                return this.addtlErrInfField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = true;
                this.addtlErrInfField = value;
            }
        }
        /// <remarks/>
        public string TermnlMgrId {
            get {
                return this.termnlMgrIdField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = true;
                this.termnlMgrIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTMSEvent6InitFlag {
            get {
                return this.xsdTMSEvent6InitFlagField;
            }
            set {
                this.xsdTMSEvent6InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a448692e-703d-4cd6-95f8-fa8482be6481")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSEvent6 {
        /// <remarks/>
        [DispId(1)]
        string TmStmp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TerminalManagementActionResult4Code Rslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TMSActionIdentification5 ActnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string AddtlErrInf {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string TermnlMgrId {
            get;
            set;
        }
        [DispId(11)]
        bool xsdTMSEvent6InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TerminalManagementActionResult4Code {
        /// <remarks/>
        ACCD,
        /// <remarks/>
        CNTE,
        /// <remarks/>
        FMTE,
        /// <remarks/>
        INVC,
        /// <remarks/>
        LENE,
        /// <remarks/>
        OVER,
        /// <remarks/>
        MISS,
        /// <remarks/>
        NSUP,
        /// <remarks/>
        SIGE,
        /// <remarks/>
        SUCC,
        /// <remarks/>
        SYNE,
        /// <remarks/>
        TIMO,
        /// <remarks/>
        UKDT,
        /// <remarks/>
        UKRF,
        /// <remarks/>
        INDP,
        /// <remarks/>
        IDMP,
        /// <remarks/>
        DPRU,
        /// <remarks/>
        AERR,
        /// <remarks/>
        CMER,
        /// <remarks/>
        ULER,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8932ab0b-3de2-4661-9f34-2e6f2ec90060")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSActionIdentification5 : ITMSActionIdentification5 {
        internal TerminalManagementAction4Code actnTpField = new TerminalManagementAction4Code();
        internal DataSetIdentification7 dataSetIdField = new DataSetIdentification7();
        internal bool xsdTMSActionIdentification5InitFlagField = false;
        /// <remarks/>
        public TerminalManagementAction4Code ActnTp {
            get {
                return this.actnTpField;
            }
            set {
                this.xsdTMSActionIdentification5InitFlagField = true;
                this.actnTpField = value;
            }
        }
        /// <remarks/>
        public DataSetIdentification7 DataSetId {
            get {
                return this.dataSetIdField;
            }
            set {
                this.xsdTMSActionIdentification5InitFlagField = true;
                this.dataSetIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTMSActionIdentification5InitFlag {
            get {
                return this.xsdTMSActionIdentification5InitFlagField;
            }
            set {
                this.xsdTMSActionIdentification5InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0dbdd515-785e-4e8c-8652-a2da7322cba9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSActionIdentification5 {
        /// <remarks/>
        [DispId(1)]
        TerminalManagementAction4Code ActnTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        DataSetIdentification7 DataSetId {
            get;
            set;
        }
        [DispId(5)]
        bool xsdTMSActionIdentification5InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TerminalManagementAction4Code {
        /// <remarks/>
        DCTV,
        /// <remarks/>
        DELT,
        /// <remarks/>
        DWNL,
        /// <remarks/>
        INST,
        /// <remarks/>
        RSTR,
        /// <remarks/>
        UPLD,
        /// <remarks/>
        UPDT,
        /// <remarks/>
        BIND,
        /// <remarks/>
        RBND,
        /// <remarks/>
        UBND,
        /// <remarks/>
        ACTV,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("86edbcca-8ad2-4645-8fa8-aa683cc46259")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HostStatus1 : IHostStatus1 {
        internal string acqrrIdField;
        internal bool rchblField;
        internal bool rchblFieldSpecified;
        internal bool xsdHostStatus1InitFlagField = false;
        /// <remarks/>
        public string AcqrrId {
            get {
                return this.acqrrIdField;
            }
            set {
                this.xsdHostStatus1InitFlagField = true;
                this.acqrrIdField = value;
            }
        }
        /// <remarks/>
        public bool Rchbl {
            get {
                return this.rchblField;
            }
            set {
                this.xsdHostStatus1InitFlagField = true;
                this.rchblField = value;
                this.RchblSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RchblSpecified {
            get {
                return this.rchblFieldSpecified;
            }
            set {
                this.xsdHostStatus1InitFlagField = true;
                this.rchblFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdHostStatus1InitFlag {
            get {
                return this.xsdHostStatus1InitFlagField;
            }
            set {
                this.xsdHostStatus1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("31f8ea2b-a9d0-4bd1-8307-17b653c6a17a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IHostStatus1 {
        /// <remarks/>
        [DispId(1)]
        string AcqrrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool Rchbl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool RchblSpecified {
            get;
            set;
        }
        [DispId(7)]
        bool xsdHostStatus1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4902f502-1818-491a-baf0-549eb0e0561b")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOISessionManagementResponseV01 : ISaleToPOISessionManagementResponseV01 {
        internal Header37 hdrField = new Header37();
        internal SessionManagementResponse2 ssnMgmtRspnField = new SessionManagementResponse2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOISessionManagementResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOISessionManagementResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public SessionManagementResponse2 SsnMgmtRspn {
            get {
                return this.ssnMgmtRspnField;
            }
            set {
                this.xsdSaleToPOISessionManagementResponseV01InitFlagField = true;
                this.ssnMgmtRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOISessionManagementResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOISessionManagementResponseV01InitFlag {
            get {
                return this.xsdSaleToPOISessionManagementResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOISessionManagementResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6af4db67-759e-4896-8be4-9b3282af37c1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOISessionManagementResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SessionManagementResponse2 SsnMgmtRspn {
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
        bool xsdSaleToPOISessionManagementResponseV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("27093365-ad6d-4a5e-811b-cebfbd41ee0e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SessionManagementResponse2 : ISessionManagementResponse2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService5Code svcCnttField = new RetailerService5Code();
        internal LoginResponse1 lgnRspnField = new LoginResponse1();
        internal DiagnosisResponse1 dgnssRspnField = new DiagnosisResponse1();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdSessionManagementResponse2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService5Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        public LoginResponse1 LgnRspn {
            get {
                return this.lgnRspnField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.lgnRspnField = value;
            }
        }
        /// <remarks/>
        public DiagnosisResponse1 DgnssRspn {
            get {
                return this.dgnssRspnField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.dgnssRspnField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = true;
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
                this.xsdSessionManagementResponse2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSessionManagementResponse2InitFlag {
            get {
                return this.xsdSessionManagementResponse2InitFlagField;
            }
            set {
                this.xsdSessionManagementResponse2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("a1063fce-ac96-4b3c-8c8b-bb03bd44830e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISessionManagementResponse2 {
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
        RetailerService5Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoginResponse1 LgnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DiagnosisResponse1 DgnssRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        ResponseType9 Rspn {
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
        bool xsdSessionManagementResponse2InitFlag {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService5Code {
        /// <remarks/>
        SMIP,
        /// <remarks/>
        SMOP,
        /// <remarks/>
        SMDP,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("473ff4f7-4f7e-4690-9c97-31efb9983a3a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoginResponse1 : ILoginResponse1 {
        internal string pOIDtTmField;
        internal PointOfInteractionComponent9[] pOISftwrField = new PointOfInteractionComponent9[0];
        internal PointOfInteractionCapabilities8 pOICpbltiesField = new PointOfInteractionCapabilities8();
        internal bool xsdLoginResponse1InitFlagField = false;
        /// <remarks/>
        public string POIDtTm {
            get {
                return this.pOIDtTmField;
            }
            set {
                this.xsdLoginResponse1InitFlagField = true;
                this.pOIDtTmField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POISftwr")]
        public PointOfInteractionComponent9[] POISftwr {
            get {
                if (((this.pOISftwrField == null)
                            || (this.pOISftwrField.Length == 0))) {
                    return null;
                }
                return this.pOISftwrField;
            }
            set {
                this.xsdLoginResponse1InitFlagField = true;
                this.pOISftwrField = value;
            }
        }
        /// <remarks/>
        public PointOfInteractionCapabilities8 POICpblties {
            get {
                return this.pOICpbltiesField;
            }
            set {
                this.xsdLoginResponse1InitFlagField = true;
                this.pOICpbltiesField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoginResponse1InitFlag {
            get {
                return this.xsdLoginResponse1InitFlagField;
            }
            set {
                this.xsdLoginResponse1InitFlagField = value;
            }
        }
        public int POISftwrSize() {
            if ((this.pOISftwrField == null)) {
                return 0;
            }
            else {
                return this.pOISftwrField.Length;
            }
        }
        public PointOfInteractionComponent9 POISftwrGetItem(int index) {
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent9[]))) {
                    return default(PointOfInteractionComponent9);
                }
                else {
                    if (((this.pOISftwrField.Length - 1)
                                >= index)) {
                        return this.pOISftwrField[index];
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
        public bool POISftwrSetItem(int index, PointOfInteractionComponent9 value) {
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    this.pOISftwrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POISftwrAddItem(PointOfInteractionComponent9 value) {
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOISftwrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.pOISftwrField.Length); i = (i + 1)) {
                        array[i] = pOISftwrField[i];
                    }
                    array[i] = value;
                    this.POISftwr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool POISftwrRemoveItem(int index) {
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent9[]))) {
                    return false;
                }
                else {
                    if ((this.pOISftwrField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent9[] array = new PointOfInteractionComponent9[(this.pOISftwrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = pOISftwrField[i];
                        }
                        for (i = (i + 1); (i < this.pOISftwrField.Length); i = (i + 1)) {
                            array[i] = pOISftwrField[i];
                        }
                        this.POISftwr = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0cd9c6e6-ebf8-4da2-8e66-d233cdfbd254")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoginResponse1 {
        /// <remarks/>
        [DispId(1)]
        string POIDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PointOfInteractionComponent9[] POISftwr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        PointOfInteractionCapabilities8 POICpblties {
            get;
            set;
        }
        [DispId(7)]
        bool xsdLoginResponse1InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int POISftwrSize();
        [DispId(9)]
        PointOfInteractionComponent9 POISftwrGetItem(int index);
        [DispId(10)]
        bool POISftwrSetItem(int index, PointOfInteractionComponent9 value);
        [DispId(11)]
        bool POISftwrAddItem(PointOfInteractionComponent9 value);
        [DispId(12)]
        bool POISftwrRemoveItem(int index);
    }
}
