using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockDeliveryNonSODetail
	{
		public Int64 DeliveryDetailId { get; set; }
		public Int64 DeliveryId { get; set; }
		public string ItemDescription { get; set; }
		public string ItemRemarks { get; set; }
		public Decimal DeliveryQuantity { get; set; }
		public Decimal? DeliveryUnitPrice { get; set; }
	}
}
