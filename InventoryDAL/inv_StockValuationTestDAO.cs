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
	public class inv_StockValuationTestDAO //: IDisposible
	{
		private static volatile inv_StockValuationTestDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockValuationTestDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockValuationTestDAO();
			}
			return instance;
		}
		public static inv_StockValuationTestDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockValuationTestDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockValuationTestDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_StockValuation> GetAll(Int64? ValuationId = null)
		{
			try
			{
				List<inv_StockValuation> inv_StockValuationLst = new List<inv_StockValuation>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ValuationId", ValuationId, DbType.Int32, ParameterDirection.Input)
				};
				inv_StockValuationLst = dbExecutor.FetchData<inv_StockValuation>(CommandType.StoredProcedure, "inv_StockValuation_Get", colparameters);
				return inv_StockValuationLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_StockValuation> GetByItemAndDepartment(Int32 ItemId, Int32 DepartmentId)
        {
            try
            {
                List<inv_StockValuation> inv_StockValuationLst = new List<inv_StockValuation>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentId", DepartmentId, DbType.Int32, ParameterDirection.Input)
				};
                inv_StockValuationLst = dbExecutor.FetchData<inv_StockValuation>(CommandType.StoredProcedure, "inv_StockValuation_GetByItemAndDepartment", colparameters);
                return inv_StockValuationLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetByItemCode(string itemCode)
        {
            try
            {
                List<inv_StockValuationTest> inv_StockValuationLst = new List<inv_StockValuationTest>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemCode", itemCode, DbType.String, ParameterDirection.Input)
				};
                inv_StockValuationLst = dbExecutor.FetchData<inv_StockValuationTest>(CommandType.StoredProcedure, "inv_StockValuationTest_GetByItemCode", colparameters);
                return inv_StockValuationLst.FirstOrDefault().Quantity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_StockValuationTest _inv_StockValuationTest)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemCode", _inv_StockValuationTest.ItemCode, DbType.String, ParameterDirection.Input),
				new Parameters("@Quantity", _inv_StockValuationTest.Quantity, DbType.Int32, ParameterDirection.Input),
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockValuationTest_Create", colparameters, true);
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
		public int Update(inv_StockValuation _inv_StockValuation)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@ValuationId", _inv_StockValuation.ValuationId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_StockValuation.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_StockValuation.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CurrentQuantity", _inv_StockValuation.CurrentQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ValuationPrice", _inv_StockValuation.ValuationPrice, DbType.Decimal, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuation_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateAdd(inv_StockValuation _inv_StockValuation)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ItemId", _inv_StockValuation.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_StockValuation.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CurrentQuantity", _inv_StockValuation.CurrentQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ValuationPrice", _inv_StockValuation.ValuationPrice, DbType.Decimal, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuation_UpdateAdd", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDeduct(inv_StockValuation _inv_StockValuation)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@ItemId", _inv_StockValuation.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_StockValuation.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CurrentQuantity", _inv_StockValuation.CurrentQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ValuationPrice", _inv_StockValuation.ValuationPrice, DbType.Decimal, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuation_UpdateDeduct", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Delete(Int64 ValuationId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ValuationId", ValuationId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockValuation_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
