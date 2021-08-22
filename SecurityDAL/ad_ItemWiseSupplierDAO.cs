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
	public class ad_ItemWiseSupplierDAO //: IDisposible
	{
		private static volatile ad_ItemWiseSupplierDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemWiseSupplierDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemWiseSupplierDAO();
			}
			return instance;
		}
		public static ad_ItemWiseSupplierDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemWiseSupplierDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemWiseSupplierDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<ad_ItemWiseSupplier> GetByItemId(Int32 ItemId)
		{
			try
			{
				List<ad_ItemWiseSupplier> ad_ItemWiseSupplierLst = new List<ad_ItemWiseSupplier>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemWiseSupplierLst = dbExecutor.FetchData<ad_ItemWiseSupplier>(CommandType.StoredProcedure, "ad_ItemWiseSupplier_GetByItemId", colparameters);
				return ad_ItemWiseSupplierLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemWiseSupplier ad_ItemWiseSupplier)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemId", ad_ItemWiseSupplier.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SupplierId", ad_ItemWiseSupplier.SupplierId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemWiseSupplier_Create", colparameters, true);
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
