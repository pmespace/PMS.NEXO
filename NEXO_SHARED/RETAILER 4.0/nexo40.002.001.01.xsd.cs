#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("69fee354-3f75-46f7-a182-b42b5c41980f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Action8 : IAction8 {
        private ActionType7Code actnTpField;
        private ActionMessage2 msgToPresField = new ActionMessage2();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public ActionType7Code ActnTp {
            get {
                return this.actnTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.actnTpField = value;
            }
        }
        /// <remarks/>
        public ActionMessage2 MsgToPres {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.msgToPresField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgToPresField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.msgToPresField = new ActionMessage2();
                }
                else {
                    this.msgToPresField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.MsgToPres.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.MsgToPres = null;
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
                if ((this.MsgToPres != null)) {
                    this.MsgToPres.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ActionType7Code {
        /// <remarks/>
        BUSY,
        /// <remarks/>
        CPTR,
        /// <remarks/>
        DISP,
        /// <remarks/>
        NOVR,
        /// <remarks/>
        RQID,
        /// <remarks/>
        PINL,
        /// <remarks/>
        PINR,
        /// <remarks/>
        PRNT,
        /// <remarks/>
        RFRL,
        /// <remarks/>
        RQDT,
        /// <remarks/>
        DCCQ,
        /// <remarks/>
        FLFW,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("422ba245-d407-4d44-a792-b28c518892e0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActionMessage2 : IActionMessage2 {
        private UserInterface4Code msgDstnField;
        private OutputFormat1Code frmtField;
        private bool frmtFieldSpecified;
        private string msgCnttField;
        private byte[] msgCnttSgntrField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public UserInterface4Code MsgDstn {
            get {
                return this.msgDstnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.msgDstnField = value;
            }
        }
        /// <remarks/>
        public OutputFormat1Code Frmt {
            get {
                return this.frmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.frmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - FrmtSpecified = true
                this.FrmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrmtSpecified {
            get {
                return this.frmtFieldSpecified;
            }
            set {
                this.frmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string MsgCntt {
            get {
                return this.msgCnttField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.msgCnttField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgCnttSgntr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.msgCnttSgntrField == null)
                            || (this.msgCnttSgntrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgCnttSgntrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.msgCnttSgntrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.FrmtSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.FrmtSpecified = false;
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
        public int MsgCnttSgntrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.msgCnttSgntrField == null)) {
                return 0;
            }
            else {
                return this.msgCnttSgntrField.Length;
            }
            // END ADDED BY XSD
        }
        public byte MsgCnttSgntrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.msgCnttSgntrField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.msgCnttSgntrField.Length - 1)
                                >= index)) {
                        return this.msgCnttSgntrField[index];
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
        public bool MsgCnttSgntrSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.msgCnttSgntrField == default(byte[]))) {
                    return false;
                }
                else {
                    this.msgCnttSgntrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgCnttSgntrAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.msgCnttSgntrField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.msgCnttSgntrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.msgCnttSgntrField.Length); i = (i + 1)) {
                        array[i] = msgCnttSgntrField[i];
                    }
                    array[i] = value;
                    this.MsgCnttSgntr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgCnttSgntrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.msgCnttSgntrField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.msgCnttSgntrField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.msgCnttSgntrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = msgCnttSgntrField[i];
                        }
                        for (i = (i + 1); (i < this.msgCnttSgntrField.Length); i = (i + 1)) {
                            array[i] = msgCnttSgntrField[i];
                        }
                        this.MsgCnttSgntr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7c41c6b9-05cc-42c4-9470-b6af3dbab5d3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AmountAndDirection93 : IAmountAndDirection93 {
        private double amtField;
        private string ccyField;
        private bool sgnField;
        private bool sgnFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public double Amt {
            get {
                return this.amtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.amtField = value;
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public bool Sgn {
            get {
                return this.sgnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.sgnField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - SgnSpecified = true
                this.SgnSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SgnSpecified {
            get {
                return this.sgnFieldSpecified;
            }
            set {
                this.sgnFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.SgnSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SgnSpecified = false;
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("84a9a0e0-f229-43fc-9db9-37fe2c7dad75")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AuthorisationResult10 : IAuthorisationResult10 {
        private GenericIdentification90 authstnNttyField = new GenericIdentification90();
        private ResponseType5 rspnToAuthstnField = new ResponseType5();
        private string authstnCdField;
        private bool cmpltnReqrdField;
        private bool cmpltnReqrdFieldSpecified;
        private TMSTrigger1 tMSTrggrField = new TMSTrigger1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public GenericIdentification90 AuthstnNtty {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.authstnNttyField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.authstnNttyField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.authstnNttyField = new GenericIdentification90();
                }
                else {
                    this.authstnNttyField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ResponseType5 RspnToAuthstn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rspnToAuthstnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rspnToAuthstnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rspnToAuthstnField = new ResponseType5();
                }
                else {
                    this.rspnToAuthstnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AuthstnCd {
            get {
                return this.authstnCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.authstnCdField = value;
            }
        }
        /// <remarks/>
        public bool CmpltnReqrd {
            get {
                return this.cmpltnReqrdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cmpltnReqrdField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - CmpltnReqrdSpecified = true
                this.CmpltnReqrdSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CmpltnReqrdSpecified {
            get {
                return this.cmpltnReqrdFieldSpecified;
            }
            set {
                this.cmpltnReqrdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public TMSTrigger1 TMSTrggr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.tMSTrggrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.tMSTrggrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.tMSTrggrField = new TMSTrigger1();
                }
                else {
                    this.tMSTrggrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.AuthstnNtty.XSD_HasBeenSetProperty)
                            || this.RspnToAuthstn.XSD_HasBeenSetProperty)
                            || this.TMSTrggr.XSD_HasBeenSetProperty)
                            || this.CmpltnReqrdSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.AuthstnNtty = null;
                    this.RspnToAuthstn = null;
                    this.TMSTrggr = null;
                    this.CmpltnReqrdSpecified = false;
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
                if ((this.AuthstnNtty != null)) {
                    this.AuthstnNtty.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.RspnToAuthstn != null)) {
                    this.RspnToAuthstn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.TMSTrggr != null)) {
                    this.TMSTrggr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7cfb0a75-bfef-4404-8309-1b539076cd5c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class GenericIdentification90 : IGenericIdentification90 {
        private string idField;
        private PartyType14Code tpField;
        private PartyType4Code issrField;
        private bool issrFieldSpecified;
        private string ctryField;
        private string shrtNmField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.idField = value;
            }
        }
        /// <remarks/>
        public PartyType14Code Tp {
            get {
                return this.tpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.tpField = value;
            }
        }
        /// <remarks/>
        public PartyType4Code Issr {
            get {
                return this.issrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.issrField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - IssrSpecified = true
                this.IssrSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IssrSpecified {
            get {
                return this.issrFieldSpecified;
            }
            set {
                this.issrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string Ctry {
            get {
                return this.ctryField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ctryField = value;
            }
        }
        /// <remarks/>
        public string ShrtNm {
            get {
                return this.shrtNmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.shrtNmField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.IssrSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.IssrSpecified = false;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PartyType14Code {
        /// <remarks/>
        OPOI,
        /// <remarks/>
        MERC,
        /// <remarks/>
        ACCP,
        /// <remarks/>
        ITAG,
        /// <remarks/>
        ACQR,
        /// <remarks/>
        CISS,
        /// <remarks/>
        DLIS,
        /// <remarks/>
        ICCA,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("786fba91-641e-4063-aeab-aef579faec47")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType5 : IResponseType5 {
        private Response4Code rspnField;
        private string rspnRsnField;
        private string addtlRspnInfField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public Response4Code Rspn {
            get {
                return this.rspnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public string RspnRsn {
            get {
                return this.rspnRsnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnRsnField = value;
            }
        }
        /// <remarks/>
        public string AddtlRspnInf {
            get {
                return this.addtlRspnInfField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlRspnInfField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Response4Code {
        /// <remarks/>
        APPR,
        /// <remarks/>
        DECL,
        /// <remarks/>
        PART,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f74dbe77-f6c2-4327-9d4f-eb96e8b88a39")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSTrigger1 : ITMSTrigger1 {
        private TMSContactLevel1Code tMSCtctLvlField;
        private string tMSIdField;
        private string tMSCtctDtTmField;
        private bool tMSCtctDtTmFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TMSContactLevel1Code TMSCtctLvl {
            get {
                return this.tMSCtctLvlField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.tMSCtctLvlField = value;
            }
        }
        /// <remarks/>
        public string TMSId {
            get {
                return this.tMSIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.tMSIdField = value;
            }
        }
        /// <remarks/>
        public string TMSCtctDtTm {
            get {
                return this.tMSCtctDtTmField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.tMSCtctDtTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - TMSCtctDtTmSpecified = true
                this.TMSCtctDtTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TMSCtctDtTmSpecified {
            get {
                return this.tMSCtctDtTmFieldSpecified;
            }
            set {
                this.tMSCtctDtTmFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.TMSCtctDtTmSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.TMSCtctDtTmSpecified = false;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TMSContactLevel1Code {
        /// <remarks/>
        CRIT,
        /// <remarks/>
        ASAP,
        /// <remarks/>
        DTIM,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("39d26d36-777e-44f0-97cf-1fcd71df506c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BalanceInquiryResponse1 : IBalanceInquiryResponse1 {
        private PaymentAccount2 pmtAcctField = new PaymentAccount2();
        private LoyaltyAccount1 lltyAcctField = new LoyaltyAccount1();
        private StoredValueAccount1[] stordValAcctField = new StoredValueAccount1[0];
        private PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public PaymentAccount2 PmtAcct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pmtAcctField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtAcctField = new PaymentAccount2();
                }
                else {
                    this.pmtAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyAccount1 LltyAcct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.lltyAcctField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lltyAcctField = new LoyaltyAccount1();
                }
                else {
                    this.lltyAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StordValAcct")]
        public StoredValueAccount1[] StordValAcct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.stordValAcctField == null)
                            || (this.stordValAcctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.stordValAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.stordValAcctField = new StoredValueAccount1[0];
                }
                else {
                    this.stordValAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rctField = new PaymentReceipt1[0];
                }
                else {
                    this.rctField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.PmtAcct.XSD_HasBeenSetProperty)
                            || this.LltyAcct.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.PmtAcct = null;
                    this.LltyAcct = null;
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
                if ((this.PmtAcct != null)) {
                    this.PmtAcct.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.LltyAcct != null)) {
                    this.LltyAcct.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int StordValAcctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.stordValAcctField == null)) {
                return 0;
            }
            else {
                return this.stordValAcctField.Length;
            }
            // END ADDED BY XSD
        }
        public StoredValueAccount1 StordValAcctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount1[]))) {
                    return default(StoredValueAccount1);
                }
                else {
                    if (((this.stordValAcctField.Length - 1)
                                >= index)) {
                        return this.stordValAcctField[index];
                    }
                    else {
                        return default(StoredValueAccount1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(StoredValueAccount1);
            }
            // END ADDED BY XSD
        }
        public bool StordValAcctSetItem(int index, StoredValueAccount1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount1[]))) {
                    return false;
                }
                else {
                    this.stordValAcctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool StordValAcctAddItem(StoredValueAccount1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount1[]))) {
                    return false;
                }
                else {
                    StoredValueAccount1[] array = new StoredValueAccount1[(this.stordValAcctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.stordValAcctField.Length); i = (i + 1)) {
                        array[i] = stordValAcctField[i];
                    }
                    array[i] = value;
                    this.StordValAcct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool StordValAcctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount1[]))) {
                    return false;
                }
                else {
                    if ((this.stordValAcctField.Length <= index)) {
                        return false;
                    }
                    else {
                        StoredValueAccount1[] array = new StoredValueAccount1[(this.stordValAcctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = stordValAcctField[i];
                        }
                        for (i = (i + 1); (i < this.stordValAcctField.Length); i = (i + 1)) {
                            array[i] = stordValAcctField[i];
                        }
                        this.StordValAcct = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int RctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
            // END ADDED BY XSD
        }
        public PaymentReceipt1 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return default(PaymentReceipt1);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt1);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    this.rctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctAddItem(PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rctField.Length); i = (i + 1)) {
                        array[i] = rctField[i];
                    }
                    array[i] = value;
                    this.Rct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        for (i = (i + 1); (i < this.rctField.Length); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        this.Rct = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a5b37b1d-0b24-4c79-ba8f-59ea6006313d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentAccount2 : IPaymentAccount2 {
        private string ccyField;
        private double curBalField;
        private bool curBalFieldSpecified;
        private Acquirer9 pmtAcqrrDataField = new Acquirer9();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public double CurBal {
            get {
                return this.curBalField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.curBalField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - CurBalSpecified = true
                this.CurBalSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurBalSpecified {
            get {
                return this.curBalFieldSpecified;
            }
            set {
                this.curBalFieldSpecified = value;
            }
        }
        /// <remarks/>
        public Acquirer9 PmtAcqrrData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pmtAcqrrDataField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtAcqrrDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtAcqrrDataField = new Acquirer9();
                }
                else {
                    this.pmtAcqrrDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.PmtAcqrrData.XSD_HasBeenSetProperty)
                            || this.CurBalSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.PmtAcqrrData = null;
                    this.CurBalSpecified = false;
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
                if ((this.PmtAcqrrData != null)) {
                    this.PmtAcqrrData.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("85dbd428-5548-4a25-bb38-0e172a379897")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentReceipt1 : IPaymentReceipt1 {
        private DocumentType7Code docQlfrField;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DocumentType7Code {
        /// <remarks/>
        JNRL,
        /// <remarks/>
        CRCP,
        /// <remarks/>
        HRCP,
        /// <remarks/>
        SRCP,
        /// <remarks/>
        RPIN,
        /// <remarks/>
        VCHR,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1de1170a-4c8b-49c0-ae4c-53554874a574")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BatchResponse1 : IBatchResponse1 {
        private PerformedTransaction1[] prfrmdTxField = new PerformedTransaction1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrfrmdTx")]
        public PerformedTransaction1[] PrfrmdTx {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.prfrmdTxField == null)
                            || (this.prfrmdTxField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prfrmdTxField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.prfrmdTxField = new PerformedTransaction1[0];
                }
                else {
                    this.prfrmdTxField = value;
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
        public int PrfrmdTxSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.prfrmdTxField == null)) {
                return 0;
            }
            else {
                return this.prfrmdTxField.Length;
            }
            // END ADDED BY XSD
        }
        public PerformedTransaction1 PrfrmdTxGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction1[]))) {
                    return default(PerformedTransaction1);
                }
                else {
                    if (((this.prfrmdTxField.Length - 1)
                                >= index)) {
                        return this.prfrmdTxField[index];
                    }
                    else {
                        return default(PerformedTransaction1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PerformedTransaction1);
            }
            // END ADDED BY XSD
        }
        public bool PrfrmdTxSetItem(int index, PerformedTransaction1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    this.prfrmdTxField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PrfrmdTxAddItem(PerformedTransaction1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    PerformedTransaction1[] array = new PerformedTransaction1[(this.prfrmdTxField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.prfrmdTxField.Length); i = (i + 1)) {
                        array[i] = prfrmdTxField[i];
                    }
                    array[i] = value;
                    this.PrfrmdTx = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PrfrmdTxRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    if ((this.prfrmdTxField.Length <= index)) {
                        return false;
                    }
                    else {
                        PerformedTransaction1[] array = new PerformedTransaction1[(this.prfrmdTxField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = prfrmdTxField[i];
                        }
                        for (i = (i + 1); (i < this.prfrmdTxField.Length); i = (i + 1)) {
                            array[i] = prfrmdTxField[i];
                        }
                        this.PrfrmdTx = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("57951409-8e7c-4f78-a24c-575963de7683")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PerformedTransaction1 : IPerformedTransaction1 {
        private ResponseType9 rspnField = new ResponseType9();
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField;
        private RetailerPaymentResult1 pmtRsltField = new RetailerPaymentResult1();
        private LoyaltyResult1[] lltyRsltField = new LoyaltyResult1[0];
        private double rvsdAmtField;
        private bool rvsdAmtFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rspnField.XSD_HasBeenSetProperty == false))) {
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
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.saleTxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleTxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleTxIdField = new TransactionIdentifier1();
                }
                else {
                    this.saleTxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public RetailerPaymentResult1 PmtRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pmtRsltField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtRsltField = new RetailerPaymentResult1();
                }
                else {
                    this.pmtRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult1[] LltyRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.lltyRsltField == null)
                            || (this.lltyRsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.lltyRsltField = new LoyaltyResult1[0];
                }
                else {
                    this.lltyRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double RvsdAmt {
            get {
                return this.rvsdAmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rvsdAmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RvsdAmtSpecified = true
                this.RvsdAmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RvsdAmtSpecified {
            get {
                return this.rvsdAmtFieldSpecified;
            }
            set {
                this.rvsdAmtFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((((this.XSD_HasBeenSetField || this.Rspn.XSD_HasBeenSetProperty)
                            || this.SaleTxId.XSD_HasBeenSetProperty)
                            || this.POITxId.XSD_HasBeenSetProperty)
                            || this.PmtRslt.XSD_HasBeenSetProperty)
                            || this.RvsdAmtSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Rspn = null;
                    this.SaleTxId = null;
                    this.POITxId = null;
                    this.PmtRslt = null;
                    this.RvsdAmtSpecified = false;
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
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PmtRslt != null)) {
                    this.PmtRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int LltyRsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.lltyRsltField == null)) {
                return 0;
            }
            else {
                return this.lltyRsltField.Length;
            }
            // END ADDED BY XSD
        }
        public LoyaltyResult1 LltyRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return default(LoyaltyResult1);
                }
                else {
                    if (((this.lltyRsltField.Length - 1)
                                >= index)) {
                        return this.lltyRsltField[index];
                    }
                    else {
                        return default(LoyaltyResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult1);
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    this.lltyRsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltAddItem(LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    LoyaltyResult1[] array = new LoyaltyResult1[(this.lltyRsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.lltyRsltField.Length); i = (i + 1)) {
                        array[i] = lltyRsltField[i];
                    }
                    array[i] = value;
                    this.LltyRslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    if ((this.lltyRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult1[] array = new LoyaltyResult1[(this.lltyRsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = lltyRsltField[i];
                        }
                        for (i = (i + 1); (i < this.lltyRsltField.Length); i = (i + 1)) {
                            array[i] = lltyRsltField[i];
                        }
                        this.LltyRslt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("44b84ce6-6c1f-4ad8-83cb-43af6a0511b2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType9 : IResponseType9 {
        private Response5Code rspnField;
        private RetailerResultDetail1Code rspnRsnField;
        private bool rspnRsnFieldSpecified;
        private string addtlRspnInfField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public Response5Code Rspn {
            get {
                return this.rspnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public RetailerResultDetail1Code RspnRsn {
            get {
                return this.rspnRsnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rspnRsnField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RspnRsnSpecified = true
                this.RspnRsnSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RspnRsnSpecified {
            get {
                return this.rspnRsnFieldSpecified;
            }
            set {
                this.rspnRsnFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string AddtlRspnInf {
            get {
                return this.addtlRspnInfField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlRspnInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.RspnRsnSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.RspnRsnSpecified = false;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Response5Code {
        /// <remarks/>
        SUCC,
        /// <remarks/>
        FAIL,
        /// <remarks/>
        PART,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerResultDetail1Code {
        /// <remarks/>
        ABRT,
        /// <remarks/>
        BUSY,
        /// <remarks/>
        CANC,
        /// <remarks/>
        DEVO,
        /// <remarks/>
        WPIN,
        /// <remarks/>
        NHOS,
        /// <remarks/>
        UNVS,
        /// <remarks/>
        UNVD,
        /// <remarks/>
        REFU,
        /// <remarks/>
        PAYR,
        /// <remarks/>
        TNFD,
        /// <remarks/>
        NALW,
        /// <remarks/>
        LOUT,
        /// <remarks/>
        IVCA,
        /// <remarks/>
        ICAR,
        /// <remarks/>
        WIPG,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d0c0eca6-c525-4d38-93bc-2220eecf5a69")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerPaymentResult1 : IRetailerPaymentResult1 {
        private CardPaymentServiceType12Code txTpField;
        private CardPaymentServiceType9Code[] addtlSvcField = new CardPaymentServiceType9Code[0];
        private CardPaymentServiceType3Code svcAttrField;
        private bool svcAttrFieldSpecified;
        private CardPaymentTransaction91 reqdTxField = new CardPaymentTransaction91();
        private CardPaymentTransaction84 txRspnField = new CardPaymentTransaction84();
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        private ContentInformationType17 prtctdCaptrdSgntrField = new ContentInformationType17();
        private bool mrchntOvrrdFlgField;
        private bool mrchntOvrrdFlgFieldSpecified;
        private string cstmrLangField;
        private bool onlnFlgField;
        private bool onlnFlgFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public CardPaymentServiceType12Code TxTp {
            get {
                return this.txTpField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.txTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlSvc")]
        public CardPaymentServiceType9Code[] AddtlSvc {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.addtlSvcField == null)
                            || (this.addtlSvcField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.addtlSvcField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlSvcField = value;
            }
        }
        /// <remarks/>
        public CardPaymentServiceType3Code SvcAttr {
            get {
                return this.svcAttrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.svcAttrField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - SvcAttrSpecified = true
                this.SvcAttrSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SvcAttrSpecified {
            get {
                return this.svcAttrFieldSpecified;
            }
            set {
                this.svcAttrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction91 ReqdTx {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.reqdTxField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.reqdTxField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.reqdTxField = new CardPaymentTransaction91();
                }
                else {
                    this.reqdTxField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardPaymentTransaction84 TxRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.txRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.txRspnField = new CardPaymentTransaction84();
                }
                else {
                    this.txRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cstmrOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.cstmrOrdrField = new CustomerOrder1[0];
                }
                else {
                    this.cstmrOrdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CapturedSignature1 ImgCaptrdSgntr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.imgCaptrdSgntrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.imgCaptrdSgntrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.imgCaptrdSgntrField = new CapturedSignature1();
                }
                else {
                    this.imgCaptrdSgntrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType17 PrtctdCaptrdSgntr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.prtctdCaptrdSgntrField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtctdCaptrdSgntrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtctdCaptrdSgntrField = new ContentInformationType17();
                }
                else {
                    this.prtctdCaptrdSgntrField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool MrchntOvrrdFlg {
            get {
                return this.mrchntOvrrdFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.mrchntOvrrdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - MrchntOvrrdFlgSpecified = true
                this.MrchntOvrrdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MrchntOvrrdFlgSpecified {
            get {
                return this.mrchntOvrrdFlgFieldSpecified;
            }
            set {
                this.mrchntOvrrdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cstmrLangField = value;
            }
        }
        /// <remarks/>
        public bool OnlnFlg {
            get {
                return this.onlnFlgField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.onlnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - OnlnFlgSpecified = true
                this.OnlnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlnFlgSpecified {
            get {
                return this.onlnFlgFieldSpecified;
            }
            set {
                this.onlnFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((((((this.XSD_HasBeenSetField || this.ReqdTx.XSD_HasBeenSetProperty)
                            || this.TxRspn.XSD_HasBeenSetProperty)
                            || this.ImgCaptrdSgntr.XSD_HasBeenSetProperty)
                            || this.PrtctdCaptrdSgntr.XSD_HasBeenSetProperty)
                            || this.SvcAttrSpecified)
                            || this.MrchntOvrrdFlgSpecified)
                            || this.OnlnFlgSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.ReqdTx = null;
                    this.TxRspn = null;
                    this.ImgCaptrdSgntr = null;
                    this.PrtctdCaptrdSgntr = null;
                    this.SvcAttrSpecified = false;
                    this.MrchntOvrrdFlgSpecified = false;
                    this.OnlnFlgSpecified = false;
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
                if ((this.ReqdTx != null)) {
                    this.ReqdTx.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.TxRspn != null)) {
                    this.TxRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.ImgCaptrdSgntr != null)) {
                    this.ImgCaptrdSgntr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PrtctdCaptrdSgntr != null)) {
                    this.PrtctdCaptrdSgntr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int AddtlSvcSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.addtlSvcField == null)) {
                return 0;
            }
            else {
                return this.addtlSvcField.Length;
            }
            // END ADDED BY XSD
        }
        public CardPaymentServiceType9Code AddtlSvcGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.addtlSvcField == default(CardPaymentServiceType9Code[]))) {
                    return default(CardPaymentServiceType9Code);
                }
                else {
                    if (((this.addtlSvcField.Length - 1)
                                >= index)) {
                        return this.addtlSvcField[index];
                    }
                    else {
                        return default(CardPaymentServiceType9Code);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CardPaymentServiceType9Code);
            }
            // END ADDED BY XSD
        }
        public bool AddtlSvcSetItem(int index, CardPaymentServiceType9Code value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.addtlSvcField == default(CardPaymentServiceType9Code[]))) {
                    return false;
                }
                else {
                    this.addtlSvcField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlSvcAddItem(CardPaymentServiceType9Code value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.addtlSvcField == default(CardPaymentServiceType9Code[]))) {
                    return false;
                }
                else {
                    CardPaymentServiceType9Code[] array = new CardPaymentServiceType9Code[(this.addtlSvcField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.addtlSvcField.Length); i = (i + 1)) {
                        array[i] = addtlSvcField[i];
                    }
                    array[i] = value;
                    this.AddtlSvc = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlSvcRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.addtlSvcField == default(CardPaymentServiceType9Code[]))) {
                    return false;
                }
                else {
                    if ((this.addtlSvcField.Length <= index)) {
                        return false;
                    }
                    else {
                        CardPaymentServiceType9Code[] array = new CardPaymentServiceType9Code[(this.addtlSvcField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = addtlSvcField[i];
                        }
                        for (i = (i + 1); (i < this.addtlSvcField.Length); i = (i + 1)) {
                            array[i] = addtlSvcField[i];
                        }
                        this.AddtlSvc = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int CstmrOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return default(CustomerOrder1);
                }
                else {
                    if (((this.cstmrOrdrField.Length - 1)
                                >= index)) {
                        return this.cstmrOrdrField[index];
                    }
                    else {
                        return default(CustomerOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CustomerOrder1);
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    this.cstmrOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                        array[i] = cstmrOrdrField[i];
                    }
                    array[i] = value;
                    this.CstmrOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.cstmrOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        this.CstmrOrdr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CardPaymentServiceType12Code {
        /// <remarks/>
        BALC,
        /// <remarks/>
        CACT,
        /// <remarks/>
        CRDP,
        /// <remarks/>
        CAFH,
        /// <remarks/>
        CAVR,
        /// <remarks/>
        CSHW,
        /// <remarks/>
        CSHD,
        /// <remarks/>
        DEFR,
        /// <remarks/>
        LOAD,
        /// <remarks/>
        ORCR,
        /// <remarks/>
        PINC,
        /// <remarks/>
        QUCH,
        /// <remarks/>
        RFND,
        /// <remarks/>
        RESA,
        /// <remarks/>
        VALC,
        /// <remarks/>
        UNLD,
        /// <remarks/>
        CAFT,
        /// <remarks/>
        CAFL,
        /// <remarks/>
        CIDD,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f0741ae7-d9a4-4bcb-86f1-32b0fce08686")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardPaymentTransaction84 : ICardPaymentTransaction84 {
        private AuthorisationResult10 authstnRsltField = new AuthorisationResult10();
        private TransactionVerificationResult4[] txVrfctnRsltField = new TransactionVerificationResult4[0];
        private Product4[] allwdPdctCdField = new Product4[0];
        private Product4[] notAllwdPdctCdField = new Product4[0];
        private Product5[] addtlAvlblPdctField = new Product5[0];
        private AmountAndDirection93 balField = new AmountAndDirection93();
        private ContentInformationType17 prtctdBalField = new ContentInformationType17();
        private Action8[] actnField = new Action8[0];
        private CurrencyConversion14 ccyConvsElgbltyField = new CurrencyConversion14();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public AuthorisationResult10 AuthstnRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.authstnRsltField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.authstnRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.authstnRsltField = new AuthorisationResult10();
                }
                else {
                    this.authstnRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxVrfctnRslt")]
        public TransactionVerificationResult4[] TxVrfctnRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.txVrfctnRsltField == null)
                            || (this.txVrfctnRsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txVrfctnRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.txVrfctnRsltField = new TransactionVerificationResult4[0];
                }
                else {
                    this.txVrfctnRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllwdPdctCd")]
        public Product4[] AllwdPdctCd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.allwdPdctCdField == null)
                            || (this.allwdPdctCdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.allwdPdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.allwdPdctCdField = new Product4[0];
                }
                else {
                    this.allwdPdctCdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotAllwdPdctCd")]
        public Product4[] NotAllwdPdctCd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.notAllwdPdctCdField == null)
                            || (this.notAllwdPdctCdField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.notAllwdPdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.notAllwdPdctCdField = new Product4[0];
                }
                else {
                    this.notAllwdPdctCdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlAvlblPdct")]
        public Product5[] AddtlAvlblPdct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.addtlAvlblPdctField == null)
                            || (this.addtlAvlblPdctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.addtlAvlblPdctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.addtlAvlblPdctField = new Product5[0];
                }
                else {
                    this.addtlAvlblPdctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public AmountAndDirection93 Bal {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.balField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.balField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.balField = new AmountAndDirection93();
                }
                else {
                    this.balField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ContentInformationType17 PrtctdBal {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.prtctdBalField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtctdBalField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtctdBalField = new ContentInformationType17();
                }
                else {
                    this.prtctdBalField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Actn")]
        public Action8[] Actn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.actnField == null)
                            || (this.actnField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.actnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.actnField = new Action8[0];
                }
                else {
                    this.actnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CurrencyConversion14 CcyConvsElgblty {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.ccyConvsElgbltyField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ccyConvsElgbltyField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ccyConvsElgbltyField = new CurrencyConversion14();
                }
                else {
                    this.ccyConvsElgbltyField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.AuthstnRslt.XSD_HasBeenSetProperty)
                            || this.Bal.XSD_HasBeenSetProperty)
                            || this.PrtctdBal.XSD_HasBeenSetProperty)
                            || this.CcyConvsElgblty.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.AuthstnRslt = null;
                    this.Bal = null;
                    this.PrtctdBal = null;
                    this.CcyConvsElgblty = null;
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
                if ((this.AuthstnRslt != null)) {
                    this.AuthstnRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Bal != null)) {
                    this.Bal.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.PrtctdBal != null)) {
                    this.PrtctdBal.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.CcyConvsElgblty != null)) {
                    this.CcyConvsElgblty.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int TxVrfctnRsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.txVrfctnRsltField == null)) {
                return 0;
            }
            else {
                return this.txVrfctnRsltField.Length;
            }
            // END ADDED BY XSD
        }
        public TransactionVerificationResult4 TxVrfctnRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.txVrfctnRsltField == default(TransactionVerificationResult4[]))) {
                    return default(TransactionVerificationResult4);
                }
                else {
                    if (((this.txVrfctnRsltField.Length - 1)
                                >= index)) {
                        return this.txVrfctnRsltField[index];
                    }
                    else {
                        return default(TransactionVerificationResult4);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TransactionVerificationResult4);
            }
            // END ADDED BY XSD
        }
        public bool TxVrfctnRsltSetItem(int index, TransactionVerificationResult4 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.txVrfctnRsltField == default(TransactionVerificationResult4[]))) {
                    return false;
                }
                else {
                    this.txVrfctnRsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxVrfctnRsltAddItem(TransactionVerificationResult4 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.txVrfctnRsltField == default(TransactionVerificationResult4[]))) {
                    return false;
                }
                else {
                    TransactionVerificationResult4[] array = new TransactionVerificationResult4[(this.txVrfctnRsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txVrfctnRsltField.Length); i = (i + 1)) {
                        array[i] = txVrfctnRsltField[i];
                    }
                    array[i] = value;
                    this.TxVrfctnRslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool TxVrfctnRsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.txVrfctnRsltField == default(TransactionVerificationResult4[]))) {
                    return false;
                }
                else {
                    if ((this.txVrfctnRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        TransactionVerificationResult4[] array = new TransactionVerificationResult4[(this.txVrfctnRsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txVrfctnRsltField[i];
                        }
                        for (i = (i + 1); (i < this.txVrfctnRsltField.Length); i = (i + 1)) {
                            array[i] = txVrfctnRsltField[i];
                        }
                        this.TxVrfctnRslt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int AllwdPdctCdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.allwdPdctCdField == null)) {
                return 0;
            }
            else {
                return this.allwdPdctCdField.Length;
            }
            // END ADDED BY XSD
        }
        public Product4 AllwdPdctCdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.allwdPdctCdField == default(Product4[]))) {
                    return default(Product4);
                }
                else {
                    if (((this.allwdPdctCdField.Length - 1)
                                >= index)) {
                        return this.allwdPdctCdField[index];
                    }
                    else {
                        return default(Product4);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Product4);
            }
            // END ADDED BY XSD
        }
        public bool AllwdPdctCdSetItem(int index, Product4 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.allwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    this.allwdPdctCdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AllwdPdctCdAddItem(Product4 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.allwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    Product4[] array = new Product4[(this.allwdPdctCdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.allwdPdctCdField.Length); i = (i + 1)) {
                        array[i] = allwdPdctCdField[i];
                    }
                    array[i] = value;
                    this.AllwdPdctCd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AllwdPdctCdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.allwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    if ((this.allwdPdctCdField.Length <= index)) {
                        return false;
                    }
                    else {
                        Product4[] array = new Product4[(this.allwdPdctCdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = allwdPdctCdField[i];
                        }
                        for (i = (i + 1); (i < this.allwdPdctCdField.Length); i = (i + 1)) {
                            array[i] = allwdPdctCdField[i];
                        }
                        this.AllwdPdctCd = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int NotAllwdPdctCdSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.notAllwdPdctCdField == null)) {
                return 0;
            }
            else {
                return this.notAllwdPdctCdField.Length;
            }
            // END ADDED BY XSD
        }
        public Product4 NotAllwdPdctCdGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.notAllwdPdctCdField == default(Product4[]))) {
                    return default(Product4);
                }
                else {
                    if (((this.notAllwdPdctCdField.Length - 1)
                                >= index)) {
                        return this.notAllwdPdctCdField[index];
                    }
                    else {
                        return default(Product4);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Product4);
            }
            // END ADDED BY XSD
        }
        public bool NotAllwdPdctCdSetItem(int index, Product4 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.notAllwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    this.notAllwdPdctCdField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool NotAllwdPdctCdAddItem(Product4 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.notAllwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    Product4[] array = new Product4[(this.notAllwdPdctCdField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.notAllwdPdctCdField.Length); i = (i + 1)) {
                        array[i] = notAllwdPdctCdField[i];
                    }
                    array[i] = value;
                    this.NotAllwdPdctCd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool NotAllwdPdctCdRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.notAllwdPdctCdField == default(Product4[]))) {
                    return false;
                }
                else {
                    if ((this.notAllwdPdctCdField.Length <= index)) {
                        return false;
                    }
                    else {
                        Product4[] array = new Product4[(this.notAllwdPdctCdField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = notAllwdPdctCdField[i];
                        }
                        for (i = (i + 1); (i < this.notAllwdPdctCdField.Length); i = (i + 1)) {
                            array[i] = notAllwdPdctCdField[i];
                        }
                        this.NotAllwdPdctCd = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int AddtlAvlblPdctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.addtlAvlblPdctField == null)) {
                return 0;
            }
            else {
                return this.addtlAvlblPdctField.Length;
            }
            // END ADDED BY XSD
        }
        public Product5 AddtlAvlblPdctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.addtlAvlblPdctField == default(Product5[]))) {
                    return default(Product5);
                }
                else {
                    if (((this.addtlAvlblPdctField.Length - 1)
                                >= index)) {
                        return this.addtlAvlblPdctField[index];
                    }
                    else {
                        return default(Product5);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Product5);
            }
            // END ADDED BY XSD
        }
        public bool AddtlAvlblPdctSetItem(int index, Product5 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.addtlAvlblPdctField == default(Product5[]))) {
                    return false;
                }
                else {
                    this.addtlAvlblPdctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlAvlblPdctAddItem(Product5 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.addtlAvlblPdctField == default(Product5[]))) {
                    return false;
                }
                else {
                    Product5[] array = new Product5[(this.addtlAvlblPdctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.addtlAvlblPdctField.Length); i = (i + 1)) {
                        array[i] = addtlAvlblPdctField[i];
                    }
                    array[i] = value;
                    this.AddtlAvlblPdct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool AddtlAvlblPdctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.addtlAvlblPdctField == default(Product5[]))) {
                    return false;
                }
                else {
                    if ((this.addtlAvlblPdctField.Length <= index)) {
                        return false;
                    }
                    else {
                        Product5[] array = new Product5[(this.addtlAvlblPdctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = addtlAvlblPdctField[i];
                        }
                        for (i = (i + 1); (i < this.addtlAvlblPdctField.Length); i = (i + 1)) {
                            array[i] = addtlAvlblPdctField[i];
                        }
                        this.AddtlAvlblPdct = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int ActnSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.actnField == null)) {
                return 0;
            }
            else {
                return this.actnField.Length;
            }
            // END ADDED BY XSD
        }
        public Action8 ActnGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.actnField == default(Action8[]))) {
                    return default(Action8);
                }
                else {
                    if (((this.actnField.Length - 1)
                                >= index)) {
                        return this.actnField[index];
                    }
                    else {
                        return default(Action8);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Action8);
            }
            // END ADDED BY XSD
        }
        public bool ActnSetItem(int index, Action8 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.actnField == default(Action8[]))) {
                    return false;
                }
                else {
                    this.actnField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ActnAddItem(Action8 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.actnField == default(Action8[]))) {
                    return false;
                }
                else {
                    Action8[] array = new Action8[(this.actnField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.actnField.Length); i = (i + 1)) {
                        array[i] = actnField[i];
                    }
                    array[i] = value;
                    this.Actn = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ActnRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.actnField == default(Action8[]))) {
                    return false;
                }
                else {
                    if ((this.actnField.Length <= index)) {
                        return false;
                    }
                    else {
                        Action8[] array = new Action8[(this.actnField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = actnField[i];
                        }
                        for (i = (i + 1); (i < this.actnField.Length); i = (i + 1)) {
                            array[i] = actnField[i];
                        }
                        this.Actn = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e0ca5ef3-b470-48f7-8d6d-45d834333b0c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product4 : IProduct4 {
        private string pdctCdField;
        private string addtlPdctCdField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pdctCdField = value;
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlPdctCdField = value;
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c8afada4-747b-445f-a235-6304e66cf4c6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product5 : IProduct5 {
        private string pdctCdField;
        private string addtlPdctCdField;
        private double amtLmtField;
        private bool amtLmtFieldSpecified;
        private double qtyLmtField;
        private bool qtyLmtFieldSpecified;
        private UnitOfMeasure6Code unitOfMeasrField;
        private bool unitOfMeasrFieldSpecified;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pdctCdField = value;
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlPdctCdField = value;
            }
        }
        /// <remarks/>
        public double AmtLmt {
            get {
                return this.amtLmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.amtLmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - AmtLmtSpecified = true
                this.AmtLmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmtLmtSpecified {
            get {
                return this.amtLmtFieldSpecified;
            }
            set {
                this.amtLmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double QtyLmt {
            get {
                return this.qtyLmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.qtyLmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - QtyLmtSpecified = true
                this.QtyLmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyLmtSpecified {
            get {
                return this.qtyLmtFieldSpecified;
            }
            set {
                this.qtyLmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public UnitOfMeasure6Code UnitOfMeasr {
            get {
                return this.unitOfMeasrField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.unitOfMeasrField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - UnitOfMeasrSpecified = true
                this.UnitOfMeasrSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitOfMeasrSpecified {
            get {
                return this.unitOfMeasrFieldSpecified;
            }
            set {
                this.unitOfMeasrFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.AmtLmtSpecified)
                            || this.QtyLmtSpecified)
                            || this.UnitOfMeasrSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.AmtLmtSpecified = false;
                    this.QtyLmtSpecified = false;
                    this.UnitOfMeasrSpecified = false;
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8edfd47f-9890-4095-839d-b2493b0c3ea2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CapturedSignature1 : ICapturedSignature1 {
        private string imgFrmtField;
        private byte[] imgDataField = new byte[0];
        private string imgRefField;
        private string addtlInfField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string ImgFrmt {
            get {
                return this.imgFrmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.imgFrmtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ImgData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.imgDataField == null)
                            || (this.imgDataField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.imgDataField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.imgDataField = value;
            }
        }
        /// <remarks/>
        public string ImgRef {
            get {
                return this.imgRefField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.imgRefField = value;
            }
        }
        /// <remarks/>
        public string AddtlInf {
            get {
                return this.addtlInfField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.addtlInfField = value;
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
        public int ImgDataSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.imgDataField == null)) {
                return 0;
            }
            else {
                return this.imgDataField.Length;
            }
            // END ADDED BY XSD
        }
        public byte ImgDataGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.imgDataField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.imgDataField.Length - 1)
                                >= index)) {
                        return this.imgDataField[index];
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
        public bool ImgDataSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.imgDataField == default(byte[]))) {
                    return false;
                }
                else {
                    this.imgDataField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ImgDataAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.imgDataField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.imgDataField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.imgDataField.Length); i = (i + 1)) {
                        array[i] = imgDataField[i];
                    }
                    array[i] = value;
                    this.ImgData = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool ImgDataRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.imgDataField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.imgDataField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.imgDataField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = imgDataField[i];
                        }
                        for (i = (i + 1); (i < this.imgDataField.Length); i = (i + 1)) {
                            array[i] = imgDataField[i];
                        }
                        this.ImgData = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3e3872c9-f520-4b8d-9ba8-8651a8fddc26")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResult1 : ILoyaltyResult1 {
        private LoyaltyAccount1 acctField = new LoyaltyAccount1();
        private LoyaltyAmount1 amtField = new LoyaltyAmount1();
        private LoyaltyServerData1 svrDataField = new LoyaltyServerData1();
        private LoyaltyRebates1 rbtsField = new LoyaltyRebates1();
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public LoyaltyAccount1 Acct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.acctField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.acctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.acctField = new LoyaltyAccount1();
                }
                else {
                    this.acctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyAmount1 Amt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.amtField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.amtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.amtField = new LoyaltyAmount1();
                }
                else {
                    this.amtField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyServerData1 SvrData {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.svrDataField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.svrDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.svrDataField = new LoyaltyServerData1();
                }
                else {
                    this.svrDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyRebates1 Rbts {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rbtsField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rbtsField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rbtsField = new LoyaltyRebates1();
                }
                else {
                    this.rbtsField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.Acct.XSD_HasBeenSetProperty)
                            || this.Amt.XSD_HasBeenSetProperty)
                            || this.SvrData.XSD_HasBeenSetProperty)
                            || this.Rbts.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Acct = null;
                    this.Amt = null;
                    this.SvrData = null;
                    this.Rbts = null;
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
                if ((this.Acct != null)) {
                    this.Acct.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Amt != null)) {
                    this.Amt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SvrData != null)) {
                    this.SvrData.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Rbts != null)) {
                    this.Rbts.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4ce81daf-037d-4342-99cd-9c500647b699")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyServerData1 : ILoyaltyServerData1 {
        private string lltySvrIdField;
        private string apprvlCdField;
        private TransactionIdentifier1 lltyTxIdField = new TransactionIdentifier1();
        private string hstRcncltnIdField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string LltySvrId {
            get {
                return this.lltySvrIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.lltySvrIdField = value;
            }
        }
        /// <remarks/>
        public string ApprvlCd {
            get {
                return this.apprvlCdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.apprvlCdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 LltyTxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.lltyTxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyTxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lltyTxIdField = new TransactionIdentifier1();
                }
                else {
                    this.lltyTxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string HstRcncltnId {
            get {
                return this.hstRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.hstRcncltnIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.LltyTxId.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.LltyTxId = null;
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
                if ((this.LltyTxId != null)) {
                    this.LltyTxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("efc66078-0ca5-46bc-a2db-650e9319bfe6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyRebates1 : ILoyaltyRebates1 {
        private double ttlRbtField;
        private bool ttlRbtFieldSpecified;
        private string rbtLablField;
        private SaleItemRebate1[] saleItmRbtField = new SaleItemRebate1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public double TtlRbt {
            get {
                return this.ttlRbtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.ttlRbtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - TtlRbtSpecified = true
                this.TtlRbtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlRbtSpecified {
            get {
                return this.ttlRbtFieldSpecified;
            }
            set {
                this.ttlRbtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string RbtLabl {
            get {
                return this.rbtLablField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rbtLablField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleItmRbt")]
        public SaleItemRebate1[] SaleItmRbt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.saleItmRbtField == null)
                            || (this.saleItmRbtField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleItmRbtField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.saleItmRbtField = new SaleItemRebate1[0];
                }
                else {
                    this.saleItmRbtField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.TtlRbtSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.TtlRbtSpecified = false;
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
        public int SaleItmRbtSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.saleItmRbtField == null)) {
                return 0;
            }
            else {
                return this.saleItmRbtField.Length;
            }
            // END ADDED BY XSD
        }
        public SaleItemRebate1 SaleItmRbtGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.saleItmRbtField == default(SaleItemRebate1[]))) {
                    return default(SaleItemRebate1);
                }
                else {
                    if (((this.saleItmRbtField.Length - 1)
                                >= index)) {
                        return this.saleItmRbtField[index];
                    }
                    else {
                        return default(SaleItemRebate1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(SaleItemRebate1);
            }
            // END ADDED BY XSD
        }
        public bool SaleItmRbtSetItem(int index, SaleItemRebate1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.saleItmRbtField == default(SaleItemRebate1[]))) {
                    return false;
                }
                else {
                    this.saleItmRbtField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SaleItmRbtAddItem(SaleItemRebate1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.saleItmRbtField == default(SaleItemRebate1[]))) {
                    return false;
                }
                else {
                    SaleItemRebate1[] array = new SaleItemRebate1[(this.saleItmRbtField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.saleItmRbtField.Length); i = (i + 1)) {
                        array[i] = saleItmRbtField[i];
                    }
                    array[i] = value;
                    this.SaleItmRbt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool SaleItmRbtRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.saleItmRbtField == default(SaleItemRebate1[]))) {
                    return false;
                }
                else {
                    if ((this.saleItmRbtField.Length <= index)) {
                        return false;
                    }
                    else {
                        SaleItemRebate1[] array = new SaleItemRebate1[(this.saleItmRbtField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = saleItmRbtField[i];
                        }
                        for (i = (i + 1); (i < this.saleItmRbtField.Length); i = (i + 1)) {
                            array[i] = saleItmRbtField[i];
                        }
                        this.SaleItmRbt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("39a7d9cc-98f3-482f-bf30-f38f1a184fb7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleItemRebate1 : ISaleItemRebate1 {
        private Product6 saleItmField = new Product6();
        private string rbtLablField;
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public Product6 SaleItm {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.saleItmField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleItmField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleItmField = new Product6();
                }
                else {
                    this.saleItmField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string RbtLabl {
            get {
                return this.rbtLablField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rbtLablField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.SaleItm.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SaleItm = null;
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
                if ((this.SaleItm != null)) {
                    this.SaleItm.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d18b6695-6928-47bd-b5c2-a307d786f341")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardAcquisitionResponse1 : ICardAcquisitionResponse1 {
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string[] pmtBrndField = new string[0];
        private string cstmrLangField;
        private LoyaltyAccount1[] lltyAcctField = new LoyaltyAccount1[0];
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtBrnd")]
        public string[] PmtBrnd {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.pmtBrndField == null)
                            || (this.pmtBrndField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtBrndField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pmtBrndField = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.cstmrLangField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyAcct")]
        public LoyaltyAccount1[] LltyAcct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.lltyAcctField == null)
                            || (this.lltyAcctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.lltyAcctField = new LoyaltyAccount1[0];
                }
                else {
                    this.lltyAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cstmrOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.cstmrOrdrField = new CustomerOrder1[0];
                }
                else {
                    this.cstmrOrdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.POITxId.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.POITxId = null;
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
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int PmtBrndSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.pmtBrndField == null)) {
                return 0;
            }
            else {
                return this.pmtBrndField.Length;
            }
            // END ADDED BY XSD
        }
        public string PmtBrndGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.pmtBrndField == default(string[]))) {
                    return default(string);
                }
                else {
                    if (((this.pmtBrndField.Length - 1)
                                >= index)) {
                        return this.pmtBrndField[index];
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
        public bool PmtBrndSetItem(int index, string value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.pmtBrndField == default(string[]))) {
                    return false;
                }
                else {
                    this.pmtBrndField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PmtBrndAddItem(string value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.pmtBrndField == default(string[]))) {
                    return false;
                }
                else {
                    string[] array = new string[(this.pmtBrndField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.pmtBrndField.Length); i = (i + 1)) {
                        array[i] = pmtBrndField[i];
                    }
                    array[i] = value;
                    this.PmtBrnd = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PmtBrndRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.pmtBrndField == default(string[]))) {
                    return false;
                }
                else {
                    if ((this.pmtBrndField.Length <= index)) {
                        return false;
                    }
                    else {
                        string[] array = new string[(this.pmtBrndField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = pmtBrndField[i];
                        }
                        for (i = (i + 1); (i < this.pmtBrndField.Length); i = (i + 1)) {
                            array[i] = pmtBrndField[i];
                        }
                        this.PmtBrnd = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int LltyAcctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.lltyAcctField == null)) {
                return 0;
            }
            else {
                return this.lltyAcctField.Length;
            }
            // END ADDED BY XSD
        }
        public LoyaltyAccount1 LltyAcctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount1[]))) {
                    return default(LoyaltyAccount1);
                }
                else {
                    if (((this.lltyAcctField.Length - 1)
                                >= index)) {
                        return this.lltyAcctField[index];
                    }
                    else {
                        return default(LoyaltyAccount1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyAccount1);
            }
            // END ADDED BY XSD
        }
        public bool LltyAcctSetItem(int index, LoyaltyAccount1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount1[]))) {
                    return false;
                }
                else {
                    this.lltyAcctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyAcctAddItem(LoyaltyAccount1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount1[]))) {
                    return false;
                }
                else {
                    LoyaltyAccount1[] array = new LoyaltyAccount1[(this.lltyAcctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.lltyAcctField.Length); i = (i + 1)) {
                        array[i] = lltyAcctField[i];
                    }
                    array[i] = value;
                    this.LltyAcct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyAcctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount1[]))) {
                    return false;
                }
                else {
                    if ((this.lltyAcctField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyAccount1[] array = new LoyaltyAccount1[(this.lltyAcctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = lltyAcctField[i];
                        }
                        for (i = (i + 1); (i < this.lltyAcctField.Length); i = (i + 1)) {
                            array[i] = lltyAcctField[i];
                        }
                        this.LltyAcct = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int CstmrOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return default(CustomerOrder1);
                }
                else {
                    if (((this.cstmrOrdrField.Length - 1)
                                >= index)) {
                        return this.cstmrOrdrField[index];
                    }
                    else {
                        return default(CustomerOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CustomerOrder1);
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    this.cstmrOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                        array[i] = cstmrOrdrField[i];
                    }
                    array[i] = value;
                    this.CstmrOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.cstmrOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        this.CstmrOrdr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("12808218-5b00-4dae-a489-09fd23cae923")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIServiceResponseV01 : ISaleToPOIServiceResponseV01 {
        private Header37 hdrField = new Header37();
        private ServiceResponse2 svcRspnField = new ServiceResponse2();
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
        public ServiceResponse2 SvcRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.svcRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.svcRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.svcRspnField = new ServiceResponse2();
                }
                else {
                    this.svcRspnField = value;
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
                            || this.SvcRspn.XSD_HasBeenSetProperty)
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
                    this.SvcRspn = null;
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
                if ((this.SvcRspn != null)) {
                    this.SvcRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.SctyTrlr != null)) {
                    this.SctyTrlr.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("28a6528a-40e1-4bcc-ab8c-bd879e8b6ed2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServiceResponse2 : IServiceResponse2 {
        private CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        private CardPaymentContext27 cntxtField = new CardPaymentContext27();
        private RetailerService3Code svcCnttField;
        private PaymentResponse1 pmtRspnField = new PaymentResponse1();
        private ReversalResponse1 rvslRspnField = new ReversalResponse1();
        private BalanceInquiryResponse1 balNqryRspnField = new BalanceInquiryResponse1();
        private LoyaltyResponse1 lltyRspnField = new LoyaltyResponse1();
        private StoredValueResponse2 stordValRspnField = new StoredValueResponse2();
        private PerformedTransaction1[] btchRspnField = new PerformedTransaction1[0];
        private CardAcquisitionResponse1 cardAcqstnRspnField = new CardAcquisitionResponse1();
        private ResponseType9 rspnField = new ResponseType9();
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
        public RetailerService3Code SvcCntt {
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
        public PaymentResponse1 PmtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pmtRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtRspnField = new PaymentResponse1();
                }
                else {
                    this.pmtRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ReversalResponse1 RvslRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rvslRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rvslRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rvslRspnField = new ReversalResponse1();
                }
                else {
                    this.rvslRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public BalanceInquiryResponse1 BalNqryRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.balNqryRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.balNqryRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.balNqryRspnField = new BalanceInquiryResponse1();
                }
                else {
                    this.balNqryRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyResponse1 LltyRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.lltyRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lltyRspnField = new LoyaltyResponse1();
                }
                else {
                    this.lltyRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public StoredValueResponse2 StordValRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.stordValRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.stordValRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.stordValRspnField = new StoredValueResponse2();
                }
                else {
                    this.stordValRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PrfrmdTx", IsNullable=false)]
        public PerformedTransaction1[] BtchRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.btchRspnField == null)
                            || (this.btchRspnField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.btchRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.btchRspnField = new PerformedTransaction1[0];
                }
                else {
                    this.btchRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardAcquisitionResponse1 CardAcqstnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.cardAcqstnRspnField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cardAcqstnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cardAcqstnRspnField = new CardAcquisitionResponse1();
                }
                else {
                    this.cardAcqstnRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rspnField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((this.XSD_HasBeenSetField || this.Envt.XSD_HasBeenSetProperty)
                            || this.Cntxt.XSD_HasBeenSetProperty)
                            || this.PmtRspn.XSD_HasBeenSetProperty)
                            || this.RvslRspn.XSD_HasBeenSetProperty)
                            || this.BalNqryRspn.XSD_HasBeenSetProperty)
                            || this.LltyRspn.XSD_HasBeenSetProperty)
                            || this.StordValRspn.XSD_HasBeenSetProperty)
                            || this.CardAcqstnRspn.XSD_HasBeenSetProperty)
                            || this.Rspn.XSD_HasBeenSetProperty);
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
                    this.PmtRspn = null;
                    this.RvslRspn = null;
                    this.BalNqryRspn = null;
                    this.LltyRspn = null;
                    this.StordValRspn = null;
                    this.CardAcqstnRspn = null;
                    this.Rspn = null;
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
                if ((this.PmtRspn != null)) {
                    this.PmtRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.RvslRspn != null)) {
                    this.RvslRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.BalNqryRspn != null)) {
                    this.BalNqryRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.LltyRspn != null)) {
                    this.LltyRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.StordValRspn != null)) {
                    this.StordValRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.CardAcqstnRspn != null)) {
                    this.CardAcqstnRspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int BtchRspnSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.btchRspnField == null)) {
                return 0;
            }
            else {
                return this.btchRspnField.Length;
            }
            // END ADDED BY XSD
        }
        public PerformedTransaction1 BtchRspnGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction1[]))) {
                    return default(PerformedTransaction1);
                }
                else {
                    if (((this.btchRspnField.Length - 1)
                                >= index)) {
                        return this.btchRspnField[index];
                    }
                    else {
                        return default(PerformedTransaction1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PerformedTransaction1);
            }
            // END ADDED BY XSD
        }
        public bool BtchRspnSetItem(int index, PerformedTransaction1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    this.btchRspnField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool BtchRspnAddItem(PerformedTransaction1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    PerformedTransaction1[] array = new PerformedTransaction1[(this.btchRspnField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.btchRspnField.Length); i = (i + 1)) {
                        array[i] = btchRspnField[i];
                    }
                    array[i] = value;
                    this.BtchRspn = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool BtchRspnRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction1[]))) {
                    return false;
                }
                else {
                    if ((this.btchRspnField.Length <= index)) {
                        return false;
                    }
                    else {
                        PerformedTransaction1[] array = new PerformedTransaction1[(this.btchRspnField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = btchRspnField[i];
                        }
                        for (i = (i + 1); (i < this.btchRspnField.Length); i = (i + 1)) {
                            array[i] = btchRspnField[i];
                        }
                        this.BtchRspn = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService3Code {
        /// <remarks/>
        FSPP,
        /// <remarks/>
        FSRP,
        /// <remarks/>
        FSIP,
        /// <remarks/>
        FSBP,
        /// <remarks/>
        FSLP,
        /// <remarks/>
        FSVP,
        /// <remarks/>
        FSEP,
        /// <remarks/>
        FSAP,
        /// <remarks/>
        FSCP,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3496b2df-9a2e-4739-ae7e-339419398801")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentResponse1 : IPaymentResponse1 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private string saleRefIdField;
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField;
        private string issrRefDataField;
        private RetailerPaymentResult1 rtlrPmtRsltField = new RetailerPaymentResult1();
        private PaymentReceipt1[] pmtRctField = new PaymentReceipt1[0];
        private LoyaltyResult1[] lltyRsltField = new LoyaltyResult1[0];
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.saleTxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleTxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleTxIdField = new TransactionIdentifier1();
                }
                else {
                    this.saleTxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string SaleRefId {
            get {
                return this.saleRefIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.saleRefIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.issrRefDataField = value;
            }
        }
        /// <remarks/>
        public RetailerPaymentResult1 RtlrPmtRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rtlrPmtRsltField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rtlrPmtRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rtlrPmtRsltField = new RetailerPaymentResult1();
                }
                else {
                    this.rtlrPmtRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtRct")]
        public PaymentReceipt1[] PmtRct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.pmtRctField == null)
                            || (this.pmtRctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.pmtRctField = new PaymentReceipt1[0];
                }
                else {
                    this.pmtRctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult1[] LltyRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.lltyRsltField == null)
                            || (this.lltyRsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.lltyRsltField = new LoyaltyResult1[0];
                }
                else {
                    this.lltyRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cstmrOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.cstmrOrdrField = new CustomerOrder1[0];
                }
                else {
                    this.cstmrOrdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (((this.XSD_HasBeenSetField || this.SaleTxId.XSD_HasBeenSetProperty)
                            || this.POITxId.XSD_HasBeenSetProperty)
                            || this.RtlrPmtRslt.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SaleTxId = null;
                    this.POITxId = null;
                    this.RtlrPmtRslt = null;
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.RtlrPmtRslt != null)) {
                    this.RtlrPmtRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int PmtRctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.pmtRctField == null)) {
                return 0;
            }
            else {
                return this.pmtRctField.Length;
            }
            // END ADDED BY XSD
        }
        public PaymentReceipt1 PmtRctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt1[]))) {
                    return default(PaymentReceipt1);
                }
                else {
                    if (((this.pmtRctField.Length - 1)
                                >= index)) {
                        return this.pmtRctField[index];
                    }
                    else {
                        return default(PaymentReceipt1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt1);
            }
            // END ADDED BY XSD
        }
        public bool PmtRctSetItem(int index, PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    this.pmtRctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PmtRctAddItem(PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    PaymentReceipt1[] array = new PaymentReceipt1[(this.pmtRctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.pmtRctField.Length); i = (i + 1)) {
                        array[i] = pmtRctField[i];
                    }
                    array[i] = value;
                    this.PmtRct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool PmtRctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    if ((this.pmtRctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt1[] array = new PaymentReceipt1[(this.pmtRctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = pmtRctField[i];
                        }
                        for (i = (i + 1); (i < this.pmtRctField.Length); i = (i + 1)) {
                            array[i] = pmtRctField[i];
                        }
                        this.PmtRct = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int LltyRsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.lltyRsltField == null)) {
                return 0;
            }
            else {
                return this.lltyRsltField.Length;
            }
            // END ADDED BY XSD
        }
        public LoyaltyResult1 LltyRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return default(LoyaltyResult1);
                }
                else {
                    if (((this.lltyRsltField.Length - 1)
                                >= index)) {
                        return this.lltyRsltField[index];
                    }
                    else {
                        return default(LoyaltyResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult1);
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    this.lltyRsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltAddItem(LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    LoyaltyResult1[] array = new LoyaltyResult1[(this.lltyRsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.lltyRsltField.Length); i = (i + 1)) {
                        array[i] = lltyRsltField[i];
                    }
                    array[i] = value;
                    this.LltyRslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    if ((this.lltyRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult1[] array = new LoyaltyResult1[(this.lltyRsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = lltyRsltField[i];
                        }
                        for (i = (i + 1); (i < this.lltyRsltField.Length); i = (i + 1)) {
                            array[i] = lltyRsltField[i];
                        }
                        this.LltyRslt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int CstmrOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return default(CustomerOrder1);
                }
                else {
                    if (((this.cstmrOrdrField.Length - 1)
                                >= index)) {
                        return this.cstmrOrdrField[index];
                    }
                    else {
                        return default(CustomerOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CustomerOrder1);
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    this.cstmrOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                        array[i] = cstmrOrdrField[i];
                    }
                    array[i] = value;
                    this.CstmrOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.cstmrOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        this.CstmrOrdr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8769ecd7-1baf-4f21-957b-bc70c8d39a2f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReversalResponse1 : IReversalResponse1 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private string saleRefIdField;
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField;
        private string issrRefDataField;
        private RetailerReversalResult1 rvslTxRsltField = new RetailerReversalResult1();
        private double rvsdAmtField;
        private bool rvsdAmtFieldSpecified;
        private PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.saleTxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleTxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleTxIdField = new TransactionIdentifier1();
                }
                else {
                    this.saleTxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string SaleRefId {
            get {
                return this.saleRefIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.saleRefIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.issrRefDataField = value;
            }
        }
        /// <remarks/>
        public RetailerReversalResult1 RvslTxRslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rvslTxRsltField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rvslTxRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rvslTxRsltField = new RetailerReversalResult1();
                }
                else {
                    this.rvslTxRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double RvsdAmt {
            get {
                return this.rvsdAmtField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rvsdAmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value may have been changed - RvsdAmtSpecified = true
                this.RvsdAmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RvsdAmtSpecified {
            get {
                return this.rvsdAmtFieldSpecified;
            }
            set {
                this.rvsdAmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rctField = new PaymentReceipt1[0];
                }
                else {
                    this.rctField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((((this.XSD_HasBeenSetField || this.SaleTxId.XSD_HasBeenSetProperty)
                            || this.POITxId.XSD_HasBeenSetProperty)
                            || this.RvslTxRslt.XSD_HasBeenSetProperty)
                            || this.RvsdAmtSpecified);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SaleTxId = null;
                    this.POITxId = null;
                    this.RvslTxRslt = null;
                    this.RvsdAmtSpecified = false;
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.RvslTxRslt != null)) {
                    this.RvslTxRslt.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int RctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
            // END ADDED BY XSD
        }
        public PaymentReceipt1 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return default(PaymentReceipt1);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt1);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    this.rctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctAddItem(PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rctField.Length); i = (i + 1)) {
                        array[i] = rctField[i];
                    }
                    array[i] = value;
                    this.Rct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        for (i = (i + 1); (i < this.rctField.Length); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        this.Rct = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e25164f3-da7f-42bb-872d-ef9a05fedac5")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerReversalResult1 : IRetailerReversalResult1 {
        private string pOIRcncltnIdField;
        private CardPaymentTransaction91 orgnlPmtTxField = new CardPaymentTransaction91();
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction91 OrgnlPmtTx {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.orgnlPmtTxField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.orgnlPmtTxField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.orgnlPmtTxField = new CardPaymentTransaction91();
                }
                else {
                    this.orgnlPmtTxField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cstmrOrdrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.cstmrOrdrField = new CustomerOrder1[0];
                }
                else {
                    this.cstmrOrdrField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.OrgnlPmtTx.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.OrgnlPmtTx = null;
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
                if ((this.OrgnlPmtTx != null)) {
                    this.OrgnlPmtTx.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int CstmrOrdrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
            // END ADDED BY XSD
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return default(CustomerOrder1);
                }
                else {
                    if (((this.cstmrOrdrField.Length - 1)
                                >= index)) {
                        return this.cstmrOrdrField[index];
                    }
                    else {
                        return default(CustomerOrder1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(CustomerOrder1);
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    this.cstmrOrdrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                        array[i] = cstmrOrdrField[i];
                    }
                    array[i] = value;
                    this.CstmrOrdr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool CstmrOrdrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.cstmrOrdrField == default(CustomerOrder1[]))) {
                    return false;
                }
                else {
                    if ((this.cstmrOrdrField.Length <= index)) {
                        return false;
                    }
                    else {
                        CustomerOrder1[] array = new CustomerOrder1[(this.cstmrOrdrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        for (i = (i + 1); (i < this.cstmrOrdrField.Length); i = (i + 1)) {
                            array[i] = cstmrOrdrField[i];
                        }
                        this.CstmrOrdr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("63965224-ce6c-4aa6-99ae-77e3feac0aa1")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResponse1 : ILoyaltyResponse1 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField;
        private LoyaltyResult1[] rsltField = new LoyaltyResult1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.saleTxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.saleTxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.saleTxIdField = new TransactionIdentifier1();
                }
                else {
                    this.saleTxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rslt")]
        public LoyaltyResult1[] Rslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rsltField == null)
                            || (this.rsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rsltField = new LoyaltyResult1[0];
                }
                else {
                    this.rsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.SaleTxId.XSD_HasBeenSetProperty)
                            || this.POITxId.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.SaleTxId = null;
                    this.POITxId = null;
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int RsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rsltField == null)) {
                return 0;
            }
            else {
                return this.rsltField.Length;
            }
            // END ADDED BY XSD
        }
        public LoyaltyResult1 RsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult1[]))) {
                    return default(LoyaltyResult1);
                }
                else {
                    if (((this.rsltField.Length - 1)
                                >= index)) {
                        return this.rsltField[index];
                    }
                    else {
                        return default(LoyaltyResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult1);
            }
            // END ADDED BY XSD
        }
        public bool RsltSetItem(int index, LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    this.rsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RsltAddItem(LoyaltyResult1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    LoyaltyResult1[] array = new LoyaltyResult1[(this.rsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rsltField.Length); i = (i + 1)) {
                        array[i] = rsltField[i];
                    }
                    array[i] = value;
                    this.Rslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult1[]))) {
                    return false;
                }
                else {
                    if ((this.rsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult1[] array = new LoyaltyResult1[(this.rsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rsltField[i];
                        }
                        for (i = (i + 1); (i < this.rsltField.Length); i = (i + 1)) {
                            array[i] = rsltField[i];
                        }
                        this.Rslt = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d2460470-68d1-45b7-90c2-bbc49c482f68")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StoredValueResponse2 : IStoredValueResponse2 {
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private StoredValueData2[] rsltField = new StoredValueData2[0];
        private PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.pOITxIdField.XSD_HasBeenSetProperty == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pOITxIdField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pOITxIdField = new TransactionIdentifier1();
                }
                else {
                    this.pOITxIdField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rslt")]
        public StoredValueData2[] Rslt {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rsltField == null)
                            || (this.rsltField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rsltField = new StoredValueData2[0];
                }
                else {
                    this.rsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.rctField = new PaymentReceipt1[0];
                }
                else {
                    this.rctField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return (this.XSD_HasBeenSetField || this.POITxId.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.POITxId = null;
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
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
        public int RsltSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rsltField == null)) {
                return 0;
            }
            else {
                return this.rsltField.Length;
            }
            // END ADDED BY XSD
        }
        public StoredValueData2 RsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rsltField == default(StoredValueData2[]))) {
                    return default(StoredValueData2);
                }
                else {
                    if (((this.rsltField.Length - 1)
                                >= index)) {
                        return this.rsltField[index];
                    }
                    else {
                        return default(StoredValueData2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(StoredValueData2);
            }
            // END ADDED BY XSD
        }
        public bool RsltSetItem(int index, StoredValueData2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rsltField == default(StoredValueData2[]))) {
                    return false;
                }
                else {
                    this.rsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RsltAddItem(StoredValueData2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rsltField == default(StoredValueData2[]))) {
                    return false;
                }
                else {
                    StoredValueData2[] array = new StoredValueData2[(this.rsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rsltField.Length); i = (i + 1)) {
                        array[i] = rsltField[i];
                    }
                    array[i] = value;
                    this.Rslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RsltRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rsltField == default(StoredValueData2[]))) {
                    return false;
                }
                else {
                    if ((this.rsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        StoredValueData2[] array = new StoredValueData2[(this.rsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rsltField[i];
                        }
                        for (i = (i + 1); (i < this.rsltField.Length); i = (i + 1)) {
                            array[i] = rsltField[i];
                        }
                        this.Rslt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public int RctSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
            // END ADDED BY XSD
        }
        public PaymentReceipt1 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return default(PaymentReceipt1);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt1);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    this.rctField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctAddItem(PaymentReceipt1 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rctField.Length); i = (i + 1)) {
                        array[i] = rctField[i];
                    }
                    array[i] = value;
                    this.Rct = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool RctRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt1[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt1[] array = new PaymentReceipt1[(this.rctField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        for (i = (i + 1); (i < this.rctField.Length); i = (i + 1)) {
                            array[i] = rctField[i];
                        }
                        this.Rct = array;
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
    [System.Runtime.InteropServices.GuidAttribute("d2ff3f23-05d8-41da-8a18-dd6946fcb28c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAction8 {
        /// <remarks/>
        [DispId(1)]
        ActionType7Code ActnTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ActionMessage2 MsgToPres {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("aadefd70-4b5c-439e-ae72-b2bc0e105833")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IActionMessage2 {
        /// <remarks/>
        [DispId(1)]
        UserInterface4Code MsgDstn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        OutputFormat1Code Frmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool FrmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string MsgCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] MsgCnttSgntr {
            get;
            set;
        }
        [DispId(6)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(7)]
        int MsgCnttSgntrSize();
        [DispId(8)]
        byte MsgCnttSgntrGetItem(int index);
        [DispId(9)]
        bool MsgCnttSgntrSetItem(int index, byte value);
        [DispId(10)]
        bool MsgCnttSgntrAddItem(byte value);
        [DispId(11)]
        bool MsgCnttSgntrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("d0d629e7-43de-4008-9794-2f93b50a6d36")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAmountAndDirection93 {
        /// <remarks/>
        [DispId(1)]
        double Amt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool Sgn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool SgnSpecified {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("bb57721c-bcc1-4f54-8db2-58135611b5f2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAuthorisationResult10 {
        /// <remarks/>
        [DispId(1)]
        GenericIdentification90 AuthstnNtty {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ResponseType5 RspnToAuthstn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string AuthstnCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool CmpltnReqrd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool CmpltnReqrdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        TMSTrigger1 TMSTrggr {
            get;
            set;
        }
        [DispId(7)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("468905a5-57f4-4940-8530-281f68962d63")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IGenericIdentification90 {
        /// <remarks/>
        [DispId(1)]
        string Id {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        PartyType14Code Tp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PartyType4Code Issr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool IssrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string Ctry {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        string ShrtNm {
            get;
            set;
        }
        [DispId(7)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6afdcb11-4623-4874-a7a9-5b1c259ea1e2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IResponseType5 {
        /// <remarks/>
        [DispId(1)]
        Response4Code Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string RspnRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string AddtlRspnInf {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4a9e9003-c8b7-435f-bc9b-87597cd2b005")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSTrigger1 {
        /// <remarks/>
        [DispId(1)]
        TMSContactLevel1Code TMSCtctLvl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string TMSId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string TMSCtctDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool TMSCtctDtTmSpecified {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("17dea412-976e-45fd-b4ba-fa7d1119ab5e")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IBalanceInquiryResponse1 {
        /// <remarks/>
        [DispId(1)]
        PaymentAccount2 PmtAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        LoyaltyAccount1 LltyAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        StoredValueAccount1[] StordValAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(6)]
        int StordValAcctSize();
        [DispId(7)]
        StoredValueAccount1 StordValAcctGetItem(int index);
        [DispId(8)]
        bool StordValAcctSetItem(int index, StoredValueAccount1 value);
        [DispId(9)]
        bool StordValAcctAddItem(StoredValueAccount1 value);
        [DispId(10)]
        bool StordValAcctRemoveItem(int index);
        [DispId(11)]
        int RctSize();
        [DispId(12)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(13)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(14)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(15)]
        bool RctRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("ae56e41d-ad63-4e30-9426-71d31a1bbecb")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentAccount2 {
        /// <remarks/>
        [DispId(1)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        double CurBal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool CurBalSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        Acquirer9 PmtAcqrrData {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("aebbf1aa-3349-456c-940d-e67a265c279b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentReceipt1 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool IntgrtdPrtFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool IntgrtdPrtFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool ReqrdSgntrFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool ReqrdSgntrFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(7)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("24c2777e-8dce-45a6-9181-628fb784debe")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IBatchResponse1 {
        /// <remarks/>
        [DispId(1)]
        PerformedTransaction1[] PrfrmdTx {
            get;
            set;
        }
        [DispId(2)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(3)]
        int PrfrmdTxSize();
        [DispId(4)]
        PerformedTransaction1 PrfrmdTxGetItem(int index);
        [DispId(5)]
        bool PrfrmdTxSetItem(int index, PerformedTransaction1 value);
        [DispId(6)]
        bool PrfrmdTxAddItem(PerformedTransaction1 value);
        [DispId(7)]
        bool PrfrmdTxRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("e107991b-bfca-462c-a886-51a065c7d884")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPerformedTransaction1 {
        /// <remarks/>
        [DispId(1)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        TransactionIdentifier1 SaleTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        RetailerPaymentResult1 PmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        LoyaltyResult1[] LltyRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        double RvsdAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        bool RvsdAmtSpecified {
            get;
            set;
        }
        [DispId(9)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(10)]
        int LltyRsltSize();
        [DispId(11)]
        LoyaltyResult1 LltyRsltGetItem(int index);
        [DispId(12)]
        bool LltyRsltSetItem(int index, LoyaltyResult1 value);
        [DispId(13)]
        bool LltyRsltAddItem(LoyaltyResult1 value);
        [DispId(14)]
        bool LltyRsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("a5794b7f-b8aa-4e13-b30d-412e43c7b4ff")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IResponseType9 {
        /// <remarks/>
        [DispId(1)]
        Response5Code Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        RetailerResultDetail1Code RspnRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool RspnRsnSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string AddtlRspnInf {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0d532241-c603-4eca-a542-21ed66a5ec49")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerPaymentResult1 {
        /// <remarks/>
        [DispId(1)]
        CardPaymentServiceType12Code TxTp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentServiceType9Code[] AddtlSvc {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        CardPaymentServiceType3Code SvcAttr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool SvcAttrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CardPaymentTransaction91 ReqdTx {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        CardPaymentTransaction84 TxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        CapturedSignature1 ImgCaptrdSgntr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        ContentInformationType17 PrtctdCaptrdSgntr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        bool MrchntOvrrdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool MrchntOvrrdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(12)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        bool OnlnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(14)]
        bool OnlnFlgSpecified {
            get;
            set;
        }
        [DispId(15)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(16)]
        int AddtlSvcSize();
        [DispId(17)]
        CardPaymentServiceType9Code AddtlSvcGetItem(int index);
        [DispId(18)]
        bool AddtlSvcSetItem(int index, CardPaymentServiceType9Code value);
        [DispId(19)]
        bool AddtlSvcAddItem(CardPaymentServiceType9Code value);
        [DispId(20)]
        bool AddtlSvcRemoveItem(int index);
        [DispId(21)]
        int CstmrOrdrSize();
        [DispId(22)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(23)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(24)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(25)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("a1c711b2-2097-443e-9408-346f88666236")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICardPaymentTransaction84 {
        /// <remarks/>
        [DispId(1)]
        AuthorisationResult10 AuthstnRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        TransactionVerificationResult4[] TxVrfctnRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        Product4[] AllwdPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        Product4[] NotAllwdPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        Product5[] AddtlAvlblPdct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        AmountAndDirection93 Bal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ContentInformationType17 PrtctdBal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        Action8[] Actn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        CurrencyConversion14 CcyConvsElgblty {
            get;
            set;
        }
        [DispId(10)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(11)]
        int TxVrfctnRsltSize();
        [DispId(12)]
        TransactionVerificationResult4 TxVrfctnRsltGetItem(int index);
        [DispId(13)]
        bool TxVrfctnRsltSetItem(int index, TransactionVerificationResult4 value);
        [DispId(14)]
        bool TxVrfctnRsltAddItem(TransactionVerificationResult4 value);
        [DispId(15)]
        bool TxVrfctnRsltRemoveItem(int index);
        [DispId(16)]
        int AllwdPdctCdSize();
        [DispId(17)]
        Product4 AllwdPdctCdGetItem(int index);
        [DispId(18)]
        bool AllwdPdctCdSetItem(int index, Product4 value);
        [DispId(19)]
        bool AllwdPdctCdAddItem(Product4 value);
        [DispId(20)]
        bool AllwdPdctCdRemoveItem(int index);
        [DispId(21)]
        int NotAllwdPdctCdSize();
        [DispId(22)]
        Product4 NotAllwdPdctCdGetItem(int index);
        [DispId(23)]
        bool NotAllwdPdctCdSetItem(int index, Product4 value);
        [DispId(24)]
        bool NotAllwdPdctCdAddItem(Product4 value);
        [DispId(25)]
        bool NotAllwdPdctCdRemoveItem(int index);
        [DispId(26)]
        int AddtlAvlblPdctSize();
        [DispId(27)]
        Product5 AddtlAvlblPdctGetItem(int index);
        [DispId(28)]
        bool AddtlAvlblPdctSetItem(int index, Product5 value);
        [DispId(29)]
        bool AddtlAvlblPdctAddItem(Product5 value);
        [DispId(30)]
        bool AddtlAvlblPdctRemoveItem(int index);
        [DispId(31)]
        int ActnSize();
        [DispId(32)]
        Action8 ActnGetItem(int index);
        [DispId(33)]
        bool ActnSetItem(int index, Action8 value);
        [DispId(34)]
        bool ActnAddItem(Action8 value);
        [DispId(35)]
        bool ActnRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("c05e1b1a-83bb-451e-aa90-bac4b6b56eb0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IProduct4 {
        /// <remarks/>
        [DispId(1)]
        string PdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string AddtlPdctCd {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4d5df1cb-b10c-4ede-bf90-fb154204c23d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IProduct5 {
        /// <remarks/>
        [DispId(1)]
        string PdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string AddtlPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        double AmtLmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        bool AmtLmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        double QtyLmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        bool QtyLmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        UnitOfMeasure6Code UnitOfMeasr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        bool UnitOfMeasrSpecified {
            get;
            set;
        }
        [DispId(9)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("76aafacc-da74-486a-9f72-d9b020ef5f73")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICapturedSignature1 {
        /// <remarks/>
        [DispId(1)]
        string ImgFrmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        byte[] ImgData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string ImgRef {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string AddtlInf {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(6)]
        int ImgDataSize();
        [DispId(7)]
        byte ImgDataGetItem(int index);
        [DispId(8)]
        bool ImgDataSetItem(int index, byte value);
        [DispId(9)]
        bool ImgDataAddItem(byte value);
        [DispId(10)]
        bool ImgDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("df8af869-29fa-40ec-8de4-3501c4e9adc0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyResult1 {
        /// <remarks/>
        [DispId(1)]
        LoyaltyAccount1 Acct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        LoyaltyAmount1 Amt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        LoyaltyServerData1 SvrData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        LoyaltyRebates1 Rbts {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("b6fe02a9-363f-43e0-bd41-b681d638adbd")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyServerData1 {
        /// <remarks/>
        [DispId(1)]
        string LltySvrId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string ApprvlCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionIdentifier1 LltyTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string HstRcncltnId {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("b99311d4-917b-4876-b533-31527c4bec90")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyRebates1 {
        /// <remarks/>
        [DispId(1)]
        double TtlRbt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        bool TtlRbtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string RbtLabl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        SaleItemRebate1[] SaleItmRbt {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(6)]
        int SaleItmRbtSize();
        [DispId(7)]
        SaleItemRebate1 SaleItmRbtGetItem(int index);
        [DispId(8)]
        bool SaleItmRbtSetItem(int index, SaleItemRebate1 value);
        [DispId(9)]
        bool SaleItmRbtAddItem(SaleItemRebate1 value);
        [DispId(10)]
        bool SaleItmRbtRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("a9801796-c308-4637-9bd7-a40031bfd2c7")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleItemRebate1 {
        /// <remarks/>
        [DispId(1)]
        Product6 SaleItm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string RbtLabl {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("409ac36c-a98e-4af0-ac5b-993dd015d6ca")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICardAcquisitionResponse1 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string[] PmtBrnd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        LoyaltyAccount1[] LltyAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(6)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(7)]
        int PmtBrndSize();
        [DispId(8)]
        string PmtBrndGetItem(int index);
        [DispId(9)]
        bool PmtBrndSetItem(int index, string value);
        [DispId(10)]
        bool PmtBrndAddItem(string value);
        [DispId(11)]
        bool PmtBrndRemoveItem(int index);
        [DispId(12)]
        int LltyAcctSize();
        [DispId(13)]
        LoyaltyAccount1 LltyAcctGetItem(int index);
        [DispId(14)]
        bool LltyAcctSetItem(int index, LoyaltyAccount1 value);
        [DispId(15)]
        bool LltyAcctAddItem(LoyaltyAccount1 value);
        [DispId(16)]
        bool LltyAcctRemoveItem(int index);
        [DispId(17)]
        int CstmrOrdrSize();
        [DispId(18)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(19)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(20)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(21)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("0c6bd506-14c9-4b12-be57-b0ef728a12b0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIServiceResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ServiceResponse2 SvcRspn {
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
    [System.Runtime.InteropServices.GuidAttribute("6cd3b54e-e73e-4e40-b4c3-555269b23957")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IServiceResponse2 {
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
        RetailerService3Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        PaymentResponse1 PmtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ReversalResponse1 RvslRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        BalanceInquiryResponse1 BalNqryRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyResponse1 LltyRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        StoredValueResponse2 StordValRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        PerformedTransaction1[] BtchRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        CardAcquisitionResponse1 CardAcqstnRspn {
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
        [DispId(12)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(13)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(14)]
        int BtchRspnSize();
        [DispId(15)]
        PerformedTransaction1 BtchRspnGetItem(int index);
        [DispId(16)]
        bool BtchRspnSetItem(int index, PerformedTransaction1 value);
        [DispId(17)]
        bool BtchRspnAddItem(PerformedTransaction1 value);
        [DispId(18)]
        bool BtchRspnRemoveItem(int index);
        [DispId(19)]
        int SplmtryDataSize();
        [DispId(20)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(21)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(22)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(23)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("0fea172a-4eab-4403-889d-0e94ae113e5d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentResponse1 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 SaleTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string SaleRefId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string IssrRefData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        RetailerPaymentResult1 RtlrPmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        PaymentReceipt1[] PmtRct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        LoyaltyResult1[] LltyRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(10)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(11)]
        int PmtRctSize();
        [DispId(12)]
        PaymentReceipt1 PmtRctGetItem(int index);
        [DispId(13)]
        bool PmtRctSetItem(int index, PaymentReceipt1 value);
        [DispId(14)]
        bool PmtRctAddItem(PaymentReceipt1 value);
        [DispId(15)]
        bool PmtRctRemoveItem(int index);
        [DispId(16)]
        int LltyRsltSize();
        [DispId(17)]
        LoyaltyResult1 LltyRsltGetItem(int index);
        [DispId(18)]
        bool LltyRsltSetItem(int index, LoyaltyResult1 value);
        [DispId(19)]
        bool LltyRsltAddItem(LoyaltyResult1 value);
        [DispId(20)]
        bool LltyRsltRemoveItem(int index);
        [DispId(21)]
        int CstmrOrdrSize();
        [DispId(22)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(23)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(24)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(25)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("59dd8a48-6c77-4dad-9c96-d19afd7d5539")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReversalResponse1 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 SaleTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        string SaleRefId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string IssrRefData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        RetailerReversalResult1 RvslTxRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        double RvsdAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        bool RvsdAmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(10)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(11)]
        int RctSize();
        [DispId(12)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(13)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(14)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(15)]
        bool RctRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("73dd4cf9-813f-4c25-934b-ab4419e9ae8f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerReversalResult1 {
        /// <remarks/>
        [DispId(1)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentTransaction91 OrgnlPmtTx {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(5)]
        int CstmrOrdrSize();
        [DispId(6)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(7)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(8)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(9)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("58957ef9-d540-4a80-a22c-a72cbb4a6a3a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyResponse1 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 SaleTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        TransactionIdentifier1 POITxId {
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
        [DispId(4)]
        LoyaltyResult1[] Rslt {
            get;
            set;
        }
        [DispId(5)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(6)]
        int RsltSize();
        [DispId(7)]
        LoyaltyResult1 RsltGetItem(int index);
        [DispId(8)]
        bool RsltSetItem(int index, LoyaltyResult1 value);
        [DispId(9)]
        bool RsltAddItem(LoyaltyResult1 value);
        [DispId(10)]
        bool RsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("b033f6b1-e7a5-48e0-a79d-d248b199d3f1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IStoredValueResponse2 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        StoredValueData2[] Rslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(4)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(5)]
        int RsltSize();
        [DispId(6)]
        StoredValueData2 RsltGetItem(int index);
        [DispId(7)]
        bool RsltSetItem(int index, StoredValueData2 value);
        [DispId(8)]
        bool RsltAddItem(StoredValueData2 value);
        [DispId(9)]
        bool RsltRemoveItem(int index);
        [DispId(10)]
        int RctSize();
        [DispId(11)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(12)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(13)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(14)]
        bool RctRemoveItem(int index);
    }
}
#endif