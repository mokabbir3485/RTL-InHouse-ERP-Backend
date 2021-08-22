using System;

namespace HrAndPayrollEntity
{
    public class hr_SalaryDetail
    {
        public Int64 SalaryDetailId { get; set; }
        public Int64 SalaryId { get; set; }
        public Int32 EmployeeId { get; set; }
        public Decimal GrossSalary { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal HouseRent { get; set; }
        public Decimal MedicalAllowance { get; set; }
        public Decimal ConveyanceAllowance { get; set; }
        public Decimal LunchAllowance { get; set; }
        public Decimal OtHrs { get; set; }
        public Decimal OtRate { get; set; }
        public Decimal OtAmount { get; set; }
        public Decimal OtherAddition { get; set; }
        public string OtherAdditionRemarks { get; set; }
        public Decimal TotalB4Deduction { get; set; }
        public Decimal TotalDays { get; set; }
        public Decimal WorkingDays { get; set; }
        public Decimal WeeklyHolidays { get; set; }
        public Decimal PublicHolidays { get; set; }
        public Decimal AbsentDays { get; set; }
        public Decimal DeductionAbsent { get; set; }
        public Decimal DeductionProvFund { get; set; }
        public Decimal DeductionTDS { get; set; }
        public Decimal DeductionRevenueStamp { get; set; }
        public Decimal DeductionAdvanceSalary { get; set; }
        public Decimal OtherDeduction { get; set; }
        public string OtherDeductionRemarks { get; set; }
        public Decimal NetPaymentBDT { get; set; }
        public Decimal NetPaymentUSD { get; set; }
        public bool IsPaid { get; set; }
        public Int32? PaymentBy { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Decimal? CashPayment { get; set; }
        public Decimal? BankPayment { get; set; }
        public Decimal? ChequePayment { get; set; }
        public Int32? BankAccountId { get; set; }
        public string GeneralRemarks { get; set; }
        public bool IsEditedAfterPayment { get; set; }
        public string EmployeeName { get; set; }
        public string BranchName { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public bool IsCash { get; set; }
        public bool IsCheque { get; set; }
    }
}
