using System;

namespace InventoryEntity
{
    public class inv_StockIssueDetail
    {
        public Int64 IssueDetailId { get; set; }
        public Int64 IssueId { get; set; }
        public Int64 ItemId { get; set; }
        public Int32 IssueUnitId { get; set; }
        public Decimal IssueQuantity { get; set; }
        public Decimal IssueUnitPrice { get; set; }
        public string ItemName { get; set; }
        public string IssueUnitName { get; set; }
        public string ItemCode { get; set; }
        public Decimal ReturnedQuantity { get; set; }
    }
}
