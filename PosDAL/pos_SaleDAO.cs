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
	public class pos_SaleDAO //: IDisposible
	{
		private static volatile pos_SaleDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SaleDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SaleDAO();
			}
			return instance;
		}
		public static pos_SaleDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SaleDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SaleDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pos_Sale> GetAll(Int64? saleId = null,Int64? shiftId = null)
		{
			try
			{
				List<pos_Sale> pos_SaleLst = new List<pos_Sale>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleId", saleId, DbType.Int32, ParameterDirection.Input)
				};
				pos_SaleLst = dbExecutor.FetchData<pos_Sale>(CommandType.StoredProcedure, "pos_Sale_Get", colparameters);
				return pos_SaleLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Sale> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_Sale> pos_SaleLst = new List<pos_Sale>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_SaleLst = dbExecutor.FetchData<pos_Sale>(CommandType.StoredProcedure, "pos_Sale_GetDynamic", colparameters);
				return pos_SaleLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Sale> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_Sale> pos_SaleLst = new List<pos_Sale>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_SaleLst = dbExecutor.FetchDataRef<pos_Sale>(CommandType.StoredProcedure, "pos_Sale_GetPaged", colparameters, ref rows);
				return pos_SaleLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public string Add(pos_Sale _pos_Sale)
		{
            string ret = string.Empty;
			try
			{
				Parameters[] colparameters = new Parameters[16]{
				new Parameters("@ShiftId", _pos_Sale.ShiftId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@TerminalId", _pos_Sale.TerminalId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CustomerCode", _pos_Sale.CustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _pos_Sale.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleDate", _pos_Sale.SaleDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@InvoiceNo", _pos_Sale.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@MemoNo", _pos_Sale.MemoNo, DbType.String, ParameterDirection.Input),
				new Parameters("@PaidAmount", _pos_Sale.PaidAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ChangeAmount", _pos_Sale.ChangeAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@SalesmanName", _pos_Sale.SalesmanName, DbType.String, ParameterDirection.Input),
				new Parameters("@IsVoid", _pos_Sale.IsVoid, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@IsPaymentSettled", _pos_Sale.IsPaymentSettled, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@CreatorId", _pos_Sale.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _pos_Sale.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pos_Sale.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pos_Sale.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalarString(true, CommandType.StoredProcedure, "pos_Sale_Create", colparameters, true);
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
		public int Update(pos_Sale _pos_Sale)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[18]{
				new Parameters("@SaleId", _pos_Sale.SaleId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ShiftId", _pos_Sale.ShiftId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@TerminalId", _pos_Sale.TerminalId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CustomerCode", _pos_Sale.CustomerCode, DbType.String, ParameterDirection.Input),
				new Parameters("@PriceTypeId", _pos_Sale.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleDate", _pos_Sale.SaleDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@InvoiceNo", _pos_Sale.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@MemoNo", _pos_Sale.MemoNo, DbType.String, ParameterDirection.Input),
				new Parameters("@PaidAmount", _pos_Sale.PaidAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ChangeAmount", _pos_Sale.ChangeAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@SalesmanName", _pos_Sale.SalesmanName, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@IsVoid", _pos_Sale.IsVoid, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@VoidBy", _pos_Sale.VoidBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@VoidDate", _pos_Sale.VoidDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@VoidReason", _pos_Sale.VoidReason, DbType.String, ParameterDirection.Input),
				new Parameters("@IsPaymentSettled", _pos_Sale.IsPaymentSettled, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pos_Sale.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pos_Sale.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_Sale_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 saleId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleId", saleId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_Sale_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataTable GetInvoiceNo(int terminalId, DateTime saleDate)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDate", saleDate, DbType.DateTime, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.Text, "SELECT dbo.ufxs_pos_GetInvoiceNo(" + terminalId + ", '" + saleDate + "')", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetByInvoiceNo(string InvoiceNo)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@InvoiceNo", InvoiceNo, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "pos_Sale_GetByInvoiceNo", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
