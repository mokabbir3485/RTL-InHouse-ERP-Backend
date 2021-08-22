using System;
using System.Text;

namespace ExportEntity
{
	public class exp_TruckChallan
	{
		public Int64 TruckChallanId { get; set; }
		public Int64 CommercialInvoiceId { get; set; }
		public string CommercialInvoiceNo { get; set; }
		public string TruckNo { get; set; }
		public string Footers { get; set; }
		public int Sort { get; set; }
		public int UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
