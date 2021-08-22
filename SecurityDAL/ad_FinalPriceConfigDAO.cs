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
	public class ad_FinalPriceConfigDAO //: IDisposible
	{
		private static volatile ad_FinalPriceConfigDAO instance;
		private static readonly object lockObj = new object();
		public static ad_FinalPriceConfigDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_FinalPriceConfigDAO();
			}
			return instance;
		}
		public static ad_FinalPriceConfigDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_FinalPriceConfigDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_FinalPriceConfigDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_FinalPriceConfig> GetAll(Int32? ConfigId = null)
		{
			try
			{
				List<ad_FinalPriceConfig> ad_FinalPriceConfigLst = new List<ad_FinalPriceConfig>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConfigId", ConfigId, DbType.Int32, ParameterDirection.Input)
				};
				ad_FinalPriceConfigLst = dbExecutor.FetchData<ad_FinalPriceConfig>(CommandType.StoredProcedure, "ad_FinalPriceConfig_Get", colparameters);
				return ad_FinalPriceConfigLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_FinalPriceConfig> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_FinalPriceConfig> ad_FinalPriceConfigLst = new List<ad_FinalPriceConfig>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_FinalPriceConfigLst = dbExecutor.FetchData<ad_FinalPriceConfig>(CommandType.StoredProcedure, "ad_FinalPriceConfig_GetDynamic", colparameters);
				return ad_FinalPriceConfigLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_FinalPriceConfig> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_FinalPriceConfig> ad_FinalPriceConfigLst = new List<ad_FinalPriceConfig>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_FinalPriceConfigLst = dbExecutor.FetchDataRef<ad_FinalPriceConfig>(CommandType.StoredProcedure, "ad_FinalPriceConfig_GetPaged", colparameters, ref rows);
				return ad_FinalPriceConfigLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_FinalPriceConfig _ad_FinalPriceConfig)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[10]{
				new Parameters("@ConfigCode", _ad_FinalPriceConfig.ConfigCode, DbType.String, ParameterDirection.Input),
				new Parameters("@ConfigName", _ad_FinalPriceConfig.ConfigName, DbType.String, ParameterDirection.Input),
				new Parameters("@TransactionTypeId", _ad_FinalPriceConfig.TransactionTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _ad_FinalPriceConfig.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_FinalPriceConfig.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_FinalPriceConfig.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_FinalPriceConfig.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_FinalPriceConfig.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_FinalPriceConfig.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_FinalPriceConfig.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_FinalPriceConfig_Create", colparameters, true);
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
		public int Update(ad_FinalPriceConfig _ad_FinalPriceConfig)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@ConfigId", _ad_FinalPriceConfig.ConfigId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ConfigCode", _ad_FinalPriceConfig.ConfigCode, DbType.String, ParameterDirection.Input),
				new Parameters("@ConfigName", _ad_FinalPriceConfig.ConfigName, DbType.String, ParameterDirection.Input),
				new Parameters("@TransactionTypeId", _ad_FinalPriceConfig.TransactionTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _ad_FinalPriceConfig.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_FinalPriceConfig.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_FinalPriceConfig.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_FinalPriceConfig.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_FinalPriceConfig.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_FinalPriceConfig_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ConfigId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConfigId", ConfigId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_FinalPriceConfig_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
