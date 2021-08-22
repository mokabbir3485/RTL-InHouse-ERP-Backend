using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PosEntity;
using PosDAL;

namespace PosBLL
{
	public class pos_SaleDetailAdAttributeBLL //: IDisposible
	{
		public pos_SaleDetailAdAttributeDAO  pos_SaleDetailAdAttributeDAO { get; set; }

		public pos_SaleDetailAdAttributeBLL()
		{
			//pos_SaleDetailAdAttributeDAO = pos_SaleDetailAdAttribute.GetInstanceThreadSafe;
			pos_SaleDetailAdAttributeDAO = new pos_SaleDetailAdAttributeDAO();
		}

        public List<pos_SaleDetailAdAttribute> GetByDepartmentAndBarcode(Int32 departmentId, string barcode)
		{
			try
			{
				return pos_SaleDetailAdAttributeDAO.GetByDepartmentAndBarcode(departmentId, barcode);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_SaleDetailAdAttribute _pos_SaleDetailAdAttribute)
		{
			try
			{
				return pos_SaleDetailAdAttributeDAO.Add(_pos_SaleDetailAdAttribute);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
