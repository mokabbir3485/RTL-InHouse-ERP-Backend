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
	public class ad_BarcodePrintDAO //: IDisposible
	{
		private static volatile ad_BarcodePrintDAO instance;
		private static readonly object lockObj = new object();
		public static ad_BarcodePrintDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_BarcodePrintDAO();
			}
			return instance;
		}
		public static ad_BarcodePrintDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_BarcodePrintDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_BarcodePrintDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}

		public Int64 Add(ad_BarcodePrint _ad_BarcodePrint)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ItemAddAttId", _ad_BarcodePrint.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@Qty", _ad_BarcodePrint.Qty, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Delete", _ad_BarcodePrint.Delete, DbType.Int32, ParameterDirection.Input),
                new Parameters("@BranchId", _ad_BarcodePrint.BranchId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_BarcodePrint_Create", colparameters, true);
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

        public Int64 AddForCustomer(ad_BarcodePrint _ad_BarcodePrint)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ItemAddAttId", _ad_BarcodePrint.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@Qty", _ad_BarcodePrint.Qty, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Delete", _ad_BarcodePrint.Delete, DbType.Int32, ParameterDirection.Input),
                new Parameters("@BranchId", _ad_BarcodePrint.BranchId, DbType.Int32, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_BarcodePrint_CreateForCustomer", colparameters, true);
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
