using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnFromDepartmentDetailBLL //: IDisposible
	{
		public inv_ReturnFromDepartmentDetailDAO  inv_ReturnFromDepartmentDetailDAO { get; set; }

		public inv_ReturnFromDepartmentDetailBLL()
		{
			//inv_ReturnFromDepartmentDetailDAO = inv_ReturnFromDepartmentDetail.GetInstanceThreadSafe;
			inv_ReturnFromDepartmentDetailDAO = new inv_ReturnFromDepartmentDetailDAO();
		}

        public List<inv_ReturnFromDepartmentDetail> GetByReturnId(Int64 returnId)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.GetByReturnId(returnId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_ReturnFromDepartmentDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_ReturnFromDepartmentDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_ReturnFromDepartmentDetail _inv_ReturnFromDepartmentDetail)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.Add(_inv_ReturnFromDepartmentDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_ReturnFromDepartmentDetail _inv_ReturnFromDepartmentDetail)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.Update(_inv_ReturnFromDepartmentDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 returnDetailId)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailDAO.Delete(returnDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
