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
	public class ad_PaymentTypeDAO //: IDisposible
	{
		private static volatile ad_PaymentTypeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_PaymentTypeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_PaymentTypeDAO();
			}
			return instance;
		}
		public static ad_PaymentTypeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_PaymentTypeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_PaymentTypeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_PaymentType> GetAllActive()
		{
			try
			{
				List<ad_PaymentType> ad_PaymentTypeLst = new List<ad_PaymentType>();
				ad_PaymentTypeLst = dbExecutor.FetchData<ad_PaymentType>(CommandType.StoredProcedure, "ad_PaymentType_GetAllActive");
				return ad_PaymentTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_PaymentType> ad_PaymentTypeLst = new List<ad_PaymentType>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_PaymentTypeLst = dbExecutor.FetchData<ad_PaymentType>(CommandType.StoredProcedure, "ad_PaymentType_GetDynamic", colparameters);
				return ad_PaymentTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_PaymentType> ad_PaymentTypeLst = new List<ad_PaymentType>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_PaymentTypeLst = dbExecutor.FetchDataRef<ad_PaymentType>(CommandType.StoredProcedure, "ad_PaymentType_GetPaged", colparameters, ref rows);
				return ad_PaymentTypeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_PaymentType _ad_PaymentType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@PaymentGroupId", _ad_PaymentType.PaymentGroupId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeName", _ad_PaymentType.PaymentTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@CommissionPercent", _ad_PaymentType.CommissionPercent, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_PaymentType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsFixed", _ad_PaymentType.IsFixed, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _ad_PaymentType.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _ad_PaymentType.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_PaymentType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_PaymentType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_PaymentType_Create", colparameters, true);
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
		public int Update(ad_PaymentType _ad_PaymentType)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@PaymentGroupId", _ad_PaymentType.PaymentGroupId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _ad_PaymentType.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeName", _ad_PaymentType.PaymentTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@CommissionPercent", _ad_PaymentType.CommissionPercent, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@IsActive", _ad_PaymentType.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsFixed", _ad_PaymentType.IsFixed, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _ad_PaymentType.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _ad_PaymentType.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_PaymentType_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 paymentTypeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PaymentTypeId", paymentTypeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_PaymentType_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
