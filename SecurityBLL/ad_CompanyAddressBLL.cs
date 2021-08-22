using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_CompanyAddressBLL //: IDisposible
	{
		public ad_CompanyAddressDAO  ad_CompanyAddressDAO { get; set; }

		public ad_CompanyAddressBLL()
		{
			//ad_CompanyAddressDAO = ad_CompanyAddress.GetInstanceThreadSafe;
			ad_CompanyAddressDAO = new ad_CompanyAddressDAO();
		}

        public List<ad_CompanyAddress> GetByCompanyId(Int32 companyId)
		{
			try
			{
				return ad_CompanyAddressDAO.GetByCompanyId(companyId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CompanyAddress _ad_CompanyAddress)
		{
			try
			{
				return ad_CompanyAddressDAO.Add(_ad_CompanyAddress);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
