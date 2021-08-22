using System;
using System.Text;

namespace ExportEntity
{
	public class exp_ConsumptionCertificateDescription
	{
		public Int64 ConsumptionCertificateDescriptionId { get; set; }
		public Int64 ConsumptionCertificateId { get; set; }
		public string ItemName { get; set; }
		public string QtyDescription { get; set; }
		public Decimal Quantity { get; set; }
		public Decimal UnitPrice { get; set; }
		public Decimal Amount { get; set; }
		public Int32 UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
