namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e0e437ff-a5d4-4596-86a2-6e5d0c20d506")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Action8 : IAction8 {
        internal ActionType7Code actnTpField = new ActionType7Code();
        internal ActionMessage2 msgToPresField = new ActionMessage2();
        internal bool xsdAction8InitFlagField = false;
        /// <remarks/>
        public ActionType7Code ActnTp {
            get {
                return this.actnTpField;
            }
            set {
                this.xsdAction8InitFlagField = true;
                this.actnTpField = value;
            }
        }
        /// <remarks/>
        public ActionMessage2 MsgToPres {
            get {
                return this.msgToPresField;
            }
            set {
                this.xsdAction8InitFlagField = true;
                this.msgToPresField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdAction8InitFlag {
            get {
                return this.xsdAction8InitFlagField;
            }
            set {
                this.xsdAction8InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("cc37e6bc-faaa-463f-9991-f7386a000987")]
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
        [DispId(3)]
        ActionMessage2 MsgToPres {
            get;
            set;
        }
        [DispId(5)]
        bool xsdAction8InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d14cad57-06e7-42a1-93fe-986c81c3ae48")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActionMessage2 : IActionMessage2 {
        internal UserInterface4Code msgDstnField = new UserInterface4Code();
        internal OutputFormat1Code frmtField = new OutputFormat1Code();
        internal bool frmtFieldSpecified;
        internal string msgCnttField;
        internal byte[] msgCnttSgntrField = new byte[0];
        internal bool xsdActionMessage2InitFlagField = false;
        /// <remarks/>
        public UserInterface4Code MsgDstn {
            get {
                return this.msgDstnField;
            }
            set {
                this.xsdActionMessage2InitFlagField = true;
                this.msgDstnField = value;
            }
        }
        /// <remarks/>
        public OutputFormat1Code Frmt {
            get {
                return this.frmtField;
            }
            set {
                this.xsdActionMessage2InitFlagField = true;
                this.frmtField = value;
                this.FrmtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrmtSpecified {
            get {
                return this.frmtFieldSpecified;
            }
            set {
                this.xsdActionMessage2InitFlagField = true;
                this.frmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string MsgCntt {
            get {
                return this.msgCnttField;
            }
            set {
                this.xsdActionMessage2InitFlagField = true;
                this.msgCnttField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgCnttSgntr {
            get {
                if (((this.msgCnttSgntrField == null)
                            || (this.msgCnttSgntrField.Length == 0))) {
                    return null;
                }
                return this.msgCnttSgntrField;
            }
            set {
                this.xsdActionMessage2InitFlagField = true;
                this.msgCnttSgntrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdActionMessage2InitFlag {
            get {
                return this.xsdActionMessage2InitFlagField;
            }
            set {
                this.xsdActionMessage2InitFlagField = value;
            }
        }
        public int MsgCnttSgntrSize() {
            if ((this.msgCnttSgntrField == null)) {
                return 0;
            }
            else {
                return this.msgCnttSgntrField.Length;
            }
        }
        public byte MsgCnttSgntrGetItem(int index) {
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
        }
        public bool MsgCnttSgntrSetItem(int index, byte value) {
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
        }
        public bool MsgCnttSgntrAddItem(byte value) {
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
        }
        public bool MsgCnttSgntrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("20bd8915-e90d-4794-b2a3-0d14bbf2b3f8")]
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
        [DispId(3)]
        OutputFormat1Code Frmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool FrmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string MsgCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        byte[] MsgCnttSgntr {
            get;
            set;
        }
        [DispId(11)]
        bool xsdActionMessage2InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int MsgCnttSgntrSize();
        [DispId(13)]
        byte MsgCnttSgntrGetItem(int index);
        [DispId(14)]
        bool MsgCnttSgntrSetItem(int index, byte value);
        [DispId(15)]
        bool MsgCnttSgntrAddItem(byte value);
        [DispId(16)]
        bool MsgCnttSgntrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7cab5e8f-7f7a-47f1-bca7-5b4032e557b9")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AmountAndDirection93 : IAmountAndDirection93 {
        internal double amtField;
        internal string ccyField;
        internal bool sgnField;
        internal bool sgnFieldSpecified;
        internal bool xsdAmountAndDirection93InitFlagField = false;
        /// <remarks/>
        public double Amt {
            get {
                return this.amtField;
            }
            set {
                this.xsdAmountAndDirection93InitFlagField = true;
                this.amtField = value;
            }
        }
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.xsdAmountAndDirection93InitFlagField = true;
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public bool Sgn {
            get {
                return this.sgnField;
            }
            set {
                this.xsdAmountAndDirection93InitFlagField = true;
                this.sgnField = value;
                this.SgnSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SgnSpecified {
            get {
                return this.sgnFieldSpecified;
            }
            set {
                this.xsdAmountAndDirection93InitFlagField = true;
                this.sgnFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdAmountAndDirection93InitFlag {
            get {
                return this.xsdAmountAndDirection93InitFlagField;
            }
            set {
                this.xsdAmountAndDirection93InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("32329ed2-e3fb-45e6-bf58-4692854f0dbb")]
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
        [DispId(3)]
        string Ccy {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool Sgn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool SgnSpecified {
            get;
            set;
        }
        [DispId(9)]
        bool xsdAmountAndDirection93InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("cab1298c-557c-43f0-a108-d08513f07088")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AuthorisationResult10 : IAuthorisationResult10 {
        internal GenericIdentification90 authstnNttyField = new GenericIdentification90();
        internal ResponseType5 rspnToAuthstnField = new ResponseType5();
        internal string authstnCdField;
        internal bool cmpltnReqrdField;
        internal bool cmpltnReqrdFieldSpecified;
        internal TMSTrigger1 tMSTrggrField = new TMSTrigger1();
        internal bool xsdAuthorisationResult10InitFlagField = false;
        /// <remarks/>
        public GenericIdentification90 AuthstnNtty {
            get {
                return this.authstnNttyField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.authstnNttyField = value;
            }
        }
        /// <remarks/>
        public ResponseType5 RspnToAuthstn {
            get {
                return this.rspnToAuthstnField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.rspnToAuthstnField = value;
            }
        }
        /// <remarks/>
        public string AuthstnCd {
            get {
                return this.authstnCdField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.authstnCdField = value;
            }
        }
        /// <remarks/>
        public bool CmpltnReqrd {
            get {
                return this.cmpltnReqrdField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.cmpltnReqrdField = value;
                this.CmpltnReqrdSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CmpltnReqrdSpecified {
            get {
                return this.cmpltnReqrdFieldSpecified;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.cmpltnReqrdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public TMSTrigger1 TMSTrggr {
            get {
                return this.tMSTrggrField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = true;
                this.tMSTrggrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdAuthorisationResult10InitFlag {
            get {
                return this.xsdAuthorisationResult10InitFlagField;
            }
            set {
                this.xsdAuthorisationResult10InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("060c0eab-e07e-4705-9656-e780f0f58382")]
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
        [DispId(3)]
        ResponseType5 RspnToAuthstn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string AuthstnCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool CmpltnReqrd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool CmpltnReqrdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        TMSTrigger1 TMSTrggr {
            get;
            set;
        }
        [DispId(13)]
        bool xsdAuthorisationResult10InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2e746788-853d-42b1-afc5-b226f81b57b6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class GenericIdentification90 : IGenericIdentification90 {
        internal string idField;
        internal PartyType14Code tpField = new PartyType14Code();
        internal PartyType4Code issrField = new PartyType4Code();
        internal bool issrFieldSpecified;
        internal string ctryField;
        internal string shrtNmField;
        internal bool xsdGenericIdentification90InitFlagField = false;
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.idField = value;
            }
        }
        /// <remarks/>
        public PartyType14Code Tp {
            get {
                return this.tpField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.tpField = value;
            }
        }
        /// <remarks/>
        public PartyType4Code Issr {
            get {
                return this.issrField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.issrField = value;
                this.IssrSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IssrSpecified {
            get {
                return this.issrFieldSpecified;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.issrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string Ctry {
            get {
                return this.ctryField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.ctryField = value;
            }
        }
        /// <remarks/>
        public string ShrtNm {
            get {
                return this.shrtNmField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = true;
                this.shrtNmField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdGenericIdentification90InitFlag {
            get {
                return this.xsdGenericIdentification90InitFlagField;
            }
            set {
                this.xsdGenericIdentification90InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("847d8d2b-2e42-4635-b5fe-b739701ec152")]
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
        [DispId(3)]
        PartyType14Code Tp {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        PartyType4Code Issr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool IssrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string Ctry {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        string ShrtNm {
            get;
            set;
        }
        [DispId(13)]
        bool xsdGenericIdentification90InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4e379705-2316-4478-98bc-7e32d0047b71")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType5 : IResponseType5 {
        internal Response4Code rspnField = new Response4Code();
        internal string rspnRsnField;
        internal string addtlRspnInfField;
        internal bool xsdResponseType5InitFlagField = false;
        /// <remarks/>
        public Response4Code Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdResponseType5InitFlagField = true;
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public string RspnRsn {
            get {
                return this.rspnRsnField;
            }
            set {
                this.xsdResponseType5InitFlagField = true;
                this.rspnRsnField = value;
            }
        }
        /// <remarks/>
        public string AddtlRspnInf {
            get {
                return this.addtlRspnInfField;
            }
            set {
                this.xsdResponseType5InitFlagField = true;
                this.addtlRspnInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdResponseType5InitFlag {
            get {
                return this.xsdResponseType5InitFlagField;
            }
            set {
                this.xsdResponseType5InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("f063c474-cba4-44da-adca-2abb1d38265a")]
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
        [DispId(3)]
        string RspnRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string AddtlRspnInf {
            get;
            set;
        }
        [DispId(7)]
        bool xsdResponseType5InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2b8c8866-ea5d-418b-83cc-697efc18e67a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TMSTrigger1 : ITMSTrigger1 {
        internal TMSContactLevel1Code tMSCtctLvlField = new TMSContactLevel1Code();
        internal string tMSIdField;
        internal string tMSCtctDtTmField;
        internal bool tMSCtctDtTmFieldSpecified;
        internal bool xsdTMSTrigger1InitFlagField = false;
        /// <remarks/>
        public TMSContactLevel1Code TMSCtctLvl {
            get {
                return this.tMSCtctLvlField;
            }
            set {
                this.xsdTMSTrigger1InitFlagField = true;
                this.tMSCtctLvlField = value;
            }
        }
        /// <remarks/>
        public string TMSId {
            get {
                return this.tMSIdField;
            }
            set {
                this.xsdTMSTrigger1InitFlagField = true;
                this.tMSIdField = value;
            }
        }
        /// <remarks/>
        public string TMSCtctDtTm {
            get {
                return this.tMSCtctDtTmField;
            }
            set {
                this.xsdTMSTrigger1InitFlagField = true;
                this.tMSCtctDtTmField = value;
                this.TMSCtctDtTmSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TMSCtctDtTmSpecified {
            get {
                return this.tMSCtctDtTmFieldSpecified;
            }
            set {
                this.xsdTMSTrigger1InitFlagField = true;
                this.tMSCtctDtTmFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdTMSTrigger1InitFlag {
            get {
                return this.xsdTMSTrigger1InitFlagField;
            }
            set {
                this.xsdTMSTrigger1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6d54e303-0a1b-4b00-bb1e-f84cf3ac9091")]
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
        [DispId(3)]
        string TMSId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string TMSCtctDtTm {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool TMSCtctDtTmSpecified {
            get;
            set;
        }
        [DispId(9)]
        bool xsdTMSTrigger1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1eace2ac-d3ac-4313-898f-8efb4a9d3838")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BalanceInquiryResponse1 : IBalanceInquiryResponse1 {
        internal PaymentAccount2 pmtAcctField = new PaymentAccount2();
        internal LoyaltyAccount1 lltyAcctField = new LoyaltyAccount1();
        internal StoredValueAccount1[] stordValAcctField = new StoredValueAccount1[0];
        internal PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        internal bool xsdBalanceInquiryResponse1InitFlagField = false;
        /// <remarks/>
        public PaymentAccount2 PmtAcct {
            get {
                return this.pmtAcctField;
            }
            set {
                this.xsdBalanceInquiryResponse1InitFlagField = true;
                this.pmtAcctField = value;
            }
        }
        /// <remarks/>
        public LoyaltyAccount1 LltyAcct {
            get {
                return this.lltyAcctField;
            }
            set {
                this.xsdBalanceInquiryResponse1InitFlagField = true;
                this.lltyAcctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StordValAcct")]
        public StoredValueAccount1[] StordValAcct {
            get {
                if (((this.stordValAcctField == null)
                            || (this.stordValAcctField.Length == 0))) {
                    return null;
                }
                return this.stordValAcctField;
            }
            set {
                this.xsdBalanceInquiryResponse1InitFlagField = true;
                this.stordValAcctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                return this.rctField;
            }
            set {
                this.xsdBalanceInquiryResponse1InitFlagField = true;
                this.rctField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdBalanceInquiryResponse1InitFlag {
            get {
                return this.xsdBalanceInquiryResponse1InitFlagField;
            }
            set {
                this.xsdBalanceInquiryResponse1InitFlagField = value;
            }
        }
        public int StordValAcctSize() {
            if ((this.stordValAcctField == null)) {
                return 0;
            }
            else {
                return this.stordValAcctField.Length;
            }
        }
        public StoredValueAccount1 StordValAcctGetItem(int index) {
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
        }
        public bool StordValAcctSetItem(int index, StoredValueAccount1 value) {
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
        }
        public bool StordValAcctAddItem(StoredValueAccount1 value) {
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
        }
        public bool StordValAcctRemoveItem(int index) {
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
        }
        public int RctSize() {
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
        }
        public PaymentReceipt1 RctGetItem(int index) {
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
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
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
        }
        public bool RctAddItem(PaymentReceipt1 value) {
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
        }
        public bool RctRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a77ff997-eb52-482d-83ab-6b71e9b1c316")]
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
        [DispId(3)]
        LoyaltyAccount1 LltyAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        StoredValueAccount1[] StordValAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(9)]
        bool xsdBalanceInquiryResponse1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int StordValAcctSize();
        [DispId(11)]
        StoredValueAccount1 StordValAcctGetItem(int index);
        [DispId(12)]
        bool StordValAcctSetItem(int index, StoredValueAccount1 value);
        [DispId(13)]
        bool StordValAcctAddItem(StoredValueAccount1 value);
        [DispId(14)]
        bool StordValAcctRemoveItem(int index);
        [DispId(15)]
        int RctSize();
        [DispId(16)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(17)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(18)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(19)]
        bool RctRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("fea54328-e80a-4b22-a7ce-a310a4526ed0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentAccount2 : IPaymentAccount2 {
        internal string ccyField;
        internal double curBalField;
        internal bool curBalFieldSpecified;
        internal Acquirer9 pmtAcqrrDataField = new Acquirer9();
        internal bool xsdPaymentAccount2InitFlagField = false;
        /// <remarks/>
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.xsdPaymentAccount2InitFlagField = true;
                this.ccyField = value;
            }
        }
        /// <remarks/>
        public double CurBal {
            get {
                return this.curBalField;
            }
            set {
                this.xsdPaymentAccount2InitFlagField = true;
                this.curBalField = value;
                this.CurBalSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurBalSpecified {
            get {
                return this.curBalFieldSpecified;
            }
            set {
                this.xsdPaymentAccount2InitFlagField = true;
                this.curBalFieldSpecified = value;
            }
        }
        /// <remarks/>
        public Acquirer9 PmtAcqrrData {
            get {
                return this.pmtAcqrrDataField;
            }
            set {
                this.xsdPaymentAccount2InitFlagField = true;
                this.pmtAcqrrDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdPaymentAccount2InitFlag {
            get {
                return this.xsdPaymentAccount2InitFlagField;
            }
            set {
                this.xsdPaymentAccount2InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8236ff93-f1f7-4a60-a85a-28908d7bb2ff")]
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
        [DispId(3)]
        double CurBal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool CurBalSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        Acquirer9 PmtAcqrrData {
            get;
            set;
        }
        [DispId(9)]
        bool xsdPaymentAccount2InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("cfd13c7c-2963-4cad-8fb8-25b97c11c9ff")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentReceipt1 : IPaymentReceipt1 {
        internal DocumentType7Code docQlfrField = new DocumentType7Code();
        internal bool intgrtdPrtFlgField;
        internal bool intgrtdPrtFlgFieldSpecified;
        internal bool reqrdSgntrFlgField;
        internal bool reqrdSgntrFlgFieldSpecified;
        internal ActionMessage6 outptCnttField = new ActionMessage6();
        internal bool xsdPaymentReceipt1InitFlagField = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
            set {
                this.xsdPaymentReceipt1InitFlagField = true;
                this.docQlfrField = value;
            }
        }
        /// <remarks/>
        public bool IntgrtdPrtFlg {
            get {
                return this.intgrtdPrtFlgField;
            }
            set {
                this.xsdPaymentReceipt1InitFlagField = true;
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
                this.xsdPaymentReceipt1InitFlagField = true;
                this.intgrtdPrtFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public bool ReqrdSgntrFlg {
            get {
                return this.reqrdSgntrFlgField;
            }
            set {
                this.xsdPaymentReceipt1InitFlagField = true;
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
                this.xsdPaymentReceipt1InitFlagField = true;
                this.reqrdSgntrFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 OutptCntt {
            get {
                return this.outptCnttField;
            }
            set {
                this.xsdPaymentReceipt1InitFlagField = true;
                this.outptCnttField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdPaymentReceipt1InitFlag {
            get {
                return this.xsdPaymentReceipt1InitFlagField;
            }
            set {
                this.xsdPaymentReceipt1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6700d06c-9694-49a7-b0b2-18b6a0af2215")]
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
        [DispId(3)]
        bool IntgrtdPrtFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool IntgrtdPrtFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool ReqrdSgntrFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool ReqrdSgntrFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        ActionMessage6 OutptCntt {
            get;
            set;
        }
        [DispId(13)]
        bool xsdPaymentReceipt1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("68b5c399-5f16-4507-8edd-ef57d4c9efb0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class BatchResponse1 : IBatchResponse1 {
        internal PerformedTransaction1[] prfrmdTxField = new PerformedTransaction1[0];
        internal bool xsdBatchResponse1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrfrmdTx")]
        public PerformedTransaction1[] PrfrmdTx {
            get {
                if (((this.prfrmdTxField == null)
                            || (this.prfrmdTxField.Length == 0))) {
                    return null;
                }
                return this.prfrmdTxField;
            }
            set {
                this.xsdBatchResponse1InitFlagField = true;
                this.prfrmdTxField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdBatchResponse1InitFlag {
            get {
                return this.xsdBatchResponse1InitFlagField;
            }
            set {
                this.xsdBatchResponse1InitFlagField = value;
            }
        }
        public int PrfrmdTxSize() {
            if ((this.prfrmdTxField == null)) {
                return 0;
            }
            else {
                return this.prfrmdTxField.Length;
            }
        }
        public PerformedTransaction1 PrfrmdTxGetItem(int index) {
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
        }
        public bool PrfrmdTxSetItem(int index, PerformedTransaction1 value) {
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
        }
        public bool PrfrmdTxAddItem(PerformedTransaction1 value) {
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
        }
        public bool PrfrmdTxRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("cfd6001a-cb0c-490d-816f-c250c474f4e0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IBatchResponse1 {
        /// <remarks/>
        [DispId(1)]
        PerformedTransaction1[] PrfrmdTx {
            get;
            set;
        }
        [DispId(3)]
        bool xsdBatchResponse1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int PrfrmdTxSize();
        [DispId(5)]
        PerformedTransaction1 PrfrmdTxGetItem(int index);
        [DispId(6)]
        bool PrfrmdTxSetItem(int index, PerformedTransaction1 value);
        [DispId(7)]
        bool PrfrmdTxAddItem(PerformedTransaction1 value);
        [DispId(8)]
        bool PrfrmdTxRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("8a95ddb8-92bd-41fc-a7de-4e3f21c118aa")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PerformedTransaction1 : IPerformedTransaction1 {
        internal ResponseType9 rspnField = new ResponseType9();
        internal TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal string pOIRcncltnIdField;
        internal RetailerPaymentResult1 pmtRsltField = new RetailerPaymentResult1();
        internal LoyaltyResult1[] lltyRsltField = new LoyaltyResult1[0];
        internal double rvsdAmtField;
        internal bool rvsdAmtFieldSpecified;
        internal bool xsdPerformedTransaction1InitFlagField = false;
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                return this.saleTxIdField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.saleTxIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public RetailerPaymentResult1 PmtRslt {
            get {
                return this.pmtRsltField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.pmtRsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult1[] LltyRslt {
            get {
                if (((this.lltyRsltField == null)
                            || (this.lltyRsltField.Length == 0))) {
                    return null;
                }
                return this.lltyRsltField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.lltyRsltField = value;
            }
        }
        /// <remarks/>
        public double RvsdAmt {
            get {
                return this.rvsdAmtField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.rvsdAmtField = value;
                this.RvsdAmtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RvsdAmtSpecified {
            get {
                return this.rvsdAmtFieldSpecified;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = true;
                this.rvsdAmtFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdPerformedTransaction1InitFlag {
            get {
                return this.xsdPerformedTransaction1InitFlagField;
            }
            set {
                this.xsdPerformedTransaction1InitFlagField = value;
            }
        }
        public int LltyRsltSize() {
            if ((this.lltyRsltField == null)) {
                return 0;
            }
            else {
                return this.lltyRsltField.Length;
            }
        }
        public LoyaltyResult1 LltyRsltGetItem(int index) {
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
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult1 value) {
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
        }
        public bool LltyRsltAddItem(LoyaltyResult1 value) {
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
        }
        public bool LltyRsltRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2eb45801-1648-41f2-8937-474cf61a367e")]
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
        [DispId(3)]
        TransactionIdentifier1 SaleTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        RetailerPaymentResult1 PmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        LoyaltyResult1[] LltyRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        double RvsdAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool RvsdAmtSpecified {
            get;
            set;
        }
        [DispId(17)]
        bool xsdPerformedTransaction1InitFlag {
            get;
            set;
        }
        [DispId(18)]
        int LltyRsltSize();
        [DispId(19)]
        LoyaltyResult1 LltyRsltGetItem(int index);
        [DispId(20)]
        bool LltyRsltSetItem(int index, LoyaltyResult1 value);
        [DispId(21)]
        bool LltyRsltAddItem(LoyaltyResult1 value);
        [DispId(22)]
        bool LltyRsltRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("da15cea1-56d0-4cc4-8e91-2f7ede98f374")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ResponseType9 : IResponseType9 {
        internal Response5Code rspnField = new Response5Code();
        internal RetailerResultDetail1Code rspnRsnField = new RetailerResultDetail1Code();
        internal bool rspnRsnFieldSpecified;
        internal string addtlRspnInfField;
        internal bool xsdResponseType9InitFlagField = false;
        /// <remarks/>
        public Response5Code Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdResponseType9InitFlagField = true;
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public RetailerResultDetail1Code RspnRsn {
            get {
                return this.rspnRsnField;
            }
            set {
                this.xsdResponseType9InitFlagField = true;
                this.rspnRsnField = value;
                this.RspnRsnSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RspnRsnSpecified {
            get {
                return this.rspnRsnFieldSpecified;
            }
            set {
                this.xsdResponseType9InitFlagField = true;
                this.rspnRsnFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string AddtlRspnInf {
            get {
                return this.addtlRspnInfField;
            }
            set {
                this.xsdResponseType9InitFlagField = true;
                this.addtlRspnInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdResponseType9InitFlag {
            get {
                return this.xsdResponseType9InitFlagField;
            }
            set {
                this.xsdResponseType9InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("aa9aec51-9762-49c5-b541-b6c646f7a2d9")]
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
        [DispId(3)]
        RetailerResultDetail1Code RspnRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool RspnRsnSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string AddtlRspnInf {
            get;
            set;
        }
        [DispId(9)]
        bool xsdResponseType9InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1f1caed4-a090-4324-a91c-d2a58f4ec504")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerPaymentResult1 : IRetailerPaymentResult1 {
        internal CardPaymentServiceType12Code txTpField = new CardPaymentServiceType12Code();
        internal CardPaymentServiceType9Code[] addtlSvcField = new CardPaymentServiceType9Code[0];
        internal CardPaymentServiceType3Code svcAttrField = new CardPaymentServiceType3Code();
        internal bool svcAttrFieldSpecified;
        internal CardPaymentTransaction91 reqdTxField = new CardPaymentTransaction91();
        internal CardPaymentTransaction84 txRspnField = new CardPaymentTransaction84();
        internal CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        internal CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        internal ContentInformationType17 prtctdCaptrdSgntrField = new ContentInformationType17();
        internal bool mrchntOvrrdFlgField;
        internal bool mrchntOvrrdFlgFieldSpecified;
        internal string cstmrLangField;
        internal bool onlnFlgField;
        internal bool onlnFlgFieldSpecified;
        internal bool xsdRetailerPaymentResult1InitFlagField = false;
        /// <remarks/>
        public CardPaymentServiceType12Code TxTp {
            get {
                return this.txTpField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.txTpField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlSvc")]
        public CardPaymentServiceType9Code[] AddtlSvc {
            get {
                if (((this.addtlSvcField == null)
                            || (this.addtlSvcField.Length == 0))) {
                    return null;
                }
                return this.addtlSvcField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.addtlSvcField = value;
            }
        }
        /// <remarks/>
        public CardPaymentServiceType3Code SvcAttr {
            get {
                return this.svcAttrField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.svcAttrField = value;
                this.SvcAttrSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SvcAttrSpecified {
            get {
                return this.svcAttrFieldSpecified;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.svcAttrFieldSpecified = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction91 ReqdTx {
            get {
                return this.reqdTxField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.reqdTxField = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction84 TxRspn {
            get {
                return this.txRspnField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.txRspnField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                return this.cstmrOrdrField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.cstmrOrdrField = value;
            }
        }
        /// <remarks/>
        public CapturedSignature1 ImgCaptrdSgntr {
            get {
                return this.imgCaptrdSgntrField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.imgCaptrdSgntrField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType17 PrtctdCaptrdSgntr {
            get {
                return this.prtctdCaptrdSgntrField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.prtctdCaptrdSgntrField = value;
            }
        }
        /// <remarks/>
        public bool MrchntOvrrdFlg {
            get {
                return this.mrchntOvrrdFlgField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.mrchntOvrrdFlgField = value;
                this.MrchntOvrrdFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MrchntOvrrdFlgSpecified {
            get {
                return this.mrchntOvrrdFlgFieldSpecified;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.mrchntOvrrdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.cstmrLangField = value;
            }
        }
        /// <remarks/>
        public bool OnlnFlg {
            get {
                return this.onlnFlgField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.onlnFlgField = value;
                this.OnlnFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlnFlgSpecified {
            get {
                return this.onlnFlgFieldSpecified;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = true;
                this.onlnFlgFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdRetailerPaymentResult1InitFlag {
            get {
                return this.xsdRetailerPaymentResult1InitFlagField;
            }
            set {
                this.xsdRetailerPaymentResult1InitFlagField = value;
            }
        }
        public int AddtlSvcSize() {
            if ((this.addtlSvcField == null)) {
                return 0;
            }
            else {
                return this.addtlSvcField.Length;
            }
        }
        public CardPaymentServiceType9Code AddtlSvcGetItem(int index) {
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
        }
        public bool AddtlSvcSetItem(int index, CardPaymentServiceType9Code value) {
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
        }
        public bool AddtlSvcAddItem(CardPaymentServiceType9Code value) {
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
        }
        public bool AddtlSvcRemoveItem(int index) {
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
        }
        public int CstmrOrdrSize() {
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
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
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("24f762b4-41c1-4238-a3ab-9827ca1ddddc")]
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
        [DispId(3)]
        CardPaymentServiceType9Code[] AddtlSvc {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CardPaymentServiceType3Code SvcAttr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool SvcAttrSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        CardPaymentTransaction91 ReqdTx {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        CardPaymentTransaction84 TxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        CapturedSignature1 ImgCaptrdSgntr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        ContentInformationType17 PrtctdCaptrdSgntr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        bool MrchntOvrrdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        bool MrchntOvrrdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(25)]
        bool OnlnFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(27)]
        bool OnlnFlgSpecified {
            get;
            set;
        }
        [DispId(29)]
        bool xsdRetailerPaymentResult1InitFlag {
            get;
            set;
        }
        [DispId(30)]
        int AddtlSvcSize();
        [DispId(31)]
        CardPaymentServiceType9Code AddtlSvcGetItem(int index);
        [DispId(32)]
        bool AddtlSvcSetItem(int index, CardPaymentServiceType9Code value);
        [DispId(33)]
        bool AddtlSvcAddItem(CardPaymentServiceType9Code value);
        [DispId(34)]
        bool AddtlSvcRemoveItem(int index);
        [DispId(35)]
        int CstmrOrdrSize();
        [DispId(36)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(37)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(38)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(39)]
        bool CstmrOrdrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("01edee31-faa2-4555-87cf-e4260ca81a02")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardPaymentTransaction84 : ICardPaymentTransaction84 {
        internal AuthorisationResult10 authstnRsltField = new AuthorisationResult10();
        internal TransactionVerificationResult4[] txVrfctnRsltField = new TransactionVerificationResult4[0];
        internal Product4[] allwdPdctCdField = new Product4[0];
        internal Product4[] notAllwdPdctCdField = new Product4[0];
        internal Product5[] addtlAvlblPdctField = new Product5[0];
        internal AmountAndDirection93 balField = new AmountAndDirection93();
        internal ContentInformationType17 prtctdBalField = new ContentInformationType17();
        internal Action8[] actnField = new Action8[0];
        internal CurrencyConversion14 ccyConvsElgbltyField = new CurrencyConversion14();
        internal bool xsdCardPaymentTransaction84InitFlagField = false;
        /// <remarks/>
        public AuthorisationResult10 AuthstnRslt {
            get {
                return this.authstnRsltField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.authstnRsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxVrfctnRslt")]
        public TransactionVerificationResult4[] TxVrfctnRslt {
            get {
                if (((this.txVrfctnRsltField == null)
                            || (this.txVrfctnRsltField.Length == 0))) {
                    return null;
                }
                return this.txVrfctnRsltField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.txVrfctnRsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllwdPdctCd")]
        public Product4[] AllwdPdctCd {
            get {
                if (((this.allwdPdctCdField == null)
                            || (this.allwdPdctCdField.Length == 0))) {
                    return null;
                }
                return this.allwdPdctCdField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.allwdPdctCdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotAllwdPdctCd")]
        public Product4[] NotAllwdPdctCd {
            get {
                if (((this.notAllwdPdctCdField == null)
                            || (this.notAllwdPdctCdField.Length == 0))) {
                    return null;
                }
                return this.notAllwdPdctCdField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.notAllwdPdctCdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlAvlblPdct")]
        public Product5[] AddtlAvlblPdct {
            get {
                if (((this.addtlAvlblPdctField == null)
                            || (this.addtlAvlblPdctField.Length == 0))) {
                    return null;
                }
                return this.addtlAvlblPdctField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.addtlAvlblPdctField = value;
            }
        }
        /// <remarks/>
        public AmountAndDirection93 Bal {
            get {
                return this.balField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.balField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType17 PrtctdBal {
            get {
                return this.prtctdBalField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.prtctdBalField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Actn")]
        public Action8[] Actn {
            get {
                if (((this.actnField == null)
                            || (this.actnField.Length == 0))) {
                    return null;
                }
                return this.actnField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.actnField = value;
            }
        }
        /// <remarks/>
        public CurrencyConversion14 CcyConvsElgblty {
            get {
                return this.ccyConvsElgbltyField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = true;
                this.ccyConvsElgbltyField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdCardPaymentTransaction84InitFlag {
            get {
                return this.xsdCardPaymentTransaction84InitFlagField;
            }
            set {
                this.xsdCardPaymentTransaction84InitFlagField = value;
            }
        }
        public int TxVrfctnRsltSize() {
            if ((this.txVrfctnRsltField == null)) {
                return 0;
            }
            else {
                return this.txVrfctnRsltField.Length;
            }
        }
        public TransactionVerificationResult4 TxVrfctnRsltGetItem(int index) {
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
        }
        public bool TxVrfctnRsltSetItem(int index, TransactionVerificationResult4 value) {
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
        }
        public bool TxVrfctnRsltAddItem(TransactionVerificationResult4 value) {
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
        }
        public bool TxVrfctnRsltRemoveItem(int index) {
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
        }
        public int AllwdPdctCdSize() {
            if ((this.allwdPdctCdField == null)) {
                return 0;
            }
            else {
                return this.allwdPdctCdField.Length;
            }
        }
        public Product4 AllwdPdctCdGetItem(int index) {
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
        }
        public bool AllwdPdctCdSetItem(int index, Product4 value) {
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
        }
        public bool AllwdPdctCdAddItem(Product4 value) {
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
        }
        public bool AllwdPdctCdRemoveItem(int index) {
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
        }
        public int NotAllwdPdctCdSize() {
            if ((this.notAllwdPdctCdField == null)) {
                return 0;
            }
            else {
                return this.notAllwdPdctCdField.Length;
            }
        }
        public Product4 NotAllwdPdctCdGetItem(int index) {
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
        }
        public bool NotAllwdPdctCdSetItem(int index, Product4 value) {
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
        }
        public bool NotAllwdPdctCdAddItem(Product4 value) {
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
        }
        public bool NotAllwdPdctCdRemoveItem(int index) {
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
        }
        public int AddtlAvlblPdctSize() {
            if ((this.addtlAvlblPdctField == null)) {
                return 0;
            }
            else {
                return this.addtlAvlblPdctField.Length;
            }
        }
        public Product5 AddtlAvlblPdctGetItem(int index) {
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
        }
        public bool AddtlAvlblPdctSetItem(int index, Product5 value) {
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
        }
        public bool AddtlAvlblPdctAddItem(Product5 value) {
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
        }
        public bool AddtlAvlblPdctRemoveItem(int index) {
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
        }
        public int ActnSize() {
            if ((this.actnField == null)) {
                return 0;
            }
            else {
                return this.actnField.Length;
            }
        }
        public Action8 ActnGetItem(int index) {
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
        }
        public bool ActnSetItem(int index, Action8 value) {
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
        }
        public bool ActnAddItem(Action8 value) {
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
        }
        public bool ActnRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("cda07274-86f0-4951-ae31-1b40f5bac02f")]
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
        [DispId(3)]
        TransactionVerificationResult4[] TxVrfctnRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        Product4[] AllwdPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        Product4[] NotAllwdPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        Product5[] AddtlAvlblPdct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        AmountAndDirection93 Bal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        ContentInformationType17 PrtctdBal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        Action8[] Actn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        CurrencyConversion14 CcyConvsElgblty {
            get;
            set;
        }
        [DispId(19)]
        bool xsdCardPaymentTransaction84InitFlag {
            get;
            set;
        }
        [DispId(20)]
        int TxVrfctnRsltSize();
        [DispId(21)]
        TransactionVerificationResult4 TxVrfctnRsltGetItem(int index);
        [DispId(22)]
        bool TxVrfctnRsltSetItem(int index, TransactionVerificationResult4 value);
        [DispId(23)]
        bool TxVrfctnRsltAddItem(TransactionVerificationResult4 value);
        [DispId(24)]
        bool TxVrfctnRsltRemoveItem(int index);
        [DispId(25)]
        int AllwdPdctCdSize();
        [DispId(26)]
        Product4 AllwdPdctCdGetItem(int index);
        [DispId(27)]
        bool AllwdPdctCdSetItem(int index, Product4 value);
        [DispId(28)]
        bool AllwdPdctCdAddItem(Product4 value);
        [DispId(29)]
        bool AllwdPdctCdRemoveItem(int index);
        [DispId(30)]
        int NotAllwdPdctCdSize();
        [DispId(31)]
        Product4 NotAllwdPdctCdGetItem(int index);
        [DispId(32)]
        bool NotAllwdPdctCdSetItem(int index, Product4 value);
        [DispId(33)]
        bool NotAllwdPdctCdAddItem(Product4 value);
        [DispId(34)]
        bool NotAllwdPdctCdRemoveItem(int index);
        [DispId(35)]
        int AddtlAvlblPdctSize();
        [DispId(36)]
        Product5 AddtlAvlblPdctGetItem(int index);
        [DispId(37)]
        bool AddtlAvlblPdctSetItem(int index, Product5 value);
        [DispId(38)]
        bool AddtlAvlblPdctAddItem(Product5 value);
        [DispId(39)]
        bool AddtlAvlblPdctRemoveItem(int index);
        [DispId(40)]
        int ActnSize();
        [DispId(41)]
        Action8 ActnGetItem(int index);
        [DispId(42)]
        bool ActnSetItem(int index, Action8 value);
        [DispId(43)]
        bool ActnAddItem(Action8 value);
        [DispId(44)]
        bool ActnRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("dff16039-a1d0-41da-9434-c048bfc63944")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product4 : IProduct4 {
        internal string pdctCdField;
        internal string addtlPdctCdField;
        internal bool xsdProduct4InitFlagField = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                this.xsdProduct4InitFlagField = true;
                this.pdctCdField = value;
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                this.xsdProduct4InitFlagField = true;
                this.addtlPdctCdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdProduct4InitFlag {
            get {
                return this.xsdProduct4InitFlagField;
            }
            set {
                this.xsdProduct4InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("f1a9b406-6d39-4e1a-945b-5a88368d5b7c")]
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
        [DispId(3)]
        string AddtlPdctCd {
            get;
            set;
        }
        [DispId(5)]
        bool xsdProduct4InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("925d3fd2-c350-4728-b511-15a0f92d60f2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Product5 : IProduct5 {
        internal string pdctCdField;
        internal string addtlPdctCdField;
        internal double amtLmtField;
        internal bool amtLmtFieldSpecified;
        internal double qtyLmtField;
        internal bool qtyLmtFieldSpecified;
        internal UnitOfMeasure6Code unitOfMeasrField = new UnitOfMeasure6Code();
        internal bool unitOfMeasrFieldSpecified;
        internal bool xsdProduct5InitFlagField = false;
        /// <remarks/>
        public string PdctCd {
            get {
                return this.pdctCdField;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.pdctCdField = value;
            }
        }
        /// <remarks/>
        public string AddtlPdctCd {
            get {
                return this.addtlPdctCdField;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.addtlPdctCdField = value;
            }
        }
        /// <remarks/>
        public double AmtLmt {
            get {
                return this.amtLmtField;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.amtLmtField = value;
                this.AmtLmtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmtLmtSpecified {
            get {
                return this.amtLmtFieldSpecified;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.amtLmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double QtyLmt {
            get {
                return this.qtyLmtField;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.qtyLmtField = value;
                this.QtyLmtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyLmtSpecified {
            get {
                return this.qtyLmtFieldSpecified;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.qtyLmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public UnitOfMeasure6Code UnitOfMeasr {
            get {
                return this.unitOfMeasrField;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.unitOfMeasrField = value;
                this.UnitOfMeasrSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitOfMeasrSpecified {
            get {
                return this.unitOfMeasrFieldSpecified;
            }
            set {
                this.xsdProduct5InitFlagField = true;
                this.unitOfMeasrFieldSpecified = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdProduct5InitFlag {
            get {
                return this.xsdProduct5InitFlagField;
            }
            set {
                this.xsdProduct5InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("12e91ba6-ab8e-47ef-9603-9c76bf47c16d")]
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
        [DispId(3)]
        string AddtlPdctCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        double AmtLmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool AmtLmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        double QtyLmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        bool QtyLmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        UnitOfMeasure6Code UnitOfMeasr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool UnitOfMeasrSpecified {
            get;
            set;
        }
        [DispId(17)]
        bool xsdProduct5InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a939870f-4575-437c-a039-b06c1f1a8b91")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CapturedSignature1 : ICapturedSignature1 {
        internal string imgFrmtField;
        internal byte[] imgDataField = new byte[0];
        internal string imgRefField;
        internal string addtlInfField;
        internal bool xsdCapturedSignature1InitFlagField = false;
        /// <remarks/>
        public string ImgFrmt {
            get {
                return this.imgFrmtField;
            }
            set {
                this.xsdCapturedSignature1InitFlagField = true;
                this.imgFrmtField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ImgData {
            get {
                if (((this.imgDataField == null)
                            || (this.imgDataField.Length == 0))) {
                    return null;
                }
                return this.imgDataField;
            }
            set {
                this.xsdCapturedSignature1InitFlagField = true;
                this.imgDataField = value;
            }
        }
        /// <remarks/>
        public string ImgRef {
            get {
                return this.imgRefField;
            }
            set {
                this.xsdCapturedSignature1InitFlagField = true;
                this.imgRefField = value;
            }
        }
        /// <remarks/>
        public string AddtlInf {
            get {
                return this.addtlInfField;
            }
            set {
                this.xsdCapturedSignature1InitFlagField = true;
                this.addtlInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdCapturedSignature1InitFlag {
            get {
                return this.xsdCapturedSignature1InitFlagField;
            }
            set {
                this.xsdCapturedSignature1InitFlagField = value;
            }
        }
        public int ImgDataSize() {
            if ((this.imgDataField == null)) {
                return 0;
            }
            else {
                return this.imgDataField.Length;
            }
        }
        public byte ImgDataGetItem(int index) {
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
        }
        public bool ImgDataSetItem(int index, byte value) {
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
        }
        public bool ImgDataAddItem(byte value) {
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
        }
        public bool ImgDataRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("2a3821a5-935c-4244-894c-563d79f839c3")]
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
        [DispId(3)]
        byte[] ImgData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string ImgRef {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string AddtlInf {
            get;
            set;
        }
        [DispId(9)]
        bool xsdCapturedSignature1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int ImgDataSize();
        [DispId(11)]
        byte ImgDataGetItem(int index);
        [DispId(12)]
        bool ImgDataSetItem(int index, byte value);
        [DispId(13)]
        bool ImgDataAddItem(byte value);
        [DispId(14)]
        bool ImgDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("fc49d05b-dea1-4f21-aeac-a42c5a58d1e6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResult1 : ILoyaltyResult1 {
        internal LoyaltyAccount1 acctField = new LoyaltyAccount1();
        internal LoyaltyAmount1 amtField = new LoyaltyAmount1();
        internal LoyaltyServerData1 svrDataField = new LoyaltyServerData1();
        internal LoyaltyRebates1 rbtsField = new LoyaltyRebates1();
        internal bool xsdLoyaltyResult1InitFlagField = false;
        /// <remarks/>
        public LoyaltyAccount1 Acct {
            get {
                return this.acctField;
            }
            set {
                this.xsdLoyaltyResult1InitFlagField = true;
                this.acctField = value;
            }
        }
        /// <remarks/>
        public LoyaltyAmount1 Amt {
            get {
                return this.amtField;
            }
            set {
                this.xsdLoyaltyResult1InitFlagField = true;
                this.amtField = value;
            }
        }
        /// <remarks/>
        public LoyaltyServerData1 SvrData {
            get {
                return this.svrDataField;
            }
            set {
                this.xsdLoyaltyResult1InitFlagField = true;
                this.svrDataField = value;
            }
        }
        /// <remarks/>
        public LoyaltyRebates1 Rbts {
            get {
                return this.rbtsField;
            }
            set {
                this.xsdLoyaltyResult1InitFlagField = true;
                this.rbtsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoyaltyResult1InitFlag {
            get {
                return this.xsdLoyaltyResult1InitFlagField;
            }
            set {
                this.xsdLoyaltyResult1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("be72664d-e0a8-4108-9c76-02d2cf6ca11f")]
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
        [DispId(3)]
        LoyaltyAmount1 Amt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        LoyaltyServerData1 SvrData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyRebates1 Rbts {
            get;
            set;
        }
        [DispId(9)]
        bool xsdLoyaltyResult1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b04ee03a-b928-4286-8868-25925fe7e8bf")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyServerData1 : ILoyaltyServerData1 {
        internal string lltySvrIdField;
        internal string apprvlCdField;
        internal TransactionIdentifier1 lltyTxIdField = new TransactionIdentifier1();
        internal string hstRcncltnIdField;
        internal bool xsdLoyaltyServerData1InitFlagField = false;
        /// <remarks/>
        public string LltySvrId {
            get {
                return this.lltySvrIdField;
            }
            set {
                this.xsdLoyaltyServerData1InitFlagField = true;
                this.lltySvrIdField = value;
            }
        }
        /// <remarks/>
        public string ApprvlCd {
            get {
                return this.apprvlCdField;
            }
            set {
                this.xsdLoyaltyServerData1InitFlagField = true;
                this.apprvlCdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 LltyTxId {
            get {
                return this.lltyTxIdField;
            }
            set {
                this.xsdLoyaltyServerData1InitFlagField = true;
                this.lltyTxIdField = value;
            }
        }
        /// <remarks/>
        public string HstRcncltnId {
            get {
                return this.hstRcncltnIdField;
            }
            set {
                this.xsdLoyaltyServerData1InitFlagField = true;
                this.hstRcncltnIdField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoyaltyServerData1InitFlag {
            get {
                return this.xsdLoyaltyServerData1InitFlagField;
            }
            set {
                this.xsdLoyaltyServerData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("966e1bc0-154d-4384-aeff-ed0cab47f665")]
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
        [DispId(3)]
        string ApprvlCd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TransactionIdentifier1 LltyTxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string HstRcncltnId {
            get;
            set;
        }
        [DispId(9)]
        bool xsdLoyaltyServerData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ba93cf93-3f20-49cf-8a8a-bd10fe2fec5e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyRebates1 : ILoyaltyRebates1 {
        internal double ttlRbtField;
        internal bool ttlRbtFieldSpecified;
        internal string rbtLablField;
        internal SaleItemRebate1[] saleItmRbtField = new SaleItemRebate1[0];
        internal bool xsdLoyaltyRebates1InitFlagField = false;
        /// <remarks/>
        public double TtlRbt {
            get {
                return this.ttlRbtField;
            }
            set {
                this.xsdLoyaltyRebates1InitFlagField = true;
                this.ttlRbtField = value;
                this.TtlRbtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlRbtSpecified {
            get {
                return this.ttlRbtFieldSpecified;
            }
            set {
                this.xsdLoyaltyRebates1InitFlagField = true;
                this.ttlRbtFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string RbtLabl {
            get {
                return this.rbtLablField;
            }
            set {
                this.xsdLoyaltyRebates1InitFlagField = true;
                this.rbtLablField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleItmRbt")]
        public SaleItemRebate1[] SaleItmRbt {
            get {
                if (((this.saleItmRbtField == null)
                            || (this.saleItmRbtField.Length == 0))) {
                    return null;
                }
                return this.saleItmRbtField;
            }
            set {
                this.xsdLoyaltyRebates1InitFlagField = true;
                this.saleItmRbtField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoyaltyRebates1InitFlag {
            get {
                return this.xsdLoyaltyRebates1InitFlagField;
            }
            set {
                this.xsdLoyaltyRebates1InitFlagField = value;
            }
        }
        public int SaleItmRbtSize() {
            if ((this.saleItmRbtField == null)) {
                return 0;
            }
            else {
                return this.saleItmRbtField.Length;
            }
        }
        public SaleItemRebate1 SaleItmRbtGetItem(int index) {
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
        }
        public bool SaleItmRbtSetItem(int index, SaleItemRebate1 value) {
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
        }
        public bool SaleItmRbtAddItem(SaleItemRebate1 value) {
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
        }
        public bool SaleItmRbtRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0223da44-94ae-4642-9c12-36113d0eb135")]
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
        [DispId(3)]
        bool TtlRbtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string RbtLabl {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        SaleItemRebate1[] SaleItmRbt {
            get;
            set;
        }
        [DispId(9)]
        bool xsdLoyaltyRebates1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int SaleItmRbtSize();
        [DispId(11)]
        SaleItemRebate1 SaleItmRbtGetItem(int index);
        [DispId(12)]
        bool SaleItmRbtSetItem(int index, SaleItemRebate1 value);
        [DispId(13)]
        bool SaleItmRbtAddItem(SaleItemRebate1 value);
        [DispId(14)]
        bool SaleItmRbtRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2dc02c29-127a-4c15-b099-97974ebbda5c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleItemRebate1 : ISaleItemRebate1 {
        internal Product6 saleItmField = new Product6();
        internal string rbtLablField;
        internal bool xsdSaleItemRebate1InitFlagField = false;
        /// <remarks/>
        public Product6 SaleItm {
            get {
                return this.saleItmField;
            }
            set {
                this.xsdSaleItemRebate1InitFlagField = true;
                this.saleItmField = value;
            }
        }
        /// <remarks/>
        public string RbtLabl {
            get {
                return this.rbtLablField;
            }
            set {
                this.xsdSaleItemRebate1InitFlagField = true;
                this.rbtLablField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleItemRebate1InitFlag {
            get {
                return this.xsdSaleItemRebate1InitFlagField;
            }
            set {
                this.xsdSaleItemRebate1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("91f2c79c-4d72-4bc4-a0f8-539824967adc")]
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
        [DispId(3)]
        string RbtLabl {
            get;
            set;
        }
        [DispId(5)]
        bool xsdSaleItemRebate1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("72d83638-a4f2-401c-b044-19fecfe02482")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CardAcquisitionResponse1 : ICardAcquisitionResponse1 {
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal string[] pmtBrndField = new string[0];
        internal string cstmrLangField;
        internal LoyaltyAccount1[] lltyAcctField = new LoyaltyAccount1[0];
        internal CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        internal bool xsdCardAcquisitionResponse1InitFlagField = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtBrnd")]
        public string[] PmtBrnd {
            get {
                if (((this.pmtBrndField == null)
                            || (this.pmtBrndField.Length == 0))) {
                    return null;
                }
                return this.pmtBrndField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = true;
                this.pmtBrndField = value;
            }
        }
        /// <remarks/>
        public string CstmrLang {
            get {
                return this.cstmrLangField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = true;
                this.cstmrLangField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyAcct")]
        public LoyaltyAccount1[] LltyAcct {
            get {
                if (((this.lltyAcctField == null)
                            || (this.lltyAcctField.Length == 0))) {
                    return null;
                }
                return this.lltyAcctField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = true;
                this.lltyAcctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                return this.cstmrOrdrField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = true;
                this.cstmrOrdrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdCardAcquisitionResponse1InitFlag {
            get {
                return this.xsdCardAcquisitionResponse1InitFlagField;
            }
            set {
                this.xsdCardAcquisitionResponse1InitFlagField = value;
            }
        }
        public int PmtBrndSize() {
            if ((this.pmtBrndField == null)) {
                return 0;
            }
            else {
                return this.pmtBrndField.Length;
            }
        }
        public string PmtBrndGetItem(int index) {
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
        }
        public bool PmtBrndSetItem(int index, string value) {
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
        }
        public bool PmtBrndAddItem(string value) {
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
        }
        public bool PmtBrndRemoveItem(int index) {
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
        }
        public int LltyAcctSize() {
            if ((this.lltyAcctField == null)) {
                return 0;
            }
            else {
                return this.lltyAcctField.Length;
            }
        }
        public LoyaltyAccount1 LltyAcctGetItem(int index) {
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
        }
        public bool LltyAcctSetItem(int index, LoyaltyAccount1 value) {
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
        }
        public bool LltyAcctAddItem(LoyaltyAccount1 value) {
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
        }
        public bool LltyAcctRemoveItem(int index) {
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
        }
        public int CstmrOrdrSize() {
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
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
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("5dc78f9c-3552-4e1f-a7ec-b73f8c44225a")]
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
        [DispId(3)]
        string[] PmtBrnd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string CstmrLang {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyAccount1[] LltyAcct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(11)]
        bool xsdCardAcquisitionResponse1InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int PmtBrndSize();
        [DispId(13)]
        string PmtBrndGetItem(int index);
        [DispId(14)]
        bool PmtBrndSetItem(int index, string value);
        [DispId(15)]
        bool PmtBrndAddItem(string value);
        [DispId(16)]
        bool PmtBrndRemoveItem(int index);
        [DispId(17)]
        int LltyAcctSize();
        [DispId(18)]
        LoyaltyAccount1 LltyAcctGetItem(int index);
        [DispId(19)]
        bool LltyAcctSetItem(int index, LoyaltyAccount1 value);
        [DispId(20)]
        bool LltyAcctAddItem(LoyaltyAccount1 value);
        [DispId(21)]
        bool LltyAcctRemoveItem(int index);
        [DispId(22)]
        int CstmrOrdrSize();
        [DispId(23)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(24)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(25)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(26)]
        bool CstmrOrdrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a97d2770-66d1-4eac-939f-7c43febed9f4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIServiceResponseV01 : ISaleToPOIServiceResponseV01 {
        internal Header37 hdrField = new Header37();
        internal ServiceResponse2 svcRspnField = new ServiceResponse2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIServiceResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIServiceResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public ServiceResponse2 SvcRspn {
            get {
                return this.svcRspnField;
            }
            set {
                this.xsdSaleToPOIServiceResponseV01InitFlagField = true;
                this.svcRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIServiceResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIServiceResponseV01InitFlag {
            get {
                return this.xsdSaleToPOIServiceResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIServiceResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("3ffefae7-9891-4155-923d-391dcc54e900")]
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
        [DispId(3)]
        ServiceResponse2 SvcRspn {
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
        bool xsdSaleToPOIServiceResponseV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("68644ab8-e32c-4247-9594-40faf76071bd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServiceResponse2 : IServiceResponse2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService3Code svcCnttField = new RetailerService3Code();
        internal PaymentResponse1 pmtRspnField = new PaymentResponse1();
        internal ReversalResponse1 rvslRspnField = new ReversalResponse1();
        internal BalanceInquiryResponse1 balNqryRspnField = new BalanceInquiryResponse1();
        internal LoyaltyResponse1 lltyRspnField = new LoyaltyResponse1();
        internal StoredValueResponse2 stordValRspnField = new StoredValueResponse2();
        internal PerformedTransaction1[] btchRspnField = new PerformedTransaction1[0];
        internal CardAcquisitionResponse1 cardAcqstnRspnField = new CardAcquisitionResponse1();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdServiceResponse2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService3Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        public PaymentResponse1 PmtRspn {
            get {
                return this.pmtRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.pmtRspnField = value;
            }
        }
        /// <remarks/>
        public ReversalResponse1 RvslRspn {
            get {
                return this.rvslRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.rvslRspnField = value;
            }
        }
        /// <remarks/>
        public BalanceInquiryResponse1 BalNqryRspn {
            get {
                return this.balNqryRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.balNqryRspnField = value;
            }
        }
        /// <remarks/>
        public LoyaltyResponse1 LltyRspn {
            get {
                return this.lltyRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.lltyRspnField = value;
            }
        }
        /// <remarks/>
        public StoredValueResponse2 StordValRspn {
            get {
                return this.stordValRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.stordValRspnField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PrfrmdTx", IsNullable=false)]
        public PerformedTransaction1[] BtchRspn {
            get {
                if (((this.btchRspnField == null)
                            || (this.btchRspnField.Length == 0))) {
                    return null;
                }
                return this.btchRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.btchRspnField = value;
            }
        }
        /// <remarks/>
        public CardAcquisitionResponse1 CardAcqstnRspn {
            get {
                return this.cardAcqstnRspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
                this.cardAcqstnRspnField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = true;
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
                this.xsdServiceResponse2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdServiceResponse2InitFlag {
            get {
                return this.xsdServiceResponse2InitFlagField;
            }
            set {
                this.xsdServiceResponse2InitFlagField = value;
            }
        }
        public int BtchRspnSize() {
            if ((this.btchRspnField == null)) {
                return 0;
            }
            else {
                return this.btchRspnField.Length;
            }
        }
        public PerformedTransaction1 BtchRspnGetItem(int index) {
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
        }
        public bool BtchRspnSetItem(int index, PerformedTransaction1 value) {
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
        }
        public bool BtchRspnAddItem(PerformedTransaction1 value) {
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
        }
        public bool BtchRspnRemoveItem(int index) {
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
    [System.Runtime.InteropServices.GuidAttribute("2ead9e2d-2030-4bc9-94f2-90e4a5267160")]
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
        [DispId(3)]
        CardPaymentContext27 Cntxt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        RetailerService3Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        PaymentResponse1 PmtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        ReversalResponse1 RvslRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        BalanceInquiryResponse1 BalNqryRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        LoyaltyResponse1 LltyRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        StoredValueResponse2 StordValRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        PerformedTransaction1[] BtchRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        CardAcquisitionResponse1 CardAcqstnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(21)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(23)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(25)]
        bool xsdServiceResponse2InitFlag {
            get;
            set;
        }
        [DispId(26)]
        int BtchRspnSize();
        [DispId(27)]
        PerformedTransaction1 BtchRspnGetItem(int index);
        [DispId(28)]
        bool BtchRspnSetItem(int index, PerformedTransaction1 value);
        [DispId(29)]
        bool BtchRspnAddItem(PerformedTransaction1 value);
        [DispId(30)]
        bool BtchRspnRemoveItem(int index);
        [DispId(31)]
        int SplmtryDataSize();
        [DispId(32)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(33)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(34)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(35)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ed365c13-75b8-4d30-a7f6-101ff2a6a5a1")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PaymentResponse1 : IPaymentResponse1 {
        internal TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        internal string saleRefIdField;
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal string pOIRcncltnIdField;
        internal string issrRefDataField;
        internal RetailerPaymentResult1 rtlrPmtRsltField = new RetailerPaymentResult1();
        internal PaymentReceipt1[] pmtRctField = new PaymentReceipt1[0];
        internal LoyaltyResult1[] lltyRsltField = new LoyaltyResult1[0];
        internal CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        internal bool xsdPaymentResponse1InitFlagField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                return this.saleTxIdField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.saleTxIdField = value;
            }
        }
        /// <remarks/>
        public string SaleRefId {
            get {
                return this.saleRefIdField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.saleRefIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.issrRefDataField = value;
            }
        }
        /// <remarks/>
        public RetailerPaymentResult1 RtlrPmtRslt {
            get {
                return this.rtlrPmtRsltField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.rtlrPmtRsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtRct")]
        public PaymentReceipt1[] PmtRct {
            get {
                if (((this.pmtRctField == null)
                            || (this.pmtRctField.Length == 0))) {
                    return null;
                }
                return this.pmtRctField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.pmtRctField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LltyRslt")]
        public LoyaltyResult1[] LltyRslt {
            get {
                if (((this.lltyRsltField == null)
                            || (this.lltyRsltField.Length == 0))) {
                    return null;
                }
                return this.lltyRsltField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.lltyRsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                return this.cstmrOrdrField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = true;
                this.cstmrOrdrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdPaymentResponse1InitFlag {
            get {
                return this.xsdPaymentResponse1InitFlagField;
            }
            set {
                this.xsdPaymentResponse1InitFlagField = value;
            }
        }
        public int PmtRctSize() {
            if ((this.pmtRctField == null)) {
                return 0;
            }
            else {
                return this.pmtRctField.Length;
            }
        }
        public PaymentReceipt1 PmtRctGetItem(int index) {
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
        }
        public bool PmtRctSetItem(int index, PaymentReceipt1 value) {
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
        }
        public bool PmtRctAddItem(PaymentReceipt1 value) {
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
        }
        public bool PmtRctRemoveItem(int index) {
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
        }
        public int LltyRsltSize() {
            if ((this.lltyRsltField == null)) {
                return 0;
            }
            else {
                return this.lltyRsltField.Length;
            }
        }
        public LoyaltyResult1 LltyRsltGetItem(int index) {
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
        }
        public bool LltyRsltSetItem(int index, LoyaltyResult1 value) {
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
        }
        public bool LltyRsltAddItem(LoyaltyResult1 value) {
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
        }
        public bool LltyRsltRemoveItem(int index) {
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
        }
        public int CstmrOrdrSize() {
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
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
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6e4bf14f-8447-4757-b290-326327363283")]
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
        [DispId(3)]
        string SaleRefId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string IssrRefData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        RetailerPaymentResult1 RtlrPmtRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        PaymentReceipt1[] PmtRct {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        LoyaltyResult1[] LltyRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(19)]
        bool xsdPaymentResponse1InitFlag {
            get;
            set;
        }
        [DispId(20)]
        int PmtRctSize();
        [DispId(21)]
        PaymentReceipt1 PmtRctGetItem(int index);
        [DispId(22)]
        bool PmtRctSetItem(int index, PaymentReceipt1 value);
        [DispId(23)]
        bool PmtRctAddItem(PaymentReceipt1 value);
        [DispId(24)]
        bool PmtRctRemoveItem(int index);
        [DispId(25)]
        int LltyRsltSize();
        [DispId(26)]
        LoyaltyResult1 LltyRsltGetItem(int index);
        [DispId(27)]
        bool LltyRsltSetItem(int index, LoyaltyResult1 value);
        [DispId(28)]
        bool LltyRsltAddItem(LoyaltyResult1 value);
        [DispId(29)]
        bool LltyRsltRemoveItem(int index);
        [DispId(30)]
        int CstmrOrdrSize();
        [DispId(31)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(32)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(33)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(34)]
        bool CstmrOrdrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e2b9d13b-d5b6-435e-a53d-e13b44a4d1bc")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReversalResponse1 : IReversalResponse1 {
        internal TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        internal string saleRefIdField;
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal string pOIRcncltnIdField;
        internal string issrRefDataField;
        internal RetailerReversalResult1 rvslTxRsltField = new RetailerReversalResult1();
        internal double rvsdAmtField;
        internal bool rvsdAmtFieldSpecified;
        internal PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        internal bool xsdReversalResponse1InitFlagField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                return this.saleTxIdField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.saleTxIdField = value;
            }
        }
        /// <remarks/>
        public string SaleRefId {
            get {
                return this.saleRefIdField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.saleRefIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public string IssrRefData {
            get {
                return this.issrRefDataField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.issrRefDataField = value;
            }
        }
        /// <remarks/>
        public RetailerReversalResult1 RvslTxRslt {
            get {
                return this.rvslTxRsltField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.rvslTxRsltField = value;
            }
        }
        /// <remarks/>
        public double RvsdAmt {
            get {
                return this.rvsdAmtField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.rvsdAmtField = value;
                this.RvsdAmtSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RvsdAmtSpecified {
            get {
                return this.rvsdAmtFieldSpecified;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.rvsdAmtFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                return this.rctField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = true;
                this.rctField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReversalResponse1InitFlag {
            get {
                return this.xsdReversalResponse1InitFlagField;
            }
            set {
                this.xsdReversalResponse1InitFlagField = value;
            }
        }
        public int RctSize() {
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
        }
        public PaymentReceipt1 RctGetItem(int index) {
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
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
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
        }
        public bool RctAddItem(PaymentReceipt1 value) {
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
        }
        public bool RctRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("dc5b1a9e-b460-48d6-94e1-aad39df25c32")]
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
        [DispId(3)]
        string SaleRefId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        string IssrRefData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        RetailerReversalResult1 RvslTxRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        double RvsdAmt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        bool RvsdAmtSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(19)]
        bool xsdReversalResponse1InitFlag {
            get;
            set;
        }
        [DispId(20)]
        int RctSize();
        [DispId(21)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(22)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(23)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(24)]
        bool RctRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("e1173df0-176c-4a5e-af99-309f069dbf54")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RetailerReversalResult1 : IRetailerReversalResult1 {
        internal string pOIRcncltnIdField;
        internal CardPaymentTransaction91 orgnlPmtTxField = new CardPaymentTransaction91();
        internal CustomerOrder1[] cstmrOrdrField = new CustomerOrder1[0];
        internal bool xsdRetailerReversalResult1InitFlagField = false;
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdRetailerReversalResult1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        public CardPaymentTransaction91 OrgnlPmtTx {
            get {
                return this.orgnlPmtTxField;
            }
            set {
                this.xsdRetailerReversalResult1InitFlagField = true;
                this.orgnlPmtTxField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CstmrOrdr")]
        public CustomerOrder1[] CstmrOrdr {
            get {
                if (((this.cstmrOrdrField == null)
                            || (this.cstmrOrdrField.Length == 0))) {
                    return null;
                }
                return this.cstmrOrdrField;
            }
            set {
                this.xsdRetailerReversalResult1InitFlagField = true;
                this.cstmrOrdrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdRetailerReversalResult1InitFlag {
            get {
                return this.xsdRetailerReversalResult1InitFlagField;
            }
            set {
                this.xsdRetailerReversalResult1InitFlagField = value;
            }
        }
        public int CstmrOrdrSize() {
            if ((this.cstmrOrdrField == null)) {
                return 0;
            }
            else {
                return this.cstmrOrdrField.Length;
            }
        }
        public CustomerOrder1 CstmrOrdrGetItem(int index) {
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
        }
        public bool CstmrOrdrSetItem(int index, CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrAddItem(CustomerOrder1 value) {
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
        }
        public bool CstmrOrdrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("8309a0f7-3982-4cac-8e7d-7eaa079e5b72")]
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
        [DispId(3)]
        CardPaymentTransaction91 OrgnlPmtTx {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        CustomerOrder1[] CstmrOrdr {
            get;
            set;
        }
        [DispId(7)]
        bool xsdRetailerReversalResult1InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int CstmrOrdrSize();
        [DispId(9)]
        CustomerOrder1 CstmrOrdrGetItem(int index);
        [DispId(10)]
        bool CstmrOrdrSetItem(int index, CustomerOrder1 value);
        [DispId(11)]
        bool CstmrOrdrAddItem(CustomerOrder1 value);
        [DispId(12)]
        bool CstmrOrdrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("dc69495e-71f6-45d8-a069-de98fc707b9d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class LoyaltyResponse1 : ILoyaltyResponse1 {
        internal TransactionIdentifier1 saleTxIdField = new TransactionIdentifier1();
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal string pOIRcncltnIdField;
        internal LoyaltyResult1[] rsltField = new LoyaltyResult1[0];
        internal bool xsdLoyaltyResponse1InitFlagField = false;
        /// <remarks/>
        public TransactionIdentifier1 SaleTxId {
            get {
                return this.saleTxIdField;
            }
            set {
                this.xsdLoyaltyResponse1InitFlagField = true;
                this.saleTxIdField = value;
            }
        }
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdLoyaltyResponse1InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdLoyaltyResponse1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rslt")]
        public LoyaltyResult1[] Rslt {
            get {
                if (((this.rsltField == null)
                            || (this.rsltField.Length == 0))) {
                    return null;
                }
                return this.rsltField;
            }
            set {
                this.xsdLoyaltyResponse1InitFlagField = true;
                this.rsltField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdLoyaltyResponse1InitFlag {
            get {
                return this.xsdLoyaltyResponse1InitFlagField;
            }
            set {
                this.xsdLoyaltyResponse1InitFlagField = value;
            }
        }
        public int RsltSize() {
            if ((this.rsltField == null)) {
                return 0;
            }
            else {
                return this.rsltField.Length;
            }
        }
        public LoyaltyResult1 RsltGetItem(int index) {
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
        }
        public bool RsltSetItem(int index, LoyaltyResult1 value) {
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
        }
        public bool RsltAddItem(LoyaltyResult1 value) {
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
        }
        public bool RsltRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("653c36fd-a758-4727-b8e5-ec9cd2487ad3")]
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
        [DispId(3)]
        TransactionIdentifier1 POITxId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyResult1[] Rslt {
            get;
            set;
        }
        [DispId(9)]
        bool xsdLoyaltyResponse1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int RsltSize();
        [DispId(11)]
        LoyaltyResult1 RsltGetItem(int index);
        [DispId(12)]
        bool RsltSetItem(int index, LoyaltyResult1 value);
        [DispId(13)]
        bool RsltAddItem(LoyaltyResult1 value);
        [DispId(14)]
        bool RsltRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.002.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("c22e2f97-c697-497c-8d74-38587c862eee")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StoredValueResponse2 : IStoredValueResponse2 {
        internal TransactionIdentifier1 pOITxIdField = new TransactionIdentifier1();
        internal StoredValueData2[] rsltField = new StoredValueData2[0];
        internal PaymentReceipt1[] rctField = new PaymentReceipt1[0];
        internal bool xsdStoredValueResponse2InitFlagField = false;
        /// <remarks/>
        public TransactionIdentifier1 POITxId {
            get {
                return this.pOITxIdField;
            }
            set {
                this.xsdStoredValueResponse2InitFlagField = true;
                this.pOITxIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rslt")]
        public StoredValueData2[] Rslt {
            get {
                if (((this.rsltField == null)
                            || (this.rsltField.Length == 0))) {
                    return null;
                }
                return this.rsltField;
            }
            set {
                this.xsdStoredValueResponse2InitFlagField = true;
                this.rsltField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rct")]
        public PaymentReceipt1[] Rct {
            get {
                if (((this.rctField == null)
                            || (this.rctField.Length == 0))) {
                    return null;
                }
                return this.rctField;
            }
            set {
                this.xsdStoredValueResponse2InitFlagField = true;
                this.rctField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdStoredValueResponse2InitFlag {
            get {
                return this.xsdStoredValueResponse2InitFlagField;
            }
            set {
                this.xsdStoredValueResponse2InitFlagField = value;
            }
        }
        public int RsltSize() {
            if ((this.rsltField == null)) {
                return 0;
            }
            else {
                return this.rsltField.Length;
            }
        }
        public StoredValueData2 RsltGetItem(int index) {
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
        }
        public bool RsltSetItem(int index, StoredValueData2 value) {
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
        }
        public bool RsltAddItem(StoredValueData2 value) {
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
        }
        public bool RsltRemoveItem(int index) {
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
        }
        public int RctSize() {
            if ((this.rctField == null)) {
                return 0;
            }
            else {
                return this.rctField.Length;
            }
        }
        public PaymentReceipt1 RctGetItem(int index) {
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
        }
        public bool RctSetItem(int index, PaymentReceipt1 value) {
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
        }
        public bool RctAddItem(PaymentReceipt1 value) {
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
        }
        public bool RctRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("82fda0c6-189a-4a1f-90b6-76d31f0494f7")]
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
        [DispId(3)]
        StoredValueData2[] Rslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        PaymentReceipt1[] Rct {
            get;
            set;
        }
        [DispId(7)]
        bool xsdStoredValueResponse2InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int RsltSize();
        [DispId(9)]
        StoredValueData2 RsltGetItem(int index);
        [DispId(10)]
        bool RsltSetItem(int index, StoredValueData2 value);
        [DispId(11)]
        bool RsltAddItem(StoredValueData2 value);
        [DispId(12)]
        bool RsltRemoveItem(int index);
        [DispId(13)]
        int RctSize();
        [DispId(14)]
        PaymentReceipt1 RctGetItem(int index);
        [DispId(15)]
        bool RctSetItem(int index, PaymentReceipt1 value);
        [DispId(16)]
        bool RctAddItem(PaymentReceipt1 value);
        [DispId(17)]
        bool RctRemoveItem(int index);
    }
}
