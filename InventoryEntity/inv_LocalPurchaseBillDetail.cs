using System;

namespace InventoryEntity
{
    public class inv_LocalPurchaseBillDetail
    {
        public Int64 LPBDetailId { get; set; }
        public Int64 LPBId { get; set; }
        public Int64 ItemId { get; set; }
        public Int32 PBUnitId { get; set; }
        public Decimal PBQty { get; set; }
        public Decimal PBPrice { get; set; }
        public string ItemName { get; set; }
        public string UnitName { get; set; }
        public string ItemCode { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Int32 ContainerId { get; set; }
        public Decimal ReceivedQty { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BilledQty { get; set; }
        public Decimal DiscountAmount { get; set; }

        public Decimal POQuantity { get; set; }
        public Decimal Charge { get; set; }
        public Int32 WarrentyInDays { get; set; }
        public string HsCode { get; set; }

        public string SdPercentage { get; set; }
        public decimal SdAmount { get; set; }
        public string VatPercentage { get; set; }
        public decimal VatAmount { get; set; }



        public decimal TotalCost { get; set; }

        public string PBQtyString { get; set; }
        public string Combination { get; set; }
        public string PBNo { get; set; }
        public decimal BillTotal { get; set; }
        public decimal BillQty { get; set; }
        public string GroupName { get; set; }
        public DateTime PBDate { get; set; }
        public string RefNo { get; set; }
        public decimal TotalCostAfterDiscount { get; set; }
    }
}
