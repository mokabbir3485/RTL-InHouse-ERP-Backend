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
	public class ad_PriceTypeDAO //: IDisposible
	{
		private static volatile ad_PriceTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_PriceTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_PriceTypeDAO();
			}
			return instance;
		}
		public static ad_PriceTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_PriceTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_PriceTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_PriceType> GetAll(Int32? PriceTypeId = null)
		{
			try
			{
				List<ad_PriceType> ad_PriceTypeLst = new List<ad_PriceType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PriceTypeId", PriceTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_PriceTypeLst = dbExecutor.FetchData<ad_PriceType>(CommandType.StoredProcedure, "ad_PriceType_Get", colparameters);
				return ad_PriceTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PriceType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_PriceType> ad_PriceTypeLst = new List<ad_PriceType>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_PriceTypeLst = dbExecutor.FetchData<ad_PriceType>(CommandType.StoredProcedure, "ad_PriceType_GetDynamic", colparameters);
				return ad_PriceTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PriceType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_PriceType> ad_PriceTypeLst = new List<ad_PriceType>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_PriceTypeLst = dbExecutor.FetchDataRef<ad_PriceType>(CommandType.StoredProcedure, "ad_PriceType_GetPaged", colparameters, ref rows);
				return ad_PriceTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_PriceType _ad_PriceType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@PriceTypeName", _ad_PriceType.PriceTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_PriceType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_PriceType.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_PriceType.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_PriceType.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_PriceType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_PriceType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_PriceType_Create", colparameters, true);
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
		public int Update(ad_PriceType _ad_PriceType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@PriceTypeId", _ad_PriceType.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PriceTypeName", _ad_PriceType.PriceTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_PriceType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ad_PriceType.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_PriceType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_PriceType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_PriceType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 PriceTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PriceTypeId", PriceTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_PriceType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
