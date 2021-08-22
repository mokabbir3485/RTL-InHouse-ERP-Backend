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
    public class inv_StockValuationAttributeBLL //: IDisposible
    {
        public inv_StockValuationAttributeDAO inv_StockValuationAttributeDAO { get; set; }

        public inv_StockValuationAttributeBLL()
        {
            //inv_StockValuationAttributeDAO = inv_StockValuationAttribute.GetInstanceThreadSafe;
            inv_StockValuationAttributeDAO = new inv_StockValuationAttributeDAO();
        }

        public List<inv_StockValuationAttribute> GetAll()
        {
            try
            {
                return inv_StockValuationAttributeDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockValuationAttribute GetByItemAndUnitAndDepartment(Int32 itemId, Int32 unitId, Int32? departmentId = null)
        {
            try
            {
                return inv_StockValuationAttributeDAO.GetByItemAndUnitAndDepartment(itemId, unitId, departmentId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockValuationAttribute> GetByDepartmentAndItemAddAttId(Int32 departmentId, string itemAddAttId)
        {
            try
            {
                return inv_StockValuationAttributeDAO.GetByDepartmentAndItemAddAttId(departmentId, itemAddAttId);
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
                return inv_StockValuationAttributeDAO.GetCurrentStockByItemCode(itemCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(inv_StockValuationAttribute _inv_StockValuationAttribute)
        {
            try
            {
                return inv_StockValuationAttributeDAO.Add(_inv_StockValuationAttribute);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_StockValuationAttribute _inv_StockValuationAttribute)
        {
            try
            {
                return inv_StockValuationAttributeDAO.Update(_inv_StockValuationAttribute);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateAdd(inv_StockValuationAttribute _inv_StockValuationAttribute)
        {
            try
            {
                return inv_StockValuationAttributeDAO.UpdateAdd(_inv_StockValuationAttribute);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDeduct(inv_StockValuationAttribute _inv_StockValuationAttribute)
        {
            try
            {
                return inv_StockValuationAttributeDAO.UpdateDeduct(_inv_StockValuationAttribute);
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
                return inv_StockValuationAttributeDAO.Delete(ValuationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
