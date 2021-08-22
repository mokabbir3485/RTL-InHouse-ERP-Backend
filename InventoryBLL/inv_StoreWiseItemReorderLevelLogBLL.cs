using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StoreWiseItemReorderLevelLogBLL //: IDisposible
	{
		public inv_StoreWiseItemReorderLevelLogDAO  inv_StoreWiseItemReorderLevelLogDAO { get; set; }

		public inv_StoreWiseItemReorderLevelLogBLL()
		{
			//inv_StoreWiseItemReorderLevelLogDAO = inv_StoreWiseItemReorderLevelLog.GetInstanceThreadSafe;
			inv_StoreWiseItemReorderLevelLogDAO = new inv_StoreWiseItemReorderLevelLogDAO();
		}

		public List<inv_StoreWiseItemReorderLevelLog> GetAll()
		{
			try
			{
				return inv_StoreWiseItemReorderLevelLogDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StoreWiseItemReorderLevelLog _inv_StoreWiseItemReorderLevelLog)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelLogDAO.Add(_inv_StoreWiseItemReorderLevelLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StoreWiseItemReorderLevelLog _inv_StoreWiseItemReorderLevelLog)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelLogDAO.Update(_inv_StoreWiseItemReorderLevelLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 ReorderLevelLogId)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelLogDAO.Delete(ReorderLevelLogId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
