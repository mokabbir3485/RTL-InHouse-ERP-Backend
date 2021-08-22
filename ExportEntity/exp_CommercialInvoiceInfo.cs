using System;
using System.Text;

namespace ExportEntity
{
	public class exp_CommercialInvoiceInfo
	{
		public Int64 InfoId { get; set; }
		public Int64? CommercialInvoiceId { get; set; }
		public string InfoType { get; set; }
		public string InfoLabel { get; set; }
        public string InfoSubType { get; set; }
		public string InfoValue { get; set; }
		public Int32? Sorting { get; set; }
	}
}
