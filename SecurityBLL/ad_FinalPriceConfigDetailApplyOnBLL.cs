using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_FinalPriceConfigDetailApplyOnBLL //: IDisposible
	{
		public ad_FinalPriceConfigDetailApplyOnDAO  ad_FinalPriceConfigDetailApplyOnDAO { get; set; }

		public ad_FinalPriceConfigDetailApplyOnBLL()
		{
			//ad_FinalPriceConfigDetailApplyOnDAO = ad_FinalPriceConfigDetailApplyOn.GetInstanceThreadSafe;
			ad_FinalPriceConfigDetailApplyOnDAO = new ad_FinalPriceConfigDetailApplyOnDAO();
		}

        public List<ad_FinalPriceConfigDetailApplyOn> GetByConfigDetailId(Int64 configDetailId)
		{
			try
			{
				return ad_FinalPriceConfigDetailApplyOnDAO.GetByConfigDetailId(configDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_FinalPriceConfigDetailApplyOn> GetByConfigId(Int32 configId)
        {
            try
            {
                return ad_FinalPriceConfigDetailApplyOnDAO.GetByConfigId(configId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_FinalPriceConfigDetailApplyOn ad_FinalPriceConfigDetailApplyOn)
		{
			try
			{
				return ad_FinalPriceConfigDetailApplyOnDAO.Add(ad_FinalPriceConfigDetailApplyOn);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
