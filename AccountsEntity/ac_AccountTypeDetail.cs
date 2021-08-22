using System;
using System.Text;

namespace AccountsEntity
{
	public class ac_AccountTypeDetail
	{
		public Int32 AccountTypeDetailId { get; set; }
		public Int32 AccountTypeId { get; set; }
		public string AccountTypeDetailName { get; set; }
		public string DetailDisplayName { get; set; }
		public bool IsActive { get; set; }
		public bool IsDefault { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public string IsActiveString { get; set; }
        public string AccountTypeName { get; set; }
	}
}
