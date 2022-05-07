#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ee7b6fa1-3245-4bf4-84ae-9b29337ab003")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Action10 : IAction10 {
        private ActionType9Code actnTpField = default(ActionType9Code);
        private ActionMessage7 msgToPresField = new ActionMessage7();
        private bool actnTpField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public ActionType9Code ActnTp {
            get {
                return this.actnTpField;
            }
        }
        /// <remarks/>
        public ActionMessage7 MsgToPres {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.msgToPresField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgToPresField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.msgToPresField = new ActionMessage7();
                }
                else {
                    this.msgToPresField = value;
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
                            || ((this.MsgToPres != null)
                            && this.MsgToPres.XSD_HasBeenSet))
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
                if ((this.MsgToPres != null)) {
                    this.MsgToPres.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ActionType9Code {
        _begin,
        _none,
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
        /// <remarks/>
        PINQ,
        /// <remarks/>
        CDCV,
        /// <remarks/>
        CHDA,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e51de422-6caa-4bbd-ad03-88c08036f5e0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AmountAndDirection93 : IAmountAndDirection93 {
        private double amtField = default(double);
        private string ccyField = default(string);
        private bool sgnField = default(bool);
        private bool sgnFieldSpecified = false;
        private bool amtField_XSD_HasBeenSet = false;
        private bool ccyField_XSD_HasBeenSet = false;
        private bool sgnField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public double Amt {
            get {
                return this.amtField;
            }
            set {
                this.amtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.amtField_XSD_HasBeenSet = (this.amtField != default(double));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.ccyField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ccyField_XSD_HasBeenSet = (this.ccyField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool Sgn {
            get {
                return this.sgnField;
            }
            set {
                this.sgnField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - SgnSpecified = true
                this.SgnSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool SgnSpecified {
            get {
                return this.sgnFieldSpecified;
            }
            set {
                this.sgnFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false || this.amtField_XSD_HasBeenSet)
                            || this.ccyField_XSD_HasBeenSet)
                            || this.sgnField_XSD_HasBeenSet)
                            || this.SgnSpecified);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3da1d270-576b-4068-91dd-6ca6cf22e336")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AuthorisationResult14 : IAuthorisationResult14 {
        private GenericIdentification90 authstnNttyField = new GenericIdentification90();
        private ResponseType10 rspnToAuthstnField = new ResponseType10();
        private string authstnCdField = default(string);
        private bool cmpltnReqrdField = default(bool);
        private bool cmpltnReqrdFieldSpecified = false;
        private TMSTrigger1 tMSTrggrField = new TMSTrigger1();
        private bool authstnCdField_XSD_HasBeenSet = false;
        private bool cmpltnReqrdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public GenericIdentification90 AuthstnNtty {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.authstnNttyField.XSD_HasBeenSet == false))) {
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
        public ResponseType10 RspnToAuthstn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rspnToAuthstnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rspnToAuthstnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rspnToAuthstnField = new ResponseType10();
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
                this.authstnCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.authstnCdField_XSD_HasBeenSet = (this.authstnCdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool CmpltnReqrd {
            get {
                return this.cmpltnReqrdField;
            }
            set {
                this.cmpltnReqrdField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - CmpltnReqrdSpecified = true
                this.CmpltnReqrdSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.tMSTrggrField.XSD_HasBeenSet == false))) {
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((false
                            || ((this.AuthstnNtty != null)
                            && this.AuthstnNtty.XSD_HasBeenSet))
                            || ((this.RspnToAuthstn != null)
                            && this.RspnToAuthstn.XSD_HasBeenSet))
                            || ((this.TMSTrggr != null)
                            && this.TMSTrggr.XSD_HasBeenSet))
                            || this.authstnCdField_XSD_HasBeenSet)
                            || this.cmpltnReqrdField_XSD_HasBeenSet)
                            || this.CmpltnReqrdSpecified);
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
                if ((this.AuthstnNtty != null)) {
                    this.AuthstnNtty.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RspnToAuthstn != null)) {
                    this.RspnToAuthstn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.TMSTrggr != null)) {
                    this.TMSTrggr.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("6db34bd4-ba8c-47a1-8928-8bce44154a63")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class GenericIdentification90 : IGenericIdentification90 {
        private string idField = default(string);
        private PartyType14Code tpField = default(PartyType14Code);
        private PartyType4Code issrField = default(PartyType4Code);
        private bool issrFieldSpecified = false;
        private string ctryField = default(string);
        private string shrtNmField = default(string);
        private bool idField_XSD_HasBeenSet = false;
        private bool tpField_XSD_HasBeenSet = false;
        private bool issrField_XSD_HasBeenSet = false;
        private bool ctryField_XSD_HasBeenSet = false;
        private bool shrtNmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.idField_XSD_HasBeenSet = (this.idField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public PartyType14Code Tp {
            get {
                return this.tpField;
            }
        }
        /// <remarks/>
        public PartyType4Code Issr {
            get {
                return this.issrField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.ctryField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ctryField_XSD_HasBeenSet = (this.ctryField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string ShrtNm {
            get {
                return this.shrtNmField;
            }
            set {
                this.shrtNmField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.shrtNmField_XSD_HasBeenSet = (this.shrtNmField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false || this.idField_XSD_HasBeenSet)
                            || this.tpField_XSD_HasBeenSet)
                            || this.issrField_XSD_HasBeenSet)
                            || this.ctryField_XSD_HasBeenSet)
                            || this.shrtNmField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PartyType14Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2450d3b5-58be-41e1-8ead-5fee5f0a63d7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType10 : IResponseType10 {
        private Response9Code rspnField = default(Response9Code);
        private string rspnRsnField = default(string);
        private string addtlRspnInfField = default(string);
        private bool rspnField_XSD_HasBeenSet = false;
        private bool rspnRsnField_XSD_HasBeenSet = false;
        private bool addtlRspnInfField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public Response9Code Rspn {
            get {
                return this.rspnField;
            }
        }
        /// <remarks/>
        public string RspnRsn {
            get {
                return this.rspnRsnField;
            }
            set {
                this.rspnRsnField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.rspnRsnField_XSD_HasBeenSet = (this.rspnRsnField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlRspnInf {
            get {
                return this.addtlRspnInfField;
            }
            set {
                this.addtlRspnInfField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlRspnInfField_XSD_HasBeenSet = (this.addtlRspnInfField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false || this.rspnField_XSD_HasBeenSet)
                            || this.rspnRsnField_XSD_HasBeenSet)
                            || this.addtlRspnInfField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Response9Code {
        _begin,
        _none,
        /// <remarks/>
        APPR,
        /// <remarks/>
        DECL,
        /// <remarks/>
        PART,
        /// <remarks/>
        SUSP,
        /// <remarks/>
        TECH,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("05ce6993-b96c-4fe5-88ad-ff2c8d9e536f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSTrigger1 : ITMSTrigger1 {
        private TMSContactLevel1Code tMSCtctLvlField = default(TMSContactLevel1Code);
        private string tMSIdField = default(string);
        private string tMSCtctDtTmField = default(string);
        private bool tMSCtctDtTmFieldSpecified = false;
        private bool tMSCtctLvlField_XSD_HasBeenSet = false;
        private bool tMSIdField_XSD_HasBeenSet = false;
        private bool tMSCtctDtTmField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TMSContactLevel1Code TMSCtctLvl {
            get {
                return this.tMSCtctLvlField;
            }
        }
        /// <remarks/>
        public string TMSId {
            get {
                return this.tMSIdField;
            }
            set {
                this.tMSIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.tMSIdField_XSD_HasBeenSet = (this.tMSIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string TMSCtctDtTm {
            get {
                return this.tMSCtctDtTmField;
            }
            set {
                this.tMSCtctDtTmField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - TMSCtctDtTmSpecified = true
                this.TMSCtctDtTmSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool TMSCtctDtTmSpecified {
            get {
                return this.tMSCtctDtTmFieldSpecified;
            }
            set {
                this.tMSCtctDtTmFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false || this.tMSCtctLvlField_XSD_HasBeenSet)
                            || this.tMSIdField_XSD_HasBeenSet)
                            || this.tMSCtctDtTmField_XSD_HasBeenSet)
                            || this.TMSCtctDtTmSpecified);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TMSContactLevel1Code {
        _begin,
        _none,
        /// <remarks/>
        CRIT,
        /// <remarks/>
        ASAP,
        /// <remarks/>
        DTIM,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d93517b6-cd7b-46cf-ac39-a9e1c7149bac")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BalanceInquiryResponse2 : IBalanceInquiryResponse2 {
        private PaymentAccount3 pmtAcctField = new PaymentAccount3();
        private LoyaltyAccount2 lltyAcctField = new LoyaltyAccount2();
        private StoredValueAccount2[] stordValAcctField = new StoredValueAccount2[0];
        private PaymentReceipt2[] rctField = new PaymentReceipt2[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public PaymentAccount3 PmtAcct {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pmtAcctField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtAcctField = new PaymentAccount3();
                }
                else {
                    this.pmtAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyAccount2 LltyAcct {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lltyAcctField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyAcctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lltyAcctField = new LoyaltyAccount2();
                }
                else {
                    this.lltyAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StordValAcct")]
        public StoredValueAccount2[] StordValAcct {
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
                    this.stordValAcctField = new StoredValueAccount2[0];
                }
                else {
                    this.stordValAcctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt2[] Rct {
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
                    this.rctField = new PaymentReceipt2[0];
                }
                else {
                    this.rctField = value;
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
                            || ((this.PmtAcct != null)
                            && this.PmtAcct.XSD_HasBeenSet))
                            || ((this.LltyAcct != null)
                            && this.LltyAcct.XSD_HasBeenSet))
                            || (this.StordValAcctSize() != 0))
                            || (this.RctSize() != 0));
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
                if ((this.PmtAcct != null)) {
                    this.PmtAcct.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.LltyAcct != null)) {
                    this.LltyAcct.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.StordValAcctSize()); i = (i + 1)) {
                    this.StordValAcct[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.RctSize()); i = (i + 1)) {
                    this.Rct[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public StoredValueAccount2 StordValAcctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount2[]))) {
                    return default(StoredValueAccount2);
                }
                else {
                    if (((this.stordValAcctField.Length - 1)
                                >= index)) {
                        return this.stordValAcctField[index];
                    }
                    else {
                        return default(StoredValueAccount2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(StoredValueAccount2);
            }
            // END ADDED BY XSD
        }
        public bool StordValAcctSetItem(int index, StoredValueAccount2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount2[]))) {
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
        public bool StordValAcctAddItem(StoredValueAccount2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.stordValAcctField == default(StoredValueAccount2[]))) {
                    return false;
                }
                else {
                    StoredValueAccount2[] array = new StoredValueAccount2[(this.stordValAcctField.Length + 1)];
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
                if ((this.stordValAcctField == default(StoredValueAccount2[]))) {
                    return false;
                }
                else {
                    if ((this.stordValAcctField.Length <= index)) {
                        return false;
                    }
                    else {
                        StoredValueAccount2[] array = new StoredValueAccount2[(this.stordValAcctField.Length - 1)];
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
        public PaymentReceipt2 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return default(PaymentReceipt2);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt2);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
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
        public bool RctAddItem(PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length + 1)];
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
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3db5ea46-1412-4138-8946-8cc6f4a9549d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentAccount3 : IPaymentAccount3 {
        private string ccyField = default(string);
        private double curBalField = default(double);
        private bool curBalFieldSpecified = false;
        private Acquirer10 pmtAcqrrDataField = new Acquirer10();
        private bool ccyField_XSD_HasBeenSet = false;
        private bool curBalField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.ccyField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.ccyField_XSD_HasBeenSet = (this.ccyField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double CurBal {
            get {
                return this.curBalField;
            }
            set {
                this.curBalField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - CurBalSpecified = true
                this.CurBalSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool CurBalSpecified {
            get {
                return this.curBalFieldSpecified;
            }
            set {
                this.curBalFieldSpecified = value;
            }
        }
        /// <remarks/>
        public Acquirer10 PmtAcqrrData {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pmtAcqrrDataField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtAcqrrDataField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtAcqrrDataField = new Acquirer10();
                }
                else {
                    this.pmtAcqrrDataField = value;
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
                            || ((this.PmtAcqrrData != null)
                            && this.PmtAcqrrData.XSD_HasBeenSet))
                            || this.ccyField_XSD_HasBeenSet)
                            || this.curBalField_XSD_HasBeenSet)
                            || this.CurBalSpecified);
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
                if ((this.PmtAcqrrData != null)) {
                    this.PmtAcqrrData.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("65ea80ea-e095-4365-9b6b-df63fb90f7dc")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentReceipt2 : IPaymentReceipt2 {
        private DocumentType7Code docQlfrField = default(DocumentType7Code);
        private bool intgrtdPrtFlgField = default(bool);
        private bool intgrtdPrtFlgFieldSpecified = false;
        private bool reqrdSgntrFlgField = default(bool);
        private bool reqrdSgntrFlgFieldSpecified = false;
        private ActionMessage7 outptCnttField = new ActionMessage7();
        private bool docQlfrField_XSD_HasBeenSet = false;
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
                return ((((((false
                            || ((this.OutptCntt != null)
                            && this.OutptCntt.XSD_HasBeenSet))
                            || this.docQlfrField_XSD_HasBeenSet)
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DocumentType7Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("889e020c-56c8-421f-9899-587e218ec16f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BatchResponse2 : IBatchResponse2 {
        private PerformedTransaction2[] prfrmdTxField = new PerformedTransaction2[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrfrmdTx")]
        public PerformedTransaction2[] PrfrmdTx {
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
                    this.prfrmdTxField = new PerformedTransaction2[0];
                }
                else {
                    this.prfrmdTxField = value;
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
                            || (this.PrfrmdTxSize() != 0));
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
                for (i = 0; (i < this.PrfrmdTxSize()); i = (i + 1)) {
                    this.PrfrmdTx[i].XSD_Optimizing = this._XSD_Optimizing;
                }
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
        public PerformedTransaction2 PrfrmdTxGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction2[]))) {
                    return default(PerformedTransaction2);
                }
                else {
                    if (((this.prfrmdTxField.Length - 1)
                                >= index)) {
                        return this.prfrmdTxField[index];
                    }
                    else {
                        return default(PerformedTransaction2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PerformedTransaction2);
            }
            // END ADDED BY XSD
        }
        public bool PrfrmdTxSetItem(int index, PerformedTransaction2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction2[]))) {
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
        public bool PrfrmdTxAddItem(PerformedTransaction2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.prfrmdTxField == default(PerformedTransaction2[]))) {
                    return false;
                }
                else {
                    PerformedTransaction2[] array = new PerformedTransaction2[(this.prfrmdTxField.Length + 1)];
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
                if ((this.prfrmdTxField == default(PerformedTransaction2[]))) {
                    return false;
                }
                else {
                    if ((this.prfrmdTxField.Length <= index)) {
                        return false;
                    }
                    else {
                        PerformedTransaction2[] array = new PerformedTransaction2[(this.prfrmdTxField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c4cf35f8-b85e-4c4f-9022-fcd2dfe62dc4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PerformedTransaction2 : IPerformedTransaction2 {
        private ResponseType9 rspnField = new ResponseType9();
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField = default(string);
        private RetailerPaymentResult2 pmtRsltField = new RetailerPaymentResult2();
        private LoyaltyResult2[] lltyRsltField = new LoyaltyResult2[0];
        private double rvsdAmtField = default(double);
        private bool rvsdAmtFieldSpecified = false;
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool rvsdAmtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
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
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleTxIdField.XSD_HasBeenSet == false))) {
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public RetailerPaymentResult2 PmtRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pmtRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtRsltField = new RetailerPaymentResult2();
                }
                else {
                    this.pmtRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult2[] LltyRslt {
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
                    this.lltyRsltField = new LoyaltyResult2[0];
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
                this.rvsdAmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - RvsdAmtSpecified = true
                this.RvsdAmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool RvsdAmtSpecified {
            get {
                return this.rvsdAmtFieldSpecified;
            }
            set {
                this.rvsdAmtFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((((((false
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || ((this.SaleTxId != null)
                            && this.SaleTxId.XSD_HasBeenSet))
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || ((this.PmtRslt != null)
                            && this.PmtRslt.XSD_HasBeenSet))
                            || (this.LltyRsltSize() != 0))
                            || this.pOIRcncltnIdField_XSD_HasBeenSet)
                            || this.rvsdAmtField_XSD_HasBeenSet)
                            || this.RvsdAmtSpecified);
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
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PmtRslt != null)) {
                    this.PmtRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.LltyRsltSize()); i = (i + 1)) {
                    this.LltyRslt[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public LoyaltyResult2 LltyRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return default(LoyaltyResult2);
                }
                else {
                    if (((this.lltyRsltField.Length - 1)
                                >= index)) {
                        return this.lltyRsltField[index];
                    }
                    else {
                        return default(LoyaltyResult2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult2);
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
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
        public bool LltyRsltAddItem(LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    LoyaltyResult2[] array = new LoyaltyResult2[(this.lltyRsltField.Length + 1)];
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
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    if ((this.lltyRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult2[] array = new LoyaltyResult2[(this.lltyRsltField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("31b341c6-b618-4e08-9b82-dacfcfae673c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType9 : IResponseType9 {
        private Response5Code rspnField = default(Response5Code);
        private RetailerResultDetail1Code rspnRsnField = default(RetailerResultDetail1Code);
        private bool rspnRsnFieldSpecified = false;
        private string addtlRspnInfField = default(string);
        private bool rspnField_XSD_HasBeenSet = false;
        private bool rspnRsnField_XSD_HasBeenSet = false;
        private bool addtlRspnInfField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public Response5Code Rspn {
            get {
                return this.rspnField;
            }
        }
        /// <remarks/>
        public RetailerResultDetail1Code RspnRsn {
            get {
                return this.rspnRsnField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.addtlRspnInfField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlRspnInfField_XSD_HasBeenSet = (this.addtlRspnInfField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false || this.rspnField_XSD_HasBeenSet)
                            || this.rspnRsnField_XSD_HasBeenSet)
                            || this.addtlRspnInfField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum Response5Code {
        _begin,
        _none,
        /// <remarks/>
        SUCC,
        /// <remarks/>
        FAIL,
        /// <remarks/>
        PART,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerResultDetail1Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f1bafdf4-ae8b-4991-89cf-d63a4c225b6a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerPaymentResult2 : IRetailerPaymentResult2 {
        private CardPaymentServiceType12Code txTpField = default(CardPaymentServiceType12Code);
        private CardPaymentServiceType9Code[] addtlSvcField = new CardPaymentServiceType9Code[0];
        private CardPaymentServiceType3Code svcAttrField = default(CardPaymentServiceType3Code);
        private bool svcAttrFieldSpecified = false;
        private CardPaymentTransaction100 reqdTxField = new CardPaymentTransaction100();
        private CardPaymentTransaction94 txRspnField = new CardPaymentTransaction94();
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        private ContentInformationType22 prtctdCaptrdSgntrField = new ContentInformationType22();
        private bool mrchntOvrrdFlgField = default(bool);
        private bool mrchntOvrrdFlgFieldSpecified = false;
        private string cstmrLangField = default(string);
        private bool onlnFlgField = default(bool);
        private bool onlnFlgFieldSpecified = false;
        private bool txTpField_XSD_HasBeenSet = false;
        private bool svcAttrField_XSD_HasBeenSet = false;
        private bool mrchntOvrrdFlgField_XSD_HasBeenSet = false;
        private bool cstmrLangField_XSD_HasBeenSet = false;
        private bool onlnFlgField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public CardPaymentServiceType12Code TxTp {
            get {
                return this.txTpField;
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
        }
        /// <remarks/>
        public CardPaymentServiceType3Code SvcAttr {
            get {
                return this.svcAttrField;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool SvcAttrSpecified {
            get {
                return this.svcAttrFieldSpecified;
            }
            set {
                this.svcAttrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction100 ReqdTx {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.reqdTxField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.reqdTxField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.reqdTxField = new CardPaymentTransaction100();
                }
                else {
                    this.reqdTxField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardPaymentTransaction94 TxRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.txRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.txRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.txRspnField = new CardPaymentTransaction94();
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.imgCaptrdSgntrField.XSD_HasBeenSet == false))) {
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
        public ContentInformationType22 PrtctdCaptrdSgntr {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.prtctdCaptrdSgntrField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtctdCaptrdSgntrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtctdCaptrdSgntrField = new ContentInformationType22();
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
                this.mrchntOvrrdFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - MrchntOvrrdFlgSpecified = true
                this.MrchntOvrrdFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.cstmrLangField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.cstmrLangField_XSD_HasBeenSet = (this.cstmrLangField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public bool OnlnFlg {
            get {
                return this.onlnFlgField;
            }
            set {
                this.onlnFlgField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - OnlnFlgSpecified = true
                this.OnlnFlgSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool OnlnFlgSpecified {
            get {
                return this.onlnFlgFieldSpecified;
            }
            set {
                this.onlnFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((((((false
                            || ((this.ReqdTx != null)
                            && this.ReqdTx.XSD_HasBeenSet))
                            || ((this.TxRspn != null)
                            && this.TxRspn.XSD_HasBeenSet))
                            || ((this.ImgCaptrdSgntr != null)
                            && this.ImgCaptrdSgntr.XSD_HasBeenSet))
                            || ((this.PrtctdCaptrdSgntr != null)
                            && this.PrtctdCaptrdSgntr.XSD_HasBeenSet))
                            || (this.AddtlSvcSize() != 0))
                            || (this.CstmrOrdrSize() != 0))
                            || this.txTpField_XSD_HasBeenSet)
                            || this.svcAttrField_XSD_HasBeenSet)
                            || this.mrchntOvrrdFlgField_XSD_HasBeenSet)
                            || this.cstmrLangField_XSD_HasBeenSet)
                            || this.onlnFlgField_XSD_HasBeenSet)
                            || this.MrchntOvrrdFlgSpecified)
                            || this.OnlnFlgSpecified);
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
                if ((this.ReqdTx != null)) {
                    this.ReqdTx.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.TxRspn != null)) {
                    this.TxRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.ImgCaptrdSgntr != null)) {
                    this.ImgCaptrdSgntr.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PrtctdCaptrdSgntr != null)) {
                    this.PrtctdCaptrdSgntr.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.AddtlSvcSize()); i = (i + 1)) {
                    this.AddtlSvc[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.CstmrOrdrSize()); i = (i + 1)) {
                    this.CstmrOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CardPaymentServiceType12Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("80ad210e-f0e9-41d0-a524-be01c41039bb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardPaymentTransaction94 : ICardPaymentTransaction94 {
        private AuthorisationResult14 authstnRsltField = new AuthorisationResult14();
        private TransactionVerificationResult4[] txVrfctnRsltField = new TransactionVerificationResult4[0];
        private Product4[] allwdPdctCdField = new Product4[0];
        private Product4[] notAllwdPdctCdField = new Product4[0];
        private Product5[] addtlAvlblPdctField = new Product5[0];
        private AmountAndDirection93 balField = new AmountAndDirection93();
        private ContentInformationType22 prtctdBalField = new ContentInformationType22();
        private Action10[] actnField = new Action10[0];
        private CurrencyConversion19 ccyConvsElgbltyField = new CurrencyConversion19();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public AuthorisationResult14 AuthstnRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.authstnRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.authstnRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.authstnRsltField = new AuthorisationResult14();
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.balField.XSD_HasBeenSet == false))) {
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
        public ContentInformationType22 PrtctdBal {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.prtctdBalField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.prtctdBalField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.prtctdBalField = new ContentInformationType22();
                }
                else {
                    this.prtctdBalField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Actn")]
        public Action10[] Actn {
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
                    this.actnField = new Action10[0];
                }
                else {
                    this.actnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CurrencyConversion19 CcyConvsElgblty {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.ccyConvsElgbltyField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.ccyConvsElgbltyField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.ccyConvsElgbltyField = new CurrencyConversion19();
                }
                else {
                    this.ccyConvsElgbltyField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((false
                            || ((this.AuthstnRslt != null)
                            && this.AuthstnRslt.XSD_HasBeenSet))
                            || ((this.Bal != null)
                            && this.Bal.XSD_HasBeenSet))
                            || ((this.PrtctdBal != null)
                            && this.PrtctdBal.XSD_HasBeenSet))
                            || ((this.CcyConvsElgblty != null)
                            && this.CcyConvsElgblty.XSD_HasBeenSet))
                            || (this.TxVrfctnRsltSize() != 0))
                            || (this.AllwdPdctCdSize() != 0))
                            || (this.NotAllwdPdctCdSize() != 0))
                            || (this.AddtlAvlblPdctSize() != 0))
                            || (this.ActnSize() != 0));
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
                if ((this.AuthstnRslt != null)) {
                    this.AuthstnRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Bal != null)) {
                    this.Bal.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.PrtctdBal != null)) {
                    this.PrtctdBal.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.CcyConvsElgblty != null)) {
                    this.CcyConvsElgblty.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.TxVrfctnRsltSize()); i = (i + 1)) {
                    this.TxVrfctnRslt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.AllwdPdctCdSize()); i = (i + 1)) {
                    this.AllwdPdctCd[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.NotAllwdPdctCdSize()); i = (i + 1)) {
                    this.NotAllwdPdctCd[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.AddtlAvlblPdctSize()); i = (i + 1)) {
                    this.AddtlAvlblPdct[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.ActnSize()); i = (i + 1)) {
                    this.Actn[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public Action10 ActnGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.actnField == default(Action10[]))) {
                    return default(Action10);
                }
                else {
                    if (((this.actnField.Length - 1)
                                >= index)) {
                        return this.actnField[index];
                    }
                    else {
                        return default(Action10);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(Action10);
            }
            // END ADDED BY XSD
        }
        public bool ActnSetItem(int index, Action10 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.actnField == default(Action10[]))) {
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
        public bool ActnAddItem(Action10 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.actnField == default(Action10[]))) {
                    return false;
                }
                else {
                    Action10[] array = new Action10[(this.actnField.Length + 1)];
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
                if ((this.actnField == default(Action10[]))) {
                    return false;
                }
                else {
                    if ((this.actnField.Length <= index)) {
                        return false;
                    }
                    else {
                        Action10[] array = new Action10[(this.actnField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("76b24028-9d25-4ce2-b784-d0a600cd8a1d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product4 : IProduct4 {
        private string pdctCdField = default(string);
        private string addtlPdctCdField = default(string);
        private bool pdctCdField_XSD_HasBeenSet = false;
        private bool addtlPdctCdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                this.pdctCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pdctCdField_XSD_HasBeenSet = (this.pdctCdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                this.addtlPdctCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlPdctCdField_XSD_HasBeenSet = (this.addtlPdctCdField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((false || this.pdctCdField_XSD_HasBeenSet)
                            || this.addtlPdctCdField_XSD_HasBeenSet);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("967a667a-d0ca-4ce0-8063-b85b3d828161")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product5 : IProduct5 {
        private string pdctCdField = default(string);
        private string addtlPdctCdField = default(string);
        private double amtLmtField = default(double);
        private bool amtLmtFieldSpecified = false;
        private double qtyLmtField = default(double);
        private bool qtyLmtFieldSpecified = false;
        private UnitOfMeasure6Code unitOfMeasrField = default(UnitOfMeasure6Code);
        private bool unitOfMeasrFieldSpecified = false;
        private bool pdctCdField_XSD_HasBeenSet = false;
        private bool addtlPdctCdField_XSD_HasBeenSet = false;
        private bool amtLmtField_XSD_HasBeenSet = false;
        private bool qtyLmtField_XSD_HasBeenSet = false;
        private bool unitOfMeasrField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                this.pdctCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pdctCdField_XSD_HasBeenSet = (this.pdctCdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                this.addtlPdctCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlPdctCdField_XSD_HasBeenSet = (this.addtlPdctCdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public double AmtLmt {
            get {
                return this.amtLmtField;
            }
            set {
                this.amtLmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - AmtLmtSpecified = true
                this.AmtLmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.qtyLmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - QtyLmtSpecified = true
                this.QtyLmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        public bool UnitOfMeasrSpecified {
            get {
                return this.unitOfMeasrFieldSpecified;
            }
            set {
                this.unitOfMeasrFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((false || this.pdctCdField_XSD_HasBeenSet)
                            || this.addtlPdctCdField_XSD_HasBeenSet)
                            || this.amtLmtField_XSD_HasBeenSet)
                            || this.qtyLmtField_XSD_HasBeenSet)
                            || this.unitOfMeasrField_XSD_HasBeenSet)
                            || this.AmtLmtSpecified)
                            || this.QtyLmtSpecified);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d72a9453-6e40-447d-ab9d-b8b0d1324f93")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CapturedSignature1 : ICapturedSignature1 {
        private string imgFrmtField = default(string);
        private byte[] imgDataField = new byte[0];
        private string imgRefField = default(string);
        private string addtlInfField = default(string);
        private bool imgFrmtField_XSD_HasBeenSet = false;
        private bool imgRefField_XSD_HasBeenSet = false;
        private bool addtlInfField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string ImgFrmt {
            get {
                return this.imgFrmtField;
            }
            set {
                this.imgFrmtField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.imgFrmtField_XSD_HasBeenSet = (this.imgFrmtField != default(string));
                // END ADDED BY XSD
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.imgDataField = new byte[0];
                }
                else {
                    this.imgDataField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string ImgRef {
            get {
                return this.imgRefField;
            }
            set {
                this.imgRefField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.imgRefField_XSD_HasBeenSet = (this.imgRefField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string AddtlInf {
            get {
                return this.addtlInfField;
            }
            set {
                this.addtlInfField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.addtlInfField_XSD_HasBeenSet = (this.addtlInfField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false
                            || (this.ImgDataSize() != 0))
                            || this.imgFrmtField_XSD_HasBeenSet)
                            || this.imgRefField_XSD_HasBeenSet)
                            || this.addtlInfField_XSD_HasBeenSet);
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b5df99f8-5662-4df6-ab01-c5ab2fa734cb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResult2 : ILoyaltyResult2 {
        private LoyaltyAccount2 acctField = new LoyaltyAccount2();
        private LoyaltyAmount1 amtField = new LoyaltyAmount1();
        private LoyaltyServerData1 svrDataField = new LoyaltyServerData1();
        private LoyaltyRebates1 rbtsField = new LoyaltyRebates1();
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public LoyaltyAccount2 Acct {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.acctField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.acctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.acctField = new LoyaltyAccount2();
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.amtField.XSD_HasBeenSet == false))) {
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.svrDataField.XSD_HasBeenSet == false))) {
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rbtsField.XSD_HasBeenSet == false))) {
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false
                            || ((this.Acct != null)
                            && this.Acct.XSD_HasBeenSet))
                            || ((this.Amt != null)
                            && this.Amt.XSD_HasBeenSet))
                            || ((this.SvrData != null)
                            && this.SvrData.XSD_HasBeenSet))
                            || ((this.Rbts != null)
                            && this.Rbts.XSD_HasBeenSet));
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
                if ((this.Acct != null)) {
                    this.Acct.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Amt != null)) {
                    this.Amt.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.SvrData != null)) {
                    this.SvrData.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Rbts != null)) {
                    this.Rbts.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d874637b-dfc8-42fe-8f52-4753291c7a58")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyServerData1 : ILoyaltyServerData1 {
        private string lltySvrIdField = default(string);
        private string apprvlCdField = default(string);
        private TransactionIdentifier1 lltyTxIdField = new TransactionIdentifier1();
        private string hstRcncltnIdField = default(string);
        private bool lltySvrIdField_XSD_HasBeenSet = false;
        private bool apprvlCdField_XSD_HasBeenSet = false;
        private bool hstRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string LltySvrId {
            get {
                return this.lltySvrIdField;
            }
            set {
                this.lltySvrIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.lltySvrIdField_XSD_HasBeenSet = (this.lltySvrIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string ApprvlCd {
            get {
                return this.apprvlCdField;
            }
            set {
                this.apprvlCdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.apprvlCdField_XSD_HasBeenSet = (this.apprvlCdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 LltyTxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lltyTxIdField.XSD_HasBeenSet == false))) {
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
                this.hstRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.hstRcncltnIdField_XSD_HasBeenSet = (this.hstRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false
                            || ((this.LltyTxId != null)
                            && this.LltyTxId.XSD_HasBeenSet))
                            || this.lltySvrIdField_XSD_HasBeenSet)
                            || this.apprvlCdField_XSD_HasBeenSet)
                            || this.hstRcncltnIdField_XSD_HasBeenSet);
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
                if ((this.LltyTxId != null)) {
                    this.LltyTxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4754edee-bcbc-4905-950f-1bbc662df142")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyRebates1 : ILoyaltyRebates1 {
        private double ttlRbtField = default(double);
        private bool ttlRbtFieldSpecified = false;
        private string rbtLablField = default(string);
        private SaleItemRebate1[] saleItmRbtField = new SaleItemRebate1[0];
        private bool ttlRbtField_XSD_HasBeenSet = false;
        private bool rbtLablField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public double TtlRbt {
            get {
                return this.ttlRbtField;
            }
            set {
                this.ttlRbtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - TtlRbtSpecified = true
                this.TtlRbtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
                this.rbtLablField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.rbtLablField_XSD_HasBeenSet = (this.rbtLablField != default(string));
                // END ADDED BY XSD
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((((false
                            || (this.SaleItmRbtSize() != 0))
                            || this.ttlRbtField_XSD_HasBeenSet)
                            || this.rbtLablField_XSD_HasBeenSet)
                            || this.TtlRbtSpecified);
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
                for (i = 0; (i < this.SaleItmRbtSize()); i = (i + 1)) {
                    this.SaleItmRbt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("6cf5bce2-9cde-476e-8d46-d9b1d40e821f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleItemRebate1 : ISaleItemRebate1 {
        private Product6 saleItmField = new Product6();
        private string rbtLablField = default(string);
        private bool rbtLablField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public Product6 SaleItm {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleItmField.XSD_HasBeenSet == false))) {
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
                this.rbtLablField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.rbtLablField_XSD_HasBeenSet = (this.rbtLablField != default(string));
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return ((false
                            || ((this.SaleItm != null)
                            && this.SaleItm.XSD_HasBeenSet))
                            || this.rbtLablField_XSD_HasBeenSet);
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
                if ((this.SaleItm != null)) {
                    this.SaleItm.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("0cc88735-2458-4d23-9151-d197f0f3b417")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardAcquisitionResponse2 : ICardAcquisitionResponse2 {
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string[] pmtBrndField = new string[0];
        private string cstmrLangField = default(string);
        private LoyaltyAccount2[] lltyAcctField = new LoyaltyAccount2[0];
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool cstmrLangField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.pmtBrndField = new string[0];
                }
                else {
                    this.pmtBrndField = value;
                }
                // END ADDED BY XSD
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
        [System.Xml.Serialization.XmlElementAttribute("LltyAcct")]
        public LoyaltyAccount2[] LltyAcct {
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
                    this.lltyAcctField = new LoyaltyAccount2[0];
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((false
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || (this.PmtBrndSize() != 0))
                            || (this.LltyAcctSize() != 0))
                            || (this.CstmrOrdrSize() != 0))
                            || this.cstmrLangField_XSD_HasBeenSet);
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
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.LltyAcctSize()); i = (i + 1)) {
                    this.LltyAcct[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.CstmrOrdrSize()); i = (i + 1)) {
                    this.CstmrOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public LoyaltyAccount2 LltyAcctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount2[]))) {
                    return default(LoyaltyAccount2);
                }
                else {
                    if (((this.lltyAcctField.Length - 1)
                                >= index)) {
                        return this.lltyAcctField[index];
                    }
                    else {
                        return default(LoyaltyAccount2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyAccount2);
            }
            // END ADDED BY XSD
        }
        public bool LltyAcctSetItem(int index, LoyaltyAccount2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount2[]))) {
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
        public bool LltyAcctAddItem(LoyaltyAccount2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyAcctField == default(LoyaltyAccount2[]))) {
                    return false;
                }
                else {
                    LoyaltyAccount2[] array = new LoyaltyAccount2[(this.lltyAcctField.Length + 1)];
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
                if ((this.lltyAcctField == default(LoyaltyAccount2[]))) {
                    return false;
                }
                else {
                    if ((this.lltyAcctField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyAccount2[] array = new LoyaltyAccount2[(this.lltyAcctField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f1cc8c6f-bb3e-445a-b5d0-380d30d672eb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIServiceResponseV02 : ISaleToPOIServiceResponseV02 {
        private Header41 hdrField = new Header41();
        private ServiceResponse3 svcRspnField = new ServiceResponse3();
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
        public ServiceResponse3 SvcRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.svcRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.svcRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.svcRspnField = new ServiceResponse3();
                }
                else {
                    this.svcRspnField = value;
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
                            || ((this.SvcRspn != null)
                            && this.SvcRspn.XSD_HasBeenSet))
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
                if ((this.SvcRspn != null)) {
                    this.SvcRspn.XSD_Optimizing = this._XSD_Optimizing;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b5d98f11-2161-4dd0-bd42-c34f313db92d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServiceResponse3 : IServiceResponse3 {
        private CardPaymentEnvironment75 envtField = new CardPaymentEnvironment75();
        private CardPaymentContext28 cntxtField = new CardPaymentContext28();
        private RetailerService3Code svcCnttField = default(RetailerService3Code);
        private PaymentResponse2 pmtRspnField = new PaymentResponse2();
        private ReversalResponse3 rvslRspnField = new ReversalResponse3();
        private BalanceInquiryResponse2 balNqryRspnField = new BalanceInquiryResponse2();
        private LoyaltyResponse2 lltyRspnField = new LoyaltyResponse2();
        private StoredValueResponse3 stordValRspnField = new StoredValueResponse3();
        private PerformedTransaction2[] btchRspnField = new PerformedTransaction2[0];
        private CardAcquisitionResponse2 cardAcqstnRspnField = new CardAcquisitionResponse2();
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
        public RetailerService3Code SvcCntt {
            get {
                return this.svcCnttField;
            }
        }
        /// <remarks/>
        public PaymentResponse2 PmtRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pmtRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.pmtRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.pmtRspnField = new PaymentResponse2();
                }
                else {
                    this.pmtRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public ReversalResponse3 RvslRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rvslRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rvslRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rvslRspnField = new ReversalResponse3();
                }
                else {
                    this.rvslRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public BalanceInquiryResponse2 BalNqryRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.balNqryRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.balNqryRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.balNqryRspnField = new BalanceInquiryResponse2();
                }
                else {
                    this.balNqryRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public LoyaltyResponse2 LltyRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.lltyRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.lltyRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.lltyRspnField = new LoyaltyResponse2();
                }
                else {
                    this.lltyRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public StoredValueResponse3 StordValRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.stordValRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.stordValRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.stordValRspnField = new StoredValueResponse3();
                }
                else {
                    this.stordValRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PrfrmdTx", IsNullable=false)]
        public PerformedTransaction2[] BtchRspn {
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
                    this.btchRspnField = new PerformedTransaction2[0];
                }
                else {
                    this.btchRspnField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardAcquisitionResponse2 CardAcqstnRspn {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.cardAcqstnRspnField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.cardAcqstnRspnField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.cardAcqstnRspnField = new CardAcquisitionResponse2();
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
                return ((((((((((((false
                            || ((this.Envt != null)
                            && this.Envt.XSD_HasBeenSet))
                            || ((this.Cntxt != null)
                            && this.Cntxt.XSD_HasBeenSet))
                            || ((this.PmtRspn != null)
                            && this.PmtRspn.XSD_HasBeenSet))
                            || ((this.RvslRspn != null)
                            && this.RvslRspn.XSD_HasBeenSet))
                            || ((this.BalNqryRspn != null)
                            && this.BalNqryRspn.XSD_HasBeenSet))
                            || ((this.LltyRspn != null)
                            && this.LltyRspn.XSD_HasBeenSet))
                            || ((this.StordValRspn != null)
                            && this.StordValRspn.XSD_HasBeenSet))
                            || ((this.CardAcqstnRspn != null)
                            && this.CardAcqstnRspn.XSD_HasBeenSet))
                            || ((this.Rspn != null)
                            && this.Rspn.XSD_HasBeenSet))
                            || (this.BtchRspnSize() != 0))
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
                if ((this.PmtRspn != null)) {
                    this.PmtRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RvslRspn != null)) {
                    this.RvslRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.BalNqryRspn != null)) {
                    this.BalNqryRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.LltyRspn != null)) {
                    this.LltyRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.StordValRspn != null)) {
                    this.StordValRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.CardAcqstnRspn != null)) {
                    this.CardAcqstnRspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.Rspn != null)) {
                    this.Rspn.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.BtchRspnSize()); i = (i + 1)) {
                    this.BtchRspn[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.SplmtryDataSize()); i = (i + 1)) {
                    this.SplmtryData[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public PerformedTransaction2 BtchRspnGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction2[]))) {
                    return default(PerformedTransaction2);
                }
                else {
                    if (((this.btchRspnField.Length - 1)
                                >= index)) {
                        return this.btchRspnField[index];
                    }
                    else {
                        return default(PerformedTransaction2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PerformedTransaction2);
            }
            // END ADDED BY XSD
        }
        public bool BtchRspnSetItem(int index, PerformedTransaction2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction2[]))) {
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
        public bool BtchRspnAddItem(PerformedTransaction2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.btchRspnField == default(PerformedTransaction2[]))) {
                    return false;
                }
                else {
                    PerformedTransaction2[] array = new PerformedTransaction2[(this.btchRspnField.Length + 1)];
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
                if ((this.btchRspnField == default(PerformedTransaction2[]))) {
                    return false;
                }
                else {
                    if ((this.btchRspnField.Length <= index)) {
                        return false;
                    }
                    else {
                        PerformedTransaction2[] array = new PerformedTransaction2[(this.btchRspnField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService3Code {
        _begin,
        _none,
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
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("983372bb-d7ad-4da1-ab65-681f02b4b1e7")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentResponse2 : IPaymentResponse2 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private string saleRefIdField = default(string);
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField = default(string);
        private string issrRefDataField = default(string);
        private RetailerPaymentResult2 rtlrPmtRsltField = new RetailerPaymentResult2();
        private PaymentReceipt2[] pmtRctField = new PaymentReceipt2[0];
        private LoyaltyResult2[] lltyRsltField = new LoyaltyResult2[0];
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool saleRefIdField_XSD_HasBeenSet = false;
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool issrRefDataField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleTxIdField.XSD_HasBeenSet == false))) {
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
                this.saleRefIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.saleRefIdField_XSD_HasBeenSet = (this.saleRefIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                this.issrRefDataField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.issrRefDataField_XSD_HasBeenSet = (this.issrRefDataField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public RetailerPaymentResult2 RtlrPmtRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rtlrPmtRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rtlrPmtRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rtlrPmtRsltField = new RetailerPaymentResult2();
                }
                else {
                    this.rtlrPmtRsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtRct")]
        public PaymentReceipt2[] PmtRct {
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
                    this.pmtRctField = new PaymentReceipt2[0];
                }
                else {
                    this.pmtRctField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult2[] LltyRslt {
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
                    this.lltyRsltField = new LoyaltyResult2[0];
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((false
                            || ((this.SaleTxId != null)
                            && this.SaleTxId.XSD_HasBeenSet))
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || ((this.RtlrPmtRslt != null)
                            && this.RtlrPmtRslt.XSD_HasBeenSet))
                            || (this.PmtRctSize() != 0))
                            || (this.LltyRsltSize() != 0))
                            || (this.CstmrOrdrSize() != 0))
                            || this.saleRefIdField_XSD_HasBeenSet)
                            || this.pOIRcncltnIdField_XSD_HasBeenSet)
                            || this.issrRefDataField_XSD_HasBeenSet);
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RtlrPmtRslt != null)) {
                    this.RtlrPmtRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.PmtRctSize()); i = (i + 1)) {
                    this.PmtRct[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.LltyRsltSize()); i = (i + 1)) {
                    this.LltyRslt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.CstmrOrdrSize()); i = (i + 1)) {
                    this.CstmrOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public PaymentReceipt2 PmtRctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt2[]))) {
                    return default(PaymentReceipt2);
                }
                else {
                    if (((this.pmtRctField.Length - 1)
                                >= index)) {
                        return this.pmtRctField[index];
                    }
                    else {
                        return default(PaymentReceipt2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt2);
            }
            // END ADDED BY XSD
        }
        public bool PmtRctSetItem(int index, PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt2[]))) {
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
        public bool PmtRctAddItem(PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.pmtRctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    PaymentReceipt2[] array = new PaymentReceipt2[(this.pmtRctField.Length + 1)];
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
                if ((this.pmtRctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    if ((this.pmtRctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt2[] array = new PaymentReceipt2[(this.pmtRctField.Length - 1)];
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
        public LoyaltyResult2 LltyRsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return default(LoyaltyResult2);
                }
                else {
                    if (((this.lltyRsltField.Length - 1)
                                >= index)) {
                        return this.lltyRsltField[index];
                    }
                    else {
                        return default(LoyaltyResult2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult2);
            }
            // END ADDED BY XSD
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
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
        public bool LltyRsltAddItem(LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    LoyaltyResult2[] array = new LoyaltyResult2[(this.lltyRsltField.Length + 1)];
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
                if ((this.lltyRsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    if ((this.lltyRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult2[] array = new LoyaltyResult2[(this.lltyRsltField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("421881e5-2c46-480c-9041-072e3eab2a8c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReversalResponse3 : IReversalResponse3 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private string saleRefIdField = default(string);
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField = default(string);
        private string issrRefDataField = default(string);
        private RetailerReversalResult2 rvslTxRsltField = new RetailerReversalResult2();
        private double rvsdAmtField = default(double);
        private bool rvsdAmtFieldSpecified = false;
        private PaymentReceipt2[] rctField = new PaymentReceipt2[0];
        private bool saleRefIdField_XSD_HasBeenSet = false;
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool issrRefDataField_XSD_HasBeenSet = false;
        private bool rvsdAmtField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleTxIdField.XSD_HasBeenSet == false))) {
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
                this.saleRefIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.saleRefIdField_XSD_HasBeenSet = (this.saleRefIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                this.issrRefDataField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.issrRefDataField_XSD_HasBeenSet = (this.issrRefDataField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public RetailerReversalResult2 RvslTxRslt {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rvslTxRsltField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rvslTxRsltField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rvslTxRsltField = new RetailerReversalResult2();
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
                this.rvsdAmtField = value;
                // BEGIN ADDED BY XSD - indicate optional system property value has been changed - RvsdAmtSpecified = true
                this.RvsdAmtSpecified = true;
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
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
        public PaymentReceipt2[] Rct {
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
                    this.rctField = new PaymentReceipt2[0];
                }
                else {
                    this.rctField = value;
                }
                // END ADDED BY XSD
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((((((((false
                            || ((this.SaleTxId != null)
                            && this.SaleTxId.XSD_HasBeenSet))
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || ((this.RvslTxRslt != null)
                            && this.RvslTxRslt.XSD_HasBeenSet))
                            || (this.RctSize() != 0))
                            || this.saleRefIdField_XSD_HasBeenSet)
                            || this.pOIRcncltnIdField_XSD_HasBeenSet)
                            || this.issrRefDataField_XSD_HasBeenSet)
                            || this.rvsdAmtField_XSD_HasBeenSet)
                            || this.RvsdAmtSpecified);
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.RvslTxRslt != null)) {
                    this.RvslTxRslt.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.RctSize()); i = (i + 1)) {
                    this.Rct[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public PaymentReceipt2 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return default(PaymentReceipt2);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt2);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
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
        public bool RctAddItem(PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length + 1)];
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
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9299b2a1-67b6-4fa1-8ed7-6df7fd4287e4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerReversalResult2 : IRetailerReversalResult2 {
        private string pOIRcncltnIdField = default(string);
        private CardPaymentTransaction100 orgnlPmtTxField = new CardPaymentTransaction100();
        private CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        public CardPaymentTransaction100 OrgnlPmtTx {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.orgnlPmtTxField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.orgnlPmtTxField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.orgnlPmtTxField = new CardPaymentTransaction100();
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
        [Newtonsoft.Json.JsonIgnore()]
        internal bool XSD_HasBeenSet {
            get {
                // BEGIN ADDED BY XSD
                return (((false
                            || ((this.OrgnlPmtTx != null)
                            && this.OrgnlPmtTx.XSD_HasBeenSet))
                            || (this.CstmrOrdrSize() != 0))
                            || this.pOIRcncltnIdField_XSD_HasBeenSet);
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
                if ((this.OrgnlPmtTx != null)) {
                    this.OrgnlPmtTx.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.CstmrOrdrSize()); i = (i + 1)) {
                    this.CstmrOrdr[i].XSD_Optimizing = this._XSD_Optimizing;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("28822bb3-e92f-4286-ae60-e7cde8afbfde")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResponse2 : ILoyaltyResponse2 {
        private TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private string pOIRcncltnIdField = default(string);
        private LoyaltyResult2[] rsltField = new LoyaltyResult2[0];
        private bool pOIRcncltnIdField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.saleTxIdField.XSD_HasBeenSet == false))) {
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
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
                this.pOIRcncltnIdField = value;
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.pOIRcncltnIdField_XSD_HasBeenSet = (this.pOIRcncltnIdField != default(string));
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rslt")]
        public LoyaltyResult2[] Rslt {
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
                    this.rsltField = new LoyaltyResult2[0];
                }
                else {
                    this.rsltField = value;
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
                            || ((this.SaleTxId != null)
                            && this.SaleTxId.XSD_HasBeenSet))
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || (this.RsltSize() != 0))
                            || this.pOIRcncltnIdField_XSD_HasBeenSet);
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
                if ((this.SaleTxId != null)) {
                    this.SaleTxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.RsltSize()); i = (i + 1)) {
                    this.Rslt[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public LoyaltyResult2 RsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult2[]))) {
                    return default(LoyaltyResult2);
                }
                else {
                    if (((this.rsltField.Length - 1)
                                >= index)) {
                        return this.rsltField[index];
                    }
                    else {
                        return default(LoyaltyResult2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(LoyaltyResult2);
            }
            // END ADDED BY XSD
        }
        public bool RsltSetItem(int index, LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult2[]))) {
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
        public bool RsltAddItem(LoyaltyResult2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    LoyaltyResult2[] array = new LoyaltyResult2[(this.rsltField.Length + 1)];
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
                if ((this.rsltField == default(LoyaltyResult2[]))) {
                    return false;
                }
                else {
                    if ((this.rsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        LoyaltyResult2[] array = new LoyaltyResult2[(this.rsltField.Length - 1)];
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("01c9a3cf-765e-481c-a2bd-52288023e765")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StoredValueResponse3 : IStoredValueResponse3 {
        private TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        private StoredValueData3[] rsltField = new StoredValueData3[0];
        private PaymentReceipt2[] rctField = new PaymentReceipt2[0];
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.pOITxIdField.XSD_HasBeenSet == false))) {
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
        public StoredValueData3[] Rslt {
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
                    this.rsltField = new StoredValueData3[0];
                }
                else {
                    this.rsltField = value;
                }
                // END ADDED BY XSD
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt2[] Rct {
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
                    this.rctField = new PaymentReceipt2[0];
                }
                else {
                    this.rctField = value;
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
                            || ((this.POITxId != null)
                            && this.POITxId.XSD_HasBeenSet))
                            || (this.RsltSize() != 0))
                            || (this.RctSize() != 0));
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
                if ((this.POITxId != null)) {
                    this.POITxId.XSD_Optimizing = this._XSD_Optimizing;
                }
                int i = 0;
                for (i = 0; (i < this.RsltSize()); i = (i + 1)) {
                    this.Rslt[i].XSD_Optimizing = this._XSD_Optimizing;
                }
                for (i = 0; (i < this.RctSize()); i = (i + 1)) {
                    this.Rct[i].XSD_Optimizing = this._XSD_Optimizing;
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
        public StoredValueData3 RsltGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rsltField == default(StoredValueData3[]))) {
                    return default(StoredValueData3);
                }
                else {
                    if (((this.rsltField.Length - 1)
                                >= index)) {
                        return this.rsltField[index];
                    }
                    else {
                        return default(StoredValueData3);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(StoredValueData3);
            }
            // END ADDED BY XSD
        }
        public bool RsltSetItem(int index, StoredValueData3 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rsltField == default(StoredValueData3[]))) {
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
        public bool RsltAddItem(StoredValueData3 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rsltField == default(StoredValueData3[]))) {
                    return false;
                }
                else {
                    StoredValueData3[] array = new StoredValueData3[(this.rsltField.Length + 1)];
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
                if ((this.rsltField == default(StoredValueData3[]))) {
                    return false;
                }
                else {
                    if ((this.rsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        StoredValueData3[] array = new StoredValueData3[(this.rsltField.Length - 1)];
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
        public PaymentReceipt2 RctGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return default(PaymentReceipt2);
                }
                else {
                    if (((this.rctField.Length - 1)
                                >= index)) {
                        return this.rctField[index];
                    }
                    else {
                        return default(PaymentReceipt2);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PaymentReceipt2);
            }
            // END ADDED BY XSD
        }
        public bool RctSetItem(int index, PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
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
        public bool RctAddItem(PaymentReceipt2 value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length + 1)];
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
                if ((this.rctField == default(PaymentReceipt2[]))) {
                    return false;
                }
                else {
                    if ((this.rctField.Length <= index)) {
                        return false;
                    }
                    else {
                        PaymentReceipt2[] array = new PaymentReceipt2[(this.rctField.Length - 1)];
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
    [System.Runtime.InteropServices.GuidAttribute("5f72eb62-df1a-4188-8c8e-2080a892c436")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAction10 {
        /// <remarks/>
        [DispId(1)]
        ActionType9Code ActnTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        ActionMessage7 MsgToPres {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("af3cbdc9-9ab0-4c2e-be56-4b08bd6c419e")]
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
    }
    [System.Runtime.InteropServices.GuidAttribute("f0d4dbf1-298a-4fbe-a19d-ac59536ba75d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAuthorisationResult14 {
        /// <remarks/>
        [DispId(1)]
        GenericIdentification90 AuthstnNtty {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ResponseType10 RspnToAuthstn {
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
    }
    [System.Runtime.InteropServices.GuidAttribute("44b090e7-83da-4593-b7f7-97c027185011")]
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
        }
        /// <remarks/>
        [DispId(3)]
        PartyType4Code Issr {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("f3a22262-ed55-46d6-a673-9319af0e277c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IResponseType10 {
        /// <remarks/>
        [DispId(1)]
        Response9Code Rspn {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("2da600e8-01aa-4187-bc1f-6d950cba1004")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ITMSTrigger1 {
        /// <remarks/>
        [DispId(1)]
        TMSContactLevel1Code TMSCtctLvl {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("dad58fc7-1b50-4e67-a9bc-200b74d8533b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IBalanceInquiryResponse2 {
        /// <remarks/>
        [DispId(1)]
        PaymentAccount3 PmtAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        LoyaltyAccount2 LltyAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        StoredValueAccount2[] StordValAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(4)]
        PaymentReceipt2[] Rct {
            get;
            set;
        }
        [DispId(5)]
        int StordValAcctSize();
        [DispId(6)]
        StoredValueAccount2 StordValAcctGetItem(int index);
        [DispId(7)]
        bool StordValAcctSetItem(int index, StoredValueAccount2 value);
        [DispId(8)]
        bool StordValAcctAddItem(StoredValueAccount2 value);
        [DispId(9)]
        bool StordValAcctRemoveItem(int index);
        [DispId(10)]
        int RctSize();
        [DispId(11)]
        PaymentReceipt2 RctGetItem(int index);
        [DispId(12)]
        bool RctSetItem(int index, PaymentReceipt2 value);
        [DispId(13)]
        bool RctAddItem(PaymentReceipt2 value);
        [DispId(14)]
        bool RctRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("aec8b214-a4ef-491f-bcf4-0b2ea204c962")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentAccount3 {
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
        Acquirer10 PmtAcqrrData {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ff9c1a3f-16d3-4e9b-969c-7c99df0743ed")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentReceipt2 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
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
        ActionMessage7 OutptCntt {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2a32d05e-f50f-4342-aefa-78798554d725")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IBatchResponse2 {
        /// <remarks/>
        [DispId(1)]
        PerformedTransaction2[] PrfrmdTx {
            get;
            set;
        }
        [DispId(2)]
        int PrfrmdTxSize();
        [DispId(3)]
        PerformedTransaction2 PrfrmdTxGetItem(int index);
        [DispId(4)]
        bool PrfrmdTxSetItem(int index, PerformedTransaction2 value);
        [DispId(5)]
        bool PrfrmdTxAddItem(PerformedTransaction2 value);
        [DispId(6)]
        bool PrfrmdTxRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("8a3fb9ba-0d48-4eaa-818a-76ad9e7b8051")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPerformedTransaction2 {
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
        RetailerPaymentResult2 PmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        LoyaltyResult2[] LltyRslt {
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
        int LltyRsltSize();
        [DispId(10)]
        LoyaltyResult2 LltyRsltGetItem(int index);
        [DispId(11)]
        bool LltyRsltSetItem(int index, LoyaltyResult2 value);
        [DispId(12)]
        bool LltyRsltAddItem(LoyaltyResult2 value);
        [DispId(13)]
        bool LltyRsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("9f408926-e133-442c-9be1-3ae5954be1d2")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IResponseType9 {
        /// <remarks/>
        [DispId(1)]
        Response5Code Rspn {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        RetailerResultDetail1Code RspnRsn {
            get;
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
    }
    [System.Runtime.InteropServices.GuidAttribute("d8899017-a5f1-4d8c-b643-cf681d0cdae0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerPaymentResult2 {
        /// <remarks/>
        [DispId(1)]
        CardPaymentServiceType12Code TxTp {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentServiceType9Code[] AddtlSvc {
            get;
        }
        /// <remarks/>
        [DispId(3)]
        CardPaymentServiceType3Code SvcAttr {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        bool SvcAttrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CardPaymentTransaction100 ReqdTx {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        CardPaymentTransaction94 TxRspn {
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
        ContentInformationType22 PrtctdCaptrdSgntr {
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
        int AddtlSvcSize();
        [DispId(16)]
        CardPaymentServiceType9Code AddtlSvcGetItem(int index);
        [DispId(17)]
        bool AddtlSvcSetItem(int index, CardPaymentServiceType9Code value);
        [DispId(18)]
        bool AddtlSvcAddItem(CardPaymentServiceType9Code value);
        [DispId(19)]
        bool AddtlSvcRemoveItem(int index);
        [DispId(20)]
        int CstmrOrdrSize();
        [DispId(21)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(22)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(23)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(24)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("163013ee-a4e9-495b-8bc3-11bc47407c1d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICardPaymentTransaction94 {
        /// <remarks/>
        [DispId(1)]
        AuthorisationResult14 AuthstnRslt {
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
        ContentInformationType22 PrtctdBal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        Action10[] Actn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        CurrencyConversion19 CcyConvsElgblty {
            get;
            set;
        }
        [DispId(10)]
        int TxVrfctnRsltSize();
        [DispId(11)]
        TransactionVerificationResult4 TxVrfctnRsltGetItem(int index);
        [DispId(12)]
        bool TxVrfctnRsltSetItem(int index, TransactionVerificationResult4 value);
        [DispId(13)]
        bool TxVrfctnRsltAddItem(TransactionVerificationResult4 value);
        [DispId(14)]
        bool TxVrfctnRsltRemoveItem(int index);
        [DispId(15)]
        int AllwdPdctCdSize();
        [DispId(16)]
        Product4 AllwdPdctCdGetItem(int index);
        [DispId(17)]
        bool AllwdPdctCdSetItem(int index, Product4 value);
        [DispId(18)]
        bool AllwdPdctCdAddItem(Product4 value);
        [DispId(19)]
        bool AllwdPdctCdRemoveItem(int index);
        [DispId(20)]
        int NotAllwdPdctCdSize();
        [DispId(21)]
        Product4 NotAllwdPdctCdGetItem(int index);
        [DispId(22)]
        bool NotAllwdPdctCdSetItem(int index, Product4 value);
        [DispId(23)]
        bool NotAllwdPdctCdAddItem(Product4 value);
        [DispId(24)]
        bool NotAllwdPdctCdRemoveItem(int index);
        [DispId(25)]
        int AddtlAvlblPdctSize();
        [DispId(26)]
        Product5 AddtlAvlblPdctGetItem(int index);
        [DispId(27)]
        bool AddtlAvlblPdctSetItem(int index, Product5 value);
        [DispId(28)]
        bool AddtlAvlblPdctAddItem(Product5 value);
        [DispId(29)]
        bool AddtlAvlblPdctRemoveItem(int index);
        [DispId(30)]
        int ActnSize();
        [DispId(31)]
        Action10 ActnGetItem(int index);
        [DispId(32)]
        bool ActnSetItem(int index, Action10 value);
        [DispId(33)]
        bool ActnAddItem(Action10 value);
        [DispId(34)]
        bool ActnRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("a02b82a4-7f81-4ab5-8a15-05cee46c2484")]
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
    }
    [System.Runtime.InteropServices.GuidAttribute("acb064ed-547a-4565-8c70-3826b3f80952")]
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
        }
        /// <remarks/>
        [DispId(8)]
        bool UnitOfMeasrSpecified {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7f758010-807a-47cf-8364-f236c83ef78b")]
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
        int ImgDataSize();
        [DispId(6)]
        byte ImgDataGetItem(int index);
        [DispId(7)]
        bool ImgDataSetItem(int index, byte value);
        [DispId(8)]
        bool ImgDataAddItem(byte value);
        [DispId(9)]
        bool ImgDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("3e37e8bb-f828-435a-a8aa-2bb7c9bd3183")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyResult2 {
        /// <remarks/>
        [DispId(1)]
        LoyaltyAccount2 Acct {
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
    }
    [System.Runtime.InteropServices.GuidAttribute("f71a46ee-62a7-4939-b60c-87816ca6f503")]
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
    }
    [System.Runtime.InteropServices.GuidAttribute("f23414ae-c07b-49c8-8cc3-393997da5c10")]
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
        int SaleItmRbtSize();
        [DispId(6)]
        SaleItemRebate1 SaleItmRbtGetItem(int index);
        [DispId(7)]
        bool SaleItmRbtSetItem(int index, SaleItemRebate1 value);
        [DispId(8)]
        bool SaleItmRbtAddItem(SaleItemRebate1 value);
        [DispId(9)]
        bool SaleItmRbtRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("d7da12ea-c384-4635-bd66-22e04ff69222")]
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
    }
    [System.Runtime.InteropServices.GuidAttribute("d32cac72-e447-4ea6-825e-db2e7baf02b6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ICardAcquisitionResponse2 {
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
        LoyaltyAccount2[] LltyAcct {
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
        int PmtBrndSize();
        [DispId(7)]
        string PmtBrndGetItem(int index);
        [DispId(8)]
        bool PmtBrndSetItem(int index, string value);
        [DispId(9)]
        bool PmtBrndAddItem(string value);
        [DispId(10)]
        bool PmtBrndRemoveItem(int index);
        [DispId(11)]
        int LltyAcctSize();
        [DispId(12)]
        LoyaltyAccount2 LltyAcctGetItem(int index);
        [DispId(13)]
        bool LltyAcctSetItem(int index, LoyaltyAccount2 value);
        [DispId(14)]
        bool LltyAcctAddItem(LoyaltyAccount2 value);
        [DispId(15)]
        bool LltyAcctRemoveItem(int index);
        [DispId(16)]
        int CstmrOrdrSize();
        [DispId(17)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(18)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(19)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(20)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("c8db9669-4bab-4452-8014-61b3f7ef91ef")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIServiceResponseV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        ServiceResponse3 SvcRspn {
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
    [System.Runtime.InteropServices.GuidAttribute("14ae8fc6-c20b-4267-9384-4f3c44addca8")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IServiceResponse3 {
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
        RetailerService3Code SvcCntt {
            get;
        }
        /// <remarks/>
        [DispId(4)]
        PaymentResponse2 PmtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ReversalResponse3 RvslRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(6)]
        BalanceInquiryResponse2 BalNqryRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyResponse2 LltyRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        StoredValueResponse3 StordValRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        PerformedTransaction2[] BtchRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(10)]
        CardAcquisitionResponse2 CardAcqstnRspn {
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
        int BtchRspnSize();
        [DispId(14)]
        PerformedTransaction2 BtchRspnGetItem(int index);
        [DispId(15)]
        bool BtchRspnSetItem(int index, PerformedTransaction2 value);
        [DispId(16)]
        bool BtchRspnAddItem(PerformedTransaction2 value);
        [DispId(17)]
        bool BtchRspnRemoveItem(int index);
        [DispId(18)]
        int SplmtryDataSize();
        [DispId(19)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(20)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(21)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(22)]
        bool SplmtryDataRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("6510d43d-c23a-43e5-8984-664101edc4fa")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPaymentResponse2 {
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
        RetailerPaymentResult2 RtlrPmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        PaymentReceipt2[] PmtRct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(8)]
        LoyaltyResult2[] LltyRslt {
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
        int PmtRctSize();
        [DispId(11)]
        PaymentReceipt2 PmtRctGetItem(int index);
        [DispId(12)]
        bool PmtRctSetItem(int index, PaymentReceipt2 value);
        [DispId(13)]
        bool PmtRctAddItem(PaymentReceipt2 value);
        [DispId(14)]
        bool PmtRctRemoveItem(int index);
        [DispId(15)]
        int LltyRsltSize();
        [DispId(16)]
        LoyaltyResult2 LltyRsltGetItem(int index);
        [DispId(17)]
        bool LltyRsltSetItem(int index, LoyaltyResult2 value);
        [DispId(18)]
        bool LltyRsltAddItem(LoyaltyResult2 value);
        [DispId(19)]
        bool LltyRsltRemoveItem(int index);
        [DispId(20)]
        int CstmrOrdrSize();
        [DispId(21)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(22)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(23)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(24)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("6bcd4dd4-071e-4c4c-8f2b-4d1c7e002f63")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReversalResponse3 {
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
        RetailerReversalResult2 RvslTxRslt {
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
        PaymentReceipt2[] Rct {
            get;
            set;
        }
        [DispId(10)]
        int RctSize();
        [DispId(11)]
        PaymentReceipt2 RctGetItem(int index);
        [DispId(12)]
        bool RctSetItem(int index, PaymentReceipt2 value);
        [DispId(13)]
        bool RctAddItem(PaymentReceipt2 value);
        [DispId(14)]
        bool RctRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("1f1fea46-d3bf-4681-8aec-f7b49b082b91")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IRetailerReversalResult2 {
        /// <remarks/>
        [DispId(1)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        CardPaymentTransaction100 OrgnlPmtTx {
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
        int CstmrOrdrSize();
        [DispId(5)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(6)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(7)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(8)]
        bool CstmrOrdrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("3c58b390-a8dd-4e86-8c2d-4eb411a1060b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ILoyaltyResponse2 {
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
        LoyaltyResult2[] Rslt {
            get;
            set;
        }
        [DispId(5)]
        int RsltSize();
        [DispId(6)]
        LoyaltyResult2 RsltGetItem(int index);
        [DispId(7)]
        bool RsltSetItem(int index, LoyaltyResult2 value);
        [DispId(8)]
        bool RsltAddItem(LoyaltyResult2 value);
        [DispId(9)]
        bool RsltRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("5b4023dd-4d4d-4f2f-a087-62fb1978ee4c")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IStoredValueResponse3 {
        /// <remarks/>
        [DispId(1)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        StoredValueData3[] Rslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PaymentReceipt2[] Rct {
            get;
            set;
        }
        [DispId(4)]
        int RsltSize();
        [DispId(5)]
        StoredValueData3 RsltGetItem(int index);
        [DispId(6)]
        bool RsltSetItem(int index, StoredValueData3 value);
        [DispId(7)]
        bool RsltAddItem(StoredValueData3 value);
        [DispId(8)]
        bool RsltRemoveItem(int index);
        [DispId(9)]
        int RctSize();
        [DispId(10)]
        PaymentReceipt2 RctGetItem(int index);
        [DispId(11)]
        bool RctSetItem(int index, PaymentReceipt2 value);
        [DispId(12)]
        bool RctAddItem(PaymentReceipt2 value);
        [DispId(13)]
        bool RctRemoveItem(int index);
    }
}
#endif
