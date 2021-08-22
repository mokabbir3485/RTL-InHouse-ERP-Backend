using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using InventoryEntity;
using DbExecutor;

namespace InventoryDAL
{
	public class inv_StockValuationSetupDAO //: IDisposible
	{
		private static volatile inv_StockValuationSetupDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockValuationSetupDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockValuationSetupDAO();
			}
			return instance;
		}
		public static inv_StockValuationSetupDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockValuationSetupDAO();
						}
					}
				}
				return instance;
			}
		}
		DBExecutor dbExecutor;
		public inv_StockValuationSetupDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_StockValuationSetup> GetAll(Int32? FinancialCycleId = null)
		{
			try
			{
                List<inv_StockValuationSetup> inv_StockValuationSetupLst = new List<inv_StockValuationSetup>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@FinancialCycleId", FinancialCycleId, DbType.Int32, ParameterDirection.Input)
				};
				inv_StockValuationSetupLst = dbExecutor.FetchData<inv_StockValuationSetup>(CommandType.StoredProcedure, "inv_StockValuationSetup_Get", colparameters);
				return inv_StockValuationSetupLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockValuationSetup _inv_StockValuationSetup)
		{
			int ret = 0;
			try
			{
                Parameters[] colparameters = new Parameters[8]{
				new Parameters("@FromDate", _inv_StockValuationSetup.FromDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@ToDate", _inv_StockValuationSetup.ToDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@ValuationType", _inv_StockValuationSetup.ValuationType, DbType.String, ParameterDirection.Input),
				new Parameters("@IsCurrent", _inv_StockValuationSetup.IsCurrent, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _inv_StockValuationSetup.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _inv_StockValuationSetup.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockValuationSetup.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockValuationSetup.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockValuationSetup_Create", colparameters, true);
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
		public int Update(inv_StockValuationSetup _inv_StockValuationSetup)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@FinancialCycleId", _inv_StockValuationSetup.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FromDate", _inv_StockValuationSetup.FromDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@ToDate", _inv_StockValuationSetup.ToDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@ValuationType", _inv_StockValuationSetup.ValuationType, DbType.String, ParameterDirection.Input),
				new Parameters("@IsCurrent", _inv_StockValuationSetup.IsCurrent, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockValuationSetup.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockValuationSetup.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuationSetup_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Delete(Int32 FinancialCycleId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@FinancialCycleId", FinancialCycleId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuationSetup_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
