#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7fc4dd4e-5b09-4401-b9e5-6081ed3fd75f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayRequest1 : IDeviceDisplayRequest1 {
        private ActionMessage6[] dispOutptField = new ActionMessage6[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispOutpt")]
        public ActionMessage6[] DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dispOutptField == null)
                            || (this.dispOutptField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage6[0];
                }
                else {
                    this.dispOutptField = value;
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
        public int DispOutptSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dispOutptField == null)) {
                return 0;
            }
            else {
                return this.dispOutptField.Length;
            }
            // END ADDED BY XSD
        }
        public ActionMessage6 DispOutptGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage6[]))) {
                    return default(ActionMessage6);
                }
                else {
                    if (((this.dispOutptField.Length - 1)
                                >= index)) {
                        return this.dispOutptField[index];
                    }
                    else {
                        return default(ActionMessage6);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(ActionMessage6);
            }
            // END ADDED BY XSD
        }
        public bool DispOutptSetItem(int index, ActionMessage6 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    this.dispOutptField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispOutptAddItem(ActionMessage6 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    ActionMessage6[] array = new ActionMessage6[(this.dispOutptField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dispOutptField.Length); i = (i + 1)) {
                        array[i] = dispOutptField[i];
                    }
                    array[i] = value;
                    this.DispOutpt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispOutptRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    if ((this.dispOutptField.Length <= index)) {
                        return false;
                    }
                    else {
                        ActionMessage6[] array = new ActionMessage6[(this.dispOutptField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dispOutptField[i];
                        }
                        for (i = (i + 1); (i < this.dispOutptField.Length); i = (i + 1)) {
                            array[i] = dispOutptField[i];
                        }
                        this.DispOutpt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9f1b570b-d35e-4e33-8bfa-8059619a4f74")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderRequest1 : IDeviceInitialisationCardReaderRequest1 {
        private bool warmRstFlgField;
        private bool warmRstFlgFieldSpecified;
        private CardDataReading6Code[] forceNtryMdField = new CardDataReading6Code[0];
        private bool leavCardFlgField;
        private bool leavCardFlgFieldSpecified;
        private double maxWtgTmField;
        private bool maxWtgTmFieldSpecified;
        private ActionMessage6 dispOutptField = new ActionMessage6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public bool WarmRstFlg {
            get {
                return this.warmRstFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.warmRstFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - WarmRstFlgSpecified = true
                this.WarmRstFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarmRstFlgSpecified {
            get {
                return this.warmRstFlgFieldSpecified;
            }
            set {
                this.warmRstFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceNtryMd")]
        public CardDataReading6Code[] ForceNtryMd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.forceNtryMdField == null)
                            || (this.forceNtryMdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.forceNtryMdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.forceNtryMdField = value;
            }
        }
        /// <remarks/>
        public bool LeavCardFlg {
            get {
                return this.leavCardFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.leavCardFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - LeavCardFlgSpecified = true
                this.LeavCardFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeavCardFlgSpecified {
            get {
                return this.leavCardFlgFieldSpecified;
            }
            set {
                this.leavCardFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dispOutptField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage6();
                }
                else {
                    this.dispOutptField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty)
                            || this.WarmRstFlgSpecified)
                            || this.LeavCardFlgSpecified)
                            || this.MaxWtgTmSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DispOutpt = null;
                    this.WarmRstFlgSpecified = false;
                    this.LeavCardFlgSpecified = false;
                    this.MaxWtgTmSpecified = false;
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int ForceNtryMdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.forceNtryMdField == null)) {
                return 0;
            }
            else {
                return this.forceNtryMdField.Length;
            }
            // END ADDED BY XSD
        }
        public CardDataReading6Code ForceNtryMdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading6Code[]))) {
                    return default(CardDataReading6Code);
                }
                else {
                    if (((this.forceNtryMdField.Length - 1)
                                >= index)) {
                        return this.forceNtryMdField[index];
                    }
                    else {
                        return default(CardDataReading6Code);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CardDataReading6Code);
            }
            // END ADDED BY XSD
        }
        public bool ForceNtryMdSetItem(int index, CardDataReading6Code value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading6Code[]))) {
                    return false;
                }
                else {
                    this.forceNtryMdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ForceNtryMdAddItem(CardDataReading6Code value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading6Code[]))) {
                    return false;
                }
                else {
                    CardDataReading6Code[] array = new CardDataReading6Code[(this.forceNtryMdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.forceNtryMdField.Length); i = (i + 1)) {
                        array[i] = forceNtryMdField[i];
                    }
                    array[i] = value;
                    this.ForceNtryMd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ForceNtryMdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading6Code[]))) {
                    return false;
                }
                else {
                    if ((this.forceNtryMdField.Length <= index)) {
                        return false;
                    }
                    else {
                        CardDataReading6Code[] array = new CardDataReading6Code[(this.forceNtryMdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = forceNtryMdField[i];
                        }
                        for (i = (i + 1); (i < this.forceNtryMdField.Length); i = (i + 1)) {
                            array[i] = forceNtryMdField[i];
                        }
                        this.ForceNtryMd = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f0508cd7-c920-458d-9371-0ca7a27786bd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputNotification1 : IDeviceInputNotification1 {
        private string xchgIdField;
        private ActionMessage6 outptCnttField = new ActionMessage6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 OutptCntt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.outptCnttField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptCnttField = new ActionMessage6();
                }
                else {
                    this.outptCnttField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.OutptCntt.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.OutptCntt = null;
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
                if ((this.OutptCntt != null)) {
                    this.OutptCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("45d36654-4071-4bbe-93a4-2c72c4fb4ffa")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputRequest1 : IDeviceInputRequest1 {
        private ActionMessage6 dispOutptField = new ActionMessage6();
        private InputData1 inptDataField = new InputData1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dispOutptField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage6();
                }
                else {
                    this.dispOutptField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public InputData1 InptData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptDataField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptDataField = new InputData1();
                }
                else {
                    this.inptDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty)
                            || this.InptData.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DispOutpt = null;
                    this.InptData = null;
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InptData != null)) {
                    this.InptData.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("348a5e01-9d85-490d-acec-6c7637f8aa1e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputData1 : IInputData1 {
        private SaleCapabilities2Code dvcTpField;
        private InformationQualify1Code infQlfrField;
        private InputCommand1Code inptCmdField;
        private bool ntfyCardInptFlgField;
        private double maxInptTmField;
        private bool maxInptTmFieldSpecified;
        private ActionMessage6 inptTxtField = new ActionMessage6();
        private bool imdtRspnFlgField;
        private bool imdtRspnFlgFieldSpecified;
        private bool waitUsrVldtnFlgField;
        private bool waitUsrVldtnFlgFieldSpecified;
        private bool beepKeyFlgField;
        private bool beepKeyFlgFieldSpecified;
        private bool gblCrrctnFlgField;
        private bool gblCrrctnFlgFieldSpecified;
        private bool dsblCclFlgField;
        private bool dsblCclFlgFieldSpecified;
        private bool dsblCrrctFlgField;
        private bool dsblCrrctFlgFieldSpecified;
        private bool dsblVldFlgField;
        private bool dsblVldFlgFieldSpecified;
        private bool menuBckFlgField;
        private bool menuBckFlgFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.inptCmdField = value;
            }
        }
        /// <remarks/>
        public bool NtfyCardInptFlg {
            get {
                return this.ntfyCardInptFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ntfyCardInptFlgField = value;
            }
        }
        /// <remarks/>
        public double MaxInptTm {
            get {
                return this.maxInptTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.maxInptTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxInptTmSpecified = true
                this.MaxInptTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxInptTmSpecified {
            get {
                return this.maxInptTmFieldSpecified;
            }
            set {
                this.maxInptTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 InptTxt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptTxtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptTxtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptTxtField = new ActionMessage6();
                }
                else {
                    this.inptTxtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool ImdtRspnFlg {
            get {
                return this.imdtRspnFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.imdtRspnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - ImdtRspnFlgSpecified = true
                this.ImdtRspnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImdtRspnFlgSpecified {
            get {
                return this.imdtRspnFlgFieldSpecified;
            }
            set {
                this.imdtRspnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool WaitUsrVldtnFlg {
            get {
                return this.waitUsrVldtnFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.waitUsrVldtnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - WaitUsrVldtnFlgSpecified = true
                this.WaitUsrVldtnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WaitUsrVldtnFlgSpecified {
            get {
                return this.waitUsrVldtnFlgFieldSpecified;
            }
            set {
                this.waitUsrVldtnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool BeepKeyFlg {
            get {
                return this.beepKeyFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.beepKeyFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BeepKeyFlgSpecified = true
                this.BeepKeyFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeepKeyFlgSpecified {
            get {
                return this.beepKeyFlgFieldSpecified;
            }
            set {
                this.beepKeyFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool GblCrrctnFlg {
            get {
                return this.gblCrrctnFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.gblCrrctnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - GblCrrctnFlgSpecified = true
                this.GblCrrctnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GblCrrctnFlgSpecified {
            get {
                return this.gblCrrctnFlgFieldSpecified;
            }
            set {
                this.gblCrrctnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblCclFlg {
            get {
                return this.dsblCclFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dsblCclFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblCclFlgSpecified = true
                this.DsblCclFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblCclFlgSpecified {
            get {
                return this.dsblCclFlgFieldSpecified;
            }
            set {
                this.dsblCclFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblCrrctFlg {
            get {
                return this.dsblCrrctFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dsblCrrctFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblCrrctFlgSpecified = true
                this.DsblCrrctFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblCrrctFlgSpecified {
            get {
                return this.dsblCrrctFlgFieldSpecified;
            }
            set {
                this.dsblCrrctFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblVldFlg {
            get {
                return this.dsblVldFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dsblVldFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - DsblVldFlgSpecified = true
                this.DsblVldFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblVldFlgSpecified {
            get {
                return this.dsblVldFlgFieldSpecified;
            }
            set {
                this.dsblVldFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool MenuBckFlg {
            get {
                return this.menuBckFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.menuBckFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MenuBckFlgSpecified = true
                this.MenuBckFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MenuBckFlgSpecified {
            get {
                return this.menuBckFlgFieldSpecified;
            }
            set {
                this.menuBckFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((((((((this.XSD_HasBeenSetField || this.InptTxt.XSD_HasBeenSetProperty)
                            || this.MaxInptTmSpecified)
                            || this.ImdtRspnFlgSpecified)
                            || this.WaitUsrVldtnFlgSpecified)
                            || this.BeepKeyFlgSpecified)
                            || this.GblCrrctnFlgSpecified)
                            || this.DsblCclFlgSpecified)
                            || this.DsblCrrctFlgSpecified)
                            || this.DsblVldFlgSpecified)
                            || this.MenuBckFlgSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.InptTxt = null;
                    this.MaxInptTmSpecified = false;
                    this.ImdtRspnFlgSpecified = false;
                    this.WaitUsrVldtnFlgSpecified = false;
                    this.BeepKeyFlgSpecified = false;
                    this.GblCrrctnFlgSpecified = false;
                    this.DsblCclFlgSpecified = false;
                    this.DsblCrrctFlgSpecified = false;
                    this.DsblVldFlgSpecified = false;
                    this.MenuBckFlgSpecified = false;
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
                if ((this.InptTxt != null)) {
                    this.InptTxt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SaleCapabilities2Code {
        /// <remarks/>
        CHIN,
        /// <remarks/>
        CUIN,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum InputCommand1Code {
        /// <remarks/>
        DCSG,
        /// <remarks/>
        DGSG,
        /// <remarks/>
        GAKY,
        /// <remarks/>
        GCNF,
        /// <remarks/>
        GFKY,
        /// <remarks/>
        GMNE,
        /// <remarks/>
        PSWD,
        /// <remarks/>
        SITE,
        /// <remarks/>
        TXSG,
        /// <remarks/>
        HTML,
        /// <remarks/>
        SIGN,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("106312c2-3eff-4435-ba32-8efc1ab45686")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePlaySoundRequest1 : IDevicePlaySoundRequest1 {
        private ResponseMode1Code rspnMdField;
        private bool rspnMdFieldSpecified;
        private SoundAction1Code soundActnField;
        private double soundVolField;
        private bool soundVolFieldSpecified;
        private SoundContent1 soundCnttField = new SoundContent1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnMdField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RspnMdSpecified = true
                this.RspnMdSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RspnMdSpecified {
            get {
                return this.rspnMdFieldSpecified;
            }
            set {
                this.rspnMdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public SoundAction1Code SoundActn {
            get {
                return this.soundActnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.soundActnField = value;
            }
        }
        /// <remarks/>
        public double SoundVol {
            get {
                return this.soundVolField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.soundVolField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - SoundVolSpecified = true
                this.SoundVolSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundVolSpecified {
            get {
                return this.soundVolFieldSpecified;
            }
            set {
                this.soundVolFieldSpecified = value;
            }
        }
        /// <remarks/>
        public SoundContent1 SoundCntt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.soundCnttField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.soundCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.soundCnttField = new SoundContent1();
                }
                else {
                    this.soundCnttField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.SoundCntt.XSD_HasBeenSetProperty)
                            || this.RspnMdSpecified)
                            || this.SoundVolSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SoundCntt = null;
                    this.RspnMdSpecified = false;
                    this.SoundVolSpecified = false;
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
                if ((this.SoundCntt != null)) {
                    this.SoundCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ResponseMode1Code {
        /// <remarks/>
        IMMD,
        /// <remarks/>
        NREQ,
        /// <remarks/>
        PEND,
        /// <remarks/>
        SEND,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoundAction1Code {
        /// <remarks/>
        DVOL,
        /// <remarks/>
        STAS,
        /// <remarks/>
        STOS,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("07085935-e2cd-4ade-b7d6-998b0f30b04e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoundContent1 : ISoundContent1 {
        private SoundFormat1Code soundFrmtField;
        private string langField;
        private string soundRefField;
        private string txtField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public SoundFormat1Code SoundFrmt {
            get {
                return this.soundFrmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.soundFrmtField = value;
            }
        }
        /// <remarks/>
        public string Lang {
            get {
                return this.langField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.langField = value;
            }
        }
        /// <remarks/>
        public string SoundRef {
            get {
                return this.soundRefField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.soundRefField = value;
            }
        }
        /// <remarks/>
        public string Txt {
            get {
                return this.txtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.txtField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoundFormat1Code {
        /// <remarks/>
        MSGR,
        /// <remarks/>
        SNDR,
        /// <remarks/>
        TEXT,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("70bb4b1c-8bbe-4514-bca6-80b910f91840")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePoweroffCardReaderRequest1 : IDevicePoweroffCardReaderRequest1 {
        private double pwrOffMaxWtgTmField;
        private bool pwrOffMaxWtgTmFieldSpecified;
        private ActionMessage6 dispOutptField = new ActionMessage6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public double PwrOffMaxWtgTm {
            get {
                return this.pwrOffMaxWtgTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pwrOffMaxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - PwrOffMaxWtgTmSpecified = true
                this.PwrOffMaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PwrOffMaxWtgTmSpecified {
            get {
                return this.pwrOffMaxWtgTmFieldSpecified;
            }
            set {
                this.pwrOffMaxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dispOutptField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispOutptField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dispOutptField = new ActionMessage6();
                }
                else {
                    this.dispOutptField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.DispOutpt.XSD_HasBeenSetProperty)
                            || this.PwrOffMaxWtgTmSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DispOutpt = null;
                    this.PwrOffMaxWtgTmSpecified = false;
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4c1b1345-e220-411c-85c5-67baec05ed9c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintRequest1 : IDevicePrintRequest1 {
        private DocumentType7Code docQlfrField;
        private ResponseMode1Code rspnMdField;
        private bool intgrtdPrtFlgField;
        private bool intgrtdPrtFlgFieldSpecified;
        private bool reqrdSgntrFlgField;
        private bool reqrdSgntrFlgFieldSpecified;
        private ActionMessage6 outptCnttField = new ActionMessage6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.docQlfrField = value;
            }
        }
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnMdField = value;
            }
        }
        /// <remarks/>
        public bool IntgrtdPrtFlg {
            get {
                return this.intgrtdPrtFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.intgrtdPrtFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - IntgrtdPrtFlgSpecified = true
                this.IntgrtdPrtFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntgrtdPrtFlgSpecified {
            get {
                return this.intgrtdPrtFlgFieldSpecified;
            }
            set {
                this.intgrtdPrtFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool ReqrdSgntrFlg {
            get {
                return this.reqrdSgntrFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.reqrdSgntrFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - ReqrdSgntrFlgSpecified = true
                this.ReqrdSgntrFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReqrdSgntrFlgSpecified {
            get {
                return this.reqrdSgntrFlgFieldSpecified;
            }
            set {
                this.reqrdSgntrFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 OutptCntt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.outptCnttField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptCnttField = new ActionMessage6();
                }
                else {
                    this.outptCnttField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.OutptCntt.XSD_HasBeenSetProperty)
                            || this.IntgrtdPrtFlgSpecified)
                            || this.ReqrdSgntrFlgSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.OutptCntt = null;
                    this.IntgrtdPrtFlgSpecified = false;
                    this.ReqrdSgntrFlgSpecified = false;
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
                if ((this.OutptCntt != null)) {
                    this.OutptCntt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("5002fe40-ee6a-4fc7-b7f3-35016ef2b567")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceRequest2 : IDeviceRequest2 {
        private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        private CardPaymentContext27 cntxtField = new CardPaymentContext27();
        private RetailerService8Code svcCnttField;
        private ActionMessage6[] dispReqField = new ActionMessage6[0];
        private DeviceInputRequest1 inptReqField = new DeviceInputRequest1();
        private DevicePrintRequest1 prtReqField = new DevicePrintRequest1();
        private DevicePlaySoundRequest1 playSoundReqField = new DevicePlaySoundRequest1();
        private DeviceSecureInputRequest1 scrInptReqField = new DeviceSecureInputRequest1();
        private DeviceInitialisationCardReaderRequest1 initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest1();
        private DeviceSendApplicationProtocolDataUnitCardReaderRequest1 cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
        private DevicePoweroffCardReaderRequest1 pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest1();
        private DeviceTransmitMessageRequest1 trnsmssnReqField = new DeviceTransmitMessageRequest1();
        private DeviceInputNotification1 inptNtfctnField = new DeviceInputNotification1();
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
        public RetailerService8Code SvcCntt {
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
        [System.Xml.Serialization.XmlArrayItemAttribute("DispOutpt", IsNullable=false)]
        public ActionMessage6[] DispReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dispReqField == null)
                            || (this.dispReqField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dispReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dispReqField = new ActionMessage6[0];
                }
                else {
                    this.dispReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInputRequest1 InptReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptReqField = new DeviceInputRequest1();
                }
                else {
                    this.inptReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DevicePrintRequest1 PrtReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.prtReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtReqField = new DevicePrintRequest1();
                }
                else {
                    this.prtReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DevicePlaySoundRequest1 PlaySoundReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.playSoundReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.playSoundReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.playSoundReqField = new DevicePlaySoundRequest1();
                }
                else {
                    this.playSoundReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceSecureInputRequest1 ScrInptReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.scrInptReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.scrInptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.scrInptReqField = new DeviceSecureInputRequest1();
                }
                else {
                    this.scrInptReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.initlstnCardRdrReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.initlstnCardRdrReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest1();
                }
                else {
                    this.initlstnCardRdrReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.cardRdrAPDUReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cardRdrAPDUReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
                }
                else {
                    this.cardRdrAPDUReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pwrOffCardRdrReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pwrOffCardRdrReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest1();
                }
                else {
                    this.pwrOffCardRdrReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceTransmitMessageRequest1 TrnsmssnReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.trnsmssnReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.trnsmssnReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.trnsmssnReqField = new DeviceTransmitMessageRequest1();
                }
                else {
                    this.trnsmssnReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInputNotification1 InptNtfctn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.inptNtfctnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptNtfctnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptNtfctnField = new DeviceInputNotification1();
                }
                else {
                    this.inptNtfctnField = value;
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
                return (((((((((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
                            || this.Cntxt.XSD_HasBeenSetProperty)
                            || this.InptReq.XSD_HasBeenSetProperty)
                            || this.PrtReq.XSD_HasBeenSetProperty)
                            || this.PlaySoundReq.XSD_HasBeenSetProperty)
                            || this.ScrInptReq.XSD_HasBeenSetProperty)
                            || this.InitlstnCardRdrReq.XSD_HasBeenSetProperty)
                            || this.CardRdrAPDUReq.XSD_HasBeenSetProperty)
                            || this.PwrOffCardRdrReq.XSD_HasBeenSetProperty)
                            || this.TrnsmssnReq.XSD_HasBeenSetProperty)
                            || this.InptNtfctn.XSD_HasBeenSetProperty);
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
                    this.InptReq = null;
                    this.PrtReq = null;
                    this.PlaySoundReq = null;
                    this.ScrInptReq = null;
                    this.InitlstnCardRdrReq = null;
                    this.CardRdrAPDUReq = null;
                    this.PwrOffCardRdrReq = null;
                    this.TrnsmssnReq = null;
                    this.InptNtfctn = null;
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
                if ((this.InptReq != null)) {
                    this.InptReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PrtReq != null)) {
                    this.PrtReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PlaySoundReq != null)) {
                    this.PlaySoundReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.ScrInptReq != null)) {
                    this.ScrInptReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InitlstnCardRdrReq != null)) {
                    this.InitlstnCardRdrReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.CardRdrAPDUReq != null)) {
                    this.CardRdrAPDUReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PwrOffCardRdrReq != null)) {
                    this.PwrOffCardRdrReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.TrnsmssnReq != null)) {
                    this.TrnsmssnReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.InptNtfctn != null)) {
                    this.InptNtfctn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int DispReqSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dispReqField == null)) {
                return 0;
            }
            else {
                return this.dispReqField.Length;
            }
            // END ADDED BY XSD
        }
        public ActionMessage6 DispReqGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage6[]))) {
                    return default(ActionMessage6);
                }
                else {
                    if (((this.dispReqField.Length - 1)
                                >= index)) {
                        return this.dispReqField[index];
                    }
                    else {
                        return default(ActionMessage6);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(ActionMessage6);
            }
            // END ADDED BY XSD
        }
        public bool DispReqSetItem(int index, ActionMessage6 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    this.dispReqField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispReqAddItem(ActionMessage6 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    ActionMessage6[] array = new ActionMessage6[(this.dispReqField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dispReqField.Length); i = (i + 1)) {
                        array[i] = dispReqField[i];
                    }
                    array[i] = value;
                    this.DispReq = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DispReqRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage6[]))) {
                    return false;
                }
                else {
                    if ((this.dispReqField.Length <= index)) {
                        return false;
                    }
                    else {
                        ActionMessage6[] array = new ActionMessage6[(this.dispReqField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dispReqField[i];
                        }
                        for (i = (i + 1); (i < this.dispReqField.Length); i = (i + 1)) {
                            array[i] = dispReqField[i];
                        }
                        this.DispReq = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService8Code {
        /// <remarks/>
        DDYQ,
        /// <remarks/>
        DINQ,
        /// <remarks/>
        DPRQ,
        /// <remarks/>
        DSOQ,
        /// <remarks/>
        DSIQ,
        /// <remarks/>
        DCIQ,
        /// <remarks/>
        DCAQ,
        /// <remarks/>
        DCPQ,
        /// <remarks/>
        DCOQ,
        /// <remarks/>
        DINO,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4c4d25bb-e0d1-4236-aa60-f78d29480a4e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputRequest1 : IDeviceSecureInputRequest1 {
        private PINRequestType1Code pINReqTpField;
        private string pINVrfctnMtdField;
        private double maxWtgTmField;
        private bool maxWtgTmFieldSpecified;
        private bool beepKeyFlgField;
        private bool beepKeyFlgFieldSpecified;
        private OnLinePIN6 crdhldrPINField = new OnLinePIN6();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public PINRequestType1Code PINReqTp {
            get {
                return this.pINReqTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pINReqTpField = value;
            }
        }
        /// <remarks/>
        public string PINVrfctnMtd {
            get {
                return this.pINVrfctnMtdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pINVrfctnMtdField = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool BeepKeyFlg {
            get {
                return this.beepKeyFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.beepKeyFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - BeepKeyFlgSpecified = true
                this.BeepKeyFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeepKeyFlgSpecified {
            get {
                return this.beepKeyFlgFieldSpecified;
            }
            set {
                this.beepKeyFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public OnLinePIN6 CrdhldrPIN {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.crdhldrPINField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.crdhldrPINField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.crdhldrPINField = new OnLinePIN6();
                }
                else {
                    this.crdhldrPINField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.CrdhldrPIN.XSD_HasBeenSetProperty)
                            || this.MaxWtgTmSpecified)
                            || this.BeepKeyFlgSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.CrdhldrPIN = null;
                    this.MaxWtgTmSpecified = false;
                    this.BeepKeyFlgSpecified = false;
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
                if ((this.CrdhldrPIN != null)) {
                    this.CrdhldrPIN.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PINRequestType1Code {
        /// <remarks/>
        PIAE,
        /// <remarks/>
        PIAV,
        /// <remarks/>
        PIVO,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9f7f3e64-b739-4533-be4e-3705b9262aec")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSendApplicationProtocolDataUnitCardReaderRequest1 : IDeviceSendApplicationProtocolDataUnitCardReaderRequest1 {
        private byte[] clssField = new byte[0];
        private byte[] instrField = new byte[0];
        private byte[] param1Field = new byte[0];
        private byte[] param2Field = new byte[0];
        private byte[] dataField = new byte[0];
        private byte[] xpctdLngthField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Clss {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.clssField == null)
                            || (this.clssField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.clssField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.clssField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Instr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.instrField == null)
                            || (this.instrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.instrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.instrField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Param1 {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.param1Field == null)
                            || (this.param1Field.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.param1Field;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.param1Field = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Param2 {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.param2Field == null)
                            || (this.param2Field.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.param2Field;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.param2Field = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Data {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dataField == null)
                            || (this.dataField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dataField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.dataField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] XpctdLngth {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.xpctdLngthField == null)
                            || (this.xpctdLngthField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.xpctdLngthField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.xpctdLngthField = value;
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
        public int ClssSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.clssField == null)) {
                return 0;
            }
            else {
                return this.clssField.Length;
            }
            // END ADDED BY XSD
        }
        public byte ClssGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.clssField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.clssField.Length - 1)
                                >= index)) {
                        return this.clssField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool ClssSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.clssField == default(byte[]))) {
                    return false;
                }
                else {
                    this.clssField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ClssAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.clssField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.clssField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.clssField.Length); i = (i + 1)) {
                        array[i] = clssField[i];
                    }
                    array[i] = value;
                    this.Clss = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ClssRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.clssField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.clssField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.clssField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = clssField[i];
                        }
                        for (i = (i + 1); (i < this.clssField.Length); i = (i + 1)) {
                            array[i] = clssField[i];
                        }
                        this.Clss = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int InstrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.instrField == null)) {
                return 0;
            }
            else {
                return this.instrField.Length;
            }
            // END ADDED BY XSD
        }
        public byte InstrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.instrField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.instrField.Length - 1)
                                >= index)) {
                        return this.instrField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool InstrSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.instrField == default(byte[]))) {
                    return false;
                }
                else {
                    this.instrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool InstrAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.instrField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.instrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.instrField.Length); i = (i + 1)) {
                        array[i] = instrField[i];
                    }
                    array[i] = value;
                    this.Instr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool InstrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.instrField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.instrField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.instrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = instrField[i];
                        }
                        for (i = (i + 1); (i < this.instrField.Length); i = (i + 1)) {
                            array[i] = instrField[i];
                        }
                        this.Instr = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int Param1Size() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.param1Field == null)) {
                return 0;
            }
            else {
                return this.param1Field.Length;
            }
            // END ADDED BY XSD
        }
        public byte Param1GetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.param1Field == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.param1Field.Length - 1)
                                >= index)) {
                        return this.param1Field[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool Param1SetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.param1Field == default(byte[]))) {
                    return false;
                }
                else {
                    this.param1Field[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool Param1AddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.param1Field == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.param1Field.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.param1Field.Length); i = (i + 1)) {
                        array[i] = param1Field[i];
                    }
                    array[i] = value;
                    this.Param1 = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool Param1RemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.param1Field == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.param1Field.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.param1Field.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = param1Field[i];
                        }
                        for (i = (i + 1); (i < this.param1Field.Length); i = (i + 1)) {
                            array[i] = param1Field[i];
                        }
                        this.Param1 = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int Param2Size() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.param2Field == null)) {
                return 0;
            }
            else {
                return this.param2Field.Length;
            }
            // END ADDED BY XSD
        }
        public byte Param2GetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.param2Field == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.param2Field.Length - 1)
                                >= index)) {
                        return this.param2Field[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool Param2SetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.param2Field == default(byte[]))) {
                    return false;
                }
                else {
                    this.param2Field[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool Param2AddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.param2Field == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.param2Field.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.param2Field.Length); i = (i + 1)) {
                        array[i] = param2Field[i];
                    }
                    array[i] = value;
                    this.Param2 = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool Param2RemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.param2Field == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.param2Field.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.param2Field.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = param2Field[i];
                        }
                        for (i = (i + 1); (i < this.param2Field.Length); i = (i + 1)) {
                            array[i] = param2Field[i];
                        }
                        this.Param2 = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int DataSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dataField == null)) {
                return 0;
            }
            else {
                return this.dataField.Length;
            }
            // END ADDED BY XSD
        }
        public byte DataGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.dataField.Length - 1)
                                >= index)) {
                        return this.dataField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool DataSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    this.dataField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DataAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.dataField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dataField.Length); i = (i + 1)) {
                        array[i] = dataField[i];
                    }
                    array[i] = value;
                    this.Data = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool DataRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.dataField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.dataField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        for (i = (i + 1); (i < this.dataField.Length); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        this.Data = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int XpctdLngthSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.xpctdLngthField == null)) {
                return 0;
            }
            else {
                return this.xpctdLngthField.Length;
            }
            // END ADDED BY XSD
        }
        public byte XpctdLngthGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.xpctdLngthField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.xpctdLngthField.Length - 1)
                                >= index)) {
                        return this.xpctdLngthField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool XpctdLngthSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.xpctdLngthField == default(byte[]))) {
                    return false;
                }
                else {
                    this.xpctdLngthField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool XpctdLngthAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.xpctdLngthField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.xpctdLngthField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.xpctdLngthField.Length); i = (i + 1)) {
                        array[i] = xpctdLngthField[i];
                    }
                    array[i] = value;
                    this.XpctdLngth = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool XpctdLngthRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.xpctdLngthField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.xpctdLngthField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.xpctdLngthField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = xpctdLngthField[i];
                        }
                        for (i = (i + 1); (i < this.xpctdLngthField.Length); i = (i + 1)) {
                            array[i] = xpctdLngthField[i];
                        }
                        this.XpctdLngth = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("57c0f6d9-7a62-4dfa-831f-c75d76616c66")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageRequest1 : IDeviceTransmitMessageRequest1 {
        private NetworkParameters5 dstnAdrField = new NetworkParameters5();
        private double maxTrnsmssnTmField;
        private double maxWtgTmField;
        private bool maxWtgTmFieldSpecified;
        private byte[] msgToSndField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public NetworkParameters5 DstnAdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dstnAdrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dstnAdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dstnAdrField = new NetworkParameters5();
                }
                else {
                    this.dstnAdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double MaxTrnsmssnTm {
            get {
                return this.maxTrnsmssnTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.maxTrnsmssnTmField = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgToSnd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.msgToSndField == null)
                            || (this.msgToSndField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgToSndField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.msgToSndField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.DstnAdr.XSD_HasBeenSetProperty)
                            || this.MaxWtgTmSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.DstnAdr = null;
                    this.MaxWtgTmSpecified = false;
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
                if ((this.DstnAdr != null)) {
                    this.DstnAdr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int MsgToSndSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.msgToSndField == null)) {
                return 0;
            }
            else {
                return this.msgToSndField.Length;
            }
            // END ADDED BY XSD
        }
        public byte MsgToSndGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.msgToSndField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.msgToSndField.Length - 1)
                                >= index)) {
                        return this.msgToSndField[index];
                    }
                    else {
                        return default(byte);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(byte);
            }
            // END ADDED BY XSD
        }
        public bool MsgToSndSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.msgToSndField == default(byte[]))) {
                    return false;
                }
                else {
                    this.msgToSndField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgToSndAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.msgToSndField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.msgToSndField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.msgToSndField.Length); i = (i + 1)) {
                        array[i] = msgToSndField[i];
                    }
                    array[i] = value;
                    this.MsgToSnd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgToSndRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.msgToSndField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.msgToSndField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.msgToSndField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = msgToSndField[i];
                        }
                        for (i = (i + 1); (i < this.msgToSndField.Length); i = (i + 1)) {
                            array[i] = msgToSndField[i];
                        }
                        this.MsgToSnd = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("82e39196-672c-4911-96ff-ea39a976f57e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceRequestV01 : ISaleToPOIDeviceRequestV01 {
        private Header37 hdrField = new Header37();
        private DeviceRequest2 dvcReqField = new DeviceRequest2();
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
        public DeviceRequest2 DvcReq {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.dvcReqField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dvcReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dvcReqField = new DeviceRequest2();
                }
                else {
                    this.dvcReqField = value;
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
                            || this.DvcReq.XSD_HasBeenSetProperty)
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
                    this.DvcReq = null;
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
                if ((this.DvcReq != null)) {
                    this.DvcReq.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0a2dd7a3-6ef8-420a-8f25-5a7867f2f238")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceDisplayRequest1 {
        /// <remarks/>
        [DispId(1)]
        ActionMessage6[] DispOutpt {
            get;
            set;
        }
        [DispId(2)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int DispOutptSize();
        [DispId(4)]
        ActionMessage6 DispOutptGetItem(int index);
        [DispId(5)]
        bool DispOutptSetItem(int index, ActionMessage6 value);
        [DispId(6)]
        bool DispOutptAddItem(ActionMessage6 value);
        [DispId(7)]
        bool DispOutptRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("04c875b5-0e4e-48c7-9a64-8d69831e38a2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInitialisationCardReaderRequest1 {
        /// <remarks/>
        [DispId(1)]
        bool WarmRstFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool WarmRstFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        CardDataReading6Code[] ForceNtryMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool LeavCardFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool LeavCardFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        double MaxWtgTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool MaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(9)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(10)]
        int ForceNtryMdSize();
        [DispId(11)]
        CardDataReading6Code ForceNtryMdGetItem(int index);
        [DispId(12)]
        bool ForceNtryMdSetItem(int index, CardDataReading6Code value);
        [DispId(13)]
        bool ForceNtryMdAddItem(CardDataReading6Code value);
        [DispId(14)]
        bool ForceNtryMdRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("b9ca47ac-ed7a-4445-b4e1-90be9d6eb886")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputNotification1 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("b8f59d9d-de73-47fc-a4dc-3f76cd2d05ce")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputRequest1 {
        /// <remarks/>
        [DispId(1)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InputData1 InptData {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7cf9531d-9960-49d8-994c-8b0e1e620afe")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputData1 {
        /// <remarks/>
        [DispId(1)]
        SaleCapabilities2Code DvcTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        InputCommand1Code InptCmd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool NtfyCardInptFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        double MaxInptTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        bool MaxInptTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ActionMessage6 InptTxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        bool ImdtRspnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool ImdtRspnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        bool WaitUsrVldtnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool WaitUsrVldtnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        bool BeepKeyFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        bool BeepKeyFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(14)]
        bool GblCrrctnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool GblCrrctnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(16)]
        bool DsblCclFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        bool DsblCclFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(18)]
        bool DsblCrrctFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        bool DsblCrrctFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(20)]
        bool DsblVldFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        bool DsblVldFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(22)]
        bool MenuBckFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        bool MenuBckFlgSpecified {
            get;
            set;
        }
        [DispId(24)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7f8cf231-5d82-47fd-9ba4-2c40e066b7c6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePlaySoundRequest1 {
        /// <remarks/>
        [DispId(1)]
        ResponseMode1Code RspnMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool RspnMdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SoundAction1Code SoundActn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        double SoundVol {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool SoundVolSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        SoundContent1 SoundCntt {
            get;
            set;
        }
        [DispId(7)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7dcfdf3c-1381-4115-94cc-63d8c2d4ac1b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISoundContent1 {
        /// <remarks/>
        [DispId(1)]
        SoundFormat1Code SoundFrmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string Lang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string SoundRef {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string Txt {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("f0027c67-8fb6-4915-a7eb-df02b55be399")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePoweroffCardReaderRequest1 {
        /// <remarks/>
        [DispId(1)]
        double PwrOffMaxWtgTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool PwrOffMaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("b1e32f68-8255-4ed4-aaf6-59a693c68429")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePrintRequest1 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ResponseMode1Code RspnMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool IntgrtdPrtFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool IntgrtdPrtFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool ReqrdSgntrFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        bool ReqrdSgntrFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(8)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("5dbe8e65-f4f8-4032-83fd-db292a5e81ba")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceRequest2 {
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
        RetailerService8Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        ActionMessage6[] DispReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        DeviceInputRequest1 InptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        DevicePrintRequest1 PrtReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        DevicePlaySoundRequest1 PlaySoundReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        DeviceSecureInputRequest1 ScrInptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        DeviceTransmitMessageRequest1 TrnsmssnReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        DeviceInputNotification1 InptNtfctn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(14)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(15)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(16)]
        int DispReqSize();
        [DispId(17)]
        ActionMessage6 DispReqGetItem(int index);
        [DispId(18)]
        bool DispReqSetItem(int index, ActionMessage6 value);
        [DispId(19)]
        bool DispReqAddItem(ActionMessage6 value);
        [DispId(20)]
        bool DispReqRemoveItem(int index);
        [DispId(21)]
        int SplmtryDataSize();
        [DispId(22)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(23)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(24)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(25)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("0caba8f8-6ff5-431d-9e99-d54ecf48121b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSecureInputRequest1 {
        /// <remarks/>
        [DispId(1)]
        PINRequestType1Code PINReqTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string PINVrfctnMtd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        double MaxWtgTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool MaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool BeepKeyFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        bool BeepKeyFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        OnLinePIN6 CrdhldrPIN {
            get;
            set;
        }
        [DispId(8)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("414a87cb-f344-4db9-afe3-f4420829f246")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSendApplicationProtocolDataUnitCardReaderRequest1 {
        /// <remarks/>
        [DispId(1)]
        byte[] Clss {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        byte[] Instr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        byte[] Param1 {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        byte[] Param2 {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] Data {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        byte[] XpctdLngth {
            get;
            set;
        }
        [DispId(7)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(8)]
        int ClssSize();
        [DispId(9)]
        byte ClssGetItem(int index);
        [DispId(10)]
        bool ClssSetItem(int index, byte value);
        [DispId(11)]
        bool ClssAddItem(byte value);
        [DispId(12)]
        bool ClssRemoveItem(int index);
        [DispId(13)]
        int InstrSize();
        [DispId(14)]
        byte InstrGetItem(int index);
        [DispId(15)]
        bool InstrSetItem(int index, byte value);
        [DispId(16)]
        bool InstrAddItem(byte value);
        [DispId(17)]
        bool InstrRemoveItem(int index);
        [DispId(18)]
        int Param1Size();
        [DispId(19)]
        byte Param1GetItem(int index);
        [DispId(20)]
        bool Param1SetItem(int index, byte value);
        [DispId(21)]
        bool Param1AddItem(byte value);
        [DispId(22)]
        bool Param1RemoveItem(int index);
        [DispId(23)]
        int Param2Size();
        [DispId(24)]
        byte Param2GetItem(int index);
        [DispId(25)]
        bool Param2SetItem(int index, byte value);
        [DispId(26)]
        bool Param2AddItem(byte value);
        [DispId(27)]
        bool Param2RemoveItem(int index);
        [DispId(28)]
        int DataSize();
        [DispId(29)]
        byte DataGetItem(int index);
        [DispId(30)]
        bool DataSetItem(int index, byte value);
        [DispId(31)]
        bool DataAddItem(byte value);
        [DispId(32)]
        bool DataRemoveItem(int index);
        [DispId(33)]
        int XpctdLngthSize();
        [DispId(34)]
        byte XpctdLngthGetItem(int index);
        [DispId(35)]
        bool XpctdLngthSetItem(int index, byte value);
        [DispId(36)]
        bool XpctdLngthAddItem(byte value);
        [DispId(37)]
        bool XpctdLngthRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("aec57acd-476c-42d2-bb11-b96a4de7e228")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceTransmitMessageRequest1 {
        /// <remarks/>
        [DispId(1)]
        NetworkParameters5 DstnAdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        double MaxTrnsmssnTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        double MaxWtgTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool MaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] MsgToSnd {
            get;
            set;
        }
        [DispId(6)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(7)]
        int MsgToSndSize();
        [DispId(8)]
        byte MsgToSndGetItem(int index);
        [DispId(9)]
        bool MsgToSndSetItem(int index, byte value);
        [DispId(10)]
        bool MsgToSndAddItem(byte value);
        [DispId(11)]
        bool MsgToSndRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("83df4693-99b5-41ef-a226-3abeeaa7c60e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIDeviceRequestV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        DeviceRequest2 DvcReq {
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
}
#endif
