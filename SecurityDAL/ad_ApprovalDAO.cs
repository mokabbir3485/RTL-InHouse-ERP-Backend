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
	public class ad_ApprovalDAO //: IDisposible
	{
		private static volatile ad_ApprovalDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ApprovalDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ApprovalDAO();
			}
			return instance;
		}
		public static ad_ApprovalDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ApprovalDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ApprovalDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_Approval> GetAll(Int32? approvalId = null)
		{
			try
			{
				List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ApprovalId", approvalId, DbType.Int32, ParameterDirection.Input)
				};
				ad_ApprovalLst = dbExecutor.FetchData<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_Get", colparameters);
				return ad_ApprovalLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Approval> GetForApproval(Int32? moduleId = null)
        {
            try
            {
                List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ModuleId", moduleId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ApprovalLst = dbExecutor.FetchData<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_GetForApproval", colparameters);
                return ad_ApprovalLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Approval> GetByScreenId(Int32 screenId)
        {
            try
            {
                List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ScreenId", screenId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ApprovalLst = dbExecutor.FetchData<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_GetByScreenId", colparameters);
                return ad_ApprovalLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Approval> GetApprovedInventoryScreen()
        {
            try
            {
                List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
                ad_ApprovalLst = dbExecutor.FetchData<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_GetApprovedInventoryScreen");
                return ad_ApprovalLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Approval> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_ApprovalLst = dbExecutor.FetchData<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_GetDynamic", colparameters);
				return ad_ApprovalLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Approval> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_Approval> ad_ApprovalLst = new List<ad_Approval>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_ApprovalLst = dbExecutor.FetchDataRef<ad_Approval>(CommandType.StoredProcedure, "ad_Approval_GetPaged", colparameters, ref rows);
				return ad_ApprovalLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Approval _ad_Approval)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@ScreenId", _ad_Approval.ScreenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsRequired", _ad_Approval.IsRequired, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_Approval.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_Approval.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Approval.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Approval.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_Approval_Create", colparameters, true);
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
		public int Update(ad_Approval _ad_Approval)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@ApprovalId", _ad_Approval.ApprovalId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ScreenId", _ad_Approval.ScreenId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsRequired", _ad_Approval.IsRequired, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Approval.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Approval.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Approval_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 approvalId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ApprovalId", approvalId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Approval_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
