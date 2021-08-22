using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryBLL
{
    public class inv_StockValuationBLL //: IDisposible
    {
        public inv_StockValuationDAO inv_StockValuationDAO { get; set; }

        public inv_StockValuationBLL()
        {
            //inv_StockValuationDAO = inv_StockValuation.GetInstanceThreadSafe;
            inv_StockValuationDAO = new inv_StockValuationDAO();
        }

        public List<inv_StockValuation> GetAll()
        {
            try
            {
                return inv_StockValuationDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockValuation GetByItemAndDepartment(Int32 ItemId, Int32 DepartmentId)
        {
            try
            {
                return inv_StockValuationDAO.GetByItemAndDepartment(ItemId, DepartmentId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockValuation GetByItemAndUnitAndDepartment(Int32 itemId, Int32 unitId, Int32? departmentId = null)
        {
            try
            {
                return inv_StockValuationDAO.GetByItemAndUnitAndDepartment(itemId, unitId, departmentId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_StockValuation> GetByItemId(Int32 itemId)
        {
            try
            {
                return inv_StockValuationDAO.GetByItemId(itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetCurrentStockByItemCode(string itemCode)
        {
            try
            {
                return inv_StockValuationDAO.GetCurrentStockByItemCode(itemCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockValuation> GetCurrentStockByItemId(Int32 itemId)
        {
            try
            {
                return inv_StockValuationDAO.GetCurrentStockByItemId(itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockValuation> GetAll_CurrentStock()
        {
            try
            {
                return inv_StockValuationDAO.GetAll_CurrentStock();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(inv_StockValuation _inv_StockValuation)
        {
            try
            {
                return inv_StockValuationDAO.Add(_inv_StockValuation);
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
                return inv_StockValuationDAO.Update(_inv_StockValuation);
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
                return inv_StockValuationDAO.UpdateAdd(_inv_StockValuation);
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
                return inv_StockValuationDAO.UpdateDeduct(_inv_StockValuation);
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
                return inv_StockValuationDAO.Delete(ValuationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
