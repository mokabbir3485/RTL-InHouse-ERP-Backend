using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;
using System.Linq;

namespace SecurityBLL
{
	public class ad_CompanyTypeBLL //: IDisposible
	{
		public ad_CompanyTypeDAO  ad_CompanyTypeDAO { get; set; }

		public ad_CompanyTypeBLL()
		{
			//ad_CompanyTypeDAO = ad_CompanyType.GetInstanceThreadSafe;
			ad_CompanyTypeDAO = new ad_CompanyTypeDAO();
		}

        public List<ad_CompanyType> GetAll(Int32? CompanyTypeId = null)
		{
			try
			{
				return ad_CompanyTypeDAO.GetAll(CompanyTypeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_CompanyType> GetAllActive(Int32? CompanyTypeId = null)
        {
            try
            {
                List<ad_CompanyType> cusTypeLst = ad_CompanyTypeDAO.GetAll(CompanyTypeId);
                cusTypeLst = cusTypeLst.Where(t => t.IsActive == true).ToList();
                return cusTypeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_CompanyType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_CompanyTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_CompanyType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_CompanyTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CompanyType _ad_CompanyType)
		{
			try
			{
				return ad_CompanyTypeDAO.Add(_ad_CompanyType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_CompanyType _ad_CompanyType)
		{
			try
			{
				return ad_CompanyTypeDAO.Update(_ad_CompanyType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 CompanyTypeId)
		{
			try
			{
				return ad_CompanyTypeDAO.Delete(CompanyTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
