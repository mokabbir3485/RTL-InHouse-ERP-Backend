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
	public class pos_OfferDAO //: IDisposible
	{
		private static volatile pos_OfferDAO instance;
		private static readonly object lockObj = new object();
		public static pos_OfferDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new pos_OfferDAO();
			}
			return instance;
		}
		public static pos_OfferDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new pos_OfferDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public pos_OfferDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<pos_Offer> GetAll(Int64? offerId = null)
		{
			try
			{
				List<pos_Offer> pos_OfferLst = new List<pos_Offer>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OfferId", offerId, DbType.Int32, ParameterDirection.Input)
				};
				pos_OfferLst = dbExecutor.FetchData<pos_Offer>(CommandType.StoredProcedure, "pos_Offer_Get", colparameters);
				return pos_OfferLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Offer> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<pos_Offer> pos_OfferLst = new List<pos_Offer>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				pos_OfferLst = dbExecutor.FetchData<pos_Offer>(CommandType.StoredProcedure, "pos_Offer_GetDynamic", colparameters);
				return pos_OfferLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<pos_Offer> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<pos_Offer> pos_OfferLst = new List<pos_Offer>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				pos_OfferLst = dbExecutor.FetchDataRef<pos_Offer>(CommandType.StoredProcedure, "pos_Offer_GetPaged", colparameters, ref rows);
				return pos_OfferLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Add(pos_Offer _pos_Offer)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[17]{
				new Parameters("@RoleId", _pos_Offer.RoleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OfferName", _pos_Offer.OfferName, DbType.String, ParameterDirection.Input),
				new Parameters("@HasDateRange", _pos_Offer.HasDateRange, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@StartDate", _pos_Offer.StartDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@EndDate", _pos_Offer.EndDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@OfferTypeId", _pos_Offer.OfferTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OffPercentage", _pos_Offer.OffPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OffAmount", _pos_Offer.OffAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ManualAmount", _pos_Offer.ManualAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@BuyCount", _pos_Offer.BuyCount, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeCount", _pos_Offer.FreeCount, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApplyOnTypeId", _pos_Offer.ApplyOnTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@MaxLimitAmount", _pos_Offer.MaxLimitAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CreatorId", _pos_Offer.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _pos_Offer.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pos_Offer.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pos_Offer.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "pos_Offer_Create", colparameters, true);
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
		public int Update(pos_Offer _pos_Offer)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[16]{
				new Parameters("@OfferId", _pos_Offer.OfferId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@RoleId", _pos_Offer.RoleId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OfferName", _pos_Offer.OfferName, DbType.String, ParameterDirection.Input),
				new Parameters("@HasDateRange", _pos_Offer.HasDateRange, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@StartDate", _pos_Offer.StartDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@EndDate", _pos_Offer.EndDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@OfferTypeId", _pos_Offer.OfferTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OffPercentage", _pos_Offer.OffPercentage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OffAmount", _pos_Offer.OffAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@ManualAmount", _pos_Offer.ManualAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@BuyCount", _pos_Offer.BuyCount, DbType.Int32, ParameterDirection.Input),
				new Parameters("@FreeCount", _pos_Offer.FreeCount, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ApplyOnTypeId", _pos_Offer.ApplyOnTypeId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@MaxLimitAmount", _pos_Offer.MaxLimitAmount, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _pos_Offer.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _pos_Offer.UpdateDate, DbType.DateTime, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_Offer_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 offerId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OfferId", offerId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "pos_Offer_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetItemOfferInfo(DateTime saleDate, int itemId, int saleUnitId, decimal quantity)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@SaleDate", saleDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SaleUnitId", saleUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@Quantity", quantity, DbType.Decimal, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "pos_Offer_GetItemOfferInfo", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTopPrecentageOff(DateTime saleDate)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@SaleDate", saleDate, DbType.DateTime, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "pos_Offer_GetTopPrecentageOff", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
