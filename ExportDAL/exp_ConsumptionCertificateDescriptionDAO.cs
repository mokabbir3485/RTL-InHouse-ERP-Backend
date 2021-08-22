using DbExecutor;
using ExportEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExportDAL
{
    public class exp_ConsumptionCertificateDescriptionDAO //: IDisposible
    {
        private static volatile exp_ConsumptionCertificateDescriptionDAO instance;
        private static readonly object lockObj = new object();
        public static exp_ConsumptionCertificateDescriptionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new exp_ConsumptionCertificateDescriptionDAO();
            }
            return instance;
        }
        public static exp_ConsumptionCertificateDescriptionDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new exp_ConsumptionCertificateDescriptionDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public exp_ConsumptionCertificateDescriptionDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<exp_ConsumptionCertificateDescription> GetAll(Int64? consumptionCertificateDescriptionId = null, Int64? consumptionCertificateId = null)
        {
            try
            {
                List<exp_ConsumptionCertificateDescription> exp_ConsumptionCertificateDescriptionLst = new List<exp_ConsumptionCertificateDescription>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@ConsumptionCertificateDescriptionId", consumptionCertificateDescriptionId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ConsumptionCertificateId", consumptionCertificateId, DbType.Int64, ParameterDirection.Input)
                };
                exp_ConsumptionCertificateDescriptionLst = dbExecutor.FetchData<exp_ConsumptionCertificateDescription>(CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_Get", colparameters);
                return exp_ConsumptionCertificateDescriptionLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateDescription> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<exp_ConsumptionCertificateDescription> exp_ConsumptionCertificateDescriptionLst = new List<exp_ConsumptionCertificateDescription>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                exp_ConsumptionCertificateDescriptionLst = dbExecutor.FetchData<exp_ConsumptionCertificateDescription>(CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_GetDynamic", colparameters);
                return exp_ConsumptionCertificateDescriptionLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateDescription> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<exp_ConsumptionCertificateDescription> exp_ConsumptionCertificateDescriptionLst = new List<exp_ConsumptionCertificateDescription>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                exp_ConsumptionCertificateDescriptionLst = dbExecutor.FetchDataRef<exp_ConsumptionCertificateDescription>(CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_GetPaged", colparameters, ref rows);
                return exp_ConsumptionCertificateDescriptionLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(exp_ConsumptionCertificateDescription _exp_ConsumptionCertificateDescription)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[8]{
                new Parameters("@ConsumptionCertificateId", _exp_ConsumptionCertificateDescription.ConsumptionCertificateId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemName", _exp_ConsumptionCertificateDescription.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@QtyDescription", _exp_ConsumptionCertificateDescription.QtyDescription, DbType.String, ParameterDirection.Input),
                new Parameters("@Quantity", _exp_ConsumptionCertificateDescription.Quantity, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UnitPrice", _exp_ConsumptionCertificateDescription.UnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@Amount", _exp_ConsumptionCertificateDescription.Amount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_ConsumptionCertificateDescription.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_ConsumptionCertificateDescription.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_Create", colparameters, true);
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
        public int Update(exp_ConsumptionCertificateDescription _exp_ConsumptionCertificateDescription)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[9]{
                new Parameters("@ConsumptionCertificateDescriptionId", _exp_ConsumptionCertificateDescription.ConsumptionCertificateDescriptionId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ConsumptionCertificateId", _exp_ConsumptionCertificateDescription.ConsumptionCertificateId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemName", _exp_ConsumptionCertificateDescription.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@QtyDescription", _exp_ConsumptionCertificateDescription.QtyDescription, DbType.String, ParameterDirection.Input),
                new Parameters("@Quantity", _exp_ConsumptionCertificateDescription.Quantity, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UnitPrice", _exp_ConsumptionCertificateDescription.UnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@Amount", _exp_ConsumptionCertificateDescription.Amount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_ConsumptionCertificateDescription.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_ConsumptionCertificateDescription.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 consumptionCertificateDescriptionId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ConsumptionCertificateDescriptionId", consumptionCertificateDescriptionId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificateDescription_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_ConsumptionCertificateDescription> Get_DescriptionOfGoods(int ciId)
        {
            try
            {
                List<exp_ConsumptionCertificateDescription> exp_ConsumptionCertificateDescriptionLst = new List<exp_ConsumptionCertificateDescription>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@CommercialInvoiceId", ciId, DbType.Int64, ParameterDirection.Input)
                };
                exp_ConsumptionCertificateDescriptionLst = dbExecutor.FetchData<exp_ConsumptionCertificateDescription>(CommandType.StoredProcedure, "exp_ConsumptionCertificate_GetDescriptionOfGoods", colparameters);
                return exp_ConsumptionCertificateDescriptionLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
