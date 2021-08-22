using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;

namespace InventoryBLL
{
    public class proc_SupplierPaymentAndAdjustmentBLL
    {
        public proc_SupplierPaymentAndAdjustmentDAO proc_SupplierPaymentAndAdjustmentDAO { get; set; }

        public proc_SupplierPaymentAndAdjustmentBLL()
        {

            proc_SupplierPaymentAndAdjustmentDAO = new proc_SupplierPaymentAndAdjustmentDAO();
        }
        public List<proc_SupplierPaymentAdjustmentDetail> SupplierAdjustmentDetailGetById(Int64 SPAId)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.SupplierAdjustmentDetailGetById(SPAId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<proc_SupplierPaymentAdjustment> SupplierPaymentAdjustmemtGetBySupplierId(Int64 SupplierId)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.SupplierPaymentAdjustmentGetBySupplierId(SupplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<proc_SupplierPaymentAdjustment> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Post(proc_SupplierPaymentAdjustment _proc_SupplierPaymentAdjustment)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.Post(_proc_SupplierPaymentAdjustment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 PostDetail(proc_SupplierPaymentAdjustmentDetail proc_SupplierPaymentAdjustmentDetail)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.PostDetail(proc_SupplierPaymentAdjustmentDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int SupplierPaymentAdjustmentDetailDeleteBySPAId(Int64 SPAId)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.SupplierPaymentAdjustmentDetailDeleteBySPAId(SPAId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //SupplierPayment Part Start


        public List<proc_SupplierPayment> SupplierPaymentGetBySupplierId(Int32 SupplierId)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.SupplierPaymentGetBySupplierId(SupplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Int64 AddDetail(proc_SupplierPaymentDetail proc_SupplierPaymentDetail)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.AddDetail(proc_SupplierPaymentDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(proc_SupplierPayment proc_SupplierPayment)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.Add(proc_SupplierPayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public List<proc_SupplierLedger> SupplierLedger_Get(Int64 supplierId, string fromDate, string toDate)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.SupplierLedger_Get(supplierId, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<proc_SupplierPayment> proc_SupplierPayment_GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return proc_SupplierPaymentAndAdjustmentDAO.proc_SupplierPayment_GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
