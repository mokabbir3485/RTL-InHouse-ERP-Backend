using System;

namespace ExportEntity
{
    public class exp_InvoiceDetail
    {
        public Int64 InvoiceDetailId { get; set; }
        public Int64 InvoiceId { get; set; }
        public Int64 SalesOrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int OrderUnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string DescriptionOne { get; set; }
        public string DescriptionTwo { get; set; }
        public decimal Amount { get; set; }

        public int UnitId { get; set; }
        public int PackageId { get; set; }
        public decimal UnitPerPackage { get; set; }
        public int ContainerId { get; set; }
        public decimal PackagePerContainer { get; set; }
        public decimal PackageWeight { get; set; }
        public decimal ContainerWeight { get; set; }
        public string ContainerSize { get; set; }
        public string SubCategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public string HsCode { get; set; }
        public int IdenticalFlag { get; set; }
    }
}
