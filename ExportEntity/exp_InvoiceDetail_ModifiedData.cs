using System;
using System.Security.AccessControl;

namespace ExportEntity
{
    public class exp_InvoiceDetail_ModifiedData
    {
        public Int64 Id { get; set; }
        public Int64 InvoiceId { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
