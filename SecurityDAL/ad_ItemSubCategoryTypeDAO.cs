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
	public class ad_ItemSubCategoryTypeDAO //: IDisposible
	{
		private static volatile ad_ItemSubCategoryTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemSubCategoryTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemSubCategoryTypeDAO();
			}
			return instance;
		}
		public static ad_ItemSubCategoryTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemSubCategoryTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemSubCategoryTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ItemSubCategoryType> GetAll(Int32? subCategoryTypeId = null)
		{
			try
			{
				List<ad_ItemSubCategoryType> ad_ItemSubCategoryTypeLst = new List<ad_ItemSubCategoryType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SubCategoryTypeId", subCategoryTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_ItemSubCategoryTypeLst = dbExecutor.FetchData<ad_ItemSubCategoryType>(CommandType.StoredProcedure, "ad_ItemSubCategoryType_Get", colparameters);
				return ad_ItemSubCategoryTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemSubCategoryType ad_ItemSubCategoryType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@SubCategoryTypeName", ad_ItemSubCategoryType.SubCategoryTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_ItemSubCategoryType.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemSubCategoryType_Create", colparameters, true);
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
		public int Update(ad_ItemSubCategoryType ad_ItemSubCategoryType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@SubCategoryTypeId", ad_ItemSubCategoryType.SubCategoryTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SubCategoryTypeName", ad_ItemSubCategoryType.SubCategoryTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_ItemSubCategoryType.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemSubCategoryType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 subCategoryTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SubCategoryTypeId", subCategoryTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemSubCategoryType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
