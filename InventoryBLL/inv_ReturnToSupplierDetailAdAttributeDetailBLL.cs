using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnToSupplierDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_ReturnToSupplierDetailAdAttributeDetailDAO  inv_ReturnToSupplierDetailAdAttributeDetailDAO { get; set; }

		public inv_ReturnToSupplierDetailAdAttributeDetailBLL()
		{
			//inv_ReturnToSupplierDetailAdAttributeDetailDAO = inv_ReturnToSupplierDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_ReturnToSupplierDetailAdAttributeDetailDAO = new inv_ReturnToSupplierDetailAdAttributeDetailDAO();
		}

        public List<inv_ReturnToSupplierDetailAdAttributeDetail> GetByReturnDetailAdAttId(Int64 returnDetailAdAttId)
		{
			try
			{
				return inv_ReturnToSupplierDetailAdAttributeDetailDAO.GetByReturnDetailAdAttId(returnDetailAdAttId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_ReturnToSupplierDetailAdAttributeDetail _inv_ReturnToSupplierDetailAdAttributeDetail)
		{
			try
			{
				return inv_ReturnToSupplierDetailAdAttributeDetailDAO.Add(_inv_ReturnToSupplierDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
