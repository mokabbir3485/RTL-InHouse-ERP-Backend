using DbExecutor;
using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_AdditionalAttribute : IEntityBase
	{
		public Int32  AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int ValueAvailibilityType { get; set; }
        public bool IsActive { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }
        public string ValueAvailibilityTypeName { get; set; }
    }
}
