namespace NEXO {
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("1fd7dd05-0b39-4977-a908-498a86d98aa3")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SaleToPOIReportResponseV01 : ISaleToPOIReportResponseV01 {
        internal Header37 hdrField = new Header37();
        internal ReportResponse2 rptRspnField = new ReportResponse2();
        internal ContentInformationType18 sctyTrlrField = new ContentInformationType18();
        internal bool xsdSaleToPOIReportResponseV01InitFlagField = false;
        /// <remarks/>
        public Header37 Hdr {
            get {
                return this.hdrField;
            }
            set {
                this.xsdSaleToPOIReportResponseV01InitFlagField = true;
                this.hdrField = value;
            }
        }
        /// <remarks/>
        public ReportResponse2 RptRspn {
            get {
                return this.rptRspnField;
            }
            set {
                this.xsdSaleToPOIReportResponseV01InitFlagField = true;
                this.rptRspnField = value;
            }
        }
        /// <remarks/>
        public ContentInformationType18 SctyTrlr {
            get {
                return this.sctyTrlrField;
            }
            set {
                this.xsdSaleToPOIReportResponseV01InitFlagField = true;
                this.sctyTrlrField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdSaleToPOIReportResponseV01InitFlag {
            get {
                return this.xsdSaleToPOIReportResponseV01InitFlagField;
            }
            set {
                this.xsdSaleToPOIReportResponseV01InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("29af4290-380d-431a-a382-76c53c1e5066")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface ISaleToPOIReportResponseV01 {
        /// <remarks/>
        [DispId(1)]
        Header37 Hdr {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        ReportResponse2 RptRspn {
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
        bool xsdSaleToPOIReportResponseV01InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("61979b3b-9a47-4e5e-9db9-9912237d1ea8")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportResponse2 : IReportResponse2 {
        internal CardPaymentEnvironment73 envtField = new CardPaymentEnvironment73();
        internal CardPaymentContext27 cntxtField = new CardPaymentContext27();
        internal RetailerService7Code svcCnttField = new RetailerService7Code();
        internal ReportTransactionResponse1 rptTxRspnField = new ReportTransactionResponse1();
        internal ReportGetTotalsResponse1 rptGetTtlsRspnField = new ReportGetTotalsResponse1();
        internal ResponseType9 rspnField = new ResponseType9();
        internal SupplementaryData1[] splmtryDataField = new SupplementaryData1[0];
        internal bool xsdReportResponse2InitFlagField = false;
        /// <remarks/>
        public CardPaymentEnvironment73 Envt {
            get {
                return this.envtField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
                this.envtField = value;
            }
        }
        /// <remarks/>
        public CardPaymentContext27 Cntxt {
            get {
                return this.cntxtField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
                this.cntxtField = value;
            }
        }
        /// <remarks/>
        public RetailerService7Code SvcCntt {
            get {
                return this.svcCnttField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
                this.svcCnttField = value;
            }
        }
        /// <remarks/>
        public ReportTransactionResponse1 RptTxRspn {
            get {
                return this.rptTxRspnField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
                this.rptTxRspnField = value;
            }
        }
        /// <remarks/>
        public ReportGetTotalsResponse1 RptGetTtlsRspn {
            get {
                return this.rptGetTtlsRspnField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
                this.rptGetTtlsRspnField = value;
            }
        }
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdReportResponse2InitFlagField = true;
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
                this.xsdReportResponse2InitFlagField = true;
                this.splmtryDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportResponse2InitFlag {
            get {
                return this.xsdReportResponse2InitFlagField;
            }
            set {
                this.xsdReportResponse2InitFlagField = value;
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
    [System.Runtime.InteropServices.GuidAttribute("37694bdd-ce40-41da-8b41-31d6800ae46d")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportResponse2 {
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
        RetailerService7Code SvcCntt {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        ReportTransactionResponse1 RptTxRspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(9)]
        ReportGetTotalsResponse1 RptGetTtlsRspn {
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
        [DispId(13)]
        SupplementaryData1[] SplmtryData {
            get;
            set;
        }
        [DispId(15)]
        bool xsdReportResponse2InitFlag {
            get;
            set;
        }
        [DispId(16)]
        int SplmtryDataSize();
        [DispId(17)]
        SupplementaryData1 SplmtryDataGetItem(int index);
        [DispId(18)]
        bool SplmtryDataSetItem(int index, SupplementaryData1 value);
        [DispId(19)]
        bool SplmtryDataAddItem(SupplementaryData1 value);
        [DispId(20)]
        bool SplmtryDataRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RetailerService7Code {
        /// <remarks/>
        RPTP,
        /// <remarks/>
        RPAP,
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("ad98d492-d054-4a0f-81f5-e2c3dad6ca70")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportTransactionResponse1 : IReportTransactionResponse1 {
        internal double rptFullSzField;
        internal double blckStartField;
        internal double blckStopField;
        internal PointOfInteractionTransactionReport1[] txRptField = new PointOfInteractionTransactionReport1[0];
        internal bool xsdReportTransactionResponse1InitFlagField = false;
        /// <remarks/>
        public double RptFullSz {
            get {
                return this.rptFullSzField;
            }
            set {
                this.xsdReportTransactionResponse1InitFlagField = true;
                this.rptFullSzField = value;
            }
        }
        /// <remarks/>
        public double BlckStart {
            get {
                return this.blckStartField;
            }
            set {
                this.xsdReportTransactionResponse1InitFlagField = true;
                this.blckStartField = value;
            }
        }
        /// <remarks/>
        public double BlckStop {
            get {
                return this.blckStopField;
            }
            set {
                this.xsdReportTransactionResponse1InitFlagField = true;
                this.blckStopField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxRpt")]
        public PointOfInteractionTransactionReport1[] TxRpt {
            get {
                if (((this.txRptField == null)
                            || (this.txRptField.Length == 0))) {
                    return null;
                }
                return this.txRptField;
            }
            set {
                this.xsdReportTransactionResponse1InitFlagField = true;
                this.txRptField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportTransactionResponse1InitFlag {
            get {
                return this.xsdReportTransactionResponse1InitFlagField;
            }
            set {
                this.xsdReportTransactionResponse1InitFlagField = value;
            }
        }
        public int TxRptSize() {
            if ((this.txRptField == null)) {
                return 0;
            }
            else {
                return this.txRptField.Length;
            }
        }
        public PointOfInteractionTransactionReport1 TxRptGetItem(int index) {
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport1[]))) {
                    return default(PointOfInteractionTransactionReport1);
                }
                else {
                    if (((this.txRptField.Length - 1)
                                >= index)) {
                        return this.txRptField[index];
                    }
                    else {
                        return default(PointOfInteractionTransactionReport1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(PointOfInteractionTransactionReport1);
            }
        }
        public bool TxRptSetItem(int index, PointOfInteractionTransactionReport1 value) {
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport1[]))) {
                    return false;
                }
                else {
                    this.txRptField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TxRptAddItem(PointOfInteractionTransactionReport1 value) {
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport1[]))) {
                    return false;
                }
                else {
                    PointOfInteractionTransactionReport1[] array = new PointOfInteractionTransactionReport1[(this.txRptField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txRptField.Length); i = (i + 1)) {
                        array[i] = txRptField[i];
                    }
                    array[i] = value;
                    this.TxRpt = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TxRptRemoveItem(int index) {
            try {
                if ((this.txRptField == default(PointOfInteractionTransactionReport1[]))) {
                    return false;
                }
                else {
                    if ((this.txRptField.Length <= index)) {
                        return false;
                    }
                    else {
                        PointOfInteractionTransactionReport1[] array = new PointOfInteractionTransactionReport1[(this.txRptField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txRptField[i];
                        }
                        for (i = (i + 1); (i < this.txRptField.Length); i = (i + 1)) {
                            array[i] = txRptField[i];
                        }
                        this.TxRpt = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("04417af7-6d24-4f2a-ba4a-feac3d34f7d1")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportTransactionResponse1 {
        /// <remarks/>
        [DispId(1)]
        double RptFullSz {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        double BlckStart {
            get;
            set;
        }
        /// <remarks/>
        [DispId(5)]
        double BlckStop {
            get;
            set;
        }
        /// <remarks/>
        [DispId(7)]
        PointOfInteractionTransactionReport1[] TxRpt {
            get;
            set;
        }
        [DispId(9)]
        bool xsdReportTransactionResponse1InitFlag {
            get;
            set;
        }
        [DispId(10)]
        int TxRptSize();
        [DispId(11)]
        PointOfInteractionTransactionReport1 TxRptGetItem(int index);
        [DispId(12)]
        bool TxRptSetItem(int index, PointOfInteractionTransactionReport1 value);
        [DispId(13)]
        bool TxRptAddItem(PointOfInteractionTransactionReport1 value);
        [DispId(14)]
        bool TxRptRemoveItem(int index);
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("b60aef14-26f4-4744-9d0f-800b46635649")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PointOfInteractionTransactionReport1 : IPointOfInteractionTransactionReport1 {
        internal ResponseType9 rspnField = new ResponseType9();
        internal PaymentResponse1 pmtRspnField = new PaymentResponse1();
        internal bool xsdPointOfInteractionTransactionReport1InitFlagField = false;
        /// <remarks/>
        public ResponseType9 Rspn {
            get {
                return this.rspnField;
            }
            set {
                this.xsdPointOfInteractionTransactionReport1InitFlagField = true;
                this.rspnField = value;
            }
        }
        /// <remarks/>
        public PaymentResponse1 PmtRspn {
            get {
                return this.pmtRspnField;
            }
            set {
                this.xsdPointOfInteractionTransactionReport1InitFlagField = true;
                this.pmtRspnField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdPointOfInteractionTransactionReport1InitFlag {
            get {
                return this.xsdPointOfInteractionTransactionReport1InitFlagField;
            }
            set {
                this.xsdPointOfInteractionTransactionReport1InitFlagField = value;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("e0a542f3-8d05-408a-8372-3eb5cdc28d21")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IPointOfInteractionTransactionReport1 {
        /// <remarks/>
        [DispId(1)]
        ResponseType9 Rspn {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        PaymentResponse1 PmtRspn {
            get;
            set;
        }
        [DispId(5)]
        bool xsdPointOfInteractionTransactionReport1InitFlag {
            get;
            set;
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("myXSD", "2.0.12.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:casp.010.001.01", IsNullable=true)]
    [System.Runtime.InteropServices.GuidAttribute("61cc31b8-65e0-44ee-996c-a3952edc45dd")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReportGetTotalsResponse1 : IReportGetTotalsResponse1 {
        internal string pOIRcncltnIdField;
        internal TransactionTotalsSet1[] txTtlsSetField = new TransactionTotalsSet1[0];
        internal bool xsdReportGetTotalsResponse1InitFlagField = false;
        /// <remarks/>
        public string POIRcncltnId {
            get {
                return this.pOIRcncltnIdField;
            }
            set {
                this.xsdReportGetTotalsResponse1InitFlagField = true;
                this.pOIRcncltnIdField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TxTtlsSet")]
        public TransactionTotalsSet1[] TxTtlsSet {
            get {
                if (((this.txTtlsSetField == null)
                            || (this.txTtlsSetField.Length == 0))) {
                    return null;
                }
                return this.txTtlsSetField;
            }
            set {
                this.xsdReportGetTotalsResponse1InitFlagField = true;
                this.txTtlsSetField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsdReportGetTotalsResponse1InitFlag {
            get {
                return this.xsdReportGetTotalsResponse1InitFlagField;
            }
            set {
                this.xsdReportGetTotalsResponse1InitFlagField = value;
            }
        }
        public int TxTtlsSetSize() {
            if ((this.txTtlsSetField == null)) {
                return 0;
            }
            else {
                return this.txTtlsSetField.Length;
            }
        }
        public TransactionTotalsSet1 TxTtlsSetGetItem(int index) {
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return default(TransactionTotalsSet1);
                }
                else {
                    if (((this.txTtlsSetField.Length - 1)
                                >= index)) {
                        return this.txTtlsSetField[index];
                    }
                    else {
                        return default(TransactionTotalsSet1);
                    }
                }
            }
            catch (System.Exception ex) {
                return default(TransactionTotalsSet1);
            }
        }
        public bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value) {
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    this.txTtlsSetField[index] = value;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TxTtlsSetAddItem(TransactionTotalsSet1 value) {
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length + 1)];
                    int i = 0;
                    for (i = 0; (i < this.txTtlsSetField.Length); i = (i + 1)) {
                        array[i] = txTtlsSetField[i];
                    }
                    array[i] = value;
                    this.TxTtlsSet = array;
                    return true;
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
        public bool TxTtlsSetRemoveItem(int index) {
            try {
                if ((this.txTtlsSetField == default(TransactionTotalsSet1[]))) {
                    return false;
                }
                else {
                    if ((this.txTtlsSetField.Length <= index)) {
                        return false;
                    }
                    else {
                        TransactionTotalsSet1[] array = new TransactionTotalsSet1[(this.txTtlsSetField.Length - 1)];
                        int i = 0;
                        for (i = 0; (i < index); i = (i + 1)) {
                            array[i] = txTtlsSetField[i];
                        }
                        for (i = (i + 1); (i < this.txTtlsSetField.Length); i = (i + 1)) {
                            array[i] = txTtlsSetField[i];
                        }
                        this.TxTtlsSet = array;
                        return true;
                    }
                }
            }
            catch (System.Exception ex) {
                return false;
            }
        }
    }
    [System.Runtime.InteropServices.GuidAttribute("ca1dbf67-5858-439f-913e-c5a45a37f767")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public interface IReportGetTotalsResponse1 {
        /// <remarks/>
        [DispId(1)]
        string POIRcncltnId {
            get;
            set;
        }
        /// <remarks/>
        [DispId(3)]
        TransactionTotalsSet1[] TxTtlsSet {
            get;
            set;
        }
        [DispId(5)]
        bool xsdReportGetTotalsResponse1InitFlag {
            get;
            set;
        }
        [DispId(6)]
        int TxTtlsSetSize();
        [DispId(7)]
        TransactionTotalsSet1 TxTtlsSetGetItem(int index);
        [DispId(8)]
        bool TxTtlsSetSetItem(int index, TransactionTotalsSet1 value);
        [DispId(9)]
        bool TxTtlsSetAddItem(TransactionTotalsSet1 value);
        [DispId(10)]
        bool TxTtlsSetRemoveItem(int index);
    }
}
