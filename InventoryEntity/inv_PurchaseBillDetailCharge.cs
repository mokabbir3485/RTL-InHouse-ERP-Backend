using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_PurchaseBillDetailCharge
	{
		public Int64  ChargeId { get; set; }
		public Int64  PBDetailId { get; set; }
		public Int32  ChargeTypeId { get; set; }
        public Decimal ChargeAmount { get; set; }
        public String ChargeTypeName { get; set; }
        public Decimal ChargePercentage { get; set; }
	}
}
