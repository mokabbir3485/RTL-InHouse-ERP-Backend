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
	public class ad_ChargeTypeApplyDAO //: IDisposible
	{
		private static volatile ad_ChargeTypeApplyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ChargeTypeApplyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ChargeTypeApplyDAO();
			}
			return instance;
		}
		public static ad_ChargeTypeApplyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ChargeTypeApplyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ChargeTypeApplyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ChargeTypeApply> GetByChargeTypeId(Int32 ChargeTypeId)
		{
			try
			{
				List<ad_ChargeTypeApply> ad_ItemChargeApplyLst = new List<ad_ChargeTypeApply>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ChargeTypeId", ChargeTypeId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemChargeApplyLst = dbExecutor.FetchData<ad_ChargeTypeApply>(CommandType.StoredProcedure, "ad_ChargeTypeApply_GetByChargeTypeId", colparameters);
				return ad_ItemChargeApplyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(ad_ChargeTypeApply ad_ItemChargeApply)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@ChargeTypeId", ad_ItemChargeApply.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApplyOnId", ad_ItemChargeApply.ApplyOnId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OrderId", ad_ItemChargeApply.OrderId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ChargeTypeApply_Create", colparameters, true);
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
