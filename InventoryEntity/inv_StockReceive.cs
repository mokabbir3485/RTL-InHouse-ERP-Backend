using DbExecutor;
using System;

namespace InventoryEntity
{
    public class inv_StockReceive : IEntityBase
    {
        public Int64 SRId { get; set; }
        public Int64 PBId { get; set; }
        public string PONo { get; set; }
        public string PBNo { get; set; }
        public string ReceiveNo { get; set; }
        public string ChallanNo { get; set; }
        public string LotNo { get; set; }
        public DateTime ReceiveDate { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 SupplierId { get; set; }
        public Int32 ReceivedById { get; set; }
        public string Remarks { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string DepartmentName { get; set; }
        public string SupplierName { get; set; }
        public string ReceivedBy { get; set; }
        public bool IsApproved { get; set; }
        public Int32 ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public Decimal TotalReceiveQty { get; set; }
        public bool IsLocalPurchase { get; set; }

    }
}
