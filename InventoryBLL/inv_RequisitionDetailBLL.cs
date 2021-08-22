using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_RequisitionDetailBLL //: IDisposible
	{
		public inv_RequisitionDetailDAO  inv_RequisitionDetailDAO { get; set; }

		public inv_RequisitionDetailBLL()
		{
			//inv_RequisitionDetailDAO = inv_RequisitionDetail.GetInstanceThreadSafe;
			inv_RequisitionDetailDAO = new inv_RequisitionDetailDAO();
		}

		public int Add(inv_RequisitionDetail _inv_RequisitionDetail)
		{
			try
			{
				return inv_RequisitionDetailDAO.Add(_inv_RequisitionDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	    public List<inv_RequisitionDetail> GetByRequisitionId(Int64 requisitionId)
	    {
            try
            {
                return inv_RequisitionDetailDAO.GetByRequisitionId(requisitionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
	    }
	}
}
