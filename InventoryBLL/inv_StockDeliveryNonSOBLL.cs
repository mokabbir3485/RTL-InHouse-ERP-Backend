using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeliveryNonSOBLL //: IDisposible
	{
		public inv_StockDeliveryNonSODAO  inv_StockDeliveryNonSODAO { get; set; }

		public inv_StockDeliveryNonSOBLL()
		{
			//inv_StockDeliveryNonSODAO = inv_StockDeliveryNonSO.GetInstanceThreadSafe;
			inv_StockDeliveryNonSODAO = new inv_StockDeliveryNonSODAO();
		}

		public List<inv_StockDeliveryNonSO> GetAll()
		{
			try
			{
				return inv_StockDeliveryNonSODAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeliveryNonSO> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockDeliveryNonSODAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeliveryNonSO> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_StockDeliveryNonSODAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_StockDeliveryNonSO _inv_StockDeliveryNonSO)
		{
			try
			{
				return inv_StockDeliveryNonSODAO.Add(_inv_StockDeliveryNonSO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockDeliveryNonSO _inv_StockDeliveryNonSO)
		{
			try
			{
				return inv_StockDeliveryNonSODAO.Update(_inv_StockDeliveryNonSO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 deliveryId)
		{
			try
			{
				return inv_StockDeliveryNonSODAO.Delete(deliveryId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
