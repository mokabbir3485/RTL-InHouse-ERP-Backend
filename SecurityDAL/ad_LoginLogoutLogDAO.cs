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
	public class ad_LoginLogoutLogDAO //: IDisposible
	{
		private static volatile ad_LoginLogoutLogDAO instance;
		private static readonly object lockObj = new object();
		public static ad_LoginLogoutLogDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_LoginLogoutLogDAO();
			}
			return instance;
		}
		public static ad_LoginLogoutLogDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_LoginLogoutLogDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_LoginLogoutLogDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_LoginLogoutLog> GetByUserId(Int32 UserId)
		{
			try
			{
				List<ad_LoginLogoutLog> ad_LoginLogoutLogLst = new List<ad_LoginLogoutLog>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@UserId", UserId, DbType.Int32, ParameterDirection.Input)
				};
                ad_LoginLogoutLogLst = dbExecutor.FetchData<ad_LoginLogoutLog>(CommandType.StoredProcedure, "ad_LoginLogoutLog_GetByUserId", colparameters);
				return ad_LoginLogoutLogLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_LoginLogoutLog ad_LoginLogoutLog)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@UserId", ad_LoginLogoutLog.UserId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@LogInTime", ad_LoginLogoutLog.LogInTime, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@IpAddress", ad_LoginLogoutLog.IpAddress, DbType.String, ParameterDirection.Input),
				new Parameters("@IsLoggedIn", ad_LoginLogoutLog.IsLoggedIn, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_LoginLogoutLog_Create", colparameters, true);
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
		public int UpdateLogout(ad_LoginLogoutLog ad_LoginLogoutLog)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@UserId", ad_LoginLogoutLog.UserId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@LogOutTime", ad_LoginLogoutLog.LogOutTime, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@IsLoggedIn", ad_LoginLogoutLog.IsLoggedIn, DbType.Boolean, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_LoginLogoutLog_UpdateLogout", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
