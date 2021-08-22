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
	public class ad_ValuationTypeBLL //: IDisposible
	{
		public ad_ValuationTypeDAO  ad_ValuationTypeDAO { get; set; }

		public ad_ValuationTypeBLL()
		{
			//ad_ValuationTypeDAO = ad_ValuationType.GetInstanceThreadSafe;
			ad_ValuationTypeDAO = new ad_ValuationTypeDAO();
		}

		public List<ad_ValuationType> GetAll()
		{
			try
			{
				return ad_ValuationTypeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_ValuationType> GetAllActive()
        {
            try
            {
                return ad_ValuationTypeDAO.GetAll().Where(v => v.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_ValuationType ad_ValuationType)
		{
			try
			{
				return ad_ValuationTypeDAO.Add(ad_ValuationType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_ValuationType ad_ValuationType)
		{
			try
			{
				return ad_ValuationTypeDAO.Update(ad_ValuationType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 valuationTypeId)
		{
			try
			{
                return ad_ValuationTypeDAO.Delete(valuationTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
