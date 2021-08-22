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
    public class pos_SaleDetailAdAttributeDAO //: IDisposible
	{
		private static volatile pos_SaleDetailAdAttributeDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SaleDetailAdAttributeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SaleDetailAdAttributeDAO();
			}
			return instance;
		}
		public static pos_SaleDetailAdAttributeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SaleDetailAdAttributeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SaleDetailAdAttributeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<pos_SaleDetailAdAttribute> GetByDepartmentAndBarcode(Int32 departmentId, string barcode)
        {
            try
            {
                List<pos_SaleDetailAdAttribute> pos_SaleDetailAdAttributeLst = new List<pos_SaleDetailAdAttribute>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Barcode", barcode, DbType.String, ParameterDirection.Input)
				};
                pos_SaleDetailAdAttributeLst = dbExecutor.FetchData<pos_SaleDetailAdAttribute>(CommandType.StoredProcedure, "inv_StockValuationAttribute_GetByDepartmentAndBarcode", colparameters);
                return pos_SaleDetailAdAttributeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public Int64 Add(pos_SaleDetailAdAttribute _pos_SaleDetailAdAttribute)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@SaleDetailId", _pos_SaleDetailAdAttribute.SaleDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _pos_SaleDetailAdAttribute.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeQty", _pos_SaleDetailAdAttribute.AttributeQty, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@AttributeQtyFree", _pos_SaleDetailAdAttribute.AttributeQtyFree, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "pos_SaleDetailAdAttribute_Create", colparameters, true);
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
