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
	public class ad_ChargeTypeDAO //: IDisposible
	{
		private static volatile ad_ChargeTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ChargeTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ChargeTypeDAO();
			}
			return instance;
		}
		public static ad_ChargeTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ChargeTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ChargeTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ChargeType> GetAll(Int32? ChargeTypeId = null)
		{
			try
			{
				List<ad_ChargeType> ad_ChargeTypeLst = new List<ad_ChargeType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ChargeTypeId", ChargeTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_ChargeTypeLst = dbExecutor.FetchData<ad_ChargeType>(CommandType.StoredProcedure, "ad_ChargeType_Get", colparameters);
				return ad_ChargeTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_ChargeType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_ChargeType> ad_ChargeTypeLst = new List<ad_ChargeType>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_ChargeTypeLst = dbExecutor.FetchData<ad_ChargeType>(CommandType.StoredProcedure, "ad_ChargeType_GetDynamic", colparameters);
				return ad_ChargeTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_ChargeType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_ChargeType> ad_ChargeTypeLst = new List<ad_ChargeType>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_ChargeTypeLst = dbExecutor.FetchDataRef<ad_ChargeType>(CommandType.StoredProcedure, "ad_ChargeType_GetPaged", colparameters, ref rows);
				return ad_ChargeTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ChargeType _ad_ChargeType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@ChargeTypeName", _ad_ChargeType.ChargeTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_ChargeType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_ChargeType.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_ChargeType.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_ChargeType.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_ChargeType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_ChargeType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ChargeType_Create", colparameters, true);
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
		public int Update(ad_ChargeType _ad_ChargeType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@ChargeTypeId", _ad_ChargeType.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeTypeName", _ad_ChargeType.ChargeTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_ChargeType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_ChargeType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_ChargeType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ChargeType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ChargeTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ChargeTypeId", ChargeTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ChargeType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
