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
	public class ad_AssetNatureDAO //: IDisposible
	{
		private static volatile ad_AssetNatureDAO instance;
		private static readonly object lockObj = new object();
		public static ad_AssetNatureDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_AssetNatureDAO();
			}
			return instance;
		}
		public static ad_AssetNatureDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_AssetNatureDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_AssetNatureDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_AssetNature> GetAll(Int32? assetNatureId = null)
		{
			try
			{
				List<ad_AssetNature> ad_AssetNatureLst = new List<ad_AssetNature>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AssetNatureId", assetNatureId, DbType.Int32, ParameterDirection.Input)
				};
				ad_AssetNatureLst = dbExecutor.FetchData<ad_AssetNature>(CommandType.StoredProcedure, "ad_AssetNature_Get", colparameters);
				return ad_AssetNatureLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_AssetNature ad_AssetNature)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@AssetNatureName", ad_AssetNature.AssetNatureName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_AssetNature.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_AssetNature_Create", colparameters, true);
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
		public int Update(ad_AssetNature ad_AssetNature)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@AssetNatureId", ad_AssetNature.AssetNatureId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AssetNatureName", ad_AssetNature.AssetNatureName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_AssetNature.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_AssetNature_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 assetNatureId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AssetNatureId", assetNatureId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_AssetNature_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
