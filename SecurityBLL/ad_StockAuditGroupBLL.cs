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
	public class ad_StockAuditGroupBLL //: IDisposible
	{
		public ad_StockAuditGroupDAO  ad_StockAuditGroupDAO { get; set; }

		public ad_StockAuditGroupBLL()
		{
			//ad_StockAuditGroupDAO = ad_StockAuditGroup.GetInstanceThreadSafe;
			ad_StockAuditGroupDAO = new ad_StockAuditGroupDAO();
		}

		public List<ad_StockAuditGroup> GetAll()
		{
			try
			{
				return ad_StockAuditGroupDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_StockAuditGroup> GetAllActive()
        {
            try
            {
                return ad_StockAuditGroupDAO.GetAll().Where(g => g.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_StockAuditGroup ad_StockAuditGroup)
		{
			try
			{
				return ad_StockAuditGroupDAO.Add(ad_StockAuditGroup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_StockAuditGroup ad_StockAuditGroup)
		{
			try
			{
				return ad_StockAuditGroupDAO.Update(ad_StockAuditGroup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 auditGroupId)
		{
			try
			{
				return ad_StockAuditGroupDAO.Delete(auditGroupId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
