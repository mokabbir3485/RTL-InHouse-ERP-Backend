using System;

namespace HrAndPayrollEntity
{
    public class hr_AttendanceTypeCount
    {
        public Int32 BranchId { get; set; }
        public string BranchName { get; set; }
        public string AttendanceTypeName { get; set; }
        public Int32 EmpCount { get; set; }
    }
}
