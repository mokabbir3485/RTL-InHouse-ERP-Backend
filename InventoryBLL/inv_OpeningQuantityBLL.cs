using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_OpeningQuantityBLL //: IDisposible
	{
		public inv_OpeningQuantityDAO  inv_OpeningQuantityDAO { get; set; }

		public inv_OpeningQuantityBLL()
		{
			//inv_OpeningQuantityDAO = inv_OpeningQuantity.GetInstanceThreadSafe;
			inv_OpeningQuantityDAO = new inv_OpeningQuantityDAO();
		}

		public List<inv_OpeningQuantity> GetAll()
		{
			try
			{
				return inv_OpeningQuantityDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_OpeningQuantity> Search(Int32 DepartmentId, Int32? CategoryId = null, Int32? SubcategoryId = null, Int32? ItemId = null)
        {
            try
            {
                return inv_OpeningQuantityDAO.Search(DepartmentId, CategoryId, SubcategoryId, ItemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_OpeningQuantity _inv_OpeningQuantity)
		{
			try
			{
				return inv_OpeningQuantityDAO.Add(_inv_OpeningQuantity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_OpeningQuantity _inv_OpeningQuantity)
		{
			try
			{
                if (string.IsNullOrEmpty(_inv_OpeningQuantity.OpeningPackageName))
                    _inv_OpeningQuantity.OpeningPackageName = "";
                if (string.IsNullOrEmpty(_inv_OpeningQuantity.OpeningContainerName))
                    _inv_OpeningQuantity.OpeningContainerName = "";
				return inv_OpeningQuantityDAO.Update(_inv_OpeningQuantity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 OpeningQtyId)
		{
			try
			{
				return inv_OpeningQuantityDAO.Delete(OpeningQtyId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
