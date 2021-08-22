using System;
using System.Text;

namespace AccountsEntity
{
	public class ac_Transaction
	{
		public Int64 TransactionId { get; set; }
		public Int32 AccountId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string TransactionType { get; set; }
		public string VoucherType { get; set; }
		public string Narration { get; set; }
		public Decimal DrAmt { get; set; }
		public Decimal CrAmt { get; set; }
		public Decimal? BalanceAmt { get; set; }
		public Int64? VoucherNo { get; set; }
		public string VoucherNum { get; set; }
		public Int32? AgainstAccountId { get; set; }
		public string AgainstNarration { get; set; }
		public Int32? CompanyId { get; set; }
		public Int32? SupplierId { get; set; }
		public Int32? BankId { get; set; }
		public Int32? BranchId { get; set; }
		public string ChequeNo { get; set; }
		public string ChequeBank { get; set; }
		public DateTime? ChequeDate { get; set; }
		public bool IsChqCleared { get; set; }
		public bool IsAuto { get; set; }
		public bool IsOpening { get; set; }
		public bool IsApproved { get; set; }
		public bool IsVoid { get; set; }
		public Int32? ApprovedBy { get; set; }
		public DateTime? ApprovedDate { get; set; }
		public Int32? VoidBy { get; set; }
		public DateTime? VoidDate { get; set; }
		public string VoidReson { get; set; }
		public string PurposeType { get; set; }
		public string CurrencyType { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
