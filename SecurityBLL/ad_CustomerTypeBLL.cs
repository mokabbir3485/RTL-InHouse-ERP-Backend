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
	public class ad_CustomerTypeBLL //: IDisposible
	{
		public ad_CustomerTypeDAO  ad_CustomerTypeDAO { get; set; }

		public ad_CustomerTypeBLL()
		{
			//ad_CustomerTypeDAO = ad_CustomerType.GetInstanceThreadSafe;
			ad_CustomerTypeDAO = new ad_CustomerTypeDAO();
		}

        public List<ad_CustomerType> GetAll(Int32? customerTypeId = null)
		{
			try
			{
				return ad_CustomerTypeDAO.GetAll(customerTypeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_CustomerType> GetAllActive(Int32? customerTypeId = null)
        {
            try
            {
                List<ad_CustomerType> cusTypeLst = ad_CustomerTypeDAO.GetAll(customerTypeId);
                cusTypeLst = cusTypeLst.Where(t => t.IsActive == true).ToList();
                return cusTypeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_CustomerType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_CustomerTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_CustomerType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_CustomerTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CustomerType _ad_CustomerType)
		{
			try
			{
				return ad_CustomerTypeDAO.Add(_ad_CustomerType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_CustomerType _ad_CustomerType)
		{
			try
			{
				return ad_CustomerTypeDAO.Update(_ad_CustomerType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 customerTypeId)
		{
			try
			{
				return ad_CustomerTypeDAO.Delete(customerTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
