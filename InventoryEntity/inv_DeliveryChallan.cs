using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryEntity
{
  public  class inv_DeliveryChallan
    {

        public Int64 DeliveryDetailId { get; set; }
        public Int64 DeliveryId { get; set; }
        public Decimal DeliveryUnitPrice { get; set; }
        public Decimal DeliveryQuantity { get; set; }
        public Decimal TotalAmt { get; set; }
        public Decimal TotalQty { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryNo { get; set; }
        public string ReferenceNo { get; set; }
        public string SalesOrderNo { get; set; }
        public DateTime SalesOrderDate { get; set; }
        public string ItemName { get; set; }
        public string Combination { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string DeliveryFromAddress { get; set; }

        public string QtySummary { get; set; }

    }
}
