using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemPrice : IEntityBase
	{
		public Int32  ItemPriceId { get; set; }
		public Int32  TransactionTypeId { get; set; }
		public Int32  ItemId { get; set; }
		public Int32  PriceTypeId { get; set; }
        public Decimal UnitPrice { get; set; }
        public Decimal PackagePrice { get; set; }
        public Decimal ContainerPrice { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string PriceTypeName { get; set; }
        public string Status { get; set; }
	}
}
