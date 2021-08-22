using System;
using System.Text;

namespace AccountsEntity
{
	public class ac_ChartOfAccount
	{
		public Int32 AccountId { get; set; }
		public Int32 AccountTypeDetailId { get; set; }
		public string AccountName { get; set; }
		public string AccountDescription { get; set; }
		public Int32 ParentId { get; set; }
		public bool IsActive { get; set; }
		public bool IsDefault { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
