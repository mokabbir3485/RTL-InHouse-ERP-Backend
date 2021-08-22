using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityEntity
{
    public abstract class BaseSupplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}