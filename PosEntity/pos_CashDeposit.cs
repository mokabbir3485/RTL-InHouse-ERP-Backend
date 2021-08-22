using System;
using System.Text;

namespace PosEntity
{
	public class pos_CashDeposit
	{
		public Int64  DepositId { get; set; }
		public Int32  BranchId { get; set; }
		public Int32  BankId { get; set; }
		public string  BankBranchName { get; set; }
		public DateTime  DepositDate { get; set; }
		public string  ReferenceNo { get; set; }
		public Int32  DepositById { get; set; }
		public string  Remarks { get; set; }
		public Decimal  Amount { get; set; }
		public string  BankName { get; set; }
		public string  DepositByName { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
