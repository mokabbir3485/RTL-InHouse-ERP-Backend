using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_RequisitionPurpose
	{
		public Int32  RequisitionPurposeId { get; set; }
		public string  RequisitionPurposeName { get; set; }
		public bool IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string Status { get; set; }
	}
}
