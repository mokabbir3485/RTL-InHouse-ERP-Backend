using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace InventoryDAL
{
    public class inv_BillOfMaterialDAO
    {
        private static volatile inv_BillOfMaterialDAO instance;
        private static readonly object lockObj = new object();
        public static inv_BillOfMaterialDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_BillOfMaterialDAO();
            }
            return instance;
        }
        public static inv_BillOfMaterialDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_BillOfMaterialDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_BillOfMaterialDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }

        public List<inv_BillOfMaterial> Get(Int64? BillOfMaterialId = null)
        {
            try
            {
                List<inv_BillOfMaterial> inv_BillOfMaterialLst = new List<inv_BillOfMaterial>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@BillOfMaterialId", BillOfMaterialId, DbType.Int64, ParameterDirection.Input)
                };
                inv_BillOfMaterialLst = dbExecutor.FetchData<inv_BillOfMaterial>(CommandType.StoredProcedure, "inv_BillOfMaterial_Get", colparameters);
                return inv_BillOfMaterialLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_BillOfMaterialOverhead> OverheadGetAll(Int64? BOMId = null, string SectorType = null)
        {
            try
            {
                List<inv_BillOfMaterialOverhead> inv_BillOfMaterialOverheadLst = new List<inv_BillOfMaterialOverhead>();
                Parameters[] colparameters = new Parameters[2]{
                    new Parameters("@BOMId", BOMId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@SectorType", SectorType, DbType.String, ParameterDirection.Input)
                };
                inv_BillOfMaterialOverheadLst = dbExecutor.FetchData<inv_BillOfMaterialOverhead>(CommandType.StoredProcedure, "inv_BillOfMaterialOverhead_Get", colparameters);
                return inv_BillOfMaterialOverheadLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_BillOfMaterialDetail> GetDetail(Int64? BOMId = null)
        {
            try
            {
                List<inv_BillOfMaterialDetail> inv_BillOfMaterialDetailLst = new List<inv_BillOfMaterialDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@BOMId", BOMId, DbType.Int64, ParameterDirection.Input)
                };
                inv_BillOfMaterialDetailLst = dbExecutor.FetchData<inv_BillOfMaterialDetail>(CommandType.StoredProcedure, "inv_BillOfMaterialDetail_Get", colparameters);
                return inv_BillOfMaterialDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_BillOfMaterial> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_BillOfMaterial> inv_BillOfMaterial = new List<inv_BillOfMaterial>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_BillOfMaterial = dbExecutor.FetchDataRef<inv_BillOfMaterial>(CommandType.StoredProcedure, "inv_BillOfMaterial_GetPaged", colparameters, ref rows);
                return inv_BillOfMaterial;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int DeleteOerheadByBOMId(Int64 BOMId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@BOMId", BOMId, DbType.Int64, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_BillOfMaterialOverhead_DeleteByBOMId", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteDetailByBOMId(Int64 BOMId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@BOMId", BOMId, DbType.Int64, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_BillOfMaterialDetail_DeleteByBOMId", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Post(inv_BillOfMaterial _inv_BillOfMaterial)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[12]{
                new Parameters("@BillOfMaterialId", _inv_BillOfMaterial.BillOfMaterialId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@BillOfMaterialNo ", _inv_BillOfMaterial.BillOfMaterialNo , DbType.String, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_BillOfMaterial.ItemId, DbType.Int64 , ParameterDirection.Input),
                new Parameters("@ItemName", _inv_BillOfMaterial.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@Qty", _inv_BillOfMaterial.Qty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@Unit", _inv_BillOfMaterial.Unit, DbType.String, ParameterDirection.Input),
                new Parameters("@SubmitDate", _inv_BillOfMaterial.SubmitDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@DeliveryDate", _inv_BillOfMaterial.DeliveryDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@CreatorId", _inv_BillOfMaterial.CreatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreateDate", _inv_BillOfMaterial.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", _inv_BillOfMaterial.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", _inv_BillOfMaterial.UpdateDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_BillOfMaterial_Post", colparameters, true);
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

        public Int64 PostDetail(inv_BillOfMaterialDetail _inv_BillOfMaterialDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[11]{
                new Parameters("@BOMDetailId", _inv_BillOfMaterialDetail.BOMDetailId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@BOMId", _inv_BillOfMaterialDetail.BOMId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@ItemId", _inv_BillOfMaterialDetail.ItemId, DbType.Int64 , ParameterDirection.Input),
                new Parameters("@ItemName", _inv_BillOfMaterialDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@Qty", _inv_BillOfMaterialDetail.Qty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@Unit", _inv_BillOfMaterialDetail.Unit, DbType.String, ParameterDirection.Input),
                new Parameters("@WastagePercentage", _inv_BillOfMaterialDetail.WastagePercentage, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@WastageAmount", _inv_BillOfMaterialDetail.WastageAmount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@TotalProduction", _inv_BillOfMaterialDetail.TotalProduction, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@UnitPrice", _inv_BillOfMaterialDetail.UnitPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@TotalValue", _inv_BillOfMaterialDetail.TotalValue, DbType.Decimal, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_BillOfMaterialDetail_Post", colparameters, true);
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

        public Int64 PostOverhead(inv_BillOfMaterialOverhead _inv_BillOfMaterialOverhead)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@BOMOverheadId", _inv_BillOfMaterialOverhead.BOMOverheadId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@BOMId", _inv_BillOfMaterialOverhead.BOMId, DbType.Int64 ,ParameterDirection.Input),
                new Parameters("@SectorName", _inv_BillOfMaterialOverhead.SectorName, DbType.String , ParameterDirection.Input),
                new Parameters("@Amount", _inv_BillOfMaterialOverhead.Amount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@SectorType", _inv_BillOfMaterialOverhead.SectorType, DbType.String , ParameterDirection.Input),
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_BillOfMaterialOverhead_Post", colparameters, true);
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

        public DbDataReader GetMaxBillOfMaterialNo()
        {
            try
            {

                DbDataReader BillOfMaterialNo = dbExecutor.ExecuteReader(CommandType.StoredProcedure, "inv_GetMaxBillOfMaterial");
                return BillOfMaterialNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
