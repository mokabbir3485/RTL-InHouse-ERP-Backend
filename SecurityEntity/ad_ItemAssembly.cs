using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemAssembly : IEntityBase
	{
		public Int32  AssemblyId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  RawItemId { get; set; }
		public Decimal  Quantity { get; set; }
		public Int32  UnitId { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
