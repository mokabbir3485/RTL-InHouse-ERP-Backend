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
	public class ad_CustomerTypeDAO //: IDisposible
	{
		private static volatile ad_CustomerTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CustomerTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CustomerTypeDAO();
			}
			return instance;
		}
		public static ad_CustomerTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CustomerTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CustomerTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_CustomerType> GetAll(Int32? customerTypeId = null)
		{
			try
			{
				List<ad_CustomerType> ad_CustomerTypeLst = new List<ad_CustomerType>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerTypeId", customerTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ad_CustomerTypeLst = dbExecutor.FetchData<ad_CustomerType>(CommandType.StoredProcedure, "ad_CustomerType_Get", colparameters);
				return ad_CustomerTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_CustomerType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_CustomerType> ad_CustomerTypeLst = new List<ad_CustomerType>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_CustomerTypeLst = dbExecutor.FetchData<ad_CustomerType>(CommandType.StoredProcedure, "ad_CustomerType_GetDynamic", colparameters);
				return ad_CustomerTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_CustomerType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_CustomerType> ad_CustomerTypeLst = new List<ad_CustomerType>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_CustomerTypeLst = dbExecutor.FetchDataRef<ad_CustomerType>(CommandType.StoredProcedure, "ad_CustomerType_GetPaged", colparameters, ref rows);
				return ad_CustomerTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CustomerType _ad_CustomerType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[12]{
				new Parameters("@CustomerTypeName", _ad_CustomerType.CustomerTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsCommissionApplicable", _ad_CustomerType.IsCommissionApplicable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CommissionPercentage", _ad_CustomerType.CommissionPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsPointApplicable", _ad_CustomerType.IsPointApplicable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@SinglePointForAmount", _ad_CustomerType.SinglePointForAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CouponPercentage", _ad_CustomerType.CouponPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@NonCouponPercentage", _ad_CustomerType.NonCouponPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_CustomerType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_CustomerType.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_CustomerType.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_CustomerType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_CustomerType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_CustomerType_Create", colparameters, true);
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
		public int Update(ad_CustomerType _ad_CustomerType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[11]{
				new Parameters("@CustomerTypeId", _ad_CustomerType.CustomerTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CustomerTypeName", _ad_CustomerType.CustomerTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsCommissionApplicable", _ad_CustomerType.IsCommissionApplicable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CommissionPercentage", _ad_CustomerType.CommissionPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@IsPointApplicable", _ad_CustomerType.IsPointApplicable, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@SinglePointForAmount", _ad_CustomerType.SinglePointForAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CouponPercentage", _ad_CustomerType.CouponPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@NonCouponPercentage", _ad_CustomerType.NonCouponPercentage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@IsActive", _ad_CustomerType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_CustomerType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_CustomerType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_CustomerType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 customerTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerTypeId", customerTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_CustomerType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
