using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace InventoryBLL
{
    public class inv_PurchaseBillBLL //: IDisposible
    {
        public inv_PurchaseBillDAO inv_PurchaseBillDAO { get; set; }

        public inv_PurchaseBillBLL()
        {
            //inv_PurchaseBillDAO = inv_PurchaseBill.GetInstanceThreadSafe;
            inv_PurchaseBillDAO = new inv_PurchaseBillDAO();
        }

        public List<inv_PurchaseBill> GetAll(Int64? PBId = null)
        {
            try
            {
                return inv_PurchaseBillDAO.GetAll(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> LocalGetAll(Int64? LPBId = null)
        {
            try
            {
                return inv_PurchaseBillDAO.LocalGetAll(LPBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<inv_PurchaseBill> GetBySupplierId(Int32 SupplierId)
        {
            try
            {
                return inv_PurchaseBillDAO.GetBySupplierId(SupplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBill> GetByLocalSupplierId(Int32 SupplierId)
        {
            try
            {
                return inv_PurchaseBillDAO.GetByLocalSupplierId(SupplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<inv_PurchaseBill> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_PurchaseBillDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> WarrantyAndSerialGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_PurchaseBillDAO.WarrantyAndSerialGetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_PurchaseBillDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> ImportGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_PurchaseBillDAO.ImportGetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBill> LocalGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_PurchaseBillDAO.LocalGetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetTopForReceive(int topQty)
        {
            try
            {
                return inv_PurchaseBillDAO.GetTopForReceive(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> GetTopForLocalReceive(int topQty)
        {
            try
            {
                return inv_PurchaseBillDAO.GetTopForLocalReceive(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetTopForWarrentyAndSerialNo(int topQty)
        {
            try
            {
                return inv_PurchaseBillDAO.GetTopForWarrentyAndSerialNo(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetTopForImportWarrentyAndSerialNo(int topQty)
        {
            try
            {
                return inv_PurchaseBillDAO.GetTopForImportWarrentyAndSerialNo(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> GetTopForLocalWarrentyAndSerialNo(int topQty)
        {
            try
            {
                return inv_PurchaseBillDAO.GetTopForLocalWarrentyAndSerialNo(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_PurchaseBill GetById(Int64 PBId)
        {
            try
            {
                return inv_PurchaseBillDAO.GetAll(PBId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_PurchaseBill _inv_PurchaseBill)
        {
            try
            {
                return inv_PurchaseBillDAO.Add(_inv_PurchaseBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 LocalPBAdd(inv_LocalPurchaseBill local_inv_PurchaseBill)
        {
            try
            {
                return inv_PurchaseBillDAO.LocalPBAdd(local_inv_PurchaseBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_PurchaseBill _inv_PurchaseBill)
        {
            try
            {
                return inv_PurchaseBillDAO.Update(_inv_PurchaseBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_PurchaseBill _inv_PurchaseBill)
        {
            try
            {
                return inv_PurchaseBillDAO.UpdateApprove(_inv_PurchaseBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 PBId)
        {
            try
            {
                return inv_PurchaseBillDAO.Delete(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DbDataReader GetMaxPurchaseBillNo()
        {
            try
            {
                return inv_PurchaseBillDAO.GetMaxPurchaseBillNo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DbDataReader GetMaxLocalPurchaseBillNo()
        {
            try
            {
                return inv_PurchaseBillDAO.GetMaxLocalPurchaseBillNo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Acknowledge(inv_PurchaseBill _inv_PurchaseBill)
        {
            try
            {
                return inv_PurchaseBillDAO.Acknowledge(_inv_PurchaseBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetForRealization(int financialCycleId, int supplierId)
        {
            try
            {
                return inv_PurchaseBillDAO.GetForRealization(financialCycleId, supplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill_Mushak> Get_Mushak6_1(int PBId)
        {
            try
            {
                return inv_PurchaseBillDAO.Get_Mushak6_1(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill_Mushak> Get_Mushak6_2(int PBId)
        {
            try
            {
                return inv_PurchaseBillDAO.Get_Mushak6_2(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<inv_LocalPurchaseBillDetail> GetLocalPB(Int64 LPBId)
        {
            try
            {
                return inv_PurchaseBillDAO.GetLocalPB(LPBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
