using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_Grade
	{
		public Int32 GradeId { get; set; }
		public string GradeName { get; set; }
        public int BasicF1_GrossMinus { get; set; }
        public Decimal BasicF2_DivideBy { get; set; }
        public Decimal BasicF3_MultiplyBy { get; set; }
        public bool HasHalfDayPenaltyFraction { get; set; }
        public string PerDaySalaryF1_ApplyOn { get; set; }
        public string PerDaySalaryF2_DaysType { get; set; }
        public bool HasProvFund { get; set; }
		public string ProvFundOn { get; set; }
		public Decimal? CompanyPFPercent { get; set; }
		public Decimal? EmployeePFPercent { get; set; }
		public bool IsActive { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
        public string PfInfo { get; set; }
        public string LeaveInfo { get; set; }
        public string BonusInfo { get; set; }
	}
}
