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
	public class inv_PurchaseOrderDAO //: IDisposible
	{
		private static volatile inv_PurchaseOrderDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseOrderDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseOrderDAO();
			}
			return instance;
		}
		public static inv_PurchaseOrderDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseOrderDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseOrderDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseOrder> GetAll(Int64? pOId = null)
		{
			try
			{
				List<inv_PurchaseOrder> inv_PurchaseOrderLst = new List<inv_PurchaseOrder>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@POId", pOId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseOrderLst = dbExecutor.FetchData<inv_PurchaseOrder>(CommandType.StoredProcedure, "inv_PurchaseOrder_Get", colparameters);
				return inv_PurchaseOrderLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseOrder> GetTopForPurchaseBill(int topQty)
        {
            try
            {
                List<inv_PurchaseOrder> inv_PurchaseOrderLst = new List<inv_PurchaseOrder>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
				};
                inv_PurchaseOrderLst = dbExecutor.FetchData<inv_PurchaseOrder>(CommandType.StoredProcedure, "inv_PurchaseOrder_GetTopForPurchaseBill", colparameters);
                return inv_PurchaseOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseOrder _inv_PurchaseOrder)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[16]{
				new Parameters("@PONo", _inv_PurchaseOrder.PONo, DbType.String, ParameterDirection.Input),
				new Parameters("@PODate", _inv_PurchaseOrder.PODate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@SupplierId", _inv_PurchaseOrder.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PreparedById", _inv_PurchaseOrder.PreparedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ShipmentInfo", _inv_PurchaseOrder.ShipmentInfo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryDate", _inv_PurchaseOrder.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _inv_PurchaseOrder.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Remarks", _inv_PurchaseOrder.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@CreatorId", _inv_PurchaseOrder.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _inv_PurchaseOrder.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_PurchaseOrder.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_PurchaseOrder.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@PreparedBy", _inv_PurchaseOrder.PreparedBy, DbType.String, ParameterDirection.Input),
				new Parameters("@SupplierName", _inv_PurchaseOrder.SupplierName, DbType.String, ParameterDirection.Input),
				new Parameters("@PriceTypeName", _inv_PurchaseOrder.PriceTypeName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_PurchaseOrder.IsApproved, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseOrder_Create", colparameters, true);
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
		public int Update(inv_PurchaseOrder _inv_PurchaseOrder)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[14]{
				new Parameters("@POId", _inv_PurchaseOrder.POId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PONo", _inv_PurchaseOrder.PONo, DbType.String, ParameterDirection.Input),
				new Parameters("@PODate", _inv_PurchaseOrder.PODate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@SupplierId", _inv_PurchaseOrder.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PreparedById", _inv_PurchaseOrder.PreparedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ShipmentInfo", _inv_PurchaseOrder.ShipmentInfo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryDate", _inv_PurchaseOrder.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _inv_PurchaseOrder.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Remarks", _inv_PurchaseOrder.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_PurchaseOrder.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_PurchaseOrder.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@PreparedBy", _inv_PurchaseOrder.PreparedBy, DbType.String, ParameterDirection.Input),
				new Parameters("@SupplierName", _inv_PurchaseOrder.SupplierName, DbType.String, ParameterDirection.Input),
				new Parameters("@PriceTypeName", _inv_PurchaseOrder.PriceTypeName, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrder_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateApprove(inv_PurchaseOrder _inv_PurchaseOrder)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@POId", _inv_PurchaseOrder.POId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_PurchaseOrder.IsApproved, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@ApprovedBy", _inv_PurchaseOrder.ApprovedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApprovedDate", _inv_PurchaseOrder.ApprovedDate, DbType.DateTime, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseOrder_UpdateApprove", colparameters, true);
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
        public int Delete(Int64 pOId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@POId", pOId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseOrder_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
