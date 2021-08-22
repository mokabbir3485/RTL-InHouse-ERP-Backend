using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_AssetNatureBLL //: IDisposible
	{
		public ad_AssetNatureDAO  ad_AssetNatureDAO { get; set; }

		public ad_AssetNatureBLL()
		{
			//ad_AssetNatureDAO = ad_AssetNature.GetInstanceThreadSafe;
			ad_AssetNatureDAO = new ad_AssetNatureDAO();
		}

		public List<ad_AssetNature> GetAll()
		{
			try
			{
				return ad_AssetNatureDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_AssetNature ad_AssetNature)
		{
			try
			{
				return ad_AssetNatureDAO.Add(ad_AssetNature);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_AssetNature ad_AssetNature)
		{
			try
			{
				return ad_AssetNatureDAO.Update(ad_AssetNature);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 assetNatureId)
		{
			try
			{
				return ad_AssetNatureDAO.Delete(assetNatureId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
