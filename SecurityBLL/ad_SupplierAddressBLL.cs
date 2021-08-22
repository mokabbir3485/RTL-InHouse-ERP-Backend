using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_SupplierAddressBLL
	{
		public ad_SupplierAddressDAO ad_SupplierAddressDAO { get; set; }

        public ad_SupplierAddressBLL()
		{
			ad_SupplierAddressDAO = new ad_SupplierAddressDAO();
		}

        public List<ad_SupplierAddress> GetAll()
        {
            try
            {
                return ad_SupplierAddressDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ad_SupplierAddress> GetBySupplierId(Int32 supplierId)
		{
			try
			{
                return ad_SupplierAddressDAO.GetBySupplierId(supplierId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public int Add(ad_SupplierAddress ad_SupplierAddress)
		{
			try
			{
                return ad_SupplierAddressDAO.Add(ad_SupplierAddress);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
