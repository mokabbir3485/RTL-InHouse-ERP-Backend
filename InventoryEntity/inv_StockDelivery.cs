using DbExecutor;
using System;
using System.Text;

namespace InventoryEntity
{
    public class inv_StockDelivery : IEntityBase
    {
        public Int64 DeliveryId { get; set; }
        public Int64 OrderId { get; set; }
        public string OrderNo { get; set; }
        public string DeliveryNo { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime BillDate { get; set; }
        public Int32 DeliveryFromDepartmentId { get; set; }
        public Int32 DeliveryToDepartmentId { get; set; }
        public Int32 DeliverydById { get; set; }
        public Int32 ReceivedById { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string DeliveryFromDepartmentName { get; set; }
        public string DeliveryToDepartmentName { get; set; }
        public string DeliverydBy { get; set; }
        public string ReceivedBy { get; set; }
        public bool IsApproved { get; set; }
        public Int32? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string CompanyName { get; set; }
        public string ReferenceNo { get; set; }
        public Decimal TotalDeliveryQty { get; set; }



    }
}
