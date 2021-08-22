using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_PriceType : IEntityBase
	{
		public Int32  PriceTypeId { get; set; }
		public string  PriceTypeName { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
        public bool IsDefault { get; set; }
        public string IsDefaultString { get; set; }
    }
}
