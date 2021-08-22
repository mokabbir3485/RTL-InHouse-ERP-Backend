using SecurityDAL;
using SecurityEntity;
using System;
using System.Collections.Generic;

namespace SecurityBLL
{
    public class ad_SectionBLL //: IDisposible
    {
        public ad_SectionDAO ad_SectionDAO { get; set; }

        public ad_SectionBLL()
        {
            //ad_DepartmentDAO = ad_Department.GetInstanceThreadSafe;
            ad_SectionDAO = new ad_SectionDAO();
        }

        public List<ad_Section> GetAll()
        {
            try
            {
                return ad_SectionDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
