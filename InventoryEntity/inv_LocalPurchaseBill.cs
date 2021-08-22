using System;

namespace InventoryEntity
{
    public class inv_LocalPurchaseBill
    {



       
        public Int64 LPBId { get; set; }
        public Int64 POId { get; set; }
        public string PONo { get; set; }
        public string PBNo { get; set; }
        public DateTime PBDate { get; set; }
        public Int32 SupplierId { get; set; }
        public Int32 PreparedById { get; set; }
        public string ShipmentInfo { get; set; }
        public Int32 PriceTypeId { get; set; }
        public string Remarks { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string PreparedBy { get; set; }
        public string SupplierName { get; set; }
        public string PriceTypeName { get; set; }
        public bool IsApproved { get; set; }
        public Int32 ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string VoucherNo { get; set; }

        public decimal AdditionDiscount { get; set; }
        public string Address { get; set; }
        public bool isRawMaterials { get; set; }
        public bool isVDS { get; set; }
        public string ChallanNo { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountAfterDiscount { get; set; }

    }
}
