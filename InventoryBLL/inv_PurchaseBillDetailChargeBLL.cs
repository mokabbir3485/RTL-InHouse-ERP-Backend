using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_PurchaseBillDetailChargeBLL //: IDisposible
	{
		public inv_PurchaseBillDetailChargeDAO  inv_PurchaseBillDetailChargeDAO { get; set; }

		public inv_PurchaseBillDetailChargeBLL()
		{
			//inv_PurchaseBillDetailChargeDAO = inv_PurchaseBillDetailCharge.GetInstanceThreadSafe;
			inv_PurchaseBillDetailChargeDAO = new inv_PurchaseBillDetailChargeDAO();
		}

        public List<inv_PurchaseBillDetailCharge> GetByPBDetailId(Int64 PBDetailId)
		{
			try
			{
				return inv_PurchaseBillDetailChargeDAO.GetByPBDetailId(PBDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailCharge _inv_PurchaseBillDetailCharge)
		{
			try
			{
				return inv_PurchaseBillDetailChargeDAO.Add(_inv_PurchaseBillDetailCharge);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(inv_PurchaseBillDetailCharge _inv_PurchaseBillDetailCharge)
		{
			try
			{
				return inv_PurchaseBillDetailChargeDAO.Update(_inv_PurchaseBillDetailCharge);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 ChargeId)
		{
			try
			{
				return inv_PurchaseBillDetailChargeDAO.Delete(ChargeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
