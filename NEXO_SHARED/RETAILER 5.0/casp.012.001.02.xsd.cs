#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bc4826f7-3257-4323-b788-18139e6515e7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIEventNotificationV02 : ISaleToPOIEventNotificationV02 {
        private Header41 hdrField = new Header41();
        private SystemEventNotification3 evtNtfctnField = new SystemEventNotification3();
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
        public SystemEventNotification3 EvtNtfctn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.evtNtfctnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.evtNtfctnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.evtNtfctnField = new SystemEventNotification3();
                }
                else {
                    this.evtNtfctnField = value;
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
                            || ((this.EvtNtfctn != null)
                            && this.EvtNtfctn.XSD_HasBeenSet))
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
                if ((this.EvtNtfctn != null)) {
                    this.EvtNtfctn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2d210ce9-76d3-41a0-88e0-245d19f5c86d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SystemEventNotification3 : ISystemEventNotification3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private EventNotificationData2 evtNtfctnField = new EventNotificationData2();
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
        public EventNotificationData2 EvtNtfctn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.evtNtfctnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.evtNtfctnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.evtNtfctnField = new EventNotificationData2();
                }
                else {
                    this.evtNtfctnField = value;
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
                return ((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.EvtNtfctn != null)
                            && this.EvtNtfctn.XSD_HasBeenSet))
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
                if ((this.EvtNtfctn != null)) {
                    this.EvtNtfctn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bec9c8fd-5978-4fa7-8091-02e098a5cc7d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EventNotificationData2 : IEventNotificationData2 {
        private RetailerEvent2 rtlrEvtField = new RetailerEvent2();
        private bool mntncReqrdFlgField = default(bool);
        private bool mntncReqrdFlgFieldSpecified = false;
        private string cstmrLangField = default(string);
        private ActionMessage7 dispOutptField = new ActionMessage7();
        private bool mntncReqrdFlgField_XSD_HasBeenSet = false;
        private bool cstmrLangField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public RetailerEvent2 RtlrEvt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rtlrEvtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rtlrEvtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rtlrEvtField = new RetailerEvent2();
                }
                else {
                    this.rtlrEvtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool MntncReqrdFlg {
            get {
                return this.mntncReqrdFlgField;
            }
            set {
                this.mntncReqrdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MntncReqrdFlgSpecified = true
                this.MntncReqrdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool MntncReqrdFlgSpecified {
            get {
                return this.mntncReqrdFlgFieldSpecified;
            }
            set {
                this.mntncReqrdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                this.cstmrLangField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cstmrLangField_XSD_HasBeenSet = (this.cstmrLangField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ActionMessage7 DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dispOutptField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage7();
                }
                else {
                    this.dispOutptField = value;
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
                            || ((this.RtlrEvt != null)
                            && this.RtlrEvt.XSD_HasBeenSet))
                            || ((this.DispOutpt != null)
                            && this.DispOutpt.XSD_HasBeenSet))
                            || this.mntncReqrdFlgField_XSD_HasBeenSet)
                            || this.cstmrLangField_XSD_HasBeenSet)
                            || this.MntncReqrdFlgSpecified);
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
                if ((this.RtlrEvt != null)) {
                    this.RtlrEvt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("538a2bf9-8c08-42f4-bbd8-c07c0e3f7217")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerEvent2 : IRetailerEvent2 {
        private string evtTmStmpField = default(string);
        private EventToNotify2Code evtToNtfyField = default(EventToNotify2Code);
        private EventContext2 evtCntxtField = new EventContext2();
        private string addtlEvtInfField = default(string);
        private bool evtTmStmpField_XSD_HasBeenSet = false;
        private bool evtToNtfyField_XSD_HasBeenSet = false;
        private bool addtlEvtInfField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string EvtTmStmp {
            get {
                return this.evtTmStmpField;
            }
            set {
                this.evtTmStmpField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.evtTmStmpField_XSD_HasBeenSet = (this.evtTmStmpField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public EventToNotify2Code EvtToNtfy {
            get {
                return this.evtToNtfyField;
            }
        }
        /// <remarks/>
        public EventContext2 EvtCntxt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.evtCntxtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.evtCntxtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.evtCntxtField = new EventContext2();
                }
                else {
                    this.evtCntxtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlEvtInf {
            get {
                return this.addtlEvtInfField;
            }
            set {
                this.addtlEvtInfField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlEvtInfField_XSD_HasBeenSet = (this.addtlEvtInfField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false
                            || ((this.EvtCntxt != null)
                            && this.EvtCntxt.XSD_HasBeenSet))
                            || this.evtTmStmpField_XSD_HasBeenSet)
                            || this.evtToNtfyField_XSD_HasBeenSet)
                            || this.addtlEvtInfField_XSD_HasBeenSet);
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
                if ((this.EvtCntxt != null)) {
                    this.EvtCntxt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum EventToNotify2Code {
        _begin,
        _none,
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
        /// <remarks/>
        TNOK,
        /// <remarks/>
        TNKO,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bb96fe27-2cbe-4f6f-a577-de808cb59d43")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class EventContext2 : IEventContext2 {
        private RetailerService1Code svcTpField = default(RetailerService1Code);
        private PointOfInteractionComponent10 cmpntIdField = new PointOfInteractionComponent10();
        private string saleIdField = default(string);
        private bool svcTpField_XSD_HasBeenSet = false;
        private bool saleIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public RetailerService1Code SvcTp {
            get {
                return this.svcTpField;
            }
        }
        /// <remarks/>
        public PointOfInteractionComponent10 CmpntId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.cmpntIdField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cmpntIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cmpntIdField = new PointOfInteractionComponent10();
                }
                else {
                    this.cmpntIdField = value;
                }
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false
                            || ((this.CmpntId != null)
                            && this.CmpntId.XSD_HasBeenSet))
                            || this.svcTpField_XSD_HasBeenSet)
                            || this.saleIdField_XSD_HasBeenSet);
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
                if ((this.CmpntId != null)) {
                    this.CmpntId.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.012.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService1Code {
        _begin,
        _none,
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
        _end,
    }
    [System.Runtime.InteropServices.GuidAttribute("51b582b6-5eff-48f8-b94c-4fbb1044a9bc")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIEventNotificationV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        SystemEventNotification3 EvtNtfctn {
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
    [System.Runtime.InteropServices.GuidAttribute("d0cc9bf9-9e7f-4cc6-8e2d-4f99b9f20896")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISystemEventNotification3 {
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
        EventNotificationData2 EvtNtfctn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(5)]
        int SplmtryDataSize();
        [DispId(6)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(7)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(8)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(9)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("40249d5b-b96f-439d-b0a9-52df7da43d9d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IEventNotificationData2 {
        /// <remarks/>
        [DispId(1)]
        RetailerEvent2 RtlrEvt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool MntncReqrdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool MntncReqrdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ActionMessage7 DispOutpt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("38908f16-5cd9-47e0-8883-8edbbb073ccd")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerEvent2 {
        /// <remarks/>
        [DispId(1)]
        string EvtTmStmp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        EventToNotify2Code EvtToNtfy {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        EventContext2 EvtCntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string AddtlEvtInf {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("15a1097c-1ab2-4270-bd25-59d5e179bec2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IEventContext2 {
        /// <remarks/>
        [DispId(1)]
        RetailerService1Code SvcTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        PointOfInteractionComponent10 CmpntId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string SaleId {
            get;
            set;
        }
    }
}
#endif
