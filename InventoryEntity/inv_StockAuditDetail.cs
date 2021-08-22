using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockAuditDetail
	{
		public Int64  AuditDetailId { get; set; }
		public Int64  AuditId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  AuditUnitId { get; set; }
		public Decimal  AuditQuantity { get; set; }
		public Decimal  SettleQuantity { get; set; }
		public Decimal  AuditUnitPrice { get; set; }
		public Int32  AuditTypeId { get; set; }
		public string  ItemName { get; set; }
		public string  AuditUnitName { get; set; }
		public string  AuditTypeName { get; set; }
	}
}
