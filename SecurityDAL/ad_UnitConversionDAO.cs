using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;

namespace SecurityDAL
{
	public class ad_UnitConversionDAO
	{
        DBExecutor dbExecutor = new DBExecutor();
        public ad_UnitConversionDAO()
		{
		}

        public List<ad_UnitConversion> GetAll(Int32? unitId = null)
		{
			try
			{
                List<ad_UnitConversion> lst = new List<ad_UnitConversion>();
                Parameters[] colparameters = new Parameters[1]{
                new  Parameters("@UnitId", unitId,  DbType.Int32 ,  ParameterDirection.Input)
                };
                lst = dbExecutor.FetchData<ad_UnitConversion>(CommandType.StoredProcedure, "ad_UnitConversion_Get", colparameters);
                return lst;
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
				//DbCommand oDbCommand = DbProviderHelper.CreateCommand("ad_UnitConversion_Create", CommandType.StoredProcedure);
		
				return 0;
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
				//DbCommand oDbCommand = DbProviderHelper.CreateCommand("ad_UnitConversion_Update", CommandType.StoredProcedure);
				
				return 0;
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
                int ret = 0;
                Parameters[] parameters = new Parameters[] {
                new Parameters("@UnitId", unitId,  DbType.Int32 ,  ParameterDirection.Input)  };

                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_UnitConversion_DeleteById", parameters, true);
                return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
