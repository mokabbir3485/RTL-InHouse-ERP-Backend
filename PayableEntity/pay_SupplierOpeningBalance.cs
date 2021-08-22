using System;
using System.Text;

namespace PayableEntity
{
	public class pay_SupplierOpeningBalance
	{
		public Int64 OpeningBalanceId { get; set; }
		public Int32 FinancialCycleId { get; set; }
		public Int32 SupplierId { get; set; }
		public DateTime OpeningDate { get; set; }
		public Decimal Amount { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
