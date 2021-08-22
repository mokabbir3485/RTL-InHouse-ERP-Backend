using DbExecutor;
using System;
using System.Text;

namespace InventoryEntity
{
    public class inv_OpeningQuantity : IEntityBase
	{
        public string DepartmentName { get; set; }
        public string CategoryName { get; set; }
        public string SubcategoryName { get; set; }
        public string ItemName { get; set; }
        public string OpeningUnitName { get; set; }
        public Decimal OpeningUnitQuantity { get; set; }
        public string OpeningPackageName { get; set; }
        public Decimal OpeningPackageQuantity { get; set; }
        public string OpeningContainerName { get; set; }
        public Decimal OpeningContainerQuantity { get; set; }
        public Decimal OpeningValue { get; set; }
        public Int64 OpeningQtyId { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 OpeningUnitId { get; set; }
        public Int32 OpeningPackageId { get; set; }
		public Int32  OpeningContainerId { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }

	}
}
