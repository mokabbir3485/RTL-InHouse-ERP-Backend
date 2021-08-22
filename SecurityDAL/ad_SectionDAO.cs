using DbExecutor;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace SecurityDAL
{
    public class ad_SectionDAO //: IDisposible
    {
        private static volatile ad_SectionDAO instance;
        private static readonly object lockObj = new object();
        public static ad_SectionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new ad_SectionDAO();
            }
            return instance;
        }
        public static ad_SectionDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ad_SectionDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public ad_SectionDAO()
        {
            //dbExecutor = DBExecutor.GetInstanceThreadSafe;
            dbExecutor = new DBExecutor();
        }
        public List<ad_Section> GetAll(Int32? sectionId = null)
        {
            try
            {
                List<ad_Section> ad_SectionLst = new List<ad_Section>();
                Parameters[] colparameters = new Parameters[1]{
                new Parameters("@SectionId", sectionId, DbType.Int32, ParameterDirection.Input)
                };
                ad_SectionLst = dbExecutor.FetchData<ad_Section>(CommandType.StoredProcedure, "ad_section_Get", colparameters);
                return ad_SectionLst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
