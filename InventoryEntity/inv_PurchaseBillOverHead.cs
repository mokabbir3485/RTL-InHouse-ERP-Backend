using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_PurchaseBillOverHead
	{
		public Int64  PBOverHeadId { get; set; }
		public Int64  PBId { get; set; }
		public Int32  OverHeadId { get; set; }
		public Decimal  Amount { get; set; }
		public string  OverHeadName { get; set; }

	}
}
