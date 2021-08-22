using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{

    public class ad_Domain : IEntityBase
	{
		public Int32  DomainId { get; set; }
		public Int32  GroupId { get; set; }
		public string  DomainName { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
