using System;

namespace InventoryEntity
{
    public class inv_StockDeliveryDetail
    {
        public Int64 DeliveryDetailId { get; set; }
        public Int64 SalesOrderDetailId { get; set; }
        public Int64 DeliveryId { get; set; }
        public Int64 ItemId { get; set; }
        public Int32 DeliveryUnitId { get; set; }
        public Decimal DeliveryQuantity { get; set; }
        public Decimal DeliveryUnitPrice { get; set; }
        public string ItemName { get; set; }
        public string DeliveryUnitName { get; set; }
        public string ItemCode { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Int32 ContainerId { get; set; }
        public bool IsLastDelivery { get; set; }
    }
}
