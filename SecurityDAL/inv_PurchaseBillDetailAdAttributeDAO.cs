using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using InventoryEntity;

namespace InventoryDAL
{
	public class inv_PurchaseBillDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_PurchaseBillDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseBillDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseBillDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_PurchaseBillDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseBillDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseBillDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseBillDetailAdAttribute> GetAll(Int64? pBDetailAdAttId = null)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttribute> inv_PurchaseBillDetailAdAttributeLst = new List<inv_PurchaseBillDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailAdAttId", pBDetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseBillDetailAdAttributeLst = dbExecutor.FetchData<inv_PurchaseBillDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_Get", colparameters);
				return inv_PurchaseBillDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttribute> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttribute> inv_PurchaseBillDetailAdAttributeLst = new List<inv_PurchaseBillDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseBillDetailAdAttributeLst = dbExecutor.FetchData<inv_PurchaseBillDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_GetDynamic", colparameters);
				return inv_PurchaseBillDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttribute> inv_PurchaseBillDetailAdAttributeLst = new List<inv_PurchaseBillDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseBillDetailAdAttributeLst = dbExecutor.FetchDataRef<inv_PurchaseBillDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_GetPaged", colparameters, ref rows);
				return inv_PurchaseBillDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailAdAttribute _inv_PurchaseBillDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@PBDetailId", _inv_PurchaseBillDetailAdAttribute.PBDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_PurchaseBillDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_Create", colparameters, true);
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
		public int Update(inv_PurchaseBillDetailAdAttribute _inv_PurchaseBillDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@PBDetailAdAttId", _inv_PurchaseBillDetailAdAttribute.PBDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PBDetailId", _inv_PurchaseBillDetailAdAttribute.PBDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_PurchaseBillDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 pBDetailAdAttId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailAdAttId", pBDetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttribute_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
