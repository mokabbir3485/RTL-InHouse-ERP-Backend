using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_OverTimeType
	{
		public Int32 OverTimeTypeId { get; set; }
		public string OverTimeTypeName { get; set; }
		public string OverTimePeriod { get; set; }
		public string OverTimeOn { get; set; }
		public Decimal TimesOfAnHour { get; set; }
		public Decimal HoursAfterOTStarts { get; set; }
		public Int32 OTPulsaeInMin { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
		public DateTime? ValidTill { get; set; }
	}
}
