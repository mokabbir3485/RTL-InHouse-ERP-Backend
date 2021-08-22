using DbExecutor;
using System;

namespace SecurityEntity
{
    public class ad_Designation : IEntityBase
    {
        public Int32 DesignationId { get; set; }
        public Int32 DepartmentId { get; set; }
        public string DesignationName { get; set; }
        public string ContactNo { get; set; }
        public int SerialNo { get; set; }
        public bool IsActive { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
    }
}
