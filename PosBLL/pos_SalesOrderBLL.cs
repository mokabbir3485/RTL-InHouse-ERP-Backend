using PosDAL;
using PosEntity;
using System;
using System.Collections.Generic;

namespace PosBLL
{
    public class pos_SalesOrderBLL //: IDisposable
    {
        public pos_SalesOrderDAO pos_SalesOrderDAO { get; set; }

        public pos_SalesOrderBLL()
        {
            //pos_SalesOrderDAO = pos_SalesOrder.GetInstanceThreadSafe;
            pos_SalesOrderDAO = new pos_SalesOrderDAO();
        }

        public List<pos_SalesOrder> GetAll()
        {
            try
            {
                return pos_SalesOrderDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return pos_SalesOrderDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrder> GetForPiUpdate(Int64 InvoiceId, Int32 CompanyId)
        {
            try
            {
                return pos_SalesOrderDAO.GetForPiUpdate(InvoiceId, CompanyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<pos_SalesOrder> pos_SalesOrderAmendment_GetForEdit(string approvalType, string approvalPassword)
        {
            try
            {
                return pos_SalesOrderDAO.pos_SalesOrderAmendment_GetForEdit(approvalType, approvalPassword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> SalesOrderGetForEdit(DateTime fromDate, DateTime toDate, int? companyId)
        {
            try
            {
                return pos_SalesOrderDAO.pos_SalesOrder_GetForEdit(fromDate, toDate, companyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> SalesOrderGetForPI(int companyId)
        {
            try
            {
                return pos_SalesOrderDAO.pos_SalesOrder_GetForPI(companyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return pos_SalesOrderDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pos_SalesOrder _pos_SalesOrder)
        {
            try
            {
                return pos_SalesOrderDAO.Add(_pos_SalesOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Acknowledge(pos_SalesOrder _pos_SalesOrder)
        {
            try
            {
                return pos_SalesOrderDAO.Acknowledge(_pos_SalesOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 salesOrderId)
        {
            try
            {
                return pos_SalesOrderDAO.Delete(salesOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxSalesOrderNo(DateTime salesOrderDate)
        {
            try
            {
                return pos_SalesOrderDAO.GetMaxSalesOrderNo(salesOrderDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetTopForDelivery(int topQty)
        {
            try
            {
                return pos_SalesOrderDAO.GetTopForDelivery(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrder> GetForRealization(int financialCycleId, int companyId)
        {
            try
            {
                return pos_SalesOrderDAO.GetForRealization(financialCycleId, companyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
