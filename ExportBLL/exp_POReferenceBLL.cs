using System;
using ExportDAL;
using ExportEntity;
using System.Collections.Generic;

namespace ExportBLL
{
    public class exp_POReferenceBLL
    {
        public exp_POReferenceDAO exp_POReferenceDAO { get; set; }

        public exp_POReferenceBLL()
        {
            exp_POReferenceDAO = new exp_POReferenceDAO();
        }

        public List<exp_POReference> GetPOReference(string DocType, Int64 DocumentId)
        {
            try
            {
                return exp_POReferenceDAO.GetPOReference(DocType, DocumentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 Add(exp_POReference _exp_POReference)
        {
            try
            {
                return exp_POReferenceDAO.Add(_exp_POReference);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
