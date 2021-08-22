using System;
using System.Text;

namespace HrAndPayrollEntity
{
	public class hr_Types
	{
		public Int32 TypesId { get; set; }
		public string Entity { get; set; }
		public string TypesName { get; set; }
		public bool IsActive { get; set; }
		public Int32 UpdatorId { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
