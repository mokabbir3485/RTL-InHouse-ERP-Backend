using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using AccountsEntity;
using AccountsDAL;

namespace AccountsBLL
{
	public class ac_AccountTypeBLL //: IDisposible
	{
		public ac_AccountTypeDAO  ac_AccountTypeDAO { get; set; }

		public ac_AccountTypeBLL()
		{
			//ac_AccountTypeDAO = ac_AccountType.GetInstanceThreadSafe;
			ac_AccountTypeDAO = new ac_AccountTypeDAO();
		}

		public List<ac_AccountType> GetAll()
		{
			try
			{
				return ac_AccountTypeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ac_AccountTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ac_AccountType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ac_AccountTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ac_AccountType _ac_AccountType)
		{
			try
			{
				return ac_AccountTypeDAO.Add(_ac_AccountType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ac_AccountType _ac_AccountType)
		{
			try
			{
				return ac_AccountTypeDAO.Update(_ac_AccountType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 accountTypeId)
		{
			try
			{
				return ac_AccountTypeDAO.Delete(accountTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
