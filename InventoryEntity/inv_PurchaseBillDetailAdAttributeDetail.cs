using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_PurchaseBillDetailAdAttributeDetail
	{
		public Int64  PBDetailAdAttDetailId { get; set; }
		public Int64  PBDetailAdAttId { get; set; }
		public Int32  ItemAddAttId { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeName { get; set; }

	}
}
