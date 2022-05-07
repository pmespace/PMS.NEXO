#if NEXO50
namespace NEXO {
    using Newtonsoft.Json;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9bf73f2d-292b-48f2-b98c-1bef58275a99")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AcceptorRejection2 : IAcceptorRejection2 {
        private RejectReason1Code rjctRsnField = default(RejectReason1Code);
        private string addtlInfField = default(string);
        private byte[] msgInErrField = new byte[0];
        private bool rjctRsnField_XSD_HasBeenSet = false;
        private bool addtlInfField_XSD_HasBeenSet = false;
        private bool _XSD_Optimizing = false;
        /// <remarks/>
        public RejectReason1Code RjctRsn {
            get {
                return this.rjctRsnField;
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
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgInErr {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.msgInErrField == null)
                            || (this.msgInErrField.Length == 0))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.msgInErrField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent array from being null
                if ((value == null)) {
                    this.msgInErrField = new byte[0];
                }
                else {
                    this.msgInErrField = value;
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
                            || (this.MsgInErrSize() != 0))
                            || this.rjctRsnField_XSD_HasBeenSet)
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
        public int MsgInErrSize() {
            // BEGIN ADDED BY XSD - array Size accessor
            if ((this.msgInErrField == null)) {
                return 0;
            }
            else {
                return this.msgInErrField.Length;
            }
            // END ADDED BY XSD
        }
        public byte MsgInErrGetItem(int index) {
            // BEGIN ADDED BY XSD - array GetItem accessor
            try {
                if ((this.msgInErrField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.msgInErrField.Length - 1)
                                >= index)) {
                        return this.msgInErrField[index];
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
        public bool MsgInErrSetItem(int index, byte value) {
            // BEGIN ADDED BY XSD - array SetItem accessor
            try {
                if ((this.msgInErrField == default(byte[]))) {
                    return false;
                }
                else {
                    this.msgInErrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgInErrAddItem(byte value) {
            // BEGIN ADDED BY XSD - array AddItem accessor
            try {
                if ((this.msgInErrField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.msgInErrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.msgInErrField.Length); i = (i + 1)) {
                        array[i] = msgInErrField[i];
                    }
                    array[i] = value;
                    this.MsgInErr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
            // END ADDED BY XSD
        }
        public bool MsgInErrRemoveItem(int index) {
            // BEGIN ADDED BY XSD - array RemoveItem accessor
            try {
                if ((this.msgInErrField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.msgInErrField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.msgInErrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = msgInErrField[i];
                        }
                        for (i = (i + 1); (i < this.msgInErrField.Length); i = (i + 1)) {
                            array[i] = msgInErrField[i];
                        }
                        this.MsgInErr = array;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RejectReason1Code {
        _begin,
        _none,
        /// <remarks/>
        UNPR,
        /// <remarks/>
        IMSG,
        /// <remarks/>
        PARS,
        /// <remarks/>
        SECU,
        /// <remarks/>
        INTP,
        /// <remarks/>
        RCPP,
        /// <remarks/>
        DPMG,
        /// <remarks/>
        VERS,
        /// <remarks/>
        MSGT,
        _end,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "4.2.1.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.02", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("fa806933-1c69-46f1-8ba5-9d5232f85a4f")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageRejectionV02 : ISaleToPOIMessageRejectionV02 {
        private Header41 hdrField = new Header41();
        private AcceptorRejection2 rjctField = new AcceptorRejection2();
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
        public AcceptorRejection2 Rjct {
            get {
                // BEGIN ADDED BY XSD - return null if user type hasBeenModified=false
                if (((this._XSD_Optimizing == true)
                            && (this.rjctField.XSD_HasBeenSet == false))) {
                    return null;
                }
                // END ADDED BY XSD
                return this.rjctField;
            }
            set {
                // BEGIN ADDED BY XSD - prevent class from being null
                if ((value == null)) {
                    this.rjctField = new AcceptorRejection2();
                }
                else {
                    this.rjctField = value;
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
                            || ((this.Hdr != null)
                            && this.Hdr.XSD_HasBeenSet))
                            || ((this.Rjct != null)
                            && this.Rjct.XSD_HasBeenSet));
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
                if ((this.Rjct != null)) {
                    this.Rjct.XSD_Optimizing = this._XSD_Optimizing;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("47759d73-7626-4a4d-85d3-ceb5e6446b89")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAcceptorRejection2 {
        /// <remarks/>
        [DispId(1)]
        RejectReason1Code RjctRsn {
            get;
        }
        /// <remarks/>
        [DispId(2)]
        string AddtlInf {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        byte[] MsgInErr {
            get;
            set;
        }
        [DispId(4)]
        int MsgInErrSize();
        [DispId(5)]
        byte MsgInErrGetItem(int index);
        [DispId(6)]
        bool MsgInErrSetItem(int index, byte value);
        [DispId(7)]
        bool MsgInErrAddItem(byte value);
        [DispId(8)]
        bool MsgInErrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("e4646d63-7a31-4577-b3f7-9ae852fda1a4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIMessageRejectionV02 {
        /// <remarks/>
        [DispId(1)]
        Header41 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(2)]
        AcceptorRejection2 Rjct {
            get;
            set;
        }
    }
}
#endif
