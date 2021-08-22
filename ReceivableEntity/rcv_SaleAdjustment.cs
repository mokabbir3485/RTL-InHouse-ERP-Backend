using System;
using System.Text;

namespace ReceivableEntity
{
	public class rcv_SaleAdjustment
	{
		public Int64 AdjustmentId { get; set; }
		public Int32 FinancialCycleId { get; set; }
		public Int64 SalesOrderId { get; set; }
		public Int32 AdjustmentTypeId { get; set; }
		public DateTime AdjustmentDate { get; set; }
		public Decimal Amount { get; set; }
		public string VoucherNo { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
