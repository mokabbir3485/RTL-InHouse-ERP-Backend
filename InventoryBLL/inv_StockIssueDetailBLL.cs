using InventoryDAL;
using InventoryEntity;
using System;
using System.Collections.Generic;

namespace InventoryBLL
{
    public class inv_StockIssueDetailBLL //: IDisposible
    {
        public inv_StockIssueDetailDAO inv_StockIssueDetailDAO { get; set; }

        public inv_StockIssueDetailBLL()
        {
            //inv_StockIssueDetailDAO = inv_StockIssueDetail.GetInstanceThreadSafe;
            inv_StockIssueDetailDAO = new inv_StockIssueDetailDAO();
        }

        public List<inv_StockIssueDetail> GetByIssueId(Int64 issueId)
        {
            try
            {
                return inv_StockIssueDetailDAO.GetByIssueId(issueId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            try
            {
                return inv_StockIssueDetailDAO.Add(_inv_StockIssueDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 AddConsume(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            try
            {
                return inv_StockIssueDetailDAO.AddConsume(_inv_StockIssueDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_StockIssueDetail _inv_StockIssueDetail)
        {
            try
            {
                return inv_StockIssueDetailDAO.UpdateApprove(_inv_StockIssueDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
