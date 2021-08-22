using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_CompanyBLL //: IDisposible
	{
		public ad_CompanyDAO  ad_CompanyDAO { get; set; }

		public ad_CompanyBLL()
		{
			//ad_CompanyDAO = ad_Company.GetInstanceThreadSafe;
			ad_CompanyDAO = new ad_CompanyDAO();
		}
        public List<ad_Company> GetCompanyIdByDetail(string companyName, string contactPerson, string contactNo, string email)
        {
            try
            {
                return ad_CompanyDAO.GetCompanyIdByDetail(companyName, contactPerson, contactNo, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Company> GetAll()
		{
			try
			{
				return ad_CompanyDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Company> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_CompanyDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Company> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_CompanyDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Company _ad_Company)
		{
			try
			{
				return ad_CompanyDAO.Add(_ad_Company);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Company _ad_Company)
		{
			try
			{
				return ad_CompanyDAO.Update(_ad_Company);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 companyId)
		{
			try
			{
				return ad_CompanyDAO.Delete(companyId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
