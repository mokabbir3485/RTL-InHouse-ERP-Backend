using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_DepartmentBLL //: IDisposible
	{
		public ad_DepartmentDAO  ad_DepartmentDAO { get; set; }

		public ad_DepartmentBLL()
		{
			//ad_DepartmentDAO = ad_Department.GetInstanceThreadSafe;
			ad_DepartmentDAO = new ad_DepartmentDAO();
		}

		public List<ad_Department> GetAll()
		{
			try
			{
				return ad_DepartmentDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Department> GetAllStore()
        {
            try
            {
                return ad_DepartmentDAO.GetAllStore();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllFactory()
        {
            try
            {
                return ad_DepartmentDAO.GetAllFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllUserDepartment(int userId)
        {
            try
            {
                return ad_DepartmentDAO.GetAllUserDepartment(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllActiveByBranchId(int branchId, Int32? departmentId = null)
        {
            try
            {
                return ad_DepartmentDAO.GetAllActiveByBranchId(branchId, departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ad_Department> GetByBranchAndGrade(int branchId, int gradeId, Int32? departmentId = null)
        {
	        try
	        {
		        return ad_DepartmentDAO.GetByBranchAndGrade(branchId, gradeId, departmentId);
	        }
	        catch (Exception ex)
	        {
		        throw ex;
	        }
        }
		public List<ad_Department> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return ad_DepartmentDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return ad_DepartmentDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_Department ad_Department)
		{
			try
			{
				return ad_DepartmentDAO.Add(ad_Department);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Department ad_Department)
		{
			try
			{
				return ad_DepartmentDAO.Update(ad_Department);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 departmentId)
		{
			try
			{
				return ad_DepartmentDAO.Delete(departmentId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
