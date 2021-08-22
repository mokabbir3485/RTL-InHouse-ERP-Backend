using DbExecutor;
using System;
using System.Text;

namespace InventoryEntity
{
    public class inv_PurchaseRequisition : IEntityBase
    {
        public Int64 PurchaseRequisitionId { get; set; }
        public string PurchaseRequisitionNo { get; set; }
        public DateTime PurchaseRequisitionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Int32 FromDepartmentId { get; set; }
        public Int32 ToDepartmentId { get; set; }
        public Int32 PreparedById { get; set; }
        public string Remarks { get; set; }
        public string FromDepartmentName { get; set; }
        public string ToDepartmentName { get; set; }
        public string PreparedBy { get; set; }
        public bool IsSentBack { get; set; }
        public bool IsActive { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
