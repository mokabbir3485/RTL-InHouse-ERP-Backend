using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SecurityEntity;
using SecurityDAL;

namespace SecurityBLL
{
    public class ad_NoticeDetailBLL //: IDisposible
    {
        public ad_NoticeDetailDAO ad_NoticeDetailDAO { get; set; }

        public ad_NoticeDetailBLL()
        {
            //ad_NoticeDetailDAO = ad_NoticeDetail.GetInstanceThreadSafe;
            ad_NoticeDetailDAO = new ad_NoticeDetailDAO();
        }

        public List<ad_NoticeDetail> GetAll()
        {
            try
            {
                return ad_NoticeDetailDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_NoticeDetail> GetDynamic(string whereCondition, string orderByExpression)
        {
            try
            {
                return ad_NoticeDetailDAO.GetDynamic(whereCondition, orderByExpression);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ad_NoticeDetail> GetPaged(int startRecordNo, int rowPerPage, string whereClause, string sortColumn, string sortOrder, ref int rows)
        {
            try
            {
                return ad_NoticeDetailDAO.GetPaged(startRecordNo, rowPerPage, whereClause, sortColumn, sortOrder, ref rows);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Add(ad_NoticeDetail _ad_NoticeDetail)
        {
            try
            {
                return ad_NoticeDetailDAO.Add(_ad_NoticeDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateIsRead(Int64 noticeId, int userId)
        {
            try
            {
                return ad_NoticeDetailDAO.UpdateIsRead(noticeId, userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(Int64 noticeDetailId)
        {
            try
            {
                return ad_NoticeDetailDAO.Delete(noticeDetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
