using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_FinalPriceConfigDetail
	{
		public Int64  ConfigDetailId { get; set; }
		public Int32  ConfigId { get; set; }
		public Int32  ChargeTypeId { get; set; }
		public Decimal  ChargePercentage { get; set; }
		public Int32  OrderId { get; set; }
        public string ChargeTypeName { get; set; }
	}
}
