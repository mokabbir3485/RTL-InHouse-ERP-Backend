using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_Terminal : IEntityBase
	{
		public Int32  TerminalId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string TerminalName { get; set; }
        public string IpAddress { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
        public string DepartmentName { get; set; }
    }
}
