using DbExecutor;
using HrAndPayrollEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace HrAndPayrollDAL
{
    public class hr_SalaryDetailDAO //: IDisposible
    {
        private static volatile hr_SalaryDetailDAO instance;
        private static readonly object lockObj = new object();
        public static hr_SalaryDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new hr_SalaryDetailDAO();
            }
            return instance;
        }
        public static hr_SalaryDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new hr_SalaryDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public hr_SalaryDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<hr_SalaryDetail> GetForPrepare(int monthId, int yearId, int branchId, int gradeId, string departmentId, int sectionId)
        {
            try
            {
                List<hr_SalaryDetail> hr_SalaryDetailLst = new List<hr_SalaryDetail>();
                Parameters[] colparameters = new Parameters[6]{
                    new Parameters("@MonthId", monthId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@YearId", yearId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@BranchId", branchId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@GradeId", gradeId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@DepartmentId", departmentId, DbType.String, ParameterDirection.Input),
                    new Parameters("@SectionId", sectionId, DbType.Int32, ParameterDirection.Input),
                };
                hr_SalaryDetailLst = dbExecutor.FetchData<hr_SalaryDetail>(CommandType.StoredProcedure, "hr_SalaryDetail_GetForPrepare", colparameters);
                return hr_SalaryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_SalaryDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<hr_SalaryDetail> hr_SalaryDetailLst = new List<hr_SalaryDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                hr_SalaryDetailLst = dbExecutor.FetchData<hr_SalaryDetail>(CommandType.StoredProcedure, "hr_SalaryDetail_GetDynamic", colparameters);
                return hr_SalaryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_SalaryDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<hr_SalaryDetail> hr_SalaryDetailLst = new List<hr_SalaryDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                hr_SalaryDetailLst = dbExecutor.FetchDataRef<hr_SalaryDetail>(CommandType.StoredProcedure, "hr_SalaryDetail_GetPaged", colparameters, ref rows);
                return hr_SalaryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Post(hr_SalaryDetail _hr_SalaryDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[34]{
                    new Parameters("@SalaryDetailId", _hr_SalaryDetail.SalaryDetailId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@SalaryId", _hr_SalaryDetail.SalaryId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@EmployeeId", _hr_SalaryDetail.EmployeeId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@GrossSalary", _hr_SalaryDetail.GrossSalary, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@BasicSalary", _hr_SalaryDetail.BasicSalary, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@HouseRent", _hr_SalaryDetail.HouseRent, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@MedicalAllowance", _hr_SalaryDetail.MedicalAllowance, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@ConveyanceAllowance", _hr_SalaryDetail.ConveyanceAllowance, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@LunchAllowance", _hr_SalaryDetail.LunchAllowance, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtHrs", _hr_SalaryDetail.OtHrs, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtRate", _hr_SalaryDetail.OtRate, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtAmount", _hr_SalaryDetail.OtAmount, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtherAddition", _hr_SalaryDetail.OtherAddition, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtherAdditionRemarks", _hr_SalaryDetail.OtherAdditionRemarks, DbType.String, ParameterDirection.Input),
                    new Parameters("@TotalB4Deduction", _hr_SalaryDetail.TotalB4Deduction, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@TotalDays", _hr_SalaryDetail.TotalDays, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@WorkingDays", _hr_SalaryDetail.WorkingDays, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@WeeklyHolidays", _hr_SalaryDetail.WeeklyHolidays, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@PublicHolidays", _hr_SalaryDetail.PublicHolidays, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@AbsentDays", _hr_SalaryDetail.AbsentDays, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@DeductionAbsent", _hr_SalaryDetail.DeductionAbsent, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@DeductionProvFund", _hr_SalaryDetail.DeductionProvFund, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@DeductionTDS", _hr_SalaryDetail.DeductionTDS, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@DeductionRevenueStamp", _hr_SalaryDetail.DeductionRevenueStamp, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@DeductionAdvanceSalary", _hr_SalaryDetail.DeductionAdvanceSalary, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtherDeduction", _hr_SalaryDetail.OtherDeduction, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@OtherDeductionRemarks", _hr_SalaryDetail.OtherDeductionRemarks, DbType.String, ParameterDirection.Input),
                    new Parameters("@NetPaymentBDT", _hr_SalaryDetail.NetPaymentBDT, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@NetPaymentUSD", _hr_SalaryDetail.NetPaymentUSD, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@BranchName", _hr_SalaryDetail.BranchName, DbType.String, ParameterDirection.Input),
                    new Parameters("@DepartmentName", _hr_SalaryDetail.DepartmentName, DbType.String, ParameterDirection.Input),
                    new Parameters("@DesignationName", _hr_SalaryDetail.DesignationName, DbType.String, ParameterDirection.Input),
                    new Parameters("@IsCash", _hr_SalaryDetail.IsCash, DbType.Boolean, ParameterDirection.Input),
                    new Parameters("@IsCheque", _hr_SalaryDetail.IsCheque, DbType.Boolean, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "hr_SalaryDetail_Post", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
            }
            catch (DBConcurrencyException except)
            {
                dbExecutor.ManageTransaction(TransactionType.Rollback);
                throw except;
            }
            catch (Exception ex)
            {
                dbExecutor.ManageTransaction(TransactionType.Rollback);
                throw ex;
            }
            return ret;
        }
        public int Update(hr_SalaryDetail _hr_SalaryDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[38]{
                new Parameters("@SalaryDetailId", _hr_SalaryDetail.SalaryDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SalaryId", _hr_SalaryDetail.SalaryId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@EmployeeId", _hr_SalaryDetail.EmployeeId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@GrossSalary", _hr_SalaryDetail.GrossSalary, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@BasicSalary", _hr_SalaryDetail.BasicSalary, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@HouseRent", _hr_SalaryDetail.HouseRent, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@MedicalAllowance", _hr_SalaryDetail.MedicalAllowance, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ConveyanceAllowance", _hr_SalaryDetail.ConveyanceAllowance, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@LunchAllowance", _hr_SalaryDetail.LunchAllowance, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtHrs", _hr_SalaryDetail.OtHrs, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtRate", _hr_SalaryDetail.OtRate, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtAmount", _hr_SalaryDetail.OtAmount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtherAddition", _hr_SalaryDetail.OtherAddition, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtherAdditionRemarks", _hr_SalaryDetail.OtherAdditionRemarks, DbType.String, ParameterDirection.Input),
                new Parameters("@TotalB4Deduction", _hr_SalaryDetail.TotalB4Deduction, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@TotalDays", _hr_SalaryDetail.TotalDays, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@WorkingDays", _hr_SalaryDetail.WorkingDays, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@WeeklyHolidays", _hr_SalaryDetail.WeeklyHolidays, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@PublicHolidays", _hr_SalaryDetail.PublicHolidays, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@AbsentDays", _hr_SalaryDetail.AbsentDays, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeductionAbsent", _hr_SalaryDetail.DeductionAbsent, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeductionProvFund", _hr_SalaryDetail.DeductionProvFund, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeductionTDS", _hr_SalaryDetail.DeductionTDS, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeductionRevenueStamp", _hr_SalaryDetail.DeductionRevenueStamp, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeductionAdvanceSalary", _hr_SalaryDetail.DeductionAdvanceSalary, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtherDeduction", _hr_SalaryDetail.OtherDeduction, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OtherDeductionRemarks", _hr_SalaryDetail.OtherDeductionRemarks, DbType.String, ParameterDirection.Input),
                new Parameters("@NetPaymentBDT", _hr_SalaryDetail.NetPaymentBDT, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@NetPaymentUSD", _hr_SalaryDetail.NetPaymentUSD, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@IsPaid", _hr_SalaryDetail.IsPaid, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@PaymentBy", _hr_SalaryDetail.PaymentBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PaymentDate", _hr_SalaryDetail.PaymentDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@CashPayment", _hr_SalaryDetail.CashPayment, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@BankPayment", _hr_SalaryDetail.BankPayment, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ChequePayment", _hr_SalaryDetail.ChequePayment, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@BankAccountId", _hr_SalaryDetail.BankAccountId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@GeneralRemarks", _hr_SalaryDetail.GeneralRemarks, DbType.String, ParameterDirection.Input),
                new Parameters("@IsEditedAfterPayment", _hr_SalaryDetail.IsEditedAfterPayment, DbType.Boolean, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "hr_SalaryDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 salaryDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SalaryDetailId", salaryDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "hr_SalaryDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
