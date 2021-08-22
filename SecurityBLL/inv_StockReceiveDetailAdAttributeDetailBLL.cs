using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockReceiveDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_StockReceiveDetailAdAttributeDetailDAO  inv_StockReceiveDetailAdAttributeDetailDAO { get; set; }

		public inv_StockReceiveDetailAdAttributeDetailBLL()
		{
			//inv_StockReceiveDetailAdAttributeDetailDAO = inv_StockReceiveDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_StockReceiveDetailAdAttributeDetailDAO = new inv_StockReceiveDetailAdAttributeDetailDAO();
		}

		public List<inv_StockReceiveDetailAdAttributeDetail> GetAll()
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttributeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockReceiveDetailAdAttributeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockReceiveDetailAdAttributeDetail _inv_StockReceiveDetailAdAttributeDetail)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.Add(_inv_StockReceiveDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockReceiveDetailAdAttributeDetail _inv_StockReceiveDetailAdAttributeDetail)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.Update(_inv_StockReceiveDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 SRDetailAdAttDetailId)
		{
			try
			{
				return inv_StockReceiveDetailAdAttributeDetailDAO.Delete(SRDetailAdAttDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
