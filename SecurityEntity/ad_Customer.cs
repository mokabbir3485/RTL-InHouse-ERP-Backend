using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_Customer : BaseCustomer, IEntityBase
	{
        public Int32 CustomerTypeId { get; set; }
        public Int32 BranchId { get; set; }
        public string CustomerTypeName { get; set; }
        public string Web { get; set; }
		public string  TradingAs { get; set; }
		public bool IsActive { get; set; }
		public bool  IsPayable { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
        public decimal TotalSaleAmt { get; set; }
        public decimal TotalAdjustedPointAmt { get; set; }
        public string Mobile { get; set; }
        public string BranchName { get; set; }
        public string ManualCustomerCode { get; set; }
    }
}
