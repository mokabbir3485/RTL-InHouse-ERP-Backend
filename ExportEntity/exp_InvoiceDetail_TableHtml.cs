using System;
using System.Security.AccessControl;

namespace ExportEntity
{
    public class exp_InvoiceDetail_TableHtml
    {
        public Int64 Id { get; set; }
        public Int64 InvoiceId { get; set; }
        public string HtmlData { get; set; }
    }
}
