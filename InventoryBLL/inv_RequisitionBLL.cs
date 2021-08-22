using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;
using System.Linq;

namespace InventoryBLL
{
	public class inv_RequisitionBLL //: IDisposible
	{
		public inv_RequisitionDAO  inv_RequisitionDAO { get; set; }

		public inv_RequisitionBLL()
		{
			//inv_RequisitionDAO = inv_Requisition.GetInstanceThreadSafe;
			inv_RequisitionDAO = new inv_RequisitionDAO();
		}

		public List<inv_Requisition> GetAll()
		{
			try
			{
				return inv_RequisitionDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_Requisition> GetTopForIssue(int topQty)
        {
            try
            {
                return inv_RequisitionDAO.GetTopForIssue(topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_Requisition GetById(Int64 requisitionId)
        {
            try
            {
                return inv_RequisitionDAO.GetAll(requisitionId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<inv_Requisition> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_RequisitionDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_Requisition> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_RequisitionDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_Requisition _inv_Requisition)
		{
			try
			{
				return inv_RequisitionDAO.Add(_inv_Requisition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_Requisition _inv_Requisition)
		{
			try
			{
				return inv_RequisitionDAO.Update(_inv_Requisition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateApprove(inv_Requisition _inv_Requisition)
        {
            try
            {
                return inv_RequisitionDAO.UpdateApprove(_inv_Requisition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 requisitionId)
		{
			try
			{
				return inv_RequisitionDAO.Delete(requisitionId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 GetGeneralMaxRequNoByDate(DateTime requDate)
        {
            try
            {
                return inv_RequisitionDAO.GetGeneralMaxRequNoByDate(requDate);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
	}
}
