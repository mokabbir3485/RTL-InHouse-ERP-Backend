using System;
using System.Text;

namespace PosEntity
{
	public class pos_Sale
	{
		public Int64  SaleId { get; set; }
		public Int64  ShiftId { get; set; }
		public Int32  TerminalId { get; set; }
		public string  CustomerCode { get; set; }
        public string CustomerName { get; set; }
		public Int32  PriceTypeId { get; set; }
		public DateTime  SaleDate { get; set; }
		public string  InvoiceNo { get; set; }
		public string  MemoNo { get; set; }
        public string Mobile { get; set; }
		public Decimal  PaidAmount { get; set; }
		public Decimal  ChangeAmount { get; set; }
		public string  SalesmanName { get; set; }
		public bool  IsVoid { get; set; }
		public Int32?  VoidBy { get; set; }
		public DateTime?  VoidDate { get; set; }
		public string  VoidReason { get; set; }
		public bool  IsPaymentSettled { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
