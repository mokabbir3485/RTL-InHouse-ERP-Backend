using System;

namespace InventoryEntity
{
    public class pro_ProductionDetail
    {
        public Int64 ProductionDetailId { get; set; }
        public Int64 ProductionId { get; set; }
        public Int64 ItemId { get; set; }
        public Decimal UsedRoll { get; set; }
        public Decimal ProductionQuantity { get; set; }
        public Decimal UnitCost { get; set; }
    }
}
