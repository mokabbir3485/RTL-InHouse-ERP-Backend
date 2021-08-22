using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_Currency : IEntityBase
	{
		public Int32  CurrencyId { get; set; }
		public string  CurrencyName { get; set; }
		public string  CurrencyShort { get; set; }
		public bool  IsActive { get; set; }
		public bool  IsDefault { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
	}
}
