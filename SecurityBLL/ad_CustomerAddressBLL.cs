using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_CustomerAddressBLL //: IDisposible
	{
		public ad_CustomerAddressDAO  ad_CustomerAddressDAO { get; set; }

		public ad_CustomerAddressBLL()
		{
			//ad_CustomerAddressDAO = ad_CustomerAddress.GetInstanceThreadSafe;
			ad_CustomerAddressDAO = new ad_CustomerAddressDAO();
		}

        public List<ad_CustomerAddress> GetByCustomerCode(string customerCode)
		{
			try
			{
                return ad_CustomerAddressDAO.GetByCustomerCode(customerCode);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<ad_CustomerAddress> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return ad_CustomerAddressDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Add(ad_CustomerAddress ad_CustomerAddress)
		{
			try
			{
				return ad_CustomerAddressDAO.Add(ad_CustomerAddress);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
