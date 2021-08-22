using System;
using System.Text;

namespace PosEntity
{
    public class pos_SaleDetailAdAttribute
	{
        public Int64 SaleDetailAdAttId { get; set; }
        public Int64 SaleDetailId { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public Decimal AttributeQty { get; set; }
        public Decimal AttributeQtyFree { get; set; }
        public string Barcode { get; set; }
        public string Combination { get; set; }
        public Int32 ItemId { get; set; }
        public Decimal CurrentQuantity { get; set; }
    }
}
