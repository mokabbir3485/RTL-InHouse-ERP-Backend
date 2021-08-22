using PosDAL;
using PosEntity;
using System;
using System.Collections.Generic;

namespace PosBLL
{
    public class pos_SalesOrderDetailBLL //: IDisposible
    {
        public pos_SalesOrderDetailDAO pos_SalesOrderDetailDAO { get; set; }

        public pos_SalesOrderDetailBLL()
        {
            //pos_SalesOrderDetailDAO = pos_SalesOrderDetail.GetInstanceThreadSafe;
            pos_SalesOrderDetailDAO = new pos_SalesOrderDetailDAO();
        }

        public List<pos_SalesOrderDetail> GetBySalesOrderId(Int64 salesOrderId)
        {
            try
            {
                return pos_SalesOrderDetailDAO.GetBySalesOrderId(salesOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return pos_SalesOrderDetailDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return pos_SalesOrderDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            try
            {
                return pos_SalesOrderDetailDAO.Add(_pos_SalesOrderDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            try
            {
                return pos_SalesOrderDetailDAO.Update(_pos_SalesOrderDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOrderQty(pos_SalesOrderDetail _pos_SalesOrderDetail)
        {
            try
            {
                return pos_SalesOrderDetailDAO.UpdateOrderQty(_pos_SalesOrderDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 salesOrderDetailId)
        {
            try
            {
                return pos_SalesOrderDetailDAO.Delete(salesOrderDetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetInvoiceDetail(Int64 invoiceId)
        {
            try
            {
                return pos_SalesOrderDetailDAO.GetInvoiceDetail(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SalesOrderDetail> GetItemForIWO(Int64 salesOrderId)
        {
            try
            {
                return pos_SalesOrderDetailDAO.GetItemForIWO(salesOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
