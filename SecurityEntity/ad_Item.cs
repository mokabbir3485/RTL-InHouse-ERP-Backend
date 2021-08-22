using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{

    public class ad_Item : IEntityBase
	{
		public Int32  ItemId { get; set; }
        public Int32 SubCategoryId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemDescriptionTwo { get; set; }
        public bool IsItemCodeBarcode { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Decimal UnitPerPackage { get; set; }
        public Int32 ContainerId { get; set; }
        public Decimal PackagePerContainer { get; set; }
        public string PurchaseMeasurement { get; set; }
        public string SaleMeasurement { get; set; }
        public Int32 PurchasePriceConfigId { get; set; }
        public Int32 SalePriceConfigId { get; set; }
        public Int32 MovementMethodId { get; set; }
        public string AccountCode { get; set; }
        public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public bool HasAddAtt { get; set; }
        public bool HasAddAttOperational { get; set; }
        public Int32 CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string Status { get; set; }
        public Int32 PurchaseUnitId { get; set; }
        public Int32 SaleUnitId { get; set; }
        public Decimal DefaultPurPrice { get; set; }
        public Decimal DefaultSalePrice { get; set; }
        public string UnitName { get; set; }
        public int ROLevel { get; set; }
        public decimal PackageWeight { get; set; }
        public decimal ContainerWeight { get; set; }
        public string ContainerSize { get; set; }
        public Int32 HsCodeId { get; set; }
        public string HsCode { get; set; }
	}
}
