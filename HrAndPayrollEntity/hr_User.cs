using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_User
	{
		public Int32 HrUserId { get; set; }
		public Int32 EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public Int32 RoleId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public Int32 BranchId { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public string BranchName { get; set; }
        public Int32 PrioritySequenceId { get; set; }
        public Int32 SerialNumber { get; set; }

   
    }
}
