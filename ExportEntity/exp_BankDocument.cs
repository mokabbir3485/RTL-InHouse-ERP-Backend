using System;
using System.Security.AccessControl;
using System.Text;

namespace ExportEntity
{
	public class exp_BankDocument
	{
		public Int64 BankDocumentId { get; set; }
		public Int64 CommercialInvoiceId { get; set; }
        public string CommercialInvoiceNo { get; set; }
        public string BankApplicationTo { get; set; }
        public string BankDocumentToDepartment { get; set; }
        public string ApplicationDate { get; set; }
        public Int64 BankDocumentDetailId { get; set; }
        public string ApplicationSubject { get; set; }
        public string LcScNo { get; set; }
        public string lcDate { get; set; }

        public string NameOfDocument { get; set; }
        public string OriginSet { get; set; }
        public int Sets { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
	}
}
