using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;

namespace SecurityDAL
{
	public class ad_FinalPriceConfigDetailApplyOnDAO //: IDisposible
	{
		private static volatile ad_FinalPriceConfigDetailApplyOnDAO instance;
		private static readonly object lockObj = new object();
		public static ad_FinalPriceConfigDetailApplyOnDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_FinalPriceConfigDetailApplyOnDAO();
			}
			return instance;
		}
		public static ad_FinalPriceConfigDetailApplyOnDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_FinalPriceConfigDetailApplyOnDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_FinalPriceConfigDetailApplyOnDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_FinalPriceConfigDetailApplyOn> GetByConfigDetailId(Int64 ConfigDetailId)
		{
			try
			{
				List<ad_FinalPriceConfigDetailApplyOn> ad_FinalPriceConfigDetailApplyOnLst = new List<ad_FinalPriceConfigDetailApplyOn>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConfigDetailId", ConfigDetailId, DbType.Int64, ParameterDirection.Input)
				};
                ad_FinalPriceConfigDetailApplyOnLst = dbExecutor.FetchData<ad_FinalPriceConfigDetailApplyOn>(CommandType.StoredProcedure, "ad_FinalPriceConfigDetailApplyOn_GetByConfigDetailId", colparameters);
				return ad_FinalPriceConfigDetailApplyOnLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_FinalPriceConfigDetailApplyOn> GetByConfigId(Int32 ConfigId)
        {
            try
            {
                List<ad_FinalPriceConfigDetailApplyOn> ad_FinalPriceConfigDetailApplyOnLst = new List<ad_FinalPriceConfigDetailApplyOn>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConfigId", ConfigId, DbType.Int32, ParameterDirection.Input)
				};
                ad_FinalPriceConfigDetailApplyOnLst = dbExecutor.FetchData<ad_FinalPriceConfigDetailApplyOn>(CommandType.StoredProcedure, "ad_FinalPriceConfigDetailApplyOn_GetByConfigId", colparameters);
                return ad_FinalPriceConfigDetailApplyOnLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_FinalPriceConfigDetailApplyOn ad_FinalPriceConfigDetailApplyOn)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ConfigDetailId", ad_FinalPriceConfigDetailApplyOn.ConfigDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ApplyOnChargeTypeId", ad_FinalPriceConfigDetailApplyOn.ApplyOnChargeTypeId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_FinalPriceConfigDetailApplyOn_Create", colparameters, true);
				dbExecutor.ManageTransaction(TransactionType.Commit);
			}
			catch (DBConcurrencyException except)
			{
				dbExecutor.ManageTransaction(TransactionType.Rollback);
				throw except;
			}
			catch (Exception ex)
			{
				dbExecutor.ManageTransaction(TransactionType.Rollback);
				throw ex;
			}
			return ret;
		}
	}
}
