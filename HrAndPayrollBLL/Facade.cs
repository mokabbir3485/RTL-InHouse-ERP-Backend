namespace HrAndPayrollBLL
{
    public static class Facade
    {
        public static hr_AttendancePolicyBLL hr_AttendancePolicy { get { return new hr_AttendancePolicyBLL(); } }
        public static hr_HolidayBLL hr_Holiday { get { return new hr_HolidayBLL(); } }
        public static hr_TypesBLL hr_Types { get { return new hr_TypesBLL(); } }
        public static hr_OverTimeTypeBLL hr_OverTimeType { get { return new hr_OverTimeTypeBLL(); } }
        public static hr_GradeBLL hr_Grade { get { return new hr_GradeBLL(); } }
        public static hr_ShiftBLL hr_Shift { get { return new hr_ShiftBLL(); } }
        public static hr_LeaveApplicationBLL hr_LeaveApplication { get { return new hr_LeaveApplicationBLL(); } }
        public static hr_LeaveTypeSetupBLL hr_LeaveTypeSetup { get { return new hr_LeaveTypeSetupBLL(); } }
        public static hr_BonusTypeSetupBLL hr_BonusTypeSetup { get { return new hr_BonusTypeSetupBLL(); } }
        public static hr_AllowanceTypeSetupBLL hr_AllowanceTypeSetup { get { return new hr_AllowanceTypeSetupBLL(); } }
        public static hr_UserBLL hr_User { get { return new hr_UserBLL(); } }
        public static hr_SalaryBLL hr_Salary { get { return new hr_SalaryBLL(); } }
        public static hr_SalaryDetailBLL hr_SalaryDetail { get { return new hr_SalaryDetailBLL(); } }
        public static hr_ContractTypeBLL hr_ContractType { get { return new hr_ContractTypeBLL(); } }
    }
}
