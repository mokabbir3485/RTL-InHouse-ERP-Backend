using System;

namespace HrAndPayrollEntity
{
    public class hr_LeaveOpeningBalance
    {
        public Int32 LeaveSetupId { get; set; }

        public Int32 EmployeeId { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal OpeningBalance { get; set; }
    }
}