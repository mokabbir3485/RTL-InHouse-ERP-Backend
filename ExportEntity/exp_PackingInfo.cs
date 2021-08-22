using System;

namespace ExportEntity
{
    public class exp_PackingInfo
    {
        public Int64 PackingInfoId { get; set; }
        public Int64 InvoiceId { get; set; }
        public Int32 TotalCarton { get; set; }
        public Decimal LabelNetWeight { get; set; }
        public Decimal LabelGrossWeight { get; set; }
        public Decimal RibonNetWeight { get; set; }
        public Decimal RibonGrossWeight { get; set; }
        public string CartonMeasurement { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string FinalDestination { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CommercialInvoiceNo { get; set; }
    }
}
