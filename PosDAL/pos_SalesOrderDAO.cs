using DbExecutor;
using PosEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace PosDAL
{
    public class pos_SalesOrderDAO //: IDisposable
    {
        private static volatile pos_SalesOrderDAO instance;
        private static readonly object lockObj = new object();
        public static pos_SalesOrderDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new pos_SalesOrderDAO();
            }
            return instance;
        }
        public static pos_SalesOrderDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new pos_SalesOrderDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public pos_SalesOrderDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<pos_SalesOrder> GetAll(Int64? salesOrderId = null)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SalesOrderId", salesOrderId, DbType.Int32, ParameterDirection.Input)
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_Get", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetDynamic", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<pos_SalesOrder> GetForPiUpdate(Int64 InvoiceId, Int32 CompanyId)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@InvoiceId", InvoiceId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@CompanyId", CompanyId, DbType.Int32, ParameterDirection.Input),
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetForPIUpdate", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrder> pos_SalesOrderAmendment_GetForEdit(string approvalType, string approvalPassword)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderList = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@ApprovalType", approvalType, DbType.String, ParameterDirection.Input),
                new Parameters("@ApprovalPassword", approvalPassword, DbType.String, ParameterDirection.Input),
                };
                pos_SalesOrderList = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrderAmendment_GetForEdit", colparameters);
                return pos_SalesOrderList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrder> pos_SalesOrder_GetForEdit(DateTime fromDate, DateTime toDate, int? companyId)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[3]{
                    new Parameters("@FromDate", fromDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@ToDate", toDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input),
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetForEdit", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrder> pos_SalesOrder_GetForPI(int companyId)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input)
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetForPI", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                pos_SalesOrderLst = dbExecutor.FetchDataRef<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetPaged", colparameters, ref rows);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pos_SalesOrder _pos_SalesOrder)
        {
            Int64 ret = 0;
            try
            {
                Common aCommon = new Common();

                //SO/17-18/1, SO/17-18/2, SO/17-18/3, SO/17-18/100, SO/17-18/1001

                string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(_pos_SalesOrder.SalesOrderDate);
                _pos_SalesOrder.SalesOrderNo = "SO/" + aFiscalYearPart + "/" + _pos_SalesOrder.SalesOrderNo;

                Parameters[] colparameters = new Parameters[17]{
                new Parameters("@SalesOrderId", _pos_SalesOrder.SalesOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@CompanyId", _pos_SalesOrder.CompanyId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PriceTypeId", _pos_SalesOrder.PriceTypeId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SalesOrderNo", _pos_SalesOrder.SalesOrderNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReferenceNo", _pos_SalesOrder.ReferenceNo, DbType.String, ParameterDirection.Input),
                new Parameters("@SalesOrderDate", _pos_SalesOrder.SalesOrderDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@InvoiceDueDate", _pos_SalesOrder.InvoiceDueDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@PODate", _pos_SalesOrder.PODate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@PreparedById", _pos_SalesOrder.PreparedById, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Remarks", _pos_SalesOrder.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@CreatorId", _pos_SalesOrder.CreatorId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@CreateDate", _pos_SalesOrder.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", _pos_SalesOrder.UpdatorId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@UpdateDate", _pos_SalesOrder.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@CompanyNameOnBill", _pos_SalesOrder.CompanyNameOnBill, DbType.String, ParameterDirection.Input),
                new Parameters("@BillingAddress", _pos_SalesOrder.BillingAddress, DbType.String, ParameterDirection.Input),
                new Parameters("@CurrencyType", _pos_SalesOrder.CurrencyType, DbType.String, ParameterDirection.Input),
                new Parameters("@SalesOrderType", _pos_SalesOrder.SalesOrderType, DbType.String, ParameterDirection.Input),
                new Parameters("@IsAmendment", _pos_SalesOrder.IsAmendment, DbType.Boolean, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "pos_SalesOrder_Post", colparameters, true);
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
        public int Acknowledge(pos_SalesOrder _pos_SalesOrder)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@SalesOrderId", _pos_SalesOrder.SalesOrderId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IsAcknowledged", _pos_SalesOrder.IsAcknowledged, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@AcknowledgedBy", _pos_SalesOrder.AcknowledgedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@AcknowledgedDate", _pos_SalesOrder.AcknowledgedDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@VoucherNo", _pos_SalesOrder.VoucherNo, DbType.String, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalesOrder_Acknowledge", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 salesOrderId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SalesOrderId", salesOrderId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalesOrder_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxSalesOrderNo(DateTime salesOrderDate)
        {
            try
            {
                Common aCommon = new Common();
                DbExecutor.FiscalYear aFiscalYear = aCommon.GetFiscalFormDateAndToDate(salesOrderDate);

                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@fromDate", aFiscalYear.FromDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@toDate", aFiscalYear.ToDate, DbType.DateTime, ParameterDirection.Input)
                };

                Int64 maxDeliveryNo = 0;
                dbExecutor.ManageTransaction(TransactionType.Open);
                maxDeliveryNo = dbExecutor.ExecuteScalar64(true, CommandType.Text, "SELECT SalesOrderNo=CAST((ISNULL( MAX(CAST(SUBSTRING([SalesOrderNo],10,((LEN([SalesOrderNo])+1)-10)) AS BIGINT)),0)+1) AS VARCHAR(50)) FROM [pos_SalesOrder] WHERE [SalesOrderNo] IS NOT NULL AND LEN([SalesOrderNo])>=10 AND ( [SalesOrderDate] BETWEEN '2021-01-01' AND '2021-05-01' )", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return maxDeliveryNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public List<pos_SalesOrder> GetTopForDelivery(int topQty)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "pos_SalesOrder_GetTopForDelivery", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetForRealization(int financialCycleId, int companyId)
        {
            try
            {
                List<pos_SalesOrder> pos_SalesOrderLst = new List<pos_SalesOrder>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@FinancialCycleId", financialCycleId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input)
                };
                pos_SalesOrderLst = dbExecutor.FetchData<pos_SalesOrder>(CommandType.StoredProcedure, "rcv_GetSalesOrderForRealization", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
