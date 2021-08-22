using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnFromDepartmentDetailAdAttributeBLL //: IDisposible
	{
		public inv_ReturnFromDepartmentDetailAdAttributeDAO  inv_ReturnFromDepartmentDetailAdAttributeDAO { get; set; }

		public inv_ReturnFromDepartmentDetailAdAttributeBLL()
		{
			//inv_ReturnFromDepartmentDetailAdAttributeDAO = inv_ReturnFromDepartmentDetailAdAttribute.GetInstanceThreadSafe;
			inv_ReturnFromDepartmentDetailAdAttributeDAO = new inv_ReturnFromDepartmentDetailAdAttributeDAO();
		}

        public List<inv_ReturnFromDepartmentDetailAdAttribute> GetByReturnDetailId(Int64 returnDetailId)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailAdAttributeDAO.GetByReturnDetailId(returnDetailId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_ReturnFromDepartmentDetailAdAttribute _inv_ReturnFromDepartmentDetailAdAttribute)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailAdAttributeDAO.Add(_inv_ReturnFromDepartmentDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
