using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace InventoryBLL
{
    public class inv_BillOfMaterialBLL
    {
        public inv_BillOfMaterialDAO inv_BillOfMaterialDAO { get; set; }

        public inv_BillOfMaterialBLL()
        {

            inv_BillOfMaterialDAO = new inv_BillOfMaterialDAO();
        }
        public List<inv_BillOfMaterial> Get(Int64? BillOfMaterialId = null)
        {
            try
            {
                return inv_BillOfMaterialDAO.Get(BillOfMaterialId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_BillOfMaterialOverhead> OverheadGetAll(Int64? BOMId = null, string SectorType = null)
        {
            try
            {
                return inv_BillOfMaterialDAO.OverheadGetAll(BOMId, SectorType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_BillOfMaterialDetail> GetDetail(Int64? BOMId = null)
        {
            try
            {
                return inv_BillOfMaterialDAO.GetDetail(BOMId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_BillOfMaterial> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return inv_BillOfMaterialDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteOerheadByBOMId(Int64 BOMId)
        {
            try
            {
                return inv_BillOfMaterialDAO.DeleteOerheadByBOMId(BOMId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteDetailByBOMId(Int64 BOMId)
        {
            try
            {
                return inv_BillOfMaterialDAO.DeleteDetailByBOMId(BOMId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Post(inv_BillOfMaterial _inv_BillOfMaterial)
        {
            try
            {
                return inv_BillOfMaterialDAO.Post(_inv_BillOfMaterial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 PostDetail(inv_BillOfMaterialDetail _inv_BillOfMaterialDetail)
        {
            try
            {
                return inv_BillOfMaterialDAO.PostDetail(_inv_BillOfMaterialDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 PostOverhead(inv_BillOfMaterialOverhead _inv_BillOfMaterialOverhead)
        {
            try
            {
                return inv_BillOfMaterialDAO.PostOverhead(_inv_BillOfMaterialOverhead);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbDataReader GetMaxBillOfMaterialNo()
        {
            try
            {
                return inv_BillOfMaterialDAO.GetMaxBillOfMaterialNo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
