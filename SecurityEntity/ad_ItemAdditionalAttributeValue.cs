using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_ItemAdditionalAttributeValue
	{
		public Int64 ItemAddAttValueId { get; set; }
        public Int64 ItemAddAttId { get; set; }
        public Int32 AttributeValueId { get; set; }
        public string Barcode { get; set; }
        public string Value { get; set; }
    }
}
