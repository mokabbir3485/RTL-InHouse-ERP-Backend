using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_PaymentGroup : IEntityBase
	{
        public Int32 PaymentGroupId { get; set; }
        public Int32 ModuleId { get; set; }
		public string  PaymentGroupName { get; set; }
		public bool  IsActive { get; set; }
		public bool  IsDefault { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
        public bool IsAdjustment { get; set; }
    }
}
