using System;
using System.Text;

namespace PayableEntity
{
	public class pay_SupplierAdvance
	{
		public Int64 AdvanceId { get; set; }
		public Int32 FinancialCycleId { get; set; }
		public Int32 SupplierId { get; set; }
		public Int32 PaymentTypeId { get; set; }
		public DateTime AdvanceDate { get; set; }
		public Decimal Amount { get; set; }
		public string VoucherNo { get; set; }
		public bool IsOpening { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public string SupplierName { get; set; }
    }
}
