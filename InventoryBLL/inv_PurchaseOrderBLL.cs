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
	public class inv_PurchaseOrderBLL //: IDisposible
	{
		public inv_PurchaseOrderDAO  inv_PurchaseOrderDAO { get; set; }

		public inv_PurchaseOrderBLL()
		{
			//inv_PurchaseOrderDAO = inv_PurchaseOrder.GetInstanceThreadSafe;
			inv_PurchaseOrderDAO = new inv_PurchaseOrderDAO();
		}

        public List<inv_PurchaseOrder> GetAll(int? poId = null)
		{
			try
			{
				return inv_PurchaseOrderDAO.GetAll(poId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public inv_PurchaseOrder GetById(Int64 POId)
        {
            try
            {
                return inv_PurchaseOrderDAO.GetAll(POId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseOrder> GetTopForPurchaseBill(int topQty)
        {
            try
            {
                return inv_PurchaseOrderDAO.GetTopForPurchaseBill(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseOrder _inv_PurchaseOrder)
		{
			try
			{
				return inv_PurchaseOrderDAO.Add(_inv_PurchaseOrder);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseOrder _inv_PurchaseOrder)
		{
			try
			{
				return inv_PurchaseOrderDAO.Update(_inv_PurchaseOrder);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateApprove(inv_PurchaseOrder _inv_PurchaseOrder)
        {
            try
            {
                return inv_PurchaseOrderDAO.UpdateApprove(_inv_PurchaseOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 POId)
		{
			try
			{
				return inv_PurchaseOrderDAO.Delete(POId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
