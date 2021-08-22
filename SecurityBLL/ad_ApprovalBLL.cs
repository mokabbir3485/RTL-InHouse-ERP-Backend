using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;
using System.Linq;

namespace SecurityBLL
{
	public class ad_ApprovalBLL //: IDisposible
	{
		public ad_ApprovalDAO  ad_ApprovalDAO { get; set; }

		public ad_ApprovalBLL()
		{
			//ad_ApprovalDAO = ad_Approval.GetInstanceThreadSafe;
			ad_ApprovalDAO = new ad_ApprovalDAO();
		}

		public List<ad_Approval> GetAll()
		{
			try
			{
				return ad_ApprovalDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Approval> GetForApproval(Int32? moduleId = null)
        {
            try
            {
                return ad_ApprovalDAO.GetForApproval(moduleId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ad_Approval GetByScreenId(Int32 screenId)
        {
            try
            {
                return ad_ApprovalDAO.GetByScreenId(screenId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Approval> GetApprovedInventoryScreen()
        {
            try
            {
                return ad_ApprovalDAO.GetApprovedInventoryScreen();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Approval> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_ApprovalDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Approval> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_ApprovalDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Approval _ad_Approval)
		{
			try
			{
				return ad_ApprovalDAO.Add(_ad_Approval);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Approval _ad_Approval)
		{
			try
			{
				return ad_ApprovalDAO.Update(_ad_Approval);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 approvalId)
		{
			try
			{
				return ad_ApprovalDAO.Delete(approvalId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
