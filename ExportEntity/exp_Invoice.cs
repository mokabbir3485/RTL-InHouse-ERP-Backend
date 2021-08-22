using System;

namespace ExportEntity
{
    public class exp_Invoice
    {
        public Int64 InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceType { get; set; }
        public Int32 ExporterBankId { get; set; }
        public Int32 ImporterBankId { get; set; }
        public string PlaceOfLoading { get; set; }
        public string FinalDestination { get; set; }
        public string TypeOfCarrier { get; set; }
        public string DescriptionOfGoods { get; set; }
        public string MasterContactNo { get; set; }
        public DateTime MasterContactDate { get; set; }
        public string SalesOrderIds { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Factory { get; set; }
        public Int32 ExporterId { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Decimal Amount { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; } // added for getting company when PI revised get for Edit
        public string SalesOrderNos { get; set; }
        public string DocStatus { get; set; }
        public string SQLMessage { get; set; }
        public bool IsSubmit { get; set; }
        public bool IsAmendment { get; set; }
        public int IsDifferentFormLC { get; set; }
        public int IsChecked { get; set; }

        public string CompanyNameBilling { get; set; }
        public string AddressBilling { get; set; }
        public string CompanyNameDelivery { get; set; }
        public string AddressDelivery { get; set; }
        public string TermsAndCondition { get; set; }

        public int DocRefId { get; set; }
        public int RefEmployeeId { get; set; }

    }
}
