using DbExecutor;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SecurityDAL
{
    public class ad_ItemDAO //: IDisposible
    {
        private static volatile ad_ItemDAO instance;
        private static readonly object lockObj = new object();
        public static ad_ItemDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ad_ItemDAO();
            }
            return instance;
        }
        public static ad_ItemDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ad_ItemDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public ad_ItemDAO()
        {
            dbExecutor = DBExecutor.GetInstanceThreadSafe;
            //dbExecutor = new DBExecutor();
        }

        public List<exp_RibbonInPerLabelCarton> GetAllSPCase()
        {
            try
            {
                List<exp_RibbonInPerLabelCarton> exp_RibbonInPerLabelCartonLst = new List<exp_RibbonInPerLabelCarton>();

                exp_RibbonInPerLabelCartonLst = dbExecutor.FetchData<exp_RibbonInPerLabelCarton>(CommandType.StoredProcedure, "exp_RibbonInPerLabelCarton_Get");
                return exp_RibbonInPerLabelCartonLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ad_Item> GetAll(Int32? itemId = null)
        {
            try
            {
                List<ad_Item> ad_ItemLst = new List<ad_Item>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input)
                };
                ad_ItemLst = dbExecutor.FetchData<ad_Item>(CommandType.StoredProcedure, "ad_Item_GetAll", colparameters);
                return ad_ItemLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_ItemVat> GetItemVatById(Int64 ItemId)
        {
            try
            {
                List<ad_ItemVat> ad_ItemVatList = new List<ad_ItemVat>();
                Parameters[] colparameters = new Parameters[1]{
                    new Parameters("@ItemId", ItemId, DbType.Int64, ParameterDirection.Input)
                };
                ad_ItemVatList = dbExecutor.FetchData<ad_ItemVat>(CommandType.StoredProcedure, "ad_ItemVat_GetById", colparameters);
                return ad_ItemVatList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetLimitedProperty(Int32? subcategoryId = null)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SubcategoryId", subcategoryId, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetLimitedProperty", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetLimitedPropertyWithAttribute(Int32 departmentId)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@DepartmentId", departmentId, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetLimitedPropertyWithAttribute", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetRaw()
        {
            try
            {
                List<ad_Item> ad_ItemLst = new List<ad_Item>();
                ad_ItemLst = dbExecutor.FetchData<ad_Item>(CommandType.StoredProcedure, "ad_Item_GetRaw");
                return ad_ItemLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetRawWithoutSelectedItem(Int32 ItemId)
        {
            try
            {
                List<ad_Item> ad_ItemLst = new List<ad_Item>();
                ad_ItemLst = dbExecutor.FetchData<ad_Item>(CommandType.StoredProcedure, "ad_Item_GetRaw");
                ad_ItemLst = ad_ItemLst.Where(i => i.ItemId != ItemId).ToList();
                return ad_ItemLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                List<ad_Item> ad_ItemLst = new List<ad_Item>();
                Parameters[] colparameters = new Parameters[2]{
                new Parameters("@WhereCondition", whereCondition, DbType.String, ParameterDirection.Input),
                new Parameters("@OrderByExpression", orderByExpression, DbType.String, ParameterDirection.Input),
                };
                ad_ItemLst = dbExecutor.FetchData<ad_Item>(CommandType.StoredProcedure, "ad_Item_GetDynamic", colparameters);
                return ad_ItemLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_Item> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                List<ad_Item> ad_ItemLst = new List<ad_Item>();
                Parameters[] colparameters = new Parameters[5]{
                new Parameters("@StartRecordNo", startRecordNo, DbType.Int32, ParameterDirection.Input),
                new Parameters("@RowPerPage", rowPerPage, DbType.Int32, ParameterDirection.Input),
                new Parameters("@WhereClause", whereClause, DbType.String, ParameterDirection.Input),
                new Parameters("@SortColumn", sortColumn, DbType.String, ParameterDirection.Input),
                new Parameters("@SortOrder", sortOrder, DbType.String, ParameterDirection.Input),
                };
                ad_ItemLst = dbExecutor.FetchDataRef<ad_Item>(CommandType.StoredProcedure, "ad_Item_GetPaged2", colparameters, ref rows);
                return ad_ItemLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int Add(ad_Item ad_Item)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[20]{
                new Parameters("@SubCategoryId", ad_Item.SubCategoryId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ItemCode", ad_Item.ItemCode, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemName", ad_Item.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemDescription", ad_Item.ItemDescription, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemDescriptionTwo", ad_Item.ItemDescriptionTwo, DbType.String, ParameterDirection.Input),
				//new Parameters("@IsItemCodeBarcode", ad_Item.IsItemCodeBarcode, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UnitId", ad_Item.UnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PackageId", ad_Item.PackageId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UnitPerPackage", ad_Item.UnitPerPackage, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ContainerId", ad_Item.ContainerId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PackagePerContainer", ad_Item.PackagePerContainer, DbType.Decimal, ParameterDirection.Input),
                //new Parameters("@PurchaseMeasurement", ad_Item.PurchaseMeasurement, DbType.String, ParameterDirection.Input),
                //new Parameters("@SaleMeasurement", ad_Item.SaleMeasurement, DbType.String, ParameterDirection.Input),
                //new Parameters("@PurchasePriceConfigId", ad_Item.PurchasePriceConfigId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@SalePriceConfigId", ad_Item.SalePriceConfigId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@AccountCode", ad_Item.AccountCode, DbType.String, ParameterDirection.Input),
				//new Parameters("@MovementMethodId", ad_Item.MovementMethodId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@IsActive", ad_Item.IsActive, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@CreatorId", ad_Item.CreatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@CreateDate", ad_Item.CreateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@UpdatorId", ad_Item.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", ad_Item.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@ROLevel",ad_Item.ROLevel,DbType.Int32,ParameterDirection.Input),
                new Parameters("@PackageWeight",ad_Item.PackageWeight,DbType.Decimal,ParameterDirection.Input),
                new Parameters("@ContainerWeight",ad_Item.ContainerWeight,DbType.Decimal,ParameterDirection.Input),
                new Parameters("@ContainerSize",ad_Item.ContainerSize,DbType.String,ParameterDirection.Input),
                new Parameters("@HsCodeId",ad_Item.HsCodeId,DbType.Int32,ParameterDirection.Input)
                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_Item_Create", colparameters, true);
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
        public int ad_ItemVat_Add(ad_ItemVat ad_ItemVat)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                    new Parameters("@ItemVatId", ad_ItemVat.ItemVatId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@ItemId", ad_ItemVat.ItemId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@Sd", ad_ItemVat.Sd, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@Vat", ad_ItemVat.Vat, DbType.Decimal, ParameterDirection.Input),

                };
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_ItemVat_Create", colparameters, true);
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

        public int ad_ItemVat_Update(ad_ItemVat ad_ItemVat)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[4]{
                    new Parameters("@ItemVatId", ad_ItemVat.ItemVatId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@ItemId", ad_ItemVat.ItemId, DbType.Int64, ParameterDirection.Input),
                    new Parameters("@Sd", ad_ItemVat.Sd, DbType.Decimal, ParameterDirection.Input),
                    new Parameters("@Vat", ad_ItemVat.Vat, DbType.Decimal, ParameterDirection.Input),
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_ItemVat_Create", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(ad_Item ad_Item)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[19]{
                new Parameters("@ItemId", ad_Item.ItemId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@SubCategoryId", ad_Item.SubCategoryId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@ItemCode", ad_Item.ItemCode, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemName", ad_Item.ItemName, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemDescription", ad_Item.ItemDescription, DbType.String, ParameterDirection.Input),
                new Parameters("@ItemDescriptionTwo", ad_Item.ItemDescriptionTwo, DbType.String, ParameterDirection.Input),
				//new Parameters("@IsItemCodeBarcode", ad_Item.IsItemCodeBarcode, DbType.Boolean, ParameterDirection.Input),
				new Parameters("@UnitId", ad_Item.UnitId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PackageId", ad_Item.PackageId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UnitPerPackage", ad_Item.UnitPerPackage, DbType.Decimal, ParameterDirection.Input),
                new Parameters("@ContainerId", ad_Item.ContainerId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@PackagePerContainer", ad_Item.PackagePerContainer, DbType.Decimal, ParameterDirection.Input),
                //new Parameters("@PurchaseMeasurement", ad_Item.PurchaseMeasurement, DbType.String, ParameterDirection.Input),
                //new Parameters("@SaleMeasurement", ad_Item.SaleMeasurement, DbType.String, ParameterDirection.Input),
                //new Parameters("@PurchasePriceConfigId", ad_Item.PurchasePriceConfigId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@SalePriceConfigId", ad_Item.SalePriceConfigId, DbType.Int32, ParameterDirection.Input),
                //new Parameters("@AccountCode", ad_Item.AccountCode, DbType.String, ParameterDirection.Input),
                //new Parameters("@MovementMethodId", ad_Item.MovementMethodId, DbType.Int32, ParameterDirection.Input)
				new Parameters("@IsActive", ad_Item.IsActive, DbType.Boolean, ParameterDirection.Input),
                new Parameters("@UpdatorId", ad_Item.UpdatorId, DbType.Int32, ParameterDirection.Input),
                new Parameters("@UpdateDate", ad_Item.UpdateDate, DbType.DateTime, ParameterDirection.Input),
                new Parameters("@ROLevel",ad_Item.ROLevel,DbType.Int32,ParameterDirection.Input),
                new Parameters("@PackageWeight",ad_Item.PackageWeight,DbType.Decimal,ParameterDirection.Input),
                new Parameters("@ContainerWeight",ad_Item.ContainerWeight,DbType.Decimal,ParameterDirection.Input),
                new Parameters("@ContainerSize",ad_Item.ContainerSize,DbType.String,ParameterDirection.Input),
                new Parameters("@HsCodeId",ad_Item.HsCodeId,DbType.Int32,ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Item_Update", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int32 itemId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@ItemId", itemId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "ad_Item_DeleteById", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetNBarcode(int qty)
        {
            try
            {
                DataTable dt = new DataTable();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@Qty", qty, DbType.Int32, ParameterDirection.Input)
                };
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetNBarcode", colparameters, true);
                return dt;
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
                dt = dbExecutor.GetDataTable(CommandType.StoredProcedure, "ad_Item_GetCombinationByRequisitionId", colparameters, true);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
