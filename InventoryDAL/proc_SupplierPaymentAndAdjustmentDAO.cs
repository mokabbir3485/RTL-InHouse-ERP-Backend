using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class proc_SupplierPaymentAndAdjustmentDAO
    {
        private static volatile proc_SupplierPaymentAndAdjustmentDAO instance;
        private static readonly object lockObj = new object();
        public static proc_SupplierPaymentAndAdjustmentDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new proc_SupplierPaymentAndAdjustmentDAO();
            }
            return instance;
        }
        public static proc_SupplierPaymentAndAdjustmentDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new proc_SupplierPaymentAndAdjustmentDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public proc_SupplierPaymentAndAdjustmentDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<proc_SupplierPaymentAdjustmentDetail> SupplierAdjustmentDetailGetById(Int64 SPAId)
        {
            try
            {
                List<proc_SupplierPaymentAdjustmentDetail> proc_SupplierPaymentAdjustmentDetailLst = new List<proc_SupplierPaymentAdjustmentDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SPAId", SPAId, DbType.Int64, ParameterDirection.Input)

                };
                proc_SupplierPaymentAdjustmentDetailLst = dbExecutor.FetchData<proc_SupplierPaymentAdjustmentDetail>(CommandType.StoredProcedure, "proc_SupplierAdjustmentDetailGetById", colparameters);
                return proc_SupplierPaymentAdjustmentDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<proc_SupplierPaymentAdjustment> SupplierPaymentAdjustmentGetBySupplierId(Int64 SupplierId)
        {
            try
            {
                List<proc_SupplierPaymentAdjustment> proc_SupplierPaymentAdjustmenttLst = new List<proc_SupplierPaymentAdjustment>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SupplierId", SupplierId, DbType.Int64, ParameterDirection.Input)
                    //new Parameters("@isLocal", isLocal, DbType.Boolean, ParameterDirection.Input),
                };
                proc_SupplierPaymentAdjustmenttLst = dbExecutor.FetchData<proc_SupplierPaymentAdjustment>(CommandType.StoredProcedure, "proc_SupplierAdjustmentBySupplierId", colparameters);
                return proc_SupplierPaymentAdjustmenttLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<proc_SupplierPaymentAdjustment> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<proc_SupplierPaymentAdjustment> proc_SupplierPaymentAdjustment = new List<proc_SupplierPaymentAdjustment>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                proc_SupplierPaymentAdjustment = dbExecutor.FetchDataRef<proc_SupplierPaymentAdjustment>(CommandType.StoredProcedure, "proc_SupplierPaymentAdjustment_GetPaged", colparameters, ref rows);
                return proc_SupplierPaymentAdjustment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<proc_SupplierLedger> SupplierLedger_Get(Int64 supplierId, string fromDate, string toDate)
        {
            try
            {
                List<proc_SupplierLedger> proc_SupplierLedger = new List<proc_SupplierLedger>();
                Parameters[] colparameters = new Parameters[3]{
                    new Parameters("@supplierId", supplierId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@fromDate", fromDate, DbType.String, ParameterDirection.Input),
                    new Parameters("@toDate", toDate, DbType.String, ParameterDirection.Input)
                    
                };
                proc_SupplierLedger = dbExecutor.FetchData<proc_SupplierLedger>(CommandType.StoredProcedure, "proc_SupplierLedger", colparameters);
                return proc_SupplierLedger;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Post(proc_SupplierPaymentAdjustment _proc_SupplierPaymentAdjustment)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[7]{
                new Parameters("@SPAId", _proc_SupplierPaymentAdjustment.SPAId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@SPADate ", _proc_SupplierPaymentAdjustment.SPADate , DbType.DateTime, ParameterDirection.Input),
                new Parameters("@SupplierId", _proc_SupplierPaymentAdjustment.SupplierId, DbType.Int64 , ParameterDirection.Input),
                new Parameters("@Remarks", _proc_SupplierPaymentAdjustment.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@JVNo", _proc_SupplierPaymentAdjustment.JVNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _proc_SupplierPaymentAdjustment.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _proc_SupplierPaymentAdjustment.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "proc_SupplierPaymentAdjustment_Post", colparameters, true);
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




        public Int64 PostDetail(proc_SupplierPaymentAdjustmentDetail _proc_SupplierPaymentAdjustmentDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@SPADetailId", _proc_SupplierPaymentAdjustmentDetail.SPADetailId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@SPAId", _proc_SupplierPaymentAdjustmentDetail.SPAId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@IsLocalPurchase", _proc_SupplierPaymentAdjustmentDetail.IsLocalPurchase, DbType.Boolean , ParameterDirection.Input),
                new Parameters("@PBId", _proc_SupplierPaymentAdjustmentDetail.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@AdjustedAmount", _proc_SupplierPaymentAdjustmentDetail.AdjustedAmount, DbType.Decimal, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "proc_SupplierPaymentAdjustmentDetail_Post", colparameters, true);
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


        public int SupplierPaymentAdjustmentDetailDeleteBySPAId(Int64 SPAId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SPAId", SPAId, DbType.Int64, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "proc_SupplierPaymentAdjustmentDetail_Delete", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //SupplierPayment Part start


        public List<proc_SupplierPayment> SupplierPaymentGetBySupplierId(Int32 SupplierId)
        {
            try
            {
                List<proc_SupplierPayment> proc_SupplierPaymentLst = new List<proc_SupplierPayment>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SupplierId", SupplierId, DbType.Int32, ParameterDirection.Input)
                    //new Parameters("@isLocal", isLocal, DbType.Boolean, ParameterDirection.Input),
                };
                proc_SupplierPaymentLst = dbExecutor.FetchData<proc_SupplierPayment>(CommandType.StoredProcedure, "proc_SupplierPayment_GetBySupplierId", colparameters);
                return proc_SupplierPaymentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public Int64 AddDetail(proc_SupplierPaymentDetail _proc_SupplierPaymentDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[8]{
                    new Parameters("@SupplierPaymentId", _proc_SupplierPaymentDetail.SupplierPaymentId, DbType.Int64 ,ParameterDirection.Input),
                    new Parameters("@IsLocalPurchase ", _proc_SupplierPaymentDetail.IsLocalPurchase , DbType.Boolean, ParameterDirection.Input),
                    new Parameters("@PBId", _proc_SupplierPaymentDetail.PBId, DbType.Int64 , ParameterDirection.Input),
                    new Parameters("@PaidAmount", _proc_SupplierPaymentDetail.PaidAmount, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@VAT", _proc_SupplierPaymentDetail.VAT, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@AIT", _proc_SupplierPaymentDetail.AIT, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@PayableAmount", _proc_SupplierPaymentDetail.PayableAmount, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@ActualAmount", _proc_SupplierPaymentDetail.ActualAmount, DbType.Decimal ,ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "proc_SupplierPaymentDetail_Create", colparameters, true);
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



        public Int64 Add(proc_SupplierPayment _proc_SupplierPayment)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[15]{
                    new Parameters("@SupplierId", _proc_SupplierPayment.SupplierId, DbType.Int32 ,ParameterDirection.Input),
                    new Parameters("@PaymentTypeId", _proc_SupplierPayment.PaymentTypeId, DbType.Int32 ,ParameterDirection.Input),
                    new Parameters("@PaymentDate ", _proc_SupplierPayment.PaymentDate , DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@Remarks", _proc_SupplierPayment.Remarks, DbType.String , ParameterDirection.Input),
                    new Parameters("@IsCheque", _proc_SupplierPayment.IsCheque, DbType.Boolean, ParameterDirection.Input),
                    new Parameters("@ChequeType", _proc_SupplierPayment.ChequeType, DbType.String, ParameterDirection.Input),
                    new Parameters("@ChequeNo", _proc_SupplierPayment.ChequeNo, DbType.String, ParameterDirection.Input),
                    new Parameters("@ChequeDate", _proc_SupplierPayment.ChequeDate, DbType.String, ParameterDirection.Input),
                    new Parameters("@BankAccountId", _proc_SupplierPayment.BankAccountId, DbType.Int32 ,ParameterDirection.Input),
                    new Parameters("@JVNo ", _proc_SupplierPayment.JVNo , DbType.Int32, ParameterDirection.Input),
                    new Parameters("@PaidAmount", _proc_SupplierPayment.PaidAmount, DbType.Decimal , ParameterDirection.Input),
                    new Parameters("@TotalVAT", _proc_SupplierPayment.TotalVAT, DbType.String, ParameterDirection.Input),
                    new Parameters("@TotalAIT", _proc_SupplierPayment.TotalAIT, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@UpdatedBy", _proc_SupplierPayment.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@UpdatedDate", _proc_SupplierPayment.UpdatedDate, DbType.DateTime, ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "proc_SupplierPayment_Create", colparameters, true);
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

        public List<proc_SupplierPayment> proc_SupplierPayment_GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<proc_SupplierPayment> proc_SupplierPayment = new List<proc_SupplierPayment>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                proc_SupplierPayment = dbExecutor.FetchDataRef<proc_SupplierPayment>(CommandType.StoredProcedure, "proc_SupplierPayment_GetPaged", colparameters, ref rows);
                return proc_SupplierPayment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
