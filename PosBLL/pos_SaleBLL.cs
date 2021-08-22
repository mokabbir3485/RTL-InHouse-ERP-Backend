using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SaleBLL //: IDisposible
	{
		public pos_SaleDAO  pos_SaleDAO { get; set; }

		public pos_SaleBLL()
		{
			//pos_SaleDAO = pos_Sale.GetInstanceThreadSafe;
			pos_SaleDAO = new pos_SaleDAO();
		}

		public List<pos_Sale> GetAll()
		{
			try
			{
				return pos_SaleDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Sale> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_SaleDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Sale> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_SaleDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public string Add(pos_Sale _pos_Sale)
		{
			try
			{
				return pos_SaleDAO.Add(_pos_Sale);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_Sale _pos_Sale)
		{
			try
			{
				return pos_SaleDAO.Update(_pos_Sale);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleId)
		{
			try
			{
				return pos_SaleDAO.Delete(saleId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetInvoiceNo(int terminalId, DateTime saleDate)
        {
            try
            {
                return pos_SaleDAO.GetInvoiceNo(terminalId, saleDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByInvoiceNo(string InvoiceNo)
        {
            try
            {
                return pos_SaleDAO.GetByInvoiceNo(InvoiceNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
