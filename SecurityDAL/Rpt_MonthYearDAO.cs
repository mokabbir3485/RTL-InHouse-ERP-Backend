using DbExecutor;
using SecurityEntity;
using System;
using System.Collections.Generic;
using System.Data;

namespace SecurityDAL
{
    public class Rpt_MonthYearDAO //: IDisposible
    {
        private static volatile Rpt_MonthYearDAO instance;
        private static readonly object lockObj = new object();
        public static Rpt_MonthYearDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new Rpt_MonthYearDAO();
            }
            return instance;
        }
        public static Rpt_MonthYearDAO GetInstanceThreadSafe
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Rpt_MonthYearDAO();
                        }
                    }
                }
                return instance;
            }
        }

        DBExecutor dbExecutor;
        public Rpt_MonthYearDAO()
        {
            dbExecutor = DBExecutor.GetInstanceThreadSafe;
            //dbExecutor = new DBExecutor();
        }
        public List<Rpt_MonthYear> Get()
        {
            try
            {
                List<Rpt_MonthYear> monthYearList = new List<Rpt_MonthYear>();
                monthYearList = dbExecutor.FetchData<Rpt_MonthYear>(CommandType.StoredProcedure, "GetRpt_MonthYear");
                return monthYearList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
