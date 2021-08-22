using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_InternalWorkOrderDetailDAO //: IDisposible
    {
        private static volatile inv_InternalWorkOrderDetailDAO instance;
        private static readonly object lockObj = new object();
        public static inv_InternalWorkOrderDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_InternalWorkOrderDetailDAO();
            }
            return instance;
        }
        public static inv_InternalWorkOrderDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_InternalWorkOrderDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_InternalWorkOrderDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderId(Int64 internalWorkOrderId)
        {
            try
            {
                List<inv_InternalWorkOrderDetail> inv_InternalWorkOrderDetailLst = new List<inv_InternalWorkOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@InternalWorkOrderId", internalWorkOrderId, DbType.Int64, ParameterDirection.Input)
                };
                inv_InternalWorkOrderDetailLst = dbExecutor.FetchData<inv_InternalWorkOrderDetail>(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_GetByInternalWorkOrderId", colparameters);
                return inv_InternalWorkOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderIdForProduction(Int64 internalWorkOrderId)
        {
            try
            {
                List<inv_InternalWorkOrderDetail> inv_InternalWorkOrderDetailLst = new List<inv_InternalWorkOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@InternalWorkOrderId", internalWorkOrderId, DbType.Int64, ParameterDirection.Input)
                };
                inv_InternalWorkOrderDetailLst = dbExecutor.FetchData<inv_InternalWorkOrderDetail>(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_GetByInternalWorkOrderId_ForProduction", colparameters);
                return inv_InternalWorkOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderIdForRequisition(Int64 internalWorkOrderId)
        {
            try
            {
                List<inv_InternalWorkOrderDetail> inv_InternalWorkOrderDetailLst = new List<inv_InternalWorkOrderDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@InternalWorkOrderId", internalWorkOrderId, DbType.Int64, ParameterDirection.Input)
                };
                inv_InternalWorkOrderDetailLst = dbExecutor.FetchData<inv_InternalWorkOrderDetail>(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_GetByInternalWorkOrderId_ForRequisition", colparameters);
                return inv_InternalWorkOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_InternalWorkOrderDetail> inv_InternalWorkOrderDetailLst = new List<inv_InternalWorkOrderDetail>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_InternalWorkOrderDetailLst = dbExecutor.FetchData<inv_InternalWorkOrderDetail>(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_GetDynamic", colparameters);
                return inv_InternalWorkOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_InternalWorkOrderDetail> inv_InternalWorkOrderDetailLst = new List<inv_InternalWorkOrderDetail>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_InternalWorkOrderDetailLst = dbExecutor.FetchDataRef<inv_InternalWorkOrderDetail>(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_GetPaged", colparameters, ref rows);
                return inv_InternalWorkOrderDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_InternalWorkOrderDetail _inv_InternalWorkOrderDetail)
        {
            Int64 ret = 0;
            try
            {

                Parameters[] colparameters = new Parameters[14]{

                new Parameters("@InternalWorkOrderId", _inv_InternalWorkOrderDetail.InternalWorkOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@FinishedItemId", _inv_InternalWorkOrderDetail.FinishedItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_InternalWorkOrderDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@Core", _inv_InternalWorkOrderDetail.Core, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@QtyPerRoll", _inv_InternalWorkOrderDetail.QtyPerRoll, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RollDirection", _inv_InternalWorkOrderDetail.RollDirection, DbType.String, ParameterDirection.Input),
                new Parameters("@DeliveryDate", _inv_InternalWorkOrderDetail.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@IsFullDelivery", _inv_InternalWorkOrderDetail.IsFullDelivery, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@DetailRemarks", _inv_InternalWorkOrderDetail.DetailRemarks, DbType.String, ParameterDirection.Input),

                new Parameters("@SalesOrderDetailId",_inv_InternalWorkOrderDetail.SalesOrderDetailId , DbType.Int64, ParameterDirection.Input),
                new Parameters("@Ups", _inv_InternalWorkOrderDetail.Ups, DbType.String, ParameterDirection.Input),
                new Parameters("@Radius", _inv_InternalWorkOrderDetail.Radius, DbType.String, ParameterDirection.Input),

               
                new Parameters("@Color", _inv_InternalWorkOrderDetail.Color, DbType.String, ParameterDirection.Input),
                new Parameters("@ArtWork", _inv_InternalWorkOrderDetail.ArtWork, DbType.String, ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_Create", colparameters, true);
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
        public int Update(inv_InternalWorkOrderDetail _inv_InternalWorkOrderDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[15]{
                new Parameters("@InternalWorkOrderId ", _inv_InternalWorkOrderDetail.InternalWorkOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@InternalWorkOrderDetailId", _inv_InternalWorkOrderDetail.InternalWorkOrderDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_InternalWorkOrderDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@FinishedItemId", _inv_InternalWorkOrderDetail.FinishedItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@Core", _inv_InternalWorkOrderDetail.Core, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@QtyPerRoll", _inv_InternalWorkOrderDetail.QtyPerRoll, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RollDirection", _inv_InternalWorkOrderDetail.RollDirection, DbType.String, ParameterDirection.Input),
                new Parameters("@DeliveryDate", _inv_InternalWorkOrderDetail.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@IsFullDelivery", _inv_InternalWorkOrderDetail.IsFullDelivery, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@DetailRemarks", _inv_InternalWorkOrderDetail.DetailRemarks, DbType.String, ParameterDirection.Input),
                new Parameters("@Color ", _inv_InternalWorkOrderDetail.Color , DbType.String, ParameterDirection.Input),
                new Parameters("@Ups  ", _inv_InternalWorkOrderDetail.Ups, DbType.String, ParameterDirection.Input),
                new Parameters("@Radius ", _inv_InternalWorkOrderDetail.Radius , DbType.String, ParameterDirection.Input),
                new Parameters("@ArtWork ", _inv_InternalWorkOrderDetail.ArtWork, DbType.String, ParameterDirection.Input),
               
                new Parameters("@SalesOrderDetailId ", _inv_InternalWorkOrderDetail.SalesOrderDetailId, DbType.Int64, ParameterDirection.Input),
               
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 internalWorkOrderDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@InternalWorkOrderDetailId", internalWorkOrderDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_InternalWorkOrderDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
