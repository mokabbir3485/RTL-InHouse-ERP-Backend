using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using InventoryEntity;
using DbExecutor;

namespace InventoryDAL
{
	public class inv_OpeningQuantityDAO //: IDisposible
	{
		private static volatile inv_OpeningQuantityDAO instance;
		private static readonly object lockObj = new object();
		public static inv_OpeningQuantityDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new inv_OpeningQuantityDAO();
			}
			return instance;
		}
		public static inv_OpeningQuantityDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new inv_OpeningQuantityDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public inv_OpeningQuantityDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<inv_OpeningQuantity> GetAll(Int64? OpeningQtyId = null)
		{
			try
			{
				List<inv_OpeningQuantity> inv_OpeningQuantityLst = new List<inv_OpeningQuantity>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OpeningQtyId", OpeningQtyId, DbType.Int32, ParameterDirection.Input)
				};
				inv_OpeningQuantityLst = dbExecutor.FetchData<inv_OpeningQuantity>(CommandType.StoredProcedure, "inv_OpeningQuantity_Get", colparameters);
				return inv_OpeningQuantityLst;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<inv_OpeningQuantity> Search(Int32 DepartmentId, Int32? CategoryId = null, Int32? SubcategoryId = null, Int32? ItemId = null)
        {
            try
            {
                List<inv_OpeningQuantity> inv_OpeningQuantityLst = new List<inv_OpeningQuantity>();
                Parameters[] colparameters = new Parameters[4]{
				new Parameters("@DepartmentId", DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CategoryId", CategoryId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@SubcategoryId", SubcategoryId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", ItemId, DbType.Int32, ParameterDirection.Input)
				};
                inv_OpeningQuantityLst = dbExecutor.FetchData<inv_OpeningQuantity>(CommandType.StoredProcedure, "inv_OpeningQuantity_Search", colparameters);
                return inv_OpeningQuantityLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Add(inv_OpeningQuantity _inv_OpeningQuantity)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[18]{
				new Parameters("@DepartmentId", _inv_OpeningQuantity.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_OpeningQuantity.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningUnitId", _inv_OpeningQuantity.OpeningUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningUnitQuantity", _inv_OpeningQuantity.OpeningUnitQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningPackageId", _inv_OpeningQuantity.OpeningPackageId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningPackageQuantity", _inv_OpeningQuantity.OpeningPackageQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningContainerId", _inv_OpeningQuantity.OpeningContainerId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningContainerQuantity", _inv_OpeningQuantity.OpeningContainerQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningValue", _inv_OpeningQuantity.OpeningValue, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@CreatorId", _inv_OpeningQuantity.CreatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@CreateDate", _inv_OpeningQuantity.CreateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_OpeningQuantity.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_OpeningQuantity.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentName", _inv_OpeningQuantity.DepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_OpeningQuantity.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningUnitName", _inv_OpeningQuantity.OpeningUnitName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningPackageName", _inv_OpeningQuantity.OpeningPackageName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningContainerName", _inv_OpeningQuantity.OpeningContainerName, DbType.String, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "inv_OpeningQuantity_Create", colparameters, true);
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
		public int Update(inv_OpeningQuantity _inv_OpeningQuantity)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[17]{
				new Parameters("@OpeningQtyId", _inv_OpeningQuantity.OpeningQtyId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@DepartmentId", _inv_OpeningQuantity.DepartmentId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@ItemId", _inv_OpeningQuantity.ItemId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningUnitId", _inv_OpeningQuantity.OpeningUnitId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningUnitQuantity", _inv_OpeningQuantity.OpeningUnitQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningPackageId", _inv_OpeningQuantity.OpeningPackageId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningPackageQuantity", _inv_OpeningQuantity.OpeningPackageQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningContainerId", _inv_OpeningQuantity.OpeningContainerId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@OpeningContainerQuantity", _inv_OpeningQuantity.OpeningContainerQuantity, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@OpeningValue", _inv_OpeningQuantity.OpeningValue, DbType.Decimal, ParameterDirection.Input),
				new Parameters("@UpdatorId", _inv_OpeningQuantity.UpdatorId, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdateDate", _inv_OpeningQuantity.UpdateDate, DbType.DateTime, ParameterDirection.Input),
				new Parameters("@DepartmentName", _inv_OpeningQuantity.DepartmentName, DbType.String, ParameterDirection.Input),
				new Parameters("@ItemName", _inv_OpeningQuantity.ItemName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningUnitName", _inv_OpeningQuantity.OpeningUnitName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningPackageName", _inv_OpeningQuantity.OpeningPackageName, DbType.String, ParameterDirection.Input),
				new Parameters("@OpeningContainerName", _inv_OpeningQuantity.OpeningContainerName, DbType.String, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_OpeningQuantity_Update", colparameters, true);
			return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Delete(Int64 OpeningQtyId)
		{
			try
			{
				int ret = 0;
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@OpeningQtyId", OpeningQtyId, DbType.Int32, ParameterDirection.Input)
				};
				ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "inv_OpeningQuantity_DeleteById", colparameters, true);
				return ret;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
