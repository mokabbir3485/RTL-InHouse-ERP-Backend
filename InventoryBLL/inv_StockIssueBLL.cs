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
	public class inv_StockIssueBLL //: IDisposible
	{
		public inv_StockIssueDAO  inv_StockIssueDAO { get; set; }
		public inv_StockIssueBLL()
		{
			//inv_StockIssueDAO = inv_StockIssue.GetInstanceThreadSafe;
			inv_StockIssueDAO = new inv_StockIssueDAO();
		}
        public List<inv_StockIssue> GetAll()
        {
            try
            {
                return inv_StockIssueDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public inv_StockIssue GetById(Int64 issueId)
        {
            try
            {
                return inv_StockIssueDAO.GetAll(issueId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockIssue> GetTopForReturn(string whereCondition, string topQty)
        {
            try
            {
                return inv_StockIssueDAO.GetTopForReturn(whereCondition, topQty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StockIssue> GetForDashboard()
        {
            try
            {
                return inv_StockIssueDAO.GetForDashboard();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<inv_StockIssue> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockIssueDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_StockIssue _inv_StockIssue)
		{
			try
			{
				return inv_StockIssueDAO.Add(_inv_StockIssue);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Update(inv_StockIssue _inv_StockIssue)
        {
            try
            {
                return inv_StockIssueDAO.Update(_inv_StockIssue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockIssue _inv_StockIssue)
        {
            try
            {
                return inv_StockIssueDAO.UpdateApprove(_inv_StockIssue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 GetMaxIssueNoByDate(DateTime issueDate)
        {
            try
            {
                return inv_StockIssueDAO.GetMaxIssueNoByDate(issueDate);
            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }
	}
}
