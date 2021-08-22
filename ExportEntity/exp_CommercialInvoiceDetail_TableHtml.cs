using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportEntity
{
    public class exp_CommercialInvoiceDetail_TableHtml
    {
        public Int64 Id { get; set; }
        public Int64 CommercialInvoiceId { get; set; }
        public string HtmlData { get; set; }
    }
}
