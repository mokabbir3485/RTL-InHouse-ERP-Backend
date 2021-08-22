using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;
using System.Linq;

namespace SecurityBLL
{
	public class ad_ItemHsCodeBLL //: IDisposible
	{
		public ad_ItemHsCodeDAO  ad_ItemHsCodeDAO { get; set; }

		public ad_ItemHsCodeBLL()
		{
			//ad_ItemHsCodeDAO = ad_Item.GetInstanceThreadSafe;
			ad_ItemHsCodeDAO = new ad_ItemHsCodeDAO();
		}

		public List<ad_ItemHsCode> Get(Int32? hsCodeId = null)
		{
			try
			{
				return ad_ItemHsCodeDAO.Get(hsCodeId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        
	}
}
