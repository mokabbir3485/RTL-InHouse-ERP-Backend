using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeclarationDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_StockDeclarationDetailAdAttributeDetailDAO  inv_StockDeclarationDetailAdAttributeDetailDAO { get; set; }

		public inv_StockDeclarationDetailAdAttributeDetailBLL()
		{
			//inv_StockDeclarationDetailAdAttributeDetailDAO = inv_StockDeclarationDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_StockDeclarationDetailAdAttributeDetailDAO = new inv_StockDeclarationDetailAdAttributeDetailDAO();
		}

        public List<inv_StockDeclarationDetailAdAttributeDetail> GetByDeclarationDetailAdAttId(Int64 declarationDetailAdAttId)
		{
			try
			{
                return inv_StockDeclarationDetailAdAttributeDetailDAO.GetByDeclarationDetailAdAttId(declarationDetailAdAttId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeclarationDetailAdAttributeDetail _inv_StockDeclarationDetailAdAttributeDetail)
		{
			try
			{
				return inv_StockDeclarationDetailAdAttributeDetailDAO.Add(_inv_StockDeclarationDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
