﻿using DbExecutor;
using ExportEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExportDAL
{
    public class exp_POReferenceDAO
    {
        private static volatile exp_POReferenceDAO instance;
        private static readonly object lockObj = new object();
        public static exp_POReferenceDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new exp_POReferenceDAO();
            }
            return instance;
        }
        public static exp_POReferenceDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new exp_POReferenceDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public exp_POReferenceDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<exp_POReference> GetPOReference(string DocType, Int64 DocumentId)
        {
            try
            {
                List<exp_POReference> exp_POReferenceLst = new List<exp_POReference>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@DocType", DocType, DbType.String, ParameterDirection.Input),
                new Parameters("@DocumentId", DocumentId, DbType.Int64, ParameterDirection.Input),
                };
                exp_POReferenceLst = dbExecutor.FetchData<exp_POReference>(CommandType.StoredProcedure, "exp_POReference_Get", colparameters);
                return exp_POReferenceLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Add(exp_POReference _exp_POReference)
        {
            Int64 ret = 0;
            try
            {

                Parameters[] colparameters = new Parameters[4]{
                //new Parameters("@POReferenceId", _exp_POReference.POReferenceId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DocumentId", _exp_POReference.DocumentId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DocType", _exp_POReference.DocType, DbType.String, ParameterDirection.Input),
                new Parameters("@PONo", _exp_POReference.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PODate", _exp_POReference.PODate, DbType.DateTime, ParameterDirection.Input)

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
