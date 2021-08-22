using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_SupplierTypeBLL //: IDisposible
	{
		public ad_SupplierTypeDAO  ad_SupplierTypeDAO { get; set; }

		public ad_SupplierTypeBLL()
		{
			//ad_SupplierTypeDAO = ad_SupplierType.GetInstanceThreadSafe;
			ad_SupplierTypeDAO = new ad_SupplierTypeDAO();
		}

		public List<ad_SupplierType> GetAll()
		{
			try
			{
				return ad_SupplierTypeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_SupplierType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_SupplierTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_SupplierType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_SupplierTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_SupplierType _ad_SupplierType)
		{
			try
			{
				return ad_SupplierTypeDAO.Add(_ad_SupplierType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_SupplierType _ad_SupplierType)
		{
			try
			{
				return ad_SupplierTypeDAO.Update(_ad_SupplierType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 SupplierTypeId)
		{
			try
			{
				return ad_SupplierTypeDAO.Delete(SupplierTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
