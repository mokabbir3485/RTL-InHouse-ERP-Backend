using System;

namespace InventoryEntity
{
    public class proc_SupplierPaymentAdjustment
    {
        public Int64 SPAId { get; set; }
        public DateTime SPADate { get; set; }
        public Int64? SupplierId { get; set; }
        public String SupplierName { get; set; }
        public string Remarks { get; set; }
        public Int32? JVNo { get; set; }
        public Int32? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsLocalPurchase { get; set; }
        public Int64 PBId { get; set; }
        public Decimal? AdjustedAmount { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime PBDate { get; set; }
        public string PBNo { get; set; }
        public decimal TotalCost { get; set; }


    }
}
