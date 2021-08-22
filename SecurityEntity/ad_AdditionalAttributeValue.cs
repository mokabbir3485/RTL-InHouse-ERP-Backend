using System;
using System.Text;

namespace SecurityEntity
{
	public class ad_AdditionalAttributeValue
	{
		public Int32  AttributeValueId { get; set; }
		public Int32  AttributeId { get; set; }
		public string  Value { get; set; }
		public bool  IsActive { get; set; }
		public Int32  CreatorId { get; set; }
		public DateTime  CreateDate { get; set; }
		public Int32  UpdatorId { get; set; }
		public DateTime  UpdateDate { get; set; }
        public string AttributeName { get; set; }
        public string Status { get; set; }
    }
}
