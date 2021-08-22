using ExportDAL;
using ExportEntity;
using System;
using System.Collections.Generic;

namespace ExportBLL
{
    public class exp_ConsumptionCertificateDescriptionBLL //: IDisposible
    {
        public exp_ConsumptionCertificateDescriptionDAO exp_ConsumptionCertificateDescriptionDAO { get; set; }

        public exp_ConsumptionCertificateDescriptionBLL()
        {
            //exp_ConsumptionCertificateDescriptionDAO = exp_ConsumptionCertificateDescription.GetInstanceThreadSafe;
            exp_ConsumptionCertificateDescriptionDAO = new exp_ConsumptionCertificateDescriptionDAO();
        }

        public List<exp_ConsumptionCertificateDescription> GetAll(Int64? consumptionCertificateDescriptionId = null, Int64? consumptionCertificateId = null)
        {
            try
            {
                return exp_ConsumptionCertificateDescriptionDAO.GetAll(consumptionCertificateDescriptionId, consumptionCertificateId);
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
                return exp_ConsumptionCertificateDescriptionDAO.GetDynamic(whereCondition, orderByExpression);
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
                return exp_ConsumptionCertificateDescriptionDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(exp_ConsumptionCertificateDescription _exp_ConsumptionCertificateDescription)
        {
            try
            {
                return exp_ConsumptionCertificateDescriptionDAO.Add(_exp_ConsumptionCertificateDescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(exp_ConsumptionCertificateDescription _exp_ConsumptionCertificateDescription)
        {
            try
            {
                return exp_ConsumptionCertificateDescriptionDAO.Update(_exp_ConsumptionCertificateDescription);
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
                return exp_ConsumptionCertificateDescriptionDAO.Delete(consumptionCertificateDescriptionId);
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
                return exp_ConsumptionCertificateDescriptionDAO.Get_DescriptionOfGoods(ciId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
