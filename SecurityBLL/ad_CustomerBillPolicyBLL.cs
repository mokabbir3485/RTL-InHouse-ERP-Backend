using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_CustomerBillPolicyBLL //: IDisposible
	{
		public ad_CustomerBillPolicyDAO  ad_CustomerBillPolicyDAO { get; set; }

		public ad_CustomerBillPolicyBLL()
		{
			//ad_CustomerBillPolicyDAO = ad_CustomerBillPolicy.GetInstanceThreadSafe;
			ad_CustomerBillPolicyDAO = new ad_CustomerBillPolicyDAO();
		}

        public List<ad_CustomerBillPolicy> GetByCustomerCode(string customerCode)
		{
			try
			{
                return ad_CustomerBillPolicyDAO.GetByCustomerCode(customerCode);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CustomerBillPolicy ad_CustomerBillPolicy)
		{
			try
			{
				return ad_CustomerBillPolicyDAO.Add(ad_CustomerBillPolicy);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
