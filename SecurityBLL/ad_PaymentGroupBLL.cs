using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_PaymentGroupBLL //: IDisposible
	{
		public ad_PaymentGroupDAO  ad_PaymentGroupDAO { get; set; }

		public ad_PaymentGroupBLL()
		{
			//ad_PaymentGroupDAO = ad_PaymentGroup.GetInstanceThreadSafe;
			ad_PaymentGroupDAO = new ad_PaymentGroupDAO();
		}

        public List<ad_PaymentGroup> GetAllActive()
		{
			try
			{
				return ad_PaymentGroupDAO.GetAllActive();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentGroup> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_PaymentGroupDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentGroup> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_PaymentGroupDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_PaymentGroup _ad_PaymentGroup)
		{
			try
			{
				return ad_PaymentGroupDAO.Add(_ad_PaymentGroup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_PaymentGroup _ad_PaymentGroup)
		{
			try
			{
				return ad_PaymentGroupDAO.Update(_ad_PaymentGroup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 PaymentGroupId)
		{
			try
			{
				return ad_PaymentGroupDAO.Delete(PaymentGroupId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
