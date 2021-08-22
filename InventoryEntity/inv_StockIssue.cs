using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockIssue
	{
		public Int64  IssueId { get; set; }
		public Int64  RequisitionId { get; set; }
		public string  IssueNo { get; set; }
		public DateTime  IssueDate { get; set; }
        public Int32 IssueFromDepartmentId { get; set; }
        public Int32 IssueToDepartmentId { get; set; }
		public Int32  IssuedById { get; set; }
		public Int32  ReceivedById { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string IssueFromDepartmentName { get; set; }
        public string IssueToDepartmentName { get; set; }
		public string  IssuedBy { get; set; }
		public string  ReceivedBy { get; set; }
		public bool  IsApproved { get; set; }
		public Int32?  ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal Amount { get; set; }
        public string RequisitionNo { get; set; }
    }
}
