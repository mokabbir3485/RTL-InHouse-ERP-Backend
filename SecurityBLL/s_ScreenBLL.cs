using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class s_ScreenBLL //: IDisposible
	{
		public s_ScreenDAO  s_ScreenDAO { get; set; }

		public s_ScreenBLL()
		{
			//s_ScreenDAO = s_Screen.GetInstanceThreadSafe;
			s_ScreenDAO = new s_ScreenDAO();
		}

        public List<s_Screen> GetAll()
        {
            try
            {
                return s_ScreenDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<s_Screen> GetByModuleId(Int32 ModuleId)
		{
			try
			{
                return s_ScreenDAO.GetByModuleId(ModuleId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(s_Screen s_Screen)
		{
			try
			{
				return s_ScreenDAO.Add(s_Screen);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(s_Screen s_Screen)
		{
			try
			{
				return s_ScreenDAO.Update(s_Screen);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 screenId)
		{
			try
			{
				return s_ScreenDAO.Delete(screenId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
