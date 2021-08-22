using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;

namespace SecurityDAL
{
	public class ad_CurrencyDAO //: IDisposible
	{
		private static volatile ad_CurrencyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CurrencyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CurrencyDAO();
			}
			return instance;
		}
		public static ad_CurrencyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CurrencyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CurrencyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_Currency> GetAll(Int32? currencyId = null)
		{
			try
			{
				List<ad_Currency> ad_CurrencyLst = new List<ad_Currency>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CurrencyId", currencyId, DbType.Int32, ParameterDirection.Input)
				};
				ad_CurrencyLst = dbExecutor.FetchData<ad_Currency>(CommandType.StoredProcedure, "ad_Currency_Get", colparameters);
				return ad_CurrencyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Currency> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_Currency> ad_CurrencyLst = new List<ad_Currency>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_CurrencyLst = dbExecutor.FetchData<ad_Currency>(CommandType.StoredProcedure, "ad_Currency_GetDynamic", colparameters);
				return ad_CurrencyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Currency> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_Currency> ad_CurrencyLst = new List<ad_Currency>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_CurrencyLst = dbExecutor.FetchDataRef<ad_Currency>(CommandType.StoredProcedure, "ad_Currency_GetPaged", colparameters, ref rows);
				return ad_CurrencyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Currency _ad_Currency)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@CurrencyName", _ad_Currency.CurrencyName, DbType.String, ParameterDirection.Input),
				new Parameters("@CurrencyShort", _ad_Currency.CurrencyShort, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_Currency.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_Currency.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_Currency.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_Currency.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Currency.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Currency.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_Currency_Create", colparameters, true);
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
		public int Update(ad_Currency _ad_Currency)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@CurrencyId", _ad_Currency.CurrencyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CurrencyName", _ad_Currency.CurrencyName, DbType.String, ParameterDirection.Input),
				new Parameters("@CurrencyShort", _ad_Currency.CurrencyShort, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_Currency.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_Currency.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Currency.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Currency.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Currency_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 currencyId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CurrencyId", currencyId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Currency_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
