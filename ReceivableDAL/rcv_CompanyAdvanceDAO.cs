using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using ReceivableEntity;
using DbExecutor;

namespace ReceivableDAL
{
	public class rcv_CompanyAdvanceDAO //: IDisposible
	{
		private static volatile rcv_CompanyAdvanceDAO instance;
		private static readonly object lockObj = new object();
		public static rcv_CompanyAdvanceDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new rcv_CompanyAdvanceDAO();
			}
			return instance;
		}
		public static rcv_CompanyAdvanceDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new rcv_CompanyAdvanceDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public rcv_CompanyAdvanceDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<rcv_CompanyAdvance> GetAll(Int64? advanceId = null)
		{
			try
			{
				List<rcv_CompanyAdvance> rcv_CompanyAdvanceLst = new List<rcv_CompanyAdvance>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AdvanceId", advanceId, DbType.Int32, ParameterDirection.Input)
				};
				rcv_CompanyAdvanceLst = dbExecutor.FetchData<rcv_CompanyAdvance>(CommandType.StoredProcedure, "rcv_CompanyAdvance_Get", colparameters);
				return rcv_CompanyAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyAdvance> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<rcv_CompanyAdvance> rcv_CompanyAdvanceLst = new List<rcv_CompanyAdvance>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				rcv_CompanyAdvanceLst = dbExecutor.FetchData<rcv_CompanyAdvance>(CommandType.StoredProcedure, "rcv_CompanyAdvance_GetDynamic", colparameters);
				return rcv_CompanyAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyAdvance> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<rcv_CompanyAdvance> rcv_CompanyAdvanceLst = new List<rcv_CompanyAdvance>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				rcv_CompanyAdvanceLst = dbExecutor.FetchDataRef<rcv_CompanyAdvance>(CommandType.StoredProcedure, "rcv_CompanyAdvance_GetPaged", colparameters, ref rows);
				return rcv_CompanyAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(rcv_CompanyAdvance _rcv_CompanyAdvance)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@FinancialCycleId", _rcv_CompanyAdvance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CompanyId", _rcv_CompanyAdvance.CompanyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _rcv_CompanyAdvance.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AdvanceDate", _rcv_CompanyAdvance.AdvanceDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _rcv_CompanyAdvance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@VoucherNo", _rcv_CompanyAdvance.VoucherNo, DbType.String, ParameterDirection.Input),
				new Parameters("@IsOpening", _rcv_CompanyAdvance.IsOpening, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _rcv_CompanyAdvance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _rcv_CompanyAdvance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "rcv_CompanyAdvance_Create", colparameters, true);
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
		public int Update(rcv_CompanyAdvance _rcv_CompanyAdvance)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[10]{
				new Parameters("@AdvanceId", _rcv_CompanyAdvance.AdvanceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@FinancialCycleId", _rcv_CompanyAdvance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CompanyId", _rcv_CompanyAdvance.CompanyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _rcv_CompanyAdvance.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AdvanceDate", _rcv_CompanyAdvance.AdvanceDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _rcv_CompanyAdvance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@VoucherNo", _rcv_CompanyAdvance.VoucherNo, DbType.String, ParameterDirection.Input),
				new Parameters("@IsOpening", _rcv_CompanyAdvance.IsOpening, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _rcv_CompanyAdvance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _rcv_CompanyAdvance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "rcv_CompanyAdvance_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 advanceId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AdvanceId", advanceId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "rcv_CompanyAdvance_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable CheckVoucherNoExists(string voucherNo)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@VoucherNo", voucherNo, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "rcv_CheckVoucherNoExists", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
