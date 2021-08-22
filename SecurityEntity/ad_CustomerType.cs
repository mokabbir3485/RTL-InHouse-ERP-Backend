using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_CustomerType : IEntityBase
	{
		public Int32  CustomerTypeId { get; set; }
		public string  CustomerTypeName { get; set; }
		public bool  IsCommissionApplicable { get; set; }
		public Int32  CommissionPercentage { get; set; }
		public bool  IsPointApplicable { get; set; }
		public Decimal  SinglePointForAmount { get; set; }
        public Int32 CouponPercentage { get; set; }
        public Int32 NonCouponPercentage { get; set; }
		public bool  IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
    }
}
