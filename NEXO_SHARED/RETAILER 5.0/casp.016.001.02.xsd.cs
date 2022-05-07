#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("48a19b65-32f9-42e3-bdc7-ae6909132305")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayRequest2 : IDeviceDisplayRequest2 {
        private ActionMessage7[] dispOutptField = new ActionMessage7[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispOutpt")]
        public ActionMessage7[] DispOutpt {
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
                    this.dispOutptField = new ActionMessage7[0];
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
                return (false
                            || (this.DispOutptSize() != 0));
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
                for (i = 0; (i < this.DispOutptSize()); i = (i + 1)) {
                    this.DispOutpt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
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
        public ActionMessage7 DispOutptGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage7[]))) {
                    return default(ActionMessage7);
                }
                else {
                    if (((this.dispOutptField.Length - 1)
                                >= index)) {
                        return this.dispOutptField[index];
                    }
                    else {
                        return default(ActionMessage7);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(ActionMessage7);
            }
            // END ADDED BY XSD
        }
        public bool DispOutptSetItem(int index, ActionMessage7 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage7[]))) {
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
        public bool DispOutptAddItem(ActionMessage7 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dispOutptField == default(ActionMessage7[]))) {
                    return false;
                }
                else {
                    ActionMessage7[] array = new ActionMessage7[(this.dispOutptField.Length + 1)];
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
                if ((this.dispOutptField == default(ActionMessage7[]))) {
                    return false;
                }
                else {
                    if ((this.dispOutptField.Length <= index)) {
                        return false;
                    }
                    else {
                        ActionMessage7[] array = new ActionMessage7[(this.dispOutptField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2102f0e8-8a91-40a3-92ae-ca01b3d7a49a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderRequest2 : IDeviceInitialisationCardReaderRequest2 {
        private bool warmRstFlgField = default(bool);
        private bool warmRstFlgFieldSpecified = false;
        private CardDataReading8Code[] forceNtryMdField = new CardDataReading8Code[0];
        private bool leavCardFlgField = default(bool);
        private bool leavCardFlgFieldSpecified = false;
        private double maxWtgTmField = default(double);
        private bool maxWtgTmFieldSpecified = false;
        private ActionMessage7 dispOutptField = new ActionMessage7();
        private bool warmRstFlgField_XSD_HasBeenSet = false;
        private bool leavCardFlgField_XSD_HasBeenSet = false;
        private bool maxWtgTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public bool WarmRstFlg {
            get {
                return this.warmRstFlgField;
            }
            set {
                this.warmRstFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - WarmRstFlgSpecified = true
                this.WarmRstFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
        public CardDataReading8Code[] ForceNtryMd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.forceNtryMdField == null)
                            || (this.forceNtryMdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.forceNtryMdField;
            }
        }
        /// <remarks/>
        public bool LeavCardFlg {
            get {
                return this.leavCardFlgField;
            }
            set {
                this.leavCardFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - LeavCardFlgSpecified = true
                this.LeavCardFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.maxWtgTmFieldSpecified = value;
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
                return ((((((((false
                            || ((this.DispOutpt != null)
                            && this.DispOutpt.XSD_HasBeenSet))
                            || (this.ForceNtryMdSize() != 0))
                            || this.warmRstFlgField_XSD_HasBeenSet)
                            || this.leavCardFlgField_XSD_HasBeenSet)
                            || this.maxWtgTmField_XSD_HasBeenSet)
                            || this.WarmRstFlgSpecified)
                            || this.LeavCardFlgSpecified)
                            || this.MaxWtgTmSpecified);
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.ForceNtryMdSize()); i = (i + 1)) {
                    this.ForceNtryMd[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public CardDataReading8Code ForceNtryMdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading8Code[]))) {
                    return default(CardDataReading8Code);
                }
                else {
                    if (((this.forceNtryMdField.Length - 1)
                                >= index)) {
                        return this.forceNtryMdField[index];
                    }
                    else {
                        return default(CardDataReading8Code);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CardDataReading8Code);
            }
            // END ADDED BY XSD
        }
        public bool ForceNtryMdSetItem(int index, CardDataReading8Code value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading8Code[]))) {
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
        public bool ForceNtryMdAddItem(CardDataReading8Code value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.forceNtryMdField == default(CardDataReading8Code[]))) {
                    return false;
                }
                else {
                    CardDataReading8Code[] array = new CardDataReading8Code[(this.forceNtryMdField.Length + 1)];
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
                if ((this.forceNtryMdField == default(CardDataReading8Code[]))) {
                    return false;
                }
                else {
                    if ((this.forceNtryMdField.Length <= index)) {
                        return false;
                    }
                    else {
                        CardDataReading8Code[] array = new CardDataReading8Code[(this.forceNtryMdField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("747272a8-8a20-4544-923e-83376a4741f8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputNotification2 : IDeviceInputNotification2 {
        private string xchgIdField = default(string);
        private ActionMessage7 outptCnttField = new ActionMessage7();
        private bool xchgIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xchgIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.xchgIdField_XSD_HasBeenSet = (this.xchgIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ActionMessage7 OutptCntt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.outptCnttField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptCnttField = new ActionMessage7();
                }
                else {
                    this.outptCnttField = value;
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
                            || ((this.OutptCntt != null)
                            && this.OutptCntt.XSD_HasBeenSet))
                            || this.xchgIdField_XSD_HasBeenSet);
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
                if ((this.OutptCntt != null)) {
                    this.OutptCntt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("cf828ce3-b3ef-4ebf-8343-e7cc0659f6c3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputRequest2 : IDeviceInputRequest2 {
        private ActionMessage7 dispOutptField = new ActionMessage7();
        private InputData2 inptDataField = new InputData2();
        private bool _XSD_Optimizing = false;
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
        /// <remarks/>
        public InputData2 InptData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptDataField = new InputData2();
                }
                else {
                    this.inptDataField = value;
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
                            || ((this.DispOutpt != null)
                            && this.DispOutpt.XSD_HasBeenSet))
                            || ((this.InptData != null)
                            && this.InptData.XSD_HasBeenSet));
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
                if ((this.DispOutpt != null)) {
                    this.DispOutpt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.InptData != null)) {
                    this.InptData.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9cbb936d-2237-4b0c-b836-293acb6cfa91")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputData2 : IInputData2 {
        private SaleCapabilities2Code dvcTpField = default(SaleCapabilities2Code);
        private InformationQualify1Code infQlfrField = default(InformationQualify1Code);
        private InputCommand1Code inptCmdField = default(InputCommand1Code);
        private bool ntfyCardInptFlgField = default(bool);
        private double maxInptTmField = default(double);
        private bool maxInptTmFieldSpecified = false;
        private ActionMessage7 inptTxtField = new ActionMessage7();
        private bool imdtRspnFlgField = default(bool);
        private bool imdtRspnFlgFieldSpecified = false;
        private bool waitUsrVldtnFlgField = default(bool);
        private bool waitUsrVldtnFlgFieldSpecified = false;
        private bool beepKeyFlgField = default(bool);
        private bool beepKeyFlgFieldSpecified = false;
        private bool gblCrrctnFlgField = default(bool);
        private bool gblCrrctnFlgFieldSpecified = false;
        private bool dsblCclFlgField = default(bool);
        private bool dsblCclFlgFieldSpecified = false;
        private bool dsblCrrctFlgField = default(bool);
        private bool dsblCrrctFlgFieldSpecified = false;
        private bool dsblVldFlgField = default(bool);
        private bool dsblVldFlgFieldSpecified = false;
        private bool menuBckFlgField = default(bool);
        private bool menuBckFlgFieldSpecified = false;
        private bool dvcTpField_XSD_HasBeenSet = false;
        private bool infQlfrField_XSD_HasBeenSet = false;
        private bool inptCmdField_XSD_HasBeenSet = false;
        private bool ntfyCardInptFlgField_XSD_HasBeenSet = false;
        private bool maxInptTmField_XSD_HasBeenSet = false;
        private bool imdtRspnFlgField_XSD_HasBeenSet = false;
        private bool waitUsrVldtnFlgField_XSD_HasBeenSet = false;
        private bool beepKeyFlgField_XSD_HasBeenSet = false;
        private bool gblCrrctnFlgField_XSD_HasBeenSet = false;
        private bool dsblCclFlgField_XSD_HasBeenSet = false;
        private bool dsblCrrctFlgField_XSD_HasBeenSet = false;
        private bool dsblVldFlgField_XSD_HasBeenSet = false;
        private bool menuBckFlgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
        }
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
        }
        /// <remarks/>
        public bool NtfyCardInptFlg {
            get {
                return this.ntfyCardInptFlgField;
            }
            set {
                this.ntfyCardInptFlgField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ntfyCardInptFlgField_XSD_HasBeenSet = (this.ntfyCardInptFlgField != default(bool));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double MaxInptTm {
            get {
                return this.maxInptTmField;
            }
            set {
                this.maxInptTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MaxInptTmSpecified = true
                this.MaxInptTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool MaxInptTmSpecified {
            get {
                return this.maxInptTmFieldSpecified;
            }
            set {
                this.maxInptTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage7 InptTxt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptTxtField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptTxtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptTxtField = new ActionMessage7();
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
                this.imdtRspnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - ImdtRspnFlgSpecified = true
                this.ImdtRspnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.waitUsrVldtnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - WaitUsrVldtnFlgSpecified = true
                this.WaitUsrVldtnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.beepKeyFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - BeepKeyFlgSpecified = true
                this.BeepKeyFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.gblCrrctnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - GblCrrctnFlgSpecified = true
                this.GblCrrctnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.dsblCclFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - DsblCclFlgSpecified = true
                this.DsblCclFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.dsblCrrctFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - DsblCrrctFlgSpecified = true
                this.DsblCrrctFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.dsblVldFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - DsblVldFlgSpecified = true
                this.DsblVldFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.menuBckFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MenuBckFlgSpecified = true
                this.MenuBckFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool MenuBckFlgSpecified {
            get {
                return this.menuBckFlgFieldSpecified;
            }
            set {
                this.menuBckFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((((((((((((((((false
                            || ((this.InptTxt != null)
                            && this.InptTxt.XSD_HasBeenSet))
                            || this.dvcTpField_XSD_HasBeenSet)
                            || this.infQlfrField_XSD_HasBeenSet)
                            || this.inptCmdField_XSD_HasBeenSet)
                            || this.ntfyCardInptFlgField_XSD_HasBeenSet)
                            || this.maxInptTmField_XSD_HasBeenSet)
                            || this.imdtRspnFlgField_XSD_HasBeenSet)
                            || this.waitUsrVldtnFlgField_XSD_HasBeenSet)
                            || this.beepKeyFlgField_XSD_HasBeenSet)
                            || this.gblCrrctnFlgField_XSD_HasBeenSet)
                            || this.dsblCclFlgField_XSD_HasBeenSet)
                            || this.dsblCrrctFlgField_XSD_HasBeenSet)
                            || this.dsblVldFlgField_XSD_HasBeenSet)
                            || this.menuBckFlgField_XSD_HasBeenSet)
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
                if ((this.InptTxt != null)) {
                    this.InptTxt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SaleCapabilities2Code {
        _begin,
        _none,
        /// <remarks/>
        CHIN,
        /// <remarks/>
        CUIN,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum InputCommand1Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("feecb03e-80d0-446d-a88f-8a8ecbe1aa3f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePlaySoundRequest1 : IDevicePlaySoundRequest1 {
        private ResponseMode1Code rspnMdField = default(ResponseMode1Code);
        private bool rspnMdFieldSpecified = false;
        private SoundAction1Code soundActnField = default(SoundAction1Code);
        private double soundVolField = default(double);
        private bool soundVolFieldSpecified = false;
        private SoundContent1 soundCnttField = new SoundContent1();
        private bool rspnMdField_XSD_HasBeenSet = false;
        private bool soundActnField_XSD_HasBeenSet = false;
        private bool soundVolField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
        }
        /// <remarks/>
        public double SoundVol {
            get {
                return this.soundVolField;
            }
            set {
                this.soundVolField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - SoundVolSpecified = true
                this.SoundVolSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.soundCnttField.XSD_HasBeenSet == false))) {
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false
                            || ((this.SoundCntt != null)
                            && this.SoundCntt.XSD_HasBeenSet))
                            || this.rspnMdField_XSD_HasBeenSet)
                            || this.soundActnField_XSD_HasBeenSet)
                            || this.soundVolField_XSD_HasBeenSet)
                            || this.SoundVolSpecified);
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
                if ((this.SoundCntt != null)) {
                    this.SoundCntt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ResponseMode1Code {
        _begin,
        _none,
        /// <remarks/>
        IMMD,
        /// <remarks/>
        NREQ,
        /// <remarks/>
        PEND,
        /// <remarks/>
        SEND,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoundAction1Code {
        _begin,
        _none,
        /// <remarks/>
        DVOL,
        /// <remarks/>
        STAS,
        /// <remarks/>
        STOS,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3b69407c-0d8c-466d-99ef-39026e491e72")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoundContent1 : ISoundContent1 {
        private SoundFormat1Code soundFrmtField = default(SoundFormat1Code);
        private string langField = default(string);
        private string soundRefField = default(string);
        private string txtField = default(string);
        private bool soundFrmtField_XSD_HasBeenSet = false;
        private bool langField_XSD_HasBeenSet = false;
        private bool soundRefField_XSD_HasBeenSet = false;
        private bool txtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public SoundFormat1Code SoundFrmt {
            get {
                return this.soundFrmtField;
            }
        }
        /// <remarks/>
        public string Lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.langField_XSD_HasBeenSet = (this.langField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string SoundRef {
            get {
                return this.soundRefField;
            }
            set {
                this.soundRefField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.soundRefField_XSD_HasBeenSet = (this.soundRefField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string Txt {
            get {
                return this.txtField;
            }
            set {
                this.txtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.txtField_XSD_HasBeenSet = (this.txtField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false || this.soundFrmtField_XSD_HasBeenSet)
                            || this.langField_XSD_HasBeenSet)
                            || this.soundRefField_XSD_HasBeenSet)
                            || this.txtField_XSD_HasBeenSet);
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
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoundFormat1Code {
        _begin,
        _none,
        /// <remarks/>
        MSGR,
        /// <remarks/>
        SNDR,
        /// <remarks/>
        TEXT,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("63e8aaa4-47e9-4752-97a9-3faa5d6e8c1a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePoweroffCardReaderRequest2 : IDevicePoweroffCardReaderRequest2 {
        private double pwrOffMaxWtgTmField = default(double);
        private bool pwrOffMaxWtgTmFieldSpecified = false;
        private ActionMessage7 dispOutptField = new ActionMessage7();
        private bool pwrOffMaxWtgTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public double PwrOffMaxWtgTm {
            get {
                return this.pwrOffMaxWtgTmField;
            }
            set {
                this.pwrOffMaxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - PwrOffMaxWtgTmSpecified = true
                this.PwrOffMaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool PwrOffMaxWtgTmSpecified {
            get {
                return this.pwrOffMaxWtgTmFieldSpecified;
            }
            set {
                this.pwrOffMaxWtgTmFieldSpecified = value;
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
                return (((false
                            || ((this.DispOutpt != null)
                            && this.DispOutpt.XSD_HasBeenSet))
                            || this.pwrOffMaxWtgTmField_XSD_HasBeenSet)
                            || this.PwrOffMaxWtgTmSpecified);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2791335e-055c-4dc8-9c40-fdbf5114e1bd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintRequest2 : IDevicePrintRequest2 {
        private DocumentType7Code docQlfrField = default(DocumentType7Code);
        private ResponseMode1Code rspnMdField = default(ResponseMode1Code);
        private bool intgrtdPrtFlgField = default(bool);
        private bool intgrtdPrtFlgFieldSpecified = false;
        private bool reqrdSgntrFlgField = default(bool);
        private bool reqrdSgntrFlgFieldSpecified = false;
        private ActionMessage7 outptCnttField = new ActionMessage7();
        private bool docQlfrField_XSD_HasBeenSet = false;
        private bool rspnMdField_XSD_HasBeenSet = false;
        private bool intgrtdPrtFlgField_XSD_HasBeenSet = false;
        private bool reqrdSgntrFlgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
        }
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
        }
        /// <remarks/>
        public bool IntgrtdPrtFlg {
            get {
                return this.intgrtdPrtFlgField;
            }
            set {
                this.intgrtdPrtFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - IntgrtdPrtFlgSpecified = true
                this.IntgrtdPrtFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.reqrdSgntrFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - ReqrdSgntrFlgSpecified = true
                this.ReqrdSgntrFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool ReqrdSgntrFlgSpecified {
            get {
                return this.reqrdSgntrFlgFieldSpecified;
            }
            set {
                this.reqrdSgntrFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage7 OutptCntt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.outptCnttField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptCnttField = new ActionMessage7();
                }
                else {
                    this.outptCnttField = value;
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
                            || ((this.OutptCntt != null)
                            && this.OutptCntt.XSD_HasBeenSet))
                            || this.docQlfrField_XSD_HasBeenSet)
                            || this.rspnMdField_XSD_HasBeenSet)
                            || this.intgrtdPrtFlgField_XSD_HasBeenSet)
                            || this.reqrdSgntrFlgField_XSD_HasBeenSet)
                            || this.IntgrtdPrtFlgSpecified)
                            || this.ReqrdSgntrFlgSpecified);
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
                if ((this.OutptCntt != null)) {
                    this.OutptCntt.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2d563a6f-5090-45df-89ad-04b9d9ee828e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceRequest3 : IDeviceRequest3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService8Code svcCnttField = default(RetailerService8Code);
        private ActionMessage7[] dispReqField = new ActionMessage7[0];
        private DeviceInputRequest2 inptReqField = new DeviceInputRequest2();
        private DevicePrintRequest2 prtReqField = new DevicePrintRequest2();
        private DevicePlaySoundRequest1 playSoundReqField = new DevicePlaySoundRequest1();
        private DeviceSecureInputRequest2 scrInptReqField = new DeviceSecureInputRequest2();
        private DeviceInitialisationCardReaderRequest2 initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest2();
        private DeviceSendApplicationProtocolDataUnitCardReaderRequest1 cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
        private DevicePoweroffCardReaderRequest2 pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest2();
        private DeviceTransmitMessageRequest2 trnsmssnReqField = new DeviceTransmitMessageRequest2();
        private DeviceInputNotification2 inptNtfctnField = new DeviceInputNotification2();
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
        public RetailerService8Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DispOutpt", IsNullable=false)]
        public ActionMessage7[] DispReq {
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
                    this.dispReqField = new ActionMessage7[0];
                }
                else {
                    this.dispReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInputRequest2 InptReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptReqField = new DeviceInputRequest2();
                }
                else {
                    this.inptReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DevicePrintRequest2 PrtReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.prtReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtReqField = new DevicePrintRequest2();
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.playSoundReqField.XSD_HasBeenSet == false))) {
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
        public DeviceSecureInputRequest2 ScrInptReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.scrInptReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.scrInptReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.scrInptReqField = new DeviceSecureInputRequest2();
                }
                else {
                    this.scrInptReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderRequest2 InitlstnCardRdrReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.initlstnCardRdrReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.initlstnCardRdrReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest2();
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.cardRdrAPDUReqField.XSD_HasBeenSet == false))) {
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
        public DevicePoweroffCardReaderRequest2 PwrOffCardRdrReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pwrOffCardRdrReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pwrOffCardRdrReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest2();
                }
                else {
                    this.pwrOffCardRdrReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceTransmitMessageRequest2 TrnsmssnReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.trnsmssnReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.trnsmssnReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.trnsmssnReqField = new DeviceTransmitMessageRequest2();
                }
                else {
                    this.trnsmssnReqField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DeviceInputNotification2 InptNtfctn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.inptNtfctnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.inptNtfctnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.inptNtfctnField = new DeviceInputNotification2();
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((((((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.InptReq != null)
                            && this.InptReq.XSD_HasBeenSet))
                            || ((this.PrtReq != null)
                            && this.PrtReq.XSD_HasBeenSet))
                            || ((this.PlaySoundReq != null)
                            && this.PlaySoundReq.XSD_HasBeenSet))
                            || ((this.ScrInptReq != null)
                            && this.ScrInptReq.XSD_HasBeenSet))
                            || ((this.InitlstnCardRdrReq != null)
                            && this.InitlstnCardRdrReq.XSD_HasBeenSet))
                            || ((this.CardRdrAPDUReq != null)
                            && this.CardRdrAPDUReq.XSD_HasBeenSet))
                            || ((this.PwrOffCardRdrReq != null)
                            && this.PwrOffCardRdrReq.XSD_HasBeenSet))
                            || ((this.TrnsmssnReq != null)
                            && this.TrnsmssnReq.XSD_HasBeenSet))
                            || ((this.InptNtfctn != null)
                            && this.InptNtfctn.XSD_HasBeenSet))
                            || (this.DispReqSize() != 0))
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
                if ((this.InptReq != null)) {
                    this.InptReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PrtReq != null)) {
                    this.PrtReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PlaySoundReq != null)) {
                    this.PlaySoundReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.ScrInptReq != null)) {
                    this.ScrInptReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.InitlstnCardRdrReq != null)) {
                    this.InitlstnCardRdrReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.CardRdrAPDUReq != null)) {
                    this.CardRdrAPDUReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PwrOffCardRdrReq != null)) {
                    this.PwrOffCardRdrReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.TrnsmssnReq != null)) {
                    this.TrnsmssnReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.InptNtfctn != null)) {
                    this.InptNtfctn.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.DispReqSize()); i = (i + 1)) {
                    this.DispReq[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.SplmtryDataSize()); i = (i + 1)) {
                    this.SplmtryData[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public ActionMessage7 DispReqGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage7[]))) {
                    return default(ActionMessage7);
                }
                else {
                    if (((this.dispReqField.Length - 1)
                                >= index)) {
                        return this.dispReqField[index];
                    }
                    else {
                        return default(ActionMessage7);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(ActionMessage7);
            }
            // END ADDED BY XSD
        }
        public bool DispReqSetItem(int index, ActionMessage7 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage7[]))) {
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
        public bool DispReqAddItem(ActionMessage7 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dispReqField == default(ActionMessage7[]))) {
                    return false;
                }
                else {
                    ActionMessage7[] array = new ActionMessage7[(this.dispReqField.Length + 1)];
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
                if ((this.dispReqField == default(ActionMessage7[]))) {
                    return false;
                }
                else {
                    if ((this.dispReqField.Length <= index)) {
                        return false;
                    }
                    else {
                        ActionMessage7[] array = new ActionMessage7[(this.dispReqField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService8Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3e3277ab-8e05-4f1d-bf9b-ec5940ad06e1")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputRequest2 : IDeviceSecureInputRequest2 {
        private PINRequestType1Code pINReqTpField = default(PINRequestType1Code);
        private string pINVrfctnMtdField = default(string);
        private double maxWtgTmField = default(double);
        private bool maxWtgTmFieldSpecified = false;
        private bool beepKeyFlgField = default(bool);
        private bool beepKeyFlgFieldSpecified = false;
        private OnLinePIN7 crdhldrPINField = new OnLinePIN7();
        private bool pINReqTpField_XSD_HasBeenSet = false;
        private bool pINVrfctnMtdField_XSD_HasBeenSet = false;
        private bool maxWtgTmField_XSD_HasBeenSet = false;
        private bool beepKeyFlgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public PINRequestType1Code PINReqTp {
            get {
                return this.pINReqTpField;
            }
        }
        /// <remarks/>
        public string PINVrfctnMtd {
            get {
                return this.pINVrfctnMtdField;
            }
            set {
                this.pINVrfctnMtdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pINVrfctnMtdField_XSD_HasBeenSet = (this.pINVrfctnMtdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.beepKeyFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - BeepKeyFlgSpecified = true
                this.BeepKeyFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool BeepKeyFlgSpecified {
            get {
                return this.beepKeyFlgFieldSpecified;
            }
            set {
                this.beepKeyFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public OnLinePIN7 CrdhldrPIN {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.crdhldrPINField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.crdhldrPINField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.crdhldrPINField = new OnLinePIN7();
                }
                else {
                    this.crdhldrPINField = value;
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
                            || ((this.CrdhldrPIN != null)
                            && this.CrdhldrPIN.XSD_HasBeenSet))
                            || this.pINReqTpField_XSD_HasBeenSet)
                            || this.pINVrfctnMtdField_XSD_HasBeenSet)
                            || this.maxWtgTmField_XSD_HasBeenSet)
                            || this.beepKeyFlgField_XSD_HasBeenSet)
                            || this.MaxWtgTmSpecified)
                            || this.BeepKeyFlgSpecified);
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
                if ((this.CrdhldrPIN != null)) {
                    this.CrdhldrPIN.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PINRequestType1Code {
        _begin,
        _none,
        /// <remarks/>
        PIAE,
        /// <remarks/>
        PIAV,
        /// <remarks/>
        PIVO,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ea452c5b-1c8c-4161-928d-386972428037")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSendApplicationProtocolDataUnitCardReaderRequest1 : IDeviceSendApplicationProtocolDataUnitCardReaderRequest1 {
        private byte[] clssField = new byte[0];
        private byte[] instrField = new byte[0];
        private byte[] param1Field = new byte[0];
        private byte[] param2Field = new byte[0];
        private byte[] dataField = new byte[0];
        private byte[] xpctdLngthField = new byte[0];
        private bool _XSD_Optimizing = false;
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.clssField = new byte[0];
                }
                else {
                    this.clssField = value;
                }
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.instrField = new byte[0];
                }
                else {
                    this.instrField = value;
                }
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.param1Field = new byte[0];
                }
                else {
                    this.param1Field = value;
                }
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.param2Field = new byte[0];
                }
                else {
                    this.param2Field = value;
                }
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dataField = new byte[0];
                }
                else {
                    this.dataField = value;
                }
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.xpctdLngthField = new byte[0];
                }
                else {
                    this.xpctdLngthField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((false
                            || (this.ClssSize() != 0))
                            || (this.InstrSize() != 0))
                            || (this.Param1Size() != 0))
                            || (this.Param2Size() != 0))
                            || (this.DataSize() != 0))
                            || (this.XpctdLngthSize() != 0));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ddcbb82b-7d9e-4578-9da9-623437ed3057")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageRequest2 : IDeviceTransmitMessageRequest2 {
        private NetworkParameters7 dstnAdrField = new NetworkParameters7();
        private double maxTrnsmssnTmField = default(double);
        private double maxWtgTmField = default(double);
        private bool maxWtgTmFieldSpecified = false;
        private byte[] msgToSndField = new byte[0];
        private bool maxTrnsmssnTmField_XSD_HasBeenSet = false;
        private bool maxWtgTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public NetworkParameters7 DstnAdr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dstnAdrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dstnAdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dstnAdrField = new NetworkParameters7();
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
                this.maxTrnsmssnTmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.maxTrnsmssnTmField_XSD_HasBeenSet = (this.maxTrnsmssnTmField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                this.maxWtgTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MaxWtgTmSpecified = true
                this.MaxWtgTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.msgToSndField = new byte[0];
                }
                else {
                    this.msgToSndField = value;
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
                            || ((this.DstnAdr != null)
                            && this.DstnAdr.XSD_HasBeenSet))
                            || (this.MsgToSndSize() != 0))
                            || this.maxTrnsmssnTmField_XSD_HasBeenSet)
                            || this.maxWtgTmField_XSD_HasBeenSet)
                            || this.MaxWtgTmSpecified);
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
                if ((this.DstnAdr != null)) {
                    this.DstnAdr.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a132b190-72ee-473b-87a1-532ac30af9ef")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceRequestV02 : ISaleToPOIDeviceRequestV02 {
        private Header41 hdrField = new Header41();
        private DeviceRequest3 dvcReqField = new DeviceRequest3();
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
        public DeviceRequest3 DvcReq {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dvcReqField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dvcReqField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dvcReqField = new DeviceRequest3();
                }
                else {
                    this.dvcReqField = value;
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
                            || ((this.DvcReq != null)
                            && this.DvcReq.XSD_HasBeenSet))
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
                if ((this.DvcReq != null)) {
                    this.DvcReq.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("09f99e37-662c-4a8a-80a2-10ee41177a4c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceDisplayRequest2 {
        /// <remarks/>
        [DispId(1)]
        ActionMessage7[] DispOutpt {
            get;
            set;
        }
        [DispId(2)]
        int DispOutptSize();
        [DispId(3)]
        ActionMessage7 DispOutptGetItem(int index);
        [DispId(4)]
        bool DispOutptSetItem(int index, ActionMessage7 value);
        [DispId(5)]
        bool DispOutptAddItem(ActionMessage7 value);
        [DispId(6)]
        bool DispOutptRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("e03f9058-dd49-4e01-a5f4-6480f7b2415f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInitialisationCardReaderRequest2 {
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
        CardDataReading8Code[] ForceNtryMd {
            get;
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
        ActionMessage7 DispOutpt {
            get;
            set;
        }
        [DispId(9)]
        int ForceNtryMdSize();
        [DispId(10)]
        CardDataReading8Code ForceNtryMdGetItem(int index);
        [DispId(11)]
        bool ForceNtryMdSetItem(int index, CardDataReading8Code value);
        [DispId(12)]
        bool ForceNtryMdAddItem(CardDataReading8Code value);
        [DispId(13)]
        bool ForceNtryMdRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("17222684-fd95-4f56-a12c-5cfd2c3585cd")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputNotification2 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ActionMessage7 OutptCntt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7801e671-a924-4325-8c54-d63773f57a1a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputRequest2 {
        /// <remarks/>
        [DispId(1)]
        ActionMessage7 DispOutpt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        InputData2 InptData {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8292ceeb-c8f2-4288-94c1-89fa8b7d538f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputData2 {
        /// <remarks/>
        [DispId(1)]
        SaleCapabilities2Code DvcTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        InformationQualify1Code InfQlfr {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        InputCommand1Code InptCmd {
            get;
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
        ActionMessage7 InptTxt {
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
    }
    [System.Runtime.InteropServices.GuidAttribute("8545aac1-3784-424f-974b-2dd8f0d8218e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePlaySoundRequest1 {
        /// <remarks/>
        [DispId(1)]
        ResponseMode1Code RspnMd {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("f6006189-a811-42fe-b933-82ee66eff1f4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISoundContent1 {
        /// <remarks/>
        [DispId(1)]
        SoundFormat1Code SoundFrmt {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("0152d0c8-ba5f-4be8-b7c6-3c73be2596ca")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePoweroffCardReaderRequest2 {
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
        ActionMessage7 DispOutpt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0630e950-8795-4164-b96e-1144c42722c1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePrintRequest2 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        ResponseMode1Code RspnMd {
            get;
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
        ActionMessage7 OutptCntt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6cc643ad-32d0-45a0-bc8d-15b6e3872f8f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceRequest3 {
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
        RetailerService8Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        ActionMessage7[] DispReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        DeviceInputRequest2 InptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        DevicePrintRequest2 PrtReq {
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
        DeviceSecureInputRequest2 ScrInptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceInitialisationCardReaderRequest2 InitlstnCardRdrReq {
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
        DevicePoweroffCardReaderRequest2 PwrOffCardRdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        DeviceTransmitMessageRequest2 TrnsmssnReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        DeviceInputNotification2 InptNtfctn {
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
        int DispReqSize();
        [DispId(16)]
        ActionMessage7 DispReqGetItem(int index);
        [DispId(17)]
        bool DispReqSetItem(int index, ActionMessage7 value);
        [DispId(18)]
        bool DispReqAddItem(ActionMessage7 value);
        [DispId(19)]
        bool DispReqRemoveItem(int index);
        [DispId(20)]
        int SplmtryDataSize();
        [DispId(21)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(22)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(23)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(24)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("57425ba9-2c2b-449b-a791-19b3e426e365")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSecureInputRequest2 {
        /// <remarks/>
        [DispId(1)]
        PINRequestType1Code PINReqTp {
            get;
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
        OnLinePIN7 CrdhldrPIN {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("13fea672-015e-4acc-92b2-1df98ddcad7f")]
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
        int ClssSize();
        [DispId(8)]
        byte ClssGetItem(int index);
        [DispId(9)]
        bool ClssSetItem(int index, byte value);
        [DispId(10)]
        bool ClssAddItem(byte value);
        [DispId(11)]
        bool ClssRemoveItem(int index);
        [DispId(12)]
        int InstrSize();
        [DispId(13)]
        byte InstrGetItem(int index);
        [DispId(14)]
        bool InstrSetItem(int index, byte value);
        [DispId(15)]
        bool InstrAddItem(byte value);
        [DispId(16)]
        bool InstrRemoveItem(int index);
        [DispId(17)]
        int Param1Size();
        [DispId(18)]
        byte Param1GetItem(int index);
        [DispId(19)]
        bool Param1SetItem(int index, byte value);
        [DispId(20)]
        bool Param1AddItem(byte value);
        [DispId(21)]
        bool Param1RemoveItem(int index);
        [DispId(22)]
        int Param2Size();
        [DispId(23)]
        byte Param2GetItem(int index);
        [DispId(24)]
        bool Param2SetItem(int index, byte value);
        [DispId(25)]
        bool Param2AddItem(byte value);
        [DispId(26)]
        bool Param2RemoveItem(int index);
        [DispId(27)]
        int DataSize();
        [DispId(28)]
        byte DataGetItem(int index);
        [DispId(29)]
        bool DataSetItem(int index, byte value);
        [DispId(30)]
        bool DataAddItem(byte value);
        [DispId(31)]
        bool DataRemoveItem(int index);
        [DispId(32)]
        int XpctdLngthSize();
        [DispId(33)]
        byte XpctdLngthGetItem(int index);
        [DispId(34)]
        bool XpctdLngthSetItem(int index, byte value);
        [DispId(35)]
        bool XpctdLngthAddItem(byte value);
        [DispId(36)]
        bool XpctdLngthRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("94523458-aa07-47dc-8212-99bc236e1708")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceTransmitMessageRequest2 {
        /// <remarks/>
        [DispId(1)]
        NetworkParameters7 DstnAdr {
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
        int MsgToSndSize();
        [DispId(7)]
        byte MsgToSndGetItem(int index);
        [DispId(8)]
        bool MsgToSndSetItem(int index, byte value);
        [DispId(9)]
        bool MsgToSndAddItem(byte value);
        [DispId(10)]
        bool MsgToSndRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("c21763f6-231f-48ae-a96e-c6a64c42463e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIDeviceRequestV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        DeviceRequest3 DvcReq {
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
}
#endif
