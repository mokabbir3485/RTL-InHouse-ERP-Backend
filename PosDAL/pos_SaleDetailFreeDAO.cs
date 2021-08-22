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
	public class pos_SaleDetailFreeDAO //: IDisposible
	{
		private static volatile pos_SaleDetailFreeDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SaleDetailFreeDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SaleDetailFreeDAO();
			}
			return instance;
		}
		public static pos_SaleDetailFreeDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SaleDetailFreeDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SaleDetailFreeDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pos_SaleDetailFree> GetAll(Int64? saleDetailFreeId = null,Int64? saleId = null)
		{
			try
			{
				List<pos_SaleDetailFree> pos_SaleDetailFreeLst = new List<pos_SaleDetailFree>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDetailFreeId", saleDetailFreeId, DbType.Int32, ParameterDirection.Input)
				};
				pos_SaleDetailFreeLst = dbExecutor.FetchData<pos_SaleDetailFree>(CommandType.StoredProcedure, "pos_SaleDetailFree_Get", colparameters);
				return pos_SaleDetailFreeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetailFree> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_SaleDetailFree> pos_SaleDetailFreeLst = new List<pos_SaleDetailFree>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_SaleDetailFreeLst = dbExecutor.FetchData<pos_SaleDetailFree>(CommandType.StoredProcedure, "pos_SaleDetailFree_GetDynamic", colparameters);
				return pos_SaleDetailFreeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetailFree> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_SaleDetailFree> pos_SaleDetailFreeLst = new List<pos_SaleDetailFree>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_SaleDetailFreeLst = dbExecutor.FetchDataRef<pos_SaleDetailFree>(CommandType.StoredProcedure, "pos_SaleDetailFree_GetPaged", colparameters, ref rows);
				return pos_SaleDetailFreeLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_SaleDetailFree _pos_SaleDetailFree)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@SaleDetailId", _pos_SaleDetailFree.SaleDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_SaleDetailFree.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeUnitId", _pos_SaleDetailFree.FreeUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeQuantity", _pos_SaleDetailFree.FreeQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitPrice", _pos_SaleDetailFree.UnitPrice, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_SaleDetailFree_Create", colparameters, true);
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
		public int Update(pos_SaleDetailFree _pos_SaleDetailFree)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@SaleDetailFreeId", _pos_SaleDetailFree.SaleDetailFreeId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@SaleDetailId", _pos_SaleDetailFree.SaleDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_SaleDetailFree.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeUnitId", _pos_SaleDetailFree.FreeUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeQuantity", _pos_SaleDetailFree.FreeQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitPrice", _pos_SaleDetailFree.UnitPrice, DbType.Decimal, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetailFree_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleDetailFreeId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDetailFreeId", saleDetailFreeId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetailFree_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
