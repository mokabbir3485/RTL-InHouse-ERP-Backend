using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using DbExecutor;
using ExportEntity;

namespace ExportDAL
{
	public class exp_BankDocumentDAO //: IDisposible
	{
		private static volatile exp_BankDocumentDAO instance;
		private static readonly object lockObj = new object();
		public static exp_BankDocumentDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new exp_BankDocumentDAO();
			}
			return instance;
		}
		public static exp_BankDocumentDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new exp_BankDocumentDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public exp_BankDocumentDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<exp_BankDocument> GetAll(Int64? bankDocumentId = null,Int64? commercialInvoiceId = null)
		{
			try
			{
				List<exp_BankDocument> exp_BankDocumentLst = new List<exp_BankDocument>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@BankDocumentId", bankDocumentId, DbType.Int32, ParameterDirection.Input)
				};
				exp_BankDocumentLst = dbExecutor.FetchData<exp_BankDocument>(CommandType.StoredProcedure, "exp_BankDocument_Get", colparameters);
				return exp_BankDocumentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_BankDocument> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<exp_BankDocument> exp_BankDocumentLst = new List<exp_BankDocument>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				exp_BankDocumentLst = dbExecutor.FetchData<exp_BankDocument>(CommandType.StoredProcedure, "exp_BankDocument_GetDynamic", colparameters);
				return exp_BankDocumentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_BankDocument> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<exp_BankDocument> exp_BankDocumentLst = new List<exp_BankDocument>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				exp_BankDocumentLst = dbExecutor.FetchDataRef<exp_BankDocument>(CommandType.StoredProcedure, "exp_BankDocument_GetPaged", colparameters, ref rows);
				return exp_BankDocumentLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(exp_BankDocument _exp_BankDocument)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[6]{
				new Parameters("@CommercialInvoiceId", _exp_BankDocument.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@BankApplicationTo", _exp_BankDocument.BankApplicationTo, DbType.String, ParameterDirection.Input),
				new Parameters("@BankDocumentToDepartment", _exp_BankDocument.BankDocumentToDepartment, DbType.String, ParameterDirection.Input),
				new Parameters("@ApplicationDate", _exp_BankDocument.ApplicationDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatedBy", _exp_BankDocument.UpdatedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedDate", _exp_BankDocument.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_BankDocument_Create", colparameters, true);
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
		public int Update(exp_BankDocument _exp_BankDocument)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@BankDocumentId", _exp_BankDocument.BankDocumentId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@CommercialInvoiceId", _exp_BankDocument.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@BankApplicationTo", _exp_BankDocument.BankApplicationTo, DbType.String, ParameterDirection.Input),
				new Parameters("@BankDocumentToDepartment", _exp_BankDocument.BankDocumentToDepartment, DbType.String, ParameterDirection.Input),
				new Parameters("@ApplicationDate", _exp_BankDocument.ApplicationDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatedBy", _exp_BankDocument.UpdatedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedDate", _exp_BankDocument.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_BankDocument_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 bankDocumentId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@BankDocumentId", bankDocumentId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_BankDocument_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
