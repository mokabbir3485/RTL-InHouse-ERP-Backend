using System;
using System.Text;

namespace SecurityEntity
{
	public class s_Role
	{
		public int RoleId { get; set; }
		public string RoleName { get; set; }
		public bool IsActive { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool IsCheckoutOperator { get; set; }
		public int CreatorId { get; set; }
		public DateTime CreateDate { get; set; }
		public Nullable<int> UpdatorId { get; set; }
		public Nullable<DateTime> UpdateDate { get; set; }
        public string Status { get; set; }
	}
}
