using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_Bank : IEntityBase
	{
		public Int32 BankId { get; set; }
		public string BankName { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public Int32 CreatorId { get; set; }
		public DateTime CreateDate { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public string Status { get; set; }
    }
}
