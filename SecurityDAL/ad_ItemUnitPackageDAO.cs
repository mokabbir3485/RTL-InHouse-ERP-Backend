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
	public class ad_ItemUnitPackageDAO //: IDisposible
	{
		private static volatile ad_ItemUnitPackageDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemUnitPackageDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemUnitPackageDAO();
			}
			return instance;
		}
		public static ad_ItemUnitPackageDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemUnitPackageDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemUnitPackageDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ItemUnitPackage> GetAll(Int32? packageId = null)
		{
			try
			{
				List<ad_ItemUnitPackage> ad_ItemUnitPackageLst = new List<ad_ItemUnitPackage>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PackageId", packageId, DbType.Int32, ParameterDirection.Input)
				};
				ad_ItemUnitPackageLst = dbExecutor.FetchData<ad_ItemUnitPackage>(CommandType.StoredProcedure, "ad_ItemUnitPackage_Get", colparameters);
				return ad_ItemUnitPackageLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemUnitPackage ad_ItemUnitPackage)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@PackageName", ad_ItemUnitPackage.PackageName, DbType.String, ParameterDirection.Input),
				new Parameters("@CreatorId", ad_ItemUnitPackage.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", ad_ItemUnitPackage.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_ItemUnitPackage.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_ItemUnitPackage.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemUnitPackage_Create", colparameters, true);
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
		public int Update(ad_ItemUnitPackage ad_ItemUnitPackage)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@PackageId", ad_ItemUnitPackage.PackageId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PackageName", ad_ItemUnitPackage.PackageName, DbType.String, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_ItemUnitPackage.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_ItemUnitPackage.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemUnitPackage_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 packageId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PackageId", packageId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemUnitPackage_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
