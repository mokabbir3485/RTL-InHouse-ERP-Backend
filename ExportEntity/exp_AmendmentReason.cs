using System;
using System.Text;

namespace ExportEntity
{
	public class exp_AmendmentReason
	{
		public Int32 AmendmentReasonId { get; set; }
		public string AmendmentReasonName { get; set; }
		public bool IsActive { get; set; }
		public Int32 UpdateBy { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
