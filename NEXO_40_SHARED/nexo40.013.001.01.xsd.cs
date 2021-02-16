#if NEXO40
namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("d3e8e32f-5405-4139-bc08-b96feec16faa")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AcceptorRejection2 : IAcceptorRejection2 {
        private RejectReason1Code rjctRsnField;
        private string addtlInfField;
        private byte[] msgInErrField = new byte[0];
        private bool XSD_HasBeenSetField = false;
        private bool XSD_OptimizingField = false;
        /// <remarks/>
        public RejectReason1Code RjctRsn {
            get {
                return this.rjctRsnField;
            }
            set {
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.rjctRsnField = value;
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
                // BEGIN ADDED BY XSD - indicate system value has been changed
                this.XSD_HasBeenSetField = true;
                // END ADDED BY XSD
                this.msgInErrField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.14.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.013.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("7dc7ffd1-0039-4342-86e0-04738d7655b2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageRejectionV01 : ISaleToPOIMessageRejectionV01 {
        private Header37 hdrField = new Header37();
        private AcceptorRejection2 rjctField = new AcceptorRejection2();
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
        public AcceptorRejection2 Rjct {
            get {
                // BEGIN ADDED BY XSD - return null if array count is 0, still keeping the array
                if (((this.XSD_OptimizingField == true)
                            && (this.rjctField.XSD_HasBeenSetProperty == false))) {
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
        public bool XSD_HasBeenSetProperty {
            get {
                // BEGIN ADDED BY XSD
                return ((this.XSD_HasBeenSetField || this.Hdr.XSD_HasBeenSetProperty)
                            || this.Rjct.XSD_HasBeenSetProperty);
                // END ADDED BY XSD
            }
            set {
                // BEGIN ADDED BY XSD - AddSetStatementFromValue
                this.XSD_HasBeenSetField = value;
                // END ADDED BY XSD - AddSetStatementFromValue
                // BEGIN ADDED BY XSD
                if ((this.XSD_HasBeenSetField == false)) {
                    this.Hdr = null;
                    this.Rjct = null;
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
                if ((this.Rjct != null)) {
                    this.Rjct.XSD_OptimizingProperty = this.XSD_OptimizingField;
                }
                // END ADDED BY XSD
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("76a73698-c58d-4f51-8881-2ee9fe246ff1")]
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
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
        [DispId(5)]
        int MsgInErrSize();
        [DispId(6)]
        byte MsgInErrGetItem(int index);
        [DispId(7)]
        bool MsgInErrSetItem(int index, byte value);
        [DispId(8)]
        bool MsgInErrAddItem(byte value);
        [DispId(9)]
        bool MsgInErrRemoveItem(int index);
    }
    [System.Runtime.InteropServices.GuidAttribute("6efd2c5c-96fe-4ec4-bb82-d0dfa19e77f6")]
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
        [DispId(2)]
        AcceptorRejection2 Rjct {
            get;
            set;
        }
        [DispId(3)]
        bool XSD_HasBeenSetProperty {
            get;
            set;
        }
    }
}
#endif
