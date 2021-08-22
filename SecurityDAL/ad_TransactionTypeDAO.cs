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
	public class ad_TransactionTypeDAO //: IDisposible
	{
		private static volatile ad_TransactionTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_TransactionTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_TransactionTypeDAO();
			}
			return instance;
		}
		public static ad_TransactionTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_TransactionTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_TransactionTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_TransactionType> GetAll(Int32? transactionTypeId = null)
		{
			try
			{
				List<ad_TransactionType> ad_TransactionTypeLst = new List<ad_TransactionType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@TransactionTypeId", transactionTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_TransactionTypeLst = dbExecutor.FetchData<ad_TransactionType>(CommandType.StoredProcedure, "ad_TransactionType_Get", colparameters);
				return ad_TransactionTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_TransactionType ad_TransactionType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@TransactionTypeName", ad_TransactionType.TransactionTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", ad_TransactionType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", ad_TransactionType.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", ad_TransactionType.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_TransactionType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_TransactionType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_TransactionType_Create", colparameters, true);
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
		public int Update(ad_TransactionType ad_TransactionType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@TransactionTypeId", ad_TransactionType.TransactionTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@TransactionTypeName", ad_TransactionType.TransactionTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", ad_TransactionType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_TransactionType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_TransactionType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_TransactionType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 transactionTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@TransactionTypeId", transactionTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_TransactionType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
