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
	public class ad_CompanyBillPolicyDAO //: IDisposible
	{
		private static volatile ad_CompanyBillPolicyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CompanyBillPolicyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CompanyBillPolicyDAO();
			}
			return instance;
		}
		public static ad_CompanyBillPolicyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CompanyBillPolicyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CompanyBillPolicyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_CompanyBillPolicy> GetByCompanyId(Int32 companyId)
		{
			try
			{
				List<ad_CompanyBillPolicy> ad_CompanyBillPolicyLst = new List<ad_CompanyBillPolicy>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CompanyId", companyId, DbType.Int32, ParameterDirection.Input)
				};
                ad_CompanyBillPolicyLst = dbExecutor.FetchData<ad_CompanyBillPolicy>(CommandType.StoredProcedure, "ad_CompanyBillPolicy_GetByCompanyId", colparameters);
				return ad_CompanyBillPolicyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_CompanyBillPolicy _ad_CompanyBillPolicy)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@CompanyId", _ad_CompanyBillPolicy.CompanyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PolicyDescription", _ad_CompanyBillPolicy.PolicyDescription, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_CompanyBillPolicy_Create", colparameters, true);
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
