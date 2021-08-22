using System;

namespace InventoryEntity
{
    public class proc_SupplierPayment
    {
        public Int64 SupplierPaymentId { get; set; }
        public Int64 PBId { get; set; }
        public Int64 LPBId { get; set; }
        public Int64 SPADetailId { get; set; }

        public Int32 SupplierId { get; set; }
        public Int32 PaymentTypeId { get; set; }


        public DateTime PaymentDate { get; set; }
        public string Remarks { get; set; }
        public bool IsCheque { get; set; }
        public string ChequeType { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeDate { get; set; }
        public Int32 BankAccountId { get; set; }
        public Int32 JVNo { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal TotalVAT { get; set; }
        public decimal TotalAIT { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal AitAmount { get; set; }
        public DateTime PBDate { get; set; }
        public string PBNo { get; set; }
        public decimal TotalCost { get; set; }

        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }







    }
}
