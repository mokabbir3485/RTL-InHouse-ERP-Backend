using HrAndPayrollDAL;
using HrAndPayrollEntity;
using System;
using System.Collections.Generic;

namespace HrAndPayrollBLL
{
    public class hr_ContractTypeBLL //: IDisposible
    {
        public hr_ContractTypeDAO hr_ContractTypeDAO { get; set; }

        public hr_ContractTypeBLL()
        {
            //hr_GradeDAO = hr_Grade.GetInstanceThreadSafe;
            hr_ContractTypeDAO = new hr_ContractTypeDAO();
        }

        public List<hr_ContractType> GetAll()
        {
            try
            {
                return hr_ContractTypeDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
