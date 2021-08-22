using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_PaymentTypeBLL //: IDisposible
	{
		public ad_PaymentTypeDAO  ad_PaymentTypeDAO { get; set; }

		public ad_PaymentTypeBLL()
		{
			//ad_PaymentTypeDAO = ad_PaymentType.GetInstanceThreadSafe;
			ad_PaymentTypeDAO = new ad_PaymentTypeDAO();
		}

        public List<ad_PaymentType> GetAllActive()
		{
			try
			{
				return ad_PaymentTypeDAO.GetAllActive();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_PaymentTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_PaymentType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_PaymentTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_PaymentType _ad_PaymentType)
		{
			try
			{
				return ad_PaymentTypeDAO.Add(_ad_PaymentType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_PaymentType _ad_PaymentType)
		{
			try
			{
				return ad_PaymentTypeDAO.Update(_ad_PaymentType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 paymentTypeId)
		{
			try
			{
				return ad_PaymentTypeDAO.Delete(paymentTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
