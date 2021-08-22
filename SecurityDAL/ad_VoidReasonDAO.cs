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
	public class ad_VoidReasonDAO : IDisposable
	{
		private static volatile ad_VoidReasonDAO instance;
		private static readonly object lockObj = new object();
		public static ad_VoidReasonDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_VoidReasonDAO();
			}
			return instance;
		}
		public static ad_VoidReasonDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_VoidReasonDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_VoidReasonDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_VoidReason> GetAll(Int32? VoidReasonId = null)
		{
			try
			{
				List<ad_VoidReason> ad_VoidReasonLst = new List<ad_VoidReason>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@VoidReasonId", VoidReasonId, DbType.Int32, ParameterDirection.Input)
				};
				ad_VoidReasonLst = dbExecutor.FetchData<ad_VoidReason>(CommandType.StoredProcedure, "ad_VoidReason_Get", colparameters);
				return ad_VoidReasonLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_VoidReason> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_VoidReason> ad_VoidReasonLst = new List<ad_VoidReason>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_VoidReasonLst = dbExecutor.FetchData<ad_VoidReason>(CommandType.StoredProcedure, "ad_VoidReason_GetDynamic", colparameters);
				return ad_VoidReasonLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_VoidReason> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_VoidReason> ad_VoidReasonLst = new List<ad_VoidReason>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_VoidReasonLst = dbExecutor.FetchDataRef<ad_VoidReason>(CommandType.StoredProcedure, "ad_VoidReason_GetPaged", colparameters, ref rows);
				return ad_VoidReasonLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_VoidReason _ad_VoidReason)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@VoidReasonName", _ad_VoidReason.VoidReasonName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_VoidReason.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_VoidReason.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_VoidReason.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_VoidReason.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_VoidReason.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_VoidReason_Create", colparameters, true);
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
		public int Update(ad_VoidReason _ad_VoidReason)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@VoidReasonId", _ad_VoidReason.VoidReasonId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@VoidReasonName", _ad_VoidReason.VoidReasonName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_VoidReason.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_VoidReason.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_VoidReason.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_VoidReason_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 VoidReasonId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@VoidReasonId", VoidReasonId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_VoidReason_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
