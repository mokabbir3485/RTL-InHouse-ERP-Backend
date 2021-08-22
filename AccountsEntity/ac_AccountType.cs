using System;
using System.Text;

namespace AccountsEntity
{
    public class ac_AccountType
    {
        public Int32 AccountTypeId { get; set; }
        public Int32 ClassId { get; set; }
        public string AccountTypeName { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public Int32 UpdatorId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string IsActiveString { get; set; }
        public string ClassName { get; set; }
    }
}
