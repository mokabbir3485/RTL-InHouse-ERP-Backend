using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SaleDetailFreeBLL //: IDisposible
	{
		public pos_SaleDetailFreeDAO  pos_SaleDetailFreeDAO { get; set; }

		public pos_SaleDetailFreeBLL()
		{
			//pos_SaleDetailFreeDAO = pos_SaleDetailFree.GetInstanceThreadSafe;
			pos_SaleDetailFreeDAO = new pos_SaleDetailFreeDAO();
		}

		public List<pos_SaleDetailFree> GetAll()
		{
			try
			{
				return pos_SaleDetailFreeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetailFree> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return pos_SaleDetailFreeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetailFree> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return pos_SaleDetailFreeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_SaleDetailFree _pos_SaleDetailFree)
		{
			try
			{
				return pos_SaleDetailFreeDAO.Add(_pos_SaleDetailFree);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_SaleDetailFree _pos_SaleDetailFree)
		{
			try
			{
				return pos_SaleDetailFreeDAO.Update(_pos_SaleDetailFree);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleDetailFreeId)
		{
			try
			{
				return pos_SaleDetailFreeDAO.Delete(saleDetailFreeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
