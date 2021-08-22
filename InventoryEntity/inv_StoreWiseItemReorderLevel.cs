using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StoreWiseItemReorderLevel
	{
        public string DepartmentName { get; set; }
        public string CategoryName { get; set; }
        public string SubcategoryName { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string UnitName { get; set; }
        public Int32 MinReorderLevel { get; set; }
        public Int32 MaxReorderLevel { get; set; }
        public Int64 ReorderLevelId { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 ItemId { get; set; }
		public Int32  ReorderUnitId { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Int32 ContainerId { get; set; }
        public decimal StockQty { get; set; }
        public decimal Difference { get; set; }
	}
}
