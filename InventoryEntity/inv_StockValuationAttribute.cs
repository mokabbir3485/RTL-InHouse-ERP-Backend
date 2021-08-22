using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockValuationAttribute
	{
		public Int64  ValuationId { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int64 ItemAddAttId { get; set; }
		public Decimal  CurrentQuantity { get; set; }
        public Decimal ValuationPrice { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
