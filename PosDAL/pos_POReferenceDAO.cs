using DbExecutor;
using PosEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace PosDAL
{
    public class pos_POReferenceDAO
    {
        private static volatile pos_POReferenceDAO instance;
        private static readonly object lockObj = new object();
        public static pos_POReferenceDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new pos_POReferenceDAO();
            }
            return instance;
        }
        public static pos_POReferenceDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new pos_POReferenceDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public pos_POReferenceDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<pos_POReference> GetPOReference(string DocType, Int64 DocumentId)
        {
            try
            {
                List<pos_POReference> pos_POReferenceLst = new List<pos_POReference>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@DocType", DocType, DbType.String, ParameterDirection.Input),
                new Parameters("@DocumentId", DocumentId, DbType.Int64, ParameterDirection.Input),
                };
                pos_POReferenceLst = dbExecutor.FetchData<pos_POReference>(CommandType.StoredProcedure, "exp_POReference_Get", colparameters);
                return pos_POReferenceLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 Add(pos_POReference _pos_POReference)
        {
            Int64 ret = 0;
            try
            {

                Parameters[] colparameters = new Parameters[4]{
                //new Parameters("@POReferenceId", _pos_POReference.POReferenceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DocumentId", _pos_POReference.DocumentId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DocType", _pos_POReference.DocType, DbType.String, ParameterDirection.Input),
                new Parameters("@PONo", _pos_POReference.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PODate", _pos_POReference.PODate, DbType.DateTime, ParameterDirection.Input)
                
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_POReference_Create", colparameters, true);
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
