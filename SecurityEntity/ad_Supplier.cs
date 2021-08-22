using DbExecutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityEntity
{
    public class ad_Supplier : BaseSupplier, IEntityBase
    {
        public string SupplierCode { get; set; }
        public int SupplierTypeId { get; set; }
        public string Web { get; set; }
        public bool IsActive { get; set; }
        public bool IsReceivable { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }
        public string SupplierNameWithCode { get; set; }
        public string TIN { get; set; }
        public string BIN { get; set; }
        public string NID { get; set; }

       //Temp Column
        public string SuppilerTypeName { get; set; }
    }
}
