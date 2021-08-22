using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using DbExecutor;
using DbExecutor;

namespace SecurityDAL
{
	public class ad_BranchGroupDAO
	{
        DBExecutor dbExecutor;
        public ad_BranchGroupDAO()
		{
            dbExecutor = DBExecutor.GetInstanceThreadSafe; // single tone instance
		}

        public List<ad_BranchGroup> GetAll(Int32? groupId = null)
        {
            try
            {
                List<ad_BranchGroup> lst = new List<ad_BranchGroup>();
                Parameters[] colparameters = new Parameters[1]{
                new  Parameters("@GroupId", groupId,  DbType.Int32 ,  ParameterDirection.Input)
                };
                lst = dbExecutor.FetchData<ad_BranchGroup>(CommandType.StoredProcedure, "ad_BranchGroup_Get", colparameters);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Add(ad_BranchGroup _ad_BranchGroup)
        {
            int ret = 0;
            try
            {
                Parameters[] colparameters = new Parameters[1]{
				new Parameters("@GroupName", _ad_BranchGroup.GroupName, DbType.String, ParameterDirection.Input)
				};
                dbExecutor.ManageTransaction(TransactionType.Open);
                ret = dbExecutor.ExecuteScalar32(true, CommandType.StoredProcedure, "ad_BranchGroup_Create", colparameters, true);
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
    }
}
