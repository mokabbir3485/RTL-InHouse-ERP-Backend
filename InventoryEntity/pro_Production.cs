using System;
using System.Text;

namespace InventoryEntity
{
	public class pro_Production
	{
		public Int64 ProductionId { get; set; }
		public Int64 InternalWorkOrderId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string ProductionNo { get; set; }
		public DateTime ProductionDate { get; set; }

		public string Remarks { get; set; }
		public Int32 PreparedById { get; set; }
		public Int32 CreatorId { get; set; }
		public DateTime CreateDate { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
