using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StockDeclarationDetailAdAttributeBLL //: IDisposible
	{
		public inv_StockDeclarationDetailAdAttributeDAO  inv_StockDeclarationDetailAdAttributeDAO { get; set; }

		public inv_StockDeclarationDetailAdAttributeBLL()
		{
			//inv_StockDeclarationDetailAdAttributeDAO = inv_StockDeclarationDetailAdAttribute.GetInstanceThreadSafe;
			inv_StockDeclarationDetailAdAttributeDAO = new inv_StockDeclarationDetailAdAttributeDAO();
		}

        public List<inv_StockDeclarationDetailAdAttribute> GetByDeclarationDetailId(Int64 declarationDetailId)
		{
			try
			{
				return inv_StockDeclarationDetailAdAttributeDAO.GetByDeclarationDetailId(declarationDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeclarationDetailAdAttribute _inv_StockDeclarationDetailAdAttribute)
		{
			try
			{
				return inv_StockDeclarationDetailAdAttributeDAO.Add(_inv_StockDeclarationDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
