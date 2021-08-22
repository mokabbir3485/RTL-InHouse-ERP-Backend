using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using DbExecutor;
using ExportEntity;

namespace ExportDAL
{
	public class exp_TruckChallanDAO //: IDisposible
	{
		private static volatile exp_TruckChallanDAO instance;
		private static readonly object lockObj = new object();
		public static exp_TruckChallanDAO GetInstance()
		{
			if (instance == null)
			{
				instance = new exp_TruckChallanDAO();
			}
			return instance;
		}
		public static exp_TruckChallanDAO GetInstanceThreadSafe
		{
			get
			{
				if (instance == null)
				{
					lock (lockObj)
					{
						if (instance == null)
						{
							instance = new exp_TruckChallanDAO();
						}
					}
				}
				return instance;
			}
		}

		DBExecutor dbExecutor;
		public exp_TruckChallanDAO()
		{
			//dbExecutor = DBExecutor.GetInstanceThreadSafe;
			dbExecutor = new DBExecutor();
		}
		public List<exp_TruckChallan> Get(Int64? CommercialInvoiceId)
		{
			try
			{
				List<exp_TruckChallan> exp_TruckChallanList = new List<exp_TruckChallan>();
				Parameters[] colparameters = new Parameters[1]{
				new Parameters("@CommercialInvoiceId", CommercialInvoiceId, DbType.Int64, ParameterDirection.Input)
				};
				exp_TruckChallanList = dbExecutor.FetchData<exp_TruckChallan>(CommandType.StoredProcedure, "exp_TruckChallan_Get", colparameters);
				return exp_TruckChallanList;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Post(exp_TruckChallan _exp_TruckChallan)
		{
			int ret = 0;
			try
			{
				Parameters[] colparameters = new Parameters[7]{
				new Parameters("@TruckChallanId", _exp_TruckChallan.TruckChallanId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@CommercialInvoiceId", _exp_TruckChallan.CommercialInvoiceId, DbType.Int64, ParameterDirection.Input),
				new Parameters("@TruckNo", _exp_TruckChallan.TruckNo, DbType.String, ParameterDirection.Input),
				new Parameters("@Footers", _exp_TruckChallan.Footers, DbType.String, ParameterDirection.Input),
				new Parameters("@Sort", _exp_TruckChallan.Sort, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedBy", _exp_TruckChallan.UpdatedBy, DbType.Int32, ParameterDirection.Input),
				new Parameters("@UpdatedDate", _exp_TruckChallan.UpdatedDate, DbType.DateTime, ParameterDirection.Input)
				};
				dbExecutor.ManageTransaction(TransactionType.Open);
				ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "exp_TruckChallan_Post", colparameters, true);
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
        public int DeleteTruckChallanByCommercialInvoiceId(Int64 commercialInvoiceId)
        {
            try
            {
                int ret = 0;
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@CommercialInvoiceId", commercialInvoiceId, DbType.Int32, ParameterDirection.Input)
                };
                ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_TruckChallan_Delete", colparameters, true);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int Update(exp_TruckChallan _exp_TruckChallan)
        //{
        //	int ret = 0;
        //	try
        //	{
        //		Parameters[] colparameters = new Parameters[10]{
        //		new Parameters("@ExporterId", _exp_TruckChallan.ExporterId, DbType.Int32, ParameterDirection.Input),
        //		new Parameters("@ExporterName", _exp_TruckChallan.ExporterName, DbType.String, ParameterDirection.Input),
        //		new Parameters("@ExporterAddress", _exp_TruckChallan.ExporterAddress, DbType.String, ParameterDirection.Input),
        //		new Parameters("@TIN", _exp_TruckChallan.TIN, DbType.String, ParameterDirection.Input),
        //		new Parameters("@VatRegNo", _exp_TruckChallan.VatRegNo, DbType.String, ParameterDirection.Input),
        //		new Parameters("@BIN", _exp_TruckChallan.BIN, DbType.String, ParameterDirection.Input),
        //		new Parameters("@TelephoneNo", _exp_TruckChallan.TelephoneNo, DbType.String, ParameterDirection.Input),
        //		new Parameters("@MobileNo", _exp_TruckChallan.MobileNo, DbType.String, ParameterDirection.Input),
        //		new Parameters("@Email", _exp_TruckChallan.Email, DbType.String, ParameterDirection.Input),
        //		new Parameters("@Website", _exp_TruckChallan.Website, DbType.String, ParameterDirection.Input)
        //		};
        //		ret = dbExecutor.ExecuteNonQuery(CommandType.StoredProcedure, "exp_Exporter_Update", colparameters, true);
        //	return ret;
        //	}
        //	catch (Exception ex)
        //	{
        //		throw ex;
        //	}
        //}
    }
}
