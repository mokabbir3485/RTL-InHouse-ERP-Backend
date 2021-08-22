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
	public class inv_StockIssueDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_StockIssueDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockIssueDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockIssueDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_StockIssueDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockIssueDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockIssueDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_StockIssueDetailAdAttribute> GetByIssueDetailId(Int64 issueDetailId)
		{
			try
			{
				List<inv_StockIssueDetailAdAttribute> inv_StockIssueDetailAdAttributeLst = new List<inv_StockIssueDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@IssueDetailId", issueDetailId, DbType.Int64, ParameterDirection.Input)
				};
                inv_StockIssueDetailAdAttributeLst = dbExecutor.FetchData<inv_StockIssueDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockIssueDetailAdAttribute_GetByIssueDetailId", colparameters);
				return inv_StockIssueDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_StockIssueDetailAdAttribute> GetByDepartmentAndItemId(Int32 departmentId, Int32 itemId)
        {
            try
            {
                List<inv_StockIssueDetailAdAttribute> inv_StockValuationAttributeLst = new List<inv_StockIssueDetailAdAttribute>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input)
				};
                inv_StockValuationAttributeLst = dbExecutor.FetchData<inv_StockIssueDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockValuationAttribute_GetByDepartmentAndItemId", colparameters);
                return inv_StockValuationAttributeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_StockIssueDetailAdAttribute _inv_StockIssueDetailAdAttribute)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@IssueDetailId", _inv_StockIssueDetailAdAttribute.IssueDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_StockIssueDetailAdAttribute.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_StockIssueDetailAdAttribute.AttributeQty, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockIssueDetailAdAttribute_Create", colparameters, true);
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
