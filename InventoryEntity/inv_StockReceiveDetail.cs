using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockReceiveDetail
	{
		public Int64 SRDetailId { get; set; }
		public Int64 SRId { get; set; }
		public Int32 ItemId { get; set; }
		public Int32 SRUnitId { get; set; }
		public Decimal SRQuantity { get; set; }
		public Int32 FreeUnitId { get; set; }
		public Decimal FreeQty { get; set; }
		public Decimal SRUnitPrice { get; set; }
		public string ItemName { get; set; }
		public string SRUnitName { get; set; }
		public string FreeUnitName { get; set; }
	}
}
