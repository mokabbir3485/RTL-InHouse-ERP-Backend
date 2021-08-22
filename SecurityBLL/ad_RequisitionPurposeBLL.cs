using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_RequisitionPurposeBLL //: IDisposible
	{
		public ad_RequisitionPurposeDAO  ad_RequisitionPurposeDAO { get; set; }

		public ad_RequisitionPurposeBLL()
		{
			//ad_RequisitionPurposeDAO = ad_RequisitionPurpose.GetInstanceThreadSafe;
			ad_RequisitionPurposeDAO = new ad_RequisitionPurposeDAO();
		}

		public List<ad_RequisitionPurpose> GetAll()
		{
			try
			{
				return ad_RequisitionPurposeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_RequisitionPurpose> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_RequisitionPurposeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_RequisitionPurpose> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_RequisitionPurposeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_RequisitionPurpose _ad_RequisitionPurpose)
		{
			try
			{
				return ad_RequisitionPurposeDAO.Add(_ad_RequisitionPurpose);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_RequisitionPurpose _ad_RequisitionPurpose)
		{
			try
			{
				return ad_RequisitionPurposeDAO.Update(_ad_RequisitionPurpose);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 RequisitionPurposeId)
		{
			try
			{
				return ad_RequisitionPurposeDAO.Delete(RequisitionPurposeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
