using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_RequisitionDetailAdAttributeBLL //: IDisposible
	{
		public inv_RequisitionDetailAdAttributeDAO  inv_RequisitionDetailAdAttributeDAO { get; set; }

		public inv_RequisitionDetailAdAttributeBLL()
		{
			//inv_RequisitionDetailAdAttributeDAO = inv_RequisitionDetailAdAttribute.GetInstanceThreadSafe;
			inv_RequisitionDetailAdAttributeDAO = new inv_RequisitionDetailAdAttributeDAO();
		}

        public List<inv_RequisitionDetailAdAttribute> GetByRequisitionDetailId(Int64 requisitionDetailId)
		{
			try
			{
				return inv_RequisitionDetailAdAttributeDAO.GetByRequisitionDetailId(requisitionDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_RequisitionDetailAdAttribute _inv_RequisitionDetailAdAttribute)
		{
			try
			{
				return inv_RequisitionDetailAdAttributeDAO.Add(_inv_RequisitionDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
