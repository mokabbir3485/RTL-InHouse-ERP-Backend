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
	public class inv_StockValuationTestBLL //: IDisposible
	{
		public inv_StockValuationTestDAO  inv_StockValuationTestDAO { get; set; }

        public inv_StockValuationTestBLL()
		{
			//inv_StockValuationTestDAO = inv_StockValuation.GetInstanceThreadSafe;
			inv_StockValuationTestDAO = new inv_StockValuationTestDAO();
		}

		public List<inv_StockValuation> GetAll()
		{
			try
			{
				return inv_StockValuationTestDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public inv_StockValuation GetByItemAndDepartment(Int32 ItemId, Int32 DepartmentId)
        {
            try
            {
                return inv_StockValuationTestDAO.GetByItemAndDepartment(ItemId, DepartmentId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetByItemCode(string itemCode)
        {
            try
            {
                return inv_StockValuationTestDAO.GetByItemCode(itemCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_StockValuationTest _inv_StockValuationTest)
		{
			try
			{
				return inv_StockValuationTestDAO.Add(_inv_StockValuationTest);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockValuation _inv_StockValuation)
		{
			try
			{
				return inv_StockValuationTestDAO.Update(_inv_StockValuation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateAdd(inv_StockValuation _inv_StockValuation)
        {
            try
            {
                return inv_StockValuationTestDAO.UpdateAdd(_inv_StockValuation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDeduct(inv_StockValuation _inv_StockValuation)
        {
            try
            {
                return inv_StockValuationTestDAO.UpdateDeduct(_inv_StockValuation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 ValuationId)
		{
			try
			{
				return inv_StockValuationTestDAO.Delete(ValuationId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
