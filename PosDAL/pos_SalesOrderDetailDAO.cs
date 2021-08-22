using DbExecutor;
using PosEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace PosDAL
{
    public class pos_SalesOrderDetailDAO //: IDisposible
    {
        private static volatile pos_SalesOrderDetailDAO instance;
        private static readonly object lockObj = new object();
        public static pos_SalesOrderDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new pos_SalesOrderDetailDAO();
            }
            return instance;
        }
        public static pos_SalesOrderDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new pos_SalesOrderDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public pos_SalesOrderDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<pos_SalesOrderDetail> GetBySalesOrderId(Int64 salesOrderId)
        {
            try
            {
                List<pos_SalesOrderDetail> pos_SalesOrderDetailLst = new List<pos_SalesOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SalesOrderId", salesOrderId, DbType.Int64, ParameterDirection.Input)
                };
                pos_SalesOrderDetailLst = dbExecutor.FetchData<pos_SalesOrderDetail>(CommandType.StoredProcedure, "pos_SalesOrderDetail_GetBySalesOrderId", colparameters);
                return pos_SalesOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<pos_SalesOrderDetail> pos_SalesOrderDetailLst = new List<pos_SalesOrderDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                pos_SalesOrderDetailLst = dbExecutor.FetchData<pos_SalesOrderDetail>(CommandType.StoredProcedure, "pos_SalesOrderDetail_GetDynamic", colparameters);
                return pos_SalesOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<pos_SalesOrderDetail> pos_SalesOrderDetailLst = new List<pos_SalesOrderDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                pos_SalesOrderDetailLst = dbExecutor.FetchDataRef<pos_SalesOrderDetail>(CommandType.StoredProcedure, "pos_SalesOrderDetail_GetPaged", colparameters, ref rows);
                return pos_SalesOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[8]{
                new Parameters("@SalesOrderId", _pos_SalesOrderDetail.SalesOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemAddAttId", _pos_SalesOrderDetail.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@OrderUnitId", _pos_SalesOrderDetail.OrderUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@OrderQty", _pos_SalesOrderDetail.OrderQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OrderPrice", _pos_SalesOrderDetail.OrderPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DueDate", _pos_SalesOrderDetail.DueDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@ItemDescription", _pos_SalesOrderDetail.ItemDescription, DbType.String, ParameterDirection.Input),
                new Parameters("@BuyerName", _pos_SalesOrderDetail.BuyerName, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "pos_SalesOrderDetail_Create", colparameters, true);
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
        public int Update(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[7]{
                new Parameters("@SalesOrderDetailId", _pos_SalesOrderDetail.SalesOrderDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SalesOrderId", _pos_SalesOrderDetail.SalesOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemAddAttId", _pos_SalesOrderDetail.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@OrderUnitId", _pos_SalesOrderDetail.OrderUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@OrderQty", _pos_SalesOrderDetail.OrderQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@OrderPrice", _pos_SalesOrderDetail.OrderPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@DueDate", _pos_SalesOrderDetail.DueDate, DbType.DateTime, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalesOrderDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOrderQty(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                new Parameters("@SalesOrderId", _pos_SalesOrderDetail.SalesOrderId, DbType.Int64, ParameterDirection.Input),
                 new Parameters("@SalesOrderDetailId", _pos_SalesOrderDetail.SalesOrderDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemAddAttId", _pos_SalesOrderDetail.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@OrderQty", _pos_SalesOrderDetail.OrderQty, DbType.Decimal, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalesOrderDetail_UpdateOrderQty", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 salesOrderDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SalesOrderDetailId", salesOrderDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalesOrderDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrderDetail> GetInvoiceDetail(Int64 invoiceId)
        {
            try
            {
                List<pos_SalesOrderDetail> pos_SalesOrderDetailLst = new List<pos_SalesOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@InvoiceId", invoiceId, DbType.Int64, ParameterDirection.Input)
                };
                pos_SalesOrderDetailLst = dbExecutor.FetchData<pos_SalesOrderDetail>(CommandType.StoredProcedure, "exp_InvoiceDetail_GetByInvoiceId", colparameters);
                return pos_SalesOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetItemForIWO(Int64 salesOrderId)
        {
            try
            {
                List<pos_SalesOrderDetail> pos_SalesOrderDetailLst = new List<pos_SalesOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SalesOrderId", salesOrderId, DbType.Int64, ParameterDirection.Input)
                };
                pos_SalesOrderDetailLst = dbExecutor.FetchData<pos_SalesOrderDetail>(CommandType.StoredProcedure, "GetItemForIWO", colparameters);
                return pos_SalesOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
