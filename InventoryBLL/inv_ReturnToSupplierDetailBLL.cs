using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnToSupplierDetailBLL //: IDisposible
	{
		public inv_ReturnToSupplierDetailDAO  inv_ReturnToSupplierDetailDAO { get; set; }

		public inv_ReturnToSupplierDetailBLL()
		{
			//inv_ReturnToSupplierDetailDAO = inv_ReturnToSupplierDetail.GetInstanceThreadSafe;
			inv_ReturnToSupplierDetailDAO = new inv_ReturnToSupplierDetailDAO();
		}

        public List<inv_ReturnToSupplierDetail> GetByReturnId(Int64 returnId)
        {
            try
            {
                return inv_ReturnToSupplierDetailDAO.GetByReturnId(returnId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public Int64 Add(inv_ReturnToSupplierDetail _inv_ReturnToSupplierDetail)
		{
			try
			{
				return inv_ReturnToSupplierDetailDAO.Add(_inv_ReturnToSupplierDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
