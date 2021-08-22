using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeliveryDetailAdAttributeBLL //: IDisposible
	{
		public inv_StockDeliveryDetailAdAttributeDAO  inv_StockDeliveryDetailAdAttributeDAO { get; set; }

		public inv_StockDeliveryDetailAdAttributeBLL()
		{
			//inv_StockDeliveryDetailAdAttributeDAO = inv_StockDeliveryDetailAdAttribute.GetInstanceThreadSafe;
			inv_StockDeliveryDetailAdAttributeDAO = new inv_StockDeliveryDetailAdAttributeDAO();
		}

		public List<inv_StockDeliveryDetailAdAttribute> GetByDeliveryDetailId(Int64 deliveryDetailId)
		{
			try
			{
				return inv_StockDeliveryDetailAdAttributeDAO.GetByDeliveryDetailId(deliveryDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeliveryDetailAdAttribute _inv_StockDeliveryDetailAdAttribute)
		{
			try
			{
				return inv_StockDeliveryDetailAdAttributeDAO.Add(_inv_StockDeliveryDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
