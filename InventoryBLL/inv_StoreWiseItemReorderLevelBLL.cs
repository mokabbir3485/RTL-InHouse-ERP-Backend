using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_StoreWiseItemReorderLevelBLL //: IDisposible
	{
		public inv_StoreWiseItemReorderLevelDAO  inv_StoreWiseItemReorderLevelDAO { get; set; }

		public inv_StoreWiseItemReorderLevelBLL()
		{
			//inv_StoreWiseItemReorderLevelDAO = inv_StoreWiseItemReorderLevel.GetInstanceThreadSafe;
			inv_StoreWiseItemReorderLevelDAO = new inv_StoreWiseItemReorderLevelDAO();
		}

		public List<inv_StoreWiseItemReorderLevel> GetAll()
		{
			try
			{
				return inv_StoreWiseItemReorderLevelDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_StoreWiseItemReorderLevel> Search(Int32 DepartmentId, Int32? CategoryId = null, Int32? SubcategoryId = null, Int32? ItemId = null)
        {
            try
            {
                return inv_StoreWiseItemReorderLevelDAO.Search(DepartmentId, CategoryId, SubcategoryId, ItemId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_StoreWiseItemReorderLevel> SearchForDashboard(Int32 DepartmentId)
        {
            try
            {
                return inv_StoreWiseItemReorderLevelDAO.SearchForDashboard(DepartmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_StoreWiseItemReorderLevel _inv_StoreWiseItemReorderLevel)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelDAO.Add(_inv_StoreWiseItemReorderLevel);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_StoreWiseItemReorderLevel _inv_StoreWiseItemReorderLevel)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelDAO.Update(_inv_StoreWiseItemReorderLevel);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 ReorderLevelId)
		{
			try
			{
				return inv_StoreWiseItemReorderLevelDAO.Delete(ReorderLevelId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
