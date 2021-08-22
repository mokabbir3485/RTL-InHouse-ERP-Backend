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
	public class ad_ItemWiseItemStateDAO //: IDisposible
	{
		private static volatile ad_ItemWiseItemStateDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemWiseItemStateDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemWiseItemStateDAO();
			}
			return instance;
		}
		public static ad_ItemWiseItemStateDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemWiseItemStateDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemWiseItemStateDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ItemWiseItemState> GetByItemId(Int32 ItemId)
		{
			try
			{
				List<ad_ItemWiseItemState> ad_ItemWiseItemStateLst = new List<ad_ItemWiseItemState>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemWiseItemStateLst = dbExecutor.FetchData<ad_ItemWiseItemState>(CommandType.StoredProcedure, "ad_ItemWiseItemState_GetByItemId", colparameters);
				return ad_ItemWiseItemStateLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemWiseItemState ad_ItemWiseItemState)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemId", ad_ItemWiseItemState.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemStateId", ad_ItemWiseItemState.ItemStateId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemWiseItemState_Create", colparameters, true);
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
		public int Update(ad_ItemWiseItemState ad_ItemWiseItemState)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@ItemWiseItemStateId", ad_ItemWiseItemState.ItemWiseItemStateId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", ad_ItemWiseItemState.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemStateId", ad_ItemWiseItemState.ItemStateId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemWiseItemState_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 itemWiseItemStateId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemWiseItemStateId", itemWiseItemStateId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemWiseItemState_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
