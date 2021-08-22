using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ValuationType
	{
		public Int32  ValuationTypeId { get; set; }
		public string  ValuationTypeName { get; set; }
		public bool IsActive { get; set; }
		public bool  IsDefault { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
	}
}
