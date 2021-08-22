using ExportDAL;
using ExportEntity;
using System;
using System.Collections.Generic;
namespace ExportBLL
{
    public class exp_ExportReportsBLL //: IDisposible
    {
        public exp_ExpReportsDAO ExpExpReportsDAO { get; set; }

        public exp_ExportReportsBLL()
        {
            //exp_ApprovalDAO = exp_Approval.GetInstanceThreadSafe;
            ExpExpReportsDAO = new exp_ExpReportsDAO();
        }

        public List<exp_ExportReports> LoadCI()
        {
            try
            {
                return ExpExpReportsDAO.LoadCI();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Pi html report
        public List<xRpt_exp_PI_Master> GetPiMasterForReport(Int64 invoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetPiMasterForReport(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<xRpt_exp_CI_Master> GetCiMasterForReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetCiMasterForReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<xRpt_exp_PI_Detail> GetPiDetailForReport(Int64 invoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetPiDetailForReport(invoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<xRpt_exp_CI_Info_Detail> GetCIInfoDetailReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetCIInfoDetailReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_BankDocument> GetBankDocForReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetBankDocForReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_CommercialInvoice> GetBillOfExchangeForReport(Int64 commercialInvoiceId,string DocType)
        {
            try
            {
                return ExpExpReportsDAO.GetBillOfExchangeForReport(commercialInvoiceId, DocType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<xRpt_exp_ConsumptionCertificate> GetConsumptionCertificateReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetConsumptionCertificateReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateDescription> GetConsumptionCertificateDescriptionReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetConsumptionCertificateDescriptionReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<exp_ConsumptionCertificateRawMaterials> GetConsumptionCertificateRawMaterialsReport(Int64 commercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetConsumptionCertificateRawMaterialsReport(commercialInvoiceId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<exp_ExportReports> GetForCertificateOfOrigin(Int64 CommercialInvoiceId, string CertificateType)
        {
            try
            {
                return ExpExpReportsDAO.GetCertificateOfOrigin(CommercialInvoiceId, CertificateType);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<exp_ExportReports> GetDeliveryChalanGetReport(Int64 CommercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetDeliveryChalanGetReport(CommercialInvoiceId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<exp_ExportReports> GetDeliveryChalanGetReportDetails(Int64 CommercialInvoiceId)
        {
            try
            {
                return ExpExpReportsDAO.GetDeliveryChalanGetReportDetails(CommercialInvoiceId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
