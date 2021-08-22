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
	public class inv_ReturnToSupplierDetailAdAttributeDetailDAO //: IDisposible
	{
		private static volatile inv_ReturnToSupplierDetailAdAttributeDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_ReturnToSupplierDetailAdAttributeDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_ReturnToSupplierDetailAdAttributeDetailDAO();
			}
			return instance;
		}
		public static inv_ReturnToSupplierDetailAdAttributeDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_ReturnToSupplierDetailAdAttributeDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_ReturnToSupplierDetailAdAttributeDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_ReturnToSupplierDetailAdAttributeDetail> GetByReturnDetailAdAttId(Int64 returnDetailAdAttId)
		{
			try
			{
				List<inv_ReturnToSupplierDetailAdAttributeDetail> inv_ReturnToSupplierDetailAdAttributeDetailLst = new List<inv_ReturnToSupplierDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ReturnDetailAdAttId", returnDetailAdAttId, DbType.Int64, ParameterDirection.Input)
				};
                inv_ReturnToSupplierDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_ReturnToSupplierDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_ReturnToSupplierDetailAdAttributeDetail_GetByReturnDetailAdAttId", colparameters);
				return inv_ReturnToSupplierDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_ReturnToSupplierDetailAdAttributeDetail _inv_ReturnToSupplierDetailAdAttributeDetail)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@ReturnDetailAdAttId", _inv_ReturnToSupplierDetailAdAttributeDetail.ReturnDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_ReturnToSupplierDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_ReturnToSupplierDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_ReturnToSupplierDetailAdAttributeDetail_Create", colparameters, true);
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
