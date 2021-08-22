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
	public class pos_SaleDetailDAO //: IDisposible
	{
		private static volatile pos_SaleDetailDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SaleDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SaleDetailDAO();
			}
			return instance;
		}
		public static pos_SaleDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SaleDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SaleDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<pos_SaleDetail> GetByInvoiceNo(string invoiceNo)
		{
			try
			{
				List<pos_SaleDetail> pos_SaleDetailLst = new List<pos_SaleDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@InvoiceNo", invoiceNo, DbType.String, ParameterDirection.Input)
				};
                pos_SaleDetailLst = dbExecutor.FetchData<pos_SaleDetail>(CommandType.StoredProcedure, "pos_SaleDetail_GetByInvoiceNo", colparameters);
				return pos_SaleDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_SaleDetail> pos_SaleDetailLst = new List<pos_SaleDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_SaleDetailLst = dbExecutor.FetchData<pos_SaleDetail>(CommandType.StoredProcedure, "pos_SaleDetail_GetDynamic", colparameters);
				return pos_SaleDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SaleDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_SaleDetail> pos_SaleDetailLst = new List<pos_SaleDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_SaleDetailLst = dbExecutor.FetchDataRef<pos_SaleDetail>(CommandType.StoredProcedure, "pos_SaleDetail_GetPaged", colparameters, ref rows);
				return pos_SaleDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pos_SaleDetail _pos_SaleDetail)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@InvoiceNo", _pos_SaleDetail.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_SaleDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleUnitId", _pos_SaleDetail.SaleUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Quantity", _pos_SaleDetail.Quantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitPrice", _pos_SaleDetail.UnitPrice, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UnitDiscount", _pos_SaleDetail.UnitDiscount, DbType.Decimal, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_SaleDetail_Create", colparameters, true);
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
        public int UpdateIsVoid(pos_SaleDetail _pos_SaleDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@InvoiceNo", _pos_SaleDetail.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_SaleDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleUnitId", _pos_SaleDetail.SaleUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Quantity", _pos_SaleDetail.Quantity, DbType.Decimal, ParameterDirection.Input)
				};
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetail_UpdateIsVoid", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDetailId", saleDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SaleDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<pos_SaleDetail> GetByInvoiceNoForExchange(string invoiceNo)
        {
            try
            {
                List<pos_SaleDetail> pos_SaleDetailLst = new List<pos_SaleDetail>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@InvoiceNo", invoiceNo, DbType.String, ParameterDirection.Input)
				};
                pos_SaleDetailLst = dbExecutor.FetchData<pos_SaleDetail>(CommandType.StoredProcedure, "pos_SaleDetail_GetByInvoiceNoForExchange", colparameters);
                return pos_SaleDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<pos_SaleDetail> GetFreeByInvoiceNo(string invoiceNo)
        {
            try
            {
                List<pos_SaleDetail> pos_SaleDetailLst = new List<pos_SaleDetail>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@InvoiceNo", invoiceNo, DbType.String, ParameterDirection.Input)
				};
                pos_SaleDetailLst = dbExecutor.FetchData<pos_SaleDetail>(CommandType.StoredProcedure, "pos_SaleDetailFree_GetByInvoiceNo", colparameters);
                return pos_SaleDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
