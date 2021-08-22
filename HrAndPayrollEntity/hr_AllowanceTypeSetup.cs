using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_AllowanceTypeSetup
	{
		public Int32 AllowanceTypeSetupId { get; set; }
		public Int32 GradeId { get; set; }
		public string AllowanceTypeName { get; set; }
		public string ValueType { get; set; }
		public string ApplyOn { get; set; }
		public Decimal Value { get; set; }
		public bool IsAfterGross { get; set; }
	}
}
