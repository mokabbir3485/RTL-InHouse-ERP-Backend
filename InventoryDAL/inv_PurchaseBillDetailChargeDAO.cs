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
	public class inv_PurchaseBillDetailChargeDAO //: IDisposible
	{
		private static volatile inv_PurchaseBillDetailChargeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseBillDetailChargeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseBillDetailChargeDAO();
			}
			return instance;
		}
		public static inv_PurchaseBillDetailChargeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseBillDetailChargeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseBillDetailChargeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_PurchaseBillDetailCharge> GetByPBDetailId(Int64 PBDetailId)
		{
			try
			{
				List<inv_PurchaseBillDetailCharge> inv_PurchaseBillDetailChargeLst = new List<inv_PurchaseBillDetailCharge>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBDetailId", PBDetailId, DbType.Int64, ParameterDirection.Input)
				};
                inv_PurchaseBillDetailChargeLst = dbExecutor.FetchData<inv_PurchaseBillDetailCharge>(CommandType.StoredProcedure, "inv_PurchaseBillDetailCharge_GetByPBDetailId", colparameters);
				return inv_PurchaseBillDetailChargeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_PurchaseBillDetailCharge _inv_PurchaseBillDetailCharge)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@PBDetailId", _inv_PurchaseBillDetailCharge.PBDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", _inv_PurchaseBillDetailCharge.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeAmount", _inv_PurchaseBillDetailCharge.ChargeAmount, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailCharge_Create", colparameters, true);
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
		public int Update(inv_PurchaseBillDetailCharge _inv_PurchaseBillDetailCharge)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ChargeId", _inv_PurchaseBillDetailCharge.ChargeId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PBDetailId", _inv_PurchaseBillDetailCharge.PBDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", _inv_PurchaseBillDetailCharge.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeAmount", _inv_PurchaseBillDetailCharge.ChargeAmount, DbType.Decimal, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailCharge_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 ChargeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ChargeId", ChargeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailCharge_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
