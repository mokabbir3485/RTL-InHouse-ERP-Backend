using System;

namespace ExportEntity
{
    public class exp_Item
    {
        public Int32 ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string BuyerName { get; set; }
        public string ReferenceNo { get; set; }
        public Decimal OrderQty { get; set; }
        public Decimal OrderPrice { get; set; }
        public string ItemDescription { get; set; }
        public string ContainerSize { get; set; }
        public bool IsActive { get; set; }
        public decimal PackageWeight { get; set; }
        public Decimal PackagePerContainer { get; set; }
        public decimal ContainerWeight { get; set; }
        public Decimal UnitPerPackage { get; set; }
        public int OrderUnitId { get; set; }
        public int SubCategoryId { get; set; }
        public decimal Amount { get; set; }
        public string HsCode { get; set; }

    }
}
