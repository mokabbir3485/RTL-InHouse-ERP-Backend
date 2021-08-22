using System;
using System.Text;

namespace ExportEntity
{
	public class exp_BankDocumentDetail
	{
		public Int64 BankDocumentDetailId { get; set; }
		public Int64 BankDocumentId { get; set; }
		public string NameOfDocument { get; set; }
		public string OriginSet { get; set; }
		public Int32 Sets { get; set; }
		public Int32 UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
