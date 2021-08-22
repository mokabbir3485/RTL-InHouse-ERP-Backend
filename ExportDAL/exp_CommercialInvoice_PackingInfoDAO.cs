using DbExecutor;
using ExportEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExportDAL
{
    public class exp_CommercialInvoice_PackingInfoDAO
    {
        private static volatile exp_CommercialInvoice_PackingInfoDAO instance;
        private static readonly object lockObj = new object();
        public static exp_CommercialInvoice_PackingInfoDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new exp_CommercialInvoice_PackingInfoDAO();
            }
            return instance;
        }
        public static exp_CommercialInvoice_PackingInfoDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new exp_CommercialInvoice_PackingInfoDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;


        public exp_CommercialInvoice_PackingInfoDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<exp_CommercialInvoice_PackingInfo> GetAll(Int64 commercialInvoiceId)
        {
            try
            {

                List<exp_CommercialInvoice_PackingInfo> exp_CommercialInvoice_PackingInfoLst = new List<exp_CommercialInvoice_PackingInfo>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@commercialInvoiceId", commercialInvoiceId, DbType.Int32, ParameterDirection.Input)
                };
                exp_CommercialInvoice_PackingInfoLst = dbExecutor.FetchData<exp_CommercialInvoice_PackingInfo>(CommandType.StoredProcedure, "exp_CommercialInvoice_PackingInfo_Get", colparameters);
                return exp_CommercialInvoice_PackingInfoLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<exp_CommercialInvoice_PackingInfo> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<exp_CommercialInvoice_PackingInfo> exp_CommercialInvoice_PackingInfoLst = new List<exp_CommercialInvoice_PackingInfo>();
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                    new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                exp_CommercialInvoice_PackingInfoLst = dbExecutor.FetchData<exp_CommercialInvoice_PackingInfo>(CommandType.StoredProcedure, "exp_CommercialInvoice_PackingInfo_GetDynamic", colparameters);
                return exp_CommercialInvoice_PackingInfoLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Add(exp_CommercialInvoice_PackingInfo _exp_CommercialInvoice_PackingInfo)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[9]{
                new Parameters("@CommercialInvoiceId", _exp_CommercialInvoice_PackingInfo.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@TotalCarton", _exp_CommercialInvoice_PackingInfo.TotalCarton, DbType.Int32, ParameterDirection.Input),
                new Parameters("@LabelNetWeight", _exp_CommercialInvoice_PackingInfo.LabelNetWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@LabelGrossWeight", _exp_CommercialInvoice_PackingInfo.LabelGrossWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@RibonNetWeight", _exp_CommercialInvoice_PackingInfo.RibonNetWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@RibonGrossWeight", _exp_CommercialInvoice_PackingInfo.RibonGrossWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@CartonMeasurement", _exp_CommercialInvoice_PackingInfo.CartonMeasurement, DbType.String, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_CommercialInvoice_PackingInfo.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_CommercialInvoice_PackingInfo.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_CommercialInvoice_PackingInfo_Create", colparameters, true);
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
        public int Update(exp_CommercialInvoice_PackingInfo _exp_CommercialInvoice_PackingInfo)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[10]{
                new Parameters("@CIPackingInfold", _exp_CommercialInvoice_PackingInfo.CIPackingInfold, DbType.Int64, ParameterDirection.Input),
                new Parameters("@CommercialInvoiceId", _exp_CommercialInvoice_PackingInfo.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@TotalCarton", _exp_CommercialInvoice_PackingInfo.TotalCarton, DbType.Int32, ParameterDirection.Input),
                new Parameters("@LabelNetWeight", _exp_CommercialInvoice_PackingInfo.LabelNetWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@LabelGrossWeight", _exp_CommercialInvoice_PackingInfo.LabelGrossWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@RibonNetWeight", _exp_CommercialInvoice_PackingInfo.RibonNetWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@RibonGrossWeight", _exp_CommercialInvoice_PackingInfo.RibonGrossWeight, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@CartonMeasurement", _exp_CommercialInvoice_PackingInfo.CartonMeasurement, DbType.String, ParameterDirection.Input),
                new Parameters("@UpdatedBy", _exp_CommercialInvoice_PackingInfo.UpdatedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatedDate", _exp_CommercialInvoice_PackingInfo.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_CommercialInvoice_PackingInfo_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
