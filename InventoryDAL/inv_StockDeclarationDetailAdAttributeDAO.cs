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
	public class inv_StockDeclarationDetailAdAttributeDAO //: IDisposible
	{
		private static volatile inv_StockDeclarationDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockDeclarationDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockDeclarationDetailAdAttributeDAO();
			}
			return instance;
		}
		public static inv_StockDeclarationDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockDeclarationDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockDeclarationDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_StockDeclarationDetailAdAttribute> GetByDeclarationDetailId(Int64 declarationDetailId)
		{
			try
			{
				List<inv_StockDeclarationDetailAdAttribute> inv_StockDeclarationDetailAdAttributeLst = new List<inv_StockDeclarationDetailAdAttribute>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeclarationDetailId", declarationDetailId, DbType.Int64, ParameterDirection.Input)
				};
                inv_StockDeclarationDetailAdAttributeLst = dbExecutor.FetchData<inv_StockDeclarationDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockDeclarationDetailAdAttribute_GetByDeclarationDetailId", colparameters);
				return inv_StockDeclarationDetailAdAttributeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeclarationDetailAdAttribute _inv_StockDeclarationDetailAdAttribute)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@DeclarationDetailId", _inv_StockDeclarationDetailAdAttribute.DeclarationDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _inv_StockDeclarationDetailAdAttribute.AttributeQty, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockDeclarationDetailAdAttribute_Create", colparameters, true);
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
