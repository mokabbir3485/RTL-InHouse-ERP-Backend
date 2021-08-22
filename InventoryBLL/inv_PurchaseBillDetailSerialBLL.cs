using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;

namespace InventoryBLL
{
    public class inv_PurchaseBillDetailSerialBLL //: IDisposible
    {
        public inv_PurchaseBillDetailSerialDAO inv_PurchaseBillDetailSerialDAO { get; set; }

        public inv_PurchaseBillDetailSerialBLL()
        {
            //inv_PurchaseBillDetailSerialDAO = inv_PurchaseBillDetailSerial.GetInstanceThreadSafe;
            inv_PurchaseBillDetailSerialDAO = new inv_PurchaseBillDetailSerialDAO();
        }

        public List<inv_PurchaseBillDetailSerial> GetAll()
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBillDetailSerial> GetBySerialAndWarrantyId(Int64 PBDetailId)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.GetBySerialAndWarrantyId(PBDetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBillDetailSerial> LocalGetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.LocalGetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Add(inv_PurchaseBillDetailSerial _inv_PurchaseBillDetailSerial)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.Add(_inv_PurchaseBillDetailSerial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 AddForLocalPurchaseBill(inv_LocalPurchaseBillDetailSerial _inv_LocalPurchaseBillDetailSerial)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.AddForLocalPurchaseBill(_inv_LocalPurchaseBillDetailSerial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Update(inv_PurchaseBillDetailSerial _inv_PurchaseBillDetailSerial)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.Update(_inv_PurchaseBillDetailSerial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDepartment(Int64 pBDetailSerialId, int departmentId)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.UpdateDepartment(pBDetailSerialId, departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int LocalUpdateDepartment(Int64 LPBDetailSerialId, int departmentId)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.LocalUpdateDepartment(LPBDetailSerialId, departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 pBDetailSerialId)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.Delete(pBDetailSerialId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDelivered(Int64 pBDetailSerialId, Int64 deliveryDetailId)
        {
            try
            {
                return inv_PurchaseBillDetailSerialDAO.UpdateDelivered(pBDetailSerialId, deliveryDetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
