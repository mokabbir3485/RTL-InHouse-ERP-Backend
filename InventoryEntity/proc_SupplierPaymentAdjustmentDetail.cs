using System;

namespace InventoryEntity
{
    public class proc_SupplierPaymentAdjustmentDetail
    {
        public Int64 SPADetailId { get; set; }
        public Int64? SPAId { get; set; }
        public bool IsLocalPurchase { get; set; }
        public Int64 PBId { get; set; }
        public string PBNo { get; set; }
        public DateTime PBDate { get; set; }
        public Decimal? AdjustedAmount { get; set; }
        public Decimal? ActualAmount { get; set; }
        public Int64? SupplierId { get; set; }



    }
}
