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
	public class inv_PurchaseBillOverHeadDAO //: IDisposible
	{
		private static volatile inv_PurchaseBillOverHeadDAO instance;
		private static readonly object lockObj = new object();
		public static inv_PurchaseBillOverHeadDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_PurchaseBillOverHeadDAO();
			}
			return instance;
		}
		public static inv_PurchaseBillOverHeadDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_PurchaseBillOverHeadDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_PurchaseBillOverHeadDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_PurchaseBillOverHead> GetAll(Int64? PBOverHeadId = null)
		{
			try
			{
				List<inv_PurchaseBillOverHead> inv_PurchaseBillOverHeadLst = new List<inv_PurchaseBillOverHead>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBOverHeadId", PBOverHeadId, DbType.Int32, ParameterDirection.Input)
				};
				inv_PurchaseBillOverHeadLst = dbExecutor.FetchData<inv_PurchaseBillOverHead>(CommandType.StoredProcedure, "inv_PurchaseBillOverHead_Get", colparameters);
				return inv_PurchaseBillOverHeadLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_PurchaseBillOverHead> GetByPBId(Int64 PBId)
        {
            try
            {
                List<inv_PurchaseBillOverHead> inv_PurchaseBillOverHeadLst = new List<inv_PurchaseBillOverHead>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBId", PBId, DbType.Int64, ParameterDirection.Input)
				};
                inv_PurchaseBillOverHeadLst = dbExecutor.FetchData<inv_PurchaseBillOverHead>(CommandType.StoredProcedure, "inv_PurchaseBillOverHead_GetByPBId", colparameters);
                return inv_PurchaseBillOverHeadLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_PurchaseBillOverHead _inv_PurchaseBillOverHead)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@PBId", _inv_PurchaseBillOverHead.PBId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OverHeadId", _inv_PurchaseBillOverHead.OverHeadId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Amount", _inv_PurchaseBillOverHead.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OverHeadName", _inv_PurchaseBillOverHead.OverHeadName, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseBillOverHead_Create", colparameters, true);
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
		public int Update(inv_PurchaseBillOverHead _inv_PurchaseBillOverHead)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@PBOverHeadId", _inv_PurchaseBillOverHead.PBOverHeadId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@PBId", _inv_PurchaseBillOverHead.PBId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OverHeadId", _inv_PurchaseBillOverHead.OverHeadId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Amount", _inv_PurchaseBillOverHead.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OverHeadName", _inv_PurchaseBillOverHead.OverHeadName, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillOverHead_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 PBOverHeadId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@PBOverHeadId", PBOverHeadId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillOverHead_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
