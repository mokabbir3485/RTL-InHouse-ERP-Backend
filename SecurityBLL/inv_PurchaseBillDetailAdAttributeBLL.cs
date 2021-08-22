using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseBillDetailAdAttributeBLL //: IDisposible
	{
		public inv_PurchaseBillDetailAdAttributeDAO  inv_PurchaseBillDetailAdAttributeDAO { get; set; }

		public inv_PurchaseBillDetailAdAttributeBLL()
		{
			//inv_PurchaseBillDetailAdAttributeDAO = inv_PurchaseBillDetailAdAttribute.GetInstanceThreadSafe;
			inv_PurchaseBillDetailAdAttributeDAO = new inv_PurchaseBillDetailAdAttributeDAO();
		}

		public List<inv_PurchaseBillDetailAdAttribute> GetAll()
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttribute> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailAdAttribute _inv_PurchaseBillDetailAdAttribute)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.Add(_inv_PurchaseBillDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseBillDetailAdAttribute _inv_PurchaseBillDetailAdAttribute)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.Update(_inv_PurchaseBillDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PBDetailAdAttId)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDAO.Delete(PBDetailAdAttId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
