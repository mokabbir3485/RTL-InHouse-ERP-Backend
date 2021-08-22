using System;

namespace InventoryEntity
{
    public class inv_BillOfMaterial
    {
        public Int64 BillOfMaterialId { get; set; }
        public string BillOfMaterialNo { get; set; }
        public Int64? ItemId { get; set; }
        public string ItemName { get; set; }
        public Decimal? Qty { get; set; }
        public string Unit { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string HsCode { get; set; }
    }
}
