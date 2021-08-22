using DbExecutor;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace SecurityDAL
{
    public class ad_ItemAdditionalAttributeDAO //: IDisposible
    {
        private static volatile ad_ItemAdditionalAttributeDAO instance;
        private static readonly object lockObj = new object();
        public static ad_ItemAdditionalAttributeDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ad_ItemAdditionalAttributeDAO();
            }
            return instance;
        }
        public static ad_ItemAdditionalAttributeDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ad_ItemAdditionalAttributeDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public ad_ItemAdditionalAttributeDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<ad_ItemAdditionalAttribute> GetAll(Int32? itemaddattid = null)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeLst = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemAddAttId", itemaddattid, DbType.Int32, ParameterDirection.Input)
                };
                ad_ItemAdditionalAttributeLst = dbExecutor.FetchData<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_Get", colparameters);
                return ad_ItemAdditionalAttributeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttribute> GetByItemId(Int32 ItemId)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeList = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
                };
                ad_ItemAdditionalAttributeList = dbExecutor.FetchData<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetByItemId", colparameters);
                return ad_ItemAdditionalAttributeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttribute> GetOperationalByItemId(Int32 ItemId)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeList = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
                };
                ad_ItemAdditionalAttributeList = dbExecutor.FetchData<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetOperationalByItemId", colparameters);
                return ad_ItemAdditionalAttributeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttribute> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeLst = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                ad_ItemAdditionalAttributeLst = dbExecutor.FetchData<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetDynamic", colparameters);
                return ad_ItemAdditionalAttributeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttribute> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeLst = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                ad_ItemAdditionalAttributeLst = dbExecutor.FetchDataRef<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetPaged", colparameters, ref rows);
                return ad_ItemAdditionalAttributeLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(ad_ItemAdditionalAttribute _ad_ItemAdditionalAttribute)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[3]{
                new Parameters("@ItemId", _ad_ItemAdditionalAttribute.ItemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Barcode", _ad_ItemAdditionalAttribute.Barcode, DbType.String, ParameterDirection.Input),
                new Parameters("@IsActive", _ad_ItemAdditionalAttribute.IsActive, DbType.Boolean, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_Create", colparameters, true);
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
        public int Update(ad_ItemAdditionalAttribute _ad_ItemAdditionalAttribute)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[3]{
                new Parameters("@ItemAddAttId", _ad_ItemAdditionalAttribute.ItemAddAttId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ItemId", _ad_ItemAdditionalAttribute.ItemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Barcode", _ad_ItemAdditionalAttribute.Barcode, DbType.String, ParameterDirection.Input),
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int32 itemaddattid)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemAddAttId", itemaddattid, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAttributeNameByItemId(int itemId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetAttributeNameByItemId", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemAdditionalAttribute> GetByItemIdAndAttributeValueIdConcat(Int32 itemId, string attributeValueIdConcat)
        {
            try
            {
                List<ad_ItemAdditionalAttribute> ad_ItemAdditionalAttributeList = new List<ad_ItemAdditionalAttribute>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Combination", attributeValueIdConcat, DbType.String, ParameterDirection.Input)
                };
                ad_ItemAdditionalAttributeList = dbExecutor.FetchData<ad_ItemAdditionalAttribute>(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetByValueId", colparameters);
                return ad_ItemAdditionalAttributeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetByItemIdAndAttributeValueIdConcatCount(Int32 itemId, string attributeValueIdConcat)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@Combination", attributeValueIdConcat, DbType.String, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetCountByValueIdConcat", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCombinationLike()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetCombinationConcat", true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByDepartment(int departmentId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetByDepartment", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCombinationWithPrice()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetCombinationWithPrice", true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCombinationByRequisitionId(Int64 requisitionId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@RequisitionId", requisitionId, DbType.Int64, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetCombinationByRequisitionId", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByDepartmentAllItem(int departmentId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetByDepartmentAllItem", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllBarcode()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetAllBarcode", true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCombinationValue()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_ItemAdditionalAttribute_GetCombinationValue", true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
