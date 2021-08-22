using System;

namespace InventoryEntity
{
    public class proc_SupplierPaymentDetail
    {
        public Int64 SupplierPaymentDetailId { get; set; }
        public Int64 SupplierPaymentId { get; set; }
        public bool IsLocalPurchase { get; set; }
        public Int64 PBId { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? VAT { get; set; }
        public decimal? AIT { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? ActualAmount { get; set; }
        public DateTime PBDate { get; set; }
        public string PBNo { get; set; }

    }
}
