using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryEntity
{
    public class inv_InternalWorkOrderReport
    {
        public Int64 InternalWorkOrderId { get; set; }
        public Int64 SalesOrderId { get; set; }
        public Int64 SalesOrderDetailId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string InternalWorkOrderNo { get; set; }
        public DateTime InternalWorkOrderDate { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string Remarks { get; set; }
        public Int32 PreparedById { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsApproved { get; set; }
        public Int32? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string FinishedItemName { get; set; }
        public string RawMaterials { get; set; }
        public string SalesOrderNo { get; set; }
        public DateTime? SalesOrderDate { get; set; }
        public string Barcode { get; set; }
        public Int64 InternalWorkOrderDetailId { get; set; }
  
     
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
        public string Ups { get; set; }
        public string Radius { get; set; }
        public string ArtWork { get; set; }
        public string FullName { get; set; }




    }
}
