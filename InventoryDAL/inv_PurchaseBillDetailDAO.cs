using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryDAL
{
    public class inv_PurchaseBillDetailDAO //: IDisposible
    {
        private static volatile inv_PurchaseBillDetailDAO instance;
        private static readonly object lockObj = new object();
        public static inv_PurchaseBillDetailDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_PurchaseBillDetailDAO();
            }
            return instance;
        }
        public static inv_PurchaseBillDetailDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_PurchaseBillDetailDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_PurchaseBillDetailDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_PurchaseBillDetail> GetAll(Int64? PBDetailId = null, Int64? PBId = null)
        {
            try
            {
                List<inv_PurchaseBillDetail> inv_PurchaseBillDetailLst = new List<inv_PurchaseBillDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBDetailId", PBDetailId, DbType.Int32, ParameterDirection.Input)
                };
                inv_PurchaseBillDetailLst = dbExecutor.FetchData<inv_PurchaseBillDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetail_Get", colparameters);
                return inv_PurchaseBillDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBillDetail> GetByPBId(Int64 PBId)
        {
            try
            {
                List<inv_PurchaseBillDetail> inv_PurchaseBillDetailLst = new List<inv_PurchaseBillDetail>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBId", PBId, DbType.Int64, ParameterDirection.Input)
                };
                inv_PurchaseBillDetailLst = dbExecutor.FetchData<inv_PurchaseBillDetail>(CommandType.StoredProcedure, "inv_PurchaseBillDetail_GetByPBId", colparameters);
                return inv_PurchaseBillDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBillDetail> LocalGetByPBId(Int64 LPBId)
        {
            try
            {
                List<inv_LocalPurchaseBillDetail> inv_LocalPurchaseBillDetailLst = new List<inv_LocalPurchaseBillDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@LPBId", LPBId, DbType.Int64, ParameterDirection.Input)
                };
                inv_LocalPurchaseBillDetailLst = dbExecutor.FetchData<inv_LocalPurchaseBillDetail>(CommandType.StoredProcedure, "inv_LocalPurchaseBillDetail_GetByPBId", colparameters);
                return inv_LocalPurchaseBillDetailLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 Add(inv_PurchaseBillDetail _inv_PurchaseBillDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[29]{
                new Parameters("@PBId", _inv_PurchaseBillDetail.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_PurchaseBillDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBUnitId", _inv_PurchaseBillDetail.PBUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PBQty", _inv_PurchaseBillDetail.PBQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@PBPrice", _inv_PurchaseBillDetail.PBPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_PurchaseBillDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@UnitName", _inv_PurchaseBillDetail.UnitName, DbType.String, ParameterDirection.Input),
                //Ne
                new Parameters("@HsCode ", _inv_PurchaseBillDetail.HsCode , DbType.String, ParameterDirection.Input),


                 new Parameters("@TotalCostAfterDiscount",  _inv_PurchaseBillDetail.TotalCostAfterDiscount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@CdPercentage ", _inv_PurchaseBillDetail.CdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@CdAmount ", _inv_PurchaseBillDetail.CdAmount , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@RdPercentage ", _inv_PurchaseBillDetail.RdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@RdAmount ", _inv_PurchaseBillDetail.RdAmount , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@DiscountAmount ", _inv_PurchaseBillDetail.DiscountAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@SdPercentage ", _inv_PurchaseBillDetail.SdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@SdAmount ", _inv_PurchaseBillDetail.SdAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@VatPercentage ", _inv_PurchaseBillDetail.VatPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@VatAmount  ", _inv_PurchaseBillDetail.VatAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@AitPercentage ", _inv_PurchaseBillDetail.AitPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@AitAmount ", _inv_PurchaseBillDetail.AitAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@AtPercentage ", _inv_PurchaseBillDetail.AtPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@AtAmount ", _inv_PurchaseBillDetail.AtAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@TtiPercentage ", _inv_PurchaseBillDetail.TtiPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@TtiAmount ", _inv_PurchaseBillDetail.TtiAmount , DbType.Decimal, ParameterDirection.Input),

                 new Parameters("@CurrentStock ", _inv_PurchaseBillDetail.CurrentStock , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@CurrencyType  ", _inv_PurchaseBillDetail.CurrencyType  , DbType.String, ParameterDirection.Input),
                 new Parameters("@ConversionRate  ", _inv_PurchaseBillDetail.ConversionRate  , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@TotalConversion  ", _inv_PurchaseBillDetail.TotalConversion  , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@TotalCost  ", _inv_PurchaseBillDetail.TotalCost  , DbType.Decimal, ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBillDetail_Create", colparameters, true);
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

        public Int64 LocalPBDetailAdd(inv_LocalPurchaseBillDetail local_inv_PurchaseBillDetail)
        {
            Int64 ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[15]{
                new Parameters("@LPBId", local_inv_PurchaseBillDetail.LPBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", local_inv_PurchaseBillDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBUnitId", local_inv_PurchaseBillDetail.PBUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PBQty", local_inv_PurchaseBillDetail.PBQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@PBPrice", local_inv_PurchaseBillDetail.PBPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", local_inv_PurchaseBillDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@UnitName", local_inv_PurchaseBillDetail.UnitName, DbType.String, ParameterDirection.Input),
                //Ne
                new Parameters("@DiscountAmount ",local_inv_PurchaseBillDetail.DiscountAmount , DbType.Decimal, ParameterDirection.Input),
                new Parameters("@HsCode ", local_inv_PurchaseBillDetail.HsCode , DbType.String, ParameterDirection.Input),
                new Parameters("@SdPercentage ", local_inv_PurchaseBillDetail.SdPercentage , DbType.String, ParameterDirection.Input),
                new Parameters("@SdAmount ", local_inv_PurchaseBillDetail.SdAmount , DbType.Decimal, ParameterDirection.Input),
                new Parameters("@VatPercentage ", local_inv_PurchaseBillDetail.VatPercentage , DbType.String, ParameterDirection.Input),
                new Parameters("@VatAmount  ", local_inv_PurchaseBillDetail.VatAmount , DbType.Decimal, ParameterDirection.Input),
                
                 new Parameters("@TotalCostAfterDiscount", local_inv_PurchaseBillDetail.TotalCostAfterDiscount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@TotalCost  ", local_inv_PurchaseBillDetail.TotalCost  , DbType.Decimal, ParameterDirection.Input)

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBillDetailLocal_Create", colparameters, true);
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
        public int Update(inv_PurchaseBillDetail _inv_PurchaseBillDetail)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[28]{

                new Parameters("@PBDetailId", _inv_PurchaseBillDetail.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBId", _inv_PurchaseBillDetail.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@ItemId", _inv_PurchaseBillDetail.ItemId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PBUnitId", _inv_PurchaseBillDetail.PBUnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PBQty", _inv_PurchaseBillDetail.PBQty, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@PBPrice", _inv_PurchaseBillDetail.PBPrice, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ItemName", _inv_PurchaseBillDetail.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@UnitName", _inv_PurchaseBillDetail.UnitName, DbType.String, ParameterDirection.Input),
                //Ne
                new Parameters("@HsCode ", _inv_PurchaseBillDetail.HsCode , DbType.String, ParameterDirection.Input),


                 new Parameters("@CdPercentage ", _inv_PurchaseBillDetail.CdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@CdAmount ", _inv_PurchaseBillDetail.CdAmount , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@RdPercentage ", _inv_PurchaseBillDetail.RdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@RdAmount ", _inv_PurchaseBillDetail.RdAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@SdPercentage ", _inv_PurchaseBillDetail.SdPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@SdAmount ", _inv_PurchaseBillDetail.SdAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@VatPercentage ", _inv_PurchaseBillDetail.VatPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@VatAmount  ", _inv_PurchaseBillDetail.VatAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@AitPercentage ", _inv_PurchaseBillDetail.AitPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@AitAmount ", _inv_PurchaseBillDetail.AitAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@AtPercentage ", _inv_PurchaseBillDetail.AtPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@AtAmount ", _inv_PurchaseBillDetail.AtAmount , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@TtiPercentage ", _inv_PurchaseBillDetail.TtiPercentage , DbType.String, ParameterDirection.Input),
                 new Parameters("@TtiAmount ", _inv_PurchaseBillDetail.TtiAmount , DbType.Decimal, ParameterDirection.Input),

                 new Parameters("@CurrentStock ", _inv_PurchaseBillDetail.CurrentStock , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@CurrencyType  ", _inv_PurchaseBillDetail.CurrencyType  , DbType.String, ParameterDirection.Input),
                 new Parameters("@ConversionRate  ", _inv_PurchaseBillDetail.ConversionRate  , DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@TotalConversion  ", _inv_PurchaseBillDetail.TotalConversion  , DbType.Decimal, ParameterDirection.Input),
                  new Parameters("@TotalCost  ", _inv_PurchaseBillDetail.TotalCost  , DbType.Decimal, ParameterDirection.Input)

                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetail_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBillDetail> GetSupplierLedger(Int32 supplierId, string fromDate, string toDate)
        {
            try
            {
                List<inv_PurchaseBillDetail> SupplierLedgerlLst = new List<inv_PurchaseBillDetail>();
                Parameters[] colparameters = new Parameters[3]{
                new Parameters("@supplierId", supplierId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@fromDate", fromDate, DbType.String, ParameterDirection.Input),
                new Parameters("@toDate", toDate, DbType.String, ParameterDirection.Input),
                };
                SupplierLedgerlLst = dbExecutor.FetchData<inv_PurchaseBillDetail>(CommandType.StoredProcedure, "proc_SupplierLedger", colparameters);
                return SupplierLedgerlLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 PBDetailId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBDetailId", PBDetailId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBillDetail_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
