using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportEntity
{
    public class exp_CommercialInvoiceDetail_ModifiedData
    {
        public Int64 Id { get; set; }
        public Int64 RowNo { get; set; }
        public Int64 CommercialInvoiceId { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
