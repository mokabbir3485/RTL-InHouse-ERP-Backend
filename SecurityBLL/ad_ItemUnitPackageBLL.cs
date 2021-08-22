using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_ItemUnitPackageBLL //: IDisposible
	{
		public ad_ItemUnitPackageDAO  ad_ItemUnitPackageDAO { get; set; }

		public ad_ItemUnitPackageBLL()
		{
			//ad_ItemUnitPackageDAO = ad_ItemUnitPackage.GetInstanceThreadSafe;
			ad_ItemUnitPackageDAO = new ad_ItemUnitPackageDAO();
		}

		public List<ad_ItemUnitPackage> GetAll()
		{
			try
			{
				return ad_ItemUnitPackageDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemUnitPackage ad_ItemUnitPackage)
		{
			try
			{
				return ad_ItemUnitPackageDAO.Add(ad_ItemUnitPackage);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_ItemUnitPackage ad_ItemUnitPackage)
		{
			try
			{
				return ad_ItemUnitPackageDAO.Update(ad_ItemUnitPackage);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 packageId)
		{
			try
			{
				return ad_ItemUnitPackageDAO.Delete(packageId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
