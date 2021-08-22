using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_TypeWiseDepartmentBLL //: IDisposible
	{
		public ad_TypeWiseDepartmentDAO  ad_TypeWiseDepartmentDAO { get; set; }

		public ad_TypeWiseDepartmentBLL()
		{
			//ad_TypeWiseDepartmentDAO = ad_TypeWiseDepartment.GetInstanceThreadSafe;
			ad_TypeWiseDepartmentDAO = new ad_TypeWiseDepartmentDAO();
		}

        public List<ad_TypeWiseDepartment> GetByDepartmentId(Int32 departmentId)
		{
			try
			{
                return ad_TypeWiseDepartmentDAO.GetByDepartmentId(departmentId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_TypeWiseDepartment ad_TypeWiseDepartment)
		{
			try
			{
				return ad_TypeWiseDepartmentDAO.Add(ad_TypeWiseDepartment);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
