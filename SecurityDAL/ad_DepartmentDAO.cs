using DbExecutor;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace SecurityDAL
{
    public class ad_DepartmentDAO //: IDisposible
    {
        private static volatile ad_DepartmentDAO instance;
        private static readonly object lockObj = new object();
        public static ad_DepartmentDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ad_DepartmentDAO();
            }
            return instance;
        }
        public static ad_DepartmentDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ad_DepartmentDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public ad_DepartmentDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<ad_Department> GetAll(Int32? departmentId = null)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_Get", colparameters);
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllStore()
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetAllStore");
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllFactory()
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetAllFactory");
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllUserDepartment(int userId)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@UserId", userId, DbType.Int32, ParameterDirection.Input)
                };
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "s_UserDepartment_GetByUserId");
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetAllActiveByBranchId(int branchId, Int32? departmentId = null)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@BranchId", branchId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetAllActiveByBranchId", colparameters);
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ad_Department> GetByBranchAndGrade(int branchId, int gradeId, Int32? departmentId = null)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[3]{
                    new Parameters("@BranchId", branchId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@GradeId", gradeId, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetByBranchAndGrade", colparameters);
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ad_Department> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                ad_DepartmentLst = dbExecutor.FetchData<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetDynamic", colparameters);
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Department> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<ad_Department> ad_DepartmentLst = new List<ad_Department>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                ad_DepartmentLst = dbExecutor.FetchDataRef<ad_Department>(CommandType.StoredProcedure, "ad_Department_GetPaged", colparameters, ref rows);
                return ad_DepartmentLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(ad_Department ad_Department)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[16]{
                new Parameters("@BranchId", ad_Department.BranchId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DepartmentName", ad_Department.DepartmentName, DbType.String, ParameterDirection.Input),
                new Parameters("@DepartmentShortName", ad_Department.DepartmentShortName, DbType.String, ParameterDirection.Input),
                new Parameters("@Address", ad_Department.Address, DbType.String, ParameterDirection.Input),
                new Parameters("@ContactNo", ad_Department.ContactNo, DbType.String, ParameterDirection.Input),
                new Parameters("@Email", ad_Department.Email, DbType.String, ParameterDirection.Input),
                new Parameters("@ManagerName", ad_Department.ManagerName, DbType.String, ParameterDirection.Input),
                new Parameters("@OpeningDate", ad_Department.OpeningDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@IsActive", ad_Department.IsActive, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@Fax", ad_Department.Fax, DbType.String, ParameterDirection.Input),
                new Parameters("@IsUnit", ad_Department.IsUnit, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@SerialNo", ad_Department.SerialNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreatorId", ad_Department.CreatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreateDate", ad_Department.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", ad_Department.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", ad_Department.UpdateDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_Department_Create", colparameters, true);
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
        public int Update(ad_Department ad_Department)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[15]{
                new Parameters("@DepartmentId", ad_Department.DepartmentId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@BranchId", ad_Department.BranchId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DepartmentName", ad_Department.DepartmentName, DbType.String, ParameterDirection.Input),
                new Parameters("@DepartmentShortName", ad_Department.DepartmentShortName, DbType.String, ParameterDirection.Input),
                new Parameters("@Address", ad_Department.Address, DbType.String, ParameterDirection.Input),
                new Parameters("@ContactNo", ad_Department.ContactNo, DbType.String, ParameterDirection.Input),
                new Parameters("@Email", ad_Department.Email, DbType.String, ParameterDirection.Input),
                new Parameters("@ManagerName", ad_Department.ManagerName, DbType.String, ParameterDirection.Input),
                new Parameters("@OpeningDate", ad_Department.OpeningDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@IsActive", ad_Department.IsActive, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@Fax", ad_Department.Fax, DbType.String, ParameterDirection.Input),
                new Parameters("@IsUnit", ad_Department.IsUnit, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@SerialNo", ad_Department.SerialNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdatorId", ad_Department.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", ad_Department.UpdateDate, DbType.DateTime, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Department_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int32 departmentId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Department_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
