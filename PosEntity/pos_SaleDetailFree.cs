using System;
using System.Text;

namespace PosEntity
{
	public class pos_SaleDetailFree
	{
		public Int64  SaleDetailFreeId { get; set; }
        public Int64 SaleDetailId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32?  FreeUnitId { get; set; }
		public Decimal  FreeQuantity { get; set; }
		public Decimal  UnitPrice { get; set; }
        public Int64 ItemAddAttId { get; set; }
    }
}
