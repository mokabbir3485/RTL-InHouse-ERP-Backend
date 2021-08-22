using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemWiseItemStateBLL //: IDisposible
	{
		public ad_ItemWiseItemStateDAO  ad_ItemWiseItemStateDAO { get; set; }

		public ad_ItemWiseItemStateBLL()
		{
			//ad_ItemWiseItemStateDAO = ad_ItemWiseItemState.GetInstanceThreadSafe;
			ad_ItemWiseItemStateDAO = new ad_ItemWiseItemStateDAO();
		}

        public List<ad_ItemWiseItemState> GetByItemId(Int32 itemId)
		{
			try
			{
				return ad_ItemWiseItemStateDAO.GetByItemId(itemId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemWiseItemState ad_ItemWiseItemState)
		{
			try
			{
				return ad_ItemWiseItemStateDAO.Add(ad_ItemWiseItemState);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_ItemWiseItemState ad_ItemWiseItemState)
		{
			try
			{
				return ad_ItemWiseItemStateDAO.Update(ad_ItemWiseItemState);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 itemWiseItemStateId)
		{
			try
			{
				return ad_ItemWiseItemStateDAO.Delete(itemWiseItemStateId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
