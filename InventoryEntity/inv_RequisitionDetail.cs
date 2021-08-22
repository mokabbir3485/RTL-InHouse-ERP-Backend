using System;

namespace InventoryEntity
{
    public class inv_RequisitionDetail
    {
        public Int64 RequisitionDetailId { get; set; }
        public Int64 RequisitionId { get; set; }
        public Int64 ItemId { get; set; }
        public Int32 RequisitionUnitId { get; set; }
        public Decimal RequisitionQuantity { get; set; }
        public Int32 RequisitionPurposeId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string RequisitionUnitName { get; set; }
        public string RequisitionPurposeName { get; set; }
        public Decimal IssuedQuantity { get; set; }
        
    }
}
