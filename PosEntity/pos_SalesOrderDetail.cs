using System;

namespace PosEntity
{
    public class pos_SalesOrderDetail
    {
        public Int64 SalesOrderDetailId { get; set; }
        public Int64 SalesOrderId { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public Int32 OrderUnitId { get; set; }
        public Decimal OrderQty { get; set; }
        public Decimal OrderPrice { get; set; }
        public DateTime DueDate { get; set; }
        public Decimal DeliveredQty { get; set; }
        public string CategoryName { get; set; }
        public string ItemDescription { get; set; }
        public string BuyerName { get; set; }
        public string ItemName { get; set; }
        public string SubCategoryName { get; set; }
        //public int UnitId { get; set; }
        //public int PackageId { get; set; }
        //public Decimal UnitPerPackage { get; set; }
        //public int ContainerId { get; set; }
        //public Decimal PackagePerContainer { get; set; }
        //public decimal PackageWeight { get; set; }
        //public decimal ContainerWeight { get; set; }
        //public string ContainerSize { get; set; }
        public decimal Amount { get; set; }
    }
}
