using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_VoidReasonBLL //: IDisposible
	{
		public ad_VoidReasonDAO  ad_VoidReasonDAO { get; set; }

		public ad_VoidReasonBLL()
		{
			//ad_VoidReasonDAO = ad_VoidReason.GetInstanceThreadSafe;
			ad_VoidReasonDAO = new ad_VoidReasonDAO();
		}

		public List<ad_VoidReason> GetAll()
		{
			try
			{
				return ad_VoidReasonDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_VoidReason> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_VoidReasonDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_VoidReason> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_VoidReasonDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_VoidReason _ad_VoidReason)
		{
			try
			{
				return ad_VoidReasonDAO.Add(_ad_VoidReason);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_VoidReason _ad_VoidReason)
		{
			try
			{
				return ad_VoidReasonDAO.Update(_ad_VoidReason);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 VoidReasonId)
		{
			try
			{
				return ad_VoidReasonDAO.Delete(VoidReasonId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
