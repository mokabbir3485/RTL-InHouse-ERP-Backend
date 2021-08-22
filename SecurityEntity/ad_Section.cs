using System;

namespace SecurityEntity
{

    public class ad_Section
    {
        public Int32 SectionId { get; set; }
        public string SectionName { get; set; }
        public bool IsActive { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
