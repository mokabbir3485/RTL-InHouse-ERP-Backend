using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using InventoryEntity;
using DbExecutor;

namespace InventoryDAL
{
	public class inv_PurchaseBillDetailAdAttributeDetailDAO //: IDisposible
	{
		private static volatile inv_PurchaseBillDetailAdAttributeDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseBillDetailAdAttributeDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseBillDetailAdAttributeDetailDAO();
			}
			return instance;
		}
		public static inv_PurchaseBillDetailAdAttributeDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseBillDetailAdAttributeDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseBillDetailAdAttributeDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseBillDetailAdAttributeDetail> GetAll(Int64? pBDetailAdAttDetailId = null,Int64? pBDetailAdAttId = null)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttributeDetail> inv_PurchaseBillDetailAdAttributeDetailLst = new List<inv_PurchaseBillDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailAdAttDetailId", pBDetailAdAttDetailId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseBillDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_PurchaseBillDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_Get", colparameters);
				return inv_PurchaseBillDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public List<inv_PurchaseBillDetailAdAttributeDetail> GetByPBDetailAdAttId(Int64 pBDetailAdAttId)
        {
            try
            {
                List<inv_PurchaseBillDetailAdAttributeDetail> inv_PurchaseBillDetailAdAttributeDetailLst = new List<inv_PurchaseBillDetailAdAttributeDetail>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailAdAttId", pBDetailAdAttId, DbType.Int64, ParameterDirection.Input)
				};
                inv_PurchaseBillDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_PurchaseBillDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_GetByPBDetailAdAttId", colparameters);
                return inv_PurchaseBillDetailAdAttributeDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<inv_PurchaseBillDetailAdAttributeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttributeDetail> inv_PurchaseBillDetailAdAttributeDetailLst = new List<inv_PurchaseBillDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseBillDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_PurchaseBillDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_GetDynamic", colparameters);
				return inv_PurchaseBillDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttributeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_PurchaseBillDetailAdAttributeDetail> inv_PurchaseBillDetailAdAttributeDetailLst = new List<inv_PurchaseBillDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_PurchaseBillDetailAdAttributeDetailLst = dbExecutor.FetchDataRef<inv_PurchaseBillDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_GetPaged", colparameters, ref rows);
				return inv_PurchaseBillDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailAdAttributeDetail _inv_PurchaseBillDetailAdAttributeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@PBDetailAdAttId", _inv_PurchaseBillDetailAdAttributeDetail.PBDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_PurchaseBillDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_PurchaseBillDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_Create", colparameters, true);
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
		public int Update(inv_PurchaseBillDetailAdAttributeDetail _inv_PurchaseBillDetailAdAttributeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@PBDetailAdAttDetailId", _inv_PurchaseBillDetailAdAttributeDetail.PBDetailAdAttDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PBDetailAdAttId", _inv_PurchaseBillDetailAdAttributeDetail.PBDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_PurchaseBillDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_PurchaseBillDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 pBDetailAdAttDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailAdAttDetailId", pBDetailAdAttDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailAdAttributeDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
