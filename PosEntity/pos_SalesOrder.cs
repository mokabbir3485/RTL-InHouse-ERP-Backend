using DbExecutor;
using System;

namespace PosEntity
{
    public class pos_SalesOrder //: IEntityBase
    {
        public Int64 SalesOrderId { get; set; }
        public Int32 CompanyId { get; set; }
        public Int32 PriceTypeId { get; set; }
        public string SalesOrderNo { get; set; }
        public string ReferenceNo { get; set; }
        public DateTime SalesOrderDate { get; set; }
        public Int32 PreparedById { get; set; }
        public string Remarks { get; set; }
        public Int32 CreatorId { get; set; }
        //public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        //public DateTime UpdateDate { get; set; }
        public string CompanyName { get; set; }
        public string RefEmployeeName { get; set; }
        public Decimal Amount { get; set; }
        public bool IsAcknowledged { get; set; }
        public bool IsAmendment { get; set; }
        public Int32? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public string VoucherNo { get; set; }
        public Decimal TotalAdjustment { get; set; }
        public Decimal TotalDue { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string CompanyNameOnBill { get; set; }
        public string BillingAddress { get; set; }
        public DateTime? PODate { get; set; }
        public string CurrencyType { get; set; }
        public string SalesOrderType { get; set; }
        public string DocStatus { get; set; }
        public bool IsChecked { get; set; }
        public int IsNonSO { get; set; }
    }
}
