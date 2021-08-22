using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_Approval : IEntityBase
	{
		public Int32  ApprovalId { get; set; }
		public Int32  ScreenId { get; set; }
		public bool  IsRequired { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string ScreenName { get; set; }
        public string ModuleName { get; set; }
        public Int32 ModuleId { get; set; }
        public Int32 Sorting { get; set; }
    }
}
