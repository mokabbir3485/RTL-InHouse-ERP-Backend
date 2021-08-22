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
	public class inv_RequisitionDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_RequisitionDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_RequisitionDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_RequisitionDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_RequisitionDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_RequisitionDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_RequisitionDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_RequisitionDetailAdAttribute> GetByRequisitionDetailId(Int64 requisitionDetailId)
		{
			try
			{
				List<inv_RequisitionDetailAdAttribute> inv_RequisitionDetailAdAttributeLst = new List<inv_RequisitionDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@RequisitionDetailId", requisitionDetailId, DbType.Int64, ParameterDirection.Input)
				};
                inv_RequisitionDetailAdAttributeLst = dbExecutor.FetchData<inv_RequisitionDetailAdAttribute>(CommandType.StoredProcedure, "inv_RequisitionDetailAdAttribute_GetByRequisitionDetailId", colparameters);
				return inv_RequisitionDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_RequisitionDetailAdAttribute _inv_RequisitionDetailAdAttribute)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@RequisitionDetailId", _inv_RequisitionDetailAdAttribute.RequisitionDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_RequisitionDetailAdAttribute.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_RequisitionDetailAdAttribute.AttributeQty, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_RequisitionDetailAdAttribute_Create", colparameters, true);
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
