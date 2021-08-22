using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class pro_ProductionDetailDAO //: IDisposible
    {
        private static volatile pro_ProductionDetailDAO instance;
        private static readonly object lockObj = new object();
        public static pro_ProductionDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new pro_ProductionDetailDAO();
            }
            return instance;
        }
        public static pro_ProductionDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new pro_ProductionDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public pro_ProductionDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<pro_ProductionDetail> GetAll(Int64? productionDetailId = null, Int64? productionId = null)
        {
            try
            {
                List<pro_ProductionDetail> pro_ProductionDetailLst = new List<pro_ProductionDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ProductionDetailId", productionDetailId, DbType.Int32, ParameterDirection.Input)
                };
                pro_ProductionDetailLst = dbExecutor.FetchData<pro_ProductionDetail>(CommandType.StoredProcedure, "pro_ProductionDetail_Get", colparameters);
                return pro_ProductionDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pro_ProductionDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<pro_ProductionDetail> pro_ProductionDetailLst = new List<pro_ProductionDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                pro_ProductionDetailLst = dbExecutor.FetchData<pro_ProductionDetail>(CommandType.StoredProcedure, "pro_ProductionDetail_GetDynamic", colparameters);
                return pro_ProductionDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pro_ProductionDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<pro_ProductionDetail> pro_ProductionDetailLst = new List<pro_ProductionDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                pro_ProductionDetailLst = dbExecutor.FetchDataRef<pro_ProductionDetail>(CommandType.StoredProcedure, "pro_ProductionDetail_GetPaged", colparameters, ref rows);
                return pro_ProductionDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pro_ProductionDetail _pro_ProductionDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@ProductionId", _pro_ProductionDetail.ProductionId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _pro_ProductionDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@UsedRoll", _pro_ProductionDetail.UsedRoll, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ProductionQuantity", _pro_ProductionDetail.ProductionQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@UnitCost", _pro_ProductionDetail.UnitCost, DbType.Decimal, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pro_ProductionDetail_Create", colparameters, true);
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
        public int Update(pro_ProductionDetail _pro_ProductionDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[6]{
                new Parameters("@ProductionDetailId", _pro_ProductionDetail.ProductionDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ProductionId", _pro_ProductionDetail.ProductionId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _pro_ProductionDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@UsedRoll", _pro_ProductionDetail.UsedRoll, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ProductionQuantity", _pro_ProductionDetail.ProductionQuantity, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@UnitCost", _pro_ProductionDetail.UnitCost, DbType.Decimal, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pro_ProductionDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 productionDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ProductionDetailId", productionDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pro_ProductionDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
