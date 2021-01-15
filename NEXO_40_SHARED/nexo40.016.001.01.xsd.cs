namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ee12b027-4ffa-44d8-9325-ea24de91ad84")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayRequest1 : IDeviceDisplayRequest1 {
        internal ActionMessage6[] dispOutptField = new ActionMessage6[0];
        internal bool xsdDeviceDisplayRequest1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispOutpt")]
        public ActionMessage6[] DispOutpt {
            get {
                if (((this.dispOutptField == null)
                            || (this.dispOutptField.Length == 0))) {
                    return null;
                }
                return this.dispOutptField;
            }
            set {
                this.xsdDeviceDisplayRequest1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceDisplayRequest1InitFlag {
            get {
                return this.xsdDeviceDisplayRequest1InitFlagField;
            }
            set {
                this.xsdDeviceDisplayRequest1InitFlagField = value;
            }
        }
        public int DispOutptSize() {
            if ((this.dispOutptField == null)) {
                return 0;
            }
            else {
                return this.dispOutptField.Length;
            }
        }
        public ActionMessage6 DispOutptGetItem(int index) {
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
        }
        public bool DispOutptSetItem(int index, ActionMessage6 value) {
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
        }
        public bool DispOutptAddItem(ActionMessage6 value) {
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
        }
        public bool DispOutptRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4c71fa0b-ea1b-4b03-92ae-e35aaaa8abba")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceDisplayRequest1 {
        /// <remarks/>
        [DispId(1)]
        ActionMessage6[] DispOutpt {
            get;
            set;
        }
        [DispId(3)]
        bool xsdDeviceDisplayRequest1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int DispOutptSize();
        [DispId(5)]
        ActionMessage6 DispOutptGetItem(int index);
        [DispId(6)]
        bool DispOutptSetItem(int index, ActionMessage6 value);
        [DispId(7)]
        bool DispOutptAddItem(ActionMessage6 value);
        [DispId(8)]
        bool DispOutptRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("797cfa1b-302f-4466-a8dd-d7e5b95a4789")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderRequest1 : IDeviceInitialisationCardReaderRequest1 {
        internal bool warmRstFlgField;
        internal bool warmRstFlgFieldSpecified;
        internal CardDataReading6Code[] forceNtryMdField = new CardDataReading6Code[0];
        internal bool leavCardFlgField;
        internal bool leavCardFlgFieldSpecified;
        internal double maxWtgTmField;
        internal bool maxWtgTmFieldSpecified;
        internal ActionMessage6 dispOutptField = new ActionMessage6();
        internal bool xsdDeviceInitialisationCardReaderRequest1InitFlagField = false;
        /// <remarks/>
        public bool WarmRstFlg {
            get {
                return this.warmRstFlgField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.warmRstFlgField = value;
                this.WarmRstFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarmRstFlgSpecified {
            get {
                return this.warmRstFlgFieldSpecified;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.warmRstFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceNtryMd")]
        public CardDataReading6Code[] ForceNtryMd {
            get {
                if (((this.forceNtryMdField == null)
                            || (this.forceNtryMdField.Length == 0))) {
                    return null;
                }
                return this.forceNtryMdField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.forceNtryMdField = value;
            }
        }
        /// <remarks/>
        public bool LeavCardFlg {
            get {
                return this.leavCardFlgField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.leavCardFlgField = value;
                this.LeavCardFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeavCardFlgSpecified {
            get {
                return this.leavCardFlgFieldSpecified;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.leavCardFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.maxWtgTmField = value;
                this.MaxWtgTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                return this.dispOutptField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceInitialisationCardReaderRequest1InitFlag {
            get {
                return this.xsdDeviceInitialisationCardReaderRequest1InitFlagField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderRequest1InitFlagField = value;
            }
        }
        public int ForceNtryMdSize() {
            if ((this.forceNtryMdField == null)) {
                return 0;
            }
            else {
                return this.forceNtryMdField.Length;
            }
        }
        public CardDataReading6Code ForceNtryMdGetItem(int index) {
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
        }
        public bool ForceNtryMdSetItem(int index, CardDataReading6Code value) {
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
        }
        public bool ForceNtryMdAddItem(CardDataReading6Code value) {
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
        }
        public bool ForceNtryMdRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a864965d-8a3b-420b-8d2f-733c51fd7055")]
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
        [DispId(3)]
        bool WarmRstFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CardDataReading6Code[] ForceNtryMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool LeavCardFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool LeavCardFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        double MaxWtgTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        bool MaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(17)]
        bool xsdDeviceInitialisationCardReaderRequest1InitFlag {
            get;
            set;
        }
        [DispId(18)]
        int ForceNtryMdSize();
        [DispId(19)]
        CardDataReading6Code ForceNtryMdGetItem(int index);
        [DispId(20)]
        bool ForceNtryMdSetItem(int index, CardDataReading6Code value);
        [DispId(21)]
        bool ForceNtryMdAddItem(CardDataReading6Code value);
        [DispId(22)]
        bool ForceNtryMdRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8e17fef5-46e8-40e8-8581-a70089f8e181")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputNotification1 : IDeviceInputNotification1 {
        internal string xchgIdField;
        internal ActionMessage6 outptCnttField = new ActionMessage6();
        internal bool xsdDeviceInputNotification1InitFlagField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xsdDeviceInputNotification1InitFlagField = true;
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 OutptCntt {
            get {
                return this.outptCnttField;
            }
            set {
                this.xsdDeviceInputNotification1InitFlagField = true;
                this.outptCnttField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceInputNotification1InitFlag {
            get {
                return this.xsdDeviceInputNotification1InitFlagField;
            }
            set {
                this.xsdDeviceInputNotification1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("e229de46-97bd-4a1e-a6aa-39cadbe9e98a")]
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
        [DispId(3)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(5)]
        bool xsdDeviceInputNotification1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ec1b16b3-35bc-4333-a943-b8041fefdefb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputRequest1 : IDeviceInputRequest1 {
        internal ActionMessage6 dispOutptField = new ActionMessage6();
        internal InputData1 inptDataField = new InputData1();
        internal bool xsdDeviceInputRequest1InitFlagField = false;
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                return this.dispOutptField;
            }
            set {
                this.xsdDeviceInputRequest1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        /// <remarks/>
        public InputData1 InptData {
            get {
                return this.inptDataField;
            }
            set {
                this.xsdDeviceInputRequest1InitFlagField = true;
                this.inptDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceInputRequest1InitFlag {
            get {
                return this.xsdDeviceInputRequest1InitFlagField;
            }
            set {
                this.xsdDeviceInputRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("42063481-cb40-43df-a6c1-e077f7417f8a")]
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
        [DispId(3)]
        InputData1 InptData {
            get;
            set;
        }
        [DispId(5)]
        bool xsdDeviceInputRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("20a99d01-1af2-480b-9ea5-d9f111a7d0da")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputData1 : IInputData1 {
        internal SaleCapabilities2Code dvcTpField = new SaleCapabilities2Code();
        internal InformationQualify1Code infQlfrField = new InformationQualify1Code();
        internal InputCommand1Code inptCmdField = new InputCommand1Code();
        internal bool ntfyCardInptFlgField;
        internal double maxInptTmField;
        internal bool maxInptTmFieldSpecified;
        internal ActionMessage6 inptTxtField = new ActionMessage6();
        internal bool imdtRspnFlgField;
        internal bool imdtRspnFlgFieldSpecified;
        internal bool waitUsrVldtnFlgField;
        internal bool waitUsrVldtnFlgFieldSpecified;
        internal bool beepKeyFlgField;
        internal bool beepKeyFlgFieldSpecified;
        internal bool gblCrrctnFlgField;
        internal bool gblCrrctnFlgFieldSpecified;
        internal bool dsblCclFlgField;
        internal bool dsblCclFlgFieldSpecified;
        internal bool dsblCrrctFlgField;
        internal bool dsblCrrctFlgFieldSpecified;
        internal bool dsblVldFlgField;
        internal bool dsblVldFlgFieldSpecified;
        internal bool menuBckFlgField;
        internal bool menuBckFlgFieldSpecified;
        internal bool xsdInputData1InitFlagField = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.inptCmdField = value;
            }
        }
        /// <remarks/>
        public bool NtfyCardInptFlg {
            get {
                return this.ntfyCardInptFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.ntfyCardInptFlgField = value;
            }
        }
        /// <remarks/>
        public double MaxInptTm {
            get {
                return this.maxInptTmField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.maxInptTmField = value;
                this.MaxInptTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxInptTmSpecified {
            get {
                return this.maxInptTmFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.maxInptTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 InptTxt {
            get {
                return this.inptTxtField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.inptTxtField = value;
            }
        }
        /// <remarks/>
        public bool ImdtRspnFlg {
            get {
                return this.imdtRspnFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.imdtRspnFlgField = value;
                this.ImdtRspnFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImdtRspnFlgSpecified {
            get {
                return this.imdtRspnFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.imdtRspnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool WaitUsrVldtnFlg {
            get {
                return this.waitUsrVldtnFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.waitUsrVldtnFlgField = value;
                this.WaitUsrVldtnFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WaitUsrVldtnFlgSpecified {
            get {
                return this.waitUsrVldtnFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.waitUsrVldtnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool BeepKeyFlg {
            get {
                return this.beepKeyFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.beepKeyFlgField = value;
                this.BeepKeyFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeepKeyFlgSpecified {
            get {
                return this.beepKeyFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.beepKeyFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool GblCrrctnFlg {
            get {
                return this.gblCrrctnFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.gblCrrctnFlgField = value;
                this.GblCrrctnFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GblCrrctnFlgSpecified {
            get {
                return this.gblCrrctnFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.gblCrrctnFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblCclFlg {
            get {
                return this.dsblCclFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblCclFlgField = value;
                this.DsblCclFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblCclFlgSpecified {
            get {
                return this.dsblCclFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblCclFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblCrrctFlg {
            get {
                return this.dsblCrrctFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblCrrctFlgField = value;
                this.DsblCrrctFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblCrrctFlgSpecified {
            get {
                return this.dsblCrrctFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblCrrctFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool DsblVldFlg {
            get {
                return this.dsblVldFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblVldFlgField = value;
                this.DsblVldFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DsblVldFlgSpecified {
            get {
                return this.dsblVldFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.dsblVldFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool MenuBckFlg {
            get {
                return this.menuBckFlgField;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.menuBckFlgField = value;
                this.MenuBckFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MenuBckFlgSpecified {
            get {
                return this.menuBckFlgFieldSpecified;
            }
            set {
                this.xsdInputData1InitFlagField = true;
                this.menuBckFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdInputData1InitFlag {
            get {
                return this.xsdInputData1InitFlagField;
            }
            set {
                this.xsdInputData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("d53aed98-cccc-4859-924f-3c7a7eb71c4f")]
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
        [DispId(3)]
        InformationQualify1Code InfQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        InputCommand1Code InptCmd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool NtfyCardInptFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        double MaxInptTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool MaxInptTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        ActionMessage6 InptTxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool ImdtRspnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        bool ImdtRspnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        bool WaitUsrVldtnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        bool WaitUsrVldtnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        bool BeepKeyFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(25)]
        bool BeepKeyFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(27)]
        bool GblCrrctnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(29)]
        bool GblCrrctnFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(31)]
        bool DsblCclFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(33)]
        bool DsblCclFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(35)]
        bool DsblCrrctFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(37)]
        bool DsblCrrctFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(39)]
        bool DsblVldFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(41)]
        bool DsblVldFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(43)]
        bool MenuBckFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(45)]
        bool MenuBckFlgSpecified {
            get;
            set;
        }
        [DispId(47)]
        bool xsdInputData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("5bded494-701b-4ea6-86dd-6e645327503a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePlaySoundRequest1 : IDevicePlaySoundRequest1 {
        internal ResponseMode1Code rspnMdField = new ResponseMode1Code();
        internal bool rspnMdFieldSpecified;
        internal SoundAction1Code soundActnField = new SoundAction1Code();
        internal double soundVolField;
        internal bool soundVolFieldSpecified;
        internal SoundContent1 soundCnttField = new SoundContent1();
        internal bool xsdDevicePlaySoundRequest1InitFlagField = false;
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.rspnMdField = value;
                this.RspnMdSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RspnMdSpecified {
            get {
                return this.rspnMdFieldSpecified;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.rspnMdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public SoundAction1Code SoundActn {
            get {
                return this.soundActnField;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.soundActnField = value;
            }
        }
        /// <remarks/>
        public double SoundVol {
            get {
                return this.soundVolField;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.soundVolField = value;
                this.SoundVolSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundVolSpecified {
            get {
                return this.soundVolFieldSpecified;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.soundVolFieldSpecified = value;
            }
        }
        /// <remarks/>
        public SoundContent1 SoundCntt {
            get {
                return this.soundCnttField;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = true;
                this.soundCnttField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDevicePlaySoundRequest1InitFlag {
            get {
                return this.xsdDevicePlaySoundRequest1InitFlagField;
            }
            set {
                this.xsdDevicePlaySoundRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("aba459e6-9b0d-4d30-91c1-5ec1a2f494c7")]
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
        [DispId(3)]
        bool RspnMdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        SoundAction1Code SoundActn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        double SoundVol {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool SoundVolSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        SoundContent1 SoundCntt {
            get;
            set;
        }
        [DispId(13)]
        bool xsdDevicePlaySoundRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1219d215-763c-40e4-b045-74c9136b8225")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoundContent1 : ISoundContent1 {
        internal SoundFormat1Code soundFrmtField = new SoundFormat1Code();
        internal string langField;
        internal string soundRefField;
        internal string txtField;
        internal bool xsdSoundContent1InitFlagField = false;
        /// <remarks/>
        public SoundFormat1Code SoundFrmt {
            get {
                return this.soundFrmtField;
            }
            set {
                this.xsdSoundContent1InitFlagField = true;
                this.soundFrmtField = value;
            }
        }
        /// <remarks/>
        public string Lang {
            get {
                return this.langField;
            }
            set {
                this.xsdSoundContent1InitFlagField = true;
                this.langField = value;
            }
        }
        /// <remarks/>
        public string SoundRef {
            get {
                return this.soundRefField;
            }
            set {
                this.xsdSoundContent1InitFlagField = true;
                this.soundRefField = value;
            }
        }
        /// <remarks/>
        public string Txt {
            get {
                return this.txtField;
            }
            set {
                this.xsdSoundContent1InitFlagField = true;
                this.txtField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSoundContent1InitFlag {
            get {
                return this.xsdSoundContent1InitFlagField;
            }
            set {
                this.xsdSoundContent1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("61e9ed5a-c6b8-4d98-9b46-03adef11daa2")]
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
        [DispId(3)]
        string Lang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string SoundRef {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string Txt {
            get;
            set;
        }
        [DispId(9)]
        bool xsdSoundContent1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b2d0cd97-401e-47f8-8fdb-68b5482a1d34")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePoweroffCardReaderRequest1 : IDevicePoweroffCardReaderRequest1 {
        internal double pwrOffMaxWtgTmField;
        internal bool pwrOffMaxWtgTmFieldSpecified;
        internal ActionMessage6 dispOutptField = new ActionMessage6();
        internal bool xsdDevicePoweroffCardReaderRequest1InitFlagField = false;
        /// <remarks/>
        public double PwrOffMaxWtgTm {
            get {
                return this.pwrOffMaxWtgTmField;
            }
            set {
                this.xsdDevicePoweroffCardReaderRequest1InitFlagField = true;
                this.pwrOffMaxWtgTmField = value;
                this.PwrOffMaxWtgTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PwrOffMaxWtgTmSpecified {
            get {
                return this.pwrOffMaxWtgTmFieldSpecified;
            }
            set {
                this.xsdDevicePoweroffCardReaderRequest1InitFlagField = true;
                this.pwrOffMaxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                return this.dispOutptField;
            }
            set {
                this.xsdDevicePoweroffCardReaderRequest1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDevicePoweroffCardReaderRequest1InitFlag {
            get {
                return this.xsdDevicePoweroffCardReaderRequest1InitFlagField;
            }
            set {
                this.xsdDevicePoweroffCardReaderRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("c9b46939-d81d-4d15-8edb-65655577e8d0")]
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
        [DispId(3)]
        bool PwrOffMaxWtgTmSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ActionMessage6 DispOutpt {
            get;
            set;
        }
        [DispId(7)]
        bool xsdDevicePoweroffCardReaderRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("db402817-134b-44cd-a2d9-9f76fcd5f1b6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintRequest1 : IDevicePrintRequest1 {
        internal DocumentType7Code docQlfrField = new DocumentType7Code();
        internal ResponseMode1Code rspnMdField = new ResponseMode1Code();
        internal bool intgrtdPrtFlgField;
        internal bool intgrtdPrtFlgFieldSpecified;
        internal bool reqrdSgntrFlgField;
        internal bool reqrdSgntrFlgFieldSpecified;
        internal ActionMessage6 outptCnttField = new ActionMessage6();
        internal bool xsdDevicePrintRequest1InitFlagField = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.docQlfrField = value;
            }
        }
        /// <remarks/>
        public ResponseMode1Code RspnMd {
            get {
                return this.rspnMdField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.rspnMdField = value;
            }
        }
        /// <remarks/>
        public bool IntgrtdPrtFlg {
            get {
                return this.intgrtdPrtFlgField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.intgrtdPrtFlgField = value;
                this.IntgrtdPrtFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntgrtdPrtFlgSpecified {
            get {
                return this.intgrtdPrtFlgFieldSpecified;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.intgrtdPrtFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool ReqrdSgntrFlg {
            get {
                return this.reqrdSgntrFlgField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.reqrdSgntrFlgField = value;
                this.ReqrdSgntrFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReqrdSgntrFlgSpecified {
            get {
                return this.reqrdSgntrFlgFieldSpecified;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.reqrdSgntrFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 OutptCntt {
            get {
                return this.outptCnttField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = true;
                this.outptCnttField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDevicePrintRequest1InitFlag {
            get {
                return this.xsdDevicePrintRequest1InitFlagField;
            }
            set {
                this.xsdDevicePrintRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8e67b757-d2f4-47ae-bbb1-6a0bc7d4c1c0")]
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
        [DispId(3)]
        ResponseMode1Code RspnMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool IntgrtdPrtFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool IntgrtdPrtFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool ReqrdSgntrFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool ReqrdSgntrFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(15)]
        bool xsdDevicePrintRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ae4863f4-32eb-4a3b-92bd-78885e7c486e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceRequest2 : IDeviceRequest2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService8Code svcCnttField = new RetailerService8Code();
        internal ActionMessage6[] dispReqField = new ActionMessage6[0];
        internal DeviceInputRequest1 inptReqField = new DeviceInputRequest1();
        internal DevicePrintRequest1 prtReqField = new DevicePrintRequest1();
        internal DevicePlaySoundRequest1 playSoundReqField = new DevicePlaySoundRequest1();
        internal DeviceSecureInputRequest1 scrInptReqField = new DeviceSecureInputRequest1();
        internal DeviceInitialisationCardReaderRequest1 initlstnCardRdrReqField = new DeviceInitialisationCardReaderRequest1();
        internal DeviceSendApplicationProtocolDataUnitCardReaderRequest1 cardRdrAPDUReqField = new DeviceSendApplicationProtocolDataUnitCardReaderRequest1();
        internal DevicePoweroffCardReaderRequest1 pwrOffCardRdrReqField = new DevicePoweroffCardReaderRequest1();
        internal DeviceTransmitMessageRequest1 trnsmssnReqField = new DeviceTransmitMessageRequest1();
        internal DeviceInputNotification1 inptNtfctnField = new DeviceInputNotification1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdDeviceRequest2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService8Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DispOutpt", IsNullable=false)]
        public ActionMessage6[] DispReq {
            get {
                if (((this.dispReqField == null)
                            || (this.dispReqField.Length == 0))) {
                    return null;
                }
                return this.dispReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.dispReqField = value;
            }
        }
        /// <remarks/>
        public DeviceInputRequest1 InptReq {
            get {
                return this.inptReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.inptReqField = value;
            }
        }
        /// <remarks/>
        public DevicePrintRequest1 PrtReq {
            get {
                return this.prtReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.prtReqField = value;
            }
        }
        /// <remarks/>
        public DevicePlaySoundRequest1 PlaySoundReq {
            get {
                return this.playSoundReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.playSoundReqField = value;
            }
        }
        /// <remarks/>
        public DeviceSecureInputRequest1 ScrInptReq {
            get {
                return this.scrInptReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.scrInptReqField = value;
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq {
            get {
                return this.initlstnCardRdrReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.initlstnCardRdrReqField = value;
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq {
            get {
                return this.cardRdrAPDUReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.cardRdrAPDUReqField = value;
            }
        }
        /// <remarks/>
        public DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq {
            get {
                return this.pwrOffCardRdrReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.pwrOffCardRdrReqField = value;
            }
        }
        /// <remarks/>
        public DeviceTransmitMessageRequest1 TrnsmssnReq {
            get {
                return this.trnsmssnReqField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.trnsmssnReqField = value;
            }
        }
        /// <remarks/>
        public DeviceInputNotification1 InptNtfctn {
            get {
                return this.inptNtfctnField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = true;
                this.inptNtfctnField = value;
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
                this.xsdDeviceRequest2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceRequest2InitFlag {
            get {
                return this.xsdDeviceRequest2InitFlagField;
            }
            set {
                this.xsdDeviceRequest2InitFlagField = value;
            }
        }
        public int DispReqSize() {
            if ((this.dispReqField == null)) {
                return 0;
            }
            else {
                return this.dispReqField.Length;
            }
        }
        public ActionMessage6 DispReqGetItem(int index) {
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
        }
        public bool DispReqSetItem(int index, ActionMessage6 value) {
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
        }
        public bool DispReqAddItem(ActionMessage6 value) {
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
        }
        public bool DispReqRemoveItem(int index) {
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
    [System.Runtime.InteropServices.GuidAttribute("fda5decd-ddaa-4e17-b72c-1633342f9e68")]
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
        [DispId(3)]
        CardPaymentContext27 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        RetailerService8Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ActionMessage6[] DispReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceInputRequest1 InptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        DevicePrintRequest1 PrtReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        DevicePlaySoundRequest1 PlaySoundReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        DeviceSecureInputRequest1 ScrInptReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        DeviceInitialisationCardReaderRequest1 InitlstnCardRdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        DeviceSendApplicationProtocolDataUnitCardReaderRequest1 CardRdrAPDUReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        DevicePoweroffCardReaderRequest1 PwrOffCardRdrReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        DeviceTransmitMessageRequest1 TrnsmssnReq {
            get;
            set;
        }
        /// <remarks/>
        [DispId(25)]
        DeviceInputNotification1 InptNtfctn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(27)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(29)]
        bool xsdDeviceRequest2InitFlag {
            get;
            set;
        }
        [DispId(30)]
        int DispReqSize();
        [DispId(31)]
        ActionMessage6 DispReqGetItem(int index);
        [DispId(32)]
        bool DispReqSetItem(int index, ActionMessage6 value);
        [DispId(33)]
        bool DispReqAddItem(ActionMessage6 value);
        [DispId(34)]
        bool DispReqRemoveItem(int index);
        [DispId(35)]
        int SplmtryDataSize();
        [DispId(36)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(37)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(38)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(39)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8b182bf5-9d81-41e9-bcc5-98477a133b84")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputRequest1 : IDeviceSecureInputRequest1 {
        internal PINRequestType1Code pINReqTpField = new PINRequestType1Code();
        internal string pINVrfctnMtdField;
        internal double maxWtgTmField;
        internal bool maxWtgTmFieldSpecified;
        internal bool beepKeyFlgField;
        internal bool beepKeyFlgFieldSpecified;
        internal OnLinePIN6 crdhldrPINField = new OnLinePIN6();
        internal bool xsdDeviceSecureInputRequest1InitFlagField = false;
        /// <remarks/>
        public PINRequestType1Code PINReqTp {
            get {
                return this.pINReqTpField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.pINReqTpField = value;
            }
        }
        /// <remarks/>
        public string PINVrfctnMtd {
            get {
                return this.pINVrfctnMtdField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.pINVrfctnMtdField = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.maxWtgTmField = value;
                this.MaxWtgTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool BeepKeyFlg {
            get {
                return this.beepKeyFlgField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.beepKeyFlgField = value;
                this.BeepKeyFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeepKeyFlgSpecified {
            get {
                return this.beepKeyFlgFieldSpecified;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.beepKeyFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public OnLinePIN6 CrdhldrPIN {
            get {
                return this.crdhldrPINField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = true;
                this.crdhldrPINField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceSecureInputRequest1InitFlag {
            get {
                return this.xsdDeviceSecureInputRequest1InitFlagField;
            }
            set {
                this.xsdDeviceSecureInputRequest1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("78f95199-c689-438d-9a41-a0d94a5ca31d")]
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
        [DispId(3)]
        string PINVrfctnMtd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
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
        [DispId(9)]
        bool BeepKeyFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool BeepKeyFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        OnLinePIN6 CrdhldrPIN {
            get;
            set;
        }
        [DispId(15)]
        bool xsdDeviceSecureInputRequest1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("22607d28-dc14-4e04-93bf-44e67ff40940")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSendApplicationProtocolDataUnitCardReaderRequest1 : IDeviceSendApplicationProtocolDataUnitCardReaderRequest1 {
        internal byte[] clssField = new byte[0];
        internal byte[] instrField = new byte[0];
        internal byte[] param1Field = new byte[0];
        internal byte[] param2Field = new byte[0];
        internal byte[] dataField = new byte[0];
        internal byte[] xpctdLngthField = new byte[0];
        internal bool xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Clss {
            get {
                if (((this.clssField == null)
                            || (this.clssField.Length == 0))) {
                    return null;
                }
                return this.clssField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.clssField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Instr {
            get {
                if (((this.instrField == null)
                            || (this.instrField.Length == 0))) {
                    return null;
                }
                return this.instrField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.instrField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Param1 {
            get {
                if (((this.param1Field == null)
                            || (this.param1Field.Length == 0))) {
                    return null;
                }
                return this.param1Field;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.param1Field = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Param2 {
            get {
                if (((this.param2Field == null)
                            || (this.param2Field.Length == 0))) {
                    return null;
                }
                return this.param2Field;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.param2Field = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Data {
            get {
                if (((this.dataField == null)
                            || (this.dataField.Length == 0))) {
                    return null;
                }
                return this.dataField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.dataField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] XpctdLngth {
            get {
                if (((this.xpctdLngthField == null)
                            || (this.xpctdLngthField.Length == 0))) {
                    return null;
                }
                return this.xpctdLngthField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = true;
                this.xpctdLngthField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlag {
            get {
                return this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlagField = value;
            }
        }
        public int ClssSize() {
            if ((this.clssField == null)) {
                return 0;
            }
            else {
                return this.clssField.Length;
            }
        }
        public byte ClssGetItem(int index) {
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
        }
        public bool ClssSetItem(int index, byte value) {
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
        }
        public bool ClssAddItem(byte value) {
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
        }
        public bool ClssRemoveItem(int index) {
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
        }
        public int InstrSize() {
            if ((this.instrField == null)) {
                return 0;
            }
            else {
                return this.instrField.Length;
            }
        }
        public byte InstrGetItem(int index) {
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
        }
        public bool InstrSetItem(int index, byte value) {
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
        }
        public bool InstrAddItem(byte value) {
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
        }
        public bool InstrRemoveItem(int index) {
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
        }
        public int Param1Size() {
            if ((this.param1Field == null)) {
                return 0;
            }
            else {
                return this.param1Field.Length;
            }
        }
        public byte Param1GetItem(int index) {
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
        }
        public bool Param1SetItem(int index, byte value) {
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
        }
        public bool Param1AddItem(byte value) {
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
        }
        public bool Param1RemoveItem(int index) {
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
        }
        public int Param2Size() {
            if ((this.param2Field == null)) {
                return 0;
            }
            else {
                return this.param2Field.Length;
            }
        }
        public byte Param2GetItem(int index) {
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
        }
        public bool Param2SetItem(int index, byte value) {
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
        }
        public bool Param2AddItem(byte value) {
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
        }
        public bool Param2RemoveItem(int index) {
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
        }
        public int DataSize() {
            if ((this.dataField == null)) {
                return 0;
            }
            else {
                return this.dataField.Length;
            }
        }
        public byte DataGetItem(int index) {
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
        }
        public bool DataSetItem(int index, byte value) {
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
        }
        public bool DataAddItem(byte value) {
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
        }
        public bool DataRemoveItem(int index) {
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
        }
        public int XpctdLngthSize() {
            if ((this.xpctdLngthField == null)) {
                return 0;
            }
            else {
                return this.xpctdLngthField.Length;
            }
        }
        public byte XpctdLngthGetItem(int index) {
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
        }
        public bool XpctdLngthSetItem(int index, byte value) {
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
        }
        public bool XpctdLngthAddItem(byte value) {
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
        }
        public bool XpctdLngthRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("9695da15-acbc-4f6b-835b-7f9414511a6d")]
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
        [DispId(3)]
        byte[] Instr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] Param1 {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        byte[] Param2 {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        byte[] Data {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        byte[] XpctdLngth {
            get;
            set;
        }
        [DispId(13)]
        bool xsdDeviceSendApplicationProtocolDataUnitCardReaderRequest1InitFlag {
            get;
            set;
        }
        [DispId(14)]
        int ClssSize();
        [DispId(15)]
        byte ClssGetItem(int index);
        [DispId(16)]
        bool ClssSetItem(int index, byte value);
        [DispId(17)]
        bool ClssAddItem(byte value);
        [DispId(18)]
        bool ClssRemoveItem(int index);
        [DispId(19)]
        int InstrSize();
        [DispId(20)]
        byte InstrGetItem(int index);
        [DispId(21)]
        bool InstrSetItem(int index, byte value);
        [DispId(22)]
        bool InstrAddItem(byte value);
        [DispId(23)]
        bool InstrRemoveItem(int index);
        [DispId(24)]
        int Param1Size();
        [DispId(25)]
        byte Param1GetItem(int index);
        [DispId(26)]
        bool Param1SetItem(int index, byte value);
        [DispId(27)]
        bool Param1AddItem(byte value);
        [DispId(28)]
        bool Param1RemoveItem(int index);
        [DispId(29)]
        int Param2Size();
        [DispId(30)]
        byte Param2GetItem(int index);
        [DispId(31)]
        bool Param2SetItem(int index, byte value);
        [DispId(32)]
        bool Param2AddItem(byte value);
        [DispId(33)]
        bool Param2RemoveItem(int index);
        [DispId(34)]
        int DataSize();
        [DispId(35)]
        byte DataGetItem(int index);
        [DispId(36)]
        bool DataSetItem(int index, byte value);
        [DispId(37)]
        bool DataAddItem(byte value);
        [DispId(38)]
        bool DataRemoveItem(int index);
        [DispId(39)]
        int XpctdLngthSize();
        [DispId(40)]
        byte XpctdLngthGetItem(int index);
        [DispId(41)]
        bool XpctdLngthSetItem(int index, byte value);
        [DispId(42)]
        bool XpctdLngthAddItem(byte value);
        [DispId(43)]
        bool XpctdLngthRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("83bcc071-81a7-4450-8b50-79f9a83e1553")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageRequest1 : IDeviceTransmitMessageRequest1 {
        internal NetworkParameters5 dstnAdrField = new NetworkParameters5();
        internal double maxTrnsmssnTmField;
        internal double maxWtgTmField;
        internal bool maxWtgTmFieldSpecified;
        internal byte[] msgToSndField = new byte[0];
        internal bool xsdDeviceTransmitMessageRequest1InitFlagField = false;
        /// <remarks/>
        public NetworkParameters5 DstnAdr {
            get {
                return this.dstnAdrField;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = true;
                this.dstnAdrField = value;
            }
        }
        /// <remarks/>
        public double MaxTrnsmssnTm {
            get {
                return this.maxTrnsmssnTmField;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = true;
                this.maxTrnsmssnTmField = value;
            }
        }
        /// <remarks/>
        public double MaxWtgTm {
            get {
                return this.maxWtgTmField;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = true;
                this.maxWtgTmField = value;
                this.MaxWtgTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxWtgTmSpecified {
            get {
                return this.maxWtgTmFieldSpecified;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = true;
                this.maxWtgTmFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgToSnd {
            get {
                if (((this.msgToSndField == null)
                            || (this.msgToSndField.Length == 0))) {
                    return null;
                }
                return this.msgToSndField;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = true;
                this.msgToSndField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceTransmitMessageRequest1InitFlag {
            get {
                return this.xsdDeviceTransmitMessageRequest1InitFlagField;
            }
            set {
                this.xsdDeviceTransmitMessageRequest1InitFlagField = value;
            }
        }
        public int MsgToSndSize() {
            if ((this.msgToSndField == null)) {
                return 0;
            }
            else {
                return this.msgToSndField.Length;
            }
        }
        public byte MsgToSndGetItem(int index) {
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
        }
        public bool MsgToSndSetItem(int index, byte value) {
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
        }
        public bool MsgToSndAddItem(byte value) {
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
        }
        public bool MsgToSndRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("75317585-c4eb-465e-88ce-b89fa1657065")]
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
        [DispId(3)]
        double MaxTrnsmssnTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
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
        [DispId(9)]
        byte[] MsgToSnd {
            get;
            set;
        }
        [DispId(11)]
        bool xsdDeviceTransmitMessageRequest1InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int MsgToSndSize();
        [DispId(13)]
        byte MsgToSndGetItem(int index);
        [DispId(14)]
        bool MsgToSndSetItem(int index, byte value);
        [DispId(15)]
        bool MsgToSndAddItem(byte value);
        [DispId(16)]
        bool MsgToSndRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.016.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("252d9d31-9b7f-4b98-a73f-82569598ea0a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceRequestV01 : ISaleToPOIDeviceRequestV01 {
        internal Header37 hdrField = new Header37();
        internal DeviceRequest2 dvcReqField = new DeviceRequest2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIDeviceRequestV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIDeviceRequestV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public DeviceRequest2 DvcReq {
            get {
                return this.dvcReqField;
            }
            set {
                this.xsdSaleToPOIDeviceRequestV01InitFlagField = true;
                this.dvcReqField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIDeviceRequestV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIDeviceRequestV01InitFlag {
            get {
                return this.xsdSaleToPOIDeviceRequestV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIDeviceRequestV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("f2235e79-308b-4cef-b29a-1946eaa3424d")]
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
        [DispId(3)]
        DeviceRequest2 DvcReq {
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
        bool xsdSaleToPOIDeviceRequestV01InitFlag {
            get;
            set;
        }
    }
}
