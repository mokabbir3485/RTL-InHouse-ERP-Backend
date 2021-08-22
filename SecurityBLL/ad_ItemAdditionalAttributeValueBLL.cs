using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemAdditionalAttributeValueBLL //: IDisposible
	{
		public ad_ItemAdditionalAttributeValueDAO  ad_ItemAdditionalAttributeValueDAO { get; set; }

		public ad_ItemAdditionalAttributeValueBLL()
		{
			//ad_ItemAdditionalAttributeValueDAO = ad_ItemAdditionalAttributeValue.GetInstanceThreadSafe;
			ad_ItemAdditionalAttributeValueDAO = new ad_ItemAdditionalAttributeValueDAO();
		}

		public List<ad_ItemAdditionalAttributeValue> GetAll()
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_ItemAdditionalAttributeValue> GetByItemAddAttId(Int32 ItemAddAttId)
        {
            try
            {
                return ad_ItemAdditionalAttributeValueDAO.GetByItemAddAttId(ItemAddAttId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttributeValue> GetByItemAddAttIdForItemEdit(Int32 itemId, Int32 attributeId)
        {
            try
            {
                return ad_ItemAdditionalAttributeValueDAO.GetByItemAddAttIdForItemEdit(itemId, attributeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_ItemAdditionalAttributeValue> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_ItemAdditionalAttributeValue> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.Add(_ad_ItemAdditionalAttributeValue);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 AddWithValue(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
        {
            try
            {
                return ad_ItemAdditionalAttributeValueDAO.AddWithValue(_ad_ItemAdditionalAttributeValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Update(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.Update(_ad_ItemAdditionalAttributeValue);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ItemAddAttValueId)
		{
			try
			{
				return ad_ItemAdditionalAttributeValueDAO.Delete(ItemAddAttValueId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataTable GetByItemId(int itemId)
        {
            try 
            {
                return ad_ItemAdditionalAttributeValueDAO.GetByItemId(itemId);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

	}
}
