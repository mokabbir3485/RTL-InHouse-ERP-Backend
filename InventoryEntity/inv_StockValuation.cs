using System;

namespace InventoryEntity
{
    public class inv_StockValuation
    {
        public Int64 ValuationId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Decimal CurrentQuantity { get; set; }

        public Decimal ValuationPrice { get; set; }
        public DateTime UpdateDate { get; set; }
        public decimal HoldQuantity { get; set; }


    }
}
