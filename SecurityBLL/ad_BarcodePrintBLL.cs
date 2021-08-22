using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_BarcodePrintBLL //: IDisposible
	{
		public ad_BarcodePrintDAO  ad_BarcodePrintDAO { get; set; }

		public ad_BarcodePrintBLL()
		{
			//ad_BarcodePrintDAO = ad_BarcodePrint.GetInstanceThreadSafe;
			ad_BarcodePrintDAO = new ad_BarcodePrintDAO();
		}

		public Int64 Add(ad_BarcodePrint _ad_BarcodePrint)
		{
			try
			{
				return ad_BarcodePrintDAO.Add(_ad_BarcodePrint);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public Int64 AddForCustomer(ad_BarcodePrint _ad_BarcodePrint)
        {
            try
            {
                return ad_BarcodePrintDAO.AddForCustomer(_ad_BarcodePrint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
