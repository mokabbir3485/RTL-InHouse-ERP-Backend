using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_PurchaseBillDetailSerialDAO //: IDisposible
    {
        private static volatile inv_PurchaseBillDetailSerialDAO instance;
        private static readonly object lockObj = new object();
        public static inv_PurchaseBillDetailSerialDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_PurchaseBillDetailSerialDAO();
            }
            return instance;
        }
        public static inv_PurchaseBillDetailSerialDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_PurchaseBillDetailSerialDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_PurchaseBillDetailSerialDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_PurchaseBillDetailSerial> GetAll(Int64? pBDetailSerialId = null)
        {
            try
            {
                List<inv_PurchaseBillDetailSerial> inv_PurchaseBillDetailSerialLst = new List<inv_PurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBDetailSerialId", pBDetailSerialId, DbType.Int64, ParameterDirection.Input)
                };
                inv_PurchaseBillDetailSerialLst = dbExecutor.FetchData<inv_PurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_Get", colparameters);
                return inv_PurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetBySerialAndWarrantyId(Int64 PBDetailId)
        {
            try
            {
                List<inv_PurchaseBillDetailSerial> inv_PurchaseBillDetailSerialLst = new List<inv_PurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBDetailId", PBDetailId, DbType.Int64, ParameterDirection.Input)
                };
                inv_PurchaseBillDetailSerialLst = dbExecutor.FetchData<inv_PurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerialGetById", colparameters);
                return inv_PurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_PurchaseBillDetailSerial> inv_PurchaseBillDetailSerialLst = new List<inv_PurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBillDetailSerialLst = dbExecutor.FetchData<inv_PurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_GetDynamic", colparameters);
                return inv_PurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBillDetailSerial> LocalGetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_LocalPurchaseBillDetailSerial> inv_LocalPurchaseBillDetailSerialLst = new List<inv_LocalPurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                    new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_LocalPurchaseBillDetailSerialLst = dbExecutor.FetchData<inv_LocalPurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_LocalPurchaseBillDetailSerial_GetDynamic", colparameters);
                return inv_LocalPurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_PurchaseBillDetailSerial> inv_PurchaseBillDetailSerialLst = new List<inv_PurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBillDetailSerialLst = dbExecutor.FetchDataRef<inv_PurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerialLocalAndImport_GetPaged", colparameters, ref rows);
                return inv_PurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_PurchaseBillDetailSerial _inv_PurchaseBillDetailSerial)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@ItemId", _inv_PurchaseBillDetailSerial.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBDetailId", _inv_PurchaseBillDetailSerial.PBDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SerialNo", _inv_PurchaseBillDetailSerial.SerialNo, DbType.String, ParameterDirection.Input),
                new Parameters("@WarrentyInDays", _inv_PurchaseBillDetailSerial.WarrentyInDays, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DepartmentId", _inv_PurchaseBillDetailSerial.DepartmentId, DbType.Int32, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_Create", colparameters, true);
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


        public Int64 AddForLocalPurchaseBill(inv_LocalPurchaseBillDetailSerial _inv_LocalPurchaseBillDetailSerial)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@ItemId", _inv_LocalPurchaseBillDetailSerial.ItemId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@LPBDetailId", _inv_LocalPurchaseBillDetailSerial.LPBDetailId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@SerialNo", _inv_LocalPurchaseBillDetailSerial.SerialNo, DbType.String, ParameterDirection.Input),
                    new Parameters("@WarrentyInDays", _inv_LocalPurchaseBillDetailSerial.WarrentyInDays, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@DepartmentId", _inv_LocalPurchaseBillDetailSerial.DepartmentId, DbType.Int32, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_LocalPurchaseBillDetailSerial_Create", colparameters, true);
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


        public Int64 Update(inv_PurchaseBillDetailSerial _inv_PurchaseBillDetailSerial)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@ItemId", _inv_PurchaseBillDetailSerial.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBDetailId", _inv_PurchaseBillDetailSerial.PBDetailId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@SerialNo", _inv_PurchaseBillDetailSerial.SerialNo, DbType.String, ParameterDirection.Input),
                new Parameters("@WarrentyInDays", _inv_PurchaseBillDetailSerial.WarrentyInDays, DbType.Int32, ParameterDirection.Input),
                new Parameters("@DepartmentId", _inv_PurchaseBillDetailSerial.DepartmentId, DbType.Int32, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_Update", colparameters, true);
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
        public int UpdateDepartment(Int64 pBDetailSerialId, int departmentId)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@PBDetailSerialId", pBDetailSerialId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_UpdateDepartment", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LocalUpdateDepartment(Int64 LPBDetailSerialId, int departmentId)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@LPBDetailSerialId", LPBDetailSerialId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_LocalPurchaseBillDetailSerial_UpdateDepartment", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 pBDetailSerialId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBDetailSerialId", pBDetailSerialId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetailSerial> GetByItemAddAttId(Int32 itemAddAttId)
        {
            try
            {
                List<inv_PurchaseBillDetailSerial> inv_PurchaseBillDetailSerialLst = new List<inv_PurchaseBillDetailSerial>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemAddAttId", itemAddAttId, DbType.Int32, ParameterDirection.Input)
                };
                inv_PurchaseBillDetailSerialLst = dbExecutor.FetchData<inv_PurchaseBillDetailSerial>(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_GetByItemAddAttId", colparameters);
                return inv_PurchaseBillDetailSerialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDelivered(Int64 pBDetailSerialId, Int64 deliveryDetailId)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@PBDetailSerialId", pBDetailSerialId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@DeliveryDetailId", deliveryDetailId, DbType.Int64, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetailSerial_UpdateDelivered", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
