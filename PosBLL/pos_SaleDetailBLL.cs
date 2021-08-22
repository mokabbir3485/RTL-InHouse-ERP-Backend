using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SaleDetailBLL //: IDisposible
	{
		public pos_SaleDetailDAO  pos_SaleDetailDAO { get; set; }

		public pos_SaleDetailBLL()
		{
			//pos_SaleDetailDAO = pos_SaleDetail.GetInstanceThreadSafe;
			pos_SaleDetailDAO = new pos_SaleDetailDAO();
		}

        public List<pos_SaleDetail> GetByInvoiceNo(string invoiceNo)
		{
			try
			{
				return pos_SaleDetailDAO.GetByInvoiceNo(invoiceNo);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_SaleDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_SaleDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_SaleDetail _pos_SaleDetail)
		{
			try
			{
				return pos_SaleDetailDAO.Add(_pos_SaleDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateIsVoid(pos_SaleDetail _pos_SaleDetail)
		{
			try
			{
				return pos_SaleDetailDAO.UpdateIsVoid(_pos_SaleDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleDetailId)
		{
			try
			{
				return pos_SaleDetailDAO.Delete(saleDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<pos_SaleDetail> GetByInvoiceNoForExchange(string invoiceNo)
        {
            try
            {
                return pos_SaleDetailDAO.GetByInvoiceNoForExchange(invoiceNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SaleDetail> GetFreeByInvoiceNo(string invoiceNo)
        {
            try
            {
                return pos_SaleDetailDAO.GetFreeByInvoiceNo(invoiceNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
