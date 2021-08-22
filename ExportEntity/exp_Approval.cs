using System;
using System.Text;

namespace ExportEntity
{
	public class exp_Approval
	{
		public Int64 ApprovalId { get; set; }
		public string ApprovalType { get; set; }
		public Int64 DocumentId { get; set; }
		public Int32? AmendmentReasonId { get; set; }
		public string RequestRemarks { get; set; }
        public bool IsApproved { get; set; }
        public Int32? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovalPassword { get; set; }
        public string ApprovedRemarks { get; set; }
		public Int32 UpdateBy { get; set; }
		public DateTime UpdateDate { get; set; }
        public string DocType { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public string Party { get; set; }
        public decimal Amount { get; set; }
	}
}
