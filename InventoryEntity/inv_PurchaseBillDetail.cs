using System;

namespace InventoryEntity
{
    public class inv_PurchaseBillDetail
    {
        public Int64 PBDetailId { get; set; }
        public Int64 PBId { get; set; }
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
        public Decimal POQuantity { get; set; }
        public Decimal Charge { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Int32 WarrentyInDays { get; set; }


        public string HsCode { get; set; }
        public string CdPercentage { get; set; }
        public decimal CdAmount { get; set; }
        public string RdPercentage { get; set; }
        public decimal RdAmount { get; set; }
        public string SdPercentage { get; set; }
        public decimal SdAmount { get; set; }
        public string VatPercentage { get; set; }
        public decimal VatAmount { get; set; }

        public string AitPercentage { get; set; }
        public decimal AitAmount { get; set; }
        public string AtPercentage { get; set; }
        public decimal AtAmount { get; set; }
        public string TtiPercentage { get; set; }
        public decimal TtiAmount { get; set; }

        public decimal CurrentStock { get; set; }
        public string CurrencyType { get; set; }
        public decimal ConversionRate { get; set; }
        public decimal TotalConversion { get; set; }
        public decimal TotalCost { get; set; }

        public decimal TotalCostAfterDiscount { get; set; }

    }
}
