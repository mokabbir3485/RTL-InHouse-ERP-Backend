using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemPriceByAttributeBLL //: IDisposible
	{
        public ad_ItemPriceByAttributeDAO ad_ItemAttPriceDAO { get; set; }

        public ad_ItemPriceByAttributeBLL()
		{
			//ad_ItemPriceDAO = ad_ItemPrice.GetInstanceThreadSafe;
            ad_ItemAttPriceDAO = new ad_ItemPriceByAttributeDAO();
		}

        public DataTable GetSinglePrice(Int32 transactionTypeId, Int32 priceTypeId, Int32 itemId, Int32 unitId)
        {
            try
            {
                return ad_ItemAttPriceDAO.GetSinglePrice(transactionTypeId, priceTypeId, itemId, unitId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(ad_ItemPriceByAttribute ad_ItemAttPrice)
		{
			try
			{
                return ad_ItemAttPriceDAO.Add(ad_ItemAttPrice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdatePrice(ad_ItemPriceByAttribute ad_ItemAttPrice)
		{
			try
			{
                return ad_ItemAttPriceDAO.UpdatePrice(ad_ItemAttPrice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int DeleteByItemId(Int32 itemId)
		{
			try
			{
                return ad_ItemAttPriceDAO.DeleteByItemId(itemId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetByItemId(int itemId)
        {
            try
            {
                return ad_ItemAttPriceDAO.GetByItemId(itemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
