using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockReceiveExtraInfoBLL //: IDisposible
	{
		public inv_StockReceiveExtraInfoDAO  inv_StockReceiveExtraInfoDAO { get; set; }

		public inv_StockReceiveExtraInfoBLL()
		{
			//inv_StockReceiveExtraInfoDAO = inv_StockReceiveExtraInfo.GetInstanceThreadSafe;
			inv_StockReceiveExtraInfoDAO = new inv_StockReceiveExtraInfoDAO();
		}

		public List<inv_StockReceiveExtraInfo> GetAll()
		{
			try
			{
				return inv_StockReceiveExtraInfoDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockReceiveExtraInfo _inv_StockReceiveExtraInfo)
		{
			try
			{
				return inv_StockReceiveExtraInfoDAO.Add(_inv_StockReceiveExtraInfo);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockReceiveExtraInfo _inv_StockReceiveExtraInfo)
		{
			try
			{
				return inv_StockReceiveExtraInfoDAO.Update(_inv_StockReceiveExtraInfo);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 SRExtraInfoId)
		{
			try
			{
				return inv_StockReceiveExtraInfoDAO.Delete(SRExtraInfoId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
