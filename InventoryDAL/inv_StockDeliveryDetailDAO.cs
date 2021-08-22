using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_StockDeliveryDetailDAO //: IDisposible
    {
        private static volatile inv_StockDeliveryDetailDAO instance;
        private static readonly object lockObj = new object();
        public static inv_StockDeliveryDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_StockDeliveryDetailDAO();
            }
            return instance;
        }
        public static inv_StockDeliveryDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_StockDeliveryDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_StockDeliveryDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_StockDeliveryDetail> GetAll(Int64? deliveryDetailId = null)
        {
            try
            {
                List<inv_StockDeliveryDetail> inv_StockDeliveryDetailLst = new List<inv_StockDeliveryDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DeliveryDetailId", deliveryDetailId, DbType.Int32, ParameterDirection.Input)
                };
                inv_StockDeliveryDetailLst = dbExecutor.FetchData<inv_StockDeliveryDetail>(CommandType.StoredProcedure, "inv_StockDeliveryDetail_Get", colparameters);
                return inv_StockDeliveryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDeliveryDetail> GetByDeliveryId(Int64 deliveryId)
        {
            try
            {
                List<inv_StockDeliveryDetail> inv_StockDeliveryDetailLst = new List<inv_StockDeliveryDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DeliveryId", deliveryId, DbType.Int64, ParameterDirection.Input)
                };
                inv_StockDeliveryDetailLst = dbExecutor.FetchData<inv_StockDeliveryDetail>(CommandType.StoredProcedure, "inv_StockDeliveryDetail_GetByDeliveryId", colparameters);
                return inv_StockDeliveryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDeliveryDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_StockDeliveryDetail> inv_StockDeliveryDetailLst = new List<inv_StockDeliveryDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_StockDeliveryDetailLst = dbExecutor.FetchData<inv_StockDeliveryDetail>(CommandType.StoredProcedure, "inv_StockDeliveryDetail_GetDynamic", colparameters);
                return inv_StockDeliveryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDeliveryDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_StockDeliveryDetail> inv_StockDeliveryDetailLst = new List<inv_StockDeliveryDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_StockDeliveryDetailLst = dbExecutor.FetchDataRef<inv_StockDeliveryDetail>(CommandType.StoredProcedure, "inv_StockDeliveryDetail_GetPaged", colparameters, ref rows);
                return inv_StockDeliveryDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockDeliveryDetail _inv_StockDeliveryDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[9]{
                new Parameters("@DeliveryId", _inv_StockDeliveryDetail.DeliveryId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SalesOrderDetailId", _inv_StockDeliveryDetail.SalesOrderDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockDeliveryDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DeliveryUnitId", _inv_StockDeliveryDetail.DeliveryUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DeliveryQuantity", _inv_StockDeliveryDetail.DeliveryQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeliveryUnitPrice", _inv_StockDeliveryDetail.DeliveryUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockDeliveryDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@DeliveryUnitName", _inv_StockDeliveryDetail.DeliveryUnitName, DbType.String, ParameterDirection.Input),
                new Parameters("@IsLastDelivery", _inv_StockDeliveryDetail.IsLastDelivery, DbType.Boolean, ParameterDirection.Input),
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockDeliveryDetail_Create", colparameters, true);
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
        public int Update(inv_StockDeliveryDetail _inv_StockDeliveryDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[8]{
                new Parameters("@DeliveryDetailId", _inv_StockDeliveryDetail.DeliveryDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DeliveryId", _inv_StockDeliveryDetail.DeliveryId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockDeliveryDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DeliveryUnitId", _inv_StockDeliveryDetail.DeliveryUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DeliveryQuantity", _inv_StockDeliveryDetail.DeliveryQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DeliveryUnitPrice", _inv_StockDeliveryDetail.DeliveryUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockDeliveryDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@DeliveryUnitName", _inv_StockDeliveryDetail.DeliveryUnitName, DbType.String, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDeliveryDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 deliveryDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DeliveryDetailId", deliveryDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDeliveryDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_DeliveryChallan> xRpt_DeliveryGetByDeliveryId(Int64 DeliveryId)
        {
         
            try
            {
                List<inv_DeliveryChallan> ret = new List<inv_DeliveryChallan>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DeliveryId", DeliveryId, DbType.Int64, ParameterDirection.Input)
                };
                ret = dbExecutor.FetchData<inv_DeliveryChallan>(CommandType.StoredProcedure, "xRpt_inv_DeliveryBySalesOrderId", colparameters);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
