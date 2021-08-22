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
	public class ad_FinalPriceConfigBLL //: IDisposible
	{
		public ad_FinalPriceConfigDAO  ad_FinalPriceConfigDAO { get; set; }

		public ad_FinalPriceConfigBLL()
		{
			//ad_FinalPriceConfigDAO = ad_FinalPriceConfig.GetInstanceThreadSafe;
			ad_FinalPriceConfigDAO = new ad_FinalPriceConfigDAO();
		}

		public List<ad_FinalPriceConfig> GetAll()
		{
			try
			{
				return ad_FinalPriceConfigDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_FinalPriceConfig> GetAllForPurchase()
        {
            try
            {
                List<ad_FinalPriceConfig> ad_FinalPriceConfigLst = ad_FinalPriceConfigDAO.GetAll();
                ad_FinalPriceConfigLst = ad_FinalPriceConfigLst.Where(c => c.TransactionTypeId == 1).ToList();
                return ad_FinalPriceConfigLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_FinalPriceConfig> GetAllForSale()
        {
            try
            {
                List<ad_FinalPriceConfig> ad_FinalPriceConfigLst = ad_FinalPriceConfigDAO.GetAll();
                ad_FinalPriceConfigLst = ad_FinalPriceConfigLst.Where(c => c.TransactionTypeId == 2).ToList();
                return ad_FinalPriceConfigLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_FinalPriceConfig> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_FinalPriceConfigDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_FinalPriceConfig> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_FinalPriceConfigDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_FinalPriceConfig _ad_FinalPriceConfig)
		{
			try
			{
				return ad_FinalPriceConfigDAO.Add(_ad_FinalPriceConfig);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_FinalPriceConfig _ad_FinalPriceConfig)
		{
			try
			{
				return ad_FinalPriceConfigDAO.Update(_ad_FinalPriceConfig);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ConfigId)
		{
			try
			{
				return ad_FinalPriceConfigDAO.Delete(ConfigId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
