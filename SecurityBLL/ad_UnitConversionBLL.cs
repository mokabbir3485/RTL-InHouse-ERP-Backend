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
	public class ad_UnitConversionBLL
	{
		public ad_UnitConversionDAO ad_UnitConversionDAO { get; set; }

		public ad_UnitConversionBLL()
		{
			ad_UnitConversionDAO = new ad_UnitConversionDAO();
		}

		public List<ad_UnitConversion> GetAll()
		{
			try
			{
				return ad_UnitConversionDAO.GetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public ad_UnitConversion GetById(int unitId)
        {
            try
            {
                return ad_UnitConversionDAO.GetAll(unitId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Add(ad_UnitConversion ad_UnitConversion)
		{
			try
			{
				return ad_UnitConversionDAO.Add(ad_UnitConversion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Update(ad_UnitConversion ad_UnitConversion)
		{
			try
			{
				return ad_UnitConversionDAO.Update(ad_UnitConversion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Delete(int unitId)
		{
			try
			{
				return ad_UnitConversionDAO.Delete(unitId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
