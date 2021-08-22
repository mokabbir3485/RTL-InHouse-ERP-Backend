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
	public class inv_PurchaseOrderDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_PurchaseOrderDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseOrderDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseOrderDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_PurchaseOrderDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseOrderDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseOrderDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseOrderDetailAdAttribute> GetAll(Int64? pODetailAdAttId = null)
		{
			try
			{
				List<inv_PurchaseOrderDetailAdAttribute> inv_PurchaseOrderDetailAdAttributeLst = new List<inv_PurchaseOrderDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PODetailAdAttId", pODetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseOrderDetailAdAttributeLst = dbExecutor.FetchData<inv_PurchaseOrderDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_Get", colparameters);
				return inv_PurchaseOrderDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseOrderDetailAdAttribute> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_PurchaseOrderDetailAdAttribute> inv_PurchaseOrderDetailAdAttributeLst = new List<inv_PurchaseOrderDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseOrderDetailAdAttributeLst = dbExecutor.FetchData<inv_PurchaseOrderDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_GetDynamic", colparameters);
				return inv_PurchaseOrderDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseOrderDetailAdAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_PurchaseOrderDetailAdAttribute> inv_PurchaseOrderDetailAdAttributeLst = new List<inv_PurchaseOrderDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseOrderDetailAdAttributeLst = dbExecutor.FetchDataRef<inv_PurchaseOrderDetailAdAttribute>(CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_GetPaged", colparameters, ref rows);
				return inv_PurchaseOrderDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseOrderDetailAdAttribute _inv_PurchaseOrderDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@PODetailId", _inv_PurchaseOrderDetailAdAttribute.PODetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_PurchaseOrderDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_Create", colparameters, true);
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
		public int Update(inv_PurchaseOrderDetailAdAttribute _inv_PurchaseOrderDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@PODetailAdAttId", _inv_PurchaseOrderDetailAdAttribute.PODetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PODetailId", _inv_PurchaseOrderDetailAdAttribute.PODetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_PurchaseOrderDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 pODetailAdAttId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PODetailAdAttId", pODetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrderDetailAdAttribute_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
