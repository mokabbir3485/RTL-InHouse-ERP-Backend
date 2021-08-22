using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HrAndPayrollEntity;
using HrAndPayrollDAL;

namespace HrAndPayrollBLL
{
	public class hr_SalaryBLL //: IDisposible
	{
		public hr_SalaryDAO  hr_SalaryDAO { get; set; }

		public hr_SalaryBLL()
		{
			//hr_SalaryDAO = hr_Salary.GetInstanceThreadSafe;
			hr_SalaryDAO = new hr_SalaryDAO();
		}

        public List<hr_Salary> GetForPrepare(int monthId, int yearId, int gradeId)
		{
			try
			{
				return hr_SalaryDAO.GetForPrepare(monthId, yearId, gradeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<hr_Salary> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return hr_SalaryDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<hr_Salary> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return hr_SalaryDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Post(hr_Salary _hr_Salary)
		{
			try
			{
				return hr_SalaryDAO.Post(_hr_Salary);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(hr_Salary _hr_Salary)
		{
			try
			{
				return hr_SalaryDAO.Update(_hr_Salary);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 salaryId)
		{
			try
			{
				return hr_SalaryDAO.Delete(salaryId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
