using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SaleDetailChargeBLL //: IDisposible
	{
		public pos_SaleDetailChargeDAO  pos_SaleDetailChargeDAO { get; set; }

		public pos_SaleDetailChargeBLL()
		{
			//pos_SaleDetailChargeDAO = pos_SaleDetailCharge.GetInstanceThreadSafe;
			pos_SaleDetailChargeDAO = new pos_SaleDetailChargeDAO();
		}

        public List<pos_SaleDetailCharge> GetBySaleDetailId(Int64 SaleDetailId)
		{
			try
			{
				return pos_SaleDetailChargeDAO.GetBySaleDetailId(SaleDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_SaleDetailCharge _pos_SaleDetailCharge)
		{
			try
			{
				return pos_SaleDetailChargeDAO.Add(_pos_SaleDetailCharge);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(pos_SaleDetailCharge _pos_SaleDetailCharge)
		{
			try
			{
				return pos_SaleDetailChargeDAO.Update(_pos_SaleDetailCharge);
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
				return pos_SaleDetailChargeDAO.Delete(ChargeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
