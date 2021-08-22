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
	public class ad_AdvancedSearchPropertyDAO //: IDisposible
	{
		private static volatile ad_AdvancedSearchPropertyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_AdvancedSearchPropertyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_AdvancedSearchPropertyDAO();
			}
			return instance;
		}
		public static ad_AdvancedSearchPropertyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_AdvancedSearchPropertyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_AdvancedSearchPropertyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_AdvancedSearchProperty> GetByTableName(String tableName)
		{
			try
			{
                List<ad_AdvancedSearchProperty> ad_AdvancedSearchPropertyLst = new List<ad_AdvancedSearchProperty>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@TableName", tableName, DbType.String, ParameterDirection.Input)
				};
                ad_AdvancedSearchPropertyLst = dbExecutor.FetchData<ad_AdvancedSearchProperty>(CommandType.StoredProcedure, "ad_AdvancedSearch_GetByTableName", colparameters);
                return ad_AdvancedSearchPropertyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_AdvancedSearchProperty> GetColumnNames(int screenId)
        {
            try
            {
                List<ad_AdvancedSearchProperty> ad_AdvancedSearchPropertyLst = new List<ad_AdvancedSearchProperty>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ScreenId", screenId, DbType.Int32, ParameterDirection.Input)
				};
                ad_AdvancedSearchPropertyLst = dbExecutor.FetchData<ad_AdvancedSearchProperty>(CommandType.StoredProcedure, "ad_AdvancedSearch_GetColumnNamesByScreenId", colparameters);
                return ad_AdvancedSearchPropertyLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Search(String tableName, String whereCondition)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@TableName", tableName, DbType.String, ParameterDirection.Input),
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_AdvancedSearch_GetData", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetDetail(int screenId, String pkId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ScreenId", screenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PKId", pkId, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_AdvancedSearch_GetDataDetail", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SearchByScreenId(int screenId, int fromScreenId, String whereCondition)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[3]{
				new Parameters("@ScreenId", screenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FromScreenId", fromScreenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_AdvancedSearch_GetDataByScreenId", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetLastPunch(string branchName)
        {
            string qry = string.Empty;
            if (branchName == "Head Office")
                qry = "SELECT CONVERT(VARCHAR, MAX(CHECKTIME), 21) FROM [Attendance].[dbo].[CHECKINOUT]";
            else if (branchName == "Uttara")
                qry = "SELECT CONVERT(VARCHAR, MAX(CHECKTIME), 21) FROM [Attendance_Uttara].[dbo].[CHECKINOUT]";
            else if (branchName == "Savar")
                qry = "SELECT CONVERT(VARCHAR, MAX(CHECKTIME), 21) FROM [Attendance_Savar].[dbo].[CHECKINOUT]";

            string ret = string.Empty;
            try
            {
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@BranchName", branchName, DbType.String, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalarString(true, CommandType.Text, qry, colparameters, true);
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
	}
}
