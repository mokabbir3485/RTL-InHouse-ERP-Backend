using DbExecutor;
using System;

namespace SecurityEntity
{

    public class s_User : IEntityBase
    {
        public Int32 UserId { get; set; }
        public Int32 RoleId { get; set; }
        public Int32 EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsReqSmsCode { get; set; }
        public string SmsMobileNo { get; set; }
        public string AuthorizationPassword { get; set; }
        public bool IsActive { get; set; }
        public Int32 CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public string FullName { get; set; }
        public bool IsCheckoutOperator { get; set; }
        public string BranchName { get; set; }
        public Int32 BranchId { get; set; }
    }
}
