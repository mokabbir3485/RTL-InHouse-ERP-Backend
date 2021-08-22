using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_FinalPriceConfig
	{
		public Int32  ConfigId { get; set; }
		public string  ConfigCode { get; set; }
		public string  ConfigName { get; set; }
		public Int32  TransactionTypeId { get; set; }
		public Int32  PriceTypeId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string TransactionTypeName { get; set; }
        public string Status { get; set; }
	}
}
