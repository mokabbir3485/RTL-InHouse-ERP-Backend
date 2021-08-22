using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using PayableEntity;
using DbExecutor;

namespace PayableDAL
{
	public class pay_SupplierAdvanceDAO //: IDisposible
	{
		private static volatile pay_SupplierAdvanceDAO instance;
		private static readonly object lockObj = new object();
		public static pay_SupplierAdvanceDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pay_SupplierAdvanceDAO();
			}
			return instance;
		}
		public static pay_SupplierAdvanceDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pay_SupplierAdvanceDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pay_SupplierAdvanceDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pay_SupplierAdvance> GetAll(Int64? advanceId = null)
		{
			try
			{
				List<pay_SupplierAdvance> pay_SupplierAdvanceLst = new List<pay_SupplierAdvance>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AdvanceId", advanceId, DbType.Int32, ParameterDirection.Input)
				};
				pay_SupplierAdvanceLst = dbExecutor.FetchData<pay_SupplierAdvance>(CommandType.StoredProcedure, "pay_SupplierAdvance_Get", colparameters);
				return pay_SupplierAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pay_SupplierAdvance> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pay_SupplierAdvance> pay_SupplierAdvanceLst = new List<pay_SupplierAdvance>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pay_SupplierAdvanceLst = dbExecutor.FetchData<pay_SupplierAdvance>(CommandType.StoredProcedure, "pay_SupplierAdvance_GetDynamic", colparameters);
				return pay_SupplierAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pay_SupplierAdvance> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pay_SupplierAdvance> pay_SupplierAdvanceLst = new List<pay_SupplierAdvance>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pay_SupplierAdvanceLst = dbExecutor.FetchDataRef<pay_SupplierAdvance>(CommandType.StoredProcedure, "pay_SupplierAdvance_GetPaged", colparameters, ref rows);
				return pay_SupplierAdvanceLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pay_SupplierAdvance _pay_SupplierAdvance)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@FinancialCycleId", _pay_SupplierAdvance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SupplierId", _pay_SupplierAdvance.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _pay_SupplierAdvance.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AdvanceDate", _pay_SupplierAdvance.AdvanceDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _pay_SupplierAdvance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@VoucherNo", _pay_SupplierAdvance.VoucherNo, DbType.String, ParameterDirection.Input),
				new Parameters("@IsOpening", _pay_SupplierAdvance.IsOpening, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pay_SupplierAdvance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pay_SupplierAdvance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "pay_SupplierAdvance_Create", colparameters, true);
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
		public int Update(pay_SupplierAdvance _pay_SupplierAdvance)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[10]{
				new Parameters("@AdvanceId", _pay_SupplierAdvance.AdvanceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@FinancialCycleId", _pay_SupplierAdvance.FinancialCycleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SupplierId", _pay_SupplierAdvance.SupplierId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@PaymentTypeId", _pay_SupplierAdvance.PaymentTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AdvanceDate", _pay_SupplierAdvance.AdvanceDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Amount", _pay_SupplierAdvance.Amount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@VoucherNo", _pay_SupplierAdvance.VoucherNo, DbType.String, ParameterDirection.Input),
				new Parameters("@IsOpening", _pay_SupplierAdvance.IsOpening, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pay_SupplierAdvance.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pay_SupplierAdvance.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pay_SupplierAdvance_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 advanceId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@AdvanceId", advanceId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pay_SupplierAdvance_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable CheckVoucherNoExists(string voucherNo)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@VoucherNo", voucherNo, DbType.String, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "pay_CheckVoucherNoExists", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
