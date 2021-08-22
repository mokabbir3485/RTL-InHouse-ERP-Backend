using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_RequisitionDetailAdAttribute
	{
		public Int64  RequisitionDetailAdAttId { get; set; }
        public Int64 RequisitionDetailId { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public string RequisitionPurposeName { get; set; }
        public Int32 RequisitionPurposeId { get; set; }
        public Decimal AttributeQty { get; set; }
	}
}
