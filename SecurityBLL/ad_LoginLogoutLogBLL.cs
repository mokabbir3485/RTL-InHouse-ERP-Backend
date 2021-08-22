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
	public class ad_LoginLogoutLogBLL //: IDisposible
	{
		public ad_LoginLogoutLogDAO  ad_LoginLogoutLogDAO { get; set; }

		public ad_LoginLogoutLogBLL()
		{
			//ad_LoginLogoutLogDAO = ad_LoginLogoutLog.GetInstanceThreadSafe;
			ad_LoginLogoutLogDAO = new ad_LoginLogoutLogDAO();
		}

        public List<ad_LoginLogoutLog> GetByUserId(Int32 userId)
		{
			try
			{
                return ad_LoginLogoutLogDAO.GetByUserId(userId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public ad_LoginLogoutLog GetLastByUserId(Int32 userId)
        {
            try
            {
                return ad_LoginLogoutLogDAO.GetByUserId(userId).LastOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Add(ad_LoginLogoutLog ad_LoginLogoutLog)
		{
			try
			{
				return ad_LoginLogoutLogDAO.Add(ad_LoginLogoutLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int UpdateLogout(ad_LoginLogoutLog ad_LoginLogoutLog)
		{
			try
			{
                return ad_LoginLogoutLogDAO.UpdateLogout(ad_LoginLogoutLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
