namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c31d530c-803f-4ca0-a1ee-b829af367af5")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIEventNotificationV01 : ISaleToPOIEventNotificationV01 {
        internal Header37 hdrField = new Header37();
        internal SystemEventNotification2 evtNtfctnField = new SystemEventNotification2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIEventNotificationV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIEventNotificationV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public SystemEventNotification2 EvtNtfctn {
            get {
                return this.evtNtfctnField;
            }
            set {
                this.xsdSaleToPOIEventNotificationV01InitFlagField = true;
                this.evtNtfctnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIEventNotificationV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIEventNotificationV01InitFlag {
            get {
                return this.xsdSaleToPOIEventNotificationV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIEventNotificationV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("9d4f2bf0-1013-4f81-a64a-01694b728b43")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIEventNotificationV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SystemEventNotification2 EvtNtfctn {
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
        bool xsdSaleToPOIEventNotificationV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("215d7031-a97d-4913-b418-630ca9507b69")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SystemEventNotification2 : ISystemEventNotification2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal EventNotificationData1 evtNtfctnField = new EventNotificationData1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdSystemEventNotification2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdSystemEventNotification2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdSystemEventNotification2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public EventNotificationData1 EvtNtfctn {
            get {
                return this.evtNtfctnField;
            }
            set {
                this.xsdSystemEventNotification2InitFlagField = true;
                this.evtNtfctnField = value;
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
                this.xsdSystemEventNotification2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSystemEventNotification2InitFlag {
            get {
                return this.xsdSystemEventNotification2InitFlagField;
            }
            set {
                this.xsdSystemEventNotification2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("de0565a0-f395-48ae-9a27-01e986ac6e0a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISystemEventNotification2 {
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
        EventNotificationData1 EvtNtfctn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(9)]
        bool xsdSystemEventNotification2InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int SplmtryDataSize();
        [DispId(11)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(12)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(13)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(14)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2bc24e61-7ec3-46fa-90d9-290bcfcbf873")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EventNotificationData1 : IEventNotificationData1 {
        internal RetailerEvent1 rtlrEvtField = new RetailerEvent1();
        internal bool mntncReqrdFlgField;
        internal bool mntncReqrdFlgFieldSpecified;
        internal string cstmrLangField;
        internal ActionMessage6 dispOutptField = new ActionMessage6();
        internal bool xsdEventNotificationData1InitFlagField = false;
        /// <remarks/>
        public RetailerEvent1 RtlrEvt {
            get {
                return this.rtlrEvtField;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = true;
                this.rtlrEvtField = value;
            }
        }
        /// <remarks/>
        public bool MntncReqrdFlg {
            get {
                return this.mntncReqrdFlgField;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = true;
                this.mntncReqrdFlgField = value;
                this.MntncReqrdFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntncReqrdFlgSpecified {
            get {
                return this.mntncReqrdFlgFieldSpecified;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = true;
                this.mntncReqrdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = true;
                this.cstmrLangField = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                return this.dispOutptField;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdEventNotificationData1InitFlag {
            get {
                return this.xsdEventNotificationData1InitFlagField;
            }
            set {
                this.xsdEventNotificationData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6b2977bf-1fa6-486e-b950-64b1dd269a57")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IEventNotificationData1 {
        /// <remarks/>
        [DispId(1)]
        RetailerEvent1 RtlrEvt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool MntncReqrdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool MntncReqrdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(11)]
        bool xsdEventNotificationData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2a9f0ee3-c6ad-485d-b2de-20b1317b27ac")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerEvent1 : IRetailerEvent1 {
        internal string evtTmStmpField;
        internal EventToNotify1Code evtToNtfyField = new EventToNotify1Code();
        internal EventContext1 evtCntxtField = new EventContext1();
        internal string addtlEvtInfField;
        internal bool xsdRetailerEvent1InitFlagField = false;
        /// <remarks/>
        public string EvtTmStmp {
            get {
                return this.evtTmStmpField;
            }
            set {
                this.xsdRetailerEvent1InitFlagField = true;
                this.evtTmStmpField = value;
            }
        }
        /// <remarks/>
        public EventToNotify1Code EvtToNtfy {
            get {
                return this.evtToNtfyField;
            }
            set {
                this.xsdRetailerEvent1InitFlagField = true;
                this.evtToNtfyField = value;
            }
        }
        /// <remarks/>
        public EventContext1 EvtCntxt {
            get {
                return this.evtCntxtField;
            }
            set {
                this.xsdRetailerEvent1InitFlagField = true;
                this.evtCntxtField = value;
            }
        }
        /// <remarks/>
        public string AddtlEvtInf {
            get {
                return this.addtlEvtInfField;
            }
            set {
                this.xsdRetailerEvent1InitFlagField = true;
                this.addtlEvtInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdRetailerEvent1InitFlag {
            get {
                return this.xsdRetailerEvent1InitFlagField;
            }
            set {
                this.xsdRetailerEvent1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0224580c-f426-49e1-a777-580bd38ae146")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerEvent1 {
        /// <remarks/>
        [DispId(1)]
        string EvtTmStmp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        EventToNotify1Code EvtToNtfy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        EventContext1 EvtCntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string AddtlEvtInf {
            get;
            set;
        }
        [DispId(9)]
        bool xsdRetailerEvent1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum EventToNotify1Code {
        /// <remarks/>
        ABRT,
        /// <remarks/>
        MAIB,
        /// <remarks/>
        CRDI,
        /// <remarks/>
        COMP,
        /// <remarks/>
        CRDR,
        /// <remarks/>
        CUSL,
        /// <remarks/>
        MAIE,
        /// <remarks/>
        INIT,
        /// <remarks/>
        KEYP,
        /// <remarks/>
        MAIR,
        /// <remarks/>
        OODR,
        /// <remarks/>
        SADM,
        /// <remarks/>
        SWUP,
        /// <remarks/>
        SECA,
        /// <remarks/>
        SHUT,
        /// <remarks/>
        SASS,
        /// <remarks/>
        DISC,
        /// <remarks/>
        CNTN,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ca17b39f-be26-4bc8-8fcf-046608131e05")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EventContext1 : IEventContext1 {
        internal RetailerService1Code svcTpField = new RetailerService1Code();
        internal PointOfInteractionComponent9 cmpntIdField = new PointOfInteractionComponent9();
        internal string saleIdField;
        internal bool xsdEventContext1InitFlagField = false;
        /// <remarks/>
        public RetailerService1Code SvcTp {
            get {
                return this.svcTpField;
            }
            set {
                this.xsdEventContext1InitFlagField = true;
                this.svcTpField = value;
            }
        }
        /// <remarks/>
        public PointOfInteractionComponent9 CmpntId {
            get {
                return this.cmpntIdField;
            }
            set {
                this.xsdEventContext1InitFlagField = true;
                this.cmpntIdField = value;
            }
        }
        /// <remarks/>
        public string SaleId {
            get {
                return this.saleIdField;
            }
            set {
                this.xsdEventContext1InitFlagField = true;
                this.saleIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdEventContext1InitFlag {
            get {
                return this.xsdEventContext1InitFlagField;
            }
            set {
                this.xsdEventContext1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("666fb060-0769-40fe-acce-0ab61ec6baa7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IEventContext1 {
        /// <remarks/>
        [DispId(1)]
        RetailerService1Code SvcTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PointOfInteractionComponent9 CmpntId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string SaleId {
            get;
            set;
        }
        [DispId(7)]
        bool xsdEventContext1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService1Code {
        /// <remarks/>
        DCAQ,
        /// <remarks/>
        ADAQ,
        /// <remarks/>
        ADAP,
        /// <remarks/>
        RPAP,
        /// <remarks/>
        RPAQ,
        /// <remarks/>
        RPTQ,
        /// <remarks/>
        RPTP,
        /// <remarks/>
        SMDQ,
        /// <remarks/>
        SMDP,
        /// <remarks/>
        SMIQ,
        /// <remarks/>
        SMIP,
        /// <remarks/>
        SMOQ,
        /// <remarks/>
        SMOP,
        /// <remarks/>
        DDYQ,
        /// <remarks/>
        DDYP,
        /// <remarks/>
        DCIQ,
        /// <remarks/>
        DCIP,
        /// <remarks/>
        DINO,
        /// <remarks/>
        DINQ,
        /// <remarks/>
        DINP,
        /// <remarks/>
        DSOQ,
        /// <remarks/>
        DSOP,
        /// <remarks/>
        DCPQ,
        /// <remarks/>
        DCPP,
        /// <remarks/>
        DPRQ,
        /// <remarks/>
        DPRP,
        /// <remarks/>
        DSIQ,
        /// <remarks/>
        DSIP,
        /// <remarks/>
        DCAP,
        /// <remarks/>
        DCOQ,
        /// <remarks/>
        DCOP,
        /// <remarks/>
        FSIQ,
        /// <remarks/>
        FSIP,
        /// <remarks/>
        FSBQ,
        /// <remarks/>
        FSBP,
        /// <remarks/>
        FSAQ,
        /// <remarks/>
        FSAP,
        /// <remarks/>
        FSEQ,
        /// <remarks/>
        FSEP,
        /// <remarks/>
        FSLQ,
        /// <remarks/>
        FSLP,
        /// <remarks/>
        FSPQ,
        /// <remarks/>
        FSPP,
        /// <remarks/>
        FSCQ,
        /// <remarks/>
        FSCP,
        /// <remarks/>
        FSRQ,
        /// <remarks/>
        FSRP,
        /// <remarks/>
        FSVQ,
        /// <remarks/>
        FSVP,
        /// <remarks/>
        SSAB,
        /// <remarks/>
        SSEN,
        /// <remarks/>
        SSRR,
        /// <remarks/>
        SSSQ,
        /// <remarks/>
        SSSP,
    }
}
