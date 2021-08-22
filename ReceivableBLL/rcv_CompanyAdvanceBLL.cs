using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ReceivableEntity;
using ReceivableDAL;

namespace ReceivableBLL
{
	public class rcv_CompanyAdvanceBLL //: IDisposible
	{
		public rcv_CompanyAdvanceDAO  rcv_CompanyAdvanceDAO { get; set; }

		public rcv_CompanyAdvanceBLL()
		{
			//rcv_CompanyAdvanceDAO = rcv_CompanyAdvance.GetInstanceThreadSafe;
			rcv_CompanyAdvanceDAO = new rcv_CompanyAdvanceDAO();
		}

		public List<rcv_CompanyAdvance> GetAll()
		{
			try
			{
				return rcv_CompanyAdvanceDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyAdvance> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return rcv_CompanyAdvanceDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<rcv_CompanyAdvance> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return rcv_CompanyAdvanceDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(rcv_CompanyAdvance _rcv_CompanyAdvance)
		{
			try
			{
				return rcv_CompanyAdvanceDAO.Add(_rcv_CompanyAdvance);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(rcv_CompanyAdvance _rcv_CompanyAdvance)
		{
			try
			{
				return rcv_CompanyAdvanceDAO.Update(_rcv_CompanyAdvance);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 advanceId)
		{
			try
			{
				return rcv_CompanyAdvanceDAO.Delete(advanceId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable CheckVoucherNoExists(string voucherNo)
        {
            try
            {
                return rcv_CompanyAdvanceDAO.CheckVoucherNoExists(voucherNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
