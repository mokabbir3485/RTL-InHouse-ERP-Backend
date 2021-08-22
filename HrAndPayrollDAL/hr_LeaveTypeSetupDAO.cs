using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using HrAndPayrollEntity;
using DbExecutor;

namespace HrAndPayrollDAL
{
	public class hr_LeaveTypeSetupDAO //: IDisposible
	{
		private static volatile hr_LeaveTypeSetupDAO instance;
		private static readonly object lockObj = new object();
		public static hr_LeaveTypeSetupDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new hr_LeaveTypeSetupDAO();
			}
			return instance;
		}
		public static hr_LeaveTypeSetupDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new hr_LeaveTypeSetupDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public hr_LeaveTypeSetupDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<hr_LeaveTypeSetup> GetByGradeId(int gradeId)
        {
            try
            {
                List<hr_LeaveTypeSetup> hr_LeaveTypeSetupLst = new List<hr_LeaveTypeSetup>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@GradeId", gradeId, DbType.Int32, ParameterDirection.Input)
				};
                hr_LeaveTypeSetupLst = dbExecutor.FetchData<hr_LeaveTypeSetup>(CommandType.StoredProcedure, "hr_LeaveTypeSetup_GetByGradeId", colparameters);
                return hr_LeaveTypeSetupLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_LeaveTypeSetup> GetLeaveTypeByGradeId(int gradeId)
        {
            try
            {
                List<hr_LeaveTypeSetup> hr_LeaveTypeTypeLst = new List<hr_LeaveTypeSetup>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@GradeId", gradeId, DbType.Int32, ParameterDirection.Input)
                };
                hr_LeaveTypeTypeLst = dbExecutor.FetchData<hr_LeaveTypeSetup>(CommandType.StoredProcedure, "hr_GetLeaveTypeByGradeId", colparameters);
                return hr_LeaveTypeTypeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hr_LeaveTypeSetup> GetEmployeeLeaveBalance(Int32 employeeId, DateTime appDate)
        {
            try
            {
                List<hr_LeaveTypeSetup> hr_LeaveTypeSetupLst = new List<hr_LeaveTypeSetup>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@EmployeeId", employeeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AppDate", appDate, DbType.DateTime, ParameterDirection.Input)
				};
                hr_LeaveTypeSetupLst = dbExecutor.FetchData<hr_LeaveTypeSetup>(CommandType.StoredProcedure, "hr_LeaveTypeSetup_GetEmployeeLeaveBalance", colparameters);
                return hr_LeaveTypeSetupLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<hr_LeaveTypeSetup> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<hr_LeaveTypeSetup> hr_LeaveTypeSetupLst = new List<hr_LeaveTypeSetup>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				hr_LeaveTypeSetupLst = dbExecutor.FetchData<hr_LeaveTypeSetup>(CommandType.StoredProcedure, "hr_LeaveTypeSetup_GetDynamic", colparameters);
				return hr_LeaveTypeSetupLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<hr_LeaveTypeSetup> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<hr_LeaveTypeSetup> hr_LeaveTypeSetupLst = new List<hr_LeaveTypeSetup>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				hr_LeaveTypeSetupLst = dbExecutor.FetchDataRef<hr_LeaveTypeSetup>(CommandType.StoredProcedure, "hr_LeaveTypeSetup_GetPaged", colparameters, ref rows);
				return hr_LeaveTypeSetupLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(hr_LeaveTypeSetup _hr_LeaveTypeSetup)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@LeaveTypeName", _hr_LeaveTypeSetup.LeaveTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@GradeId", _hr_LeaveTypeSetup.GradeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsByYearly", _hr_LeaveTypeSetup.IsByYearly, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@NoOfDaysYearly", _hr_LeaveTypeSetup.NoOfDaysYearly, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "hr_LeaveTypeSetup_Create", colparameters, true);
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
		public int Update(hr_LeaveTypeSetup _hr_LeaveTypeSetup)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@LeaveSetupId", _hr_LeaveTypeSetup.LeaveSetupId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@LeaveTypeName", _hr_LeaveTypeSetup.LeaveTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@GradeId", _hr_LeaveTypeSetup.GradeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsCompensatory", _hr_LeaveTypeSetup.IsCompensatory, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CompensateWith", _hr_LeaveTypeSetup.CompensateWith, DbType.String, ParameterDirection.Input),
				new Parameters("@CompensateDaysPerHoliday", _hr_LeaveTypeSetup.CompensateDaysPerHoliday, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OTHoursPerCompenasateDay", _hr_LeaveTypeSetup.OTHoursPerCompenasateDay, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@IsByYearly", _hr_LeaveTypeSetup.IsByYearly, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@NoOfDaysYearly", _hr_LeaveTypeSetup.NoOfDaysYearly, DbType.Decimal, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "hr_LeaveTypeSetup_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 leaveSetupId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@LeaveSetupId", leaveSetupId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "hr_LeaveTypeSetup_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 LeaveOpeningBalanceCreate(hr_LeaveOpeningBalance _hr_LeaveOpeningBalance)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                    new Parameters("@LeaveSetupId", _hr_LeaveOpeningBalance.LeaveSetupId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@EmployeeId", _hr_LeaveOpeningBalance.EmployeeId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@OpeningDate", _hr_LeaveOpeningBalance.OpeningDate, DbType.DateTime, ParameterDirection.Input),
                   
                    new Parameters("@OpeningBalance", _hr_LeaveOpeningBalance.OpeningBalance, DbType.Int32, ParameterDirection.Input),
                   
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "hr_LeaveOpeningBalance_Create", colparameters, true);
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
    }
}
