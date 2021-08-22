using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemWiseSupplier
	{
		public Int64  ItemWiseSupplierId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
	}
}
