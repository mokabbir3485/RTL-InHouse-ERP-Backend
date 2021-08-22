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
	public class ad_DepartmentTypeDAO //: IDisposible
	{
		private static volatile ad_DepartmentTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_DepartmentTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_DepartmentTypeDAO();
			}
			return instance;
		}
		public static ad_DepartmentTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_DepartmentTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_DepartmentTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_DepartmentType> GetAll(Int32? departmentTypeId = null)
		{
			try
			{
				List<ad_DepartmentType> ad_DepartmentTypeLst = new List<ad_DepartmentType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DepartmentTypeId", departmentTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_DepartmentTypeLst = dbExecutor.FetchData<ad_DepartmentType>(CommandType.StoredProcedure, "ad_DepartmentType_Get", colparameters);
				return ad_DepartmentTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_DepartmentType ad_DepartmentType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@DepartmentTypeName", ad_DepartmentType.DepartmentTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_DepartmentType.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_DepartmentType_Create", colparameters, true);
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
		public int Update(ad_DepartmentType ad_DepartmentType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@DepartmentTypeId", ad_DepartmentType.DepartmentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentTypeName", ad_DepartmentType.DepartmentTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsFixed", ad_DepartmentType.IsFixed, DbType.Boolean, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_DepartmentType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 departmentTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DepartmentTypeId", departmentTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_DepartmentType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
