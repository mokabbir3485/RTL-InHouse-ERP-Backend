using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;
using System.Linq;

namespace InventoryBLL
{
	public class inv_StockValuationSetupBLL //: IDisposible
	{
        public inv_StockValuationSetupDAO inv_StockValuationSetupDAO { get; set; }

		public inv_StockValuationSetupBLL()
		{
			//inv_StockValuationSetupDAO = inv_StockValuationSetup.GetInstanceThreadSafe;
            inv_StockValuationSetupDAO = new inv_StockValuationSetupDAO();
		}

		public List<inv_StockValuationSetup> GetAll()
		{
			try
			{
                List<inv_StockValuationSetup> lstinv_StockValuationSetup = inv_StockValuationSetupDAO.GetAll();
                //lstinv_StockValuationSetup = lstinv_StockValuationSetup.Where(c => c.ChargeTypeName != "Product Price").ToList();
                return lstinv_StockValuationSetup;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public inv_StockValuationSetup GetCurrent()
        {
            try
            {
                List<inv_StockValuationSetup> lstinv_StockValuationSetup = inv_StockValuationSetupDAO.GetAll();
                return lstinv_StockValuationSetup.FirstOrDefault(s => s.IsCurrent == true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockValuationSetup GetNext()
        {
            try
            {
                List<inv_StockValuationSetup> lstinv_StockValuationSetup = inv_StockValuationSetupDAO.GetAll();
                inv_StockValuationSetup stkValSetupCurrent = new inv_StockValuationSetup();
                stkValSetupCurrent = lstinv_StockValuationSetup.FirstOrDefault(s => s.IsCurrent == true);
                return lstinv_StockValuationSetup.FirstOrDefault(s => s.FinancialCycleId > stkValSetupCurrent.FinancialCycleId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_StockValuationSetup _inv_StockValuationSetup)
		{
			try
			{
				return inv_StockValuationSetupDAO.Add(_inv_StockValuationSetup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockValuationSetup _inv_StockValuationSetup)
		{
			try
			{
				return inv_StockValuationSetupDAO.Update(_inv_StockValuationSetup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ChargeTypeId)
		{
			try
			{
				return inv_StockValuationSetupDAO.Delete(ChargeTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
