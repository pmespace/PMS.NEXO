namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4eaabcf5-9ee9-4eff-a004-85bd801089e6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AcceptorRejection2 : IAcceptorRejection2 {
        internal RejectReason1Code rjctRsnField = new RejectReason1Code();
        internal string addtlInfField;
        internal byte[] msgInErrField = new byte[0];
        internal bool xsdAcceptorRejection2InitFlagField = false;
        /// <remarks/>
        public RejectReason1Code RjctRsn {
            get {
                return this.rjctRsnField;
            }
            set {
                this.xsdAcceptorRejection2InitFlagField = true;
                this.rjctRsnField = value;
            }
        }
        /// <remarks/>
        public string AddtlInf {
            get {
                return this.addtlInfField;
            }
            set {
                this.xsdAcceptorRejection2InitFlagField = true;
                this.addtlInfField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] MsgInErr {
            get {
                if (((this.msgInErrField == null)
                            || (this.msgInErrField.Length == 0))) {
                    return null;
                }
                return this.msgInErrField;
            }
            set {
                this.xsdAcceptorRejection2InitFlagField = true;
                this.msgInErrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdAcceptorRejection2InitFlag {
            get {
                return this.xsdAcceptorRejection2InitFlagField;
            }
            set {
                this.xsdAcceptorRejection2InitFlagField = value;
            }
        }
        public int MsgInErrSize() {
            if ((this.msgInErrField == null)) {
                return 0;
            }
            else {
                return this.msgInErrField.Length;
            }
        }
        public byte MsgInErrGetItem(int index) {
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
        }
        public bool MsgInErrSetItem(int index, byte value) {
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
        }
        public bool MsgInErrAddItem(byte value) {
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
        }
        public bool MsgInErrRemoveItem(int index) {
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
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("e9fe530a-db16-4a24-800d-fa6d40209d06")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAcceptorRejection2 {
        /// <remarks/>
        [DispId(1)]
        RejectReason1Code RjctRsn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string AddtlInf {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        byte[] MsgInErr {
            get;
            set;
        }
        [DispId(7)]
        bool xsdAcceptorRejection2InitFlag {
            get;
            set;
        }
        [DispId(8)]
        int MsgInErrSize();
        [DispId(9)]
        byte MsgInErrGetItem(int index);
        [DispId(10)]
        bool MsgInErrSetItem(int index, byte value);
        [DispId(11)]
        bool MsgInErrAddItem(byte value);
        [DispId(12)]
        bool MsgInErrRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RejectReason1Code {
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("38a35dd5-09d6-48ea-a210-3d4a46bfc242")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageRejectionV01 : ISaleToPOIMessageRejectionV01 {
        internal Header37 hdrField = new Header37();
        internal AcceptorRejection2 rjctField = new AcceptorRejection2();
        internal bool xsdSaleToPOIMessageRejectionV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIMessageRejectionV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public AcceptorRejection2 Rjct {
            get {
                return this.rjctField;
            }
            set {
                this.xsdSaleToPOIMessageRejectionV01InitFlagField = true;
                this.rjctField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIMessageRejectionV01InitFlag {
            get {
                return this.xsdSaleToPOIMessageRejectionV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIMessageRejectionV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("cb813c27-c617-4152-abe6-5eb26536ce47")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIMessageRejectionV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        AcceptorRejection2 Rjct {
            get;
            set;
        }
        [DispId(5)]
        bool xsdSaleToPOIMessageRejectionV01InitFlag {
            get;
            set;
        }
    }
}
