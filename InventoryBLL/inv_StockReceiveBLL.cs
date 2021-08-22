using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryBLL
{
    public class inv_StockReceiveBLL //: IDisposible
    {
        public inv_StockReceiveDAO inv_StockReceiveDAO { get; set; }

        public inv_StockReceiveBLL()
        {
            //inv_StockReceiveDAO = inv_StockReceive.GetInstanceThreadSafe;
            inv_StockReceiveDAO = new inv_StockReceiveDAO();
        }

        public List<inv_StockReceive> GetAll()
        {
            try
            {
                return inv_StockReceiveDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockReceive GetById(Int64 SRId)
        {
            try
            {
                return inv_StockReceiveDAO.GetAll(SRId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceive> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_StockReceiveDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockReceive> GetTopForReturn(string whereCondition, string topQty)
        {
            try
            {
                return inv_StockReceiveDAO.GetTopForReturn(whereCondition, topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockReceive _inv_StockReceive, ref string savedReceiveNo)
        {
            try
            {
                return inv_StockReceiveDAO.Add(_inv_StockReceive, ref savedReceiveNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 StockRCAdd(inv_StockReceive _inv_StockReceive)
        {
            try
            {
                return inv_StockReceiveDAO.StockRCAdd(_inv_StockReceive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_StockReceive _inv_StockReceive)
        {
            try
            {
                return inv_StockReceiveDAO.Update(_inv_StockReceive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockReceive _inv_StockReceive)
        {
            try
            {
                return inv_StockReceiveDAO.UpdateApprove(_inv_StockReceive);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 SRId)
        {
            try
            {
                return inv_StockReceiveDAO.Delete(SRId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxStockReciveIdByDate(DateTime stockReciveDate)
        {
            try
            {
                return inv_StockReceiveDAO.GetMaxStockReciveIdByDate(stockReciveDate);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
