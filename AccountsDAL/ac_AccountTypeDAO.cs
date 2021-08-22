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
	public class ac_AccountTypeDAO //: IDisposible
	{
		private static volatile ac_AccountTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ac_AccountTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ac_AccountTypeDAO();
			}
			return instance;
		}
		public static ac_AccountTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ac_AccountTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ac_AccountTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ac_AccountType> GetAll(Int32? accountTypeId = null)
		{
			try
			{
				List<ac_AccountType> ac_AccountTypeLst = new List<ac_AccountType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AccountTypeId", accountTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ac_AccountTypeLst = dbExecutor.FetchData<ac_AccountType>(CommandType.StoredProcedure, "ac_AccountType_Get", colparameters);
				return ac_AccountTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ac_AccountType> ac_AccountTypeLst = new List<ac_AccountType>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ac_AccountTypeLst = dbExecutor.FetchData<ac_AccountType>(CommandType.StoredProcedure, "ac_AccountType_GetDynamic", colparameters);
				return ac_AccountTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ac_AccountType> ac_AccountTypeLst = new List<ac_AccountType>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ac_AccountTypeLst = dbExecutor.FetchDataRef<ac_AccountType>(CommandType.StoredProcedure, "ac_AccountType_GetPaged", colparameters, ref rows);
				return ac_AccountTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ac_AccountType _ac_AccountType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@ClassId", _ac_AccountType.ClassId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AccountTypeName", _ac_AccountType.AccountTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@DisplayName", _ac_AccountType.DisplayName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ac_AccountType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ac_AccountType.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ac_AccountType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ac_AccountType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ac_AccountType_Create", colparameters, true);
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
		public int Update(ac_AccountType _ac_AccountType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@AccountTypeId", _ac_AccountType.AccountTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ClassId", _ac_AccountType.ClassId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AccountTypeName", _ac_AccountType.AccountTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@DisplayName", _ac_AccountType.DisplayName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ac_AccountType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsDefault", _ac_AccountType.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ac_AccountType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ac_AccountType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ac_AccountType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 accountTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AccountTypeId", accountTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ac_AccountType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
