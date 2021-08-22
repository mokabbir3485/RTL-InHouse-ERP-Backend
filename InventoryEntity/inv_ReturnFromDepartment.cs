using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_ReturnFromDepartment
	{
		public Int64  ReturnId { get; set; }
		public Int32  FromDepartmentId { get; set; }
		public Int32  ToDepartmentId { get; set; }
		public string  ReturnNo { get; set; }
		public DateTime  ReturnDate { get; set; }
		public Int64  IssueId { get; set; }
		public string  IssueNo { get; set; }
		public Int32  ReturnFromId { get; set; }
		public Int32  ReturnToId { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
		public string  FromDepartmentName { get; set; }
		public string  ToDepartmentName { get; set; }
		public string  ReturnFrom { get; set; }
		public string  ReturnTo { get; set; }
        public bool IsApproved { get; set; }
        public Int32 ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public Decimal ReturnedQuantity { get; set; }
        public string ItemCode { get; set; }
        public Decimal IssueQuantity { get; set; }
        public Decimal IssueUnitPrice { get; set; }
	}
}
