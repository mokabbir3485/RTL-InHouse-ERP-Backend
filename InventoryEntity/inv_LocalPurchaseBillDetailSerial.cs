using System;

namespace InventoryEntity
{
    public class inv_LocalPurchaseBillDetailSerial
    {

        public Int64 LPBDetailSerialId { get; set; }
        public Int64 LPBDetailId { get; set; }
        public string SerialNo { get; set; }
        public Int32 WarrentyInDays { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int64 ItemId { get; set; }
        public Int64 DeliveryDetailId { get; set; }

    }
}
