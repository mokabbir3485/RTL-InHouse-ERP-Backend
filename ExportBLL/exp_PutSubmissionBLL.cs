using ExportDAL;
using System;

namespace ExportBLL
{
    public class exp_PutSubmissionBLL //: IDisposible
    {
        public exp_PutSubmissionDAO exp_PutSubmissionDao { get; set; }

        public exp_PutSubmissionBLL()
        {
            //exp_ApprovalDAO = exp_Approval.GetInstanceThreadSafe;
            exp_PutSubmissionDao = new exp_PutSubmissionDAO();
        }

        public int Put(string docType, Int64 documentId, bool isSubmit)
        {
            try
            {
                return exp_PutSubmissionDao.Put(docType, documentId, isSubmit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
