using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_StockReceiveDetailDAO //: IDisposible
    {
        private static volatile inv_StockReceiveDetailDAO instance;
        private static readonly object lockObj = new object();
        public static inv_StockReceiveDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_StockReceiveDetailDAO();
            }
            return instance;
        }
        public static inv_StockReceiveDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_StockReceiveDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_StockReceiveDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_StockReceiveDetail> GetAll(Int64? sRDetailId = null)
        {
            try
            {
                List<inv_StockReceiveDetail> inv_StockReceiveDetailLst = new List<inv_StockReceiveDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SRDetailId", sRDetailId, DbType.Int32, ParameterDirection.Input)
                };
                inv_StockReceiveDetailLst = dbExecutor.FetchData<inv_StockReceiveDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetail_Get", colparameters);
                return inv_StockReceiveDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceiveDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_StockReceiveDetail> inv_StockReceiveDetailLst = new List<inv_StockReceiveDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_StockReceiveDetailLst = dbExecutor.FetchData<inv_StockReceiveDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetail_GetDynamic", colparameters);
                return inv_StockReceiveDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceiveDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_StockReceiveDetail> inv_StockReceiveDetailLst = new List<inv_StockReceiveDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_StockReceiveDetailLst = dbExecutor.FetchDataRef<inv_StockReceiveDetail>(CommandType.StoredProcedure, "inv_StockReceiveDetail_GetPaged", colparameters, ref rows);
                return inv_StockReceiveDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(inv_StockReceiveDetail _inv_StockReceiveDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[10]{
                new Parameters("@SRId", _inv_StockReceiveDetail.SRId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockReceiveDetail.ItemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SRUnitId", _inv_StockReceiveDetail.SRUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SRQuantity", _inv_StockReceiveDetail.SRQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@FreeUnitId", _inv_StockReceiveDetail.FreeUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@FreeQty", _inv_StockReceiveDetail.FreeQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@SRUnitPrice", _inv_StockReceiveDetail.SRUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockReceiveDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@SRUnitName", _inv_StockReceiveDetail.SRUnitName, DbType.String, ParameterDirection.Input),
                new Parameters("@FreeUnitName", _inv_StockReceiveDetail.FreeUnitName, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockReceiveDetail_Create", colparameters, true);
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
        public int Update(inv_StockReceiveDetail _inv_StockReceiveDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[11]{
                new Parameters("@SRDetailId", _inv_StockReceiveDetail.SRDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SRId", _inv_StockReceiveDetail.SRId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockReceiveDetail.ItemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SRUnitId", _inv_StockReceiveDetail.SRUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SRQuantity", _inv_StockReceiveDetail.SRQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@FreeUnitId", _inv_StockReceiveDetail.FreeUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@FreeQty", _inv_StockReceiveDetail.FreeQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@SRUnitPrice", _inv_StockReceiveDetail.SRUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockReceiveDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@SRUnitName", _inv_StockReceiveDetail.SRUnitName, DbType.String, ParameterDirection.Input),
                new Parameters("@FreeUnitName", _inv_StockReceiveDetail.FreeUnitName, DbType.String, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 sRDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SRDetailId", sRDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceiveDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
