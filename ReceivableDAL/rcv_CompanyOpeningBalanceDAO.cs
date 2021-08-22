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
	public class rcv_CompanyOpeningBalanceDAO //: IDisposible
	{
		private static volatile rcv_CompanyOpeningBalanceDAO instance;
		private static readonly object lockObj = new object();
		public static rcv_CompanyOpeningBalanceDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new rcv_CompanyOpeningBalanceDAO();
			}
			return instance;
		}
		public static rcv_CompanyOpeningBalanceDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new rcv_CompanyOpeningBalanceDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public rcv_CompanyOpeningBalanceDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<rcv_CompanyOpeningBalance> GetAll(Int64? openingBalanceId = null)
		{
			try
			{
				List<rcv_CompanyOpeningBalance> rcv_CompanyOpeningBalanceLst = new List<rcv_CompanyOpeningBalance>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OpeningBalanceId", openingBalanceId, DbType.Int32, ParameterDirection.Input)
				};
				rcv_CompanyOpeningBalanceLst = dbExecutor.FetchData<rcv_CompanyOpeningBalance>(CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_Get", colparameters);
				return rcv_CompanyOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyOpeningBalance> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<rcv_CompanyOpeningBalance> rcv_CompanyOpeningBalanceLst = new List<rcv_CompanyOpeningBalance>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				rcv_CompanyOpeningBalanceLst = dbExecutor.FetchData<rcv_CompanyOpeningBalance>(CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_GetDynamic", colparameters);
				return rcv_CompanyOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyOpeningBalance> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<rcv_CompanyOpeningBalance> rcv_CompanyOpeningBalanceLst = new List<rcv_CompanyOpeningBalance>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				rcv_CompanyOpeningBalanceLst = dbExecutor.FetchDataRef<rcv_CompanyOpeningBalance>(CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_GetPaged", colparameters, ref rows);
				return rcv_CompanyOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(rcv_CompanyOpeningBalance _rcv_CompanyOpeningBalance)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@FinancialCycleId", _rcv_CompanyOpeningBalance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CompanyId", _rcv_CompanyOpeningBalance.CompanyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningDate", _rcv_CompanyOpeningBalance.OpeningDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _rcv_CompanyOpeningBalance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _rcv_CompanyOpeningBalance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _rcv_CompanyOpeningBalance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_Create", colparameters, true);
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
		public int Update(rcv_CompanyOpeningBalance _rcv_CompanyOpeningBalance)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@OpeningBalanceId", _rcv_CompanyOpeningBalance.OpeningBalanceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@FinancialCycleId", _rcv_CompanyOpeningBalance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CompanyId", _rcv_CompanyOpeningBalance.CompanyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningDate", _rcv_CompanyOpeningBalance.OpeningDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _rcv_CompanyOpeningBalance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _rcv_CompanyOpeningBalance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _rcv_CompanyOpeningBalance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 openingBalanceId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OpeningBalanceId", openingBalanceId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "rcv_CompanyOpeningBalance_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
