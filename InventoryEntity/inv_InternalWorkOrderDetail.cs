using System;

namespace InventoryEntity
{
    public class inv_InternalWorkOrderDetail
    {
      
        public Int64 InternalWorkOrderDetailId { get; set; }
        public Int64 InternalWorkOrderId { get; set; }
        public Int64 SalesOrderId { get; set; }
        public Int64 SalesOrderDetailId { get; set; }
    
        public Int64 FinishedItemId { get; set; }
        public Int64 ItemId { get; set; }
        public Decimal Core { get; set; }
        public Int32 QtyPerRoll { get; set; }
        public string RollDirection { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsFullDelivery { get; set; }
        public Decimal OrderQty { get; set; }
        public string DetailRemarks { get; set; }
        public Decimal UnitCost { get; set; }
        public string Color { get; set; }
        public string Ups{ get; set; }
        public string Radius { get; set; }
        public string ArtWork { get; set; }
        public string SubCategoryName { get; set; }
        public string ItemName { get; set; }
        public string CategoryName { get; set; }
        public string Barcode { get; set; }



    }
}
