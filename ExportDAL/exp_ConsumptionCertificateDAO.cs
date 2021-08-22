using DbExecutor;
using ExportEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExportDAL
{
    public class exp_ConsumptionCertificateDAO //: IDisposible
    {
        private static volatile exp_ConsumptionCertificateDAO instance;
        private static readonly object lockObj = new object();
        public static exp_ConsumptionCertificateDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new exp_ConsumptionCertificateDAO();
            }
            return instance;
        }
        public static exp_ConsumptionCertificateDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new exp_ConsumptionCertificateDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public exp_ConsumptionCertificateDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<exp_ConsumptionCertificate> GetAll(Int64? consumptionCertificateId = null, Int64? commercialInvoiceId = null)
        {
            try
            {
                List<exp_ConsumptionCertificate> exp_ConsumptionCertificateLst = new List<exp_ConsumptionCertificate>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ConsumptionCertificateId", consumptionCertificateId, DbType.Int32, ParameterDirection.Input)
                };
                exp_ConsumptionCertificateLst = dbExecutor.FetchData<exp_ConsumptionCertificate>(CommandType.StoredProcedure, "exp_ConsumptionCertificate_Get", colparameters);
                return exp_ConsumptionCertificateLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificate> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<exp_ConsumptionCertificate> exp_ConsumptionCertificateLst = new List<exp_ConsumptionCertificate>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                exp_ConsumptionCertificateLst = dbExecutor.FetchData<exp_ConsumptionCertificate>(CommandType.StoredProcedure, "exp_ConsumptionCertificate_GetDynamic", colparameters);
                return exp_ConsumptionCertificateLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificate> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<exp_ConsumptionCertificate> exp_ConsumptionCertificateLst = new List<exp_ConsumptionCertificate>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                exp_ConsumptionCertificateLst = dbExecutor.FetchDataRef<exp_ConsumptionCertificate>(CommandType.StoredProcedure, "exp_ConsumptionCertificate_GetPaged", colparameters, ref rows);
                return exp_ConsumptionCertificateLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(exp_ConsumptionCertificate _exp_ConsumptionCertificate)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[9]{
                new Parameters("@CommercialInvoiceId", _exp_ConsumptionCertificate.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@StatementNo", _exp_ConsumptionCertificate.StatementNo, DbType.String, ParameterDirection.Input),
                new Parameters("@StatementDate", _exp_ConsumptionCertificate.StatementDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@BillOfEntryNo", _exp_ConsumptionCertificate.BillOfEntryNo, DbType.String, ParameterDirection.Input),
                new Parameters("@BillOfEntryDate", _exp_ConsumptionCertificate.BillOfEntryDate, DbType.String, ParameterDirection.Input),
                new Parameters("@EpzPermissionNo", _exp_ConsumptionCertificate.EpzPermissionNo, DbType.String, ParameterDirection.Input),
                new Parameters("@EpzPermissionDate", _exp_ConsumptionCertificate.EpzPermissionDate, DbType.String, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_ConsumptionCertificate.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_ConsumptionCertificate.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_ConsumptionCertificate_Create", colparameters, true);
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
        public int Update(exp_ConsumptionCertificate _exp_ConsumptionCertificate)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[10]{
                new Parameters("@ConsumptionCertificateId", _exp_ConsumptionCertificate.ConsumptionCertificateId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@CommercialInvoiceId", _exp_ConsumptionCertificate.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@StatementNo", _exp_ConsumptionCertificate.StatementNo, DbType.String, ParameterDirection.Input),
                new Parameters("@StatementDate", _exp_ConsumptionCertificate.StatementDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@BillOfEntryNo", _exp_ConsumptionCertificate.BillOfEntryNo, DbType.String, ParameterDirection.Input),
                new Parameters("@BillOfEntryDate", _exp_ConsumptionCertificate.BillOfEntryDate, DbType.String, ParameterDirection.Input),
                new Parameters("@EpzPermissionNo", _exp_ConsumptionCertificate.EpzPermissionNo, DbType.String, ParameterDirection.Input),
                new Parameters("@EpzPermissionDate", _exp_ConsumptionCertificate.EpzPermissionDate, DbType.String, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_ConsumptionCertificate.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_ConsumptionCertificate.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificate_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 consumptionCertificateId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ConsumptionCertificateId", consumptionCertificateId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificate_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_ConsumptionCertificate> GetByConsumptionCertificateForReports(Int64 CommercialInvoiceId)
        {
            try
            {
                List<exp_ConsumptionCertificate> exp_consumptionCertificateList = new List<exp_ConsumptionCertificate>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", CommercialInvoiceId, DbType.Int64, ParameterDirection.Input)
                };
                exp_consumptionCertificateList = dbExecutor.FetchData<exp_ConsumptionCertificate>(CommandType.StoredProcedure, "xRpt_exp_ConsumptionCertificate", colparameters);
                return exp_consumptionCertificateList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
