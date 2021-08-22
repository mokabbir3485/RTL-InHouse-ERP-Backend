using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class s_PermissionBLL //: IDisposible
	{
		public s_PermissionDAO  s_PermissionDAO { get; set; }

		public s_PermissionBLL()
		{
			//s_PermissionDAO = s_Permission.GetInstanceThreadSafe;
			s_PermissionDAO = new s_PermissionDAO();
		}

        public List<s_Permission> GetByRoleId(Int32 roleId)
		{
			try
			{
                return s_PermissionDAO.GetByRoleId(roleId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(s_Permission s_Permission)
		{
			try
			{
				return s_PermissionDAO.Add(s_Permission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(s_Permission s_Permission)
		{
			try
			{
				return s_PermissionDAO.Update(s_Permission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int DeleteByRoleId(Int64 roleId)
		{
			try
			{
                return s_PermissionDAO.DeleteByRoleId(roleId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
