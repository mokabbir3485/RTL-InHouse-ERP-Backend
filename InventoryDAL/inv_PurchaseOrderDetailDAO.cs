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
	public class inv_PurchaseOrderDetailDAO //: IDisposible
	{
		private static volatile inv_PurchaseOrderDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseOrderDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseOrderDetailDAO();
			}
			return instance;
		}
		public static inv_PurchaseOrderDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseOrderDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseOrderDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseOrderDetail> GetAll(Int64? PODetailId = null)
		{
			try
			{
				List<inv_PurchaseOrderDetail> inv_PurchaseOrderDetailLst = new List<inv_PurchaseOrderDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PODetailId", PODetailId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseOrderDetailLst = dbExecutor.FetchData<inv_PurchaseOrderDetail>(CommandType.StoredProcedure, "inv_PurchaseOrderDetail_Get", colparameters);
				return inv_PurchaseOrderDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseOrderDetail> GetByPOId(Int64 POId)
        {
            try
            {
                List<inv_PurchaseOrderDetail> inv_PurchaseOrderDetailLst = new List<inv_PurchaseOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@POId", POId, DbType.Int64, ParameterDirection.Input)
				};
                inv_PurchaseOrderDetailLst = dbExecutor.FetchData<inv_PurchaseOrderDetail>(CommandType.StoredProcedure, "inv_PurchaseOrderDetail_GetByPOId", colparameters);
                return inv_PurchaseOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseOrderDetail _inv_PurchaseOrderDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@POId", _inv_PurchaseOrderDetail.POId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_PurchaseOrderDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@POUnitId", _inv_PurchaseOrderDetail.POUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@POQuantity", _inv_PurchaseOrderDetail.POQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@POUnitPrice", _inv_PurchaseOrderDetail.POUnitPrice, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_PurchaseOrderDetail.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@UnitName", _inv_PurchaseOrderDetail.UnitName, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseOrderDetail_Create", colparameters, true);
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
		public int Update(inv_PurchaseOrderDetail _inv_PurchaseOrderDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@PODetailId", _inv_PurchaseOrderDetail.PODetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@POId", _inv_PurchaseOrderDetail.POId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_PurchaseOrderDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@POUnitId", _inv_PurchaseOrderDetail.POUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@POQuantity", _inv_PurchaseOrderDetail.POQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@POUnitPrice", _inv_PurchaseOrderDetail.POUnitPrice, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_PurchaseOrderDetail.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@UnitName", _inv_PurchaseOrderDetail.UnitName, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrderDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PODetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PODetailId", PODetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrderDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
