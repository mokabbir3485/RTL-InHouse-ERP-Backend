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
	public class pos_SalePaymentDAO //: IDisposible
	{
		private static volatile pos_SalePaymentDAO instance;
		private static readonly object lockObj = new object();
		public static pos_SalePaymentDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_SalePaymentDAO();
			}
			return instance;
		}
		public static pos_SalePaymentDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_SalePaymentDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_SalePaymentDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pos_SalePayment> GetAll(Int64? salePaymentId = null,Int32? currencyId = null)
		{
			try
			{
				List<pos_SalePayment> pos_SalePaymentLst = new List<pos_SalePayment>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SalePaymentId", salePaymentId, DbType.Int32, ParameterDirection.Input)
				};
				pos_SalePaymentLst = dbExecutor.FetchData<pos_SalePayment>(CommandType.StoredProcedure, "pos_SalePayment_Get", colparameters);
				return pos_SalePaymentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SalePayment> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_SalePayment> pos_SalePaymentLst = new List<pos_SalePayment>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_SalePaymentLst = dbExecutor.FetchData<pos_SalePayment>(CommandType.StoredProcedure, "pos_SalePayment_GetDynamic", colparameters);
				return pos_SalePaymentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_SalePayment> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_SalePayment> pos_SalePaymentLst = new List<pos_SalePayment>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_SalePaymentLst = dbExecutor.FetchDataRef<pos_SalePayment>(CommandType.StoredProcedure, "pos_SalePayment_GetPaged", colparameters, ref rows);
				return pos_SalePaymentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_SalePayment _pos_SalePayment)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@InvoiceNo", _pos_SalePayment.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@CurrencyId", _pos_SalePayment.CurrencyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _pos_SalePayment.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Amount", _pos_SalePayment.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CommissionPercent", _pos_SalePayment.CommissionPercent, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@RefNumber", _pos_SalePayment.RefNumber, DbType.String, ParameterDirection.Input),
				new Parameters("@CardName", _pos_SalePayment.CardName, DbType.String, ParameterDirection.Input),
				new Parameters("@CardNumber", _pos_SalePayment.CardNumber, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_SalePayment_Create", colparameters, true);
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
		public int Update(pos_SalePayment _pos_SalePayment)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@SalePaymentId", _pos_SalePayment.SalePaymentId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@InvoiceNo", _pos_SalePayment.InvoiceNo, DbType.String, ParameterDirection.Input),
				new Parameters("@CurrencyId", _pos_SalePayment.CurrencyId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _pos_SalePayment.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Amount", _pos_SalePayment.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CommissionPercent", _pos_SalePayment.CommissionPercent, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@RefNumber", _pos_SalePayment.RefNumber, DbType.String, ParameterDirection.Input),
				new Parameters("@CardName", _pos_SalePayment.CardName, DbType.String, ParameterDirection.Input),
				new Parameters("@CardNumber", _pos_SalePayment.CardNumber, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalePayment_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 salePaymentId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SalePaymentId", salePaymentId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_SalePayment_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetSalePaymentByShift(int shiftId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ShiftId", shiftId, DbType.Int32, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "pos_SalePaymentByShift", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
