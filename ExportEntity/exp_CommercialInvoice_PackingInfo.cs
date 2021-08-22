using System;

namespace ExportEntity
{
    public class exp_CommercialInvoice_PackingInfo
    {
        public Int64 CIPackingInfold { get; set; }
        public Int64 CommercialInvoiceId { get; set; }
        public Int32 TotalCarton { get; set; }
        public Decimal LabelNetWeight { get; set; }
        public Decimal LabelGrossWeight { get; set; }
        public Decimal RibonNetWeight { get; set; }
        public Decimal RibonGrossWeight { get; set; }
        public string CartonMeasurement { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
