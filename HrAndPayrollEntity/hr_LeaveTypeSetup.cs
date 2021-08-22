using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_LeaveTypeSetup
	{
		public Int32 LeaveSetupId { get; set; }
        public Int32 GradeId { get; set; }
        public string LeaveTypeName { get; set; }
		public bool? IsCompensatory { get; set; }
		public string CompensateWith { get; set; }
		public Decimal? CompensateDaysPerHoliday { get; set; }
		public Decimal? OTHoursPerCompenasateDay { get; set; }
		public bool IsByYearly { get; set; }
        public Decimal NoOfDaysYearly { get; set; }
        public Decimal BalanceDays { get; set; }
	}
}
