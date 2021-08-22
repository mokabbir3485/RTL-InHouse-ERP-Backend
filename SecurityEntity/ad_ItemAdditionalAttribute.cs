using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemAdditionalAttribute
	{
		public Int64 ItemAddAttId { get; set; }
		public Int32 ItemId { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }
        public string AttributeName { get; set; }
        public Int32 AttributeId { get; set; }
        public string Combination { get; set; }
    }
}
