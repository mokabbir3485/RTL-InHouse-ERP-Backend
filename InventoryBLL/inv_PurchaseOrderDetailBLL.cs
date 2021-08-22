using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseOrderDetailBLL //: IDisposible
	{
		public inv_PurchaseOrderDetailDAO  inv_PurchaseOrderDetailDAO { get; set; }

		public inv_PurchaseOrderDetailBLL()
		{
			//inv_PurchaseOrderDetailDAO = inv_PurchaseOrderDetail.GetInstanceThreadSafe;
			inv_PurchaseOrderDetailDAO = new inv_PurchaseOrderDetailDAO();
		}

		public List<inv_PurchaseOrderDetail> GetAll()
		{
			try
			{
				return inv_PurchaseOrderDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseOrderDetail> GetByPOId(Int64 POId)
        {
            try
            {
                return inv_PurchaseOrderDetailDAO.GetByPOId(POId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseOrderDetail _inv_PurchaseOrderDetail)
		{
			try
			{
				return inv_PurchaseOrderDetailDAO.Add(_inv_PurchaseOrderDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseOrderDetail _inv_PurchaseOrderDetail)
		{
			try
			{
				return inv_PurchaseOrderDetailDAO.Update(_inv_PurchaseOrderDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PODetailId)
		{
			try
			{
				return inv_PurchaseOrderDetailDAO.Delete(PODetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
