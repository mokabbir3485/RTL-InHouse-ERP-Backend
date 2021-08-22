using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;

namespace InventoryBLL
{
    public class inv_InternalWorkOrderBLL //: IDisposible
    {
        public inv_InternalWorkOrderDAO inv_InternalWorkOrderDAO { get; set; }

        public inv_InternalWorkOrderBLL()
        {
            //inv_InternalWorkOrderDAO = inv_InternalWorkOrder.GetInstanceThreadSafe;
            inv_InternalWorkOrderDAO = new inv_InternalWorkOrderDAO();
        }

        public List<inv_InternalWorkOrder> GetAll()
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrder> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrder> inv_InternalWorkOrder_ForProduction()
        {
            try
            {
                return inv_InternalWorkOrderDAO.inv_InternalWorkOrder_ForProduction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrder> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_InternalWorkOrder _inv_InternalWorkOrder)
        {
            try
            {
                return inv_InternalWorkOrderDAO.Add(_inv_InternalWorkOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(inv_InternalWorkOrder _inv_InternalWorkOrder)
        {
            try
            {
                return inv_InternalWorkOrderDAO.Update(_inv_InternalWorkOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_InternalWorkOrder _inv_InternalWorkOrder)
        {
            try
            {
                return inv_InternalWorkOrderDAO.UpdateApprove(_inv_InternalWorkOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 internalWorkOrderId)
        {
            try
            {
                return inv_InternalWorkOrderDAO.Delete(internalWorkOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxInternalWorkerNo(DateTime iwDate)
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetMaxInternalWorkerNo(iwDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<inv_InternalWorkOrder> GetBy_inv_CIFProductReports(Int64 CompanyId, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetBy_inv_CIFProductReports(CompanyId, startDate, endDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_InternalWorkOrder> GetBy_inv_CIFCustomerReports(Int64 CompanyId)
        {
            try
            {
                return inv_InternalWorkOrderDAO.GetBy_inv_CIFCustomerReports(CompanyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
