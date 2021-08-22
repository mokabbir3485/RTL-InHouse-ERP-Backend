using DbExecutor;
using HrAndPayrollEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace HrAndPayrollDAL
{
    public class hr_ContractTypeDAO //: IDisposible
    {
        private static volatile hr_ContractTypeDAO instance;
        private static readonly object lockObj = new object();
        public static hr_ContractTypeDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new hr_ContractTypeDAO();
            }
            return instance;
        }
        public static hr_ContractTypeDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new hr_ContractTypeDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public hr_ContractTypeDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<hr_ContractType> GetAll()
        {
            try
            {
                List<hr_ContractType> hr_ContractTypeList = new List<hr_ContractType>();
                hr_ContractTypeList = dbExecutor.FetchData<hr_ContractType>(CommandType.StoredProcedure, "hr_ContractType_GetAll");
                return hr_ContractTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
