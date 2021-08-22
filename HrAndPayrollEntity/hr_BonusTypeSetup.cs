using System;
using System.Text;

namespace HrAndPayrollEntity
{
    public class hr_BonusTypeSetup
    {
        public Int32 BonusTypeSetupId { get; set; }
        public Int32 GradeId { get; set; }
        public string BonusTypeName { get; set; }
        public string BonusOn { get; set; }
        public Decimal BonusRatio { get; set; }
    }
}
