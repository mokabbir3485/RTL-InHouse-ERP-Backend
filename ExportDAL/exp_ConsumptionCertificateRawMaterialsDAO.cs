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
	public class exp_ConsumptionCertificateRawMaterialsDAO //: IDisposible
	{
		private static volatile exp_ConsumptionCertificateRawMaterialsDAO instance;
		private static readonly object lockObj = new object();
		public static exp_ConsumptionCertificateRawMaterialsDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new exp_ConsumptionCertificateRawMaterialsDAO();
			}
			return instance;
		}
		public static exp_ConsumptionCertificateRawMaterialsDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new exp_ConsumptionCertificateRawMaterialsDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public exp_ConsumptionCertificateRawMaterialsDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<exp_ConsumptionCertificateRawMaterials> GetAll(Int64? consumptionCertificateRawMaterialsId = null,Int64? consumptionCertificateId = null)
		{
			try
			{
				List<exp_ConsumptionCertificateRawMaterials> exp_ConsumptionCertificateRawMaterialsLst = new List<exp_ConsumptionCertificateRawMaterials>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConsumptionCertificateRawMaterialsId", consumptionCertificateRawMaterialsId, DbType.Int32, ParameterDirection.Input)
				};
				exp_ConsumptionCertificateRawMaterialsLst = dbExecutor.FetchData<exp_ConsumptionCertificateRawMaterials>(CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_Get", colparameters);
				return exp_ConsumptionCertificateRawMaterialsLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificateRawMaterials> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<exp_ConsumptionCertificateRawMaterials> exp_ConsumptionCertificateRawMaterialsLst = new List<exp_ConsumptionCertificateRawMaterials>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				exp_ConsumptionCertificateRawMaterialsLst = dbExecutor.FetchData<exp_ConsumptionCertificateRawMaterials>(CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_GetDynamic", colparameters);
				return exp_ConsumptionCertificateRawMaterialsLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<exp_ConsumptionCertificateRawMaterials> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<exp_ConsumptionCertificateRawMaterials> exp_ConsumptionCertificateRawMaterialsLst = new List<exp_ConsumptionCertificateRawMaterials>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				exp_ConsumptionCertificateRawMaterialsLst = dbExecutor.FetchDataRef<exp_ConsumptionCertificateRawMaterials>(CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_GetPaged", colparameters, ref rows);
				return exp_ConsumptionCertificateRawMaterialsLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(exp_ConsumptionCertificateRawMaterials _exp_ConsumptionCertificateRawMaterials)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@ConsumptionCertificateId", _exp_ConsumptionCertificateRawMaterials.ConsumptionCertificateId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ImportBondNo", _exp_ConsumptionCertificateRawMaterials.ImportBondNo, DbType.String, ParameterDirection.Input),
				new Parameters("@PreviousBalance", _exp_ConsumptionCertificateRawMaterials.PreviousBalance, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ExportQty", _exp_ConsumptionCertificateRawMaterials.ExportQty, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ClosingBalance", _exp_ConsumptionCertificateRawMaterials.ClosingBalance, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatedBy", _exp_ConsumptionCertificateRawMaterials.UpdatedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedDate", _exp_ConsumptionCertificateRawMaterials.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_Create", colparameters, true);
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

		public List<exp_ConsumptionCertificateRawMaterials> GetByConsumptionCertificateRawMetrialByCiId(Int64 CommercialInvoiceId)
		{
			try
			{
				List<exp_ConsumptionCertificateRawMaterials> exp_consumptionCertificateList = new List<exp_ConsumptionCertificateRawMaterials>();
				Parameters[] colparameters = new Parameters[1]{
					new Parameters("@CommercialInvoiceId", CommercialInvoiceId, DbType.Int64, ParameterDirection.Input)
				};
				exp_consumptionCertificateList = dbExecutor.FetchData<exp_ConsumptionCertificateRawMaterials>(CommandType.StoredProcedure, "xRpt_exp_ConsumptionCertificateRawMaterials", colparameters);
				return exp_consumptionCertificateList;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Update(exp_ConsumptionCertificateRawMaterials _exp_ConsumptionCertificateRawMaterials)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@ConsumptionCertificateRawMaterialsId", _exp_ConsumptionCertificateRawMaterials.ConsumptionCertificateRawMaterialsId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ConsumptionCertificateId", _exp_ConsumptionCertificateRawMaterials.ConsumptionCertificateId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ImportBondNo", _exp_ConsumptionCertificateRawMaterials.ImportBondNo, DbType.String, ParameterDirection.Input),
				new Parameters("@PreviousBalance", _exp_ConsumptionCertificateRawMaterials.PreviousBalance, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ExportQty", _exp_ConsumptionCertificateRawMaterials.ExportQty, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ClosingBalance", _exp_ConsumptionCertificateRawMaterials.ClosingBalance, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatedBy", _exp_ConsumptionCertificateRawMaterials.UpdatedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedDate", _exp_ConsumptionCertificateRawMaterials.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 consumptionCertificateRawMaterialsId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ConsumptionCertificateRawMaterialsId", consumptionCertificateRawMaterialsId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_ConsumptionCertificateRawMaterials_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
