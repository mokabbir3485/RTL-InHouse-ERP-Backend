using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseBillDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_PurchaseBillDetailAdAttributeDetailDAO  inv_PurchaseBillDetailAdAttributeDetailDAO { get; set; }

		public inv_PurchaseBillDetailAdAttributeDetailBLL()
		{
			//inv_PurchaseBillDetailAdAttributeDetailDAO = inv_PurchaseBillDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_PurchaseBillDetailAdAttributeDetailDAO = new inv_PurchaseBillDetailAdAttributeDetailDAO();
		}

		public List<inv_PurchaseBillDetailAdAttributeDetail> GetAll()
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttributeDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_PurchaseBillDetailAdAttributeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailAdAttributeDetail _inv_PurchaseBillDetailAdAttributeDetail)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.Add(_inv_PurchaseBillDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseBillDetailAdAttributeDetail _inv_PurchaseBillDetailAdAttributeDetail)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.Update(_inv_PurchaseBillDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PBDetailAdAttDetailId)
		{
			try
			{
				return inv_PurchaseBillDetailAdAttributeDetailDAO.Delete(PBDetailAdAttDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
