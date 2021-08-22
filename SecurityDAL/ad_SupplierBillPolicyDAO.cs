using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;

namespace SecurityDAL
{
    public class ad_SupplierBillPolicyDAO
    {
        DBExecutor dbExecutor;
        public ad_SupplierBillPolicyDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<ad_SupplierBillPolicy> GetBySupplierId(Int32 SupplierId)
        {
            try
            {
                List<ad_SupplierBillPolicy> lst = new List<ad_SupplierBillPolicy>();
                Parameters[] colparameters = new Parameters[1]{
                new  Parameters("@SupplierId", SupplierId,  DbType.Int32 ,  ParameterDirection.Input)
                };
                lst = dbExecutor.FetchData<ad_SupplierBillPolicy>(CommandType.StoredProcedure, "ad_SupplierBillPolicy_GetBySupplierId", colparameters);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Add(ad_SupplierBillPolicy ad_SupplierBillPolicy)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@SupplierId", ad_SupplierBillPolicy.SupplierId,  DbType.Int32 ,  ParameterDirection.Input),
                new Parameters("@PolicyDescription",ad_SupplierBillPolicy.PolicyDescription , DbType.String , ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_SupplierBillPolicy_Create", colparameters, true);
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
