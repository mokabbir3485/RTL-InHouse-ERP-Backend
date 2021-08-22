using DbExecutor;
using System;

namespace SecurityEntity
{
    public class ad_Employee : BaseEmployee, IEntityBase
    {
        public bool IsUser { get; set; }
        public Int32 SectionId { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public string Username { get; set; }
        public Int32 RoleId { get; set; }
        public string FullName { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 BranchId { get; set; }
        public string BranchName { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public Int32 ManagerId { get; set; }
        public Int32 GradeId { get; set; }
        public string GradeName { get; set; }
        public string BloodGroup { get; set; }
        public bool IsFlexibleOnDate { get; set; }
        public bool IsFlexibleOnTime { get; set; }
        public decimal BasicSalary { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string ExistingShift { get; set; }
        public string UnitName { get; set; }
        public bool IsManagerRef { get; set; }
        public int ContractTypeId { get; set; }
    }
}
