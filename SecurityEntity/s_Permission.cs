using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{

    public class s_Permission : IEntityBase
	{
		public Int64  PermissionId { get; set; }
		public Int32  RoleId { get; set; }
		public Int32  ScreenId { get; set; }
		public bool  CanView { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string ModuleName { get; set; }
        public string ScreenName { get; set; }
	}
}
