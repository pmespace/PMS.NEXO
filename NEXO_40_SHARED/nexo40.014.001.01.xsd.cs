namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("a1b3e5f3-a972-418c-b252-e7808e62a4d6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageStatusRequestV01 : ISaleToPOIMessageStatusRequestV01 {
        internal Header37 hdrField = new Header37();
        internal MessageStatusRequest2 stsReqField = new MessageStatusRequest2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIMessageStatusRequestV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIMessageStatusRequestV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public MessageStatusRequest2 StsReq {
            get {
                return this.stsReqField;
            }
            set {
                this.xsdSaleToPOIMessageStatusRequestV01InitFlagField = true;
                this.stsReqField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIMessageStatusRequestV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIMessageStatusRequestV01InitFlag {
            get {
                return this.xsdSaleToPOIMessageStatusRequestV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIMessageStatusRequestV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("d2c00a8f-d989-448e-807d-a90d0a82b24a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIMessageStatusRequestV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        MessageStatusRequest2 StsReq {
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
        bool xsdSaleToPOIMessageStatusRequestV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("322d747d-5c02-4ce7-a200-91ded8b1f587")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusRequest2 : IMessageStatusRequest2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal MessageStatusRequestData1 msgStsReqDataField = new MessageStatusRequestData1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdMessageStatusRequest2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdMessageStatusRequest2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdMessageStatusRequest2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public MessageStatusRequestData1 MsgStsReqData {
            get {
                return this.msgStsReqDataField;
            }
            set {
                this.xsdMessageStatusRequest2InitFlagField = true;
                this.msgStsReqDataField = value;
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
                this.xsdMessageStatusRequest2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdMessageStatusRequest2InitFlag {
            get {
                return this.xsdMessageStatusRequest2InitFlagField;
            }
            set {
                this.xsdMessageStatusRequest2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("26972746-d38e-4520-8434-a381f0048f38")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusRequest2 {
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
        MessageStatusRequestData1 MsgStsReqData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(9)]
        bool xsdMessageStatusRequest2InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int SplmtryDataSize();
        [DispId(11)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(12)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(13)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(14)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.014.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("adb570b5-e143-4459-95d4-1787950b9fde")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusRequestData1 : IMessageStatusRequestData1 {
        internal string xchgIdField;
        internal GenericIdentification171 initgPtyField = new GenericIdentification171();
        internal bool rctRprntFlgField;
        internal bool rctRprntFlgFieldSpecified;
        internal DocumentType7Code[] docQlfrField = new DocumentType7Code[0];
        internal bool xsdMessageStatusRequestData1InitFlagField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = true;
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public GenericIdentification171 InitgPty {
            get {
                return this.initgPtyField;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = true;
                this.initgPtyField = value;
            }
        }
        /// <remarks/>
        public bool RctRprntFlg {
            get {
                return this.rctRprntFlgField;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = true;
                this.rctRprntFlgField = value;
                this.RctRprntFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RctRprntFlgSpecified {
            get {
                return this.rctRprntFlgFieldSpecified;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = true;
                this.rctRprntFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocQlfr")]
        public DocumentType7Code[] DocQlfr {
            get {
                if (((this.docQlfrField == null)
                            || (this.docQlfrField.Length == 0))) {
                    return null;
                }
                return this.docQlfrField;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = true;
                this.docQlfrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdMessageStatusRequestData1InitFlag {
            get {
                return this.xsdMessageStatusRequestData1InitFlagField;
            }
            set {
                this.xsdMessageStatusRequestData1InitFlagField = value;
            }
        }
        public int DocQlfrSize() {
            if ((this.docQlfrField == null)) {
                return 0;
            }
            else {
                return this.docQlfrField.Length;
            }
        }
        public DocumentType7Code DocQlfrGetItem(int index) {
            try {
                if ((this.docQlfrField == default(DocumentType7Code[]))) {
                    return default(DocumentType7Code);
                }
                else {
                    if (((this.docQlfrField.Length - 1)
                                >= index)) {
                        return this.docQlfrField[index];
                    }
                    else {
                        return default(DocumentType7Code);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(DocumentType7Code);
            }
        }
        public bool DocQlfrSetItem(int index, DocumentType7Code value) {
            try {
                if ((this.docQlfrField == default(DocumentType7Code[]))) {
                    return false;
                }
                else {
                    this.docQlfrField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DocQlfrAddItem(DocumentType7Code value) {
            try {
                if ((this.docQlfrField == default(DocumentType7Code[]))) {
                    return false;
                }
                else {
                    DocumentType7Code[] array = new DocumentType7Code[(this.docQlfrField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.docQlfrField.Length); i = (i + 1)) {
                        array[i] = docQlfrField[i];
                    }
                    array[i] = value;
                    this.DocQlfr = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DocQlfrRemoveItem(int index) {
            try {
                if ((this.docQlfrField == default(DocumentType7Code[]))) {
                    return false;
                }
                else {
                    if ((this.docQlfrField.Length <= index)) {
                        return false;
                    }
                    else {
                        DocumentType7Code[] array = new DocumentType7Code[(this.docQlfrField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = docQlfrField[i];
                        }
                        for (i = (i + 1); (i < this.docQlfrField.Length); i = (i + 1)) {
                            array[i] = docQlfrField[i];
                        }
                        this.DocQlfr = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("290805cf-d958-4dc5-84be-a9939aa02675")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusRequestData1 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        GenericIdentification171 InitgPty {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool RctRprntFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        bool RctRprntFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DocumentType7Code[] DocQlfr {
            get;
            set;
        }
        [DispId(11)]
        bool xsdMessageStatusRequestData1InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int DocQlfrSize();
        [DispId(13)]
        DocumentType7Code DocQlfrGetItem(int index);
        [DispId(14)]
        bool DocQlfrSetItem(int index, DocumentType7Code value);
        [DispId(15)]
        bool DocQlfrAddItem(DocumentType7Code value);
        [DispId(16)]
        bool DocQlfrRemoveItem(int index);
    }
}
