using System;
using System.Text;

namespace ReceivableEntity
{
	public class rcv_CompanyOpeningBalance
	{
		public Int64 OpeningBalanceId { get; set; }
		public Int32 FinancialCycleId { get; set; }
		public Int32 CompanyId { get; set; }
		public DateTime OpeningDate { get; set; }
		public Decimal Amount { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
