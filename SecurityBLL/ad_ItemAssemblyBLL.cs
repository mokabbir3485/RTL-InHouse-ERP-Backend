using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemAssemblyBLL //: IDisposible
	{
		public ad_ItemAssemblyDAO  ad_ItemAssemblyDAO { get; set; }

		public ad_ItemAssemblyBLL()
		{
			//ad_ItemAssemblyDAO = ad_ItemAssembly.GetInstanceThreadSafe;
			ad_ItemAssemblyDAO = new ad_ItemAssemblyDAO();
		}

        public List<ad_ItemAssembly> GetByItemId(Int32 itemId)
		{
			try
			{
				return ad_ItemAssemblyDAO.GetByItemId(itemId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemAssembly ad_ItemAssembly)
		{
			try
			{
				return ad_ItemAssemblyDAO.Add(ad_ItemAssembly);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_ItemAssembly ad_ItemAssembly)
		{
			try
			{
				return ad_ItemAssemblyDAO.Update(ad_ItemAssembly);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 assemblyId)
		{
			try
			{
				return ad_ItemAssemblyDAO.Delete(assemblyId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
