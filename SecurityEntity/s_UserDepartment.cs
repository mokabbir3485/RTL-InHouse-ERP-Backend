using System;
using System.Text;

namespace SecurityEntity
{
	public class s_UserDepartment
	{
		public Int32  UserDepartmentId { get; set; }
		public Int32  UserId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Int32 BranchId { get; set; }
        public string BranchName { get; set; }
        public DateTime OpeningDate { get; set; }
    }
}
