using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HrAndPayrollEntity;
using HrAndPayrollDAL;

namespace HrAndPayrollBLL
{
	public class hr_SalaryDetailBLL //: IDisposible
	{
		public hr_SalaryDetailDAO  hr_SalaryDetailDAO { get; set; }

		public hr_SalaryDetailBLL()
		{
			//hr_SalaryDetailDAO = hr_SalaryDetail.GetInstanceThreadSafe;
			hr_SalaryDetailDAO = new hr_SalaryDetailDAO();
		}

		public List<hr_SalaryDetail> GetForPrepare(int monthId, int yearId, int branchId, int gradeId, string departmentId, int sectionId)
		{
			try
			{
                return hr_SalaryDetailDAO.GetForPrepare(monthId, yearId, branchId,gradeId,departmentId,sectionId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<hr_SalaryDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return hr_SalaryDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<hr_SalaryDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return hr_SalaryDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Post(hr_SalaryDetail _hr_SalaryDetail)
		{
			try
			{
				return hr_SalaryDetailDAO.Post(_hr_SalaryDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(hr_SalaryDetail _hr_SalaryDetail)
		{
			try
			{
				return hr_SalaryDetailDAO.Update(_hr_SalaryDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 salaryDetailId)
		{
			try
			{
				return hr_SalaryDetailDAO.Delete(salaryDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
