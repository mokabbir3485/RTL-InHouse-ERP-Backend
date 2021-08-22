using System;


namespace ExportEntity
{
    public class exp_ConsumptionCertificate
    {
        public Int64 ConsumptionCertificateId { get; set; }
        public Int64 CommercialInvoiceId { get; set; }
        public string CommercialInvoiceNo { get; set; }
        public string StatementNo { get; set; }
        public DateTime StatementDate { get; set; }
        public string ImporterDeliveryAddress { get; set; }

        public string BillOfEntryNo { get; set; }
        public string BillOfEntryDate { get; set; }
        public string ImporterName { get; set; }
        public string EpzPermissionNo { get; set; }
        public string EpzPermissionDate { get; set; }
        public string LcScNo { get; set; }
        public DateTime LcDate { get; set; }
        public string DEPZPermissionNo { get; set; }
        public string DEPZPermissionDate { get; set; }
        public string InvoiceNo { get; set; }

        public string CompanyNameBilling { get; set; }
        public string CompanyNameDelivery { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
