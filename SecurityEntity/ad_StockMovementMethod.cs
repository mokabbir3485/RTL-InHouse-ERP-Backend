using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_StockMovementMethod : IEntityBase
	{
		public Int32  MovementMethodId { get; set; }
		public string  MovementMethodName { get; set; }
		public bool  IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
