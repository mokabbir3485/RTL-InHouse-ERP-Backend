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
	public class pro_ProductionDAO //: IDisposible
	{
		private static volatile pro_ProductionDAO instance;
		private static readonly object lockObj = new object();
		public static pro_ProductionDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pro_ProductionDAO();
			}
			return instance;
		}
		public static pro_ProductionDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pro_ProductionDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pro_ProductionDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pro_Production> GetAll(Int64? productionId = null)
		{
			try
			{
				List<pro_Production> pro_ProductionLst = new List<pro_Production>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ProductionId", productionId, DbType.Int32, ParameterDirection.Input)
				};
				pro_ProductionLst = dbExecutor.FetchData<pro_Production>(CommandType.StoredProcedure, "pro_Production_Get", colparameters);
				return pro_ProductionLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pro_Production> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pro_Production> pro_ProductionLst = new List<pro_Production>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pro_ProductionLst = dbExecutor.FetchData<pro_Production>(CommandType.StoredProcedure, "pro_Production_GetDynamic", colparameters);
				return pro_ProductionLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pro_Production> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pro_Production> pro_ProductionLst = new List<pro_Production>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pro_ProductionLst = dbExecutor.FetchDataRef<pro_Production>(CommandType.StoredProcedure, "pro_Production_GetPaged", colparameters, ref rows);
				return pro_ProductionLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(pro_Production _pro_Production)
		{
			Int64 ret = 0;
			try
			{
                Common aCommon = new Common();

                //PN/17-18/1, PN/17-18/2, PN/17-18/3, PN/17-18/100, PN/17-18/1001

                string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(_pro_Production.ProductionDate);
                _pro_Production.ProductionNo = "PN/" + aFiscalYearPart + "/" + _pro_Production.ProductionNo;

				Parameters[] colparameters = new Parameters[10]{
				new Parameters("@DepartmentId", _pro_Production.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@InternalWorkOrderId", _pro_Production.InternalWorkOrderId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ProductionNo", _pro_Production.ProductionNo, DbType.String, ParameterDirection.Input),
				new Parameters("@ProductionDate", _pro_Production.ProductionDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Remarks", _pro_Production.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@PreparedById", _pro_Production.PreparedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreatorId", _pro_Production.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _pro_Production.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pro_Production.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pro_Production.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pro_Production_Create", colparameters, true);
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
		public int Update(pro_Production _pro_Production)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[8]{
				new Parameters("@ProductionId", _pro_Production.ProductionId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@InternalWorkOrderId", _pro_Production.InternalWorkOrderId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ProductionNo", _pro_Production.ProductionNo, DbType.String, ParameterDirection.Input),
				new Parameters("@ProductionDate", _pro_Production.ProductionDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@Remarks", _pro_Production.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@PreparedById", _pro_Production.PreparedById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pro_Production.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pro_Production.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pro_Production_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 productionId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ProductionId", productionId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pro_Production_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 GetMaxProductionNo(DateTime productionDate)
        {
            try
            {
                Common aCommon = new Common();
                DbExecutor.FiscalYear aFiscalYear = aCommon.GetFiscalFormDateAndToDate(productionDate);

                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@fromDate", aFiscalYear.FromDate, DbType.DateTime, ParameterDirection.Input),
                    new Parameters("@toDate", aFiscalYear.ToDate, DbType.DateTime, ParameterDirection.Input)
                };

                Int64 maxIWNo = 0;

                dbExecutor.ManageTransaction(TransactionType.Open);
                maxIWNo = dbExecutor.ExecuteScalar64(true, CommandType.Text, "SELECT ProductionNo=CAST((ISNULL( MAX(CAST(SUBSTRING([ProductionNo],10,((LEN([ProductionNo])+1)-10)) AS BIGINT)),0)+1) AS VARCHAR(50)) FROM [pro_Production] WHERE [ProductionNo] IS NOT NULL AND LEN([ProductionNo])>=10 AND ( [ProductionDate] BETWEEN @fromDate AND @toDate )", colparameters, true);
                dbExecutor.ManageTransaction(TransactionType.Commit);
                return maxIWNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
