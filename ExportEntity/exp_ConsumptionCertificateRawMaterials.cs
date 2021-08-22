using System;
using System.Text;

namespace ExportEntity
{
	public class exp_ConsumptionCertificateRawMaterials
	{
		public Int64 ConsumptionCertificateRawMaterialsId { get; set; }
		public Int64 ConsumptionCertificateId { get; set; }
		public string ImportBondNo { get; set; }
		public Decimal PreviousBalance { get; set; }
		public Decimal ExportQty { get; set; }
		public Decimal ClosingBalance { get; set; }
		public Int32 UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
