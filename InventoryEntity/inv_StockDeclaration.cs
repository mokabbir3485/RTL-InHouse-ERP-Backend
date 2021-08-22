using System;
using System.Text;

namespace InventoryEntity
{
	public class inv_StockDeclaration
	{
		public Int64  DeclarationId { get; set; }
		public string  DeclarationNo { get; set; }
		public DateTime  DeclarationDate { get; set; }
		public Int32  DepartmentId { get; set; }
		public Int32  DeclaredById { get; set; }
		public string  Remarks { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
		public string  DepartmentName { get; set; }
		public string  DeclaredBy { get; set; }
		public bool  IsApproved { get; set; }
		public Int32?  ApprovedBy { get; set; }
		public DateTime?  ApprovedDate { get; set; }
	}
}
