using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseBillOverHeadBLL //: IDisposible
	{
		public inv_PurchaseBillOverHeadDAO  inv_PurchaseBillOverHeadDAO { get; set; }

		public inv_PurchaseBillOverHeadBLL()
		{
			//inv_PurchaseBillOverHeadDAO = inv_PurchaseBillOverHead.GetInstanceThreadSafe;
			inv_PurchaseBillOverHeadDAO = new inv_PurchaseBillOverHeadDAO();
		}

		public List<inv_PurchaseBillOverHead> GetAll()
		{
			try
			{
				return inv_PurchaseBillOverHeadDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseBillOverHead> GetByPBId(Int64 PBId)
        {
            try
            {
                return inv_PurchaseBillOverHeadDAO.GetByPBId(PBId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseBillOverHead _inv_PurchaseBillOverHead)
		{
			try
			{
				return inv_PurchaseBillOverHeadDAO.Add(_inv_PurchaseBillOverHead);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseBillOverHead _inv_PurchaseBillOverHead)
		{
			try
			{
				return inv_PurchaseBillOverHeadDAO.Update(_inv_PurchaseBillOverHead);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PBOverHeadId)
		{
			try
			{
				return inv_PurchaseBillOverHeadDAO.Delete(PBOverHeadId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
