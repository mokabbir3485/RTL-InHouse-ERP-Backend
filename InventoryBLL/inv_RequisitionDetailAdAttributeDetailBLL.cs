using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_RequisitionDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_RequisitionDetailAdAttributeDetailDAO  inv_RequisitionDetailAdAttributeDetailDAO { get; set; }

		public inv_RequisitionDetailAdAttributeDetailBLL()
		{
			//inv_RequisitionDetailAdAttributeDetailDAO = inv_RequisitionDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_RequisitionDetailAdAttributeDetailDAO = new inv_RequisitionDetailAdAttributeDetailDAO();
		}

        public List<inv_RequisitionDetailAdAttributeDetail> GetByRequisitionDetailAdAttId(Int64 requisitionDetailAdAttId)
		{
			try
			{
				return inv_RequisitionDetailAdAttributeDetailDAO.GetByRequisitionDetailAdAttId(requisitionDetailAdAttId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_RequisitionDetailAdAttributeDetail _inv_RequisitionDetailAdAttributeDetail)
		{
			try
			{
				return inv_RequisitionDetailAdAttributeDetailDAO.Add(_inv_RequisitionDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
