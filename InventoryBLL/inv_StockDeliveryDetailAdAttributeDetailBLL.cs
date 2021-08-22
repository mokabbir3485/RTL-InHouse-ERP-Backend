using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeliveryDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_StockDeliveryDetailAdAttributeDetailDAO  inv_StockDeliveryDetailAdAttributeDetailDAO { get; set; }

		public inv_StockDeliveryDetailAdAttributeDetailBLL()
		{
			//inv_StockDeliveryDetailAdAttributeDetailDAO = inv_StockDeliveryDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_StockDeliveryDetailAdAttributeDetailDAO = new inv_StockDeliveryDetailAdAttributeDetailDAO();
		}

        public List<inv_StockDeliveryDetailAdAttributeDetail> GetByDeliveryDetailAdAttId(Int64 deliveryDetailAdAttId)
		{
			try
			{
				return inv_StockDeliveryDetailAdAttributeDetailDAO.GetByDeliveryDetailAdAttId(deliveryDetailAdAttId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeliveryDetailAdAttributeDetail _inv_StockDeliveryDetailAdAttributeDetail)
		{
			try
			{
				return inv_StockDeliveryDetailAdAttributeDetailDAO.Add(_inv_StockDeliveryDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
