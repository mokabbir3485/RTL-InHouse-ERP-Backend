using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeclarationBLL //: IDisposible
	{
		public inv_StockDeclarationDAO  inv_StockDeclarationDAO { get; set; }

		public inv_StockDeclarationBLL()
		{
			//inv_StockDeclarationDAO = inv_StockDeclaration.GetInstanceThreadSafe;
			inv_StockDeclarationDAO = new inv_StockDeclarationDAO();
		}

        public List<inv_StockDeclaration> GetAll(Int64? declarationId = null)
		{
			try
			{
                return inv_StockDeclarationDAO.GetAll(declarationId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeclaration> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return inv_StockDeclarationDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeclaration> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return inv_StockDeclarationDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_StockDeclaration _inv_StockDeclaration)
		{
			try
			{
				return inv_StockDeclarationDAO.Add(_inv_StockDeclaration);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StockDeclaration _inv_StockDeclaration)
		{
			try
			{
				return inv_StockDeclarationDAO.Update(_inv_StockDeclaration);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateApprove(inv_StockDeclaration _inv_StockDeclaration)
        {
            try
            {
                return inv_StockDeclarationDAO.UpdateApprove(_inv_StockDeclaration);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 declarationId)
		{
			try
			{
				return inv_StockDeclarationDAO.Delete(declarationId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
