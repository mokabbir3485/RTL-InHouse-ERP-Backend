using System;
using System.Text;

namespace ReceivableEntity
{
	public class rcv_SaleRealization
	{
		public Int64 RealizationId { get; set; }
		public Int32 FinancialCycleId { get; set; }
        public Int32 CompanyId { get; set; }
        public Int64 SalesOrderId { get; set; }
		public Int32 PaymentTypeId { get; set; }
		public DateTime PaymentDate { get; set; }
		public Decimal Amount { get; set; }
		public Decimal FromAdvance { get; set; }
		public Decimal TDS { get; set; }
		public Decimal VDS { get; set; }
		public string VoucherNo { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<DateTime> ChequeDate { get; set; }
        public string ChequeBank { get; set; }
    }
}
