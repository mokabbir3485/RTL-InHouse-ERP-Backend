using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SalePaymentBLL //: IDisposible
	{
		public pos_SalePaymentDAO  pos_SalePaymentDAO { get; set; }

		public pos_SalePaymentBLL()
		{
			//pos_SalePaymentDAO = pos_SalePayment.GetInstanceThreadSafe;
			pos_SalePaymentDAO = new pos_SalePaymentDAO();
		}

		public List<pos_SalePayment> GetAll()
		{
			try
			{
				return pos_SalePaymentDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SalePayment> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_SalePaymentDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SalePayment> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_SalePaymentDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_SalePayment _pos_SalePayment)
		{
			try
			{
				return pos_SalePaymentDAO.Add(_pos_SalePayment);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_SalePayment _pos_SalePayment)
		{
			try
			{
				return pos_SalePaymentDAO.Update(_pos_SalePayment);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 salePaymentId)
		{
			try
			{
				return pos_SalePaymentDAO.Delete(salePaymentId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetSalePaymentByShift(int shiftId)
        {
            try
            {
                return pos_SalePaymentDAO.GetSalePaymentByShift(shiftId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
