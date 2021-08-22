using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_BranchBLL //: IDisposable
	{
		public ad_BranchDAO  ad_BranchDAO { get; set; }

		public ad_BranchBLL()
		{
			//ad_BranchDAO = ad_Branch.GetInstanceThreadSafe;
			ad_BranchDAO = new ad_BranchDAO();
		}

		public List<ad_Branch> GetAll()
		{
			try
			{
				return ad_BranchDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Branch> GetByUserId(int userId, Int32? BranchId = null)
        {
            try
            {
                return ad_BranchDAO.GetByUserId(userId, BranchId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Branch> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_BranchDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Branch> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_BranchDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Branch _ad_Branch)
		{
			try
			{
				return ad_BranchDAO.Add(_ad_Branch);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Branch _ad_Branch)
		{
			try
			{
				return ad_BranchDAO.Update(_ad_Branch);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 BranchId)
		{
			try
			{
				return ad_BranchDAO.Delete(BranchId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int SyncIn(Int32 BranchId)
        {
            try
            {
                return ad_BranchDAO.SyncIn(BranchId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SyncOut(Int32 BranchId)
        {
            try
            {
                return ad_BranchDAO.SyncOut(BranchId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
