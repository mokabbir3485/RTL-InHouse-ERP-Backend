using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_InternalWorkOrderDetailBLL //: IDisposible
	{
		public inv_InternalWorkOrderDetailDAO  inv_InternalWorkOrderDetailDAO { get; set; }




		public inv_InternalWorkOrderDetailBLL()
		{
			//inv_InternalWorkOrderDetailDAO = inv_InternalWorkOrderDetail.GetInstanceThreadSafe;
			inv_InternalWorkOrderDetailDAO = new inv_InternalWorkOrderDetailDAO();
		}

        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderId(Int64 internalWorkOrderId)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.GetByInternalWorkOrderId(internalWorkOrderId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderIdForProduction(Int64 internalWorkOrderId)
        {
            try
            {
                return inv_InternalWorkOrderDetailDAO.GetByInternalWorkOrderIdForProduction(internalWorkOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetByInternalWorkOrderIdForRequisition(Int64 internalWorkOrderId)
        {
            try
            {
                return inv_InternalWorkOrderDetailDAO.GetByInternalWorkOrderIdForRequisition(internalWorkOrderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_InternalWorkOrderDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_InternalWorkOrderDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_InternalWorkOrderDetail _inv_InternalWorkOrderDetail)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.Add(_inv_InternalWorkOrderDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_InternalWorkOrderDetail _inv_InternalWorkOrderDetail)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.Update(_inv_InternalWorkOrderDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 internalWorkOrderDetailId)
		{
			try
			{
				return inv_InternalWorkOrderDetailDAO.Delete(internalWorkOrderDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
