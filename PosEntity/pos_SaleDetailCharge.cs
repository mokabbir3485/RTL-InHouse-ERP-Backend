using System;
using System.Text;

namespace PosEntity
{
    public class pos_SaleDetailCharge
	{
		public Int64  ChargeId { get; set; }
		public Int64  SaleDetailId { get; set; }
		public Int32  ChargeTypeId { get; set; }
        public Decimal ChargeAmount { get; set; }
        public String ChargeTypeName { get; set; }
        public Decimal ChargePercentage { get; set; }
	}
}
