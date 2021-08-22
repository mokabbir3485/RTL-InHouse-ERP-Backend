using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_ReturnToSupplier
	{
		public Int64  ReturnId { get; set; }
		public Int32  DepartmentId { get; set; }
		public string  ReturnNo { get; set; }
		public DateTime  ReturnDate { get; set; }
		public Int64  SRId { get; set; }
		public Int32  SupplierId { get; set; }
		public string  ChallanNo { get; set; }
		public Int32  ReturnById { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
		public string  DepartmentName { get; set; }
		public string  SupplierName { get; set; }
		public string  ReturnBy { get; set; }
		public bool  IsApproved { get; set; }
		public Int32  ApprovedBy { get; set; }
		public DateTime  ApprovedDate { get; set; }
	}
}
