using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_SupplierType
	{
		public Int32  SupplierTypeId { get; set; }
		public string  SupplierTypeName { get; set; }
		public bool  IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32?  UpdatorId { get; set; }
		public DateTime?  UpdateDate { get; set; }
	}
}
