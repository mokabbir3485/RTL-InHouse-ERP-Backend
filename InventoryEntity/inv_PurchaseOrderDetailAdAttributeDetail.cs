using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_PurchaseOrderDetailAdAttributeDetail
	{
		public Int64  PODetailAdAttDetailId { get; set; }
		public Int64  PODetailAdAttId { get; set; }
		public Int32  ItemAddAttId { get; set; }
		public string  AttributeValue { get; set; }
        public Int32 AttributeId { get; set; }
        public string AttributeName { get; set; }
        public bool IsStockMaintain { get; set; }
    }
}
