using System;
using System.Text;

namespace PosEntity
{
	public class pos_SaleDetail
	{
		public Int64  SaleDetailId { get; set; }
        public string InvoiceNo { get; set; }
		public Int32  ItemId { get; set; }
		public Int32?  SaleUnitId { get; set; }
		public Decimal  Quantity { get; set; }
		public Decimal  UnitPrice { get; set; }
		public Decimal  UnitDiscount { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string UnitName { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public Decimal CurrentQuantity { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public Decimal AttributeQtyFree { get; set; }
    }
}
