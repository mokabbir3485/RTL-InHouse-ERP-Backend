using DbExecutor;
using System;
using System.Text;

namespace InventoryEntity
{
    public class inv_PurchaseOrder : IEntityBase
	{
		public Int64  POId { get; set; }
		public string  PONo { get; set; }
		public DateTime  PODate { get; set; }
		public Int32  SupplierId { get; set; }
		public Int32  PreparedById { get; set; }
		public string  ShipmentInfo { get; set; }
		public DateTime  DeliveryDate { get; set; }
		public Int32  PriceTypeId { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string PreparedBy { get; set; }
        public string SupplierName { get; set; }
		public string  PriceTypeName { get; set; }
        public bool IsApproved { get; set; }
        public Int32 ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
	}
}
