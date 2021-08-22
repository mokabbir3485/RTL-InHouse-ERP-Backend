using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ChargeTypeApplyBLL //: IDisposible
	{
		public ad_ChargeTypeApplyDAO  ad_ItemChargeApplyDAO { get; set; }

		public ad_ChargeTypeApplyBLL()
		{
			//ad_ItemChargeApplyDAO = ad_ItemChargeApply.GetInstanceThreadSafe;
			ad_ItemChargeApplyDAO = new ad_ChargeTypeApplyDAO();
		}

        public List<ad_ChargeTypeApply> GetByChargeTypeId(Int32 chargeTypeId)
		{
			try
			{
                return ad_ItemChargeApplyDAO.GetByChargeTypeId(chargeTypeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(ad_ChargeTypeApply ad_ItemChargeApply)
		{
			try
			{
				return ad_ItemChargeApplyDAO.Add(ad_ItemChargeApply);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
