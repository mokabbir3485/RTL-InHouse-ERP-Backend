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
	public class inv_StockReceiveDetailAdAttributeDetailDAO //: IDisposible
	{
		private static volatile inv_StockReceiveDetailAdAttributeDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockReceiveDetailAdAttributeDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockReceiveDetailAdAttributeDetailDAO();
			}
			return instance;
		}
		public static inv_StockReceiveDetailAdAttributeDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockReceiveDetailAdAttributeDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockReceiveDetailAdAttributeDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_StockReceiveDetailAdAttributeDetail> GetAll(Int64? sRDetailAdAttDetailId = null,Int64? sRDetailAdAttId = null)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttributeDetail> inv_StockReceiveDetailAdAttributeDetailLst = new List<inv_StockReceiveDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SRDetailAdAttDetailId", sRDetailAdAttDetailId, DbType.Int32, ParameterDirection.Input)
				};
				inv_StockReceiveDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_StockReceiveDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_Get", colparameters);
				return inv_StockReceiveDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttributeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttributeDetail> inv_StockReceiveDetailAdAttributeDetailLst = new List<inv_StockReceiveDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_StockReceiveDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_StockReceiveDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_GetDynamic", colparameters);
				return inv_StockReceiveDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttributeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_StockReceiveDetailAdAttributeDetail> inv_StockReceiveDetailAdAttributeDetailLst = new List<inv_StockReceiveDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_StockReceiveDetailAdAttributeDetailLst = dbExecutor.FetchDataRef<inv_StockReceiveDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_GetPaged", colparameters, ref rows);
				return inv_StockReceiveDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockReceiveDetailAdAttributeDetail _inv_StockReceiveDetailAdAttributeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@SRDetailAdAttId", _inv_StockReceiveDetailAdAttributeDetail.SRDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_StockReceiveDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_StockReceiveDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_Create", colparameters, true);
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
		public int Update(inv_StockReceiveDetailAdAttributeDetail _inv_StockReceiveDetailAdAttributeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@SRDetailAdAttDetailId", _inv_StockReceiveDetailAdAttributeDetail.SRDetailAdAttDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@SRDetailAdAttId", _inv_StockReceiveDetailAdAttributeDetail.SRDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_StockReceiveDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_StockReceiveDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 sRDetailAdAttDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SRDetailAdAttDetailId", sRDetailAdAttDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetailAdAttributeDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
