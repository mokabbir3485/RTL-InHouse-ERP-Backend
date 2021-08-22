using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;

namespace InventoryBLL
{
    public class inv_PurchaseBillDetailBLL //: IDisposible
    {
        public inv_PurchaseBillDetailDAO inv_PurchaseBillDetailDAO { get; set; }

        public inv_PurchaseBillDetailBLL()
        {
            //inv_PurchaseBillDetailDAO = inv_PurchaseBillDetail.GetInstanceThreadSafe;
            inv_PurchaseBillDetailDAO = new inv_PurchaseBillDetailDAO();
        }

        public List<inv_PurchaseBillDetail> GetAll()
        {
            try
            {
                return inv_PurchaseBillDetailDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBillDetail> GetByPBId(Int64 PBId)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.GetByPBId(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBillDetail> LocalGetByPBId(Int64 LPBId)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.LocalGetByPBId(LPBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetail> GetSupplierLedger(Int32 supplierId, string fromDate, string toDate)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.GetSupplierLedger(supplierId, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_PurchaseBillDetail _inv_PurchaseBillDetail)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.Add(_inv_PurchaseBillDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 LocalPBDetailAdd(inv_LocalPurchaseBillDetail local_inv_PurchaseBillDetail)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.LocalPBDetailAdd(local_inv_PurchaseBillDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_PurchaseBillDetail _inv_PurchaseBillDetail)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.Update(_inv_PurchaseBillDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 PBDetailId)
        {
            try
            {
                return inv_PurchaseBillDetailDAO.Delete(PBDetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
