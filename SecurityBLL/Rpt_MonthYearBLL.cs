using SecurityDAL;
using SecurityEntity;
using System;
using System.Collections.Generic;

namespace SecurityBLL
{
    public class Rpt_MonthYearBLL //: IDisposible
    {
        public Rpt_MonthYearDAO Rpt_MonthYearDAO { get; set; }

        public Rpt_MonthYearBLL()
        {
            //ad_NoticeDAO = ad_Notice.GetInstanceThreadSafe;
            Rpt_MonthYearDAO = new Rpt_MonthYearDAO();
        }

        public List<Rpt_MonthYear> Get()
        {
            try
            {
                return Rpt_MonthYearDAO.Get();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
