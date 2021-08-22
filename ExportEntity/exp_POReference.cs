
using System;

namespace ExportEntity
{
    public class exp_POReference
    {
        public Int64 POReferenceId { set; get; }
        public Int64 DocumentId { set; get; }
        public string DocType { set; get; }
        public string PONo { set; get; }
        public DateTime PODate { set; get; }
    }
}
