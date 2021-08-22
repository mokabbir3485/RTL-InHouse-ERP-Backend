using System;

namespace ExportEntity
{
    public class exp_CommercialInvoiceDetail
    {
        public Int64 CommercialInvoiceDetailId { get; set; }
        public Int64 CommercialInvoiceId { get; set; }
        public Int64 InvoiceId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 OrderUnitId { get; set; }
        public string DescriptionOne { get; set; }
        public bool IsDescriptionOverride { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public Int32 Hscode { get; set; }
        public string ItemDescription { get; set; }
        public decimal PackageWeight { get; set; }
        public decimal PackagePerContainer { get; set; }
        public decimal ContainerWeight { get; set; }
        public string ContainerSize { get; set; }
        public Int32 UnitId { get; set; }
        public decimal UnitPerPackage { get; set; }
        public Int64 SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public Int32 IdenticalFlag { get; set; }



    }
}
