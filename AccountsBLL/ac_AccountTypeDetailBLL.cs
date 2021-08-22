using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using AccountsEntity;
using AccountsDAL;

namespace AccountsBLL
{
	public class ac_AccountTypeDetailBLL //: IDisposible
	{
		public ac_AccountTypeDetailDAO  ac_AccountTypeDetailDAO { get; set; }

		public ac_AccountTypeDetailBLL()
		{
			//ac_AccountTypeDetailDAO = ac_AccountTypeDetail.GetInstanceThreadSafe;
			ac_AccountTypeDetailDAO = new ac_AccountTypeDetailDAO();
		}

		public List<ac_AccountTypeDetail> GetAll()
		{
			try
			{
				return ac_AccountTypeDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountTypeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ac_AccountTypeDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountTypeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ac_AccountTypeDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ac_AccountTypeDetail _ac_AccountTypeDetail)
		{
			try
			{
				return ac_AccountTypeDetailDAO.Add(_ac_AccountTypeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ac_AccountTypeDetail _ac_AccountTypeDetail)
		{
			try
			{
				return ac_AccountTypeDetailDAO.Update(_ac_AccountTypeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 accountTypeDetailId)
		{
			try
			{
				return ac_AccountTypeDetailDAO.Delete(accountTypeDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
