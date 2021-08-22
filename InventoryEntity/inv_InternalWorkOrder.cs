using System;

namespace InventoryEntity
{
    public class inv_InternalWorkOrder
    {
        public Int64 InternalWorkOrderId { get; set; }
        public Int64 SalesOrderId { get; set; }
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
        public string CompanyNameOnBill { get; set; }
        public string DepartmentName { get; set; }
        public string EmployeeName { get; set; }


        //public string RollDirection { get; set; }
        //public Int64 SalesOrderDetailId { get; set; }
        //public DateTime? DeliveryDate { get; set; }
        //public string DetailRemarks { get; set; }
        //public Int64 ItemId { get; set; }
        //public string Radius { get; set; }
        //public string Ups { get; set; }
        //public string Color { get; set; }
        //public string ArtWorkUps { get; set; }
        //public Int32 QtyPerRoll { get; set; }
        //public bool IsFullDelivery { get; set; }
        //public Int64 InternalWorkOrderDetailId { get; set; }
        public Int64 CompanyId { get; set; }
        public Int64 SalesOrderDetailId { get; set; }
        public string Size { get; set; }
        public string ERPCode { get; set; }
        public string Material { get; set; }
        public Decimal Core { get; set; }
        public string RollDirection { get; set; }
        public Int32 QtyPerRoll { get; set; }
        public Decimal PricePerPCS { get; set; }
        public string FormNo { get; set; }
        public string DateOfOrigin { get; set; }
        public string RevisionNo { get; set; }
        public string RevisionDate { get; set; }
        public string PaymentTerms { get; set; }
        public string OfficeAddess { get; set; }
        public string DeliveryAddress { get; set; }
        public string ContactPerson { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string SalesPerson1 { get; set; }
        public string SalesPerson2 { get; set; }



    }
}
