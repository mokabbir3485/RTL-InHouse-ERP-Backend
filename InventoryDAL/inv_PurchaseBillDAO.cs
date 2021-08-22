using DbExecutor;
using InventoryEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace InventoryDAL
{
    public class inv_PurchaseBillDAO //: IDisposible
    {
        private static volatile inv_PurchaseBillDAO instance;
        private static readonly object lockObj = new object();
        public static inv_PurchaseBillDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new inv_PurchaseBillDAO();
            }
            return instance;
        }
        public static inv_PurchaseBillDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new inv_PurchaseBillDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public inv_PurchaseBillDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<inv_PurchaseBill> GetAll(Int64? PBId = null)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBId", PBId, DbType.Int64, ParameterDirection.Input)
                };
                inv_PurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBill_Get", colparameters);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBill> LocalGetAll(Int64? LPBId = null)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_LocalPurchaseBillLst = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@LPBId", LPBId, DbType.Int64, ParameterDirection.Input)
                };
                inv_LocalPurchaseBillLst = dbExecutor.FetchData<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_LocalPurchaseBill_Get", colparameters);
                return inv_LocalPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_PurchaseBill> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBill_GetDynamic", colparameters);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> GetBySupplierId(Int32 SupplierId)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SupplierId", SupplierId, DbType.Int32, ParameterDirection.Input)
                };
                inv_PurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBillGetBySupplierId", colparameters);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> GetByLocalSupplierId(Int32 SupplierId)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_LocalPurchaseBillLst = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@SupplierId", SupplierId, DbType.Int32, ParameterDirection.Input)
                };
                inv_LocalPurchaseBillLst = dbExecutor.FetchData<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_LocalPurchaseBillGetBySupplierId", colparameters);
                return inv_LocalPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<inv_LocalPurchaseBill> WarrantyAndSerialGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_PurchaseBill = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBill = dbExecutor.FetchDataRef<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_WarrantyAndSerial_GetPaged", colparameters, ref rows);
                return inv_PurchaseBill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<inv_PurchaseBill> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBillLst = dbExecutor.FetchDataRef<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBill_GetPaged", colparameters, ref rows);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> ImportGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_PurchaseBillLst = dbExecutor.FetchDataRef<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_ImportPurchaseBill_GetPaged", colparameters, ref rows);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBill> LocalGetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_localPurchaseBillLst = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[5]{
                    new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                    new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                    new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                inv_localPurchaseBillLst = dbExecutor.FetchDataRef<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_LocalPurchaseBill_GetPaged", colparameters, ref rows);
                return inv_localPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> GetTopForReceive(int topQty)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                inv_PurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBill_GetTopForReceive", colparameters);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> GetTopForLocalReceive(int topQty)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_LocalPurchaseBillLst = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                inv_LocalPurchaseBillLst = dbExecutor.FetchData<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_LocalPurchaseBill_GetTopForReceive", colparameters);
                return inv_LocalPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<inv_LocalPurchaseBill> GetTopForLocalWarrentyAndSerialNo(int topQty)
        {
            try
            {
                List<inv_LocalPurchaseBill> inv_LocalPurchaseBillLst = new List<inv_LocalPurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                inv_LocalPurchaseBillLst = dbExecutor.FetchData<inv_LocalPurchaseBill>(CommandType.StoredProcedure, "inv_LocalPurchaseBill_GetTopForWarrentyAndSerialNo", colparameters);
                return inv_LocalPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> GetTopForImportWarrentyAndSerialNo(int topQty)
        {
            try
            {
                List<inv_PurchaseBill> inv_ImportPurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                inv_ImportPurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_ImportPurchaseBill_GetTopForWarrentyAndSerialNo", colparameters);
                return inv_ImportPurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<inv_PurchaseBill> GetTopForWarrentyAndSerialNo(int topQty)
        {
            try
            {
                List<inv_PurchaseBill> inv_PurchaseBillLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@TopQty", topQty, DbType.Int32, ParameterDirection.Input)
                };
                inv_PurchaseBillLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "inv_PurchaseBill_GetTopForWarrentyAndSerialNo", colparameters);
                return inv_PurchaseBillLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 Add(inv_PurchaseBill _inv_PurchaseBill)
        {


            Int64 ret = 0;
            try
            {
                //Common aCommon = new Common();

                ////PB/17-18/1, PB/17-18/2, PB/17-18/3, PB/17-18/100, PB/17-18/1001

                //string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(_inv_PurchaseBill.PBDate);
                //_inv_PurchaseBill.PBNo = "PB/" + aFiscalYearPart + "/" + _inv_PurchaseBill.PBNo;

                Parameters[] colparameters = new Parameters[26]{
				//new Parameters("@POId", _inv_PurchaseBill.POId, DbType.Int64, ParameterDirection.Input),
				//new Parameters("@PONo", _inv_PurchaseBill.PONo, DbType.String, ParameterDirection.Input),
				//new Parameters("@PBNo", _inv_PurchaseBill.PBNo, DbType.String, ParameterDirection.Input),
    //            new Parameters("@Address",_inv_PurchaseBill.Address , DbType.String , ParameterDirection.Input),
    //            new Parameters("@SupplierName",_inv_PurchaseBill.SupplierName , DbType.String , ParameterDirection.Input),
    //            new Parameters("@PBDate", _inv_PurchaseBill.PBDate, DbType.DateTime, ParameterDirection.Input),
				//new Parameters("@SupplierId", _inv_PurchaseBill.SupplierId, DbType.Int32, ParameterDirection.Input),
				//new Parameters("@PreparedById", _inv_PurchaseBill.PreparedById, DbType.Int32, ParameterDirection.Input),
				//new Parameters("@ShipmentInfo", _inv_PurchaseBill.ShipmentInfo, DbType.String, ParameterDirection.Input),
				//new Parameters("@PriceTypeId", _inv_PurchaseBill.PriceTypeId, DbType.Int32, ParameterDirection.Input),
				//new Parameters("@Remarks", _inv_PurchaseBill.Remarks, DbType.String, ParameterDirection.Input),
				//new Parameters("@CreatorId", _inv_PurchaseBill.CreatorId, DbType.Int32, ParameterDirection.Input),
				//new Parameters("@CreateDate", _inv_PurchaseBill.CreateDate, DbType.DateTime, ParameterDirection.Input),
				//new Parameters("@UpdatorId", _inv_PurchaseBill.UpdatorId, DbType.Int32, ParameterDirection.Input),
				//new Parameters("@UpdateDate", _inv_PurchaseBill.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				//new Parameters("@PreparedBy", _inv_PurchaseBill.PreparedBy, DbType.String, ParameterDirection.Input),
				//new Parameters("@PriceTypeName", _inv_PurchaseBill.PriceTypeName, DbType.String, ParameterDirection.Input),
				//new Parameters("@IsApproved", _inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
    //            new Parameters("@isRawMaterials", _inv_PurchaseBill.isRawMaterials, DbType.Boolean, ParameterDirection.Input),
    //              new Parameters("@isVDS", _inv_PurchaseBill.isVDS, DbType.Boolean, ParameterDirection.Input)
                 new Parameters("@POId", _inv_PurchaseBill.POId, DbType.Int64, ParameterDirection.Input),
                 new Parameters("@PBNo", _inv_PurchaseBill.PBNo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PONo", _inv_PurchaseBill.PONo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PBDate", _inv_PurchaseBill.PBDate, DbType.DateTime, ParameterDirection.Input),
                 new Parameters("@SupplierId", _inv_PurchaseBill.SupplierId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@PreparedById", _inv_PurchaseBill.PreparedById, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@ShipmentInfo", _inv_PurchaseBill.ShipmentInfo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PriceTypeId ", _inv_PurchaseBill.PriceTypeId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@Remarks", _inv_PurchaseBill.Remarks, DbType.String, ParameterDirection.Input),
                 new Parameters("@CreatorId", _inv_PurchaseBill.CreatorId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@CreateDate", _inv_PurchaseBill.CreateDate, DbType.DateTime, ParameterDirection.Input),
                 new Parameters("@AdditionDiscount", _inv_PurchaseBill.AdditionDiscount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@TotalAmount", _inv_PurchaseBill.TotalAmount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@TotalAmountAfterDiscount", _inv_PurchaseBill.TotalAmountAfterDiscount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@UpdatorId", _inv_PurchaseBill.UpdatorId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@UpdateDate", _inv_PurchaseBill.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                 new Parameters("@Address",_inv_PurchaseBill.Address , DbType.String , ParameterDirection.Input),
                 new Parameters("@SupplierName",_inv_PurchaseBill.SupplierName , DbType.String , ParameterDirection.Input),

                new Parameters("@PreparedBy", _inv_PurchaseBill.PreparedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@PriceTypeName", _inv_PurchaseBill.PriceTypeName, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedDate", _inv_PurchaseBill.ApprovedDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@VoucherNo", _inv_PurchaseBill.VoucherNo, DbType.String, ParameterDirection.Input),

                new Parameters("@isRawMaterials", _inv_PurchaseBill.isRawMaterials, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@isVDS", _inv_PurchaseBill.isVDS, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ChallanNo", _inv_PurchaseBill.ChallanNo, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBill_Create", colparameters, true);
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

        public Int64 LocalPBAdd(inv_LocalPurchaseBill local_inv_PurchaseBill)
        {


            Int64 ret = 0;
            try
            {
                //Common aCommon = new Common();

                ////PB/17-18/1, PB/17-18/2, PB/17-18/3, PB/17-18/100, PB/17-18/1001

                //string aFiscalYearPart = aCommon.GetFiscalFormDateAndToDateString(local_inv_PurchaseBill.PBDate);
                //local_inv_PurchaseBill.PBNo = "PBL/" + aFiscalYearPart + "/" + local_inv_PurchaseBill.PBNo;

                Parameters[] colparameters = new Parameters[27]{


                 new Parameters("@POId", local_inv_PurchaseBill.POId, DbType.Int64, ParameterDirection.Input),
                 new Parameters("@PONo", local_inv_PurchaseBill.PONo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PBNo", local_inv_PurchaseBill.PBNo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PBDate", local_inv_PurchaseBill.PBDate, DbType.DateTime, ParameterDirection.Input),
                 new Parameters("@SupplierId", local_inv_PurchaseBill.SupplierId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@PreparedById", local_inv_PurchaseBill.PreparedById, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@ShipmentInfo", local_inv_PurchaseBill.ShipmentInfo, DbType.String, ParameterDirection.Input),
                 new Parameters("@PriceTypeId ", local_inv_PurchaseBill.PriceTypeId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@Remarks", local_inv_PurchaseBill.Remarks, DbType.String, ParameterDirection.Input),
                 new Parameters("@CreatorId", local_inv_PurchaseBill.CreatorId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@CreateDate", local_inv_PurchaseBill.CreateDate, DbType.DateTime, ParameterDirection.Input),
                   new Parameters("@AdditionDiscount", local_inv_PurchaseBill.AdditionDiscount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@UpdatorId", local_inv_PurchaseBill.UpdatorId, DbType.Int32, ParameterDirection.Input),
                 new Parameters("@UpdateDate", local_inv_PurchaseBill.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                 new Parameters("@Address",local_inv_PurchaseBill.Address , DbType.String , ParameterDirection.Input),
                 new Parameters("@SupplierName",local_inv_PurchaseBill.SupplierName , DbType.String , ParameterDirection.Input),
                  new Parameters("@TotalAmount", local_inv_PurchaseBill.TotalAmount, DbType.Decimal, ParameterDirection.Input),
                 new Parameters("@TotalAmountAfterDiscount", local_inv_PurchaseBill.TotalAmountAfterDiscount, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@PreparedBy", local_inv_PurchaseBill.PreparedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@PriceTypeName", local_inv_PurchaseBill.PriceTypeName, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", local_inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedBy", local_inv_PurchaseBill.ApprovedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ApprovedDate", local_inv_PurchaseBill.ApprovedDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@VoucherNo", local_inv_PurchaseBill.VoucherNo, DbType.String, ParameterDirection.Input),

                new Parameters("@isRawMaterials", local_inv_PurchaseBill.isRawMaterials, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@isVDS", local_inv_PurchaseBill.isVDS, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ChallanNo", local_inv_PurchaseBill.ChallanNo, DbType.String, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar64(true, CommandType.StoredProcedure, "inv_PurchaseBillLocal_Create", colparameters, true);
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

        public int Update(inv_PurchaseBill _inv_PurchaseBill)
        {
            int ret = 0;
            try
            {


                Parameters[] colparameters = new Parameters[25]{
                new Parameters("@PBId", _inv_PurchaseBill.POId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@POId", _inv_PurchaseBill.POId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@PONo", _inv_PurchaseBill.PONo, DbType.String, ParameterDirection.Input),
                new Parameters("@PBNo", _inv_PurchaseBill.PBNo, DbType.String, ParameterDirection.Input),
                new Parameters("@PBDate", _inv_PurchaseBill.PBDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@SupplierId", _inv_PurchaseBill.SupplierId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PreparedById", _inv_PurchaseBill.PreparedById, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PriceTypeId", _inv_PurchaseBill.PriceTypeId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ShipmentInfo", _inv_PurchaseBill.ShipmentInfo, DbType.String, ParameterDirection.Input),
                new Parameters("@Remarks", _inv_PurchaseBill.Remarks, DbType.String, ParameterDirection.Input),
                new Parameters("@SupplierName",_inv_PurchaseBill.SupplierName , DbType.String , ParameterDirection.Input),
                new Parameters("@UpdatorId", _inv_PurchaseBill.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", _inv_PurchaseBill.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@PreparedBy", _inv_PurchaseBill.PreparedBy, DbType.String, ParameterDirection.Input),
                new Parameters("@PriceTypeName", _inv_PurchaseBill.PriceTypeName, DbType.String, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedBy", _inv_PurchaseBill.ApprovedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ApprovedDate", _inv_PurchaseBill.ApprovedDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@VoucherNo", _inv_PurchaseBill.ApprovedDate, DbType.String, ParameterDirection.Input),
                new Parameters("@NID", _inv_PurchaseBill.NID, DbType.String, ParameterDirection.Input),
                new Parameters("@Port",_inv_PurchaseBill.Port, DbType.String , ParameterDirection.Input),
                new Parameters("@Address",_inv_PurchaseBill.Address , DbType.String , ParameterDirection.Input),
                new Parameters("@isRawMaterials", _inv_PurchaseBill.isRawMaterials, DbType.Boolean, ParameterDirection.Input),
                 new Parameters("@isVDS", _inv_PurchaseBill.isVDS, DbType.Boolean, ParameterDirection.Input),
                 new Parameters("@ChallanNo", _inv_PurchaseBill.ChallanNo, DbType.String, ParameterDirection.Input),
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBill_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateApprove(inv_PurchaseBill _inv_PurchaseBill)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                new Parameters("@PBId", _inv_PurchaseBill.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedBy", _inv_PurchaseBill.ApprovedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ApprovedDate", _inv_PurchaseBill.ApprovedDate, DbType.DateTime, ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_PurchaseBill_UpdateApprove", colparameters, true);
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
        public int Delete(Int64 PBId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBId", PBId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBill_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetRawMaterialAndCombination()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetRawMaterialAndCombination", true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DbDataReader GetMaxPurchaseBillNo()
        {
            try
            {

                DbDataReader PONo = dbExecutor.ExecuteReader(CommandType.StoredProcedure, "inv_GetMaxPurchaseBillNo");
                return PONo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbDataReader GetMaxLocalPurchaseBillNo()
        {
            try
            {

                DbDataReader PONo = dbExecutor.ExecuteReader(CommandType.StoredProcedure, "inv_GetMaxLocalPurchaseBillNo");
                return PONo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Acknowledge(inv_PurchaseBill _inv_PurchaseBill)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@PBId", _inv_PurchaseBill.PBId, DbType.Int64, ParameterDirection.Input),
                new Parameters("@IsApproved", _inv_PurchaseBill.IsApproved, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@ApprovedBy", _inv_PurchaseBill.ApprovedBy, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ApprovedDate", _inv_PurchaseBill.ApprovedDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@VoucherNo", _inv_PurchaseBill.VoucherNo, DbType.String, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_PurchaseBill_Acknowledge", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill> GetForRealization(int financialCycleId, int supplierId)
        {
            try
            {
                List<inv_PurchaseBill> pos_SalesOrderLst = new List<inv_PurchaseBill>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@FinancialCycleId", financialCycleId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SupplierId", supplierId, DbType.Int32, ParameterDirection.Input)
                };
                pos_SalesOrderLst = dbExecutor.FetchData<inv_PurchaseBill>(CommandType.StoredProcedure, "pay_GetPurchaseBillForRealization", colparameters);
                return pos_SalesOrderLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill_Mushak> Get_Mushak6_1(int PBId)
        {
            try
            {
                List<inv_PurchaseBill_Mushak> inv_PurchaseBill_MushakList = new List<inv_PurchaseBill_Mushak>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBId", PBId, DbType.Int32, ParameterDirection.Input),

                };
                inv_PurchaseBill_MushakList = dbExecutor.FetchData<inv_PurchaseBill_Mushak>(CommandType.StoredProcedure, "inv_PurchaseBill_Mushak_6_1", colparameters);
                return inv_PurchaseBill_MushakList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_PurchaseBill_Mushak> Get_Mushak6_2(int PBId)
        {
            try
            {
                List<inv_PurchaseBill_Mushak> inv_PurchaseBill_MushakList = new List<inv_PurchaseBill_Mushak>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@PBId", PBId, DbType.Int32, ParameterDirection.Input),

                };
                inv_PurchaseBill_MushakList = dbExecutor.FetchData<inv_PurchaseBill_Mushak>(CommandType.StoredProcedure, "inv_PurchaseBill_Mushak_6_2", colparameters);
                return inv_PurchaseBill_MushakList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<inv_LocalPurchaseBillDetail> GetLocalPB(Int64 LPBId)
        {
            try
            {
                List<inv_LocalPurchaseBillDetail> localPbList = new List<inv_LocalPurchaseBillDetail>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@LPBId", LPBId, DbType.Int64, ParameterDirection.Input),

                };
                localPbList = dbExecutor.FetchData<inv_LocalPurchaseBillDetail>(CommandType.StoredProcedure, "xRpt_inv_LocalPurchaseBillByPBId", colparameters);
                return localPbList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
