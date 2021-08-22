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
	public class ad_AdditionalAttributeBLL //: IDisposible
	{
		public ad_AdditionalAttributeDAO  ad_AdditionalAttributeDAO { get; set; }

		public ad_AdditionalAttributeBLL()
		{
			//ad_AdditionalAttributeDAO = ad_AdditionalAttribute.GetInstanceThreadSafe;
			ad_AdditionalAttributeDAO = new ad_AdditionalAttributeDAO();
		}

        public List<ad_AdditionalAttribute> GetAll(Int32? attributeId = null)
		{
			try
			{
                return ad_AdditionalAttributeDAO.GetAll(attributeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_AdditionalAttribute> GetAllActive()
        {
            try
            {
                List<ad_AdditionalAttribute> ad_AdditionalAttributeLst = ad_AdditionalAttributeDAO.GetAll();
                return ad_AdditionalAttributeLst.Where(a => a.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_AdditionalAttribute> GetAllActiveByIds(string attributeIds)
        {
            try
            {
                return ad_AdditionalAttributeDAO.GetAllActiveByIds(attributeIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_AdditionalAttribute> GetFromSavedType()
        {
            try
            {
                List<ad_AdditionalAttribute> ad_AdditionalAttributeLst = ad_AdditionalAttributeDAO.GetAll();
                return ad_AdditionalAttributeLst.Where(a => a.ValueAvailibilityType == 1 & a.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_AdditionalAttribute> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return ad_AdditionalAttributeDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_AdditionalAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return ad_AdditionalAttributeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_AdditionalAttribute ad_AdditionalAttribute)
		{
			try
			{
				return ad_AdditionalAttributeDAO.Add(ad_AdditionalAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_AdditionalAttribute ad_AdditionalAttribute)
		{
			try
			{
				return ad_AdditionalAttributeDAO.Update(ad_AdditionalAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 addAttId)
		{
			try
			{
				return ad_AdditionalAttributeDAO.Delete(addAttId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
