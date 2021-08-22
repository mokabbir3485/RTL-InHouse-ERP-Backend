using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemUnitPackage : IEntityBase
	{
		public Int32  PackageId { get; set; }
		public string  PackageName { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
