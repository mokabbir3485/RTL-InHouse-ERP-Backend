using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class pro_ProductionDetailBLL //: IDisposible
	{
		public pro_ProductionDetailDAO  pro_ProductionDetailDAO { get; set; }

		public pro_ProductionDetailBLL()
		{
			//pro_ProductionDetailDAO = pro_ProductionDetail.GetInstanceThreadSafe;
			pro_ProductionDetailDAO = new pro_ProductionDetailDAO();
		}

		public List<pro_ProductionDetail> GetAll()
		{
			try
			{
				return pro_ProductionDetailDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pro_ProductionDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pro_ProductionDetailDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pro_ProductionDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pro_ProductionDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pro_ProductionDetail _pro_ProductionDetail)
		{
			try
			{
				return pro_ProductionDetailDAO.Add(_pro_ProductionDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pro_ProductionDetail _pro_ProductionDetail)
		{
			try
			{
				return pro_ProductionDetailDAO.Update(_pro_ProductionDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 productionDetailId)
		{
			try
			{
				return pro_ProductionDetailDAO.Delete(productionDetailId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
