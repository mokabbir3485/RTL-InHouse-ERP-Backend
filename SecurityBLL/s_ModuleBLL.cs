using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class s_ModuleBLL //: IDisposible
	{
		public s_ModuleDAO  s_ModuleDAO { get; set; }

		public s_ModuleBLL()
		{
			//s_ModuleDAO = s_Module.GetInstanceThreadSafe;
			s_ModuleDAO = new s_ModuleDAO();
		}

        public List<s_Module> GetByDomainId(Int32 domainId)
		{
			try
			{
                return s_ModuleDAO.GetByDomainId(domainId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<s_Module> GetActive()
        {
            try
            {
                return s_ModuleDAO.GetActive();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<s_Module> GetExAdminSecurity()
        {
            try
            {
                return s_ModuleDAO.GetExAdminSecurity();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(s_Module s_Module)
		{
			try
			{
				return s_ModuleDAO.Add(s_Module);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(s_Module s_Module)
		{
			try
			{
				return s_ModuleDAO.Update(s_Module);
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
                return s_ModuleDAO.Delete(domainId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
