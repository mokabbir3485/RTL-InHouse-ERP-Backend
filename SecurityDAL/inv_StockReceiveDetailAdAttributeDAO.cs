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
	public class inv_StockReceiveDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_StockReceiveDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockReceiveDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockReceiveDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_StockReceiveDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockReceiveDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockReceiveDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_StockReceiveDetailAdAttribute> GetAll(Int64? sRDetailAdAttId = null)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttribute> inv_StockReceiveDetailAdAttributeLst = new List<inv_StockReceiveDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SRDetailAdAttId", sRDetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				inv_StockReceiveDetailAdAttributeLst = dbExecutor.FetchData<inv_StockReceiveDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_Get", colparameters);
				return inv_StockReceiveDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttribute> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttribute> inv_StockReceiveDetailAdAttributeLst = new List<inv_StockReceiveDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_StockReceiveDetailAdAttributeLst = dbExecutor.FetchData<inv_StockReceiveDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_GetDynamic", colparameters);
				return inv_StockReceiveDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttribute> inv_StockReceiveDetailAdAttributeLst = new List<inv_StockReceiveDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_StockReceiveDetailAdAttributeLst = dbExecutor.FetchDataRef<inv_StockReceiveDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_GetPaged", colparameters, ref rows);
				return inv_StockReceiveDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockReceiveDetailAdAttribute _inv_StockReceiveDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@SRDetailId", _inv_StockReceiveDetailAdAttribute.SRDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_StockReceiveDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input),
				new Parameters("@IsFree", _inv_StockReceiveDetailAdAttribute.IsFree, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_Create", colparameters, true);
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
		public int Update(inv_StockReceiveDetailAdAttribute _inv_StockReceiveDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@SRDetailAdAttId", _inv_StockReceiveDetailAdAttribute.SRDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@SRDetailId", _inv_StockReceiveDetailAdAttribute.SRDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_StockReceiveDetailAdAttribute.AttributeQty, DbType., ParameterDirection.Input),
				new Parameters("@IsFree", _inv_StockReceiveDetailAdAttribute.IsFree, DbType.Boolean, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 sRDetailAdAttId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SRDetailAdAttId", sRDetailAdAttId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttribute_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
