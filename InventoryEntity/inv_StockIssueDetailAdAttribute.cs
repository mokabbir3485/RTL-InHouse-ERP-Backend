using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockIssueDetailAdAttribute
	{
		public Int64  IssueDetailAdAttId { get; set; }
		public Int64  IssueDetailId { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public Decimal AttributeQty { get; set; }
        public string Barcode { get; set; }
        public string Combination { get; set; }
        public Int32 ItemId { get; set; }
        public Decimal CurrentQuantity { get; set; }
        public Decimal ValuationPrice { get; set; }
	}
}
