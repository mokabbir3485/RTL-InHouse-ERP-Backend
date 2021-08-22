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
	public class ad_ItemChargeDAO //: IDisposible
	{
		private static volatile ad_ItemChargeDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemChargeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemChargeDAO();
			}
			return instance;
		}
		public static ad_ItemChargeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemChargeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemChargeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_ItemCharge> GetByItemId(Int32 ItemId)
		{
			try
			{
				List<ad_ItemCharge> ad_ItemChargeLst = new List<ad_ItemCharge>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemChargeLst = dbExecutor.FetchData<ad_ItemCharge>(CommandType.StoredProcedure, "ad_ItemCharge_GetByItemId", colparameters);
				return ad_ItemChargeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(ad_ItemCharge ad_ItemCharge)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@TransactionTypeId", ad_ItemCharge.TransactionTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", ad_ItemCharge.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", ad_ItemCharge.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargePercentage", ad_ItemCharge.ChargePercentage, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@IsActive", ad_ItemCharge.IsActive, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", ad_ItemCharge.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", ad_ItemCharge.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_ItemCharge.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_ItemCharge.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemCharge_Create", colparameters, true);
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
