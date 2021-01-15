namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3cef9c49-2d31-493e-9700-0bbbab654535")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceDisplayResponse1 : IDeviceDisplayResponse1 {
        internal OutputResult1[] outptRsltField = new OutputResult1[0];
        internal bool xsdDeviceDisplayResponse1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutptRslt")]
        public OutputResult1[] OutptRslt {
            get {
                if (((this.outptRsltField == null)
                            || (this.outptRsltField.Length == 0))) {
                    return null;
                }
                return this.outptRsltField;
            }
            set {
                this.xsdDeviceDisplayResponse1InitFlagField = true;
                this.outptRsltField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceDisplayResponse1InitFlag {
            get {
                return this.xsdDeviceDisplayResponse1InitFlagField;
            }
            set {
                this.xsdDeviceDisplayResponse1InitFlagField = value;
            }
        }
        public int OutptRsltSize() {
            if ((this.outptRsltField == null)) {
                return 0;
            }
            else {
                return this.outptRsltField.Length;
            }
        }
        public OutputResult1 OutptRsltGetItem(int index) {
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return default(OutputResult1);
                }
                else {
                    if (((this.outptRsltField.Length - 1)
                                >= index)) {
                        return this.outptRsltField[index];
                    }
                    else {
                        return default(OutputResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(OutputResult1);
            }
        }
        public bool OutptRsltSetItem(int index, OutputResult1 value) {
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    this.outptRsltField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool OutptRsltAddItem(OutputResult1 value) {
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    OutputResult1[] array = new OutputResult1[(this.outptRsltField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.outptRsltField.Length); i = (i + 1)) {
                        array[i] = outptRsltField[i];
                    }
                    array[i] = value;
                    this.OutptRslt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool OutptRsltRemoveItem(int index) {
            try {
                if ((this.outptRsltField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    if ((this.outptRsltField.Length <= index)) {
                        return false;
                    }
                    else {
                        OutputResult1[] array = new OutputResult1[(this.outptRsltField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = outptRsltField[i];
                        }
                        for (i = (i + 1); (i < this.outptRsltField.Length); i = (i + 1)) {
                            array[i] = outptRsltField[i];
                        }
                        this.OutptRslt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ab3c2b9c-8c6a-4b5b-8a63-60c96f39f2d4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceDisplayResponse1 {
        /// <remarks/>
        [DispId(1)]
        OutputResult1[] OutptRslt {
            get;
            set;
        }
        [DispId(3)]
        bool xsdDeviceDisplayResponse1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int OutptRsltSize();
        [DispId(5)]
        OutputResult1 OutptRsltGetItem(int index);
        [DispId(6)]
        bool OutptRsltSetItem(int index, OutputResult1 value);
        [DispId(7)]
        bool OutptRsltAddItem(OutputResult1 value);
        [DispId(8)]
        bool OutptRsltRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3a5c1ecb-17a1-4c37-97aa-872e2de7994d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OutputResult1 : IOutputResult1 {
        internal UserInterface4Code dvcTpField = new UserInterface4Code();
        internal InformationQualify1Code infQlfrField = new InformationQualify1Code();
        internal ResponseType9 rspnField = new ResponseType9();
        internal bool xsdOutputResult1InitFlagField = false;
        /// <remarks/>
        public UserInterface4Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                this.xsdOutputResult1InitFlagField = true;
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                this.xsdOutputResult1InitFlagField = true;
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdOutputResult1InitFlagField = true;
                this.rspnField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdOutputResult1InitFlag {
            get {
                return this.xsdOutputResult1InitFlagField;
            }
            set {
                this.xsdOutputResult1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a1f49ee8-1183-445c-94c4-2af297b7c634")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IOutputResult1 {
        /// <remarks/>
        [DispId(1)]
        UserInterface4Code DvcTp {
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
        ResponseType9 Rspn {
            get;
            set;
        }
        [DispId(7)]
        bool xsdOutputResult1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("dce825f3-e9d8-4e14-a75f-64e6190de0bc")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInitialisationCardReaderResponse1 : IDeviceInitialisationCardReaderResponse1 {
        internal CardDataReading6Code cardNtryMdField = new CardDataReading6Code();
        internal bool cardNtryMdFieldSpecified;
        internal ICCResetData1 iCCRstDataField = new ICCResetData1();
        internal byte[] addtlInfField = new byte[0];
        internal bool xsdDeviceInitialisationCardReaderResponse1InitFlagField = false;
        /// <remarks/>
        public CardDataReading6Code CardNtryMd {
            get {
                return this.cardNtryMdField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderResponse1InitFlagField = true;
                this.cardNtryMdField = value;
                this.CardNtryMdSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CardNtryMdSpecified {
            get {
                return this.cardNtryMdFieldSpecified;
            }
            set {
                this.xsdDeviceInitialisationCardReaderResponse1InitFlagField = true;
                this.cardNtryMdFieldSpecified = value;
            }
        }
        /// <remarks/>
        public ICCResetData1 ICCRstData {
            get {
                return this.iCCRstDataField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderResponse1InitFlagField = true;
                this.iCCRstDataField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] AddtlInf {
            get {
                if (((this.addtlInfField == null)
                            || (this.addtlInfField.Length == 0))) {
                    return null;
                }
                return this.addtlInfField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderResponse1InitFlagField = true;
                this.addtlInfField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceInitialisationCardReaderResponse1InitFlag {
            get {
                return this.xsdDeviceInitialisationCardReaderResponse1InitFlagField;
            }
            set {
                this.xsdDeviceInitialisationCardReaderResponse1InitFlagField = value;
            }
        }
        public int AddtlInfSize() {
            if ((this.addtlInfField == null)) {
                return 0;
            }
            else {
                return this.addtlInfField.Length;
            }
        }
        public byte AddtlInfGetItem(int index) {
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.addtlInfField.Length - 1)
                                >= index)) {
                        return this.addtlInfField[index];
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
        public bool AddtlInfSetItem(int index, byte value) {
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    this.addtlInfField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool AddtlInfAddItem(byte value) {
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.addtlInfField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.addtlInfField.Length); i = (i + 1)) {
                        array[i] = addtlInfField[i];
                    }
                    array[i] = value;
                    this.AddtlInf = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool AddtlInfRemoveItem(int index) {
            try {
                if ((this.addtlInfField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.addtlInfField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.addtlInfField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = addtlInfField[i];
                        }
                        for (i = (i + 1); (i < this.addtlInfField.Length); i = (i + 1)) {
                            array[i] = addtlInfField[i];
                        }
                        this.AddtlInf = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("0fa4d0e0-6335-47f0-8c99-d1d0b2bf55a3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInitialisationCardReaderResponse1 {
        /// <remarks/>
        [DispId(1)]
        CardDataReading6Code CardNtryMd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool CardNtryMdSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        ICCResetData1 ICCRstData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        byte[] AddtlInf {
            get;
            set;
        }
        [DispId(9)]
        bool xsdDeviceInitialisationCardReaderResponse1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int AddtlInfSize();
        [DispId(11)]
        byte AddtlInfGetItem(int index);
        [DispId(12)]
        bool AddtlInfSetItem(int index, byte value);
        [DispId(13)]
        bool AddtlInfAddItem(byte value);
        [DispId(14)]
        bool AddtlInfRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ccc36b34-729c-4363-9f59-52b2a4b1e8cd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ICCResetData1 : IICCResetData1 {
        internal byte[] aTRValField = new byte[0];
        internal byte[] cardStsField = new byte[0];
        internal bool xsdICCResetData1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] ATRVal {
            get {
                if (((this.aTRValField == null)
                            || (this.aTRValField.Length == 0))) {
                    return null;
                }
                return this.aTRValField;
            }
            set {
                this.xsdICCResetData1InitFlagField = true;
                this.aTRValField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] CardSts {
            get {
                if (((this.cardStsField == null)
                            || (this.cardStsField.Length == 0))) {
                    return null;
                }
                return this.cardStsField;
            }
            set {
                this.xsdICCResetData1InitFlagField = true;
                this.cardStsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdICCResetData1InitFlag {
            get {
                return this.xsdICCResetData1InitFlagField;
            }
            set {
                this.xsdICCResetData1InitFlagField = value;
            }
        }
        public int ATRValSize() {
            if ((this.aTRValField == null)) {
                return 0;
            }
            else {
                return this.aTRValField.Length;
            }
        }
        public byte ATRValGetItem(int index) {
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.aTRValField.Length - 1)
                                >= index)) {
                        return this.aTRValField[index];
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
        public bool ATRValSetItem(int index, byte value) {
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    this.aTRValField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool ATRValAddItem(byte value) {
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.aTRValField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.aTRValField.Length); i = (i + 1)) {
                        array[i] = aTRValField[i];
                    }
                    array[i] = value;
                    this.ATRVal = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool ATRValRemoveItem(int index) {
            try {
                if ((this.aTRValField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.aTRValField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.aTRValField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = aTRValField[i];
                        }
                        for (i = (i + 1); (i < this.aTRValField.Length); i = (i + 1)) {
                            array[i] = aTRValField[i];
                        }
                        this.ATRVal = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public int CardStsSize() {
            if ((this.cardStsField == null)) {
                return 0;
            }
            else {
                return this.cardStsField.Length;
            }
        }
        public byte CardStsGetItem(int index) {
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.cardStsField.Length - 1)
                                >= index)) {
                        return this.cardStsField[index];
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
        public bool CardStsSetItem(int index, byte value) {
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    this.cardStsField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool CardStsAddItem(byte value) {
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.cardStsField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.cardStsField.Length); i = (i + 1)) {
                        array[i] = cardStsField[i];
                    }
                    array[i] = value;
                    this.CardSts = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool CardStsRemoveItem(int index) {
            try {
                if ((this.cardStsField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.cardStsField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.cardStsField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = cardStsField[i];
                        }
                        for (i = (i + 1); (i < this.cardStsField.Length); i = (i + 1)) {
                            array[i] = cardStsField[i];
                        }
                        this.CardSts = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("a81260f6-ee89-4fdf-90f4-f84a70af022f")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IICCResetData1 {
        /// <remarks/>
        [DispId(1)]
        byte[] ATRVal {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        byte[] CardSts {
            get;
            set;
        }
        [DispId(5)]
        bool xsdICCResetData1InitFlag {
            get;
            set;
        }
        [DispId(6)]
        int ATRValSize();
        [DispId(7)]
        byte ATRValGetItem(int index);
        [DispId(8)]
        bool ATRValSetItem(int index, byte value);
        [DispId(9)]
        bool ATRValAddItem(byte value);
        [DispId(10)]
        bool ATRValRemoveItem(int index);
        [DispId(11)]
        int CardStsSize();
        [DispId(12)]
        byte CardStsGetItem(int index);
        [DispId(13)]
        bool CardStsSetItem(int index, byte value);
        [DispId(14)]
        bool CardStsAddItem(byte value);
        [DispId(15)]
        bool CardStsRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("0071611c-d374-409b-a355-fcc79b23f761")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceInputResponse1 : IDeviceInputResponse1 {
        internal OutputResult1 outptRsltField = new OutputResult1();
        internal InputResult1 inptRsltField = new InputResult1();
        internal bool xsdDeviceInputResponse1InitFlagField = false;
        /// <remarks/>
        public OutputResult1 OutptRslt {
            get {
                return this.outptRsltField;
            }
            set {
                this.xsdDeviceInputResponse1InitFlagField = true;
                this.outptRsltField = value;
            }
        }
        /// <remarks/>
        public InputResult1 InptRslt {
            get {
                return this.inptRsltField;
            }
            set {
                this.xsdDeviceInputResponse1InitFlagField = true;
                this.inptRsltField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceInputResponse1InitFlag {
            get {
                return this.xsdDeviceInputResponse1InitFlagField;
            }
            set {
                this.xsdDeviceInputResponse1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("192d81c9-5841-4e30-8b53-5bf42da56a84")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceInputResponse1 {
        /// <remarks/>
        [DispId(1)]
        OutputResult1 OutptRslt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        InputResult1 InptRslt {
            get;
            set;
        }
        [DispId(5)]
        bool xsdDeviceInputResponse1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("246688f1-d533-44d7-a0e4-c5ba4e2f6628")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResult1 : IInputResult1 {
        internal SaleCapabilities2Code dvcTpField = new SaleCapabilities2Code();
        internal InformationQualify1Code infQlfrField = new InformationQualify1Code();
        internal InputResultData1 inptRsltDataField = new InputResultData1();
        internal bool xsdInputResult1InitFlagField = false;
        /// <remarks/>
        public SaleCapabilities2Code DvcTp {
            get {
                return this.dvcTpField;
            }
            set {
                this.xsdInputResult1InitFlagField = true;
                this.dvcTpField = value;
            }
        }
        /// <remarks/>
        public InformationQualify1Code InfQlfr {
            get {
                return this.infQlfrField;
            }
            set {
                this.xsdInputResult1InitFlagField = true;
                this.infQlfrField = value;
            }
        }
        /// <remarks/>
        public InputResultData1 InptRsltData {
            get {
                return this.inptRsltDataField;
            }
            set {
                this.xsdInputResult1InitFlagField = true;
                this.inptRsltDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdInputResult1InitFlag {
            get {
                return this.xsdInputResult1InitFlagField;
            }
            set {
                this.xsdInputResult1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("d8bc8f1f-b5f3-44da-a24f-da031737af05")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResult1 {
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
        InputResultData1 InptRsltData {
            get;
            set;
        }
        [DispId(7)]
        bool xsdInputResult1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("4391cb89-a004-45fd-9a3a-61aa7c96c956")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InputResultData1 : IInputResultData1 {
        internal InputCommand1Code inptCmdField = new InputCommand1Code();
        internal bool confdFlgField;
        internal bool confdFlgFieldSpecified;
        internal double fctnKeyField;
        internal bool fctnKeyFieldSpecified;
        internal string inptMsgField;
        internal ContentInformationType19 pwdField = new ContentInformationType19();
        internal CapturedSignature1 imgCaptrdSgntrField = new CapturedSignature1();
        internal bool xsdInputResultData1InitFlagField = false;
        /// <remarks/>
        public InputCommand1Code InptCmd {
            get {
                return this.inptCmdField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.inptCmdField = value;
            }
        }
        /// <remarks/>
        public bool ConfdFlg {
            get {
                return this.confdFlgField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.confdFlgField = value;
                this.ConfdFlgSpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfdFlgSpecified {
            get {
                return this.confdFlgFieldSpecified;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.confdFlgFieldSpecified = value;
            }
        }
        /// <remarks/>
        public double FctnKey {
            get {
                return this.fctnKeyField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.fctnKeyField = value;
                this.FctnKeySpecified = true;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FctnKeySpecified {
            get {
                return this.fctnKeyFieldSpecified;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.fctnKeyFieldSpecified = value;
            }
        }
        /// <remarks/>
        public string InptMsg {
            get {
                return this.inptMsgField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.inptMsgField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType19 Pwd {
            get {
                return this.pwdField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.pwdField = value;
            }
        }
        /// <remarks/>
        public CapturedSignature1 ImgCaptrdSgntr {
            get {
                return this.imgCaptrdSgntrField;
            }
            set {
                this.xsdInputResultData1InitFlagField = true;
                this.imgCaptrdSgntrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdInputResultData1InitFlag {
            get {
                return this.xsdInputResultData1InitFlagField;
            }
            set {
                this.xsdInputResultData1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("7f4ec12a-2070-41eb-a6c1-5ffded1d73f9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IInputResultData1 {
        /// <remarks/>
        [DispId(1)]
        InputCommand1Code InptCmd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        bool ConfdFlg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        bool ConfdFlgSpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        double FctnKey {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        bool FctnKeySpecified {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        string InptMsg {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        ContentInformationType19 Pwd {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        CapturedSignature1 ImgCaptrdSgntr {
            get;
            set;
        }
        [DispId(17)]
        bool xsdInputResultData1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("9084cf00-a724-4e73-adca-35990480cc25")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DevicePrintResponse1 : IDevicePrintResponse1 {
        internal DocumentType7Code docQlfrField = new DocumentType7Code();
        internal bool xsdDevicePrintResponse1InitFlagField = false;
        /// <remarks/>
        public DocumentType7Code DocQlfr {
            get {
                return this.docQlfrField;
            }
            set {
                this.xsdDevicePrintResponse1InitFlagField = true;
                this.docQlfrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDevicePrintResponse1InitFlag {
            get {
                return this.xsdDevicePrintResponse1InitFlagField;
            }
            set {
                this.xsdDevicePrintResponse1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6dbcfcd8-80f8-4897-a2cb-8ca773933846")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDevicePrintResponse1 {
        /// <remarks/>
        [DispId(1)]
        DocumentType7Code DocQlfr {
            get;
            set;
        }
        [DispId(3)]
        bool xsdDevicePrintResponse1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ce908366-b176-4df8-abbb-0a0aac51b0a4")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceResponse2 : IDeviceResponse2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService9Code svcCnttField = new RetailerService9Code();
        internal OutputResult1[] dispRspnField = new OutputResult1[0];
        internal DeviceInputResponse1 inptRspnField = new DeviceInputResponse1();
        internal DevicePrintResponse1 prtRspnField = new DevicePrintResponse1();
        internal DeviceSecureInputResponse1 scrInptRspnField = new DeviceSecureInputResponse1();
        internal DeviceInitialisationCardReaderResponse1 initlstnCardRdrRspnField = new DeviceInitialisationCardReaderResponse1();
        internal DeviceSendApplicationProtocolDataUnitCardReaderResponse1 cardRdrApplPrtcolDataUnitRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
        internal DeviceTransmitMessageResponse1 trnsmssnRspnField = new DeviceTransmitMessageResponse1();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdDeviceResponse2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService9Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutptRslt", IsNullable=false)]
        public OutputResult1[] DispRspn {
            get {
                if (((this.dispRspnField == null)
                            || (this.dispRspnField.Length == 0))) {
                    return null;
                }
                return this.dispRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.dispRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceInputResponse1 InptRspn {
            get {
                return this.inptRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.inptRspnField = value;
            }
        }
        /// <remarks/>
        public DevicePrintResponse1 PrtRspn {
            get {
                return this.prtRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.prtRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceSecureInputResponse1 ScrInptRspn {
            get {
                return this.scrInptRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.scrInptRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceInitialisationCardReaderResponse1 InitlstnCardRdrRspn {
            get {
                return this.initlstnCardRdrRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.initlstnCardRdrRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderResponse1 CardRdrApplPrtcolDataUnitRspn {
            get {
                return this.cardRdrApplPrtcolDataUnitRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.cardRdrApplPrtcolDataUnitRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceTransmitMessageResponse1 TrnsmssnRspn {
            get {
                return this.trnsmssnRspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
                this.trnsmssnRspnField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = true;
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
                this.xsdDeviceResponse2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceResponse2InitFlag {
            get {
                return this.xsdDeviceResponse2InitFlagField;
            }
            set {
                this.xsdDeviceResponse2InitFlagField = value;
            }
        }
        public int DispRspnSize() {
            if ((this.dispRspnField == null)) {
                return 0;
            }
            else {
                return this.dispRspnField.Length;
            }
        }
        public OutputResult1 DispRspnGetItem(int index) {
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return default(OutputResult1);
                }
                else {
                    if (((this.dispRspnField.Length - 1)
                                >= index)) {
                        return this.dispRspnField[index];
                    }
                    else {
                        return default(OutputResult1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(OutputResult1);
            }
        }
        public bool DispRspnSetItem(int index, OutputResult1 value) {
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    this.dispRspnField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DispRspnAddItem(OutputResult1 value) {
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    OutputResult1[] array = new OutputResult1[(this.dispRspnField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dispRspnField.Length); i = (i + 1)) {
                        array[i] = dispRspnField[i];
                    }
                    array[i] = value;
                    this.DispRspn = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DispRspnRemoveItem(int index) {
            try {
                if ((this.dispRspnField == default(OutputResult1[]))) {
                    return false;
                }
                else {
                    if ((this.dispRspnField.Length <= index)) {
                        return false;
                    }
                    else {
                        OutputResult1[] array = new OutputResult1[(this.dispRspnField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dispRspnField[i];
                        }
                        for (i = (i + 1); (i < this.dispRspnField.Length); i = (i + 1)) {
                            array[i] = dispRspnField[i];
                        }
                        this.DispRspn = array;
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
    [System.Runtime.InteropServices.GuidAttribute("894f7ab6-cfcc-4f36-9576-4b2dd068b770")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceResponse2 {
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
        RetailerService9Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        OutputResult1[] DispRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        DeviceInputResponse1 InptRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        DevicePrintResponse1 PrtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        DeviceSecureInputResponse1 ScrInptRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        DeviceInitialisationCardReaderResponse1 InitlstnCardRdrRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        DeviceSendApplicationProtocolDataUnitCardReaderResponse1 CardRdrApplPrtcolDataUnitRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(19)]
        DeviceTransmitMessageResponse1 TrnsmssnRspn {
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
        bool xsdDeviceResponse2InitFlag {
            get;
            set;
        }
        [DispId(26)]
        int DispRspnSize();
        [DispId(27)]
        OutputResult1 DispRspnGetItem(int index);
        [DispId(28)]
        bool DispRspnSetItem(int index, OutputResult1 value);
        [DispId(29)]
        bool DispRspnAddItem(OutputResult1 value);
        [DispId(30)]
        bool DispRspnRemoveItem(int index);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService9Code {
        /// <remarks/>
        DDYP,
        /// <remarks/>
        DINP,
        /// <remarks/>
        DPRP,
        /// <remarks/>
        DSOP,
        /// <remarks/>
        DSIP,
        /// <remarks/>
        DCIP,
        /// <remarks/>
        DCAP,
        /// <remarks/>
        DCPP,
        /// <remarks/>
        DCOP,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("2ecc270b-29b6-4c20-8e13-f7ce8919008c")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSecureInputResponse1 : IDeviceSecureInputResponse1 {
        internal OnLinePIN6 crdhldrPINField = new OnLinePIN6();
        internal bool xsdDeviceSecureInputResponse1InitFlagField = false;
        /// <remarks/>
        public OnLinePIN6 CrdhldrPIN {
            get {
                return this.crdhldrPINField;
            }
            set {
                this.xsdDeviceSecureInputResponse1InitFlagField = true;
                this.crdhldrPINField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceSecureInputResponse1InitFlag {
            get {
                return this.xsdDeviceSecureInputResponse1InitFlagField;
            }
            set {
                this.xsdDeviceSecureInputResponse1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("4cac88a1-bfea-4ca1-9bc7-0733b1688cfa")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSecureInputResponse1 {
        /// <remarks/>
        [DispId(1)]
        OnLinePIN6 CrdhldrPIN {
            get;
            set;
        }
        [DispId(3)]
        bool xsdDeviceSecureInputResponse1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("3cc3db42-26ef-4917-9913-76c41736461d")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceTransmitMessageResponse1 : IDeviceTransmitMessageResponse1 {
        internal byte[] rcvdMsgField = new byte[0];
        internal bool xsdDeviceTransmitMessageResponse1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] RcvdMsg {
            get {
                if (((this.rcvdMsgField == null)
                            || (this.rcvdMsgField.Length == 0))) {
                    return null;
                }
                return this.rcvdMsgField;
            }
            set {
                this.xsdDeviceTransmitMessageResponse1InitFlagField = true;
                this.rcvdMsgField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceTransmitMessageResponse1InitFlag {
            get {
                return this.xsdDeviceTransmitMessageResponse1InitFlagField;
            }
            set {
                this.xsdDeviceTransmitMessageResponse1InitFlagField = value;
            }
        }
        public int RcvdMsgSize() {
            if ((this.rcvdMsgField == null)) {
                return 0;
            }
            else {
                return this.rcvdMsgField.Length;
            }
        }
        public byte RcvdMsgGetItem(int index) {
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.rcvdMsgField.Length - 1)
                                >= index)) {
                        return this.rcvdMsgField[index];
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
        public bool RcvdMsgSetItem(int index, byte value) {
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    this.rcvdMsgField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool RcvdMsgAddItem(byte value) {
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.rcvdMsgField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.rcvdMsgField.Length); i = (i + 1)) {
                        array[i] = rcvdMsgField[i];
                    }
                    array[i] = value;
                    this.RcvdMsg = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool RcvdMsgRemoveItem(int index) {
            try {
                if ((this.rcvdMsgField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.rcvdMsgField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.rcvdMsgField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = rcvdMsgField[i];
                        }
                        for (i = (i + 1); (i < this.rcvdMsgField.Length); i = (i + 1)) {
                            array[i] = rcvdMsgField[i];
                        }
                        this.RcvdMsg = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("6ac6ed2e-f376-411f-97c0-cdcb0aa82de5")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceTransmitMessageResponse1 {
        /// <remarks/>
        [DispId(1)]
        byte[] RcvdMsg {
            get;
            set;
        }
        [DispId(3)]
        bool xsdDeviceTransmitMessageResponse1InitFlag {
            get;
            set;
        }
        [DispId(4)]
        int RcvdMsgSize();
        [DispId(5)]
        byte RcvdMsgGetItem(int index);
        [DispId(6)]
        bool RcvdMsgSetItem(int index, byte value);
        [DispId(7)]
        bool RcvdMsgAddItem(byte value);
        [DispId(8)]
        bool RcvdMsgRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.017.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("91cfa45f-a083-4be4-91fd-0b285e1beb2a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIDeviceResponseV01 : ISaleToPOIDeviceResponseV01 {
        internal Header37 hdrField = new Header37();
        internal DeviceResponse2 dvcRspnField = new DeviceResponse2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIDeviceResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIDeviceResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public DeviceResponse2 DvcRspn {
            get {
                return this.dvcRspnField;
            }
            set {
                this.xsdSaleToPOIDeviceResponseV01InitFlagField = true;
                this.dvcRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIDeviceResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIDeviceResponseV01InitFlag {
            get {
                return this.xsdSaleToPOIDeviceResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIDeviceResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("1ffe1ea8-4b5b-4c55-a219-0e688e78f9a1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIDeviceResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        DeviceResponse2 DvcRspn {
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
        bool xsdSaleToPOIDeviceResponseV01InitFlag {
            get;
            set;
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TagsEnumeration {
        Abrt,
        AbrtRsn,
        AccptdByCrdhldr,
        AccptdByCrdhldrSpecified,
        AccsCd,
        AccsdBy,
        Acct,
        AcctId,
        AcctNb,
        AcctRef,
        AcctTp,
        AcctTpSpecified,
        Acqrr,
        AcqrrId,
        ActlAmt,
        ActlAmtSpecified,
        Actn,
        ActnId,
        ActnTp,
        Actv,
        ActvtnDt,
        ActvtnDtSpecified,
        AddtlAvlblPdct,
        AddtlCardData,
        AddtlCtctInf,
        AddtlErrInf,
        AddtlEvtInf,
        AddtlId,
        AddtlInf,
        AddtlInpt,
        AddtlMgmtInf,
        AddtlParams,
        AddtlPdctCd,
        AddtlPdctDesc,
        AddtlRslt,
        AddtlRspnInf,
        AddtlSaleData,
        AddtlSvc,
        AddtlTxData,
        AddtlVhclData,
        AdmstvReq,
        AdmstvRspn,
        AdmstvSvcId,
        Adr,
        AdrDgts,
        AdrLine,
        AdrTp,
        AdrTpSpecified,
        AdrVal,
        AdrVrfctn,
        AggtnTx,
        Algo,
        AllwdLltyBrnd,
        AllwdNtryMd,
        AllwdPdct,
        AllwdPdctCd,
        AllwdPmtBrnd,
        AlnRegnNb,
        AlphaCd,
        Amt,
        AmtGoodsAndSvcs,
        AmtGoodsAndSvcsSpecified,
        AmtLmt,
        AmtLmtSpecified,
        AmtQlfr,
        AmtQlfrSpecified,
        ApprvlCd,
        ApprvlCdLngth,
        ApprvlCdLngthSpecified,
        Assgnr,
        Assmnt,
        ATRVal,
        AttndncCntxt,
        AttndncCntxtSpecified,
        AttndntLang,
        AttndntMsgCpbl,
        AttndntMsgCpblSpecified,
        AttrTp,
        AttrVal,
        AuthntcdData,
        Authntcn,
        AuthntcnAddtlInf,
        AuthntcnLvl,
        AuthntcnMtd,
        AuthntcnRslt,
        AuthntcnRsltSpecified,
        AuthntcnTp,
        AuthntcnVal,
        AuthrsdAmt,
        AuthrsdAmtSpecified,
        AuthstnCd,
        AuthstnNtty,
        AuthstnRslt,
        AvlblFrmt,
        AvlblLang,
        Bal,
        BalNqryReq,
        BalNqryRspn,
        BalSpecified,
        BeepKeyFlg,
        BeepKeyFlgSpecified,
        BirthDt,
        BkId,
        BlckStart,
        BlckStartSpecified,
        BlckStop,
        BlckStopSpecified,
        BldgNb,
        BllgAdr,
        BPddg,
        BPddgSpecified,
        BrcdTp,
        BrcdVal,
        Brnd,
        BtchReq,
        BtchRspn,
        Card,
        CardAcqstnReq,
        CardAcqstnRspn,
        CardBrnd,
        CardCaptrCpbl,
        CardCaptrCpblSpecified,
        CardCcyCd,
        CardCtryCd,
        CardDataNtryMd,
        CardDataNtryMdSpecified,
        CardNtryMd,
        CardNtryMdSpecified,
        CardPdctPrfl,
        CardPdctSubTp,
        CardPdctTp,
        CardPdctTpSpecified,
        CardPres,
        CardPresSpecified,
        CardPrgrmmApld,
        CardPrgrmmPropsd,
        CardRdngCpblties,
        CardRdrAPDUReq,
        CardRdrApplPrtcolDataUnitRspn,
        CardSeqNb,
        CardSts,
        Ccy,
        CcyConvs,
        CcyConvsElgblty,
        CcyConvsId,
        CcyConvsRslt,
        Cdtr,
        CdtrId,
        Cert,
        Chck,
        ChckCardNb,
        ChckNb,
        ChckTp,
        ChckTpSpecified,
        ChckTrckData2,
        Chrgs,
        ChrgsSpecified,
        Chrtcs,
        CityOfBirth,
        ClntCert,
        Clss,
        CmltvAmt,
        CmltvAmtSpecified,
        CmonNm,
        CmpltnReqrd,
        CmpltnReqrdSpecified,
        Cmpnt,
        CmpntId,
        Cntt,
        CnttNcrptnAlgo,
        CnttTp,
        Cntxt,
        Com,
        ComssnDtls,
        ComTp,
        ConfdFlg,
        ConfdFlgSpecified,
        Convs,
        ConvsDtls,
        Cpblties,
        Crdhldr,
        CrdhldrId,
        CrdhldrNm,
        CrdhldrOnLinePIN,
        CrdhldrPIN,
        CrdhldrPres,
        CrdhldrPresSpecified,
        CrdhldrVrfctnCpblties,
        CreDtTm,
        CreDtTmSpecified,
        CritOrdr,
        CshBck,
        CshBckFlg,
        CshBckFlgSpecified,
        CshBckSpecified,
        CshrId,
        CshrLang,
        CstmrCnsnt,
        CstmrCnsntSpecified,
        CstmrDvc,
        CstmrLang,
        CstmrNb,
        CstmrOrdr,
        CstmrOrdrId,
        CstmrOrdrReq,
        CstmrOrdrReqFlg,
        CstmrOrdrReqFlgSpecified,
        CstmrOrdrReqSpecified,
        CstmrSvc,
        CstmrTkn,
        Ctry,
        CtryCd,
        CtryOfBirth,
        CtrySubDvsn,
        CurAmt,
        CurAmtSpecified,
        CurBal,
        CurBalSpecified,
        Data,
        DataSetId,
        DataSetReqrd,
        DbtPrefrdFlg,
        DbtPrefrdFlgSpecified,
        Dbtr,
        DbtrId,
        DclrtnDtls,
        Dcml,
        DcmlSpecified,
        DeactvtnDt,
        DeactvtnDtSpecified,
        Dept,
        DerivtnId,
        DgnssReq,
        DgnssRspn,
        Dgst,
        DgstAlgo,
        DgstAlgoSpecified,
        DgstdData,
        DispOutpt,
        DispReq,
        DispRspn,
        DlgtnProof,
        DlvryDt,
        DlvryDtSpecified,
        DlvryLctn,
        DlvryNoteNb,
        DlvrySvc,
        DlvrySvcSpecified,
        DocQlfr,
        DrctDbtCntxt,
        DrvrId,
        DrvrLicLctn,
        DrvrLicNb,
        DrvrLicNm,
        DrvrOrVhclCard,
        DsblCclFlg,
        DsblCclFlgSpecified,
        DsblCrrctFlg,
        DsblCrrctFlgSpecified,
        DsblVldFlg,
        DsblVldFlgSpecified,
        DscndgOrdr,
        DscndgOrdrSpecified,
        Dstn,
        DstnAdr,
        DtAndPlcOfBirth,
        DtldAmt,
        DtOfSgntr,
        DtOfSgntrSpecified,
        DtTm,
        DvcReq,
        DvcRspn,
        DvcTp,
        EANUPC,
        Email,
        EmailAdr,
        EndDt,
        EndDtSpecified,
        Envlp,
        EnvlpdData,
        Envt,
        Errs,
        Evt,
        EvtCntxt,
        EvtNtfctn,
        EvtTmStmp,
        EvtToNtfy,
        Fctn,
        FctnKey,
        FctnKeySpecified,
        FctvDt,
        Fees,
        FllbckInd,
        FllbckIndSpecified,
        ForceCstmrSelctnFlg,
        ForceCstmrSelctnFlgSpecified,
        ForceNtryMd,
        ForceOnlnFlg,
        ForceOnlnFlgSpecified,
        FrcstdAmt,
        FreeSz,
        Frmt,
        FrmtSpecified,
        FrstAmt,
        FrstAmtSpecified,
        FrstPmtDt,
        FrstPmtDtSpecified,
        FrstPmtDtTm,
        FrstPmtDtTmSpecified,
        GblCrrctnFlg,
        GblCrrctnFlgSpecified,
        GeogcCordints,
        Glctn,
        GrpId,
        Grtty,
        GrttySpecified,
        Hbmtr,
        HbmtrSpecified,
        Hdr,
        HstDgnssFlg,
        HstDgnssFlgSpecified,
        HstRcncltnId,
        HstSts,
        HstTxId,
        ICCRltdData,
        ICCRstData,
        Id,
        IdntyCardNb,
        IdTp,
        IdTpSpecified,
        ImdtRspnFlg,
        ImdtRspnFlgSpecified,
        IMEI,
        ImgCaptrdSgntr,
        ImgData,
        ImgFrmt,
        ImgRef,
        IMSI,
        IndvPmt,
        InfQlfr,
        InfQlfrSpecified,
        InitgPty,
        InitlstnCardRdrReq,
        InitlstnCardRdrRspn,
        InitlstnVctr,
        InptCmd,
        InptData,
        InptMsg,
        InptNtfctn,
        InptReq,
        InptRslt,
        InptRsltData,
        InptRspn,
        InptTxt,
        Instlmt,
        InstlmtPlan,
        InstlmtPrd,
        InstlmtPrdSpecified,
        Instr,
        IntgrtdPrtFlg,
        IntgrtdPrtFlgSpecified,
        IntrfcNm,
        IntrfcTp,
        IntrfcTpSpecified,
        IntrnlCard,
        IntrnlCardSpecified,
        InvcAmt,
        InvcAmtSpecified,
        InvcNb,
        Issr,
        IssrBIN,
        IssrRefData,
        IssrSpecified,
        Item,
        ItemElementName,
        ItmAmt,
        ItmAmtSpecified,
        ItmId,
        ItmNb,
        JobNb,
        KEKId,
        KeyChckVal,
        KeyId,
        KeyNcrptnAlgo,
        KeyVal,
        KeyVrsn,
        Labl,
        Lang,
        LastPmtDtTm,
        LastPmtDtTmSpecified,
        LastTxFlg,
        LastTxFlgSpecified,
        Lat,
        LctnAndCtct,
        LctnCtgy,
        LctnCtgySpecified,
        LeavCardFlg,
        LeavCardFlgSpecified,
        LggdSaleId,
        LgnDtTm,
        LgnReq,
        LgnRspn,
        LgtReq,
        LineWidth,
        LineWidthSpecified,
        LltyAcct,
        LltyAcctReq,
        LltyData,
        LltyHdlg,
        LltyHdlgSpecified,
        LltyId,
        LltyReq,
        LltyRslt,
        LltyRspn,
        LltySvrId,
        LltyTxId,
        LltyTxTp,
        LltyTxTtl,
        LltyUnit,
        LltyUnitSpecified,
        Long,
        MAC,
        MACAlgo,
        MaxAmt,
        MaxAmtSpecified,
        MaxCshBckAmt,
        MaxCshBckAmtSpecified,
        MaxInptTm,
        MaxInptTmSpecified,
        MaxTrnsmssnTm,
        MaxWtgTm,
        MaxWtgTmSpecified,
        MenuBckFlg,
        MenuBckFlgSpecified,
        MinAmt,
        MinAmtSpecified,
        MinAmtToDlvr,
        MinAmtToDlvrSpecified,
        MinDispTm,
        MinDispTmSpecified,
        MinSpltAmt,
        MinSpltAmtSpecified,
        Mmry,
        MndtId,
        MndtImg,
        MndtRltdInf,
        MntncAllwd,
        MntncAllwdSpecified,
        MntncId,
        MntncReqrdFlg,
        MntncReqrdFlgSpecified,
        MobCtryCd,
        MobData,
        MobMskdMSISDN,
        MobNtwkCd,
        MplyeeIdNb,
        MplyrIdNb,
        Mrchnt,
        MrchntCtgyCd,
        MrchntOvrrdFlg,
        MrchntOvrrdFlgSpecified,
        MrchntRefData,
        MrkUpDtls,
        MsgCntt,
        MsgCnttSgntr,
        MsgCpblties,
        MsgDstn,
        MsgFctn,
        MsgInErr,
        MsgStsReqData,
        MsgStsRspnData,
        MsgToPres,
        MsgToSnd,
        MSISDN,
        MskdPAN,
        MskGnrtrAlgo,
        Mtd,
        MxScrptLngth,
        MxScrptLngthSpecified,
        Nb,
        NblSvcReq,
        NbOfLines,
        NbOfLinesSpecified,
        NbOfPmts,
        NbOfPmtsSpecified,
        NcpsltdCntt,
        NcrptdCntt,
        NcrptdData,
        NcrptdKey,
        NcrptdPINBlck,
        NcrptnFrmt,
        NcrptnFrmtSpecified,
        Nm,
        NmrcCd,
        NotAllwdPdctCd,
        NtfyCardInptFlg,
        NtryMd,
        NtryMdSpecified,
        NtwkTp,
        NvrtdXchgRate,
        NvrtdXchgRateSpecified,
        Odmtr,
        OdmtrSpecified,
        OnLineCntxt,
        OnLineCntxtSpecified,
        OnLineCpblties,
        OnLineCpbltiesSpecified,
        OnLineRsn,
        OnlnFlg,
        OnlnFlgSpecified,
        OpnOrdrStat,
        OpnOrdrStatSpecified,
        Oprtr,
        OrgnlAmt,
        OrgnlPmtTx,
        OrgnlPOITx,
        OrgnlTx,
        OrgtrInf,
        Othr,
        OutptBrcd,
        OutptCntt,
        OutptRslt,
        OwnrNm,
        PAN,
        Param,
        Param1,
        Param2,
        Params,
        ParamsVrsn,
        PdctAmt,
        PdctAmtSgn,
        PdctAmtSgnSpecified,
        PdctCd,
        PdctCdSetId,
        PdctDesc,
        PdctQty,
        PdctQtySpecified,
        Phne,
        PhysIntrfc,
        PINFrmt,
        PINLngthCpblties,
        PINLngthCpbltiesSpecified,
        PINReqTp,
        PINVrfctnMtd,
        PlainCardData,
        PlanId,
        PlaySoundReq,
        PlcAndNm,
        PmtAcct,
        PmtAcctRef,
        PmtAcctReq,
        PmtAcqrrData,
        PmtBrnd,
        PmtCntxt,
        PmtInstrmTp,
        PmtRct,
        PmtReq,
        PmtRslt,
        PmtRspn,
        PmtTkn,
        PmtTp,
        PmtTpSpecified,
        PmtTx,
        POI,
        POIChllng,
        POICmpnt,
        POICpblties,
        POIDtTm,
        POIGrpId,
        POIId,
        POIRcncltnId,
        POISftwr,
        POISts,
        POITxId,
        PrdUnit,
        PrdUnitSpecified,
        PrfrmdTx,
        PrsnlData,
        PrtcolNm,
        PrtcolVrsn,
        PrtctdAuthntcnVal,
        PrtctdBal,
        PrtctdCaptrdSgntr,
        PrtctdCardData,
        PrtctdCrdhldrData,
        PrtctdDlgtnProof,
        PrtctdMobData,
        PrtctdVal,
        PrtReq,
        PrtRspn,
        PrvcOfBirth,
        Prvdr,
        PrvdrId,
        PrvtCardData,
        PsptNb,
        PstCd,
        PstCdId,
        PstlAdr,
        PstlCdDgts,
        PurchsOrdrNb,
        Pwd,
        PwrOffCardRdrReq,
        PwrOffMaxWtgTm,
        PwrOffMaxWtgTmSpecified,
        QRCdBinryVal,
        QRCdErrCrrctn,
        QRCdErrCrrctnSpecified,
        QRCdNcodgMd,
        QRCdVrsn,
        QtnDt,
        QtnDtSpecified,
        QtyLmt,
        QtyLmtSpecified,
        Rate,
        Rbt,
        RbtLabl,
        Rbts,
        Rchbl,
        RchblSpecified,
        RcncltnId,
        RcncltnReq,
        RcncltnReqData,
        RcncltnRspn,
        RcncltnRspnData,
        RcncltnTp,
        Rcpt,
        RcptId,
        RcptPty,
        Rct,
        RctRprntFlg,
        RctRprntFlgSpecified,
        RcvdMsg,
        RefrHrs,
        RegdIdr,
        RegnId,
        ReqdAmt,
        ReqdAmtSpecified,
        ReqdTx,
        ReqrdSgntrFlg,
        ReqrdSgntrFlgSpecified,
        ReuseCardDataFlg,
        ReuseCardDataFlgSpecified,
        Rjct,
        RjctRsn,
        RlayId,
        RltvDstngshdNm,
        RmngAmt,
        RmngAmtSpecified,
        RmotAccs,
        RmotPty,
        RmvAllFlg,
        RmvAllFlgSpecified,
        RpeatdCardAcqstnRspn,
        RpeatdLltyRspn,
        RpeatdPmtRspn,
        RpeatdRvslRspn,
        RpeatdSndApplPrtcolDataUnitCardRdrRspn,
        RpeatdStordValRspn,
        RplcmntCar,
        RplcmntCarSpecified,
        RptFullSz,
        RptGetTtlsReq,
        RptGetTtlsRspn,
        RptReq,
        RptRspn,
        RptTxReq,
        RptTxRspn,
        RqstrId,
        Rslt,
        RsltgAmt,
        RsltRsn,
        RsltSpecified,
        Rspn,
        RspnMd,
        RspnMdSpecified,
        RspnReqrdFlg,
        RspnReqrdFlgSpecified,
        RspnRsn,
        RspnRsnSpecified,
        RspnToAuthstn,
        RtlrEvt,
        RtlrPmtRslt,
        RvsdAmt,
        RvsdAmtSpecified,
        RvslReq,
        RvslRsn,
        RvslRspn,
        RvslTxRslt,
        SaleChanl,
        SaleCntxt,
        SaleCpblties,
        SaleEnvt,
        SaleId,
        SaleItm,
        SaleItmRbt,
        SaleRcncltnId,
        SaleRefId,
        SaleRefNb,
        SaleSftwr,
        SaleTermnlData,
        SaleTknScp,
        SaleTknScpSpecified,
        SaleToAcqrrData,
        SaleToIssrData,
        SaleToPOIData,
        SaleToPOISvcReq,
        SaleTxId,
        SaltLngth,
        SbcbrIdntyMdls,
        SbcbrIdntyMdlsSpecified,
        SchAnd,
        SchCrit,
        SchmeData,
        SchmeNm,
        SchOr,
        SchOutptOrdr,
        SclSctyNb,
        ScrInptReq,
        ScrInptRspn,
        SctyAccsMdls,
        SctyAccsMdlsSpecified,
        SctyElmt,
        SctyPrfl,
        SctyTrlr,
        SeqNb,
        SeqNbSpecified,
        Sgn,
        SgndAttrbts,
        SgndData,
        Sgnr,
        SgnrId,
        SgnSpecified,
        Sgntr,
        SgntrAlgo,
        ShftNb,
        ShppgAdr,
        ShrtNm,
        SnstvMobData,
        SoundActn,
        SoundCntt,
        SoundFrmt,
        SoundRef,
        SoundVol,
        SoundVolSpecified,
        SplmtryData,
        SpltPmt,
        SpltPmtSpecified,
        SpnsrdMrchnt,
        SpprtdOptn,
        SrcCcy,
        Srchrg,
        SrlNb,
        SsnKey,
        SsnMgmtReq,
        SsnMgmtRspn,
        StartDt,
        StdCmplc,
        StordValAcct,
        StordValAcctReq,
        StordValReq,
        StordValRspn,
        StrtNm,
        Sts,
        StsReq,
        StsRspn,
        StsSpecified,
        SubDept,
        SubTpInf,
        SvcAttr,
        SvcAttrSpecified,
        SvcCd,
        SvcCntt,
        SvcOptn,
        SvcReq,
        SvcRspn,
        SvcsNbld,
        SvcsNbldSpecified,
        SvcTp,
        SvrCert,
        SvrCertIdr,
        SvrData,
        SysAbrt,
        SysNm,
        TaxIdNb,
        TaxTp,
        TermnlEnvt,
        TermnlEnvtSpecified,
        TermnlIntgtn,
        TermnlIntgtnSpecified,
        TermnlMgrId,
        Tkn,
        TknAssrncData,
        TknAssrncLvl,
        TknAssrncLvlSpecified,
        TknChrtc,
        TknReqdTp,
        TknReqdTpSpecified,
        TknRqstr,
        TknXpryDt,
        TMChllng,
        TMSCtctDtTm,
        TMSCtctDtTmSpecified,
        TMSCtctLvl,
        TMSId,
        TmStmp,
        TMSTrggr,
        TmZone,
        Tp,
        TpSpecified,
        Tracblt,
        TracDtTmIn,
        TracDtTmOut,
        Trck1,
        Trck2,
        Trck3,
        TrckFrmt,
        TrckFrmtSpecified,
        TrckNb,
        TrckNbSpecified,
        TrckVal,
        Trgt,
        TrgtCcy,
        TripNb,
        TrlrFld,
        TrlrFldSpecified,
        TrlrHrs,
        TrlrNb,
        TrngMdFlg,
        TrngMdFlgSpecified,
        TrnsmssnReq,
        TrnsmssnRspn,
        TtlAmt,
        TtlAmtSpecified,
        TtlDtls,
        TtlDtlsSpecified,
        TtlFltr,
        TtlNb,
        TtlNbOfPmts,
        TtlNbOfPmtsSpecified,
        TtlRbt,
        TtlRbtSpecified,
        TtlsGrpId,
        TtlSz,
        TwnNm,
        Tx,
        TxActn,
        TxCaptr,
        TxCaptrSpecified,
        TxChanl,
        TxChanlSpecified,
        TxDtls,
        TxDtTm,
        TxEnvt,
        TxEnvtSpecified,
        TxId,
        TxRef,
        TxRpt,
        TxRspn,
        Txt,
        TxToPrfrm,
        TxTp,
        TxTtl,
        TxTtls,
        TxTtlsSet,
        TxVrfctnRslt,
        UattnddLvlCtgy,
        Unit,
        UnitNb,
        UnitOfMeasr,
        UnitOfMeasrSpecified,
        UnitPric,
        UnitPricSgn,
        UnitPricSgnSpecified,
        UnitPricSpecified,
        UnitSpecified,
        URLAdr,
        UsrNm,
        UTMCordints,
        UTMEstwrd,
        UTMNrthwrd,
        UTMZone,
        Val,
        ValAddedTax,
        ValAddedTaxSpecified,
        Value,
        Vhcl,
        VhclNb,
        VhclTag,
        VhclTagNtryMd,
        VhclTagNtryMdSpecified,
        VldtyDt,
        VldtyDtSpecified,
        VldUntil,
        VldUntilSpecified,
        VrfctnNtty,
        VrfctnNttySpecified,
        Vrsn,
        VrsnNb,
        VrsnSpecified,
        WaitUsrVldtnFlg,
        WaitUsrVldtnFlgSpecified,
        WarmRstFlg,
        WarmRstFlgSpecified,
        Wllt,
        XchgId,
        XchgRate,
        XpctdLngth,
        XprtnDt,
        XprtnDtSpecified,
        XpryDt,
        XpryDtSpecified,
    }
}
