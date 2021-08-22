using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_DomainBLL //: IDisposible
	{
		public ad_DomainDAO  ad_DomainDAO { get; set; }

		public ad_DomainBLL()
		{
			//ad_DomainDAO = ad_Domain.GetInstanceThreadSafe;
			ad_DomainDAO = new ad_DomainDAO();
		}

		public List<ad_Domain> GetAll()
		{
			try
			{
				return ad_DomainDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Domain ad_Domain)
		{
			try
			{
				return ad_DomainDAO.Add(ad_Domain);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Domain ad_Domain)
		{
			try
			{
				return ad_DomainDAO.Update(ad_Domain);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 domainId)
		{
			try
			{
				return ad_DomainDAO.Delete(domainId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
