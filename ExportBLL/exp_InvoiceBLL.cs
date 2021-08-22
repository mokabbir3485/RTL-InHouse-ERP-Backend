using ExportDAL;
using ExportEntity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ExportBLL
{
    public class exp_InvoiceBLL //: IDisposible
    {
        public exp_InvoiceDAO exp_InvoiceDAO { get; set; }

        public exp_InvoiceBLL()
        {
            //exp_InvoiceDAO = exp_Invoice.GetInstanceThreadSafe;
            exp_InvoiceDAO = new exp_InvoiceDAO();
        }

        public List<exp_Invoice> GetAll()
        {
            try
            {
                return exp_InvoiceDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_Invoice> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return exp_InvoiceDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<exp_Invoice> GetForCiUpdate(int CompanyId, Int64 CommercialInvoiceId)
        {
            try
            {
                return exp_InvoiceDAO.GetForCiUpdate(CompanyId, CommercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_Invoice> exp_Invoice_GetForEdit(DateTime fromDate, DateTime toDate, int? companyId)
        {
            try
            {
                return exp_InvoiceDAO.exp_Invoice_GetForEdit(fromDate, toDate, companyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_Invoice> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return exp_InvoiceDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_Item> GetItemByInvoice(int invoiceId)
        {
            try
            {
                return exp_InvoiceDAO.GetItemByInvoice(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxInvoiceNo(DateTime invoiceDate, Int32 ExporterId)
        {
            try
            {
                return exp_InvoiceDAO.GetMaxInvoiceNo(invoiceDate, ExporterId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_InvoiceDetail> InvoiceDetailGetBySalesOrderId(Int64 salesOrerId)
        {
            try
            {
                return exp_InvoiceDAO.InvoiceDetailGetBySalesOrderId(salesOrerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_InvoiceDetail> InvoiceDetailGetByInvoiceId(Int64 invoice)
        {
            try
            {
                return exp_InvoiceDAO.InvoiceDetailGetByInvoiceId(invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Add(exp_Invoice _exp_Invoice)
        {
            try
            {
                return exp_InvoiceDAO.Add(_exp_Invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Post(exp_Invoice _exp_Invoice)
        {
            try
            {
                return exp_InvoiceDAO.Post(_exp_Invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 AddDetail(exp_InvoiceDetail _exp_InvoiceDetail)
        {
            try
            {
                return exp_InvoiceDAO.AddDetail(_exp_InvoiceDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(exp_Invoice _exp_Invoice)
        {
            try
            {
                return exp_InvoiceDAO.Update(_exp_Invoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 invoiceId)
        {
            try
            {
                return exp_InvoiceDAO.Delete(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InvoiceDetailDeleteByInvoiceId(Int64 invoiceId)
        {
            try
            {
                return exp_InvoiceDAO.InvoiceDetailDeleteByInvoiceId(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 AddInvoiceDetailTableHtmletail(exp_InvoiceDetail_TableHtml _exp_InvoiceDetail_TableHtml)
        {
            try
            {
                return exp_InvoiceDAO.AddInvoiceDetailTableHtml(_exp_InvoiceDetail_TableHtml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 AddInvoiceDetailModifiedData(exp_InvoiceDetail_ModifiedData _exp_InvoiceDetail_ModifiedData)
        {
            try
            {
                return exp_InvoiceDAO.AddInvoiceDetailModifiedData(_exp_InvoiceDetail_ModifiedData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_InvoiceDetail_TableHtml> GetInvoiceDetailTableHtml(Int32? invoiceId = null)
        {
            try
            {
                return exp_InvoiceDAO.GetInvoiceDetailTableHtml(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_InvoiceDetail_ModifiedData> GetInvoiceDetailModifiedData(Int32? invoiceId = null)
        {
            try
            {
                return exp_InvoiceDAO.GetInvoiceDetailModifiedData(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteInvoiceDetailModifiedData(Int64 invoiceId)
        {
            try
            {
                return exp_InvoiceDAO.DeleteInvoiceDetailModifiedData(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList GetInvoiceDetailModifiedDataForUpdate(Int64 invoiceId)
        {
            try
            {
                return exp_InvoiceDAO.GetInvoiceDetailModifiedDataForUpdate(invoiceId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
