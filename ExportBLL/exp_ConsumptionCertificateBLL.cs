using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ExportEntity;
using ExportDAL;

namespace ExportBLL
{
	public class exp_ConsumptionCertificateBLL //: IDisposible
	{
		public exp_ConsumptionCertificateDAO  exp_ConsumptionCertificateDAO { get; set; }

		public exp_ConsumptionCertificateBLL()
		{
			//exp_ConsumptionCertificateDAO = exp_ConsumptionCertificate.GetInstanceThreadSafe;
			exp_ConsumptionCertificateDAO = new exp_ConsumptionCertificateDAO();
		}

		public List<exp_ConsumptionCertificate> GetAll()
		{
			try
			{
				return exp_ConsumptionCertificateDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificate> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return exp_ConsumptionCertificateDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificate> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return exp_ConsumptionCertificateDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(exp_ConsumptionCertificate _exp_ConsumptionCertificate)
		{
			try
			{
				return exp_ConsumptionCertificateDAO.Add(_exp_ConsumptionCertificate);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(exp_ConsumptionCertificate _exp_ConsumptionCertificate)
		{
			try
			{
				return exp_ConsumptionCertificateDAO.Update(_exp_ConsumptionCertificate);
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
				return exp_ConsumptionCertificateDAO.Delete(consumptionCertificateId);
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
				return exp_ConsumptionCertificateDAO.GetByConsumptionCertificateForReports(CommercialInvoiceId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
