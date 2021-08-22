using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ExportEntity;
using ExportDAL;

namespace ExportBLL
{
	public class exp_TruckChallanBLL //: IDisposible
	{
		public exp_TruckChallanDAO  exp_TruckChallanDAO { get; set; }

		public exp_TruckChallanBLL()
		{
			//exp_TruckChallanDAO = exp_TruckChallan.GetInstanceThreadSafe;
			exp_TruckChallanDAO = new exp_TruckChallanDAO();
		}

		public List<exp_TruckChallan> Get(Int64? CommercialInvoiceId)
		{
			try
			{
				return exp_TruckChallanDAO.Get(CommercialInvoiceId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Post(exp_TruckChallan _exp_TruckChallan)
		{
			try
			{
				return exp_TruckChallanDAO.Post(_exp_TruckChallan);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int DeleteTruckChallanByCommercialInvoiceId(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_TruckChallanDAO.DeleteTruckChallanByCommercialInvoiceId(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
