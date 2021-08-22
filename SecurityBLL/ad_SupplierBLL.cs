using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
	public class ad_SupplierBLL //: IDisposible
	{
		public ad_SupplierDAO  ad_SupplierDAO { get; set; }

		public ad_SupplierBLL()
		{
			//ad_SupplierDAO = ad_Supplier.GetInstanceThreadSafe;
			ad_SupplierDAO = new ad_SupplierDAO();
		}

		public List<ad_Supplier> GetAll()
		{
			try
			{
				return ad_SupplierDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_Supplier> GetById(int supplierId)
        {
            try
            {
                return ad_SupplierDAO.GetAll(supplierId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_Supplier> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_SupplierDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_Supplier> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_SupplierDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_Supplier _ad_Supplier)
		{
			try
			{
				return ad_SupplierDAO.Add(_ad_Supplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_Supplier _ad_Supplier)
		{
			try
			{
				return ad_SupplierDAO.Update(_ad_Supplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 SupplierId)
		{
			try
			{
				return ad_SupplierDAO.Delete(SupplierId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
