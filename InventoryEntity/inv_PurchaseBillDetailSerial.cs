using System;

namespace InventoryEntity
{
    public class inv_PurchaseBillDetailSerial
    {
        public Int64 PBDetailSerialId { get; set; }
        public Int64 PBDetailId { get; set; }
        public string SerialNo { get; set; }
        public string ItemName { get; set; }
        public Int32 WarrentyInDays { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int64 ItemId { get; set; }
        public Int64 DeliveryDetailId { get; set; }
        public bool IsLocal { get; set; }
    }
}
