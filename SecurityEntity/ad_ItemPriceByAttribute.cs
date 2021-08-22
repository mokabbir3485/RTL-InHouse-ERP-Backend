using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_ItemPriceByAttribute : IEntityBase
	{
        public Int32 AttributePriceId { get; set; }
        public Int64 ItemAddAttId { get; set; }
		public Int32  PriceTypeId { get; set; }
        public Decimal PurchaseUnitPrice { get; set; }
        public Decimal PurchasePackagePrice { get; set; }
        public Decimal PurchaseContainerPrice { get; set; }
        public Decimal SaleUnitPrice { get; set; }
        public Decimal SalePackagePrice { get; set; }
        public Decimal SaleContainerPrice { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Barcode { get; set; }
	}
}
