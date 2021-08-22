using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_CustomerBLL //: IDisposible
	{
		public ad_CustomerDAO  ad_CustomerDAO { get; set; }

		public ad_CustomerBLL()
		{
			//ad_CustomerDAO = ad_Customer.GetInstanceThreadSafe;
			ad_CustomerDAO = new ad_CustomerDAO();
		}

		public List<ad_Customer> GetAll()
		{
			try
			{
				return ad_CustomerDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Customer> GetAllNonRegistered(Int32? CustomerId = null)
        {
            try
            {
                return ad_CustomerDAO.GetAllNonRegistered(CustomerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Customer> GetById(int customerId)
        {
            try
            {
                return ad_CustomerDAO.GetAll(customerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Customer> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_CustomerDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Customer> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_CustomerDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public string Add(ad_Customer _ad_Customer)
		{
			try
			{
				return ad_CustomerDAO.Add(_ad_Customer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int AddNonReg(ad_Customer _ad_Customer, int departmentId)
        {
            try
            {
                return ad_CustomerDAO.AddNonReg(_ad_Customer, departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public string Update(ad_Customer _ad_Customer)
		{
			try
			{
				return ad_CustomerDAO.Update(_ad_Customer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 CustomerId)
		{
			try
			{
				return ad_CustomerDAO.Delete(CustomerId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
