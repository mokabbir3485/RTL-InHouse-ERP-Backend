using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ExportEntity;
using ExportDAL;

namespace ExportBLL
{
	public class exp_BankDocumentDetailBLL //: IDisposible
	{
		public exp_BankDocumentDetailDAO  exp_BankDocumentDetailDAO { get; set; }

		public exp_BankDocumentDetailBLL()
		{
			//exp_BankDocumentDetailDAO = exp_BankDocumentDetail.GetInstanceThreadSafe;
			exp_BankDocumentDetailDAO = new exp_BankDocumentDetailDAO();
		}

		public List<exp_BankDocumentDetail> GetAll(Int64? bankDocumentDetailId = null, Int64? bankDocumentId = null)
		{
			try
			{
				return exp_BankDocumentDetailDAO.GetAll(bankDocumentDetailId, bankDocumentId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_BankDocumentDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return exp_BankDocumentDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_BankDocumentDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return exp_BankDocumentDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(exp_BankDocumentDetail _exp_BankDocumentDetail)
		{
			try
			{
				return exp_BankDocumentDetailDAO.Add(_exp_BankDocumentDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(exp_BankDocumentDetail _exp_BankDocumentDetail)
		{
			try
			{
				return exp_BankDocumentDetailDAO.Update(_exp_BankDocumentDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 bankDocumentDetailId)
		{
			try
			{
				return exp_BankDocumentDetailDAO.Delete(bankDocumentDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
