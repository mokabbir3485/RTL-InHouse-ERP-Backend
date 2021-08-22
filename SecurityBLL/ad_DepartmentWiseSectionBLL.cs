using SecurityDAL;
using SecurityEntity;
using System;
using System.Collections.Generic;

namespace SecurityBLL
{
    public class ad_DepartmentWiseSectionBLL //: IDisposible
    {
        public ad_DepartmentWiseSectionDAO ad_DepartmentWiseSectionDAO { get; set; }

        public ad_DepartmentWiseSectionBLL()
        {
            //ad_DepartmentDAO = ad_Department.GetInstanceThreadSafe;
            ad_DepartmentWiseSectionDAO = new ad_DepartmentWiseSectionDAO();
        }

        public int Add(ad_DepartmentWiseSection ad_DepartmentWiseSection)
        {
            try
            {
                return ad_DepartmentWiseSectionDAO.Add(ad_DepartmentWiseSection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_DepartmentWiseSection> GetSectionByDepartmentId(int departmentId)
        {
            try
            {
                return ad_DepartmentWiseSectionDAO.GetSectionByDepartmentId(departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_DepartmentWiseSection> GetSectionByDepartmentIds(string departmentIds)
        {
            try
            {
                return ad_DepartmentWiseSectionDAO.GetSectionByDepartmentIds(departmentIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
