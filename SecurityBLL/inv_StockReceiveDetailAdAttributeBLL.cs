using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockReceiveDetailAdAttributeBLL //: IDisposible
	{
		public inv_StockReceiveDetailAdAttributeDAO  inv_StockReceiveDetailAdAttributeDAO { get; set; }

		public inv_StockReceiveDetailAdAttributeBLL()
		{
			//inv_StockReceiveDetailAdAttributeDAO = inv_StockReceiveDetailAdAttribute.GetInstanceThreadSafe;
			inv_StockReceiveDetailAdAttributeDAO = new inv_StockReceiveDetailAdAttributeDAO();
		}

		public List<inv_StockReceiveDetailAdAttribute> GetAll()
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttribute> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockReceiveDetailAdAttribute _inv_StockReceiveDetailAdAttribute)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.Add(_inv_StockReceiveDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockReceiveDetailAdAttribute _inv_StockReceiveDetailAdAttribute)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.Update(_inv_StockReceiveDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 SRDetailAdAttId)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDAO.Delete(SRDetailAdAttId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
