using System;

namespace InventoryEntity
{
    public class inv_BillOfMaterialOverhead
    {
        public Int64 BOMOverheadId { get; set; }
        public Int64? BOMId { get; set; }
        public string SectorName { get; set; }
        public Decimal? Amount { get; set; }
        public string SectorType { get; set; }
    }
}
