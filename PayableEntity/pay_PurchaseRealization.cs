using System;
using System.Text;

namespace PayableEntity
{
	public class pay_PurchaseRealization
	{
		public Int64 RealizationId { get; set; }
		public Int32 FinancialCycleId { get; set; }
        public Int32 SupplierId { get; set; }
        public Int64 PBId { get; set; }
		public Int32 PaymentTypeId { get; set; }
		public DateTime PaymentDate { get; set; }
		public Decimal Amount { get; set; }
		public Decimal FromAdvance { get; set; }
		public Decimal TDS { get; set; }
		public Decimal VDS { get; set; }
		public string VoucherNo { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
