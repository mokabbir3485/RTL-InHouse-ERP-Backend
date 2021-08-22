using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_Holiday
	{
		public Int32 HolidayId { get; set; }
		public string HolidayName { get; set; }
		public Int32 BranchId { get; set; }
		public Int32 DepartmentId { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToDate { get; set; }
		public string Remarks { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
