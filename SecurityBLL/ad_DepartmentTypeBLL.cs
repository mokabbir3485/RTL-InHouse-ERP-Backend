using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_DepartmentTypeBLL //: IDisposible
	{
		public ad_DepartmentTypeDAO  ad_DepartmentTypeDAO { get; set; }

		public ad_DepartmentTypeBLL()
		{
			//ad_DepartmentTypeDAO = ad_DepartmentType.GetInstanceThreadSafe;
			ad_DepartmentTypeDAO = new ad_DepartmentTypeDAO();
		}

		public List<ad_DepartmentType> GetAll()
		{
			try
			{
				return ad_DepartmentTypeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_DepartmentType ad_DepartmentType)
		{
			try
			{
				return ad_DepartmentTypeDAO.Add(ad_DepartmentType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_DepartmentType ad_DepartmentType)
		{
			try
			{
				return ad_DepartmentTypeDAO.Update(ad_DepartmentType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 departmentTypeId)
		{
			try
			{
				return ad_DepartmentTypeDAO.Delete(departmentTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
