using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_BankAccount
	{
		public Int32 BankAccountId { get; set; }
		public string BankName { get; set; }
		public string AccountNo { get; set; }
		public string AccountName { get; set; }
		public string SwiftCode { get; set; }
		public string BIN { get; set; }
		public string BranchName { get; set; }
		public string BranchAddress { get; set; }
		public string AccountFor { get; set; }
		public Int32 AccountRefId { get; set; }
        public bool IsActive { get; set; }
        public Int32 UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
        public string Status { get; set; }
    }
}
