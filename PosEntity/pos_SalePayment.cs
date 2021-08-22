using System;
using System.Text;

namespace PosEntity
{
	public class pos_SalePayment
	{
		public Int64  SalePaymentId { get; set; }
		public string  InvoiceNo { get; set; }
		public Int32  CurrencyId { get; set; }
		public Int32  PaymentTypeId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal CommissionPercent { get; set; }
		public string  RefNumber { get; set; }
		public string  CardName { get; set; }
		public string  CardNumber { get; set; }
        public string PaymentTypeName { get; set; }
    }
}
