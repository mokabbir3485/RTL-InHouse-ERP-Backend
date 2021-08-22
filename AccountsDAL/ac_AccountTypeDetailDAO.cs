using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using AccountsEntity;
using DbExecutor;

namespace AccountsDAL
{
	public class ac_AccountTypeDetailDAO //: IDisposible
	{
		private static volatile ac_AccountTypeDetailDAO instance;
		private static readonly object lockObj = new object();
		public static ac_AccountTypeDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ac_AccountTypeDetailDAO();
			}
			return instance;
		}
		public static ac_AccountTypeDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ac_AccountTypeDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ac_AccountTypeDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ac_AccountTypeDetail> GetAll(Int32? accountTypeDetailId = null)
		{
			try
			{
				List<ac_AccountTypeDetail> ac_AccountTypeDetailLst = new List<ac_AccountTypeDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AccountTypeDetailId", accountTypeDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ac_AccountTypeDetailLst = dbExecutor.FetchData<ac_AccountTypeDetail>(CommandType.StoredProcedure, "ac_AccountTypeDetail_Get", colparameters);
				return ac_AccountTypeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountTypeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ac_AccountTypeDetail> ac_AccountTypeDetailLst = new List<ac_AccountTypeDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ac_AccountTypeDetailLst = dbExecutor.FetchData<ac_AccountTypeDetail>(CommandType.StoredProcedure, "ac_AccountTypeDetail_GetDynamic", colparameters);
				return ac_AccountTypeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountTypeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ac_AccountTypeDetail> ac_AccountTypeDetailLst = new List<ac_AccountTypeDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ac_AccountTypeDetailLst = dbExecutor.FetchDataRef<ac_AccountTypeDetail>(CommandType.StoredProcedure, "ac_AccountTypeDetail_GetPaged", colparameters, ref rows);
				return ac_AccountTypeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ac_AccountTypeDetail _ac_AccountTypeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@AccountTypeId", _ac_AccountTypeDetail.AccountTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AccountTypeDetailName", _ac_AccountTypeDetail.AccountTypeDetailName, DbType.String, ParameterDirection.Input),
				new Parameters("@DetailDisplayName", _ac_AccountTypeDetail.DetailDisplayName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ac_AccountTypeDetail.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ac_AccountTypeDetail.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ac_AccountTypeDetail.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ac_AccountTypeDetail.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ac_AccountTypeDetail_Create", colparameters, true);
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
		public int Update(ac_AccountTypeDetail _ac_AccountTypeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@AccountTypeDetailId", _ac_AccountTypeDetail.AccountTypeDetailId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AccountTypeId", _ac_AccountTypeDetail.AccountTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AccountTypeDetailName", _ac_AccountTypeDetail.AccountTypeDetailName, DbType.String, ParameterDirection.Input),
				new Parameters("@DetailDisplayName", _ac_AccountTypeDetail.DetailDisplayName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ac_AccountTypeDetail.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ac_AccountTypeDetail.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ac_AccountTypeDetail.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ac_AccountTypeDetail.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ac_AccountTypeDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 accountTypeDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AccountTypeDetailId", accountTypeDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ac_AccountTypeDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
