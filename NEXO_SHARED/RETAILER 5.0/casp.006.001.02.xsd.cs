#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DataSetCategory14Code {
        _begin,
        _none,
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
        /// <remarks/>
        MDFL,
        /// <remarks/>
        SOFT,
        /// <remarks/>
        CONF,
        /// <remarks/>
        RPFL,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f718ead9-73fd-4560-b627-3adae062bda8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DataSetIdentification8 : IDataSetIdentification8 {
        private string nmField = default(string);
        private DataSetCategory14Code tpField = default(DataSetCategory14Code);
        private string vrsnField = default(string);
        private string creDtTmField = default(string);
        private bool creDtTmFieldSpecified = false;
        private bool nmField_XSD_HasBeenSet = false;
        private bool tpField_XSD_HasBeenSet = false;
        private bool vrsnField_XSD_HasBeenSet = false;
        private bool creDtTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.nmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.nmField_XSD_HasBeenSet = (this.nmField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DataSetCategory14Code Tp {
            get {
                return this.tpField;
            }
        }
        /// <remarks/>
        public string Vrsn {
            get {
                return this.vrsnField;
            }
            set {
                this.vrsnField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.vrsnField_XSD_HasBeenSet = (this.vrsnField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string CreDtTm {
            get {
                return this.creDtTmField;
            }
            set {
                this.creDtTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - CreDtTmSpecified = true
                this.CreDtTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool CreDtTmSpecified {
            get {
                return this.creDtTmFieldSpecified;
            }
            set {
                this.creDtTmFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false || this.nmField_XSD_HasBeenSet)
                            || this.tpField_XSD_HasBeenSet)
                            || this.vrsnField_XSD_HasBeenSet)
                            || this.creDtTmField_XSD_HasBeenSet)
                            || this.CreDtTmSpecified);
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7dddedda-4824-498e-811c-b366f95ad9c9")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DataSetRequest1 : IDataSetRequest1 {
        private DataSetIdentification8 idField = new DataSetIdentification8();
        private byte[] pOIChllngField = new byte[0];
        private byte[] tMChllngField = new byte[0];
        private CryptographicKey14 ssnKeyField = new CryptographicKey14();
        private byte[] dlgtnProofField = new byte[0];
        private ContentInformationType23 prtctdDlgtnProofField = new ContentInformationType23();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public DataSetIdentification8 Id {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.idField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.idField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.idField = new DataSetIdentification8();
                }
                else {
                    this.idField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] POIChllng {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.pOIChllngField == null)
                            || (this.pOIChllngField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOIChllngField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.pOIChllngField = new byte[0];
                }
                else {
                    this.pOIChllngField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] TMChllng {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.tMChllngField == null)
                            || (this.tMChllngField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.tMChllngField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.tMChllngField = new byte[0];
                }
                else {
                    this.tMChllngField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CryptographicKey14 SsnKey {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.ssnKeyField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ssnKeyField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ssnKeyField = new CryptographicKey14();
                }
                else {
                    this.ssnKeyField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DlgtnProof {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dlgtnProofField == null)
                            || (this.dlgtnProofField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dlgtnProofField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dlgtnProofField = new byte[0];
                }
                else {
                    this.dlgtnProofField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType23 PrtctdDlgtnProof {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.prtctdDlgtnProofField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtctdDlgtnProofField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtctdDlgtnProofField = new ContentInformationType23();
                }
                else {
                    this.prtctdDlgtnProofField = value;
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
                            || ((this.Id != null)
                            && this.Id.XSD_HasBeenSet))
                            || ((this.SsnKey != null)
                            && this.SsnKey.XSD_HasBeenSet))
                            || ((this.PrtctdDlgtnProof != null)
                            && this.PrtctdDlgtnProof.XSD_HasBeenSet))
                            || (this.POIChllngSize() != 0))
                            || (this.TMChllngSize() != 0))
                            || (this.DlgtnProofSize() != 0));
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
                if ((this.Id != null)) {
                    this.Id.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SsnKey != null)) {
                    this.SsnKey.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PrtctdDlgtnProof != null)) {
                    this.PrtctdDlgtnProof.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int POIChllngSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.pOIChllngField == null)) {
                return 0;
            }
            else {
                return this.pOIChllngField.Length;
            }
            // END ADDED BY XSD
        }
        public byte POIChllngGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool POIChllngSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool POIChllngAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool POIChllngRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
        public int TMChllngSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.tMChllngField == null)) {
                return 0;
            }
            else {
                return this.tMChllngField.Length;
            }
            // END ADDED BY XSD
        }
        public byte TMChllngGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool TMChllngSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool TMChllngAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool TMChllngRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
        public int DlgtnProofSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dlgtnProofField == null)) {
                return 0;
            }
            else {
                return this.dlgtnProofField.Length;
            }
            // END ADDED BY XSD
        }
        public byte DlgtnProofGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool DlgtnProofSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool DlgtnProofAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool DlgtnProofRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("bae59336-9631-4284-9e67-1a7d6c9774cd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DiagnosisResponse2 : IDiagnosisResponse2 {
        private string[] lggdSaleIdField = new string[0];
        private StatusReportContent9 pOIStsField = new StatusReportContent9();
        private HostStatus1[] hstStsField = new HostStatus1[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LggdSaleId")]
        public string[] LggdSaleId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.lggdSaleIdField == null)
                            || (this.lggdSaleIdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lggdSaleIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.lggdSaleIdField = new string[0];
                }
                else {
                    this.lggdSaleIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public StatusReportContent9 POISts {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOIStsField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOIStsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOIStsField = new StatusReportContent9();
                }
                else {
                    this.pOIStsField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HstSts")]
        public HostStatus1[] HstSts {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.hstStsField == null)
                            || (this.hstStsField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.hstStsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.hstStsField = new HostStatus1[0];
                }
                else {
                    this.hstStsField = value;
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
                            || ((this.POISts != null)
                            && this.POISts.XSD_HasBeenSet))
                            || (this.LggdSaleIdSize() != 0))
                            || (this.HstStsSize() != 0));
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
                if ((this.POISts != null)) {
                    this.POISts.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.HstStsSize()); i = (i + 1)) {
                    this.HstSts[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int LggdSaleIdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.lggdSaleIdField == null)) {
                return 0;
            }
            else {
                return this.lggdSaleIdField.Length;
            }
            // END ADDED BY XSD
        }
        public string LggdSaleIdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool LggdSaleIdSetItem(int index, string value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool LggdSaleIdAddItem(string value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool LggdSaleIdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
        public int HstStsSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.hstStsField == null)) {
                return 0;
            }
            else {
                return this.hstStsField.Length;
            }
            // END ADDED BY XSD
        }
        public HostStatus1 HstStsGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool HstStsSetItem(int index, HostStatus1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool HstStsAddItem(HostStatus1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool HstStsRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8a9b16fc-5a91-403c-86cc-e23a38332b78")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StatusReportContent9 : IStatusReportContent9 {
        private PointOfInteractionCapabilities9 pOICpbltiesField = new PointOfInteractionCapabilities9();
        private PointOfInteractionComponent10[] pOICmpntField = new PointOfInteractionComponent10[0];
        private AttendanceContext1Code attndncCntxtField = default(AttendanceContext1Code);
        private bool attndncCntxtFieldSpecified = false;
        private string pOIDtTmField = default(string);
        private DataSetRequest1[] dataSetReqrdField = new DataSetRequest1[0];
        private TMSEvent7[] evtField = new TMSEvent7[0];
        private string[] errsField = new string[0];
        private bool attndncCntxtField_XSD_HasBeenSet = false;
        private bool pOIDtTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public PointOfInteractionCapabilities9 POICpblties {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOICpbltiesField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOICpbltiesField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOICpbltiesField = new PointOfInteractionCapabilities9();
                }
                else {
                    this.pOICpbltiesField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POICmpnt")]
        public PointOfInteractionComponent10[] POICmpnt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.pOICmpntField == null)
                            || (this.pOICmpntField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOICmpntField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.pOICmpntField = new PointOfInteractionComponent10[0];
                }
                else {
                    this.pOICmpntField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public AttendanceContext1Code AttndncCntxt {
            get {
                return this.attndncCntxtField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool AttndncCntxtSpecified {
            get {
                return this.attndncCntxtFieldSpecified;
            }
            set {
                this.attndncCntxtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string POIDtTm {
            get {
                return this.pOIDtTmField;
            }
            set {
                this.pOIDtTmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIDtTmField_XSD_HasBeenSet = (this.pOIDtTmField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSetReqrd")]
        public DataSetRequest1[] DataSetReqrd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.dataSetReqrdField == null)
                            || (this.dataSetReqrdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dataSetReqrdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.dataSetReqrdField = new DataSetRequest1[0];
                }
                else {
                    this.dataSetReqrdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Evt")]
        public TMSEvent7[] Evt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.evtField == null)
                            || (this.evtField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.evtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.evtField = new TMSEvent7[0];
                }
                else {
                    this.evtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errs")]
        public string[] Errs {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.errsField == null)
                            || (this.errsField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.errsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.errsField = new string[0];
                }
                else {
                    this.errsField = value;
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
                            || ((this.POICpblties != null)
                            && this.POICpblties.XSD_HasBeenSet))
                            || (this.POICmpntSize() != 0))
                            || (this.DataSetReqrdSize() != 0))
                            || (this.EvtSize() != 0))
                            || (this.ErrsSize() != 0))
                            || this.attndncCntxtField_XSD_HasBeenSet)
                            || this.pOIDtTmField_XSD_HasBeenSet);
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
                if ((this.POICpblties != null)) {
                    this.POICpblties.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.POICmpntSize()); i = (i + 1)) {
                    this.POICmpnt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.DataSetReqrdSize()); i = (i + 1)) {
                    this.DataSetReqrd[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.EvtSize()); i = (i + 1)) {
                    this.Evt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int POICmpntSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.pOICmpntField == null)) {
                return 0;
            }
            else {
                return this.pOICmpntField.Length;
            }
            // END ADDED BY XSD
        }
        public PointOfInteractionComponent10 POICmpntGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent10[]))) {
                    return default(PointOfInteractionComponent10);
                }
                else {
                    if (((this.pOICmpntField.Length - 1)
                                >= index)) {
                        return this.pOICmpntField[index];
                    }
                    else {
                        return default(PointOfInteractionComponent10);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionComponent10);
            }
            // END ADDED BY XSD
        }
        public bool POICmpntSetItem(int index, PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent10[]))) {
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
            // END ADDED BY XSD
        }
        public bool POICmpntAddItem(PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.pOICmpntField.Length + 1)];
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
            // END ADDED BY XSD
        }
        public bool POICmpntRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.pOICmpntField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    if ((this.pOICmpntField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.pOICmpntField.Length - 1)];
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
            // END ADDED BY XSD
        }
        public int DataSetReqrdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.dataSetReqrdField == null)) {
                return 0;
            }
            else {
                return this.dataSetReqrdField.Length;
            }
            // END ADDED BY XSD
        }
        public DataSetRequest1 DataSetReqrdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.dataSetReqrdField == default(DataSetRequest1[]))) {
                    return default(DataSetRequest1);
                }
                else {
                    if (((this.dataSetReqrdField.Length - 1)
                                >= index)) {
                        return this.dataSetReqrdField[index];
                    }
                    else {
                        return default(DataSetRequest1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(DataSetRequest1);
            }
            // END ADDED BY XSD
        }
        public bool DataSetReqrdSetItem(int index, DataSetRequest1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.dataSetReqrdField == default(DataSetRequest1[]))) {
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
            // END ADDED BY XSD
        }
        public bool DataSetReqrdAddItem(DataSetRequest1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.dataSetReqrdField == default(DataSetRequest1[]))) {
                    return false;
                }
                else {
                    DataSetRequest1[] array = new DataSetRequest1[(this.dataSetReqrdField.Length + 1)];
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
            // END ADDED BY XSD
        }
        public bool DataSetReqrdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.dataSetReqrdField == default(DataSetRequest1[]))) {
                    return false;
                }
                else {
                    if ((this.dataSetReqrdField.Length <= index)) {
                        return false;
                    }
                    else {
                        DataSetRequest1[] array = new DataSetRequest1[(this.dataSetReqrdField.Length - 1)];
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
            // END ADDED BY XSD
        }
        public int EvtSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.evtField == null)) {
                return 0;
            }
            else {
                return this.evtField.Length;
            }
            // END ADDED BY XSD
        }
        public TMSEvent7 EvtGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.evtField == default(TMSEvent7[]))) {
                    return default(TMSEvent7);
                }
                else {
                    if (((this.evtField.Length - 1)
                                >= index)) {
                        return this.evtField[index];
                    }
                    else {
                        return default(TMSEvent7);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TMSEvent7);
            }
            // END ADDED BY XSD
        }
        public bool EvtSetItem(int index, TMSEvent7 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.evtField == default(TMSEvent7[]))) {
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
            // END ADDED BY XSD
        }
        public bool EvtAddItem(TMSEvent7 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.evtField == default(TMSEvent7[]))) {
                    return false;
                }
                else {
                    TMSEvent7[] array = new TMSEvent7[(this.evtField.Length + 1)];
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
            // END ADDED BY XSD
        }
        public bool EvtRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.evtField == default(TMSEvent7[]))) {
                    return false;
                }
                else {
                    if ((this.evtField.Length <= index)) {
                        return false;
                    }
                    else {
                        TMSEvent7[] array = new TMSEvent7[(this.evtField.Length - 1)];
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
            // END ADDED BY XSD
        }
        public int ErrsSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.errsField == null)) {
                return 0;
            }
            else {
                return this.errsField.Length;
            }
            // END ADDED BY XSD
        }
        public string ErrsGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
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
            // END ADDED BY XSD
        }
        public bool ErrsSetItem(int index, string value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
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
            // END ADDED BY XSD
        }
        public bool ErrsAddItem(string value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
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
            // END ADDED BY XSD
        }
        public bool ErrsRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
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
            // END ADDED BY XSD
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("07b3870f-a750-4718-8973-b61fa1c97eb3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSEvent7 : ITMSEvent7 {
        private string tmStmpField = default(string);
        private TerminalManagementActionResult4Code rsltField = default(TerminalManagementActionResult4Code);
        private TMSActionIdentification6 actnIdField = new TMSActionIdentification6();
        private string addtlErrInfField = default(string);
        private string termnlMgrIdField = default(string);
        private bool tmStmpField_XSD_HasBeenSet = false;
        private bool rsltField_XSD_HasBeenSet = false;
        private bool addtlErrInfField_XSD_HasBeenSet = false;
        private bool termnlMgrIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string TmStmp {
            get {
                return this.tmStmpField;
            }
            set {
                this.tmStmpField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.tmStmpField_XSD_HasBeenSet = (this.tmStmpField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TerminalManagementActionResult4Code Rslt {
            get {
                return this.rsltField;
            }
        }
        /// <remarks/>
        public TMSActionIdentification6 ActnId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.actnIdField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.actnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.actnIdField = new TMSActionIdentification6();
                }
                else {
                    this.actnIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlErrInf {
            get {
                return this.addtlErrInfField;
            }
            set {
                this.addtlErrInfField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlErrInfField_XSD_HasBeenSet = (this.addtlErrInfField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string TermnlMgrId {
            get {
                return this.termnlMgrIdField;
            }
            set {
                this.termnlMgrIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.termnlMgrIdField_XSD_HasBeenSet = (this.termnlMgrIdField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false
                            || ((this.ActnId != null)
                            && this.ActnId.XSD_HasBeenSet))
                            || this.tmStmpField_XSD_HasBeenSet)
                            || this.rsltField_XSD_HasBeenSet)
                            || this.addtlErrInfField_XSD_HasBeenSet)
                            || this.termnlMgrIdField_XSD_HasBeenSet);
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
                if ((this.ActnId != null)) {
                    this.ActnId.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TerminalManagementActionResult4Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("5e398ffd-e556-4fc0-9a4d-be73fbda2afb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSActionIdentification6 : ITMSActionIdentification6 {
        private TerminalManagementAction4Code actnTpField = default(TerminalManagementAction4Code);
        private DataSetIdentification8 dataSetIdField = new DataSetIdentification8();
        private bool actnTpField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TerminalManagementAction4Code ActnTp {
            get {
                return this.actnTpField;
            }
        }
        /// <remarks/>
        public DataSetIdentification8 DataSetId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dataSetIdField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dataSetIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dataSetIdField = new DataSetIdentification8();
                }
                else {
                    this.dataSetIdField = value;
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
                            || ((this.DataSetId != null)
                            && this.DataSetId.XSD_HasBeenSet))
                            || this.actnTpField_XSD_HasBeenSet);
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
                if ((this.DataSetId != null)) {
                    this.DataSetId.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TerminalManagementAction4Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("fc498441-a36b-4854-95b4-1093420bd697")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HostStatus1 : IHostStatus1 {
        private string acqrrIdField = default(string);
        private bool rchblField = default(bool);
        private bool rchblFieldSpecified = false;
        private bool acqrrIdField_XSD_HasBeenSet = false;
        private bool rchblField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
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
        public bool Rchbl {
            get {
                return this.rchblField;
            }
            set {
                this.rchblField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - RchblSpecified = true
                this.RchblSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool RchblSpecified {
            get {
                return this.rchblFieldSpecified;
            }
            set {
                this.rchblFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false || this.acqrrIdField_XSD_HasBeenSet)
                            || this.rchblField_XSD_HasBeenSet)
                            || this.RchblSpecified);
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ce8afff8-2463-40d7-8cab-311b271fb2d8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOISessionManagementResponseV02 : ISaleToPOISessionManagementResponseV02 {
        private Header41 hdrField = new Header41();
        private SessionManagementResponse3 ssnMgmtRspnField = new SessionManagementResponse3();
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
        public SessionManagementResponse3 SsnMgmtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.ssnMgmtRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ssnMgmtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ssnMgmtRspnField = new SessionManagementResponse3();
                }
                else {
                    this.ssnMgmtRspnField = value;
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
                            || ((this.SsnMgmtRspn != null)
                            && this.SsnMgmtRspn.XSD_HasBeenSet))
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
                if ((this.SsnMgmtRspn != null)) {
                    this.SsnMgmtRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("02da77d6-9511-4b85-a10d-e63354dcb1b2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SessionManagementResponse3 : ISessionManagementResponse3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService5Code svcCnttField = default(RetailerService5Code);
        private LoginResponse2 lgnRspnField = new LoginResponse2();
        private DiagnosisResponse2 dgnssRspnField = new DiagnosisResponse2();
        private ResponseType9 rspnField = new ResponseType9();
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
        public RetailerService5Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        public LoginResponse2 LgnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lgnRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lgnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lgnRspnField = new LoginResponse2();
                }
                else {
                    this.lgnRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public DiagnosisResponse2 DgnssRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.dgnssRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.dgnssRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.dgnssRspnField = new DiagnosisResponse2();
                }
                else {
                    this.dgnssRspnField = value;
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
                return (((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.LgnRspn != null)
                            && this.LgnRspn.XSD_HasBeenSet))
                            || ((this.DgnssRspn != null)
                            && this.DgnssRspn.XSD_HasBeenSet))
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
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
                if ((this.LgnRspn != null)) {
                    this.LgnRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.DgnssRspn != null)) {
                    this.DgnssRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService5Code {
        _begin,
        _none,
        /// <remarks/>
        SMIP,
        /// <remarks/>
        SMOP,
        /// <remarks/>
        SMDP,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.006.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("eb9f8677-8478-4dc0-bde4-33db8f3236c9")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoginResponse2 : ILoginResponse2 {
        private string pOIDtTmField = default(string);
        private PointOfInteractionComponent10[] pOISftwrField = new PointOfInteractionComponent10[0];
        private PointOfInteractionCapabilities9 pOICpbltiesField = new PointOfInteractionCapabilities9();
        private ActionMessage7 outptDispField = new ActionMessage7();
        private bool pOIDtTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string POIDtTm {
            get {
                return this.pOIDtTmField;
            }
            set {
                this.pOIDtTmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIDtTmField_XSD_HasBeenSet = (this.pOIDtTmField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POISftwr")]
        public PointOfInteractionComponent10[] POISftwr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.pOISftwrField == null)
                            || (this.pOISftwrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOISftwrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.pOISftwrField = new PointOfInteractionComponent10[0];
                }
                else {
                    this.pOISftwrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public PointOfInteractionCapabilities9 POICpblties {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOICpbltiesField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOICpbltiesField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOICpbltiesField = new PointOfInteractionCapabilities9();
                }
                else {
                    this.pOICpbltiesField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ActionMessage7 OutptDisp {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.outptDispField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.outptDispField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.outptDispField = new ActionMessage7();
                }
                else {
                    this.outptDispField = value;
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
                            || ((this.POICpblties != null)
                            && this.POICpblties.XSD_HasBeenSet))
                            || ((this.OutptDisp != null)
                            && this.OutptDisp.XSD_HasBeenSet))
                            || (this.POISftwrSize() != 0))
                            || this.pOIDtTmField_XSD_HasBeenSet);
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
                if ((this.POICpblties != null)) {
                    this.POICpblties.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.OutptDisp != null)) {
                    this.OutptDisp.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.POISftwrSize()); i = (i + 1)) {
                    this.POISftwr[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
        public int POISftwrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.pOISftwrField == null)) {
                return 0;
            }
            else {
                return this.pOISftwrField.Length;
            }
            // END ADDED BY XSD
        }
        public PointOfInteractionComponent10 POISftwrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent10[]))) {
                    return default(PointOfInteractionComponent10);
                }
                else {
                    if (((this.pOISftwrField.Length - 1)
                                >= index)) {
                        return this.pOISftwrField[index];
                    }
                    else {
                        return default(PointOfInteractionComponent10);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionComponent10);
            }
            // END ADDED BY XSD
        }
        public bool POISftwrSetItem(int index, PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent10[]))) {
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
            // END ADDED BY XSD
        }
        public bool POISftwrAddItem(PointOfInteractionComponent10 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.pOISftwrField.Length + 1)];
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
            // END ADDED BY XSD
        }
        public bool POISftwrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.pOISftwrField == default(PointOfInteractionComponent10[]))) {
                    return false;
                }
                else {
                    if ((this.pOISftwrField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionComponent10[] array = new PointOfInteractionComponent10[(this.pOISftwrField.Length - 1)];
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
            // END ADDED BY XSD
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("69756eda-6e1f-4979-9b7b-74d60b88e572")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDataSetIdentification8 {
        /// <remarks/>
        [DispId(1)]
        string Nm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        DataSetCategory14Code Tp {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        string Vrsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string CreDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool CreDtTmSpecified {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("791b7cbe-1d70-4924-bf54-84e32e48c79c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDataSetRequest1 {
        /// <remarks/>
        [DispId(1)]
        DataSetIdentification8 Id {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        byte[] POIChllng {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        byte[] TMChllng {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        CryptographicKey14 SsnKey {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] DlgtnProof {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        ContentInformationType23 PrtctdDlgtnProof {
            get;
            set;
        }
        [DispId(7)]
        int POIChllngSize();
        [DispId(8)]
        byte POIChllngGetItem(int index);
        [DispId(9)]
        bool POIChllngSetItem(int index, byte value);
        [DispId(10)]
        bool POIChllngAddItem(byte value);
        [DispId(11)]
        bool POIChllngRemoveItem(int index);
        [DispId(12)]
        int TMChllngSize();
        [DispId(13)]
        byte TMChllngGetItem(int index);
        [DispId(14)]
        bool TMChllngSetItem(int index, byte value);
        [DispId(15)]
        bool TMChllngAddItem(byte value);
        [DispId(16)]
        bool TMChllngRemoveItem(int index);
        [DispId(17)]
        int DlgtnProofSize();
        [DispId(18)]
        byte DlgtnProofGetItem(int index);
        [DispId(19)]
        bool DlgtnProofSetItem(int index, byte value);
        [DispId(20)]
        bool DlgtnProofAddItem(byte value);
        [DispId(21)]
        bool DlgtnProofRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("2d01f1be-c06c-4b83-8f03-d15d5df15c83")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDiagnosisResponse2 {
        /// <remarks/>
        [DispId(1)]
        string[] LggdSaleId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        StatusReportContent9 POISts {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        HostStatus1[] HstSts {
            get;
            set;
        }
        [DispId(4)]
        int LggdSaleIdSize();
        [DispId(5)]
        string LggdSaleIdGetItem(int index);
        [DispId(6)]
        bool LggdSaleIdSetItem(int index, string value);
        [DispId(7)]
        bool LggdSaleIdAddItem(string value);
        [DispId(8)]
        bool LggdSaleIdRemoveItem(int index);
        [DispId(9)]
        int HstStsSize();
        [DispId(10)]
        HostStatus1 HstStsGetItem(int index);
        [DispId(11)]
        bool HstStsSetItem(int index, HostStatus1 value);
        [DispId(12)]
        bool HstStsAddItem(HostStatus1 value);
        [DispId(13)]
        bool HstStsRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("c6eb428a-0633-4748-8988-6d32c1317369")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IStatusReportContent9 {
        /// <remarks/>
        [DispId(1)]
        PointOfInteractionCapabilities9 POICpblties {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        PointOfInteractionComponent10[] POICmpnt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        AttendanceContext1Code AttndncCntxt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        bool AttndncCntxtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string POIDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        DataSetRequest1[] DataSetReqrd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        TMSEvent7[] Evt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        string[] Errs {
            get;
            set;
        }
        [DispId(9)]
        int POICmpntSize();
        [DispId(10)]
        PointOfInteractionComponent10 POICmpntGetItem(int index);
        [DispId(11)]
        bool POICmpntSetItem(int index, PointOfInteractionComponent10 value);
        [DispId(12)]
        bool POICmpntAddItem(PointOfInteractionComponent10 value);
        [DispId(13)]
        bool POICmpntRemoveItem(int index);
        [DispId(14)]
        int DataSetReqrdSize();
        [DispId(15)]
        DataSetRequest1 DataSetReqrdGetItem(int index);
        [DispId(16)]
        bool DataSetReqrdSetItem(int index, DataSetRequest1 value);
        [DispId(17)]
        bool DataSetReqrdAddItem(DataSetRequest1 value);
        [DispId(18)]
        bool DataSetReqrdRemoveItem(int index);
        [DispId(19)]
        int EvtSize();
        [DispId(20)]
        TMSEvent7 EvtGetItem(int index);
        [DispId(21)]
        bool EvtSetItem(int index, TMSEvent7 value);
        [DispId(22)]
        bool EvtAddItem(TMSEvent7 value);
        [DispId(23)]
        bool EvtRemoveItem(int index);
        [DispId(24)]
        int ErrsSize();
        [DispId(25)]
        string ErrsGetItem(int index);
        [DispId(26)]
        bool ErrsSetItem(int index, string value);
        [DispId(27)]
        bool ErrsAddItem(string value);
        [DispId(28)]
        bool ErrsRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("55cf5451-868b-4c32-b956-6415c46b3540")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSEvent7 {
        /// <remarks/>
        [DispId(1)]
        string TmStmp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        TerminalManagementActionResult4Code Rslt {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        TMSActionIdentification6 ActnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string AddtlErrInf {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string TermnlMgrId {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0ee5c7a8-a603-42b8-9311-c608dbc901c2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSActionIdentification6 {
        /// <remarks/>
        [DispId(1)]
        TerminalManagementAction4Code ActnTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        DataSetIdentification8 DataSetId {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6828ed7d-aca3-47bc-b010-5ca143dd9947")]
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
        [DispId(2)]
        bool Rchbl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool RchblSpecified {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("bff088ea-fbb1-438f-b650-8e1ade50bcb7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOISessionManagementResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        SessionManagementResponse3 SsnMgmtRspn {
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
    [System.Runtime.InteropServices.GuidAttribute("8700e666-353b-4f3d-8db4-652382f6bc05")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISessionManagementResponse3 {
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
        RetailerService5Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        LoginResponse2 LgnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        DiagnosisResponse2 DgnssRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(8)]
        int SplmtryDataSize();
        [DispId(9)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(10)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(11)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(12)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("a81e5d11-1fd1-4b4d-beec-591fe639c8f5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoginResponse2 {
        /// <remarks/>
        [DispId(1)]
        string POIDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        PointOfInteractionComponent10[] POISftwr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PointOfInteractionCapabilities9 POICpblties {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        ActionMessage7 OutptDisp {
            get;
            set;
        }
        [DispId(5)]
        int POISftwrSize();
        [DispId(6)]
        PointOfInteractionComponent10 POISftwrGetItem(int index);
        [DispId(7)]
        bool POISftwrSetItem(int index, PointOfInteractionComponent10 value);
        [DispId(8)]
        bool POISftwrAddItem(PointOfInteractionComponent10 value);
        [DispId(9)]
        bool POISftwrRemoveItem(int index);
    }
}
#endif
