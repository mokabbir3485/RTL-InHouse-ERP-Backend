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
	public class s_PermissionDAO //: IDisposible
	{
		private static volatile s_PermissionDAO instance;
		private static readonly object lockObj = new object();
		public static s_PermissionDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new s_PermissionDAO();
			}
			return instance;
		}
		public static s_PermissionDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new s_PermissionDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public s_PermissionDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<s_Permission> GetByRoleId(Int64 RoleId)
		{
			try
			{
				List<s_Permission> s_PermissionLst = new List<s_Permission>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@RoleId", RoleId, DbType.Int32, ParameterDirection.Input)
				};
                s_PermissionLst = dbExecutor.FetchData<s_Permission>(CommandType.StoredProcedure, "s_Permission_GetByRoleId", colparameters);
				return s_PermissionLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(s_Permission s_Permission)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@RoleId", s_Permission.RoleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ScreenId", s_Permission.ScreenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CanView", s_Permission.CanView, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", s_Permission.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", s_Permission.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", s_Permission.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", s_Permission.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "s_Permission_Create", colparameters, true);
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
		public int Update(s_Permission s_Permission)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@PermissionId", s_Permission.PermissionId, DbType.String, ParameterDirection.Input),
				new Parameters("@RoleId", s_Permission.RoleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ScreenId", s_Permission.ScreenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CanView", s_Permission.CanView, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", s_Permission.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", s_Permission.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "s_Permission_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int DeleteByRoleId(Int64 RoleId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@RoleId", RoleId, DbType.Int32, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "s_Permission_DeleteByRoleId", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
