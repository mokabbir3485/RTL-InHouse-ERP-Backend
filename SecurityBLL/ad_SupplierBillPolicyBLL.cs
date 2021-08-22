using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_SupplierBillPolicyBLL
	{
		public ad_SupplierBillPolicyDAO ad_SupplierBillPolicyDAO { get; set; }

        public ad_SupplierBillPolicyBLL()
		{
			ad_SupplierBillPolicyDAO = new ad_SupplierBillPolicyDAO();
		}

        public List<ad_SupplierBillPolicy> GetBySupplierId(Int32 supplierId)
		{
			try
			{
                return ad_SupplierBillPolicyDAO.GetBySupplierId(supplierId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public int Add(ad_SupplierBillPolicy ad_SupplierBillPolicy)
		{
			try
			{
                return ad_SupplierBillPolicyDAO.Add(ad_SupplierBillPolicy);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
