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
	public class inv_StockDeclarationDetailAdAttributeDetailDAO //: IDisposible
	{
		private static volatile inv_StockDeclarationDetailAdAttributeDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockDeclarationDetailAdAttributeDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockDeclarationDetailAdAttributeDetailDAO();
			}
			return instance;
		}
		public static inv_StockDeclarationDetailAdAttributeDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockDeclarationDetailAdAttributeDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockDeclarationDetailAdAttributeDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_StockDeclarationDetailAdAttributeDetail> GetByDeclarationDetailAdAttId(Int64 declarationDetailAdAttId)
		{
			try
			{
				List<inv_StockDeclarationDetailAdAttributeDetail> inv_StockDeclarationDetailAdAttributeDetailLst = new List<inv_StockDeclarationDetailAdAttributeDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeclarationDetailAdAttId", declarationDetailAdAttId, DbType.Int64, ParameterDirection.Input)
				};
                inv_StockDeclarationDetailAdAttributeDetailLst = dbExecutor.FetchData<inv_StockDeclarationDetailAdAttributeDetail>(CommandType.StoredProcedure, "inv_StockDeclarationDetailAdAttributeDetail_GetByDeclarationDetailAdAttId", colparameters);
				return inv_StockDeclarationDetailAdAttributeDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(inv_StockDeclarationDetailAdAttributeDetail _inv_StockDeclarationDetailAdAttributeDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@DeclarationDetailAdAttId", _inv_StockDeclarationDetailAdAttributeDetail.DeclarationDetailAdAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _inv_StockDeclarationDetailAdAttributeDetail.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeValue", _inv_StockDeclarationDetailAdAttributeDetail.AttributeValue, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockDeclarationDetailAdAttributeDetail_Create", colparameters, true);
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
