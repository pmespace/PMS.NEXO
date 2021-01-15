namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("09a2da1e-6924-471f-a6c8-3bf19fe2507a")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DeviceSendApplicationProtocolDataUnitCardReaderResponse1 : IDeviceSendApplicationProtocolDataUnitCardReaderResponse1 {
        internal byte[] dataField = new byte[0];
        internal byte[] cardStsField = new byte[0];
        internal bool xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlagField = false;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Data {
            get {
                if (((this.dataField == null)
                            || (this.dataField.Length == 0))) {
                    return null;
                }
                return this.dataField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlagField = true;
                this.dataField = value;
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
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlagField = true;
                this.cardStsField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlag {
            get {
                return this.xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlagField;
            }
            set {
                this.xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlagField = value;
            }
        }
        public int DataSize() {
            if ((this.dataField == null)) {
                return 0;
            }
            else {
                return this.dataField.Length;
            }
        }
        public byte DataGetItem(int index) {
            try {
                if ((this.dataField == default(byte[]))) {
                    return default(byte);
                }
                else {
                    if (((this.dataField.Length - 1)
                                >= index)) {
                        return this.dataField[index];
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
        public bool DataSetItem(int index, byte value) {
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    this.dataField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DataAddItem(byte value) {
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    byte[] array = new byte[(this.dataField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.dataField.Length); i = (i + 1)) {
                        array[i] = dataField[i];
                    }
                    array[i] = value;
                    this.Data = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool DataRemoveItem(int index) {
            try {
                if ((this.dataField == default(byte[]))) {
                    return false;
                }
                else {
                    if ((this.dataField.Length <= index)) {
                        return false;
                    }
                    else {
                        byte[] array = new byte[(this.dataField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        for (i = (i + 1); (i < this.dataField.Length); i = (i + 1)) {
                            array[i] = dataField[i];
                        }
                        this.Data = array;
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
    [System.Runtime.InteropServices.GuidAttribute("0e31ce04-425d-443a-8963-ab3e9fb8c771")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IDeviceSendApplicationProtocolDataUnitCardReaderResponse1 {
        /// <remarks/>
        [DispId(1)]
        byte[] Data {
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
        bool xsdDeviceSendApplicationProtocolDataUnitCardReaderResponse1InitFlag {
            get;
            set;
        }
        [DispId(6)]
        int DataSize();
        [DispId(7)]
        byte DataGetItem(int index);
        [DispId(8)]
        bool DataSetItem(int index, byte value);
        [DispId(9)]
        bool DataAddItem(byte value);
        [DispId(10)]
        bool DataRemoveItem(int index);
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("496b7d2e-fbd9-4988-8fa1-47a7a74833fb")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIMessageStatusResponseV01 : ISaleToPOIMessageStatusResponseV01 {
        internal Header37 hdrField = new Header37();
        internal MessageStatusResponse2 stsRspnField = new MessageStatusResponse2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIMessageStatusResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIMessageStatusResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public MessageStatusResponse2 StsRspn {
            get {
                return this.stsRspnField;
            }
            set {
                this.xsdSaleToPOIMessageStatusResponseV01InitFlagField = true;
                this.stsRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIMessageStatusResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIMessageStatusResponseV01InitFlag {
            get {
                return this.xsdSaleToPOIMessageStatusResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIMessageStatusResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("17dec134-6514-4c13-b7f4-babf692cbf51")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIMessageStatusResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        MessageStatusResponse2 StsRspn {
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
        bool xsdSaleToPOIMessageStatusResponseV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("f84dc5c1-1beb-4670-b8c2-ae677ce40eaa")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusResponse2 : IMessageStatusResponse2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal MessageStatusResponseData2 msgStsRspnDataField = new MessageStatusResponseData2();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdMessageStatusResponse2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdMessageStatusResponse2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdMessageStatusResponse2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public MessageStatusResponseData2 MsgStsRspnData {
            get {
                return this.msgStsRspnDataField;
            }
            set {
                this.xsdMessageStatusResponse2InitFlagField = true;
                this.msgStsRspnDataField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdMessageStatusResponse2InitFlagField = true;
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
                this.xsdMessageStatusResponse2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdMessageStatusResponse2InitFlag {
            get {
                return this.xsdMessageStatusResponse2InitFlagField;
            }
            set {
                this.xsdMessageStatusResponse2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("253e0f94-b542-4f0d-8d62-2c685d864937")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusResponse2 {
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
        MessageStatusResponseData2 MsgStsRspnData {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(11)]
        bool xsdMessageStatusResponse2InitFlag {
            get;
            set;
        }
        [DispId(12)]
        int SplmtryDataSize();
        [DispId(13)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(14)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(15)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(16)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.015.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("02977337-ac5b-4cfc-8463-79e9a12a8ea0")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MessageStatusResponseData2 : IMessageStatusResponseData2 {
        internal string xchgIdField;
        internal GenericIdentification171 initgPtyField = new GenericIdentification171();
        internal ResponseType9 txRspnField = new ResponseType9();
        internal LoyaltyResponse1 rpeatdLltyRspnField = new LoyaltyResponse1();
        internal PaymentResponse1 rpeatdPmtRspnField = new PaymentResponse1();
        internal ReversalResponse1 rpeatdRvslRspnField = new ReversalResponse1();
        internal StoredValueResponse2 rpeatdStordValRspnField = new StoredValueResponse2();
        internal CardAcquisitionResponse1 rpeatdCardAcqstnRspnField = new CardAcquisitionResponse1();
        internal DeviceSendApplicationProtocolDataUnitCardReaderResponse1 rpeatdSndApplPrtcolDataUnitCardRdrRspnField = new DeviceSendApplicationProtocolDataUnitCardReaderResponse1();
        internal bool xsdMessageStatusResponseData2InitFlagField = false;
        /// <remarks/>
        public string XchgId {
            get {
                return this.xchgIdField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.xchgIdField = value;
            }
        }
        /// <remarks/>
        public GenericIdentification171 InitgPty {
            get {
                return this.initgPtyField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.initgPtyField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 TxRspn {
            get {
                return this.txRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.txRspnField = value;
            }
        }
        /// <remarks/>
        public LoyaltyResponse1 RpeatdLltyRspn {
            get {
                return this.rpeatdLltyRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdLltyRspnField = value;
            }
        }
        /// <remarks/>
        public PaymentResponse1 RpeatdPmtRspn {
            get {
                return this.rpeatdPmtRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdPmtRspnField = value;
            }
        }
        /// <remarks/>
        public ReversalResponse1 RpeatdRvslRspn {
            get {
                return this.rpeatdRvslRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdRvslRspnField = value;
            }
        }
        /// <remarks/>
        public StoredValueResponse2 RpeatdStordValRspn {
            get {
                return this.rpeatdStordValRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdStordValRspnField = value;
            }
        }
        /// <remarks/>
        public CardAcquisitionResponse1 RpeatdCardAcqstnRspn {
            get {
                return this.rpeatdCardAcqstnRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdCardAcqstnRspnField = value;
            }
        }
        /// <remarks/>
        public DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn {
            get {
                return this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = true;
                this.rpeatdSndApplPrtcolDataUnitCardRdrRspnField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdMessageStatusResponseData2InitFlag {
            get {
                return this.xsdMessageStatusResponseData2InitFlagField;
            }
            set {
                this.xsdMessageStatusResponseData2InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("dc70ebdd-a9f8-41e6-b825-ac49123552bc")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IMessageStatusResponseData2 {
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
        ResponseType9 TxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        LoyaltyResponse1 RpeatdLltyRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        PaymentResponse1 RpeatdPmtRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(11)]
        ReversalResponse1 RpeatdRvslRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(13)]
        StoredValueResponse2 RpeatdStordValRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(15)]
        CardAcquisitionResponse1 RpeatdCardAcqstnRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(17)]
        DeviceSendApplicationProtocolDataUnitCardReaderResponse1 RpeatdSndApplPrtcolDataUnitCardRdrRspn {
            get;
            set;
        }
        [DispId(19)]
        bool xsdMessageStatusResponseData2InitFlag {
            get;
            set;
        }
    }
}
