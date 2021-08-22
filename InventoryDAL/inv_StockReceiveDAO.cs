using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_StockReceiveDAO //: IDisposible
    {
        private static volatile inv_StockReceiveDAO instance;
        private static readonly object lockObj = new object();
        public static inv_StockReceiveDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_StockReceiveDAO();
            }
            return instance;
        }
        public static inv_StockReceiveDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_StockReceiveDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_StockReceiveDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_StockReceive> GetAll(Int64? SRId = null)
        {
            try
            {
                List<inv_StockReceive> inv_StockReceiveLst = new List<inv_StockReceive>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SRId", SRId, DbType.Int32, ParameterDirection.Input)
                };
                inv_StockReceiveLst = dbExecutor.FetchData<inv_StockReceive>(CommandType.StoredProcedure, "inv_StockReceive_Get", colparameters);
                return inv_StockReceiveLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceive> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_StockReceive> inv_StockReceiveLst = new List<inv_StockReceive>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_StockReceiveLst = dbExecutor.FetchData<inv_StockReceive>(CommandType.StoredProcedure, "inv_StockReceive_GetDynamic", colparameters);
                return inv_StockReceiveLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceive> GetTopForReturn(string whereCondition, string topQty)
        {
            try
            {
                List<inv_StockReceive> inv_StockReceiveLst = new List<inv_StockReceive>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@TopQty", topQty, DbType.String, ParameterDirection.Input)
                };
                inv_StockReceiveLst = dbExecutor.FetchData<inv_StockReceive>(CommandType.StoredProcedure, "inv_StockReceive_GetTopForReturn", colparameters);
                return inv_StockReceiveLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockReceive _inv_StockReceive, ref string savedReceiveNo)
        {
            Int64 ret = 0;
            try
            {
                Common aCommon = new Common();

                //SR/17-18/1, SR/17-18/2, SR/17-18/3, SR/17-18/100, SR/17-18/1001

                //string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(_inv_StockReceive.ReceiveDate);
                //_inv_StockReceive.ReceiveNo = "SR/" + aFiscalYearPart + "/" + _inv_StockReceive.ReceiveNo;

                Parameters[] colparameters = new Parameters[19]{
                new Parameters("@PBId", _inv_StockReceive.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PONo", _inv_StockReceive.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PBNo", _inv_StockReceive.PBNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveNo", _inv_StockReceive.ReceiveNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ChallanNo", _inv_StockReceive.ChallanNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveDate", _inv_StockReceive.ReceiveDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentId", _inv_StockReceive.DepartmentId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SupplierId", _inv_StockReceive.SupplierId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ReceivedById", _inv_StockReceive.ReceivedById, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Remarks", _inv_StockReceive.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@CreatorId", _inv_StockReceive.CreatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreateDate", _inv_StockReceive.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", _inv_StockReceive.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", _inv_StockReceive.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentName", _inv_StockReceive.DepartmentName, DbType.String, ParameterDirection.Input),
                new Parameters("@SupplierName", _inv_StockReceive.SupplierName, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceivedBy", _inv_StockReceive.ReceivedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_StockReceive.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@TotalReceiveQty", _inv_StockReceive.TotalReceiveQty, DbType.Decimal, ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64Ref(true, CommandType.StoredProcedure, "inv_StockReceive_Create", colparameters, true, ref savedReceiveNo);
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
        public Int64 StockRCAdd(inv_StockReceive _inv_StockReceive)
        {
            Int64 ret = 0;
            try
            {


                Parameters[] colparameters = new Parameters[20]{
                new Parameters("@PBId", _inv_StockReceive.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PONo", _inv_StockReceive.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PBNo", _inv_StockReceive.PBNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveNo", _inv_StockReceive.ReceiveNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ChallanNo", _inv_StockReceive.ChallanNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveDate", _inv_StockReceive.ReceiveDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentId", _inv_StockReceive.DepartmentId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SupplierId", _inv_StockReceive.SupplierId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ReceivedById", _inv_StockReceive.ReceivedById, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Remarks", _inv_StockReceive.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@CreatorId", _inv_StockReceive.CreatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreateDate", _inv_StockReceive.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", _inv_StockReceive.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", _inv_StockReceive.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentName", _inv_StockReceive.DepartmentName, DbType.String, ParameterDirection.Input),
                new Parameters("@SupplierName", _inv_StockReceive.SupplierName, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceivedBy", _inv_StockReceive.ReceivedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_StockReceive.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@IsLocalPurchase", _inv_StockReceive.IsLocalPurchase, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@TotalReceiveQty", _inv_StockReceive.TotalReceiveQty, DbType.Decimal, ParameterDirection.Input)
                };

                dbExecutor.ManageTransaction(TransactionType.Open);
                //ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_StockReceive_Create", colparameters, true);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_StockReceive_Create", colparameters, true);
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
        public int Update(inv_StockReceive _inv_StockReceive)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[17]{
                new Parameters("@SRId", _inv_StockReceive.SRId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBId", _inv_StockReceive.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PONo", _inv_StockReceive.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PBNo", _inv_StockReceive.PBNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveNo", _inv_StockReceive.ReceiveNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ChallanNo", _inv_StockReceive.ChallanNo, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceiveDate", _inv_StockReceive.ReceiveDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentId", _inv_StockReceive.DepartmentId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SupplierId", _inv_StockReceive.SupplierId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ReceivedById", _inv_StockReceive.ReceivedById, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Remarks", _inv_StockReceive.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@UpdatorId", _inv_StockReceive.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", _inv_StockReceive.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DepartmentName", _inv_StockReceive.DepartmentName, DbType.String, ParameterDirection.Input),
                new Parameters("@SupplierName", _inv_StockReceive.SupplierName, DbType.String, ParameterDirection.Input),
                new Parameters("@ReceivedBy", _inv_StockReceive.ReceivedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_StockReceive.IsApproved, DbType.Boolean, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceive_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockReceive _inv_StockReceive)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                new Parameters("@SRId", _inv_StockReceive.SRId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_StockReceive.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedBy", _inv_StockReceive.ApprovedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ApprovedDate", _inv_StockReceive.ApprovedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockReceive_UpdateApprove", colparameters, true);
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
        public int Delete(Int64 SRId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SRId", SRId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockReceive_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 GetMaxStockReciveIdByDate(DateTime stockReciveDate)
        {
            try
            {
                Common aCommon = new Common();
                DbExecutor.FiscalYear aFiscalYear = aCommon.GetFiscalFormDateAndToDate(stockReciveDate);

                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@fromDate", aFiscalYear.FromDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@toDate", aFiscalYear.ToDate, DbType.DateTime, ParameterDirection.Input)
                };

                Int64 maxNumber = 0;

                dbExecutor.ManageTransaction(TransactionType.Open);
                maxNumber = dbExecutor.ExecuteScalar64(true, CommandType.Text, "SELECT  ReceiveNo =CAST((ISNULL( MAX(CAST(SUBSTRING([ReceiveNo],10,((LEN([ReceiveNo])+1)-10)) AS BIGINT)),0)+1) AS VARCHAR(50)) FROM [inv_StockReceive] WHERE ReceiveDate BETWEEN  @fromDate AND @toDate", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return maxNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
