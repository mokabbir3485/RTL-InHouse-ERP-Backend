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
    public class inv_StockDeliveryDAO //: IDisposible
    {
        private static volatile inv_StockDeliveryDAO instance;
        private static readonly object lockObj = new object();
        public static inv_StockDeliveryDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_StockDeliveryDAO();
            }
            return instance;
        }
        public static inv_StockDeliveryDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_StockDeliveryDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_StockDeliveryDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_StockDelivery> GetAll(Int64? deliveryId = null)
        {
            try
            {
                List<inv_StockDelivery> inv_StockDeliveryLst = new List<inv_StockDelivery>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeliveryId", deliveryId, DbType.Int64, ParameterDirection.Input)
				};
                inv_StockDeliveryLst = dbExecutor.FetchData<inv_StockDelivery>(CommandType.StoredProcedure, "inv_StockDelivery_Get", colparameters);
                return inv_StockDeliveryLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDelivery> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_StockDelivery> inv_StockDeliveryLst = new List<inv_StockDelivery>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
                inv_StockDeliveryLst = dbExecutor.FetchData<inv_StockDelivery>(CommandType.StoredProcedure, "inv_StockDelivery_GetDynamic", colparameters);
                return inv_StockDeliveryLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDelivery> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_StockDelivery> inv_StockDeliveryLst = new List<inv_StockDelivery>();
                Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
                inv_StockDeliveryLst = dbExecutor.FetchDataRef<inv_StockDelivery>(CommandType.StoredProcedure, "inv_StockDelivery_GetPaged", colparameters, ref rows);
                return inv_StockDeliveryLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockDelivery _inv_StockDelivery, ref string savedDeliveryNo)
        {
            Int64 ret = 0;
            try
            {
                //Common aCommon = new Common();

                ////DN/17-18/1, DN/17-18/2, DN/17-18/3, DN/17-18/100, DN/17-18/1001

                //string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(_inv_StockDelivery.DeliveryDate);
                //_inv_StockDelivery.DeliveryNo = "DN/" + aFiscalYearPart + "/" + _inv_StockDelivery.DeliveryNo;

                Parameters[] colparameters = new Parameters[19]{
				new Parameters("@OrderId", _inv_StockDelivery.OrderId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OrderNo", _inv_StockDelivery.OrderNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryNo", _inv_StockDelivery.DeliveryNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryDate", _inv_StockDelivery.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@BillDate", _inv_StockDelivery.BillDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DeliveryFromDepartmentId", _inv_StockDelivery.DeliveryFromDepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeliveryToDepartmentId", _inv_StockDelivery.DeliveryToDepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeliverydById", _inv_StockDelivery.DeliverydById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReceivedById", _inv_StockDelivery.ReceivedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreatorId", _inv_StockDelivery.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _inv_StockDelivery.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockDelivery.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockDelivery.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DeliveryFromDepartmentName", _inv_StockDelivery.DeliveryFromDepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryToDepartmentName", _inv_StockDelivery.DeliveryToDepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliverydBy", _inv_StockDelivery.DeliverydBy, DbType.String, ParameterDirection.Input),
				new Parameters("@ReceivedBy", _inv_StockDelivery.ReceivedBy, DbType.String, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDelivery.IsApproved, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@TotalDeliveryQty", _inv_StockDelivery.TotalDeliveryQty, DbType.Decimal, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64Ref(true, CommandType.StoredProcedure, "inv_StockDelivery_Create", colparameters, true, ref savedDeliveryNo);
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
        public int Update(inv_StockDelivery _inv_StockDelivery)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[17]{
				new Parameters("@DeliveryId", _inv_StockDelivery.DeliveryId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OrderId", _inv_StockDelivery.OrderId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OrderNo", _inv_StockDelivery.OrderNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryNo", _inv_StockDelivery.DeliveryNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryDate", _inv_StockDelivery.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@BillDate", _inv_StockDelivery.BillDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DeliveryFromDepartmentId", _inv_StockDelivery.DeliveryFromDepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeliveryToDepartmentId", _inv_StockDelivery.DeliveryToDepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeliverydById", _inv_StockDelivery.DeliverydById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReceivedById", _inv_StockDelivery.ReceivedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockDelivery.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockDelivery.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DeliveryFromDepartmentName", _inv_StockDelivery.DeliveryFromDepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliveryToDepartmentName", _inv_StockDelivery.DeliveryToDepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeliverydBy", _inv_StockDelivery.DeliverydBy, DbType.String, ParameterDirection.Input),
				new Parameters("@ReceivedBy", _inv_StockDelivery.ReceivedBy, DbType.String, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDelivery.IsApproved, DbType.Boolean, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDelivery_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockDelivery _inv_StockDelivery)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@DeliveryId", _inv_StockDelivery.DeliveryId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDelivery.IsApproved, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@ApprovedBy", _inv_StockDelivery.ApprovedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApprovedDate", _inv_StockDelivery.ApprovedDate, DbType.DateTime, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDelivery_UpdateApprove", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 deliveryId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeliveryId", deliveryId, DbType.Int32, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDelivery_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxDeliveryNo(DateTime deliveryDate)
        {
            try
            {
                Common aCommon = new Common();
                DbExecutor.FiscalYear aFiscalYear = aCommon.GetFiscalFormDateAndToDate(deliveryDate);

                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@fromDate", aFiscalYear.FromDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@toDate", aFiscalYear.ToDate, DbType.DateTime, ParameterDirection.Input)
                };

                Int64 maxDeliveryNo = 0;

                dbExecutor.ManageTransaction(TransactionType.Open);
                maxDeliveryNo = dbExecutor.ExecuteScalar64(true, CommandType.Text, "SELECT DeliveryNo=CAST((ISNULL(MAX(CAST(DeliveryNo AS BIGINT)),0)+1) AS VARCHAR(20)) FROM [inv_StockDeliveryNonSO] WHERE [DeliveryDate] BETWEEN @fromDate AND @toDate", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return maxDeliveryNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxDeliveryId()
        {
            try
            {
                
                Int64 maxDeliveryId = 0;

                dbExecutor.ManageTransaction(TransactionType.Open);
                maxDeliveryId = dbExecutor.ExecuteScalar64(true, CommandType.Text, "SELECT MAX( [DeliveryId] ) AS DeliveryId   FROM [dbo].[inv_StockDelivery]", null, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return maxDeliveryId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
