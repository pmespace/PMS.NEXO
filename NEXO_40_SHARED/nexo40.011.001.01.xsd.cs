namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("04620ad2-6712-4b1f-b8a7-99c686a1e094")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AbortData1 : IAbortData1 {
        internal string xchgIdField;
        internal string abrtRsnField;
        internal ActionMessage6 dispOutptField = new ActionMessage6();
        internal bool xsdAbortData1InitFlagField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xsdAbortData1InitFlagField = true;
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public string AbrtRsn {
            get {
                return this.abrtRsnField;
            }
            set {
                this.xsdAbortData1InitFlagField = true;
                this.abrtRsnField = value;
            }
        }
        /// <remarks/>
        public ActionMessage6 DispOutpt {
            get {
                return this.dispOutptField;
            }
            set {
                this.xsdAbortData1InitFlagField = true;
                this.dispOutptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdAbortData1InitFlag {
            get {
                return this.xsdAbortData1InitFlagField;
            }
            set {
                this.xsdAbortData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7b74df2e-a371-4e70-bb79-ad913cc4969a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IAbortData1 {
        /// <remarks/>
        [DispId(1)]
        string XchgId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        string AbrtRsn {
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
        bool xsdAbortData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2aebe2cd-2a2e-4e1c-9956-9de1103aa4e6")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIAbortV01 : ISaleToPOIAbortV01 {
        internal Header37 hdrField = new Header37();
        internal SystemAbort2 abrtField = new SystemAbort2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIAbortV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIAbortV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public SystemAbort2 Abrt {
            get {
                return this.abrtField;
            }
            set {
                this.xsdSaleToPOIAbortV01InitFlagField = true;
                this.abrtField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIAbortV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIAbortV01InitFlag {
            get {
                return this.xsdSaleToPOIAbortV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIAbortV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("d2d50f9e-d6a4-4bf0-9664-6e9b7cf3fc0d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIAbortV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        SystemAbort2 Abrt {
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
        bool xsdSaleToPOIAbortV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.011.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ecaf2d6c-7966-4c98-bb31-ee2644053e7e")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SystemAbort2 : ISystemAbort2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal AbortData1 sysAbrtField = new AbortData1();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdSystemAbort2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdSystemAbort2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdSystemAbort2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public AbortData1 SysAbrt {
            get {
                return this.sysAbrtField;
            }
            set {
                this.xsdSystemAbort2InitFlagField = true;
                this.sysAbrtField = value;
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
                this.xsdSystemAbort2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSystemAbort2InitFlag {
            get {
                return this.xsdSystemAbort2InitFlagField;
            }
            set {
                this.xsdSystemAbort2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("3fc0ff34-262c-43b5-a9f5-0b00cad84bdf")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISystemAbort2 {
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
        AbortData1 SysAbrt {
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
        bool xsdSystemAbort2InitFlag {
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
}
