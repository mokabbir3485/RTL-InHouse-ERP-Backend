using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
    public class inv_InternalWorkOrderDetailReportBLL
    {
        public inv_InternalWorkOrderDetailReportDAO inv_InternalWorkOrderDetailReportDAO { get; set; }

        public inv_InternalWorkOrderDetailReportBLL()
        {
            //inv_InternalWorkOrderDetailDAO = inv_InternalWorkOrderDetail.GetInstanceThreadSafe;
            inv_InternalWorkOrderDetailReportDAO = new inv_InternalWorkOrderDetailReportDAO();
        }

        public List<inv_InternalWorkOrderReport> GetByInternalWorkOrderId(Int64 internalWorkOrderId)
        {
            try
            {
                return inv_InternalWorkOrderDetailReportDAO.GetByInternalWorkOrderId(internalWorkOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
