using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_CashDepositBLL //: IDisposible
	{
		public pos_CashDepositDAO  pos_CashDepositDAO { get; set; }

		public pos_CashDepositBLL()
		{
			//pos_CashDepositDAO = pos_CashDeposit.GetInstanceThreadSafe;
			pos_CashDepositDAO = new pos_CashDepositDAO();
		}

		public List<pos_CashDeposit> GetAll()
		{
			try
			{
				return pos_CashDepositDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_CashDeposit> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_CashDepositDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_CashDeposit> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_CashDepositDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_CashDeposit _pos_CashDeposit)
		{
			try
			{
				return pos_CashDepositDAO.Add(_pos_CashDeposit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_CashDeposit _pos_CashDeposit)
		{
			try
			{
				return pos_CashDepositDAO.Update(_pos_CashDeposit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 depositId)
		{
			try
			{
				return pos_CashDepositDAO.Delete(depositId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
