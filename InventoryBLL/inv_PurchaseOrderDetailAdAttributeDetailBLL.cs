using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseOrderDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_PurchaseOrderDetailAdAttributeDetailDAO  inv_PurchaseOrderDetailAdAttributeDetailDAO { get; set; }

		public inv_PurchaseOrderDetailAdAttributeDetailBLL()
		{
			//inv_PurchaseOrderDetailAdAttributeDetailDAO = inv_PurchaseOrderDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_PurchaseOrderDetailAdAttributeDetailDAO = new inv_PurchaseOrderDetailAdAttributeDetailDAO();
		}

		public List<inv_PurchaseOrderDetailAdAttributeDetail> GetAll()
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseOrderDetailAdAttributeDetail> GetByPODetailAdAttId(Int64 PODetailAdAttId)
        {
            try
            {
                return inv_PurchaseOrderDetailAdAttributeDetailDAO.GetByPODetailAdAttId(PODetailAdAttId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_PurchaseOrderDetailAdAttributeDetail GetByPODetailAdAttIdAndItemAddAttId(Int64 pODetailAdAttId, Int32 itemAddAttId)
        {
            try
            {
                return inv_PurchaseOrderDetailAdAttributeDetailDAO.GetByPODetailAdAttIdAndItemAddAttId(pODetailAdAttId, itemAddAttId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<inv_PurchaseOrderDetailAdAttributeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseOrderDetailAdAttributeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseOrderDetailAdAttributeDetail _inv_PurchaseOrderDetailAdAttributeDetail)
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.Add(_inv_PurchaseOrderDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseOrderDetailAdAttributeDetail _inv_PurchaseOrderDetailAdAttributeDetail)
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.Update(_inv_PurchaseOrderDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PODetailAdAttDetailId)
		{
			try
			{
				return inv_PurchaseOrderDetailAdAttributeDetailDAO.Delete(PODetailAdAttDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
