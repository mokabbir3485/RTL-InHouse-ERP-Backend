using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using PosEntity;
using DbExecutor;

namespace PosDAL
{
	public class pos_SaleDetailChargeDAO //: IDisposible
	{
		private static volatile pos_SaleDetailChargeDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SaleDetailChargeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SaleDetailChargeDAO();
			}
			return instance;
		}
		public static pos_SaleDetailChargeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SaleDetailChargeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SaleDetailChargeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<pos_SaleDetailCharge> GetBySaleDetailId(Int64 SaleDetailId)
		{
			try
			{
				List<pos_SaleDetailCharge> pos_SaleDetailChargeLst = new List<pos_SaleDetailCharge>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDetailId", SaleDetailId, DbType.Int64, ParameterDirection.Input)
				};
                pos_SaleDetailChargeLst = dbExecutor.FetchData<pos_SaleDetailCharge>(CommandType.StoredProcedure, "pos_SaleDetailCharge_GetBySaleDetailId", colparameters);
				return pos_SaleDetailChargeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_SaleDetailCharge _pos_SaleDetailCharge)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@SaleDetailId", _pos_SaleDetailCharge.SaleDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", _pos_SaleDetailCharge.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeAmount", _pos_SaleDetailCharge.ChargeAmount, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_SaleDetailCharge_Create", colparameters, true);
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
		public int Update(pos_SaleDetailCharge _pos_SaleDetailCharge)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ChargeId", _pos_SaleDetailCharge.ChargeId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@SaleDetailId", _pos_SaleDetailCharge.SaleDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ChargeTypeId", _pos_SaleDetailCharge.ChargeTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ChargeAmount", _pos_SaleDetailCharge.ChargeAmount, DbType.Decimal, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetailCharge_Update", colparameters, true);
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
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetailCharge_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
