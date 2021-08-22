using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnToSupplierDetailAdAttributeBLL //: IDisposible
	{
		public inv_ReturnToSupplierDetailAdAttributeDAO  inv_ReturnToSupplierDetailAdAttributeDAO { get; set; }

		public inv_ReturnToSupplierDetailAdAttributeBLL()
		{
			//inv_ReturnToSupplierDetailAdAttributeDAO = inv_ReturnToSupplierDetailAdAttribute.GetInstanceThreadSafe;
			inv_ReturnToSupplierDetailAdAttributeDAO = new inv_ReturnToSupplierDetailAdAttributeDAO();
		}

        public List<inv_ReturnToSupplierDetailAdAttribute> GetByReturnDetailId(Int64 returnDetailId)
		{
			try
			{
				return inv_ReturnToSupplierDetailAdAttributeDAO.GetByReturnDetailId(returnDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_ReturnToSupplierDetailAdAttribute _inv_ReturnToSupplierDetailAdAttribute)
		{
			try
			{
				return inv_ReturnToSupplierDetailAdAttributeDAO.Add(_inv_ReturnToSupplierDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
