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
	public class inv_StockDeclarationDAO //: IDisposible
	{
		private static volatile inv_StockDeclarationDAO instance;
		private static readonly object lockObj = new object();
		public static inv_StockDeclarationDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_StockDeclarationDAO();
			}
			return instance;
		}
		public static inv_StockDeclarationDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_StockDeclarationDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_StockDeclarationDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_StockDeclaration> GetAll(Int64? declarationId = null)
		{
			try
			{
				List<inv_StockDeclaration> inv_StockDeclarationLst = new List<inv_StockDeclaration>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeclarationId", declarationId, DbType.Int32, ParameterDirection.Input)
				};
				inv_StockDeclarationLst = dbExecutor.FetchData<inv_StockDeclaration>(CommandType.StoredProcedure, "inv_StockDeclaration_Get", colparameters);
				return inv_StockDeclarationLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeclaration> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_StockDeclaration> inv_StockDeclarationLst = new List<inv_StockDeclaration>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_StockDeclarationLst = dbExecutor.FetchData<inv_StockDeclaration>(CommandType.StoredProcedure, "inv_StockDeclaration_GetDynamic", colparameters);
				return inv_StockDeclarationLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_StockDeclaration> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_StockDeclaration> inv_StockDeclarationLst = new List<inv_StockDeclaration>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_StockDeclarationLst = dbExecutor.FetchDataRef<inv_StockDeclaration>(CommandType.StoredProcedure, "inv_StockDeclaration_GetPaged", colparameters, ref rows);
				return inv_StockDeclarationLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public Int64 Add(inv_StockDeclaration _inv_StockDeclaration)
		{
            Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[12]{
				new Parameters("@DeclarationNo", _inv_StockDeclaration.DeclarationNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeclarationDate", _inv_StockDeclaration.DeclarationDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_StockDeclaration.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeclaredById", _inv_StockDeclaration.DeclaredById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Remarks", _inv_StockDeclaration.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@CreatorId", _inv_StockDeclaration.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _inv_StockDeclaration.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockDeclaration.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockDeclaration.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentName", _inv_StockDeclaration.DepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeclaredBy", _inv_StockDeclaration.DeclaredBy, DbType.String, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDeclaration.IsApproved, DbType.Boolean, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockDeclaration_Create", colparameters, true);
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
		public int Update(inv_StockDeclaration _inv_StockDeclaration)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[11]{
				new Parameters("@DeclarationId", _inv_StockDeclaration.DeclarationId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@DeclarationNo", _inv_StockDeclaration.DeclarationNo, DbType.String, ParameterDirection.Input),
				new Parameters("@DeclarationDate", _inv_StockDeclaration.DeclarationDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_StockDeclaration.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@DeclaredById", _inv_StockDeclaration.DeclaredById, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Remarks", _inv_StockDeclaration.Remarks, DbType.String, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_StockDeclaration.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_StockDeclaration.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentName", _inv_StockDeclaration.DepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@DeclaredBy", _inv_StockDeclaration.DeclaredBy, DbType.String, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDeclaration.IsApproved, DbType.Boolean, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDeclaration_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateApprove(inv_StockDeclaration _inv_StockDeclaration)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@DeclarationId", _inv_StockDeclaration.DeclarationId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@IsApproved", _inv_StockDeclaration.IsApproved, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@ApprovedBy", _inv_StockDeclaration.ApprovedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApprovedDate", _inv_StockDeclaration.ApprovedDate, DbType.DateTime, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_StockDeclaration_UpdateApprove", colparameters, true);
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
		public int Delete(Int64 declarationId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@DeclarationId", declarationId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_StockDeclaration_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
