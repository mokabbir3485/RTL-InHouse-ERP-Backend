using ExportDAL;
using ExportEntity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ExportBLL
{
    public class exp_CommercialInvoiceBLL //: IDisposible
    {
        public exp_CommercialInvoiceDAO exp_CommercialInvoiceDAO { get; set; }

        public exp_CommercialInvoiceBLL()
        {
            //exp_CommercialInvoiceDAO = exp_CommercialInvoice.GetInstanceThreadSafe;
            exp_CommercialInvoiceDAO = new exp_CommercialInvoiceDAO();
        }

        public List<exp_CommercialInvoice> GetAll()
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_CommercialInvoice> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_CommercialInvoice> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(exp_CommercialInvoice _exp_CommercialInvoice)
        {
            try
            {
                return exp_CommercialInvoiceDAO.Add(_exp_CommercialInvoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(exp_CommercialInvoice _exp_CommercialInvoice)
        {
            try
            {
                return exp_CommercialInvoiceDAO.Update(_exp_CommercialInvoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Post(exp_CommercialInvoice _exp_CommercialInvoice)
        {
            try
            {
                return exp_CommercialInvoiceDAO.Post(_exp_CommercialInvoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 AddDetail(exp_CommercialInvoiceDetail _exp_CommercialInvoiceDetail)
        {
            try
            {
                return exp_CommercialInvoiceDAO.AddDetail(_exp_CommercialInvoiceDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_CommercialInvoiceDetail> CommercialInvoiceDetailGetByCommercialInvoiceId(Int64 commercialInvoice)
        {
            try
            {
                return exp_CommercialInvoiceDAO.CommercialInvoiceDetailGetByCommercialInvoiceId(commercialInvoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.Delete(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateChallanGate(exp_CommercialInvoice _exp_CommercialInvoice)
        {
            try
            {
                return exp_CommercialInvoiceDAO.UpdateChallanGate(_exp_CommercialInvoice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_Item> GetItemByCI(Int64 ciId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetItemByCI(ciId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CommercialInvoiceDetailDeleteByCommercialInvoiceId(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.CommercialInvoiceDetailDeleteByCommercialInvoiceId(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //rakin
       
        public Int64 AddCommercialInvoiceDetailTableHtml(exp_CommercialInvoiceDetail_TableHtml _exp_CommercialInvoiceDetail_TableHtml)
        {
            try
            {
                return exp_CommercialInvoiceDAO.AddCommercialInvoiceDetailTableHtml(_exp_CommercialInvoiceDetail_TableHtml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 AddCommercialInvoiceDetailModifiedData(exp_CommercialInvoiceDetail_ModifiedData _exp_CommercialInvoiceDetail_ModifiedData)
        {
            try
            {
                return exp_CommercialInvoiceDAO.AddCommercialInvoiceDetailModifiedData(_exp_CommercialInvoiceDetail_ModifiedData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_CommercialInvoiceDetail_TableHtml> GetCommercialInvoiceDetailTableHtml(Int32? commercialInvoiceId = null)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetCommercialInvoiceDetailTableHtml(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_CommercialInvoiceDetail_ModifiedData> GetCommercialInvoiceDetailModifiedData(Int32? commercialInvoiceId = null)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetCommercialInvoiceDetailModifiedData(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteCommercialInvoiceDetailModifiedData(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.DeleteCommercialInvoiceDetailModifiedData(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
             public IList GetCommercialInvoiceDetailModifiedDataForCiUpdate(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetCommercialInvoiceDetailModifiedDataForCiUpdate(commercialInvoiceId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IList GetCommercialInvoiceDetailModifiedDataGetByInvoiceId(Int64 commercialInvoiceId)
        {
            try
            {
                return exp_CommercialInvoiceDAO.GetCommercialInvoiceDetailModifiedDataGetByInvoiceId(commercialInvoiceId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
