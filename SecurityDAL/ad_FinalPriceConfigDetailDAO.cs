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
	public class ad_FinalPriceConfigDetailDAO //: IDisposible
	{
		private static volatile ad_FinalPriceConfigDetailDAO instance;
		private static readonly object lockObj = new object();
		public static ad_FinalPriceConfigDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_FinalPriceConfigDetailDAO();
			}
			return instance;
		}
		public static ad_FinalPriceConfigDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_FinalPriceConfigDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_FinalPriceConfigDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_FinalPriceConfigDetail> GetByConfigId(Int32 ConfigId)
		{
			try
			{
				List<ad_FinalPriceConfigDetail> ad_FinalPriceConfigDetailLst = new List<ad_FinalPriceConfigDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConfigId", ConfigId, DbType.Int32, ParameterDirection.Input)
				};
                ad_FinalPriceConfigDetailLst = dbExecutor.FetchData<ad_FinalPriceConfigDetail>(CommandType.StoredProcedure, "ad_FinalPriceConfigDetail_GetByConfigId", colparameters);
				return ad_FinalPriceConfigDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_FinalPriceConfigDetail ad_FinalPriceConfigDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ConfigId", ad_FinalPriceConfigDetail.ConfigId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", ad_FinalPriceConfigDetail.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargePercentage", ad_FinalPriceConfigDetail.ChargePercentage, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OrderId", ad_FinalPriceConfigDetail.OrderId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_FinalPriceConfigDetail_Create", colparameters, true);
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
