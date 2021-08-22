using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockReceiveExtraInfo
	{
		public Int64  SRExtraInfoId { get; set; }
		public Int64  SRDetailId { get; set; }
		public Decimal  ExtraInfoQuantity { get; set; }
		public DateTime  ExpiryDate { get; set; }
		public Int32  WarrantyInMon { get; set; }

	}
}
