using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using PayableEntity;
using DbExecutor;

namespace PayableDAL
{
	public class pay_SupplierOpeningBalanceDAO //: IDisposible
	{
		private static volatile pay_SupplierOpeningBalanceDAO instance;
		private static readonly object lockObj = new object();
		public static pay_SupplierOpeningBalanceDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pay_SupplierOpeningBalanceDAO();
			}
			return instance;
		}
		public static pay_SupplierOpeningBalanceDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pay_SupplierOpeningBalanceDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pay_SupplierOpeningBalanceDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pay_SupplierOpeningBalance> GetAll(Int64? openingBalanceId = null)
		{
			try
			{
				List<pay_SupplierOpeningBalance> pay_SupplierOpeningBalanceLst = new List<pay_SupplierOpeningBalance>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OpeningBalanceId", openingBalanceId, DbType.Int32, ParameterDirection.Input)
				};
				pay_SupplierOpeningBalanceLst = dbExecutor.FetchData<pay_SupplierOpeningBalance>(CommandType.StoredProcedure, "pay_SupplierOpeningBalance_Get", colparameters);
				return pay_SupplierOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pay_SupplierOpeningBalance> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pay_SupplierOpeningBalance> pay_SupplierOpeningBalanceLst = new List<pay_SupplierOpeningBalance>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pay_SupplierOpeningBalanceLst = dbExecutor.FetchData<pay_SupplierOpeningBalance>(CommandType.StoredProcedure, "pay_SupplierOpeningBalance_GetDynamic", colparameters);
				return pay_SupplierOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pay_SupplierOpeningBalance> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pay_SupplierOpeningBalance> pay_SupplierOpeningBalanceLst = new List<pay_SupplierOpeningBalance>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pay_SupplierOpeningBalanceLst = dbExecutor.FetchDataRef<pay_SupplierOpeningBalance>(CommandType.StoredProcedure, "pay_SupplierOpeningBalance_GetPaged", colparameters, ref rows);
				return pay_SupplierOpeningBalanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pay_SupplierOpeningBalance _pay_SupplierOpeningBalance)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@FinancialCycleId", _pay_SupplierOpeningBalance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SupplierId", _pay_SupplierOpeningBalance.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningDate", _pay_SupplierOpeningBalance.OpeningDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _pay_SupplierOpeningBalance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pay_SupplierOpeningBalance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pay_SupplierOpeningBalance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "pay_SupplierOpeningBalance_Create", colparameters, true);
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
		public int Update(pay_SupplierOpeningBalance _pay_SupplierOpeningBalance)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@OpeningBalanceId", _pay_SupplierOpeningBalance.OpeningBalanceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@FinancialCycleId", _pay_SupplierOpeningBalance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SupplierId", _pay_SupplierOpeningBalance.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningDate", _pay_SupplierOpeningBalance.OpeningDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _pay_SupplierOpeningBalance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pay_SupplierOpeningBalance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pay_SupplierOpeningBalance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pay_SupplierOpeningBalance_Update", colparameters, true);
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
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pay_SupplierOpeningBalance_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
