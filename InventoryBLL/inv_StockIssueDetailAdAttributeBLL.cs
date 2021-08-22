using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockIssueDetailAdAttributeBLL //: IDisposible
	{
		public inv_StockIssueDetailAdAttributeDAO  inv_StockIssueDetailAdAttributeDAO { get; set; }

		public inv_StockIssueDetailAdAttributeBLL()
		{
			//inv_StockIssueDetailAdAttributeDAO = inv_StockIssueDetailAdAttribute.GetInstanceThreadSafe;
			inv_StockIssueDetailAdAttributeDAO = new inv_StockIssueDetailAdAttributeDAO();
		}

        public List<inv_StockIssueDetailAdAttribute> GetByIssueDetailId(Int64 issueDetailId)
		{
			try
			{
				return inv_StockIssueDetailAdAttributeDAO.GetByIssueDetailId(issueDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_StockIssueDetailAdAttribute> GetByDepartmentAndItemId(Int32 departmentId, Int32 itemId)
        {
            try
            {
                return inv_StockIssueDetailAdAttributeDAO.GetByDepartmentAndItemId(departmentId, itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockIssueDetailAdAttribute _inv_StockIssueDetailAdAttribute)
		{
			try
			{
				return inv_StockIssueDetailAdAttributeDAO.Add(_inv_StockIssueDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
