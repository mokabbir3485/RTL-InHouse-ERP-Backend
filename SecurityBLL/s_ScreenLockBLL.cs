using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class s_ScreenLockBLL //: IDisposible
	{
		public s_ScreenLockDAO  s_ScreenLockDAO { get; set; }

		public s_ScreenLockBLL()
		{
			//s_ScreenLockDAO = s_ScreenLock.GetInstanceThreadSafe;
			s_ScreenLockDAO = new s_ScreenLockDAO();
		}

        public List<s_ScreenLock> GetByUserAndScreen(Int32 userId, Int32 screenId)
		{
			try
			{
				return s_ScreenLockDAO.GetByUserAndScreen(userId, screenId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(s_ScreenLock s_ScreenLock)
		{
			try
			{
				return s_ScreenLockDAO.Add(s_ScreenLock);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UnLockAll(Int32 userId)
		{
			try
			{
				return s_ScreenLockDAO.UnLockAll(userId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 screenLockId)
		{
			try
			{
				return s_ScreenLockDAO.Delete(screenLockId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
