using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ExportEntity;
using ExportDAL;

namespace ExportBLL
{
	public class exp_ConsumptionCertificateRawMaterialsBLL //: IDisposible
	{
		public exp_ConsumptionCertificateRawMaterialsDAO  exp_ConsumptionCertificateRawMaterialsDAO { get; set; }

		public exp_ConsumptionCertificateRawMaterialsBLL()
		{
			//exp_ConsumptionCertificateRawMaterialsDAO = exp_ConsumptionCertificateRawMaterials.GetInstanceThreadSafe;
			exp_ConsumptionCertificateRawMaterialsDAO = new exp_ConsumptionCertificateRawMaterialsDAO();
		}

		public List<exp_ConsumptionCertificateRawMaterials> GetAll()
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificateRawMaterials> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificateRawMaterials> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(exp_ConsumptionCertificateRawMaterials _exp_ConsumptionCertificateRawMaterials)
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.Add(_exp_ConsumptionCertificateRawMaterials);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<exp_ConsumptionCertificateRawMaterials> GetByConsumptionCertificateRawMetrialByCiId(Int64 CommercialInvoiceId)
        {
	        try
	        {
		        return exp_ConsumptionCertificateRawMaterialsDAO.GetByConsumptionCertificateRawMetrialByCiId(CommercialInvoiceId);
	        }
	        catch (Exception ex)
	        {
		        throw ex;
	        }
        }
		public int Update(exp_ConsumptionCertificateRawMaterials _exp_ConsumptionCertificateRawMaterials)
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.Update(_exp_ConsumptionCertificateRawMaterials);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 consumptionCertificateRawMaterialsId)
		{
			try
			{
				return exp_ConsumptionCertificateRawMaterialsDAO.Delete(consumptionCertificateRawMaterialsId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
