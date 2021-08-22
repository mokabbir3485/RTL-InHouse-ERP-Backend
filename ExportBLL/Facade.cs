namespace ExportBLL
{
    public static class Facade
    {
        public static exp_BankDocumentBLL exp_BankDocument { get { return new exp_BankDocumentBLL(); } }
        public static exp_BankDocumentDetailBLL exp_BankDocumentDetail { get { return new exp_BankDocumentDetailBLL(); } }
        public static exp_CommercialInvoiceBLL exp_CommercialInvoice { get { return new exp_CommercialInvoiceBLL(); } }
        public static exp_CommercialInvoiceInfoBLL expCommercialInvoiceInfo { get { return new exp_CommercialInvoiceInfoBLL(); } }
        public static exp_ConsumptionCertificateBLL exp_ConsumptionCertificate { get { return new exp_ConsumptionCertificateBLL(); } }
        public static exp_ConsumptionCertificateDescriptionBLL exp_ConsumptionCertificateDescription { get { return new exp_ConsumptionCertificateDescriptionBLL(); } }
        public static exp_ConsumptionCertificateRawMaterialsBLL exp_ConsumptionCertificateRawMaterials { get { return new exp_ConsumptionCertificateRawMaterialsBLL(); } }
        public static exp_InvoiceBLL exp_Invoice { get { return new exp_InvoiceBLL(); } }
        public static exp_PackingInfoBLL exp_PackingInfo { get { return new exp_PackingInfoBLL(); } }
        public static exp_CommercialInvoice_PackingInfoBLL exp_CommercialInvoice_PackingInfo { get { return new exp_CommercialInvoice_PackingInfoBLL(); } }
        public static exp_PaymentProcessBLL exp_PaymentProcess { get { return new exp_PaymentProcessBLL(); } }
        public static exp_ExporterBLL exp_Exporter { get { return new exp_ExporterBLL(); } }
        public static exp_AmendmentReasonBLL exp_AmendmentReason { get { return new exp_AmendmentReasonBLL(); } }
        public static exp_ApprovalBLL exp_Approval { get { return new exp_ApprovalBLL(); } }
        public static exp_ExportReportsBLL exp_ExpReports { get { return new exp_ExportReportsBLL(); } }
        public static exp_PutSubmissionBLL exp_PutSubmission { get { return new exp_PutSubmissionBLL(); } }
        public static exp_UploadAttachmentBLL exp_UploadAttachment { get { return new exp_UploadAttachmentBLL(); } }
        public static exp_TruckChallanBLL exp_TruckChallan { get { return new exp_TruckChallanBLL(); } }
        public static exp_POReferenceBLL exp_POReferenceBLL { get { return new exp_POReferenceBLL(); } }
    }
}
