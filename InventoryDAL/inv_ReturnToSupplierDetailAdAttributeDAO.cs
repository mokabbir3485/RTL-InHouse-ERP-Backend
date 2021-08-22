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
	public class inv_ReturnToSupplierDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_ReturnToSupplierDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_ReturnToSupplierDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_ReturnToSupplierDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_ReturnToSupplierDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_ReturnToSupplierDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_ReturnToSupplierDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_ReturnToSupplierDetailAdAttribute> GetByReturnDetailId(Int64 returnDetailId)
		{
			try
			{
				List<inv_ReturnToSupplierDetailAdAttribute> inv_ReturnToSupplierDetailAdAttributeLst = new List<inv_ReturnToSupplierDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ReturnDetailId", returnDetailId, DbType.Int64, ParameterDirection.Input)
				};
                inv_ReturnToSupplierDetailAdAttributeLst = dbExecutor.FetchData<inv_ReturnToSupplierDetailAdAttribute>(CommandType.StoredProcedure, "inv_ReturnToSupplierDetailAdAttribute_GetByReturnDetailId", colparameters);
				return inv_ReturnToSupplierDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_ReturnToSupplierDetailAdAttribute _inv_ReturnToSupplierDetailAdAttribute)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ReturnDetailId", _inv_ReturnToSupplierDetailAdAttribute.ReturnDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_ReturnToSupplierDetailAdAttribute.AttributeQty, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_ReturnToSupplierDetailAdAttribute_Create", colparameters, true);
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
