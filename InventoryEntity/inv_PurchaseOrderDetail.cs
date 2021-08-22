using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_PurchaseOrderDetail
	{
		public Int64  PODetailId { get; set; }
		public Int64  POId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  POUnitId { get; set; }
		public Decimal  POQuantity { get; set; }
		public Decimal  POUnitPrice { get; set; }
		public string  ItemName { get; set; }
		public string  UnitName { get; set; }
        public string ItemCode { get; set; }
        public Decimal StockQty { get; set; }
        public Decimal Amount { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Int32 ContainerId { get; set; }
        public Decimal BilledQty { get; set; }
    }
}
