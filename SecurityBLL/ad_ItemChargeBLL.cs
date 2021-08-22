using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemChargeBLL //: IDisposible
	{
		public ad_ItemChargeDAO  ad_ItemChargeDAO { get; set; }

		public ad_ItemChargeBLL()
		{
			//ad_ItemChargeDAO = ad_ItemCharge.GetInstanceThreadSafe;
			ad_ItemChargeDAO = new ad_ItemChargeDAO();
		}

        public List<ad_ItemCharge> GetByItemId(Int32 itemId)
		{
			try
			{
				return ad_ItemChargeDAO.GetByItemId(itemId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(ad_ItemCharge ad_ItemCharge)
		{
			try
			{
				return ad_ItemChargeDAO.Add(ad_ItemCharge);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
