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
	public class ad_CustomerAddressDAO //: IDisposible
	{
		private static volatile ad_CustomerAddressDAO instance;
		private static readonly object lockObj = new object();
		public static ad_CustomerAddressDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_CustomerAddressDAO();
			}
			return instance;
		}
		public static ad_CustomerAddressDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_CustomerAddressDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_CustomerAddressDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_CustomerAddress> GetByCustomerCode(string customerCode)
		{
			try
			{
				List<ad_CustomerAddress> ad_CustomerAddressLst = new List<ad_CustomerAddress>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CustomerCode", customerCode, DbType.String, ParameterDirection.Input)
				};
                ad_CustomerAddressLst = dbExecutor.FetchData<ad_CustomerAddress>(CommandType.StoredProcedure, "ad_CustomerAddress_GetByCustomerCode", colparameters);
				return ad_CustomerAddressLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_CustomerAddress> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<ad_CustomerAddress> ad_CustomerAddressLst = new List<ad_CustomerAddress>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
                ad_CustomerAddressLst = dbExecutor.FetchData<ad_CustomerAddress>(CommandType.StoredProcedure, "ad_CustomerAddress_GetDynamic", colparameters);
                return ad_CustomerAddressLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(ad_CustomerAddress ad_CustomerAddress)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[14]{
				new Parameters("@CustomerCode", ad_CustomerAddress.CustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@AddressType", ad_CustomerAddress.AddressType, DbType.String, ParameterDirection.Input),
				new Parameters("@Address", ad_CustomerAddress.Address, DbType.String, ParameterDirection.Input),
				new Parameters("@ContactPerson", ad_CustomerAddress.ContactPerson, DbType.String, ParameterDirection.Input),
				new Parameters("@ContactDesignation", ad_CustomerAddress.ContactDesignation, DbType.String, ParameterDirection.Input),
				new Parameters("@Phone", ad_CustomerAddress.Phone, DbType.String, ParameterDirection.Input),
				new Parameters("@Mobile", ad_CustomerAddress.Mobile, DbType.String, ParameterDirection.Input),
				new Parameters("@Email", ad_CustomerAddress.Email, DbType.String, ParameterDirection.Input),
				new Parameters("@Fax", ad_CustomerAddress.Fax, DbType.String, ParameterDirection.Input),
				new Parameters("@IsDefault", ad_CustomerAddress.IsDefault, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", ad_CustomerAddress.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", ad_CustomerAddress.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_CustomerAddress.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_CustomerAddress.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_CustomerAddress_Create", colparameters, true);
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
