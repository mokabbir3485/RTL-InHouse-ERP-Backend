using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnToSupplierBLL //: IDisposible
	{
		public inv_ReturnToSupplierDAO  inv_ReturnToSupplierDAO { get; set; }

		public inv_ReturnToSupplierBLL()
		{
			//inv_ReturnToSupplierDAO = inv_ReturnToSupplier.GetInstanceThreadSafe;
			inv_ReturnToSupplierDAO = new inv_ReturnToSupplierDAO();
		}

        public List<inv_ReturnToSupplier> GetAll(Int64? returnId = null)
        {
            try
            {
                return inv_ReturnToSupplierDAO.GetAll(returnId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public Int64 Add(inv_ReturnToSupplier _inv_ReturnToSupplier)
		{
			try
			{
				return inv_ReturnToSupplierDAO.Add(_inv_ReturnToSupplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Update(inv_ReturnToSupplier _inv_ReturnToSupplier)
        {
            try
            {
                return inv_ReturnToSupplierDAO.Update(_inv_ReturnToSupplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateApprove(inv_ReturnToSupplier _inv_ReturnToSupplier)
        {
            try
            {
                return inv_ReturnToSupplierDAO.UpdateApprove(_inv_ReturnToSupplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
