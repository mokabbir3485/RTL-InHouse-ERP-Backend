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
	public class inv_ReturnFromDepartmentDetailDAO //: IDisposible
	{
		private static volatile inv_ReturnFromDepartmentDetailDAO instance;
		private static readonly object lockObj = new object();
		public static inv_ReturnFromDepartmentDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_ReturnFromDepartmentDetailDAO();
			}
			return instance;
		}
		public static inv_ReturnFromDepartmentDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_ReturnFromDepartmentDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_ReturnFromDepartmentDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
        public List<inv_ReturnFromDepartmentDetail> GetByReturnId(Int64 returnId)
		{
			try
			{
				List<inv_ReturnFromDepartmentDetail> inv_ReturnFromDepartmentDetailLst = new List<inv_ReturnFromDepartmentDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ReturnId", returnId, DbType.Int64, ParameterDirection.Input)
				};
                inv_ReturnFromDepartmentDetailLst = dbExecutor.FetchData<inv_ReturnFromDepartmentDetail>(CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_GetByReturnId", colparameters);
				return inv_ReturnFromDepartmentDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_ReturnFromDepartmentDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<inv_ReturnFromDepartmentDetail> inv_ReturnFromDepartmentDetailLst = new List<inv_ReturnFromDepartmentDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				inv_ReturnFromDepartmentDetailLst = dbExecutor.FetchData<inv_ReturnFromDepartmentDetail>(CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_GetDynamic", colparameters);
				return inv_ReturnFromDepartmentDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<inv_ReturnFromDepartmentDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<inv_ReturnFromDepartmentDetail> inv_ReturnFromDepartmentDetailLst = new List<inv_ReturnFromDepartmentDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				inv_ReturnFromDepartmentDetailLst = dbExecutor.FetchDataRef<inv_ReturnFromDepartmentDetail>(CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_GetPaged", colparameters, ref rows);
				return inv_ReturnFromDepartmentDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(inv_ReturnFromDepartmentDetail _inv_ReturnFromDepartmentDetail)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[9]{
				new Parameters("@ReturnId", _inv_ReturnFromDepartmentDetail.ReturnId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_ReturnFromDepartmentDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReturnUnitId", _inv_ReturnFromDepartmentDetail.ReturnUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReturnQuantity", _inv_ReturnFromDepartmentDetail.ReturnQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ReturnUnitPrice", _inv_ReturnFromDepartmentDetail.ReturnUnitPrice, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ReturnReasonId", _inv_ReturnFromDepartmentDetail.ReturnReasonId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_ReturnFromDepartmentDetail.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@ReturnUnitName", _inv_ReturnFromDepartmentDetail.ReturnUnitName, DbType.String, ParameterDirection.Input),
				new Parameters("@ReturnReasonName", _inv_ReturnFromDepartmentDetail.ReturnReasonName, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_Create", colparameters, true);
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
		public int Update(inv_ReturnFromDepartmentDetail _inv_ReturnFromDepartmentDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[10]{
				new Parameters("@ReturnDetailId", _inv_ReturnFromDepartmentDetail.ReturnDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ReturnId", _inv_ReturnFromDepartmentDetail.ReturnId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_ReturnFromDepartmentDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReturnUnitId", _inv_ReturnFromDepartmentDetail.ReturnUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ReturnQuantity", _inv_ReturnFromDepartmentDetail.ReturnQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ReturnUnitPrice", _inv_ReturnFromDepartmentDetail.ReturnUnitPrice, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ReturnReasonId", _inv_ReturnFromDepartmentDetail.ReturnReasonId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_ReturnFromDepartmentDetail.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@ReturnUnitName", _inv_ReturnFromDepartmentDetail.ReturnUnitName, DbType.String, ParameterDirection.Input),
				new Parameters("@ReturnReasonName", _inv_ReturnFromDepartmentDetail.ReturnReasonName, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 returnDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ReturnDetailId", returnDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_ReturnFromDepartmentDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
