using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using InventoryEntity;
using InventoryDAL;

namespace InventoryBLL
{
	public class inv_ReturnFromDepartmentDetailAdAttributeDetailBLL //: IDisposible
	{
		public inv_ReturnFromDepartmentDetailAdAttributeDetailDAO  inv_ReturnFromDepartmentDetailAdAttributeDetailDAO { get; set; }

		public inv_ReturnFromDepartmentDetailAdAttributeDetailBLL()
		{
			//inv_ReturnFromDepartmentDetailAdAttributeDetailDAO = inv_ReturnFromDepartmentDetailAdAttributeDetail.GetInstanceThreadSafe;
			inv_ReturnFromDepartmentDetailAdAttributeDetailDAO = new inv_ReturnFromDepartmentDetailAdAttributeDetailDAO();
		}

        public List<inv_ReturnFromDepartmentDetailAdAttributeDetail> GetByReturnDetailAdAttId(Int64 returnDetailAdAttId)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailAdAttributeDetailDAO.GetByReturnDetailAdAttId(returnDetailAdAttId);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_ReturnFromDepartmentDetailAdAttributeDetail _inv_ReturnFromDepartmentDetailAdAttributeDetail)
		{
			try
			{
				return inv_ReturnFromDepartmentDetailAdAttributeDetailDAO.Add(_inv_ReturnFromDepartmentDetailAdAttributeDetail);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
