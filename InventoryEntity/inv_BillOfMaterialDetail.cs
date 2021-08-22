using System;


namespace InventoryEntity
{
    public class inv_BillOfMaterialDetail
    {
        public Int64 BOMDetailId { get; set; }
        public Int64? BOMId { get; set; }
        public Int64? ItemId { get; set; }
        public string ItemName { get; set; }
        public Decimal? Qty { get; set; }
        public string Unit { get; set; }
        public Decimal? WastagePercentage { get; set; }
        public Decimal? WastageAmount { get; set; }
        public Decimal? TotalProduction { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? TotalValue { get; set; }

    }
}
