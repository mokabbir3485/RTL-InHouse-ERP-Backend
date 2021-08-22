using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StoreWiseItemReorderLevelLog
	{
		public Int64  ReorderLevelLogId { get; set; }
		public Int32  DepartmentId { get; set; }
		public Int32  ItemId { get; set; }
        public Int32 ReorderUnitId { get; set; }
		public Int32  MinReorderLevel { get; set; }
		public Int32  MaxReorderLevel { get; set; }
		public DateTime  LogDate { get; set; }
		public string  ItemName { get; set; }
		public string  UnitName { get; set; }

	}
}
