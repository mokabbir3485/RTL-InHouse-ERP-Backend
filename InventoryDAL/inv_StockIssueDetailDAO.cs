using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_StockIssueDetailDAO //: IDisposible
    {
        private static volatile inv_StockIssueDetailDAO instance;
        private static readonly object lockObj = new object();
        public static inv_StockIssueDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_StockIssueDetailDAO();
            }
            return instance;
        }
        public static inv_StockIssueDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_StockIssueDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_StockIssueDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_StockIssueDetail> GetByIssueId(Int64 issueId)
        {
            try
            {
                List<inv_StockIssueDetail> inv_StockIssueDetailLst = new List<inv_StockIssueDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@IssueId", issueId, DbType.Int32, ParameterDirection.Input)
                };
                inv_StockIssueDetailLst = dbExecutor.FetchData<inv_StockIssueDetail>(CommandType.StoredProcedure, "inv_StockIssueDetail_GetByIssueId", colparameters);
                return inv_StockIssueDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[7]{
                new Parameters("@IssueId", _inv_StockIssueDetail.IssueId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockIssueDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IssueUnitId", _inv_StockIssueDetail.IssueUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@IssueQuantity", _inv_StockIssueDetail.IssueQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@IssueUnitPrice", _inv_StockIssueDetail.IssueUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockIssueDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@IssueUnitName", _inv_StockIssueDetail.IssueUnitName, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_StockIssueDetail_Create", colparameters, true);
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
        public Int64 AddConsume(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[7]{
                new Parameters("@IssueId", _inv_StockIssueDetail.IssueId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockIssueDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IssueUnitId", _inv_StockIssueDetail.IssueUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@IssueQuantity", _inv_StockIssueDetail.IssueQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@IssueUnitPrice", _inv_StockIssueDetail.IssueUnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_StockIssueDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@IssueUnitName", _inv_StockIssueDetail.IssueUnitName, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_StockIssueDetailConsume_Create", colparameters, true);
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

        public int UpdateApprove(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@IssueId", _inv_StockIssueDetail.IssueId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_StockIssueDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IssueUnitId", _inv_StockIssueDetail.IssueUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@IssueQuantity", _inv_StockIssueDetail.IssueQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@IssueUnitPrice", _inv_StockIssueDetail.IssueUnitPrice, DbType.Decimal, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockIssueDetail_UpdateApprove", colparameters, true);
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
    }
}
