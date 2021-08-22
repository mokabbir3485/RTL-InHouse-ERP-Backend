using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
    public class inv_StockDeliveryBLL //: IDisposible
    {
        public inv_StockDeliveryDAO inv_StockDeliveryDAO { get; set; }

        public inv_StockDeliveryBLL()
        {
            //inv_StockDeliveryDAO = inv_StockDelivery.GetInstanceThreadSafe;
            inv_StockDeliveryDAO = new inv_StockDeliveryDAO();
        }

        public List<inv_StockDelivery> GetAll(Int64? deliveryId = null)
        {
            try
            {
                return inv_StockDeliveryDAO.GetAll(deliveryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDelivery> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_StockDeliveryDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockDelivery> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_StockDeliveryDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockDelivery _inv_StockDelivery, ref string savedDeliveryNo)
        {
            try
            {
                return inv_StockDeliveryDAO.Add(_inv_StockDelivery, ref savedDeliveryNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_StockDelivery _inv_StockDelivery)
        {
            try
            {
                return inv_StockDeliveryDAO.Update(_inv_StockDelivery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockDelivery _inv_StockDelivery)
        {
            try
            {
                return inv_StockDeliveryDAO.UpdateApprove(_inv_StockDelivery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 deliveryId)
        {
            try
            {
                return inv_StockDeliveryDAO.Delete(deliveryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxDeliveryNo(DateTime deliveryDate)
        {
            try
            {
                return inv_StockDeliveryDAO.GetMaxDeliveryNo(deliveryDate);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public Int64 GetMaxDeliveryId()
        {
            try
            {
                return inv_StockDeliveryDAO.GetMaxDeliveryId();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
