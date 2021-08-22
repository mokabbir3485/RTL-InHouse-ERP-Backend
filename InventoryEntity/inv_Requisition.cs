using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_Requisition
	{
		public Int64  RequisitionId { get; set; }
        public Int64 InternalWorkOrderId { get; set; }
        public string RequisitionNo { get; set; }
		public DateTime  RequisitionDate { get; set; }
		public Int32  FromDepartmentId { get; set; }
		public Int32  ToDepartmentId { get; set; }
		public Int32  PreparedById { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
		public string  FromDepartmentName { get; set; }
		public string  ToDepartmentName { get; set; }
		public string  PreparedBy { get; set; }
		public bool  IsSentBack { get; set; }
		public bool  IsApproved { get; set; }
		public Int32?  ApprovedBy { get; set; }
		public DateTime?  ApprovedDate { get; set; }
	}
}
