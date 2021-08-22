using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ReceivableEntity;
using ReceivableDAL;

namespace ReceivableBLL
{
	public class rcv_SaleRealizationBLL //: IDisposible
	{
		public rcv_SaleRealizationDAO  rcv_SaleRealizationDAO { get; set; }

		public rcv_SaleRealizationBLL()
		{
			//rcv_SaleRealizationDAO = rcv_SaleRealization.GetInstanceThreadSafe;
			rcv_SaleRealizationDAO = new rcv_SaleRealizationDAO();
		}

		public List<rcv_SaleRealization> GetAll()
		{
			try
			{
				return rcv_SaleRealizationDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_SaleRealization> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return rcv_SaleRealizationDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_SaleRealization> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return rcv_SaleRealizationDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(rcv_SaleRealization _rcv_SaleRealization)
		{
			try
			{
				return rcv_SaleRealizationDAO.Add(_rcv_SaleRealization);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(rcv_SaleRealization _rcv_SaleRealization)
		{
			try
			{
				return rcv_SaleRealizationDAO.Update(_rcv_SaleRealization);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 realizationId)
		{
			try
			{
				return rcv_SaleRealizationDAO.Delete(realizationId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetCompanyTotals(int financialCycleId, int companyId)
        {
            try
            {
                return rcv_SaleRealizationDAO.GetCompanyTotals(financialCycleId, companyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
