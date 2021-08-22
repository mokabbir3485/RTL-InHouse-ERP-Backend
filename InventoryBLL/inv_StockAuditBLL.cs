using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockAuditBLL //: IDisposible
	{
		public inv_StockAuditDAO  inv_StockAuditDAO { get; set; }

		public inv_StockAuditBLL()
		{
			//inv_StockAuditDAO = inv_StockAudit.GetInstanceThreadSafe;
			inv_StockAuditDAO = new inv_StockAuditDAO();
		}

		public List<inv_StockAudit> GetAll()
		{
			try
			{
				return inv_StockAuditDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockAudit> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockAuditDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockAudit> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_StockAuditDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockAudit _inv_StockAudit)
		{
			try
			{
				return inv_StockAuditDAO.Add(_inv_StockAudit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockAudit _inv_StockAudit)
		{
			try
			{
				return inv_StockAuditDAO.Update(_inv_StockAudit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 auditId)
		{
			try
			{
				return inv_StockAuditDAO.Delete(auditId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
