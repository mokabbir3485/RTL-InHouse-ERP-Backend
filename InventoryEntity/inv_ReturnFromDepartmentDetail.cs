using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_ReturnFromDepartmentDetail
	{
		public Int64  ReturnDetailId { get; set; }
		public Int64  ReturnId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  ReturnUnitId { get; set; }
		public Decimal  ReturnQuantity { get; set; }
		public Decimal  ReturnUnitPrice { get; set; }
		public Int32  ReturnReasonId { get; set; }
		public string  ItemName { get; set; }
		public string  ReturnUnitName { get; set; }
		public string  ReturnReasonName { get; set; }
	}
}
