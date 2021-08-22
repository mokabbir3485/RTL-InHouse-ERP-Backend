using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;

namespace SecurityDAL
{
	public class ad_ItemAdditionalAttributeValueDAO //: IDisposible
	{
		private static volatile ad_ItemAdditionalAttributeValueDAO instance;
		private static readonly object lockObj = new object();
		public static ad_ItemAdditionalAttributeValueDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new ad_ItemAdditionalAttributeValueDAO();
			}
			return instance;
		}
		public static ad_ItemAdditionalAttributeValueDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new ad_ItemAdditionalAttributeValueDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public ad_ItemAdditionalAttributeValueDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<ad_ItemAdditionalAttributeValue> GetAll(Int32? itemaddattvalueid = null,Int32? itemaddattid = null)
		{
			try
			{
				List<ad_ItemAdditionalAttributeValue> ad_ItemAdditionalAttributeValueLst = new List<ad_ItemAdditionalAttributeValue>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemAddAttValueId", itemaddattvalueid, DbType.Int32, ParameterDirection.Input)
				};
				ad_ItemAdditionalAttributeValueLst = dbExecutor.FetchData<ad_ItemAdditionalAttributeValue>(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_Get", colparameters);
				return ad_ItemAdditionalAttributeValueLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ad_ItemAdditionalAttributeValue> GetByItemAddAttId(Int32 ItemAddAttId)
        {
            try
            {
                List<ad_ItemAdditionalAttributeValue> ad_ItemAdditionalAttributeValueList = new List<ad_ItemAdditionalAttributeValue>();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemAddAttId", ItemAddAttId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemAdditionalAttributeValueList = dbExecutor.FetchData<ad_ItemAdditionalAttributeValue>(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_GetByItemAddAttId", colparameters);
                return ad_ItemAdditionalAttributeValueList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttributeValue> GetByItemAddAttIdForItemEdit(Int32 itemId, Int32 attributeId)
        {
            try
            {
                List<ad_ItemAdditionalAttributeValue> ad_ItemAdditionalAttributeValueList = new List<ad_ItemAdditionalAttributeValue>();
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@AttributeId", attributeId, DbType.Int32, ParameterDirection.Input)
				};
                ad_ItemAdditionalAttributeValueList = dbExecutor.FetchData<ad_ItemAdditionalAttributeValue>(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_GetByItemAddAttIdForItemEdit", colparameters);
                return ad_ItemAdditionalAttributeValueList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<ad_ItemAdditionalAttributeValue> GetDynamic(string whereCondition,string orderByExpression)
		{
			try
			{
				List<ad_ItemAdditionalAttributeValue> ad_ItemAdditionalAttributeValueLst = new List<ad_ItemAdditionalAttributeValue>();
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
				new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
				};
				ad_ItemAdditionalAttributeValueLst = dbExecutor.FetchData<ad_ItemAdditionalAttributeValue>(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_GetDynamic", colparameters);
				return ad_ItemAdditionalAttributeValueLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ad_ItemAdditionalAttributeValue> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
		{
			try
			{
				List<ad_ItemAdditionalAttributeValue> ad_ItemAdditionalAttributeValueLst = new List<ad_ItemAdditionalAttributeValue>();
				Parameters[] colparameters = new Parameters[5]{
				new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
				new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
				new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
				new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
				new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
				};
				ad_ItemAdditionalAttributeValueLst = dbExecutor.FetchDataRef<ad_ItemAdditionalAttributeValue>(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_GetPaged", colparameters, ref rows);
				return ad_ItemAdditionalAttributeValueLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Int64 Add(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
		{
			Int64 ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemAddAttId", _ad_ItemAdditionalAttributeValue.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeValueId", _ad_ItemAdditionalAttributeValue.AttributeValueId, DbType.Int32, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_Create", colparameters, true);
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
        public Int64 AddWithValue(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
				new Parameters("@ItemAddAttId", _ad_ItemAdditionalAttributeValue.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@Value", _ad_ItemAdditionalAttributeValue.Value, DbType.String, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_CreateWithValue", colparameters, true);
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
		public int Update(ad_ItemAdditionalAttributeValue _ad_ItemAdditionalAttributeValue)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[3]{
				new Parameters("@ItemAddAttValueId", _ad_ItemAdditionalAttributeValue.ItemAddAttValueId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@ItemAddAttId", _ad_ItemAdditionalAttributeValue.ItemAddAttId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@AttributeValueId", _ad_ItemAdditionalAttributeValue.AttributeValueId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int32 itemaddattvalueid)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemAddAttValueId", itemaddattvalueid, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataTable GetByItemId(int itemId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input)
				};
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttributeValue_GetByItemId", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
