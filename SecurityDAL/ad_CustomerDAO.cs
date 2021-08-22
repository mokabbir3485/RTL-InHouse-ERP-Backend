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
	public class ad_CustomerDAO //: IDisposible
	{
		private static volatile ad_CustomerDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CustomerDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CustomerDAO();
			}
			return instance;
		}
		public static ad_CustomerDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CustomerDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CustomerDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_Customer> GetAll(Int32? CustomerId = null)
		{
			try
			{
				List<ad_Customer> ad_CustomerLst = new List<ad_Customer>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerId", CustomerId, DbType.Int32, ParameterDirection.Input)
				};
				ad_CustomerLst = dbExecutor.FetchData<ad_Customer>(CommandType.StoredProcedure, "ad_Customer_Get", colparameters);
				return ad_CustomerLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Customer> GetAllNonRegistered(Int32? CustomerId = null)
        {
            try
            {
                List<ad_Customer> ad_CustomerLst = new List<ad_Customer>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerId", CustomerId, DbType.Int32, ParameterDirection.Input)
				};
                ad_CustomerLst = dbExecutor.FetchData<ad_Customer>(CommandType.StoredProcedure, "ad_Customer_GetNonRegistered", colparameters);
                return ad_CustomerLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public List<ad_Customer> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_Customer> ad_CustomerLst = new List<ad_Customer>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_CustomerLst = dbExecutor.FetchData<ad_Customer>(CommandType.StoredProcedure, "ad_Customer_GetDynamic", colparameters);
				return ad_CustomerLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Customer> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_Customer> ad_CustomerLst = new List<ad_Customer>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_CustomerLst = dbExecutor.FetchDataRef<ad_Customer>(CommandType.StoredProcedure, "ad_Customer_GetPaged", colparameters, ref rows);
				return ad_CustomerLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public string Add(ad_Customer _ad_Customer)
		{
            string ret = string.Empty;
			try
			{
				Parameters[] colparameters = new Parameters[17]{
				new Parameters("@CustomerTypeId", _ad_Customer.CustomerTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@BranchId", _ad_Customer.BranchId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ManualCustomerCode", _ad_Customer.ManualCustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@Title", _ad_Customer.Title, DbType.String, ParameterDirection.Input),
				new Parameters("@FirstName", _ad_Customer.FirstName, DbType.String, ParameterDirection.Input),
				new Parameters("@MiddleName", _ad_Customer.MiddleName, DbType.String, ParameterDirection.Input),
				new Parameters("@LastName", _ad_Customer.LastName, DbType.String, ParameterDirection.Input),
				new Parameters("@Gender", _ad_Customer.Gender, DbType.String, ParameterDirection.Input),
				new Parameters("@DateOfBirth", _ad_Customer.DateOfBirth, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Web", _ad_Customer.Web, DbType.String, ParameterDirection.Input),
				new Parameters("@TradingAs", _ad_Customer.TradingAs, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_Customer.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsPayable", _ad_Customer.IsPayable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_Customer.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_Customer.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Customer.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Customer.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalarString(true, CommandType.StoredProcedure, "ad_Customer_Create", colparameters, true);
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
        public int AddNonReg(ad_Customer _ad_Customer, int departmentId)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[17]{
				new Parameters("@CustomerTypeId", _ad_Customer.CustomerTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@BranchId", _ad_Customer.BranchId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Title", _ad_Customer.Title, DbType.String, ParameterDirection.Input),
				new Parameters("@FirstName", _ad_Customer.FirstName, DbType.String, ParameterDirection.Input),
				new Parameters("@MiddleName", _ad_Customer.MiddleName, DbType.String, ParameterDirection.Input),
				new Parameters("@LastName", _ad_Customer.LastName, DbType.String, ParameterDirection.Input),
				new Parameters("@Gender", _ad_Customer.Gender, DbType.String, ParameterDirection.Input),
				new Parameters("@DateOfBirth", _ad_Customer.DateOfBirth, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Web", _ad_Customer.Web, DbType.String, ParameterDirection.Input),
				new Parameters("@TradingAs", _ad_Customer.TradingAs, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_Customer.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsPayable", _ad_Customer.IsPayable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_Customer.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_Customer.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Customer.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Customer.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_Customer_CreateNonReg", colparameters, true);
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
        public string Update(ad_Customer _ad_Customer)
		{
            string ret = string.Empty;
			try
			{
				Parameters[] colparameters = new Parameters[16]{
                new Parameters("@CustomerTypeId", _ad_Customer.CustomerTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@BranchId", _ad_Customer.BranchId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CustomerId", _ad_Customer.CustomerId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ManualCustomerCode", _ad_Customer.ManualCustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@Title", _ad_Customer.Title, DbType.String, ParameterDirection.Input),
				new Parameters("@FirstName", _ad_Customer.FirstName, DbType.String, ParameterDirection.Input),
				new Parameters("@MiddleName", _ad_Customer.MiddleName, DbType.String, ParameterDirection.Input),
				new Parameters("@LastName", _ad_Customer.LastName, DbType.String, ParameterDirection.Input),
				new Parameters("@Gender", _ad_Customer.Gender, DbType.String, ParameterDirection.Input),
				new Parameters("@DateOfBirth", _ad_Customer.DateOfBirth, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Web", _ad_Customer.Web, DbType.String, ParameterDirection.Input),
				new Parameters("@TradingAs", _ad_Customer.TradingAs, DbType.String, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_Customer.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsPayable", _ad_Customer.IsPayable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_Customer.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_Customer.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalarString(true, CommandType.StoredProcedure, "ad_Customer_Update", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 CustomerId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerId", CustomerId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Customer_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
