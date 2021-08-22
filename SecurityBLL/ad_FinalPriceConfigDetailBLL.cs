using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_FinalPriceConfigDetailBLL //: IDisposible
	{
		public ad_FinalPriceConfigDetailDAO  ad_FinalPriceConfigDetailDAO { get; set; }

		public ad_FinalPriceConfigDetailBLL()
		{
			//ad_FinalPriceConfigDetailDAO = ad_FinalPriceConfigDetail.GetInstanceThreadSafe;
			ad_FinalPriceConfigDetailDAO = new ad_FinalPriceConfigDetailDAO();
		}

		public List<ad_FinalPriceConfigDetail> GetByConfigId(Int32 configId)
		{
			try
			{
				return ad_FinalPriceConfigDetailDAO.GetByConfigId(configId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_FinalPriceConfigDetail ad_FinalPriceConfigDetail)
		{
			try
			{
				return ad_FinalPriceConfigDetailDAO.Add(ad_FinalPriceConfigDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
