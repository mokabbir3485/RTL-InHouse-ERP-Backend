using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;
using System.Linq;

namespace SecurityBLL
{
	public class ad_ChargeTypeBLL //: IDisposible
	{
		public ad_ChargeTypeDAO  ad_ChargeTypeDAO { get; set; }

		public ad_ChargeTypeBLL()
		{
			//ad_ChargeTypeDAO = ad_ChargeType.GetInstanceThreadSafe;
			ad_ChargeTypeDAO = new ad_ChargeTypeDAO();
		}

		public List<ad_ChargeType> GetAll()
		{
			try
			{
				return ad_ChargeTypeDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_ChargeType> GetAllWithProductPrice()
        {
            try
            {
                return ad_ChargeTypeDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ChargeType> GetAllWithProductPriceExcludeSelectedChargeId(Int32 chargeTypeId)
        {
            try
            {
                List<ad_ChargeType> lstAd_ChargeType = ad_ChargeTypeDAO.GetAll();
                lstAd_ChargeType = lstAd_ChargeType.Where(c => c.ChargeTypeId != chargeTypeId).ToList();
                return lstAd_ChargeType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_ChargeType> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				return ad_ChargeTypeDAO.GetDynamic(whereCondition, orderByExpression);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_ChargeType> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				return ad_ChargeTypeDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ChargeType _ad_ChargeType)
		{
			try
			{
				return ad_ChargeTypeDAO.Add(_ad_ChargeType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Update(ad_ChargeType _ad_ChargeType)
		{
			try
			{
				return ad_ChargeTypeDAO.Update(_ad_ChargeType);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 ChargeTypeId)
		{
			try
			{
				return ad_ChargeTypeDAO.Delete(ChargeTypeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
