using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockDeliveryNonSO
	{
		public Int64 DeliveryId { get; set; }
		public string DeliveryNo { get; set; }
		public DateTime DeliveryDate { get; set; }
		public Int32 DeliveryFromDepartmentId { get; set; }
		public Int32? DeliveryToDepartmentId { get; set; }
		public string DeliverydBy { get; set; }
		public string ReceivedBy { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
		public string DeliveryFromDepartmentName { get; set; }
		public string DeliveryToDepartmentName { get; set; }
		public bool IsApproved { get; set; }
		public Int32? ApprovedBy { get; set; }
		public DateTime? ApprovedDate { get; set; }
	}
}
