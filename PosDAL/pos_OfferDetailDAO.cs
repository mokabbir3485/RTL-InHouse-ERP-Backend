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
	public class pos_OfferDetailDAO //: IDisposible
	{
		private static volatile pos_OfferDetailDAO instance;
		private static readonly object lockObj = new object();
		public static pos_OfferDetailDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_OfferDetailDAO();
			}
			return instance;
		}
		public static pos_OfferDetailDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_OfferDetailDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_OfferDetailDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pos_OfferDetail> GetByOfferId(Int64 offerId)
		{
			try
			{
				List<pos_OfferDetail> pos_OfferDetailLst = new List<pos_OfferDetail>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OfferId", offerId, DbType.Int64, ParameterDirection.Input)
				};
                pos_OfferDetailLst = dbExecutor.FetchData<pos_OfferDetail>(CommandType.StoredProcedure, "pos_OfferDetail_GetByOfferId", colparameters);
				return pos_OfferDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_OfferDetail> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_OfferDetail> pos_OfferDetailLst = new List<pos_OfferDetail>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_OfferDetailLst = dbExecutor.FetchData<pos_OfferDetail>(CommandType.StoredProcedure, "pos_OfferDetail_GetDynamic", colparameters);
				return pos_OfferDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_OfferDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_OfferDetail> pos_OfferDetailLst = new List<pos_OfferDetail>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_OfferDetailLst = dbExecutor.FetchDataRef<pos_OfferDetail>(CommandType.StoredProcedure, "pos_OfferDetail_GetPaged", colparameters, ref rows);
				return pos_OfferDetailLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_OfferDetail _pos_OfferDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[4]{
				new Parameters("@OfferId", _pos_OfferDetail.OfferId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_OfferDetail.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleUnitId", _pos_OfferDetail.SaleUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeUnitId", _pos_OfferDetail.FreeUnitId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_OfferDetail_Create", colparameters, true);
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
		public int Update(pos_OfferDetail _pos_OfferDetail)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@OfferDetailId", _pos_OfferDetail.OfferDetailId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@OfferId", _pos_OfferDetail.OfferId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemId", _pos_OfferDetail.ItemId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_OfferDetail_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 offerDetailId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OfferDetailId", offerDetailId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_OfferDetail_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
