using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockDeclarationDetail
	{
		public Int64  DeclarationDetailId { get; set; }
		public Int64  DeclarationId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  DeclarationUnitId { get; set; }
		public Decimal  DeclarationQuantity { get; set; }
		public Decimal  DeclarationUnitPrice { get; set; }
		public Int32  DeclarationTypeId { get; set; }
		public string  ItemName { get; set; }
		public string  DeclarationUnitName { get; set; }
		public string  DeclarationTypeName { get; set; }
        public string ItemCode { get; set; }
        public Int32 UnitId { get; set; }
        public Int32 PackageId { get; set; }
        public Int32 ContainerId { get; set; }
        public Decimal StockQty { get; set; }
        public Decimal PrvDeclarationQuantity { get; set; }
        public Decimal UnitPerPackage { get; set; }
    }
}
