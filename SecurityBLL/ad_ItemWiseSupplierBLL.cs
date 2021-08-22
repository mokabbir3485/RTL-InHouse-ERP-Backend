using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemWiseSupplierBLL //: IDisposible
	{
		public ad_ItemWiseSupplierDAO  ad_ItemWiseSupplierDAO { get; set; }

		public ad_ItemWiseSupplierBLL()
		{
			//ad_ItemWiseSupplierDAO = ad_ItemWiseSupplier.GetInstanceThreadSafe;
			ad_ItemWiseSupplierDAO = new ad_ItemWiseSupplierDAO();
		}

        public List<ad_ItemWiseSupplier> GetByItemId(Int32 itemId)
		{
			try
			{
				return ad_ItemWiseSupplierDAO.GetByItemId(itemId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemWiseSupplier ad_ItemWiseSupplier)
		{
			try
			{
				return ad_ItemWiseSupplierDAO.Add(ad_ItemWiseSupplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
