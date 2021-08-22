using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_StockAuditType
	{
		public Int32  AuditTypeId { get; set; }
		public Int32  AuditGroupId { get; set; }
		public string  AuditTypeName { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string AuditGroupName { get; set; }
        public string Status { get; set; }
	}
}
