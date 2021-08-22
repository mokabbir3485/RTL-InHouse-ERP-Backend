using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockAudit
	{
		public Int64  AuditId { get; set; }
		public string  AuditNo { get; set; }
		public DateTime  AuditDate { get; set; }
		public Int32  DepartmentId { get; set; }
		public Int32  AuditedById { get; set; }
		public bool  IsSettled { get; set; }
		public Int32  SettledWithId { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
		public string  DepartmentName { get; set; }
		public string  AuditedBy { get; set; }
		public string  SettledWith { get; set; }
	}
}
