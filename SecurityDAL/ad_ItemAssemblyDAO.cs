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
	public class ad_ItemAssemblyDAO //: IDisposible
	{
		private static volatile ad_ItemAssemblyDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemAssemblyDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemAssemblyDAO();
			}
			return instance;
		}
		public static ad_ItemAssemblyDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemAssemblyDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemAssemblyDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ItemAssembly> GetByItemId(Int32 ItemId)
		{
			try
			{
				List<ad_ItemAssembly> ad_ItemAssemblyLst = new List<ad_ItemAssembly>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
				};
				ad_ItemAssemblyLst = dbExecutor.FetchData<ad_ItemAssembly>(CommandType.StoredProcedure, "ad_ItemAssembly_GetByItemId", colparameters);
				return ad_ItemAssemblyLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(ad_ItemAssembly ad_ItemAssembly)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@ItemId", ad_ItemAssembly.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RawItemId", ad_ItemAssembly.RawItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Quantity", ad_ItemAssembly.Quantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitId", ad_ItemAssembly.UnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreatorId", ad_ItemAssembly.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", ad_ItemAssembly.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_ItemAssembly.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_ItemAssembly.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemAssembly_Create", colparameters, true);
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
		public int Update(ad_ItemAssembly ad_ItemAssembly)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@AssemblyId", ad_ItemAssembly.AssemblyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", ad_ItemAssembly.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RawItemId", ad_ItemAssembly.RawItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Quantity", ad_ItemAssembly.Quantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitId", ad_ItemAssembly.UnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatorId", ad_ItemAssembly.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", ad_ItemAssembly.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAssembly_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 assemblyId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AssemblyId", assemblyId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAssembly_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
