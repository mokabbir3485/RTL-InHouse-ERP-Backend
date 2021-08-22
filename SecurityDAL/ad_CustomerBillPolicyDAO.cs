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
	public class ad_CustomerBillPolicyDAO //: IDisposible
	{
		private static volatile ad_CustomerBillPolicyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CustomerBillPolicyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CustomerBillPolicyDAO();
			}
			return instance;
		}
		public static ad_CustomerBillPolicyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CustomerBillPolicyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CustomerBillPolicyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_CustomerBillPolicy> GetByCustomerCode(string customerCode)
		{
			try
			{
				List<ad_CustomerBillPolicy> ad_CustomerBillPolicyLst = new List<ad_CustomerBillPolicy>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerCode", customerCode, DbType.String, ParameterDirection.Input)
				};
                ad_CustomerBillPolicyLst = dbExecutor.FetchData<ad_CustomerBillPolicy>(CommandType.StoredProcedure, "ad_CustomerBillPolicy_GetByCustomerCode", colparameters);
				return ad_CustomerBillPolicyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CustomerBillPolicy ad_CustomerBillPolicy)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@CustomerCode", ad_CustomerBillPolicy.CustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@PolicyDescription", ad_CustomerBillPolicy.PolicyDescription, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_CustomerBillPolicy_Create", colparameters, true);
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
